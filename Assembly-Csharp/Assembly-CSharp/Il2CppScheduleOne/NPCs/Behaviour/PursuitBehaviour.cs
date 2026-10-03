using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Police;
using Il2CppScheduleOne.Vision;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000681 RID: 1665
	public class PursuitBehaviour : CombatBehaviour
	{
		// Token: 0x0600A12C RID: 41260 RVA: 0x002AF6B0 File Offset: 0x002AD8B0
		// Note: this type is marked as 'beforefieldinit'.
		static PursuitBehaviour()
		{
			Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "PursuitBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr);
			PursuitBehaviour.NativeFieldInfoPtr_ARREST_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "ARREST_RANGE");
			PursuitBehaviour.NativeFieldInfoPtr_ARREST_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "ARREST_TIME");
			PursuitBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "EXTRA_VISIBILITY_TIME");
			PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_INVESTIGATING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "MOVE_SPEED_INVESTIGATING");
			PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_ARRESTING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "MOVE_SPEED_ARRESTING");
			PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_CHASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "MOVE_SPEED_CHASE");
			PursuitBehaviour.NativeFieldInfoPtr_CHASE_SPEED_DISTANCE_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "CHASE_SPEED_DISTANCE_THRESHOLD");
			PursuitBehaviour.NativeFieldInfoPtr_ARREST_MAX_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "ARREST_MAX_DISTANCE");
			PursuitBehaviour.NativeFieldInfoPtr_LEAVE_ARREST_CIRCLE_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "LEAVE_ARREST_CIRCLE_LIMIT");
			PursuitBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "<TargetPlayer>k__BackingField");
			PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "ArrestCircle_MaxVisibleDistance");
			PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "ArrestCircle_MaxOpacity");
			PursuitBehaviour.NativeFieldInfoPtr_Weapon_Baton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "Weapon_Baton");
			PursuitBehaviour.NativeFieldInfoPtr_Weapon_Taser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "Weapon_Taser");
			PursuitBehaviour.NativeFieldInfoPtr_Weapon_Gun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "Weapon_Gun");
			PursuitBehaviour.NativeFieldInfoPtr_arrestingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "arrestingEnabled");
			PursuitBehaviour.NativeFieldInfoPtr_currentPursuitLevelDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "currentPursuitLevelDuration");
			PursuitBehaviour.NativeFieldInfoPtr_timeWithinArrestRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "timeWithinArrestRange");
			PursuitBehaviour.NativeFieldInfoPtr_distanceOnPursuitStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "distanceOnPursuitStart");
			PursuitBehaviour.NativeFieldInfoPtr_officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "officer");
			PursuitBehaviour.NativeFieldInfoPtr_targetWasDrivingOnPursuitStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "targetWasDrivingOnPursuitStart");
			PursuitBehaviour.NativeFieldInfoPtr_wasInArrestCircleLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "wasInArrestCircleLastFrame");
			PursuitBehaviour.NativeFieldInfoPtr_leaveArrestCircleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "leaveArrestCircleCount");
			PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.PursuitBehaviourAssembly-CSharp.dll_Excuted");
			PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.PursuitBehaviourAssembly-CSharp.dll_Excuted");
			PursuitBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684622);
			PursuitBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684623);
			PursuitBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684624);
			PursuitBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684625);
			PursuitBehaviour.NativeMethodInfoPtr_SetTarget_Protected_Virtual_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684626);
			PursuitBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684627);
			PursuitBehaviour.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684628);
			PursuitBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684629);
			PursuitBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684630);
			PursuitBehaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684631);
			PursuitBehaviour.NativeMethodInfoPtr_IsTargetValid_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684632);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateInvestigatingBehaviour_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684633);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateArrestBehaviour_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684634);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateNonLethalBehaviour_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684635);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateLethalBehaviour_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684636);
			PursuitBehaviour.NativeMethodInfoPtr_OnCurrentWeaponChanged_Protected_Virtual_Void_AvatarWeapon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684637);
			PursuitBehaviour.NativeMethodInfoPtr_GetIdealRangedWeaponDistance_Protected_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684638);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateArrest_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684639);
			PursuitBehaviour.NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684640);
			PursuitBehaviour.NativeMethodInfoPtr_EndCombat_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684641);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateArrestCircle_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684642);
			PursuitBehaviour.NativeMethodInfoPtr_ResetArrestProgress_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684643);
			PursuitBehaviour.NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684644);
			PursuitBehaviour.NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684645);
			PursuitBehaviour.NativeMethodInfoPtr_OnThirdPartyVisionEvent_Private_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684646);
			PursuitBehaviour.NativeMethodInfoPtr_TargetResighted_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684647);
			PursuitBehaviour.NativeMethodInfoPtr_TargetSpotted_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684648);
			PursuitBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684649);
			PursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684650);
			PursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684651);
			PursuitBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684652);
			PursuitBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100684653);
		}

		// Token: 0x170030B8 RID: 12472
		// (get) Token: 0x0600A12D RID: 41261 RVA: 0x002AFB54 File Offset: 0x002ADD54
		// (set) Token: 0x0600A12E RID: 41262 RVA: 0x002AFB94 File Offset: 0x002ADD94
		public unsafe Player TargetPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A12F RID: 41263 RVA: 0x002AFBD8 File Offset: 0x002ADDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284782, XrefRangeEnd = 284783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A130 RID: 41264 RVA: 0x002AFC14 File Offset: 0x002ADE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284783, XrefRangeEnd = 284805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A131 RID: 41265 RVA: 0x002AFC48 File Offset: 0x002ADE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284805, XrefRangeEnd = 284830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetTarget(NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_SetTarget_Protected_Virtual_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A132 RID: 41266 RVA: 0x002AFC98 File Offset: 0x002ADE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284830, XrefRangeEnd = 284833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A133 RID: 41267 RVA: 0x002AFCD4 File Offset: 0x002ADED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284833, XrefRangeEnd = 284836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A134 RID: 41268 RVA: 0x002AFD10 File Offset: 0x002ADF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284836, XrefRangeEnd = 284838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A135 RID: 41269 RVA: 0x002AFD4C File Offset: 0x002ADF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284838, XrefRangeEnd = 284849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A136 RID: 41270 RVA: 0x002AFD88 File Offset: 0x002ADF88
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnActiveTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A137 RID: 41271 RVA: 0x002AFDC4 File Offset: 0x002ADFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284849, XrefRangeEnd = 284866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsTargetValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_IsTargetValid_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A138 RID: 41272 RVA: 0x002AFE0C File Offset: 0x002AE00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284866, XrefRangeEnd = 284875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateInvestigatingBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateInvestigatingBehaviour_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A139 RID: 41273 RVA: 0x002AFE48 File Offset: 0x002AE048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284875, XrefRangeEnd = 284916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateArrestBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateArrestBehaviour_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A13A RID: 41274 RVA: 0x002AFE84 File Offset: 0x002AE084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284916, XrefRangeEnd = 284937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateNonLethalBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateNonLethalBehaviour_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A13B RID: 41275 RVA: 0x002AFEC0 File Offset: 0x002AE0C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284937, XrefRangeEnd = 284958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateLethalBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateLethalBehaviour_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A13C RID: 41276 RVA: 0x002AFEFC File Offset: 0x002AE0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284958, XrefRangeEnd = 284979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCurrentWeaponChanged(AvatarWeapon weapon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(weapon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_OnCurrentWeaponChanged_Protected_Virtual_Void_AvatarWeapon_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A13D RID: 41277 RVA: 0x002AFF4C File Offset: 0x002AE14C
		[CallerCount(0)]
		public unsafe override float GetIdealRangedWeaponDistance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_GetIdealRangedWeaponDistance_Protected_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A13E RID: 41278 RVA: 0x002AFF94 File Offset: 0x002AE194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284979, XrefRangeEnd = 284995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateArrest(float tick)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tick;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_UpdateArrest_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A13F RID: 41279 RVA: 0x002AFFD4 File Offset: 0x002AE1D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285023, RefRangeEnd = 285024, XrefRangeStart = 284995, XrefRangeEnd = 285023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSpeedControls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A140 RID: 41280 RVA: 0x002B0008 File Offset: 0x002AE208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285024, XrefRangeEnd = 285036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndCombat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_EndCombat_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A141 RID: 41281 RVA: 0x002B0044 File Offset: 0x002AE244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285036, XrefRangeEnd = 285060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateArrestCircle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateArrestCircle_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A142 RID: 41282 RVA: 0x002B0080 File Offset: 0x002AE280
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285060, RefRangeEnd = 285061, XrefRangeStart = 285060, XrefRangeEnd = 285060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetArrestProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_ResetArrestProgress_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A143 RID: 41283 RVA: 0x002B00B4 File Offset: 0x002AE2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285061, XrefRangeEnd = 285063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrestCircleAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A144 RID: 41284 RVA: 0x002B00F4 File Offset: 0x002AE2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285063, XrefRangeEnd = 285064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrestCircleColor(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A145 RID: 41285 RVA: 0x002B0134 File Offset: 0x002AE334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285064, XrefRangeEnd = 285065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnThirdPartyVisionEvent(VisionEventReceipt receipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_OnThirdPartyVisionEvent_Private_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A146 RID: 41286 RVA: 0x002B0178 File Offset: 0x002AE378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285065, XrefRangeEnd = 285080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TargetResighted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_TargetResighted_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A147 RID: 41287 RVA: 0x002B01B4 File Offset: 0x002AE3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285080, XrefRangeEnd = 285083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TargetSpotted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_TargetSpotted_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A148 RID: 41288 RVA: 0x002B01F0 File Offset: 0x002AE3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285083, XrefRangeEnd = 285084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PursuitBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A149 RID: 41289 RVA: 0x002B022C File Offset: 0x002AE42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285084, XrefRangeEnd = 285085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A14A RID: 41290 RVA: 0x002B0268 File Offset: 0x002AE468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285085, XrefRangeEnd = 285086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A14B RID: 41291 RVA: 0x002B02A4 File Offset: 0x002AE4A4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A14C RID: 41292 RVA: 0x002B02E0 File Offset: 0x002AE4E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285114, RefRangeEnd = 285115, XrefRangeStart = 285086, XrefRangeEnd = 285114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A14D RID: 41293 RVA: 0x0004A01C File Offset: 0x0004821C
		public PursuitBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700309F RID: 12447
		// (get) Token: 0x0600A14E RID: 41294 RVA: 0x002B031C File Offset: 0x002AE51C
		// (set) Token: 0x0600A14F RID: 41295 RVA: 0x0004A025 File Offset: 0x00048225
		public unsafe static float ARREST_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_RANGE, (void*)(&value));
			}
		}

		// Token: 0x170030A0 RID: 12448
		// (get) Token: 0x0600A150 RID: 41296 RVA: 0x002B0338 File Offset: 0x002AE538
		// (set) Token: 0x0600A151 RID: 41297 RVA: 0x0004A033 File Offset: 0x00048233
		public unsafe static float ARREST_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_TIME, (void*)(&value));
			}
		}

		// Token: 0x170030A1 RID: 12449
		// (get) Token: 0x0600A152 RID: 41298 RVA: 0x002B0354 File Offset: 0x002AE554
		// (set) Token: 0x0600A153 RID: 41299 RVA: 0x0004A041 File Offset: 0x00048241
		public unsafe static float EXTRA_VISIBILITY_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME, (void*)(&value));
			}
		}

		// Token: 0x170030A2 RID: 12450
		// (get) Token: 0x0600A154 RID: 41300 RVA: 0x002B0370 File Offset: 0x002AE570
		// (set) Token: 0x0600A155 RID: 41301 RVA: 0x0004A04F File Offset: 0x0004824F
		public unsafe static float MOVE_SPEED_INVESTIGATING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_INVESTIGATING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_INVESTIGATING, (void*)(&value));
			}
		}

		// Token: 0x170030A3 RID: 12451
		// (get) Token: 0x0600A156 RID: 41302 RVA: 0x002B038C File Offset: 0x002AE58C
		// (set) Token: 0x0600A157 RID: 41303 RVA: 0x0004A05D File Offset: 0x0004825D
		public unsafe static float MOVE_SPEED_ARRESTING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_ARRESTING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_ARRESTING, (void*)(&value));
			}
		}

		// Token: 0x170030A4 RID: 12452
		// (get) Token: 0x0600A158 RID: 41304 RVA: 0x002B03A8 File Offset: 0x002AE5A8
		// (set) Token: 0x0600A159 RID: 41305 RVA: 0x0004A06B File Offset: 0x0004826B
		public unsafe static float MOVE_SPEED_CHASE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_CHASE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_CHASE, (void*)(&value));
			}
		}

		// Token: 0x170030A5 RID: 12453
		// (get) Token: 0x0600A15A RID: 41306 RVA: 0x002B03C4 File Offset: 0x002AE5C4
		// (set) Token: 0x0600A15B RID: 41307 RVA: 0x0004A079 File Offset: 0x00048279
		public unsafe static float CHASE_SPEED_DISTANCE_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_CHASE_SPEED_DISTANCE_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_CHASE_SPEED_DISTANCE_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170030A6 RID: 12454
		// (get) Token: 0x0600A15C RID: 41308 RVA: 0x002B03E0 File Offset: 0x002AE5E0
		// (set) Token: 0x0600A15D RID: 41309 RVA: 0x0004A087 File Offset: 0x00048287
		public unsafe static float ARREST_MAX_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_MAX_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_MAX_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x170030A7 RID: 12455
		// (get) Token: 0x0600A15E RID: 41310 RVA: 0x002B03FC File Offset: 0x002AE5FC
		// (set) Token: 0x0600A15F RID: 41311 RVA: 0x0004A095 File Offset: 0x00048295
		public unsafe static int LEAVE_ARREST_CIRCLE_LIMIT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_LEAVE_ARREST_CIRCLE_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_LEAVE_ARREST_CIRCLE_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x170030A8 RID: 12456
		// (get) Token: 0x0600A160 RID: 41312 RVA: 0x002B0418 File Offset: 0x002AE618
		// (set) Token: 0x0600A161 RID: 41313 RVA: 0x0004A0A3 File Offset: 0x000482A3
		public unsafe Player _TargetPlayer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030A9 RID: 12457
		// (get) Token: 0x0600A162 RID: 41314 RVA: 0x002B0448 File Offset: 0x002AE648
		// (set) Token: 0x0600A163 RID: 41315 RVA: 0x0004A0C2 File Offset: 0x000482C2
		public unsafe float ArrestCircle_MaxVisibleDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance)) = value;
			}
		}

		// Token: 0x170030AA RID: 12458
		// (get) Token: 0x0600A164 RID: 41316 RVA: 0x002B0470 File Offset: 0x002AE670
		// (set) Token: 0x0600A165 RID: 41317 RVA: 0x0004A0DD File Offset: 0x000482DD
		public unsafe float ArrestCircle_MaxOpacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity)) = value;
			}
		}

		// Token: 0x170030AB RID: 12459
		// (get) Token: 0x0600A166 RID: 41318 RVA: 0x002B0498 File Offset: 0x002AE698
		// (set) Token: 0x0600A167 RID: 41319 RVA: 0x0004A0F8 File Offset: 0x000482F8
		public unsafe AvatarWeapon Weapon_Baton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_Weapon_Baton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarWeapon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_Weapon_Baton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030AC RID: 12460
		// (get) Token: 0x0600A168 RID: 41320 RVA: 0x002B04C8 File Offset: 0x002AE6C8
		// (set) Token: 0x0600A169 RID: 41321 RVA: 0x0004A117 File Offset: 0x00048317
		public unsafe AvatarWeapon Weapon_Taser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_Weapon_Taser);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarWeapon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_Weapon_Taser), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030AD RID: 12461
		// (get) Token: 0x0600A16A RID: 41322 RVA: 0x002B04F8 File Offset: 0x002AE6F8
		// (set) Token: 0x0600A16B RID: 41323 RVA: 0x0004A136 File Offset: 0x00048336
		public unsafe AvatarWeapon Weapon_Gun
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_Weapon_Gun);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarWeapon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_Weapon_Gun), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030AE RID: 12462
		// (get) Token: 0x0600A16C RID: 41324 RVA: 0x002B0528 File Offset: 0x002AE728
		// (set) Token: 0x0600A16D RID: 41325 RVA: 0x0004A155 File Offset: 0x00048355
		public unsafe bool arrestingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_arrestingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_arrestingEnabled)) = value;
			}
		}

		// Token: 0x170030AF RID: 12463
		// (get) Token: 0x0600A16E RID: 41326 RVA: 0x002B0550 File Offset: 0x002AE750
		// (set) Token: 0x0600A16F RID: 41327 RVA: 0x0004A170 File Offset: 0x00048370
		public unsafe float currentPursuitLevelDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_currentPursuitLevelDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_currentPursuitLevelDuration)) = value;
			}
		}

		// Token: 0x170030B0 RID: 12464
		// (get) Token: 0x0600A170 RID: 41328 RVA: 0x002B0578 File Offset: 0x002AE778
		// (set) Token: 0x0600A171 RID: 41329 RVA: 0x0004A18B File Offset: 0x0004838B
		public unsafe float timeWithinArrestRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_timeWithinArrestRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_timeWithinArrestRange)) = value;
			}
		}

		// Token: 0x170030B1 RID: 12465
		// (get) Token: 0x0600A172 RID: 41330 RVA: 0x002B05A0 File Offset: 0x002AE7A0
		// (set) Token: 0x0600A173 RID: 41331 RVA: 0x0004A1A6 File Offset: 0x000483A6
		public unsafe float distanceOnPursuitStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_distanceOnPursuitStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_distanceOnPursuitStart)) = value;
			}
		}

		// Token: 0x170030B2 RID: 12466
		// (get) Token: 0x0600A174 RID: 41332 RVA: 0x002B05C8 File Offset: 0x002AE7C8
		// (set) Token: 0x0600A175 RID: 41333 RVA: 0x0004A1C1 File Offset: 0x000483C1
		public unsafe PoliceOfficer officer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_officer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_officer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030B3 RID: 12467
		// (get) Token: 0x0600A176 RID: 41334 RVA: 0x002B05F8 File Offset: 0x002AE7F8
		// (set) Token: 0x0600A177 RID: 41335 RVA: 0x0004A1E0 File Offset: 0x000483E0
		public unsafe bool targetWasDrivingOnPursuitStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_targetWasDrivingOnPursuitStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_targetWasDrivingOnPursuitStart)) = value;
			}
		}

		// Token: 0x170030B4 RID: 12468
		// (get) Token: 0x0600A178 RID: 41336 RVA: 0x002B0620 File Offset: 0x002AE820
		// (set) Token: 0x0600A179 RID: 41337 RVA: 0x0004A1FB File Offset: 0x000483FB
		public unsafe bool wasInArrestCircleLastFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_wasInArrestCircleLastFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_wasInArrestCircleLastFrame)) = value;
			}
		}

		// Token: 0x170030B5 RID: 12469
		// (get) Token: 0x0600A17A RID: 41338 RVA: 0x002B0648 File Offset: 0x002AE848
		// (set) Token: 0x0600A17B RID: 41339 RVA: 0x0004A216 File Offset: 0x00048416
		public unsafe int leaveArrestCircleCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_leaveArrestCircleCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_leaveArrestCircleCount)) = value;
			}
		}

		// Token: 0x170030B6 RID: 12470
		// (get) Token: 0x0600A17C RID: 41340 RVA: 0x002B0670 File Offset: 0x002AE870
		// (set) Token: 0x0600A17D RID: 41341 RVA: 0x0004A231 File Offset: 0x00048431
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170030B7 RID: 12471
		// (get) Token: 0x0600A17E RID: 41342 RVA: 0x002B0698 File Offset: 0x002AE898
		// (set) Token: 0x0600A17F RID: 41343 RVA: 0x0004A24C File Offset: 0x0004844C
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006F4F RID: 28495
		private static readonly IntPtr NativeFieldInfoPtr_ARREST_RANGE;

		// Token: 0x04006F50 RID: 28496
		private static readonly IntPtr NativeFieldInfoPtr_ARREST_TIME;

		// Token: 0x04006F51 RID: 28497
		private static readonly IntPtr NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME;

		// Token: 0x04006F52 RID: 28498
		private static readonly IntPtr NativeFieldInfoPtr_MOVE_SPEED_INVESTIGATING;

		// Token: 0x04006F53 RID: 28499
		private static readonly IntPtr NativeFieldInfoPtr_MOVE_SPEED_ARRESTING;

		// Token: 0x04006F54 RID: 28500
		private static readonly IntPtr NativeFieldInfoPtr_MOVE_SPEED_CHASE;

		// Token: 0x04006F55 RID: 28501
		private static readonly IntPtr NativeFieldInfoPtr_CHASE_SPEED_DISTANCE_THRESHOLD;

		// Token: 0x04006F56 RID: 28502
		private static readonly IntPtr NativeFieldInfoPtr_ARREST_MAX_DISTANCE;

		// Token: 0x04006F57 RID: 28503
		private static readonly IntPtr NativeFieldInfoPtr_LEAVE_ARREST_CIRCLE_LIMIT;

		// Token: 0x04006F58 RID: 28504
		private static readonly IntPtr NativeFieldInfoPtr__TargetPlayer_k__BackingField;

		// Token: 0x04006F59 RID: 28505
		private static readonly IntPtr NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance;

		// Token: 0x04006F5A RID: 28506
		private static readonly IntPtr NativeFieldInfoPtr_ArrestCircle_MaxOpacity;

		// Token: 0x04006F5B RID: 28507
		private static readonly IntPtr NativeFieldInfoPtr_Weapon_Baton;

		// Token: 0x04006F5C RID: 28508
		private static readonly IntPtr NativeFieldInfoPtr_Weapon_Taser;

		// Token: 0x04006F5D RID: 28509
		private static readonly IntPtr NativeFieldInfoPtr_Weapon_Gun;

		// Token: 0x04006F5E RID: 28510
		private static readonly IntPtr NativeFieldInfoPtr_arrestingEnabled;

		// Token: 0x04006F5F RID: 28511
		private static readonly IntPtr NativeFieldInfoPtr_currentPursuitLevelDuration;

		// Token: 0x04006F60 RID: 28512
		private static readonly IntPtr NativeFieldInfoPtr_timeWithinArrestRange;

		// Token: 0x04006F61 RID: 28513
		private static readonly IntPtr NativeFieldInfoPtr_distanceOnPursuitStart;

		// Token: 0x04006F62 RID: 28514
		private static readonly IntPtr NativeFieldInfoPtr_officer;

		// Token: 0x04006F63 RID: 28515
		private static readonly IntPtr NativeFieldInfoPtr_targetWasDrivingOnPursuitStart;

		// Token: 0x04006F64 RID: 28516
		private static readonly IntPtr NativeFieldInfoPtr_wasInArrestCircleLastFrame;

		// Token: 0x04006F65 RID: 28517
		private static readonly IntPtr NativeFieldInfoPtr_leaveArrestCircleCount;

		// Token: 0x04006F66 RID: 28518
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006F67 RID: 28519
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006F68 RID: 28520
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0;

		// Token: 0x04006F69 RID: 28521
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0;

		// Token: 0x04006F6A RID: 28522
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04006F6B RID: 28523
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04006F6C RID: 28524
		private static readonly IntPtr NativeMethodInfoPtr_SetTarget_Protected_Virtual_Void_NetworkObject_0;

		// Token: 0x04006F6D RID: 28525
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

		// Token: 0x04006F6E RID: 28526
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x04006F6F RID: 28527
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04006F70 RID: 28528
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x04006F71 RID: 28529
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0;

		// Token: 0x04006F72 RID: 28530
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetValid_Protected_Virtual_Boolean_0;

		// Token: 0x04006F73 RID: 28531
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInvestigatingBehaviour_Protected_Virtual_New_Void_0;

		// Token: 0x04006F74 RID: 28532
		private static readonly IntPtr NativeMethodInfoPtr_UpdateArrestBehaviour_Protected_Virtual_New_Void_0;

		// Token: 0x04006F75 RID: 28533
		private static readonly IntPtr NativeMethodInfoPtr_UpdateNonLethalBehaviour_Protected_Virtual_New_Void_0;

		// Token: 0x04006F76 RID: 28534
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLethalBehaviour_Protected_Virtual_New_Void_0;

		// Token: 0x04006F77 RID: 28535
		private static readonly IntPtr NativeMethodInfoPtr_OnCurrentWeaponChanged_Protected_Virtual_Void_AvatarWeapon_0;

		// Token: 0x04006F78 RID: 28536
		private static readonly IntPtr NativeMethodInfoPtr_GetIdealRangedWeaponDistance_Protected_Virtual_Single_0;

		// Token: 0x04006F79 RID: 28537
		private static readonly IntPtr NativeMethodInfoPtr_UpdateArrest_Private_Void_Single_0;

		// Token: 0x04006F7A RID: 28538
		private static readonly IntPtr NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0;

		// Token: 0x04006F7B RID: 28539
		private static readonly IntPtr NativeMethodInfoPtr_EndCombat_Protected_Virtual_Void_1;

		// Token: 0x04006F7C RID: 28540
		private static readonly IntPtr NativeMethodInfoPtr_UpdateArrestCircle_Protected_Virtual_New_Void_0;

		// Token: 0x04006F7D RID: 28541
		private static readonly IntPtr NativeMethodInfoPtr_ResetArrestProgress_Public_Void_0;

		// Token: 0x04006F7E RID: 28542
		private static readonly IntPtr NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0;

		// Token: 0x04006F7F RID: 28543
		private static readonly IntPtr NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0;

		// Token: 0x04006F80 RID: 28544
		private static readonly IntPtr NativeMethodInfoPtr_OnThirdPartyVisionEvent_Private_Void_VisionEventReceipt_0;

		// Token: 0x04006F81 RID: 28545
		private static readonly IntPtr NativeMethodInfoPtr_TargetResighted_Protected_Virtual_Void_1;

		// Token: 0x04006F82 RID: 28546
		private static readonly IntPtr NativeMethodInfoPtr_TargetSpotted_Protected_Virtual_Void_1;

		// Token: 0x04006F83 RID: 28547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006F84 RID: 28548
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006F85 RID: 28549
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006F86 RID: 28550
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006F87 RID: 28551
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000C6A RID: 3178
		[OriginalName("Assembly-CSharp.dll", "", "EPursuitAction")]
		public enum EPursuitAction
		{
			// Token: 0x0400A367 RID: 41831
			None,
			// Token: 0x0400A368 RID: 41832
			Move,
			// Token: 0x0400A369 RID: 41833
			Shoot,
			// Token: 0x0400A36A RID: 41834
			MoveAndShoot
		}
	}
}
