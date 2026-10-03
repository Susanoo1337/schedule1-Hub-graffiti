using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.NPCs.CharacterClasses;
using Il2CppScheduleOne.ScriptableObjects;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x02000157 RID: 343
	public class Quest_TheDeepEnd : Quest
	{
		// Token: 0x06002208 RID: 8712 RVA: 0x000EB740 File Offset: 0x000E9940
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_TheDeepEnd()
		{
			Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_TheDeepEnd");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr);
			Quest_TheDeepEnd.NativeFieldInfoPtr_MEETING_REMINDER_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "MEETING_REMINDER_TIME");
			Quest_TheDeepEnd.NativeFieldInfoPtr_KIDNAP_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "KIDNAP_TIME");
			Quest_TheDeepEnd.NativeFieldInfoPtr_kidnapQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "kidnapQueued");
			Quest_TheDeepEnd.NativeFieldInfoPtr_meetingSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "meetingSetup");
			Quest_TheDeepEnd.NativeFieldInfoPtr_Thomas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "Thomas");
			Quest_TheDeepEnd.NativeFieldInfoPtr_Gate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "Gate");
			Quest_TheDeepEnd.NativeFieldInfoPtr_Switch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "Switch");
			Quest_TheDeepEnd.NativeFieldInfoPtr_MeetingTeleportPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "MeetingTeleportPoint");
			Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "PostMeetingCall");
			Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "PostMeetingTrigger");
			Quest_TheDeepEnd.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667695);
			Quest_TheDeepEnd.NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667696);
			Quest_TheDeepEnd.NativeMethodInfoPtr_SetupFirstMeeting_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667697);
			Quest_TheDeepEnd.NativeMethodInfoPtr_ThomasDialogueNodeDisplayed_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667698);
			Quest_TheDeepEnd.NativeMethodInfoPtr_HourPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667699);
			Quest_TheDeepEnd.NativeMethodInfoPtr_BeforeSleep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667700);
			Quest_TheDeepEnd.NativeMethodInfoPtr_SleepFadeOut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667701);
			Quest_TheDeepEnd.NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_Void_Int32_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667702);
			Quest_TheDeepEnd.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667703);
			Quest_TheDeepEnd.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667704);
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x000EB900 File Offset: 0x000E9B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111306, XrefRangeEnd = 111351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_TheDeepEnd.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x000EB93C File Offset: 0x000E9B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111351, XrefRangeEnd = 111353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_TheDeepEnd.NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x000EB988 File Offset: 0x000E9B88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111365, RefRangeEnd = 111367, XrefRangeStart = 111353, XrefRangeEnd = 111365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupFirstMeeting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_SetupFirstMeeting_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x000EB9BC File Offset: 0x000E9BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111367, XrefRangeEnd = 111389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThomasDialogueNodeDisplayed(string nodeLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(nodeLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_ThomasDialogueNodeDisplayed_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x000EBA00 File Offset: 0x000E9C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111389, XrefRangeEnd = 111412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_HourPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x000EBA34 File Offset: 0x000E9C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111412, XrefRangeEnd = 111419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeforeSleep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_BeforeSleep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x000EBA68 File Offset: 0x000E9C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111419, XrefRangeEnd = 111432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepFadeOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_SleepFadeOut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x000EBA9C File Offset: 0x000E9C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111432, XrefRangeEnd = 111437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetQuestEntryState(int entryIndex, EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref entryIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_TheDeepEnd.NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_Void_Int32_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x000EBB04 File Offset: 0x000E9D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111437, XrefRangeEnd = 111441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_TheDeepEnd() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x000EBB40 File Offset: 0x000E9D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111441, XrefRangeEnd = 111446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x00012229 File Offset: 0x00010429
		public Quest_TheDeepEnd(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06002214 RID: 8724 RVA: 0x000EBB80 File Offset: 0x000E9D80
		// (set) Token: 0x06002215 RID: 8725 RVA: 0x00012232 File Offset: 0x00010432
		public unsafe static float MEETING_REMINDER_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Quest_TheDeepEnd.NativeFieldInfoPtr_MEETING_REMINDER_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest_TheDeepEnd.NativeFieldInfoPtr_MEETING_REMINDER_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x000EBB9C File Offset: 0x000E9D9C
		// (set) Token: 0x06002217 RID: 8727 RVA: 0x00012240 File Offset: 0x00010440
		public unsafe static float KIDNAP_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Quest_TheDeepEnd.NativeFieldInfoPtr_KIDNAP_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest_TheDeepEnd.NativeFieldInfoPtr_KIDNAP_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06002218 RID: 8728 RVA: 0x000EBBB8 File Offset: 0x000E9DB8
		// (set) Token: 0x06002219 RID: 8729 RVA: 0x0001224E File Offset: 0x0001044E
		public unsafe bool kidnapQueued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_kidnapQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_kidnapQueued)) = value;
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x0600221A RID: 8730 RVA: 0x000EBBE0 File Offset: 0x000E9DE0
		// (set) Token: 0x0600221B RID: 8731 RVA: 0x00012269 File Offset: 0x00010469
		public unsafe bool meetingSetup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_meetingSetup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_meetingSetup)) = value;
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x0600221C RID: 8732 RVA: 0x000EBC08 File Offset: 0x000E9E08
		// (set) Token: 0x0600221D RID: 8733 RVA: 0x00012284 File Offset: 0x00010484
		public unsafe Thomas Thomas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Thomas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thomas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Thomas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x0600221E RID: 8734 RVA: 0x000EBC38 File Offset: 0x000E9E38
		// (set) Token: 0x0600221F RID: 8735 RVA: 0x000122A3 File Offset: 0x000104A3
		public unsafe ManorGate Gate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Gate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManorGate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Gate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06002220 RID: 8736 RVA: 0x000EBC68 File Offset: 0x000E9E68
		// (set) Token: 0x06002221 RID: 8737 RVA: 0x000122C2 File Offset: 0x000104C2
		public unsafe ModularSwitch Switch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Switch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModularSwitch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Switch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06002222 RID: 8738 RVA: 0x000EBC98 File Offset: 0x000E9E98
		// (set) Token: 0x06002223 RID: 8739 RVA: 0x000122E1 File Offset: 0x000104E1
		public unsafe Transform MeetingTeleportPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_MeetingTeleportPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_MeetingTeleportPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06002224 RID: 8740 RVA: 0x000EBCC8 File Offset: 0x000E9EC8
		// (set) Token: 0x06002225 RID: 8741 RVA: 0x00012300 File Offset: 0x00010500
		public unsafe PhoneCallData PostMeetingCall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingCall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingCall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06002226 RID: 8742 RVA: 0x000EBCF8 File Offset: 0x000E9EF8
		// (set) Token: 0x06002227 RID: 8743 RVA: 0x0001231F File Offset: 0x0001051F
		public unsafe SystemTriggerObject PostMeetingTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SystemTriggerObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001788 RID: 6024
		private static readonly IntPtr NativeFieldInfoPtr_MEETING_REMINDER_TIME;

		// Token: 0x04001789 RID: 6025
		private static readonly IntPtr NativeFieldInfoPtr_KIDNAP_TIME;

		// Token: 0x0400178A RID: 6026
		private static readonly IntPtr NativeFieldInfoPtr_kidnapQueued;

		// Token: 0x0400178B RID: 6027
		private static readonly IntPtr NativeFieldInfoPtr_meetingSetup;

		// Token: 0x0400178C RID: 6028
		private static readonly IntPtr NativeFieldInfoPtr_Thomas;

		// Token: 0x0400178D RID: 6029
		private static readonly IntPtr NativeFieldInfoPtr_Gate;

		// Token: 0x0400178E RID: 6030
		private static readonly IntPtr NativeFieldInfoPtr_Switch;

		// Token: 0x0400178F RID: 6031
		private static readonly IntPtr NativeFieldInfoPtr_MeetingTeleportPoint;

		// Token: 0x04001790 RID: 6032
		private static readonly IntPtr NativeFieldInfoPtr_PostMeetingCall;

		// Token: 0x04001791 RID: 6033
		private static readonly IntPtr NativeFieldInfoPtr_PostMeetingTrigger;

		// Token: 0x04001792 RID: 6034
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001793 RID: 6035
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0;

		// Token: 0x04001794 RID: 6036
		private static readonly IntPtr NativeMethodInfoPtr_SetupFirstMeeting_Public_Void_0;

		// Token: 0x04001795 RID: 6037
		private static readonly IntPtr NativeMethodInfoPtr_ThomasDialogueNodeDisplayed_Private_Void_String_0;

		// Token: 0x04001796 RID: 6038
		private static readonly IntPtr NativeMethodInfoPtr_HourPass_Private_Void_0;

		// Token: 0x04001797 RID: 6039
		private static readonly IntPtr NativeMethodInfoPtr_BeforeSleep_Private_Void_0;

		// Token: 0x04001798 RID: 6040
		private static readonly IntPtr NativeMethodInfoPtr_SleepFadeOut_Private_Void_0;

		// Token: 0x04001799 RID: 6041
		private static readonly IntPtr NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_Void_Int32_EQuestState_Boolean_0;

		// Token: 0x0400179A RID: 6042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400179B RID: 6043
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x0200096E RID: 2414
		[ObfuscatedName("ScheduleOne.Quests.Quest_TheDeepEnd+<<ThomasDialogueNodeDisplayed>g__Wait|13_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D969 RID: 55657 RVA: 0x0035F548 File Offset: 0x0035D748
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique()
			{
				Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "<<ThomasDialogueNodeDisplayed>g__Wait|13_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, "<>1__state");
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, "<>2__current");
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, "<>4__this");
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667705);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667706);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667707);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667708);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667709);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667710);
			}

			// Token: 0x0600D96A RID: 55658 RVA: 0x0035F628 File Offset: 0x0035D828
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D96B RID: 55659 RVA: 0x0035F670 File Offset: 0x0035D870
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D96C RID: 55660 RVA: 0x0035F6A4 File Offset: 0x0035D8A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111271, XrefRangeEnd = 111292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004267 RID: 16999
			// (get) Token: 0x0600D96D RID: 55661 RVA: 0x0035F6E0 File Offset: 0x0035D8E0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D96E RID: 55662 RVA: 0x0035F720 File Offset: 0x0035D920
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111292, XrefRangeEnd = 111297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004268 RID: 17000
			// (get) Token: 0x0600D96F RID: 55663 RVA: 0x0035F754 File Offset: 0x0035D954
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D970 RID: 55664 RVA: 0x000663C2 File Offset: 0x000645C2
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004264 RID: 16996
			// (get) Token: 0x0600D971 RID: 55665 RVA: 0x0035F794 File Offset: 0x0035D994
			// (set) Token: 0x0600D972 RID: 55666 RVA: 0x000663CB File Offset: 0x000645CB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004265 RID: 16997
			// (get) Token: 0x0600D973 RID: 55667 RVA: 0x0035F7BC File Offset: 0x0035D9BC
			// (set) Token: 0x0600D974 RID: 55668 RVA: 0x000663E6 File Offset: 0x000645E6
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004266 RID: 16998
			// (get) Token: 0x0600D975 RID: 55669 RVA: 0x0035F7EC File Offset: 0x0035D9EC
			// (set) Token: 0x0600D976 RID: 55670 RVA: 0x00066405 File Offset: 0x00064605
			public unsafe Quest_TheDeepEnd __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest_TheDeepEnd>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009468 RID: 37992
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009469 RID: 37993
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400946A RID: 37994
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400946B RID: 37995
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400946C RID: 37996
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400946D RID: 37997
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400946E RID: 37998
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400946F RID: 37999
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009470 RID: 38000
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200096F RID: 2415
		[ObfuscatedName("ScheduleOne.Quests.Quest_TheDeepEnd+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D977 RID: 55671 RVA: 0x0035F81C File Offset: 0x0035DA1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr);
				Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr, "<>9");
				Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr, "<>9__13_1");
				Quest_TheDeepEnd.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr, 100667712);
				Quest_TheDeepEnd.__c.NativeMethodInfoPtr__ThomasDialogueNodeDisplayed_b__13_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr, 100667713);
			}

			// Token: 0x0600D978 RID: 55672 RVA: 0x0035F898 File Offset: 0x0035DA98
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D979 RID: 55673 RVA: 0x0035F8D4 File Offset: 0x0035DAD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111297, XrefRangeEnd = 111306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ThomasDialogueNodeDisplayed_b__13_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.__c.NativeMethodInfoPtr__ThomasDialogueNodeDisplayed_b__13_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D97A RID: 55674 RVA: 0x00066424 File Offset: 0x00064624
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004269 RID: 17001
			// (get) Token: 0x0600D97B RID: 55675 RVA: 0x0035F910 File Offset: 0x0035DB10
			// (set) Token: 0x0600D97C RID: 55676 RVA: 0x0006642D File Offset: 0x0006462D
			public unsafe static Quest_TheDeepEnd.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest_TheDeepEnd.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700426A RID: 17002
			// (get) Token: 0x0600D97D RID: 55677 RVA: 0x0035F938 File Offset: 0x0035DB38
			// (set) Token: 0x0600D97E RID: 55678 RVA: 0x0006643F File Offset: 0x0006463F
			public unsafe static Func<bool> __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009471 RID: 38001
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009472 RID: 38002
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x04009473 RID: 38003
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009474 RID: 38004
			private static readonly IntPtr NativeMethodInfoPtr__ThomasDialogueNodeDisplayed_b__13_1_Internal_Boolean_0;
		}
	}
}
