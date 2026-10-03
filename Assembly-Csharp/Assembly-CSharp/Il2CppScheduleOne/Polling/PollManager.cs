using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Networking;

namespace Il2CppScheduleOne.Polling
{
	// Token: 0x02000171 RID: 369
	public class PollManager : MonoBehaviour
	{
		// Token: 0x0600252B RID: 9515 RVA: 0x000F64B0 File Offset: 0x000F46B0
		// Note: this type is marked as 'beforefieldinit'.
		static PollManager()
		{
			Il2CppClassPointerStore<PollManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Polling", "PollManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollManager>.NativeClassPtr);
			PollManager.NativeFieldInfoPtr_ServerUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "ServerUrl");
			PollManager.NativeFieldInfoPtr__ActivePoll_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "<ActivePoll>k__BackingField");
			PollManager.NativeFieldInfoPtr__ConfirmedPoll_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "<ConfirmedPoll>k__BackingField");
			PollManager.NativeFieldInfoPtr__SubmissionResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "<SubmissionResult>k__BackingField");
			PollManager.NativeFieldInfoPtr__SubmisssionFailedMesssage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "<SubmisssionFailedMesssage>k__BackingField");
			PollManager.NativeFieldInfoPtr_onActivePollReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "onActivePollReceived");
			PollManager.NativeFieldInfoPtr_onConfirmedPollReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "onConfirmedPollReceived");
			PollManager.NativeFieldInfoPtr__receivedPollResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "_receivedPollResponse");
			PollManager.NativeFieldInfoPtr_loadDebugData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "loadDebugData");
			PollManager.NativeFieldInfoPtr_debugData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "debugData");
			PollManager.NativeMethodInfoPtr_get_ActivePoll_Public_get_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100668115);
			PollManager.NativeMethodInfoPtr_set_ActivePoll_Private_set_Void_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100668116);
			PollManager.NativeMethodInfoPtr_get_ConfirmedPoll_Public_get_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100668117);
			PollManager.NativeMethodInfoPtr_set_ConfirmedPoll_Private_set_Void_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100668118);
			PollManager.NativeMethodInfoPtr_get_SubmissionResult_Public_get_EPollSubmissionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100668119);
			PollManager.NativeMethodInfoPtr_set_SubmissionResult_Private_set_Void_EPollSubmissionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100668120);
			PollManager.NativeMethodInfoPtr_get_SubmisssionFailedMesssage_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100668121);
			PollManager.NativeMethodInfoPtr_set_SubmisssionFailedMesssage_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100668122);
			PollManager.NativeMethodInfoPtr_add_onActivePollReceived_Public_add_Void_Action_1_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100668123);
			PollManager.NativeMethodInfoPtr_remove_onActivePollReceived_Public_rem_Void_Action_1_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100668124);
			PollManager.NativeMethodInfoPtr_add_onConfirmedPollReceived_Public_add_Void_Action_1_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100668125);
			PollManager.NativeMethodInfoPtr_remove_onConfirmedPollReceived_Public_rem_Void_Action_1_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100668126);
			PollManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100668127);
			PollManager.NativeMethodInfoPtr_PlatformInitialized_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100668128);
			PollManager.NativeMethodInfoPtr_SelectPollResponse_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100668129);
			PollManager.NativeMethodInfoPtr_TryGetExistingPollResponse_Public_Static_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100668130);
			PollManager.NativeMethodInfoPtr_SubmitAnswerToServer_Private_IEnumerator_PollAnswer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100668131);
			PollManager.NativeMethodInfoPtr_RequestPoll_Private_IEnumerator_String_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100668132);
			PollManager.NativeMethodInfoPtr_ResponseCallback_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100668133);
			PollManager.NativeMethodInfoPtr_CleanTicket_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100668134);
			PollManager.NativeMethodInfoPtr_RecordSubmission_Private_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100668135);
			PollManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100668136);
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x0600252C RID: 9516 RVA: 0x000F6760 File Offset: 0x000F4960
		// (set) Token: 0x0600252D RID: 9517 RVA: 0x000F67A0 File Offset: 0x000F49A0
		public unsafe PollData ActivePoll
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_get_ActivePoll_Public_get_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PollData>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_set_ActivePoll_Private_set_Void_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x000F67E4 File Offset: 0x000F49E4
		// (set) Token: 0x0600252F RID: 9519 RVA: 0x000F6824 File Offset: 0x000F4A24
		public unsafe PollData ConfirmedPoll
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_get_ConfirmedPoll_Public_get_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PollData>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_set_ConfirmedPoll_Private_set_Void_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06002530 RID: 9520 RVA: 0x000F6868 File Offset: 0x000F4A68
		// (set) Token: 0x06002531 RID: 9521 RVA: 0x000F68A4 File Offset: 0x000F4AA4
		public unsafe PollManager.EPollSubmissionResult SubmissionResult
		{
			[CallerCount(149)]
			[CachedScanResults(RefRangeStart = 35494, RefRangeEnd = 35643, XrefRangeStart = 35494, XrefRangeEnd = 35643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_get_SubmissionResult_Public_get_EPollSubmissionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 63932, RefRangeEnd = 63933, XrefRangeStart = 63932, XrefRangeEnd = 63933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_set_SubmissionResult_Private_set_Void_EPollSubmissionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06002532 RID: 9522 RVA: 0x000F68E4 File Offset: 0x000F4AE4
		// (set) Token: 0x06002533 RID: 9523 RVA: 0x000F691C File Offset: 0x000F4B1C
		public unsafe string SubmisssionFailedMesssage
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 2980, RefRangeEnd = 2987, XrefRangeStart = 2980, XrefRangeEnd = 2987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_get_SubmisssionFailedMesssage_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_set_SubmisssionFailedMesssage_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x000F6960 File Offset: 0x000F4B60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115295, RefRangeEnd = 115296, XrefRangeStart = 115290, XrefRangeEnd = 115295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_onActivePollReceived(Action<PollData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_add_onActivePollReceived_Public_add_Void_Action_1_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x000F69A4 File Offset: 0x000F4BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115296, XrefRangeEnd = 115301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_onActivePollReceived(Action<PollData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_remove_onActivePollReceived_Public_rem_Void_Action_1_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x000F69E8 File Offset: 0x000F4BE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115306, RefRangeEnd = 115307, XrefRangeStart = 115301, XrefRangeEnd = 115306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_onConfirmedPollReceived(Action<PollData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_add_onConfirmedPollReceived_Public_add_Void_Action_1_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x000F6A2C File Offset: 0x000F4C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115307, XrefRangeEnd = 115312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_onConfirmedPollReceived(Action<PollData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_remove_onConfirmedPollReceived_Public_rem_Void_Action_1_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x000F6A70 File Offset: 0x000F4C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115312, XrefRangeEnd = 115329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x000F6AA4 File Offset: 0x000F4CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115329, XrefRangeEnd = 115330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PlatformInitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_PlatformInitialized_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x000F6AE0 File Offset: 0x000F4CE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115356, RefRangeEnd = 115357, XrefRangeStart = 115330, XrefRangeEnd = 115356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectPollResponse(int responseIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref responseIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_SelectPollResponse_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x000F6B20 File Offset: 0x000F4D20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115367, RefRangeEnd = 115368, XrefRangeStart = 115357, XrefRangeEnd = 115367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetExistingPollResponse(int pollId, out int response)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pollId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &response;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_TryGetExistingPollResponse_Public_Static_Boolean_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x000F6B6C File Offset: 0x000F4D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115368, XrefRangeEnd = 115374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SubmitAnswerToServer(PollAnswer answer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(answer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_SubmitAnswerToServer_Private_IEnumerator_PollAnswer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x000F6BBC File Offset: 0x000F4DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115374, XrefRangeEnd = 115380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RequestPoll(string url, Action<string> callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_RequestPoll_Private_IEnumerator_String_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x000F6C20 File Offset: 0x000F4E20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115444, RefRangeEnd = 115445, XrefRangeStart = 115380, XrefRangeEnd = 115444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResponseCallback(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_ResponseCallback_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x000F6C64 File Offset: 0x000F4E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115445, XrefRangeEnd = 115451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CleanTicket(string ticket)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ticket);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_CleanTicket_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x000F6CA0 File Offset: 0x000F4EA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115457, RefRangeEnd = 115458, XrefRangeStart = 115451, XrefRangeEnd = 115457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecordSubmission(int pollId, int response)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pollId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref response;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_RecordSubmission_Private_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x000F6CE0 File Offset: 0x000F4EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115458, XrefRangeEnd = 115464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PollManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x0001394B File Offset: 0x00011B4B
		public PollManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x06002543 RID: 9539 RVA: 0x000F6D1C File Offset: 0x000F4F1C
		// (set) Token: 0x06002544 RID: 9540 RVA: 0x00013954 File Offset: 0x00011B54
		public unsafe static string ServerUrl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PollManager.NativeFieldInfoPtr_ServerUrl, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PollManager.NativeFieldInfoPtr_ServerUrl, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x06002545 RID: 9541 RVA: 0x000F6D3C File Offset: 0x000F4F3C
		// (set) Token: 0x06002546 RID: 9542 RVA: 0x00013966 File Offset: 0x00011B66
		public unsafe PollData _ActivePoll_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr__ActivePoll_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr__ActivePoll_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x06002547 RID: 9543 RVA: 0x000F6D6C File Offset: 0x000F4F6C
		// (set) Token: 0x06002548 RID: 9544 RVA: 0x00013985 File Offset: 0x00011B85
		public unsafe PollData _ConfirmedPoll_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr__ConfirmedPoll_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr__ConfirmedPoll_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06002549 RID: 9545 RVA: 0x000F6D9C File Offset: 0x000F4F9C
		// (set) Token: 0x0600254A RID: 9546 RVA: 0x000139A4 File Offset: 0x00011BA4
		public unsafe PollManager.EPollSubmissionResult _SubmissionResult_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr__SubmissionResult_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr__SubmissionResult_k__BackingField)) = value;
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x0600254B RID: 9547 RVA: 0x000F6DC4 File Offset: 0x000F4FC4
		// (set) Token: 0x0600254C RID: 9548 RVA: 0x000139BF File Offset: 0x00011BBF
		public unsafe string _SubmisssionFailedMesssage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr__SubmisssionFailedMesssage_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr__SubmisssionFailedMesssage_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x0600254D RID: 9549 RVA: 0x000F6DEC File Offset: 0x000F4FEC
		// (set) Token: 0x0600254E RID: 9550 RVA: 0x000139DE File Offset: 0x00011BDE
		public unsafe Action<PollData> onActivePollReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_onActivePollReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PollData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_onActivePollReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x0600254F RID: 9551 RVA: 0x000F6E1C File Offset: 0x000F501C
		// (set) Token: 0x06002550 RID: 9552 RVA: 0x000139FD File Offset: 0x00011BFD
		public unsafe Action<PollData> onConfirmedPollReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_onConfirmedPollReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PollData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_onConfirmedPollReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06002551 RID: 9553 RVA: 0x000F6E4C File Offset: 0x000F504C
		// (set) Token: 0x06002552 RID: 9554 RVA: 0x00013A1C File Offset: 0x00011C1C
		public unsafe PollResponse _receivedPollResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr__receivedPollResponse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollResponse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr__receivedPollResponse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06002553 RID: 9555 RVA: 0x000F6E7C File Offset: 0x000F507C
		// (set) Token: 0x06002554 RID: 9556 RVA: 0x00013A3B File Offset: 0x00011C3B
		public unsafe bool loadDebugData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_loadDebugData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_loadDebugData)) = value;
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06002555 RID: 9557 RVA: 0x000F6EA4 File Offset: 0x000F50A4
		// (set) Token: 0x06002556 RID: 9558 RVA: 0x00013A56 File Offset: 0x00011C56
		public unsafe string debugData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_debugData);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_debugData), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040019AF RID: 6575
		private static readonly IntPtr NativeFieldInfoPtr_ServerUrl;

		// Token: 0x040019B0 RID: 6576
		private static readonly IntPtr NativeFieldInfoPtr__ActivePoll_k__BackingField;

		// Token: 0x040019B1 RID: 6577
		private static readonly IntPtr NativeFieldInfoPtr__ConfirmedPoll_k__BackingField;

		// Token: 0x040019B2 RID: 6578
		private static readonly IntPtr NativeFieldInfoPtr__SubmissionResult_k__BackingField;

		// Token: 0x040019B3 RID: 6579
		private static readonly IntPtr NativeFieldInfoPtr__SubmisssionFailedMesssage_k__BackingField;

		// Token: 0x040019B4 RID: 6580
		private static readonly IntPtr NativeFieldInfoPtr_onActivePollReceived;

		// Token: 0x040019B5 RID: 6581
		private static readonly IntPtr NativeFieldInfoPtr_onConfirmedPollReceived;

		// Token: 0x040019B6 RID: 6582
		private static readonly IntPtr NativeFieldInfoPtr__receivedPollResponse;

		// Token: 0x040019B7 RID: 6583
		private static readonly IntPtr NativeFieldInfoPtr_loadDebugData;

		// Token: 0x040019B8 RID: 6584
		private static readonly IntPtr NativeFieldInfoPtr_debugData;

		// Token: 0x040019B9 RID: 6585
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivePoll_Public_get_PollData_0;

		// Token: 0x040019BA RID: 6586
		private static readonly IntPtr NativeMethodInfoPtr_set_ActivePoll_Private_set_Void_PollData_0;

		// Token: 0x040019BB RID: 6587
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfirmedPoll_Public_get_PollData_0;

		// Token: 0x040019BC RID: 6588
		private static readonly IntPtr NativeMethodInfoPtr_set_ConfirmedPoll_Private_set_Void_PollData_0;

		// Token: 0x040019BD RID: 6589
		private static readonly IntPtr NativeMethodInfoPtr_get_SubmissionResult_Public_get_EPollSubmissionResult_0;

		// Token: 0x040019BE RID: 6590
		private static readonly IntPtr NativeMethodInfoPtr_set_SubmissionResult_Private_set_Void_EPollSubmissionResult_0;

		// Token: 0x040019BF RID: 6591
		private static readonly IntPtr NativeMethodInfoPtr_get_SubmisssionFailedMesssage_Public_get_String_0;

		// Token: 0x040019C0 RID: 6592
		private static readonly IntPtr NativeMethodInfoPtr_set_SubmisssionFailedMesssage_Private_set_Void_String_0;

		// Token: 0x040019C1 RID: 6593
		private static readonly IntPtr NativeMethodInfoPtr_add_onActivePollReceived_Public_add_Void_Action_1_PollData_0;

		// Token: 0x040019C2 RID: 6594
		private static readonly IntPtr NativeMethodInfoPtr_remove_onActivePollReceived_Public_rem_Void_Action_1_PollData_0;

		// Token: 0x040019C3 RID: 6595
		private static readonly IntPtr NativeMethodInfoPtr_add_onConfirmedPollReceived_Public_add_Void_Action_1_PollData_0;

		// Token: 0x040019C4 RID: 6596
		private static readonly IntPtr NativeMethodInfoPtr_remove_onConfirmedPollReceived_Public_rem_Void_Action_1_PollData_0;

		// Token: 0x040019C5 RID: 6597
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040019C6 RID: 6598
		private static readonly IntPtr NativeMethodInfoPtr_PlatformInitialized_Private_Boolean_0;

		// Token: 0x040019C7 RID: 6599
		private static readonly IntPtr NativeMethodInfoPtr_SelectPollResponse_Public_Void_Int32_0;

		// Token: 0x040019C8 RID: 6600
		private static readonly IntPtr NativeMethodInfoPtr_TryGetExistingPollResponse_Public_Static_Boolean_Int32_byref_Int32_0;

		// Token: 0x040019C9 RID: 6601
		private static readonly IntPtr NativeMethodInfoPtr_SubmitAnswerToServer_Private_IEnumerator_PollAnswer_0;

		// Token: 0x040019CA RID: 6602
		private static readonly IntPtr NativeMethodInfoPtr_RequestPoll_Private_IEnumerator_String_Action_1_String_0;

		// Token: 0x040019CB RID: 6603
		private static readonly IntPtr NativeMethodInfoPtr_ResponseCallback_Private_Void_String_0;

		// Token: 0x040019CC RID: 6604
		private static readonly IntPtr NativeMethodInfoPtr_CleanTicket_Private_Static_String_String_0;

		// Token: 0x040019CD RID: 6605
		private static readonly IntPtr NativeMethodInfoPtr_RecordSubmission_Private_Static_Void_Int32_Int32_0;

		// Token: 0x040019CE RID: 6606
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000982 RID: 2434
		[OriginalName("Assembly-CSharp.dll", "", "EPollSubmissionResult")]
		public enum EPollSubmissionResult
		{
			// Token: 0x040094CB RID: 38091
			InProgress,
			// Token: 0x040094CC RID: 38092
			Success,
			// Token: 0x040094CD RID: 38093
			Failed
		}

		// Token: 0x02000983 RID: 2435
		[ObfuscatedName("ScheduleOne.Polling.PollManager+<RequestPoll>d__32")]
		public sealed class _RequestPoll_d__32 : Il2CppSystem.Object
		{
			// Token: 0x0600DA08 RID: 55816 RVA: 0x00361320 File Offset: 0x0035F520
			// Note: this type is marked as 'beforefieldinit'.
			static _RequestPoll_d__32()
			{
				Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "<RequestPoll>d__32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr);
				PollManager._RequestPoll_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr, "<>1__state");
				PollManager._RequestPoll_d__32.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr, "<>2__current");
				PollManager._RequestPoll_d__32.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr, "url");
				PollManager._RequestPoll_d__32.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr, "callback");
				PollManager._RequestPoll_d__32.NativeFieldInfoPtr__request_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr, "<request>5__2");
				PollManager._RequestPoll_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr, 100668137);
				PollManager._RequestPoll_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr, 100668138);
				PollManager._RequestPoll_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr, 100668139);
				PollManager._RequestPoll_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr, 100668140);
				PollManager._RequestPoll_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr, 100668141);
				PollManager._RequestPoll_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr, 100668142);
			}

			// Token: 0x0600DA09 RID: 55817 RVA: 0x00361428 File Offset: 0x0035F628
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RequestPoll_d__32(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._RequestPoll_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA0A RID: 55818 RVA: 0x00361470 File Offset: 0x0035F670
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._RequestPoll_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA0B RID: 55819 RVA: 0x003614A4 File Offset: 0x0035F6A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115212, XrefRangeEnd = 115216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._RequestPoll_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004291 RID: 17041
			// (get) Token: 0x0600DA0C RID: 55820 RVA: 0x003614E0 File Offset: 0x0035F6E0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._RequestPoll_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DA0D RID: 55821 RVA: 0x00361520 File Offset: 0x0035F720
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115216, XrefRangeEnd = 115221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._RequestPoll_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004292 RID: 17042
			// (get) Token: 0x0600DA0E RID: 55822 RVA: 0x00361554 File Offset: 0x0035F754
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._RequestPoll_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DA0F RID: 55823 RVA: 0x000667E7 File Offset: 0x000649E7
			public _RequestPoll_d__32(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700428C RID: 17036
			// (get) Token: 0x0600DA10 RID: 55824 RVA: 0x00361594 File Offset: 0x0035F794
			// (set) Token: 0x0600DA11 RID: 55825 RVA: 0x000667F0 File Offset: 0x000649F0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._RequestPoll_d__32.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._RequestPoll_d__32.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700428D RID: 17037
			// (get) Token: 0x0600DA12 RID: 55826 RVA: 0x003615BC File Offset: 0x0035F7BC
			// (set) Token: 0x0600DA13 RID: 55827 RVA: 0x0006680B File Offset: 0x00064A0B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._RequestPoll_d__32.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._RequestPoll_d__32.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700428E RID: 17038
			// (get) Token: 0x0600DA14 RID: 55828 RVA: 0x003615EC File Offset: 0x0035F7EC
			// (set) Token: 0x0600DA15 RID: 55829 RVA: 0x0006682A File Offset: 0x00064A2A
			public unsafe string url
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._RequestPoll_d__32.NativeFieldInfoPtr_url);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._RequestPoll_d__32.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700428F RID: 17039
			// (get) Token: 0x0600DA16 RID: 55830 RVA: 0x00361614 File Offset: 0x0035F814
			// (set) Token: 0x0600DA17 RID: 55831 RVA: 0x00066849 File Offset: 0x00064A49
			public unsafe Action<string> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._RequestPoll_d__32.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._RequestPoll_d__32.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004290 RID: 17040
			// (get) Token: 0x0600DA18 RID: 55832 RVA: 0x00361644 File Offset: 0x0035F844
			// (set) Token: 0x0600DA19 RID: 55833 RVA: 0x00066868 File Offset: 0x00064A68
			public unsafe UnityWebRequest _request_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._RequestPoll_d__32.NativeFieldInfoPtr__request_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._RequestPoll_d__32.NativeFieldInfoPtr__request_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040094CE RID: 38094
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040094CF RID: 38095
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040094D0 RID: 38096
			private static readonly IntPtr NativeFieldInfoPtr_url;

			// Token: 0x040094D1 RID: 38097
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x040094D2 RID: 38098
			private static readonly IntPtr NativeFieldInfoPtr__request_5__2;

			// Token: 0x040094D3 RID: 38099
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040094D4 RID: 38100
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094D5 RID: 38101
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040094D6 RID: 38102
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040094D7 RID: 38103
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094D8 RID: 38104
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000984 RID: 2436
		[ObfuscatedName("ScheduleOne.Polling.PollManager+<SubmitAnswerToServer>d__31")]
		public sealed class _SubmitAnswerToServer_d__31 : Il2CppSystem.Object
		{
			// Token: 0x0600DA1A RID: 55834 RVA: 0x00361674 File Offset: 0x0035F874
			// Note: this type is marked as 'beforefieldinit'.
			static _SubmitAnswerToServer_d__31()
			{
				Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "<SubmitAnswerToServer>d__31");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr);
				PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, "<>1__state");
				PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, "<>2__current");
				PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr_answer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, "answer");
				PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, "<>4__this");
				PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr__req_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, "<req>5__2");
				PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, 100668143);
				PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, 100668144);
				PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, 100668145);
				PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, 100668146);
				PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, 100668147);
				PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, 100668148);
				PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, 100668149);
			}

			// Token: 0x0600DA1B RID: 55835 RVA: 0x00361790 File Offset: 0x0035F990
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SubmitAnswerToServer_d__31(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA1C RID: 55836 RVA: 0x003617D8 File Offset: 0x0035F9D8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 115224, RefRangeEnd = 115225, XrefRangeStart = 115221, XrefRangeEnd = 115224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA1D RID: 55837 RVA: 0x0036180C File Offset: 0x0035FA0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115225, XrefRangeEnd = 115278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA1E RID: 55838 RVA: 0x00361848 File Offset: 0x0035FA48
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 115281, RefRangeEnd = 115285, XrefRangeStart = 115278, XrefRangeEnd = 115281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004298 RID: 17048
			// (get) Token: 0x0600DA1F RID: 55839 RVA: 0x0036187C File Offset: 0x0035FA7C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DA20 RID: 55840 RVA: 0x003618BC File Offset: 0x0035FABC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115285, XrefRangeEnd = 115290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004299 RID: 17049
			// (get) Token: 0x0600DA21 RID: 55841 RVA: 0x003618F0 File Offset: 0x0035FAF0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DA22 RID: 55842 RVA: 0x00066887 File Offset: 0x00064A87
			public _SubmitAnswerToServer_d__31(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004293 RID: 17043
			// (get) Token: 0x0600DA23 RID: 55843 RVA: 0x00361930 File Offset: 0x0035FB30
			// (set) Token: 0x0600DA24 RID: 55844 RVA: 0x00066890 File Offset: 0x00064A90
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004294 RID: 17044
			// (get) Token: 0x0600DA25 RID: 55845 RVA: 0x00361958 File Offset: 0x0035FB58
			// (set) Token: 0x0600DA26 RID: 55846 RVA: 0x000668AB File Offset: 0x00064AAB
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004295 RID: 17045
			// (get) Token: 0x0600DA27 RID: 55847 RVA: 0x00361988 File Offset: 0x0035FB88
			// (set) Token: 0x0600DA28 RID: 55848 RVA: 0x000668CA File Offset: 0x00064ACA
			public unsafe PollAnswer answer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr_answer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollAnswer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr_answer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004296 RID: 17046
			// (get) Token: 0x0600DA29 RID: 55849 RVA: 0x003619B8 File Offset: 0x0035FBB8
			// (set) Token: 0x0600DA2A RID: 55850 RVA: 0x000668E9 File Offset: 0x00064AE9
			public unsafe PollManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004297 RID: 17047
			// (get) Token: 0x0600DA2B RID: 55851 RVA: 0x003619E8 File Offset: 0x0035FBE8
			// (set) Token: 0x0600DA2C RID: 55852 RVA: 0x00066908 File Offset: 0x00064B08
			public unsafe UnityWebRequest _req_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr__req_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr__req_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040094D9 RID: 38105
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040094DA RID: 38106
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040094DB RID: 38107
			private static readonly IntPtr NativeFieldInfoPtr_answer;

			// Token: 0x040094DC RID: 38108
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040094DD RID: 38109
			private static readonly IntPtr NativeFieldInfoPtr__req_5__2;

			// Token: 0x040094DE RID: 38110
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040094DF RID: 38111
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094E0 RID: 38112
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040094E1 RID: 38113
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040094E2 RID: 38114
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040094E3 RID: 38115
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094E4 RID: 38116
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
