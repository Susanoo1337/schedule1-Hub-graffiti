using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x02000165 RID: 357
	public class Manor : Property
	{
		// Token: 0x06002313 RID: 8979 RVA: 0x000EEC90 File Offset: 0x000ECE90
		// Note: this type is marked as 'beforefieldinit'.
		static Manor()
		{
			Il2CppClassPointerStore<Manor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "Manor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Manor>.NativeClassPtr);
			Manor.NativeFieldInfoPtr_REBUILD_AFTER_DAYS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manor>.NativeClassPtr, "REBUILD_AFTER_DAYS");
			Manor.NativeFieldInfoPtr_REBUILD_DURATION_DAYS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manor>.NativeClassPtr, "REBUILD_DURATION_DAYS");
			Manor.NativeFieldInfoPtr__ManorState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manor>.NativeClassPtr, "<ManorState>k__BackingField");
			Manor.NativeFieldInfoPtr__DaysSinceStateChange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manor>.NativeClassPtr, "<DaysSinceStateChange>k__BackingField");
			Manor.NativeFieldInfoPtr__TunnelDug_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manor>.NativeClassPtr, "<TunnelDug>k__BackingField");
			Manor.NativeFieldInfoPtr_OriginalContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manor>.NativeClassPtr, "OriginalContainer");
			Manor.NativeFieldInfoPtr_DestroyedContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manor>.NativeClassPtr, "DestroyedContainer");
			Manor.NativeFieldInfoPtr_RebuiltContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manor>.NativeClassPtr, "RebuiltContainer");
			Manor.NativeFieldInfoPtr_DestructionFXContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manor>.NativeClassPtr, "DestructionFXContainer");
			Manor.NativeFieldInfoPtr_TunnelBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manor>.NativeClassPtr, "TunnelBlocker");
			Manor.NativeFieldInfoPtr_TunnelCollapse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manor>.NativeClassPtr, "TunnelCollapse");
			Manor.NativeFieldInfoPtr_ConstructionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manor>.NativeClassPtr, "ConstructionContainer");
			Manor.NativeFieldInfoPtr_ExplosionSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manor>.NativeClassPtr, "ExplosionSounds");
			Manor.NativeFieldInfoPtr_DisableOnRebuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manor>.NativeClassPtr, "DisableOnRebuild");
			Manor.NativeFieldInfoPtr_onRebuildComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manor>.NativeClassPtr, "onRebuildComplete");
			Manor.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manor>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.ManorAssembly-CSharp.dll_Excuted");
			Manor.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manor>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.ManorAssembly-CSharp.dll_Excuted");
			Manor.NativeMethodInfoPtr_get_ManorState_Public_get_EManorState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667820);
			Manor.NativeMethodInfoPtr_set_ManorState_Private_set_Void_EManorState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667821);
			Manor.NativeMethodInfoPtr_get_DaysSinceStateChange_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667822);
			Manor.NativeMethodInfoPtr_set_DaysSinceStateChange_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667823);
			Manor.NativeMethodInfoPtr_get_TunnelDug_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667824);
			Manor.NativeMethodInfoPtr_set_TunnelDug_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667825);
			Manor.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667826);
			Manor.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667827);
			Manor.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667828);
			Manor.NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667829);
			Manor.NativeMethodInfoPtr_SetManorState_Private_Void_NetworkConnection_EManorState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667830);
			Manor.NativeMethodInfoPtr_Explode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667831);
			Manor.NativeMethodInfoPtr_Rebuild_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667832);
			Manor.NativeMethodInfoPtr_SetDestroyedIfOriginal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667833);
			Manor.NativeMethodInfoPtr_DigTunnel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667834);
			Manor.NativeMethodInfoPtr_SetTunnelDug_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667835);
			Manor.NativeMethodInfoPtr_CanBePurchased_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667836);
			Manor.NativeMethodInfoPtr_OnSleepEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667837);
			Manor.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667838);
			Manor.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667839);
			Manor.NativeMethodInfoPtr_Load_Public_Virtual_Void_PropertyData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667840);
			Manor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667841);
			Manor.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667842);
			Manor.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667843);
			Manor.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667844);
			Manor.NativeMethodInfoPtr_RpcWriter___Observers_SetManorState_365422978_Private_Void_NetworkConnection_EManorState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667845);
			Manor.NativeMethodInfoPtr_RpcLogic___SetManorState_365422978_Private_Void_NetworkConnection_EManorState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667846);
			Manor.NativeMethodInfoPtr_RpcReader___Observers_SetManorState_365422978_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667847);
			Manor.NativeMethodInfoPtr_RpcWriter___Target_SetManorState_365422978_Private_Void_NetworkConnection_EManorState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667848);
			Manor.NativeMethodInfoPtr_RpcReader___Target_SetManorState_365422978_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667849);
			Manor.NativeMethodInfoPtr_RpcWriter___Observers_SetTunnelDug_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667850);
			Manor.NativeMethodInfoPtr_RpcLogic___SetTunnelDug_214505783_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667851);
			Manor.NativeMethodInfoPtr_RpcReader___Observers_SetTunnelDug_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667852);
			Manor.NativeMethodInfoPtr_RpcWriter___Target_SetTunnelDug_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667853);
			Manor.NativeMethodInfoPtr_RpcReader___Target_SetTunnelDug_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667854);
			Manor.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manor>.NativeClassPtr, 100667855);
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06002314 RID: 8980 RVA: 0x000EF0E4 File Offset: 0x000ED2E4
		// (set) Token: 0x06002315 RID: 8981 RVA: 0x000EF120 File Offset: 0x000ED320
		public unsafe Manor.EManorState ManorState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr_get_ManorState_Public_get_EManorState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr_set_ManorState_Private_set_Void_EManorState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06002316 RID: 8982 RVA: 0x000EF160 File Offset: 0x000ED360
		// (set) Token: 0x06002317 RID: 8983 RVA: 0x000EF19C File Offset: 0x000ED39C
		public unsafe int DaysSinceStateChange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr_get_DaysSinceStateChange_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr_set_DaysSinceStateChange_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06002318 RID: 8984 RVA: 0x000EF1DC File Offset: 0x000ED3DC
		// (set) Token: 0x06002319 RID: 8985 RVA: 0x000EF218 File Offset: 0x000ED418
		public unsafe bool TunnelDug
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr_get_TunnelDug_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr_set_TunnelDug_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x000EF258 File Offset: 0x000ED458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112434, XrefRangeEnd = 112441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manor.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x000EF294 File Offset: 0x000ED494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112441, XrefRangeEnd = 112445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manor.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x000EF2E4 File Offset: 0x000ED4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112445, XrefRangeEnd = 112464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manor.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x000EF320 File Offset: 0x000ED520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112464, XrefRangeEnd = 112467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RecieveOwned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manor.NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x000EF35C File Offset: 0x000ED55C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 112508, RefRangeEnd = 112517, XrefRangeStart = 112467, XrefRangeEnd = 112508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetManorState(NetworkConnection conn, Manor.EManorState state, bool resetStateChangeTimer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resetStateChangeTimer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr_SetManorState_Private_Void_NetworkConnection_EManorState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x000EF3BC File Offset: 0x000ED5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112517, XrefRangeEnd = 112538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Explode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr_Explode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x000EF3F0 File Offset: 0x000ED5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112538, XrefRangeEnd = 112539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rebuild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr_Rebuild_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x000EF424 File Offset: 0x000ED624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112539, XrefRangeEnd = 112540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestroyedIfOriginal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr_SetDestroyedIfOriginal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x000EF458 File Offset: 0x000ED658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112540, XrefRangeEnd = 112541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DigTunnel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr_DigTunnel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x000EF48C File Offset: 0x000ED68C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 112551, RefRangeEnd = 112555, XrefRangeStart = 112541, XrefRangeEnd = 112551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTunnelDug(NetworkConnection conn, bool dug)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dug;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr_SetTunnelDug_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x000EF4DC File Offset: 0x000ED6DC
		[CallerCount(0)]
		public unsafe override bool CanBePurchased()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manor.NativeMethodInfoPtr_CanBePurchased_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x000EF524 File Offset: 0x000ED724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112555, XrefRangeEnd = 112561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSleepEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr_OnSleepEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x000EF558 File Offset: 0x000ED758
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manor.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x000EF5A0 File Offset: 0x000ED7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112561, XrefRangeEnd = 112600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manor.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x000EF5E4 File Offset: 0x000ED7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112600, XrefRangeEnd = 112612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(PropertyData propertyData, string propertyDataString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyDataString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manor.NativeMethodInfoPtr_Load_Public_Virtual_Void_PropertyData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x000EF644 File Offset: 0x000ED844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112612, XrefRangeEnd = 112616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Manor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Manor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x000EF680 File Offset: 0x000ED880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112616, XrefRangeEnd = 112642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manor.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x000EF6BC File Offset: 0x000ED8BC
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manor.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x000EF6F8 File Offset: 0x000ED8F8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manor.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x000EF734 File Offset: 0x000ED934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112642, XrefRangeEnd = 112653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetManorState_365422978(NetworkConnection conn, Manor.EManorState state, bool resetStateChangeTimer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resetStateChangeTimer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr_RpcWriter___Observers_SetManorState_365422978_Private_Void_NetworkConnection_EManorState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x000EF794 File Offset: 0x000ED994
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 112672, RefRangeEnd = 112675, XrefRangeStart = 112653, XrefRangeEnd = 112672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetManorState_365422978(NetworkConnection conn, Manor.EManorState state, bool resetStateChangeTimer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resetStateChangeTimer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr_RpcLogic___SetManorState_365422978_Private_Void_NetworkConnection_EManorState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x000EF7F4 File Offset: 0x000ED9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112675, XrefRangeEnd = 112679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetManorState_365422978(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr_RpcReader___Observers_SetManorState_365422978_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x000EF844 File Offset: 0x000EDA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112679, XrefRangeEnd = 112690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetManorState_365422978(NetworkConnection conn, Manor.EManorState state, bool resetStateChangeTimer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resetStateChangeTimer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr_RpcWriter___Target_SetManorState_365422978_Private_Void_NetworkConnection_EManorState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x000EF8A4 File Offset: 0x000EDAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112690, XrefRangeEnd = 112694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetManorState_365422978(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr_RpcReader___Target_SetManorState_365422978_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x000EF8F4 File Offset: 0x000EDAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112694, XrefRangeEnd = 112704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetTunnelDug_214505783(NetworkConnection conn, bool dug)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dug;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr_RpcWriter___Observers_SetTunnelDug_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x000EF944 File Offset: 0x000EDB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112704, XrefRangeEnd = 112706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetTunnelDug_214505783(NetworkConnection conn, bool dug)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dug;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr_RpcLogic___SetTunnelDug_214505783_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x000EF994 File Offset: 0x000EDB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112706, XrefRangeEnd = 112709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetTunnelDug_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr_RpcReader___Observers_SetTunnelDug_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002335 RID: 9013 RVA: 0x000EF9E4 File Offset: 0x000EDBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112709, XrefRangeEnd = 112719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetTunnelDug_214505783(NetworkConnection conn, bool dug)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dug;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr_RpcWriter___Target_SetTunnelDug_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x000EFA34 File Offset: 0x000EDC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112719, XrefRangeEnd = 112722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetTunnelDug_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manor.NativeMethodInfoPtr_RpcReader___Target_SetTunnelDug_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x000EFA84 File Offset: 0x000EDC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112722, XrefRangeEnd = 112729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manor.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x00012A5E File Offset: 0x00010C5E
		public Manor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06002339 RID: 9017 RVA: 0x000EFAC0 File Offset: 0x000EDCC0
		// (set) Token: 0x0600233A RID: 9018 RVA: 0x00012A67 File Offset: 0x00010C67
		public unsafe static int REBUILD_AFTER_DAYS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Manor.NativeFieldInfoPtr_REBUILD_AFTER_DAYS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Manor.NativeFieldInfoPtr_REBUILD_AFTER_DAYS, (void*)(&value));
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x0600233B RID: 9019 RVA: 0x000EFADC File Offset: 0x000EDCDC
		// (set) Token: 0x0600233C RID: 9020 RVA: 0x00012A75 File Offset: 0x00010C75
		public unsafe static int REBUILD_DURATION_DAYS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Manor.NativeFieldInfoPtr_REBUILD_DURATION_DAYS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Manor.NativeFieldInfoPtr_REBUILD_DURATION_DAYS, (void*)(&value));
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x0600233D RID: 9021 RVA: 0x000EFAF8 File Offset: 0x000EDCF8
		// (set) Token: 0x0600233E RID: 9022 RVA: 0x00012A83 File Offset: 0x00010C83
		public unsafe Manor.EManorState _ManorState_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr__ManorState_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr__ManorState_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x0600233F RID: 9023 RVA: 0x000EFB20 File Offset: 0x000EDD20
		// (set) Token: 0x06002340 RID: 9024 RVA: 0x00012A9E File Offset: 0x00010C9E
		public unsafe int _DaysSinceStateChange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr__DaysSinceStateChange_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr__DaysSinceStateChange_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06002341 RID: 9025 RVA: 0x000EFB48 File Offset: 0x000EDD48
		// (set) Token: 0x06002342 RID: 9026 RVA: 0x00012AB9 File Offset: 0x00010CB9
		public unsafe bool _TunnelDug_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr__TunnelDug_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr__TunnelDug_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06002343 RID: 9027 RVA: 0x000EFB70 File Offset: 0x000EDD70
		// (set) Token: 0x06002344 RID: 9028 RVA: 0x00012AD4 File Offset: 0x00010CD4
		public unsafe GameObject OriginalContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_OriginalContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_OriginalContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06002345 RID: 9029 RVA: 0x000EFBA0 File Offset: 0x000EDDA0
		// (set) Token: 0x06002346 RID: 9030 RVA: 0x00012AF3 File Offset: 0x00010CF3
		public unsafe GameObject DestroyedContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_DestroyedContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_DestroyedContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x000EFBD0 File Offset: 0x000EDDD0
		// (set) Token: 0x06002348 RID: 9032 RVA: 0x00012B12 File Offset: 0x00010D12
		public unsafe GameObject RebuiltContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_RebuiltContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_RebuiltContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x000EFC00 File Offset: 0x000EDE00
		// (set) Token: 0x0600234A RID: 9034 RVA: 0x00012B31 File Offset: 0x00010D31
		public unsafe GameObject DestructionFXContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_DestructionFXContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_DestructionFXContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x0600234B RID: 9035 RVA: 0x000EFC30 File Offset: 0x000EDE30
		// (set) Token: 0x0600234C RID: 9036 RVA: 0x00012B50 File Offset: 0x00010D50
		public unsafe GameObject TunnelBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_TunnelBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_TunnelBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x0600234D RID: 9037 RVA: 0x000EFC60 File Offset: 0x000EDE60
		// (set) Token: 0x0600234E RID: 9038 RVA: 0x00012B6F File Offset: 0x00010D6F
		public unsafe GameObject TunnelCollapse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_TunnelCollapse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_TunnelCollapse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x0600234F RID: 9039 RVA: 0x000EFC90 File Offset: 0x000EDE90
		// (set) Token: 0x06002350 RID: 9040 RVA: 0x00012B8E File Offset: 0x00010D8E
		public unsafe GameObject ConstructionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_ConstructionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_ConstructionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06002351 RID: 9041 RVA: 0x000EFCC0 File Offset: 0x000EDEC0
		// (set) Token: 0x06002352 RID: 9042 RVA: 0x00012BAD File Offset: 0x00010DAD
		public unsafe Il2CppReferenceArray<AudioSourceController> ExplosionSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_ExplosionSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_ExplosionSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06002353 RID: 9043 RVA: 0x000EFCF0 File Offset: 0x000EDEF0
		// (set) Token: 0x06002354 RID: 9044 RVA: 0x00012BCC File Offset: 0x00010DCC
		public unsafe Il2CppReferenceArray<GameObject> DisableOnRebuild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_DisableOnRebuild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_DisableOnRebuild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06002355 RID: 9045 RVA: 0x000EFD20 File Offset: 0x000EDF20
		// (set) Token: 0x06002356 RID: 9046 RVA: 0x00012BEB File Offset: 0x00010DEB
		public unsafe Action onRebuildComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_onRebuildComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_onRebuildComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06002357 RID: 9047 RVA: 0x000EFD50 File Offset: 0x000EDF50
		// (set) Token: 0x06002358 RID: 9048 RVA: 0x00012C0A File Offset: 0x00010E0A
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x06002359 RID: 9049 RVA: 0x000EFD78 File Offset: 0x000EDF78
		// (set) Token: 0x0600235A RID: 9050 RVA: 0x00012C25 File Offset: 0x00010E25
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manor.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04001832 RID: 6194
		private static readonly IntPtr NativeFieldInfoPtr_REBUILD_AFTER_DAYS;

		// Token: 0x04001833 RID: 6195
		private static readonly IntPtr NativeFieldInfoPtr_REBUILD_DURATION_DAYS;

		// Token: 0x04001834 RID: 6196
		private static readonly IntPtr NativeFieldInfoPtr__ManorState_k__BackingField;

		// Token: 0x04001835 RID: 6197
		private static readonly IntPtr NativeFieldInfoPtr__DaysSinceStateChange_k__BackingField;

		// Token: 0x04001836 RID: 6198
		private static readonly IntPtr NativeFieldInfoPtr__TunnelDug_k__BackingField;

		// Token: 0x04001837 RID: 6199
		private static readonly IntPtr NativeFieldInfoPtr_OriginalContainer;

		// Token: 0x04001838 RID: 6200
		private static readonly IntPtr NativeFieldInfoPtr_DestroyedContainer;

		// Token: 0x04001839 RID: 6201
		private static readonly IntPtr NativeFieldInfoPtr_RebuiltContainer;

		// Token: 0x0400183A RID: 6202
		private static readonly IntPtr NativeFieldInfoPtr_DestructionFXContainer;

		// Token: 0x0400183B RID: 6203
		private static readonly IntPtr NativeFieldInfoPtr_TunnelBlocker;

		// Token: 0x0400183C RID: 6204
		private static readonly IntPtr NativeFieldInfoPtr_TunnelCollapse;

		// Token: 0x0400183D RID: 6205
		private static readonly IntPtr NativeFieldInfoPtr_ConstructionContainer;

		// Token: 0x0400183E RID: 6206
		private static readonly IntPtr NativeFieldInfoPtr_ExplosionSounds;

		// Token: 0x0400183F RID: 6207
		private static readonly IntPtr NativeFieldInfoPtr_DisableOnRebuild;

		// Token: 0x04001840 RID: 6208
		private static readonly IntPtr NativeFieldInfoPtr_onRebuildComplete;

		// Token: 0x04001841 RID: 6209
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04001842 RID: 6210
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04001843 RID: 6211
		private static readonly IntPtr NativeMethodInfoPtr_get_ManorState_Public_get_EManorState_0;

		// Token: 0x04001844 RID: 6212
		private static readonly IntPtr NativeMethodInfoPtr_set_ManorState_Private_set_Void_EManorState_0;

		// Token: 0x04001845 RID: 6213
		private static readonly IntPtr NativeMethodInfoPtr_get_DaysSinceStateChange_Public_get_Int32_0;

		// Token: 0x04001846 RID: 6214
		private static readonly IntPtr NativeMethodInfoPtr_set_DaysSinceStateChange_Private_set_Void_Int32_0;

		// Token: 0x04001847 RID: 6215
		private static readonly IntPtr NativeMethodInfoPtr_get_TunnelDug_Public_get_Boolean_0;

		// Token: 0x04001848 RID: 6216
		private static readonly IntPtr NativeMethodInfoPtr_set_TunnelDug_Public_set_Void_Boolean_0;

		// Token: 0x04001849 RID: 6217
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400184A RID: 6218
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400184B RID: 6219
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x0400184C RID: 6220
		private static readonly IntPtr NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_Void_1;

		// Token: 0x0400184D RID: 6221
		private static readonly IntPtr NativeMethodInfoPtr_SetManorState_Private_Void_NetworkConnection_EManorState_Boolean_0;

		// Token: 0x0400184E RID: 6222
		private static readonly IntPtr NativeMethodInfoPtr_Explode_Public_Void_0;

		// Token: 0x0400184F RID: 6223
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Void_0;

		// Token: 0x04001850 RID: 6224
		private static readonly IntPtr NativeMethodInfoPtr_SetDestroyedIfOriginal_Public_Void_0;

		// Token: 0x04001851 RID: 6225
		private static readonly IntPtr NativeMethodInfoPtr_DigTunnel_Public_Void_0;

		// Token: 0x04001852 RID: 6226
		private static readonly IntPtr NativeMethodInfoPtr_SetTunnelDug_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x04001853 RID: 6227
		private static readonly IntPtr NativeMethodInfoPtr_CanBePurchased_Public_Virtual_Boolean_0;

		// Token: 0x04001854 RID: 6228
		private static readonly IntPtr NativeMethodInfoPtr_OnSleepEnd_Private_Void_0;

		// Token: 0x04001855 RID: 6229
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x04001856 RID: 6230
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04001857 RID: 6231
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_PropertyData_String_0;

		// Token: 0x04001858 RID: 6232
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001859 RID: 6233
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400185A RID: 6234
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400185B RID: 6235
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400185C RID: 6236
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetManorState_365422978_Private_Void_NetworkConnection_EManorState_Boolean_0;

		// Token: 0x0400185D RID: 6237
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetManorState_365422978_Private_Void_NetworkConnection_EManorState_Boolean_0;

		// Token: 0x0400185E RID: 6238
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetManorState_365422978_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400185F RID: 6239
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetManorState_365422978_Private_Void_NetworkConnection_EManorState_Boolean_0;

		// Token: 0x04001860 RID: 6240
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetManorState_365422978_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001861 RID: 6241
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetTunnelDug_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04001862 RID: 6242
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetTunnelDug_214505783_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x04001863 RID: 6243
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetTunnelDug_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001864 RID: 6244
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetTunnelDug_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04001865 RID: 6245
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetTunnelDug_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001866 RID: 6246
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000974 RID: 2420
		[OriginalName("Assembly-CSharp.dll", "", "EManorState")]
		public enum EManorState
		{
			// Token: 0x0400948A RID: 38026
			Original,
			// Token: 0x0400948B RID: 38027
			Destroyed,
			// Token: 0x0400948C RID: 38028
			Rebuilt
		}
	}
}
