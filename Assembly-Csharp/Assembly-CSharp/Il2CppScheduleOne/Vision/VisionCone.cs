using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.UI.WorldspacePopup;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x0200019C RID: 412
	public class VisionCone : NetworkBehaviour
	{
		// Token: 0x06002969 RID: 10601 RVA: 0x00103F00 File Offset: 0x00102100
		// Note: this type is marked as 'beforefieldinit'.
		static VisionCone()
		{
			Il2CppClassPointerStore<VisionCone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "VisionCone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionCone>.NativeClassPtr);
			VisionCone.NativeFieldInfoPtr_VISION_UPDATE_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "VISION_UPDATE_INTERVAL");
			VisionCone.NativeFieldInfoPtr_MinVisionDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "MinVisionDelta");
			VisionCone.NativeFieldInfoPtr_ExclamationSoundCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "ExclamationSoundCooldown");
			VisionCone.NativeFieldInfoPtr_TimeOnLastExclamationSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "TimeOnLastExclamationSound");
			VisionCone.NativeFieldInfoPtr_UniversalAttentivenessScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "UniversalAttentivenessScale");
			VisionCone.NativeFieldInfoPtr_UniversalMemoryScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "UniversalMemoryScale");
			VisionCone.NativeFieldInfoPtr_HorizontalFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "HorizontalFOV");
			VisionCone.NativeFieldInfoPtr_VerticalFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "VerticalFOV");
			VisionCone.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "Range");
			VisionCone.NativeFieldInfoPtr_MinorWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "MinorWidth");
			VisionCone.NativeFieldInfoPtr_MinorHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "MinorHeight");
			VisionCone.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "DEBUG");
			VisionCone.NativeFieldInfoPtr_VisionOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "VisionOrigin");
			VisionCone.NativeFieldInfoPtr_VisionFalloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "VisionFalloff");
			VisionCone.NativeFieldInfoPtr_VisibilityBlockingLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "VisibilityBlockingLayers");
			VisionCone.NativeFieldInfoPtr_RangeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "RangeMultiplier");
			VisionCone.NativeFieldInfoPtr_DefaultStatesOfInterest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "DefaultStatesOfInterest");
			VisionCone.NativeFieldInfoPtr_Attentiveness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "Attentiveness");
			VisionCone.NativeFieldInfoPtr_Memory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "Memory");
			VisionCone.NativeFieldInfoPtr_UseTremoloSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "UseTremoloSound");
			VisionCone.NativeFieldInfoPtr_WorldspaceIconsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "WorldspaceIconsEnabled");
			VisionCone.NativeFieldInfoPtr_QuestionMarkPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "QuestionMarkPopup");
			VisionCone.NativeFieldInfoPtr_ExclamationPointPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "ExclamationPointPopup");
			VisionCone.NativeFieldInfoPtr_ExclamationSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "ExclamationSound");
			VisionCone.NativeFieldInfoPtr_onVisionEventStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "onVisionEventStarted");
			VisionCone.NativeFieldInfoPtr_onVisionEventHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "onVisionEventHalf");
			VisionCone.NativeFieldInfoPtr_onVisionEventFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "onVisionEventFull");
			VisionCone.NativeFieldInfoPtr_onVisionEventExpired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "onVisionEventExpired");
			VisionCone.NativeFieldInfoPtr_sightablesOfInterest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "sightablesOfInterest");
			VisionCone.NativeFieldInfoPtr_sightableDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "sightableDatas");
			VisionCone.NativeFieldInfoPtr_stateSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "stateSettings");
			VisionCone.NativeFieldInfoPtr_activeVisionEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "activeVisionEvents");
			VisionCone.NativeFieldInfoPtr_cachedVisionEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "cachedVisionEvents");
			VisionCone.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "npc");
			VisionCone.NativeFieldInfoPtr_noticeGeneralCrime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "noticeGeneralCrime");
			VisionCone.NativeFieldInfoPtr_sightablesSeenThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "sightablesSeenThisFrame");
			VisionCone.NativeFieldInfoPtr_toRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "toRemove");
			VisionCone.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Vision.VisionConeAssembly-CSharp.dll_Excuted");
			VisionCone.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Vision.VisionConeAssembly-CSharp.dll_Excuted");
			VisionCone.NativeMethodInfoPtr_get_effectiveRange_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668597);
			VisionCone.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668598);
			VisionCone.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668599);
			VisionCone.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668600);
			VisionCone.NativeMethodInfoPtr_VisionUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668601);
			VisionCone.NativeMethodInfoPtr_UpdateEvents_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668602);
			VisionCone.NativeMethodInfoPtr_UpdateVision_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668603);
			VisionCone.NativeMethodInfoPtr_EventReachedZero_Public_Virtual_New_Void_VisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668604);
			VisionCone.NativeMethodInfoPtr_EventHalfNoticed_Public_Virtual_New_Void_VisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668605);
			VisionCone.NativeMethodInfoPtr_EventFullyNoticed_Public_Virtual_New_Void_VisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668606);
			VisionCone.NativeMethodInfoPtr_SendEventReceipt_Public_Void_VisionEventReceipt_EEventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668607);
			VisionCone.NativeMethodInfoPtr_ReceiveEventReceipt_Public_Virtual_New_Void_VisionEventReceipt_EEventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668608);
			VisionCone.NativeMethodInfoPtr_AddSightableOfInterest_Public_Void_ISightable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668609);
			VisionCone.NativeMethodInfoPtr_RemoveSightableOfInterest_Public_Void_ISightable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668610);
			VisionCone.NativeMethodInfoPtr_SetSightableStateEnabled_Public_Void_ISightable_EVisualState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668611);
			VisionCone.NativeMethodInfoPtr_PrintSightableStates_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668612);
			VisionCone.NativeMethodInfoPtr_IsPointWithinSight_Public_Virtual_New_Boolean_Vector3_Boolean_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668613);
			VisionCone.NativeMethodInfoPtr_GetEvent_Public_VisionEvent_ISightable_EntityVisualState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668614);
			VisionCone.NativeMethodInfoPtr_IsPlayerVisible_Public_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668615);
			VisionCone.NativeMethodInfoPtr_WasSightableVisibleThisFrame_Public_Boolean_ISightable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668616);
			VisionCone.NativeMethodInfoPtr_IsTargetVisible_Public_Boolean_ISightable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668617);
			VisionCone.NativeMethodInfoPtr_GetPlayerVisibility_Public_Single_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668618);
			VisionCone.NativeMethodInfoPtr_IsPlayerVisible_Public_Boolean_Player_byref_SightableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668619);
			VisionCone.NativeMethodInfoPtr_SetNoticePlayerCrimes_Public_Virtual_New_Void_Player_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668620);
			VisionCone.NativeMethodInfoPtr_OnDie_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668621);
			VisionCone.NativeMethodInfoPtr_ClearEvents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668622);
			VisionCone.NativeMethodInfoPtr_GetFrustumVertices_Private_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668623);
			VisionCone.NativeMethodInfoPtr_GetFrustumPlanes_Private_Il2CppStructArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668624);
			VisionCone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668625);
			VisionCone.NativeMethodInfoPtr_Method_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668627);
			VisionCone.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668628);
			VisionCone.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668629);
			VisionCone.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668630);
			VisionCone.NativeMethodInfoPtr_RpcWriter___Server_SendEventReceipt_3486014028_Private_Void_VisionEventReceipt_EEventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668631);
			VisionCone.NativeMethodInfoPtr_RpcLogic___SendEventReceipt_3486014028_Public_Void_VisionEventReceipt_EEventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668632);
			VisionCone.NativeMethodInfoPtr_RpcReader___Server_SendEventReceipt_3486014028_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668633);
			VisionCone.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEventReceipt_3486014028_Private_Void_VisionEventReceipt_EEventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668634);
			VisionCone.NativeMethodInfoPtr_RpcLogic___ReceiveEventReceipt_3486014028_Public_Virtual_New_Void_VisionEventReceipt_EEventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668635);
			VisionCone.NativeMethodInfoPtr_RpcReader___Observers_ReceiveEventReceipt_3486014028_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668636);
			VisionCone.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100668637);
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x0600296A RID: 10602 RVA: 0x0010455C File Offset: 0x0010275C
		public unsafe float effectiveRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_get_effectiveRange_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x00104598 File Offset: 0x00102798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122801, XrefRangeEnd = 122802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x001045D4 File Offset: 0x001027D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122802, XrefRangeEnd = 122807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x00104608 File Offset: 0x00102808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122807, XrefRangeEnd = 122812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x0010463C File Offset: 0x0010283C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122812, XrefRangeEnd = 122813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void VisionUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_VisionUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x00104678 File Offset: 0x00102878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122813, XrefRangeEnd = 122941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateEvents(float tickTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tickTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_UpdateEvents_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x001046C4 File Offset: 0x001028C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122941, XrefRangeEnd = 123062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateVision(float tickTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tickTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_UpdateVision_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x00104710 File Offset: 0x00102910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123062, XrefRangeEnd = 123075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EventReachedZero(VisionEvent _event)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_event);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_EventReachedZero_Public_Virtual_New_Void_VisionEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x00104760 File Offset: 0x00102960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123075, XrefRangeEnd = 123085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EventHalfNoticed(VisionEvent _event)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_event);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_EventHalfNoticed_Public_Virtual_New_Void_VisionEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x001047B0 File Offset: 0x001029B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123085, XrefRangeEnd = 123121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EventFullyNoticed(VisionEvent _event)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_event);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_EventFullyNoticed_Public_Virtual_New_Void_VisionEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x00104800 File Offset: 0x00102A00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 123143, RefRangeEnd = 123146, XrefRangeStart = 123121, XrefRangeEnd = 123143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendEventReceipt(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_SendEventReceipt_Public_Void_VisionEventReceipt_EEventLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x00104850 File Offset: 0x00102A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123146, XrefRangeEnd = 123169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReceiveEventReceipt(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_ReceiveEventReceipt_Public_Virtual_New_Void_VisionEventReceipt_EEventLevel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x001048AC File Offset: 0x00102AAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123175, RefRangeEnd = 123176, XrefRangeStart = 123169, XrefRangeEnd = 123175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSightableOfInterest(ISightable s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_AddSightableOfInterest_Public_Void_ISightable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x001048F0 File Offset: 0x00102AF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123184, RefRangeEnd = 123185, XrefRangeStart = 123176, XrefRangeEnd = 123184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSightableOfInterest(ISightable s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_RemoveSightableOfInterest_Public_Void_ISightable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x00104934 File Offset: 0x00102B34
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 123194, RefRangeEnd = 123207, XrefRangeStart = 123185, XrefRangeEnd = 123194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSightableStateEnabled(ISightable sightable, EVisualState state, bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sightable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_SetSightableStateEnabled_Public_Void_ISightable_EVisualState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x00104994 File Offset: 0x00102B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123207, XrefRangeEnd = 123275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintSightableStates()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_PrintSightableStates_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x001049C8 File Offset: 0x00102BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123275, XrefRangeEnd = 123313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsPointWithinSight(Vector3 point, bool ignoreLoS = false, LandVehicle vehicleToIgnore = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreLoS;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicleToIgnore);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_IsPointWithinSight_Public_Virtual_New_Boolean_Vector3_Boolean_LandVehicle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x00104A3C File Offset: 0x00102C3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123329, RefRangeEnd = 123330, XrefRangeStart = 123313, XrefRangeEnd = 123329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisionEvent GetEvent(ISightable target, EntityVisualState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_GetEvent_Public_VisionEvent_ISightable_EntityVisualState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisionEvent>(intPtr3) : null;
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x00104AA0 File Offset: 0x00102CA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 123334, RefRangeEnd = 123337, XrefRangeStart = 123330, XrefRangeEnd = 123334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerVisible(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_IsPlayerVisible_Public_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x00104AF0 File Offset: 0x00102CF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 123334, RefRangeEnd = 123337, XrefRangeStart = 123334, XrefRangeEnd = 123337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WasSightableVisibleThisFrame(ISightable sightable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sightable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_WasSightableVisibleThisFrame_Public_Boolean_ISightable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x00104B40 File Offset: 0x00102D40
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 123346, RefRangeEnd = 123354, XrefRangeStart = 123337, XrefRangeEnd = 123346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetVisible(ISightable target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_IsTargetVisible_Public_Boolean_ISightable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x00104B90 File Offset: 0x00102D90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123364, RefRangeEnd = 123366, XrefRangeStart = 123354, XrefRangeEnd = 123364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPlayerVisibility(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_GetPlayerVisibility_Public_Single_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x00104BE0 File Offset: 0x00102DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123366, XrefRangeEnd = 123371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerVisible(Player player, out VisionCone.SightableData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_IsPlayerVisible_Public_Boolean_Player_byref_SightableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : new VisionCone.SightableData(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x00104C50 File Offset: 0x00102E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123371, XrefRangeEnd = 123377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetNoticePlayerCrimes(Player player, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_SetNoticePlayerCrimes_Public_Virtual_New_Void_Player_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x00104CAC File Offset: 0x00102EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123377, XrefRangeEnd = 123378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDie()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_OnDie_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x00104CE0 File Offset: 0x00102EE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 123391, RefRangeEnd = 123394, XrefRangeStart = 123378, XrefRangeEnd = 123391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_ClearEvents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x00104D14 File Offset: 0x00102F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123394, XrefRangeEnd = 123416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Vector3> GetFrustumVertices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_GetFrustumVertices_Private_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x00104D54 File Offset: 0x00102F54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123437, RefRangeEnd = 123438, XrefRangeStart = 123416, XrefRangeEnd = 123437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Plane> GetFrustumPlanes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_GetFrustumPlanes_Private_Il2CppStructArray_1_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Plane>>(intPtr3) : null;
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x00104D94 File Offset: 0x00102F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123438, XrefRangeEnd = 123489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisionCone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionCone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x00104DD0 File Offset: 0x00102FD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123515, RefRangeEnd = 123516, XrefRangeStart = 123489, XrefRangeEnd = 123515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_Player_0(Player plr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(plr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_Method_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x00104E14 File Offset: 0x00103014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123516, XrefRangeEnd = 123530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x00104E50 File Offset: 0x00103050
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x00104E8C File Offset: 0x0010308C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x00104EC8 File Offset: 0x001030C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123530, XrefRangeEnd = 123541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_RpcWriter___Server_SendEventReceipt_3486014028_Private_Void_VisionEventReceipt_EEventLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x00104F18 File Offset: 0x00103118
		[CallerCount(0)]
		public unsafe void RpcLogic___SendEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_RpcLogic___SendEventReceipt_3486014028_Public_Void_VisionEventReceipt_EEventLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x00104F68 File Offset: 0x00103168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123541, XrefRangeEnd = 123545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendEventReceipt_3486014028(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_RpcReader___Server_SendEventReceipt_3486014028_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x00104FCC File Offset: 0x001031CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123545, XrefRangeEnd = 123556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEventReceipt_3486014028_Private_Void_VisionEventReceipt_EEventLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x0010501C File Offset: 0x0010321C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123556, RefRangeEnd = 123558, XrefRangeStart = 123556, XrefRangeEnd = 123556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___ReceiveEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_RpcLogic___ReceiveEventReceipt_3486014028_Public_Virtual_New_Void_VisionEventReceipt_EEventLevel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x00105078 File Offset: 0x00103278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123558, XrefRangeEnd = 123563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveEventReceipt_3486014028(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_RpcReader___Observers_ReceiveEventReceipt_3486014028_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x001050C8 File Offset: 0x001032C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123607, RefRangeEnd = 123608, XrefRangeStart = 123563, XrefRangeEnd = 123607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x00015B01 File Offset: 0x00013D01
		public VisionCone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06002993 RID: 10643 RVA: 0x00105104 File Offset: 0x00103304
		// (set) Token: 0x06002994 RID: 10644 RVA: 0x00015B0A File Offset: 0x00013D0A
		public unsafe static float VISION_UPDATE_INTERVAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VisionCone.NativeFieldInfoPtr_VISION_UPDATE_INTERVAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisionCone.NativeFieldInfoPtr_VISION_UPDATE_INTERVAL, (void*)(&value));
			}
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x06002995 RID: 10645 RVA: 0x00105120 File Offset: 0x00103320
		// (set) Token: 0x06002996 RID: 10646 RVA: 0x00015B18 File Offset: 0x00013D18
		public unsafe static float MinVisionDelta
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VisionCone.NativeFieldInfoPtr_MinVisionDelta, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisionCone.NativeFieldInfoPtr_MinVisionDelta, (void*)(&value));
			}
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x06002997 RID: 10647 RVA: 0x0010513C File Offset: 0x0010333C
		// (set) Token: 0x06002998 RID: 10648 RVA: 0x00015B26 File Offset: 0x00013D26
		public unsafe static float ExclamationSoundCooldown
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VisionCone.NativeFieldInfoPtr_ExclamationSoundCooldown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisionCone.NativeFieldInfoPtr_ExclamationSoundCooldown, (void*)(&value));
			}
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06002999 RID: 10649 RVA: 0x00105158 File Offset: 0x00103358
		// (set) Token: 0x0600299A RID: 10650 RVA: 0x00015B34 File Offset: 0x00013D34
		public unsafe static float TimeOnLastExclamationSound
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VisionCone.NativeFieldInfoPtr_TimeOnLastExclamationSound, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisionCone.NativeFieldInfoPtr_TimeOnLastExclamationSound, (void*)(&value));
			}
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x0600299B RID: 10651 RVA: 0x00105174 File Offset: 0x00103374
		// (set) Token: 0x0600299C RID: 10652 RVA: 0x00015B42 File Offset: 0x00013D42
		public unsafe static float UniversalAttentivenessScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VisionCone.NativeFieldInfoPtr_UniversalAttentivenessScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisionCone.NativeFieldInfoPtr_UniversalAttentivenessScale, (void*)(&value));
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x0600299D RID: 10653 RVA: 0x00105190 File Offset: 0x00103390
		// (set) Token: 0x0600299E RID: 10654 RVA: 0x00015B50 File Offset: 0x00013D50
		public unsafe static float UniversalMemoryScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VisionCone.NativeFieldInfoPtr_UniversalMemoryScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisionCone.NativeFieldInfoPtr_UniversalMemoryScale, (void*)(&value));
			}
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x0600299F RID: 10655 RVA: 0x001051AC File Offset: 0x001033AC
		// (set) Token: 0x060029A0 RID: 10656 RVA: 0x00015B5E File Offset: 0x00013D5E
		public unsafe static float HorizontalFOV
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VisionCone.NativeFieldInfoPtr_HorizontalFOV, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisionCone.NativeFieldInfoPtr_HorizontalFOV, (void*)(&value));
			}
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x060029A1 RID: 10657 RVA: 0x001051C8 File Offset: 0x001033C8
		// (set) Token: 0x060029A2 RID: 10658 RVA: 0x00015B6C File Offset: 0x00013D6C
		public unsafe static float VerticalFOV
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VisionCone.NativeFieldInfoPtr_VerticalFOV, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisionCone.NativeFieldInfoPtr_VerticalFOV, (void*)(&value));
			}
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x060029A3 RID: 10659 RVA: 0x001051E4 File Offset: 0x001033E4
		// (set) Token: 0x060029A4 RID: 10660 RVA: 0x00015B7A File Offset: 0x00013D7A
		public unsafe static float Range
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VisionCone.NativeFieldInfoPtr_Range, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisionCone.NativeFieldInfoPtr_Range, (void*)(&value));
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x060029A5 RID: 10661 RVA: 0x00105200 File Offset: 0x00103400
		// (set) Token: 0x060029A6 RID: 10662 RVA: 0x00015B88 File Offset: 0x00013D88
		public unsafe static float MinorWidth
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VisionCone.NativeFieldInfoPtr_MinorWidth, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisionCone.NativeFieldInfoPtr_MinorWidth, (void*)(&value));
			}
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x060029A7 RID: 10663 RVA: 0x0010521C File Offset: 0x0010341C
		// (set) Token: 0x060029A8 RID: 10664 RVA: 0x00015B96 File Offset: 0x00013D96
		public unsafe static float MinorHeight
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VisionCone.NativeFieldInfoPtr_MinorHeight, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisionCone.NativeFieldInfoPtr_MinorHeight, (void*)(&value));
			}
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x060029A9 RID: 10665 RVA: 0x00105238 File Offset: 0x00103438
		// (set) Token: 0x060029AA RID: 10666 RVA: 0x00015BA4 File Offset: 0x00013DA4
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x060029AB RID: 10667 RVA: 0x00105260 File Offset: 0x00103460
		// (set) Token: 0x060029AC RID: 10668 RVA: 0x00015BBF File Offset: 0x00013DBF
		public unsafe Transform VisionOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VisionOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VisionOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x060029AD RID: 10669 RVA: 0x00105290 File Offset: 0x00103490
		// (set) Token: 0x060029AE RID: 10670 RVA: 0x00015BDE File Offset: 0x00013DDE
		public unsafe AnimationCurve VisionFalloff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VisionFalloff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VisionFalloff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x060029AF RID: 10671 RVA: 0x001052C0 File Offset: 0x001034C0
		// (set) Token: 0x060029B0 RID: 10672 RVA: 0x00015BFD File Offset: 0x00013DFD
		public unsafe LayerMask VisibilityBlockingLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VisibilityBlockingLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VisibilityBlockingLayers)) = value;
			}
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x060029B1 RID: 10673 RVA: 0x001052E8 File Offset: 0x001034E8
		// (set) Token: 0x060029B2 RID: 10674 RVA: 0x00015C18 File Offset: 0x00013E18
		public unsafe float RangeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_RangeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_RangeMultiplier)) = value;
			}
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x060029B3 RID: 10675 RVA: 0x00105310 File Offset: 0x00103510
		// (set) Token: 0x060029B4 RID: 10676 RVA: 0x00015C33 File Offset: 0x00013E33
		public unsafe List<VisionCone.StateContainer> DefaultStatesOfInterest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_DefaultStatesOfInterest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisionCone.StateContainer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_DefaultStatesOfInterest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x060029B5 RID: 10677 RVA: 0x00105340 File Offset: 0x00103540
		// (set) Token: 0x060029B6 RID: 10678 RVA: 0x00015C52 File Offset: 0x00013E52
		public unsafe float Attentiveness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_Attentiveness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_Attentiveness)) = value;
			}
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x060029B7 RID: 10679 RVA: 0x00105368 File Offset: 0x00103568
		// (set) Token: 0x060029B8 RID: 10680 RVA: 0x00015C6D File Offset: 0x00013E6D
		public unsafe float Memory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_Memory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_Memory)) = value;
			}
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x060029B9 RID: 10681 RVA: 0x00105390 File Offset: 0x00103590
		// (set) Token: 0x060029BA RID: 10682 RVA: 0x00015C88 File Offset: 0x00013E88
		public unsafe bool UseTremoloSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_UseTremoloSound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_UseTremoloSound)) = value;
			}
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x060029BB RID: 10683 RVA: 0x001053B8 File Offset: 0x001035B8
		// (set) Token: 0x060029BC RID: 10684 RVA: 0x00015CA3 File Offset: 0x00013EA3
		public unsafe bool WorldspaceIconsEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_WorldspaceIconsEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_WorldspaceIconsEnabled)) = value;
			}
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x060029BD RID: 10685 RVA: 0x001053E0 File Offset: 0x001035E0
		// (set) Token: 0x060029BE RID: 10686 RVA: 0x00015CBE File Offset: 0x00013EBE
		public unsafe WorldspacePopup QuestionMarkPopup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_QuestionMarkPopup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_QuestionMarkPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x060029BF RID: 10687 RVA: 0x00105410 File Offset: 0x00103610
		// (set) Token: 0x060029C0 RID: 10688 RVA: 0x00015CDD File Offset: 0x00013EDD
		public unsafe WorldspacePopup ExclamationPointPopup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_ExclamationPointPopup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_ExclamationPointPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x060029C1 RID: 10689 RVA: 0x00105440 File Offset: 0x00103640
		// (set) Token: 0x060029C2 RID: 10690 RVA: 0x00015CFC File Offset: 0x00013EFC
		public unsafe AudioSourceController ExclamationSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_ExclamationSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_ExclamationSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x060029C3 RID: 10691 RVA: 0x00105470 File Offset: 0x00103670
		// (set) Token: 0x060029C4 RID: 10692 RVA: 0x00015D1B File Offset: 0x00013F1B
		public unsafe VisionCone.EventStateChange onVisionEventStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventStarted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionCone.EventStateChange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventStarted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x060029C5 RID: 10693 RVA: 0x001054A0 File Offset: 0x001036A0
		// (set) Token: 0x060029C6 RID: 10694 RVA: 0x00015D3A File Offset: 0x00013F3A
		public unsafe VisionCone.EventStateChange onVisionEventHalf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventHalf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionCone.EventStateChange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventHalf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x060029C7 RID: 10695 RVA: 0x001054D0 File Offset: 0x001036D0
		// (set) Token: 0x060029C8 RID: 10696 RVA: 0x00015D59 File Offset: 0x00013F59
		public unsafe VisionCone.EventStateChange onVisionEventFull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventFull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionCone.EventStateChange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventFull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x060029C9 RID: 10697 RVA: 0x00105500 File Offset: 0x00103700
		// (set) Token: 0x060029CA RID: 10698 RVA: 0x00015D78 File Offset: 0x00013F78
		public unsafe VisionCone.EventStateChange onVisionEventExpired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventExpired);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionCone.EventStateChange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventExpired), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x060029CB RID: 10699 RVA: 0x00105530 File Offset: 0x00103730
		// (set) Token: 0x060029CC RID: 10700 RVA: 0x00015D97 File Offset: 0x00013F97
		public unsafe List<ISightable> sightablesOfInterest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_sightablesOfInterest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ISightable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_sightablesOfInterest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x060029CD RID: 10701 RVA: 0x00105560 File Offset: 0x00103760
		// (set) Token: 0x060029CE RID: 10702 RVA: 0x00015DB6 File Offset: 0x00013FB6
		public unsafe Dictionary<ISightable, VisionCone.SightableData> sightableDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_sightableDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ISightable, VisionCone.SightableData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_sightableDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x060029CF RID: 10703 RVA: 0x00105590 File Offset: 0x00103790
		// (set) Token: 0x060029D0 RID: 10704 RVA: 0x00015DD5 File Offset: 0x00013FD5
		public unsafe Dictionary<ISightable, Dictionary<EVisualState, VisionCone.StateContainer>> stateSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_stateSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ISightable, Dictionary<EVisualState, VisionCone.StateContainer>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_stateSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x060029D1 RID: 10705 RVA: 0x001055C0 File Offset: 0x001037C0
		// (set) Token: 0x060029D2 RID: 10706 RVA: 0x00015DF4 File Offset: 0x00013FF4
		public unsafe List<VisionEvent> activeVisionEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_activeVisionEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisionEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_activeVisionEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x060029D3 RID: 10707 RVA: 0x001055F0 File Offset: 0x001037F0
		// (set) Token: 0x060029D4 RID: 10708 RVA: 0x00015E13 File Offset: 0x00014013
		public unsafe List<VisionEvent> cachedVisionEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_cachedVisionEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisionEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_cachedVisionEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x060029D5 RID: 10709 RVA: 0x00105620 File Offset: 0x00103820
		// (set) Token: 0x060029D6 RID: 10710 RVA: 0x00015E32 File Offset: 0x00014032
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x060029D7 RID: 10711 RVA: 0x00105650 File Offset: 0x00103850
		// (set) Token: 0x060029D8 RID: 10712 RVA: 0x00015E51 File Offset: 0x00014051
		public unsafe bool noticeGeneralCrime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_noticeGeneralCrime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_noticeGeneralCrime)) = value;
			}
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x060029D9 RID: 10713 RVA: 0x00105678 File Offset: 0x00103878
		// (set) Token: 0x060029DA RID: 10714 RVA: 0x00015E6C File Offset: 0x0001406C
		public unsafe List<ISightable> sightablesSeenThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_sightablesSeenThisFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ISightable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_sightablesSeenThisFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x060029DB RID: 10715 RVA: 0x001056A8 File Offset: 0x001038A8
		// (set) Token: 0x060029DC RID: 10716 RVA: 0x00015E8B File Offset: 0x0001408B
		public unsafe List<ISightable> toRemove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_toRemove);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ISightable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_toRemove), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x060029DD RID: 10717 RVA: 0x001056D8 File Offset: 0x001038D8
		// (set) Token: 0x060029DE RID: 10718 RVA: 0x00015EAA File Offset: 0x000140AA
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x060029DF RID: 10719 RVA: 0x00105700 File Offset: 0x00103900
		// (set) Token: 0x060029E0 RID: 10720 RVA: 0x00015EC5 File Offset: 0x000140C5
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04001C81 RID: 7297
		private static readonly IntPtr NativeFieldInfoPtr_VISION_UPDATE_INTERVAL;

		// Token: 0x04001C82 RID: 7298
		private static readonly IntPtr NativeFieldInfoPtr_MinVisionDelta;

		// Token: 0x04001C83 RID: 7299
		private static readonly IntPtr NativeFieldInfoPtr_ExclamationSoundCooldown;

		// Token: 0x04001C84 RID: 7300
		private static readonly IntPtr NativeFieldInfoPtr_TimeOnLastExclamationSound;

		// Token: 0x04001C85 RID: 7301
		private static readonly IntPtr NativeFieldInfoPtr_UniversalAttentivenessScale;

		// Token: 0x04001C86 RID: 7302
		private static readonly IntPtr NativeFieldInfoPtr_UniversalMemoryScale;

		// Token: 0x04001C87 RID: 7303
		private static readonly IntPtr NativeFieldInfoPtr_HorizontalFOV;

		// Token: 0x04001C88 RID: 7304
		private static readonly IntPtr NativeFieldInfoPtr_VerticalFOV;

		// Token: 0x04001C89 RID: 7305
		private static readonly IntPtr NativeFieldInfoPtr_Range;

		// Token: 0x04001C8A RID: 7306
		private static readonly IntPtr NativeFieldInfoPtr_MinorWidth;

		// Token: 0x04001C8B RID: 7307
		private static readonly IntPtr NativeFieldInfoPtr_MinorHeight;

		// Token: 0x04001C8C RID: 7308
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04001C8D RID: 7309
		private static readonly IntPtr NativeFieldInfoPtr_VisionOrigin;

		// Token: 0x04001C8E RID: 7310
		private static readonly IntPtr NativeFieldInfoPtr_VisionFalloff;

		// Token: 0x04001C8F RID: 7311
		private static readonly IntPtr NativeFieldInfoPtr_VisibilityBlockingLayers;

		// Token: 0x04001C90 RID: 7312
		private static readonly IntPtr NativeFieldInfoPtr_RangeMultiplier;

		// Token: 0x04001C91 RID: 7313
		private static readonly IntPtr NativeFieldInfoPtr_DefaultStatesOfInterest;

		// Token: 0x04001C92 RID: 7314
		private static readonly IntPtr NativeFieldInfoPtr_Attentiveness;

		// Token: 0x04001C93 RID: 7315
		private static readonly IntPtr NativeFieldInfoPtr_Memory;

		// Token: 0x04001C94 RID: 7316
		private static readonly IntPtr NativeFieldInfoPtr_UseTremoloSound;

		// Token: 0x04001C95 RID: 7317
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceIconsEnabled;

		// Token: 0x04001C96 RID: 7318
		private static readonly IntPtr NativeFieldInfoPtr_QuestionMarkPopup;

		// Token: 0x04001C97 RID: 7319
		private static readonly IntPtr NativeFieldInfoPtr_ExclamationPointPopup;

		// Token: 0x04001C98 RID: 7320
		private static readonly IntPtr NativeFieldInfoPtr_ExclamationSound;

		// Token: 0x04001C99 RID: 7321
		private static readonly IntPtr NativeFieldInfoPtr_onVisionEventStarted;

		// Token: 0x04001C9A RID: 7322
		private static readonly IntPtr NativeFieldInfoPtr_onVisionEventHalf;

		// Token: 0x04001C9B RID: 7323
		private static readonly IntPtr NativeFieldInfoPtr_onVisionEventFull;

		// Token: 0x04001C9C RID: 7324
		private static readonly IntPtr NativeFieldInfoPtr_onVisionEventExpired;

		// Token: 0x04001C9D RID: 7325
		private static readonly IntPtr NativeFieldInfoPtr_sightablesOfInterest;

		// Token: 0x04001C9E RID: 7326
		private static readonly IntPtr NativeFieldInfoPtr_sightableDatas;

		// Token: 0x04001C9F RID: 7327
		private static readonly IntPtr NativeFieldInfoPtr_stateSettings;

		// Token: 0x04001CA0 RID: 7328
		private static readonly IntPtr NativeFieldInfoPtr_activeVisionEvents;

		// Token: 0x04001CA1 RID: 7329
		private static readonly IntPtr NativeFieldInfoPtr_cachedVisionEvents;

		// Token: 0x04001CA2 RID: 7330
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x04001CA3 RID: 7331
		private static readonly IntPtr NativeFieldInfoPtr_noticeGeneralCrime;

		// Token: 0x04001CA4 RID: 7332
		private static readonly IntPtr NativeFieldInfoPtr_sightablesSeenThisFrame;

		// Token: 0x04001CA5 RID: 7333
		private static readonly IntPtr NativeFieldInfoPtr_toRemove;

		// Token: 0x04001CA6 RID: 7334
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04001CA7 RID: 7335
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04001CA8 RID: 7336
		private static readonly IntPtr NativeMethodInfoPtr_get_effectiveRange_Protected_get_Single_0;

		// Token: 0x04001CA9 RID: 7337
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04001CAA RID: 7338
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001CAB RID: 7339
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04001CAC RID: 7340
		private static readonly IntPtr NativeMethodInfoPtr_VisionUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04001CAD RID: 7341
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEvents_Protected_Virtual_New_Void_Single_0;

		// Token: 0x04001CAE RID: 7342
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVision_Protected_Virtual_New_Void_Single_0;

		// Token: 0x04001CAF RID: 7343
		private static readonly IntPtr NativeMethodInfoPtr_EventReachedZero_Public_Virtual_New_Void_VisionEvent_0;

		// Token: 0x04001CB0 RID: 7344
		private static readonly IntPtr NativeMethodInfoPtr_EventHalfNoticed_Public_Virtual_New_Void_VisionEvent_0;

		// Token: 0x04001CB1 RID: 7345
		private static readonly IntPtr NativeMethodInfoPtr_EventFullyNoticed_Public_Virtual_New_Void_VisionEvent_0;

		// Token: 0x04001CB2 RID: 7346
		private static readonly IntPtr NativeMethodInfoPtr_SendEventReceipt_Public_Void_VisionEventReceipt_EEventLevel_0;

		// Token: 0x04001CB3 RID: 7347
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveEventReceipt_Public_Virtual_New_Void_VisionEventReceipt_EEventLevel_0;

		// Token: 0x04001CB4 RID: 7348
		private static readonly IntPtr NativeMethodInfoPtr_AddSightableOfInterest_Public_Void_ISightable_0;

		// Token: 0x04001CB5 RID: 7349
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSightableOfInterest_Public_Void_ISightable_0;

		// Token: 0x04001CB6 RID: 7350
		private static readonly IntPtr NativeMethodInfoPtr_SetSightableStateEnabled_Public_Void_ISightable_EVisualState_Boolean_0;

		// Token: 0x04001CB7 RID: 7351
		private static readonly IntPtr NativeMethodInfoPtr_PrintSightableStates_Public_Void_0;

		// Token: 0x04001CB8 RID: 7352
		private static readonly IntPtr NativeMethodInfoPtr_IsPointWithinSight_Public_Virtual_New_Boolean_Vector3_Boolean_LandVehicle_0;

		// Token: 0x04001CB9 RID: 7353
		private static readonly IntPtr NativeMethodInfoPtr_GetEvent_Public_VisionEvent_ISightable_EntityVisualState_0;

		// Token: 0x04001CBA RID: 7354
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayerVisible_Public_Boolean_Player_0;

		// Token: 0x04001CBB RID: 7355
		private static readonly IntPtr NativeMethodInfoPtr_WasSightableVisibleThisFrame_Public_Boolean_ISightable_0;

		// Token: 0x04001CBC RID: 7356
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetVisible_Public_Boolean_ISightable_0;

		// Token: 0x04001CBD RID: 7357
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerVisibility_Public_Single_Player_0;

		// Token: 0x04001CBE RID: 7358
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayerVisible_Public_Boolean_Player_byref_SightableData_0;

		// Token: 0x04001CBF RID: 7359
		private static readonly IntPtr NativeMethodInfoPtr_SetNoticePlayerCrimes_Public_Virtual_New_Void_Player_Boolean_0;

		// Token: 0x04001CC0 RID: 7360
		private static readonly IntPtr NativeMethodInfoPtr_OnDie_Private_Void_0;

		// Token: 0x04001CC1 RID: 7361
		private static readonly IntPtr NativeMethodInfoPtr_ClearEvents_Public_Void_0;

		// Token: 0x04001CC2 RID: 7362
		private static readonly IntPtr NativeMethodInfoPtr_GetFrustumVertices_Private_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04001CC3 RID: 7363
		private static readonly IntPtr NativeMethodInfoPtr_GetFrustumPlanes_Private_Il2CppStructArray_1_Plane_0;

		// Token: 0x04001CC4 RID: 7364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001CC5 RID: 7365
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Player_0;

		// Token: 0x04001CC6 RID: 7366
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04001CC7 RID: 7367
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04001CC8 RID: 7368
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04001CC9 RID: 7369
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendEventReceipt_3486014028_Private_Void_VisionEventReceipt_EEventLevel_0;

		// Token: 0x04001CCA RID: 7370
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendEventReceipt_3486014028_Public_Void_VisionEventReceipt_EEventLevel_0;

		// Token: 0x04001CCB RID: 7371
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendEventReceipt_3486014028_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04001CCC RID: 7372
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEventReceipt_3486014028_Private_Void_VisionEventReceipt_EEventLevel_0;

		// Token: 0x04001CCD RID: 7373
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveEventReceipt_3486014028_Public_Virtual_New_Void_VisionEventReceipt_EEventLevel_0;

		// Token: 0x04001CCE RID: 7374
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveEventReceipt_3486014028_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001CCF RID: 7375
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x0200099A RID: 2458
		[OriginalName("Assembly-CSharp.dll", "", "EEventLevel")]
		public enum EEventLevel
		{
			// Token: 0x04009554 RID: 38228
			Start,
			// Token: 0x04009555 RID: 38229
			Half,
			// Token: 0x04009556 RID: 38230
			Full,
			// Token: 0x04009557 RID: 38231
			Zero
		}

		// Token: 0x0200099B RID: 2459
		[Serializable]
		public class StateContainer : Il2CppSystem.Object
		{
			// Token: 0x0600DAA7 RID: 55975 RVA: 0x00363068 File Offset: 0x00361268
			// Note: this type is marked as 'beforefieldinit'.
			static StateContainer()
			{
				Il2CppClassPointerStore<VisionCone.StateContainer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "StateContainer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionCone.StateContainer>.NativeClassPtr);
				VisionCone.StateContainer.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.StateContainer>.NativeClassPtr, "state");
				VisionCone.StateContainer.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.StateContainer>.NativeClassPtr, "Enabled");
				VisionCone.StateContainer.NativeFieldInfoPtr_NoticeTimeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.StateContainer>.NativeClassPtr, "NoticeTimeMultiplier");
				VisionCone.StateContainer.NativeMethodInfoPtr_get_RequiredNoticeTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.StateContainer>.NativeClassPtr, 100668638);
				VisionCone.StateContainer.NativeMethodInfoPtr_GetCopy_Public_StateContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.StateContainer>.NativeClassPtr, 100668639);
				VisionCone.StateContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.StateContainer>.NativeClassPtr, 100668640);
			}

			// Token: 0x170042C4 RID: 17092
			// (get) Token: 0x0600DAA8 RID: 55976 RVA: 0x0036310C File Offset: 0x0036130C
			public unsafe float RequiredNoticeTime
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.StateContainer.NativeMethodInfoPtr_get_RequiredNoticeTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600DAA9 RID: 55977 RVA: 0x00363148 File Offset: 0x00361348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122796, XrefRangeEnd = 122800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VisionCone.StateContainer GetCopy()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.StateContainer.NativeMethodInfoPtr_GetCopy_Public_StateContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisionCone.StateContainer>(intPtr3) : null;
			}

			// Token: 0x0600DAAA RID: 55978 RVA: 0x00363188 File Offset: 0x00361388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122800, XrefRangeEnd = 122801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StateContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionCone.StateContainer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.StateContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAAB RID: 55979 RVA: 0x00066CCB File Offset: 0x00064ECB
			public StateContainer(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042C1 RID: 17089
			// (get) Token: 0x0600DAAC RID: 55980 RVA: 0x003631C4 File Offset: 0x003613C4
			// (set) Token: 0x0600DAAD RID: 55981 RVA: 0x00066CD4 File Offset: 0x00064ED4
			public unsafe EVisualState state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.StateContainer.NativeFieldInfoPtr_state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.StateContainer.NativeFieldInfoPtr_state)) = value;
				}
			}

			// Token: 0x170042C2 RID: 17090
			// (get) Token: 0x0600DAAE RID: 55982 RVA: 0x003631EC File Offset: 0x003613EC
			// (set) Token: 0x0600DAAF RID: 55983 RVA: 0x00066CEF File Offset: 0x00064EEF
			public unsafe bool Enabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.StateContainer.NativeFieldInfoPtr_Enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.StateContainer.NativeFieldInfoPtr_Enabled)) = value;
				}
			}

			// Token: 0x170042C3 RID: 17091
			// (get) Token: 0x0600DAB0 RID: 55984 RVA: 0x00363214 File Offset: 0x00361414
			// (set) Token: 0x0600DAB1 RID: 55985 RVA: 0x00066D0A File Offset: 0x00064F0A
			public unsafe float NoticeTimeMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.StateContainer.NativeFieldInfoPtr_NoticeTimeMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.StateContainer.NativeFieldInfoPtr_NoticeTimeMultiplier)) = value;
				}
			}

			// Token: 0x04009558 RID: 38232
			private static readonly IntPtr NativeFieldInfoPtr_state;

			// Token: 0x04009559 RID: 38233
			private static readonly IntPtr NativeFieldInfoPtr_Enabled;

			// Token: 0x0400955A RID: 38234
			private static readonly IntPtr NativeFieldInfoPtr_NoticeTimeMultiplier;

			// Token: 0x0400955B RID: 38235
			private static readonly IntPtr NativeMethodInfoPtr_get_RequiredNoticeTime_Public_get_Single_0;

			// Token: 0x0400955C RID: 38236
			private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_StateContainer_0;

			// Token: 0x0400955D RID: 38237
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200099C RID: 2460
		public class SightableData : Il2CppSystem.Object
		{
			// Token: 0x0600DAB2 RID: 55986 RVA: 0x0036323C File Offset: 0x0036143C
			// Note: this type is marked as 'beforefieldinit'.
			static SightableData()
			{
				Il2CppClassPointerStore<VisionCone.SightableData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "SightableData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionCone.SightableData>.NativeClassPtr);
				VisionCone.SightableData.NativeFieldInfoPtr_Sightable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.SightableData>.NativeClassPtr, "Sightable");
				VisionCone.SightableData.NativeFieldInfoPtr_VisionDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.SightableData>.NativeClassPtr, "VisionDelta");
				VisionCone.SightableData.NativeFieldInfoPtr_TimeVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.SightableData>.NativeClassPtr, "TimeVisible");
				VisionCone.SightableData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.SightableData>.NativeClassPtr, 100668641);
			}

			// Token: 0x0600DAB3 RID: 55987 RVA: 0x003632B8 File Offset: 0x003614B8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SightableData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionCone.SightableData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.SightableData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAB4 RID: 55988 RVA: 0x00066D25 File Offset: 0x00064F25
			public SightableData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042C5 RID: 17093
			// (get) Token: 0x0600DAB5 RID: 55989 RVA: 0x003632F4 File Offset: 0x003614F4
			// (set) Token: 0x0600DAB6 RID: 55990 RVA: 0x00066D2E File Offset: 0x00064F2E
			public unsafe ISightable Sightable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.SightableData.NativeFieldInfoPtr_Sightable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISightable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.SightableData.NativeFieldInfoPtr_Sightable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042C6 RID: 17094
			// (get) Token: 0x0600DAB7 RID: 55991 RVA: 0x00363324 File Offset: 0x00361524
			// (set) Token: 0x0600DAB8 RID: 55992 RVA: 0x00066D4D File Offset: 0x00064F4D
			public unsafe float VisionDelta
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.SightableData.NativeFieldInfoPtr_VisionDelta);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.SightableData.NativeFieldInfoPtr_VisionDelta)) = value;
				}
			}

			// Token: 0x170042C7 RID: 17095
			// (get) Token: 0x0600DAB9 RID: 55993 RVA: 0x0036334C File Offset: 0x0036154C
			// (set) Token: 0x0600DABA RID: 55994 RVA: 0x00066D68 File Offset: 0x00064F68
			public unsafe float TimeVisible
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.SightableData.NativeFieldInfoPtr_TimeVisible);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.SightableData.NativeFieldInfoPtr_TimeVisible)) = value;
				}
			}

			// Token: 0x0400955E RID: 38238
			private static readonly IntPtr NativeFieldInfoPtr_Sightable;

			// Token: 0x0400955F RID: 38239
			private static readonly IntPtr NativeFieldInfoPtr_VisionDelta;

			// Token: 0x04009560 RID: 38240
			private static readonly IntPtr NativeFieldInfoPtr_TimeVisible;

			// Token: 0x04009561 RID: 38241
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200099D RID: 2461
		public sealed class EventStateChange : MulticastDelegate
		{
			// Token: 0x0600DABB RID: 55995 RVA: 0x00363374 File Offset: 0x00361574
			// Note: this type is marked as 'beforefieldinit'.
			static EventStateChange()
			{
				Il2CppClassPointerStore<VisionCone.EventStateChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "EventStateChange");
				VisionCone.EventStateChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.EventStateChange>.NativeClassPtr, 100668642);
				VisionCone.EventStateChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.EventStateChange>.NativeClassPtr, 100668643);
				VisionCone.EventStateChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VisionEventReceipt_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.EventStateChange>.NativeClassPtr, 100668644);
				VisionCone.EventStateChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.EventStateChange>.NativeClassPtr, 100668645);
			}

			// Token: 0x0600DABC RID: 55996 RVA: 0x003633E8 File Offset: 0x003615E8
			[CallerCount(628)]
			[CachedScanResults(RefRangeStart = 71168, RefRangeEnd = 71796, XrefRangeStart = 71168, XrefRangeEnd = 71796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventStateChange(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionCone.EventStateChange>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.EventStateChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DABD RID: 55997 RVA: 0x00363444 File Offset: 0x00361644
			[CallerCount(0)]
			public unsafe void Invoke(VisionEventReceipt _event)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_event);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.EventStateChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DABE RID: 55998 RVA: 0x00363488 File Offset: 0x00361688
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 71797, RefRangeEnd = 71798, XrefRangeStart = 71797, XrefRangeEnd = 71798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(VisionEventReceipt _event, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_event);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.EventStateChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VisionEventReceipt_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600DABF RID: 55999 RVA: 0x003634FC File Offset: 0x003616FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.EventStateChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAC0 RID: 56000 RVA: 0x00066D83 File Offset: 0x00064F83
			public EventStateChange(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600DAC1 RID: 56001 RVA: 0x00066D8C File Offset: 0x00064F8C
			public static implicit operator VisionCone.EventStateChange(Action<VisionEventReceipt> A_0)
			{
				return DelegateSupport.ConvertDelegate<VisionCone.EventStateChange>(A_0);
			}

			// Token: 0x0600DAC2 RID: 56002 RVA: 0x00066D94 File Offset: 0x00064F94
			public static VisionCone.EventStateChange operator +(VisionCone.EventStateChange A_0, VisionCone.EventStateChange A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VisionCone.EventStateChange>();
			}

			// Token: 0x0600DAC3 RID: 56003 RVA: 0x00066DA2 File Offset: 0x00064FA2
			public static VisionCone.EventStateChange operator -(VisionCone.EventStateChange A_0, VisionCone.EventStateChange A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<VisionCone.EventStateChange>();
				}
				return result;
			}

			// Token: 0x04009562 RID: 38242
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04009563 RID: 38243
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VisionEventReceipt_0;

			// Token: 0x04009564 RID: 38244
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VisionEventReceipt_AsyncCallback_Object_0;

			// Token: 0x04009565 RID: 38245
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200099E RID: 2462
		[ObfuscatedName("ScheduleOne.Vision.VisionCone+<>c__DisplayClass59_0")]
		public sealed class __c__DisplayClass59_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DAC4 RID: 56004 RVA: 0x00363540 File Offset: 0x00361740
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass59_0()
			{
				Il2CppClassPointerStore<VisionCone.__c__DisplayClass59_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "<>c__DisplayClass59_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionCone.__c__DisplayClass59_0>.NativeClassPtr);
				VisionCone.__c__DisplayClass59_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.__c__DisplayClass59_0>.NativeClassPtr, "target");
				VisionCone.__c__DisplayClass59_0.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.__c__DisplayClass59_0>.NativeClassPtr, "state");
				VisionCone.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.__c__DisplayClass59_0>.NativeClassPtr, 100668646);
				VisionCone.__c__DisplayClass59_0.NativeMethodInfoPtr__GetEvent_b__0_Internal_Boolean_VisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.__c__DisplayClass59_0>.NativeClassPtr, 100668647);
			}

			// Token: 0x0600DAC5 RID: 56005 RVA: 0x003635BC File Offset: 0x003617BC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass59_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionCone.__c__DisplayClass59_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAC6 RID: 56006 RVA: 0x003635F8 File Offset: 0x003617F8
			[CallerCount(0)]
			public unsafe bool _GetEvent_b__0(VisionEvent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.__c__DisplayClass59_0.NativeMethodInfoPtr__GetEvent_b__0_Internal_Boolean_VisionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DAC7 RID: 56007 RVA: 0x00066DB3 File Offset: 0x00064FB3
			public __c__DisplayClass59_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042C8 RID: 17096
			// (get) Token: 0x0600DAC8 RID: 56008 RVA: 0x00363648 File Offset: 0x00361848
			// (set) Token: 0x0600DAC9 RID: 56009 RVA: 0x00066DBC File Offset: 0x00064FBC
			public unsafe ISightable target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.__c__DisplayClass59_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISightable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.__c__DisplayClass59_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042C9 RID: 17097
			// (get) Token: 0x0600DACA RID: 56010 RVA: 0x00363678 File Offset: 0x00361878
			// (set) Token: 0x0600DACB RID: 56011 RVA: 0x00066DDB File Offset: 0x00064FDB
			public unsafe EntityVisualState state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.__c__DisplayClass59_0.NativeFieldInfoPtr_state);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityVisualState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.__c__DisplayClass59_0.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009566 RID: 38246
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04009567 RID: 38247
			private static readonly IntPtr NativeFieldInfoPtr_state;

			// Token: 0x04009568 RID: 38248
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009569 RID: 38249
			private static readonly IntPtr NativeMethodInfoPtr__GetEvent_b__0_Internal_Boolean_VisionEvent_0;
		}
	}
}
