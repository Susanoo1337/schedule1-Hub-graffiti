using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Police;
using Il2CppScheduleOne.Product.Packaging;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000657 RID: 1623
	public class BodySearchBehaviour : Behaviour
	{
		// Token: 0x06009AB6 RID: 39606 RVA: 0x00296228 File Offset: 0x00294428
		// Note: this type is marked as 'beforefieldinit'.
		static BodySearchBehaviour()
		{
			Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "BodySearchBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr);
			BodySearchBehaviour.NativeFieldInfoPtr_MAX_STEALTH_LEVEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "MAX_STEALTH_LEVEL");
			BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "BODY_SEARCH_RANGE");
			BodySearchBehaviour.NativeFieldInfoPtr_MAX_SEARCH_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "MAX_SEARCH_TIME");
			BodySearchBehaviour.NativeFieldInfoPtr_MAX_TIME_OUTSIDE_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "MAX_TIME_OUTSIDE_RANGE");
			BodySearchBehaviour.NativeFieldInfoPtr_RANGE_TO_ESCALATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "RANGE_TO_ESCALATE");
			BodySearchBehaviour.NativeFieldInfoPtr_MOVE_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "MOVE_SPEED");
			BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "BODY_SEARCH_COOLDOWN");
			BodySearchBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "<TargetPlayer>k__BackingField");
			BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "ArrestCircle_MaxVisibleDistance");
			BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "ArrestCircle_MaxOpacity");
			BodySearchBehaviour.NativeFieldInfoPtr_ShowPostSearchDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "ShowPostSearchDialogue");
			BodySearchBehaviour.NativeFieldInfoPtr_MaxStealthLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "MaxStealthLevel");
			BodySearchBehaviour.NativeFieldInfoPtr_officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "officer");
			BodySearchBehaviour.NativeFieldInfoPtr_targetDistanceOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "targetDistanceOnStart");
			BodySearchBehaviour.NativeFieldInfoPtr_searchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "searchTime");
			BodySearchBehaviour.NativeFieldInfoPtr_timeOutsideRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "timeOutsideRange");
			BodySearchBehaviour.NativeFieldInfoPtr_timeSinceCantReach = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "timeSinceCantReach");
			BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_Clear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "onSearchComplete_Clear");
			BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_ItemsFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "onSearchComplete_ItemsFound");
			BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BodySearchBehaviourAssembly-CSharp.dll_Excuted");
			BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BodySearchBehaviourAssembly-CSharp.dll_Excuted");
			BodySearchBehaviour.NativeMethodInfoPtr_get_BODY_SEARCH_TIME_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683440);
			BodySearchBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683441);
			BodySearchBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683442);
			BodySearchBehaviour.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683443);
			BodySearchBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683444);
			BodySearchBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683445);
			BodySearchBehaviour.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683446);
			BodySearchBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683447);
			BodySearchBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683448);
			BodySearchBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683449);
			BodySearchBehaviour.NativeMethodInfoPtr_UpdateSearch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683450);
			BodySearchBehaviour.NativeMethodInfoPtr_UpdateMovement_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683451);
			BodySearchBehaviour.NativeMethodInfoPtr_SearchClean_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683452);
			BodySearchBehaviour.NativeMethodInfoPtr_SearchFail_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683453);
			BodySearchBehaviour.NativeMethodInfoPtr_UpdateEscalation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683454);
			BodySearchBehaviour.NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683455);
			BodySearchBehaviour.NativeMethodInfoPtr_UpdateCircle_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683456);
			BodySearchBehaviour.NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683457);
			BodySearchBehaviour.NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683458);
			BodySearchBehaviour.NativeMethodInfoPtr_GetNewDestination_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683459);
			BodySearchBehaviour.NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683460);
			BodySearchBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683461);
			BodySearchBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683462);
			BodySearchBehaviour.NativeMethodInfoPtr_DoesPlayerContainItemsOfInterest_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683463);
			BodySearchBehaviour.NativeMethodInfoPtr_ConcludeSearch_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683464);
			BodySearchBehaviour.NativeMethodInfoPtr_Escalate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683465);
			BodySearchBehaviour.NativeMethodInfoPtr_NoItemsOfInterestFound_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683466);
			BodySearchBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683467);
			BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683468);
			BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683469);
			BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683470);
			BodySearchBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683471);
			BodySearchBehaviour.NativeMethodInfoPtr_RpcLogic___AssignTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683472);
			BodySearchBehaviour.NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_1824087381_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683473);
			BodySearchBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100683474);
		}

		// Token: 0x17002F5C RID: 12124
		// (get) Token: 0x06009AB7 RID: 39607 RVA: 0x002966B8 File Offset: 0x002948B8
		public unsafe static float BODY_SEARCH_TIME
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275759, XrefRangeEnd = 275764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_get_BODY_SEARCH_TIME_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002F5D RID: 12125
		// (get) Token: 0x06009AB8 RID: 39608 RVA: 0x002966E8 File Offset: 0x002948E8
		// (set) Token: 0x06009AB9 RID: 39609 RVA: 0x00296728 File Offset: 0x00294928
		public unsafe Player TargetPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 109090, RefRangeEnd = 109096, XrefRangeStart = 109090, XrefRangeEnd = 109096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002F5E RID: 12126
		// (get) Token: 0x06009ABA RID: 39610 RVA: 0x0029676C File Offset: 0x0029496C
		public unsafe DialogueDatabase dialogueDatabase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueDatabase>(intPtr3) : null;
			}
		}

		// Token: 0x06009ABB RID: 39611 RVA: 0x002967AC File Offset: 0x002949AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275764, XrefRangeEnd = 275771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009ABC RID: 39612 RVA: 0x002967E8 File Offset: 0x002949E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275771, XrefRangeEnd = 275799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009ABD RID: 39613 RVA: 0x00296824 File Offset: 0x00294A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275799, XrefRangeEnd = 275813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009ABE RID: 39614 RVA: 0x00296860 File Offset: 0x00294A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275813, XrefRangeEnd = 275824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009ABF RID: 39615 RVA: 0x0029689C File Offset: 0x00294A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275824, XrefRangeEnd = 275831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AC0 RID: 39616 RVA: 0x002968D8 File Offset: 0x00294AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275831, XrefRangeEnd = 275840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AC1 RID: 39617 RVA: 0x00296914 File Offset: 0x00294B14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275882, RefRangeEnd = 275883, XrefRangeStart = 275840, XrefRangeEnd = 275882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_UpdateSearch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AC2 RID: 39618 RVA: 0x00296948 File Offset: 0x00294B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275883, XrefRangeEnd = 275902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_UpdateMovement_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AC3 RID: 39619 RVA: 0x00296984 File Offset: 0x00294B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275902, XrefRangeEnd = 275923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SearchClean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_SearchClean_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AC4 RID: 39620 RVA: 0x002969B8 File Offset: 0x00294BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275923, XrefRangeEnd = 275944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SearchFail()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_SearchFail_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AC5 RID: 39621 RVA: 0x002969EC File Offset: 0x00294BEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275966, RefRangeEnd = 275967, XrefRangeStart = 275944, XrefRangeEnd = 275966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEscalation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_UpdateEscalation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AC6 RID: 39622 RVA: 0x00296A20 File Offset: 0x00294C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275967, XrefRangeEnd = 275973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateLookAt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AC7 RID: 39623 RVA: 0x00296A5C File Offset: 0x00294C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275973, XrefRangeEnd = 275997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateCircle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_UpdateCircle_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AC8 RID: 39624 RVA: 0x00296A98 File Offset: 0x00294C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275997, XrefRangeEnd = 275999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrestCircleAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AC9 RID: 39625 RVA: 0x00296AD8 File Offset: 0x00294CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275999, XrefRangeEnd = 276000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrestCircleColor(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009ACA RID: 39626 RVA: 0x00296B18 File Offset: 0x00294D18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276012, RefRangeEnd = 276013, XrefRangeStart = 276000, XrefRangeEnd = 276012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetNewDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_GetNewDestination_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009ACB RID: 39627 RVA: 0x00296B54 File Offset: 0x00294D54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276018, RefRangeEnd = 276020, XrefRangeStart = 276013, XrefRangeEnd = 276018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSpeedControls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009ACC RID: 39628 RVA: 0x00296B88 File Offset: 0x00294D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276020, XrefRangeEnd = 276025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetValid(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009ACD RID: 39629 RVA: 0x00296BD8 File Offset: 0x00294DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276025, XrefRangeEnd = 276027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignTarget(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009ACE RID: 39630 RVA: 0x00296C38 File Offset: 0x00294E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276027, XrefRangeEnd = 276053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoesPlayerContainItemsOfInterest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_DoesPlayerContainItemsOfInterest_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009ACF RID: 39631 RVA: 0x00296C80 File Offset: 0x00294E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276053, XrefRangeEnd = 276082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ConcludeSearch(bool clear)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref clear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_ConcludeSearch_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AD0 RID: 39632 RVA: 0x00296CCC File Offset: 0x00294ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276082, XrefRangeEnd = 276100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Escalate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Escalate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AD1 RID: 39633 RVA: 0x00296D08 File Offset: 0x00294F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276100, XrefRangeEnd = 276103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoItemsOfInterestFound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_NoItemsOfInterestFound_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AD2 RID: 39634 RVA: 0x00296D44 File Offset: 0x00294F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276103, XrefRangeEnd = 276104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BodySearchBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AD3 RID: 39635 RVA: 0x00296D80 File Offset: 0x00294F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276104, XrefRangeEnd = 276111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AD4 RID: 39636 RVA: 0x00296DBC File Offset: 0x00294FBC
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AD5 RID: 39637 RVA: 0x00296DF8 File Offset: 0x00294FF8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AD6 RID: 39638 RVA: 0x00296E34 File Offset: 0x00295034
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276130, RefRangeEnd = 276131, XrefRangeStart = 276111, XrefRangeEnd = 276130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AssignTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AD7 RID: 39639 RVA: 0x00296E88 File Offset: 0x00295088
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276143, RefRangeEnd = 276145, XrefRangeStart = 276131, XrefRangeEnd = 276143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___AssignTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_RpcLogic___AssignTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AD8 RID: 39640 RVA: 0x00296EE8 File Offset: 0x002950E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276145, XrefRangeEnd = 276150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AssignTarget_1824087381(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_1824087381_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AD9 RID: 39641 RVA: 0x00296F38 File Offset: 0x00295138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276150, XrefRangeEnd = 276157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009ADA RID: 39642 RVA: 0x00047FF3 File Offset: 0x000461F3
		public BodySearchBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F47 RID: 12103
		// (get) Token: 0x06009ADB RID: 39643 RVA: 0x00296F74 File Offset: 0x00295174
		// (set) Token: 0x06009ADC RID: 39644 RVA: 0x00047FFC File Offset: 0x000461FC
		public unsafe static EStealthLevel MAX_STEALTH_LEVEL
		{
			get
			{
				EStealthLevel result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_STEALTH_LEVEL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_STEALTH_LEVEL, (void*)(&value));
			}
		}

		// Token: 0x17002F48 RID: 12104
		// (get) Token: 0x06009ADD RID: 39645 RVA: 0x00296F90 File Offset: 0x00295190
		// (set) Token: 0x06009ADE RID: 39646 RVA: 0x0004800A File Offset: 0x0004620A
		public unsafe static float BODY_SEARCH_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17002F49 RID: 12105
		// (get) Token: 0x06009ADF RID: 39647 RVA: 0x00296FAC File Offset: 0x002951AC
		// (set) Token: 0x06009AE0 RID: 39648 RVA: 0x00048018 File Offset: 0x00046218
		public unsafe static float MAX_SEARCH_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_SEARCH_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_SEARCH_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002F4A RID: 12106
		// (get) Token: 0x06009AE1 RID: 39649 RVA: 0x00296FC8 File Offset: 0x002951C8
		// (set) Token: 0x06009AE2 RID: 39650 RVA: 0x00048026 File Offset: 0x00046226
		public unsafe static float MAX_TIME_OUTSIDE_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_TIME_OUTSIDE_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_TIME_OUTSIDE_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17002F4B RID: 12107
		// (get) Token: 0x06009AE3 RID: 39651 RVA: 0x00296FE4 File Offset: 0x002951E4
		// (set) Token: 0x06009AE4 RID: 39652 RVA: 0x00048034 File Offset: 0x00046234
		public unsafe static float RANGE_TO_ESCALATE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_RANGE_TO_ESCALATE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_RANGE_TO_ESCALATE, (void*)(&value));
			}
		}

		// Token: 0x17002F4C RID: 12108
		// (get) Token: 0x06009AE5 RID: 39653 RVA: 0x00297000 File Offset: 0x00295200
		// (set) Token: 0x06009AE6 RID: 39654 RVA: 0x00048042 File Offset: 0x00046242
		public unsafe static float MOVE_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_MOVE_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_MOVE_SPEED, (void*)(&value));
			}
		}

		// Token: 0x17002F4D RID: 12109
		// (get) Token: 0x06009AE7 RID: 39655 RVA: 0x0029701C File Offset: 0x0029521C
		// (set) Token: 0x06009AE8 RID: 39656 RVA: 0x00048050 File Offset: 0x00046250
		public unsafe static float BODY_SEARCH_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17002F4E RID: 12110
		// (get) Token: 0x06009AE9 RID: 39657 RVA: 0x00297038 File Offset: 0x00295238
		// (set) Token: 0x06009AEA RID: 39658 RVA: 0x0004805E File Offset: 0x0004625E
		public unsafe Player _TargetPlayer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F4F RID: 12111
		// (get) Token: 0x06009AEB RID: 39659 RVA: 0x00297068 File Offset: 0x00295268
		// (set) Token: 0x06009AEC RID: 39660 RVA: 0x0004807D File Offset: 0x0004627D
		public unsafe float ArrestCircle_MaxVisibleDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance)) = value;
			}
		}

		// Token: 0x17002F50 RID: 12112
		// (get) Token: 0x06009AED RID: 39661 RVA: 0x00297090 File Offset: 0x00295290
		// (set) Token: 0x06009AEE RID: 39662 RVA: 0x00048098 File Offset: 0x00046298
		public unsafe float ArrestCircle_MaxOpacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity)) = value;
			}
		}

		// Token: 0x17002F51 RID: 12113
		// (get) Token: 0x06009AEF RID: 39663 RVA: 0x002970B8 File Offset: 0x002952B8
		// (set) Token: 0x06009AF0 RID: 39664 RVA: 0x000480B3 File Offset: 0x000462B3
		public unsafe bool ShowPostSearchDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ShowPostSearchDialogue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ShowPostSearchDialogue)) = value;
			}
		}

		// Token: 0x17002F52 RID: 12114
		// (get) Token: 0x06009AF1 RID: 39665 RVA: 0x002970E0 File Offset: 0x002952E0
		// (set) Token: 0x06009AF2 RID: 39666 RVA: 0x000480CE File Offset: 0x000462CE
		public unsafe EStealthLevel MaxStealthLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_MaxStealthLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_MaxStealthLevel)) = value;
			}
		}

		// Token: 0x17002F53 RID: 12115
		// (get) Token: 0x06009AF3 RID: 39667 RVA: 0x00297108 File Offset: 0x00295308
		// (set) Token: 0x06009AF4 RID: 39668 RVA: 0x000480E9 File Offset: 0x000462E9
		public unsafe PoliceOfficer officer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_officer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_officer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F54 RID: 12116
		// (get) Token: 0x06009AF5 RID: 39669 RVA: 0x00297138 File Offset: 0x00295338
		// (set) Token: 0x06009AF6 RID: 39670 RVA: 0x00048108 File Offset: 0x00046308
		public unsafe float targetDistanceOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_targetDistanceOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_targetDistanceOnStart)) = value;
			}
		}

		// Token: 0x17002F55 RID: 12117
		// (get) Token: 0x06009AF7 RID: 39671 RVA: 0x00297160 File Offset: 0x00295360
		// (set) Token: 0x06009AF8 RID: 39672 RVA: 0x00048123 File Offset: 0x00046323
		public unsafe float searchTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_searchTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_searchTime)) = value;
			}
		}

		// Token: 0x17002F56 RID: 12118
		// (get) Token: 0x06009AF9 RID: 39673 RVA: 0x00297188 File Offset: 0x00295388
		// (set) Token: 0x06009AFA RID: 39674 RVA: 0x0004813E File Offset: 0x0004633E
		public unsafe float timeOutsideRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_timeOutsideRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_timeOutsideRange)) = value;
			}
		}

		// Token: 0x17002F57 RID: 12119
		// (get) Token: 0x06009AFB RID: 39675 RVA: 0x002971B0 File Offset: 0x002953B0
		// (set) Token: 0x06009AFC RID: 39676 RVA: 0x00048159 File Offset: 0x00046359
		public unsafe float timeSinceCantReach
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_timeSinceCantReach);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_timeSinceCantReach)) = value;
			}
		}

		// Token: 0x17002F58 RID: 12120
		// (get) Token: 0x06009AFD RID: 39677 RVA: 0x002971D8 File Offset: 0x002953D8
		// (set) Token: 0x06009AFE RID: 39678 RVA: 0x00048174 File Offset: 0x00046374
		public unsafe UnityEvent onSearchComplete_Clear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_Clear);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_Clear), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F59 RID: 12121
		// (get) Token: 0x06009AFF RID: 39679 RVA: 0x00297208 File Offset: 0x00295408
		// (set) Token: 0x06009B00 RID: 39680 RVA: 0x00048193 File Offset: 0x00046393
		public unsafe UnityEvent onSearchComplete_ItemsFound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_ItemsFound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_ItemsFound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F5A RID: 12122
		// (get) Token: 0x06009B01 RID: 39681 RVA: 0x00297238 File Offset: 0x00295438
		// (set) Token: 0x06009B02 RID: 39682 RVA: 0x000481B2 File Offset: 0x000463B2
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002F5B RID: 12123
		// (get) Token: 0x06009B03 RID: 39683 RVA: 0x00297260 File Offset: 0x00295460
		// (set) Token: 0x06009B04 RID: 39684 RVA: 0x000481CD File Offset: 0x000463CD
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006A51 RID: 27217
		private static readonly IntPtr NativeFieldInfoPtr_MAX_STEALTH_LEVEL;

		// Token: 0x04006A52 RID: 27218
		private static readonly IntPtr NativeFieldInfoPtr_BODY_SEARCH_RANGE;

		// Token: 0x04006A53 RID: 27219
		private static readonly IntPtr NativeFieldInfoPtr_MAX_SEARCH_TIME;

		// Token: 0x04006A54 RID: 27220
		private static readonly IntPtr NativeFieldInfoPtr_MAX_TIME_OUTSIDE_RANGE;

		// Token: 0x04006A55 RID: 27221
		private static readonly IntPtr NativeFieldInfoPtr_RANGE_TO_ESCALATE;

		// Token: 0x04006A56 RID: 27222
		private static readonly IntPtr NativeFieldInfoPtr_MOVE_SPEED;

		// Token: 0x04006A57 RID: 27223
		private static readonly IntPtr NativeFieldInfoPtr_BODY_SEARCH_COOLDOWN;

		// Token: 0x04006A58 RID: 27224
		private static readonly IntPtr NativeFieldInfoPtr__TargetPlayer_k__BackingField;

		// Token: 0x04006A59 RID: 27225
		private static readonly IntPtr NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance;

		// Token: 0x04006A5A RID: 27226
		private static readonly IntPtr NativeFieldInfoPtr_ArrestCircle_MaxOpacity;

		// Token: 0x04006A5B RID: 27227
		private static readonly IntPtr NativeFieldInfoPtr_ShowPostSearchDialogue;

		// Token: 0x04006A5C RID: 27228
		private static readonly IntPtr NativeFieldInfoPtr_MaxStealthLevel;

		// Token: 0x04006A5D RID: 27229
		private static readonly IntPtr NativeFieldInfoPtr_officer;

		// Token: 0x04006A5E RID: 27230
		private static readonly IntPtr NativeFieldInfoPtr_targetDistanceOnStart;

		// Token: 0x04006A5F RID: 27231
		private static readonly IntPtr NativeFieldInfoPtr_searchTime;

		// Token: 0x04006A60 RID: 27232
		private static readonly IntPtr NativeFieldInfoPtr_timeOutsideRange;

		// Token: 0x04006A61 RID: 27233
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceCantReach;

		// Token: 0x04006A62 RID: 27234
		private static readonly IntPtr NativeFieldInfoPtr_onSearchComplete_Clear;

		// Token: 0x04006A63 RID: 27235
		private static readonly IntPtr NativeFieldInfoPtr_onSearchComplete_ItemsFound;

		// Token: 0x04006A64 RID: 27236
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006A65 RID: 27237
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006A66 RID: 27238
		private static readonly IntPtr NativeMethodInfoPtr_get_BODY_SEARCH_TIME_Public_Static_get_Single_0;

		// Token: 0x04006A67 RID: 27239
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0;

		// Token: 0x04006A68 RID: 27240
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0;

		// Token: 0x04006A69 RID: 27241
		private static readonly IntPtr NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0;

		// Token: 0x04006A6A RID: 27242
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04006A6B RID: 27243
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

		// Token: 0x04006A6C RID: 27244
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x04006A6D RID: 27245
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

		// Token: 0x04006A6E RID: 27246
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Virtual_Void_0;

		// Token: 0x04006A6F RID: 27247
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x04006A70 RID: 27248
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSearch_Private_Void_0;

		// Token: 0x04006A71 RID: 27249
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMovement_Protected_Virtual_New_Void_0;

		// Token: 0x04006A72 RID: 27250
		private static readonly IntPtr NativeMethodInfoPtr_SearchClean_Private_Void_0;

		// Token: 0x04006A73 RID: 27251
		private static readonly IntPtr NativeMethodInfoPtr_SearchFail_Private_Void_0;

		// Token: 0x04006A74 RID: 27252
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEscalation_Private_Void_0;

		// Token: 0x04006A75 RID: 27253
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0;

		// Token: 0x04006A76 RID: 27254
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCircle_Protected_Virtual_New_Void_0;

		// Token: 0x04006A77 RID: 27255
		private static readonly IntPtr NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0;

		// Token: 0x04006A78 RID: 27256
		private static readonly IntPtr NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0;

		// Token: 0x04006A79 RID: 27257
		private static readonly IntPtr NativeMethodInfoPtr_GetNewDestination_Private_Vector3_0;

		// Token: 0x04006A7A RID: 27258
		private static readonly IntPtr NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0;

		// Token: 0x04006A7B RID: 27259
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetValid_Private_Boolean_Player_0;

		// Token: 0x04006A7C RID: 27260
		private static readonly IntPtr NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x04006A7D RID: 27261
		private static readonly IntPtr NativeMethodInfoPtr_DoesPlayerContainItemsOfInterest_Public_Virtual_New_Boolean_0;

		// Token: 0x04006A7E RID: 27262
		private static readonly IntPtr NativeMethodInfoPtr_ConcludeSearch_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04006A7F RID: 27263
		private static readonly IntPtr NativeMethodInfoPtr_Escalate_Public_Virtual_New_Void_0;

		// Token: 0x04006A80 RID: 27264
		private static readonly IntPtr NativeMethodInfoPtr_NoItemsOfInterestFound_Public_Virtual_New_Void_0;

		// Token: 0x04006A81 RID: 27265
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006A82 RID: 27266
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006A83 RID: 27267
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006A84 RID: 27268
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006A85 RID: 27269
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x04006A86 RID: 27270
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AssignTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x04006A87 RID: 27271
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_1824087381_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006A88 RID: 27272
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
