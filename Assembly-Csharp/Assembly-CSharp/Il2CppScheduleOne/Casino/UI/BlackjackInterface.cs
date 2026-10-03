using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Casino.UI
{
	// Token: 0x02000437 RID: 1079
	public class BlackjackInterface : Singleton<BlackjackInterface>
	{
		// Token: 0x0600608B RID: 24715 RVA: 0x001C9B94 File Offset: 0x001C7D94
		// Note: this type is marked as 'beforefieldinit'.
		static BlackjackInterface()
		{
			Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino.UI", "BlackjackInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr);
			BlackjackInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "<CurrentGame>k__BackingField");
			BlackjackInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "Canvas");
			BlackjackInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "Container");
			BlackjackInterface.NativeFieldInfoPtr_PlayerDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "PlayerDisplay");
			BlackjackInterface.NativeFieldInfoPtr_WaitingContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "WaitingContainer");
			BlackjackInterface.NativeFieldInfoPtr_WaitingLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "WaitingLabel");
			BlackjackInterface.NativeFieldInfoPtr_DealerScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "DealerScoreLabel");
			BlackjackInterface.NativeFieldInfoPtr_PlayerScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "PlayerScoreLabel");
			BlackjackInterface.NativeFieldInfoPtr_InputPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "InputPanel");
			BlackjackInterface.NativeFieldInfoPtr_HitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "HitButton");
			BlackjackInterface.NativeFieldInfoPtr_StandButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "StandButton");
			BlackjackInterface.NativeFieldInfoPtr_InputContainerAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "InputContainerAnimation");
			BlackjackInterface.NativeFieldInfoPtr_InputContainerCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "InputContainerCanvasGroup");
			BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "InputContainerFadeIn");
			BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "InputContainerFadeOut");
			BlackjackInterface.NativeFieldInfoPtr_SelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "SelectionIndicator");
			BlackjackInterface.NativeFieldInfoPtr_ScoresContainerAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "ScoresContainerAnimation");
			BlackjackInterface.NativeFieldInfoPtr_ScoresContainerCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "ScoresContainerCanvasGroup");
			BlackjackInterface.NativeFieldInfoPtr_PositiveOutcomeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "PositiveOutcomeLabel");
			BlackjackInterface.NativeFieldInfoPtr_PayoutLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "PayoutLabel");
			BlackjackInterface.NativeFieldInfoPtr_BetPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "BetPanel");
			BlackjackInterface.NativeFieldInfoPtr_UIScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "UIScreen");
			BlackjackInterface.NativeFieldInfoPtr_onBust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "onBust");
			BlackjackInterface.NativeFieldInfoPtr_onBlackjack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "onBlackjack");
			BlackjackInterface.NativeFieldInfoPtr_onWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "onWin");
			BlackjackInterface.NativeFieldInfoPtr_onLose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "onLose");
			BlackjackInterface.NativeFieldInfoPtr_onPush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "onPush");
			BlackjackInterface.NativeMethodInfoPtr_get_CurrentGame_Public_get_BlackjackGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676002);
			BlackjackInterface.NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_BlackjackGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676003);
			BlackjackInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676004);
			BlackjackInterface.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676005);
			BlackjackInterface.NativeMethodInfoPtr_Open_Public_Void_BlackjackGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676006);
			BlackjackInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676007);
			BlackjackInterface.NativeMethodInfoPtr_LocalPlayerReadyForInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676008);
			BlackjackInterface.NativeMethodInfoPtr_ShowScores_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676009);
			BlackjackInterface.NativeMethodInfoPtr_HideScores_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676010);
			BlackjackInterface.NativeMethodInfoPtr_HitClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676011);
			BlackjackInterface.NativeMethodInfoPtr_StandClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676012);
			BlackjackInterface.NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676013);
			BlackjackInterface.NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676014);
			BlackjackInterface.NativeMethodInfoPtr_OnLocalPlayerBust_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676015);
			BlackjackInterface.NativeMethodInfoPtr_OnLocalPlayerRoundCompleted_Private_Void_EPayoutType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676016);
			BlackjackInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676017);
		}

		// Token: 0x17001DC7 RID: 7623
		// (get) Token: 0x0600608C RID: 24716 RVA: 0x001C9F20 File Offset: 0x001C8120
		// (set) Token: 0x0600608D RID: 24717 RVA: 0x001C9F60 File Offset: 0x001C8160
		public unsafe BlackjackGameController CurrentGame
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_get_CurrentGame_Public_get_BlackjackGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BlackjackGameController>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_BlackjackGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600608E RID: 24718 RVA: 0x001C9FA4 File Offset: 0x001C81A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205374, XrefRangeEnd = 205397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600608F RID: 24719 RVA: 0x001C9FE0 File Offset: 0x001C81E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205397, XrefRangeEnd = 205424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006090 RID: 24720 RVA: 0x001CA014 File Offset: 0x001C8214
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205500, RefRangeEnd = 205501, XrefRangeStart = 205424, XrefRangeEnd = 205500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(BlackjackGameController game)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(game);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_Open_Public_Void_BlackjackGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006091 RID: 24721 RVA: 0x001CA058 File Offset: 0x001C8258
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205581, RefRangeEnd = 205582, XrefRangeStart = 205501, XrefRangeEnd = 205581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006092 RID: 24722 RVA: 0x001CA08C File Offset: 0x001C828C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205582, XrefRangeEnd = 205592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalPlayerReadyForInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_LocalPlayerReadyForInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006093 RID: 24723 RVA: 0x001CA0C0 File Offset: 0x001C82C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205592, XrefRangeEnd = 205595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowScores()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_ShowScores_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006094 RID: 24724 RVA: 0x001CA0F4 File Offset: 0x001C82F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205595, XrefRangeEnd = 205598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideScores()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_HideScores_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006095 RID: 24725 RVA: 0x001CA128 File Offset: 0x001C8328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205598, XrefRangeEnd = 205614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HitClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_HitClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006096 RID: 24726 RVA: 0x001CA15C File Offset: 0x001C835C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205614, XrefRangeEnd = 205630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StandClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_StandClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006097 RID: 24727 RVA: 0x001CA190 File Offset: 0x001C8390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205630, XrefRangeEnd = 205636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalPlayerExitRound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006098 RID: 24728 RVA: 0x001CA1C4 File Offset: 0x001C83C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205636, XrefRangeEnd = 205637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadyButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006099 RID: 24729 RVA: 0x001CA1F8 File Offset: 0x001C83F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205637, XrefRangeEnd = 205638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLocalPlayerBust()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_OnLocalPlayerBust_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600609A RID: 24730 RVA: 0x001CA22C File Offset: 0x001C842C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205638, XrefRangeEnd = 205646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLocalPlayerRoundCompleted(BlackjackGameController.EPayoutType payout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref payout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_OnLocalPlayerRoundCompleted_Private_Void_EPayoutType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600609B RID: 24731 RVA: 0x001CA26C File Offset: 0x001C846C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205646, XrefRangeEnd = 205649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlackjackInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600609C RID: 24732 RVA: 0x0002D8AD File Offset: 0x0002BAAD
		public BlackjackInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DAC RID: 7596
		// (get) Token: 0x0600609D RID: 24733 RVA: 0x001CA2A8 File Offset: 0x001C84A8
		// (set) Token: 0x0600609E RID: 24734 RVA: 0x0002D8B6 File Offset: 0x0002BAB6
		public unsafe BlackjackGameController _CurrentGame_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DAD RID: 7597
		// (get) Token: 0x0600609F RID: 24735 RVA: 0x001CA2D8 File Offset: 0x001C84D8
		// (set) Token: 0x060060A0 RID: 24736 RVA: 0x0002D8D5 File Offset: 0x0002BAD5
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DAE RID: 7598
		// (get) Token: 0x060060A1 RID: 24737 RVA: 0x001CA308 File Offset: 0x001C8508
		// (set) Token: 0x060060A2 RID: 24738 RVA: 0x0002D8F4 File Offset: 0x0002BAF4
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DAF RID: 7599
		// (get) Token: 0x060060A3 RID: 24739 RVA: 0x001CA338 File Offset: 0x001C8538
		// (set) Token: 0x060060A4 RID: 24740 RVA: 0x0002D913 File Offset: 0x0002BB13
		public unsafe CasinoGamePlayerDisplay PlayerDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PlayerDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PlayerDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DB0 RID: 7600
		// (get) Token: 0x060060A5 RID: 24741 RVA: 0x001CA368 File Offset: 0x001C8568
		// (set) Token: 0x060060A6 RID: 24742 RVA: 0x0002D932 File Offset: 0x0002BB32
		public unsafe RectTransform WaitingContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_WaitingContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_WaitingContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DB1 RID: 7601
		// (get) Token: 0x060060A7 RID: 24743 RVA: 0x001CA398 File Offset: 0x001C8598
		// (set) Token: 0x060060A8 RID: 24744 RVA: 0x0002D951 File Offset: 0x0002BB51
		public unsafe TextMeshProUGUI WaitingLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_WaitingLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_WaitingLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DB2 RID: 7602
		// (get) Token: 0x060060A9 RID: 24745 RVA: 0x001CA3C8 File Offset: 0x001C85C8
		// (set) Token: 0x060060AA RID: 24746 RVA: 0x0002D970 File Offset: 0x0002BB70
		public unsafe TextMeshProUGUI DealerScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_DealerScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_DealerScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DB3 RID: 7603
		// (get) Token: 0x060060AB RID: 24747 RVA: 0x001CA3F8 File Offset: 0x001C85F8
		// (set) Token: 0x060060AC RID: 24748 RVA: 0x0002D98F File Offset: 0x0002BB8F
		public unsafe TextMeshProUGUI PlayerScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PlayerScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PlayerScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DB4 RID: 7604
		// (get) Token: 0x060060AD RID: 24749 RVA: 0x001CA428 File Offset: 0x001C8628
		// (set) Token: 0x060060AE RID: 24750 RVA: 0x0002D9AE File Offset: 0x0002BBAE
		public unsafe UIPanel InputPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DB5 RID: 7605
		// (get) Token: 0x060060AF RID: 24751 RVA: 0x001CA458 File Offset: 0x001C8658
		// (set) Token: 0x060060B0 RID: 24752 RVA: 0x0002D9CD File Offset: 0x0002BBCD
		public unsafe Button HitButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_HitButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_HitButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DB6 RID: 7606
		// (get) Token: 0x060060B1 RID: 24753 RVA: 0x001CA488 File Offset: 0x001C8688
		// (set) Token: 0x060060B2 RID: 24754 RVA: 0x0002D9EC File Offset: 0x0002BBEC
		public unsafe Button StandButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_StandButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_StandButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DB7 RID: 7607
		// (get) Token: 0x060060B3 RID: 24755 RVA: 0x001CA4B8 File Offset: 0x001C86B8
		// (set) Token: 0x060060B4 RID: 24756 RVA: 0x0002DA0B File Offset: 0x0002BC0B
		public unsafe Animation InputContainerAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DB8 RID: 7608
		// (get) Token: 0x060060B5 RID: 24757 RVA: 0x001CA4E8 File Offset: 0x001C86E8
		// (set) Token: 0x060060B6 RID: 24758 RVA: 0x0002DA2A File Offset: 0x0002BC2A
		public unsafe CanvasGroup InputContainerCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DB9 RID: 7609
		// (get) Token: 0x060060B7 RID: 24759 RVA: 0x001CA518 File Offset: 0x001C8718
		// (set) Token: 0x060060B8 RID: 24760 RVA: 0x0002DA49 File Offset: 0x0002BC49
		public unsafe AnimationClip InputContainerFadeIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DBA RID: 7610
		// (get) Token: 0x060060B9 RID: 24761 RVA: 0x001CA548 File Offset: 0x001C8748
		// (set) Token: 0x060060BA RID: 24762 RVA: 0x0002DA68 File Offset: 0x0002BC68
		public unsafe AnimationClip InputContainerFadeOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeOut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeOut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DBB RID: 7611
		// (get) Token: 0x060060BB RID: 24763 RVA: 0x001CA578 File Offset: 0x001C8778
		// (set) Token: 0x060060BC RID: 24764 RVA: 0x0002DA87 File Offset: 0x0002BC87
		public unsafe RectTransform SelectionIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_SelectionIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_SelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DBC RID: 7612
		// (get) Token: 0x060060BD RID: 24765 RVA: 0x001CA5A8 File Offset: 0x001C87A8
		// (set) Token: 0x060060BE RID: 24766 RVA: 0x0002DAA6 File Offset: 0x0002BCA6
		public unsafe Animation ScoresContainerAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ScoresContainerAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ScoresContainerAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DBD RID: 7613
		// (get) Token: 0x060060BF RID: 24767 RVA: 0x001CA5D8 File Offset: 0x001C87D8
		// (set) Token: 0x060060C0 RID: 24768 RVA: 0x0002DAC5 File Offset: 0x0002BCC5
		public unsafe CanvasGroup ScoresContainerCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ScoresContainerCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ScoresContainerCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DBE RID: 7614
		// (get) Token: 0x060060C1 RID: 24769 RVA: 0x001CA608 File Offset: 0x001C8808
		// (set) Token: 0x060060C2 RID: 24770 RVA: 0x0002DAE4 File Offset: 0x0002BCE4
		public unsafe TextMeshProUGUI PositiveOutcomeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PositiveOutcomeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PositiveOutcomeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DBF RID: 7615
		// (get) Token: 0x060060C3 RID: 24771 RVA: 0x001CA638 File Offset: 0x001C8838
		// (set) Token: 0x060060C4 RID: 24772 RVA: 0x0002DB03 File Offset: 0x0002BD03
		public unsafe TextMeshProUGUI PayoutLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PayoutLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PayoutLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC0 RID: 7616
		// (get) Token: 0x060060C5 RID: 24773 RVA: 0x001CA668 File Offset: 0x001C8868
		// (set) Token: 0x060060C6 RID: 24774 RVA: 0x0002DB22 File Offset: 0x0002BD22
		public unsafe CasinoGameBetPanel BetPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGameBetPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC1 RID: 7617
		// (get) Token: 0x060060C7 RID: 24775 RVA: 0x001CA698 File Offset: 0x001C8898
		// (set) Token: 0x060060C8 RID: 24776 RVA: 0x0002DB41 File Offset: 0x0002BD41
		public unsafe UIScreen UIScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_UIScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_UIScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC2 RID: 7618
		// (get) Token: 0x060060C9 RID: 24777 RVA: 0x001CA6C8 File Offset: 0x001C88C8
		// (set) Token: 0x060060CA RID: 24778 RVA: 0x0002DB60 File Offset: 0x0002BD60
		public unsafe UnityEvent onBust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onBust);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onBust), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC3 RID: 7619
		// (get) Token: 0x060060CB RID: 24779 RVA: 0x001CA6F8 File Offset: 0x001C88F8
		// (set) Token: 0x060060CC RID: 24780 RVA: 0x0002DB7F File Offset: 0x0002BD7F
		public unsafe UnityEvent onBlackjack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onBlackjack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onBlackjack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC4 RID: 7620
		// (get) Token: 0x060060CD RID: 24781 RVA: 0x001CA728 File Offset: 0x001C8928
		// (set) Token: 0x060060CE RID: 24782 RVA: 0x0002DB9E File Offset: 0x0002BD9E
		public unsafe UnityEvent onWin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onWin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onWin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC5 RID: 7621
		// (get) Token: 0x060060CF RID: 24783 RVA: 0x001CA758 File Offset: 0x001C8958
		// (set) Token: 0x060060D0 RID: 24784 RVA: 0x0002DBBD File Offset: 0x0002BDBD
		public unsafe UnityEvent onLose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onLose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onLose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC6 RID: 7622
		// (get) Token: 0x060060D1 RID: 24785 RVA: 0x001CA788 File Offset: 0x001C8988
		// (set) Token: 0x060060D2 RID: 24786 RVA: 0x0002DBDC File Offset: 0x0002BDDC
		public unsafe UnityEvent onPush
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onPush);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onPush), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400428D RID: 17037
		private static readonly IntPtr NativeFieldInfoPtr__CurrentGame_k__BackingField;

		// Token: 0x0400428E RID: 17038
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400428F RID: 17039
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04004290 RID: 17040
		private static readonly IntPtr NativeFieldInfoPtr_PlayerDisplay;

		// Token: 0x04004291 RID: 17041
		private static readonly IntPtr NativeFieldInfoPtr_WaitingContainer;

		// Token: 0x04004292 RID: 17042
		private static readonly IntPtr NativeFieldInfoPtr_WaitingLabel;

		// Token: 0x04004293 RID: 17043
		private static readonly IntPtr NativeFieldInfoPtr_DealerScoreLabel;

		// Token: 0x04004294 RID: 17044
		private static readonly IntPtr NativeFieldInfoPtr_PlayerScoreLabel;

		// Token: 0x04004295 RID: 17045
		private static readonly IntPtr NativeFieldInfoPtr_InputPanel;

		// Token: 0x04004296 RID: 17046
		private static readonly IntPtr NativeFieldInfoPtr_HitButton;

		// Token: 0x04004297 RID: 17047
		private static readonly IntPtr NativeFieldInfoPtr_StandButton;

		// Token: 0x04004298 RID: 17048
		private static readonly IntPtr NativeFieldInfoPtr_InputContainerAnimation;

		// Token: 0x04004299 RID: 17049
		private static readonly IntPtr NativeFieldInfoPtr_InputContainerCanvasGroup;

		// Token: 0x0400429A RID: 17050
		private static readonly IntPtr NativeFieldInfoPtr_InputContainerFadeIn;

		// Token: 0x0400429B RID: 17051
		private static readonly IntPtr NativeFieldInfoPtr_InputContainerFadeOut;

		// Token: 0x0400429C RID: 17052
		private static readonly IntPtr NativeFieldInfoPtr_SelectionIndicator;

		// Token: 0x0400429D RID: 17053
		private static readonly IntPtr NativeFieldInfoPtr_ScoresContainerAnimation;

		// Token: 0x0400429E RID: 17054
		private static readonly IntPtr NativeFieldInfoPtr_ScoresContainerCanvasGroup;

		// Token: 0x0400429F RID: 17055
		private static readonly IntPtr NativeFieldInfoPtr_PositiveOutcomeLabel;

		// Token: 0x040042A0 RID: 17056
		private static readonly IntPtr NativeFieldInfoPtr_PayoutLabel;

		// Token: 0x040042A1 RID: 17057
		private static readonly IntPtr NativeFieldInfoPtr_BetPanel;

		// Token: 0x040042A2 RID: 17058
		private static readonly IntPtr NativeFieldInfoPtr_UIScreen;

		// Token: 0x040042A3 RID: 17059
		private static readonly IntPtr NativeFieldInfoPtr_onBust;

		// Token: 0x040042A4 RID: 17060
		private static readonly IntPtr NativeFieldInfoPtr_onBlackjack;

		// Token: 0x040042A5 RID: 17061
		private static readonly IntPtr NativeFieldInfoPtr_onWin;

		// Token: 0x040042A6 RID: 17062
		private static readonly IntPtr NativeFieldInfoPtr_onLose;

		// Token: 0x040042A7 RID: 17063
		private static readonly IntPtr NativeFieldInfoPtr_onPush;

		// Token: 0x040042A8 RID: 17064
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentGame_Public_get_BlackjackGameController_0;

		// Token: 0x040042A9 RID: 17065
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_BlackjackGameController_0;

		// Token: 0x040042AA RID: 17066
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040042AB RID: 17067
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040042AC RID: 17068
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_BlackjackGameController_0;

		// Token: 0x040042AD RID: 17069
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040042AE RID: 17070
		private static readonly IntPtr NativeMethodInfoPtr_LocalPlayerReadyForInput_Private_Void_0;

		// Token: 0x040042AF RID: 17071
		private static readonly IntPtr NativeMethodInfoPtr_ShowScores_Private_Void_0;

		// Token: 0x040042B0 RID: 17072
		private static readonly IntPtr NativeMethodInfoPtr_HideScores_Private_Void_0;

		// Token: 0x040042B1 RID: 17073
		private static readonly IntPtr NativeMethodInfoPtr_HitClicked_Private_Void_0;

		// Token: 0x040042B2 RID: 17074
		private static readonly IntPtr NativeMethodInfoPtr_StandClicked_Private_Void_0;

		// Token: 0x040042B3 RID: 17075
		private static readonly IntPtr NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0;

		// Token: 0x040042B4 RID: 17076
		private static readonly IntPtr NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0;

		// Token: 0x040042B5 RID: 17077
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalPlayerBust_Private_Void_0;

		// Token: 0x040042B6 RID: 17078
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalPlayerRoundCompleted_Private_Void_EPayoutType_0;

		// Token: 0x040042B7 RID: 17079
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
