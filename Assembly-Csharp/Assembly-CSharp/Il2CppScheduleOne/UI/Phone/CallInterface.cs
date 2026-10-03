using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ScriptableObjects;
using Il2CppScheduleOne.State;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Text.RegularExpressions;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020007A9 RID: 1961
	public class CallInterface : Singleton<CallInterface>
	{
		// Token: 0x0600BE23 RID: 48675 RVA: 0x0030B2E8 File Offset: 0x003094E8
		// Note: this type is marked as 'beforefieldinit'.
		static CallInterface()
		{
			Il2CppClassPointerStore<CallInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "CallInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallInterface>.NativeClassPtr);
			CallInterface.NativeFieldInfoPtr_TimePerChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "TimePerChar");
			CallInterface.NativeFieldInfoPtr__ActiveCallData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "<ActiveCallData>k__BackingField");
			CallInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			CallInterface.NativeFieldInfoPtr_CallEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "CallEnded");
			CallInterface.NativeFieldInfoPtr_CallCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "CallCompleted");
			CallInterface.NativeFieldInfoPtr_CallStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "CallStarted");
			CallInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "Canvas");
			CallInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "Container");
			CallInterface.NativeFieldInfoPtr_ProfilePicture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "ProfilePicture");
			CallInterface.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "NameLabel");
			CallInterface.NativeFieldInfoPtr_MainText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "MainText");
			CallInterface.NativeFieldInfoPtr_ContinuePrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "ContinuePrompt");
			CallInterface.NativeFieldInfoPtr_OpenAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "OpenAnim");
			CallInterface.NativeFieldInfoPtr_TypewriterEffectSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "TypewriterEffectSound");
			CallInterface.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "CanvasGroup");
			CallInterface.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "State");
			CallInterface.NativeFieldInfoPtr_Highlight1Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "Highlight1Color");
			CallInterface.NativeFieldInfoPtr_currentCallStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "currentCallStage");
			CallInterface.NativeFieldInfoPtr_slideRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "slideRoutine");
			CallInterface.NativeFieldInfoPtr_skipRollout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "skipRollout");
			CallInterface.NativeFieldInfoPtr_rolloutRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "rolloutRoutine");
			CallInterface.NativeFieldInfoPtr_highlight1Hex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "highlight1Hex");
			CallInterface.NativeMethodInfoPtr_get_ActiveCallData_Public_get_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100688092);
			CallInterface.NativeMethodInfoPtr_set_ActiveCallData_Private_set_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100688093);
			CallInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100688094);
			CallInterface.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100688095);
			CallInterface.NativeMethodInfoPtr_add_CallEnded_Public_add_Void_Action_1_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100688096);
			CallInterface.NativeMethodInfoPtr_remove_CallEnded_Public_rem_Void_Action_1_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100688097);
			CallInterface.NativeMethodInfoPtr_add_CallCompleted_Public_add_Void_Action_1_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100688098);
			CallInterface.NativeMethodInfoPtr_remove_CallCompleted_Public_rem_Void_Action_1_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100688099);
			CallInterface.NativeMethodInfoPtr_add_CallStarted_Public_add_Void_Action_1_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100688100);
			CallInterface.NativeMethodInfoPtr_remove_CallStarted_Public_rem_Void_Action_1_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100688101);
			CallInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100688102);
			CallInterface.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100688103);
			CallInterface.NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_CallerID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100688104);
			CallInterface.NativeMethodInfoPtr_CompleteCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100688105);
			CallInterface.NativeMethodInfoPtr_Close_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100688106);
			CallInterface.NativeMethodInfoPtr_OnClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100688107);
			CallInterface.NativeMethodInfoPtr_Continue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100688108);
			CallInterface.NativeMethodInfoPtr_ShowStage_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100688109);
			CallInterface.NativeMethodInfoPtr_ProcessText_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100688110);
			CallInterface.NativeMethodInfoPtr_GetVisibleText_Private_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100688111);
			CallInterface.NativeMethodInfoPtr_SetIsVisible_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100688112);
			CallInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100688113);
			CallInterface.NativeMethodInfoPtr__ProcessText_b__42_0_Private_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100688114);
		}

		// Token: 0x17003980 RID: 14720
		// (get) Token: 0x0600BE24 RID: 48676 RVA: 0x0030B69C File Offset: 0x0030989C
		// (set) Token: 0x0600BE25 RID: 48677 RVA: 0x0030B6DC File Offset: 0x003098DC
		public unsafe PhoneCallData ActiveCallData
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_get_ActiveCallData_Public_get_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_set_ActiveCallData_Private_set_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003981 RID: 14721
		// (get) Token: 0x0600BE26 RID: 48678 RVA: 0x0030B720 File Offset: 0x00309920
		// (set) Token: 0x0600BE27 RID: 48679 RVA: 0x0030B75C File Offset: 0x0030995C
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600BE28 RID: 48680 RVA: 0x0030B79C File Offset: 0x0030999C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316650, RefRangeEnd = 316651, XrefRangeStart = 316645, XrefRangeEnd = 316650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_CallEnded(Action<PhoneCallData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_add_CallEnded_Public_add_Void_Action_1_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE29 RID: 48681 RVA: 0x0030B7E0 File Offset: 0x003099E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316651, XrefRangeEnd = 316656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_CallEnded(Action<PhoneCallData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_remove_CallEnded_Public_rem_Void_Action_1_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE2A RID: 48682 RVA: 0x0030B824 File Offset: 0x00309A24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316661, RefRangeEnd = 316663, XrefRangeStart = 316656, XrefRangeEnd = 316661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_CallCompleted(Action<PhoneCallData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_add_CallCompleted_Public_add_Void_Action_1_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE2B RID: 48683 RVA: 0x0030B868 File Offset: 0x00309A68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316668, RefRangeEnd = 316670, XrefRangeStart = 316663, XrefRangeEnd = 316668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_CallCompleted(Action<PhoneCallData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_remove_CallCompleted_Public_rem_Void_Action_1_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE2C RID: 48684 RVA: 0x0030B8AC File Offset: 0x00309AAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316675, RefRangeEnd = 316676, XrefRangeStart = 316670, XrefRangeEnd = 316675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_CallStarted(Action<PhoneCallData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_add_CallStarted_Public_add_Void_Action_1_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE2D RID: 48685 RVA: 0x0030B8F0 File Offset: 0x00309AF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316681, RefRangeEnd = 316682, XrefRangeStart = 316676, XrefRangeEnd = 316681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_CallStarted(Action<PhoneCallData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_remove_CallStarted_Public_rem_Void_Action_1_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE2E RID: 48686 RVA: 0x0030B934 File Offset: 0x00309B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316682, XrefRangeEnd = 316703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE2F RID: 48687 RVA: 0x0030B970 File Offset: 0x00309B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316703, XrefRangeEnd = 316716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE30 RID: 48688 RVA: 0x0030B9A4 File Offset: 0x00309BA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316744, RefRangeEnd = 316745, XrefRangeStart = 316716, XrefRangeEnd = 316744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartCall(PhoneCallData data, CallerID caller, int startStage = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caller);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startStage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_CallerID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE31 RID: 48689 RVA: 0x0030BA08 File Offset: 0x00309C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316745, XrefRangeEnd = 316758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_CompleteCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE32 RID: 48690 RVA: 0x0030BA3C File Offset: 0x00309C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316758, XrefRangeEnd = 316760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_Close_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE33 RID: 48691 RVA: 0x0030BA70 File Offset: 0x00309C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316760, XrefRangeEnd = 316782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_OnClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE34 RID: 48692 RVA: 0x0030BAA4 File Offset: 0x00309CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316782, XrefRangeEnd = 316798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Continue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_Continue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE35 RID: 48693 RVA: 0x0030BAD8 File Offset: 0x00309CD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 316813, RefRangeEnd = 316816, XrefRangeStart = 316798, XrefRangeEnd = 316813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowStage(int stageIndex, float initialDelay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stageIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_ShowStage_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE36 RID: 48694 RVA: 0x0030BB24 File Offset: 0x00309D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316816, XrefRangeEnd = 316842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ProcessText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_ProcessText_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600BE37 RID: 48695 RVA: 0x0030BB6C File Offset: 0x00309D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316842, XrefRangeEnd = 316844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetVisibleText(int charactersShown, string fullText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref charactersShown;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fullText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_GetVisibleText_Private_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600BE38 RID: 48696 RVA: 0x0030BBC4 File Offset: 0x00309DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316844, XrefRangeEnd = 316854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_SetIsVisible_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE39 RID: 48697 RVA: 0x0030BC04 File Offset: 0x00309E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316854, XrefRangeEnd = 316857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE3A RID: 48698 RVA: 0x0030BC40 File Offset: 0x00309E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316857, XrefRangeEnd = 316872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _ProcessText_b__42_0(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr__ProcessText_b__42_0_Private_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600BE3B RID: 48699 RVA: 0x00058C6D File Offset: 0x00056E6D
		public CallInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700396A RID: 14698
		// (get) Token: 0x0600BE3C RID: 48700 RVA: 0x0030BC88 File Offset: 0x00309E88
		// (set) Token: 0x0600BE3D RID: 48701 RVA: 0x00058C76 File Offset: 0x00056E76
		public unsafe static float TimePerChar
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CallInterface.NativeFieldInfoPtr_TimePerChar, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallInterface.NativeFieldInfoPtr_TimePerChar, (void*)(&value));
			}
		}

		// Token: 0x1700396B RID: 14699
		// (get) Token: 0x0600BE3E RID: 48702 RVA: 0x0030BCA4 File Offset: 0x00309EA4
		// (set) Token: 0x0600BE3F RID: 48703 RVA: 0x00058C84 File Offset: 0x00056E84
		public unsafe PhoneCallData _ActiveCallData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr__ActiveCallData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr__ActiveCallData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700396C RID: 14700
		// (get) Token: 0x0600BE40 RID: 48704 RVA: 0x0030BCD4 File Offset: 0x00309ED4
		// (set) Token: 0x0600BE41 RID: 48705 RVA: 0x00058CA3 File Offset: 0x00056EA3
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700396D RID: 14701
		// (get) Token: 0x0600BE42 RID: 48706 RVA: 0x0030BCFC File Offset: 0x00309EFC
		// (set) Token: 0x0600BE43 RID: 48707 RVA: 0x00058CBE File Offset: 0x00056EBE
		public unsafe Action<PhoneCallData> CallEnded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_CallEnded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PhoneCallData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_CallEnded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700396E RID: 14702
		// (get) Token: 0x0600BE44 RID: 48708 RVA: 0x0030BD2C File Offset: 0x00309F2C
		// (set) Token: 0x0600BE45 RID: 48709 RVA: 0x00058CDD File Offset: 0x00056EDD
		public unsafe Action<PhoneCallData> CallCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_CallCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PhoneCallData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_CallCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700396F RID: 14703
		// (get) Token: 0x0600BE46 RID: 48710 RVA: 0x0030BD5C File Offset: 0x00309F5C
		// (set) Token: 0x0600BE47 RID: 48711 RVA: 0x00058CFC File Offset: 0x00056EFC
		public unsafe Action<PhoneCallData> CallStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_CallStarted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PhoneCallData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_CallStarted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003970 RID: 14704
		// (get) Token: 0x0600BE48 RID: 48712 RVA: 0x0030BD8C File Offset: 0x00309F8C
		// (set) Token: 0x0600BE49 RID: 48713 RVA: 0x00058D1B File Offset: 0x00056F1B
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003971 RID: 14705
		// (get) Token: 0x0600BE4A RID: 48714 RVA: 0x0030BDBC File Offset: 0x00309FBC
		// (set) Token: 0x0600BE4B RID: 48715 RVA: 0x00058D3A File Offset: 0x00056F3A
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003972 RID: 14706
		// (get) Token: 0x0600BE4C RID: 48716 RVA: 0x0030BDEC File Offset: 0x00309FEC
		// (set) Token: 0x0600BE4D RID: 48717 RVA: 0x00058D59 File Offset: 0x00056F59
		public unsafe Image ProfilePicture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_ProfilePicture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_ProfilePicture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003973 RID: 14707
		// (get) Token: 0x0600BE4E RID: 48718 RVA: 0x0030BE1C File Offset: 0x0030A01C
		// (set) Token: 0x0600BE4F RID: 48719 RVA: 0x00058D78 File Offset: 0x00056F78
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003974 RID: 14708
		// (get) Token: 0x0600BE50 RID: 48720 RVA: 0x0030BE4C File Offset: 0x0030A04C
		// (set) Token: 0x0600BE51 RID: 48721 RVA: 0x00058D97 File Offset: 0x00056F97
		public unsafe TextMeshProUGUI MainText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_MainText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_MainText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003975 RID: 14709
		// (get) Token: 0x0600BE52 RID: 48722 RVA: 0x0030BE7C File Offset: 0x0030A07C
		// (set) Token: 0x0600BE53 RID: 48723 RVA: 0x00058DB6 File Offset: 0x00056FB6
		public unsafe Transform ContinuePrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_ContinuePrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_ContinuePrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003976 RID: 14710
		// (get) Token: 0x0600BE54 RID: 48724 RVA: 0x0030BEAC File Offset: 0x0030A0AC
		// (set) Token: 0x0600BE55 RID: 48725 RVA: 0x00058DD5 File Offset: 0x00056FD5
		public unsafe Animation OpenAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_OpenAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_OpenAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003977 RID: 14711
		// (get) Token: 0x0600BE56 RID: 48726 RVA: 0x0030BEDC File Offset: 0x0030A0DC
		// (set) Token: 0x0600BE57 RID: 48727 RVA: 0x00058DF4 File Offset: 0x00056FF4
		public unsafe AudioSourceController TypewriterEffectSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_TypewriterEffectSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_TypewriterEffectSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003978 RID: 14712
		// (get) Token: 0x0600BE58 RID: 48728 RVA: 0x0030BF0C File Offset: 0x0030A10C
		// (set) Token: 0x0600BE59 RID: 48729 RVA: 0x00058E13 File Offset: 0x00057013
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003979 RID: 14713
		// (get) Token: 0x0600BE5A RID: 48730 RVA: 0x0030BF3C File Offset: 0x0030A13C
		// (set) Token: 0x0600BE5B RID: 48731 RVA: 0x00058E32 File Offset: 0x00057032
		public unsafe MonoState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700397A RID: 14714
		// (get) Token: 0x0600BE5C RID: 48732 RVA: 0x0030BF6C File Offset: 0x0030A16C
		// (set) Token: 0x0600BE5D RID: 48733 RVA: 0x00058E51 File Offset: 0x00057051
		public unsafe Color Highlight1Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Highlight1Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Highlight1Color)) = value;
			}
		}

		// Token: 0x1700397B RID: 14715
		// (get) Token: 0x0600BE5E RID: 48734 RVA: 0x0030BF94 File Offset: 0x0030A194
		// (set) Token: 0x0600BE5F RID: 48735 RVA: 0x00058E6C File Offset: 0x0005706C
		public unsafe int currentCallStage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_currentCallStage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_currentCallStage)) = value;
			}
		}

		// Token: 0x1700397C RID: 14716
		// (get) Token: 0x0600BE60 RID: 48736 RVA: 0x0030BFBC File Offset: 0x0030A1BC
		// (set) Token: 0x0600BE61 RID: 48737 RVA: 0x00058E87 File Offset: 0x00057087
		public unsafe Coroutine slideRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_slideRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_slideRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700397D RID: 14717
		// (get) Token: 0x0600BE62 RID: 48738 RVA: 0x0030BFEC File Offset: 0x0030A1EC
		// (set) Token: 0x0600BE63 RID: 48739 RVA: 0x00058EA6 File Offset: 0x000570A6
		public unsafe bool skipRollout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_skipRollout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_skipRollout)) = value;
			}
		}

		// Token: 0x1700397E RID: 14718
		// (get) Token: 0x0600BE64 RID: 48740 RVA: 0x0030C014 File Offset: 0x0030A214
		// (set) Token: 0x0600BE65 RID: 48741 RVA: 0x00058EC1 File Offset: 0x000570C1
		public unsafe Coroutine rolloutRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_rolloutRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_rolloutRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700397F RID: 14719
		// (get) Token: 0x0600BE66 RID: 48742 RVA: 0x0030C044 File Offset: 0x0030A244
		// (set) Token: 0x0600BE67 RID: 48743 RVA: 0x00058EE0 File Offset: 0x000570E0
		public unsafe string highlight1Hex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_highlight1Hex);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_highlight1Hex), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04008231 RID: 33329
		private static readonly IntPtr NativeFieldInfoPtr_TimePerChar;

		// Token: 0x04008232 RID: 33330
		private static readonly IntPtr NativeFieldInfoPtr__ActiveCallData_k__BackingField;

		// Token: 0x04008233 RID: 33331
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04008234 RID: 33332
		private static readonly IntPtr NativeFieldInfoPtr_CallEnded;

		// Token: 0x04008235 RID: 33333
		private static readonly IntPtr NativeFieldInfoPtr_CallCompleted;

		// Token: 0x04008236 RID: 33334
		private static readonly IntPtr NativeFieldInfoPtr_CallStarted;

		// Token: 0x04008237 RID: 33335
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04008238 RID: 33336
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04008239 RID: 33337
		private static readonly IntPtr NativeFieldInfoPtr_ProfilePicture;

		// Token: 0x0400823A RID: 33338
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x0400823B RID: 33339
		private static readonly IntPtr NativeFieldInfoPtr_MainText;

		// Token: 0x0400823C RID: 33340
		private static readonly IntPtr NativeFieldInfoPtr_ContinuePrompt;

		// Token: 0x0400823D RID: 33341
		private static readonly IntPtr NativeFieldInfoPtr_OpenAnim;

		// Token: 0x0400823E RID: 33342
		private static readonly IntPtr NativeFieldInfoPtr_TypewriterEffectSound;

		// Token: 0x0400823F RID: 33343
		private static readonly IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x04008240 RID: 33344
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04008241 RID: 33345
		private static readonly IntPtr NativeFieldInfoPtr_Highlight1Color;

		// Token: 0x04008242 RID: 33346
		private static readonly IntPtr NativeFieldInfoPtr_currentCallStage;

		// Token: 0x04008243 RID: 33347
		private static readonly IntPtr NativeFieldInfoPtr_slideRoutine;

		// Token: 0x04008244 RID: 33348
		private static readonly IntPtr NativeFieldInfoPtr_skipRollout;

		// Token: 0x04008245 RID: 33349
		private static readonly IntPtr NativeFieldInfoPtr_rolloutRoutine;

		// Token: 0x04008246 RID: 33350
		private static readonly IntPtr NativeFieldInfoPtr_highlight1Hex;

		// Token: 0x04008247 RID: 33351
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveCallData_Public_get_PhoneCallData_0;

		// Token: 0x04008248 RID: 33352
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveCallData_Private_set_Void_PhoneCallData_0;

		// Token: 0x04008249 RID: 33353
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400824A RID: 33354
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x0400824B RID: 33355
		private static readonly IntPtr NativeMethodInfoPtr_add_CallEnded_Public_add_Void_Action_1_PhoneCallData_0;

		// Token: 0x0400824C RID: 33356
		private static readonly IntPtr NativeMethodInfoPtr_remove_CallEnded_Public_rem_Void_Action_1_PhoneCallData_0;

		// Token: 0x0400824D RID: 33357
		private static readonly IntPtr NativeMethodInfoPtr_add_CallCompleted_Public_add_Void_Action_1_PhoneCallData_0;

		// Token: 0x0400824E RID: 33358
		private static readonly IntPtr NativeMethodInfoPtr_remove_CallCompleted_Public_rem_Void_Action_1_PhoneCallData_0;

		// Token: 0x0400824F RID: 33359
		private static readonly IntPtr NativeMethodInfoPtr_add_CallStarted_Public_add_Void_Action_1_PhoneCallData_0;

		// Token: 0x04008250 RID: 33360
		private static readonly IntPtr NativeMethodInfoPtr_remove_CallStarted_Public_rem_Void_Action_1_PhoneCallData_0;

		// Token: 0x04008251 RID: 33361
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04008252 RID: 33362
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04008253 RID: 33363
		private static readonly IntPtr NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_CallerID_Int32_0;

		// Token: 0x04008254 RID: 33364
		private static readonly IntPtr NativeMethodInfoPtr_CompleteCall_Public_Void_0;

		// Token: 0x04008255 RID: 33365
		private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_0;

		// Token: 0x04008256 RID: 33366
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Private_Void_0;

		// Token: 0x04008257 RID: 33367
		private static readonly IntPtr NativeMethodInfoPtr_Continue_Public_Void_0;

		// Token: 0x04008258 RID: 33368
		private static readonly IntPtr NativeMethodInfoPtr_ShowStage_Private_Void_Int32_Single_0;

		// Token: 0x04008259 RID: 33369
		private static readonly IntPtr NativeMethodInfoPtr_ProcessText_Private_String_String_0;

		// Token: 0x0400825A RID: 33370
		private static readonly IntPtr NativeMethodInfoPtr_GetVisibleText_Private_String_Int32_String_0;

		// Token: 0x0400825B RID: 33371
		private static readonly IntPtr NativeMethodInfoPtr_SetIsVisible_Private_Void_Boolean_0;

		// Token: 0x0400825C RID: 33372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400825D RID: 33373
		private static readonly IntPtr NativeMethodInfoPtr__ProcessText_b__42_0_Private_String_Match_0;

		// Token: 0x02000D23 RID: 3363
		[ObfuscatedName("ScheduleOne.UI.Phone.CallInterface+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F887 RID: 63623 RVA: 0x003B8264 File Offset: 0x003B6464
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0>.NativeClassPtr);
				CallInterface.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0>.NativeClassPtr, "<>4__this");
				CallInterface.__c__DisplayClass41_0.NativeFieldInfoPtr_initialDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0>.NativeClassPtr, "initialDelay");
				CallInterface.__c__DisplayClass41_0.NativeFieldInfoPtr_stageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0>.NativeClassPtr, "stageIndex");
				CallInterface.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0>.NativeClassPtr, 100688115);
				CallInterface.__c__DisplayClass41_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0>.NativeClassPtr, 100688116);
			}

			// Token: 0x0600F888 RID: 63624 RVA: 0x003B82F4 File Offset: 0x003B64F4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F889 RID: 63625 RVA: 0x003B8330 File Offset: 0x003B6530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316640, XrefRangeEnd = 316645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass41_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F88A RID: 63626 RVA: 0x00075823 File Offset: 0x00073A23
			public __c__DisplayClass41_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B8C RID: 19340
			// (get) Token: 0x0600F88B RID: 63627 RVA: 0x003B8370 File Offset: 0x003B6570
			// (set) Token: 0x0600F88C RID: 63628 RVA: 0x0007582C File Offset: 0x00073A2C
			public unsafe CallInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B8D RID: 19341
			// (get) Token: 0x0600F88D RID: 63629 RVA: 0x003B83A0 File Offset: 0x003B65A0
			// (set) Token: 0x0600F88E RID: 63630 RVA: 0x0007584B File Offset: 0x00073A4B
			public unsafe float initialDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass41_0.NativeFieldInfoPtr_initialDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass41_0.NativeFieldInfoPtr_initialDelay)) = value;
				}
			}

			// Token: 0x17004B8E RID: 19342
			// (get) Token: 0x0600F88F RID: 63631 RVA: 0x003B83C8 File Offset: 0x003B65C8
			// (set) Token: 0x0600F890 RID: 63632 RVA: 0x00075866 File Offset: 0x00073A66
			public unsafe int stageIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass41_0.NativeFieldInfoPtr_stageIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass41_0.NativeFieldInfoPtr_stageIndex)) = value;
				}
			}

			// Token: 0x0400A7F7 RID: 42999
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A7F8 RID: 43000
			private static readonly IntPtr NativeFieldInfoPtr_initialDelay;

			// Token: 0x0400A7F9 RID: 43001
			private static readonly IntPtr NativeFieldInfoPtr_stageIndex;

			// Token: 0x0400A7FA RID: 43002
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A7FB RID: 43003
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000E14 RID: 3604
			[ObfuscatedName("ScheduleOne.UI.Phone.CallInterface+<>c__DisplayClass41_0+<<ShowStage>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique : Il2CppSystem.Object
			{
				// Token: 0x060103B3 RID: 66483 RVA: 0x003D8AA4 File Offset: 0x003D6CA4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique()
				{
					Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0>.NativeClassPtr, "<<ShowStage>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr);
					CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<>1__state");
					CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<>2__current");
					CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<>4__this");
					CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__stageText_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<stageText>5__2");
					CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__parsedLength_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<parsedLength>5__3");
					CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<i>5__4");
					CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100688117);
					CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100688118);
					CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100688119);
					CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100688120);
					CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100688121);
					CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100688122);
				}

				// Token: 0x060103B4 RID: 66484 RVA: 0x003D8BC0 File Offset: 0x003D6DC0
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060103B5 RID: 66485 RVA: 0x003D8C08 File Offset: 0x003D6E08
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060103B6 RID: 66486 RVA: 0x003D8C3C File Offset: 0x003D6E3C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316599, XrefRangeEnd = 316635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004F66 RID: 20326
				// (get) Token: 0x060103B7 RID: 66487 RVA: 0x003D8C78 File Offset: 0x003D6E78
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060103B8 RID: 66488 RVA: 0x003D8CB8 File Offset: 0x003D6EB8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316635, XrefRangeEnd = 316640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004F67 RID: 20327
				// (get) Token: 0x060103B9 RID: 66489 RVA: 0x003D8CEC File Offset: 0x003D6EEC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060103BA RID: 66490 RVA: 0x0007B30B File Offset: 0x0007950B
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004F60 RID: 20320
				// (get) Token: 0x060103BB RID: 66491 RVA: 0x003D8D2C File Offset: 0x003D6F2C
				// (set) Token: 0x060103BC RID: 66492 RVA: 0x0007B314 File Offset: 0x00079514
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004F61 RID: 20321
				// (get) Token: 0x060103BD RID: 66493 RVA: 0x003D8D54 File Offset: 0x003D6F54
				// (set) Token: 0x060103BE RID: 66494 RVA: 0x0007B32F File Offset: 0x0007952F
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F62 RID: 20322
				// (get) Token: 0x060103BF RID: 66495 RVA: 0x003D8D84 File Offset: 0x003D6F84
				// (set) Token: 0x060103C0 RID: 66496 RVA: 0x0007B34E File Offset: 0x0007954E
				public unsafe CallInterface.__c__DisplayClass41_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallInterface.__c__DisplayClass41_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F63 RID: 20323
				// (get) Token: 0x060103C1 RID: 66497 RVA: 0x003D8DB4 File Offset: 0x003D6FB4
				// (set) Token: 0x060103C2 RID: 66498 RVA: 0x0007B36D File Offset: 0x0007956D
				public unsafe string _stageText_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__stageText_5__2);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__stageText_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17004F64 RID: 20324
				// (get) Token: 0x060103C3 RID: 66499 RVA: 0x003D8DDC File Offset: 0x003D6FDC
				// (set) Token: 0x060103C4 RID: 66500 RVA: 0x0007B38C File Offset: 0x0007958C
				public unsafe int _parsedLength_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__parsedLength_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__parsedLength_5__3)) = value;
					}
				}

				// Token: 0x17004F65 RID: 20325
				// (get) Token: 0x060103C5 RID: 66501 RVA: 0x003D8E04 File Offset: 0x003D7004
				// (set) Token: 0x060103C6 RID: 66502 RVA: 0x0007B3A7 File Offset: 0x000795A7
				public unsafe int _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x0400AEBF RID: 44735
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AEC0 RID: 44736
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AEC1 RID: 44737
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AEC2 RID: 44738
				private static readonly IntPtr NativeFieldInfoPtr__stageText_5__2;

				// Token: 0x0400AEC3 RID: 44739
				private static readonly IntPtr NativeFieldInfoPtr__parsedLength_5__3;

				// Token: 0x0400AEC4 RID: 44740
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x0400AEC5 RID: 44741
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AEC6 RID: 44742
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AEC7 RID: 44743
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AEC8 RID: 44744
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AEC9 RID: 44745
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AECA RID: 44746
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
