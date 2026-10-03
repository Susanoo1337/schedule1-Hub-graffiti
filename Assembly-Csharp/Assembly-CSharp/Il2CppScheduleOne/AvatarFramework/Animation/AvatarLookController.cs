using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRootMotion.FinalIK;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using Unity.Profiling;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x020004BD RID: 1213
	public class AvatarLookController : MonoBehaviour
	{
		// Token: 0x06006F15 RID: 28437 RVA: 0x001F9A9C File Offset: 0x001F7C9C
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarLookController()
		{
			Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarLookController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr);
			AvatarLookController.NativeFieldInfoPtr_CullRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "CullRange");
			AvatarLookController.NativeFieldInfoPtr_CullRangeSqr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "CullRangeSqr");
			AvatarLookController.NativeFieldInfoPtr_LookAtPlayerRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "LookAtPlayerRange");
			AvatarLookController.NativeFieldInfoPtr_EyeContractRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "EyeContractRange");
			AvatarLookController.NativeFieldInfoPtr_TempContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "TempContainer");
			AvatarLookController.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "DEBUG");
			AvatarLookController.NativeFieldInfoPtr__BodyRotationSpeedMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "<BodyRotationSpeedMultiplier>k__BackingField");
			AvatarLookController.NativeFieldInfoPtr_Aim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "Aim");
			AvatarLookController.NativeFieldInfoPtr_HeadBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "HeadBone");
			AvatarLookController.NativeFieldInfoPtr_LookForwardTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "LookForwardTarget");
			AvatarLookController.NativeFieldInfoPtr_LookOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "LookOrigin");
			AvatarLookController.NativeFieldInfoPtr_Eyes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "Eyes");
			AvatarLookController.NativeFieldInfoPtr_AutoLookAtPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "AutoLookAtPlayer");
			AvatarLookController.NativeFieldInfoPtr_LookLerpSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "LookLerpSpeed");
			AvatarLookController.NativeFieldInfoPtr_AimIKWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "AimIKWeight");
			AvatarLookController.NativeFieldInfoPtr_BodyRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "BodyRotationSpeed");
			AvatarLookController.NativeFieldInfoPtr__parentNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "_parentNPC");
			AvatarLookController.NativeFieldInfoPtr__parentPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "_parentPlayer");
			AvatarLookController.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "avatar");
			AvatarLookController.NativeFieldInfoPtr_lookAtPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "lookAtPos");
			AvatarLookController.NativeFieldInfoPtr_lookAtTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "lookAtTarget");
			AvatarLookController.NativeFieldInfoPtr_lastFrameOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "lastFrameOffset");
			AvatarLookController.NativeFieldInfoPtr_overrideLookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "overrideLookAt");
			AvatarLookController.NativeFieldInfoPtr_overriddenLookTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "overriddenLookTarget");
			AvatarLookController.NativeFieldInfoPtr_overrideLookPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "overrideLookPriority");
			AvatarLookController.NativeFieldInfoPtr_overrideRotateBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "overrideRotateBody");
			AvatarLookController.NativeFieldInfoPtr_blockLookOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "blockLookOverrides");
			AvatarLookController.NativeFieldInfoPtr_ForceLookTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "ForceLookTarget");
			AvatarLookController.NativeFieldInfoPtr_ForceLookRotateBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "ForceLookRotateBody");
			AvatarLookController.NativeFieldInfoPtr_defaultIKWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "defaultIKWeight");
			AvatarLookController.NativeFieldInfoPtr_nearestPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "nearestPlayer");
			AvatarLookController.NativeFieldInfoPtr_nearestPlayerDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "nearestPlayerDist");
			AvatarLookController.NativeFieldInfoPtr_localPlayerSqrDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "localPlayerSqrDist");
			AvatarLookController.NativeFieldInfoPtr_updateLookMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "updateLookMarker");
			AvatarLookController.NativeFieldInfoPtr_lerpTargetMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "lerpTargetMarker");
			AvatarLookController.NativeFieldInfoPtr_eyeLookAtMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "eyeLookAtMarker");
			AvatarLookController.NativeMethodInfoPtr_get_BodyRotationSpeedMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100677718);
			AvatarLookController.NativeMethodInfoPtr_set_BodyRotationSpeedMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100677719);
			AvatarLookController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100677720);
			AvatarLookController.NativeMethodInfoPtr_UpdateLook_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100677721);
			AvatarLookController.NativeMethodInfoPtr_UpdateNearestPlayer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100677722);
			AvatarLookController.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100677723);
			AvatarLookController.NativeMethodInfoPtr_OverrideLookTarget_Public_Void_Vector3_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100677724);
			AvatarLookController.NativeMethodInfoPtr_BlockLookTargetOverrides_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100677725);
			AvatarLookController.NativeMethodInfoPtr_LookForward_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100677726);
			AvatarLookController.NativeMethodInfoPtr_LerpTargetTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100677727);
			AvatarLookController.NativeMethodInfoPtr_CanLookAt_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100677728);
			AvatarLookController.NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100677729);
			AvatarLookController.NativeMethodInfoPtr_OverrideIKWeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100677730);
			AvatarLookController.NativeMethodInfoPtr_ResetIKWeight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100677731);
			AvatarLookController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100677732);
		}

		// Token: 0x1700226C RID: 8812
		// (get) Token: 0x06006F16 RID: 28438 RVA: 0x001F9EC8 File Offset: 0x001F80C8
		// (set) Token: 0x06006F17 RID: 28439 RVA: 0x001F9F04 File Offset: 0x001F8104
		public unsafe float BodyRotationSpeedMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_get_BodyRotationSpeedMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_set_BodyRotationSpeedMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006F18 RID: 28440 RVA: 0x001F9F44 File Offset: 0x001F8144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223495, XrefRangeEnd = 223560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F19 RID: 28441 RVA: 0x001F9F78 File Offset: 0x001F8178
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223583, RefRangeEnd = 223584, XrefRangeStart = 223560, XrefRangeEnd = 223583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLook()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_UpdateLook_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F1A RID: 28442 RVA: 0x001F9FAC File Offset: 0x001F81AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223584, XrefRangeEnd = 223602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateNearestPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_UpdateNearestPlayer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F1B RID: 28443 RVA: 0x001F9FE0 File Offset: 0x001F81E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223602, XrefRangeEnd = 223652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F1C RID: 28444 RVA: 0x001FA014 File Offset: 0x001F8214
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 223669, RefRangeEnd = 223685, XrefRangeStart = 223652, XrefRangeEnd = 223669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideLookTarget(Vector3 targetPosition, int priority, bool rotateBody = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotateBody;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_OverrideLookTarget_Public_Void_Vector3_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F1D RID: 28445 RVA: 0x001FA070 File Offset: 0x001F8270
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223685, RefRangeEnd = 223686, XrefRangeStart = 223685, XrefRangeEnd = 223685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlockLookTargetOverrides()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_BlockLookTargetOverrides_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F1E RID: 28446 RVA: 0x001FA0A4 File Offset: 0x001F82A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223697, RefRangeEnd = 223698, XrefRangeStart = 223686, XrefRangeEnd = 223697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookForward()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_LookForward_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F1F RID: 28447 RVA: 0x001FA0D8 File Offset: 0x001F82D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223716, RefRangeEnd = 223717, XrefRangeStart = 223698, XrefRangeEnd = 223716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpTargetTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_LerpTargetTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F20 RID: 28448 RVA: 0x001FA10C File Offset: 0x001F830C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223721, RefRangeEnd = 223722, XrefRangeStart = 223717, XrefRangeEnd = 223721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanLookAt(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_CanLookAt_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006F21 RID: 28449 RVA: 0x001FA158 File Offset: 0x001F8358
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RagdollChange(bool oldValue, bool ragdoll, bool playStandUpAnim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldValue;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ragdoll;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playStandUpAnim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F22 RID: 28450 RVA: 0x001FA1B4 File Offset: 0x001F83B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 223724, RefRangeEnd = 223727, XrefRangeStart = 223722, XrefRangeEnd = 223724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideIKWeight(float weight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_OverrideIKWeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F23 RID: 28451 RVA: 0x001FA1F4 File Offset: 0x001F83F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223729, RefRangeEnd = 223730, XrefRangeStart = 223727, XrefRangeEnd = 223729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetIKWeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_ResetIKWeight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F24 RID: 28452 RVA: 0x001FA228 File Offset: 0x001F8428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223730, XrefRangeEnd = 223737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarLookController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F25 RID: 28453 RVA: 0x000349E5 File Offset: 0x00032BE5
		public AvatarLookController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002248 RID: 8776
		// (get) Token: 0x06006F26 RID: 28454 RVA: 0x001FA264 File Offset: 0x001F8464
		// (set) Token: 0x06006F27 RID: 28455 RVA: 0x000349EE File Offset: 0x00032BEE
		public unsafe static float CullRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarLookController.NativeFieldInfoPtr_CullRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarLookController.NativeFieldInfoPtr_CullRange, (void*)(&value));
			}
		}

		// Token: 0x17002249 RID: 8777
		// (get) Token: 0x06006F28 RID: 28456 RVA: 0x001FA280 File Offset: 0x001F8480
		// (set) Token: 0x06006F29 RID: 28457 RVA: 0x000349FC File Offset: 0x00032BFC
		public unsafe static float CullRangeSqr
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarLookController.NativeFieldInfoPtr_CullRangeSqr, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarLookController.NativeFieldInfoPtr_CullRangeSqr, (void*)(&value));
			}
		}

		// Token: 0x1700224A RID: 8778
		// (get) Token: 0x06006F2A RID: 28458 RVA: 0x001FA29C File Offset: 0x001F849C
		// (set) Token: 0x06006F2B RID: 28459 RVA: 0x00034A0A File Offset: 0x00032C0A
		public unsafe static float LookAtPlayerRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarLookController.NativeFieldInfoPtr_LookAtPlayerRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarLookController.NativeFieldInfoPtr_LookAtPlayerRange, (void*)(&value));
			}
		}

		// Token: 0x1700224B RID: 8779
		// (get) Token: 0x06006F2C RID: 28460 RVA: 0x001FA2B8 File Offset: 0x001F84B8
		// (set) Token: 0x06006F2D RID: 28461 RVA: 0x00034A18 File Offset: 0x00032C18
		public unsafe static float EyeContractRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarLookController.NativeFieldInfoPtr_EyeContractRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarLookController.NativeFieldInfoPtr_EyeContractRange, (void*)(&value));
			}
		}

		// Token: 0x1700224C RID: 8780
		// (get) Token: 0x06006F2E RID: 28462 RVA: 0x001FA2D4 File Offset: 0x001F84D4
		// (set) Token: 0x06006F2F RID: 28463 RVA: 0x00034A26 File Offset: 0x00032C26
		public unsafe static Transform TempContainer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AvatarLookController.NativeFieldInfoPtr_TempContainer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarLookController.NativeFieldInfoPtr_TempContainer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700224D RID: 8781
		// (get) Token: 0x06006F30 RID: 28464 RVA: 0x001FA2FC File Offset: 0x001F84FC
		// (set) Token: 0x06006F31 RID: 28465 RVA: 0x00034A38 File Offset: 0x00032C38
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x1700224E RID: 8782
		// (get) Token: 0x06006F32 RID: 28466 RVA: 0x001FA324 File Offset: 0x001F8524
		// (set) Token: 0x06006F33 RID: 28467 RVA: 0x00034A53 File Offset: 0x00032C53
		public unsafe float _BodyRotationSpeedMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr__BodyRotationSpeedMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr__BodyRotationSpeedMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x1700224F RID: 8783
		// (get) Token: 0x06006F34 RID: 28468 RVA: 0x001FA34C File Offset: 0x001F854C
		// (set) Token: 0x06006F35 RID: 28469 RVA: 0x00034A6E File Offset: 0x00032C6E
		public unsafe AimIK Aim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_Aim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AimIK>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_Aim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002250 RID: 8784
		// (get) Token: 0x06006F36 RID: 28470 RVA: 0x001FA37C File Offset: 0x001F857C
		// (set) Token: 0x06006F37 RID: 28471 RVA: 0x00034A8D File Offset: 0x00032C8D
		public unsafe Transform HeadBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_HeadBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_HeadBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002251 RID: 8785
		// (get) Token: 0x06006F38 RID: 28472 RVA: 0x001FA3AC File Offset: 0x001F85AC
		// (set) Token: 0x06006F39 RID: 28473 RVA: 0x00034AAC File Offset: 0x00032CAC
		public unsafe Transform LookForwardTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookForwardTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookForwardTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002252 RID: 8786
		// (get) Token: 0x06006F3A RID: 28474 RVA: 0x001FA3DC File Offset: 0x001F85DC
		// (set) Token: 0x06006F3B RID: 28475 RVA: 0x00034ACB File Offset: 0x00032CCB
		public unsafe Transform LookOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002253 RID: 8787
		// (get) Token: 0x06006F3C RID: 28476 RVA: 0x001FA40C File Offset: 0x001F860C
		// (set) Token: 0x06006F3D RID: 28477 RVA: 0x00034AEA File Offset: 0x00032CEA
		public unsafe EyeController Eyes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_Eyes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyeController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_Eyes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002254 RID: 8788
		// (get) Token: 0x06006F3E RID: 28478 RVA: 0x001FA43C File Offset: 0x001F863C
		// (set) Token: 0x06006F3F RID: 28479 RVA: 0x00034B09 File Offset: 0x00032D09
		public unsafe bool AutoLookAtPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_AutoLookAtPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_AutoLookAtPlayer)) = value;
			}
		}

		// Token: 0x17002255 RID: 8789
		// (get) Token: 0x06006F40 RID: 28480 RVA: 0x001FA464 File Offset: 0x001F8664
		// (set) Token: 0x06006F41 RID: 28481 RVA: 0x00034B24 File Offset: 0x00032D24
		public unsafe float LookLerpSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookLerpSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookLerpSpeed)) = value;
			}
		}

		// Token: 0x17002256 RID: 8790
		// (get) Token: 0x06006F42 RID: 28482 RVA: 0x001FA48C File Offset: 0x001F868C
		// (set) Token: 0x06006F43 RID: 28483 RVA: 0x00034B3F File Offset: 0x00032D3F
		public unsafe float AimIKWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_AimIKWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_AimIKWeight)) = value;
			}
		}

		// Token: 0x17002257 RID: 8791
		// (get) Token: 0x06006F44 RID: 28484 RVA: 0x001FA4B4 File Offset: 0x001F86B4
		// (set) Token: 0x06006F45 RID: 28485 RVA: 0x00034B5A File Offset: 0x00032D5A
		public unsafe float BodyRotationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_BodyRotationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_BodyRotationSpeed)) = value;
			}
		}

		// Token: 0x17002258 RID: 8792
		// (get) Token: 0x06006F46 RID: 28486 RVA: 0x001FA4DC File Offset: 0x001F86DC
		// (set) Token: 0x06006F47 RID: 28487 RVA: 0x00034B75 File Offset: 0x00032D75
		public unsafe NPC _parentNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr__parentNPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr__parentNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002259 RID: 8793
		// (get) Token: 0x06006F48 RID: 28488 RVA: 0x001FA50C File Offset: 0x001F870C
		// (set) Token: 0x06006F49 RID: 28489 RVA: 0x00034B94 File Offset: 0x00032D94
		public unsafe Player _parentPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr__parentPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr__parentPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700225A RID: 8794
		// (get) Token: 0x06006F4A RID: 28490 RVA: 0x001FA53C File Offset: 0x001F873C
		// (set) Token: 0x06006F4B RID: 28491 RVA: 0x00034BB3 File Offset: 0x00032DB3
		public unsafe Avatar avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700225B RID: 8795
		// (get) Token: 0x06006F4C RID: 28492 RVA: 0x001FA56C File Offset: 0x001F876C
		// (set) Token: 0x06006F4D RID: 28493 RVA: 0x00034BD2 File Offset: 0x00032DD2
		public unsafe Vector3 lookAtPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lookAtPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lookAtPos)) = value;
			}
		}

		// Token: 0x1700225C RID: 8796
		// (get) Token: 0x06006F4E RID: 28494 RVA: 0x001FA594 File Offset: 0x001F8794
		// (set) Token: 0x06006F4F RID: 28495 RVA: 0x00034BED File Offset: 0x00032DED
		public unsafe Transform lookAtTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lookAtTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lookAtTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700225D RID: 8797
		// (get) Token: 0x06006F50 RID: 28496 RVA: 0x001FA5C4 File Offset: 0x001F87C4
		// (set) Token: 0x06006F51 RID: 28497 RVA: 0x00034C0C File Offset: 0x00032E0C
		public unsafe Vector3 lastFrameOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lastFrameOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lastFrameOffset)) = value;
			}
		}

		// Token: 0x1700225E RID: 8798
		// (get) Token: 0x06006F52 RID: 28498 RVA: 0x001FA5EC File Offset: 0x001F87EC
		// (set) Token: 0x06006F53 RID: 28499 RVA: 0x00034C27 File Offset: 0x00032E27
		public unsafe bool overrideLookAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideLookAt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideLookAt)) = value;
			}
		}

		// Token: 0x1700225F RID: 8799
		// (get) Token: 0x06006F54 RID: 28500 RVA: 0x001FA614 File Offset: 0x001F8814
		// (set) Token: 0x06006F55 RID: 28501 RVA: 0x00034C42 File Offset: 0x00032E42
		public unsafe Vector3 overriddenLookTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overriddenLookTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overriddenLookTarget)) = value;
			}
		}

		// Token: 0x17002260 RID: 8800
		// (get) Token: 0x06006F56 RID: 28502 RVA: 0x001FA63C File Offset: 0x001F883C
		// (set) Token: 0x06006F57 RID: 28503 RVA: 0x00034C5D File Offset: 0x00032E5D
		public unsafe int overrideLookPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideLookPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideLookPriority)) = value;
			}
		}

		// Token: 0x17002261 RID: 8801
		// (get) Token: 0x06006F58 RID: 28504 RVA: 0x001FA664 File Offset: 0x001F8864
		// (set) Token: 0x06006F59 RID: 28505 RVA: 0x00034C78 File Offset: 0x00032E78
		public unsafe bool overrideRotateBody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideRotateBody);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideRotateBody)) = value;
			}
		}

		// Token: 0x17002262 RID: 8802
		// (get) Token: 0x06006F5A RID: 28506 RVA: 0x001FA68C File Offset: 0x001F888C
		// (set) Token: 0x06006F5B RID: 28507 RVA: 0x00034C93 File Offset: 0x00032E93
		public unsafe bool blockLookOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_blockLookOverrides);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_blockLookOverrides)) = value;
			}
		}

		// Token: 0x17002263 RID: 8803
		// (get) Token: 0x06006F5C RID: 28508 RVA: 0x001FA6B4 File Offset: 0x001F88B4
		// (set) Token: 0x06006F5D RID: 28509 RVA: 0x00034CAE File Offset: 0x00032EAE
		public unsafe Transform ForceLookTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_ForceLookTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_ForceLookTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002264 RID: 8804
		// (get) Token: 0x06006F5E RID: 28510 RVA: 0x001FA6E4 File Offset: 0x001F88E4
		// (set) Token: 0x06006F5F RID: 28511 RVA: 0x00034CCD File Offset: 0x00032ECD
		public unsafe bool ForceLookRotateBody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_ForceLookRotateBody);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_ForceLookRotateBody)) = value;
			}
		}

		// Token: 0x17002265 RID: 8805
		// (get) Token: 0x06006F60 RID: 28512 RVA: 0x001FA70C File Offset: 0x001F890C
		// (set) Token: 0x06006F61 RID: 28513 RVA: 0x00034CE8 File Offset: 0x00032EE8
		public unsafe float defaultIKWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_defaultIKWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_defaultIKWeight)) = value;
			}
		}

		// Token: 0x17002266 RID: 8806
		// (get) Token: 0x06006F62 RID: 28514 RVA: 0x001FA734 File Offset: 0x001F8934
		// (set) Token: 0x06006F63 RID: 28515 RVA: 0x00034D03 File Offset: 0x00032F03
		public unsafe Player nearestPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_nearestPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_nearestPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002267 RID: 8807
		// (get) Token: 0x06006F64 RID: 28516 RVA: 0x001FA764 File Offset: 0x001F8964
		// (set) Token: 0x06006F65 RID: 28517 RVA: 0x00034D22 File Offset: 0x00032F22
		public unsafe float nearestPlayerDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_nearestPlayerDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_nearestPlayerDist)) = value;
			}
		}

		// Token: 0x17002268 RID: 8808
		// (get) Token: 0x06006F66 RID: 28518 RVA: 0x001FA78C File Offset: 0x001F898C
		// (set) Token: 0x06006F67 RID: 28519 RVA: 0x00034D3D File Offset: 0x00032F3D
		public unsafe float localPlayerSqrDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_localPlayerSqrDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_localPlayerSqrDist)) = value;
			}
		}

		// Token: 0x17002269 RID: 8809
		// (get) Token: 0x06006F68 RID: 28520 RVA: 0x001FA7B4 File Offset: 0x001F89B4
		// (set) Token: 0x06006F69 RID: 28521 RVA: 0x00034D58 File Offset: 0x00032F58
		public unsafe static ProfilerMarker updateLookMarker
		{
			get
			{
				ProfilerMarker result;
				IL2CPP.il2cpp_field_static_get_value(AvatarLookController.NativeFieldInfoPtr_updateLookMarker, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarLookController.NativeFieldInfoPtr_updateLookMarker, (void*)(&value));
			}
		}

		// Token: 0x1700226A RID: 8810
		// (get) Token: 0x06006F6A RID: 28522 RVA: 0x001FA7D0 File Offset: 0x001F89D0
		// (set) Token: 0x06006F6B RID: 28523 RVA: 0x00034D66 File Offset: 0x00032F66
		public unsafe static ProfilerMarker lerpTargetMarker
		{
			get
			{
				ProfilerMarker result;
				IL2CPP.il2cpp_field_static_get_value(AvatarLookController.NativeFieldInfoPtr_lerpTargetMarker, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarLookController.NativeFieldInfoPtr_lerpTargetMarker, (void*)(&value));
			}
		}

		// Token: 0x1700226B RID: 8811
		// (get) Token: 0x06006F6C RID: 28524 RVA: 0x001FA7EC File Offset: 0x001F89EC
		// (set) Token: 0x06006F6D RID: 28525 RVA: 0x00034D74 File Offset: 0x00032F74
		public unsafe static ProfilerMarker eyeLookAtMarker
		{
			get
			{
				ProfilerMarker result;
				IL2CPP.il2cpp_field_static_get_value(AvatarLookController.NativeFieldInfoPtr_eyeLookAtMarker, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarLookController.NativeFieldInfoPtr_eyeLookAtMarker, (void*)(&value));
			}
		}

		// Token: 0x04004C20 RID: 19488
		private static readonly IntPtr NativeFieldInfoPtr_CullRange;

		// Token: 0x04004C21 RID: 19489
		private static readonly IntPtr NativeFieldInfoPtr_CullRangeSqr;

		// Token: 0x04004C22 RID: 19490
		private static readonly IntPtr NativeFieldInfoPtr_LookAtPlayerRange;

		// Token: 0x04004C23 RID: 19491
		private static readonly IntPtr NativeFieldInfoPtr_EyeContractRange;

		// Token: 0x04004C24 RID: 19492
		private static readonly IntPtr NativeFieldInfoPtr_TempContainer;

		// Token: 0x04004C25 RID: 19493
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04004C26 RID: 19494
		private static readonly IntPtr NativeFieldInfoPtr__BodyRotationSpeedMultiplier_k__BackingField;

		// Token: 0x04004C27 RID: 19495
		private static readonly IntPtr NativeFieldInfoPtr_Aim;

		// Token: 0x04004C28 RID: 19496
		private static readonly IntPtr NativeFieldInfoPtr_HeadBone;

		// Token: 0x04004C29 RID: 19497
		private static readonly IntPtr NativeFieldInfoPtr_LookForwardTarget;

		// Token: 0x04004C2A RID: 19498
		private static readonly IntPtr NativeFieldInfoPtr_LookOrigin;

		// Token: 0x04004C2B RID: 19499
		private static readonly IntPtr NativeFieldInfoPtr_Eyes;

		// Token: 0x04004C2C RID: 19500
		private static readonly IntPtr NativeFieldInfoPtr_AutoLookAtPlayer;

		// Token: 0x04004C2D RID: 19501
		private static readonly IntPtr NativeFieldInfoPtr_LookLerpSpeed;

		// Token: 0x04004C2E RID: 19502
		private static readonly IntPtr NativeFieldInfoPtr_AimIKWeight;

		// Token: 0x04004C2F RID: 19503
		private static readonly IntPtr NativeFieldInfoPtr_BodyRotationSpeed;

		// Token: 0x04004C30 RID: 19504
		private static readonly IntPtr NativeFieldInfoPtr__parentNPC;

		// Token: 0x04004C31 RID: 19505
		private static readonly IntPtr NativeFieldInfoPtr__parentPlayer;

		// Token: 0x04004C32 RID: 19506
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04004C33 RID: 19507
		private static readonly IntPtr NativeFieldInfoPtr_lookAtPos;

		// Token: 0x04004C34 RID: 19508
		private static readonly IntPtr NativeFieldInfoPtr_lookAtTarget;

		// Token: 0x04004C35 RID: 19509
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameOffset;

		// Token: 0x04004C36 RID: 19510
		private static readonly IntPtr NativeFieldInfoPtr_overrideLookAt;

		// Token: 0x04004C37 RID: 19511
		private static readonly IntPtr NativeFieldInfoPtr_overriddenLookTarget;

		// Token: 0x04004C38 RID: 19512
		private static readonly IntPtr NativeFieldInfoPtr_overrideLookPriority;

		// Token: 0x04004C39 RID: 19513
		private static readonly IntPtr NativeFieldInfoPtr_overrideRotateBody;

		// Token: 0x04004C3A RID: 19514
		private static readonly IntPtr NativeFieldInfoPtr_blockLookOverrides;

		// Token: 0x04004C3B RID: 19515
		private static readonly IntPtr NativeFieldInfoPtr_ForceLookTarget;

		// Token: 0x04004C3C RID: 19516
		private static readonly IntPtr NativeFieldInfoPtr_ForceLookRotateBody;

		// Token: 0x04004C3D RID: 19517
		private static readonly IntPtr NativeFieldInfoPtr_defaultIKWeight;

		// Token: 0x04004C3E RID: 19518
		private static readonly IntPtr NativeFieldInfoPtr_nearestPlayer;

		// Token: 0x04004C3F RID: 19519
		private static readonly IntPtr NativeFieldInfoPtr_nearestPlayerDist;

		// Token: 0x04004C40 RID: 19520
		private static readonly IntPtr NativeFieldInfoPtr_localPlayerSqrDist;

		// Token: 0x04004C41 RID: 19521
		private static readonly IntPtr NativeFieldInfoPtr_updateLookMarker;

		// Token: 0x04004C42 RID: 19522
		private static readonly IntPtr NativeFieldInfoPtr_lerpTargetMarker;

		// Token: 0x04004C43 RID: 19523
		private static readonly IntPtr NativeFieldInfoPtr_eyeLookAtMarker;

		// Token: 0x04004C44 RID: 19524
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyRotationSpeedMultiplier_Public_get_Single_0;

		// Token: 0x04004C45 RID: 19525
		private static readonly IntPtr NativeMethodInfoPtr_set_BodyRotationSpeedMultiplier_Public_set_Void_Single_0;

		// Token: 0x04004C46 RID: 19526
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004C47 RID: 19527
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLook_Private_Void_0;

		// Token: 0x04004C48 RID: 19528
		private static readonly IntPtr NativeMethodInfoPtr_UpdateNearestPlayer_Private_Void_0;

		// Token: 0x04004C49 RID: 19529
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04004C4A RID: 19530
		private static readonly IntPtr NativeMethodInfoPtr_OverrideLookTarget_Public_Void_Vector3_Int32_Boolean_0;

		// Token: 0x04004C4B RID: 19531
		private static readonly IntPtr NativeMethodInfoPtr_BlockLookTargetOverrides_Public_Void_0;

		// Token: 0x04004C4C RID: 19532
		private static readonly IntPtr NativeMethodInfoPtr_LookForward_Private_Void_0;

		// Token: 0x04004C4D RID: 19533
		private static readonly IntPtr NativeMethodInfoPtr_LerpTargetTransform_Private_Void_0;

		// Token: 0x04004C4E RID: 19534
		private static readonly IntPtr NativeMethodInfoPtr_CanLookAt_Private_Boolean_Vector3_0;

		// Token: 0x04004C4F RID: 19535
		private static readonly IntPtr NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0;

		// Token: 0x04004C50 RID: 19536
		private static readonly IntPtr NativeMethodInfoPtr_OverrideIKWeight_Public_Void_Single_0;

		// Token: 0x04004C51 RID: 19537
		private static readonly IntPtr NativeMethodInfoPtr_ResetIKWeight_Public_Void_0;

		// Token: 0x04004C52 RID: 19538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
