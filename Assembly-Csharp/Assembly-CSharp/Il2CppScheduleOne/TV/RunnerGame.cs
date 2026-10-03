using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x02000100 RID: 256
	public class RunnerGame : TVApp
	{
		// Token: 0x0600186F RID: 6255 RVA: 0x000CBEF8 File Offset: 0x000CA0F8
		// Note: this type is marked as 'beforefieldinit'.
		static RunnerGame()
		{
			Il2CppClassPointerStore<RunnerGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "RunnerGame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr);
			RunnerGame.NativeFieldInfoPtr_GameSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "GameSpeed");
			RunnerGame.NativeFieldInfoPtr_MinGameSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "MinGameSpeed");
			RunnerGame.NativeFieldInfoPtr_MaxGameSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "MaxGameSpeed");
			RunnerGame.NativeFieldInfoPtr_SpeedIncreaseRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "SpeedIncreaseRate");
			RunnerGame.NativeFieldInfoPtr_ScoreRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "ScoreRate");
			RunnerGame.NativeFieldInfoPtr_Gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "Gravity");
			RunnerGame.NativeFieldInfoPtr_JumpForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "JumpForce");
			RunnerGame.NativeFieldInfoPtr_GlobalForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "GlobalForceMultiplier");
			RunnerGame.NativeFieldInfoPtr_DropForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "DropForce");
			RunnerGame.NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "Character");
			RunnerGame.NativeFieldInfoPtr_CharacterFlipboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "CharacterFlipboard");
			RunnerGame.NativeFieldInfoPtr_Ground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "Ground");
			RunnerGame.NativeFieldInfoPtr_CloudSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "CloudSpawner");
			RunnerGame.NativeFieldInfoPtr_ObstacleSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "ObstacleSpawner");
			RunnerGame.NativeFieldInfoPtr_ScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "ScoreLabel");
			RunnerGame.NativeFieldInfoPtr_HighScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "HighScoreLabel");
			RunnerGame.NativeFieldInfoPtr_StartScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "StartScreen");
			RunnerGame.NativeFieldInfoPtr_GameOverScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "GameOverScreen");
			RunnerGame.NativeFieldInfoPtr_NewHighScoreAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "NewHighScoreAnimation");
			RunnerGame.NativeFieldInfoPtr_JumpSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "JumpSprite");
			RunnerGame.NativeFieldInfoPtr_isJumping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "isJumping");
			RunnerGame.NativeFieldInfoPtr_isGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "isGrounded");
			RunnerGame.NativeFieldInfoPtr_isReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "isReady");
			RunnerGame.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "score");
			RunnerGame.NativeFieldInfoPtr_yVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "yVelocity");
			RunnerGame.NativeFieldInfoPtr_defaultCharacterY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "defaultCharacterY");
			RunnerGame.NativeFieldInfoPtr_clouds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "clouds");
			RunnerGame.NativeFieldInfoPtr_obstacles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "obstacles");
			RunnerGame.NativeFieldInfoPtr_onJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "onJump");
			RunnerGame.NativeFieldInfoPtr_onHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "onHit");
			RunnerGame.NativeFieldInfoPtr_onNewHighScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "onNewHighScore");
			RunnerGame.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666605);
			RunnerGame.NativeMethodInfoPtr_Open_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666606);
			RunnerGame.NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666607);
			RunnerGame.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666608);
			RunnerGame.NativeMethodInfoPtr_Jump_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666609);
			RunnerGame.NativeMethodInfoPtr_CloudSpawned_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666610);
			RunnerGame.NativeMethodInfoPtr_ObstacleSpawned_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666611);
			RunnerGame.NativeMethodInfoPtr_RefreshHighScore_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666612);
			RunnerGame.NativeMethodInfoPtr_PlayerCollided_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666613);
			RunnerGame.NativeMethodInfoPtr_EndGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666614);
			RunnerGame.NativeMethodInfoPtr_StartGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666615);
			RunnerGame.NativeMethodInfoPtr_ResetGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666616);
			RunnerGame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666617);
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x000CC298 File Offset: 0x000CA498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98221, XrefRangeEnd = 98240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunnerGame.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x000CC2D4 File Offset: 0x000CA4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98240, XrefRangeEnd = 98242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunnerGame.NativeMethodInfoPtr_Open_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x000CC310 File Offset: 0x000CA510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98242, XrefRangeEnd = 98243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TryPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunnerGame.NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x000CC34C File Offset: 0x000CA54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98243, XrefRangeEnd = 98336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x000CC380 File Offset: 0x000CA580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98336, XrefRangeEnd = 98337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Jump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_Jump_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x000CC3B4 File Offset: 0x000CA5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98337, XrefRangeEnd = 98346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloudSpawned(GameObject cloud)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cloud);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_CloudSpawned_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x000CC3F8 File Offset: 0x000CA5F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98346, XrefRangeEnd = 98355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObstacleSpawned(GameObject obstacle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obstacle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_ObstacleSpawned_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x000CC43C File Offset: 0x000CA63C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98367, RefRangeEnd = 98369, XrefRangeStart = 98355, XrefRangeEnd = 98367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshHighScore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_RefreshHighScore_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x000CC470 File Offset: 0x000CA670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98369, XrefRangeEnd = 98371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerCollided()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_PlayerCollided_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x000CC4A4 File Offset: 0x000CA6A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98390, RefRangeEnd = 98392, XrefRangeStart = 98371, XrefRangeEnd = 98390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_EndGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x000CC4D8 File Offset: 0x000CA6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98392, XrefRangeEnd = 98396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_StartGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x000CC50C File Offset: 0x000CA70C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98447, RefRangeEnd = 98449, XrefRangeStart = 98396, XrefRangeEnd = 98447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_ResetGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x000CC540 File Offset: 0x000CA740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98449, XrefRangeEnd = 98462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunnerGame() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x0000D64D File Offset: 0x0000B84D
		public RunnerGame(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x000CC57C File Offset: 0x000CA77C
		// (set) Token: 0x0600187F RID: 6271 RVA: 0x0000D656 File Offset: 0x0000B856
		public unsafe float GameSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GameSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GameSpeed)) = value;
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x000CC5A4 File Offset: 0x000CA7A4
		// (set) Token: 0x06001881 RID: 6273 RVA: 0x0000D671 File Offset: 0x0000B871
		public unsafe float MinGameSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_MinGameSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_MinGameSpeed)) = value;
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x000CC5CC File Offset: 0x000CA7CC
		// (set) Token: 0x06001883 RID: 6275 RVA: 0x0000D68C File Offset: 0x0000B88C
		public unsafe float MaxGameSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_MaxGameSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_MaxGameSpeed)) = value;
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x000CC5F4 File Offset: 0x000CA7F4
		// (set) Token: 0x06001885 RID: 6277 RVA: 0x0000D6A7 File Offset: 0x0000B8A7
		public unsafe float SpeedIncreaseRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_SpeedIncreaseRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_SpeedIncreaseRate)) = value;
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06001886 RID: 6278 RVA: 0x000CC61C File Offset: 0x000CA81C
		// (set) Token: 0x06001887 RID: 6279 RVA: 0x0000D6C2 File Offset: 0x0000B8C2
		public unsafe int ScoreRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ScoreRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ScoreRate)) = value;
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x000CC644 File Offset: 0x000CA844
		// (set) Token: 0x06001889 RID: 6281 RVA: 0x0000D6DD File Offset: 0x0000B8DD
		public unsafe float Gravity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Gravity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Gravity)) = value;
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x000CC66C File Offset: 0x000CA86C
		// (set) Token: 0x0600188B RID: 6283 RVA: 0x0000D6F8 File Offset: 0x0000B8F8
		public unsafe float JumpForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_JumpForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_JumpForce)) = value;
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x000CC694 File Offset: 0x000CA894
		// (set) Token: 0x0600188D RID: 6285 RVA: 0x0000D713 File Offset: 0x0000B913
		public unsafe float GlobalForceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GlobalForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GlobalForceMultiplier)) = value;
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x000CC6BC File Offset: 0x000CA8BC
		// (set) Token: 0x0600188F RID: 6287 RVA: 0x0000D72E File Offset: 0x0000B92E
		public unsafe float DropForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_DropForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_DropForce)) = value;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001890 RID: 6288 RVA: 0x000CC6E4 File Offset: 0x000CA8E4
		// (set) Token: 0x06001891 RID: 6289 RVA: 0x0000D749 File Offset: 0x0000B949
		public unsafe RectTransform Character
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Character);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Character), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x000CC714 File Offset: 0x000CA914
		// (set) Token: 0x06001893 RID: 6291 RVA: 0x0000D768 File Offset: 0x0000B968
		public unsafe Flipboard CharacterFlipboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_CharacterFlipboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Flipboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_CharacterFlipboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06001894 RID: 6292 RVA: 0x000CC744 File Offset: 0x000CA944
		// (set) Token: 0x06001895 RID: 6293 RVA: 0x0000D787 File Offset: 0x0000B987
		public unsafe SlidingRect Ground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Ground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlidingRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Ground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x000CC774 File Offset: 0x000CA974
		// (set) Token: 0x06001897 RID: 6295 RVA: 0x0000D7A6 File Offset: 0x0000B9A6
		public unsafe UISpawner CloudSpawner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_CloudSpawner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISpawner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_CloudSpawner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06001898 RID: 6296 RVA: 0x000CC7A4 File Offset: 0x000CA9A4
		// (set) Token: 0x06001899 RID: 6297 RVA: 0x0000D7C5 File Offset: 0x0000B9C5
		public unsafe UISpawner ObstacleSpawner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ObstacleSpawner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISpawner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ObstacleSpawner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x0600189A RID: 6298 RVA: 0x000CC7D4 File Offset: 0x000CA9D4
		// (set) Token: 0x0600189B RID: 6299 RVA: 0x0000D7E4 File Offset: 0x0000B9E4
		public unsafe TextMeshProUGUI ScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x0600189C RID: 6300 RVA: 0x000CC804 File Offset: 0x000CAA04
		// (set) Token: 0x0600189D RID: 6301 RVA: 0x0000D803 File Offset: 0x0000BA03
		public unsafe TextMeshProUGUI HighScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_HighScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_HighScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x0600189E RID: 6302 RVA: 0x000CC834 File Offset: 0x000CAA34
		// (set) Token: 0x0600189F RID: 6303 RVA: 0x0000D822 File Offset: 0x0000BA22
		public unsafe GameObject StartScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_StartScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_StartScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x060018A0 RID: 6304 RVA: 0x000CC864 File Offset: 0x000CAA64
		// (set) Token: 0x060018A1 RID: 6305 RVA: 0x0000D841 File Offset: 0x0000BA41
		public unsafe GameObject GameOverScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GameOverScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GameOverScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060018A2 RID: 6306 RVA: 0x000CC894 File Offset: 0x000CAA94
		// (set) Token: 0x060018A3 RID: 6307 RVA: 0x0000D860 File Offset: 0x0000BA60
		public unsafe Animation NewHighScoreAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_NewHighScoreAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_NewHighScoreAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x060018A4 RID: 6308 RVA: 0x000CC8C4 File Offset: 0x000CAAC4
		// (set) Token: 0x060018A5 RID: 6309 RVA: 0x0000D87F File Offset: 0x0000BA7F
		public unsafe Sprite JumpSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_JumpSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_JumpSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x060018A6 RID: 6310 RVA: 0x000CC8F4 File Offset: 0x000CAAF4
		// (set) Token: 0x060018A7 RID: 6311 RVA: 0x0000D89E File Offset: 0x0000BA9E
		public unsafe bool isJumping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isJumping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isJumping)) = value;
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x060018A8 RID: 6312 RVA: 0x000CC91C File Offset: 0x000CAB1C
		// (set) Token: 0x060018A9 RID: 6313 RVA: 0x0000D8B9 File Offset: 0x0000BAB9
		public unsafe bool isGrounded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isGrounded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isGrounded)) = value;
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x060018AA RID: 6314 RVA: 0x000CC944 File Offset: 0x000CAB44
		// (set) Token: 0x060018AB RID: 6315 RVA: 0x0000D8D4 File Offset: 0x0000BAD4
		public unsafe bool isReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isReady);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isReady)) = value;
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x060018AC RID: 6316 RVA: 0x000CC96C File Offset: 0x000CAB6C
		// (set) Token: 0x060018AD RID: 6317 RVA: 0x0000D8EF File Offset: 0x0000BAEF
		public unsafe float score
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_score);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_score)) = value;
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x060018AE RID: 6318 RVA: 0x000CC994 File Offset: 0x000CAB94
		// (set) Token: 0x060018AF RID: 6319 RVA: 0x0000D90A File Offset: 0x0000BB0A
		public unsafe float yVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_yVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_yVelocity)) = value;
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060018B0 RID: 6320 RVA: 0x000CC9BC File Offset: 0x000CABBC
		// (set) Token: 0x060018B1 RID: 6321 RVA: 0x0000D925 File Offset: 0x0000BB25
		public unsafe float defaultCharacterY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_defaultCharacterY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_defaultCharacterY)) = value;
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060018B2 RID: 6322 RVA: 0x000CC9E4 File Offset: 0x000CABE4
		// (set) Token: 0x060018B3 RID: 6323 RVA: 0x0000D940 File Offset: 0x0000BB40
		public unsafe List<UIMover> clouds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_clouds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIMover>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_clouds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060018B4 RID: 6324 RVA: 0x000CCA14 File Offset: 0x000CAC14
		// (set) Token: 0x060018B5 RID: 6325 RVA: 0x0000D95F File Offset: 0x0000BB5F
		public unsafe List<UIMover> obstacles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_obstacles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIMover>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_obstacles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x060018B6 RID: 6326 RVA: 0x000CCA44 File Offset: 0x000CAC44
		// (set) Token: 0x060018B7 RID: 6327 RVA: 0x0000D97E File Offset: 0x0000BB7E
		public unsafe UnityEvent onJump
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onJump);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onJump), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x060018B8 RID: 6328 RVA: 0x000CCA74 File Offset: 0x000CAC74
		// (set) Token: 0x060018B9 RID: 6329 RVA: 0x0000D99D File Offset: 0x0000BB9D
		public unsafe UnityEvent onHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onHit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onHit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x060018BA RID: 6330 RVA: 0x000CCAA4 File Offset: 0x000CACA4
		// (set) Token: 0x060018BB RID: 6331 RVA: 0x0000D9BC File Offset: 0x0000BBBC
		public unsafe UnityEvent onNewHighScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onNewHighScore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onNewHighScore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeFieldInfoPtr_GameSpeed;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeFieldInfoPtr_MinGameSpeed;

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeFieldInfoPtr_MaxGameSpeed;

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeFieldInfoPtr_SpeedIncreaseRate;

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeFieldInfoPtr_ScoreRate;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeFieldInfoPtr_Gravity;

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeFieldInfoPtr_JumpForce;

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeFieldInfoPtr_GlobalForceMultiplier;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeFieldInfoPtr_DropForce;

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeFieldInfoPtr_Character;

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeFieldInfoPtr_CharacterFlipboard;

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeFieldInfoPtr_Ground;

		// Token: 0x04001103 RID: 4355
		private static readonly IntPtr NativeFieldInfoPtr_CloudSpawner;

		// Token: 0x04001104 RID: 4356
		private static readonly IntPtr NativeFieldInfoPtr_ObstacleSpawner;

		// Token: 0x04001105 RID: 4357
		private static readonly IntPtr NativeFieldInfoPtr_ScoreLabel;

		// Token: 0x04001106 RID: 4358
		private static readonly IntPtr NativeFieldInfoPtr_HighScoreLabel;

		// Token: 0x04001107 RID: 4359
		private static readonly IntPtr NativeFieldInfoPtr_StartScreen;

		// Token: 0x04001108 RID: 4360
		private static readonly IntPtr NativeFieldInfoPtr_GameOverScreen;

		// Token: 0x04001109 RID: 4361
		private static readonly IntPtr NativeFieldInfoPtr_NewHighScoreAnimation;

		// Token: 0x0400110A RID: 4362
		private static readonly IntPtr NativeFieldInfoPtr_JumpSprite;

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeFieldInfoPtr_isJumping;

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeFieldInfoPtr_isGrounded;

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeFieldInfoPtr_isReady;

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeFieldInfoPtr_score;

		// Token: 0x0400110F RID: 4367
		private static readonly IntPtr NativeFieldInfoPtr_yVelocity;

		// Token: 0x04001110 RID: 4368
		private static readonly IntPtr NativeFieldInfoPtr_defaultCharacterY;

		// Token: 0x04001111 RID: 4369
		private static readonly IntPtr NativeFieldInfoPtr_clouds;

		// Token: 0x04001112 RID: 4370
		private static readonly IntPtr NativeFieldInfoPtr_obstacles;

		// Token: 0x04001113 RID: 4371
		private static readonly IntPtr NativeFieldInfoPtr_onJump;

		// Token: 0x04001114 RID: 4372
		private static readonly IntPtr NativeFieldInfoPtr_onHit;

		// Token: 0x04001115 RID: 4373
		private static readonly IntPtr NativeFieldInfoPtr_onNewHighScore;

		// Token: 0x04001116 RID: 4374
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04001117 RID: 4375
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_0;

		// Token: 0x04001118 RID: 4376
		private static readonly IntPtr NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0;

		// Token: 0x04001119 RID: 4377
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x0400111A RID: 4378
		private static readonly IntPtr NativeMethodInfoPtr_Jump_Private_Void_0;

		// Token: 0x0400111B RID: 4379
		private static readonly IntPtr NativeMethodInfoPtr_CloudSpawned_Private_Void_GameObject_0;

		// Token: 0x0400111C RID: 4380
		private static readonly IntPtr NativeMethodInfoPtr_ObstacleSpawned_Private_Void_GameObject_0;

		// Token: 0x0400111D RID: 4381
		private static readonly IntPtr NativeMethodInfoPtr_RefreshHighScore_Private_Void_0;

		// Token: 0x0400111E RID: 4382
		private static readonly IntPtr NativeMethodInfoPtr_PlayerCollided_Public_Void_0;

		// Token: 0x0400111F RID: 4383
		private static readonly IntPtr NativeMethodInfoPtr_EndGame_Private_Void_0;

		// Token: 0x04001120 RID: 4384
		private static readonly IntPtr NativeMethodInfoPtr_StartGame_Private_Void_0;

		// Token: 0x04001121 RID: 4385
		private static readonly IntPtr NativeMethodInfoPtr_ResetGame_Private_Void_0;

		// Token: 0x04001122 RID: 4386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
