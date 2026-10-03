using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.State;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x0200042F RID: 1071
	public class CasinoGameController : NetworkBehaviour
	{
		// Token: 0x06005EC6 RID: 24262 RVA: 0x001C2AEC File Offset: 0x001C0CEC
		// Note: this type is marked as 'beforefieldinit'.
		static CasinoGameController()
		{
			Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "CasinoGameController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr);
			CasinoGameController.NativeFieldInfoPtr_FOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "FOV");
			CasinoGameController.NativeFieldInfoPtr_CAMERA_LERP_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "CAMERA_LERP_TIME");
			CasinoGameController.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "<IsOpen>k__BackingField");
			CasinoGameController.NativeFieldInfoPtr__LocalPlayerBet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "<LocalPlayerBet>k__BackingField");
			CasinoGameController.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "Players");
			CasinoGameController.NativeFieldInfoPtr_Interaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "Interaction");
			CasinoGameController.NativeFieldInfoPtr_DefaultCameraTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "DefaultCameraTransforms");
			CasinoGameController.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "State");
			CasinoGameController.NativeFieldInfoPtr_onLocalPlayerBetChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "onLocalPlayerBetChange");
			CasinoGameController.NativeFieldInfoPtr_localDefaultCameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "localDefaultCameraTransform");
			CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Casino.CasinoGameControllerAssembly-CSharp.dll_Excuted");
			CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Casino.CasinoGameControllerAssembly-CSharp.dll_Excuted");
			CasinoGameController.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100675721);
			CasinoGameController.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100675722);
			CasinoGameController.NativeMethodInfoPtr_get_LocalPlayerBet_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100675723);
			CasinoGameController.NativeMethodInfoPtr_set_LocalPlayerBet_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100675724);
			CasinoGameController.NativeMethodInfoPtr_get_LocalPlayerData_Public_get_CasinoGamePlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100675725);
			CasinoGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100675726);
			CasinoGameController.NativeMethodInfoPtr_OnLocalPlayerRequestJoin_Protected_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100675727);
			CasinoGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100675728);
			CasinoGameController.NativeMethodInfoPtr_Open_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100675729);
			CasinoGameController.NativeMethodInfoPtr_Close_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100675730);
			CasinoGameController.NativeMethodInfoPtr_OnClose_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100675731);
			CasinoGameController.NativeMethodInfoPtr_SetLocalPlayerBet_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100675732);
			CasinoGameController.NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100675733);
			CasinoGameController.NativeMethodInfoPtr_IsWaitingForPlayers_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100675734);
			CasinoGameController.NativeMethodInfoPtr_GetBetLimits_Public_Abstract_Virtual_New_Void_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100675735);
			CasinoGameController.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100675736);
			CasinoGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100675737);
			CasinoGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100675738);
			CasinoGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100675739);
			CasinoGameController.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr, 100675740);
		}

		// Token: 0x17001D40 RID: 7488
		// (get) Token: 0x06005EC7 RID: 24263 RVA: 0x001C2D9C File Offset: 0x001C0F9C
		// (set) Token: 0x06005EC8 RID: 24264 RVA: 0x001C2DD8 File Offset: 0x001C0FD8
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameController.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameController.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x06005EC9 RID: 24265 RVA: 0x001C2E18 File Offset: 0x001C1018
		// (set) Token: 0x06005ECA RID: 24266 RVA: 0x001C2E54 File Offset: 0x001C1054
		public unsafe float LocalPlayerBet
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 75479, RefRangeEnd = 75481, XrefRangeStart = 75479, XrefRangeEnd = 75481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameController.NativeMethodInfoPtr_get_LocalPlayerBet_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameController.NativeMethodInfoPtr_set_LocalPlayerBet_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D42 RID: 7490
		// (get) Token: 0x06005ECB RID: 24267 RVA: 0x001C2E94 File Offset: 0x001C1094
		public unsafe CasinoGamePlayerData LocalPlayerData
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 202280, RefRangeEnd = 202290, XrefRangeStart = 202274, XrefRangeEnd = 202280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameController.NativeMethodInfoPtr_get_LocalPlayerData_Public_get_CasinoGamePlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerData>(intPtr3) : null;
			}
		}

		// Token: 0x06005ECC RID: 24268 RVA: 0x001C2ED4 File Offset: 0x001C10D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202291, RefRangeEnd = 202293, XrefRangeStart = 202290, XrefRangeEnd = 202291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ECD RID: 24269 RVA: 0x001C2F10 File Offset: 0x001C1110
		[CallerCount(0)]
		public unsafe virtual void OnLocalPlayerRequestJoin(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_OnLocalPlayerRequestJoin_Protected_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ECE RID: 24270 RVA: 0x001C2F60 File Offset: 0x001C1160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202296, RefRangeEnd = 202297, XrefRangeStart = 202293, XrefRangeEnd = 202296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ECF RID: 24271 RVA: 0x001C2FB0 File Offset: 0x001C11B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202346, RefRangeEnd = 202348, XrefRangeStart = 202297, XrefRangeEnd = 202346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_Open_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ED0 RID: 24272 RVA: 0x001C2FEC File Offset: 0x001C11EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202348, XrefRangeEnd = 202350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameController.NativeMethodInfoPtr_Close_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ED1 RID: 24273 RVA: 0x001C3020 File Offset: 0x001C1220
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202389, RefRangeEnd = 202391, XrefRangeStart = 202350, XrefRangeEnd = 202389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_OnClose_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ED2 RID: 24274 RVA: 0x001C305C File Offset: 0x001C125C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202391, RefRangeEnd = 202393, XrefRangeStart = 202391, XrefRangeEnd = 202391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocalPlayerBet(float bet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bet;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameController.NativeMethodInfoPtr_SetLocalPlayerBet_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ED3 RID: 24275 RVA: 0x001C309C File Offset: 0x001C129C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202412, RefRangeEnd = 202413, XrefRangeStart = 202393, XrefRangeEnd = 202412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ToggleLocalPlayerReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ED4 RID: 24276 RVA: 0x001C30D8 File Offset: 0x001C12D8
		[CallerCount(0)]
		public unsafe virtual bool IsWaitingForPlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_IsWaitingForPlayers_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005ED5 RID: 24277 RVA: 0x001C3120 File Offset: 0x001C1320
		[CallerCount(0)]
		public unsafe virtual void GetBetLimits(out float minimum, out float maximum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &minimum;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maximum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_GetBetLimits_Public_Abstract_Virtual_New_Void_byref_Single_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ED6 RID: 24278 RVA: 0x001C3178 File Offset: 0x001C1378
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 65655, RefRangeEnd = 65684, XrefRangeStart = 65655, XrefRangeEnd = 65684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGameController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGameController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGameController.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ED7 RID: 24279 RVA: 0x001C31B4 File Offset: 0x001C13B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202413, RefRangeEnd = 202414, XrefRangeStart = 202413, XrefRangeEnd = 202413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ED8 RID: 24280 RVA: 0x001C31F0 File Offset: 0x001C13F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202414, RefRangeEnd = 202415, XrefRangeStart = 202414, XrefRangeEnd = 202414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ED9 RID: 24281 RVA: 0x001C322C File Offset: 0x001C142C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EDA RID: 24282 RVA: 0x001C3268 File Offset: 0x001C1468
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 202445, RefRangeEnd = 202448, XrefRangeStart = 202415, XrefRangeEnd = 202445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGameController.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EDB RID: 24283 RVA: 0x0002CD2A File Offset: 0x0002AF2A
		public CasinoGameController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D34 RID: 7476
		// (get) Token: 0x06005EDC RID: 24284 RVA: 0x001C32A4 File Offset: 0x001C14A4
		// (set) Token: 0x06005EDD RID: 24285 RVA: 0x0002CD33 File Offset: 0x0002AF33
		public unsafe static float FOV
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CasinoGameController.NativeFieldInfoPtr_FOV, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CasinoGameController.NativeFieldInfoPtr_FOV, (void*)(&value));
			}
		}

		// Token: 0x17001D35 RID: 7477
		// (get) Token: 0x06005EDE RID: 24286 RVA: 0x001C32C0 File Offset: 0x001C14C0
		// (set) Token: 0x06005EDF RID: 24287 RVA: 0x0002CD41 File Offset: 0x0002AF41
		public unsafe static float CAMERA_LERP_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CasinoGameController.NativeFieldInfoPtr_CAMERA_LERP_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CasinoGameController.NativeFieldInfoPtr_CAMERA_LERP_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001D36 RID: 7478
		// (get) Token: 0x06005EE0 RID: 24288 RVA: 0x001C32DC File Offset: 0x001C14DC
		// (set) Token: 0x06005EE1 RID: 24289 RVA: 0x0002CD4F File Offset: 0x0002AF4F
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D37 RID: 7479
		// (get) Token: 0x06005EE2 RID: 24290 RVA: 0x001C3304 File Offset: 0x001C1504
		// (set) Token: 0x06005EE3 RID: 24291 RVA: 0x0002CD6A File Offset: 0x0002AF6A
		public unsafe float _LocalPlayerBet_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr__LocalPlayerBet_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr__LocalPlayerBet_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D38 RID: 7480
		// (get) Token: 0x06005EE4 RID: 24292 RVA: 0x001C332C File Offset: 0x001C152C
		// (set) Token: 0x06005EE5 RID: 24293 RVA: 0x0002CD85 File Offset: 0x0002AF85
		public unsafe CasinoGamePlayers Players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_Players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D39 RID: 7481
		// (get) Token: 0x06005EE6 RID: 24294 RVA: 0x001C335C File Offset: 0x001C155C
		// (set) Token: 0x06005EE7 RID: 24295 RVA: 0x0002CDA4 File Offset: 0x0002AFA4
		public unsafe CasinoGameInteraction Interaction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_Interaction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGameInteraction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_Interaction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D3A RID: 7482
		// (get) Token: 0x06005EE8 RID: 24296 RVA: 0x001C338C File Offset: 0x001C158C
		// (set) Token: 0x06005EE9 RID: 24297 RVA: 0x0002CDC3 File Offset: 0x0002AFC3
		public unsafe Il2CppReferenceArray<Transform> DefaultCameraTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_DefaultCameraTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_DefaultCameraTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D3B RID: 7483
		// (get) Token: 0x06005EEA RID: 24298 RVA: 0x001C33BC File Offset: 0x001C15BC
		// (set) Token: 0x06005EEB RID: 24299 RVA: 0x0002CDE2 File Offset: 0x0002AFE2
		public unsafe MonoState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x06005EEC RID: 24300 RVA: 0x001C33EC File Offset: 0x001C15EC
		// (set) Token: 0x06005EED RID: 24301 RVA: 0x0002CE01 File Offset: 0x0002B001
		public unsafe Action onLocalPlayerBetChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_onLocalPlayerBetChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_onLocalPlayerBetChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x06005EEE RID: 24302 RVA: 0x001C341C File Offset: 0x001C161C
		// (set) Token: 0x06005EEF RID: 24303 RVA: 0x0002CE20 File Offset: 0x0002B020
		public unsafe Transform localDefaultCameraTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_localDefaultCameraTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_localDefaultCameraTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x06005EF0 RID: 24304 RVA: 0x001C344C File Offset: 0x001C164C
		// (set) Token: 0x06005EF1 RID: 24305 RVA: 0x0002CE3F File Offset: 0x0002B03F
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x06005EF2 RID: 24306 RVA: 0x001C3474 File Offset: 0x001C1674
		// (set) Token: 0x06005EF3 RID: 24307 RVA: 0x0002CE5A File Offset: 0x0002B05A
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGameController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400413B RID: 16699
		private static readonly IntPtr NativeFieldInfoPtr_FOV;

		// Token: 0x0400413C RID: 16700
		private static readonly IntPtr NativeFieldInfoPtr_CAMERA_LERP_TIME;

		// Token: 0x0400413D RID: 16701
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400413E RID: 16702
		private static readonly IntPtr NativeFieldInfoPtr__LocalPlayerBet_k__BackingField;

		// Token: 0x0400413F RID: 16703
		private static readonly IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x04004140 RID: 16704
		private static readonly IntPtr NativeFieldInfoPtr_Interaction;

		// Token: 0x04004141 RID: 16705
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCameraTransforms;

		// Token: 0x04004142 RID: 16706
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04004143 RID: 16707
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerBetChange;

		// Token: 0x04004144 RID: 16708
		private static readonly IntPtr NativeFieldInfoPtr_localDefaultCameraTransform;

		// Token: 0x04004145 RID: 16709
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004146 RID: 16710
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004147 RID: 16711
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04004148 RID: 16712
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04004149 RID: 16713
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerBet_Public_get_Single_0;

		// Token: 0x0400414A RID: 16714
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalPlayerBet_Protected_set_Void_Single_0;

		// Token: 0x0400414B RID: 16715
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerData_Public_get_CasinoGamePlayerData_0;

		// Token: 0x0400414C RID: 16716
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400414D RID: 16717
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalPlayerRequestJoin_Protected_Virtual_New_Void_Player_0;

		// Token: 0x0400414E RID: 16718
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0;

		// Token: 0x0400414F RID: 16719
		private static readonly IntPtr NativeMethodInfoPtr_Open_Protected_Virtual_New_Void_1;

		// Token: 0x04004150 RID: 16720
		private static readonly IntPtr NativeMethodInfoPtr_Close_Protected_Void_0;

		// Token: 0x04004151 RID: 16721
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Protected_Virtual_New_Void_1;

		// Token: 0x04004152 RID: 16722
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalPlayerBet_Public_Void_Single_0;

		// Token: 0x04004153 RID: 16723
		private static readonly IntPtr NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Virtual_New_Void_0;

		// Token: 0x04004154 RID: 16724
		private static readonly IntPtr NativeMethodInfoPtr_IsWaitingForPlayers_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04004155 RID: 16725
		private static readonly IntPtr NativeMethodInfoPtr_GetBetLimits_Public_Abstract_Virtual_New_Void_byref_Single_byref_Single_0;

		// Token: 0x04004156 RID: 16726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04004157 RID: 16727
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004158 RID: 16728
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004159 RID: 16729
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400415A RID: 16730
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
