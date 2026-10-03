using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Casino.UI
{
	// Token: 0x0200043A RID: 1082
	public class RTBInterface : Singleton<RTBInterface>
	{
		// Token: 0x060060FC RID: 24828 RVA: 0x001CAF90 File Offset: 0x001C9190
		// Note: this type is marked as 'beforefieldinit'.
		static RTBInterface()
		{
			Il2CppClassPointerStore<RTBInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino.UI", "RTBInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr);
			RTBInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "<CurrentGame>k__BackingField");
			RTBInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "Canvas");
			RTBInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "Container");
			RTBInterface.NativeFieldInfoPtr_PlayerDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "PlayerDisplay");
			RTBInterface.NativeFieldInfoPtr_BetPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "BetPanel");
			RTBInterface.NativeFieldInfoPtr_StatusLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "StatusLabel");
			RTBInterface.NativeFieldInfoPtr_WinningsMultiplierLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "WinningsMultiplierLabel");
			RTBInterface.NativeFieldInfoPtr_UIScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "UIScreen");
			RTBInterface.NativeFieldInfoPtr_AnswerPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "AnswerPanel");
			RTBInterface.NativeFieldInfoPtr_QuestionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "QuestionLabel");
			RTBInterface.NativeFieldInfoPtr_TimerSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "TimerSlider");
			RTBInterface.NativeFieldInfoPtr_AnswerButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "AnswerButtons");
			RTBInterface.NativeFieldInfoPtr_AnswerLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "AnswerLabels");
			RTBInterface.NativeFieldInfoPtr_ForfeitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "ForfeitButton");
			RTBInterface.NativeFieldInfoPtr_ForfeitLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "ForfeitLabel");
			RTBInterface.NativeFieldInfoPtr_QuestionContainerAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "QuestionContainerAnimation");
			RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "QuestionContainerFadeIn");
			RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "QuestionContainerFadeOut");
			RTBInterface.NativeFieldInfoPtr_QuestionCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "QuestionCanvasGroup");
			RTBInterface.NativeFieldInfoPtr_SelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "SelectionIndicator");
			RTBInterface.NativeFieldInfoPtr_onCorrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "onCorrect");
			RTBInterface.NativeFieldInfoPtr_onFinalCorrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "onFinalCorrect");
			RTBInterface.NativeFieldInfoPtr_onIncorrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "onIncorrect");
			RTBInterface.NativeMethodInfoPtr_get_CurrentGame_Public_get_RTBGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676033);
			RTBInterface.NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_RTBGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676034);
			RTBInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676035);
			RTBInterface.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676036);
			RTBInterface.NativeMethodInfoPtr_GetStatusText_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676037);
			RTBInterface.NativeMethodInfoPtr_Open_Public_Void_RTBGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676038);
			RTBInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676039);
			RTBInterface.NativeMethodInfoPtr_QuestionReady_Private_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676040);
			RTBInterface.NativeMethodInfoPtr_AnswerButtonClicked_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676041);
			RTBInterface.NativeMethodInfoPtr_ForfeitClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676042);
			RTBInterface.NativeMethodInfoPtr_QuestionDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676043);
			RTBInterface.NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676044);
			RTBInterface.NativeMethodInfoPtr_Correct_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676045);
			RTBInterface.NativeMethodInfoPtr_Incorrect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676046);
			RTBInterface.NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676047);
			RTBInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676048);
			RTBInterface.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676049);
		}

		// Token: 0x17001DEA RID: 7658
		// (get) Token: 0x060060FD RID: 24829 RVA: 0x001CB2E0 File Offset: 0x001C94E0
		// (set) Token: 0x060060FE RID: 24830 RVA: 0x001CB320 File Offset: 0x001C9520
		public unsafe RTBGameController CurrentGame
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_get_CurrentGame_Public_get_RTBGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTBGameController>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_RTBGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060060FF RID: 24831 RVA: 0x001CB364 File Offset: 0x001C9564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205888, XrefRangeEnd = 205917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006100 RID: 24832 RVA: 0x001CB3A0 File Offset: 0x001C95A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205917, XrefRangeEnd = 205922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006101 RID: 24833 RVA: 0x001CB3D4 File Offset: 0x001C95D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205932, RefRangeEnd = 205933, XrefRangeStart = 205922, XrefRangeEnd = 205932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStatusText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_GetStatusText_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006102 RID: 24834 RVA: 0x001CB40C File Offset: 0x001C960C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206008, RefRangeEnd = 206009, XrefRangeStart = 205933, XrefRangeEnd = 206008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(RTBGameController game)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(game);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_Open_Public_Void_RTBGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006103 RID: 24835 RVA: 0x001CB450 File Offset: 0x001C9650
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206088, RefRangeEnd = 206089, XrefRangeStart = 206009, XrefRangeEnd = 206088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006104 RID: 24836 RVA: 0x001CB484 File Offset: 0x001C9684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206089, XrefRangeEnd = 206118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QuestionReady(string question, Il2CppStringArray answers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(question);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(answers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_QuestionReady_Private_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006105 RID: 24837 RVA: 0x001CB4D8 File Offset: 0x001C96D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206118, XrefRangeEnd = 206127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AnswerButtonClicked(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_AnswerButtonClicked_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006106 RID: 24838 RVA: 0x001CB518 File Offset: 0x001C9718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206127, XrefRangeEnd = 206138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForfeitClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_ForfeitClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006107 RID: 24839 RVA: 0x001CB54C File Offset: 0x001C974C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206138, XrefRangeEnd = 206142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QuestionDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_QuestionDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006108 RID: 24840 RVA: 0x001CB580 File Offset: 0x001C9780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206142, XrefRangeEnd = 206146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalPlayerExitRound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006109 RID: 24841 RVA: 0x001CB5B4 File Offset: 0x001C97B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206146, XrefRangeEnd = 206152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Correct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_Correct_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600610A RID: 24842 RVA: 0x001CB5E8 File Offset: 0x001C97E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Incorrect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_Incorrect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600610B RID: 24843 RVA: 0x001CB61C File Offset: 0x001C981C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadyButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600610C RID: 24844 RVA: 0x001CB650 File Offset: 0x001C9850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206152, XrefRangeEnd = 206155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTBInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600610D RID: 24845 RVA: 0x001CB68C File Offset: 0x001C988C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206155, XrefRangeEnd = 206160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600610E RID: 24846 RVA: 0x0002DD62 File Offset: 0x0002BF62
		public RTBInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DD3 RID: 7635
		// (get) Token: 0x0600610F RID: 24847 RVA: 0x001CB6CC File Offset: 0x001C98CC
		// (set) Token: 0x06006110 RID: 24848 RVA: 0x0002DD6B File Offset: 0x0002BF6B
		public unsafe RTBGameController _CurrentGame_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBGameController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DD4 RID: 7636
		// (get) Token: 0x06006111 RID: 24849 RVA: 0x001CB6FC File Offset: 0x001C98FC
		// (set) Token: 0x06006112 RID: 24850 RVA: 0x0002DD8A File Offset: 0x0002BF8A
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DD5 RID: 7637
		// (get) Token: 0x06006113 RID: 24851 RVA: 0x001CB72C File Offset: 0x001C992C
		// (set) Token: 0x06006114 RID: 24852 RVA: 0x0002DDA9 File Offset: 0x0002BFA9
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DD6 RID: 7638
		// (get) Token: 0x06006115 RID: 24853 RVA: 0x001CB75C File Offset: 0x001C995C
		// (set) Token: 0x06006116 RID: 24854 RVA: 0x0002DDC8 File Offset: 0x0002BFC8
		public unsafe CasinoGamePlayerDisplay PlayerDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_PlayerDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_PlayerDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DD7 RID: 7639
		// (get) Token: 0x06006117 RID: 24855 RVA: 0x001CB78C File Offset: 0x001C998C
		// (set) Token: 0x06006118 RID: 24856 RVA: 0x0002DDE7 File Offset: 0x0002BFE7
		public unsafe CasinoGameBetPanel BetPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGameBetPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DD8 RID: 7640
		// (get) Token: 0x06006119 RID: 24857 RVA: 0x001CB7BC File Offset: 0x001C99BC
		// (set) Token: 0x0600611A RID: 24858 RVA: 0x0002DE06 File Offset: 0x0002C006
		public unsafe TextMeshProUGUI StatusLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_StatusLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_StatusLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DD9 RID: 7641
		// (get) Token: 0x0600611B RID: 24859 RVA: 0x001CB7EC File Offset: 0x001C99EC
		// (set) Token: 0x0600611C RID: 24860 RVA: 0x0002DE25 File Offset: 0x0002C025
		public unsafe TextMeshProUGUI WinningsMultiplierLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_WinningsMultiplierLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_WinningsMultiplierLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DDA RID: 7642
		// (get) Token: 0x0600611D RID: 24861 RVA: 0x001CB81C File Offset: 0x001C9A1C
		// (set) Token: 0x0600611E RID: 24862 RVA: 0x0002DE44 File Offset: 0x0002C044
		public unsafe UIScreen UIScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_UIScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_UIScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DDB RID: 7643
		// (get) Token: 0x0600611F RID: 24863 RVA: 0x001CB84C File Offset: 0x001C9A4C
		// (set) Token: 0x06006120 RID: 24864 RVA: 0x0002DE63 File Offset: 0x0002C063
		public unsafe UIPanel AnswerPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_AnswerPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_AnswerPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DDC RID: 7644
		// (get) Token: 0x06006121 RID: 24865 RVA: 0x001CB87C File Offset: 0x001C9A7C
		// (set) Token: 0x06006122 RID: 24866 RVA: 0x0002DE82 File Offset: 0x0002C082
		public unsafe TextMeshProUGUI QuestionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DDD RID: 7645
		// (get) Token: 0x06006123 RID: 24867 RVA: 0x001CB8AC File Offset: 0x001C9AAC
		// (set) Token: 0x06006124 RID: 24868 RVA: 0x0002DEA1 File Offset: 0x0002C0A1
		public unsafe Slider TimerSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_TimerSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_TimerSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DDE RID: 7646
		// (get) Token: 0x06006125 RID: 24869 RVA: 0x001CB8DC File Offset: 0x001C9ADC
		// (set) Token: 0x06006126 RID: 24870 RVA: 0x0002DEC0 File Offset: 0x0002C0C0
		public unsafe Il2CppReferenceArray<Button> AnswerButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_AnswerButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_AnswerButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DDF RID: 7647
		// (get) Token: 0x06006127 RID: 24871 RVA: 0x001CB90C File Offset: 0x001C9B0C
		// (set) Token: 0x06006128 RID: 24872 RVA: 0x0002DEDF File Offset: 0x0002C0DF
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> AnswerLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_AnswerLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_AnswerLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DE0 RID: 7648
		// (get) Token: 0x06006129 RID: 24873 RVA: 0x001CB93C File Offset: 0x001C9B3C
		// (set) Token: 0x0600612A RID: 24874 RVA: 0x0002DEFE File Offset: 0x0002C0FE
		public unsafe Button ForfeitButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ForfeitButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ForfeitButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DE1 RID: 7649
		// (get) Token: 0x0600612B RID: 24875 RVA: 0x001CB96C File Offset: 0x001C9B6C
		// (set) Token: 0x0600612C RID: 24876 RVA: 0x0002DF1D File Offset: 0x0002C11D
		public unsafe TextMeshProUGUI ForfeitLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ForfeitLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ForfeitLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DE2 RID: 7650
		// (get) Token: 0x0600612D RID: 24877 RVA: 0x001CB99C File Offset: 0x001C9B9C
		// (set) Token: 0x0600612E RID: 24878 RVA: 0x0002DF3C File Offset: 0x0002C13C
		public unsafe Animation QuestionContainerAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DE3 RID: 7651
		// (get) Token: 0x0600612F RID: 24879 RVA: 0x001CB9CC File Offset: 0x001C9BCC
		// (set) Token: 0x06006130 RID: 24880 RVA: 0x0002DF5B File Offset: 0x0002C15B
		public unsafe AnimationClip QuestionContainerFadeIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DE4 RID: 7652
		// (get) Token: 0x06006131 RID: 24881 RVA: 0x001CB9FC File Offset: 0x001C9BFC
		// (set) Token: 0x06006132 RID: 24882 RVA: 0x0002DF7A File Offset: 0x0002C17A
		public unsafe AnimationClip QuestionContainerFadeOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeOut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeOut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DE5 RID: 7653
		// (get) Token: 0x06006133 RID: 24883 RVA: 0x001CBA2C File Offset: 0x001C9C2C
		// (set) Token: 0x06006134 RID: 24884 RVA: 0x0002DF99 File Offset: 0x0002C199
		public unsafe CanvasGroup QuestionCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DE6 RID: 7654
		// (get) Token: 0x06006135 RID: 24885 RVA: 0x001CBA5C File Offset: 0x001C9C5C
		// (set) Token: 0x06006136 RID: 24886 RVA: 0x0002DFB8 File Offset: 0x0002C1B8
		public unsafe RectTransform SelectionIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_SelectionIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_SelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DE7 RID: 7655
		// (get) Token: 0x06006137 RID: 24887 RVA: 0x001CBA8C File Offset: 0x001C9C8C
		// (set) Token: 0x06006138 RID: 24888 RVA: 0x0002DFD7 File Offset: 0x0002C1D7
		public unsafe UnityEvent onCorrect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onCorrect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onCorrect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DE8 RID: 7656
		// (get) Token: 0x06006139 RID: 24889 RVA: 0x001CBABC File Offset: 0x001C9CBC
		// (set) Token: 0x0600613A RID: 24890 RVA: 0x0002DFF6 File Offset: 0x0002C1F6
		public unsafe UnityEvent onFinalCorrect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onFinalCorrect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onFinalCorrect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DE9 RID: 7657
		// (get) Token: 0x0600613B RID: 24891 RVA: 0x001CBAEC File Offset: 0x001C9CEC
		// (set) Token: 0x0600613C RID: 24892 RVA: 0x0002E015 File Offset: 0x0002C215
		public unsafe UnityEvent onIncorrect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onIncorrect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onIncorrect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040042D2 RID: 17106
		private static readonly IntPtr NativeFieldInfoPtr__CurrentGame_k__BackingField;

		// Token: 0x040042D3 RID: 17107
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040042D4 RID: 17108
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040042D5 RID: 17109
		private static readonly IntPtr NativeFieldInfoPtr_PlayerDisplay;

		// Token: 0x040042D6 RID: 17110
		private static readonly IntPtr NativeFieldInfoPtr_BetPanel;

		// Token: 0x040042D7 RID: 17111
		private static readonly IntPtr NativeFieldInfoPtr_StatusLabel;

		// Token: 0x040042D8 RID: 17112
		private static readonly IntPtr NativeFieldInfoPtr_WinningsMultiplierLabel;

		// Token: 0x040042D9 RID: 17113
		private static readonly IntPtr NativeFieldInfoPtr_UIScreen;

		// Token: 0x040042DA RID: 17114
		private static readonly IntPtr NativeFieldInfoPtr_AnswerPanel;

		// Token: 0x040042DB RID: 17115
		private static readonly IntPtr NativeFieldInfoPtr_QuestionLabel;

		// Token: 0x040042DC RID: 17116
		private static readonly IntPtr NativeFieldInfoPtr_TimerSlider;

		// Token: 0x040042DD RID: 17117
		private static readonly IntPtr NativeFieldInfoPtr_AnswerButtons;

		// Token: 0x040042DE RID: 17118
		private static readonly IntPtr NativeFieldInfoPtr_AnswerLabels;

		// Token: 0x040042DF RID: 17119
		private static readonly IntPtr NativeFieldInfoPtr_ForfeitButton;

		// Token: 0x040042E0 RID: 17120
		private static readonly IntPtr NativeFieldInfoPtr_ForfeitLabel;

		// Token: 0x040042E1 RID: 17121
		private static readonly IntPtr NativeFieldInfoPtr_QuestionContainerAnimation;

		// Token: 0x040042E2 RID: 17122
		private static readonly IntPtr NativeFieldInfoPtr_QuestionContainerFadeIn;

		// Token: 0x040042E3 RID: 17123
		private static readonly IntPtr NativeFieldInfoPtr_QuestionContainerFadeOut;

		// Token: 0x040042E4 RID: 17124
		private static readonly IntPtr NativeFieldInfoPtr_QuestionCanvasGroup;

		// Token: 0x040042E5 RID: 17125
		private static readonly IntPtr NativeFieldInfoPtr_SelectionIndicator;

		// Token: 0x040042E6 RID: 17126
		private static readonly IntPtr NativeFieldInfoPtr_onCorrect;

		// Token: 0x040042E7 RID: 17127
		private static readonly IntPtr NativeFieldInfoPtr_onFinalCorrect;

		// Token: 0x040042E8 RID: 17128
		private static readonly IntPtr NativeFieldInfoPtr_onIncorrect;

		// Token: 0x040042E9 RID: 17129
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentGame_Public_get_RTBGameController_0;

		// Token: 0x040042EA RID: 17130
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_RTBGameController_0;

		// Token: 0x040042EB RID: 17131
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040042EC RID: 17132
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040042ED RID: 17133
		private static readonly IntPtr NativeMethodInfoPtr_GetStatusText_Private_String_0;

		// Token: 0x040042EE RID: 17134
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_RTBGameController_0;

		// Token: 0x040042EF RID: 17135
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040042F0 RID: 17136
		private static readonly IntPtr NativeMethodInfoPtr_QuestionReady_Private_Void_String_Il2CppStringArray_0;

		// Token: 0x040042F1 RID: 17137
		private static readonly IntPtr NativeMethodInfoPtr_AnswerButtonClicked_Private_Void_Int32_0;

		// Token: 0x040042F2 RID: 17138
		private static readonly IntPtr NativeMethodInfoPtr_ForfeitClicked_Private_Void_0;

		// Token: 0x040042F3 RID: 17139
		private static readonly IntPtr NativeMethodInfoPtr_QuestionDone_Private_Void_0;

		// Token: 0x040042F4 RID: 17140
		private static readonly IntPtr NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0;

		// Token: 0x040042F5 RID: 17141
		private static readonly IntPtr NativeMethodInfoPtr_Correct_Private_Void_0;

		// Token: 0x040042F6 RID: 17142
		private static readonly IntPtr NativeMethodInfoPtr_Incorrect_Private_Void_0;

		// Token: 0x040042F7 RID: 17143
		private static readonly IntPtr NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0;

		// Token: 0x040042F8 RID: 17144
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040042F9 RID: 17145
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B2F RID: 2863
		[ObfuscatedName("ScheduleOne.Casino.UI.RTBInterface+<<QuestionReady>g__Routine|31_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600E676 RID: 58998 RVA: 0x00383D50 File Offset: 0x00381F50
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique()
			{
				Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "<<QuestionReady>g__Routine|31_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, "<>1__state");
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, "<>2__current");
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, "<>4__this");
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100676050);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100676051);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100676052);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100676053);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100676054);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100676055);
			}

			// Token: 0x0600E677 RID: 58999 RVA: 0x00383E30 File Offset: 0x00382030
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E678 RID: 59000 RVA: 0x00383E78 File Offset: 0x00382078
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E679 RID: 59001 RVA: 0x00383EAC File Offset: 0x003820AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205865, XrefRangeEnd = 205874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170045F7 RID: 17911
			// (get) Token: 0x0600E67A RID: 59002 RVA: 0x00383EE8 File Offset: 0x003820E8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E67B RID: 59003 RVA: 0x00383F28 File Offset: 0x00382128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205874, XrefRangeEnd = 205879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170045F8 RID: 17912
			// (get) Token: 0x0600E67C RID: 59004 RVA: 0x00383F5C File Offset: 0x0038215C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E67D RID: 59005 RVA: 0x0006CB3D File Offset: 0x0006AD3D
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045F4 RID: 17908
			// (get) Token: 0x0600E67E RID: 59006 RVA: 0x00383F9C File Offset: 0x0038219C
			// (set) Token: 0x0600E67F RID: 59007 RVA: 0x0006CB46 File Offset: 0x0006AD46
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170045F5 RID: 17909
			// (get) Token: 0x0600E680 RID: 59008 RVA: 0x00383FC4 File Offset: 0x003821C4
			// (set) Token: 0x0600E681 RID: 59009 RVA: 0x0006CB61 File Offset: 0x0006AD61
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045F6 RID: 17910
			// (get) Token: 0x0600E682 RID: 59010 RVA: 0x00383FF4 File Offset: 0x003821F4
			// (set) Token: 0x0600E683 RID: 59011 RVA: 0x0006CB80 File Offset: 0x0006AD80
			public unsafe RTBInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009C7B RID: 40059
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009C7C RID: 40060
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009C7D RID: 40061
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009C7E RID: 40062
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009C7F RID: 40063
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009C80 RID: 40064
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009C81 RID: 40065
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009C82 RID: 40066
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009C83 RID: 40067
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B30 RID: 2864
		[ObfuscatedName("ScheduleOne.Casino.UI.RTBInterface+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E684 RID: 59012 RVA: 0x00384024 File Offset: 0x00382224
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<RTBInterface.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass26_0>.NativeClassPtr);
				RTBInterface.__c__DisplayClass26_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass26_0>.NativeClassPtr, "index");
				RTBInterface.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass26_0>.NativeClassPtr, "<>4__this");
				RTBInterface.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass26_0>.NativeClassPtr, 100676056);
				RTBInterface.__c__DisplayClass26_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass26_0>.NativeClassPtr, 100676057);
			}

			// Token: 0x0600E685 RID: 59013 RVA: 0x003840A0 File Offset: 0x003822A0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E686 RID: 59014 RVA: 0x003840DC File Offset: 0x003822DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205879, XrefRangeEnd = 205888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.__c__DisplayClass26_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E687 RID: 59015 RVA: 0x0006CB9F File Offset: 0x0006AD9F
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045F9 RID: 17913
			// (get) Token: 0x0600E688 RID: 59016 RVA: 0x00384110 File Offset: 0x00382310
			// (set) Token: 0x0600E689 RID: 59017 RVA: 0x0006CBA8 File Offset: 0x0006ADA8
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.__c__DisplayClass26_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.__c__DisplayClass26_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170045FA RID: 17914
			// (get) Token: 0x0600E68A RID: 59018 RVA: 0x00384138 File Offset: 0x00382338
			// (set) Token: 0x0600E68B RID: 59019 RVA: 0x0006CBC3 File Offset: 0x0006ADC3
			public unsafe RTBInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009C84 RID: 40068
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04009C85 RID: 40069
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009C86 RID: 40070
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C87 RID: 40071
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;
		}
	}
}
