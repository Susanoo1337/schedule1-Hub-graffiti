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
	// Token: 0x02000434 RID: 1076
	public class RTBGameController : CasinoGameController
	{
		// Token: 0x06005F94 RID: 24468 RVA: 0x001C6128 File Offset: 0x001C4328
		// Note: this type is marked as 'beforefieldinit'.
		static RTBGameController()
		{
			Il2CppClassPointerStore<RTBGameController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "RTBGameController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr);
			RTBGameController.NativeFieldInfoPtr_MinimumBet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "MinimumBet");
			RTBGameController.NativeFieldInfoPtr_MaximumBet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "MaximumBet");
			RTBGameController.NativeFieldInfoPtr_AnswerMaxTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "AnswerMaxTime");
			RTBGameController.NativeFieldInfoPtr_PlayCameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "PlayCameraTransform");
			RTBGameController.NativeFieldInfoPtr_FocusedCameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "FocusedCameraTransform");
			RTBGameController.NativeFieldInfoPtr_Cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "Cards");
			RTBGameController.NativeFieldInfoPtr_CardDefaultPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "CardDefaultPositions");
			RTBGameController.NativeFieldInfoPtr_ActiveCardPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "ActiveCardPosition");
			RTBGameController.NativeFieldInfoPtr_DockedCardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "DockedCardPositions");
			RTBGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<CurrentStage>k__BackingField");
			RTBGameController.NativeFieldInfoPtr_onStageChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onStageChange");
			RTBGameController.NativeFieldInfoPtr_onQuestionReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onQuestionReady");
			RTBGameController.NativeFieldInfoPtr_onQuestionDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onQuestionDone");
			RTBGameController.NativeFieldInfoPtr_onLocalPlayerCorrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onLocalPlayerCorrect");
			RTBGameController.NativeFieldInfoPtr_onLocalPlayerIncorrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onLocalPlayerIncorrect");
			RTBGameController.NativeFieldInfoPtr_onLocalPlayerExitRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onLocalPlayerExitRound");
			RTBGameController.NativeFieldInfoPtr__IsQuestionActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<IsQuestionActive>k__BackingField");
			RTBGameController.NativeFieldInfoPtr__LocalPlayerBetMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<LocalPlayerBetMultiplier>k__BackingField");
			RTBGameController.NativeFieldInfoPtr__RemainingAnswerTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<RemainingAnswerTime>k__BackingField");
			RTBGameController.NativeFieldInfoPtr_playersInCurrentRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "playersInCurrentRound");
			RTBGameController.NativeFieldInfoPtr_cardsInDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "cardsInDeck");
			RTBGameController.NativeFieldInfoPtr_drawnCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "drawnCards");
			RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Casino.RTBGameControllerAssembly-CSharp.dll_Excuted");
			RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Casino.RTBGameControllerAssembly-CSharp.dll_Excuted");
			RTBGameController.NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675848);
			RTBGameController.NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675849);
			RTBGameController.NativeMethodInfoPtr_get_IsQuestionActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675850);
			RTBGameController.NativeMethodInfoPtr_set_IsQuestionActive_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675851);
			RTBGameController.NativeMethodInfoPtr_get_LocalPlayerBetMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675852);
			RTBGameController.NativeMethodInfoPtr_set_LocalPlayerBetMultiplier_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675853);
			RTBGameController.NativeMethodInfoPtr_get_MultipliedLocalPlayerBet_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675854);
			RTBGameController.NativeMethodInfoPtr_get_RemainingAnswerTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675855);
			RTBGameController.NativeMethodInfoPtr_set_RemainingAnswerTime_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675856);
			RTBGameController.NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675857);
			RTBGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675858);
			RTBGameController.NativeMethodInfoPtr_Open_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675859);
			RTBGameController.NativeMethodInfoPtr_OnClose_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675860);
			RTBGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675861);
			RTBGameController.NativeMethodInfoPtr_SetStage_Private_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675862);
			RTBGameController.NativeMethodInfoPtr_RunRound_Private_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675863);
			RTBGameController.NativeMethodInfoPtr_SetBetMultiplier_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675864);
			RTBGameController.NativeMethodInfoPtr_EndGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675865);
			RTBGameController.NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675866);
			RTBGameController.NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675867);
			RTBGameController.NativeMethodInfoPtr_GetAnswerIndex_Private_Single_EStage_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675868);
			RTBGameController.NativeMethodInfoPtr_NotifyAnswer_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675869);
			RTBGameController.NativeMethodInfoPtr_QuestionDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675870);
			RTBGameController.NativeMethodInfoPtr_GetQuestionsAndAnswers_Private_Void_EStage_byref_String_byref_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675871);
			RTBGameController.NativeMethodInfoPtr_ResetCards_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675872);
			RTBGameController.NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675873);
			RTBGameController.NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675874);
			RTBGameController.NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675875);
			RTBGameController.NativeMethodInfoPtr_PullCardFromDeck_Private_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675876);
			RTBGameController.NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675877);
			RTBGameController.NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675878);
			RTBGameController.NativeMethodInfoPtr_SetLocalPlayerAnswer_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675879);
			RTBGameController.NativeMethodInfoPtr_GetAnsweredPlayersCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675880);
			RTBGameController.NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675881);
			RTBGameController.NativeMethodInfoPtr_TryNextStage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675882);
			RTBGameController.NativeMethodInfoPtr_GetCardNumberValue_Private_Int32_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675883);
			RTBGameController.NativeMethodInfoPtr_GetNetBetMultiplier_Public_Static_Single_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675884);
			RTBGameController.NativeMethodInfoPtr_IsWaitingForPlayers_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675885);
			RTBGameController.NativeMethodInfoPtr_GetBetLimits_Public_Virtual_Void_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675886);
			RTBGameController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675887);
			RTBGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675888);
			RTBGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675889);
			RTBGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675890);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetStage_2502303021_Private_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675891);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___SetStage_2502303021_Private_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675892);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_SetStage_2502303021_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675893);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetBetMultiplier_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675894);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___SetBetMultiplier_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675895);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_SetBetMultiplier_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675896);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675897);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675898);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675899);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_NotifyAnswer_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675900);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___NotifyAnswer_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675901);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_NotifyAnswer_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675902);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_QuestionDone_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675903);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___QuestionDone_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675904);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_QuestionDone_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675905);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675906);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675907);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675908);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675909);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675910);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675911);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675912);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675913);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675914);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Server_TryNextStage_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675915);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___TryNextStage_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675916);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Server_TryNextStage_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675917);
			RTBGameController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100675918);
		}

		// Token: 0x17001D80 RID: 7552
		// (get) Token: 0x06005F95 RID: 24469 RVA: 0x001C68C4 File Offset: 0x001C4AC4
		// (set) Token: 0x06005F96 RID: 24470 RVA: 0x001C6900 File Offset: 0x001C4B00
		public unsafe RTBGameController.EStage CurrentStage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D81 RID: 7553
		// (get) Token: 0x06005F97 RID: 24471 RVA: 0x001C6940 File Offset: 0x001C4B40
		// (set) Token: 0x06005F98 RID: 24472 RVA: 0x001C697C File Offset: 0x001C4B7C
		public unsafe bool IsQuestionActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_IsQuestionActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_set_IsQuestionActive_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D82 RID: 7554
		// (get) Token: 0x06005F99 RID: 24473 RVA: 0x001C69BC File Offset: 0x001C4BBC
		// (set) Token: 0x06005F9A RID: 24474 RVA: 0x001C69F8 File Offset: 0x001C4BF8
		public unsafe float LocalPlayerBetMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_LocalPlayerBetMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_set_LocalPlayerBetMultiplier_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D83 RID: 7555
		// (get) Token: 0x06005F9B RID: 24475 RVA: 0x001C6A38 File Offset: 0x001C4C38
		public unsafe float MultipliedLocalPlayerBet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_MultipliedLocalPlayerBet_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001D84 RID: 7556
		// (get) Token: 0x06005F9C RID: 24476 RVA: 0x001C6A74 File Offset: 0x001C4C74
		// (set) Token: 0x06005F9D RID: 24477 RVA: 0x001C6AB0 File Offset: 0x001C4CB0
		public unsafe float RemainingAnswerTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_RemainingAnswerTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_set_RemainingAnswerTime_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D85 RID: 7557
		// (get) Token: 0x06005F9E RID: 24478 RVA: 0x001C6AF0 File Offset: 0x001C4CF0
		public unsafe bool IsLocalPlayerInCurrentRound
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 203993, RefRangeEnd = 204004, XrefRangeStart = 203985, XrefRangeEnd = 203993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005F9F RID: 24479 RVA: 0x001C6B2C File Offset: 0x001C4D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204004, XrefRangeEnd = 204006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FA0 RID: 24480 RVA: 0x001C6B68 File Offset: 0x001C4D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204006, XrefRangeEnd = 204013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_Open_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FA1 RID: 24481 RVA: 0x001C6BA4 File Offset: 0x001C4DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204013, XrefRangeEnd = 204022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_OnClose_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FA2 RID: 24482 RVA: 0x001C6BE0 File Offset: 0x001C4DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204022, XrefRangeEnd = 204027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FA3 RID: 24483 RVA: 0x001C6C30 File Offset: 0x001C4E30
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 204049, RefRangeEnd = 204054, XrefRangeStart = 204027, XrefRangeEnd = 204049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStage(RTBGameController.EStage stage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_SetStage_Private_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FA4 RID: 24484 RVA: 0x001C6C70 File Offset: 0x001C4E70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204071, RefRangeEnd = 204072, XrefRangeStart = 204054, XrefRangeEnd = 204071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunRound(RTBGameController.EStage stage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RunRound_Private_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FA5 RID: 24485 RVA: 0x001C6CB0 File Offset: 0x001C4EB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 204092, RefRangeEnd = 204095, XrefRangeStart = 204072, XrefRangeEnd = 204092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBetMultiplier(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_SetBetMultiplier_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FA6 RID: 24486 RVA: 0x001C6CF0 File Offset: 0x001C4EF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204119, RefRangeEnd = 204120, XrefRangeStart = 204095, XrefRangeEnd = 204119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_EndGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FA7 RID: 24487 RVA: 0x001C6D24 File Offset: 0x001C4F24
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 204164, RefRangeEnd = 204170, XrefRangeStart = 204120, XrefRangeEnd = 204164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveLocalPlayerFromGame(bool payout, float cameraDelay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref payout;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FA8 RID: 24488 RVA: 0x001C6D70 File Offset: 0x001C4F70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204171, RefRangeEnd = 204172, XrefRangeStart = 204170, XrefRangeEnd = 204171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCurrentRoundEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005FA9 RID: 24489 RVA: 0x001C6DAC File Offset: 0x001C4FAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204184, RefRangeEnd = 204185, XrefRangeStart = 204172, XrefRangeEnd = 204184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAnswerIndex(RTBGameController.EStage stage, PlayingCard.CardData card)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref card;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetAnswerIndex_Private_Single_EStage_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005FAA RID: 24490 RVA: 0x001C6E04 File Offset: 0x001C5004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204185, XrefRangeEnd = 204207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyAnswer(float answerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref answerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_NotifyAnswer_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FAB RID: 24491 RVA: 0x001C6E44 File Offset: 0x001C5044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204207, XrefRangeEnd = 204228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QuestionDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_QuestionDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FAC RID: 24492 RVA: 0x001C6E78 File Offset: 0x001C5078
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204291, RefRangeEnd = 204292, XrefRangeStart = 204228, XrefRangeEnd = 204291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetQuestionsAndAnswers(RTBGameController.EStage stage, out string question, out Il2CppStringArray answers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stage;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetQuestionsAndAnswers_Private_Void_EStage_byref_String_byref_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			question = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			answers = ((intPtr5 == 0) ? null : new Il2CppStringArray(intPtr5));
		}

		// Token: 0x06005FAD RID: 24493 RVA: 0x001C6EF4 File Offset: 0x001C50F4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 204314, RefRangeEnd = 204319, XrefRangeStart = 204292, XrefRangeEnd = 204314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCards()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_ResetCards_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FAE RID: 24494 RVA: 0x001C6F28 File Offset: 0x001C5128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204319, XrefRangeEnd = 204341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayerToCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FAF RID: 24495 RVA: 0x001C6F6C File Offset: 0x001C516C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204341, XrefRangeEnd = 204363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestRemovePlayerFromCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FB0 RID: 24496 RVA: 0x001C6FB0 File Offset: 0x001C51B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 204385, RefRangeEnd = 204388, XrefRangeStart = 204363, XrefRangeEnd = 204385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePlayerFromCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FB1 RID: 24497 RVA: 0x001C6FF4 File Offset: 0x001C51F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204388, XrefRangeEnd = 204399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayingCard.CardData PullCardFromDeck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_PullCardFromDeck_Private_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005FB2 RID: 24498 RVA: 0x001C7030 File Offset: 0x001C5230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204399, XrefRangeEnd = 204402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreAllPlayersReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005FB3 RID: 24499 RVA: 0x001C706C File Offset: 0x001C526C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 204415, RefRangeEnd = 204417, XrefRangeStart = 204402, XrefRangeEnd = 204415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPlayersReadyCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005FB4 RID: 24500 RVA: 0x001C70A8 File Offset: 0x001C52A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 204423, RefRangeEnd = 204426, XrefRangeStart = 204417, XrefRangeEnd = 204423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocalPlayerAnswer(float answer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref answer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_SetLocalPlayerAnswer_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FB5 RID: 24501 RVA: 0x001C70E8 File Offset: 0x001C52E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204426, XrefRangeEnd = 204443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAnsweredPlayersCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetAnsweredPlayersCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005FB6 RID: 24502 RVA: 0x001C7124 File Offset: 0x001C5324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204443, XrefRangeEnd = 204465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ToggleLocalPlayerReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FB7 RID: 24503 RVA: 0x001C7160 File Offset: 0x001C5360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204465, XrefRangeEnd = 204486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryNextStage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_TryNextStage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FB8 RID: 24504 RVA: 0x001C7194 File Offset: 0x001C5394
		[CallerCount(0)]
		public unsafe int GetCardNumberValue(PlayingCard.CardData card)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref card;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetCardNumberValue_Private_Int32_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005FB9 RID: 24505 RVA: 0x001C71E0 File Offset: 0x001C53E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204486, RefRangeEnd = 204487, XrefRangeStart = 204486, XrefRangeEnd = 204486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetNetBetMultiplier(RTBGameController.EStage stage)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetNetBetMultiplier_Public_Static_Single_EStage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005FBA RID: 24506 RVA: 0x001C7220 File Offset: 0x001C5420
		[CallerCount(0)]
		public unsafe override bool IsWaitingForPlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_IsWaitingForPlayers_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005FBB RID: 24507 RVA: 0x001C7268 File Offset: 0x001C5468
		[CallerCount(0)]
		public unsafe override void GetBetLimits(out float minimum, out float maximum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &minimum;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maximum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_GetBetLimits_Public_Virtual_Void_byref_Single_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FBC RID: 24508 RVA: 0x001C72C0 File Offset: 0x001C54C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204487, XrefRangeEnd = 204507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTBGameController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FBD RID: 24509 RVA: 0x001C72FC File Offset: 0x001C54FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204507, XrefRangeEnd = 204564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FBE RID: 24510 RVA: 0x001C7338 File Offset: 0x001C5538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204564, XrefRangeEnd = 204565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FBF RID: 24511 RVA: 0x001C7374 File Offset: 0x001C5574
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FC0 RID: 24512 RVA: 0x001C73B0 File Offset: 0x001C55B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204565, XrefRangeEnd = 204575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetStage_2502303021(RTBGameController.EStage stage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetStage_2502303021_Private_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FC1 RID: 24513 RVA: 0x001C73F0 File Offset: 0x001C55F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 204591, RefRangeEnd = 204593, XrefRangeStart = 204575, XrefRangeEnd = 204591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetStage_2502303021(RTBGameController.EStage stage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___SetStage_2502303021_Private_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FC2 RID: 24514 RVA: 0x001C7430 File Offset: 0x001C5630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204593, XrefRangeEnd = 204597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetStage_2502303021(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_SetStage_2502303021_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FC3 RID: 24515 RVA: 0x001C7480 File Offset: 0x001C5680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204597, XrefRangeEnd = 204607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetBetMultiplier_431000436(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetBetMultiplier_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FC4 RID: 24516 RVA: 0x001C74C0 File Offset: 0x001C56C0
		[CallerCount(0)]
		public unsafe void RpcLogic___SetBetMultiplier_431000436(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___SetBetMultiplier_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FC5 RID: 24517 RVA: 0x001C7500 File Offset: 0x001C5700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204607, XrefRangeEnd = 204610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetBetMultiplier_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_SetBetMultiplier_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FC6 RID: 24518 RVA: 0x001C7550 File Offset: 0x001C5750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204610, XrefRangeEnd = 204619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EndGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FC7 RID: 24519 RVA: 0x001C7584 File Offset: 0x001C5784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204619, XrefRangeEnd = 204623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___EndGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FC8 RID: 24520 RVA: 0x001C75B8 File Offset: 0x001C57B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204623, XrefRangeEnd = 204629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EndGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FC9 RID: 24521 RVA: 0x001C7608 File Offset: 0x001C5808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204629, XrefRangeEnd = 204639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_NotifyAnswer_431000436(float answerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref answerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_NotifyAnswer_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FCA RID: 24522 RVA: 0x001C7648 File Offset: 0x001C5848
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 204659, RefRangeEnd = 204662, XrefRangeStart = 204639, XrefRangeEnd = 204659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___NotifyAnswer_431000436(float answerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref answerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___NotifyAnswer_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FCB RID: 24523 RVA: 0x001C7688 File Offset: 0x001C5888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204662, XrefRangeEnd = 204666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_NotifyAnswer_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_NotifyAnswer_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FCC RID: 24524 RVA: 0x001C76D8 File Offset: 0x001C58D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204666, XrefRangeEnd = 204675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_QuestionDone_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_QuestionDone_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FCD RID: 24525 RVA: 0x001C770C File Offset: 0x001C590C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 204683, RefRangeEnd = 204688, XrefRangeStart = 204675, XrefRangeEnd = 204683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___QuestionDone_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___QuestionDone_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FCE RID: 24526 RVA: 0x001C7740 File Offset: 0x001C5940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204688, XrefRangeEnd = 204691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_QuestionDone_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_QuestionDone_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FCF RID: 24527 RVA: 0x001C7790 File Offset: 0x001C5990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204691, XrefRangeEnd = 204701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD0 RID: 24528 RVA: 0x001C77D4 File Offset: 0x001C59D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 204714, RefRangeEnd = 204717, XrefRangeStart = 204701, XrefRangeEnd = 204714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD1 RID: 24529 RVA: 0x001C7818 File Offset: 0x001C5A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204717, XrefRangeEnd = 204721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddPlayerToCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD2 RID: 24530 RVA: 0x001C7868 File Offset: 0x001C5A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204721, XrefRangeEnd = 204731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD3 RID: 24531 RVA: 0x001C78AC File Offset: 0x001C5AAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 204385, RefRangeEnd = 204388, XrefRangeStart = 204385, XrefRangeEnd = 204388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD4 RID: 24532 RVA: 0x001C78F0 File Offset: 0x001C5AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204731, XrefRangeEnd = 204735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD5 RID: 24533 RVA: 0x001C7954 File Offset: 0x001C5B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204735, XrefRangeEnd = 204745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD6 RID: 24534 RVA: 0x001C7998 File Offset: 0x001C5B98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 204761, RefRangeEnd = 204764, XrefRangeStart = 204745, XrefRangeEnd = 204761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD7 RID: 24535 RVA: 0x001C79DC File Offset: 0x001C5BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204764, XrefRangeEnd = 204768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD8 RID: 24536 RVA: 0x001C7A2C File Offset: 0x001C5C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204768, XrefRangeEnd = 204777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_TryNextStage_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Server_TryNextStage_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD9 RID: 24537 RVA: 0x001C7A60 File Offset: 0x001C5C60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 204806, RefRangeEnd = 204809, XrefRangeStart = 204777, XrefRangeEnd = 204806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___TryNextStage_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___TryNextStage_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FDA RID: 24538 RVA: 0x001C7A94 File Offset: 0x001C5C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204809, XrefRangeEnd = 204812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_TryNextStage_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Server_TryNextStage_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FDB RID: 24539 RVA: 0x001C7AF8 File Offset: 0x001C5CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204812, XrefRangeEnd = 204814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FDC RID: 24540 RVA: 0x0002D223 File Offset: 0x0002B423
		public RTBGameController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D68 RID: 7528
		// (get) Token: 0x06005FDD RID: 24541 RVA: 0x001C7B34 File Offset: 0x001C5D34
		// (set) Token: 0x06005FDE RID: 24542 RVA: 0x0002D22C File Offset: 0x0002B42C
		public unsafe static int MinimumBet
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RTBGameController.NativeFieldInfoPtr_MinimumBet, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RTBGameController.NativeFieldInfoPtr_MinimumBet, (void*)(&value));
			}
		}

		// Token: 0x17001D69 RID: 7529
		// (get) Token: 0x06005FDF RID: 24543 RVA: 0x001C7B50 File Offset: 0x001C5D50
		// (set) Token: 0x06005FE0 RID: 24544 RVA: 0x0002D23A File Offset: 0x0002B43A
		public unsafe static int MaximumBet
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RTBGameController.NativeFieldInfoPtr_MaximumBet, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RTBGameController.NativeFieldInfoPtr_MaximumBet, (void*)(&value));
			}
		}

		// Token: 0x17001D6A RID: 7530
		// (get) Token: 0x06005FE1 RID: 24545 RVA: 0x001C7B6C File Offset: 0x001C5D6C
		// (set) Token: 0x06005FE2 RID: 24546 RVA: 0x0002D248 File Offset: 0x0002B448
		public unsafe static float AnswerMaxTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RTBGameController.NativeFieldInfoPtr_AnswerMaxTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RTBGameController.NativeFieldInfoPtr_AnswerMaxTime, (void*)(&value));
			}
		}

		// Token: 0x17001D6B RID: 7531
		// (get) Token: 0x06005FE3 RID: 24547 RVA: 0x001C7B88 File Offset: 0x001C5D88
		// (set) Token: 0x06005FE4 RID: 24548 RVA: 0x0002D256 File Offset: 0x0002B456
		public unsafe Transform PlayCameraTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_PlayCameraTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_PlayCameraTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D6C RID: 7532
		// (get) Token: 0x06005FE5 RID: 24549 RVA: 0x001C7BB8 File Offset: 0x001C5DB8
		// (set) Token: 0x06005FE6 RID: 24550 RVA: 0x0002D275 File Offset: 0x0002B475
		public unsafe Transform FocusedCameraTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_FocusedCameraTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_FocusedCameraTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D6D RID: 7533
		// (get) Token: 0x06005FE7 RID: 24551 RVA: 0x001C7BE8 File Offset: 0x001C5DE8
		// (set) Token: 0x06005FE8 RID: 24552 RVA: 0x0002D294 File Offset: 0x0002B494
		public unsafe Il2CppReferenceArray<PlayingCard> Cards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_Cards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_Cards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D6E RID: 7534
		// (get) Token: 0x06005FE9 RID: 24553 RVA: 0x001C7C18 File Offset: 0x001C5E18
		// (set) Token: 0x06005FEA RID: 24554 RVA: 0x0002D2B3 File Offset: 0x0002B4B3
		public unsafe Il2CppReferenceArray<Transform> CardDefaultPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_CardDefaultPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_CardDefaultPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D6F RID: 7535
		// (get) Token: 0x06005FEB RID: 24555 RVA: 0x001C7C48 File Offset: 0x001C5E48
		// (set) Token: 0x06005FEC RID: 24556 RVA: 0x0002D2D2 File Offset: 0x0002B4D2
		public unsafe Transform ActiveCardPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_ActiveCardPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_ActiveCardPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D70 RID: 7536
		// (get) Token: 0x06005FED RID: 24557 RVA: 0x001C7C78 File Offset: 0x001C5E78
		// (set) Token: 0x06005FEE RID: 24558 RVA: 0x0002D2F1 File Offset: 0x0002B4F1
		public unsafe Il2CppReferenceArray<Transform> DockedCardPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_DockedCardPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_DockedCardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D71 RID: 7537
		// (get) Token: 0x06005FEF RID: 24559 RVA: 0x001C7CA8 File Offset: 0x001C5EA8
		// (set) Token: 0x06005FF0 RID: 24560 RVA: 0x0002D310 File Offset: 0x0002B510
		public unsafe RTBGameController.EStage _CurrentStage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D72 RID: 7538
		// (get) Token: 0x06005FF1 RID: 24561 RVA: 0x001C7CD0 File Offset: 0x001C5ED0
		// (set) Token: 0x06005FF2 RID: 24562 RVA: 0x0002D32B File Offset: 0x0002B52B
		public unsafe Action<RTBGameController.EStage> onStageChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onStageChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<RTBGameController.EStage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onStageChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D73 RID: 7539
		// (get) Token: 0x06005FF3 RID: 24563 RVA: 0x001C7D00 File Offset: 0x001C5F00
		// (set) Token: 0x06005FF4 RID: 24564 RVA: 0x0002D34A File Offset: 0x0002B54A
		public unsafe Action<string, Il2CppStringArray> onQuestionReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onQuestionReady);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, Il2CppStringArray>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onQuestionReady), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D74 RID: 7540
		// (get) Token: 0x06005FF5 RID: 24565 RVA: 0x001C7D30 File Offset: 0x001C5F30
		// (set) Token: 0x06005FF6 RID: 24566 RVA: 0x0002D369 File Offset: 0x0002B569
		public unsafe Action onQuestionDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onQuestionDone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onQuestionDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D75 RID: 7541
		// (get) Token: 0x06005FF7 RID: 24567 RVA: 0x001C7D60 File Offset: 0x001C5F60
		// (set) Token: 0x06005FF8 RID: 24568 RVA: 0x0002D388 File Offset: 0x0002B588
		public unsafe Action onLocalPlayerCorrect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerCorrect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerCorrect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D76 RID: 7542
		// (get) Token: 0x06005FF9 RID: 24569 RVA: 0x001C7D90 File Offset: 0x001C5F90
		// (set) Token: 0x06005FFA RID: 24570 RVA: 0x0002D3A7 File Offset: 0x0002B5A7
		public unsafe Action onLocalPlayerIncorrect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerIncorrect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerIncorrect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D77 RID: 7543
		// (get) Token: 0x06005FFB RID: 24571 RVA: 0x001C7DC0 File Offset: 0x001C5FC0
		// (set) Token: 0x06005FFC RID: 24572 RVA: 0x0002D3C6 File Offset: 0x0002B5C6
		public unsafe Action onLocalPlayerExitRound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerExitRound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerExitRound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D78 RID: 7544
		// (get) Token: 0x06005FFD RID: 24573 RVA: 0x001C7DF0 File Offset: 0x001C5FF0
		// (set) Token: 0x06005FFE RID: 24574 RVA: 0x0002D3E5 File Offset: 0x0002B5E5
		public unsafe bool _IsQuestionActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__IsQuestionActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__IsQuestionActive_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D79 RID: 7545
		// (get) Token: 0x06005FFF RID: 24575 RVA: 0x001C7E18 File Offset: 0x001C6018
		// (set) Token: 0x06006000 RID: 24576 RVA: 0x0002D400 File Offset: 0x0002B600
		public unsafe float _LocalPlayerBetMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__LocalPlayerBetMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__LocalPlayerBetMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D7A RID: 7546
		// (get) Token: 0x06006001 RID: 24577 RVA: 0x001C7E40 File Offset: 0x001C6040
		// (set) Token: 0x06006002 RID: 24578 RVA: 0x0002D41B File Offset: 0x0002B61B
		public unsafe float _RemainingAnswerTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__RemainingAnswerTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__RemainingAnswerTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D7B RID: 7547
		// (get) Token: 0x06006003 RID: 24579 RVA: 0x001C7E68 File Offset: 0x001C6068
		// (set) Token: 0x06006004 RID: 24580 RVA: 0x0002D436 File Offset: 0x0002B636
		public unsafe List<Player> playersInCurrentRound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_playersInCurrentRound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_playersInCurrentRound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D7C RID: 7548
		// (get) Token: 0x06006005 RID: 24581 RVA: 0x001C7E98 File Offset: 0x001C6098
		// (set) Token: 0x06006006 RID: 24582 RVA: 0x0002D455 File Offset: 0x0002B655
		public unsafe List<PlayingCard.CardData> cardsInDeck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_cardsInDeck);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard.CardData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_cardsInDeck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D7D RID: 7549
		// (get) Token: 0x06006007 RID: 24583 RVA: 0x001C7EC8 File Offset: 0x001C60C8
		// (set) Token: 0x06006008 RID: 24584 RVA: 0x0002D474 File Offset: 0x0002B674
		public unsafe List<PlayingCard.CardData> drawnCards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_drawnCards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard.CardData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_drawnCards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D7E RID: 7550
		// (get) Token: 0x06006009 RID: 24585 RVA: 0x001C7EF8 File Offset: 0x001C60F8
		// (set) Token: 0x0600600A RID: 24586 RVA: 0x0002D493 File Offset: 0x0002B693
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001D7F RID: 7551
		// (get) Token: 0x0600600B RID: 24587 RVA: 0x001C7F20 File Offset: 0x001C6120
		// (set) Token: 0x0600600C RID: 24588 RVA: 0x0002D4AE File Offset: 0x0002B6AE
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040041D5 RID: 16853
		private static readonly IntPtr NativeFieldInfoPtr_MinimumBet;

		// Token: 0x040041D6 RID: 16854
		private static readonly IntPtr NativeFieldInfoPtr_MaximumBet;

		// Token: 0x040041D7 RID: 16855
		private static readonly IntPtr NativeFieldInfoPtr_AnswerMaxTime;

		// Token: 0x040041D8 RID: 16856
		private static readonly IntPtr NativeFieldInfoPtr_PlayCameraTransform;

		// Token: 0x040041D9 RID: 16857
		private static readonly IntPtr NativeFieldInfoPtr_FocusedCameraTransform;

		// Token: 0x040041DA RID: 16858
		private static readonly IntPtr NativeFieldInfoPtr_Cards;

		// Token: 0x040041DB RID: 16859
		private static readonly IntPtr NativeFieldInfoPtr_CardDefaultPositions;

		// Token: 0x040041DC RID: 16860
		private static readonly IntPtr NativeFieldInfoPtr_ActiveCardPosition;

		// Token: 0x040041DD RID: 16861
		private static readonly IntPtr NativeFieldInfoPtr_DockedCardPositions;

		// Token: 0x040041DE RID: 16862
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStage_k__BackingField;

		// Token: 0x040041DF RID: 16863
		private static readonly IntPtr NativeFieldInfoPtr_onStageChange;

		// Token: 0x040041E0 RID: 16864
		private static readonly IntPtr NativeFieldInfoPtr_onQuestionReady;

		// Token: 0x040041E1 RID: 16865
		private static readonly IntPtr NativeFieldInfoPtr_onQuestionDone;

		// Token: 0x040041E2 RID: 16866
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerCorrect;

		// Token: 0x040041E3 RID: 16867
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerIncorrect;

		// Token: 0x040041E4 RID: 16868
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerExitRound;

		// Token: 0x040041E5 RID: 16869
		private static readonly IntPtr NativeFieldInfoPtr__IsQuestionActive_k__BackingField;

		// Token: 0x040041E6 RID: 16870
		private static readonly IntPtr NativeFieldInfoPtr__LocalPlayerBetMultiplier_k__BackingField;

		// Token: 0x040041E7 RID: 16871
		private static readonly IntPtr NativeFieldInfoPtr__RemainingAnswerTime_k__BackingField;

		// Token: 0x040041E8 RID: 16872
		private static readonly IntPtr NativeFieldInfoPtr_playersInCurrentRound;

		// Token: 0x040041E9 RID: 16873
		private static readonly IntPtr NativeFieldInfoPtr_cardsInDeck;

		// Token: 0x040041EA RID: 16874
		private static readonly IntPtr NativeFieldInfoPtr_drawnCards;

		// Token: 0x040041EB RID: 16875
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040041EC RID: 16876
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040041ED RID: 16877
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0;

		// Token: 0x040041EE RID: 16878
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0;

		// Token: 0x040041EF RID: 16879
		private static readonly IntPtr NativeMethodInfoPtr_get_IsQuestionActive_Public_get_Boolean_0;

		// Token: 0x040041F0 RID: 16880
		private static readonly IntPtr NativeMethodInfoPtr_set_IsQuestionActive_Private_set_Void_Boolean_0;

		// Token: 0x040041F1 RID: 16881
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerBetMultiplier_Public_get_Single_0;

		// Token: 0x040041F2 RID: 16882
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalPlayerBetMultiplier_Private_set_Void_Single_0;

		// Token: 0x040041F3 RID: 16883
		private static readonly IntPtr NativeMethodInfoPtr_get_MultipliedLocalPlayerBet_Public_get_Single_0;

		// Token: 0x040041F4 RID: 16884
		private static readonly IntPtr NativeMethodInfoPtr_get_RemainingAnswerTime_Public_get_Single_0;

		// Token: 0x040041F5 RID: 16885
		private static readonly IntPtr NativeMethodInfoPtr_set_RemainingAnswerTime_Private_set_Void_Single_0;

		// Token: 0x040041F6 RID: 16886
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0;

		// Token: 0x040041F7 RID: 16887
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040041F8 RID: 16888
		private static readonly IntPtr NativeMethodInfoPtr_Open_Protected_Virtual_Void_1;

		// Token: 0x040041F9 RID: 16889
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Protected_Virtual_Void_1;

		// Token: 0x040041FA RID: 16890
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0;

		// Token: 0x040041FB RID: 16891
		private static readonly IntPtr NativeMethodInfoPtr_SetStage_Private_Void_EStage_0;

		// Token: 0x040041FC RID: 16892
		private static readonly IntPtr NativeMethodInfoPtr_RunRound_Private_Void_EStage_0;

		// Token: 0x040041FD RID: 16893
		private static readonly IntPtr NativeMethodInfoPtr_SetBetMultiplier_Private_Void_Single_0;

		// Token: 0x040041FE RID: 16894
		private static readonly IntPtr NativeMethodInfoPtr_EndGame_Private_Void_0;

		// Token: 0x040041FF RID: 16895
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_Boolean_Single_0;

		// Token: 0x04004200 RID: 16896
		private static readonly IntPtr NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0;

		// Token: 0x04004201 RID: 16897
		private static readonly IntPtr NativeMethodInfoPtr_GetAnswerIndex_Private_Single_EStage_CardData_0;

		// Token: 0x04004202 RID: 16898
		private static readonly IntPtr NativeMethodInfoPtr_NotifyAnswer_Private_Void_Single_0;

		// Token: 0x04004203 RID: 16899
		private static readonly IntPtr NativeMethodInfoPtr_QuestionDone_Private_Void_0;

		// Token: 0x04004204 RID: 16900
		private static readonly IntPtr NativeMethodInfoPtr_GetQuestionsAndAnswers_Private_Void_EStage_byref_String_byref_Il2CppStringArray_0;

		// Token: 0x04004205 RID: 16901
		private static readonly IntPtr NativeMethodInfoPtr_ResetCards_Private_Void_0;

		// Token: 0x04004206 RID: 16902
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x04004207 RID: 16903
		private static readonly IntPtr NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x04004208 RID: 16904
		private static readonly IntPtr NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x04004209 RID: 16905
		private static readonly IntPtr NativeMethodInfoPtr_PullCardFromDeck_Private_CardData_0;

		// Token: 0x0400420A RID: 16906
		private static readonly IntPtr NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0;

		// Token: 0x0400420B RID: 16907
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0;

		// Token: 0x0400420C RID: 16908
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalPlayerAnswer_Public_Void_Single_0;

		// Token: 0x0400420D RID: 16909
		private static readonly IntPtr NativeMethodInfoPtr_GetAnsweredPlayersCount_Public_Int32_0;

		// Token: 0x0400420E RID: 16910
		private static readonly IntPtr NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Virtual_Void_0;

		// Token: 0x0400420F RID: 16911
		private static readonly IntPtr NativeMethodInfoPtr_TryNextStage_Private_Void_0;

		// Token: 0x04004210 RID: 16912
		private static readonly IntPtr NativeMethodInfoPtr_GetCardNumberValue_Private_Int32_CardData_0;

		// Token: 0x04004211 RID: 16913
		private static readonly IntPtr NativeMethodInfoPtr_GetNetBetMultiplier_Public_Static_Single_EStage_0;

		// Token: 0x04004212 RID: 16914
		private static readonly IntPtr NativeMethodInfoPtr_IsWaitingForPlayers_Public_Virtual_Boolean_0;

		// Token: 0x04004213 RID: 16915
		private static readonly IntPtr NativeMethodInfoPtr_GetBetLimits_Public_Virtual_Void_byref_Single_byref_Single_0;

		// Token: 0x04004214 RID: 16916
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004215 RID: 16917
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004216 RID: 16918
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004217 RID: 16919
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004218 RID: 16920
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetStage_2502303021_Private_Void_EStage_0;

		// Token: 0x04004219 RID: 16921
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetStage_2502303021_Private_Void_EStage_0;

		// Token: 0x0400421A RID: 16922
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetStage_2502303021_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400421B RID: 16923
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetBetMultiplier_431000436_Private_Void_Single_0;

		// Token: 0x0400421C RID: 16924
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetBetMultiplier_431000436_Private_Void_Single_0;

		// Token: 0x0400421D RID: 16925
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetBetMultiplier_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400421E RID: 16926
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0;

		// Token: 0x0400421F RID: 16927
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0;

		// Token: 0x04004220 RID: 16928
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004221 RID: 16929
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_NotifyAnswer_431000436_Private_Void_Single_0;

		// Token: 0x04004222 RID: 16930
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___NotifyAnswer_431000436_Private_Void_Single_0;

		// Token: 0x04004223 RID: 16931
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_NotifyAnswer_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004224 RID: 16932
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_QuestionDone_2166136261_Private_Void_0;

		// Token: 0x04004225 RID: 16933
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___QuestionDone_2166136261_Private_Void_0;

		// Token: 0x04004226 RID: 16934
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_QuestionDone_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004227 RID: 16935
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004228 RID: 16936
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004229 RID: 16937
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400422A RID: 16938
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400422B RID: 16939
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400422C RID: 16940
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400422D RID: 16941
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400422E RID: 16942
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400422F RID: 16943
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004230 RID: 16944
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_TryNextStage_2166136261_Private_Void_0;

		// Token: 0x04004231 RID: 16945
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___TryNextStage_2166136261_Private_Void_0;

		// Token: 0x04004232 RID: 16946
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_TryNextStage_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004233 RID: 16947
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000B28 RID: 2856
		[OriginalName("Assembly-CSharp.dll", "", "EStage")]
		public enum EStage
		{
			// Token: 0x04009C57 RID: 40023
			WaitingForPlayers,
			// Token: 0x04009C58 RID: 40024
			RedOrBlack,
			// Token: 0x04009C59 RID: 40025
			HigherOrLower,
			// Token: 0x04009C5A RID: 40026
			InsideOrOutside,
			// Token: 0x04009C5B RID: 40027
			Suit
		}

		// Token: 0x02000B29 RID: 2857
		[ObfuscatedName("ScheduleOne.Casino.RTBGameController+<>c__DisplayClass44_0")]
		public sealed class __c__DisplayClass44_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E652 RID: 58962 RVA: 0x00383794 File Offset: 0x00381994
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass44_0()
			{
				Il2CppClassPointerStore<RTBGameController.__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<>c__DisplayClass44_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass44_0>.NativeClassPtr);
				RTBGameController.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass44_0>.NativeClassPtr, "<>4__this");
				RTBGameController.__c__DisplayClass44_0.NativeFieldInfoPtr_stage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass44_0>.NativeClassPtr, "stage");
				RTBGameController.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass44_0>.NativeClassPtr, 100675919);
				RTBGameController.__c__DisplayClass44_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass44_0>.NativeClassPtr, 100675920);
				RTBGameController.__c__DisplayClass44_0.NativeMethodInfoPtr__RunRound_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass44_0>.NativeClassPtr, 100675921);
			}

			// Token: 0x0600E653 RID: 58963 RVA: 0x00383824 File Offset: 0x00381A24
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass44_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass44_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E654 RID: 58964 RVA: 0x00383860 File Offset: 0x00381A60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203964, XrefRangeEnd = 203969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass44_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E655 RID: 58965 RVA: 0x003838A0 File Offset: 0x00381AA0
			[CallerCount(0)]
			public unsafe bool _RunRound_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass44_0.NativeMethodInfoPtr__RunRound_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E656 RID: 58966 RVA: 0x0006C9F7 File Offset: 0x0006ABF7
			public __c__DisplayClass44_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045EA RID: 17898
			// (get) Token: 0x0600E657 RID: 58967 RVA: 0x003838DC File Offset: 0x00381ADC
			// (set) Token: 0x0600E658 RID: 58968 RVA: 0x0006CA00 File Offset: 0x0006AC00
			public unsafe RTBGameController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBGameController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045EB RID: 17899
			// (get) Token: 0x0600E659 RID: 58969 RVA: 0x0038390C File Offset: 0x00381B0C
			// (set) Token: 0x0600E65A RID: 58970 RVA: 0x0006CA1F File Offset: 0x0006AC1F
			public unsafe RTBGameController.EStage stage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass44_0.NativeFieldInfoPtr_stage);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass44_0.NativeFieldInfoPtr_stage)) = value;
				}
			}

			// Token: 0x04009C5C RID: 40028
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009C5D RID: 40029
			private static readonly IntPtr NativeFieldInfoPtr_stage;

			// Token: 0x04009C5E RID: 40030
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C5F RID: 40031
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009C60 RID: 40032
			private static readonly IntPtr NativeMethodInfoPtr__RunRound_b__1_Internal_Boolean_0;

			// Token: 0x02000DD9 RID: 3545
			[ObfuscatedName("ScheduleOne.Casino.RTBGameController+<>c__DisplayClass44_0+<<RunRound>g__RunRound|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FFDC RID: 65500 RVA: 0x003CD110 File Offset: 0x003CB310
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique()
				{
					Il2CppClassPointerStore<RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass44_0>.NativeClassPtr, "<<RunRound>g__RunRound|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr);
					RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<>1__state");
					RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<>2__current");
					RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<>4__this");
					RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr__activeCard_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<activeCard>5__2");
					RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100675922);
					RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100675923);
					RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100675924);
					RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100675925);
					RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100675926);
					RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100675927);
				}

				// Token: 0x0600FFDD RID: 65501 RVA: 0x003CD204 File Offset: 0x003CB404
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FFDE RID: 65502 RVA: 0x003CD24C File Offset: 0x003CB44C
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FFDF RID: 65503 RVA: 0x003CD280 File Offset: 0x003CB480
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203781, XrefRangeEnd = 203959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004DEF RID: 19951
				// (get) Token: 0x0600FFE0 RID: 65504 RVA: 0x003CD2BC File Offset: 0x003CB4BC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FFE1 RID: 65505 RVA: 0x003CD2FC File Offset: 0x003CB4FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203959, XrefRangeEnd = 203964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004DF0 RID: 19952
				// (get) Token: 0x0600FFE2 RID: 65506 RVA: 0x003CD330 File Offset: 0x003CB530
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FFE3 RID: 65507 RVA: 0x00079418 File Offset: 0x00077618
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004DEB RID: 19947
				// (get) Token: 0x0600FFE4 RID: 65508 RVA: 0x003CD370 File Offset: 0x003CB570
				// (set) Token: 0x0600FFE5 RID: 65509 RVA: 0x00079421 File Offset: 0x00077621
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004DEC RID: 19948
				// (get) Token: 0x0600FFE6 RID: 65510 RVA: 0x003CD398 File Offset: 0x003CB598
				// (set) Token: 0x0600FFE7 RID: 65511 RVA: 0x0007943C File Offset: 0x0007763C
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DED RID: 19949
				// (get) Token: 0x0600FFE8 RID: 65512 RVA: 0x003CD3C8 File Offset: 0x003CB5C8
				// (set) Token: 0x0600FFE9 RID: 65513 RVA: 0x0007945B File Offset: 0x0007765B
				public unsafe RTBGameController.__c__DisplayClass44_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBGameController.__c__DisplayClass44_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DEE RID: 19950
				// (get) Token: 0x0600FFEA RID: 65514 RVA: 0x003CD3F8 File Offset: 0x003CB5F8
				// (set) Token: 0x0600FFEB RID: 65515 RVA: 0x0007947A File Offset: 0x0007767A
				public unsafe PlayingCard _activeCard_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr__activeCard_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayingCard>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr__activeCard_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AC5D RID: 44125
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AC5E RID: 44126
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AC5F RID: 44127
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AC60 RID: 44128
				private static readonly IntPtr NativeFieldInfoPtr__activeCard_5__2;

				// Token: 0x0400AC61 RID: 44129
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AC62 RID: 44130
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC63 RID: 44131
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AC64 RID: 44132
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AC65 RID: 44133
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC66 RID: 44134
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B2A RID: 2858
		[ObfuscatedName("ScheduleOne.Casino.RTBGameController+<>c__DisplayClass47_0")]
		public sealed class __c__DisplayClass47_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E65B RID: 58971 RVA: 0x00383934 File Offset: 0x00381B34
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass47_0()
			{
				Il2CppClassPointerStore<RTBGameController.__c__DisplayClass47_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<>c__DisplayClass47_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass47_0>.NativeClassPtr);
				RTBGameController.__c__DisplayClass47_0.NativeFieldInfoPtr_cameraDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass47_0>.NativeClassPtr, "cameraDelay");
				RTBGameController.__c__DisplayClass47_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass47_0>.NativeClassPtr, "<>4__this");
				RTBGameController.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass47_0>.NativeClassPtr, 100675928);
				RTBGameController.__c__DisplayClass47_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass47_0>.NativeClassPtr, 100675929);
			}

			// Token: 0x0600E65C RID: 58972 RVA: 0x003839B0 File Offset: 0x00381BB0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass47_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass47_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E65D RID: 58973 RVA: 0x003839EC File Offset: 0x00381BEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203980, XrefRangeEnd = 203985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass47_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E65E RID: 58974 RVA: 0x0006CA3A File Offset: 0x0006AC3A
			public __c__DisplayClass47_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045EC RID: 17900
			// (get) Token: 0x0600E65F RID: 58975 RVA: 0x00383A2C File Offset: 0x00381C2C
			// (set) Token: 0x0600E660 RID: 58976 RVA: 0x0006CA43 File Offset: 0x0006AC43
			public unsafe float cameraDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass47_0.NativeFieldInfoPtr_cameraDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass47_0.NativeFieldInfoPtr_cameraDelay)) = value;
				}
			}

			// Token: 0x170045ED RID: 17901
			// (get) Token: 0x0600E661 RID: 58977 RVA: 0x00383A54 File Offset: 0x00381C54
			// (set) Token: 0x0600E662 RID: 58978 RVA: 0x0006CA5E File Offset: 0x0006AC5E
			public unsafe RTBGameController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass47_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBGameController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass47_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009C61 RID: 40033
			private static readonly IntPtr NativeFieldInfoPtr_cameraDelay;

			// Token: 0x04009C62 RID: 40034
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009C63 RID: 40035
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C64 RID: 40036
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DDA RID: 3546
			[ObfuscatedName("ScheduleOne.Casino.RTBGameController+<>c__DisplayClass47_0+<<RemoveLocalPlayerFromGame>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FFEC RID: 65516 RVA: 0x003CD428 File Offset: 0x003CB628
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass47_0>.NativeClassPtr, "<<RemoveLocalPlayerFromGame>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675930);
					RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675931);
					RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675932);
					RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675933);
					RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675934);
					RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675935);
				}

				// Token: 0x0600FFED RID: 65517 RVA: 0x003CD508 File Offset: 0x003CB708
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FFEE RID: 65518 RVA: 0x003CD550 File Offset: 0x003CB750
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FFEF RID: 65519 RVA: 0x003CD584 File Offset: 0x003CB784
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203969, XrefRangeEnd = 203975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004DF4 RID: 19956
				// (get) Token: 0x0600FFF0 RID: 65520 RVA: 0x003CD5C0 File Offset: 0x003CB7C0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FFF1 RID: 65521 RVA: 0x003CD600 File Offset: 0x003CB800
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203975, XrefRangeEnd = 203980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004DF5 RID: 19957
				// (get) Token: 0x0600FFF2 RID: 65522 RVA: 0x003CD634 File Offset: 0x003CB834
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FFF3 RID: 65523 RVA: 0x00079499 File Offset: 0x00077699
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004DF1 RID: 19953
				// (get) Token: 0x0600FFF4 RID: 65524 RVA: 0x003CD674 File Offset: 0x003CB874
				// (set) Token: 0x0600FFF5 RID: 65525 RVA: 0x000794A2 File Offset: 0x000776A2
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004DF2 RID: 19954
				// (get) Token: 0x0600FFF6 RID: 65526 RVA: 0x003CD69C File Offset: 0x003CB89C
				// (set) Token: 0x0600FFF7 RID: 65527 RVA: 0x000794BD File Offset: 0x000776BD
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DF3 RID: 19955
				// (get) Token: 0x0600FFF8 RID: 65528 RVA: 0x003CD6CC File Offset: 0x003CB8CC
				// (set) Token: 0x0600FFF9 RID: 65529 RVA: 0x000794DC File Offset: 0x000776DC
				public unsafe RTBGameController.__c__DisplayClass47_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBGameController.__c__DisplayClass47_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass47_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AC67 RID: 44135
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AC68 RID: 44136
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AC69 RID: 44137
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AC6A RID: 44138
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AC6B RID: 44139
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC6C RID: 44140
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AC6D RID: 44141
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AC6E RID: 44142
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC6F RID: 44143
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
