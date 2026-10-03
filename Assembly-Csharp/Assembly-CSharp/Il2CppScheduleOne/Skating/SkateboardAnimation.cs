using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Skating
{
	// Token: 0x0200012D RID: 301
	public class SkateboardAnimation : MonoBehaviour
	{
		// Token: 0x06001DCD RID: 7629 RVA: 0x000DD708 File Offset: 0x000DB908
		// Note: this type is marked as 'beforefieldinit'.
		static SkateboardAnimation()
		{
			Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "SkateboardAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr);
			SkateboardAnimation.NativeFieldInfoPtr_JumpCrouchAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "JumpCrouchAmount");
			SkateboardAnimation.NativeFieldInfoPtr_CrouchSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "CrouchSpeed");
			SkateboardAnimation.NativeFieldInfoPtr_ArmLiftRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "ArmLiftRate");
			SkateboardAnimation.NativeFieldInfoPtr_PelvisMaxRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "PelvisMaxRotation");
			SkateboardAnimation.NativeFieldInfoPtr_HandsMaxRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "HandsMaxRotation");
			SkateboardAnimation.NativeFieldInfoPtr_PelvisOffsetBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "PelvisOffsetBlend");
			SkateboardAnimation.NativeFieldInfoPtr_VerticalMomentumMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "VerticalMomentumMultiplier");
			SkateboardAnimation.NativeFieldInfoPtr_VerticalMomentumOffsetClamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "VerticalMomentumOffsetClamp");
			SkateboardAnimation.NativeFieldInfoPtr_MomentumMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "MomentumMoveSpeed");
			SkateboardAnimation.NativeFieldInfoPtr_IKBlendChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "IKBlendChangeRate");
			SkateboardAnimation.NativeFieldInfoPtr_PushAnimationDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "PushAnimationDuration");
			SkateboardAnimation.NativeFieldInfoPtr_PushAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "PushAnimationSpeed");
			SkateboardAnimation.NativeFieldInfoPtr_PushAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "PushAnim");
			SkateboardAnimation.NativeFieldInfoPtr_PelvisContainerAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "PelvisContainerAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_PelvisAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "PelvisAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_SpineContainerAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "SpineContainerAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_SpineAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "SpineAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_SpineAlignment_Hunched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "SpineAlignment_Hunched");
			SkateboardAnimation.NativeFieldInfoPtr_LeftFootAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "LeftFootAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_RightFootAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "RightFootAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_LeftLegBendTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "LeftLegBendTarget");
			SkateboardAnimation.NativeFieldInfoPtr_RightLegBendTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "RightLegBendTarget");
			SkateboardAnimation.NativeFieldInfoPtr_LeftHandAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "LeftHandAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_RightHandAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "RightHandAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_AvatarFaceTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "AvatarFaceTarget");
			SkateboardAnimation.NativeFieldInfoPtr_HandContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "HandContainer");
			SkateboardAnimation.NativeFieldInfoPtr_IKAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "IKAnimation");
			SkateboardAnimation.NativeFieldInfoPtr_LeftHandLoweredAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "LeftHandLoweredAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_LeftHandRaisedAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "LeftHandRaisedAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_RightHandLoweredAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "RightHandLoweredAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_RightHandRaisedAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "RightHandRaisedAlignment");
			SkateboardAnimation.NativeFieldInfoPtr_board = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "board");
			SkateboardAnimation.NativeFieldInfoPtr_currentCrouchShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "currentCrouchShift");
			SkateboardAnimation.NativeFieldInfoPtr_targetArmLift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "targetArmLift");
			SkateboardAnimation.NativeFieldInfoPtr_currentArmLift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "currentArmLift");
			SkateboardAnimation.NativeFieldInfoPtr_pelvisDefaultRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "pelvisDefaultRotation");
			SkateboardAnimation.NativeFieldInfoPtr_pelvisDefaultPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "pelvisDefaultPosition");
			SkateboardAnimation.NativeFieldInfoPtr_spineDefaultPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "spineDefaultPosition");
			SkateboardAnimation.NativeFieldInfoPtr_currentMomentumOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "currentMomentumOffset");
			SkateboardAnimation.NativeFieldInfoPtr_ikBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "ikBlend");
			SkateboardAnimation.NativeFieldInfoPtr_alignmentSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "alignmentSets");
			SkateboardAnimation.NativeMethodInfoPtr_get_CurrentCrouchShift_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667204);
			SkateboardAnimation.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667205);
			SkateboardAnimation.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667206);
			SkateboardAnimation.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667207);
			SkateboardAnimation.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667208);
			SkateboardAnimation.NativeMethodInfoPtr_UpdateIKBlend_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667209);
			SkateboardAnimation.NativeMethodInfoPtr_UpdateBodyAlignment_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667210);
			SkateboardAnimation.NativeMethodInfoPtr_UpdateArmLift_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667211);
			SkateboardAnimation.NativeMethodInfoPtr_UpdatePelvisRotation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667212);
			SkateboardAnimation.NativeMethodInfoPtr_SetArmLift_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667213);
			SkateboardAnimation.NativeMethodInfoPtr_OnPushStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667214);
			SkateboardAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, 100667215);
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06001DCE RID: 7630 RVA: 0x000DDB5C File Offset: 0x000DBD5C
		public unsafe float CurrentCrouchShift
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_get_CurrentCrouchShift_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x000DDB98 File Offset: 0x000DBD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104581, XrefRangeEnd = 104653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x000DDBCC File Offset: 0x000DBDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104653, XrefRangeEnd = 104654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x000DDC00 File Offset: 0x000DBE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104654, XrefRangeEnd = 104657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x000DDC34 File Offset: 0x000DBE34
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x000DDC68 File Offset: 0x000DBE68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104685, RefRangeEnd = 104686, XrefRangeStart = 104657, XrefRangeEnd = 104685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIKBlend()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_UpdateIKBlend_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x000DDC9C File Offset: 0x000DBE9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104703, RefRangeEnd = 104704, XrefRangeStart = 104686, XrefRangeEnd = 104703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBodyAlignment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_UpdateBodyAlignment_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x000DDCD0 File Offset: 0x000DBED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104728, RefRangeEnd = 104729, XrefRangeStart = 104704, XrefRangeEnd = 104728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateArmLift()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_UpdateArmLift_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x000DDD04 File Offset: 0x000DBF04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104741, RefRangeEnd = 104742, XrefRangeStart = 104729, XrefRangeEnd = 104741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePelvisRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_UpdatePelvisRotation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x000DDD38 File Offset: 0x000DBF38
		[CallerCount(0)]
		public unsafe void SetArmLift(float lift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lift;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_SetArmLift_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x000DDD78 File Offset: 0x000DBF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104742, XrefRangeEnd = 104749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPushStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr_OnPushStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x000DDDAC File Offset: 0x000DBFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104749, XrefRangeEnd = 104757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkateboardAnimation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x000100E9 File Offset: 0x0000E2E9
		public SkateboardAnimation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06001DDB RID: 7643 RVA: 0x000DDDE8 File Offset: 0x000DBFE8
		// (set) Token: 0x06001DDC RID: 7644 RVA: 0x000100F2 File Offset: 0x0000E2F2
		public unsafe float JumpCrouchAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_JumpCrouchAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_JumpCrouchAmount)) = value;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x000DDE10 File Offset: 0x000DC010
		// (set) Token: 0x06001DDE RID: 7646 RVA: 0x0001010D File Offset: 0x0000E30D
		public unsafe float CrouchSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_CrouchSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_CrouchSpeed)) = value;
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06001DDF RID: 7647 RVA: 0x000DDE38 File Offset: 0x000DC038
		// (set) Token: 0x06001DE0 RID: 7648 RVA: 0x00010128 File Offset: 0x0000E328
		public unsafe float ArmLiftRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_ArmLiftRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_ArmLiftRate)) = value;
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x000DDE60 File Offset: 0x000DC060
		// (set) Token: 0x06001DE2 RID: 7650 RVA: 0x00010143 File Offset: 0x0000E343
		public unsafe float PelvisMaxRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisMaxRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisMaxRotation)) = value;
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x000DDE88 File Offset: 0x000DC088
		// (set) Token: 0x06001DE4 RID: 7652 RVA: 0x0001015E File Offset: 0x0000E35E
		public unsafe float HandsMaxRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_HandsMaxRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_HandsMaxRotation)) = value;
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x000DDEB0 File Offset: 0x000DC0B0
		// (set) Token: 0x06001DE6 RID: 7654 RVA: 0x00010179 File Offset: 0x0000E379
		public unsafe float PelvisOffsetBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisOffsetBlend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisOffsetBlend)) = value;
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x000DDED8 File Offset: 0x000DC0D8
		// (set) Token: 0x06001DE8 RID: 7656 RVA: 0x00010194 File Offset: 0x0000E394
		public unsafe float VerticalMomentumMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_VerticalMomentumMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_VerticalMomentumMultiplier)) = value;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06001DE9 RID: 7657 RVA: 0x000DDF00 File Offset: 0x000DC100
		// (set) Token: 0x06001DEA RID: 7658 RVA: 0x000101AF File Offset: 0x0000E3AF
		public unsafe float VerticalMomentumOffsetClamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_VerticalMomentumOffsetClamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_VerticalMomentumOffsetClamp)) = value;
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06001DEB RID: 7659 RVA: 0x000DDF28 File Offset: 0x000DC128
		// (set) Token: 0x06001DEC RID: 7660 RVA: 0x000101CA File Offset: 0x0000E3CA
		public unsafe float MomentumMoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_MomentumMoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_MomentumMoveSpeed)) = value;
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x000DDF50 File Offset: 0x000DC150
		// (set) Token: 0x06001DEE RID: 7662 RVA: 0x000101E5 File Offset: 0x0000E3E5
		public unsafe float IKBlendChangeRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_IKBlendChangeRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_IKBlendChangeRate)) = value;
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x000DDF78 File Offset: 0x000DC178
		// (set) Token: 0x06001DF0 RID: 7664 RVA: 0x00010200 File Offset: 0x0000E400
		public unsafe float PushAnimationDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PushAnimationDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PushAnimationDuration)) = value;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x000DDFA0 File Offset: 0x000DC1A0
		// (set) Token: 0x06001DF2 RID: 7666 RVA: 0x0001021B File Offset: 0x0000E41B
		public unsafe float PushAnimationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PushAnimationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PushAnimationSpeed)) = value;
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06001DF3 RID: 7667 RVA: 0x000DDFC8 File Offset: 0x000DC1C8
		// (set) Token: 0x06001DF4 RID: 7668 RVA: 0x00010236 File Offset: 0x0000E436
		public unsafe AnimationClip PushAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PushAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PushAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x000DDFF8 File Offset: 0x000DC1F8
		// (set) Token: 0x06001DF6 RID: 7670 RVA: 0x00010255 File Offset: 0x0000E455
		public unsafe SkateboardAnimation.AlignmentSet PelvisContainerAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisContainerAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisContainerAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06001DF7 RID: 7671 RVA: 0x000DE028 File Offset: 0x000DC228
		// (set) Token: 0x06001DF8 RID: 7672 RVA: 0x00010274 File Offset: 0x0000E474
		public unsafe SkateboardAnimation.AlignmentSet PelvisAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_PelvisAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x000DE058 File Offset: 0x000DC258
		// (set) Token: 0x06001DFA RID: 7674 RVA: 0x00010293 File Offset: 0x0000E493
		public unsafe SkateboardAnimation.AlignmentSet SpineContainerAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_SpineContainerAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_SpineContainerAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06001DFB RID: 7675 RVA: 0x000DE088 File Offset: 0x000DC288
		// (set) Token: 0x06001DFC RID: 7676 RVA: 0x000102B2 File Offset: 0x0000E4B2
		public unsafe SkateboardAnimation.AlignmentSet SpineAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_SpineAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_SpineAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x000DE0B8 File Offset: 0x000DC2B8
		// (set) Token: 0x06001DFE RID: 7678 RVA: 0x000102D1 File Offset: 0x0000E4D1
		public unsafe Transform SpineAlignment_Hunched
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_SpineAlignment_Hunched);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_SpineAlignment_Hunched), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06001DFF RID: 7679 RVA: 0x000DE0E8 File Offset: 0x000DC2E8
		// (set) Token: 0x06001E00 RID: 7680 RVA: 0x000102F0 File Offset: 0x0000E4F0
		public unsafe SkateboardAnimation.AlignmentSet LeftFootAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftFootAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftFootAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06001E01 RID: 7681 RVA: 0x000DE118 File Offset: 0x000DC318
		// (set) Token: 0x06001E02 RID: 7682 RVA: 0x0001030F File Offset: 0x0000E50F
		public unsafe SkateboardAnimation.AlignmentSet RightFootAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightFootAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightFootAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06001E03 RID: 7683 RVA: 0x000DE148 File Offset: 0x000DC348
		// (set) Token: 0x06001E04 RID: 7684 RVA: 0x0001032E File Offset: 0x0000E52E
		public unsafe SkateboardAnimation.AlignmentSet LeftLegBendTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftLegBendTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftLegBendTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06001E05 RID: 7685 RVA: 0x000DE178 File Offset: 0x000DC378
		// (set) Token: 0x06001E06 RID: 7686 RVA: 0x0001034D File Offset: 0x0000E54D
		public unsafe SkateboardAnimation.AlignmentSet RightLegBendTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightLegBendTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightLegBendTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06001E07 RID: 7687 RVA: 0x000DE1A8 File Offset: 0x000DC3A8
		// (set) Token: 0x06001E08 RID: 7688 RVA: 0x0001036C File Offset: 0x0000E56C
		public unsafe SkateboardAnimation.AlignmentSet LeftHandAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftHandAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftHandAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06001E09 RID: 7689 RVA: 0x000DE1D8 File Offset: 0x000DC3D8
		// (set) Token: 0x06001E0A RID: 7690 RVA: 0x0001038B File Offset: 0x0000E58B
		public unsafe SkateboardAnimation.AlignmentSet RightHandAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightHandAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightHandAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06001E0B RID: 7691 RVA: 0x000DE208 File Offset: 0x000DC408
		// (set) Token: 0x06001E0C RID: 7692 RVA: 0x000103AA File Offset: 0x0000E5AA
		public unsafe Transform AvatarFaceTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_AvatarFaceTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_AvatarFaceTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06001E0D RID: 7693 RVA: 0x000DE238 File Offset: 0x000DC438
		// (set) Token: 0x06001E0E RID: 7694 RVA: 0x000103C9 File Offset: 0x0000E5C9
		public unsafe Transform HandContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_HandContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_HandContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06001E0F RID: 7695 RVA: 0x000DE268 File Offset: 0x000DC468
		// (set) Token: 0x06001E10 RID: 7696 RVA: 0x000103E8 File Offset: 0x0000E5E8
		public unsafe Animation IKAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_IKAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_IKAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06001E11 RID: 7697 RVA: 0x000DE298 File Offset: 0x000DC498
		// (set) Token: 0x06001E12 RID: 7698 RVA: 0x00010407 File Offset: 0x0000E607
		public unsafe SkateboardAnimation.AlignmentSet LeftHandLoweredAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftHandLoweredAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftHandLoweredAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06001E13 RID: 7699 RVA: 0x000DE2C8 File Offset: 0x000DC4C8
		// (set) Token: 0x06001E14 RID: 7700 RVA: 0x00010426 File Offset: 0x0000E626
		public unsafe SkateboardAnimation.AlignmentSet LeftHandRaisedAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftHandRaisedAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_LeftHandRaisedAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06001E15 RID: 7701 RVA: 0x000DE2F8 File Offset: 0x000DC4F8
		// (set) Token: 0x06001E16 RID: 7702 RVA: 0x00010445 File Offset: 0x0000E645
		public unsafe SkateboardAnimation.AlignmentSet RightHandLoweredAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightHandLoweredAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightHandLoweredAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06001E17 RID: 7703 RVA: 0x000DE328 File Offset: 0x000DC528
		// (set) Token: 0x06001E18 RID: 7704 RVA: 0x00010464 File Offset: 0x0000E664
		public unsafe SkateboardAnimation.AlignmentSet RightHandRaisedAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightHandRaisedAlignment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation.AlignmentSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_RightHandRaisedAlignment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06001E19 RID: 7705 RVA: 0x000DE358 File Offset: 0x000DC558
		// (set) Token: 0x06001E1A RID: 7706 RVA: 0x00010483 File Offset: 0x0000E683
		public unsafe Skateboard board
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_board);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_board), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x000DE388 File Offset: 0x000DC588
		// (set) Token: 0x06001E1C RID: 7708 RVA: 0x000104A2 File Offset: 0x0000E6A2
		public unsafe float currentCrouchShift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_currentCrouchShift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_currentCrouchShift)) = value;
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06001E1D RID: 7709 RVA: 0x000DE3B0 File Offset: 0x000DC5B0
		// (set) Token: 0x06001E1E RID: 7710 RVA: 0x000104BD File Offset: 0x0000E6BD
		public unsafe float targetArmLift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_targetArmLift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_targetArmLift)) = value;
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06001E1F RID: 7711 RVA: 0x000DE3D8 File Offset: 0x000DC5D8
		// (set) Token: 0x06001E20 RID: 7712 RVA: 0x000104D8 File Offset: 0x0000E6D8
		public unsafe float currentArmLift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_currentArmLift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_currentArmLift)) = value;
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06001E21 RID: 7713 RVA: 0x000DE400 File Offset: 0x000DC600
		// (set) Token: 0x06001E22 RID: 7714 RVA: 0x000104F3 File Offset: 0x0000E6F3
		public unsafe Quaternion pelvisDefaultRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_pelvisDefaultRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_pelvisDefaultRotation)) = value;
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06001E23 RID: 7715 RVA: 0x000DE428 File Offset: 0x000DC628
		// (set) Token: 0x06001E24 RID: 7716 RVA: 0x0001050E File Offset: 0x0000E70E
		public unsafe Vector3 pelvisDefaultPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_pelvisDefaultPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_pelvisDefaultPosition)) = value;
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x000DE450 File Offset: 0x000DC650
		// (set) Token: 0x06001E26 RID: 7718 RVA: 0x00010529 File Offset: 0x0000E729
		public unsafe Vector3 spineDefaultPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_spineDefaultPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_spineDefaultPosition)) = value;
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06001E27 RID: 7719 RVA: 0x000DE478 File Offset: 0x000DC678
		// (set) Token: 0x06001E28 RID: 7720 RVA: 0x00010544 File Offset: 0x0000E744
		public unsafe float currentMomentumOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_currentMomentumOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_currentMomentumOffset)) = value;
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06001E29 RID: 7721 RVA: 0x000DE4A0 File Offset: 0x000DC6A0
		// (set) Token: 0x06001E2A RID: 7722 RVA: 0x0001055F File Offset: 0x0000E75F
		public unsafe float ikBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_ikBlend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_ikBlend)) = value;
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06001E2B RID: 7723 RVA: 0x000DE4C8 File Offset: 0x000DC6C8
		// (set) Token: 0x06001E2C RID: 7724 RVA: 0x0001057A File Offset: 0x0000E77A
		public unsafe List<SkateboardAnimation.AlignmentSet> alignmentSets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_alignmentSets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SkateboardAnimation.AlignmentSet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.NativeFieldInfoPtr_alignmentSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014B9 RID: 5305
		private static readonly IntPtr NativeFieldInfoPtr_JumpCrouchAmount;

		// Token: 0x040014BA RID: 5306
		private static readonly IntPtr NativeFieldInfoPtr_CrouchSpeed;

		// Token: 0x040014BB RID: 5307
		private static readonly IntPtr NativeFieldInfoPtr_ArmLiftRate;

		// Token: 0x040014BC RID: 5308
		private static readonly IntPtr NativeFieldInfoPtr_PelvisMaxRotation;

		// Token: 0x040014BD RID: 5309
		private static readonly IntPtr NativeFieldInfoPtr_HandsMaxRotation;

		// Token: 0x040014BE RID: 5310
		private static readonly IntPtr NativeFieldInfoPtr_PelvisOffsetBlend;

		// Token: 0x040014BF RID: 5311
		private static readonly IntPtr NativeFieldInfoPtr_VerticalMomentumMultiplier;

		// Token: 0x040014C0 RID: 5312
		private static readonly IntPtr NativeFieldInfoPtr_VerticalMomentumOffsetClamp;

		// Token: 0x040014C1 RID: 5313
		private static readonly IntPtr NativeFieldInfoPtr_MomentumMoveSpeed;

		// Token: 0x040014C2 RID: 5314
		private static readonly IntPtr NativeFieldInfoPtr_IKBlendChangeRate;

		// Token: 0x040014C3 RID: 5315
		private static readonly IntPtr NativeFieldInfoPtr_PushAnimationDuration;

		// Token: 0x040014C4 RID: 5316
		private static readonly IntPtr NativeFieldInfoPtr_PushAnimationSpeed;

		// Token: 0x040014C5 RID: 5317
		private static readonly IntPtr NativeFieldInfoPtr_PushAnim;

		// Token: 0x040014C6 RID: 5318
		private static readonly IntPtr NativeFieldInfoPtr_PelvisContainerAlignment;

		// Token: 0x040014C7 RID: 5319
		private static readonly IntPtr NativeFieldInfoPtr_PelvisAlignment;

		// Token: 0x040014C8 RID: 5320
		private static readonly IntPtr NativeFieldInfoPtr_SpineContainerAlignment;

		// Token: 0x040014C9 RID: 5321
		private static readonly IntPtr NativeFieldInfoPtr_SpineAlignment;

		// Token: 0x040014CA RID: 5322
		private static readonly IntPtr NativeFieldInfoPtr_SpineAlignment_Hunched;

		// Token: 0x040014CB RID: 5323
		private static readonly IntPtr NativeFieldInfoPtr_LeftFootAlignment;

		// Token: 0x040014CC RID: 5324
		private static readonly IntPtr NativeFieldInfoPtr_RightFootAlignment;

		// Token: 0x040014CD RID: 5325
		private static readonly IntPtr NativeFieldInfoPtr_LeftLegBendTarget;

		// Token: 0x040014CE RID: 5326
		private static readonly IntPtr NativeFieldInfoPtr_RightLegBendTarget;

		// Token: 0x040014CF RID: 5327
		private static readonly IntPtr NativeFieldInfoPtr_LeftHandAlignment;

		// Token: 0x040014D0 RID: 5328
		private static readonly IntPtr NativeFieldInfoPtr_RightHandAlignment;

		// Token: 0x040014D1 RID: 5329
		private static readonly IntPtr NativeFieldInfoPtr_AvatarFaceTarget;

		// Token: 0x040014D2 RID: 5330
		private static readonly IntPtr NativeFieldInfoPtr_HandContainer;

		// Token: 0x040014D3 RID: 5331
		private static readonly IntPtr NativeFieldInfoPtr_IKAnimation;

		// Token: 0x040014D4 RID: 5332
		private static readonly IntPtr NativeFieldInfoPtr_LeftHandLoweredAlignment;

		// Token: 0x040014D5 RID: 5333
		private static readonly IntPtr NativeFieldInfoPtr_LeftHandRaisedAlignment;

		// Token: 0x040014D6 RID: 5334
		private static readonly IntPtr NativeFieldInfoPtr_RightHandLoweredAlignment;

		// Token: 0x040014D7 RID: 5335
		private static readonly IntPtr NativeFieldInfoPtr_RightHandRaisedAlignment;

		// Token: 0x040014D8 RID: 5336
		private static readonly IntPtr NativeFieldInfoPtr_board;

		// Token: 0x040014D9 RID: 5337
		private static readonly IntPtr NativeFieldInfoPtr_currentCrouchShift;

		// Token: 0x040014DA RID: 5338
		private static readonly IntPtr NativeFieldInfoPtr_targetArmLift;

		// Token: 0x040014DB RID: 5339
		private static readonly IntPtr NativeFieldInfoPtr_currentArmLift;

		// Token: 0x040014DC RID: 5340
		private static readonly IntPtr NativeFieldInfoPtr_pelvisDefaultRotation;

		// Token: 0x040014DD RID: 5341
		private static readonly IntPtr NativeFieldInfoPtr_pelvisDefaultPosition;

		// Token: 0x040014DE RID: 5342
		private static readonly IntPtr NativeFieldInfoPtr_spineDefaultPosition;

		// Token: 0x040014DF RID: 5343
		private static readonly IntPtr NativeFieldInfoPtr_currentMomentumOffset;

		// Token: 0x040014E0 RID: 5344
		private static readonly IntPtr NativeFieldInfoPtr_ikBlend;

		// Token: 0x040014E1 RID: 5345
		private static readonly IntPtr NativeFieldInfoPtr_alignmentSets;

		// Token: 0x040014E2 RID: 5346
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentCrouchShift_Public_get_Single_0;

		// Token: 0x040014E3 RID: 5347
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040014E4 RID: 5348
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040014E5 RID: 5349
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040014E6 RID: 5350
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040014E7 RID: 5351
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIKBlend_Private_Void_0;

		// Token: 0x040014E8 RID: 5352
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBodyAlignment_Private_Void_0;

		// Token: 0x040014E9 RID: 5353
		private static readonly IntPtr NativeMethodInfoPtr_UpdateArmLift_Private_Void_0;

		// Token: 0x040014EA RID: 5354
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePelvisRotation_Private_Void_0;

		// Token: 0x040014EB RID: 5355
		private static readonly IntPtr NativeMethodInfoPtr_SetArmLift_Public_Void_Single_0;

		// Token: 0x040014EC RID: 5356
		private static readonly IntPtr NativeMethodInfoPtr_OnPushStart_Private_Void_0;

		// Token: 0x040014ED RID: 5357
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200095B RID: 2395
		[Serializable]
		public class AlignmentSet : Il2CppSystem.Object
		{
			// Token: 0x0600D8B9 RID: 55481 RVA: 0x0035D554 File Offset: 0x0035B754
			// Note: this type is marked as 'beforefieldinit'.
			static AlignmentSet()
			{
				Il2CppClassPointerStore<SkateboardAnimation.AlignmentSet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SkateboardAnimation>.NativeClassPtr, "AlignmentSet");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkateboardAnimation.AlignmentSet>.NativeClassPtr);
				SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation.AlignmentSet>.NativeClassPtr, "Transform");
				SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation.AlignmentSet>.NativeClassPtr, "Default");
				SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Animated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAnimation.AlignmentSet>.NativeClassPtr, "Animated");
				SkateboardAnimation.AlignmentSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAnimation.AlignmentSet>.NativeClassPtr, 100667216);
			}

			// Token: 0x0600D8BA RID: 55482 RVA: 0x0035D5D0 File Offset: 0x0035B7D0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AlignmentSet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkateboardAnimation.AlignmentSet>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAnimation.AlignmentSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8BB RID: 55483 RVA: 0x00065E8D File Offset: 0x0006408D
			public AlignmentSet(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700422F RID: 16943
			// (get) Token: 0x0600D8BC RID: 55484 RVA: 0x0035D60C File Offset: 0x0035B80C
			// (set) Token: 0x0600D8BD RID: 55485 RVA: 0x00065E96 File Offset: 0x00064096
			public unsafe Transform Transform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Transform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Transform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004230 RID: 16944
			// (get) Token: 0x0600D8BE RID: 55486 RVA: 0x0035D63C File Offset: 0x0035B83C
			// (set) Token: 0x0600D8BF RID: 55487 RVA: 0x00065EB5 File Offset: 0x000640B5
			public unsafe Transform Default
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Default);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Default), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004231 RID: 16945
			// (get) Token: 0x0600D8C0 RID: 55488 RVA: 0x0035D66C File Offset: 0x0035B86C
			// (set) Token: 0x0600D8C1 RID: 55489 RVA: 0x00065ED4 File Offset: 0x000640D4
			public unsafe Transform Animated
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Animated);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAnimation.AlignmentSet.NativeFieldInfoPtr_Animated), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093FB RID: 37883
			private static readonly IntPtr NativeFieldInfoPtr_Transform;

			// Token: 0x040093FC RID: 37884
			private static readonly IntPtr NativeFieldInfoPtr_Default;

			// Token: 0x040093FD RID: 37885
			private static readonly IntPtr NativeFieldInfoPtr_Animated;

			// Token: 0x040093FE RID: 37886
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
