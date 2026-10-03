using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x0200042D RID: 1069
	public class BlackjackGameController : CasinoGameController
	{
		// Token: 0x06005DFF RID: 24063 RVA: 0x001BF7C8 File Offset: 0x001BD9C8
		// Note: this type is marked as 'beforefieldinit'.
		static BlackjackGameController()
		{
			Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "BlackjackGameController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr);
			BlackjackGameController.NativeFieldInfoPtr_MinimumBet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "MinimumBet");
			BlackjackGameController.NativeFieldInfoPtr_MaximumBet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "MaximumBet");
			BlackjackGameController.NativeFieldInfoPtr_PayoutRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "PayoutRatio");
			BlackjackGameController.NativeFieldInfoPtr_BlackjackPayoutRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "BlackjackPayoutRatio");
			BlackjackGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<CurrentStage>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr__PlayerTurn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<PlayerTurn>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr__DealerScore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<DealerScore>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr__LocalPlayerScore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<LocalPlayerScore>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBlackjack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<IsLocalPlayerBlackjack>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBust_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<IsLocalPlayerBust>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr_Cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "Cards");
			BlackjackGameController.NativeFieldInfoPtr_DefaultCardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "DefaultCardPositions");
			BlackjackGameController.NativeFieldInfoPtr_FocusedCameraTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "FocusedCameraTransforms");
			BlackjackGameController.NativeFieldInfoPtr_FinalCameraTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "FinalCameraTransforms");
			BlackjackGameController.NativeFieldInfoPtr_Player1CardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "Player1CardPositions");
			BlackjackGameController.NativeFieldInfoPtr_Player2CardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "Player2CardPositions");
			BlackjackGameController.NativeFieldInfoPtr_Player3CardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "Player3CardPositions");
			BlackjackGameController.NativeFieldInfoPtr_Player4CardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "Player4CardPositions");
			BlackjackGameController.NativeFieldInfoPtr_DealerCardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "DealerCardPositions");
			BlackjackGameController.NativeFieldInfoPtr_playersInCurrentRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "playersInCurrentRound");
			BlackjackGameController.NativeFieldInfoPtr_playStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "playStack");
			BlackjackGameController.NativeFieldInfoPtr_player1Hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "player1Hand");
			BlackjackGameController.NativeFieldInfoPtr_player2Hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "player2Hand");
			BlackjackGameController.NativeFieldInfoPtr_player3Hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "player3Hand");
			BlackjackGameController.NativeFieldInfoPtr_player4Hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "player4Hand");
			BlackjackGameController.NativeFieldInfoPtr_dealerHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "dealerHand");
			BlackjackGameController.NativeFieldInfoPtr_cardValuesInDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "cardValuesInDeck");
			BlackjackGameController.NativeFieldInfoPtr_drawnCardsValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "drawnCardsValues");
			BlackjackGameController.NativeFieldInfoPtr_localFocusCameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "localFocusCameraTransform");
			BlackjackGameController.NativeFieldInfoPtr_localFinalCameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "localFinalCameraTransform");
			BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerExitRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "onLocalPlayerExitRound");
			BlackjackGameController.NativeFieldInfoPtr_onInitialCardsDealt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "onInitialCardsDealt");
			BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerReadyForInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "onLocalPlayerReadyForInput");
			BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerBust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "onLocalPlayerBust");
			BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerRoundCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "onLocalPlayerRoundCompleted");
			BlackjackGameController.NativeFieldInfoPtr_roundEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "roundEnded");
			BlackjackGameController.NativeFieldInfoPtr_gameRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "gameRoutine");
			BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Casino.BlackjackGameControllerAssembly-CSharp.dll_Excuted");
			BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Casino.BlackjackGameControllerAssembly-CSharp.dll_Excuted");
			BlackjackGameController.NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675589);
			BlackjackGameController.NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675590);
			BlackjackGameController.NativeMethodInfoPtr_get_PlayerTurn_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675591);
			BlackjackGameController.NativeMethodInfoPtr_set_PlayerTurn_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675592);
			BlackjackGameController.NativeMethodInfoPtr_get_DealerScore_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675593);
			BlackjackGameController.NativeMethodInfoPtr_set_DealerScore_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675594);
			BlackjackGameController.NativeMethodInfoPtr_get_LocalPlayerScore_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675595);
			BlackjackGameController.NativeMethodInfoPtr_set_LocalPlayerScore_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675596);
			BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerBlackjack_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675597);
			BlackjackGameController.NativeMethodInfoPtr_set_IsLocalPlayerBlackjack_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675598);
			BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerBust_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675599);
			BlackjackGameController.NativeMethodInfoPtr_set_IsLocalPlayerBust_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675600);
			BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675601);
			BlackjackGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675602);
			BlackjackGameController.NativeMethodInfoPtr_Open_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675603);
			BlackjackGameController.NativeMethodInfoPtr_OnClose_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675604);
			BlackjackGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675605);
			BlackjackGameController.NativeMethodInfoPtr_GetClockwisePlayers_Private_List_1_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675606);
			BlackjackGameController.NativeMethodInfoPtr_StartGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675607);
			BlackjackGameController.NativeMethodInfoPtr_NotifyPlayerScore_Private_Void_NetworkObject_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675608);
			BlackjackGameController.NativeMethodInfoPtr_GetPlayerCardPositions_Private_Il2CppReferenceArray_1_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675609);
			BlackjackGameController.NativeMethodInfoPtr_SetRoundEnded_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675610);
			BlackjackGameController.NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_PlayingCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675611);
			BlackjackGameController.NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675612);
			BlackjackGameController.NativeMethodInfoPtr_AddCardToDealerHand_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675613);
			BlackjackGameController.NativeMethodInfoPtr_GetPlayerCards_Private_List_1_PlayingCard_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675614);
			BlackjackGameController.NativeMethodInfoPtr_GetHandScore_Private_Int32_List_1_PlayingCard_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675615);
			BlackjackGameController.NativeMethodInfoPtr_IsWaitingForPlayers_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675616);
			BlackjackGameController.NativeMethodInfoPtr_GetBetLimits_Public_Virtual_Void_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675617);
			BlackjackGameController.NativeMethodInfoPtr_GetCardValue_Private_Int32_PlayingCard_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675618);
			BlackjackGameController.NativeMethodInfoPtr_DrawCard_Private_PlayingCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675619);
			BlackjackGameController.NativeMethodInfoPtr_ResetCards_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675620);
			BlackjackGameController.NativeMethodInfoPtr_EndGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675621);
			BlackjackGameController.NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_EPayoutType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675622);
			BlackjackGameController.NativeMethodInfoPtr_GetPayout_Public_Single_Single_EPayoutType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675623);
			BlackjackGameController.NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675624);
			BlackjackGameController.NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675625);
			BlackjackGameController.NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675626);
			BlackjackGameController.NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675627);
			BlackjackGameController.NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675628);
			BlackjackGameController.NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675629);
			BlackjackGameController.NativeMethodInfoPtr_TryStartGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675630);
			BlackjackGameController.NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675631);
			BlackjackGameController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675632);
			BlackjackGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675633);
			BlackjackGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675634);
			BlackjackGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675635);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_StartGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675636);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___StartGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675637);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_StartGame_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675638);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675639);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675640);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_NotifyPlayerScore_2864061566_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675641);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetRoundEnded_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675642);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___SetRoundEnded_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675643);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_SetRoundEnded_1140765316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675644);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675645);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675646);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddCardToPlayerHand_2801973956_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675647);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddCardToDealerHand_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675648);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddCardToDealerHand_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675649);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddCardToDealerHand_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675650);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675651);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675652);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675653);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675654);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675655);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675656);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675657);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675658);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675659);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675660);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675661);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675662);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Server_TryStartGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675663);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___TryStartGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675664);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Server_TryStartGame_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675665);
			BlackjackGameController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100675666);
		}

		// Token: 0x17001D29 RID: 7465
		// (get) Token: 0x06005E00 RID: 24064 RVA: 0x001C011C File Offset: 0x001BE31C
		// (set) Token: 0x06005E01 RID: 24065 RVA: 0x001C0158 File Offset: 0x001BE358
		public unsafe BlackjackGameController.EStage CurrentStage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D2A RID: 7466
		// (get) Token: 0x06005E02 RID: 24066 RVA: 0x001C0198 File Offset: 0x001BE398
		// (set) Token: 0x06005E03 RID: 24067 RVA: 0x001C01D8 File Offset: 0x001BE3D8
		public unsafe Player PlayerTurn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_PlayerTurn_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_PlayerTurn_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D2B RID: 7467
		// (get) Token: 0x06005E04 RID: 24068 RVA: 0x001C021C File Offset: 0x001BE41C
		// (set) Token: 0x06005E05 RID: 24069 RVA: 0x001C0258 File Offset: 0x001BE458
		public unsafe int DealerScore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_DealerScore_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_DealerScore_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D2C RID: 7468
		// (get) Token: 0x06005E06 RID: 24070 RVA: 0x001C0298 File Offset: 0x001BE498
		// (set) Token: 0x06005E07 RID: 24071 RVA: 0x001C02D4 File Offset: 0x001BE4D4
		public unsafe int LocalPlayerScore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_LocalPlayerScore_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_LocalPlayerScore_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D2D RID: 7469
		// (get) Token: 0x06005E08 RID: 24072 RVA: 0x001C0314 File Offset: 0x001BE514
		// (set) Token: 0x06005E09 RID: 24073 RVA: 0x001C0350 File Offset: 0x001BE550
		public unsafe bool IsLocalPlayerBlackjack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerBlackjack_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_IsLocalPlayerBlackjack_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D2E RID: 7470
		// (get) Token: 0x06005E0A RID: 24074 RVA: 0x001C0390 File Offset: 0x001BE590
		// (set) Token: 0x06005E0B RID: 24075 RVA: 0x001C03CC File Offset: 0x001BE5CC
		public unsafe bool IsLocalPlayerBust
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerBust_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_IsLocalPlayerBust_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D2F RID: 7471
		// (get) Token: 0x06005E0C RID: 24076 RVA: 0x001C040C File Offset: 0x001BE60C
		public unsafe bool IsLocalPlayerInCurrentRound
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 200836, RefRangeEnd = 200840, XrefRangeStart = 200828, XrefRangeEnd = 200836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005E0D RID: 24077 RVA: 0x001C0448 File Offset: 0x001BE648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200840, XrefRangeEnd = 200842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E0E RID: 24078 RVA: 0x001C0484 File Offset: 0x001BE684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200842, XrefRangeEnd = 200863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_Open_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E0F RID: 24079 RVA: 0x001C04C0 File Offset: 0x001BE6C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200863, XrefRangeEnd = 200872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_OnClose_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E10 RID: 24080 RVA: 0x001C04FC File Offset: 0x001BE6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200872, XrefRangeEnd = 200879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E11 RID: 24081 RVA: 0x001C054C File Offset: 0x001BE74C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 200911, RefRangeEnd = 200913, XrefRangeStart = 200879, XrefRangeEnd = 200911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Player> GetClockwisePlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetClockwisePlayers_Private_List_1_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr3) : null;
		}

		// Token: 0x06005E12 RID: 24082 RVA: 0x001C058C File Offset: 0x001BE78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200913, XrefRangeEnd = 200934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_StartGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E13 RID: 24083 RVA: 0x001C05C0 File Offset: 0x001BE7C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 200959, RefRangeEnd = 200961, XrefRangeStart = 200934, XrefRangeEnd = 200959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyPlayerScore(NetworkObject player, int score, bool blackjack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blackjack;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_NotifyPlayerScore_Private_Void_NetworkObject_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E14 RID: 24084 RVA: 0x001C0620 File Offset: 0x001BE820
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 200961, RefRangeEnd = 200964, XrefRangeStart = 200961, XrefRangeEnd = 200961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Transform> GetPlayerCardPositions(int playerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetPlayerCardPositions_Private_Il2CppReferenceArray_1_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr3) : null;
		}

		// Token: 0x06005E15 RID: 24085 RVA: 0x001C066C File Offset: 0x001BE86C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200984, RefRangeEnd = 200985, XrefRangeStart = 200964, XrefRangeEnd = 200984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRoundEnded(bool ended)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ended;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_SetRoundEnded_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E16 RID: 24086 RVA: 0x001C06AC File Offset: 0x001BE8AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 201009, RefRangeEnd = 201012, XrefRangeStart = 200985, XrefRangeEnd = 201009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCardToPlayerHand(int playerIndex, PlayingCard card)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playerIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(card);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_PlayingCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E17 RID: 24087 RVA: 0x001C06FC File Offset: 0x001BE8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201012, XrefRangeEnd = 201036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCardToPlayerHand(int playerindex, string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playerindex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cardID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E18 RID: 24088 RVA: 0x001C074C File Offset: 0x001BE94C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 201058, RefRangeEnd = 201060, XrefRangeStart = 201036, XrefRangeEnd = 201058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCardToDealerHand(string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_AddCardToDealerHand_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E19 RID: 24089 RVA: 0x001C0790 File Offset: 0x001BE990
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 201060, RefRangeEnd = 201061, XrefRangeStart = 201060, XrefRangeEnd = 201060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<PlayingCard> GetPlayerCards(int playerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetPlayerCards_Private_List_1_PlayingCard_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr3) : null;
		}

		// Token: 0x06005E1A RID: 24090 RVA: 0x001C07DC File Offset: 0x001BE9DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 201089, RefRangeEnd = 201092, XrefRangeStart = 201061, XrefRangeEnd = 201089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetHandScore(List<PlayingCard> cards, bool countFaceDown = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cards);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref countFaceDown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetHandScore_Private_Int32_List_1_PlayingCard_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E1B RID: 24091 RVA: 0x001C0838 File Offset: 0x001BEA38
		[CallerCount(0)]
		public unsafe override bool IsWaitingForPlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_IsWaitingForPlayers_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E1C RID: 24092 RVA: 0x001C0880 File Offset: 0x001BEA80
		[CallerCount(0)]
		public unsafe override void GetBetLimits(out float minimum, out float maximum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &minimum;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maximum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_GetBetLimits_Public_Virtual_Void_byref_Single_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E1D RID: 24093 RVA: 0x001C08D8 File Offset: 0x001BEAD8
		[CallerCount(0)]
		public unsafe int GetCardValue(PlayingCard card, bool aceAsEleven = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aceAsEleven;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetCardValue_Private_Int32_PlayingCard_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E1E RID: 24094 RVA: 0x001C0934 File Offset: 0x001BEB34
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 201111, RefRangeEnd = 201116, XrefRangeStart = 201092, XrefRangeEnd = 201111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayingCard DrawCard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_DrawCard_Private_PlayingCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayingCard>(intPtr3) : null;
		}

		// Token: 0x06005E1F RID: 24095 RVA: 0x001C0974 File Offset: 0x001BEB74
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 201149, RefRangeEnd = 201155, XrefRangeStart = 201116, XrefRangeEnd = 201149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCards()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_ResetCards_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E20 RID: 24096 RVA: 0x001C09A8 File Offset: 0x001BEBA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 201177, RefRangeEnd = 201178, XrefRangeStart = 201155, XrefRangeEnd = 201177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_EndGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E21 RID: 24097 RVA: 0x001C09DC File Offset: 0x001BEBDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 201224, RefRangeEnd = 201227, XrefRangeStart = 201178, XrefRangeEnd = 201224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveLocalPlayerFromGame(BlackjackGameController.EPayoutType payout, float cameraDelay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref payout;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_EPayoutType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E22 RID: 24098 RVA: 0x001C0A28 File Offset: 0x001BEC28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 201227, RefRangeEnd = 201228, XrefRangeStart = 201227, XrefRangeEnd = 201227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPayout(float bet, BlackjackGameController.EPayoutType payout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bet;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref payout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetPayout_Public_Single_Single_EPayoutType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E23 RID: 24099 RVA: 0x001C0A80 File Offset: 0x001BEC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201228, XrefRangeEnd = 201229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCurrentRoundEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E24 RID: 24100 RVA: 0x001C0ABC File Offset: 0x001BECBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201229, XrefRangeEnd = 201251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayerToCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E25 RID: 24101 RVA: 0x001C0B00 File Offset: 0x001BED00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201251, XrefRangeEnd = 201273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestRemovePlayerFromCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E26 RID: 24102 RVA: 0x001C0B44 File Offset: 0x001BED44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 201295, RefRangeEnd = 201298, XrefRangeStart = 201273, XrefRangeEnd = 201295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePlayerFromCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E27 RID: 24103 RVA: 0x001C0B88 File Offset: 0x001BED88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201298, XrefRangeEnd = 201313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreAllPlayersReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E28 RID: 24104 RVA: 0x001C0BC4 File Offset: 0x001BEDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201313, XrefRangeEnd = 201326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPlayersReadyCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E29 RID: 24105 RVA: 0x001C0C00 File Offset: 0x001BEE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201326, XrefRangeEnd = 201347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryStartGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_TryStartGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E2A RID: 24106 RVA: 0x001C0C34 File Offset: 0x001BEE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201347, XrefRangeEnd = 201387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ToggleLocalPlayerReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E2B RID: 24107 RVA: 0x001C0C70 File Offset: 0x001BEE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201387, XrefRangeEnd = 201439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlackjackGameController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E2C RID: 24108 RVA: 0x001C0CAC File Offset: 0x001BEEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201439, XrefRangeEnd = 201501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E2D RID: 24109 RVA: 0x001C0CE8 File Offset: 0x001BEEE8
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E2E RID: 24110 RVA: 0x001C0D24 File Offset: 0x001BEF24
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E2F RID: 24111 RVA: 0x001C0D60 File Offset: 0x001BEF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201501, XrefRangeEnd = 201510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_StartGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E30 RID: 24112 RVA: 0x001C0D94 File Offset: 0x001BEF94
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 201570, RefRangeEnd = 201575, XrefRangeStart = 201510, XrefRangeEnd = 201570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___StartGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E31 RID: 24113 RVA: 0x001C0DC8 File Offset: 0x001BEFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201575, XrefRangeEnd = 201578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_StartGame_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E32 RID: 24114 RVA: 0x001C0E18 File Offset: 0x001BF018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201578, XrefRangeEnd = 201591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_NotifyPlayerScore_2864061566(NetworkObject player, int score, bool blackjack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blackjack;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E33 RID: 24115 RVA: 0x001C0E78 File Offset: 0x001BF078
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 201599, RefRangeEnd = 201601, XrefRangeStart = 201591, XrefRangeEnd = 201599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___NotifyPlayerScore_2864061566(NetworkObject player, int score, bool blackjack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blackjack;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E34 RID: 24116 RVA: 0x001C0ED8 File Offset: 0x001BF0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201601, XrefRangeEnd = 201607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_NotifyPlayerScore_2864061566(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_NotifyPlayerScore_2864061566_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E35 RID: 24117 RVA: 0x001C0F28 File Offset: 0x001BF128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201607, XrefRangeEnd = 201617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetRoundEnded_1140765316(bool ended)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ended;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetRoundEnded_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E36 RID: 24118 RVA: 0x001C0F68 File Offset: 0x001BF168
		[CallerCount(0)]
		public unsafe void RpcLogic___SetRoundEnded_1140765316(bool ended)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ended;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___SetRoundEnded_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E37 RID: 24119 RVA: 0x001C0FA8 File Offset: 0x001BF1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201617, XrefRangeEnd = 201619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetRoundEnded_1140765316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_SetRoundEnded_1140765316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E38 RID: 24120 RVA: 0x001C0FF8 File Offset: 0x001BF1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201619, XrefRangeEnd = 201631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddCardToPlayerHand_2801973956(int playerindex, string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playerindex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cardID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E39 RID: 24121 RVA: 0x001C1048 File Offset: 0x001BF248
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 201655, RefRangeEnd = 201658, XrefRangeStart = 201631, XrefRangeEnd = 201655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddCardToPlayerHand_2801973956(int playerindex, string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playerindex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cardID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E3A RID: 24122 RVA: 0x001C1098 File Offset: 0x001BF298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201658, XrefRangeEnd = 201664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddCardToPlayerHand_2801973956(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddCardToPlayerHand_2801973956_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E3B RID: 24123 RVA: 0x001C10E8 File Offset: 0x001BF2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201664, XrefRangeEnd = 201674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddCardToDealerHand_3615296227(string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddCardToDealerHand_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E3C RID: 24124 RVA: 0x001C112C File Offset: 0x001BF32C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 201698, RefRangeEnd = 201700, XrefRangeStart = 201674, XrefRangeEnd = 201698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddCardToDealerHand_3615296227(string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddCardToDealerHand_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E3D RID: 24125 RVA: 0x001C1170 File Offset: 0x001BF370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201700, XrefRangeEnd = 201704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddCardToDealerHand_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddCardToDealerHand_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E3E RID: 24126 RVA: 0x001C11C0 File Offset: 0x001BF3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201704, XrefRangeEnd = 201713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EndGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E3F RID: 24127 RVA: 0x001C11F4 File Offset: 0x001BF3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201713, XrefRangeEnd = 201715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___EndGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E40 RID: 24128 RVA: 0x001C1228 File Offset: 0x001BF428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201715, XrefRangeEnd = 201719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EndGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E41 RID: 24129 RVA: 0x001C1278 File Offset: 0x001BF478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201719, XrefRangeEnd = 201729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E42 RID: 24130 RVA: 0x001C12BC File Offset: 0x001BF4BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 201750, RefRangeEnd = 201753, XrefRangeStart = 201729, XrefRangeEnd = 201750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E43 RID: 24131 RVA: 0x001C1300 File Offset: 0x001BF500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201753, XrefRangeEnd = 201757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddPlayerToCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E44 RID: 24132 RVA: 0x001C1350 File Offset: 0x001BF550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201757, XrefRangeEnd = 201767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E45 RID: 24133 RVA: 0x001C1394 File Offset: 0x001BF594
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 201295, RefRangeEnd = 201298, XrefRangeStart = 201295, XrefRangeEnd = 201298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E46 RID: 24134 RVA: 0x001C13D8 File Offset: 0x001BF5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201767, XrefRangeEnd = 201771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E47 RID: 24135 RVA: 0x001C143C File Offset: 0x001BF63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201771, XrefRangeEnd = 201781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E48 RID: 24136 RVA: 0x001C1480 File Offset: 0x001BF680
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 201802, RefRangeEnd = 201805, XrefRangeStart = 201781, XrefRangeEnd = 201802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E49 RID: 24137 RVA: 0x001C14C4 File Offset: 0x001BF6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201805, XrefRangeEnd = 201809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E4A RID: 24138 RVA: 0x001C1514 File Offset: 0x001BF714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201809, XrefRangeEnd = 201818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_TryStartGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Server_TryStartGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E4B RID: 24139 RVA: 0x001C1548 File Offset: 0x001BF748
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 201879, RefRangeEnd = 201882, XrefRangeStart = 201818, XrefRangeEnd = 201879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___TryStartGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___TryStartGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E4C RID: 24140 RVA: 0x001C157C File Offset: 0x001BF77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201882, XrefRangeEnd = 201885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_TryStartGame_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Server_TryStartGame_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E4D RID: 24141 RVA: 0x001C15E0 File Offset: 0x001BF7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201885, XrefRangeEnd = 201887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E4E RID: 24142 RVA: 0x0002C84F File Offset: 0x0002AA4F
		public BlackjackGameController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D02 RID: 7426
		// (get) Token: 0x06005E4F RID: 24143 RVA: 0x001C161C File Offset: 0x001BF81C
		// (set) Token: 0x06005E50 RID: 24144 RVA: 0x0002C858 File Offset: 0x0002AA58
		public unsafe static int MinimumBet
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(BlackjackGameController.NativeFieldInfoPtr_MinimumBet, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BlackjackGameController.NativeFieldInfoPtr_MinimumBet, (void*)(&value));
			}
		}

		// Token: 0x17001D03 RID: 7427
		// (get) Token: 0x06005E51 RID: 24145 RVA: 0x001C1638 File Offset: 0x001BF838
		// (set) Token: 0x06005E52 RID: 24146 RVA: 0x0002C866 File Offset: 0x0002AA66
		public unsafe static int MaximumBet
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(BlackjackGameController.NativeFieldInfoPtr_MaximumBet, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BlackjackGameController.NativeFieldInfoPtr_MaximumBet, (void*)(&value));
			}
		}

		// Token: 0x17001D04 RID: 7428
		// (get) Token: 0x06005E53 RID: 24147 RVA: 0x001C1654 File Offset: 0x001BF854
		// (set) Token: 0x06005E54 RID: 24148 RVA: 0x0002C874 File Offset: 0x0002AA74
		public unsafe static float PayoutRatio
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BlackjackGameController.NativeFieldInfoPtr_PayoutRatio, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BlackjackGameController.NativeFieldInfoPtr_PayoutRatio, (void*)(&value));
			}
		}

		// Token: 0x17001D05 RID: 7429
		// (get) Token: 0x06005E55 RID: 24149 RVA: 0x001C1670 File Offset: 0x001BF870
		// (set) Token: 0x06005E56 RID: 24150 RVA: 0x0002C882 File Offset: 0x0002AA82
		public unsafe static float BlackjackPayoutRatio
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BlackjackGameController.NativeFieldInfoPtr_BlackjackPayoutRatio, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BlackjackGameController.NativeFieldInfoPtr_BlackjackPayoutRatio, (void*)(&value));
			}
		}

		// Token: 0x17001D06 RID: 7430
		// (get) Token: 0x06005E57 RID: 24151 RVA: 0x001C168C File Offset: 0x001BF88C
		// (set) Token: 0x06005E58 RID: 24152 RVA: 0x0002C890 File Offset: 0x0002AA90
		public unsafe BlackjackGameController.EStage _CurrentStage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D07 RID: 7431
		// (get) Token: 0x06005E59 RID: 24153 RVA: 0x001C16B4 File Offset: 0x001BF8B4
		// (set) Token: 0x06005E5A RID: 24154 RVA: 0x0002C8AB File Offset: 0x0002AAAB
		public unsafe Player _PlayerTurn_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__PlayerTurn_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__PlayerTurn_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D08 RID: 7432
		// (get) Token: 0x06005E5B RID: 24155 RVA: 0x001C16E4 File Offset: 0x001BF8E4
		// (set) Token: 0x06005E5C RID: 24156 RVA: 0x0002C8CA File Offset: 0x0002AACA
		public unsafe int _DealerScore_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__DealerScore_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__DealerScore_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D09 RID: 7433
		// (get) Token: 0x06005E5D RID: 24157 RVA: 0x001C170C File Offset: 0x001BF90C
		// (set) Token: 0x06005E5E RID: 24158 RVA: 0x0002C8E5 File Offset: 0x0002AAE5
		public unsafe int _LocalPlayerScore_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__LocalPlayerScore_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__LocalPlayerScore_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D0A RID: 7434
		// (get) Token: 0x06005E5F RID: 24159 RVA: 0x001C1734 File Offset: 0x001BF934
		// (set) Token: 0x06005E60 RID: 24160 RVA: 0x0002C900 File Offset: 0x0002AB00
		public unsafe bool _IsLocalPlayerBlackjack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBlackjack_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBlackjack_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D0B RID: 7435
		// (get) Token: 0x06005E61 RID: 24161 RVA: 0x001C175C File Offset: 0x001BF95C
		// (set) Token: 0x06005E62 RID: 24162 RVA: 0x0002C91B File Offset: 0x0002AB1B
		public unsafe bool _IsLocalPlayerBust_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBust_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBust_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D0C RID: 7436
		// (get) Token: 0x06005E63 RID: 24163 RVA: 0x001C1784 File Offset: 0x001BF984
		// (set) Token: 0x06005E64 RID: 24164 RVA: 0x0002C936 File Offset: 0x0002AB36
		public unsafe Il2CppReferenceArray<PlayingCard> Cards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Cards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Cards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D0D RID: 7437
		// (get) Token: 0x06005E65 RID: 24165 RVA: 0x001C17B4 File Offset: 0x001BF9B4
		// (set) Token: 0x06005E66 RID: 24166 RVA: 0x0002C955 File Offset: 0x0002AB55
		public unsafe Il2CppReferenceArray<Transform> DefaultCardPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_DefaultCardPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_DefaultCardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D0E RID: 7438
		// (get) Token: 0x06005E67 RID: 24167 RVA: 0x001C17E4 File Offset: 0x001BF9E4
		// (set) Token: 0x06005E68 RID: 24168 RVA: 0x0002C974 File Offset: 0x0002AB74
		public unsafe Il2CppReferenceArray<Transform> FocusedCameraTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_FocusedCameraTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_FocusedCameraTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D0F RID: 7439
		// (get) Token: 0x06005E69 RID: 24169 RVA: 0x001C1814 File Offset: 0x001BFA14
		// (set) Token: 0x06005E6A RID: 24170 RVA: 0x0002C993 File Offset: 0x0002AB93
		public unsafe Il2CppReferenceArray<Transform> FinalCameraTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_FinalCameraTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_FinalCameraTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D10 RID: 7440
		// (get) Token: 0x06005E6B RID: 24171 RVA: 0x001C1844 File Offset: 0x001BFA44
		// (set) Token: 0x06005E6C RID: 24172 RVA: 0x0002C9B2 File Offset: 0x0002ABB2
		public unsafe Il2CppReferenceArray<Transform> Player1CardPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player1CardPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player1CardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D11 RID: 7441
		// (get) Token: 0x06005E6D RID: 24173 RVA: 0x001C1874 File Offset: 0x001BFA74
		// (set) Token: 0x06005E6E RID: 24174 RVA: 0x0002C9D1 File Offset: 0x0002ABD1
		public unsafe Il2CppReferenceArray<Transform> Player2CardPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player2CardPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player2CardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D12 RID: 7442
		// (get) Token: 0x06005E6F RID: 24175 RVA: 0x001C18A4 File Offset: 0x001BFAA4
		// (set) Token: 0x06005E70 RID: 24176 RVA: 0x0002C9F0 File Offset: 0x0002ABF0
		public unsafe Il2CppReferenceArray<Transform> Player3CardPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player3CardPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player3CardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D13 RID: 7443
		// (get) Token: 0x06005E71 RID: 24177 RVA: 0x001C18D4 File Offset: 0x001BFAD4
		// (set) Token: 0x06005E72 RID: 24178 RVA: 0x0002CA0F File Offset: 0x0002AC0F
		public unsafe Il2CppReferenceArray<Transform> Player4CardPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player4CardPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player4CardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D14 RID: 7444
		// (get) Token: 0x06005E73 RID: 24179 RVA: 0x001C1904 File Offset: 0x001BFB04
		// (set) Token: 0x06005E74 RID: 24180 RVA: 0x0002CA2E File Offset: 0x0002AC2E
		public unsafe Il2CppReferenceArray<Transform> DealerCardPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_DealerCardPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_DealerCardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D15 RID: 7445
		// (get) Token: 0x06005E75 RID: 24181 RVA: 0x001C1934 File Offset: 0x001BFB34
		// (set) Token: 0x06005E76 RID: 24182 RVA: 0x0002CA4D File Offset: 0x0002AC4D
		public unsafe List<Player> playersInCurrentRound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_playersInCurrentRound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_playersInCurrentRound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D16 RID: 7446
		// (get) Token: 0x06005E77 RID: 24183 RVA: 0x001C1964 File Offset: 0x001BFB64
		// (set) Token: 0x06005E78 RID: 24184 RVA: 0x0002CA6C File Offset: 0x0002AC6C
		public unsafe List<PlayingCard> playStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_playStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_playStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D17 RID: 7447
		// (get) Token: 0x06005E79 RID: 24185 RVA: 0x001C1994 File Offset: 0x001BFB94
		// (set) Token: 0x06005E7A RID: 24186 RVA: 0x0002CA8B File Offset: 0x0002AC8B
		public unsafe List<PlayingCard> player1Hand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player1Hand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player1Hand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D18 RID: 7448
		// (get) Token: 0x06005E7B RID: 24187 RVA: 0x001C19C4 File Offset: 0x001BFBC4
		// (set) Token: 0x06005E7C RID: 24188 RVA: 0x0002CAAA File Offset: 0x0002ACAA
		public unsafe List<PlayingCard> player2Hand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player2Hand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player2Hand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D19 RID: 7449
		// (get) Token: 0x06005E7D RID: 24189 RVA: 0x001C19F4 File Offset: 0x001BFBF4
		// (set) Token: 0x06005E7E RID: 24190 RVA: 0x0002CAC9 File Offset: 0x0002ACC9
		public unsafe List<PlayingCard> player3Hand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player3Hand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player3Hand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D1A RID: 7450
		// (get) Token: 0x06005E7F RID: 24191 RVA: 0x001C1A24 File Offset: 0x001BFC24
		// (set) Token: 0x06005E80 RID: 24192 RVA: 0x0002CAE8 File Offset: 0x0002ACE8
		public unsafe List<PlayingCard> player4Hand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player4Hand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player4Hand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D1B RID: 7451
		// (get) Token: 0x06005E81 RID: 24193 RVA: 0x001C1A54 File Offset: 0x001BFC54
		// (set) Token: 0x06005E82 RID: 24194 RVA: 0x0002CB07 File Offset: 0x0002AD07
		public unsafe List<PlayingCard> dealerHand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_dealerHand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_dealerHand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D1C RID: 7452
		// (get) Token: 0x06005E83 RID: 24195 RVA: 0x001C1A84 File Offset: 0x001BFC84
		// (set) Token: 0x06005E84 RID: 24196 RVA: 0x0002CB26 File Offset: 0x0002AD26
		public unsafe List<PlayingCard.CardData> cardValuesInDeck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_cardValuesInDeck);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard.CardData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_cardValuesInDeck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D1D RID: 7453
		// (get) Token: 0x06005E85 RID: 24197 RVA: 0x001C1AB4 File Offset: 0x001BFCB4
		// (set) Token: 0x06005E86 RID: 24198 RVA: 0x0002CB45 File Offset: 0x0002AD45
		public unsafe List<PlayingCard.CardData> drawnCardsValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_drawnCardsValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard.CardData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_drawnCardsValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D1E RID: 7454
		// (get) Token: 0x06005E87 RID: 24199 RVA: 0x001C1AE4 File Offset: 0x001BFCE4
		// (set) Token: 0x06005E88 RID: 24200 RVA: 0x0002CB64 File Offset: 0x0002AD64
		public unsafe Transform localFocusCameraTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_localFocusCameraTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_localFocusCameraTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D1F RID: 7455
		// (get) Token: 0x06005E89 RID: 24201 RVA: 0x001C1B14 File Offset: 0x001BFD14
		// (set) Token: 0x06005E8A RID: 24202 RVA: 0x0002CB83 File Offset: 0x0002AD83
		public unsafe Transform localFinalCameraTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_localFinalCameraTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_localFinalCameraTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D20 RID: 7456
		// (get) Token: 0x06005E8B RID: 24203 RVA: 0x001C1B44 File Offset: 0x001BFD44
		// (set) Token: 0x06005E8C RID: 24204 RVA: 0x0002CBA2 File Offset: 0x0002ADA2
		public unsafe Action onLocalPlayerExitRound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerExitRound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerExitRound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D21 RID: 7457
		// (get) Token: 0x06005E8D RID: 24205 RVA: 0x001C1B74 File Offset: 0x001BFD74
		// (set) Token: 0x06005E8E RID: 24206 RVA: 0x0002CBC1 File Offset: 0x0002ADC1
		public unsafe Action onInitialCardsDealt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onInitialCardsDealt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onInitialCardsDealt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D22 RID: 7458
		// (get) Token: 0x06005E8F RID: 24207 RVA: 0x001C1BA4 File Offset: 0x001BFDA4
		// (set) Token: 0x06005E90 RID: 24208 RVA: 0x0002CBE0 File Offset: 0x0002ADE0
		public unsafe Action onLocalPlayerReadyForInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerReadyForInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerReadyForInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D23 RID: 7459
		// (get) Token: 0x06005E91 RID: 24209 RVA: 0x001C1BD4 File Offset: 0x001BFDD4
		// (set) Token: 0x06005E92 RID: 24210 RVA: 0x0002CBFF File Offset: 0x0002ADFF
		public unsafe Action onLocalPlayerBust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerBust);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerBust), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D24 RID: 7460
		// (get) Token: 0x06005E93 RID: 24211 RVA: 0x001C1C04 File Offset: 0x001BFE04
		// (set) Token: 0x06005E94 RID: 24212 RVA: 0x0002CC1E File Offset: 0x0002AE1E
		public unsafe Action<BlackjackGameController.EPayoutType> onLocalPlayerRoundCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerRoundCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BlackjackGameController.EPayoutType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerRoundCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D25 RID: 7461
		// (get) Token: 0x06005E95 RID: 24213 RVA: 0x001C1C34 File Offset: 0x001BFE34
		// (set) Token: 0x06005E96 RID: 24214 RVA: 0x0002CC3D File Offset: 0x0002AE3D
		public unsafe bool roundEnded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_roundEnded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_roundEnded)) = value;
			}
		}

		// Token: 0x17001D26 RID: 7462
		// (get) Token: 0x06005E97 RID: 24215 RVA: 0x001C1C5C File Offset: 0x001BFE5C
		// (set) Token: 0x06005E98 RID: 24216 RVA: 0x0002CC58 File Offset: 0x0002AE58
		public unsafe Coroutine gameRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_gameRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_gameRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D27 RID: 7463
		// (get) Token: 0x06005E99 RID: 24217 RVA: 0x001C1C8C File Offset: 0x001BFE8C
		// (set) Token: 0x06005E9A RID: 24218 RVA: 0x0002CC77 File Offset: 0x0002AE77
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001D28 RID: 7464
		// (get) Token: 0x06005E9B RID: 24219 RVA: 0x001C1CB4 File Offset: 0x001BFEB4
		// (set) Token: 0x06005E9C RID: 24220 RVA: 0x0002CC92 File Offset: 0x0002AE92
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040040A3 RID: 16547
		private static readonly IntPtr NativeFieldInfoPtr_MinimumBet;

		// Token: 0x040040A4 RID: 16548
		private static readonly IntPtr NativeFieldInfoPtr_MaximumBet;

		// Token: 0x040040A5 RID: 16549
		private static readonly IntPtr NativeFieldInfoPtr_PayoutRatio;

		// Token: 0x040040A6 RID: 16550
		private static readonly IntPtr NativeFieldInfoPtr_BlackjackPayoutRatio;

		// Token: 0x040040A7 RID: 16551
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStage_k__BackingField;

		// Token: 0x040040A8 RID: 16552
		private static readonly IntPtr NativeFieldInfoPtr__PlayerTurn_k__BackingField;

		// Token: 0x040040A9 RID: 16553
		private static readonly IntPtr NativeFieldInfoPtr__DealerScore_k__BackingField;

		// Token: 0x040040AA RID: 16554
		private static readonly IntPtr NativeFieldInfoPtr__LocalPlayerScore_k__BackingField;

		// Token: 0x040040AB RID: 16555
		private static readonly IntPtr NativeFieldInfoPtr__IsLocalPlayerBlackjack_k__BackingField;

		// Token: 0x040040AC RID: 16556
		private static readonly IntPtr NativeFieldInfoPtr__IsLocalPlayerBust_k__BackingField;

		// Token: 0x040040AD RID: 16557
		private static readonly IntPtr NativeFieldInfoPtr_Cards;

		// Token: 0x040040AE RID: 16558
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCardPositions;

		// Token: 0x040040AF RID: 16559
		private static readonly IntPtr NativeFieldInfoPtr_FocusedCameraTransforms;

		// Token: 0x040040B0 RID: 16560
		private static readonly IntPtr NativeFieldInfoPtr_FinalCameraTransforms;

		// Token: 0x040040B1 RID: 16561
		private static readonly IntPtr NativeFieldInfoPtr_Player1CardPositions;

		// Token: 0x040040B2 RID: 16562
		private static readonly IntPtr NativeFieldInfoPtr_Player2CardPositions;

		// Token: 0x040040B3 RID: 16563
		private static readonly IntPtr NativeFieldInfoPtr_Player3CardPositions;

		// Token: 0x040040B4 RID: 16564
		private static readonly IntPtr NativeFieldInfoPtr_Player4CardPositions;

		// Token: 0x040040B5 RID: 16565
		private static readonly IntPtr NativeFieldInfoPtr_DealerCardPositions;

		// Token: 0x040040B6 RID: 16566
		private static readonly IntPtr NativeFieldInfoPtr_playersInCurrentRound;

		// Token: 0x040040B7 RID: 16567
		private static readonly IntPtr NativeFieldInfoPtr_playStack;

		// Token: 0x040040B8 RID: 16568
		private static readonly IntPtr NativeFieldInfoPtr_player1Hand;

		// Token: 0x040040B9 RID: 16569
		private static readonly IntPtr NativeFieldInfoPtr_player2Hand;

		// Token: 0x040040BA RID: 16570
		private static readonly IntPtr NativeFieldInfoPtr_player3Hand;

		// Token: 0x040040BB RID: 16571
		private static readonly IntPtr NativeFieldInfoPtr_player4Hand;

		// Token: 0x040040BC RID: 16572
		private static readonly IntPtr NativeFieldInfoPtr_dealerHand;

		// Token: 0x040040BD RID: 16573
		private static readonly IntPtr NativeFieldInfoPtr_cardValuesInDeck;

		// Token: 0x040040BE RID: 16574
		private static readonly IntPtr NativeFieldInfoPtr_drawnCardsValues;

		// Token: 0x040040BF RID: 16575
		private static readonly IntPtr NativeFieldInfoPtr_localFocusCameraTransform;

		// Token: 0x040040C0 RID: 16576
		private static readonly IntPtr NativeFieldInfoPtr_localFinalCameraTransform;

		// Token: 0x040040C1 RID: 16577
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerExitRound;

		// Token: 0x040040C2 RID: 16578
		private static readonly IntPtr NativeFieldInfoPtr_onInitialCardsDealt;

		// Token: 0x040040C3 RID: 16579
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerReadyForInput;

		// Token: 0x040040C4 RID: 16580
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerBust;

		// Token: 0x040040C5 RID: 16581
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerRoundCompleted;

		// Token: 0x040040C6 RID: 16582
		private static readonly IntPtr NativeFieldInfoPtr_roundEnded;

		// Token: 0x040040C7 RID: 16583
		private static readonly IntPtr NativeFieldInfoPtr_gameRoutine;

		// Token: 0x040040C8 RID: 16584
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040040C9 RID: 16585
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040040CA RID: 16586
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0;

		// Token: 0x040040CB RID: 16587
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0;

		// Token: 0x040040CC RID: 16588
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerTurn_Public_get_Player_0;

		// Token: 0x040040CD RID: 16589
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerTurn_Private_set_Void_Player_0;

		// Token: 0x040040CE RID: 16590
		private static readonly IntPtr NativeMethodInfoPtr_get_DealerScore_Public_get_Int32_0;

		// Token: 0x040040CF RID: 16591
		private static readonly IntPtr NativeMethodInfoPtr_set_DealerScore_Private_set_Void_Int32_0;

		// Token: 0x040040D0 RID: 16592
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerScore_Public_get_Int32_0;

		// Token: 0x040040D1 RID: 16593
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalPlayerScore_Private_set_Void_Int32_0;

		// Token: 0x040040D2 RID: 16594
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocalPlayerBlackjack_Public_get_Boolean_0;

		// Token: 0x040040D3 RID: 16595
		private static readonly IntPtr NativeMethodInfoPtr_set_IsLocalPlayerBlackjack_Private_set_Void_Boolean_0;

		// Token: 0x040040D4 RID: 16596
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocalPlayerBust_Public_get_Boolean_0;

		// Token: 0x040040D5 RID: 16597
		private static readonly IntPtr NativeMethodInfoPtr_set_IsLocalPlayerBust_Private_set_Void_Boolean_0;

		// Token: 0x040040D6 RID: 16598
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0;

		// Token: 0x040040D7 RID: 16599
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040040D8 RID: 16600
		private static readonly IntPtr NativeMethodInfoPtr_Open_Protected_Virtual_Void_1;

		// Token: 0x040040D9 RID: 16601
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Protected_Virtual_Void_1;

		// Token: 0x040040DA RID: 16602
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0;

		// Token: 0x040040DB RID: 16603
		private static readonly IntPtr NativeMethodInfoPtr_GetClockwisePlayers_Private_List_1_Player_0;

		// Token: 0x040040DC RID: 16604
		private static readonly IntPtr NativeMethodInfoPtr_StartGame_Private_Void_0;

		// Token: 0x040040DD RID: 16605
		private static readonly IntPtr NativeMethodInfoPtr_NotifyPlayerScore_Private_Void_NetworkObject_Int32_Boolean_0;

		// Token: 0x040040DE RID: 16606
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerCardPositions_Private_Il2CppReferenceArray_1_Transform_Int32_0;

		// Token: 0x040040DF RID: 16607
		private static readonly IntPtr NativeMethodInfoPtr_SetRoundEnded_Private_Void_Boolean_0;

		// Token: 0x040040E0 RID: 16608
		private static readonly IntPtr NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_PlayingCard_0;

		// Token: 0x040040E1 RID: 16609
		private static readonly IntPtr NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_String_0;

		// Token: 0x040040E2 RID: 16610
		private static readonly IntPtr NativeMethodInfoPtr_AddCardToDealerHand_Private_Void_String_0;

		// Token: 0x040040E3 RID: 16611
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerCards_Private_List_1_PlayingCard_Int32_0;

		// Token: 0x040040E4 RID: 16612
		private static readonly IntPtr NativeMethodInfoPtr_GetHandScore_Private_Int32_List_1_PlayingCard_Boolean_0;

		// Token: 0x040040E5 RID: 16613
		private static readonly IntPtr NativeMethodInfoPtr_IsWaitingForPlayers_Public_Virtual_Boolean_0;

		// Token: 0x040040E6 RID: 16614
		private static readonly IntPtr NativeMethodInfoPtr_GetBetLimits_Public_Virtual_Void_byref_Single_byref_Single_0;

		// Token: 0x040040E7 RID: 16615
		private static readonly IntPtr NativeMethodInfoPtr_GetCardValue_Private_Int32_PlayingCard_Boolean_0;

		// Token: 0x040040E8 RID: 16616
		private static readonly IntPtr NativeMethodInfoPtr_DrawCard_Private_PlayingCard_0;

		// Token: 0x040040E9 RID: 16617
		private static readonly IntPtr NativeMethodInfoPtr_ResetCards_Private_Void_0;

		// Token: 0x040040EA RID: 16618
		private static readonly IntPtr NativeMethodInfoPtr_EndGame_Private_Void_0;

		// Token: 0x040040EB RID: 16619
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_EPayoutType_Single_0;

		// Token: 0x040040EC RID: 16620
		private static readonly IntPtr NativeMethodInfoPtr_GetPayout_Public_Single_Single_EPayoutType_0;

		// Token: 0x040040ED RID: 16621
		private static readonly IntPtr NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0;

		// Token: 0x040040EE RID: 16622
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x040040EF RID: 16623
		private static readonly IntPtr NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x040040F0 RID: 16624
		private static readonly IntPtr NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x040040F1 RID: 16625
		private static readonly IntPtr NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0;

		// Token: 0x040040F2 RID: 16626
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0;

		// Token: 0x040040F3 RID: 16627
		private static readonly IntPtr NativeMethodInfoPtr_TryStartGame_Private_Void_0;

		// Token: 0x040040F4 RID: 16628
		private static readonly IntPtr NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Virtual_Void_0;

		// Token: 0x040040F5 RID: 16629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040040F6 RID: 16630
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040040F7 RID: 16631
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040040F8 RID: 16632
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040040F9 RID: 16633
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartGame_2166136261_Private_Void_0;

		// Token: 0x040040FA RID: 16634
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartGame_2166136261_Private_Void_0;

		// Token: 0x040040FB RID: 16635
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartGame_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040040FC RID: 16636
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0;

		// Token: 0x040040FD RID: 16637
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0;

		// Token: 0x040040FE RID: 16638
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_NotifyPlayerScore_2864061566_Private_Void_PooledReader_Channel_0;

		// Token: 0x040040FF RID: 16639
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetRoundEnded_1140765316_Private_Void_Boolean_0;

		// Token: 0x04004100 RID: 16640
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetRoundEnded_1140765316_Private_Void_Boolean_0;

		// Token: 0x04004101 RID: 16641
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetRoundEnded_1140765316_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004102 RID: 16642
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0;

		// Token: 0x04004103 RID: 16643
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0;

		// Token: 0x04004104 RID: 16644
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddCardToPlayerHand_2801973956_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004105 RID: 16645
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddCardToDealerHand_3615296227_Private_Void_String_0;

		// Token: 0x04004106 RID: 16646
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddCardToDealerHand_3615296227_Private_Void_String_0;

		// Token: 0x04004107 RID: 16647
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddCardToDealerHand_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004108 RID: 16648
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0;

		// Token: 0x04004109 RID: 16649
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0;

		// Token: 0x0400410A RID: 16650
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400410B RID: 16651
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400410C RID: 16652
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400410D RID: 16653
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400410E RID: 16654
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400410F RID: 16655
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004110 RID: 16656
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004111 RID: 16657
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004112 RID: 16658
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004113 RID: 16659
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004114 RID: 16660
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_TryStartGame_2166136261_Private_Void_0;

		// Token: 0x04004115 RID: 16661
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___TryStartGame_2166136261_Private_Void_0;

		// Token: 0x04004116 RID: 16662
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_TryStartGame_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004117 RID: 16663
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000B18 RID: 2840
		[OriginalName("Assembly-CSharp.dll", "", "EStage")]
		public enum EStage
		{
			// Token: 0x04009C0A RID: 39946
			WaitingForPlayers,
			// Token: 0x04009C0B RID: 39947
			Dealing,
			// Token: 0x04009C0C RID: 39948
			PlayerTurn,
			// Token: 0x04009C0D RID: 39949
			DealerTurn,
			// Token: 0x04009C0E RID: 39950
			Ending
		}

		// Token: 0x02000B19 RID: 2841
		[OriginalName("Assembly-CSharp.dll", "", "EPayoutType")]
		public enum EPayoutType
		{
			// Token: 0x04009C10 RID: 39952
			None,
			// Token: 0x04009C11 RID: 39953
			Blackjack,
			// Token: 0x04009C12 RID: 39954
			Win,
			// Token: 0x04009C13 RID: 39955
			Push
		}

		// Token: 0x02000B1A RID: 2842
		[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass64_0")]
		public sealed class __c__DisplayClass64_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E5FF RID: 58879 RVA: 0x00382990 File Offset: 0x00380B90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass64_0()
			{
				Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<>c__DisplayClass64_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0>.NativeClassPtr);
				BlackjackGameController.__c__DisplayClass64_0.NativeFieldInfoPtr_clockwisePlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0>.NativeClassPtr, "clockwisePlayers");
				BlackjackGameController.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0>.NativeClassPtr, "<>4__this");
				BlackjackGameController.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0>.NativeClassPtr, 100675667);
				BlackjackGameController.__c__DisplayClass64_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0>.NativeClassPtr, 100675668);
				BlackjackGameController.__c__DisplayClass64_0.NativeMethodInfoPtr__StartGame_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0>.NativeClassPtr, 100675669);
			}

			// Token: 0x0600E600 RID: 58880 RVA: 0x00382A20 File Offset: 0x00380C20
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass64_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E601 RID: 58881 RVA: 0x00382A5C File Offset: 0x00380C5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200798, XrefRangeEnd = 200803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass64_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E602 RID: 58882 RVA: 0x00382A9C File Offset: 0x00380C9C
			[CallerCount(0)]
			public unsafe bool _StartGame_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass64_0.NativeMethodInfoPtr__StartGame_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E603 RID: 58883 RVA: 0x0006C747 File Offset: 0x0006A947
			public __c__DisplayClass64_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045D5 RID: 17877
			// (get) Token: 0x0600E604 RID: 58884 RVA: 0x00382AD8 File Offset: 0x00380CD8
			// (set) Token: 0x0600E605 RID: 58885 RVA: 0x0006C750 File Offset: 0x0006A950
			public unsafe List<Player> clockwisePlayers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_0.NativeFieldInfoPtr_clockwisePlayers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_0.NativeFieldInfoPtr_clockwisePlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045D6 RID: 17878
			// (get) Token: 0x0600E606 RID: 58886 RVA: 0x00382B08 File Offset: 0x00380D08
			// (set) Token: 0x0600E607 RID: 58887 RVA: 0x0006C76F File Offset: 0x0006A96F
			public unsafe BlackjackGameController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009C14 RID: 39956
			private static readonly IntPtr NativeFieldInfoPtr_clockwisePlayers;

			// Token: 0x04009C15 RID: 39957
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009C16 RID: 39958
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C17 RID: 39959
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009C18 RID: 39960
			private static readonly IntPtr NativeMethodInfoPtr__StartGame_b__1_Internal_Boolean_0;

			// Token: 0x02000DD6 RID: 3542
			[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass64_0+<<StartGame>g__GameRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FFA0 RID: 65440 RVA: 0x003CC670 File Offset: 0x003CA870
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique()
				{
					Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0>.NativeClassPtr, "<<StartGame>g__GameRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr);
					BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<>1__state");
					BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<>2__current");
					BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<>4__this");
					BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<>8__1");
					BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__drawSpacing_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<drawSpacing>5__2");
					BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__dealerTurn_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<dealerTurn>5__3");
					BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<i>5__4");
					BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__playerIndex_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<playerIndex>5__5");
					BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__turn_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<turn>5__6");
					BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100675670);
					BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100675671);
					BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100675672);
					BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100675673);
					BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100675674);
					BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100675675);
				}

				// Token: 0x0600FFA1 RID: 65441 RVA: 0x003CC7C8 File Offset: 0x003CA9C8
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FFA2 RID: 65442 RVA: 0x003CC810 File Offset: 0x003CAA10
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FFA3 RID: 65443 RVA: 0x003CC844 File Offset: 0x003CAA44
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200534, XrefRangeEnd = 200793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004DDC RID: 19932
				// (get) Token: 0x0600FFA4 RID: 65444 RVA: 0x003CC880 File Offset: 0x003CAA80
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FFA5 RID: 65445 RVA: 0x003CC8C0 File Offset: 0x003CAAC0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200793, XrefRangeEnd = 200798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004DDD RID: 19933
				// (get) Token: 0x0600FFA6 RID: 65446 RVA: 0x003CC8F4 File Offset: 0x003CAAF4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FFA7 RID: 65447 RVA: 0x000791FB File Offset: 0x000773FB
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004DD3 RID: 19923
				// (get) Token: 0x0600FFA8 RID: 65448 RVA: 0x003CC934 File Offset: 0x003CAB34
				// (set) Token: 0x0600FFA9 RID: 65449 RVA: 0x00079204 File Offset: 0x00077404
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004DD4 RID: 19924
				// (get) Token: 0x0600FFAA RID: 65450 RVA: 0x003CC95C File Offset: 0x003CAB5C
				// (set) Token: 0x0600FFAB RID: 65451 RVA: 0x0007921F File Offset: 0x0007741F
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DD5 RID: 19925
				// (get) Token: 0x0600FFAC RID: 65452 RVA: 0x003CC98C File Offset: 0x003CAB8C
				// (set) Token: 0x0600FFAD RID: 65453 RVA: 0x0007923E File Offset: 0x0007743E
				public unsafe BlackjackGameController.__c__DisplayClass64_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController.__c__DisplayClass64_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DD6 RID: 19926
				// (get) Token: 0x0600FFAE RID: 65454 RVA: 0x003CC9BC File Offset: 0x003CABBC
				// (set) Token: 0x0600FFAF RID: 65455 RVA: 0x0007925D File Offset: 0x0007745D
				public unsafe BlackjackGameController.__c__DisplayClass64_1 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController.__c__DisplayClass64_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DD7 RID: 19927
				// (get) Token: 0x0600FFB0 RID: 65456 RVA: 0x003CC9EC File Offset: 0x003CABEC
				// (set) Token: 0x0600FFB1 RID: 65457 RVA: 0x0007927C File Offset: 0x0007747C
				public unsafe float _drawSpacing_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__drawSpacing_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__drawSpacing_5__2)) = value;
					}
				}

				// Token: 0x17004DD8 RID: 19928
				// (get) Token: 0x0600FFB2 RID: 65458 RVA: 0x003CCA14 File Offset: 0x003CAC14
				// (set) Token: 0x0600FFB3 RID: 65459 RVA: 0x00079297 File Offset: 0x00077497
				public unsafe int _dealerTurn_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__dealerTurn_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__dealerTurn_5__3)) = value;
					}
				}

				// Token: 0x17004DD9 RID: 19929
				// (get) Token: 0x0600FFB4 RID: 65460 RVA: 0x003CCA3C File Offset: 0x003CAC3C
				// (set) Token: 0x0600FFB5 RID: 65461 RVA: 0x000792B2 File Offset: 0x000774B2
				public unsafe int _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x17004DDA RID: 19930
				// (get) Token: 0x0600FFB6 RID: 65462 RVA: 0x003CCA64 File Offset: 0x003CAC64
				// (set) Token: 0x0600FFB7 RID: 65463 RVA: 0x000792CD File Offset: 0x000774CD
				public unsafe int _playerIndex_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__playerIndex_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__playerIndex_5__5)) = value;
					}
				}

				// Token: 0x17004DDB RID: 19931
				// (get) Token: 0x0600FFB8 RID: 65464 RVA: 0x003CCA8C File Offset: 0x003CAC8C
				// (set) Token: 0x0600FFB9 RID: 65465 RVA: 0x000792E8 File Offset: 0x000774E8
				public unsafe int _turn_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__turn_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__turn_5__6)) = value;
					}
				}

				// Token: 0x0400AC39 RID: 44089
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AC3A RID: 44090
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AC3B RID: 44091
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AC3C RID: 44092
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400AC3D RID: 44093
				private static readonly IntPtr NativeFieldInfoPtr__drawSpacing_5__2;

				// Token: 0x0400AC3E RID: 44094
				private static readonly IntPtr NativeFieldInfoPtr__dealerTurn_5__3;

				// Token: 0x0400AC3F RID: 44095
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x0400AC40 RID: 44096
				private static readonly IntPtr NativeFieldInfoPtr__playerIndex_5__5;

				// Token: 0x0400AC41 RID: 44097
				private static readonly IntPtr NativeFieldInfoPtr__turn_5__6;

				// Token: 0x0400AC42 RID: 44098
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AC43 RID: 44099
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC44 RID: 44100
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AC45 RID: 44101
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AC46 RID: 44102
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC47 RID: 44103
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B1B RID: 2843
		[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass64_1")]
		public sealed class __c__DisplayClass64_1 : Il2CppSystem.Object
		{
			// Token: 0x0600E608 RID: 58888 RVA: 0x00382B38 File Offset: 0x00380D38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass64_1()
			{
				Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<>c__DisplayClass64_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_1>.NativeClassPtr);
				BlackjackGameController.__c__DisplayClass64_1.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_1>.NativeClassPtr, "player");
				BlackjackGameController.__c__DisplayClass64_1.NativeFieldInfoPtr_field_Public___c__DisplayClass64_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_1>.NativeClassPtr, "CS$<>8__locals1");
				BlackjackGameController.__c__DisplayClass64_1.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_1>.NativeClassPtr, "<>9__2");
				BlackjackGameController.__c__DisplayClass64_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_1>.NativeClassPtr, 100675676);
				BlackjackGameController.__c__DisplayClass64_1.NativeMethodInfoPtr__StartGame_b__2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_1>.NativeClassPtr, 100675677);
			}

			// Token: 0x0600E609 RID: 58889 RVA: 0x00382BC8 File Offset: 0x00380DC8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass64_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass64_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass64_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E60A RID: 58890 RVA: 0x00382C04 File Offset: 0x00380E04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200803, XrefRangeEnd = 200810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartGame_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass64_1.NativeMethodInfoPtr__StartGame_b__2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E60B RID: 58891 RVA: 0x0006C78E File Offset: 0x0006A98E
			public __c__DisplayClass64_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045D7 RID: 17879
			// (get) Token: 0x0600E60C RID: 58892 RVA: 0x00382C40 File Offset: 0x00380E40
			// (set) Token: 0x0600E60D RID: 58893 RVA: 0x0006C797 File Offset: 0x0006A997
			public unsafe Player player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_1.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_1.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045D8 RID: 17880
			// (get) Token: 0x0600E60E RID: 58894 RVA: 0x00382C70 File Offset: 0x00380E70
			// (set) Token: 0x0600E60F RID: 58895 RVA: 0x0006C7B6 File Offset: 0x0006A9B6
			public unsafe BlackjackGameController.__c__DisplayClass64_0 field_Public___c__DisplayClass64_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_1.NativeFieldInfoPtr_field_Public___c__DisplayClass64_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController.__c__DisplayClass64_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_1.NativeFieldInfoPtr_field_Public___c__DisplayClass64_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045D9 RID: 17881
			// (get) Token: 0x0600E610 RID: 58896 RVA: 0x00382CA0 File Offset: 0x00380EA0
			// (set) Token: 0x0600E611 RID: 58897 RVA: 0x0006C7D5 File Offset: 0x0006A9D5
			public unsafe Func<bool> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_1.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass64_1.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009C19 RID: 39961
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04009C1A RID: 39962
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass64_0_0;

			// Token: 0x04009C1B RID: 39963
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04009C1C RID: 39964
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C1D RID: 39965
			private static readonly IntPtr NativeMethodInfoPtr__StartGame_b__2_Internal_Boolean_0;
		}

		// Token: 0x02000B1C RID: 2844
		[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass69_0")]
		public sealed class __c__DisplayClass69_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E612 RID: 58898 RVA: 0x00382CD0 File Offset: 0x00380ED0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass69_0()
			{
				Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass69_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<>c__DisplayClass69_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass69_0>.NativeClassPtr);
				BlackjackGameController.__c__DisplayClass69_0.NativeFieldInfoPtr_cardID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass69_0>.NativeClassPtr, "cardID");
				BlackjackGameController.__c__DisplayClass69_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass69_0>.NativeClassPtr, 100675678);
				BlackjackGameController.__c__DisplayClass69_0.NativeMethodInfoPtr__AddCardToPlayerHand_b__0_Internal_Boolean_PlayingCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass69_0>.NativeClassPtr, 100675679);
			}

			// Token: 0x0600E613 RID: 58899 RVA: 0x00382D38 File Offset: 0x00380F38
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass69_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass69_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass69_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E614 RID: 58900 RVA: 0x00382D74 File Offset: 0x00380F74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200810, XrefRangeEnd = 200812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddCardToPlayerHand_b__0(PlayingCard x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass69_0.NativeMethodInfoPtr__AddCardToPlayerHand_b__0_Internal_Boolean_PlayingCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E615 RID: 58901 RVA: 0x0006C7F4 File Offset: 0x0006A9F4
			public __c__DisplayClass69_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045DA RID: 17882
			// (get) Token: 0x0600E616 RID: 58902 RVA: 0x00382DC4 File Offset: 0x00380FC4
			// (set) Token: 0x0600E617 RID: 58903 RVA: 0x0006C7FD File Offset: 0x0006A9FD
			public unsafe string cardID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass69_0.NativeFieldInfoPtr_cardID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass69_0.NativeFieldInfoPtr_cardID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009C1E RID: 39966
			private static readonly IntPtr NativeFieldInfoPtr_cardID;

			// Token: 0x04009C1F RID: 39967
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C20 RID: 39968
			private static readonly IntPtr NativeMethodInfoPtr__AddCardToPlayerHand_b__0_Internal_Boolean_PlayingCard_0;
		}

		// Token: 0x02000B1D RID: 2845
		[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass70_0")]
		public sealed class __c__DisplayClass70_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E618 RID: 58904 RVA: 0x00382DEC File Offset: 0x00380FEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_0()
			{
				Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<>c__DisplayClass70_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr);
				BlackjackGameController.__c__DisplayClass70_0.NativeFieldInfoPtr_cardID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr, "cardID");
				BlackjackGameController.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr, 100675680);
				BlackjackGameController.__c__DisplayClass70_0.NativeMethodInfoPtr__AddCardToDealerHand_b__0_Internal_Boolean_PlayingCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr, 100675681);
			}

			// Token: 0x0600E619 RID: 58905 RVA: 0x00382E54 File Offset: 0x00381054
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E61A RID: 58906 RVA: 0x00382E90 File Offset: 0x00381090
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddCardToDealerHand_b__0(PlayingCard x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.NativeMethodInfoPtr__AddCardToDealerHand_b__0_Internal_Boolean_PlayingCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E61B RID: 58907 RVA: 0x0006C81C File Offset: 0x0006AA1C
			public __c__DisplayClass70_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045DB RID: 17883
			// (get) Token: 0x0600E61C RID: 58908 RVA: 0x00382EE0 File Offset: 0x003810E0
			// (set) Token: 0x0600E61D RID: 58909 RVA: 0x0006C825 File Offset: 0x0006AA25
			public unsafe string cardID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.NativeFieldInfoPtr_cardID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.NativeFieldInfoPtr_cardID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009C21 RID: 39969
			private static readonly IntPtr NativeFieldInfoPtr_cardID;

			// Token: 0x04009C22 RID: 39970
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C23 RID: 39971
			private static readonly IntPtr NativeMethodInfoPtr__AddCardToDealerHand_b__0_Internal_Boolean_PlayingCard_0;
		}

		// Token: 0x02000B1E RID: 2846
		[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass79_0")]
		public sealed class __c__DisplayClass79_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E61E RID: 58910 RVA: 0x00382F08 File Offset: 0x00381108
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass79_0()
			{
				Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass79_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<>c__DisplayClass79_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass79_0>.NativeClassPtr);
				BlackjackGameController.__c__DisplayClass79_0.NativeFieldInfoPtr_cameraDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass79_0>.NativeClassPtr, "cameraDelay");
				BlackjackGameController.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass79_0>.NativeClassPtr, "<>4__this");
				BlackjackGameController.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass79_0>.NativeClassPtr, 100675682);
				BlackjackGameController.__c__DisplayClass79_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass79_0>.NativeClassPtr, 100675683);
			}

			// Token: 0x0600E61F RID: 58911 RVA: 0x00382F84 File Offset: 0x00381184
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass79_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass79_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E620 RID: 58912 RVA: 0x00382FC0 File Offset: 0x003811C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200823, XrefRangeEnd = 200828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass79_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E621 RID: 58913 RVA: 0x0006C844 File Offset: 0x0006AA44
			public __c__DisplayClass79_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045DC RID: 17884
			// (get) Token: 0x0600E622 RID: 58914 RVA: 0x00383000 File Offset: 0x00381200
			// (set) Token: 0x0600E623 RID: 58915 RVA: 0x0006C84D File Offset: 0x0006AA4D
			public unsafe float cameraDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass79_0.NativeFieldInfoPtr_cameraDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass79_0.NativeFieldInfoPtr_cameraDelay)) = value;
				}
			}

			// Token: 0x170045DD RID: 17885
			// (get) Token: 0x0600E624 RID: 58916 RVA: 0x00383028 File Offset: 0x00381228
			// (set) Token: 0x0600E625 RID: 58917 RVA: 0x0006C868 File Offset: 0x0006AA68
			public unsafe BlackjackGameController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009C24 RID: 39972
			private static readonly IntPtr NativeFieldInfoPtr_cameraDelay;

			// Token: 0x04009C25 RID: 39973
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009C26 RID: 39974
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C27 RID: 39975
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DD7 RID: 3543
			[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass79_0+<<RemoveLocalPlayerFromGame>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FFBA RID: 65466 RVA: 0x003CCAB4 File Offset: 0x003CACB4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass79_0>.NativeClassPtr, "<<RemoveLocalPlayerFromGame>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675684);
					BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675685);
					BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675686);
					BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675687);
					BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675688);
					BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675689);
				}

				// Token: 0x0600FFBB RID: 65467 RVA: 0x003CCB94 File Offset: 0x003CAD94
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FFBC RID: 65468 RVA: 0x003CCBDC File Offset: 0x003CADDC
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FFBD RID: 65469 RVA: 0x003CCC10 File Offset: 0x003CAE10
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200812, XrefRangeEnd = 200818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004DE1 RID: 19937
				// (get) Token: 0x0600FFBE RID: 65470 RVA: 0x003CCC4C File Offset: 0x003CAE4C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FFBF RID: 65471 RVA: 0x003CCC8C File Offset: 0x003CAE8C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200818, XrefRangeEnd = 200823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004DE2 RID: 19938
				// (get) Token: 0x0600FFC0 RID: 65472 RVA: 0x003CCCC0 File Offset: 0x003CAEC0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FFC1 RID: 65473 RVA: 0x00079303 File Offset: 0x00077503
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004DDE RID: 19934
				// (get) Token: 0x0600FFC2 RID: 65474 RVA: 0x003CCD00 File Offset: 0x003CAF00
				// (set) Token: 0x0600FFC3 RID: 65475 RVA: 0x0007930C File Offset: 0x0007750C
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004DDF RID: 19935
				// (get) Token: 0x0600FFC4 RID: 65476 RVA: 0x003CCD28 File Offset: 0x003CAF28
				// (set) Token: 0x0600FFC5 RID: 65477 RVA: 0x00079327 File Offset: 0x00077527
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DE0 RID: 19936
				// (get) Token: 0x0600FFC6 RID: 65478 RVA: 0x003CCD58 File Offset: 0x003CAF58
				// (set) Token: 0x0600FFC7 RID: 65479 RVA: 0x00079346 File Offset: 0x00077546
				public unsafe BlackjackGameController.__c__DisplayClass79_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController.__c__DisplayClass79_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AC48 RID: 44104
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AC49 RID: 44105
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AC4A RID: 44106
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AC4B RID: 44107
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AC4C RID: 44108
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC4D RID: 44109
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AC4E RID: 44110
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AC4F RID: 44111
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC50 RID: 44112
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
