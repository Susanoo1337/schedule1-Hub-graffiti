using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x02000433 RID: 1075
	public class PlayingCard : MonoBehaviour
	{
		// Token: 0x06005F65 RID: 24421 RVA: 0x001C578C File Offset: 0x001C398C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayingCard()
		{
			Il2CppClassPointerStore<PlayingCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "PlayingCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr);
			PlayingCard.NativeFieldInfoPtr__IsFaceUp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<IsFaceUp>k__BackingField");
			PlayingCard.NativeFieldInfoPtr__Suit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<Suit>k__BackingField");
			PlayingCard.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<Value>k__BackingField");
			PlayingCard.NativeFieldInfoPtr__CardController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<CardController>k__BackingField");
			PlayingCard.NativeFieldInfoPtr_CardID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "CardID");
			PlayingCard.NativeFieldInfoPtr_CardSpriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "CardSpriteRenderer");
			PlayingCard.NativeFieldInfoPtr_CardSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "CardSprites");
			PlayingCard.NativeFieldInfoPtr_FlipAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "FlipAnimation");
			PlayingCard.NativeFieldInfoPtr_FlipFaceUpClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "FlipFaceUpClip");
			PlayingCard.NativeFieldInfoPtr_FlipFaceDownClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "FlipFaceDownClip");
			PlayingCard.NativeFieldInfoPtr_FlipSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "FlipSound");
			PlayingCard.NativeFieldInfoPtr_LandSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "LandSound");
			PlayingCard.NativeFieldInfoPtr_moveRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "moveRoutine");
			PlayingCard.NativeFieldInfoPtr_lastGlideTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "lastGlideTarget");
			PlayingCard.NativeMethodInfoPtr_get_IsFaceUp_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100675819);
			PlayingCard.NativeMethodInfoPtr_set_IsFaceUp_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100675820);
			PlayingCard.NativeMethodInfoPtr_get_Suit_Public_get_ECardSuit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100675821);
			PlayingCard.NativeMethodInfoPtr_set_Suit_Private_set_Void_ECardSuit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100675822);
			PlayingCard.NativeMethodInfoPtr_get_Value_Public_get_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100675823);
			PlayingCard.NativeMethodInfoPtr_set_Value_Private_set_Void_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100675824);
			PlayingCard.NativeMethodInfoPtr_get_CardController_Public_get_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100675825);
			PlayingCard.NativeMethodInfoPtr_set_CardController_Private_set_Void_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100675826);
			PlayingCard.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100675827);
			PlayingCard.NativeMethodInfoPtr_SetCardController_Public_Void_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100675828);
			PlayingCard.NativeMethodInfoPtr_SetCard_Public_Void_ECardSuit_ECardValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100675829);
			PlayingCard.NativeMethodInfoPtr_ClearCard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100675830);
			PlayingCard.NativeMethodInfoPtr_SetFaceUp_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100675831);
			PlayingCard.NativeMethodInfoPtr_GlideTo_Public_Void_Vector3_Quaternion_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100675832);
			PlayingCard.NativeMethodInfoPtr_GetCardSprite_Private_CardSprite_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100675833);
			PlayingCard.NativeMethodInfoPtr_VerifyCardSprites_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100675834);
			PlayingCard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100675835);
		}

		// Token: 0x17001D64 RID: 7524
		// (get) Token: 0x06005F66 RID: 24422 RVA: 0x001C5A28 File Offset: 0x001C3C28
		// (set) Token: 0x06005F67 RID: 24423 RVA: 0x001C5A64 File Offset: 0x001C3C64
		public unsafe bool IsFaceUp
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_get_IsFaceUp_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_set_IsFaceUp_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D65 RID: 7525
		// (get) Token: 0x06005F68 RID: 24424 RVA: 0x001C5AA4 File Offset: 0x001C3CA4
		// (set) Token: 0x06005F69 RID: 24425 RVA: 0x001C5AE0 File Offset: 0x001C3CE0
		public unsafe PlayingCard.ECardSuit Suit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_get_Suit_Public_get_ECardSuit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29041, RefRangeEnd = 29043, XrefRangeStart = 29041, XrefRangeEnd = 29043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_set_Suit_Private_set_Void_ECardSuit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D66 RID: 7526
		// (get) Token: 0x06005F6A RID: 24426 RVA: 0x001C5B20 File Offset: 0x001C3D20
		// (set) Token: 0x06005F6B RID: 24427 RVA: 0x001C5B5C File Offset: 0x001C3D5C
		public unsafe PlayingCard.ECardValue Value
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 29072, RefRangeEnd = 29101, XrefRangeStart = 29072, XrefRangeEnd = 29101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_get_Value_Public_get_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29101, RefRangeEnd = 29102, XrefRangeStart = 29101, XrefRangeEnd = 29102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_set_Value_Private_set_Void_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D67 RID: 7527
		// (get) Token: 0x06005F6C RID: 24428 RVA: 0x001C5B9C File Offset: 0x001C3D9C
		// (set) Token: 0x06005F6D RID: 24429 RVA: 0x001C5BDC File Offset: 0x001C3DDC
		public unsafe CardController CardController
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_get_CardController_Public_get_CardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardController>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 2978, RefRangeEnd = 2980, XrefRangeStart = 2978, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_set_CardController_Private_set_Void_CardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005F6E RID: 24430 RVA: 0x001C5C20 File Offset: 0x001C3E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203603, XrefRangeEnd = 203611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F6F RID: 24431 RVA: 0x001C5C54 File Offset: 0x001C3E54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 2978, RefRangeEnd = 2980, XrefRangeStart = 2978, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCardController(CardController cardController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_SetCardController_Public_Void_CardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F70 RID: 24432 RVA: 0x001C5C98 File Offset: 0x001C3E98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 203616, RefRangeEnd = 203620, XrefRangeStart = 203611, XrefRangeEnd = 203616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCard(PlayingCard.ECardSuit suit, PlayingCard.ECardValue value, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref suit;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_SetCard_Public_Void_ECardSuit_ECardValue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F71 RID: 24433 RVA: 0x001C5CF4 File Offset: 0x001C3EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203620, XrefRangeEnd = 203621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_ClearCard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F72 RID: 24434 RVA: 0x001C5D28 File Offset: 0x001C3F28
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 203629, RefRangeEnd = 203637, XrefRangeStart = 203621, XrefRangeEnd = 203629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFaceUp(bool faceUp, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref faceUp;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_SetFaceUp_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F73 RID: 24435 RVA: 0x001C5D74 File Offset: 0x001C3F74
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 203669, RefRangeEnd = 203681, XrefRangeStart = 203637, XrefRangeEnd = 203669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GlideTo(Vector3 position, Quaternion rotation, float duration = 0.5f, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_GlideTo_Public_Void_Vector3_Quaternion_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F74 RID: 24436 RVA: 0x001C5DDC File Offset: 0x001C3FDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203695, RefRangeEnd = 203696, XrefRangeStart = 203681, XrefRangeEnd = 203695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayingCard.CardSprite GetCardSprite(PlayingCard.ECardSuit suit, PlayingCard.ECardValue val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref suit;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_GetCardSprite_Private_CardSprite_ECardSuit_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayingCard.CardSprite>(intPtr3) : null;
		}

		// Token: 0x06005F75 RID: 24437 RVA: 0x001C5E38 File Offset: 0x001C4038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203696, XrefRangeEnd = 203776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VerifyCardSprites()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_VerifyCardSprites_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F76 RID: 24438 RVA: 0x001C5E6C File Offset: 0x001C406C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203776, XrefRangeEnd = 203781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayingCard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F77 RID: 24439 RVA: 0x0002D074 File Offset: 0x0002B274
		public PlayingCard(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D56 RID: 7510
		// (get) Token: 0x06005F78 RID: 24440 RVA: 0x001C5EA8 File Offset: 0x001C40A8
		// (set) Token: 0x06005F79 RID: 24441 RVA: 0x0002D07D File Offset: 0x0002B27D
		public unsafe bool _IsFaceUp_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__IsFaceUp_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__IsFaceUp_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D57 RID: 7511
		// (get) Token: 0x06005F7A RID: 24442 RVA: 0x001C5ED0 File Offset: 0x001C40D0
		// (set) Token: 0x06005F7B RID: 24443 RVA: 0x0002D098 File Offset: 0x0002B298
		public unsafe PlayingCard.ECardSuit _Suit_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__Suit_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__Suit_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D58 RID: 7512
		// (get) Token: 0x06005F7C RID: 24444 RVA: 0x001C5EF8 File Offset: 0x001C40F8
		// (set) Token: 0x06005F7D RID: 24445 RVA: 0x0002D0B3 File Offset: 0x0002B2B3
		public unsafe PlayingCard.ECardValue _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__Value_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__Value_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D59 RID: 7513
		// (get) Token: 0x06005F7E RID: 24446 RVA: 0x001C5F20 File Offset: 0x001C4120
		// (set) Token: 0x06005F7F RID: 24447 RVA: 0x0002D0CE File Offset: 0x0002B2CE
		public unsafe CardController _CardController_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__CardController_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__CardController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D5A RID: 7514
		// (get) Token: 0x06005F80 RID: 24448 RVA: 0x001C5F50 File Offset: 0x001C4150
		// (set) Token: 0x06005F81 RID: 24449 RVA: 0x0002D0ED File Offset: 0x0002B2ED
		public unsafe string CardID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D5B RID: 7515
		// (get) Token: 0x06005F82 RID: 24450 RVA: 0x001C5F78 File Offset: 0x001C4178
		// (set) Token: 0x06005F83 RID: 24451 RVA: 0x0002D10C File Offset: 0x0002B30C
		public unsafe SpriteRenderer CardSpriteRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardSpriteRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardSpriteRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D5C RID: 7516
		// (get) Token: 0x06005F84 RID: 24452 RVA: 0x001C5FA8 File Offset: 0x001C41A8
		// (set) Token: 0x06005F85 RID: 24453 RVA: 0x0002D12B File Offset: 0x0002B32B
		public unsafe Il2CppReferenceArray<PlayingCard.CardSprite> CardSprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardSprites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayingCard.CardSprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardSprites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D5D RID: 7517
		// (get) Token: 0x06005F86 RID: 24454 RVA: 0x001C5FD8 File Offset: 0x001C41D8
		// (set) Token: 0x06005F87 RID: 24455 RVA: 0x0002D14A File Offset: 0x0002B34A
		public unsafe Animation FlipAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D5E RID: 7518
		// (get) Token: 0x06005F88 RID: 24456 RVA: 0x001C6008 File Offset: 0x001C4208
		// (set) Token: 0x06005F89 RID: 24457 RVA: 0x0002D169 File Offset: 0x0002B369
		public unsafe AnimationClip FlipFaceUpClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipFaceUpClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipFaceUpClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D5F RID: 7519
		// (get) Token: 0x06005F8A RID: 24458 RVA: 0x001C6038 File Offset: 0x001C4238
		// (set) Token: 0x06005F8B RID: 24459 RVA: 0x0002D188 File Offset: 0x0002B388
		public unsafe AnimationClip FlipFaceDownClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipFaceDownClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipFaceDownClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D60 RID: 7520
		// (get) Token: 0x06005F8C RID: 24460 RVA: 0x001C6068 File Offset: 0x001C4268
		// (set) Token: 0x06005F8D RID: 24461 RVA: 0x0002D1A7 File Offset: 0x0002B3A7
		public unsafe AudioSourceController FlipSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x06005F8E RID: 24462 RVA: 0x001C6098 File Offset: 0x001C4298
		// (set) Token: 0x06005F8F RID: 24463 RVA: 0x0002D1C6 File Offset: 0x0002B3C6
		public unsafe AudioSourceController LandSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_LandSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_LandSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x06005F90 RID: 24464 RVA: 0x001C60C8 File Offset: 0x001C42C8
		// (set) Token: 0x06005F91 RID: 24465 RVA: 0x0002D1E5 File Offset: 0x0002B3E5
		public unsafe Coroutine moveRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_moveRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_moveRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x06005F92 RID: 24466 RVA: 0x001C60F8 File Offset: 0x001C42F8
		// (set) Token: 0x06005F93 RID: 24467 RVA: 0x0002D204 File Offset: 0x0002B404
		public unsafe Tuple<Vector3, Quaternion> lastGlideTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_lastGlideTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tuple<Vector3, Quaternion>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_lastGlideTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040041B6 RID: 16822
		private static readonly IntPtr NativeFieldInfoPtr__IsFaceUp_k__BackingField;

		// Token: 0x040041B7 RID: 16823
		private static readonly IntPtr NativeFieldInfoPtr__Suit_k__BackingField;

		// Token: 0x040041B8 RID: 16824
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x040041B9 RID: 16825
		private static readonly IntPtr NativeFieldInfoPtr__CardController_k__BackingField;

		// Token: 0x040041BA RID: 16826
		private static readonly IntPtr NativeFieldInfoPtr_CardID;

		// Token: 0x040041BB RID: 16827
		private static readonly IntPtr NativeFieldInfoPtr_CardSpriteRenderer;

		// Token: 0x040041BC RID: 16828
		private static readonly IntPtr NativeFieldInfoPtr_CardSprites;

		// Token: 0x040041BD RID: 16829
		private static readonly IntPtr NativeFieldInfoPtr_FlipAnimation;

		// Token: 0x040041BE RID: 16830
		private static readonly IntPtr NativeFieldInfoPtr_FlipFaceUpClip;

		// Token: 0x040041BF RID: 16831
		private static readonly IntPtr NativeFieldInfoPtr_FlipFaceDownClip;

		// Token: 0x040041C0 RID: 16832
		private static readonly IntPtr NativeFieldInfoPtr_FlipSound;

		// Token: 0x040041C1 RID: 16833
		private static readonly IntPtr NativeFieldInfoPtr_LandSound;

		// Token: 0x040041C2 RID: 16834
		private static readonly IntPtr NativeFieldInfoPtr_moveRoutine;

		// Token: 0x040041C3 RID: 16835
		private static readonly IntPtr NativeFieldInfoPtr_lastGlideTarget;

		// Token: 0x040041C4 RID: 16836
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFaceUp_Public_get_Boolean_0;

		// Token: 0x040041C5 RID: 16837
		private static readonly IntPtr NativeMethodInfoPtr_set_IsFaceUp_Private_set_Void_Boolean_0;

		// Token: 0x040041C6 RID: 16838
		private static readonly IntPtr NativeMethodInfoPtr_get_Suit_Public_get_ECardSuit_0;

		// Token: 0x040041C7 RID: 16839
		private static readonly IntPtr NativeMethodInfoPtr_set_Suit_Private_set_Void_ECardSuit_0;

		// Token: 0x040041C8 RID: 16840
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_ECardValue_0;

		// Token: 0x040041C9 RID: 16841
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Private_set_Void_ECardValue_0;

		// Token: 0x040041CA RID: 16842
		private static readonly IntPtr NativeMethodInfoPtr_get_CardController_Public_get_CardController_0;

		// Token: 0x040041CB RID: 16843
		private static readonly IntPtr NativeMethodInfoPtr_set_CardController_Private_set_Void_CardController_0;

		// Token: 0x040041CC RID: 16844
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x040041CD RID: 16845
		private static readonly IntPtr NativeMethodInfoPtr_SetCardController_Public_Void_CardController_0;

		// Token: 0x040041CE RID: 16846
		private static readonly IntPtr NativeMethodInfoPtr_SetCard_Public_Void_ECardSuit_ECardValue_Boolean_0;

		// Token: 0x040041CF RID: 16847
		private static readonly IntPtr NativeMethodInfoPtr_ClearCard_Public_Void_0;

		// Token: 0x040041D0 RID: 16848
		private static readonly IntPtr NativeMethodInfoPtr_SetFaceUp_Public_Void_Boolean_Boolean_0;

		// Token: 0x040041D1 RID: 16849
		private static readonly IntPtr NativeMethodInfoPtr_GlideTo_Public_Void_Vector3_Quaternion_Single_Boolean_0;

		// Token: 0x040041D2 RID: 16850
		private static readonly IntPtr NativeMethodInfoPtr_GetCardSprite_Private_CardSprite_ECardSuit_ECardValue_0;

		// Token: 0x040041D3 RID: 16851
		private static readonly IntPtr NativeMethodInfoPtr_VerifyCardSprites_Public_Void_0;

		// Token: 0x040041D4 RID: 16852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B22 RID: 2850
		[Serializable]
		public class CardSprite : Il2CppSystem.Object
		{
			// Token: 0x0600E630 RID: 58928 RVA: 0x00383258 File Offset: 0x00381458
			// Note: this type is marked as 'beforefieldinit'.
			static CardSprite()
			{
				Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "CardSprite");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr);
				PlayingCard.CardSprite.NativeFieldInfoPtr_Suit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr, "Suit");
				PlayingCard.CardSprite.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr, "Value");
				PlayingCard.CardSprite.NativeFieldInfoPtr_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr, "Sprite");
				PlayingCard.CardSprite.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr, 100675836);
			}

			// Token: 0x0600E631 RID: 58929 RVA: 0x003832D4 File Offset: 0x003814D4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CardSprite() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.CardSprite.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E632 RID: 58930 RVA: 0x0006C8B4 File Offset: 0x0006AAB4
			public CardSprite(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045E0 RID: 17888
			// (get) Token: 0x0600E633 RID: 58931 RVA: 0x00383310 File Offset: 0x00381510
			// (set) Token: 0x0600E634 RID: 58932 RVA: 0x0006C8BD File Offset: 0x0006AABD
			public unsafe PlayingCard.ECardSuit Suit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Suit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Suit)) = value;
				}
			}

			// Token: 0x170045E1 RID: 17889
			// (get) Token: 0x0600E635 RID: 58933 RVA: 0x00383338 File Offset: 0x00381538
			// (set) Token: 0x0600E636 RID: 58934 RVA: 0x0006C8D8 File Offset: 0x0006AAD8
			public unsafe PlayingCard.ECardValue Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Value)) = value;
				}
			}

			// Token: 0x170045E2 RID: 17890
			// (get) Token: 0x0600E637 RID: 58935 RVA: 0x00383360 File Offset: 0x00381560
			// (set) Token: 0x0600E638 RID: 58936 RVA: 0x0006C8F3 File Offset: 0x0006AAF3
			public unsafe Sprite Sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009C2E RID: 39982
			private static readonly IntPtr NativeFieldInfoPtr_Suit;

			// Token: 0x04009C2F RID: 39983
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x04009C30 RID: 39984
			private static readonly IntPtr NativeFieldInfoPtr_Sprite;

			// Token: 0x04009C31 RID: 39985
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B23 RID: 2851
		[StructLayout(2)]
		public struct CardData
		{
			// Token: 0x0600E639 RID: 58937 RVA: 0x00383390 File Offset: 0x00381590
			// Note: this type is marked as 'beforefieldinit'.
			static CardData()
			{
				Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "CardData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr);
				PlayingCard.CardData.NativeFieldInfoPtr_Suit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr, "Suit");
				PlayingCard.CardData.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr, "Value");
				PlayingCard.CardData.NativeMethodInfoPtr__ctor_Public_Void_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr, 100675837);
			}

			// Token: 0x0600E63A RID: 58938 RVA: 0x003833F8 File Offset: 0x003815F8
			[CallerCount(494)]
			[CachedScanResults(RefRangeStart = 60743, RefRangeEnd = 61237, XrefRangeStart = 60743, XrefRangeEnd = 61237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CardData(PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref suit;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.CardData.NativeMethodInfoPtr__ctor_Public_Void_ECardSuit_ECardValue_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E63B RID: 58939 RVA: 0x0006C912 File Offset: 0x0006AB12
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr, ref this));
			}

			// Token: 0x04009C32 RID: 39986
			private static readonly IntPtr NativeFieldInfoPtr_Suit;

			// Token: 0x04009C33 RID: 39987
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x04009C34 RID: 39988
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ECardSuit_ECardValue_0;

			// Token: 0x04009C35 RID: 39989
			[FieldOffset(0)]
			public PlayingCard.ECardSuit Suit;

			// Token: 0x04009C36 RID: 39990
			[FieldOffset(4)]
			public PlayingCard.ECardValue Value;
		}

		// Token: 0x02000B24 RID: 2852
		[OriginalName("Assembly-CSharp.dll", "", "ECardSuit")]
		public enum ECardSuit
		{
			// Token: 0x04009C38 RID: 39992
			Spades,
			// Token: 0x04009C39 RID: 39993
			Hearts,
			// Token: 0x04009C3A RID: 39994
			Diamonds,
			// Token: 0x04009C3B RID: 39995
			Clubs
		}

		// Token: 0x02000B25 RID: 2853
		[OriginalName("Assembly-CSharp.dll", "", "ECardValue")]
		public enum ECardValue
		{
			// Token: 0x04009C3D RID: 39997
			Blank,
			// Token: 0x04009C3E RID: 39998
			Ace,
			// Token: 0x04009C3F RID: 39999
			Two,
			// Token: 0x04009C40 RID: 40000
			Three,
			// Token: 0x04009C41 RID: 40001
			Four,
			// Token: 0x04009C42 RID: 40002
			Five,
			// Token: 0x04009C43 RID: 40003
			Six,
			// Token: 0x04009C44 RID: 40004
			Seven,
			// Token: 0x04009C45 RID: 40005
			Eight,
			// Token: 0x04009C46 RID: 40006
			Nine,
			// Token: 0x04009C47 RID: 40007
			Ten,
			// Token: 0x04009C48 RID: 40008
			Jack,
			// Token: 0x04009C49 RID: 40009
			Queen,
			// Token: 0x04009C4A RID: 40010
			King
		}

		// Token: 0x02000B26 RID: 2854
		[ObfuscatedName("ScheduleOne.Casino.PlayingCard+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E63C RID: 58940 RVA: 0x00383438 File Offset: 0x00381638
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr);
				PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
				PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "duration");
				PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "position");
				PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_verticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "verticalOffset");
				PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "rotation");
				PlayingCard.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, 100675838);
				PlayingCard.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, 100675839);
			}

			// Token: 0x0600E63D RID: 58941 RVA: 0x003834F0 File Offset: 0x003816F0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E63E RID: 58942 RVA: 0x0038352C File Offset: 0x0038172C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203598, XrefRangeEnd = 203603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E63F RID: 58943 RVA: 0x0006C924 File Offset: 0x0006AB24
			public __c__DisplayClass35_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045E3 RID: 17891
			// (get) Token: 0x0600E640 RID: 58944 RVA: 0x0038356C File Offset: 0x0038176C
			// (set) Token: 0x0600E641 RID: 58945 RVA: 0x0006C92D File Offset: 0x0006AB2D
			public unsafe PlayingCard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayingCard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045E4 RID: 17892
			// (get) Token: 0x0600E642 RID: 58946 RVA: 0x0038359C File Offset: 0x0038179C
			// (set) Token: 0x0600E643 RID: 58947 RVA: 0x0006C94C File Offset: 0x0006AB4C
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x170045E5 RID: 17893
			// (get) Token: 0x0600E644 RID: 58948 RVA: 0x003835C4 File Offset: 0x003817C4
			// (set) Token: 0x0600E645 RID: 58949 RVA: 0x0006C967 File Offset: 0x0006AB67
			public unsafe Vector3 position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x170045E6 RID: 17894
			// (get) Token: 0x0600E646 RID: 58950 RVA: 0x003835EC File Offset: 0x003817EC
			// (set) Token: 0x0600E647 RID: 58951 RVA: 0x0006C982 File Offset: 0x0006AB82
			public unsafe float verticalOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_verticalOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_verticalOffset)) = value;
				}
			}

			// Token: 0x170045E7 RID: 17895
			// (get) Token: 0x0600E648 RID: 58952 RVA: 0x00383614 File Offset: 0x00381814
			// (set) Token: 0x0600E649 RID: 58953 RVA: 0x0006C99D File Offset: 0x0006AB9D
			public unsafe Quaternion rotation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_rotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_rotation)) = value;
				}
			}

			// Token: 0x04009C4B RID: 40011
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009C4C RID: 40012
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04009C4D RID: 40013
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x04009C4E RID: 40014
			private static readonly IntPtr NativeFieldInfoPtr_verticalOffset;

			// Token: 0x04009C4F RID: 40015
			private static readonly IntPtr NativeFieldInfoPtr_rotation;

			// Token: 0x04009C50 RID: 40016
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C51 RID: 40017
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DD8 RID: 3544
			[ObfuscatedName("ScheduleOne.Casino.PlayingCard+<>c__DisplayClass35_0+<<GlideTo>g__MoveRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FFC8 RID: 65480 RVA: 0x003CCD88 File Offset: 0x003CAF88
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique()
				{
					Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "<<GlideTo>g__MoveRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<>1__state");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<>2__current");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<>4__this");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startPosition_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<startPosition>5__2");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startRotation_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<startRotation>5__3");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__time_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<time>5__4");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100675840);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100675841);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100675842);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100675843);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100675844);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100675845);
				}

				// Token: 0x0600FFC9 RID: 65481 RVA: 0x003CCEA4 File Offset: 0x003CB0A4
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FFCA RID: 65482 RVA: 0x003CCEEC File Offset: 0x003CB0EC
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FFCB RID: 65483 RVA: 0x003CCF20 File Offset: 0x003CB120
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203573, XrefRangeEnd = 203593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004DE9 RID: 19945
				// (get) Token: 0x0600FFCC RID: 65484 RVA: 0x003CCF5C File Offset: 0x003CB15C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FFCD RID: 65485 RVA: 0x003CCF9C File Offset: 0x003CB19C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203593, XrefRangeEnd = 203598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004DEA RID: 19946
				// (get) Token: 0x0600FFCE RID: 65486 RVA: 0x003CCFD0 File Offset: 0x003CB1D0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FFCF RID: 65487 RVA: 0x00079365 File Offset: 0x00077565
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004DE3 RID: 19939
				// (get) Token: 0x0600FFD0 RID: 65488 RVA: 0x003CD010 File Offset: 0x003CB210
				// (set) Token: 0x0600FFD1 RID: 65489 RVA: 0x0007936E File Offset: 0x0007756E
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004DE4 RID: 19940
				// (get) Token: 0x0600FFD2 RID: 65490 RVA: 0x003CD038 File Offset: 0x003CB238
				// (set) Token: 0x0600FFD3 RID: 65491 RVA: 0x00079389 File Offset: 0x00077589
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DE5 RID: 19941
				// (get) Token: 0x0600FFD4 RID: 65492 RVA: 0x003CD068 File Offset: 0x003CB268
				// (set) Token: 0x0600FFD5 RID: 65493 RVA: 0x000793A8 File Offset: 0x000775A8
				public unsafe PlayingCard.__c__DisplayClass35_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayingCard.__c__DisplayClass35_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DE6 RID: 19942
				// (get) Token: 0x0600FFD6 RID: 65494 RVA: 0x003CD098 File Offset: 0x003CB298
				// (set) Token: 0x0600FFD7 RID: 65495 RVA: 0x000793C7 File Offset: 0x000775C7
				public unsafe Vector3 _startPosition_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startPosition_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startPosition_5__2)) = value;
					}
				}

				// Token: 0x17004DE7 RID: 19943
				// (get) Token: 0x0600FFD8 RID: 65496 RVA: 0x003CD0C0 File Offset: 0x003CB2C0
				// (set) Token: 0x0600FFD9 RID: 65497 RVA: 0x000793E2 File Offset: 0x000775E2
				public unsafe Quaternion _startRotation_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startRotation_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startRotation_5__3)) = value;
					}
				}

				// Token: 0x17004DE8 RID: 19944
				// (get) Token: 0x0600FFDA RID: 65498 RVA: 0x003CD0E8 File Offset: 0x003CB2E8
				// (set) Token: 0x0600FFDB RID: 65499 RVA: 0x000793FD File Offset: 0x000775FD
				public unsafe float _time_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__time_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__time_5__4)) = value;
					}
				}

				// Token: 0x0400AC51 RID: 44113
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AC52 RID: 44114
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AC53 RID: 44115
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AC54 RID: 44116
				private static readonly IntPtr NativeFieldInfoPtr__startPosition_5__2;

				// Token: 0x0400AC55 RID: 44117
				private static readonly IntPtr NativeFieldInfoPtr__startRotation_5__3;

				// Token: 0x0400AC56 RID: 44118
				private static readonly IntPtr NativeFieldInfoPtr__time_5__4;

				// Token: 0x0400AC57 RID: 44119
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AC58 RID: 44120
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC59 RID: 44121
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AC5A RID: 44122
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AC5B RID: 44123
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC5C RID: 44124
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B27 RID: 2855
		[ObfuscatedName("ScheduleOne.Casino.PlayingCard+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E64A RID: 58954 RVA: 0x0038363C File Offset: 0x0038183C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr);
				PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_suit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr, "suit");
				PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr, "val");
				PlayingCard.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr, 100675846);
				PlayingCard.__c__DisplayClass36_0.NativeMethodInfoPtr__GetCardSprite_b__0_Internal_Boolean_CardSprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr, 100675847);
			}

			// Token: 0x0600E64B RID: 58955 RVA: 0x003836B8 File Offset: 0x003818B8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E64C RID: 58956 RVA: 0x003836F4 File Offset: 0x003818F4
			[CallerCount(0)]
			public unsafe bool _GetCardSprite_b__0(PlayingCard.CardSprite x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass36_0.NativeMethodInfoPtr__GetCardSprite_b__0_Internal_Boolean_CardSprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E64D RID: 58957 RVA: 0x0006C9B8 File Offset: 0x0006ABB8
			public __c__DisplayClass36_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045E8 RID: 17896
			// (get) Token: 0x0600E64E RID: 58958 RVA: 0x00383744 File Offset: 0x00381944
			// (set) Token: 0x0600E64F RID: 58959 RVA: 0x0006C9C1 File Offset: 0x0006ABC1
			public unsafe PlayingCard.ECardSuit suit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_suit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_suit)) = value;
				}
			}

			// Token: 0x170045E9 RID: 17897
			// (get) Token: 0x0600E650 RID: 58960 RVA: 0x0038376C File Offset: 0x0038196C
			// (set) Token: 0x0600E651 RID: 58961 RVA: 0x0006C9DC File Offset: 0x0006ABDC
			public unsafe PlayingCard.ECardValue val
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_val);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_val)) = value;
				}
			}

			// Token: 0x04009C52 RID: 40018
			private static readonly IntPtr NativeFieldInfoPtr_suit;

			// Token: 0x04009C53 RID: 40019
			private static readonly IntPtr NativeFieldInfoPtr_val;

			// Token: 0x04009C54 RID: 40020
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C55 RID: 40021
			private static readonly IntPtr NativeMethodInfoPtr__GetCardSprite_b__0_Internal_Boolean_CardSprite_0;
		}
	}
}
