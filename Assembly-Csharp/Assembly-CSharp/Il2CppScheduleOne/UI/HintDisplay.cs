using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI.Input;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text.RegularExpressions;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000739 RID: 1849
	public class HintDisplay : Singleton<HintDisplay>
	{
		// Token: 0x0600B26F RID: 45679 RVA: 0x002E8260 File Offset: 0x002E6460
		// Note: this type is marked as 'beforefieldinit'.
		static HintDisplay()
		{
			Il2CppClassPointerStore<HintDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "HintDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr);
			HintDisplay.NativeFieldInfoPtr_FadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "FadeTime");
			HintDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "<IsOpen>k__BackingField");
			HintDisplay.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Container");
			HintDisplay.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Label");
			HintDisplay.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Group");
			HintDisplay.NativeFieldInfoPtr_FlashAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "FlashAnim");
			HintDisplay.NativeFieldInfoPtr_DismissAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "DismissAction");
			HintDisplay.NativeFieldInfoPtr_InputPromptObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "InputPromptObj");
			HintDisplay.NativeFieldInfoPtr_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Padding");
			HintDisplay.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Offset");
			HintDisplay.NativeFieldInfoPtr_autoCloseRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "autoCloseRoutine");
			HintDisplay.NativeFieldInfoPtr_fadeRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "fadeRoutine");
			HintDisplay.NativeFieldInfoPtr_hintQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "hintQueue");
			HintDisplay.NativeFieldInfoPtr_timeSinceOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "timeSinceOpened");
			HintDisplay.NativeFieldInfoPtr__currentHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "_currentHint");
			HintDisplay.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100686744);
			HintDisplay.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100686745);
			HintDisplay.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100686746);
			HintDisplay.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100686747);
			HintDisplay.NativeMethodInfoPtr_ShowHint_10s_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100686748);
			HintDisplay.NativeMethodInfoPtr_ShowHint_20s_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100686749);
			HintDisplay.NativeMethodInfoPtr_ShowHint_Public_Void_String_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100686750);
			HintDisplay.NativeMethodInfoPtr_ProcessHint_Private_Void_String_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100686751);
			HintDisplay.NativeMethodInfoPtr_SetHint_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100686752);
			HintDisplay.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100686753);
			HintDisplay.NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100686754);
			HintDisplay.NativeMethodInfoPtr_QueueHint_10s_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100686755);
			HintDisplay.NativeMethodInfoPtr_QueueHint_20s_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100686756);
			HintDisplay.NativeMethodInfoPtr_QueueHint_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100686757);
			HintDisplay.NativeMethodInfoPtr_ProcessText_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100686758);
			HintDisplay.NativeMethodInfoPtr_GetHintTextForCurrentDevice_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100686759);
			HintDisplay.NativeMethodInfoPtr_HandleInputDeviceChanged_Private_Void_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100686760);
			HintDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100686761);
			HintDisplay.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100686762);
		}

		// Token: 0x170035B6 RID: 13750
		// (get) Token: 0x0600B270 RID: 45680 RVA: 0x002E8538 File Offset: 0x002E6738
		// (set) Token: 0x0600B271 RID: 45681 RVA: 0x002E8574 File Offset: 0x002E6774
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B272 RID: 45682 RVA: 0x002E85B4 File Offset: 0x002E67B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302113, XrefRangeEnd = 302142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HintDisplay.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B273 RID: 45683 RVA: 0x002E85F0 File Offset: 0x002E67F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302142, XrefRangeEnd = 302164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B274 RID: 45684 RVA: 0x002E8624 File Offset: 0x002E6824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302164, XrefRangeEnd = 302172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowHint_10s(string text, string alternateText = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(alternateText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_ShowHint_10s_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B275 RID: 45685 RVA: 0x002E8678 File Offset: 0x002E6878
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 302180, RefRangeEnd = 302189, XrefRangeStart = 302172, XrefRangeEnd = 302180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowHint_20s(string text, string alternateText = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(alternateText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_ShowHint_20s_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B276 RID: 45686 RVA: 0x002E86CC File Offset: 0x002E68CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 302197, RefRangeEnd = 302202, XrefRangeStart = 302189, XrefRangeEnd = 302197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowHint(string text, float autoCloseTime = 0f, string alternateText = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoCloseTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(alternateText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_ShowHint_Public_Void_String_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B277 RID: 45687 RVA: 0x002E8730 File Offset: 0x002E6930
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 302197, RefRangeEnd = 302202, XrefRangeStart = 302197, XrefRangeEnd = 302202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessHint(string text, float autoCloseTime = 0f, string alternateText = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoCloseTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(alternateText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_ProcessHint_Private_Void_String_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B278 RID: 45688 RVA: 0x002E8794 File Offset: 0x002E6994
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 302223, RefRangeEnd = 302227, XrefRangeStart = 302202, XrefRangeEnd = 302223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHint(float autoCloseTime = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref autoCloseTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_SetHint_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B279 RID: 45689 RVA: 0x002E87D4 File Offset: 0x002E69D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302231, RefRangeEnd = 302232, XrefRangeStart = 302227, XrefRangeEnd = 302231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B27A RID: 45690 RVA: 0x002E8808 File Offset: 0x002E6A08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 302248, RefRangeEnd = 302251, XrefRangeStart = 302232, XrefRangeEnd = 302248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B27B RID: 45691 RVA: 0x002E8848 File Offset: 0x002E6A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302251, XrefRangeEnd = 302263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueHint_10s(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_QueueHint_10s_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B27C RID: 45692 RVA: 0x002E888C File Offset: 0x002E6A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302263, XrefRangeEnd = 302275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueHint_20s(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_QueueHint_20s_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B27D RID: 45693 RVA: 0x002E88D0 File Offset: 0x002E6AD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 302284, RefRangeEnd = 302286, XrefRangeStart = 302275, XrefRangeEnd = 302284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueHint(string message, float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_QueueHint_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B27E RID: 45694 RVA: 0x002E8920 File Offset: 0x002E6B20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 302328, RefRangeEnd = 302330, XrefRangeStart = 302286, XrefRangeEnd = 302328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ProcessText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_ProcessText_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600B27F RID: 45695 RVA: 0x002E8968 File Offset: 0x002E6B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302330, XrefRangeEnd = 302337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetHintTextForCurrentDevice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_GetHintTextForCurrentDevice_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600B280 RID: 45696 RVA: 0x002E89A0 File Offset: 0x002E6BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302337, XrefRangeEnd = 302339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleInputDeviceChanged(GameInput.InputDeviceType newDevice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newDevice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_HandleInputDeviceChanged_Private_Void_InputDeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B281 RID: 45697 RVA: 0x002E89E0 File Offset: 0x002E6BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302339, XrefRangeEnd = 302349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HintDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B282 RID: 45698 RVA: 0x002E8A1C File Offset: 0x002E6C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302349, XrefRangeEnd = 302354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_Single_PDM_0(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B283 RID: 45699 RVA: 0x000521EC File Offset: 0x000503EC
		public HintDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170035A7 RID: 13735
		// (get) Token: 0x0600B284 RID: 45700 RVA: 0x002E8A68 File Offset: 0x002E6C68
		// (set) Token: 0x0600B285 RID: 45701 RVA: 0x000521F5 File Offset: 0x000503F5
		public unsafe static float FadeTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(HintDisplay.NativeFieldInfoPtr_FadeTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HintDisplay.NativeFieldInfoPtr_FadeTime, (void*)(&value));
			}
		}

		// Token: 0x170035A8 RID: 13736
		// (get) Token: 0x0600B286 RID: 45702 RVA: 0x002E8A84 File Offset: 0x002E6C84
		// (set) Token: 0x0600B287 RID: 45703 RVA: 0x00052203 File Offset: 0x00050403
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170035A9 RID: 13737
		// (get) Token: 0x0600B288 RID: 45704 RVA: 0x002E8AAC File Offset: 0x002E6CAC
		// (set) Token: 0x0600B289 RID: 45705 RVA: 0x0005221E File Offset: 0x0005041E
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035AA RID: 13738
		// (get) Token: 0x0600B28A RID: 45706 RVA: 0x002E8ADC File Offset: 0x002E6CDC
		// (set) Token: 0x0600B28B RID: 45707 RVA: 0x0005223D File Offset: 0x0005043D
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035AB RID: 13739
		// (get) Token: 0x0600B28C RID: 45708 RVA: 0x002E8B0C File Offset: 0x002E6D0C
		// (set) Token: 0x0600B28D RID: 45709 RVA: 0x0005225C File Offset: 0x0005045C
		public unsafe CanvasGroup Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035AC RID: 13740
		// (get) Token: 0x0600B28E RID: 45710 RVA: 0x002E8B3C File Offset: 0x002E6D3C
		// (set) Token: 0x0600B28F RID: 45711 RVA: 0x0005227B File Offset: 0x0005047B
		public unsafe Animation FlashAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_FlashAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_FlashAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035AD RID: 13741
		// (get) Token: 0x0600B290 RID: 45712 RVA: 0x002E8B6C File Offset: 0x002E6D6C
		// (set) Token: 0x0600B291 RID: 45713 RVA: 0x0005229A File Offset: 0x0005049A
		public unsafe InputActionReference DismissAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_DismissAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_DismissAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035AE RID: 13742
		// (get) Token: 0x0600B292 RID: 45714 RVA: 0x002E8B9C File Offset: 0x002E6D9C
		// (set) Token: 0x0600B293 RID: 45715 RVA: 0x000522B9 File Offset: 0x000504B9
		public unsafe InputPromptObj InputPromptObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_InputPromptObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptObj>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_InputPromptObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035AF RID: 13743
		// (get) Token: 0x0600B294 RID: 45716 RVA: 0x002E8BCC File Offset: 0x002E6DCC
		// (set) Token: 0x0600B295 RID: 45717 RVA: 0x000522D8 File Offset: 0x000504D8
		public unsafe Vector2 Padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Padding)) = value;
			}
		}

		// Token: 0x170035B0 RID: 13744
		// (get) Token: 0x0600B296 RID: 45718 RVA: 0x002E8BF4 File Offset: 0x002E6DF4
		// (set) Token: 0x0600B297 RID: 45719 RVA: 0x000522F3 File Offset: 0x000504F3
		public unsafe Vector2 Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Offset)) = value;
			}
		}

		// Token: 0x170035B1 RID: 13745
		// (get) Token: 0x0600B298 RID: 45720 RVA: 0x002E8C1C File Offset: 0x002E6E1C
		// (set) Token: 0x0600B299 RID: 45721 RVA: 0x0005230E File Offset: 0x0005050E
		public unsafe Coroutine autoCloseRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_autoCloseRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_autoCloseRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035B2 RID: 13746
		// (get) Token: 0x0600B29A RID: 45722 RVA: 0x002E8C4C File Offset: 0x002E6E4C
		// (set) Token: 0x0600B29B RID: 45723 RVA: 0x0005232D File Offset: 0x0005052D
		public unsafe Coroutine fadeRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_fadeRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_fadeRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035B3 RID: 13747
		// (get) Token: 0x0600B29C RID: 45724 RVA: 0x002E8C7C File Offset: 0x002E6E7C
		// (set) Token: 0x0600B29D RID: 45725 RVA: 0x0005234C File Offset: 0x0005054C
		public unsafe List<HintDisplay.Hint> hintQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_hintQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<HintDisplay.Hint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_hintQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035B4 RID: 13748
		// (get) Token: 0x0600B29E RID: 45726 RVA: 0x002E8CAC File Offset: 0x002E6EAC
		// (set) Token: 0x0600B29F RID: 45727 RVA: 0x0005236B File Offset: 0x0005056B
		public unsafe float timeSinceOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_timeSinceOpened);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_timeSinceOpened)) = value;
			}
		}

		// Token: 0x170035B5 RID: 13749
		// (get) Token: 0x0600B2A0 RID: 45728 RVA: 0x002E8CD4 File Offset: 0x002E6ED4
		// (set) Token: 0x0600B2A1 RID: 45729 RVA: 0x00052386 File Offset: 0x00050586
		public unsafe HintDisplay.Hint _currentHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr__currentHint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HintDisplay.Hint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr__currentHint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007AE2 RID: 31458
		private static readonly IntPtr NativeFieldInfoPtr_FadeTime;

		// Token: 0x04007AE3 RID: 31459
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04007AE4 RID: 31460
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04007AE5 RID: 31461
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04007AE6 RID: 31462
		private static readonly IntPtr NativeFieldInfoPtr_Group;

		// Token: 0x04007AE7 RID: 31463
		private static readonly IntPtr NativeFieldInfoPtr_FlashAnim;

		// Token: 0x04007AE8 RID: 31464
		private static readonly IntPtr NativeFieldInfoPtr_DismissAction;

		// Token: 0x04007AE9 RID: 31465
		private static readonly IntPtr NativeFieldInfoPtr_InputPromptObj;

		// Token: 0x04007AEA RID: 31466
		private static readonly IntPtr NativeFieldInfoPtr_Padding;

		// Token: 0x04007AEB RID: 31467
		private static readonly IntPtr NativeFieldInfoPtr_Offset;

		// Token: 0x04007AEC RID: 31468
		private static readonly IntPtr NativeFieldInfoPtr_autoCloseRoutine;

		// Token: 0x04007AED RID: 31469
		private static readonly IntPtr NativeFieldInfoPtr_fadeRoutine;

		// Token: 0x04007AEE RID: 31470
		private static readonly IntPtr NativeFieldInfoPtr_hintQueue;

		// Token: 0x04007AEF RID: 31471
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceOpened;

		// Token: 0x04007AF0 RID: 31472
		private static readonly IntPtr NativeFieldInfoPtr__currentHint;

		// Token: 0x04007AF1 RID: 31473
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04007AF2 RID: 31474
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04007AF3 RID: 31475
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04007AF4 RID: 31476
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04007AF5 RID: 31477
		private static readonly IntPtr NativeMethodInfoPtr_ShowHint_10s_Public_Void_String_String_0;

		// Token: 0x04007AF6 RID: 31478
		private static readonly IntPtr NativeMethodInfoPtr_ShowHint_20s_Public_Void_String_String_0;

		// Token: 0x04007AF7 RID: 31479
		private static readonly IntPtr NativeMethodInfoPtr_ShowHint_Public_Void_String_Single_String_0;

		// Token: 0x04007AF8 RID: 31480
		private static readonly IntPtr NativeMethodInfoPtr_ProcessHint_Private_Void_String_Single_String_0;

		// Token: 0x04007AF9 RID: 31481
		private static readonly IntPtr NativeMethodInfoPtr_SetHint_Private_Void_Single_0;

		// Token: 0x04007AFA RID: 31482
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

		// Token: 0x04007AFB RID: 31483
		private static readonly IntPtr NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0;

		// Token: 0x04007AFC RID: 31484
		private static readonly IntPtr NativeMethodInfoPtr_QueueHint_10s_Public_Void_String_0;

		// Token: 0x04007AFD RID: 31485
		private static readonly IntPtr NativeMethodInfoPtr_QueueHint_20s_Public_Void_String_0;

		// Token: 0x04007AFE RID: 31486
		private static readonly IntPtr NativeMethodInfoPtr_QueueHint_Public_Void_String_Single_0;

		// Token: 0x04007AFF RID: 31487
		private static readonly IntPtr NativeMethodInfoPtr_ProcessText_Private_String_String_0;

		// Token: 0x04007B00 RID: 31488
		private static readonly IntPtr NativeMethodInfoPtr_GetHintTextForCurrentDevice_Private_String_0;

		// Token: 0x04007B01 RID: 31489
		private static readonly IntPtr NativeMethodInfoPtr_HandleInputDeviceChanged_Private_Void_InputDeviceType_0;

		// Token: 0x04007B02 RID: 31490
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007B03 RID: 31491
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0;

		// Token: 0x02000CCC RID: 3276
		public class Hint : Il2CppSystem.Object
		{
			// Token: 0x0600F4ED RID: 62701 RVA: 0x003ADAB0 File Offset: 0x003ABCB0
			// Note: this type is marked as 'beforefieldinit'.
			static Hint()
			{
				Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Hint");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr);
				HintDisplay.Hint.NativeFieldInfoPtr_StandardText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr, "StandardText");
				HintDisplay.Hint.NativeFieldInfoPtr_GamepadText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr, "GamepadText");
				HintDisplay.Hint.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr, "Duration");
				HintDisplay.Hint.NativeMethodInfoPtr__ctor_Public_Void_String_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr, 100686763);
			}

			// Token: 0x0600F4EE RID: 62702 RVA: 0x003ADB2C File Offset: 0x003ABD2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302061, XrefRangeEnd = 302064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Hint(string text, float duration, string gamepadText = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gamepadText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.Hint.NativeMethodInfoPtr__ctor_Public_Void_String_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4EF RID: 62703 RVA: 0x00073BE0 File Offset: 0x00071DE0
			public Hint(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A63 RID: 19043
			// (get) Token: 0x0600F4F0 RID: 62704 RVA: 0x003ADB98 File Offset: 0x003ABD98
			// (set) Token: 0x0600F4F1 RID: 62705 RVA: 0x00073BE9 File Offset: 0x00071DE9
			public unsafe string StandardText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.Hint.NativeFieldInfoPtr_StandardText);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.Hint.NativeFieldInfoPtr_StandardText), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004A64 RID: 19044
			// (get) Token: 0x0600F4F2 RID: 62706 RVA: 0x003ADBC0 File Offset: 0x003ABDC0
			// (set) Token: 0x0600F4F3 RID: 62707 RVA: 0x00073C08 File Offset: 0x00071E08
			public unsafe string GamepadText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.Hint.NativeFieldInfoPtr_GamepadText);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.Hint.NativeFieldInfoPtr_GamepadText), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004A65 RID: 19045
			// (get) Token: 0x0600F4F4 RID: 62708 RVA: 0x003ADBE8 File Offset: 0x003ABDE8
			// (set) Token: 0x0600F4F5 RID: 62709 RVA: 0x00073C27 File Offset: 0x00071E27
			public unsafe float Duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.Hint.NativeFieldInfoPtr_Duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.Hint.NativeFieldInfoPtr_Duration)) = value;
				}
			}

			// Token: 0x0400A5C2 RID: 42434
			private static readonly IntPtr NativeFieldInfoPtr_StandardText;

			// Token: 0x0400A5C3 RID: 42435
			private static readonly IntPtr NativeFieldInfoPtr_GamepadText;

			// Token: 0x0400A5C4 RID: 42436
			private static readonly IntPtr NativeFieldInfoPtr_Duration;

			// Token: 0x0400A5C5 RID: 42437
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_String_0;
		}

		// Token: 0x02000CCD RID: 3277
		[ObfuscatedName("ScheduleOne.UI.HintDisplay+<<SetHint>g__AutoClose|25_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600F4F6 RID: 62710 RVA: 0x003ADC10 File Offset: 0x003ABE10
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique()
			{
				Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "<<SetHint>g__AutoClose|25_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, "<>1__state");
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, "<>2__current");
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, "time");
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, "<>4__this");
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100686764);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100686765);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100686766);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100686767);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100686768);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100686769);
			}

			// Token: 0x0600F4F7 RID: 62711 RVA: 0x003ADD04 File Offset: 0x003ABF04
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4F8 RID: 62712 RVA: 0x003ADD4C File Offset: 0x003ABF4C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4F9 RID: 62713 RVA: 0x003ADD80 File Offset: 0x003ABF80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302064, XrefRangeEnd = 302069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004A6A RID: 19050
			// (get) Token: 0x0600F4FA RID: 62714 RVA: 0x003ADDBC File Offset: 0x003ABFBC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F4FB RID: 62715 RVA: 0x003ADDFC File Offset: 0x003ABFFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302069, XrefRangeEnd = 302074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004A6B RID: 19051
			// (get) Token: 0x0600F4FC RID: 62716 RVA: 0x003ADE30 File Offset: 0x003AC030
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F4FD RID: 62717 RVA: 0x00073C42 File Offset: 0x00071E42
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A66 RID: 19046
			// (get) Token: 0x0600F4FE RID: 62718 RVA: 0x003ADE70 File Offset: 0x003AC070
			// (set) Token: 0x0600F4FF RID: 62719 RVA: 0x00073C4B File Offset: 0x00071E4B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004A67 RID: 19047
			// (get) Token: 0x0600F500 RID: 62720 RVA: 0x003ADE98 File Offset: 0x003AC098
			// (set) Token: 0x0600F501 RID: 62721 RVA: 0x00073C66 File Offset: 0x00071E66
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A68 RID: 19048
			// (get) Token: 0x0600F502 RID: 62722 RVA: 0x003ADEC8 File Offset: 0x003AC0C8
			// (set) Token: 0x0600F503 RID: 62723 RVA: 0x00073C85 File Offset: 0x00071E85
			public unsafe float time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x17004A69 RID: 19049
			// (get) Token: 0x0600F504 RID: 62724 RVA: 0x003ADEF0 File Offset: 0x003AC0F0
			// (set) Token: 0x0600F505 RID: 62725 RVA: 0x00073CA0 File Offset: 0x00071EA0
			public unsafe HintDisplay __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HintDisplay>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A5C6 RID: 42438
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A5C7 RID: 42439
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A5C8 RID: 42440
			private static readonly IntPtr NativeFieldInfoPtr_time;

			// Token: 0x0400A5C9 RID: 42441
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A5CA RID: 42442
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A5CB RID: 42443
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A5CC RID: 42444
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A5CD RID: 42445
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A5CE RID: 42446
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A5CF RID: 42447
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000CCE RID: 3278
		[ObfuscatedName("ScheduleOne.UI.HintDisplay+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F506 RID: 62726 RVA: 0x003ADF20 File Offset: 0x003AC120
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr);
				HintDisplay.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr, "<>9");
				HintDisplay.__c.NativeFieldInfoPtr___9__31_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr, "<>9__31_0");
				HintDisplay.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr, 100686771);
				HintDisplay.__c.NativeMethodInfoPtr__ProcessText_b__31_0_Internal_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr, 100686772);
			}

			// Token: 0x0600F507 RID: 62727 RVA: 0x003ADF9C File Offset: 0x003AC19C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F508 RID: 62728 RVA: 0x003ADFD8 File Offset: 0x003AC1D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302074, XrefRangeEnd = 302093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ProcessText_b__31_0(Match match)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c.NativeMethodInfoPtr__ProcessText_b__31_0_Internal_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600F509 RID: 62729 RVA: 0x00073CBF File Offset: 0x00071EBF
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A6C RID: 19052
			// (get) Token: 0x0600F50A RID: 62730 RVA: 0x003AE020 File Offset: 0x003AC220
			// (set) Token: 0x0600F50B RID: 62731 RVA: 0x00073CC8 File Offset: 0x00071EC8
			public unsafe static HintDisplay.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HintDisplay.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HintDisplay.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HintDisplay.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A6D RID: 19053
			// (get) Token: 0x0600F50C RID: 62732 RVA: 0x003AE048 File Offset: 0x003AC248
			// (set) Token: 0x0600F50D RID: 62733 RVA: 0x00073CDA File Offset: 0x00071EDA
			public unsafe static MatchEvaluator __9__31_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HintDisplay.__c.NativeFieldInfoPtr___9__31_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchEvaluator>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HintDisplay.__c.NativeFieldInfoPtr___9__31_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A5D0 RID: 42448
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A5D1 RID: 42449
			private static readonly IntPtr NativeFieldInfoPtr___9__31_0;

			// Token: 0x0400A5D2 RID: 42450
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A5D3 RID: 42451
			private static readonly IntPtr NativeMethodInfoPtr__ProcessText_b__31_0_Internal_String_Match_0;
		}

		// Token: 0x02000CCF RID: 3279
		[ObfuscatedName("ScheduleOne.UI.HintDisplay+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F50E RID: 62734 RVA: 0x003AE070 File Offset: 0x003AC270
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<HintDisplay.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass27_0>.NativeClassPtr);
				HintDisplay.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				HintDisplay.__c__DisplayClass27_0.NativeFieldInfoPtr_alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass27_0>.NativeClassPtr, "alpha");
				HintDisplay.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass27_0>.NativeClassPtr, 100686773);
				HintDisplay.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass27_0>.NativeClassPtr, 100686774);
			}

			// Token: 0x0600F50F RID: 62735 RVA: 0x003AE0EC File Offset: 0x003AC2EC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F510 RID: 62736 RVA: 0x003AE128 File Offset: 0x003AC328
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302108, XrefRangeEnd = 302113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F511 RID: 62737 RVA: 0x00073CEC File Offset: 0x00071EEC
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A6E RID: 19054
			// (get) Token: 0x0600F512 RID: 62738 RVA: 0x003AE168 File Offset: 0x003AC368
			// (set) Token: 0x0600F513 RID: 62739 RVA: 0x00073CF5 File Offset: 0x00071EF5
			public unsafe HintDisplay __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HintDisplay>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A6F RID: 19055
			// (get) Token: 0x0600F514 RID: 62740 RVA: 0x003AE198 File Offset: 0x003AC398
			// (set) Token: 0x0600F515 RID: 62741 RVA: 0x00073D14 File Offset: 0x00071F14
			public unsafe float alpha
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass27_0.NativeFieldInfoPtr_alpha);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass27_0.NativeFieldInfoPtr_alpha)) = value;
				}
			}

			// Token: 0x0400A5D4 RID: 42452
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A5D5 RID: 42453
			private static readonly IntPtr NativeFieldInfoPtr_alpha;

			// Token: 0x0400A5D6 RID: 42454
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A5D7 RID: 42455
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000E0A RID: 3594
			[ObfuscatedName("ScheduleOne.UI.HintDisplay+<>c__DisplayClass27_0+<<SetAlpha>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060102F0 RID: 66288 RVA: 0x003D67A8 File Offset: 0x003D49A8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique()
				{
					Il2CppClassPointerStore<HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass27_0>.NativeClassPtr, "<<SetAlpha>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr);
					HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>1__state");
					HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>2__current");
					HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>4__this");
					HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startAlpha_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<startAlpha>5__2");
					HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<i>5__3");
					HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100686775);
					HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100686776);
					HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100686777);
					HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100686778);
					HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100686779);
					HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100686780);
				}

				// Token: 0x060102F1 RID: 66289 RVA: 0x003D68B0 File Offset: 0x003D4AB0
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060102F2 RID: 66290 RVA: 0x003D68F8 File Offset: 0x003D4AF8
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060102F3 RID: 66291 RVA: 0x003D692C File Offset: 0x003D4B2C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302093, XrefRangeEnd = 302103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004F18 RID: 20248
				// (get) Token: 0x060102F4 RID: 66292 RVA: 0x003D6968 File Offset: 0x003D4B68
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060102F5 RID: 66293 RVA: 0x003D69A8 File Offset: 0x003D4BA8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302103, XrefRangeEnd = 302108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004F19 RID: 20249
				// (get) Token: 0x060102F6 RID: 66294 RVA: 0x003D69DC File Offset: 0x003D4BDC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060102F7 RID: 66295 RVA: 0x0007AC43 File Offset: 0x00078E43
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004F13 RID: 20243
				// (get) Token: 0x060102F8 RID: 66296 RVA: 0x003D6A1C File Offset: 0x003D4C1C
				// (set) Token: 0x060102F9 RID: 66297 RVA: 0x0007AC4C File Offset: 0x00078E4C
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004F14 RID: 20244
				// (get) Token: 0x060102FA RID: 66298 RVA: 0x003D6A44 File Offset: 0x003D4C44
				// (set) Token: 0x060102FB RID: 66299 RVA: 0x0007AC67 File Offset: 0x00078E67
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F15 RID: 20245
				// (get) Token: 0x060102FC RID: 66300 RVA: 0x003D6A74 File Offset: 0x003D4C74
				// (set) Token: 0x060102FD RID: 66301 RVA: 0x0007AC86 File Offset: 0x00078E86
				public unsafe HintDisplay.__c__DisplayClass27_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<HintDisplay.__c__DisplayClass27_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F16 RID: 20246
				// (get) Token: 0x060102FE RID: 66302 RVA: 0x003D6AA4 File Offset: 0x003D4CA4
				// (set) Token: 0x060102FF RID: 66303 RVA: 0x0007ACA5 File Offset: 0x00078EA5
				public unsafe float _startAlpha_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startAlpha_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startAlpha_5__2)) = value;
					}
				}

				// Token: 0x17004F17 RID: 20247
				// (get) Token: 0x06010300 RID: 66304 RVA: 0x003D6ACC File Offset: 0x003D4CCC
				// (set) Token: 0x06010301 RID: 66305 RVA: 0x0007ACC0 File Offset: 0x00078EC0
				public unsafe float _i_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x0400AE49 RID: 44617
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AE4A RID: 44618
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AE4B RID: 44619
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AE4C RID: 44620
				private static readonly IntPtr NativeFieldInfoPtr__startAlpha_5__2;

				// Token: 0x0400AE4D RID: 44621
				private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x0400AE4E RID: 44622
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AE4F RID: 44623
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AE50 RID: 44624
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AE51 RID: 44625
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AE52 RID: 44626
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AE53 RID: 44627
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
