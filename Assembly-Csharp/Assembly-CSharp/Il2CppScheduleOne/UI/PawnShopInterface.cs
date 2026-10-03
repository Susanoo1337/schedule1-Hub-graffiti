using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.State;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000748 RID: 1864
	public class PawnShopInterface : Singleton<PawnShopInterface>
	{
		// Token: 0x0600B4FA RID: 46330 RVA: 0x002EF974 File Offset: 0x002EDB74
		// Note: this type is marked as 'beforefieldinit'.
		static PawnShopInterface()
		{
			Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PawnShopInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr);
			PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PAYMENT_MIN");
			PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PAYMENT_MAX");
			PawnShopInterface.NativeFieldInfoPtr_THINK_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "THINK_TIME");
			PawnShopInterface.NativeFieldInfoPtr_MIN_VALUE_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "MIN_VALUE_MULTIPLIER");
			PawnShopInterface.NativeFieldInfoPtr_MAX_VALUE_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "MAX_VALUE_MULTIPLIER");
			PawnShopInterface.NativeFieldInfoPtr_PAWN_SLOT_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PAWN_SLOT_COUNT");
			PawnShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			PawnShopInterface.NativeFieldInfoPtr_CurrentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "CurrentState");
			PawnShopInterface.NativeFieldInfoPtr_PlayerResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PlayerResponse");
			PawnShopInterface.NativeFieldInfoPtr_CurrentNegotiationRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "CurrentNegotiationRound");
			PawnShopInterface.NativeFieldInfoPtr_InitialShopOffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "InitialShopOffer");
			PawnShopInterface.NativeFieldInfoPtr_LastShopOffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "LastShopOffer");
			PawnShopInterface.NativeFieldInfoPtr_LastRefusedAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "LastRefusedAmount");
			PawnShopInterface.NativeFieldInfoPtr_PawnShopNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PawnShopNPC");
			PawnShopInterface.NativeFieldInfoPtr__NPCAnger_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "<NPCAnger>k__BackingField");
			PawnShopInterface.NativeFieldInfoPtr_RandomCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "RandomCurve");
			PawnShopInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Canvas");
			PawnShopInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Container");
			PawnShopInterface.NativeFieldInfoPtr_Slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Slots");
			PawnShopInterface.NativeFieldInfoPtr_ValueRangeLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "ValueRangeLabels");
			PawnShopInterface.NativeFieldInfoPtr_TotalValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "TotalValueLabel");
			PawnShopInterface.NativeFieldInfoPtr_StartButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "StartButton");
			PawnShopInterface.NativeFieldInfoPtr_Step1Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Step1Animation");
			PawnShopInterface.NativeFieldInfoPtr_Step1CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Step1CanvasGroup");
			PawnShopInterface.NativeFieldInfoPtr_Step2Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Step2Animation");
			PawnShopInterface.NativeFieldInfoPtr_Step2CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Step2CanvasGroup");
			PawnShopInterface.NativeFieldInfoPtr_FadeInAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "FadeInAnim");
			PawnShopInterface.NativeFieldInfoPtr_FadeOutAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "FadeOutAnim");
			PawnShopInterface.NativeFieldInfoPtr_AngerSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "AngerSlider");
			PawnShopInterface.NativeFieldInfoPtr_AcceptCounterButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "AcceptCounterButtonLabel");
			PawnShopInterface.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "State");
			PawnShopInterface.NativeFieldInfoPtr_AmountSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "AmountSelector");
			PawnShopInterface.NativeFieldInfoPtr_OfferLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "OfferLines");
			PawnShopInterface.NativeFieldInfoPtr_ThinkLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "ThinkLines");
			PawnShopInterface.NativeFieldInfoPtr_AcceptLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "AcceptLines");
			PawnShopInterface.NativeFieldInfoPtr_CounterLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "CounterLines");
			PawnShopInterface.NativeFieldInfoPtr_RefusalLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "RefusalLines");
			PawnShopInterface.NativeFieldInfoPtr_DealFinalizedLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "DealFinalizedLines");
			PawnShopInterface.NativeFieldInfoPtr_AngeredLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "AngeredLines");
			PawnShopInterface.NativeFieldInfoPtr_CrashOutLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "CrashOutLines");
			PawnShopInterface.NativeFieldInfoPtr_PawnSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PawnSlots");
			PawnShopInterface.NativeFieldInfoPtr_routine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "routine");
			PawnShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687007);
			PawnShopInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687008);
			PawnShopInterface.NativeMethodInfoPtr_get_NPCAnger_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687009);
			PawnShopInterface.NativeMethodInfoPtr_set_NPCAnger_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687010);
			PawnShopInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687011);
			PawnShopInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687012);
			PawnShopInterface.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687013);
			PawnShopInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687014);
			PawnShopInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687015);
			PawnShopInterface.NativeMethodInfoPtr_OnClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687016);
			PawnShopInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687017);
			PawnShopInterface.NativeMethodInfoPtr_OnMinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687018);
			PawnShopInterface.NativeMethodInfoPtr_OnDayPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687019);
			PawnShopInterface.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687020);
			PawnShopInterface.NativeMethodInfoPtr_GetPawnItems_Private_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687021);
			PawnShopInterface.NativeMethodInfoPtr_PawnSlotChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687022);
			PawnShopInterface.NativeMethodInfoPtr_UpdateValueRangeLabels_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687023);
			PawnShopInterface.NativeMethodInfoPtr_StartButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687024);
			PawnShopInterface.NativeMethodInfoPtr_StartNegotiation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687025);
			PawnShopInterface.NativeMethodInfoPtr_PlayShopResponse_Private_Void_EShopResponse_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687026);
			PawnShopInterface.NativeMethodInfoPtr_EvaluateCounter_Private_EShopResponse_Single_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687027);
			PawnShopInterface.NativeMethodInfoPtr_EndNegotiation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687028);
			PawnShopInterface.NativeMethodInfoPtr_SetPlayerResponse_Public_Void_EPlayerResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687029);
			PawnShopInterface.NativeMethodInfoPtr_AcceptOrCounter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687030);
			PawnShopInterface.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687031);
			PawnShopInterface.NativeMethodInfoPtr_ChangeAnger_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687032);
			PawnShopInterface.NativeMethodInfoPtr_ClearPawnshopSlots_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687033);
			PawnShopInterface.NativeMethodInfoPtr_SetAngeredToday_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687034);
			PawnShopInterface.NativeMethodInfoPtr_Think_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687035);
			PawnShopInterface.NativeMethodInfoPtr_SetOffer_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687036);
			PawnShopInterface.NativeMethodInfoPtr_FinalizeDeal_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687037);
			PawnShopInterface.NativeMethodInfoPtr_GetTotalValue_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687038);
			PawnShopInterface.NativeMethodInfoPtr_RoundOffer_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687039);
			PawnShopInterface.NativeMethodInfoPtr_GetItemValue_Private_Single_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687040);
			PawnShopInterface.NativeMethodInfoPtr_ResetUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687041);
			PawnShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687042);
			PawnShopInterface.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687043);
			PawnShopInterface.NativeMethodInfoPtr__StartNegotiation_b__65_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687044);
			PawnShopInterface.NativeMethodInfoPtr__StartNegotiation_b__65_2_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100687045);
		}

		// Token: 0x170036B6 RID: 14006
		// (get) Token: 0x0600B4FB RID: 46331 RVA: 0x002EFFF8 File Offset: 0x002EE1F8
		// (set) Token: 0x0600B4FC RID: 46332 RVA: 0x002F0034 File Offset: 0x002EE234
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 33070, RefRangeEnd = 33090, XrefRangeStart = 33070, XrefRangeEnd = 33090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170036B7 RID: 14007
		// (get) Token: 0x0600B4FD RID: 46333 RVA: 0x002F0074 File Offset: 0x002EE274
		// (set) Token: 0x0600B4FE RID: 46334 RVA: 0x002F00B0 File Offset: 0x002EE2B0
		public unsafe float NPCAnger
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_get_NPCAnger_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_set_NPCAnger_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B4FF RID: 46335 RVA: 0x002F00F0 File Offset: 0x002EE2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304826, XrefRangeEnd = 304912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PawnShopInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B500 RID: 46336 RVA: 0x002F012C File Offset: 0x002EE32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304912, XrefRangeEnd = 304974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PawnShopInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B501 RID: 46337 RVA: 0x002F0168 File Offset: 0x002EE368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304974, XrefRangeEnd = 305005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PawnShopInterface.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B502 RID: 46338 RVA: 0x002F01A4 File Offset: 0x002EE3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305005, XrefRangeEnd = 305018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B503 RID: 46339 RVA: 0x002F01D8 File Offset: 0x002EE3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305018, XrefRangeEnd = 305020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B504 RID: 46340 RVA: 0x002F020C File Offset: 0x002EE40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305020, XrefRangeEnd = 305038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_OnClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B505 RID: 46341 RVA: 0x002F0240 File Offset: 0x002EE440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305038, XrefRangeEnd = 305041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B506 RID: 46342 RVA: 0x002F0284 File Offset: 0x002EE484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305041, XrefRangeEnd = 305042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_OnMinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B507 RID: 46343 RVA: 0x002F02B8 File Offset: 0x002EE4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305042, XrefRangeEnd = 305043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_OnDayPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B508 RID: 46344 RVA: 0x002F02EC File Offset: 0x002EE4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305043, XrefRangeEnd = 305068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B509 RID: 46345 RVA: 0x002F0320 File Offset: 0x002EE520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305068, XrefRangeEnd = 305078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemInstance> GetPawnItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_GetPawnItems_Private_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemInstance>>(intPtr3) : null;
		}

		// Token: 0x0600B50A RID: 46346 RVA: 0x002F0360 File Offset: 0x002EE560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305078, XrefRangeEnd = 305079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PawnSlotChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_PawnSlotChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B50B RID: 46347 RVA: 0x002F0394 File Offset: 0x002EE594
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 305106, RefRangeEnd = 305108, XrefRangeStart = 305079, XrefRangeEnd = 305106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValueRangeLabels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_UpdateValueRangeLabels_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B50C RID: 46348 RVA: 0x002F03C8 File Offset: 0x002EE5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305108, XrefRangeEnd = 305120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_StartButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B50D RID: 46349 RVA: 0x002F03FC File Offset: 0x002EE5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartNegotiation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_StartNegotiation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B50E RID: 46350 RVA: 0x002F0430 File Offset: 0x002EE630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305120, XrefRangeEnd = 305142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayShopResponse(PawnShopInterface.EShopResponse response, float counter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref response;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref counter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_PlayShopResponse_Private_Void_EShopResponse_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B50F RID: 46351 RVA: 0x002F047C File Offset: 0x002EE67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305142, XrefRangeEnd = 305172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PawnShopInterface.EShopResponse EvaluateCounter(float lastShopOffer, float playerOffer, out float counterAmount, out float angerChange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lastShopOffer;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &counterAmount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &angerChange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_EvaluateCounter_Private_EShopResponse_Single_Single_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B510 RID: 46352 RVA: 0x002F04F0 File Offset: 0x002EE6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305172, XrefRangeEnd = 305184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndNegotiation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_EndNegotiation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B511 RID: 46353 RVA: 0x002F0524 File Offset: 0x002EE724
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 305194, RefRangeEnd = 305198, XrefRangeStart = 305184, XrefRangeEnd = 305194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerResponse(PawnShopInterface.EPlayerResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref response;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_SetPlayerResponse_Public_Void_EPlayerResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B512 RID: 46354 RVA: 0x002F0564 File Offset: 0x002EE764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305198, XrefRangeEnd = 305201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AcceptOrCounter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_AcceptOrCounter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B513 RID: 46355 RVA: 0x002F0598 File Offset: 0x002EE798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305201, XrefRangeEnd = 305202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B514 RID: 46356 RVA: 0x002F05CC File Offset: 0x002EE7CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 305235, RefRangeEnd = 305236, XrefRangeStart = 305202, XrefRangeEnd = 305235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeAnger(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_ChangeAnger_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B515 RID: 46357 RVA: 0x002F060C File Offset: 0x002EE80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305236, XrefRangeEnd = 305237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPawnshopSlots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_ClearPawnshopSlots_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B516 RID: 46358 RVA: 0x002F0640 File Offset: 0x002EE840
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 305248, RefRangeEnd = 305250, XrefRangeStart = 305237, XrefRangeEnd = 305248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAngeredToday(bool angered)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angered;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_SetAngeredToday_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B517 RID: 46359 RVA: 0x002F0680 File Offset: 0x002EE880
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 305254, RefRangeEnd = 305255, XrefRangeStart = 305250, XrefRangeEnd = 305254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Think()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Think_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B518 RID: 46360 RVA: 0x002F06B4 File Offset: 0x002EE8B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 305272, RefRangeEnd = 305273, XrefRangeStart = 305255, XrefRangeEnd = 305272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOffer(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_SetOffer_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B519 RID: 46361 RVA: 0x002F06F4 File Offset: 0x002EE8F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 305284, RefRangeEnd = 305285, XrefRangeStart = 305273, XrefRangeEnd = 305284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizeDeal(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_FinalizeDeal_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B51A RID: 46362 RVA: 0x002F0734 File Offset: 0x002EE934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305285, XrefRangeEnd = 305287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_GetTotalValue_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B51B RID: 46363 RVA: 0x002F0770 File Offset: 0x002EE970
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 305288, RefRangeEnd = 305290, XrefRangeStart = 305287, XrefRangeEnd = 305288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float RoundOffer(float offer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_RoundOffer_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B51C RID: 46364 RVA: 0x002F07BC File Offset: 0x002EE9BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 305322, RefRangeEnd = 305324, XrefRangeStart = 305290, XrefRangeEnd = 305322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetItemValue(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_GetItemValue_Private_Single_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B51D RID: 46365 RVA: 0x002F080C File Offset: 0x002EEA0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 305335, RefRangeEnd = 305338, XrefRangeStart = 305324, XrefRangeEnd = 305335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_ResetUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B51E RID: 46366 RVA: 0x002F0840 File Offset: 0x002EEA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305338, XrefRangeEnd = 305341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PawnShopInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B51F RID: 46367 RVA: 0x002F087C File Offset: 0x002EEA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305341, XrefRangeEnd = 305346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B520 RID: 46368 RVA: 0x002F08BC File Offset: 0x002EEABC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 305346, RefRangeEnd = 305355, XrefRangeStart = 305346, XrefRangeEnd = 305346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _StartNegotiation_b__65_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr__StartNegotiation_b__65_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B521 RID: 46369 RVA: 0x002F08F8 File Offset: 0x002EEAF8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 305346, RefRangeEnd = 305355, XrefRangeStart = 305346, XrefRangeEnd = 305355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _StartNegotiation_b__65_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr__StartNegotiation_b__65_2_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B522 RID: 46370 RVA: 0x00053B89 File Offset: 0x00051D89
		public PawnShopInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700368C RID: 13964
		// (get) Token: 0x0600B523 RID: 46371 RVA: 0x002F0934 File Offset: 0x002EEB34
		// (set) Token: 0x0600B524 RID: 46372 RVA: 0x00053B92 File Offset: 0x00051D92
		public unsafe static float PAYMENT_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MIN, (void*)(&value));
			}
		}

		// Token: 0x1700368D RID: 13965
		// (get) Token: 0x0600B525 RID: 46373 RVA: 0x002F0950 File Offset: 0x002EEB50
		// (set) Token: 0x0600B526 RID: 46374 RVA: 0x00053BA0 File Offset: 0x00051DA0
		public unsafe static float PAYMENT_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MAX, (void*)(&value));
			}
		}

		// Token: 0x1700368E RID: 13966
		// (get) Token: 0x0600B527 RID: 46375 RVA: 0x002F096C File Offset: 0x002EEB6C
		// (set) Token: 0x0600B528 RID: 46376 RVA: 0x00053BAE File Offset: 0x00051DAE
		public unsafe static float THINK_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_THINK_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_THINK_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700368F RID: 13967
		// (get) Token: 0x0600B529 RID: 46377 RVA: 0x002F0988 File Offset: 0x002EEB88
		// (set) Token: 0x0600B52A RID: 46378 RVA: 0x00053BBC File Offset: 0x00051DBC
		public unsafe static float MIN_VALUE_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_MIN_VALUE_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_MIN_VALUE_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17003690 RID: 13968
		// (get) Token: 0x0600B52B RID: 46379 RVA: 0x002F09A4 File Offset: 0x002EEBA4
		// (set) Token: 0x0600B52C RID: 46380 RVA: 0x00053BCA File Offset: 0x00051DCA
		public unsafe static float MAX_VALUE_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_MAX_VALUE_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_MAX_VALUE_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17003691 RID: 13969
		// (get) Token: 0x0600B52D RID: 46381 RVA: 0x002F09C0 File Offset: 0x002EEBC0
		// (set) Token: 0x0600B52E RID: 46382 RVA: 0x00053BD8 File Offset: 0x00051DD8
		public unsafe static int PAWN_SLOT_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_PAWN_SLOT_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_PAWN_SLOT_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17003692 RID: 13970
		// (get) Token: 0x0600B52F RID: 46383 RVA: 0x002F09DC File Offset: 0x002EEBDC
		// (set) Token: 0x0600B530 RID: 46384 RVA: 0x00053BE6 File Offset: 0x00051DE6
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003693 RID: 13971
		// (get) Token: 0x0600B531 RID: 46385 RVA: 0x002F0A04 File Offset: 0x002EEC04
		// (set) Token: 0x0600B532 RID: 46386 RVA: 0x00053C01 File Offset: 0x00051E01
		public unsafe PawnShopInterface.EState CurrentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CurrentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CurrentState)) = value;
			}
		}

		// Token: 0x17003694 RID: 13972
		// (get) Token: 0x0600B533 RID: 46387 RVA: 0x002F0A2C File Offset: 0x002EEC2C
		// (set) Token: 0x0600B534 RID: 46388 RVA: 0x00053C1C File Offset: 0x00051E1C
		public unsafe PawnShopInterface.EPlayerResponse PlayerResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PlayerResponse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PlayerResponse)) = value;
			}
		}

		// Token: 0x17003695 RID: 13973
		// (get) Token: 0x0600B535 RID: 46389 RVA: 0x002F0A54 File Offset: 0x002EEC54
		// (set) Token: 0x0600B536 RID: 46390 RVA: 0x00053C37 File Offset: 0x00051E37
		public unsafe int CurrentNegotiationRound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CurrentNegotiationRound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CurrentNegotiationRound)) = value;
			}
		}

		// Token: 0x17003696 RID: 13974
		// (get) Token: 0x0600B537 RID: 46391 RVA: 0x002F0A7C File Offset: 0x002EEC7C
		// (set) Token: 0x0600B538 RID: 46392 RVA: 0x00053C52 File Offset: 0x00051E52
		public unsafe float InitialShopOffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_InitialShopOffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_InitialShopOffer)) = value;
			}
		}

		// Token: 0x17003697 RID: 13975
		// (get) Token: 0x0600B539 RID: 46393 RVA: 0x002F0AA4 File Offset: 0x002EECA4
		// (set) Token: 0x0600B53A RID: 46394 RVA: 0x00053C6D File Offset: 0x00051E6D
		public unsafe float LastShopOffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_LastShopOffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_LastShopOffer)) = value;
			}
		}

		// Token: 0x17003698 RID: 13976
		// (get) Token: 0x0600B53B RID: 46395 RVA: 0x002F0ACC File Offset: 0x002EECCC
		// (set) Token: 0x0600B53C RID: 46396 RVA: 0x00053C88 File Offset: 0x00051E88
		public unsafe float LastRefusedAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_LastRefusedAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_LastRefusedAmount)) = value;
			}
		}

		// Token: 0x17003699 RID: 13977
		// (get) Token: 0x0600B53D RID: 46397 RVA: 0x002F0AF4 File Offset: 0x002EECF4
		// (set) Token: 0x0600B53E RID: 46398 RVA: 0x00053CA3 File Offset: 0x00051EA3
		public unsafe NPC PawnShopNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PawnShopNPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PawnShopNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700369A RID: 13978
		// (get) Token: 0x0600B53F RID: 46399 RVA: 0x002F0B24 File Offset: 0x002EED24
		// (set) Token: 0x0600B540 RID: 46400 RVA: 0x00053CC2 File Offset: 0x00051EC2
		public unsafe float _NPCAnger_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr__NPCAnger_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr__NPCAnger_k__BackingField)) = value;
			}
		}

		// Token: 0x1700369B RID: 13979
		// (get) Token: 0x0600B541 RID: 46401 RVA: 0x002F0B4C File Offset: 0x002EED4C
		// (set) Token: 0x0600B542 RID: 46402 RVA: 0x00053CDD File Offset: 0x00051EDD
		public unsafe AnimationCurve RandomCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_RandomCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_RandomCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700369C RID: 13980
		// (get) Token: 0x0600B543 RID: 46403 RVA: 0x002F0B7C File Offset: 0x002EED7C
		// (set) Token: 0x0600B544 RID: 46404 RVA: 0x00053CFC File Offset: 0x00051EFC
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700369D RID: 13981
		// (get) Token: 0x0600B545 RID: 46405 RVA: 0x002F0BAC File Offset: 0x002EEDAC
		// (set) Token: 0x0600B546 RID: 46406 RVA: 0x00053D1B File Offset: 0x00051F1B
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700369E RID: 13982
		// (get) Token: 0x0600B547 RID: 46407 RVA: 0x002F0BDC File Offset: 0x002EEDDC
		// (set) Token: 0x0600B548 RID: 46408 RVA: 0x00053D3A File Offset: 0x00051F3A
		public unsafe Il2CppReferenceArray<ItemSlotUI> Slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700369F RID: 13983
		// (get) Token: 0x0600B549 RID: 46409 RVA: 0x002F0C0C File Offset: 0x002EEE0C
		// (set) Token: 0x0600B54A RID: 46410 RVA: 0x00053D59 File Offset: 0x00051F59
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> ValueRangeLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_ValueRangeLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_ValueRangeLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036A0 RID: 13984
		// (get) Token: 0x0600B54B RID: 46411 RVA: 0x002F0C3C File Offset: 0x002EEE3C
		// (set) Token: 0x0600B54C RID: 46412 RVA: 0x00053D78 File Offset: 0x00051F78
		public unsafe TextMeshProUGUI TotalValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_TotalValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_TotalValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036A1 RID: 13985
		// (get) Token: 0x0600B54D RID: 46413 RVA: 0x002F0C6C File Offset: 0x002EEE6C
		// (set) Token: 0x0600B54E RID: 46414 RVA: 0x00053D97 File Offset: 0x00051F97
		public unsafe Button StartButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_StartButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_StartButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036A2 RID: 13986
		// (get) Token: 0x0600B54F RID: 46415 RVA: 0x002F0C9C File Offset: 0x002EEE9C
		// (set) Token: 0x0600B550 RID: 46416 RVA: 0x00053DB6 File Offset: 0x00051FB6
		public unsafe Animation Step1Animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step1Animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step1Animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036A3 RID: 13987
		// (get) Token: 0x0600B551 RID: 46417 RVA: 0x002F0CCC File Offset: 0x002EEECC
		// (set) Token: 0x0600B552 RID: 46418 RVA: 0x00053DD5 File Offset: 0x00051FD5
		public unsafe CanvasGroup Step1CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step1CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step1CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036A4 RID: 13988
		// (get) Token: 0x0600B553 RID: 46419 RVA: 0x002F0CFC File Offset: 0x002EEEFC
		// (set) Token: 0x0600B554 RID: 46420 RVA: 0x00053DF4 File Offset: 0x00051FF4
		public unsafe Animation Step2Animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step2Animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step2Animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036A5 RID: 13989
		// (get) Token: 0x0600B555 RID: 46421 RVA: 0x002F0D2C File Offset: 0x002EEF2C
		// (set) Token: 0x0600B556 RID: 46422 RVA: 0x00053E13 File Offset: 0x00052013
		public unsafe CanvasGroup Step2CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step2CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step2CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036A6 RID: 13990
		// (get) Token: 0x0600B557 RID: 46423 RVA: 0x002F0D5C File Offset: 0x002EEF5C
		// (set) Token: 0x0600B558 RID: 46424 RVA: 0x00053E32 File Offset: 0x00052032
		public unsafe AnimationClip FadeInAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_FadeInAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_FadeInAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036A7 RID: 13991
		// (get) Token: 0x0600B559 RID: 46425 RVA: 0x002F0D8C File Offset: 0x002EEF8C
		// (set) Token: 0x0600B55A RID: 46426 RVA: 0x00053E51 File Offset: 0x00052051
		public unsafe AnimationClip FadeOutAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_FadeOutAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_FadeOutAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036A8 RID: 13992
		// (get) Token: 0x0600B55B RID: 46427 RVA: 0x002F0DBC File Offset: 0x002EEFBC
		// (set) Token: 0x0600B55C RID: 46428 RVA: 0x00053E70 File Offset: 0x00052070
		public unsafe Slider AngerSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AngerSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AngerSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036A9 RID: 13993
		// (get) Token: 0x0600B55D RID: 46429 RVA: 0x002F0DEC File Offset: 0x002EEFEC
		// (set) Token: 0x0600B55E RID: 46430 RVA: 0x00053E8F File Offset: 0x0005208F
		public unsafe TextMeshProUGUI AcceptCounterButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AcceptCounterButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AcceptCounterButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036AA RID: 13994
		// (get) Token: 0x0600B55F RID: 46431 RVA: 0x002F0E1C File Offset: 0x002EF01C
		// (set) Token: 0x0600B560 RID: 46432 RVA: 0x00053EAE File Offset: 0x000520AE
		public unsafe MonoState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036AB RID: 13995
		// (get) Token: 0x0600B561 RID: 46433 RVA: 0x002F0E4C File Offset: 0x002EF04C
		// (set) Token: 0x0600B562 RID: 46434 RVA: 0x00053ECD File Offset: 0x000520CD
		public unsafe AmountSelector AmountSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AmountSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AmountSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AmountSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036AC RID: 13996
		// (get) Token: 0x0600B563 RID: 46435 RVA: 0x002F0E7C File Offset: 0x002EF07C
		// (set) Token: 0x0600B564 RID: 46436 RVA: 0x00053EEC File Offset: 0x000520EC
		public unsafe Il2CppStringArray OfferLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_OfferLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_OfferLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036AD RID: 13997
		// (get) Token: 0x0600B565 RID: 46437 RVA: 0x002F0EAC File Offset: 0x002EF0AC
		// (set) Token: 0x0600B566 RID: 46438 RVA: 0x00053F0B File Offset: 0x0005210B
		public unsafe Il2CppStringArray ThinkLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_ThinkLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_ThinkLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036AE RID: 13998
		// (get) Token: 0x0600B567 RID: 46439 RVA: 0x002F0EDC File Offset: 0x002EF0DC
		// (set) Token: 0x0600B568 RID: 46440 RVA: 0x00053F2A File Offset: 0x0005212A
		public unsafe Il2CppStringArray AcceptLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AcceptLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AcceptLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036AF RID: 13999
		// (get) Token: 0x0600B569 RID: 46441 RVA: 0x002F0F0C File Offset: 0x002EF10C
		// (set) Token: 0x0600B56A RID: 46442 RVA: 0x00053F49 File Offset: 0x00052149
		public unsafe Il2CppStringArray CounterLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CounterLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CounterLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036B0 RID: 14000
		// (get) Token: 0x0600B56B RID: 46443 RVA: 0x002F0F3C File Offset: 0x002EF13C
		// (set) Token: 0x0600B56C RID: 46444 RVA: 0x00053F68 File Offset: 0x00052168
		public unsafe Il2CppStringArray RefusalLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_RefusalLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_RefusalLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036B1 RID: 14001
		// (get) Token: 0x0600B56D RID: 46445 RVA: 0x002F0F6C File Offset: 0x002EF16C
		// (set) Token: 0x0600B56E RID: 46446 RVA: 0x00053F87 File Offset: 0x00052187
		public unsafe Il2CppStringArray DealFinalizedLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_DealFinalizedLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_DealFinalizedLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036B2 RID: 14002
		// (get) Token: 0x0600B56F RID: 46447 RVA: 0x002F0F9C File Offset: 0x002EF19C
		// (set) Token: 0x0600B570 RID: 46448 RVA: 0x00053FA6 File Offset: 0x000521A6
		public unsafe Il2CppStringArray AngeredLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AngeredLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AngeredLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036B3 RID: 14003
		// (get) Token: 0x0600B571 RID: 46449 RVA: 0x002F0FCC File Offset: 0x002EF1CC
		// (set) Token: 0x0600B572 RID: 46450 RVA: 0x00053FC5 File Offset: 0x000521C5
		public unsafe Il2CppStringArray CrashOutLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CrashOutLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CrashOutLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036B4 RID: 14004
		// (get) Token: 0x0600B573 RID: 46451 RVA: 0x002F0FFC File Offset: 0x002EF1FC
		// (set) Token: 0x0600B574 RID: 46452 RVA: 0x00053FE4 File Offset: 0x000521E4
		public unsafe Il2CppReferenceArray<ItemSlot> PawnSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PawnSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PawnSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036B5 RID: 14005
		// (get) Token: 0x0600B575 RID: 46453 RVA: 0x002F102C File Offset: 0x002EF22C
		// (set) Token: 0x0600B576 RID: 46454 RVA: 0x00054003 File Offset: 0x00052203
		public unsafe Coroutine routine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_routine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_routine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007C77 RID: 31863
		private static readonly IntPtr NativeFieldInfoPtr_PAYMENT_MIN;

		// Token: 0x04007C78 RID: 31864
		private static readonly IntPtr NativeFieldInfoPtr_PAYMENT_MAX;

		// Token: 0x04007C79 RID: 31865
		private static readonly IntPtr NativeFieldInfoPtr_THINK_TIME;

		// Token: 0x04007C7A RID: 31866
		private static readonly IntPtr NativeFieldInfoPtr_MIN_VALUE_MULTIPLIER;

		// Token: 0x04007C7B RID: 31867
		private static readonly IntPtr NativeFieldInfoPtr_MAX_VALUE_MULTIPLIER;

		// Token: 0x04007C7C RID: 31868
		private static readonly IntPtr NativeFieldInfoPtr_PAWN_SLOT_COUNT;

		// Token: 0x04007C7D RID: 31869
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04007C7E RID: 31870
		private static readonly IntPtr NativeFieldInfoPtr_CurrentState;

		// Token: 0x04007C7F RID: 31871
		private static readonly IntPtr NativeFieldInfoPtr_PlayerResponse;

		// Token: 0x04007C80 RID: 31872
		private static readonly IntPtr NativeFieldInfoPtr_CurrentNegotiationRound;

		// Token: 0x04007C81 RID: 31873
		private static readonly IntPtr NativeFieldInfoPtr_InitialShopOffer;

		// Token: 0x04007C82 RID: 31874
		private static readonly IntPtr NativeFieldInfoPtr_LastShopOffer;

		// Token: 0x04007C83 RID: 31875
		private static readonly IntPtr NativeFieldInfoPtr_LastRefusedAmount;

		// Token: 0x04007C84 RID: 31876
		private static readonly IntPtr NativeFieldInfoPtr_PawnShopNPC;

		// Token: 0x04007C85 RID: 31877
		private static readonly IntPtr NativeFieldInfoPtr__NPCAnger_k__BackingField;

		// Token: 0x04007C86 RID: 31878
		private static readonly IntPtr NativeFieldInfoPtr_RandomCurve;

		// Token: 0x04007C87 RID: 31879
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04007C88 RID: 31880
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04007C89 RID: 31881
		private static readonly IntPtr NativeFieldInfoPtr_Slots;

		// Token: 0x04007C8A RID: 31882
		private static readonly IntPtr NativeFieldInfoPtr_ValueRangeLabels;

		// Token: 0x04007C8B RID: 31883
		private static readonly IntPtr NativeFieldInfoPtr_TotalValueLabel;

		// Token: 0x04007C8C RID: 31884
		private static readonly IntPtr NativeFieldInfoPtr_StartButton;

		// Token: 0x04007C8D RID: 31885
		private static readonly IntPtr NativeFieldInfoPtr_Step1Animation;

		// Token: 0x04007C8E RID: 31886
		private static readonly IntPtr NativeFieldInfoPtr_Step1CanvasGroup;

		// Token: 0x04007C8F RID: 31887
		private static readonly IntPtr NativeFieldInfoPtr_Step2Animation;

		// Token: 0x04007C90 RID: 31888
		private static readonly IntPtr NativeFieldInfoPtr_Step2CanvasGroup;

		// Token: 0x04007C91 RID: 31889
		private static readonly IntPtr NativeFieldInfoPtr_FadeInAnim;

		// Token: 0x04007C92 RID: 31890
		private static readonly IntPtr NativeFieldInfoPtr_FadeOutAnim;

		// Token: 0x04007C93 RID: 31891
		private static readonly IntPtr NativeFieldInfoPtr_AngerSlider;

		// Token: 0x04007C94 RID: 31892
		private static readonly IntPtr NativeFieldInfoPtr_AcceptCounterButtonLabel;

		// Token: 0x04007C95 RID: 31893
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04007C96 RID: 31894
		private static readonly IntPtr NativeFieldInfoPtr_AmountSelector;

		// Token: 0x04007C97 RID: 31895
		private static readonly IntPtr NativeFieldInfoPtr_OfferLines;

		// Token: 0x04007C98 RID: 31896
		private static readonly IntPtr NativeFieldInfoPtr_ThinkLines;

		// Token: 0x04007C99 RID: 31897
		private static readonly IntPtr NativeFieldInfoPtr_AcceptLines;

		// Token: 0x04007C9A RID: 31898
		private static readonly IntPtr NativeFieldInfoPtr_CounterLines;

		// Token: 0x04007C9B RID: 31899
		private static readonly IntPtr NativeFieldInfoPtr_RefusalLines;

		// Token: 0x04007C9C RID: 31900
		private static readonly IntPtr NativeFieldInfoPtr_DealFinalizedLines;

		// Token: 0x04007C9D RID: 31901
		private static readonly IntPtr NativeFieldInfoPtr_AngeredLines;

		// Token: 0x04007C9E RID: 31902
		private static readonly IntPtr NativeFieldInfoPtr_CrashOutLines;

		// Token: 0x04007C9F RID: 31903
		private static readonly IntPtr NativeFieldInfoPtr_PawnSlots;

		// Token: 0x04007CA0 RID: 31904
		private static readonly IntPtr NativeFieldInfoPtr_routine;

		// Token: 0x04007CA1 RID: 31905
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04007CA2 RID: 31906
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04007CA3 RID: 31907
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCAnger_Public_get_Single_0;

		// Token: 0x04007CA4 RID: 31908
		private static readonly IntPtr NativeMethodInfoPtr_set_NPCAnger_Private_set_Void_Single_0;

		// Token: 0x04007CA5 RID: 31909
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007CA6 RID: 31910
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04007CA7 RID: 31911
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04007CA8 RID: 31912
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04007CA9 RID: 31913
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04007CAA RID: 31914
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Private_Void_0;

		// Token: 0x04007CAB RID: 31915
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04007CAC RID: 31916
		private static readonly IntPtr NativeMethodInfoPtr_OnMinPass_Private_Void_0;

		// Token: 0x04007CAD RID: 31917
		private static readonly IntPtr NativeMethodInfoPtr_OnDayPass_Private_Void_0;

		// Token: 0x04007CAE RID: 31918
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007CAF RID: 31919
		private static readonly IntPtr NativeMethodInfoPtr_GetPawnItems_Private_List_1_ItemInstance_0;

		// Token: 0x04007CB0 RID: 31920
		private static readonly IntPtr NativeMethodInfoPtr_PawnSlotChanged_Private_Void_0;

		// Token: 0x04007CB1 RID: 31921
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValueRangeLabels_Private_Void_0;

		// Token: 0x04007CB2 RID: 31922
		private static readonly IntPtr NativeMethodInfoPtr_StartButtonPressed_Public_Void_0;

		// Token: 0x04007CB3 RID: 31923
		private static readonly IntPtr NativeMethodInfoPtr_StartNegotiation_Private_Void_0;

		// Token: 0x04007CB4 RID: 31924
		private static readonly IntPtr NativeMethodInfoPtr_PlayShopResponse_Private_Void_EShopResponse_Single_0;

		// Token: 0x04007CB5 RID: 31925
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateCounter_Private_EShopResponse_Single_Single_byref_Single_byref_Single_0;

		// Token: 0x04007CB6 RID: 31926
		private static readonly IntPtr NativeMethodInfoPtr_EndNegotiation_Private_Void_0;

		// Token: 0x04007CB7 RID: 31927
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerResponse_Public_Void_EPlayerResponse_0;

		// Token: 0x04007CB8 RID: 31928
		private static readonly IntPtr NativeMethodInfoPtr_AcceptOrCounter_Public_Void_0;

		// Token: 0x04007CB9 RID: 31929
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		// Token: 0x04007CBA RID: 31930
		private static readonly IntPtr NativeMethodInfoPtr_ChangeAnger_Private_Void_Single_0;

		// Token: 0x04007CBB RID: 31931
		private static readonly IntPtr NativeMethodInfoPtr_ClearPawnshopSlots_Private_Void_0;

		// Token: 0x04007CBC RID: 31932
		private static readonly IntPtr NativeMethodInfoPtr_SetAngeredToday_Private_Void_Boolean_0;

		// Token: 0x04007CBD RID: 31933
		private static readonly IntPtr NativeMethodInfoPtr_Think_Private_Void_0;

		// Token: 0x04007CBE RID: 31934
		private static readonly IntPtr NativeMethodInfoPtr_SetOffer_Private_Void_Single_0;

		// Token: 0x04007CBF RID: 31935
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeDeal_Private_Void_Single_0;

		// Token: 0x04007CC0 RID: 31936
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalValue_Private_Single_0;

		// Token: 0x04007CC1 RID: 31937
		private static readonly IntPtr NativeMethodInfoPtr_RoundOffer_Private_Single_Single_0;

		// Token: 0x04007CC2 RID: 31938
		private static readonly IntPtr NativeMethodInfoPtr_GetItemValue_Private_Single_ItemInstance_0;

		// Token: 0x04007CC3 RID: 31939
		private static readonly IntPtr NativeMethodInfoPtr_ResetUI_Private_Void_0;

		// Token: 0x04007CC4 RID: 31940
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007CC5 RID: 31941
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04007CC6 RID: 31942
		private static readonly IntPtr NativeMethodInfoPtr__StartNegotiation_b__65_1_Private_Boolean_0;

		// Token: 0x04007CC7 RID: 31943
		private static readonly IntPtr NativeMethodInfoPtr__StartNegotiation_b__65_2_Private_Boolean_0;

		// Token: 0x02000CDA RID: 3290
		[OriginalName("Assembly-CSharp.dll", "", "EState")]
		public enum EState
		{
			// Token: 0x0400A625 RID: 42533
			WaitingForOffer,
			// Token: 0x0400A626 RID: 42534
			Negotiating
		}

		// Token: 0x02000CDB RID: 3291
		[OriginalName("Assembly-CSharp.dll", "", "EPlayerResponse")]
		public enum EPlayerResponse
		{
			// Token: 0x0400A628 RID: 42536
			None,
			// Token: 0x0400A629 RID: 42537
			Accept,
			// Token: 0x0400A62A RID: 42538
			Counter,
			// Token: 0x0400A62B RID: 42539
			Cancel
		}

		// Token: 0x02000CDC RID: 3292
		[OriginalName("Assembly-CSharp.dll", "", "EShopResponse")]
		public enum EShopResponse
		{
			// Token: 0x0400A62D RID: 42541
			Accept,
			// Token: 0x0400A62E RID: 42542
			Counter,
			// Token: 0x0400A62F RID: 42543
			Refusal
		}

		// Token: 0x02000CDD RID: 3293
		[ObfuscatedName("ScheduleOne.UI.PawnShopInterface+<<StartNegotiation>g__NegotiationRoutine|65_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600F59E RID: 62878 RVA: 0x003AF8F0 File Offset: 0x003ADAF0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique()
			{
				Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "<<StartNegotiation>g__NegotiationRoutine|65_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, "<>1__state");
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, "<>2__current");
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, "<>4__this");
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__shopResponse_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, "<shopResponse>5__2");
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__counter_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, "<counter>5__3");
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100687046);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100687047);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100687048);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100687049);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100687050);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100687051);
			}

			// Token: 0x0600F59F RID: 62879 RVA: 0x003AF9F8 File Offset: 0x003ADBF8
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F5A0 RID: 62880 RVA: 0x003AFA40 File Offset: 0x003ADC40
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F5A1 RID: 62881 RVA: 0x003AFA74 File Offset: 0x003ADC74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304772, XrefRangeEnd = 304821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004AA5 RID: 19109
			// (get) Token: 0x0600F5A2 RID: 62882 RVA: 0x003AFAB0 File Offset: 0x003ADCB0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F5A3 RID: 62883 RVA: 0x003AFAF0 File Offset: 0x003ADCF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304821, XrefRangeEnd = 304826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004AA6 RID: 19110
			// (get) Token: 0x0600F5A4 RID: 62884 RVA: 0x003AFB24 File Offset: 0x003ADD24
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F5A5 RID: 62885 RVA: 0x000741E1 File Offset: 0x000723E1
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004AA0 RID: 19104
			// (get) Token: 0x0600F5A6 RID: 62886 RVA: 0x003AFB64 File Offset: 0x003ADD64
			// (set) Token: 0x0600F5A7 RID: 62887 RVA: 0x000741EA File Offset: 0x000723EA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004AA1 RID: 19105
			// (get) Token: 0x0600F5A8 RID: 62888 RVA: 0x003AFB8C File Offset: 0x003ADD8C
			// (set) Token: 0x0600F5A9 RID: 62889 RVA: 0x00074205 File Offset: 0x00072405
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AA2 RID: 19106
			// (get) Token: 0x0600F5AA RID: 62890 RVA: 0x003AFBBC File Offset: 0x003ADDBC
			// (set) Token: 0x0600F5AB RID: 62891 RVA: 0x00074224 File Offset: 0x00072424
			public unsafe PawnShopInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PawnShopInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AA3 RID: 19107
			// (get) Token: 0x0600F5AC RID: 62892 RVA: 0x003AFBEC File Offset: 0x003ADDEC
			// (set) Token: 0x0600F5AD RID: 62893 RVA: 0x00074243 File Offset: 0x00072443
			public unsafe PawnShopInterface.EShopResponse _shopResponse_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__shopResponse_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__shopResponse_5__2)) = value;
				}
			}

			// Token: 0x17004AA4 RID: 19108
			// (get) Token: 0x0600F5AE RID: 62894 RVA: 0x003AFC14 File Offset: 0x003ADE14
			// (set) Token: 0x0600F5AF RID: 62895 RVA: 0x0007425E File Offset: 0x0007245E
			public unsafe float _counter_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__counter_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__counter_5__3)) = value;
				}
			}

			// Token: 0x0400A630 RID: 42544
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A631 RID: 42545
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A632 RID: 42546
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A633 RID: 42547
			private static readonly IntPtr NativeFieldInfoPtr__shopResponse_5__2;

			// Token: 0x0400A634 RID: 42548
			private static readonly IntPtr NativeFieldInfoPtr__counter_5__3;

			// Token: 0x0400A635 RID: 42549
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A636 RID: 42550
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A637 RID: 42551
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A638 RID: 42552
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A639 RID: 42553
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A63A RID: 42554
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
