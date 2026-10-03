using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.State;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000753 RID: 1875
	public class SleepCanvas : Singleton<SleepCanvas>
	{
		// Token: 0x0600B6C5 RID: 46789 RVA: 0x002F4C9C File Offset: 0x002F2E9C
		// Note: this type is marked as 'beforefieldinit'.
		static SleepCanvas()
		{
			Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "SleepCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr);
			SleepCanvas.NativeFieldInfoPtr_MaxSleepTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "MaxSleepTime");
			SleepCanvas.NativeFieldInfoPtr_MinSleepTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "MinSleepTime");
			SleepCanvas.NativeFieldInfoPtr__IsMenuOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<IsMenuOpen>k__BackingField");
			SleepCanvas.NativeFieldInfoPtr__QueuedSleepMessage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<QueuedSleepMessage>k__BackingField");
			SleepCanvas.NativeFieldInfoPtr_QueuedMessageDisplayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "QueuedMessageDisplayTime");
			SleepCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "Canvas");
			SleepCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "Container");
			SleepCanvas.NativeFieldInfoPtr_UIScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "UIScreen");
			SleepCanvas.NativeFieldInfoPtr_MenuContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "MenuContainer");
			SleepCanvas.NativeFieldInfoPtr_CurrentTimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "CurrentTimeLabel");
			SleepCanvas.NativeFieldInfoPtr_EndTimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "EndTimeLabel");
			SleepCanvas.NativeFieldInfoPtr_SleepButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "SleepButton");
			SleepCanvas.NativeFieldInfoPtr_SleepButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "SleepButtonLabel");
			SleepCanvas.NativeFieldInfoPtr_BlackOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "BlackOverlay");
			SleepCanvas.NativeFieldInfoPtr_SleepMessageLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "SleepMessageLabel");
			SleepCanvas.NativeFieldInfoPtr_SleepMessageGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "SleepMessageGroup");
			SleepCanvas.NativeFieldInfoPtr_TimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "TimeLabel");
			SleepCanvas.NativeFieldInfoPtr_WakeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "WakeLabel");
			SleepCanvas.NativeFieldInfoPtr_WaitingForHostLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "WaitingForHostLabel");
			SleepCanvas.NativeFieldInfoPtr_MenuState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "MenuState");
			SleepCanvas.NativeFieldInfoPtr_SleepingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "SleepingState");
			SleepCanvas.NativeFieldInfoPtr_onSleepFullyFaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "onSleepFullyFaded");
			SleepCanvas.NativeFieldInfoPtr_onSleepEndFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "onSleepEndFade");
			SleepCanvas.NativeFieldInfoPtr_queuedPostSleepEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "queuedPostSleepEvents");
			SleepCanvas.NativeMethodInfoPtr_get_IsMenuOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100687201);
			SleepCanvas.NativeMethodInfoPtr_set_IsMenuOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100687202);
			SleepCanvas.NativeMethodInfoPtr_get_QueuedSleepMessage_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100687203);
			SleepCanvas.NativeMethodInfoPtr_set_QueuedSleepMessage_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100687204);
			SleepCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100687205);
			SleepCanvas.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100687206);
			SleepCanvas.NativeMethodInfoPtr_OpenMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100687207);
			SleepCanvas.NativeMethodInfoPtr_OnMenuClosed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100687208);
			SleepCanvas.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100687209);
			SleepCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100687210);
			SleepCanvas.NativeMethodInfoPtr_AddPostSleepEvent_Public_Void_IPostSleepEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100687211);
			SleepCanvas.NativeMethodInfoPtr_UpdateSleepButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100687212);
			SleepCanvas.NativeMethodInfoPtr_SleepButtonPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100687213);
			SleepCanvas.NativeMethodInfoPtr_SleepStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100687214);
			SleepCanvas.NativeMethodInfoPtr_LerpBlackOverlay_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100687215);
			SleepCanvas.NativeMethodInfoPtr_QueueSleepMessage_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100687216);
			SleepCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100687217);
			SleepCanvas.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100687218);
		}

		// Token: 0x17003743 RID: 14147
		// (get) Token: 0x0600B6C6 RID: 46790 RVA: 0x002F5014 File Offset: 0x002F3214
		// (set) Token: 0x0600B6C7 RID: 46791 RVA: 0x002F5050 File Offset: 0x002F3250
		public unsafe bool IsMenuOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_get_IsMenuOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 33070, RefRangeEnd = 33090, XrefRangeStart = 33070, XrefRangeEnd = 33090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_set_IsMenuOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003744 RID: 14148
		// (get) Token: 0x0600B6C8 RID: 46792 RVA: 0x002F5090 File Offset: 0x002F3290
		// (set) Token: 0x0600B6C9 RID: 46793 RVA: 0x002F50C8 File Offset: 0x002F32C8
		public unsafe string QueuedSleepMessage
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_get_QueuedSleepMessage_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 2978, RefRangeEnd = 2980, XrefRangeStart = 2978, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_set_QueuedSleepMessage_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B6CA RID: 46794 RVA: 0x002F510C File Offset: 0x002F330C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307221, XrefRangeEnd = 307273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SleepCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6CB RID: 46795 RVA: 0x002F5148 File Offset: 0x002F3348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307273, XrefRangeEnd = 307276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6CC RID: 46796 RVA: 0x002F518C File Offset: 0x002F338C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 307295, RefRangeEnd = 307296, XrefRangeStart = 307276, XrefRangeEnd = 307295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenMenu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_OpenMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6CD RID: 46797 RVA: 0x002F51C0 File Offset: 0x002F33C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307296, XrefRangeEnd = 307304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMenuClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_OnMenuClosed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6CE RID: 46798 RVA: 0x002F51F4 File Offset: 0x002F33F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307304, XrefRangeEnd = 307306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6CF RID: 46799 RVA: 0x002F5228 File Offset: 0x002F3428
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 307325, RefRangeEnd = 307327, XrefRangeStart = 307306, XrefRangeEnd = 307325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6D0 RID: 46800 RVA: 0x002F525C File Offset: 0x002F345C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 307341, RefRangeEnd = 307343, XrefRangeStart = 307327, XrefRangeEnd = 307341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPostSleepEvent(IPostSleepEvent postSleepEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(postSleepEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_AddPostSleepEvent_Public_Void_IPostSleepEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6D1 RID: 46801 RVA: 0x002F52A0 File Offset: 0x002F34A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307343, XrefRangeEnd = 307353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSleepButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_UpdateSleepButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6D2 RID: 46802 RVA: 0x002F52D4 File Offset: 0x002F34D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307353, XrefRangeEnd = 307360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_SleepButtonPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6D3 RID: 46803 RVA: 0x002F5308 File Offset: 0x002F3508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307360, XrefRangeEnd = 307388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_SleepStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6D4 RID: 46804 RVA: 0x002F533C File Offset: 0x002F353C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 307401, RefRangeEnd = 307403, XrefRangeStart = 307388, XrefRangeEnd = 307401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpBlackOverlay(float transparency, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref transparency;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_LerpBlackOverlay_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6D5 RID: 46805 RVA: 0x002F5388 File Offset: 0x002F3588
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 307424, RefRangeEnd = 307426, XrefRangeStart = 307403, XrefRangeEnd = 307424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueSleepMessage(string message, float displayTime = 3f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref displayTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_QueueSleepMessage_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6D6 RID: 46806 RVA: 0x002F53D8 File Offset: 0x002F35D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307426, XrefRangeEnd = 307439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SleepCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6D7 RID: 46807 RVA: 0x002F5414 File Offset: 0x002F3614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307439, XrefRangeEnd = 307444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B6D8 RID: 46808 RVA: 0x00054CA5 File Offset: 0x00052EA5
		public SleepCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700372B RID: 14123
		// (get) Token: 0x0600B6D9 RID: 46809 RVA: 0x002F5454 File Offset: 0x002F3654
		// (set) Token: 0x0600B6DA RID: 46810 RVA: 0x00054CAE File Offset: 0x00052EAE
		public unsafe static int MaxSleepTime
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SleepCanvas.NativeFieldInfoPtr_MaxSleepTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SleepCanvas.NativeFieldInfoPtr_MaxSleepTime, (void*)(&value));
			}
		}

		// Token: 0x1700372C RID: 14124
		// (get) Token: 0x0600B6DB RID: 46811 RVA: 0x002F5470 File Offset: 0x002F3670
		// (set) Token: 0x0600B6DC RID: 46812 RVA: 0x00054CBC File Offset: 0x00052EBC
		public unsafe static int MinSleepTime
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SleepCanvas.NativeFieldInfoPtr_MinSleepTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SleepCanvas.NativeFieldInfoPtr_MinSleepTime, (void*)(&value));
			}
		}

		// Token: 0x1700372D RID: 14125
		// (get) Token: 0x0600B6DD RID: 46813 RVA: 0x002F548C File Offset: 0x002F368C
		// (set) Token: 0x0600B6DE RID: 46814 RVA: 0x00054CCA File Offset: 0x00052ECA
		public unsafe bool _IsMenuOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr__IsMenuOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr__IsMenuOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700372E RID: 14126
		// (get) Token: 0x0600B6DF RID: 46815 RVA: 0x002F54B4 File Offset: 0x002F36B4
		// (set) Token: 0x0600B6E0 RID: 46816 RVA: 0x00054CE5 File Offset: 0x00052EE5
		public unsafe string _QueuedSleepMessage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr__QueuedSleepMessage_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr__QueuedSleepMessage_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700372F RID: 14127
		// (get) Token: 0x0600B6E1 RID: 46817 RVA: 0x002F54DC File Offset: 0x002F36DC
		// (set) Token: 0x0600B6E2 RID: 46818 RVA: 0x00054D04 File Offset: 0x00052F04
		public unsafe float QueuedMessageDisplayTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_QueuedMessageDisplayTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_QueuedMessageDisplayTime)) = value;
			}
		}

		// Token: 0x17003730 RID: 14128
		// (get) Token: 0x0600B6E3 RID: 46819 RVA: 0x002F5504 File Offset: 0x002F3704
		// (set) Token: 0x0600B6E4 RID: 46820 RVA: 0x00054D1F File Offset: 0x00052F1F
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003731 RID: 14129
		// (get) Token: 0x0600B6E5 RID: 46821 RVA: 0x002F5534 File Offset: 0x002F3734
		// (set) Token: 0x0600B6E6 RID: 46822 RVA: 0x00054D3E File Offset: 0x00052F3E
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003732 RID: 14130
		// (get) Token: 0x0600B6E7 RID: 46823 RVA: 0x002F5564 File Offset: 0x002F3764
		// (set) Token: 0x0600B6E8 RID: 46824 RVA: 0x00054D5D File Offset: 0x00052F5D
		public unsafe UIScreen UIScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_UIScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_UIScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003733 RID: 14131
		// (get) Token: 0x0600B6E9 RID: 46825 RVA: 0x002F5594 File Offset: 0x002F3794
		// (set) Token: 0x0600B6EA RID: 46826 RVA: 0x00054D7C File Offset: 0x00052F7C
		public unsafe RectTransform MenuContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_MenuContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_MenuContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003734 RID: 14132
		// (get) Token: 0x0600B6EB RID: 46827 RVA: 0x002F55C4 File Offset: 0x002F37C4
		// (set) Token: 0x0600B6EC RID: 46828 RVA: 0x00054D9B File Offset: 0x00052F9B
		public unsafe TextMeshProUGUI CurrentTimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_CurrentTimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_CurrentTimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003735 RID: 14133
		// (get) Token: 0x0600B6ED RID: 46829 RVA: 0x002F55F4 File Offset: 0x002F37F4
		// (set) Token: 0x0600B6EE RID: 46830 RVA: 0x00054DBA File Offset: 0x00052FBA
		public unsafe TextMeshProUGUI EndTimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_EndTimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_EndTimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003736 RID: 14134
		// (get) Token: 0x0600B6EF RID: 46831 RVA: 0x002F5624 File Offset: 0x002F3824
		// (set) Token: 0x0600B6F0 RID: 46832 RVA: 0x00054DD9 File Offset: 0x00052FD9
		public unsafe Button SleepButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003737 RID: 14135
		// (get) Token: 0x0600B6F1 RID: 46833 RVA: 0x002F5654 File Offset: 0x002F3854
		// (set) Token: 0x0600B6F2 RID: 46834 RVA: 0x00054DF8 File Offset: 0x00052FF8
		public unsafe TextMeshProUGUI SleepButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003738 RID: 14136
		// (get) Token: 0x0600B6F3 RID: 46835 RVA: 0x002F5684 File Offset: 0x002F3884
		// (set) Token: 0x0600B6F4 RID: 46836 RVA: 0x00054E17 File Offset: 0x00053017
		public unsafe Image BlackOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_BlackOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_BlackOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003739 RID: 14137
		// (get) Token: 0x0600B6F5 RID: 46837 RVA: 0x002F56B4 File Offset: 0x002F38B4
		// (set) Token: 0x0600B6F6 RID: 46838 RVA: 0x00054E36 File Offset: 0x00053036
		public unsafe TextMeshProUGUI SleepMessageLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepMessageLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepMessageLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700373A RID: 14138
		// (get) Token: 0x0600B6F7 RID: 46839 RVA: 0x002F56E4 File Offset: 0x002F38E4
		// (set) Token: 0x0600B6F8 RID: 46840 RVA: 0x00054E55 File Offset: 0x00053055
		public unsafe CanvasGroup SleepMessageGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepMessageGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepMessageGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700373B RID: 14139
		// (get) Token: 0x0600B6F9 RID: 46841 RVA: 0x002F5714 File Offset: 0x002F3914
		// (set) Token: 0x0600B6FA RID: 46842 RVA: 0x00054E74 File Offset: 0x00053074
		public unsafe TextMeshProUGUI TimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_TimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_TimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700373C RID: 14140
		// (get) Token: 0x0600B6FB RID: 46843 RVA: 0x002F5744 File Offset: 0x002F3944
		// (set) Token: 0x0600B6FC RID: 46844 RVA: 0x00054E93 File Offset: 0x00053093
		public unsafe TextMeshProUGUI WakeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_WakeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_WakeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700373D RID: 14141
		// (get) Token: 0x0600B6FD RID: 46845 RVA: 0x002F5774 File Offset: 0x002F3974
		// (set) Token: 0x0600B6FE RID: 46846 RVA: 0x00054EB2 File Offset: 0x000530B2
		public unsafe TextMeshProUGUI WaitingForHostLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_WaitingForHostLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_WaitingForHostLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700373E RID: 14142
		// (get) Token: 0x0600B6FF RID: 46847 RVA: 0x002F57A4 File Offset: 0x002F39A4
		// (set) Token: 0x0600B700 RID: 46848 RVA: 0x00054ED1 File Offset: 0x000530D1
		public unsafe MonoState MenuState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_MenuState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_MenuState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700373F RID: 14143
		// (get) Token: 0x0600B701 RID: 46849 RVA: 0x002F57D4 File Offset: 0x002F39D4
		// (set) Token: 0x0600B702 RID: 46850 RVA: 0x00054EF0 File Offset: 0x000530F0
		public unsafe MonoStateMachine SleepingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepingState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoStateMachine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepingState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003740 RID: 14144
		// (get) Token: 0x0600B703 RID: 46851 RVA: 0x002F5804 File Offset: 0x002F3A04
		// (set) Token: 0x0600B704 RID: 46852 RVA: 0x00054F0F File Offset: 0x0005310F
		public unsafe UnityEvent onSleepFullyFaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_onSleepFullyFaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_onSleepFullyFaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003741 RID: 14145
		// (get) Token: 0x0600B705 RID: 46853 RVA: 0x002F5834 File Offset: 0x002F3A34
		// (set) Token: 0x0600B706 RID: 46854 RVA: 0x00054F2E File Offset: 0x0005312E
		public unsafe UnityEvent onSleepEndFade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_onSleepEndFade);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_onSleepEndFade), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003742 RID: 14146
		// (get) Token: 0x0600B707 RID: 46855 RVA: 0x002F5864 File Offset: 0x002F3A64
		// (set) Token: 0x0600B708 RID: 46856 RVA: 0x00054F4D File Offset: 0x0005314D
		public unsafe List<IPostSleepEvent> queuedPostSleepEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_queuedPostSleepEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IPostSleepEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_queuedPostSleepEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007D97 RID: 32151
		private static readonly IntPtr NativeFieldInfoPtr_MaxSleepTime;

		// Token: 0x04007D98 RID: 32152
		private static readonly IntPtr NativeFieldInfoPtr_MinSleepTime;

		// Token: 0x04007D99 RID: 32153
		private static readonly IntPtr NativeFieldInfoPtr__IsMenuOpen_k__BackingField;

		// Token: 0x04007D9A RID: 32154
		private static readonly IntPtr NativeFieldInfoPtr__QueuedSleepMessage_k__BackingField;

		// Token: 0x04007D9B RID: 32155
		private static readonly IntPtr NativeFieldInfoPtr_QueuedMessageDisplayTime;

		// Token: 0x04007D9C RID: 32156
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04007D9D RID: 32157
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04007D9E RID: 32158
		private static readonly IntPtr NativeFieldInfoPtr_UIScreen;

		// Token: 0x04007D9F RID: 32159
		private static readonly IntPtr NativeFieldInfoPtr_MenuContainer;

		// Token: 0x04007DA0 RID: 32160
		private static readonly IntPtr NativeFieldInfoPtr_CurrentTimeLabel;

		// Token: 0x04007DA1 RID: 32161
		private static readonly IntPtr NativeFieldInfoPtr_EndTimeLabel;

		// Token: 0x04007DA2 RID: 32162
		private static readonly IntPtr NativeFieldInfoPtr_SleepButton;

		// Token: 0x04007DA3 RID: 32163
		private static readonly IntPtr NativeFieldInfoPtr_SleepButtonLabel;

		// Token: 0x04007DA4 RID: 32164
		private static readonly IntPtr NativeFieldInfoPtr_BlackOverlay;

		// Token: 0x04007DA5 RID: 32165
		private static readonly IntPtr NativeFieldInfoPtr_SleepMessageLabel;

		// Token: 0x04007DA6 RID: 32166
		private static readonly IntPtr NativeFieldInfoPtr_SleepMessageGroup;

		// Token: 0x04007DA7 RID: 32167
		private static readonly IntPtr NativeFieldInfoPtr_TimeLabel;

		// Token: 0x04007DA8 RID: 32168
		private static readonly IntPtr NativeFieldInfoPtr_WakeLabel;

		// Token: 0x04007DA9 RID: 32169
		private static readonly IntPtr NativeFieldInfoPtr_WaitingForHostLabel;

		// Token: 0x04007DAA RID: 32170
		private static readonly IntPtr NativeFieldInfoPtr_MenuState;

		// Token: 0x04007DAB RID: 32171
		private static readonly IntPtr NativeFieldInfoPtr_SleepingState;

		// Token: 0x04007DAC RID: 32172
		private static readonly IntPtr NativeFieldInfoPtr_onSleepFullyFaded;

		// Token: 0x04007DAD RID: 32173
		private static readonly IntPtr NativeFieldInfoPtr_onSleepEndFade;

		// Token: 0x04007DAE RID: 32174
		private static readonly IntPtr NativeFieldInfoPtr_queuedPostSleepEvents;

		// Token: 0x04007DAF RID: 32175
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMenuOpen_Public_get_Boolean_0;

		// Token: 0x04007DB0 RID: 32176
		private static readonly IntPtr NativeMethodInfoPtr_set_IsMenuOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04007DB1 RID: 32177
		private static readonly IntPtr NativeMethodInfoPtr_get_QueuedSleepMessage_Public_get_String_0;

		// Token: 0x04007DB2 RID: 32178
		private static readonly IntPtr NativeMethodInfoPtr_set_QueuedSleepMessage_Protected_set_Void_String_0;

		// Token: 0x04007DB3 RID: 32179
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007DB4 RID: 32180
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04007DB5 RID: 32181
		private static readonly IntPtr NativeMethodInfoPtr_OpenMenu_Public_Void_0;

		// Token: 0x04007DB6 RID: 32182
		private static readonly IntPtr NativeMethodInfoPtr_OnMenuClosed_Private_Void_0;

		// Token: 0x04007DB7 RID: 32183
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04007DB8 RID: 32184
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x04007DB9 RID: 32185
		private static readonly IntPtr NativeMethodInfoPtr_AddPostSleepEvent_Public_Void_IPostSleepEvent_0;

		// Token: 0x04007DBA RID: 32186
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSleepButton_Private_Void_0;

		// Token: 0x04007DBB RID: 32187
		private static readonly IntPtr NativeMethodInfoPtr_SleepButtonPressed_Private_Void_0;

		// Token: 0x04007DBC RID: 32188
		private static readonly IntPtr NativeMethodInfoPtr_SleepStart_Private_Void_0;

		// Token: 0x04007DBD RID: 32189
		private static readonly IntPtr NativeMethodInfoPtr_LerpBlackOverlay_Private_Void_Single_Single_0;

		// Token: 0x04007DBE RID: 32190
		private static readonly IntPtr NativeMethodInfoPtr_QueueSleepMessage_Public_Void_String_Single_0;

		// Token: 0x04007DBF RID: 32191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007DC0 RID: 32192
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000CE8 RID: 3304
		[ObfuscatedName("ScheduleOne.UI.SleepCanvas+<<SleepStart>g__Sleep|39_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600F634 RID: 63028 RVA: 0x003B1534 File Offset: 0x003AF734
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique()
			{
				Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<<SleepStart>g__Sleep|39_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<>1__state");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<>2__current");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<>4__this");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<>8__1");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<>7__wrap1");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<lerpTime>5__3");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<i>5__4");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100687219);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100687220);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100687221);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100687222);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100687223);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100687224);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100687225);
			}

			// Token: 0x0600F635 RID: 63029 RVA: 0x003B1678 File Offset: 0x003AF878
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F636 RID: 63030 RVA: 0x003B16C0 File Offset: 0x003AF8C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306954, XrefRangeEnd = 306959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F637 RID: 63031 RVA: 0x003B16F4 File Offset: 0x003AF8F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306959, XrefRangeEnd = 307179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F638 RID: 63032 RVA: 0x003B1730 File Offset: 0x003AF930
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 307182, RefRangeEnd = 307183, XrefRangeStart = 307179, XrefRangeEnd = 307182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004AE0 RID: 19168
			// (get) Token: 0x0600F639 RID: 63033 RVA: 0x003B1764 File Offset: 0x003AF964
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F63A RID: 63034 RVA: 0x003B17A4 File Offset: 0x003AF9A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307183, XrefRangeEnd = 307188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004AE1 RID: 19169
			// (get) Token: 0x0600F63B RID: 63035 RVA: 0x003B17D8 File Offset: 0x003AF9D8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F63C RID: 63036 RVA: 0x00074697 File Offset: 0x00072897
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004AD9 RID: 19161
			// (get) Token: 0x0600F63D RID: 63037 RVA: 0x003B1818 File Offset: 0x003AFA18
			// (set) Token: 0x0600F63E RID: 63038 RVA: 0x000746A0 File Offset: 0x000728A0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004ADA RID: 19162
			// (get) Token: 0x0600F63F RID: 63039 RVA: 0x003B1840 File Offset: 0x003AFA40
			// (set) Token: 0x0600F640 RID: 63040 RVA: 0x000746BB File Offset: 0x000728BB
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ADB RID: 19163
			// (get) Token: 0x0600F641 RID: 63041 RVA: 0x003B1870 File Offset: 0x003AFA70
			// (set) Token: 0x0600F642 RID: 63042 RVA: 0x000746DA File Offset: 0x000728DA
			public unsafe SleepCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SleepCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ADC RID: 19164
			// (get) Token: 0x0600F643 RID: 63043 RVA: 0x003B18A0 File Offset: 0x003AFAA0
			// (set) Token: 0x0600F644 RID: 63044 RVA: 0x000746F9 File Offset: 0x000728F9
			public unsafe SleepCanvas.__c__DisplayClass39_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SleepCanvas.__c__DisplayClass39_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ADD RID: 19165
			// (get) Token: 0x0600F645 RID: 63045 RVA: 0x003B18D0 File Offset: 0x003AFAD0
			// (set) Token: 0x0600F646 RID: 63046 RVA: 0x00074718 File Offset: 0x00072918
			public List<IPostSleepEvent>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___7__wrap1);
					return new List<IPostSleepEvent>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<IPostSleepEvent>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<IPostSleepEvent>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004ADE RID: 19166
			// (get) Token: 0x0600F647 RID: 63047 RVA: 0x003B1900 File Offset: 0x003AFB00
			// (set) Token: 0x0600F648 RID: 63048 RVA: 0x00074746 File Offset: 0x00072946
			public unsafe float _lerpTime_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3)) = value;
				}
			}

			// Token: 0x17004ADF RID: 19167
			// (get) Token: 0x0600F649 RID: 63049 RVA: 0x003B1928 File Offset: 0x003AFB28
			// (set) Token: 0x0600F64A RID: 63050 RVA: 0x00074761 File Offset: 0x00072961
			public unsafe float _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x0400A694 RID: 42644
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A695 RID: 42645
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A696 RID: 42646
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A697 RID: 42647
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400A698 RID: 42648
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400A699 RID: 42649
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__3;

			// Token: 0x0400A69A RID: 42650
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x0400A69B RID: 42651
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A69C RID: 42652
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A69D RID: 42653
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A69E RID: 42654
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400A69F RID: 42655
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A6A0 RID: 42656
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A6A1 RID: 42657
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000CE9 RID: 3305
		[ObfuscatedName("ScheduleOne.UI.SleepCanvas+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F64B RID: 63051 RVA: 0x003B1950 File Offset: 0x003AFB50
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr);
				SleepCanvas.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, "<>9");
				SleepCanvas.__c.NativeFieldInfoPtr___9__39_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, "<>9__39_1");
				SleepCanvas.__c.NativeFieldInfoPtr___9__39_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, "<>9__39_2");
				SleepCanvas.__c.NativeFieldInfoPtr___9__39_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, "<>9__39_3");
				SleepCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, 100687227);
				SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__39_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, 100687228);
				SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__39_2_Internal_Int32_IPostSleepEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, 100687229);
				SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__39_3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, 100687230);
			}

			// Token: 0x0600F64C RID: 63052 RVA: 0x003B1A1C File Offset: 0x003AFC1C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F64D RID: 63053 RVA: 0x003B1A58 File Offset: 0x003AFC58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307188, XrefRangeEnd = 307192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SleepStart_b__39_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__39_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F64E RID: 63054 RVA: 0x003B1A94 File Offset: 0x003AFC94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307192, XrefRangeEnd = 307196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SleepStart_b__39_2(IPostSleepEvent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__39_2_Internal_Int32_IPostSleepEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F64F RID: 63055 RVA: 0x003B1AE4 File Offset: 0x003AFCE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307196, XrefRangeEnd = 307200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SleepStart_b__39_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__39_3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F650 RID: 63056 RVA: 0x0007477C File Offset: 0x0007297C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004AE2 RID: 19170
			// (get) Token: 0x0600F651 RID: 63057 RVA: 0x003B1B20 File Offset: 0x003AFD20
			// (set) Token: 0x0600F652 RID: 63058 RVA: 0x00074785 File Offset: 0x00072985
			public unsafe static SleepCanvas.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SleepCanvas.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SleepCanvas.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SleepCanvas.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AE3 RID: 19171
			// (get) Token: 0x0600F653 RID: 63059 RVA: 0x003B1B48 File Offset: 0x003AFD48
			// (set) Token: 0x0600F654 RID: 63060 RVA: 0x00074797 File Offset: 0x00072997
			public unsafe static Func<bool> __9__39_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SleepCanvas.__c.NativeFieldInfoPtr___9__39_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SleepCanvas.__c.NativeFieldInfoPtr___9__39_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AE4 RID: 19172
			// (get) Token: 0x0600F655 RID: 63061 RVA: 0x003B1B70 File Offset: 0x003AFD70
			// (set) Token: 0x0600F656 RID: 63062 RVA: 0x000747A9 File Offset: 0x000729A9
			public unsafe static Func<IPostSleepEvent, int> __9__39_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SleepCanvas.__c.NativeFieldInfoPtr___9__39_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IPostSleepEvent, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SleepCanvas.__c.NativeFieldInfoPtr___9__39_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AE5 RID: 19173
			// (get) Token: 0x0600F657 RID: 63063 RVA: 0x003B1B98 File Offset: 0x003AFD98
			// (set) Token: 0x0600F658 RID: 63064 RVA: 0x000747BB File Offset: 0x000729BB
			public unsafe static Func<bool> __9__39_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SleepCanvas.__c.NativeFieldInfoPtr___9__39_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SleepCanvas.__c.NativeFieldInfoPtr___9__39_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A6A2 RID: 42658
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A6A3 RID: 42659
			private static readonly IntPtr NativeFieldInfoPtr___9__39_1;

			// Token: 0x0400A6A4 RID: 42660
			private static readonly IntPtr NativeFieldInfoPtr___9__39_2;

			// Token: 0x0400A6A5 RID: 42661
			private static readonly IntPtr NativeFieldInfoPtr___9__39_3;

			// Token: 0x0400A6A6 RID: 42662
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A6A7 RID: 42663
			private static readonly IntPtr NativeMethodInfoPtr__SleepStart_b__39_1_Internal_Boolean_0;

			// Token: 0x0400A6A8 RID: 42664
			private static readonly IntPtr NativeMethodInfoPtr__SleepStart_b__39_2_Internal_Int32_IPostSleepEvent_0;

			// Token: 0x0400A6A9 RID: 42665
			private static readonly IntPtr NativeMethodInfoPtr__SleepStart_b__39_3_Internal_Boolean_0;
		}

		// Token: 0x02000CEA RID: 3306
		[ObfuscatedName("ScheduleOne.UI.SleepCanvas+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F659 RID: 63065 RVA: 0x003B1BC0 File Offset: 0x003AFDC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass39_0>.NativeClassPtr);
				SleepCanvas.__c__DisplayClass39_0.NativeFieldInfoPtr_pse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass39_0>.NativeClassPtr, "pse");
				SleepCanvas.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass39_0>.NativeClassPtr, 100687231);
				SleepCanvas.__c__DisplayClass39_0.NativeMethodInfoPtr__SleepStart_b__4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass39_0>.NativeClassPtr, 100687232);
			}

			// Token: 0x0600F65A RID: 63066 RVA: 0x003B1C28 File Offset: 0x003AFE28
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F65B RID: 63067 RVA: 0x003B1C64 File Offset: 0x003AFE64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307200, XrefRangeEnd = 307203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SleepStart_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass39_0.NativeMethodInfoPtr__SleepStart_b__4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F65C RID: 63068 RVA: 0x000747CD File Offset: 0x000729CD
			public __c__DisplayClass39_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004AE6 RID: 19174
			// (get) Token: 0x0600F65D RID: 63069 RVA: 0x003B1CA0 File Offset: 0x003AFEA0
			// (set) Token: 0x0600F65E RID: 63070 RVA: 0x000747D6 File Offset: 0x000729D6
			public unsafe IPostSleepEvent pse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass39_0.NativeFieldInfoPtr_pse);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPostSleepEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass39_0.NativeFieldInfoPtr_pse), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A6AA RID: 42666
			private static readonly IntPtr NativeFieldInfoPtr_pse;

			// Token: 0x0400A6AB RID: 42667
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A6AC RID: 42668
			private static readonly IntPtr NativeMethodInfoPtr__SleepStart_b__4_Internal_Boolean_0;
		}

		// Token: 0x02000CEB RID: 3307
		[ObfuscatedName("ScheduleOne.UI.SleepCanvas+<>c__DisplayClass40_0")]
		public sealed class __c__DisplayClass40_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F65F RID: 63071 RVA: 0x003B1CD0 File Offset: 0x003AFED0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass40_0()
			{
				Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<>c__DisplayClass40_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0>.NativeClassPtr);
				SleepCanvas.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0>.NativeClassPtr, "<>4__this");
				SleepCanvas.__c__DisplayClass40_0.NativeFieldInfoPtr_transparency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0>.NativeClassPtr, "transparency");
				SleepCanvas.__c__DisplayClass40_0.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0>.NativeClassPtr, "lerpTime");
				SleepCanvas.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0>.NativeClassPtr, 100687233);
				SleepCanvas.__c__DisplayClass40_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0>.NativeClassPtr, 100687234);
			}

			// Token: 0x0600F660 RID: 63072 RVA: 0x003B1D60 File Offset: 0x003AFF60
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass40_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F661 RID: 63073 RVA: 0x003B1D9C File Offset: 0x003AFF9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307216, XrefRangeEnd = 307221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass40_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F662 RID: 63074 RVA: 0x000747F5 File Offset: 0x000729F5
			public __c__DisplayClass40_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004AE7 RID: 19175
			// (get) Token: 0x0600F663 RID: 63075 RVA: 0x003B1DDC File Offset: 0x003AFFDC
			// (set) Token: 0x0600F664 RID: 63076 RVA: 0x000747FE File Offset: 0x000729FE
			public unsafe SleepCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SleepCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AE8 RID: 19176
			// (get) Token: 0x0600F665 RID: 63077 RVA: 0x003B1E0C File Offset: 0x003B000C
			// (set) Token: 0x0600F666 RID: 63078 RVA: 0x0007481D File Offset: 0x00072A1D
			public unsafe float transparency
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass40_0.NativeFieldInfoPtr_transparency);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass40_0.NativeFieldInfoPtr_transparency)) = value;
				}
			}

			// Token: 0x17004AE9 RID: 19177
			// (get) Token: 0x0600F667 RID: 63079 RVA: 0x003B1E34 File Offset: 0x003B0034
			// (set) Token: 0x0600F668 RID: 63080 RVA: 0x00074838 File Offset: 0x00072A38
			public unsafe float lerpTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass40_0.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass40_0.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x0400A6AD RID: 42669
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A6AE RID: 42670
			private static readonly IntPtr NativeFieldInfoPtr_transparency;

			// Token: 0x0400A6AF RID: 42671
			private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x0400A6B0 RID: 42672
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A6B1 RID: 42673
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000E0E RID: 3598
			[ObfuscatedName("ScheduleOne.UI.SleepCanvas+<>c__DisplayClass40_0+<<LerpBlackOverlay>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06010338 RID: 66360 RVA: 0x003D74E0 File Offset: 0x003D56E0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique()
				{
					Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0>.NativeClassPtr, "<<LerpBlackOverlay>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr);
					SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<>1__state");
					SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<>2__current");
					SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<>4__this");
					SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__startColor_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<startColor>5__2");
					SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__endColor_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<endColor>5__3");
					SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<i>5__4");
					SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100687235);
					SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100687236);
					SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100687237);
					SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100687238);
					SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100687239);
					SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100687240);
				}

				// Token: 0x06010339 RID: 66361 RVA: 0x003D75FC File Offset: 0x003D57FC
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601033A RID: 66362 RVA: 0x003D7644 File Offset: 0x003D5844
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601033B RID: 66363 RVA: 0x003D7678 File Offset: 0x003D5878
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307203, XrefRangeEnd = 307211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004F35 RID: 20277
				// (get) Token: 0x0601033C RID: 66364 RVA: 0x003D76B4 File Offset: 0x003D58B4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601033D RID: 66365 RVA: 0x003D76F4 File Offset: 0x003D58F4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307211, XrefRangeEnd = 307216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004F36 RID: 20278
				// (get) Token: 0x0601033E RID: 66366 RVA: 0x003D7728 File Offset: 0x003D5928
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601033F RID: 66367 RVA: 0x0007AEA7 File Offset: 0x000790A7
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004F2F RID: 20271
				// (get) Token: 0x06010340 RID: 66368 RVA: 0x003D7768 File Offset: 0x003D5968
				// (set) Token: 0x06010341 RID: 66369 RVA: 0x0007AEB0 File Offset: 0x000790B0
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004F30 RID: 20272
				// (get) Token: 0x06010342 RID: 66370 RVA: 0x003D7790 File Offset: 0x003D5990
				// (set) Token: 0x06010343 RID: 66371 RVA: 0x0007AECB File Offset: 0x000790CB
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F31 RID: 20273
				// (get) Token: 0x06010344 RID: 66372 RVA: 0x003D77C0 File Offset: 0x003D59C0
				// (set) Token: 0x06010345 RID: 66373 RVA: 0x0007AEEA File Offset: 0x000790EA
				public unsafe SleepCanvas.__c__DisplayClass40_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SleepCanvas.__c__DisplayClass40_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F32 RID: 20274
				// (get) Token: 0x06010346 RID: 66374 RVA: 0x003D77F0 File Offset: 0x003D59F0
				// (set) Token: 0x06010347 RID: 66375 RVA: 0x0007AF09 File Offset: 0x00079109
				public unsafe Color _startColor_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__startColor_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__startColor_5__2)) = value;
					}
				}

				// Token: 0x17004F33 RID: 20275
				// (get) Token: 0x06010348 RID: 66376 RVA: 0x003D7818 File Offset: 0x003D5A18
				// (set) Token: 0x06010349 RID: 66377 RVA: 0x0007AF24 File Offset: 0x00079124
				public unsafe Color _endColor_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__endColor_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__endColor_5__3)) = value;
					}
				}

				// Token: 0x17004F34 RID: 20276
				// (get) Token: 0x0601034A RID: 66378 RVA: 0x003D7840 File Offset: 0x003D5A40
				// (set) Token: 0x0601034B RID: 66379 RVA: 0x0007AF3F File Offset: 0x0007913F
				public unsafe float _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x0400AE75 RID: 44661
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AE76 RID: 44662
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AE77 RID: 44663
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AE78 RID: 44664
				private static readonly IntPtr NativeFieldInfoPtr__startColor_5__2;

				// Token: 0x0400AE79 RID: 44665
				private static readonly IntPtr NativeFieldInfoPtr__endColor_5__3;

				// Token: 0x0400AE7A RID: 44666
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x0400AE7B RID: 44667
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AE7C RID: 44668
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AE7D RID: 44669
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AE7E RID: 44670
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AE7F RID: 44671
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AE80 RID: 44672
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
