using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x020000FD RID: 253
	public class Pong : TVApp
	{
		// Token: 0x06001801 RID: 6145 RVA: 0x000CABFC File Offset: 0x000C8DFC
		// Note: this type is marked as 'beforefieldinit'.
		static Pong()
		{
			Il2CppClassPointerStore<Pong>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "Pong");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pong>.NativeClassPtr);
			Pong.NativeFieldInfoPtr__GameMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "<GameMode>k__BackingField");
			Pong.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "<State>k__BackingField");
			Pong.NativeFieldInfoPtr__LeftScore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "<LeftScore>k__BackingField");
			Pong.NativeFieldInfoPtr__RightScore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "<RightScore>k__BackingField");
			Pong.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "Rect");
			Pong.NativeFieldInfoPtr_LeftPaddle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "LeftPaddle");
			Pong.NativeFieldInfoPtr_RightPaddle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "RightPaddle");
			Pong.NativeFieldInfoPtr_Ball = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "Ball");
			Pong.NativeFieldInfoPtr_LeftScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "LeftScoreLabel");
			Pong.NativeFieldInfoPtr_RightScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "RightScoreLabel");
			Pong.NativeFieldInfoPtr_WinnerLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "WinnerLabel");
			Pong.NativeFieldInfoPtr_InitialVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "InitialVelocity");
			Pong.NativeFieldInfoPtr_VelocityGainPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "VelocityGainPerSecond");
			Pong.NativeFieldInfoPtr_MaxVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "MaxVelocity");
			Pong.NativeFieldInfoPtr_GoalsToWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "GoalsToWin");
			Pong.NativeFieldInfoPtr_ReactionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "ReactionTime");
			Pong.NativeFieldInfoPtr_TargetRandomization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "TargetRandomization");
			Pong.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "SpeedMultiplier");
			Pong.NativeFieldInfoPtr_onServe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onServe");
			Pong.NativeFieldInfoPtr_onLeftScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onLeftScore");
			Pong.NativeFieldInfoPtr_onRightScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onRightScore");
			Pong.NativeFieldInfoPtr_onGameOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onGameOver");
			Pong.NativeFieldInfoPtr_onLocalPlayerWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onLocalPlayerWin");
			Pong.NativeFieldInfoPtr_onReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onReset");
			Pong.NativeFieldInfoPtr_nextBallSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "nextBallSide");
			Pong.NativeFieldInfoPtr_ballVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "ballVelocity");
			Pong.NativeFieldInfoPtr_reactionTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "reactionTimer");
			Pong.NativeMethodInfoPtr_get_GameMode_Public_get_EGameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666575);
			Pong.NativeMethodInfoPtr_set_GameMode_Public_set_Void_EGameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666576);
			Pong.NativeMethodInfoPtr_get_State_Public_get_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666577);
			Pong.NativeMethodInfoPtr_set_State_Public_set_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666578);
			Pong.NativeMethodInfoPtr_get_LeftScore_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666579);
			Pong.NativeMethodInfoPtr_set_LeftScore_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666580);
			Pong.NativeMethodInfoPtr_get_RightScore_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666581);
			Pong.NativeMethodInfoPtr_set_RightScore_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666582);
			Pong.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666583);
			Pong.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666584);
			Pong.NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666585);
			Pong.NativeMethodInfoPtr_UpdateInputs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666586);
			Pong.NativeMethodInfoPtr_UpdateAI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666587);
			Pong.NativeMethodInfoPtr_GoalHit_Public_Void_ESide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666588);
			Pong.NativeMethodInfoPtr_Win_Private_Void_ESide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666589);
			Pong.NativeMethodInfoPtr_ResetBall_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666590);
			Pong.NativeMethodInfoPtr_ServeBall_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666591);
			Pong.NativeMethodInfoPtr_ResetGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666592);
			Pong.NativeMethodInfoPtr_SetPaddleTargetY_Public_Void_ESide_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666593);
			Pong.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666594);
			Pong.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666595);
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06001802 RID: 6146 RVA: 0x000CAFEC File Offset: 0x000C91EC
		// (set) Token: 0x06001803 RID: 6147 RVA: 0x000CB028 File Offset: 0x000C9228
		public unsafe Pong.EGameMode GameMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_get_GameMode_Public_get_EGameMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_set_GameMode_Public_set_Void_EGameMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06001804 RID: 6148 RVA: 0x000CB068 File Offset: 0x000C9268
		// (set) Token: 0x06001805 RID: 6149 RVA: 0x000CB0A4 File Offset: 0x000C92A4
		public new unsafe Pong.EState State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_get_State_Public_get_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_set_State_Public_set_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06001806 RID: 6150 RVA: 0x000CB0E4 File Offset: 0x000C92E4
		// (set) Token: 0x06001807 RID: 6151 RVA: 0x000CB120 File Offset: 0x000C9320
		public unsafe int LeftScore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_get_LeftScore_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_set_LeftScore_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06001808 RID: 6152 RVA: 0x000CB160 File Offset: 0x000C9360
		// (set) Token: 0x06001809 RID: 6153 RVA: 0x000CB19C File Offset: 0x000C939C
		public unsafe int RightScore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_get_RightScore_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_set_RightScore_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x000CB1DC File Offset: 0x000C93DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98079, XrefRangeEnd = 98082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x000CB210 File Offset: 0x000C9410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98082, XrefRangeEnd = 98094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x000CB244 File Offset: 0x000C9444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98094, XrefRangeEnd = 98098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TryPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pong.NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x000CB280 File Offset: 0x000C9480
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98110, RefRangeEnd = 98111, XrefRangeStart = 98098, XrefRangeEnd = 98110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInputs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_UpdateInputs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x000CB2B4 File Offset: 0x000C94B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98119, RefRangeEnd = 98120, XrefRangeStart = 98111, XrefRangeEnd = 98119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_UpdateAI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x000CB2E8 File Offset: 0x000C94E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98129, RefRangeEnd = 98130, XrefRangeStart = 98120, XrefRangeEnd = 98129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoalHit(Pong.ESide side)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_GoalHit_Public_Void_ESide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x000CB328 File Offset: 0x000C9528
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98142, RefRangeEnd = 98143, XrefRangeStart = 98130, XrefRangeEnd = 98142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Win(Pong.ESide winner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref winner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_Win_Private_Void_ESide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x000CB368 File Offset: 0x000C9568
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 98160, RefRangeEnd = 98163, XrefRangeStart = 98143, XrefRangeEnd = 98160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetBall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_ResetBall_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x000CB39C File Offset: 0x000C959C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98163, XrefRangeEnd = 98171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ServeBall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_ServeBall_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x000CB3D0 File Offset: 0x000C95D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98171, XrefRangeEnd = 98177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_ResetGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x000CB404 File Offset: 0x000C9604
		[CallerCount(0)]
		public unsafe void SetPaddleTargetY(Pong.ESide player, float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref player;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_SetPaddleTargetY_Public_Void_ESide_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x000CB450 File Offset: 0x000C9650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98177, XrefRangeEnd = 98180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pong.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x000CB48C File Offset: 0x000C968C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98180, XrefRangeEnd = 98183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pong() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pong>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x0000D21D File Offset: 0x0000B41D
		public Pong(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x000CB4C8 File Offset: 0x000C96C8
		// (set) Token: 0x06001819 RID: 6169 RVA: 0x0000D226 File Offset: 0x0000B426
		public unsafe Pong.EGameMode _GameMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__GameMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__GameMode_k__BackingField)) = value;
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x000CB4F0 File Offset: 0x000C96F0
		// (set) Token: 0x0600181B RID: 6171 RVA: 0x0000D241 File Offset: 0x0000B441
		public unsafe Pong.EState _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x0600181C RID: 6172 RVA: 0x000CB518 File Offset: 0x000C9718
		// (set) Token: 0x0600181D RID: 6173 RVA: 0x0000D25C File Offset: 0x0000B45C
		public unsafe int _LeftScore_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__LeftScore_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__LeftScore_k__BackingField)) = value;
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x0600181E RID: 6174 RVA: 0x000CB540 File Offset: 0x000C9740
		// (set) Token: 0x0600181F RID: 6175 RVA: 0x0000D277 File Offset: 0x0000B477
		public unsafe int _RightScore_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__RightScore_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__RightScore_k__BackingField)) = value;
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06001820 RID: 6176 RVA: 0x000CB568 File Offset: 0x000C9768
		// (set) Token: 0x06001821 RID: 6177 RVA: 0x0000D292 File Offset: 0x0000B492
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06001822 RID: 6178 RVA: 0x000CB598 File Offset: 0x000C9798
		// (set) Token: 0x06001823 RID: 6179 RVA: 0x0000D2B1 File Offset: 0x0000B4B1
		public unsafe PongPaddle LeftPaddle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_LeftPaddle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PongPaddle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_LeftPaddle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06001824 RID: 6180 RVA: 0x000CB5C8 File Offset: 0x000C97C8
		// (set) Token: 0x06001825 RID: 6181 RVA: 0x0000D2D0 File Offset: 0x0000B4D0
		public unsafe PongPaddle RightPaddle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_RightPaddle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PongPaddle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_RightPaddle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06001826 RID: 6182 RVA: 0x000CB5F8 File Offset: 0x000C97F8
		// (set) Token: 0x06001827 RID: 6183 RVA: 0x0000D2EF File Offset: 0x0000B4EF
		public unsafe PongBall Ball
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_Ball);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PongBall>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_Ball), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001828 RID: 6184 RVA: 0x000CB628 File Offset: 0x000C9828
		// (set) Token: 0x06001829 RID: 6185 RVA: 0x0000D30E File Offset: 0x0000B50E
		public unsafe TextMeshProUGUI LeftScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_LeftScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_LeftScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x0600182A RID: 6186 RVA: 0x000CB658 File Offset: 0x000C9858
		// (set) Token: 0x0600182B RID: 6187 RVA: 0x0000D32D File Offset: 0x0000B52D
		public unsafe TextMeshProUGUI RightScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_RightScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_RightScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x0600182C RID: 6188 RVA: 0x000CB688 File Offset: 0x000C9888
		// (set) Token: 0x0600182D RID: 6189 RVA: 0x0000D34C File Offset: 0x0000B54C
		public unsafe TextMeshProUGUI WinnerLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_WinnerLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_WinnerLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x0600182E RID: 6190 RVA: 0x000CB6B8 File Offset: 0x000C98B8
		// (set) Token: 0x0600182F RID: 6191 RVA: 0x0000D36B File Offset: 0x0000B56B
		public unsafe float InitialVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_InitialVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_InitialVelocity)) = value;
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06001830 RID: 6192 RVA: 0x000CB6E0 File Offset: 0x000C98E0
		// (set) Token: 0x06001831 RID: 6193 RVA: 0x0000D386 File Offset: 0x0000B586
		public unsafe float VelocityGainPerSecond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_VelocityGainPerSecond);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_VelocityGainPerSecond)) = value;
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06001832 RID: 6194 RVA: 0x000CB708 File Offset: 0x000C9908
		// (set) Token: 0x06001833 RID: 6195 RVA: 0x0000D3A1 File Offset: 0x0000B5A1
		public unsafe float MaxVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_MaxVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_MaxVelocity)) = value;
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06001834 RID: 6196 RVA: 0x000CB730 File Offset: 0x000C9930
		// (set) Token: 0x06001835 RID: 6197 RVA: 0x0000D3BC File Offset: 0x0000B5BC
		public unsafe int GoalsToWin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_GoalsToWin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_GoalsToWin)) = value;
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06001836 RID: 6198 RVA: 0x000CB758 File Offset: 0x000C9958
		// (set) Token: 0x06001837 RID: 6199 RVA: 0x0000D3D7 File Offset: 0x0000B5D7
		public unsafe float ReactionTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_ReactionTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_ReactionTime)) = value;
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06001838 RID: 6200 RVA: 0x000CB780 File Offset: 0x000C9980
		// (set) Token: 0x06001839 RID: 6201 RVA: 0x0000D3F2 File Offset: 0x0000B5F2
		public unsafe float TargetRandomization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_TargetRandomization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_TargetRandomization)) = value;
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x0600183A RID: 6202 RVA: 0x000CB7A8 File Offset: 0x000C99A8
		// (set) Token: 0x0600183B RID: 6203 RVA: 0x0000D40D File Offset: 0x0000B60D
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x0600183C RID: 6204 RVA: 0x000CB7D0 File Offset: 0x000C99D0
		// (set) Token: 0x0600183D RID: 6205 RVA: 0x0000D428 File Offset: 0x0000B628
		public unsafe UnityEvent onServe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onServe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onServe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x0600183E RID: 6206 RVA: 0x000CB800 File Offset: 0x000C9A00
		// (set) Token: 0x0600183F RID: 6207 RVA: 0x0000D447 File Offset: 0x0000B647
		public unsafe UnityEvent onLeftScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onLeftScore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onLeftScore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06001840 RID: 6208 RVA: 0x000CB830 File Offset: 0x000C9A30
		// (set) Token: 0x06001841 RID: 6209 RVA: 0x0000D466 File Offset: 0x0000B666
		public unsafe UnityEvent onRightScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onRightScore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onRightScore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06001842 RID: 6210 RVA: 0x000CB860 File Offset: 0x000C9A60
		// (set) Token: 0x06001843 RID: 6211 RVA: 0x0000D485 File Offset: 0x0000B685
		public unsafe UnityEvent onGameOver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onGameOver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onGameOver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06001844 RID: 6212 RVA: 0x000CB890 File Offset: 0x000C9A90
		// (set) Token: 0x06001845 RID: 6213 RVA: 0x0000D4A4 File Offset: 0x0000B6A4
		public unsafe UnityEvent onLocalPlayerWin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onLocalPlayerWin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onLocalPlayerWin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06001846 RID: 6214 RVA: 0x000CB8C0 File Offset: 0x000C9AC0
		// (set) Token: 0x06001847 RID: 6215 RVA: 0x0000D4C3 File Offset: 0x0000B6C3
		public unsafe UnityEvent onReset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onReset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onReset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06001848 RID: 6216 RVA: 0x000CB8F0 File Offset: 0x000C9AF0
		// (set) Token: 0x06001849 RID: 6217 RVA: 0x0000D4E2 File Offset: 0x0000B6E2
		public unsafe Pong.ESide nextBallSide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_nextBallSide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_nextBallSide)) = value;
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x0600184A RID: 6218 RVA: 0x000CB918 File Offset: 0x000C9B18
		// (set) Token: 0x0600184B RID: 6219 RVA: 0x0000D4FD File Offset: 0x0000B6FD
		public unsafe Vector3 ballVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_ballVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_ballVelocity)) = value;
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x0600184C RID: 6220 RVA: 0x000CB940 File Offset: 0x000C9B40
		// (set) Token: 0x0600184D RID: 6221 RVA: 0x0000D518 File Offset: 0x0000B718
		public unsafe float reactionTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_reactionTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_reactionTimer)) = value;
			}
		}

		// Token: 0x040010B4 RID: 4276
		private static readonly IntPtr NativeFieldInfoPtr__GameMode_k__BackingField;

		// Token: 0x040010B5 RID: 4277
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x040010B6 RID: 4278
		private static readonly IntPtr NativeFieldInfoPtr__LeftScore_k__BackingField;

		// Token: 0x040010B7 RID: 4279
		private static readonly IntPtr NativeFieldInfoPtr__RightScore_k__BackingField;

		// Token: 0x040010B8 RID: 4280
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeFieldInfoPtr_LeftPaddle;

		// Token: 0x040010BA RID: 4282
		private static readonly IntPtr NativeFieldInfoPtr_RightPaddle;

		// Token: 0x040010BB RID: 4283
		private static readonly IntPtr NativeFieldInfoPtr_Ball;

		// Token: 0x040010BC RID: 4284
		private static readonly IntPtr NativeFieldInfoPtr_LeftScoreLabel;

		// Token: 0x040010BD RID: 4285
		private static readonly IntPtr NativeFieldInfoPtr_RightScoreLabel;

		// Token: 0x040010BE RID: 4286
		private static readonly IntPtr NativeFieldInfoPtr_WinnerLabel;

		// Token: 0x040010BF RID: 4287
		private static readonly IntPtr NativeFieldInfoPtr_InitialVelocity;

		// Token: 0x040010C0 RID: 4288
		private static readonly IntPtr NativeFieldInfoPtr_VelocityGainPerSecond;

		// Token: 0x040010C1 RID: 4289
		private static readonly IntPtr NativeFieldInfoPtr_MaxVelocity;

		// Token: 0x040010C2 RID: 4290
		private static readonly IntPtr NativeFieldInfoPtr_GoalsToWin;

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeFieldInfoPtr_ReactionTime;

		// Token: 0x040010C4 RID: 4292
		private static readonly IntPtr NativeFieldInfoPtr_TargetRandomization;

		// Token: 0x040010C5 RID: 4293
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x040010C6 RID: 4294
		private static readonly IntPtr NativeFieldInfoPtr_onServe;

		// Token: 0x040010C7 RID: 4295
		private static readonly IntPtr NativeFieldInfoPtr_onLeftScore;

		// Token: 0x040010C8 RID: 4296
		private static readonly IntPtr NativeFieldInfoPtr_onRightScore;

		// Token: 0x040010C9 RID: 4297
		private static readonly IntPtr NativeFieldInfoPtr_onGameOver;

		// Token: 0x040010CA RID: 4298
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerWin;

		// Token: 0x040010CB RID: 4299
		private static readonly IntPtr NativeFieldInfoPtr_onReset;

		// Token: 0x040010CC RID: 4300
		private static readonly IntPtr NativeFieldInfoPtr_nextBallSide;

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeFieldInfoPtr_ballVelocity;

		// Token: 0x040010CE RID: 4302
		private static readonly IntPtr NativeFieldInfoPtr_reactionTimer;

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeMethodInfoPtr_get_GameMode_Public_get_EGameMode_0;

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeMethodInfoPtr_set_GameMode_Public_set_Void_EGameMode_0;

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_EState_0;

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Public_set_Void_EState_0;

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftScore_Public_get_Int32_0;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftScore_Public_set_Void_Int32_0;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeMethodInfoPtr_get_RightScore_Public_get_Int32_0;

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeMethodInfoPtr_set_RightScore_Public_set_Void_Int32_0;

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInputs_Public_Void_0;

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAI_Private_Void_0;

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeMethodInfoPtr_GoalHit_Public_Void_ESide_0;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeMethodInfoPtr_Win_Private_Void_ESide_0;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeMethodInfoPtr_ResetBall_Private_Void_0;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeMethodInfoPtr_ServeBall_Private_Void_0;

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeMethodInfoPtr_ResetGame_Private_Void_0;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeMethodInfoPtr_SetPaddleTargetY_Public_Void_ESide_Single_0;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200093A RID: 2362
		[OriginalName("Assembly-CSharp.dll", "", "EGameMode")]
		public enum EGameMode
		{
			// Token: 0x04009357 RID: 37719
			SinglePlayer,
			// Token: 0x04009358 RID: 37720
			MultiPlayer
		}

		// Token: 0x0200093B RID: 2363
		[OriginalName("Assembly-CSharp.dll", "", "ESide")]
		public enum ESide
		{
			// Token: 0x0400935A RID: 37722
			Left,
			// Token: 0x0400935B RID: 37723
			Right
		}

		// Token: 0x0200093C RID: 2364
		[OriginalName("Assembly-CSharp.dll", "", "EState")]
		public enum EState
		{
			// Token: 0x0400935D RID: 37725
			Ready,
			// Token: 0x0400935E RID: 37726
			Playing,
			// Token: 0x0400935F RID: 37727
			GameOver
		}
	}
}
