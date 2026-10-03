using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Polling;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Polling
{
	// Token: 0x020007A2 RID: 1954
	public class PollPanel : MonoBehaviour
	{
		// Token: 0x0600BCE3 RID: 48355 RVA: 0x00307948 File Offset: 0x00305B48
		// Note: this type is marked as 'beforefieldinit'.
		static PollPanel()
		{
			Il2CppClassPointerStore<PollPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Polling", "PollPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollPanel>.NativeClassPtr);
			PollPanel.NativeFieldInfoPtr_BUTTON_PRESS_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "BUTTON_PRESS_TIME");
			PollPanel.NativeFieldInfoPtr_ResponseSubmittedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "ResponseSubmittedMessage");
			PollPanel.NativeFieldInfoPtr_ButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "ButtonPrefab");
			PollPanel.NativeFieldInfoPtr_TextColor_Green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "TextColor_Green");
			PollPanel.NativeFieldInfoPtr_TextColor_Red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "TextColor_Red");
			PollPanel.NativeFieldInfoPtr_PollManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "PollManager");
			PollPanel.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "Container");
			PollPanel.NativeFieldInfoPtr_ActivePill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "ActivePill");
			PollPanel.NativeFieldInfoPtr_ClosedPill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "ClosedPill");
			PollPanel.NativeFieldInfoPtr_QuestionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "QuestionLabel");
			PollPanel.NativeFieldInfoPtr_ButtonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "ButtonContainer");
			PollPanel.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "InstructionLabel");
			PollPanel.NativeFieldInfoPtr_ConfirmationMessageLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "ConfirmationMessageLabel");
			PollPanel.NativeFieldInfoPtr_SubmissionStartSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "SubmissionStartSound");
			PollPanel.NativeFieldInfoPtr_SubmissionSuccessSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "SubmissionSuccessSound");
			PollPanel.NativeFieldInfoPtr_SubmissionFailSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "SubmissionFailSound");
			PollPanel.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "buttons");
			PollPanel.NativeFieldInfoPtr_buttonFills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "buttonFills");
			PollPanel.NativeFieldInfoPtr_heldButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "heldButton");
			PollPanel.NativeFieldInfoPtr_selectedButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "selectedButton");
			PollPanel.NativeFieldInfoPtr_lastHeldButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "lastHeldButton");
			PollPanel.NativeFieldInfoPtr_buttonPressTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "buttonPressTime");
			PollPanel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, 100687939);
			PollPanel.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, 100687940);
			PollPanel.NativeMethodInfoPtr_DisplayActivePoll_Public_Void_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, 100687941);
			PollPanel.NativeMethodInfoPtr_DisplayConfirmedPoll_Public_Void_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, 100687942);
			PollPanel.NativeMethodInfoPtr_DisplaySubmittedAnswer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, 100687943);
			PollPanel.NativeMethodInfoPtr_Rebuild_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, 100687944);
			PollPanel.NativeMethodInfoPtr_CreateButtons_Private_List_1_Button_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, 100687945);
			PollPanel.NativeMethodInfoPtr_ButtonPressed_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, 100687946);
			PollPanel.NativeMethodInfoPtr_FinalizeButtonPress_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, 100687947);
			PollPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, 100687948);
		}

		// Token: 0x0600BCE4 RID: 48356 RVA: 0x00307BF8 File Offset: 0x00305DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314746, XrefRangeEnd = 314762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCE5 RID: 48357 RVA: 0x00307C2C File Offset: 0x00305E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314762, XrefRangeEnd = 314783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCE6 RID: 48358 RVA: 0x00307C60 File Offset: 0x00305E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314783, XrefRangeEnd = 314829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayActivePoll(PollData poll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(poll);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.NativeMethodInfoPtr_DisplayActivePoll_Public_Void_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCE7 RID: 48359 RVA: 0x00307CA4 File Offset: 0x00305EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314829, XrefRangeEnd = 314891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayConfirmedPoll(PollData poll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(poll);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.NativeMethodInfoPtr_DisplayConfirmedPoll_Public_Void_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCE8 RID: 48360 RVA: 0x00307CE8 File Offset: 0x00305EE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314935, RefRangeEnd = 314936, XrefRangeStart = 314891, XrefRangeEnd = 314935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplaySubmittedAnswer(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buttonIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.NativeMethodInfoPtr_DisplaySubmittedAnswer_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCE9 RID: 48361 RVA: 0x00307D28 File Offset: 0x00305F28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 314967, RefRangeEnd = 314969, XrefRangeStart = 314936, XrefRangeEnd = 314967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rebuild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.NativeMethodInfoPtr_Rebuild_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCEA RID: 48362 RVA: 0x00307D5C File Offset: 0x00305F5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 315046, RefRangeEnd = 315048, XrefRangeStart = 314969, XrefRangeEnd = 315046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Button> CreateButtons(PollData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.NativeMethodInfoPtr_CreateButtons_Private_List_1_Button_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr3) : null;
		}

		// Token: 0x0600BCEB RID: 48363 RVA: 0x00307DAC File Offset: 0x00305FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315048, XrefRangeEnd = 315068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ButtonPressed(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buttonIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.NativeMethodInfoPtr_ButtonPressed_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCEC RID: 48364 RVA: 0x00307DEC File Offset: 0x00305FEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 315106, RefRangeEnd = 315108, XrefRangeStart = 315068, XrefRangeEnd = 315106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizeButtonPress(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buttonIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.NativeMethodInfoPtr_FinalizeButtonPress_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCED RID: 48365 RVA: 0x00307E2C File Offset: 0x0030602C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315108, XrefRangeEnd = 315123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PollPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCEE RID: 48366 RVA: 0x00057FBA File Offset: 0x000561BA
		public PollPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038F9 RID: 14585
		// (get) Token: 0x0600BCEF RID: 48367 RVA: 0x00307E68 File Offset: 0x00306068
		// (set) Token: 0x0600BCF0 RID: 48368 RVA: 0x00057FC3 File Offset: 0x000561C3
		public unsafe static float BUTTON_PRESS_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PollPanel.NativeFieldInfoPtr_BUTTON_PRESS_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PollPanel.NativeFieldInfoPtr_BUTTON_PRESS_TIME, (void*)(&value));
			}
		}

		// Token: 0x170038FA RID: 14586
		// (get) Token: 0x0600BCF1 RID: 48369 RVA: 0x00307E84 File Offset: 0x00306084
		// (set) Token: 0x0600BCF2 RID: 48370 RVA: 0x00057FD1 File Offset: 0x000561D1
		public unsafe static string ResponseSubmittedMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PollPanel.NativeFieldInfoPtr_ResponseSubmittedMessage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PollPanel.NativeFieldInfoPtr_ResponseSubmittedMessage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170038FB RID: 14587
		// (get) Token: 0x0600BCF3 RID: 48371 RVA: 0x00307EA4 File Offset: 0x003060A4
		// (set) Token: 0x0600BCF4 RID: 48372 RVA: 0x00057FE3 File Offset: 0x000561E3
		public unsafe GameObject ButtonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_ButtonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_ButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038FC RID: 14588
		// (get) Token: 0x0600BCF5 RID: 48373 RVA: 0x00307ED4 File Offset: 0x003060D4
		// (set) Token: 0x0600BCF6 RID: 48374 RVA: 0x00058002 File Offset: 0x00056202
		public unsafe Color TextColor_Green
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_TextColor_Green);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_TextColor_Green)) = value;
			}
		}

		// Token: 0x170038FD RID: 14589
		// (get) Token: 0x0600BCF7 RID: 48375 RVA: 0x00307EFC File Offset: 0x003060FC
		// (set) Token: 0x0600BCF8 RID: 48376 RVA: 0x0005801D File Offset: 0x0005621D
		public unsafe Color TextColor_Red
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_TextColor_Red);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_TextColor_Red)) = value;
			}
		}

		// Token: 0x170038FE RID: 14590
		// (get) Token: 0x0600BCF9 RID: 48377 RVA: 0x00307F24 File Offset: 0x00306124
		// (set) Token: 0x0600BCFA RID: 48378 RVA: 0x00058038 File Offset: 0x00056238
		public unsafe PollManager PollManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_PollManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_PollManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038FF RID: 14591
		// (get) Token: 0x0600BCFB RID: 48379 RVA: 0x00307F54 File Offset: 0x00306154
		// (set) Token: 0x0600BCFC RID: 48380 RVA: 0x00058057 File Offset: 0x00056257
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003900 RID: 14592
		// (get) Token: 0x0600BCFD RID: 48381 RVA: 0x00307F84 File Offset: 0x00306184
		// (set) Token: 0x0600BCFE RID: 48382 RVA: 0x00058076 File Offset: 0x00056276
		public unsafe GameObject ActivePill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_ActivePill);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_ActivePill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003901 RID: 14593
		// (get) Token: 0x0600BCFF RID: 48383 RVA: 0x00307FB4 File Offset: 0x003061B4
		// (set) Token: 0x0600BD00 RID: 48384 RVA: 0x00058095 File Offset: 0x00056295
		public unsafe GameObject ClosedPill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_ClosedPill);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_ClosedPill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003902 RID: 14594
		// (get) Token: 0x0600BD01 RID: 48385 RVA: 0x00307FE4 File Offset: 0x003061E4
		// (set) Token: 0x0600BD02 RID: 48386 RVA: 0x000580B4 File Offset: 0x000562B4
		public unsafe TextMeshProUGUI QuestionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_QuestionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_QuestionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003903 RID: 14595
		// (get) Token: 0x0600BD03 RID: 48387 RVA: 0x00308014 File Offset: 0x00306214
		// (set) Token: 0x0600BD04 RID: 48388 RVA: 0x000580D3 File Offset: 0x000562D3
		public unsafe RectTransform ButtonContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_ButtonContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_ButtonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003904 RID: 14596
		// (get) Token: 0x0600BD05 RID: 48389 RVA: 0x00308044 File Offset: 0x00306244
		// (set) Token: 0x0600BD06 RID: 48390 RVA: 0x000580F2 File Offset: 0x000562F2
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003905 RID: 14597
		// (get) Token: 0x0600BD07 RID: 48391 RVA: 0x00308074 File Offset: 0x00306274
		// (set) Token: 0x0600BD08 RID: 48392 RVA: 0x00058111 File Offset: 0x00056311
		public unsafe TextMeshProUGUI ConfirmationMessageLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_ConfirmationMessageLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_ConfirmationMessageLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003906 RID: 14598
		// (get) Token: 0x0600BD09 RID: 48393 RVA: 0x003080A4 File Offset: 0x003062A4
		// (set) Token: 0x0600BD0A RID: 48394 RVA: 0x00058130 File Offset: 0x00056330
		public unsafe AudioSourceController SubmissionStartSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_SubmissionStartSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_SubmissionStartSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003907 RID: 14599
		// (get) Token: 0x0600BD0B RID: 48395 RVA: 0x003080D4 File Offset: 0x003062D4
		// (set) Token: 0x0600BD0C RID: 48396 RVA: 0x0005814F File Offset: 0x0005634F
		public unsafe AudioSourceController SubmissionSuccessSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_SubmissionSuccessSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_SubmissionSuccessSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003908 RID: 14600
		// (get) Token: 0x0600BD0D RID: 48397 RVA: 0x00308104 File Offset: 0x00306304
		// (set) Token: 0x0600BD0E RID: 48398 RVA: 0x0005816E File Offset: 0x0005636E
		public unsafe AudioSourceController SubmissionFailSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_SubmissionFailSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_SubmissionFailSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003909 RID: 14601
		// (get) Token: 0x0600BD0F RID: 48399 RVA: 0x00308134 File Offset: 0x00306334
		// (set) Token: 0x0600BD10 RID: 48400 RVA: 0x0005818D File Offset: 0x0005638D
		public unsafe List<Button> buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700390A RID: 14602
		// (get) Token: 0x0600BD11 RID: 48401 RVA: 0x00308164 File Offset: 0x00306364
		// (set) Token: 0x0600BD12 RID: 48402 RVA: 0x000581AC File Offset: 0x000563AC
		public unsafe List<Image> buttonFills
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_buttonFills);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_buttonFills), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700390B RID: 14603
		// (get) Token: 0x0600BD13 RID: 48403 RVA: 0x00308194 File Offset: 0x00306394
		// (set) Token: 0x0600BD14 RID: 48404 RVA: 0x000581CB File Offset: 0x000563CB
		public unsafe int heldButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_heldButton);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_heldButton)) = value;
			}
		}

		// Token: 0x1700390C RID: 14604
		// (get) Token: 0x0600BD15 RID: 48405 RVA: 0x003081BC File Offset: 0x003063BC
		// (set) Token: 0x0600BD16 RID: 48406 RVA: 0x000581E6 File Offset: 0x000563E6
		public unsafe int selectedButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_selectedButton);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_selectedButton)) = value;
			}
		}

		// Token: 0x1700390D RID: 14605
		// (get) Token: 0x0600BD17 RID: 48407 RVA: 0x003081E4 File Offset: 0x003063E4
		// (set) Token: 0x0600BD18 RID: 48408 RVA: 0x00058201 File Offset: 0x00056401
		public unsafe int lastHeldButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_lastHeldButton);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_lastHeldButton)) = value;
			}
		}

		// Token: 0x1700390E RID: 14606
		// (get) Token: 0x0600BD19 RID: 48409 RVA: 0x0030820C File Offset: 0x0030640C
		// (set) Token: 0x0600BD1A RID: 48410 RVA: 0x0005821C File Offset: 0x0005641C
		public unsafe float buttonPressTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_buttonPressTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.NativeFieldInfoPtr_buttonPressTime)) = value;
			}
		}

		// Token: 0x0400816C RID: 33132
		private static readonly IntPtr NativeFieldInfoPtr_BUTTON_PRESS_TIME;

		// Token: 0x0400816D RID: 33133
		private static readonly IntPtr NativeFieldInfoPtr_ResponseSubmittedMessage;

		// Token: 0x0400816E RID: 33134
		private static readonly IntPtr NativeFieldInfoPtr_ButtonPrefab;

		// Token: 0x0400816F RID: 33135
		private static readonly IntPtr NativeFieldInfoPtr_TextColor_Green;

		// Token: 0x04008170 RID: 33136
		private static readonly IntPtr NativeFieldInfoPtr_TextColor_Red;

		// Token: 0x04008171 RID: 33137
		private static readonly IntPtr NativeFieldInfoPtr_PollManager;

		// Token: 0x04008172 RID: 33138
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04008173 RID: 33139
		private static readonly IntPtr NativeFieldInfoPtr_ActivePill;

		// Token: 0x04008174 RID: 33140
		private static readonly IntPtr NativeFieldInfoPtr_ClosedPill;

		// Token: 0x04008175 RID: 33141
		private static readonly IntPtr NativeFieldInfoPtr_QuestionLabel;

		// Token: 0x04008176 RID: 33142
		private static readonly IntPtr NativeFieldInfoPtr_ButtonContainer;

		// Token: 0x04008177 RID: 33143
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x04008178 RID: 33144
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmationMessageLabel;

		// Token: 0x04008179 RID: 33145
		private static readonly IntPtr NativeFieldInfoPtr_SubmissionStartSound;

		// Token: 0x0400817A RID: 33146
		private static readonly IntPtr NativeFieldInfoPtr_SubmissionSuccessSound;

		// Token: 0x0400817B RID: 33147
		private static readonly IntPtr NativeFieldInfoPtr_SubmissionFailSound;

		// Token: 0x0400817C RID: 33148
		private static readonly IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x0400817D RID: 33149
		private static readonly IntPtr NativeFieldInfoPtr_buttonFills;

		// Token: 0x0400817E RID: 33150
		private static readonly IntPtr NativeFieldInfoPtr_heldButton;

		// Token: 0x0400817F RID: 33151
		private static readonly IntPtr NativeFieldInfoPtr_selectedButton;

		// Token: 0x04008180 RID: 33152
		private static readonly IntPtr NativeFieldInfoPtr_lastHeldButton;

		// Token: 0x04008181 RID: 33153
		private static readonly IntPtr NativeFieldInfoPtr_buttonPressTime;

		// Token: 0x04008182 RID: 33154
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04008183 RID: 33155
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04008184 RID: 33156
		private static readonly IntPtr NativeMethodInfoPtr_DisplayActivePoll_Public_Void_PollData_0;

		// Token: 0x04008185 RID: 33157
		private static readonly IntPtr NativeMethodInfoPtr_DisplayConfirmedPoll_Public_Void_PollData_0;

		// Token: 0x04008186 RID: 33158
		private static readonly IntPtr NativeMethodInfoPtr_DisplaySubmittedAnswer_Private_Void_Int32_0;

		// Token: 0x04008187 RID: 33159
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Private_Void_0;

		// Token: 0x04008188 RID: 33160
		private static readonly IntPtr NativeMethodInfoPtr_CreateButtons_Private_List_1_Button_PollData_0;

		// Token: 0x04008189 RID: 33161
		private static readonly IntPtr NativeMethodInfoPtr_ButtonPressed_Private_Void_Int32_0;

		// Token: 0x0400818A RID: 33162
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeButtonPress_Private_Void_Int32_0;

		// Token: 0x0400818B RID: 33163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D14 RID: 3348
		[ObfuscatedName("ScheduleOne.UI.Polling.PollPanel+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F7F4 RID: 63476 RVA: 0x003B66EC File Offset: 0x003B48EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0>.NativeClassPtr);
				PollPanel.__c__DisplayClass27_0.NativeFieldInfoPtr_layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0>.NativeClassPtr, "layout");
				PollPanel.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0>.NativeClassPtr, 100687949);
				PollPanel.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0>.NativeClassPtr, 100687950);
			}

			// Token: 0x0600F7F5 RID: 63477 RVA: 0x003B6754 File Offset: 0x003B4954
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F7F6 RID: 63478 RVA: 0x003B6790 File Offset: 0x003B4990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314690, XrefRangeEnd = 314695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F7F7 RID: 63479 RVA: 0x000753F5 File Offset: 0x000735F5
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B62 RID: 19298
			// (get) Token: 0x0600F7F8 RID: 63480 RVA: 0x003B67D0 File Offset: 0x003B49D0
			// (set) Token: 0x0600F7F9 RID: 63481 RVA: 0x000753FE File Offset: 0x000735FE
			public unsafe VerticalLayoutGroup layout
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass27_0.NativeFieldInfoPtr_layout);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass27_0.NativeFieldInfoPtr_layout), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7A3 RID: 42915
			private static readonly IntPtr NativeFieldInfoPtr_layout;

			// Token: 0x0400A7A4 RID: 42916
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A7A5 RID: 42917
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000E12 RID: 3602
			[ObfuscatedName("ScheduleOne.UI.Polling.PollPanel+<>c__DisplayClass27_0+<<Rebuild>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06010397 RID: 66455 RVA: 0x003D84FC File Offset: 0x003D66FC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0>.NativeClassPtr, "<<Rebuild>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100687951);
					PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100687952);
					PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100687953);
					PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100687954);
					PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100687955);
					PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100687956);
				}

				// Token: 0x06010398 RID: 66456 RVA: 0x003D85DC File Offset: 0x003D67DC
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06010399 RID: 66457 RVA: 0x003D8624 File Offset: 0x003D6824
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601039A RID: 66458 RVA: 0x003D8658 File Offset: 0x003D6858
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314674, XrefRangeEnd = 314685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004F59 RID: 20313
				// (get) Token: 0x0601039B RID: 66459 RVA: 0x003D8694 File Offset: 0x003D6894
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601039C RID: 66460 RVA: 0x003D86D4 File Offset: 0x003D68D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314685, XrefRangeEnd = 314690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004F5A RID: 20314
				// (get) Token: 0x0601039D RID: 66461 RVA: 0x003D8708 File Offset: 0x003D6908
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601039E RID: 66462 RVA: 0x0007B247 File Offset: 0x00079447
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004F56 RID: 20310
				// (get) Token: 0x0601039F RID: 66463 RVA: 0x003D8748 File Offset: 0x003D6948
				// (set) Token: 0x060103A0 RID: 66464 RVA: 0x0007B250 File Offset: 0x00079450
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004F57 RID: 20311
				// (get) Token: 0x060103A1 RID: 66465 RVA: 0x003D8770 File Offset: 0x003D6970
				// (set) Token: 0x060103A2 RID: 66466 RVA: 0x0007B26B File Offset: 0x0007946B
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F58 RID: 20312
				// (get) Token: 0x060103A3 RID: 66467 RVA: 0x003D87A0 File Offset: 0x003D69A0
				// (set) Token: 0x060103A4 RID: 66468 RVA: 0x0007B28A File Offset: 0x0007948A
				public unsafe PollPanel.__c__DisplayClass27_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollPanel.__c__DisplayClass27_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AEAD RID: 44717
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AEAE RID: 44718
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AEAF RID: 44719
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AEB0 RID: 44720
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AEB1 RID: 44721
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AEB2 RID: 44722
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AEB3 RID: 44723
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AEB4 RID: 44724
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AEB5 RID: 44725
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000D15 RID: 3349
		[ObfuscatedName("ScheduleOne.UI.Polling.PollPanel+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F7FA RID: 63482 RVA: 0x003B6800 File Offset: 0x003B4A00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<PollPanel.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollPanel.__c__DisplayClass28_0>.NativeClassPtr);
				PollPanel.__c__DisplayClass28_0.NativeFieldInfoPtr_buttonIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel.__c__DisplayClass28_0>.NativeClassPtr, "buttonIndex");
				PollPanel.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel.__c__DisplayClass28_0>.NativeClassPtr, "<>4__this");
				PollPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass28_0>.NativeClassPtr, 100687957);
				PollPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__CreateButtons_b__0_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass28_0>.NativeClassPtr, 100687958);
				PollPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__CreateButtons_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass28_0>.NativeClassPtr, 100687959);
			}

			// Token: 0x0600F7FB RID: 63483 RVA: 0x003B6890 File Offset: 0x003B4A90
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollPanel.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F7FC RID: 63484 RVA: 0x003B68CC File Offset: 0x003B4ACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314695, XrefRangeEnd = 314715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateButtons_b__0(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__CreateButtons_b__0_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F7FD RID: 63485 RVA: 0x003B6910 File Offset: 0x003B4B10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314715, XrefRangeEnd = 314717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateButtons_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__CreateButtons_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F7FE RID: 63486 RVA: 0x0007541D File Offset: 0x0007361D
			public __c__DisplayClass28_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B63 RID: 19299
			// (get) Token: 0x0600F7FF RID: 63487 RVA: 0x003B6944 File Offset: 0x003B4B44
			// (set) Token: 0x0600F800 RID: 63488 RVA: 0x00075426 File Offset: 0x00073626
			public unsafe int buttonIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass28_0.NativeFieldInfoPtr_buttonIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass28_0.NativeFieldInfoPtr_buttonIndex)) = value;
				}
			}

			// Token: 0x17004B64 RID: 19300
			// (get) Token: 0x0600F801 RID: 63489 RVA: 0x003B696C File Offset: 0x003B4B6C
			// (set) Token: 0x0600F802 RID: 63490 RVA: 0x00075441 File Offset: 0x00073641
			public unsafe PollPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7A6 RID: 42918
			private static readonly IntPtr NativeFieldInfoPtr_buttonIndex;

			// Token: 0x0400A7A7 RID: 42919
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A7A8 RID: 42920
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A7A9 RID: 42921
			private static readonly IntPtr NativeMethodInfoPtr__CreateButtons_b__0_Internal_Void_BaseEventData_0;

			// Token: 0x0400A7AA RID: 42922
			private static readonly IntPtr NativeMethodInfoPtr__CreateButtons_b__1_Internal_Void_0;
		}

		// Token: 0x02000D16 RID: 3350
		[ObfuscatedName("ScheduleOne.UI.Polling.PollPanel+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F803 RID: 63491 RVA: 0x003B699C File Offset: 0x003B4B9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PollPanel>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0>.NativeClassPtr);
				PollPanel.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0>.NativeClassPtr, "<>4__this");
				PollPanel.__c__DisplayClass30_0.NativeFieldInfoPtr_buttonIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0>.NativeClassPtr, "buttonIndex");
				PollPanel.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0>.NativeClassPtr, 100687960);
				PollPanel.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0>.NativeClassPtr, 100687961);
				PollPanel.__c__DisplayClass30_0.NativeMethodInfoPtr__FinalizeButtonPress_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0>.NativeClassPtr, 100687962);
			}

			// Token: 0x0600F804 RID: 63492 RVA: 0x003B6A2C File Offset: 0x003B4C2C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F805 RID: 63493 RVA: 0x003B6A68 File Offset: 0x003B4C68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314741, XrefRangeEnd = 314746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F806 RID: 63494 RVA: 0x003B6AA8 File Offset: 0x003B4CA8
			[CallerCount(0)]
			public unsafe bool _FinalizeButtonPress_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass30_0.NativeMethodInfoPtr__FinalizeButtonPress_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F807 RID: 63495 RVA: 0x00075460 File Offset: 0x00073660
			public __c__DisplayClass30_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B65 RID: 19301
			// (get) Token: 0x0600F808 RID: 63496 RVA: 0x003B6AE4 File Offset: 0x003B4CE4
			// (set) Token: 0x0600F809 RID: 63497 RVA: 0x00075469 File Offset: 0x00073669
			public unsafe PollPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B66 RID: 19302
			// (get) Token: 0x0600F80A RID: 63498 RVA: 0x003B6B14 File Offset: 0x003B4D14
			// (set) Token: 0x0600F80B RID: 63499 RVA: 0x00075488 File Offset: 0x00073688
			public unsafe int buttonIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass30_0.NativeFieldInfoPtr_buttonIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass30_0.NativeFieldInfoPtr_buttonIndex)) = value;
				}
			}

			// Token: 0x0400A7AB RID: 42923
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A7AC RID: 42924
			private static readonly IntPtr NativeFieldInfoPtr_buttonIndex;

			// Token: 0x0400A7AD RID: 42925
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A7AE RID: 42926
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0400A7AF RID: 42927
			private static readonly IntPtr NativeMethodInfoPtr__FinalizeButtonPress_b__1_Internal_Boolean_0;

			// Token: 0x02000E13 RID: 3603
			[ObfuscatedName("ScheduleOne.UI.Polling.PollPanel+<>c__DisplayClass30_0+<<FinalizeButtonPress>g__Submit|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060103A5 RID: 66469 RVA: 0x003D87D0 File Offset: 0x003D69D0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0>.NativeClassPtr, "<<FinalizeButtonPress>g__Submit|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100687963);
					PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100687964);
					PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100687965);
					PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100687966);
					PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100687967);
					PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100687968);
				}

				// Token: 0x060103A6 RID: 66470 RVA: 0x003D88B0 File Offset: 0x003D6AB0
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060103A7 RID: 66471 RVA: 0x003D88F8 File Offset: 0x003D6AF8
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060103A8 RID: 66472 RVA: 0x003D892C File Offset: 0x003D6B2C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314717, XrefRangeEnd = 314736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004F5E RID: 20318
				// (get) Token: 0x060103A9 RID: 66473 RVA: 0x003D8968 File Offset: 0x003D6B68
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060103AA RID: 66474 RVA: 0x003D89A8 File Offset: 0x003D6BA8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314736, XrefRangeEnd = 314741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004F5F RID: 20319
				// (get) Token: 0x060103AB RID: 66475 RVA: 0x003D89DC File Offset: 0x003D6BDC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060103AC RID: 66476 RVA: 0x0007B2A9 File Offset: 0x000794A9
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004F5B RID: 20315
				// (get) Token: 0x060103AD RID: 66477 RVA: 0x003D8A1C File Offset: 0x003D6C1C
				// (set) Token: 0x060103AE RID: 66478 RVA: 0x0007B2B2 File Offset: 0x000794B2
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004F5C RID: 20316
				// (get) Token: 0x060103AF RID: 66479 RVA: 0x003D8A44 File Offset: 0x003D6C44
				// (set) Token: 0x060103B0 RID: 66480 RVA: 0x0007B2CD File Offset: 0x000794CD
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F5D RID: 20317
				// (get) Token: 0x060103B1 RID: 66481 RVA: 0x003D8A74 File Offset: 0x003D6C74
				// (set) Token: 0x060103B2 RID: 66482 RVA: 0x0007B2EC File Offset: 0x000794EC
				public unsafe PollPanel.__c__DisplayClass30_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollPanel.__c__DisplayClass30_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollPanel.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AEB6 RID: 44726
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AEB7 RID: 44727
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AEB8 RID: 44728
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AEB9 RID: 44729
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AEBA RID: 44730
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AEBB RID: 44731
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AEBC RID: 44732
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AEBD RID: 44733
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AEBE RID: 44734
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
