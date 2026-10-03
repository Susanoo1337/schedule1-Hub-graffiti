using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.UI.Input;
using UnityEngine;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x0200016E RID: 366
	public class Tap : NetworkBehaviour
	{
		// Token: 0x060024B4 RID: 9396 RVA: 0x000F4B5C File Offset: 0x000F2D5C
		// Note: this type is marked as 'beforefieldinit'.
		static Tap()
		{
			Il2CppClassPointerStore<Tap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "Tap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tap>.NativeClassPtr);
			Tap.NativeFieldInfoPtr_FlowRateMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "FlowRateMultiplier");
			Tap.NativeFieldInfoPtr_HandleMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "HandleMoveSpeed");
			Tap.NativeFieldInfoPtr__CameraPos_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "<CameraPos>k__BackingField");
			Tap.NativeFieldInfoPtr__FillableModelContainer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "<FillableModelContainer>k__BackingField");
			Tap.NativeFieldInfoPtr__interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "_interactable");
			Tap.NativeFieldInfoPtr__handleTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "_handleTransform");
			Tap.NativeFieldInfoPtr__handleClickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "_handleClickable");
			Tap.NativeFieldInfoPtr__waterParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "_waterParticles");
			Tap.NativeFieldInfoPtr__squeakSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "_squeakSound");
			Tap.NativeFieldInfoPtr__waterRunningSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "_waterRunningSound");
			Tap.NativeFieldInfoPtr__handlePromptData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "_handlePromptData");
			Tap.NativeFieldInfoPtr__handlePromptAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "_handlePromptAnchor");
			Tap.NativeFieldInfoPtr__IsHeldOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "<IsHeldOpen>k__BackingField");
			Tap.NativeFieldInfoPtr__NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "<NPCUserObject>k__BackingField");
			Tap.NativeFieldInfoPtr__PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "<PlayerUserObject>k__BackingField");
			Tap.NativeFieldInfoPtr__normalizedTapFlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "_normalizedTapFlow");
			Tap.NativeFieldInfoPtr__defaultParticleStartSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "_defaultParticleStartSize");
			Tap.NativeFieldInfoPtr__maxTapOpenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "_maxTapOpenValue");
			Tap.NativeFieldInfoPtr_syncVar____IsHeldOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "syncVar___<IsHeldOpen>k__BackingField");
			Tap.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "syncVar___<NPCUserObject>k__BackingField");
			Tap.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "syncVar___<PlayerUserObject>k__BackingField");
			Tap.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.TapAssembly-CSharp.dll_Excuted");
			Tap.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.TapAssembly-CSharp.dll_Excuted");
			Tap.NativeMethodInfoPtr_get_CameraPos_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668066);
			Tap.NativeMethodInfoPtr_set_CameraPos_Private_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668067);
			Tap.NativeMethodInfoPtr_get_FillableModelContainer_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668068);
			Tap.NativeMethodInfoPtr_set_FillableModelContainer_Private_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668069);
			Tap.NativeMethodInfoPtr_get_IsHeldOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668070);
			Tap.NativeMethodInfoPtr_set_IsHeldOpen_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668071);
			Tap.NativeMethodInfoPtr_get_ActualFlowRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668072);
			Tap.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668073);
			Tap.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668074);
			Tap.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668075);
			Tap.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668076);
			Tap.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668077);
			Tap.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668078);
			Tap.NativeMethodInfoPtr_UpdateTapVisuals_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668079);
			Tap.NativeMethodInfoPtr_UpdateWaterSound_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668080);
			Tap.NativeMethodInfoPtr_Hovered_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668081);
			Tap.NativeMethodInfoPtr_Interacted_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668082);
			Tap.NativeMethodInfoPtr_SetHandleEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668083);
			Tap.NativeMethodInfoPtr_SetHeldOpen_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668084);
			Tap.NativeMethodInfoPtr_OnHandleClickStart_Private_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668085);
			Tap.NativeMethodInfoPtr_OnHandleClickEnd_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668086);
			Tap.NativeMethodInfoPtr_CanInteract_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668087);
			Tap.NativeMethodInfoPtr_SetMaxTapOpen_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668088);
			Tap.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668089);
			Tap.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668090);
			Tap.NativeMethodInfoPtr_GetTapFlow_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668091);
			Tap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668092);
			Tap.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668093);
			Tap.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668094);
			Tap.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668095);
			Tap.NativeMethodInfoPtr_RpcWriter___Server_SetHeldOpen_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668096);
			Tap.NativeMethodInfoPtr_RpcLogic___SetHeldOpen_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668097);
			Tap.NativeMethodInfoPtr_RpcReader___Server_SetHeldOpen_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668098);
			Tap.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668099);
			Tap.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668100);
			Tap.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668101);
			Tap.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668102);
			Tap.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668103);
			Tap.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668104);
			Tap.NativeMethodInfoPtr_sync___get_value__IsHeldOpen_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668105);
			Tap.NativeMethodInfoPtr_sync___set_value__IsHeldOpen_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668106);
			Tap.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Property_Tap_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668107);
			Tap.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668108);
			Tap.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668109);
			Tap.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668110);
			Tap.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668111);
			Tap.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100668112);
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x060024B5 RID: 9397 RVA: 0x000F5104 File Offset: 0x000F3304
		// (set) Token: 0x060024B6 RID: 9398 RVA: 0x000F5144 File Offset: 0x000F3344
		public unsafe Transform CameraPos
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_get_CameraPos_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_set_CameraPos_Private_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x060024B7 RID: 9399 RVA: 0x000F5188 File Offset: 0x000F3388
		// (set) Token: 0x060024B8 RID: 9400 RVA: 0x000F51C8 File Offset: 0x000F33C8
		public unsafe Transform FillableModelContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_get_FillableModelContainer_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_set_FillableModelContainer_Private_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x060024B9 RID: 9401 RVA: 0x000F520C File Offset: 0x000F340C
		// (set) Token: 0x060024BA RID: 9402 RVA: 0x000F5248 File Offset: 0x000F3448
		public unsafe bool IsHeldOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_get_IsHeldOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 114806, RefRangeEnd = 114811, XrefRangeStart = 114799, XrefRangeEnd = 114806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_set_IsHeldOpen_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x060024BB RID: 9403 RVA: 0x000F5288 File Offset: 0x000F3488
		public unsafe float ActualFlowRate
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 114811, RefRangeEnd = 114814, XrefRangeStart = 114811, XrefRangeEnd = 114811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_get_ActualFlowRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x060024BC RID: 9404 RVA: 0x000F52C4 File Offset: 0x000F34C4
		// (set) Token: 0x060024BD RID: 9405 RVA: 0x000F5304 File Offset: 0x000F3504
		public unsafe virtual NetworkObject NPCUserObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114814, XrefRangeEnd = 114822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x060024BE RID: 9406 RVA: 0x000F5348 File Offset: 0x000F3548
		// (set) Token: 0x060024BF RID: 9407 RVA: 0x000F5388 File Offset: 0x000F3588
		public unsafe virtual NetworkObject PlayerUserObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114822, XrefRangeEnd = 114830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x000F53CC File Offset: 0x000F35CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114830, XrefRangeEnd = 114831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tap.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x000F5408 File Offset: 0x000F3608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114831, XrefRangeEnd = 114847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tap.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x000F5444 File Offset: 0x000F3644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114847, XrefRangeEnd = 114851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTapVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_UpdateTapVisuals_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x000F5478 File Offset: 0x000F3678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114851, XrefRangeEnd = 114853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWaterSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_UpdateWaterSound_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x000F54AC File Offset: 0x000F36AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114853, XrefRangeEnd = 114856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_Hovered_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x000F54E0 File Offset: 0x000F36E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114856, XrefRangeEnd = 114870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_Interacted_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x000F5514 File Offset: 0x000F3714
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114870, RefRangeEnd = 114872, XrefRangeStart = 114870, XrefRangeEnd = 114870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHandleEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_SetHandleEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x000F5554 File Offset: 0x000F3754
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114894, RefRangeEnd = 114896, XrefRangeStart = 114872, XrefRangeEnd = 114894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHeldOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_SetHeldOpen_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x000F5594 File Offset: 0x000F3794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114896, XrefRangeEnd = 114912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnHandleClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_OnHandleClickStart_Private_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x000F55D4 File Offset: 0x000F37D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114912, XrefRangeEnd = 114932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnHandleClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_OnHandleClickEnd_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x000F5608 File Offset: 0x000F3808
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114952, RefRangeEnd = 114954, XrefRangeStart = 114932, XrefRangeEnd = 114952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanInteract(out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_CanInteract_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x000F5660 File Offset: 0x000F3860
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114954, RefRangeEnd = 114955, XrefRangeStart = 114954, XrefRangeEnd = 114954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaxTapOpen(float max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_SetMaxTapOpen_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x000F56A0 File Offset: 0x000F38A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114977, RefRangeEnd = 114979, XrefRangeStart = 114955, XrefRangeEnd = 114977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetPlayerUser(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x000F56E4 File Offset: 0x000F38E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114979, XrefRangeEnd = 115001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetNPCUser(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x000F5728 File Offset: 0x000F3928
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115007, RefRangeEnd = 115008, XrefRangeStart = 115001, XrefRangeEnd = 115007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTapFlow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_GetTapFlow_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x000F5764 File Offset: 0x000F3964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115008, XrefRangeEnd = 115009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tap() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x000F57A0 File Offset: 0x000F39A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115009, XrefRangeEnd = 115060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tap.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x000F57DC File Offset: 0x000F39DC
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tap.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x000F5818 File Offset: 0x000F3A18
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tap.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x000F5854 File Offset: 0x000F3A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115060, XrefRangeEnd = 115070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetHeldOpen_1140765316(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcWriter___Server_SetHeldOpen_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x000F5894 File Offset: 0x000F3A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115070, XrefRangeEnd = 115072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetHeldOpen_1140765316(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcLogic___SetHeldOpen_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x000F58D4 File Offset: 0x000F3AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115072, XrefRangeEnd = 115075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetHeldOpen_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcReader___Server_SetHeldOpen_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x000F5938 File Offset: 0x000F3B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115075, XrefRangeEnd = 115085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x000F597C File Offset: 0x000F3B7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 115113, RefRangeEnd = 115115, XrefRangeStart = 115085, XrefRangeEnd = 115113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x000F59C0 File Offset: 0x000F3BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115115, XrefRangeEnd = 115119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x000F5A24 File Offset: 0x000F3C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115119, XrefRangeEnd = 115129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x000F5A68 File Offset: 0x000F3C68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 115141, RefRangeEnd = 115143, XrefRangeStart = 115129, XrefRangeEnd = 115141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x000F5AAC File Offset: 0x000F3CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115143, XrefRangeEnd = 115147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x060024DC RID: 9436 RVA: 0x000F5B10 File Offset: 0x000F3D10
		// (set) Token: 0x060024DD RID: 9437 RVA: 0x000F5B4C File Offset: 0x000F3D4C
		public unsafe bool SyncAccessor_<IsHeldOpen>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_sync___get_value__IsHeldOpen_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115147, XrefRangeEnd = 115155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_sync___set_value__IsHeldOpen_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x000F5B98 File Offset: 0x000F3D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115155, XrefRangeEnd = 115157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Property_Tap(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tap.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Property_Tap_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x060024DF RID: 9439 RVA: 0x000F5C0C File Offset: 0x000F3E0C
		// (set) Token: 0x060024E0 RID: 9440 RVA: 0x000F5C4C File Offset: 0x000F3E4C
		public unsafe NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115157, XrefRangeEnd = 115166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x060024E1 RID: 9441 RVA: 0x000F5C9C File Offset: 0x000F3E9C
		// (set) Token: 0x060024E2 RID: 9442 RVA: 0x000F5CDC File Offset: 0x000F3EDC
		public unsafe NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115166, XrefRangeEnd = 115175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x000F5D2C File Offset: 0x000F3F2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115209, RefRangeEnd = 115210, XrefRangeStart = 115175, XrefRangeEnd = 115209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x0001359A File Offset: 0x0001179A
		public Tap(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x060024E5 RID: 9445 RVA: 0x000F5D60 File Offset: 0x000F3F60
		// (set) Token: 0x060024E6 RID: 9446 RVA: 0x000135A3 File Offset: 0x000117A3
		public unsafe static float FlowRateMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Tap.NativeFieldInfoPtr_FlowRateMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Tap.NativeFieldInfoPtr_FlowRateMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x060024E7 RID: 9447 RVA: 0x000F5D7C File Offset: 0x000F3F7C
		// (set) Token: 0x060024E8 RID: 9448 RVA: 0x000135B1 File Offset: 0x000117B1
		public unsafe static float HandleMoveSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Tap.NativeFieldInfoPtr_HandleMoveSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Tap.NativeFieldInfoPtr_HandleMoveSpeed, (void*)(&value));
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x060024E9 RID: 9449 RVA: 0x000F5D98 File Offset: 0x000F3F98
		// (set) Token: 0x060024EA RID: 9450 RVA: 0x000135BF File Offset: 0x000117BF
		public unsafe Transform _CameraPos_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__CameraPos_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__CameraPos_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x060024EB RID: 9451 RVA: 0x000F5DC8 File Offset: 0x000F3FC8
		// (set) Token: 0x060024EC RID: 9452 RVA: 0x000135DE File Offset: 0x000117DE
		public unsafe Transform _FillableModelContainer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__FillableModelContainer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__FillableModelContainer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x060024ED RID: 9453 RVA: 0x000F5DF8 File Offset: 0x000F3FF8
		// (set) Token: 0x060024EE RID: 9454 RVA: 0x000135FD File Offset: 0x000117FD
		public unsafe InteractableObject _interactable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__interactable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__interactable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x060024EF RID: 9455 RVA: 0x000F5E28 File Offset: 0x000F4028
		// (set) Token: 0x060024F0 RID: 9456 RVA: 0x0001361C File Offset: 0x0001181C
		public unsafe Transform _handleTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__handleTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__handleTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x060024F1 RID: 9457 RVA: 0x000F5E58 File Offset: 0x000F4058
		// (set) Token: 0x060024F2 RID: 9458 RVA: 0x0001363B File Offset: 0x0001183B
		public unsafe Clickable _handleClickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__handleClickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__handleClickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x060024F3 RID: 9459 RVA: 0x000F5E88 File Offset: 0x000F4088
		// (set) Token: 0x060024F4 RID: 9460 RVA: 0x0001365A File Offset: 0x0001185A
		public unsafe ParticleSystem _waterParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__waterParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__waterParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x060024F5 RID: 9461 RVA: 0x000F5EB8 File Offset: 0x000F40B8
		// (set) Token: 0x060024F6 RID: 9462 RVA: 0x00013679 File Offset: 0x00011879
		public unsafe AudioSourceController _squeakSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__squeakSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__squeakSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x060024F7 RID: 9463 RVA: 0x000F5EE8 File Offset: 0x000F40E8
		// (set) Token: 0x060024F8 RID: 9464 RVA: 0x00013698 File Offset: 0x00011898
		public unsafe AudioSourceController _waterRunningSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__waterRunningSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__waterRunningSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x060024F9 RID: 9465 RVA: 0x000F5F18 File Offset: 0x000F4118
		// (set) Token: 0x060024FA RID: 9466 RVA: 0x000136B7 File Offset: 0x000118B7
		public unsafe InputPromptsData _handlePromptData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__handlePromptData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__handlePromptData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x060024FB RID: 9467 RVA: 0x000F5F48 File Offset: 0x000F4148
		// (set) Token: 0x060024FC RID: 9468 RVA: 0x000136D6 File Offset: 0x000118D6
		public unsafe Transform _handlePromptAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__handlePromptAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__handlePromptAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x060024FD RID: 9469 RVA: 0x000F5F78 File Offset: 0x000F4178
		// (set) Token: 0x060024FE RID: 9470 RVA: 0x000136F5 File Offset: 0x000118F5
		public unsafe bool _IsHeldOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__IsHeldOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__IsHeldOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x060024FF RID: 9471 RVA: 0x000F5FA0 File Offset: 0x000F41A0
		// (set) Token: 0x06002500 RID: 9472 RVA: 0x00013710 File Offset: 0x00011910
		public unsafe NetworkObject _NPCUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__NPCUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06002501 RID: 9473 RVA: 0x000F5FD0 File Offset: 0x000F41D0
		// (set) Token: 0x06002502 RID: 9474 RVA: 0x0001372F File Offset: 0x0001192F
		public unsafe NetworkObject _PlayerUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__PlayerUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06002503 RID: 9475 RVA: 0x000F6000 File Offset: 0x000F4200
		// (set) Token: 0x06002504 RID: 9476 RVA: 0x0001374E File Offset: 0x0001194E
		public unsafe float _normalizedTapFlow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__normalizedTapFlow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__normalizedTapFlow)) = value;
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06002505 RID: 9477 RVA: 0x000F6028 File Offset: 0x000F4228
		// (set) Token: 0x06002506 RID: 9478 RVA: 0x00013769 File Offset: 0x00011969
		public unsafe Vector2 _defaultParticleStartSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__defaultParticleStartSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__defaultParticleStartSize)) = value;
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06002507 RID: 9479 RVA: 0x000F6050 File Offset: 0x000F4250
		// (set) Token: 0x06002508 RID: 9480 RVA: 0x00013784 File Offset: 0x00011984
		public unsafe float _maxTapOpenValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__maxTapOpenValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__maxTapOpenValue)) = value;
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06002509 RID: 9481 RVA: 0x000F6078 File Offset: 0x000F4278
		// (set) Token: 0x0600250A RID: 9482 RVA: 0x0001379F File Offset: 0x0001199F
		public unsafe SyncVar<bool> syncVar____IsHeldOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_syncVar____IsHeldOpen_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_syncVar____IsHeldOpen_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x0600250B RID: 9483 RVA: 0x000F60A8 File Offset: 0x000F42A8
		// (set) Token: 0x0600250C RID: 9484 RVA: 0x000137BE File Offset: 0x000119BE
		public unsafe SyncVar<NetworkObject> syncVar____NPCUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x0600250D RID: 9485 RVA: 0x000F60D8 File Offset: 0x000F42D8
		// (set) Token: 0x0600250E RID: 9486 RVA: 0x000137DD File Offset: 0x000119DD
		public unsafe SyncVar<NetworkObject> syncVar____PlayerUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x0600250F RID: 9487 RVA: 0x000F6108 File Offset: 0x000F4308
		// (set) Token: 0x06002510 RID: 9488 RVA: 0x000137FC File Offset: 0x000119FC
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06002511 RID: 9489 RVA: 0x000F6130 File Offset: 0x000F4330
		// (set) Token: 0x06002512 RID: 9490 RVA: 0x00013817 File Offset: 0x00011A17
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400195E RID: 6494
		private static readonly IntPtr NativeFieldInfoPtr_FlowRateMultiplier;

		// Token: 0x0400195F RID: 6495
		private static readonly IntPtr NativeFieldInfoPtr_HandleMoveSpeed;

		// Token: 0x04001960 RID: 6496
		private static readonly IntPtr NativeFieldInfoPtr__CameraPos_k__BackingField;

		// Token: 0x04001961 RID: 6497
		private static readonly IntPtr NativeFieldInfoPtr__FillableModelContainer_k__BackingField;

		// Token: 0x04001962 RID: 6498
		private static readonly IntPtr NativeFieldInfoPtr__interactable;

		// Token: 0x04001963 RID: 6499
		private static readonly IntPtr NativeFieldInfoPtr__handleTransform;

		// Token: 0x04001964 RID: 6500
		private static readonly IntPtr NativeFieldInfoPtr__handleClickable;

		// Token: 0x04001965 RID: 6501
		private static readonly IntPtr NativeFieldInfoPtr__waterParticles;

		// Token: 0x04001966 RID: 6502
		private static readonly IntPtr NativeFieldInfoPtr__squeakSound;

		// Token: 0x04001967 RID: 6503
		private static readonly IntPtr NativeFieldInfoPtr__waterRunningSound;

		// Token: 0x04001968 RID: 6504
		private static readonly IntPtr NativeFieldInfoPtr__handlePromptData;

		// Token: 0x04001969 RID: 6505
		private static readonly IntPtr NativeFieldInfoPtr__handlePromptAnchor;

		// Token: 0x0400196A RID: 6506
		private static readonly IntPtr NativeFieldInfoPtr__IsHeldOpen_k__BackingField;

		// Token: 0x0400196B RID: 6507
		private static readonly IntPtr NativeFieldInfoPtr__NPCUserObject_k__BackingField;

		// Token: 0x0400196C RID: 6508
		private static readonly IntPtr NativeFieldInfoPtr__PlayerUserObject_k__BackingField;

		// Token: 0x0400196D RID: 6509
		private static readonly IntPtr NativeFieldInfoPtr__normalizedTapFlow;

		// Token: 0x0400196E RID: 6510
		private static readonly IntPtr NativeFieldInfoPtr__defaultParticleStartSize;

		// Token: 0x0400196F RID: 6511
		private static readonly IntPtr NativeFieldInfoPtr__maxTapOpenValue;

		// Token: 0x04001970 RID: 6512
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____IsHeldOpen_k__BackingField;

		// Token: 0x04001971 RID: 6513
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField;

		// Token: 0x04001972 RID: 6514
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField;

		// Token: 0x04001973 RID: 6515
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04001974 RID: 6516
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04001975 RID: 6517
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraPos_Public_get_Transform_0;

		// Token: 0x04001976 RID: 6518
		private static readonly IntPtr NativeMethodInfoPtr_set_CameraPos_Private_set_Void_Transform_0;

		// Token: 0x04001977 RID: 6519
		private static readonly IntPtr NativeMethodInfoPtr_get_FillableModelContainer_Public_get_Transform_0;

		// Token: 0x04001978 RID: 6520
		private static readonly IntPtr NativeMethodInfoPtr_set_FillableModelContainer_Private_set_Void_Transform_0;

		// Token: 0x04001979 RID: 6521
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHeldOpen_Public_get_Boolean_0;

		// Token: 0x0400197A RID: 6522
		private static readonly IntPtr NativeMethodInfoPtr_set_IsHeldOpen_Public_set_Void_Boolean_0;

		// Token: 0x0400197B RID: 6523
		private static readonly IntPtr NativeMethodInfoPtr_get_ActualFlowRate_Public_get_Single_0;

		// Token: 0x0400197C RID: 6524
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x0400197D RID: 6525
		private static readonly IntPtr NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x0400197E RID: 6526
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x0400197F RID: 6527
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x04001980 RID: 6528
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04001981 RID: 6529
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04001982 RID: 6530
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTapVisuals_Private_Void_1;

		// Token: 0x04001983 RID: 6531
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWaterSound_Private_Void_1;

		// Token: 0x04001984 RID: 6532
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Private_Void_1;

		// Token: 0x04001985 RID: 6533
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_1;

		// Token: 0x04001986 RID: 6534
		private static readonly IntPtr NativeMethodInfoPtr_SetHandleEnabled_Public_Void_Boolean_0;

		// Token: 0x04001987 RID: 6535
		private static readonly IntPtr NativeMethodInfoPtr_SetHeldOpen_Private_Void_Boolean_0;

		// Token: 0x04001988 RID: 6536
		private static readonly IntPtr NativeMethodInfoPtr_OnHandleClickStart_Private_Void_RaycastHit_0;

		// Token: 0x04001989 RID: 6537
		private static readonly IntPtr NativeMethodInfoPtr_OnHandleClickEnd_Private_Void_1;

		// Token: 0x0400198A RID: 6538
		private static readonly IntPtr NativeMethodInfoPtr_CanInteract_Private_Boolean_byref_String_0;

		// Token: 0x0400198B RID: 6539
		private static readonly IntPtr NativeMethodInfoPtr_SetMaxTapOpen_Public_Void_Single_0;

		// Token: 0x0400198C RID: 6540
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x0400198D RID: 6541
		private static readonly IntPtr NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x0400198E RID: 6542
		private static readonly IntPtr NativeMethodInfoPtr_GetTapFlow_Private_Single_0;

		// Token: 0x0400198F RID: 6543
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001990 RID: 6544
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04001991 RID: 6545
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04001992 RID: 6546
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04001993 RID: 6547
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetHeldOpen_1140765316_Private_Void_Boolean_0;

		// Token: 0x04001994 RID: 6548
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetHeldOpen_1140765316_Private_Void_Boolean_0;

		// Token: 0x04001995 RID: 6549
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetHeldOpen_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04001996 RID: 6550
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04001997 RID: 6551
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04001998 RID: 6552
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04001999 RID: 6553
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400199A RID: 6554
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x0400199B RID: 6555
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400199C RID: 6556
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__IsHeldOpen_k__BackingField_Public_get_Boolean_0;

		// Token: 0x0400199D RID: 6557
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__IsHeldOpen_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x0400199E RID: 6558
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Property_Tap_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x0400199F RID: 6559
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x040019A0 RID: 6560
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x040019A1 RID: 6561
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x040019A2 RID: 6562
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x040019A3 RID: 6563
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;
	}
}
