using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Skating;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x020004BA RID: 1210
	public class AvatarAnimation : MonoBehaviour
	{
		// Token: 0x06006E53 RID: 28243 RVA: 0x001F784C File Offset: 0x001F5A4C
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarAnimation()
		{
			Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr);
			AvatarAnimation.NativeFieldInfoPtr_ImpostorsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "ImpostorsEnabled");
			AvatarAnimation.NativeFieldInfoPtr_MaxDirectionSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "MaxDirectionSpeed");
			AvatarAnimation.NativeFieldInfoPtr_MaxStrafeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "MaxStrafeSpeed");
			AvatarAnimation.NativeFieldInfoPtr_MaxCrouchDirectionSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "MaxCrouchDirectionSpeed");
			AvatarAnimation.NativeFieldInfoPtr_MaxCrouchStrafeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "MaxCrouchStrafeSpeed");
			AvatarAnimation.NativeFieldInfoPtr_BlendIncreaseMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "BlendIncreaseMultiplier");
			AvatarAnimation.NativeFieldInfoPtr_BlendReduceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "BlendReduceMultiplier");
			AvatarAnimation.NativeFieldInfoPtr_FrustrumCullMinDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "FrustrumCullMinDist");
			AvatarAnimation.NativeFieldInfoPtr_RunningAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "RunningAnimationSpeed");
			AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "MaxBoneOffset");
			AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffsetSqr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "MaxBoneOffsetSqr");
			AvatarAnimation.NativeFieldInfoPtr_SITTING_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "SITTING_OFFSET");
			AvatarAnimation.NativeFieldInfoPtr_SEAT_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "SEAT_TIME");
			AvatarAnimation.NativeFieldInfoPtr_StandUpFromBackClipName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "StandUpFromBackClipName");
			AvatarAnimation.NativeFieldInfoPtr_StandUpFromFrontClipName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "StandUpFromFrontClipName");
			AvatarAnimation.NativeFieldInfoPtr__IsCrouched_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<IsCrouched>k__BackingField");
			AvatarAnimation.NativeFieldInfoPtr__TimeSinceSitEnd_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<TimeSinceSitEnd>k__BackingField");
			AvatarAnimation.NativeFieldInfoPtr__CurrentSeat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<CurrentSeat>k__BackingField");
			AvatarAnimation.NativeFieldInfoPtr__StandUpAnimationPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<StandUpAnimationPlaying>k__BackingField");
			AvatarAnimation.NativeFieldInfoPtr__IsAvatarCulled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<IsAvatarCulled>k__BackingField");
			AvatarAnimation.NativeFieldInfoPtr_DEBUG_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "DEBUG_MODE");
			AvatarAnimation.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "animator");
			AvatarAnimation.NativeFieldInfoPtr_HipBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "HipBone");
			AvatarAnimation.NativeFieldInfoPtr_Bones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "Bones");
			AvatarAnimation.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "avatar");
			AvatarAnimation.NativeFieldInfoPtr_LeftHandContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "LeftHandContainer");
			AvatarAnimation.NativeFieldInfoPtr_RightHandContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "RightHandContainer");
			AvatarAnimation.NativeFieldInfoPtr_RightHandAlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "RightHandAlignmentPoint");
			AvatarAnimation.NativeFieldInfoPtr_LeftHandAlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "LeftHandAlignmentPoint");
			AvatarAnimation.NativeFieldInfoPtr_IKController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "IKController");
			AvatarAnimation.NativeFieldInfoPtr_FootstepDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "FootstepDetector");
			AvatarAnimation.NativeFieldInfoPtr_GroundingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "GroundingMask");
			AvatarAnimation.NativeFieldInfoPtr_AllowCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "AllowCulling");
			AvatarAnimation.NativeFieldInfoPtr_VisibilityRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "VisibilityRange");
			AvatarAnimation.NativeFieldInfoPtr_DirectionAnimationValueCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "DirectionAnimationValueCurve");
			AvatarAnimation.NativeFieldInfoPtr_StrafeAnimationValueCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "StrafeAnimationValueCurve");
			AvatarAnimation.NativeFieldInfoPtr_CrouchMovementAnimationValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "CrouchMovementAnimationValue");
			AvatarAnimation.NativeFieldInfoPtr_StrafeBlendMultiplierCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "StrafeBlendMultiplierCurve");
			AvatarAnimation.NativeFieldInfoPtr_onStandupStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "onStandupStart");
			AvatarAnimation.NativeFieldInfoPtr_onStandupDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "onStandupDone");
			AvatarAnimation.NativeFieldInfoPtr_onHeavyFlinch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "onHeavyFlinch");
			AvatarAnimation.NativeFieldInfoPtr_standUpFromBackBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "standUpFromBackBoneTransforms");
			AvatarAnimation.NativeFieldInfoPtr_standUpFromFrontBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "standUpFromFrontBoneTransforms");
			AvatarAnimation.NativeFieldInfoPtr_ragdollBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "ragdollBoneTransforms");
			AvatarAnimation.NativeFieldInfoPtr_standUpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "standUpRoutine");
			AvatarAnimation.NativeFieldInfoPtr_seatRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "seatRoutine");
			AvatarAnimation.NativeFieldInfoPtr_activeSkateboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "activeSkateboard");
			AvatarAnimation.NativeFieldInfoPtr_animationEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "animationEnabled");
			AvatarAnimation.NativeFieldInfoPtr__lastFrameBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "_lastFrameBoneTransforms");
			AvatarAnimation.NativeFieldInfoPtr__lastFrameBoneTransformsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "_lastFrameBoneTransformsValid");
			AvatarAnimation.NativeFieldInfoPtr__activateRagdollNextFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "_activateRagdollNextFrame");
			AvatarAnimation.NativeFieldInfoPtr_visibilityRangeSqr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "visibilityRangeSqr");
			AvatarAnimation.NativeFieldInfoPtr__currentStrafeBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "_currentStrafeBlend");
			AvatarAnimation.NativeFieldInfoPtr__lastTargetStrafe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "_lastTargetStrafe");
			AvatarAnimation.NativeFieldInfoPtr__currentDirectionBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "_currentDirectionBlend");
			AvatarAnimation.NativeFieldInfoPtr__lastTargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "_lastTargetDirection");
			AvatarAnimation.NativeFieldInfoPtr__lastMotionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "_lastMotionTime");
			AvatarAnimation.NativeFieldInfoPtr__smoothedMotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "_smoothedMotion");
			AvatarAnimation.NativeMethodInfoPtr_get_IsCrouched_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677647);
			AvatarAnimation.NativeMethodInfoPtr_set_IsCrouched_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677648);
			AvatarAnimation.NativeMethodInfoPtr_get_IsSeated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677649);
			AvatarAnimation.NativeMethodInfoPtr_get_TimeSinceSitEnd_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677650);
			AvatarAnimation.NativeMethodInfoPtr_set_TimeSinceSitEnd_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677651);
			AvatarAnimation.NativeMethodInfoPtr_get_CurrentSeat_Public_get_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677652);
			AvatarAnimation.NativeMethodInfoPtr_set_CurrentSeat_Protected_set_Void_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677653);
			AvatarAnimation.NativeMethodInfoPtr_get_StandUpAnimationPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677654);
			AvatarAnimation.NativeMethodInfoPtr_set_StandUpAnimationPlaying_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677655);
			AvatarAnimation.NativeMethodInfoPtr_get_IsAvatarCulled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677656);
			AvatarAnimation.NativeMethodInfoPtr_set_IsAvatarCulled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677657);
			AvatarAnimation.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677658);
			AvatarAnimation.NativeMethodInfoPtr_RecalculateVisibilityRangeSqr_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677659);
			AvatarAnimation.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677660);
			AvatarAnimation.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677661);
			AvatarAnimation.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677662);
			AvatarAnimation.NativeMethodInfoPtr_UpdateAnimationActive_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677663);
			AvatarAnimation.NativeMethodInfoPtr_SetMotion_Public_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677664);
			AvatarAnimation.NativeMethodInfoPtr_UpdateBlend_Private_Single_byref_Single_Single_Single_byref_Single_AnimationCurve_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677665);
			AvatarAnimation.NativeMethodInfoPtr_SetDirection_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677666);
			AvatarAnimation.NativeMethodInfoPtr_SetStrafe_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677667);
			AvatarAnimation.NativeMethodInfoPtr_SetTimeAirborne_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677668);
			AvatarAnimation.NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677669);
			AvatarAnimation.NativeMethodInfoPtr_SetGrounded_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677670);
			AvatarAnimation.NativeMethodInfoPtr_Jump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677671);
			AvatarAnimation.NativeMethodInfoPtr_SetAnimationEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677672);
			AvatarAnimation.NativeMethodInfoPtr_ResetAnimatorState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677673);
			AvatarAnimation.NativeMethodInfoPtr_Flinch_Public_Void_Vector3_EFlinchType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677674);
			AvatarAnimation.NativeMethodInfoPtr_PlayStandUpAnimation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677675);
			AvatarAnimation.NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677676);
			AvatarAnimation.NativeMethodInfoPtr_AlignPositionToHips_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677677);
			AvatarAnimation.NativeMethodInfoPtr_ShouldGetUpFromBack_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677678);
			AvatarAnimation.NativeMethodInfoPtr_PopulateBoneTransforms_Private_Void_Il2CppReferenceArray_1_BoneTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677679);
			AvatarAnimation.NativeMethodInfoPtr_PopulateAnimationStartBoneTransforms_Private_Void_String_Il2CppReferenceArray_1_BoneTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677680);
			AvatarAnimation.NativeMethodInfoPtr_ApplyBoneTransforms_Private_Void_Il2CppReferenceArray_1_BoneTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677681);
			AvatarAnimation.NativeMethodInfoPtr_SetTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677682);
			AvatarAnimation.NativeMethodInfoPtr_ResetTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677683);
			AvatarAnimation.NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677684);
			AvatarAnimation.NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677685);
			AvatarAnimation.NativeMethodInfoPtr_SkateboardMounted_Public_Void_Skateboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677686);
			AvatarAnimation.NativeMethodInfoPtr_SkateboardDismounted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677687);
			AvatarAnimation.NativeMethodInfoPtr_SkateboardPush_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677688);
			AvatarAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100677689);
		}

		// Token: 0x17002237 RID: 8759
		// (get) Token: 0x06006E54 RID: 28244 RVA: 0x001F8060 File Offset: 0x001F6260
		// (set) Token: 0x06006E55 RID: 28245 RVA: 0x001F809C File Offset: 0x001F629C
		public unsafe bool IsCrouched
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_IsCrouched_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_set_IsCrouched_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002238 RID: 8760
		// (get) Token: 0x06006E56 RID: 28246 RVA: 0x001F80DC File Offset: 0x001F62DC
		public unsafe bool IsSeated
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 222799, RefRangeEnd = 222800, XrefRangeStart = 222795, XrefRangeEnd = 222799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_IsSeated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002239 RID: 8761
		// (get) Token: 0x06006E57 RID: 28247 RVA: 0x001F8118 File Offset: 0x001F6318
		// (set) Token: 0x06006E58 RID: 28248 RVA: 0x001F8154 File Offset: 0x001F6354
		public unsafe float TimeSinceSitEnd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_TimeSinceSitEnd_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 29058, RefRangeEnd = 29072, XrefRangeStart = 29058, XrefRangeEnd = 29072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_set_TimeSinceSitEnd_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700223A RID: 8762
		// (get) Token: 0x06006E59 RID: 28249 RVA: 0x001F8194 File Offset: 0x001F6394
		// (set) Token: 0x06006E5A RID: 28250 RVA: 0x001F81D4 File Offset: 0x001F63D4
		public unsafe AvatarSeat CurrentSeat
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_CurrentSeat_Public_get_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarSeat>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_set_CurrentSeat_Protected_set_Void_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700223B RID: 8763
		// (get) Token: 0x06006E5B RID: 28251 RVA: 0x001F8218 File Offset: 0x001F6418
		// (set) Token: 0x06006E5C RID: 28252 RVA: 0x001F8254 File Offset: 0x001F6454
		public unsafe bool StandUpAnimationPlaying
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_StandUpAnimationPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_set_StandUpAnimationPlaying_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700223C RID: 8764
		// (get) Token: 0x06006E5D RID: 28253 RVA: 0x001F8294 File Offset: 0x001F6494
		// (set) Token: 0x06006E5E RID: 28254 RVA: 0x001F82D0 File Offset: 0x001F64D0
		public unsafe bool IsAvatarCulled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_IsAvatarCulled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 53226, RefRangeEnd = 53227, XrefRangeStart = 53226, XrefRangeEnd = 53227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_set_IsAvatarCulled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006E5F RID: 28255 RVA: 0x001F8310 File Offset: 0x001F6510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222800, XrefRangeEnd = 222880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarAnimation.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E60 RID: 28256 RVA: 0x001F834C File Offset: 0x001F654C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222880, XrefRangeEnd = 222882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateVisibilityRangeSqr(int a, int b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_RecalculateVisibilityRangeSqr_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E61 RID: 28257 RVA: 0x001F8398 File Offset: 0x001F6598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222882, XrefRangeEnd = 222908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E62 RID: 28258 RVA: 0x001F83CC File Offset: 0x001F65CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222908, XrefRangeEnd = 222934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E63 RID: 28259 RVA: 0x001F8400 File Offset: 0x001F6600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222934, XrefRangeEnd = 222935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E64 RID: 28260 RVA: 0x001F8434 File Offset: 0x001F6634
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 222979, RefRangeEnd = 222982, XrefRangeStart = 222935, XrefRangeEnd = 222979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAnimationActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_UpdateAnimationActive_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E65 RID: 28261 RVA: 0x001F8468 File Offset: 0x001F6668
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223000, RefRangeEnd = 223002, XrefRangeStart = 222982, XrefRangeEnd = 223000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMotion(Vector3 relativeMotion, bool isCrouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref relativeMotion;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCrouched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetMotion_Public_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E66 RID: 28262 RVA: 0x001F84B4 File Offset: 0x001F66B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223010, RefRangeEnd = 223012, XrefRangeStart = 223002, XrefRangeEnd = 223010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float UpdateBlend(ref float blend, float relativeMotion, float maxSpeed, ref float lastTargetInput, AnimationCurve curve, float tick, float blendMultiplier = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &blend;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeMotion;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lastTargetInput;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(curve);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tick;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blendMultiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_UpdateBlend_Private_Single_byref_Single_Single_Single_byref_Single_AnimationCurve_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006E67 RID: 28263 RVA: 0x001F8558 File Offset: 0x001F6758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223012, XrefRangeEnd = 223018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirection(float dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetDirection_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E68 RID: 28264 RVA: 0x001F8598 File Offset: 0x001F6798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223018, XrefRangeEnd = 223024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStrafe(float strafe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref strafe;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetStrafe_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E69 RID: 28265 RVA: 0x001F85D8 File Offset: 0x001F67D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223030, RefRangeEnd = 223031, XrefRangeStart = 223024, XrefRangeEnd = 223030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTimeAirborne(float airbone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref airbone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetTimeAirborne_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E6A RID: 28266 RVA: 0x001F8618 File Offset: 0x001F6818
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 223037, RefRangeEnd = 223042, XrefRangeStart = 223031, XrefRangeEnd = 223037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCrouched(bool crouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref crouched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E6B RID: 28267 RVA: 0x001F8658 File Offset: 0x001F6858
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223048, RefRangeEnd = 223049, XrefRangeStart = 223042, XrefRangeEnd = 223048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGrounded(bool grounded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref grounded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetGrounded_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E6C RID: 28268 RVA: 0x001F8698 File Offset: 0x001F6898
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223055, RefRangeEnd = 223057, XrefRangeStart = 223049, XrefRangeEnd = 223055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Jump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_Jump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E6D RID: 28269 RVA: 0x001F86CC File Offset: 0x001F68CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223069, RefRangeEnd = 223071, XrefRangeStart = 223057, XrefRangeEnd = 223069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAnimationEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetAnimationEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E6E RID: 28270 RVA: 0x001F870C File Offset: 0x001F690C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223081, RefRangeEnd = 223082, XrefRangeStart = 223071, XrefRangeEnd = 223081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAnimatorState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_ResetAnimatorState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E6F RID: 28271 RVA: 0x001F8740 File Offset: 0x001F6940
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223107, RefRangeEnd = 223109, XrefRangeStart = 223082, XrefRangeEnd = 223107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flinch(Vector3 forceDirection, AvatarAnimation.EFlinchType flinchType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forceDirection;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flinchType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_Flinch_Public_Void_Vector3_EFlinchType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E70 RID: 28272 RVA: 0x001F878C File Offset: 0x001F698C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223109, XrefRangeEnd = 223140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayStandUpAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_PlayStandUpAnimation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E71 RID: 28273 RVA: 0x001F87C0 File Offset: 0x001F69C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223140, XrefRangeEnd = 223174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RagdollChange(bool wasRagdolled, bool ragdoll, bool playStandUpAnim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref wasRagdolled;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ragdoll;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playStandUpAnim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E72 RID: 28274 RVA: 0x001F881C File Offset: 0x001F6A1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223210, RefRangeEnd = 223211, XrefRangeStart = 223174, XrefRangeEnd = 223210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignPositionToHips()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_AlignPositionToHips_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E73 RID: 28275 RVA: 0x001F8850 File Offset: 0x001F6A50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223215, RefRangeEnd = 223217, XrefRangeStart = 223211, XrefRangeEnd = 223215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldGetUpFromBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_ShouldGetUpFromBack_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006E74 RID: 28276 RVA: 0x001F888C File Offset: 0x001F6A8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 223226, RefRangeEnd = 223229, XrefRangeStart = 223217, XrefRangeEnd = 223226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateBoneTransforms(Il2CppReferenceArray<BoneTransform> boneTransforms)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(boneTransforms);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_PopulateBoneTransforms_Private_Void_Il2CppReferenceArray_1_BoneTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E75 RID: 28277 RVA: 0x001F88D0 File Offset: 0x001F6AD0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 223250, RefRangeEnd = 223254, XrefRangeStart = 223229, XrefRangeEnd = 223250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateAnimationStartBoneTransforms(string clipName, Il2CppReferenceArray<BoneTransform> boneTransforms)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(clipName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boneTransforms);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_PopulateAnimationStartBoneTransforms_Private_Void_String_Il2CppReferenceArray_1_BoneTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E76 RID: 28278 RVA: 0x001F8924 File Offset: 0x001F6B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223254, XrefRangeEnd = 223257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyBoneTransforms(Il2CppReferenceArray<BoneTransform> boneTransforms)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(boneTransforms);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_ApplyBoneTransforms_Private_Void_Il2CppReferenceArray_1_BoneTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E77 RID: 28279 RVA: 0x001F8968 File Offset: 0x001F6B68
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 223268, RefRangeEnd = 223285, XrefRangeStart = 223257, XrefRangeEnd = 223268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrigger(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E78 RID: 28280 RVA: 0x001F89AC File Offset: 0x001F6BAC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 223291, RefRangeEnd = 223299, XrefRangeStart = 223285, XrefRangeEnd = 223291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetTrigger(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_ResetTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E79 RID: 28281 RVA: 0x001F89F0 File Offset: 0x001F6BF0
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 223310, RefRangeEnd = 223337, XrefRangeStart = 223299, XrefRangeEnd = 223310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBool(string id, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E7A RID: 28282 RVA: 0x001F8A40 File Offset: 0x001F6C40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223393, RefRangeEnd = 223395, XrefRangeStart = 223337, XrefRangeEnd = 223393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSeat(AvatarSeat seat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(seat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E7B RID: 28283 RVA: 0x001F8A84 File Offset: 0x001F6C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223395, XrefRangeEnd = 223421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkateboardMounted(Skateboard board)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(board);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SkateboardMounted_Public_Void_Skateboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E7C RID: 28284 RVA: 0x001F8AC8 File Offset: 0x001F6CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223421, XrefRangeEnd = 223437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkateboardDismounted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SkateboardDismounted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E7D RID: 28285 RVA: 0x001F8AFC File Offset: 0x001F6CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223437, XrefRangeEnd = 223440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkateboardPush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SkateboardPush_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E7E RID: 28286 RVA: 0x001F8B30 File Offset: 0x001F6D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223440, XrefRangeEnd = 223443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarAnimation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E7F RID: 28287 RVA: 0x0003430D File Offset: 0x0003250D
		public AvatarAnimation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021FD RID: 8701
		// (get) Token: 0x06006E80 RID: 28288 RVA: 0x001F8B6C File Offset: 0x001F6D6C
		// (set) Token: 0x06006E81 RID: 28289 RVA: 0x00034316 File Offset: 0x00032516
		public unsafe static bool ImpostorsEnabled
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_ImpostorsEnabled, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_ImpostorsEnabled, (void*)(&value));
			}
		}

		// Token: 0x170021FE RID: 8702
		// (get) Token: 0x06006E82 RID: 28290 RVA: 0x001F8B88 File Offset: 0x001F6D88
		// (set) Token: 0x06006E83 RID: 28291 RVA: 0x00034324 File Offset: 0x00032524
		public unsafe static float MaxDirectionSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_MaxDirectionSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_MaxDirectionSpeed, (void*)(&value));
			}
		}

		// Token: 0x170021FF RID: 8703
		// (get) Token: 0x06006E84 RID: 28292 RVA: 0x001F8BA4 File Offset: 0x001F6DA4
		// (set) Token: 0x06006E85 RID: 28293 RVA: 0x00034332 File Offset: 0x00032532
		public unsafe static float MaxStrafeSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_MaxStrafeSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_MaxStrafeSpeed, (void*)(&value));
			}
		}

		// Token: 0x17002200 RID: 8704
		// (get) Token: 0x06006E86 RID: 28294 RVA: 0x001F8BC0 File Offset: 0x001F6DC0
		// (set) Token: 0x06006E87 RID: 28295 RVA: 0x00034340 File Offset: 0x00032540
		public unsafe static float MaxCrouchDirectionSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_MaxCrouchDirectionSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_MaxCrouchDirectionSpeed, (void*)(&value));
			}
		}

		// Token: 0x17002201 RID: 8705
		// (get) Token: 0x06006E88 RID: 28296 RVA: 0x001F8BDC File Offset: 0x001F6DDC
		// (set) Token: 0x06006E89 RID: 28297 RVA: 0x0003434E File Offset: 0x0003254E
		public unsafe static float MaxCrouchStrafeSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_MaxCrouchStrafeSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_MaxCrouchStrafeSpeed, (void*)(&value));
			}
		}

		// Token: 0x17002202 RID: 8706
		// (get) Token: 0x06006E8A RID: 28298 RVA: 0x001F8BF8 File Offset: 0x001F6DF8
		// (set) Token: 0x06006E8B RID: 28299 RVA: 0x0003435C File Offset: 0x0003255C
		public unsafe static float BlendIncreaseMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_BlendIncreaseMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_BlendIncreaseMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17002203 RID: 8707
		// (get) Token: 0x06006E8C RID: 28300 RVA: 0x001F8C14 File Offset: 0x001F6E14
		// (set) Token: 0x06006E8D RID: 28301 RVA: 0x0003436A File Offset: 0x0003256A
		public unsafe static float BlendReduceMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_BlendReduceMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_BlendReduceMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17002204 RID: 8708
		// (get) Token: 0x06006E8E RID: 28302 RVA: 0x001F8C30 File Offset: 0x001F6E30
		// (set) Token: 0x06006E8F RID: 28303 RVA: 0x00034378 File Offset: 0x00032578
		public unsafe static float FrustrumCullMinDist
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_FrustrumCullMinDist, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_FrustrumCullMinDist, (void*)(&value));
			}
		}

		// Token: 0x17002205 RID: 8709
		// (get) Token: 0x06006E90 RID: 28304 RVA: 0x001F8C4C File Offset: 0x001F6E4C
		// (set) Token: 0x06006E91 RID: 28305 RVA: 0x00034386 File Offset: 0x00032586
		public unsafe static float RunningAnimationSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_RunningAnimationSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_RunningAnimationSpeed, (void*)(&value));
			}
		}

		// Token: 0x17002206 RID: 8710
		// (get) Token: 0x06006E92 RID: 28306 RVA: 0x001F8C68 File Offset: 0x001F6E68
		// (set) Token: 0x06006E93 RID: 28307 RVA: 0x00034394 File Offset: 0x00032594
		public unsafe static float MaxBoneOffset
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffset, (void*)(&value));
			}
		}

		// Token: 0x17002207 RID: 8711
		// (get) Token: 0x06006E94 RID: 28308 RVA: 0x001F8C84 File Offset: 0x001F6E84
		// (set) Token: 0x06006E95 RID: 28309 RVA: 0x000343A2 File Offset: 0x000325A2
		public unsafe static float MaxBoneOffsetSqr
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffsetSqr, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffsetSqr, (void*)(&value));
			}
		}

		// Token: 0x17002208 RID: 8712
		// (get) Token: 0x06006E96 RID: 28310 RVA: 0x001F8CA0 File Offset: 0x001F6EA0
		// (set) Token: 0x06006E97 RID: 28311 RVA: 0x000343B0 File Offset: 0x000325B0
		public unsafe static Vector3 SITTING_OFFSET
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_SITTING_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_SITTING_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x17002209 RID: 8713
		// (get) Token: 0x06006E98 RID: 28312 RVA: 0x001F8CBC File Offset: 0x001F6EBC
		// (set) Token: 0x06006E99 RID: 28313 RVA: 0x000343BE File Offset: 0x000325BE
		public unsafe static float SEAT_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_SEAT_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_SEAT_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700220A RID: 8714
		// (get) Token: 0x06006E9A RID: 28314 RVA: 0x001F8CD8 File Offset: 0x001F6ED8
		// (set) Token: 0x06006E9B RID: 28315 RVA: 0x000343CC File Offset: 0x000325CC
		public unsafe static string StandUpFromBackClipName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_StandUpFromBackClipName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_StandUpFromBackClipName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700220B RID: 8715
		// (get) Token: 0x06006E9C RID: 28316 RVA: 0x001F8CF8 File Offset: 0x001F6EF8
		// (set) Token: 0x06006E9D RID: 28317 RVA: 0x000343DE File Offset: 0x000325DE
		public unsafe static string StandUpFromFrontClipName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_StandUpFromFrontClipName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_StandUpFromFrontClipName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700220C RID: 8716
		// (get) Token: 0x06006E9E RID: 28318 RVA: 0x001F8D18 File Offset: 0x001F6F18
		// (set) Token: 0x06006E9F RID: 28319 RVA: 0x000343F0 File Offset: 0x000325F0
		public unsafe bool _IsCrouched_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__IsCrouched_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__IsCrouched_k__BackingField)) = value;
			}
		}

		// Token: 0x1700220D RID: 8717
		// (get) Token: 0x06006EA0 RID: 28320 RVA: 0x001F8D40 File Offset: 0x001F6F40
		// (set) Token: 0x06006EA1 RID: 28321 RVA: 0x0003440B File Offset: 0x0003260B
		public unsafe float _TimeSinceSitEnd_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__TimeSinceSitEnd_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__TimeSinceSitEnd_k__BackingField)) = value;
			}
		}

		// Token: 0x1700220E RID: 8718
		// (get) Token: 0x06006EA2 RID: 28322 RVA: 0x001F8D68 File Offset: 0x001F6F68
		// (set) Token: 0x06006EA3 RID: 28323 RVA: 0x00034426 File Offset: 0x00032626
		public unsafe AvatarSeat _CurrentSeat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__CurrentSeat_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSeat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__CurrentSeat_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700220F RID: 8719
		// (get) Token: 0x06006EA4 RID: 28324 RVA: 0x001F8D98 File Offset: 0x001F6F98
		// (set) Token: 0x06006EA5 RID: 28325 RVA: 0x00034445 File Offset: 0x00032645
		public unsafe bool _StandUpAnimationPlaying_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__StandUpAnimationPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__StandUpAnimationPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x17002210 RID: 8720
		// (get) Token: 0x06006EA6 RID: 28326 RVA: 0x001F8DC0 File Offset: 0x001F6FC0
		// (set) Token: 0x06006EA7 RID: 28327 RVA: 0x00034460 File Offset: 0x00032660
		public unsafe bool _IsAvatarCulled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__IsAvatarCulled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__IsAvatarCulled_k__BackingField)) = value;
			}
		}

		// Token: 0x17002211 RID: 8721
		// (get) Token: 0x06006EA8 RID: 28328 RVA: 0x001F8DE8 File Offset: 0x001F6FE8
		// (set) Token: 0x06006EA9 RID: 28329 RVA: 0x0003447B File Offset: 0x0003267B
		public unsafe bool DEBUG_MODE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_DEBUG_MODE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_DEBUG_MODE)) = value;
			}
		}

		// Token: 0x17002212 RID: 8722
		// (get) Token: 0x06006EAA RID: 28330 RVA: 0x001F8E10 File Offset: 0x001F7010
		// (set) Token: 0x06006EAB RID: 28331 RVA: 0x00034496 File Offset: 0x00032696
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002213 RID: 8723
		// (get) Token: 0x06006EAC RID: 28332 RVA: 0x001F8E40 File Offset: 0x001F7040
		// (set) Token: 0x06006EAD RID: 28333 RVA: 0x000344B5 File Offset: 0x000326B5
		public unsafe Transform HipBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_HipBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_HipBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002214 RID: 8724
		// (get) Token: 0x06006EAE RID: 28334 RVA: 0x001F8E70 File Offset: 0x001F7070
		// (set) Token: 0x06006EAF RID: 28335 RVA: 0x000344D4 File Offset: 0x000326D4
		public unsafe Il2CppReferenceArray<Transform> Bones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_Bones);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_Bones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002215 RID: 8725
		// (get) Token: 0x06006EB0 RID: 28336 RVA: 0x001F8EA0 File Offset: 0x001F70A0
		// (set) Token: 0x06006EB1 RID: 28337 RVA: 0x000344F3 File Offset: 0x000326F3
		public unsafe Avatar avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002216 RID: 8726
		// (get) Token: 0x06006EB2 RID: 28338 RVA: 0x001F8ED0 File Offset: 0x001F70D0
		// (set) Token: 0x06006EB3 RID: 28339 RVA: 0x00034512 File Offset: 0x00032712
		public unsafe Transform LeftHandContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_LeftHandContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_LeftHandContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002217 RID: 8727
		// (get) Token: 0x06006EB4 RID: 28340 RVA: 0x001F8F00 File Offset: 0x001F7100
		// (set) Token: 0x06006EB5 RID: 28341 RVA: 0x00034531 File Offset: 0x00032731
		public unsafe Transform RightHandContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_RightHandContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_RightHandContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002218 RID: 8728
		// (get) Token: 0x06006EB6 RID: 28342 RVA: 0x001F8F30 File Offset: 0x001F7130
		// (set) Token: 0x06006EB7 RID: 28343 RVA: 0x00034550 File Offset: 0x00032750
		public unsafe Transform RightHandAlignmentPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_RightHandAlignmentPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_RightHandAlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002219 RID: 8729
		// (get) Token: 0x06006EB8 RID: 28344 RVA: 0x001F8F60 File Offset: 0x001F7160
		// (set) Token: 0x06006EB9 RID: 28345 RVA: 0x0003456F File Offset: 0x0003276F
		public unsafe Transform LeftHandAlignmentPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_LeftHandAlignmentPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_LeftHandAlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700221A RID: 8730
		// (get) Token: 0x06006EBA RID: 28346 RVA: 0x001F8F90 File Offset: 0x001F7190
		// (set) Token: 0x06006EBB RID: 28347 RVA: 0x0003458E File Offset: 0x0003278E
		public unsafe AvatarIKController IKController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_IKController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarIKController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_IKController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700221B RID: 8731
		// (get) Token: 0x06006EBC RID: 28348 RVA: 0x001F8FC0 File Offset: 0x001F71C0
		// (set) Token: 0x06006EBD RID: 28349 RVA: 0x000345AD File Offset: 0x000327AD
		public unsafe AvatarFootstepDetector FootstepDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_FootstepDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarFootstepDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_FootstepDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700221C RID: 8732
		// (get) Token: 0x06006EBE RID: 28350 RVA: 0x001F8FF0 File Offset: 0x001F71F0
		// (set) Token: 0x06006EBF RID: 28351 RVA: 0x000345CC File Offset: 0x000327CC
		public unsafe LayerMask GroundingMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_GroundingMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_GroundingMask)) = value;
			}
		}

		// Token: 0x1700221D RID: 8733
		// (get) Token: 0x06006EC0 RID: 28352 RVA: 0x001F9018 File Offset: 0x001F7218
		// (set) Token: 0x06006EC1 RID: 28353 RVA: 0x000345E7 File Offset: 0x000327E7
		public unsafe bool AllowCulling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_AllowCulling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_AllowCulling)) = value;
			}
		}

		// Token: 0x1700221E RID: 8734
		// (get) Token: 0x06006EC2 RID: 28354 RVA: 0x001F9040 File Offset: 0x001F7240
		// (set) Token: 0x06006EC3 RID: 28355 RVA: 0x00034602 File Offset: 0x00032802
		public unsafe float VisibilityRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_VisibilityRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_VisibilityRange)) = value;
			}
		}

		// Token: 0x1700221F RID: 8735
		// (get) Token: 0x06006EC4 RID: 28356 RVA: 0x001F9068 File Offset: 0x001F7268
		// (set) Token: 0x06006EC5 RID: 28357 RVA: 0x0003461D File Offset: 0x0003281D
		public unsafe AnimationCurve DirectionAnimationValueCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_DirectionAnimationValueCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_DirectionAnimationValueCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002220 RID: 8736
		// (get) Token: 0x06006EC6 RID: 28358 RVA: 0x001F9098 File Offset: 0x001F7298
		// (set) Token: 0x06006EC7 RID: 28359 RVA: 0x0003463C File Offset: 0x0003283C
		public unsafe AnimationCurve StrafeAnimationValueCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_StrafeAnimationValueCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_StrafeAnimationValueCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002221 RID: 8737
		// (get) Token: 0x06006EC8 RID: 28360 RVA: 0x001F90C8 File Offset: 0x001F72C8
		// (set) Token: 0x06006EC9 RID: 28361 RVA: 0x0003465B File Offset: 0x0003285B
		public unsafe AnimationCurve CrouchMovementAnimationValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_CrouchMovementAnimationValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_CrouchMovementAnimationValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002222 RID: 8738
		// (get) Token: 0x06006ECA RID: 28362 RVA: 0x001F90F8 File Offset: 0x001F72F8
		// (set) Token: 0x06006ECB RID: 28363 RVA: 0x0003467A File Offset: 0x0003287A
		public unsafe AnimationCurve StrafeBlendMultiplierCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_StrafeBlendMultiplierCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_StrafeBlendMultiplierCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002223 RID: 8739
		// (get) Token: 0x06006ECC RID: 28364 RVA: 0x001F9128 File Offset: 0x001F7328
		// (set) Token: 0x06006ECD RID: 28365 RVA: 0x00034699 File Offset: 0x00032899
		public unsafe UnityEvent onStandupStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onStandupStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onStandupStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002224 RID: 8740
		// (get) Token: 0x06006ECE RID: 28366 RVA: 0x001F9158 File Offset: 0x001F7358
		// (set) Token: 0x06006ECF RID: 28367 RVA: 0x000346B8 File Offset: 0x000328B8
		public unsafe UnityEvent onStandupDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onStandupDone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onStandupDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002225 RID: 8741
		// (get) Token: 0x06006ED0 RID: 28368 RVA: 0x001F9188 File Offset: 0x001F7388
		// (set) Token: 0x06006ED1 RID: 28369 RVA: 0x000346D7 File Offset: 0x000328D7
		public unsafe UnityEvent onHeavyFlinch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onHeavyFlinch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onHeavyFlinch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002226 RID: 8742
		// (get) Token: 0x06006ED2 RID: 28370 RVA: 0x001F91B8 File Offset: 0x001F73B8
		// (set) Token: 0x06006ED3 RID: 28371 RVA: 0x000346F6 File Offset: 0x000328F6
		public unsafe Il2CppReferenceArray<BoneTransform> standUpFromBackBoneTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpFromBackBoneTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoneTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpFromBackBoneTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002227 RID: 8743
		// (get) Token: 0x06006ED4 RID: 28372 RVA: 0x001F91E8 File Offset: 0x001F73E8
		// (set) Token: 0x06006ED5 RID: 28373 RVA: 0x00034715 File Offset: 0x00032915
		public unsafe Il2CppReferenceArray<BoneTransform> standUpFromFrontBoneTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpFromFrontBoneTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoneTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpFromFrontBoneTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002228 RID: 8744
		// (get) Token: 0x06006ED6 RID: 28374 RVA: 0x001F9218 File Offset: 0x001F7418
		// (set) Token: 0x06006ED7 RID: 28375 RVA: 0x00034734 File Offset: 0x00032934
		public unsafe Il2CppReferenceArray<BoneTransform> ragdollBoneTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_ragdollBoneTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoneTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_ragdollBoneTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002229 RID: 8745
		// (get) Token: 0x06006ED8 RID: 28376 RVA: 0x001F9248 File Offset: 0x001F7448
		// (set) Token: 0x06006ED9 RID: 28377 RVA: 0x00034753 File Offset: 0x00032953
		public unsafe Coroutine standUpRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700222A RID: 8746
		// (get) Token: 0x06006EDA RID: 28378 RVA: 0x001F9278 File Offset: 0x001F7478
		// (set) Token: 0x06006EDB RID: 28379 RVA: 0x00034772 File Offset: 0x00032972
		public unsafe Coroutine seatRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_seatRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_seatRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700222B RID: 8747
		// (get) Token: 0x06006EDC RID: 28380 RVA: 0x001F92A8 File Offset: 0x001F74A8
		// (set) Token: 0x06006EDD RID: 28381 RVA: 0x00034791 File Offset: 0x00032991
		public unsafe Skateboard activeSkateboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_activeSkateboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_activeSkateboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700222C RID: 8748
		// (get) Token: 0x06006EDE RID: 28382 RVA: 0x001F92D8 File Offset: 0x001F74D8
		// (set) Token: 0x06006EDF RID: 28383 RVA: 0x000347B0 File Offset: 0x000329B0
		public unsafe bool animationEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_animationEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_animationEnabled)) = value;
			}
		}

		// Token: 0x1700222D RID: 8749
		// (get) Token: 0x06006EE0 RID: 28384 RVA: 0x001F9300 File Offset: 0x001F7500
		// (set) Token: 0x06006EE1 RID: 28385 RVA: 0x000347CB File Offset: 0x000329CB
		public unsafe Il2CppReferenceArray<BoneTransform> _lastFrameBoneTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__lastFrameBoneTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoneTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__lastFrameBoneTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700222E RID: 8750
		// (get) Token: 0x06006EE2 RID: 28386 RVA: 0x001F9330 File Offset: 0x001F7530
		// (set) Token: 0x06006EE3 RID: 28387 RVA: 0x000347EA File Offset: 0x000329EA
		public unsafe bool _lastFrameBoneTransformsValid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__lastFrameBoneTransformsValid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__lastFrameBoneTransformsValid)) = value;
			}
		}

		// Token: 0x1700222F RID: 8751
		// (get) Token: 0x06006EE4 RID: 28388 RVA: 0x001F9358 File Offset: 0x001F7558
		// (set) Token: 0x06006EE5 RID: 28389 RVA: 0x00034805 File Offset: 0x00032A05
		public unsafe bool _activateRagdollNextFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__activateRagdollNextFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__activateRagdollNextFrame)) = value;
			}
		}

		// Token: 0x17002230 RID: 8752
		// (get) Token: 0x06006EE6 RID: 28390 RVA: 0x001F9380 File Offset: 0x001F7580
		// (set) Token: 0x06006EE7 RID: 28391 RVA: 0x00034820 File Offset: 0x00032A20
		public unsafe float visibilityRangeSqr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_visibilityRangeSqr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_visibilityRangeSqr)) = value;
			}
		}

		// Token: 0x17002231 RID: 8753
		// (get) Token: 0x06006EE8 RID: 28392 RVA: 0x001F93A8 File Offset: 0x001F75A8
		// (set) Token: 0x06006EE9 RID: 28393 RVA: 0x0003483B File Offset: 0x00032A3B
		public unsafe float _currentStrafeBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__currentStrafeBlend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__currentStrafeBlend)) = value;
			}
		}

		// Token: 0x17002232 RID: 8754
		// (get) Token: 0x06006EEA RID: 28394 RVA: 0x001F93D0 File Offset: 0x001F75D0
		// (set) Token: 0x06006EEB RID: 28395 RVA: 0x00034856 File Offset: 0x00032A56
		public unsafe float _lastTargetStrafe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__lastTargetStrafe);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__lastTargetStrafe)) = value;
			}
		}

		// Token: 0x17002233 RID: 8755
		// (get) Token: 0x06006EEC RID: 28396 RVA: 0x001F93F8 File Offset: 0x001F75F8
		// (set) Token: 0x06006EED RID: 28397 RVA: 0x00034871 File Offset: 0x00032A71
		public unsafe float _currentDirectionBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__currentDirectionBlend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__currentDirectionBlend)) = value;
			}
		}

		// Token: 0x17002234 RID: 8756
		// (get) Token: 0x06006EEE RID: 28398 RVA: 0x001F9420 File Offset: 0x001F7620
		// (set) Token: 0x06006EEF RID: 28399 RVA: 0x0003488C File Offset: 0x00032A8C
		public unsafe float _lastTargetDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__lastTargetDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__lastTargetDirection)) = value;
			}
		}

		// Token: 0x17002235 RID: 8757
		// (get) Token: 0x06006EF0 RID: 28400 RVA: 0x001F9448 File Offset: 0x001F7648
		// (set) Token: 0x06006EF1 RID: 28401 RVA: 0x000348A7 File Offset: 0x00032AA7
		public unsafe float _lastMotionTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__lastMotionTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__lastMotionTime)) = value;
			}
		}

		// Token: 0x17002236 RID: 8758
		// (get) Token: 0x06006EF2 RID: 28402 RVA: 0x001F9470 File Offset: 0x001F7670
		// (set) Token: 0x06006EF3 RID: 28403 RVA: 0x000348C2 File Offset: 0x00032AC2
		public unsafe Vector3 _smoothedMotion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__smoothedMotion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__smoothedMotion)) = value;
			}
		}

		// Token: 0x04004BA7 RID: 19367
		private static readonly IntPtr NativeFieldInfoPtr_ImpostorsEnabled;

		// Token: 0x04004BA8 RID: 19368
		private static readonly IntPtr NativeFieldInfoPtr_MaxDirectionSpeed;

		// Token: 0x04004BA9 RID: 19369
		private static readonly IntPtr NativeFieldInfoPtr_MaxStrafeSpeed;

		// Token: 0x04004BAA RID: 19370
		private static readonly IntPtr NativeFieldInfoPtr_MaxCrouchDirectionSpeed;

		// Token: 0x04004BAB RID: 19371
		private static readonly IntPtr NativeFieldInfoPtr_MaxCrouchStrafeSpeed;

		// Token: 0x04004BAC RID: 19372
		private static readonly IntPtr NativeFieldInfoPtr_BlendIncreaseMultiplier;

		// Token: 0x04004BAD RID: 19373
		private static readonly IntPtr NativeFieldInfoPtr_BlendReduceMultiplier;

		// Token: 0x04004BAE RID: 19374
		private static readonly IntPtr NativeFieldInfoPtr_FrustrumCullMinDist;

		// Token: 0x04004BAF RID: 19375
		private static readonly IntPtr NativeFieldInfoPtr_RunningAnimationSpeed;

		// Token: 0x04004BB0 RID: 19376
		private static readonly IntPtr NativeFieldInfoPtr_MaxBoneOffset;

		// Token: 0x04004BB1 RID: 19377
		private static readonly IntPtr NativeFieldInfoPtr_MaxBoneOffsetSqr;

		// Token: 0x04004BB2 RID: 19378
		private static readonly IntPtr NativeFieldInfoPtr_SITTING_OFFSET;

		// Token: 0x04004BB3 RID: 19379
		private static readonly IntPtr NativeFieldInfoPtr_SEAT_TIME;

		// Token: 0x04004BB4 RID: 19380
		private static readonly IntPtr NativeFieldInfoPtr_StandUpFromBackClipName;

		// Token: 0x04004BB5 RID: 19381
		private static readonly IntPtr NativeFieldInfoPtr_StandUpFromFrontClipName;

		// Token: 0x04004BB6 RID: 19382
		private static readonly IntPtr NativeFieldInfoPtr__IsCrouched_k__BackingField;

		// Token: 0x04004BB7 RID: 19383
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceSitEnd_k__BackingField;

		// Token: 0x04004BB8 RID: 19384
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSeat_k__BackingField;

		// Token: 0x04004BB9 RID: 19385
		private static readonly IntPtr NativeFieldInfoPtr__StandUpAnimationPlaying_k__BackingField;

		// Token: 0x04004BBA RID: 19386
		private static readonly IntPtr NativeFieldInfoPtr__IsAvatarCulled_k__BackingField;

		// Token: 0x04004BBB RID: 19387
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG_MODE;

		// Token: 0x04004BBC RID: 19388
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04004BBD RID: 19389
		private static readonly IntPtr NativeFieldInfoPtr_HipBone;

		// Token: 0x04004BBE RID: 19390
		private static readonly IntPtr NativeFieldInfoPtr_Bones;

		// Token: 0x04004BBF RID: 19391
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04004BC0 RID: 19392
		private static readonly IntPtr NativeFieldInfoPtr_LeftHandContainer;

		// Token: 0x04004BC1 RID: 19393
		private static readonly IntPtr NativeFieldInfoPtr_RightHandContainer;

		// Token: 0x04004BC2 RID: 19394
		private static readonly IntPtr NativeFieldInfoPtr_RightHandAlignmentPoint;

		// Token: 0x04004BC3 RID: 19395
		private static readonly IntPtr NativeFieldInfoPtr_LeftHandAlignmentPoint;

		// Token: 0x04004BC4 RID: 19396
		private static readonly IntPtr NativeFieldInfoPtr_IKController;

		// Token: 0x04004BC5 RID: 19397
		private static readonly IntPtr NativeFieldInfoPtr_FootstepDetector;

		// Token: 0x04004BC6 RID: 19398
		private static readonly IntPtr NativeFieldInfoPtr_GroundingMask;

		// Token: 0x04004BC7 RID: 19399
		private static readonly IntPtr NativeFieldInfoPtr_AllowCulling;

		// Token: 0x04004BC8 RID: 19400
		private static readonly IntPtr NativeFieldInfoPtr_VisibilityRange;

		// Token: 0x04004BC9 RID: 19401
		private static readonly IntPtr NativeFieldInfoPtr_DirectionAnimationValueCurve;

		// Token: 0x04004BCA RID: 19402
		private static readonly IntPtr NativeFieldInfoPtr_StrafeAnimationValueCurve;

		// Token: 0x04004BCB RID: 19403
		private static readonly IntPtr NativeFieldInfoPtr_CrouchMovementAnimationValue;

		// Token: 0x04004BCC RID: 19404
		private static readonly IntPtr NativeFieldInfoPtr_StrafeBlendMultiplierCurve;

		// Token: 0x04004BCD RID: 19405
		private static readonly IntPtr NativeFieldInfoPtr_onStandupStart;

		// Token: 0x04004BCE RID: 19406
		private static readonly IntPtr NativeFieldInfoPtr_onStandupDone;

		// Token: 0x04004BCF RID: 19407
		private static readonly IntPtr NativeFieldInfoPtr_onHeavyFlinch;

		// Token: 0x04004BD0 RID: 19408
		private static readonly IntPtr NativeFieldInfoPtr_standUpFromBackBoneTransforms;

		// Token: 0x04004BD1 RID: 19409
		private static readonly IntPtr NativeFieldInfoPtr_standUpFromFrontBoneTransforms;

		// Token: 0x04004BD2 RID: 19410
		private static readonly IntPtr NativeFieldInfoPtr_ragdollBoneTransforms;

		// Token: 0x04004BD3 RID: 19411
		private static readonly IntPtr NativeFieldInfoPtr_standUpRoutine;

		// Token: 0x04004BD4 RID: 19412
		private static readonly IntPtr NativeFieldInfoPtr_seatRoutine;

		// Token: 0x04004BD5 RID: 19413
		private static readonly IntPtr NativeFieldInfoPtr_activeSkateboard;

		// Token: 0x04004BD6 RID: 19414
		private static readonly IntPtr NativeFieldInfoPtr_animationEnabled;

		// Token: 0x04004BD7 RID: 19415
		private static readonly IntPtr NativeFieldInfoPtr__lastFrameBoneTransforms;

		// Token: 0x04004BD8 RID: 19416
		private static readonly IntPtr NativeFieldInfoPtr__lastFrameBoneTransformsValid;

		// Token: 0x04004BD9 RID: 19417
		private static readonly IntPtr NativeFieldInfoPtr__activateRagdollNextFrame;

		// Token: 0x04004BDA RID: 19418
		private static readonly IntPtr NativeFieldInfoPtr_visibilityRangeSqr;

		// Token: 0x04004BDB RID: 19419
		private static readonly IntPtr NativeFieldInfoPtr__currentStrafeBlend;

		// Token: 0x04004BDC RID: 19420
		private static readonly IntPtr NativeFieldInfoPtr__lastTargetStrafe;

		// Token: 0x04004BDD RID: 19421
		private static readonly IntPtr NativeFieldInfoPtr__currentDirectionBlend;

		// Token: 0x04004BDE RID: 19422
		private static readonly IntPtr NativeFieldInfoPtr__lastTargetDirection;

		// Token: 0x04004BDF RID: 19423
		private static readonly IntPtr NativeFieldInfoPtr__lastMotionTime;

		// Token: 0x04004BE0 RID: 19424
		private static readonly IntPtr NativeFieldInfoPtr__smoothedMotion;

		// Token: 0x04004BE1 RID: 19425
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCrouched_Public_get_Boolean_0;

		// Token: 0x04004BE2 RID: 19426
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCrouched_Protected_set_Void_Boolean_0;

		// Token: 0x04004BE3 RID: 19427
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSeated_Public_get_Boolean_0;

		// Token: 0x04004BE4 RID: 19428
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceSitEnd_Public_get_Single_0;

		// Token: 0x04004BE5 RID: 19429
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceSitEnd_Protected_set_Void_Single_0;

		// Token: 0x04004BE6 RID: 19430
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSeat_Public_get_AvatarSeat_0;

		// Token: 0x04004BE7 RID: 19431
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSeat_Protected_set_Void_AvatarSeat_0;

		// Token: 0x04004BE8 RID: 19432
		private static readonly IntPtr NativeMethodInfoPtr_get_StandUpAnimationPlaying_Public_get_Boolean_0;

		// Token: 0x04004BE9 RID: 19433
		private static readonly IntPtr NativeMethodInfoPtr_set_StandUpAnimationPlaying_Protected_set_Void_Boolean_0;

		// Token: 0x04004BEA RID: 19434
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAvatarCulled_Public_get_Boolean_0;

		// Token: 0x04004BEB RID: 19435
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAvatarCulled_Private_set_Void_Boolean_0;

		// Token: 0x04004BEC RID: 19436
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004BED RID: 19437
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateVisibilityRangeSqr_Private_Void_Int32_Int32_0;

		// Token: 0x04004BEE RID: 19438
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004BEF RID: 19439
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004BF0 RID: 19440
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04004BF1 RID: 19441
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAnimationActive_Private_Void_0;

		// Token: 0x04004BF2 RID: 19442
		private static readonly IntPtr NativeMethodInfoPtr_SetMotion_Public_Void_Vector3_Boolean_0;

		// Token: 0x04004BF3 RID: 19443
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBlend_Private_Single_byref_Single_Single_Single_byref_Single_AnimationCurve_Single_Single_0;

		// Token: 0x04004BF4 RID: 19444
		private static readonly IntPtr NativeMethodInfoPtr_SetDirection_Private_Void_Single_0;

		// Token: 0x04004BF5 RID: 19445
		private static readonly IntPtr NativeMethodInfoPtr_SetStrafe_Private_Void_Single_0;

		// Token: 0x04004BF6 RID: 19446
		private static readonly IntPtr NativeMethodInfoPtr_SetTimeAirborne_Public_Void_Single_0;

		// Token: 0x04004BF7 RID: 19447
		private static readonly IntPtr NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0;

		// Token: 0x04004BF8 RID: 19448
		private static readonly IntPtr NativeMethodInfoPtr_SetGrounded_Public_Void_Boolean_0;

		// Token: 0x04004BF9 RID: 19449
		private static readonly IntPtr NativeMethodInfoPtr_Jump_Public_Void_0;

		// Token: 0x04004BFA RID: 19450
		private static readonly IntPtr NativeMethodInfoPtr_SetAnimationEnabled_Public_Void_Boolean_0;

		// Token: 0x04004BFB RID: 19451
		private static readonly IntPtr NativeMethodInfoPtr_ResetAnimatorState_Public_Void_0;

		// Token: 0x04004BFC RID: 19452
		private static readonly IntPtr NativeMethodInfoPtr_Flinch_Public_Void_Vector3_EFlinchType_0;

		// Token: 0x04004BFD RID: 19453
		private static readonly IntPtr NativeMethodInfoPtr_PlayStandUpAnimation_Public_Void_0;

		// Token: 0x04004BFE RID: 19454
		private static readonly IntPtr NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0;

		// Token: 0x04004BFF RID: 19455
		private static readonly IntPtr NativeMethodInfoPtr_AlignPositionToHips_Private_Void_0;

		// Token: 0x04004C00 RID: 19456
		private static readonly IntPtr NativeMethodInfoPtr_ShouldGetUpFromBack_Private_Boolean_0;

		// Token: 0x04004C01 RID: 19457
		private static readonly IntPtr NativeMethodInfoPtr_PopulateBoneTransforms_Private_Void_Il2CppReferenceArray_1_BoneTransform_0;

		// Token: 0x04004C02 RID: 19458
		private static readonly IntPtr NativeMethodInfoPtr_PopulateAnimationStartBoneTransforms_Private_Void_String_Il2CppReferenceArray_1_BoneTransform_0;

		// Token: 0x04004C03 RID: 19459
		private static readonly IntPtr NativeMethodInfoPtr_ApplyBoneTransforms_Private_Void_Il2CppReferenceArray_1_BoneTransform_0;

		// Token: 0x04004C04 RID: 19460
		private static readonly IntPtr NativeMethodInfoPtr_SetTrigger_Public_Void_String_0;

		// Token: 0x04004C05 RID: 19461
		private static readonly IntPtr NativeMethodInfoPtr_ResetTrigger_Public_Void_String_0;

		// Token: 0x04004C06 RID: 19462
		private static readonly IntPtr NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0;

		// Token: 0x04004C07 RID: 19463
		private static readonly IntPtr NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0;

		// Token: 0x04004C08 RID: 19464
		private static readonly IntPtr NativeMethodInfoPtr_SkateboardMounted_Public_Void_Skateboard_0;

		// Token: 0x04004C09 RID: 19465
		private static readonly IntPtr NativeMethodInfoPtr_SkateboardDismounted_Public_Void_0;

		// Token: 0x04004C0A RID: 19466
		private static readonly IntPtr NativeMethodInfoPtr_SkateboardPush_Private_Void_0;

		// Token: 0x04004C0B RID: 19467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B79 RID: 2937
		[OriginalName("Assembly-CSharp.dll", "", "EFlinchType")]
		public enum EFlinchType
		{
			// Token: 0x04009DEF RID: 40431
			Light,
			// Token: 0x04009DF0 RID: 40432
			Heavy
		}

		// Token: 0x02000B7A RID: 2938
		[OriginalName("Assembly-CSharp.dll", "", "EFlinchDirection")]
		public enum EFlinchDirection
		{
			// Token: 0x04009DF2 RID: 40434
			Forward,
			// Token: 0x04009DF3 RID: 40435
			Backward,
			// Token: 0x04009DF4 RID: 40436
			Left,
			// Token: 0x04009DF5 RID: 40437
			Right
		}

		// Token: 0x02000B7B RID: 2939
		[ObfuscatedName("ScheduleOne.AvatarFramework.Animation.AvatarAnimation+<>c__DisplayClass104_0")]
		public sealed class __c__DisplayClass104_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E8DD RID: 59613 RVA: 0x0038AC38 File Offset: 0x00388E38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass104_0()
			{
				Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<>c__DisplayClass104_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0>.NativeClassPtr);
				AvatarAnimation.__c__DisplayClass104_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0>.NativeClassPtr, "<>4__this");
				AvatarAnimation.__c__DisplayClass104_0.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0>.NativeClassPtr, "startPos");
				AvatarAnimation.__c__DisplayClass104_0.NativeFieldInfoPtr_endPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0>.NativeClassPtr, "endPos");
				AvatarAnimation.__c__DisplayClass104_0.NativeFieldInfoPtr_startRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0>.NativeClassPtr, "startRot");
				AvatarAnimation.__c__DisplayClass104_0.NativeFieldInfoPtr_endRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0>.NativeClassPtr, "endRot");
				AvatarAnimation.__c__DisplayClass104_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0>.NativeClassPtr, 100677691);
				AvatarAnimation.__c__DisplayClass104_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0>.NativeClassPtr, 100677692);
			}

			// Token: 0x0600E8DE RID: 59614 RVA: 0x0038ACF0 File Offset: 0x00388EF0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass104_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass104_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E8DF RID: 59615 RVA: 0x0038AD2C File Offset: 0x00388F2C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 222762, RefRangeEnd = 222763, XrefRangeStart = 222757, XrefRangeEnd = 222762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Boolean_0(bool resetLocalCoordinates)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref resetLocalCoordinates;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass104_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E8E0 RID: 59616 RVA: 0x0006DD47 File Offset: 0x0006BF47
			public __c__DisplayClass104_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700469F RID: 18079
			// (get) Token: 0x0600E8E1 RID: 59617 RVA: 0x0038AD78 File Offset: 0x00388F78
			// (set) Token: 0x0600E8E2 RID: 59618 RVA: 0x0006DD50 File Offset: 0x0006BF50
			public unsafe AvatarAnimation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass104_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass104_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046A0 RID: 18080
			// (get) Token: 0x0600E8E3 RID: 59619 RVA: 0x0038ADA8 File Offset: 0x00388FA8
			// (set) Token: 0x0600E8E4 RID: 59620 RVA: 0x0006DD6F File Offset: 0x0006BF6F
			public unsafe Vector3 startPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass104_0.NativeFieldInfoPtr_startPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass104_0.NativeFieldInfoPtr_startPos)) = value;
				}
			}

			// Token: 0x170046A1 RID: 18081
			// (get) Token: 0x0600E8E5 RID: 59621 RVA: 0x0038ADD0 File Offset: 0x00388FD0
			// (set) Token: 0x0600E8E6 RID: 59622 RVA: 0x0006DD8A File Offset: 0x0006BF8A
			public unsafe Vector3 endPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass104_0.NativeFieldInfoPtr_endPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass104_0.NativeFieldInfoPtr_endPos)) = value;
				}
			}

			// Token: 0x170046A2 RID: 18082
			// (get) Token: 0x0600E8E7 RID: 59623 RVA: 0x0038ADF8 File Offset: 0x00388FF8
			// (set) Token: 0x0600E8E8 RID: 59624 RVA: 0x0006DDA5 File Offset: 0x0006BFA5
			public unsafe Quaternion startRot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass104_0.NativeFieldInfoPtr_startRot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass104_0.NativeFieldInfoPtr_startRot)) = value;
				}
			}

			// Token: 0x170046A3 RID: 18083
			// (get) Token: 0x0600E8E9 RID: 59625 RVA: 0x0038AE20 File Offset: 0x00389020
			// (set) Token: 0x0600E8EA RID: 59626 RVA: 0x0006DDC0 File Offset: 0x0006BFC0
			public unsafe Quaternion endRot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass104_0.NativeFieldInfoPtr_endRot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass104_0.NativeFieldInfoPtr_endRot)) = value;
				}
			}

			// Token: 0x04009DF6 RID: 40438
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009DF7 RID: 40439
			private static readonly IntPtr NativeFieldInfoPtr_startPos;

			// Token: 0x04009DF8 RID: 40440
			private static readonly IntPtr NativeFieldInfoPtr_endPos;

			// Token: 0x04009DF9 RID: 40441
			private static readonly IntPtr NativeFieldInfoPtr_startRot;

			// Token: 0x04009DFA RID: 40442
			private static readonly IntPtr NativeFieldInfoPtr_endRot;

			// Token: 0x04009DFB RID: 40443
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009DFC RID: 40444
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Boolean_0;

			// Token: 0x02000DE4 RID: 3556
			[ObfuscatedName("ScheduleOne.AvatarFramework.Animation.AvatarAnimation+<>c__DisplayClass104_0+<<SetSeat>g__Lerp|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0601008E RID: 65678 RVA: 0x003CF30C File Offset: 0x003CD50C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique()
				{
					Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0>.NativeClassPtr, "<<SetSeat>g__Lerp|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr);
					AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, "<>1__state");
					AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, "<>2__current");
					AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, "<>4__this");
					AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr_resetLocalCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, "resetLocalCoordinates");
					AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, "<i>5__2");
					AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100677693);
					AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100677694);
					AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100677695);
					AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100677696);
					AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100677697);
					AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100677698);
				}

				// Token: 0x0601008F RID: 65679 RVA: 0x003CF414 File Offset: 0x003CD614
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06010090 RID: 65680 RVA: 0x003CF45C File Offset: 0x003CD65C
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06010091 RID: 65681 RVA: 0x003CF490 File Offset: 0x003CD690
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222736, XrefRangeEnd = 222752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004E33 RID: 20019
				// (get) Token: 0x06010092 RID: 65682 RVA: 0x003CF4CC File Offset: 0x003CD6CC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010093 RID: 65683 RVA: 0x003CF50C File Offset: 0x003CD70C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222752, XrefRangeEnd = 222757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004E34 RID: 20020
				// (get) Token: 0x06010094 RID: 65684 RVA: 0x003CF540 File Offset: 0x003CD740
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010095 RID: 65685 RVA: 0x0007999A File Offset: 0x00077B9A
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004E2E RID: 20014
				// (get) Token: 0x06010096 RID: 65686 RVA: 0x003CF580 File Offset: 0x003CD780
				// (set) Token: 0x06010097 RID: 65687 RVA: 0x000799A3 File Offset: 0x00077BA3
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004E2F RID: 20015
				// (get) Token: 0x06010098 RID: 65688 RVA: 0x003CF5A8 File Offset: 0x003CD7A8
				// (set) Token: 0x06010099 RID: 65689 RVA: 0x000799BE File Offset: 0x00077BBE
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E30 RID: 20016
				// (get) Token: 0x0601009A RID: 65690 RVA: 0x003CF5D8 File Offset: 0x003CD7D8
				// (set) Token: 0x0601009B RID: 65691 RVA: 0x000799DD File Offset: 0x00077BDD
				public unsafe AvatarAnimation.__c__DisplayClass104_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation.__c__DisplayClass104_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E31 RID: 20017
				// (get) Token: 0x0601009C RID: 65692 RVA: 0x003CF608 File Offset: 0x003CD808
				// (set) Token: 0x0601009D RID: 65693 RVA: 0x000799FC File Offset: 0x00077BFC
				public unsafe bool resetLocalCoordinates
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr_resetLocalCoordinates);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr_resetLocalCoordinates)) = value;
					}
				}

				// Token: 0x17004E32 RID: 20018
				// (get) Token: 0x0601009E RID: 65694 RVA: 0x003CF630 File Offset: 0x003CD830
				// (set) Token: 0x0601009F RID: 65695 RVA: 0x00079A17 File Offset: 0x00077C17
				public unsafe float _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass104_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x0400ACCC RID: 44236
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ACCD RID: 44237
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400ACCE RID: 44238
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400ACCF RID: 44239
				private static readonly IntPtr NativeFieldInfoPtr_resetLocalCoordinates;

				// Token: 0x0400ACD0 RID: 44240
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x0400ACD1 RID: 44241
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400ACD2 RID: 44242
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ACD3 RID: 44243
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400ACD4 RID: 44244
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400ACD5 RID: 44245
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ACD6 RID: 44246
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B7C RID: 2940
		[ObfuscatedName("ScheduleOne.AvatarFramework.Animation.AvatarAnimation+<>c__DisplayClass94_0")]
		public sealed class __c__DisplayClass94_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E8EB RID: 59627 RVA: 0x0038AE48 File Offset: 0x00389048
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass94_0()
			{
				Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass94_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<>c__DisplayClass94_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass94_0>.NativeClassPtr);
				AvatarAnimation.__c__DisplayClass94_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass94_0>.NativeClassPtr, "<>4__this");
				AvatarAnimation.__c__DisplayClass94_0.NativeFieldInfoPtr_finalBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass94_0>.NativeClassPtr, "finalBoneTransforms");
				AvatarAnimation.__c__DisplayClass94_0.NativeFieldInfoPtr_standUpFromBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass94_0>.NativeClassPtr, "standUpFromBack");
				AvatarAnimation.__c__DisplayClass94_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass94_0>.NativeClassPtr, 100677699);
				AvatarAnimation.__c__DisplayClass94_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass94_0>.NativeClassPtr, 100677700);
			}

			// Token: 0x0600E8EC RID: 59628 RVA: 0x0038AED8 File Offset: 0x003890D8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass94_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass94_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass94_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E8ED RID: 59629 RVA: 0x0038AF14 File Offset: 0x00389114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222790, XrefRangeEnd = 222795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass94_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E8EE RID: 59630 RVA: 0x0006DDDB File Offset: 0x0006BFDB
			public __c__DisplayClass94_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046A4 RID: 18084
			// (get) Token: 0x0600E8EF RID: 59631 RVA: 0x0038AF54 File Offset: 0x00389154
			// (set) Token: 0x0600E8F0 RID: 59632 RVA: 0x0006DDE4 File Offset: 0x0006BFE4
			public unsafe AvatarAnimation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass94_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass94_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046A5 RID: 18085
			// (get) Token: 0x0600E8F1 RID: 59633 RVA: 0x0038AF84 File Offset: 0x00389184
			// (set) Token: 0x0600E8F2 RID: 59634 RVA: 0x0006DE03 File Offset: 0x0006C003
			public unsafe Il2CppReferenceArray<BoneTransform> finalBoneTransforms
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass94_0.NativeFieldInfoPtr_finalBoneTransforms);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoneTransform>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass94_0.NativeFieldInfoPtr_finalBoneTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046A6 RID: 18086
			// (get) Token: 0x0600E8F3 RID: 59635 RVA: 0x0038AFB4 File Offset: 0x003891B4
			// (set) Token: 0x0600E8F4 RID: 59636 RVA: 0x0006DE22 File Offset: 0x0006C022
			public unsafe bool standUpFromBack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass94_0.NativeFieldInfoPtr_standUpFromBack);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass94_0.NativeFieldInfoPtr_standUpFromBack)) = value;
				}
			}

			// Token: 0x04009DFD RID: 40445
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009DFE RID: 40446
			private static readonly IntPtr NativeFieldInfoPtr_finalBoneTransforms;

			// Token: 0x04009DFF RID: 40447
			private static readonly IntPtr NativeFieldInfoPtr_standUpFromBack;

			// Token: 0x04009E00 RID: 40448
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009E01 RID: 40449
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DE5 RID: 3557
			[ObfuscatedName("ScheduleOne.AvatarFramework.Animation.AvatarAnimation+<>c__DisplayClass94_0+<<PlayStandUpAnimation>g__StandUpRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060100A0 RID: 65696 RVA: 0x003CF658 File Offset: 0x003CD858
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique()
				{
					Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass94_0>.NativeClassPtr, "<<PlayStandUpAnimation>g__StandUpRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr);
					AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>1__state");
					AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>2__current");
					AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>4__this");
					AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__time_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<time>5__2");
					AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<i>5__3");
					AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100677701);
					AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100677702);
					AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100677703);
					AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100677704);
					AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100677705);
					AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100677706);
				}

				// Token: 0x060100A1 RID: 65697 RVA: 0x003CF760 File Offset: 0x003CD960
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060100A2 RID: 65698 RVA: 0x003CF7A8 File Offset: 0x003CD9A8
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060100A3 RID: 65699 RVA: 0x003CF7DC File Offset: 0x003CD9DC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222763, XrefRangeEnd = 222785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004E3A RID: 20026
				// (get) Token: 0x060100A4 RID: 65700 RVA: 0x003CF818 File Offset: 0x003CDA18
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060100A5 RID: 65701 RVA: 0x003CF858 File Offset: 0x003CDA58
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222785, XrefRangeEnd = 222790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004E3B RID: 20027
				// (get) Token: 0x060100A6 RID: 65702 RVA: 0x003CF88C File Offset: 0x003CDA8C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060100A7 RID: 65703 RVA: 0x00079A32 File Offset: 0x00077C32
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004E35 RID: 20021
				// (get) Token: 0x060100A8 RID: 65704 RVA: 0x003CF8CC File Offset: 0x003CDACC
				// (set) Token: 0x060100A9 RID: 65705 RVA: 0x00079A3B File Offset: 0x00077C3B
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004E36 RID: 20022
				// (get) Token: 0x060100AA RID: 65706 RVA: 0x003CF8F4 File Offset: 0x003CDAF4
				// (set) Token: 0x060100AB RID: 65707 RVA: 0x00079A56 File Offset: 0x00077C56
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E37 RID: 20023
				// (get) Token: 0x060100AC RID: 65708 RVA: 0x003CF924 File Offset: 0x003CDB24
				// (set) Token: 0x060100AD RID: 65709 RVA: 0x00079A75 File Offset: 0x00077C75
				public unsafe AvatarAnimation.__c__DisplayClass94_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation.__c__DisplayClass94_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E38 RID: 20024
				// (get) Token: 0x060100AE RID: 65710 RVA: 0x003CF954 File Offset: 0x003CDB54
				// (set) Token: 0x060100AF RID: 65711 RVA: 0x00079A94 File Offset: 0x00077C94
				public unsafe float _time_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__time_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__time_5__2)) = value;
					}
				}

				// Token: 0x17004E39 RID: 20025
				// (get) Token: 0x060100B0 RID: 65712 RVA: 0x003CF97C File Offset: 0x003CDB7C
				// (set) Token: 0x060100B1 RID: 65713 RVA: 0x00079AAF File Offset: 0x00077CAF
				public unsafe float _i_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x0400ACD7 RID: 44247
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ACD8 RID: 44248
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400ACD9 RID: 44249
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400ACDA RID: 44250
				private static readonly IntPtr NativeFieldInfoPtr__time_5__2;

				// Token: 0x0400ACDB RID: 44251
				private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x0400ACDC RID: 44252
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400ACDD RID: 44253
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ACDE RID: 44254
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400ACDF RID: 44255
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400ACE0 RID: 44256
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ACE1 RID: 44257
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
