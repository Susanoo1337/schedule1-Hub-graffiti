using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x02000102 RID: 258
	public class Snake : TVApp
	{
		// Token: 0x060018C4 RID: 6340 RVA: 0x000CCC34 File Offset: 0x000CAE34
		// Note: this type is marked as 'beforefieldinit'.
		static Snake()
		{
			Il2CppClassPointerStore<Snake>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "Snake");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snake>.NativeClassPtr);
			Snake.NativeFieldInfoPtr_SIZE_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "SIZE_X");
			Snake.NativeFieldInfoPtr_SIZE_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "SIZE_Y");
			Snake.NativeFieldInfoPtr_TilePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "TilePrefab");
			Snake.NativeFieldInfoPtr_TimePerTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "TimePerTile");
			Snake.NativeFieldInfoPtr_PlaySpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "PlaySpace");
			Snake.NativeFieldInfoPtr_Tiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "Tiles");
			Snake.NativeFieldInfoPtr_ScoreText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "ScoreText");
			Snake.NativeFieldInfoPtr__HeadPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "<HeadPosition>k__BackingField");
			Snake.NativeFieldInfoPtr__Tail_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "<Tail>k__BackingField");
			Snake.NativeFieldInfoPtr__LastTailPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "<LastTailPosition>k__BackingField");
			Snake.NativeFieldInfoPtr__Direction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "<Direction>k__BackingField");
			Snake.NativeFieldInfoPtr__QueuedDirection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "<QueuedDirection>k__BackingField");
			Snake.NativeFieldInfoPtr__NextDirection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "<NextDirection>k__BackingField");
			Snake.NativeFieldInfoPtr_lastFoodPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "lastFoodPosition");
			Snake.NativeFieldInfoPtr__GameState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "<GameState>k__BackingField");
			Snake.NativeFieldInfoPtr__timeSinceLastMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "_timeSinceLastMove");
			Snake.NativeFieldInfoPtr__timeOnGameOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "_timeOnGameOver");
			Snake.NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "onStart");
			Snake.NativeFieldInfoPtr_onEat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "onEat");
			Snake.NativeFieldInfoPtr_onGameOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "onGameOver");
			Snake.NativeFieldInfoPtr_onWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "onWin");
			Snake.NativeMethodInfoPtr_get_HeadPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666620);
			Snake.NativeMethodInfoPtr_set_HeadPosition_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666621);
			Snake.NativeMethodInfoPtr_get_Tail_Public_get_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666622);
			Snake.NativeMethodInfoPtr_set_Tail_Private_set_Void_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666623);
			Snake.NativeMethodInfoPtr_get_LastTailPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666624);
			Snake.NativeMethodInfoPtr_set_LastTailPosition_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666625);
			Snake.NativeMethodInfoPtr_get_Direction_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666626);
			Snake.NativeMethodInfoPtr_set_Direction_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666627);
			Snake.NativeMethodInfoPtr_get_QueuedDirection_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666628);
			Snake.NativeMethodInfoPtr_set_QueuedDirection_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666629);
			Snake.NativeMethodInfoPtr_get_NextDirection_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666630);
			Snake.NativeMethodInfoPtr_set_NextDirection_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666631);
			Snake.NativeMethodInfoPtr_get_GameState_Public_get_EGameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666632);
			Snake.NativeMethodInfoPtr_set_GameState_Private_set_Void_EGameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666633);
			Snake.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666634);
			Snake.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666635);
			Snake.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666636);
			Snake.NativeMethodInfoPtr_UpdateMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666637);
			Snake.NativeMethodInfoPtr_MoveSnake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666638);
			Snake.NativeMethodInfoPtr_GetTile_Private_SnakeTile_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666639);
			Snake.NativeMethodInfoPtr_StartGame_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666640);
			Snake.NativeMethodInfoPtr_Eat_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666641);
			Snake.NativeMethodInfoPtr_SpawnFood_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666642);
			Snake.NativeMethodInfoPtr_GameOver_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666643);
			Snake.NativeMethodInfoPtr_Win_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666644);
			Snake.NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666645);
			Snake.NativeMethodInfoPtr_CreateTiles_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666646);
			Snake.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666647);
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x060018C5 RID: 6341 RVA: 0x000CD038 File Offset: 0x000CB238
		// (set) Token: 0x060018C6 RID: 6342 RVA: 0x000CD074 File Offset: 0x000CB274
		public unsafe Vector2 HeadPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_get_HeadPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_set_HeadPosition_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x060018C7 RID: 6343 RVA: 0x000CD0B4 File Offset: 0x000CB2B4
		// (set) Token: 0x060018C8 RID: 6344 RVA: 0x000CD0F4 File Offset: 0x000CB2F4
		public unsafe List<Vector2> Tail
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_get_Tail_Public_get_List_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 38417, RefRangeEnd = 38421, XrefRangeStart = 38417, XrefRangeEnd = 38421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_set_Tail_Private_set_Void_List_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x060018C9 RID: 6345 RVA: 0x000CD138 File Offset: 0x000CB338
		// (set) Token: 0x060018CA RID: 6346 RVA: 0x000CD174 File Offset: 0x000CB374
		public unsafe Vector2 LastTailPosition
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38421, RefRangeEnd = 38424, XrefRangeStart = 38421, XrefRangeEnd = 38424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_get_LastTailPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_set_LastTailPosition_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x060018CB RID: 6347 RVA: 0x000CD1B4 File Offset: 0x000CB3B4
		// (set) Token: 0x060018CC RID: 6348 RVA: 0x000CD1F0 File Offset: 0x000CB3F0
		public unsafe Vector2 Direction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_get_Direction_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_set_Direction_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x060018CD RID: 6349 RVA: 0x000CD230 File Offset: 0x000CB430
		// (set) Token: 0x060018CE RID: 6350 RVA: 0x000CD26C File Offset: 0x000CB46C
		public unsafe Vector2 QueuedDirection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_get_QueuedDirection_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_set_QueuedDirection_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x060018CF RID: 6351 RVA: 0x000CD2AC File Offset: 0x000CB4AC
		// (set) Token: 0x060018D0 RID: 6352 RVA: 0x000CD2E8 File Offset: 0x000CB4E8
		public unsafe Vector2 NextDirection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_get_NextDirection_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_set_NextDirection_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x060018D1 RID: 6353 RVA: 0x000CD328 File Offset: 0x000CB528
		// (set) Token: 0x060018D2 RID: 6354 RVA: 0x000CD364 File Offset: 0x000CB564
		public unsafe Snake.EGameState GameState
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 52394, RefRangeEnd = 52399, XrefRangeStart = 52394, XrefRangeEnd = 52399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_get_GameState_Public_get_EGameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_set_GameState_Private_set_Void_EGameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x000CD3A4 File Offset: 0x000CB5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98470, XrefRangeEnd = 98471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Snake.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x000CD3E0 File Offset: 0x000CB5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98471, XrefRangeEnd = 98478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x000CD414 File Offset: 0x000CB614
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98534, RefRangeEnd = 98535, XrefRangeStart = 98478, XrefRangeEnd = 98534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x000CD448 File Offset: 0x000CB648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98535, XrefRangeEnd = 98537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_UpdateMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x000CD47C File Offset: 0x000CB67C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 98548, RefRangeEnd = 98551, XrefRangeStart = 98537, XrefRangeEnd = 98548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveSnake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_MoveSnake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x000CD4B0 File Offset: 0x000CB6B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 98551, RefRangeEnd = 98554, XrefRangeStart = 98551, XrefRangeEnd = 98551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SnakeTile GetTile(Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_GetTile_Private_SnakeTile_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SnakeTile>(intPtr3) : null;
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x000CD4FC File Offset: 0x000CB6FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98574, RefRangeEnd = 98575, XrefRangeStart = 98554, XrefRangeEnd = 98574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGame(Vector2 initialDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref initialDir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_StartGame_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x000CD53C File Offset: 0x000CB73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98575, XrefRangeEnd = 98580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Eat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_Eat_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x000CD570 File Offset: 0x000CB770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98596, RefRangeEnd = 98597, XrefRangeStart = 98580, XrefRangeEnd = 98596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnFood()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_SpawnFood_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x000CD5A4 File Offset: 0x000CB7A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98597, XrefRangeEnd = 98598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GameOver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_GameOver_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x000CD5D8 File Offset: 0x000CB7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98598, XrefRangeEnd = 98599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Win()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_Win_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x000CD60C File Offset: 0x000CB80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98599, XrefRangeEnd = 98600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TryPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Snake.NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x000CD648 File Offset: 0x000CB848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98600, XrefRangeEnd = 98620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTiles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_CreateTiles_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x000CD67C File Offset: 0x000CB87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98620, XrefRangeEnd = 98638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Snake() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Snake>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x0000DA22 File Offset: 0x0000BC22
		public Snake(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x060018E2 RID: 6370 RVA: 0x000CD6B8 File Offset: 0x000CB8B8
		// (set) Token: 0x060018E3 RID: 6371 RVA: 0x0000DA2B File Offset: 0x0000BC2B
		public unsafe static int SIZE_X
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Snake.NativeFieldInfoPtr_SIZE_X, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Snake.NativeFieldInfoPtr_SIZE_X, (void*)(&value));
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x060018E4 RID: 6372 RVA: 0x000CD6D4 File Offset: 0x000CB8D4
		// (set) Token: 0x060018E5 RID: 6373 RVA: 0x0000DA39 File Offset: 0x0000BC39
		public unsafe static int SIZE_Y
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Snake.NativeFieldInfoPtr_SIZE_Y, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Snake.NativeFieldInfoPtr_SIZE_Y, (void*)(&value));
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x060018E6 RID: 6374 RVA: 0x000CD6F0 File Offset: 0x000CB8F0
		// (set) Token: 0x060018E7 RID: 6375 RVA: 0x0000DA47 File Offset: 0x0000BC47
		public unsafe SnakeTile TilePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_TilePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SnakeTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_TilePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x000CD720 File Offset: 0x000CB920
		// (set) Token: 0x060018E9 RID: 6377 RVA: 0x0000DA66 File Offset: 0x0000BC66
		public unsafe float TimePerTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_TimePerTile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_TimePerTile)) = value;
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x060018EA RID: 6378 RVA: 0x000CD748 File Offset: 0x000CB948
		// (set) Token: 0x060018EB RID: 6379 RVA: 0x0000DA81 File Offset: 0x0000BC81
		public unsafe RectTransform PlaySpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_PlaySpace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_PlaySpace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x060018EC RID: 6380 RVA: 0x000CD778 File Offset: 0x000CB978
		// (set) Token: 0x060018ED RID: 6381 RVA: 0x0000DAA0 File Offset: 0x0000BCA0
		public unsafe Il2CppReferenceArray<SnakeTile> Tiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_Tiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SnakeTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_Tiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x060018EE RID: 6382 RVA: 0x000CD7A8 File Offset: 0x000CB9A8
		// (set) Token: 0x060018EF RID: 6383 RVA: 0x0000DABF File Offset: 0x0000BCBF
		public unsafe TextMeshProUGUI ScoreText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_ScoreText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_ScoreText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x060018F0 RID: 6384 RVA: 0x000CD7D8 File Offset: 0x000CB9D8
		// (set) Token: 0x060018F1 RID: 6385 RVA: 0x0000DADE File Offset: 0x0000BCDE
		public unsafe Vector2 _HeadPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__HeadPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__HeadPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x060018F2 RID: 6386 RVA: 0x000CD800 File Offset: 0x000CBA00
		// (set) Token: 0x060018F3 RID: 6387 RVA: 0x0000DAF9 File Offset: 0x0000BCF9
		public unsafe List<Vector2> _Tail_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__Tail_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__Tail_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x060018F4 RID: 6388 RVA: 0x000CD830 File Offset: 0x000CBA30
		// (set) Token: 0x060018F5 RID: 6389 RVA: 0x0000DB18 File Offset: 0x0000BD18
		public unsafe Vector2 _LastTailPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__LastTailPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__LastTailPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x000CD858 File Offset: 0x000CBA58
		// (set) Token: 0x060018F7 RID: 6391 RVA: 0x0000DB33 File Offset: 0x0000BD33
		public unsafe Vector2 _Direction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__Direction_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__Direction_k__BackingField)) = value;
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x000CD880 File Offset: 0x000CBA80
		// (set) Token: 0x060018F9 RID: 6393 RVA: 0x0000DB4E File Offset: 0x0000BD4E
		public unsafe Vector2 _QueuedDirection_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__QueuedDirection_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__QueuedDirection_k__BackingField)) = value;
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x000CD8A8 File Offset: 0x000CBAA8
		// (set) Token: 0x060018FB RID: 6395 RVA: 0x0000DB69 File Offset: 0x0000BD69
		public unsafe Vector2 _NextDirection_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__NextDirection_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__NextDirection_k__BackingField)) = value;
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x000CD8D0 File Offset: 0x000CBAD0
		// (set) Token: 0x060018FD RID: 6397 RVA: 0x0000DB84 File Offset: 0x0000BD84
		public unsafe Vector2 lastFoodPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_lastFoodPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_lastFoodPosition)) = value;
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x000CD8F8 File Offset: 0x000CBAF8
		// (set) Token: 0x060018FF RID: 6399 RVA: 0x0000DB9F File Offset: 0x0000BD9F
		public unsafe Snake.EGameState _GameState_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__GameState_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__GameState_k__BackingField)) = value;
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x000CD920 File Offset: 0x000CBB20
		// (set) Token: 0x06001901 RID: 6401 RVA: 0x0000DBBA File Offset: 0x0000BDBA
		public unsafe float _timeSinceLastMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__timeSinceLastMove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__timeSinceLastMove)) = value;
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x000CD948 File Offset: 0x000CBB48
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x0000DBD5 File Offset: 0x0000BDD5
		public unsafe float _timeOnGameOver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__timeOnGameOver);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__timeOnGameOver)) = value;
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x000CD970 File Offset: 0x000CBB70
		// (set) Token: 0x06001905 RID: 6405 RVA: 0x0000DBF0 File Offset: 0x0000BDF0
		public unsafe UnityEvent onStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x000CD9A0 File Offset: 0x000CBBA0
		// (set) Token: 0x06001907 RID: 6407 RVA: 0x0000DC0F File Offset: 0x0000BE0F
		public unsafe UnityEvent onEat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onEat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onEat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x000CD9D0 File Offset: 0x000CBBD0
		// (set) Token: 0x06001909 RID: 6409 RVA: 0x0000DC2E File Offset: 0x0000BE2E
		public unsafe UnityEvent onGameOver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onGameOver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onGameOver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x000CDA00 File Offset: 0x000CBC00
		// (set) Token: 0x0600190B RID: 6411 RVA: 0x0000DC4D File Offset: 0x0000BE4D
		public unsafe UnityEvent onWin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onWin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onWin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001127 RID: 4391
		private static readonly IntPtr NativeFieldInfoPtr_SIZE_X;

		// Token: 0x04001128 RID: 4392
		private static readonly IntPtr NativeFieldInfoPtr_SIZE_Y;

		// Token: 0x04001129 RID: 4393
		private static readonly IntPtr NativeFieldInfoPtr_TilePrefab;

		// Token: 0x0400112A RID: 4394
		private static readonly IntPtr NativeFieldInfoPtr_TimePerTile;

		// Token: 0x0400112B RID: 4395
		private static readonly IntPtr NativeFieldInfoPtr_PlaySpace;

		// Token: 0x0400112C RID: 4396
		private static readonly IntPtr NativeFieldInfoPtr_Tiles;

		// Token: 0x0400112D RID: 4397
		private static readonly IntPtr NativeFieldInfoPtr_ScoreText;

		// Token: 0x0400112E RID: 4398
		private static readonly IntPtr NativeFieldInfoPtr__HeadPosition_k__BackingField;

		// Token: 0x0400112F RID: 4399
		private static readonly IntPtr NativeFieldInfoPtr__Tail_k__BackingField;

		// Token: 0x04001130 RID: 4400
		private static readonly IntPtr NativeFieldInfoPtr__LastTailPosition_k__BackingField;

		// Token: 0x04001131 RID: 4401
		private static readonly IntPtr NativeFieldInfoPtr__Direction_k__BackingField;

		// Token: 0x04001132 RID: 4402
		private static readonly IntPtr NativeFieldInfoPtr__QueuedDirection_k__BackingField;

		// Token: 0x04001133 RID: 4403
		private static readonly IntPtr NativeFieldInfoPtr__NextDirection_k__BackingField;

		// Token: 0x04001134 RID: 4404
		private static readonly IntPtr NativeFieldInfoPtr_lastFoodPosition;

		// Token: 0x04001135 RID: 4405
		private static readonly IntPtr NativeFieldInfoPtr__GameState_k__BackingField;

		// Token: 0x04001136 RID: 4406
		private static readonly IntPtr NativeFieldInfoPtr__timeSinceLastMove;

		// Token: 0x04001137 RID: 4407
		private static readonly IntPtr NativeFieldInfoPtr__timeOnGameOver;

		// Token: 0x04001138 RID: 4408
		private static readonly IntPtr NativeFieldInfoPtr_onStart;

		// Token: 0x04001139 RID: 4409
		private static readonly IntPtr NativeFieldInfoPtr_onEat;

		// Token: 0x0400113A RID: 4410
		private static readonly IntPtr NativeFieldInfoPtr_onGameOver;

		// Token: 0x0400113B RID: 4411
		private static readonly IntPtr NativeFieldInfoPtr_onWin;

		// Token: 0x0400113C RID: 4412
		private static readonly IntPtr NativeMethodInfoPtr_get_HeadPosition_Public_get_Vector2_0;

		// Token: 0x0400113D RID: 4413
		private static readonly IntPtr NativeMethodInfoPtr_set_HeadPosition_Private_set_Void_Vector2_0;

		// Token: 0x0400113E RID: 4414
		private static readonly IntPtr NativeMethodInfoPtr_get_Tail_Public_get_List_1_Vector2_0;

		// Token: 0x0400113F RID: 4415
		private static readonly IntPtr NativeMethodInfoPtr_set_Tail_Private_set_Void_List_1_Vector2_0;

		// Token: 0x04001140 RID: 4416
		private static readonly IntPtr NativeMethodInfoPtr_get_LastTailPosition_Public_get_Vector2_0;

		// Token: 0x04001141 RID: 4417
		private static readonly IntPtr NativeMethodInfoPtr_set_LastTailPosition_Private_set_Void_Vector2_0;

		// Token: 0x04001142 RID: 4418
		private static readonly IntPtr NativeMethodInfoPtr_get_Direction_Public_get_Vector2_0;

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeMethodInfoPtr_set_Direction_Private_set_Void_Vector2_0;

		// Token: 0x04001144 RID: 4420
		private static readonly IntPtr NativeMethodInfoPtr_get_QueuedDirection_Public_get_Vector2_0;

		// Token: 0x04001145 RID: 4421
		private static readonly IntPtr NativeMethodInfoPtr_set_QueuedDirection_Private_set_Void_Vector2_0;

		// Token: 0x04001146 RID: 4422
		private static readonly IntPtr NativeMethodInfoPtr_get_NextDirection_Public_get_Vector2_0;

		// Token: 0x04001147 RID: 4423
		private static readonly IntPtr NativeMethodInfoPtr_set_NextDirection_Private_set_Void_Vector2_0;

		// Token: 0x04001148 RID: 4424
		private static readonly IntPtr NativeMethodInfoPtr_get_GameState_Public_get_EGameState_0;

		// Token: 0x04001149 RID: 4425
		private static readonly IntPtr NativeMethodInfoPtr_set_GameState_Private_set_Void_EGameState_0;

		// Token: 0x0400114A RID: 4426
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400114B RID: 4427
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400114C RID: 4428
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x0400114D RID: 4429
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMovement_Private_Void_0;

		// Token: 0x0400114E RID: 4430
		private static readonly IntPtr NativeMethodInfoPtr_MoveSnake_Private_Void_0;

		// Token: 0x0400114F RID: 4431
		private static readonly IntPtr NativeMethodInfoPtr_GetTile_Private_SnakeTile_Vector2_0;

		// Token: 0x04001150 RID: 4432
		private static readonly IntPtr NativeMethodInfoPtr_StartGame_Private_Void_Vector2_0;

		// Token: 0x04001151 RID: 4433
		private static readonly IntPtr NativeMethodInfoPtr_Eat_Private_Void_0;

		// Token: 0x04001152 RID: 4434
		private static readonly IntPtr NativeMethodInfoPtr_SpawnFood_Private_Void_0;

		// Token: 0x04001153 RID: 4435
		private static readonly IntPtr NativeMethodInfoPtr_GameOver_Private_Void_0;

		// Token: 0x04001154 RID: 4436
		private static readonly IntPtr NativeMethodInfoPtr_Win_Private_Void_0;

		// Token: 0x04001155 RID: 4437
		private static readonly IntPtr NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0;

		// Token: 0x04001156 RID: 4438
		private static readonly IntPtr NativeMethodInfoPtr_CreateTiles_Public_Void_0;

		// Token: 0x04001157 RID: 4439
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200093D RID: 2365
		[OriginalName("Assembly-CSharp.dll", "", "EGameState")]
		public enum EGameState
		{
			// Token: 0x04009361 RID: 37729
			Ready,
			// Token: 0x04009362 RID: 37730
			Playing
		}
	}
}
