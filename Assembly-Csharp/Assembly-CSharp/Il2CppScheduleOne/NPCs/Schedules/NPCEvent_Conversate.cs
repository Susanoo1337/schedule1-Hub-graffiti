using System;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.VoiceOver;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x02000690 RID: 1680
	public class NPCEvent_Conversate : NPCEvent
	{
		// Token: 0x0600A351 RID: 41809 RVA: 0x002B6918 File Offset: 0x002B4B18
		// Note: this type is marked as 'beforefieldinit'.
		static NPCEvent_Conversate()
		{
			Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "NPCEvent_Conversate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr);
			NPCEvent_Conversate.NativeFieldInfoPtr_ConversationLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "ConversationLines");
			NPCEvent_Conversate.NativeFieldInfoPtr_AnimationTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "AnimationTriggers");
			NPCEvent_Conversate.NativeFieldInfoPtr_DESTINATION_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "DESTINATION_THRESHOLD");
			NPCEvent_Conversate.NativeFieldInfoPtr_TIME_BEFORE_WAIT_START = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "TIME_BEFORE_WAIT_START");
			NPCEvent_Conversate.NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "Location");
			NPCEvent_Conversate.NativeFieldInfoPtr_IsConversating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "IsConversating");
			NPCEvent_Conversate.NativeFieldInfoPtr_conversateRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "conversateRoutine");
			NPCEvent_Conversate.NativeFieldInfoPtr_IsWaiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "IsWaiting");
			NPCEvent_Conversate.NativeFieldInfoPtr_OnWaitStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "OnWaitStart");
			NPCEvent_Conversate.NativeFieldInfoPtr_OnWaitEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "OnWaitEnd");
			NPCEvent_Conversate.NativeFieldInfoPtr_timeAtDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "timeAtDestination");
			NPCEvent_Conversate.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_ConversateAssembly-CSharp.dll_Excuted");
			NPCEvent_Conversate.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_ConversateAssembly-CSharp.dll_Excuted");
			NPCEvent_Conversate.NativeMethodInfoPtr_get_ActionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684894);
			NPCEvent_Conversate.NativeMethodInfoPtr_get_StandPoint_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684895);
			NPCEvent_Conversate.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684896);
			NPCEvent_Conversate.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684897);
			NPCEvent_Conversate.NativeMethodInfoPtr_Started_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684898);
			NPCEvent_Conversate.NativeMethodInfoPtr_ActiveUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684899);
			NPCEvent_Conversate.NativeMethodInfoPtr_MinPassed_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684900);
			NPCEvent_Conversate.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684901);
			NPCEvent_Conversate.NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684902);
			NPCEvent_Conversate.NativeMethodInfoPtr_End_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684903);
			NPCEvent_Conversate.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684904);
			NPCEvent_Conversate.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684905);
			NPCEvent_Conversate.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684906);
			NPCEvent_Conversate.NativeMethodInfoPtr_CanConversationStart_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684907);
			NPCEvent_Conversate.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684908);
			NPCEvent_Conversate.NativeMethodInfoPtr_StartWait_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684909);
			NPCEvent_Conversate.NativeMethodInfoPtr_EndWait_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684910);
			NPCEvent_Conversate.NativeMethodInfoPtr_StartConversate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684911);
			NPCEvent_Conversate.NativeMethodInfoPtr_EndConversate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684912);
			NPCEvent_Conversate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684913);
			NPCEvent_Conversate.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684914);
			NPCEvent_Conversate.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684915);
			NPCEvent_Conversate.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684916);
			NPCEvent_Conversate.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684917);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcWriter___Observers_StartWait_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684918);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcLogic___StartWait_2166136261_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684919);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcReader___Observers_StartWait_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684920);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcWriter___Observers_EndWait_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684921);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcLogic___EndWait_2166136261_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684922);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcReader___Observers_EndWait_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684923);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcWriter___Observers_StartConversate_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684924);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcLogic___StartConversate_2166136261_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684925);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcReader___Observers_StartConversate_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684926);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcWriter___Observers_EndConversate_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684927);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcLogic___EndConversate_2166136261_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684928);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcReader___Observers_EndConversate_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684929);
			NPCEvent_Conversate.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100684930);
		}

		// Token: 0x17003140 RID: 12608
		// (get) Token: 0x0600A352 RID: 41810 RVA: 0x002B6D30 File Offset: 0x002B4F30
		public new unsafe string ActionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287215, XrefRangeEnd = 287217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_get_ActionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17003141 RID: 12609
		// (get) Token: 0x0600A353 RID: 41811 RVA: 0x002B6D68 File Offset: 0x002B4F68
		public unsafe Transform StandPoint
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 287225, RefRangeEnd = 287232, XrefRangeStart = 287217, XrefRangeEnd = 287225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_get_StandPoint_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x0600A354 RID: 41812 RVA: 0x002B6DA8 File Offset: 0x002B4FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287232, XrefRangeEnd = 287246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_GetName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600A355 RID: 41813 RVA: 0x002B6DEC File Offset: 0x002B4FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287246, XrefRangeEnd = 287253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A356 RID: 41814 RVA: 0x002B6E28 File Offset: 0x002B5028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287253, XrefRangeEnd = 287258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Started()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_Started_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A357 RID: 41815 RVA: 0x002B6E64 File Offset: 0x002B5064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287258, XrefRangeEnd = 287261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_ActiveUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A358 RID: 41816 RVA: 0x002B6EA0 File Offset: 0x002B50A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287261, XrefRangeEnd = 287266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_MinPassed_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A359 RID: 41817 RVA: 0x002B6EDC File Offset: 0x002B50DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287266, XrefRangeEnd = 287271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A35A RID: 41818 RVA: 0x002B6F18 File Offset: 0x002B5118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287271, XrefRangeEnd = 287282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void JumpTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A35B RID: 41819 RVA: 0x002B6F54 File Offset: 0x002B5154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287282, XrefRangeEnd = 287284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_End_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A35C RID: 41820 RVA: 0x002B6F90 File Offset: 0x002B5190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287284, XrefRangeEnd = 287288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A35D RID: 41821 RVA: 0x002B6FCC File Offset: 0x002B51CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287288, XrefRangeEnd = 287293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A35E RID: 41822 RVA: 0x002B7008 File Offset: 0x002B5208
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 287301, RefRangeEnd = 287305, XrefRangeStart = 287293, XrefRangeEnd = 287301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A35F RID: 41823 RVA: 0x002B7044 File Offset: 0x002B5244
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 287326, RefRangeEnd = 287329, XrefRangeStart = 287305, XrefRangeEnd = 287326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanConversationStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_CanConversationStart_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A360 RID: 41824 RVA: 0x002B7080 File Offset: 0x002B5280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287329, XrefRangeEnd = 287334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WalkCallback(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A361 RID: 41825 RVA: 0x002B70CC File Offset: 0x002B52CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287334, XrefRangeEnd = 287354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartWait()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_StartWait_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A362 RID: 41826 RVA: 0x002B7108 File Offset: 0x002B5308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287354, XrefRangeEnd = 287374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndWait()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_EndWait_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A363 RID: 41827 RVA: 0x002B7144 File Offset: 0x002B5344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287374, XrefRangeEnd = 287395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartConversate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_StartConversate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A364 RID: 41828 RVA: 0x002B7180 File Offset: 0x002B5380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287395, XrefRangeEnd = 287416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndConversate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_EndConversate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A365 RID: 41829 RVA: 0x002B71BC File Offset: 0x002B53BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287416, XrefRangeEnd = 287442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCEvent_Conversate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A366 RID: 41830 RVA: 0x002B71F8 File Offset: 0x002B53F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287442, XrefRangeEnd = 287447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A367 RID: 41831 RVA: 0x002B7238 File Offset: 0x002B5438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287447, XrefRangeEnd = 287473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A368 RID: 41832 RVA: 0x002B7274 File Offset: 0x002B5474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287473, XrefRangeEnd = 287474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A369 RID: 41833 RVA: 0x002B72B0 File Offset: 0x002B54B0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A36A RID: 41834 RVA: 0x002B72EC File Offset: 0x002B54EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287474, XrefRangeEnd = 287483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartWait_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_RpcWriter___Observers_StartWait_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A36B RID: 41835 RVA: 0x002B7320 File Offset: 0x002B5520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287483, XrefRangeEnd = 287484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___StartWait_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_RpcLogic___StartWait_2166136261_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A36C RID: 41836 RVA: 0x002B735C File Offset: 0x002B555C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287484, XrefRangeEnd = 287487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartWait_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_RpcReader___Observers_StartWait_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A36D RID: 41837 RVA: 0x002B73AC File Offset: 0x002B55AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287487, XrefRangeEnd = 287496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EndWait_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_RpcWriter___Observers_EndWait_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A36E RID: 41838 RVA: 0x002B73E0 File Offset: 0x002B55E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287496, XrefRangeEnd = 287497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___EndWait_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_RpcLogic___EndWait_2166136261_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A36F RID: 41839 RVA: 0x002B741C File Offset: 0x002B561C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287497, XrefRangeEnd = 287500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EndWait_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_RpcReader___Observers_EndWait_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A370 RID: 41840 RVA: 0x002B746C File Offset: 0x002B566C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287500, XrefRangeEnd = 287509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartConversate_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_RpcWriter___Observers_StartConversate_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A371 RID: 41841 RVA: 0x002B74A0 File Offset: 0x002B56A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287520, RefRangeEnd = 287522, XrefRangeStart = 287509, XrefRangeEnd = 287520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___StartConversate_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_RpcLogic___StartConversate_2166136261_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A372 RID: 41842 RVA: 0x002B74DC File Offset: 0x002B56DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287522, XrefRangeEnd = 287525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartConversate_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_RpcReader___Observers_StartConversate_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A373 RID: 41843 RVA: 0x002B752C File Offset: 0x002B572C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287525, XrefRangeEnd = 287534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EndConversate_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_RpcWriter___Observers_EndConversate_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A374 RID: 41844 RVA: 0x002B7560 File Offset: 0x002B5760
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287538, RefRangeEnd = 287540, XrefRangeStart = 287534, XrefRangeEnd = 287538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___EndConversate_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_RpcLogic___EndConversate_2166136261_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A375 RID: 41845 RVA: 0x002B759C File Offset: 0x002B579C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287540, XrefRangeEnd = 287543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EndConversate_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_RpcReader___Observers_EndConversate_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A376 RID: 41846 RVA: 0x002B75EC File Offset: 0x002B57EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287543, XrefRangeEnd = 287544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A377 RID: 41847 RVA: 0x0004AD96 File Offset: 0x00048F96
		public NPCEvent_Conversate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003133 RID: 12595
		// (get) Token: 0x0600A378 RID: 41848 RVA: 0x002B7628 File Offset: 0x002B5828
		// (set) Token: 0x0600A379 RID: 41849 RVA: 0x0004AD9F File Offset: 0x00048F9F
		public unsafe Il2CppStructArray<EVOLineType> ConversationLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_ConversationLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<EVOLineType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_ConversationLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003134 RID: 12596
		// (get) Token: 0x0600A37A RID: 41850 RVA: 0x002B7658 File Offset: 0x002B5858
		// (set) Token: 0x0600A37B RID: 41851 RVA: 0x0004ADBE File Offset: 0x00048FBE
		public unsafe Il2CppStringArray AnimationTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_AnimationTriggers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_AnimationTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003135 RID: 12597
		// (get) Token: 0x0600A37C RID: 41852 RVA: 0x002B7688 File Offset: 0x002B5888
		// (set) Token: 0x0600A37D RID: 41853 RVA: 0x0004ADDD File Offset: 0x00048FDD
		public unsafe static float DESTINATION_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCEvent_Conversate.NativeFieldInfoPtr_DESTINATION_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCEvent_Conversate.NativeFieldInfoPtr_DESTINATION_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17003136 RID: 12598
		// (get) Token: 0x0600A37E RID: 41854 RVA: 0x002B76A4 File Offset: 0x002B58A4
		// (set) Token: 0x0600A37F RID: 41855 RVA: 0x0004ADEB File Offset: 0x00048FEB
		public unsafe static float TIME_BEFORE_WAIT_START
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCEvent_Conversate.NativeFieldInfoPtr_TIME_BEFORE_WAIT_START, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCEvent_Conversate.NativeFieldInfoPtr_TIME_BEFORE_WAIT_START, (void*)(&value));
			}
		}

		// Token: 0x17003137 RID: 12599
		// (get) Token: 0x0600A380 RID: 41856 RVA: 0x002B76C0 File Offset: 0x002B58C0
		// (set) Token: 0x0600A381 RID: 41857 RVA: 0x0004ADF9 File Offset: 0x00048FF9
		public unsafe ConversationLocation Location
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_Location);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConversationLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_Location), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003138 RID: 12600
		// (get) Token: 0x0600A382 RID: 41858 RVA: 0x002B76F0 File Offset: 0x002B58F0
		// (set) Token: 0x0600A383 RID: 41859 RVA: 0x0004AE18 File Offset: 0x00049018
		public unsafe bool IsConversating
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_IsConversating);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_IsConversating)) = value;
			}
		}

		// Token: 0x17003139 RID: 12601
		// (get) Token: 0x0600A384 RID: 41860 RVA: 0x002B7718 File Offset: 0x002B5918
		// (set) Token: 0x0600A385 RID: 41861 RVA: 0x0004AE33 File Offset: 0x00049033
		public unsafe Coroutine conversateRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_conversateRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_conversateRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700313A RID: 12602
		// (get) Token: 0x0600A386 RID: 41862 RVA: 0x002B7748 File Offset: 0x002B5948
		// (set) Token: 0x0600A387 RID: 41863 RVA: 0x0004AE52 File Offset: 0x00049052
		public unsafe bool IsWaiting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_IsWaiting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_IsWaiting)) = value;
			}
		}

		// Token: 0x1700313B RID: 12603
		// (get) Token: 0x0600A388 RID: 41864 RVA: 0x002B7770 File Offset: 0x002B5970
		// (set) Token: 0x0600A389 RID: 41865 RVA: 0x0004AE6D File Offset: 0x0004906D
		public unsafe UnityEvent OnWaitStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_OnWaitStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_OnWaitStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700313C RID: 12604
		// (get) Token: 0x0600A38A RID: 41866 RVA: 0x002B77A0 File Offset: 0x002B59A0
		// (set) Token: 0x0600A38B RID: 41867 RVA: 0x0004AE8C File Offset: 0x0004908C
		public unsafe UnityEvent OnWaitEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_OnWaitEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_OnWaitEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700313D RID: 12605
		// (get) Token: 0x0600A38C RID: 41868 RVA: 0x002B77D0 File Offset: 0x002B59D0
		// (set) Token: 0x0600A38D RID: 41869 RVA: 0x0004AEAB File Offset: 0x000490AB
		public unsafe float timeAtDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_timeAtDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_timeAtDestination)) = value;
			}
		}

		// Token: 0x1700313E RID: 12606
		// (get) Token: 0x0600A38E RID: 41870 RVA: 0x002B77F8 File Offset: 0x002B59F8
		// (set) Token: 0x0600A38F RID: 41871 RVA: 0x0004AEC6 File Offset: 0x000490C6
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700313F RID: 12607
		// (get) Token: 0x0600A390 RID: 41872 RVA: 0x002B7820 File Offset: 0x002B5A20
		// (set) Token: 0x0600A391 RID: 41873 RVA: 0x0004AEE1 File Offset: 0x000490E1
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040070D2 RID: 28882
		private static readonly IntPtr NativeFieldInfoPtr_ConversationLines;

		// Token: 0x040070D3 RID: 28883
		private static readonly IntPtr NativeFieldInfoPtr_AnimationTriggers;

		// Token: 0x040070D4 RID: 28884
		private static readonly IntPtr NativeFieldInfoPtr_DESTINATION_THRESHOLD;

		// Token: 0x040070D5 RID: 28885
		private static readonly IntPtr NativeFieldInfoPtr_TIME_BEFORE_WAIT_START;

		// Token: 0x040070D6 RID: 28886
		private static readonly IntPtr NativeFieldInfoPtr_Location;

		// Token: 0x040070D7 RID: 28887
		private static readonly IntPtr NativeFieldInfoPtr_IsConversating;

		// Token: 0x040070D8 RID: 28888
		private static readonly IntPtr NativeFieldInfoPtr_conversateRoutine;

		// Token: 0x040070D9 RID: 28889
		private static readonly IntPtr NativeFieldInfoPtr_IsWaiting;

		// Token: 0x040070DA RID: 28890
		private static readonly IntPtr NativeFieldInfoPtr_OnWaitStart;

		// Token: 0x040070DB RID: 28891
		private static readonly IntPtr NativeFieldInfoPtr_OnWaitEnd;

		// Token: 0x040070DC RID: 28892
		private static readonly IntPtr NativeFieldInfoPtr_timeAtDestination;

		// Token: 0x040070DD RID: 28893
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040070DE RID: 28894
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040070DF RID: 28895
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionName_Public_get_String_0;

		// Token: 0x040070E0 RID: 28896
		private static readonly IntPtr NativeMethodInfoPtr_get_StandPoint_Private_get_Transform_0;

		// Token: 0x040070E1 RID: 28897
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x040070E2 RID: 28898
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040070E3 RID: 28899
		private static readonly IntPtr NativeMethodInfoPtr_Started_Public_Virtual_Void_0;

		// Token: 0x040070E4 RID: 28900
		private static readonly IntPtr NativeMethodInfoPtr_ActiveUpdate_Public_Virtual_Void_0;

		// Token: 0x040070E5 RID: 28901
		private static readonly IntPtr NativeMethodInfoPtr_MinPassed_Public_Virtual_Void_0;

		// Token: 0x040070E6 RID: 28902
		private static readonly IntPtr NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0;

		// Token: 0x040070E7 RID: 28903
		private static readonly IntPtr NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0;

		// Token: 0x040070E8 RID: 28904
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Virtual_Void_0;

		// Token: 0x040070E9 RID: 28905
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0;

		// Token: 0x040070EA RID: 28906
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x040070EB RID: 28907
		private static readonly IntPtr NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0;

		// Token: 0x040070EC RID: 28908
		private static readonly IntPtr NativeMethodInfoPtr_CanConversationStart_Private_Boolean_0;

		// Token: 0x040070ED RID: 28909
		private static readonly IntPtr NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0;

		// Token: 0x040070EE RID: 28910
		private static readonly IntPtr NativeMethodInfoPtr_StartWait_Protected_Virtual_New_Void_0;

		// Token: 0x040070EF RID: 28911
		private static readonly IntPtr NativeMethodInfoPtr_EndWait_Protected_Virtual_New_Void_0;

		// Token: 0x040070F0 RID: 28912
		private static readonly IntPtr NativeMethodInfoPtr_StartConversate_Protected_Virtual_New_Void_0;

		// Token: 0x040070F1 RID: 28913
		private static readonly IntPtr NativeMethodInfoPtr_EndConversate_Protected_Virtual_New_Void_0;

		// Token: 0x040070F2 RID: 28914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040070F3 RID: 28915
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x040070F4 RID: 28916
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040070F5 RID: 28917
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040070F6 RID: 28918
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040070F7 RID: 28919
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartWait_2166136261_Private_Void_0;

		// Token: 0x040070F8 RID: 28920
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartWait_2166136261_Protected_Virtual_New_Void_0;

		// Token: 0x040070F9 RID: 28921
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartWait_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040070FA RID: 28922
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EndWait_2166136261_Private_Void_0;

		// Token: 0x040070FB RID: 28923
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EndWait_2166136261_Protected_Virtual_New_Void_0;

		// Token: 0x040070FC RID: 28924
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EndWait_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040070FD RID: 28925
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartConversate_2166136261_Private_Void_0;

		// Token: 0x040070FE RID: 28926
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartConversate_2166136261_Protected_Virtual_New_Void_0;

		// Token: 0x040070FF RID: 28927
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartConversate_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007100 RID: 28928
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EndConversate_2166136261_Private_Void_0;

		// Token: 0x04007101 RID: 28929
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EndConversate_2166136261_Protected_Virtual_New_Void_0;

		// Token: 0x04007102 RID: 28930
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EndConversate_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007103 RID: 28931
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000C70 RID: 3184
		[ObfuscatedName("ScheduleOne.NPCs.Schedules.NPCEvent_Conversate+<<StartConversate>g__Routine|30_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600F194 RID: 61844 RVA: 0x003A43C0 File Offset: 0x003A25C0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique()
			{
				Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "<<StartConversate>g__Routine|30_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr);
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, "<>1__state");
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, "<>2__current");
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, "<>4__this");
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr__wait_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, "<wait>5__2");
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr__otherNPC_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, "<otherNPC>5__3");
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr__t_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, "<t>5__4");
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, 100684931);
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, 100684932);
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, 100684933);
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, 100684934);
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, 100684935);
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, 100684936);
			}

			// Token: 0x0600F195 RID: 61845 RVA: 0x003A44DC File Offset: 0x003A26DC
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F196 RID: 61846 RVA: 0x003A4524 File Offset: 0x003A2724
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F197 RID: 61847 RVA: 0x003A4558 File Offset: 0x003A2758
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287160, XrefRangeEnd = 287210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004959 RID: 18777
			// (get) Token: 0x0600F198 RID: 61848 RVA: 0x003A4594 File Offset: 0x003A2794
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F199 RID: 61849 RVA: 0x003A45D4 File Offset: 0x003A27D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287210, XrefRangeEnd = 287215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700495A RID: 18778
			// (get) Token: 0x0600F19A RID: 61850 RVA: 0x003A4608 File Offset: 0x003A2808
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F19B RID: 61851 RVA: 0x00072018 File Offset: 0x00070218
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004953 RID: 18771
			// (get) Token: 0x0600F19C RID: 61852 RVA: 0x003A4648 File Offset: 0x003A2848
			// (set) Token: 0x0600F19D RID: 61853 RVA: 0x00072021 File Offset: 0x00070221
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004954 RID: 18772
			// (get) Token: 0x0600F19E RID: 61854 RVA: 0x003A4670 File Offset: 0x003A2870
			// (set) Token: 0x0600F19F RID: 61855 RVA: 0x0007203C File Offset: 0x0007023C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004955 RID: 18773
			// (get) Token: 0x0600F1A0 RID: 61856 RVA: 0x003A46A0 File Offset: 0x003A28A0
			// (set) Token: 0x0600F1A1 RID: 61857 RVA: 0x0007205B File Offset: 0x0007025B
			public unsafe NPCEvent_Conversate __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEvent_Conversate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004956 RID: 18774
			// (get) Token: 0x0600F1A2 RID: 61858 RVA: 0x003A46D0 File Offset: 0x003A28D0
			// (set) Token: 0x0600F1A3 RID: 61859 RVA: 0x0007207A File Offset: 0x0007027A
			public unsafe float _wait_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr__wait_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr__wait_5__2)) = value;
				}
			}

			// Token: 0x17004957 RID: 18775
			// (get) Token: 0x0600F1A4 RID: 61860 RVA: 0x003A46F8 File Offset: 0x003A28F8
			// (set) Token: 0x0600F1A5 RID: 61861 RVA: 0x00072095 File Offset: 0x00070295
			public unsafe NPC _otherNPC_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr__otherNPC_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr__otherNPC_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004958 RID: 18776
			// (get) Token: 0x0600F1A6 RID: 61862 RVA: 0x003A4728 File Offset: 0x003A2928
			// (set) Token: 0x0600F1A7 RID: 61863 RVA: 0x000720B4 File Offset: 0x000702B4
			public unsafe float _t_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr__t_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr__t_5__4)) = value;
				}
			}

			// Token: 0x0400A387 RID: 41863
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A388 RID: 41864
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A389 RID: 41865
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A38A RID: 41866
			private static readonly IntPtr NativeFieldInfoPtr__wait_5__2;

			// Token: 0x0400A38B RID: 41867
			private static readonly IntPtr NativeFieldInfoPtr__otherNPC_5__3;

			// Token: 0x0400A38C RID: 41868
			private static readonly IntPtr NativeFieldInfoPtr__t_5__4;

			// Token: 0x0400A38D RID: 41869
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A38E RID: 41870
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A38F RID: 41871
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A390 RID: 41872
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A391 RID: 41873
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A392 RID: 41874
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
