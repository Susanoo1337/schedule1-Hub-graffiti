using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ObjectScripts.Cash;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.State;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000740 RID: 1856
	public class LaunderingInterface : MonoBehaviour
	{
		// Token: 0x0600B3B9 RID: 46009 RVA: 0x002EC000 File Offset: 0x002EA200
		// Note: this type is marked as 'beforefieldinit'.
		static LaunderingInterface()
		{
			Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "LaunderingInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr);
			LaunderingInterface.NativeFieldInfoPtr_FoV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "FoV");
			LaunderingInterface.NativeFieldInfoPtr_LerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "LerpTime");
			LaunderingInterface.NativeFieldInfoPtr_MinLaunderAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "MinLaunderAmount");
			LaunderingInterface.NativeFieldInfoPtr__Business_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "<Business>k__BackingField");
			LaunderingInterface.NativeFieldInfoPtr_cameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "cameraPosition");
			LaunderingInterface.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "intObj");
			LaunderingInterface.NativeFieldInfoPtr_launderButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "launderButton");
			LaunderingInterface.NativeFieldInfoPtr_amountSelectorScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "amountSelectorScreen");
			LaunderingInterface.NativeFieldInfoPtr_amountSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "amountSlider");
			LaunderingInterface.NativeFieldInfoPtr_amountInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "amountInputField");
			LaunderingInterface.NativeFieldInfoPtr_notchContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "notchContainer");
			LaunderingInterface.NativeFieldInfoPtr_currentTotalAmountLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "currentTotalAmountLabel");
			LaunderingInterface.NativeFieldInfoPtr_launderCapacityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "launderCapacityLabel");
			LaunderingInterface.NativeFieldInfoPtr_insufficientCashLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "insufficientCashLabel");
			LaunderingInterface.NativeFieldInfoPtr_entryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "entryContainer");
			LaunderingInterface.NativeFieldInfoPtr_noEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "noEntries");
			LaunderingInterface.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "container");
			LaunderingInterface.NativeFieldInfoPtr_cashStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "cashStacks");
			LaunderingInterface.NativeFieldInfoPtr_mainState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "mainState");
			LaunderingInterface.NativeFieldInfoPtr_amountSelectorState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "amountSelectorState");
			LaunderingInterface.NativeFieldInfoPtr_timelineNotchPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "timelineNotchPrefab");
			LaunderingInterface.NativeFieldInfoPtr_entryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "entryPrefab");
			LaunderingInterface.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "canvas");
			LaunderingInterface.NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "scrollRect");
			LaunderingInterface.NativeFieldInfoPtr_selectedAmountToLaunder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "selectedAmountToLaunder");
			LaunderingInterface.NativeFieldInfoPtr_operationToNotch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "operationToNotch");
			LaunderingInterface.NativeFieldInfoPtr_notches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "notches");
			LaunderingInterface.NativeFieldInfoPtr_ignoreSliderChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "ignoreSliderChange");
			LaunderingInterface.NativeFieldInfoPtr_operationToEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "operationToEntry");
			LaunderingInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686872);
			LaunderingInterface.NativeMethodInfoPtr_get_Business_Public_get_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686873);
			LaunderingInterface.NativeMethodInfoPtr_set_Business_Private_set_Void_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686874);
			LaunderingInterface.NativeMethodInfoPtr_get_maxLaunderAmount_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686875);
			LaunderingInterface.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686876);
			LaunderingInterface.NativeMethodInfoPtr_Initialize_Public_Void_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686877);
			LaunderingInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686878);
			LaunderingInterface.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686879);
			LaunderingInterface.NativeMethodInfoPtr_UpdateTimeline_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686880);
			LaunderingInterface.NativeMethodInfoPtr_UpdateCurrentTotal_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686881);
			LaunderingInterface.NativeMethodInfoPtr_CreateEntry_Private_Void_LaunderingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686882);
			LaunderingInterface.NativeMethodInfoPtr_RemoveEntry_Private_Void_LaunderingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686883);
			LaunderingInterface.NativeMethodInfoPtr_UpdateEntryTimes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686884);
			LaunderingInterface.NativeMethodInfoPtr_UpdateCashStacks_Private_Void_LaunderingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686885);
			LaunderingInterface.NativeMethodInfoPtr_RefreshLaunderButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686886);
			LaunderingInterface.NativeMethodInfoPtr_OpenAmountSelector_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686887);
			LaunderingInterface.NativeMethodInfoPtr_CloseAmountSelector_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686888);
			LaunderingInterface.NativeMethodInfoPtr_OnAmountSelectorClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686889);
			LaunderingInterface.NativeMethodInfoPtr_ConfirmAmount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686890);
			LaunderingInterface.NativeMethodInfoPtr_SliderValueChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686891);
			LaunderingInterface.NativeMethodInfoPtr_InputValueChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686892);
			LaunderingInterface.NativeMethodInfoPtr_ChangeSelectorValue_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686893);
			LaunderingInterface.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686894);
			LaunderingInterface.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686895);
			LaunderingInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686896);
			LaunderingInterface.NativeMethodInfoPtr_OnClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686897);
			LaunderingInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686898);
			LaunderingInterface.NativeMethodInfoPtr__Initialize_b__37_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686899);
			LaunderingInterface.NativeMethodInfoPtr__UpdateTimeline_b__40_0_Private_Boolean_KeyValuePair_2_LaunderingOperation_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100686900);
		}

		// Token: 0x17003636 RID: 13878
		// (get) Token: 0x0600B3BA RID: 46010 RVA: 0x002EC4B8 File Offset: 0x002EA6B8
		public unsafe bool IsOpen
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 303090, RefRangeEnd = 303094, XrefRangeStart = 303086, XrefRangeEnd = 303090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003637 RID: 13879
		// (get) Token: 0x0600B3BB RID: 46011 RVA: 0x002EC4F4 File Offset: 0x002EA6F4
		// (set) Token: 0x0600B3BC RID: 46012 RVA: 0x002EC534 File Offset: 0x002EA734
		public unsafe Business Business
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_get_Business_Public_get_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Business>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_set_Business_Private_set_Void_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003638 RID: 13880
		// (get) Token: 0x0600B3BD RID: 46013 RVA: 0x002EC578 File Offset: 0x002EA778
		public unsafe int maxLaunderAmount
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 303100, RefRangeEnd = 303104, XrefRangeStart = 303094, XrefRangeEnd = 303100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_get_maxLaunderAmount_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600B3BE RID: 46014 RVA: 0x002EC5B4 File Offset: 0x002EA7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303104, XrefRangeEnd = 303108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3BF RID: 46015 RVA: 0x002EC5E8 File Offset: 0x002EA7E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303260, RefRangeEnd = 303261, XrefRangeStart = 303108, XrefRangeEnd = 303260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Business bus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bus);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_Initialize_Public_Void_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3C0 RID: 46016 RVA: 0x002EC62C File Offset: 0x002EA82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303261, XrefRangeEnd = 303336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3C1 RID: 46017 RVA: 0x002EC660 File Offset: 0x002EA860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303336, XrefRangeEnd = 303341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LaunderingInterface.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3C2 RID: 46018 RVA: 0x002EC69C File Offset: 0x002EA89C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 303448, RefRangeEnd = 303451, XrefRangeStart = 303341, XrefRangeEnd = 303448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimeline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_UpdateTimeline_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3C3 RID: 46019 RVA: 0x002EC6D0 File Offset: 0x002EA8D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 303457, RefRangeEnd = 303460, XrefRangeStart = 303451, XrefRangeEnd = 303457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurrentTotal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_UpdateCurrentTotal_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3C4 RID: 46020 RVA: 0x002EC704 File Offset: 0x002EA904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303498, RefRangeEnd = 303499, XrefRangeStart = 303460, XrefRangeEnd = 303498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateEntry(LaunderingOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_CreateEntry_Private_Void_LaunderingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3C5 RID: 46021 RVA: 0x002EC748 File Offset: 0x002EA948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303499, XrefRangeEnd = 303521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveEntry(LaunderingOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_RemoveEntry_Private_Void_LaunderingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3C6 RID: 46022 RVA: 0x002EC78C File Offset: 0x002EA98C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 303583, RefRangeEnd = 303585, XrefRangeStart = 303521, XrefRangeEnd = 303583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEntryTimes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_UpdateEntryTimes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3C7 RID: 46023 RVA: 0x002EC7C0 File Offset: 0x002EA9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303585, XrefRangeEnd = 303590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCashStacks(LaunderingOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_UpdateCashStacks_Private_Void_LaunderingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3C8 RID: 46024 RVA: 0x002EC804 File Offset: 0x002EAA04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 303620, RefRangeEnd = 303623, XrefRangeStart = 303590, XrefRangeEnd = 303620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshLaunderButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_RefreshLaunderButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3C9 RID: 46025 RVA: 0x002EC838 File Offset: 0x002EAA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303623, XrefRangeEnd = 303632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenAmountSelector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_OpenAmountSelector_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3CA RID: 46026 RVA: 0x002EC86C File Offset: 0x002EAA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303632, XrefRangeEnd = 303634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseAmountSelector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_CloseAmountSelector_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3CB RID: 46027 RVA: 0x002EC8A0 File Offset: 0x002EAAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303634, XrefRangeEnd = 303637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAmountSelectorClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_OnAmountSelectorClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3CC RID: 46028 RVA: 0x002EC8D4 File Offset: 0x002EAAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303637, XrefRangeEnd = 303664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmAmount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_ConfirmAmount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3CD RID: 46029 RVA: 0x002EC908 File Offset: 0x002EAB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303664, XrefRangeEnd = 303666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SliderValueChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_SliderValueChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3CE RID: 46030 RVA: 0x002EC93C File Offset: 0x002EAB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303666, XrefRangeEnd = 303672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InputValueChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_InputValueChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3CF RID: 46031 RVA: 0x002EC970 File Offset: 0x002EAB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303672, XrefRangeEnd = 303674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeSelectorValue(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_ChangeSelectorValue_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3D0 RID: 46032 RVA: 0x002EC9B0 File Offset: 0x002EABB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303674, XrefRangeEnd = 303679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3D1 RID: 46033 RVA: 0x002EC9E4 File Offset: 0x002EABE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303679, XrefRangeEnd = 303681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3D2 RID: 46034 RVA: 0x002ECA18 File Offset: 0x002EAC18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303706, RefRangeEnd = 303707, XrefRangeStart = 303681, XrefRangeEnd = 303706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3D3 RID: 46035 RVA: 0x002ECA4C File Offset: 0x002EAC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303707, XrefRangeEnd = 303725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_OnClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3D4 RID: 46036 RVA: 0x002ECA80 File Offset: 0x002EAC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303725, XrefRangeEnd = 303745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LaunderingInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3D5 RID: 46037 RVA: 0x002ECABC File Offset: 0x002EACBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303745, XrefRangeEnd = 303751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__37_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr__Initialize_b__37_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3D6 RID: 46038 RVA: 0x002ECAF0 File Offset: 0x002EACF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303751, XrefRangeEnd = 303756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _UpdateTimeline_b__40_0(KeyValuePair<LaunderingOperation, RectTransform> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr__UpdateTimeline_b__40_0_Private_Boolean_KeyValuePair_2_LaunderingOperation_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B3D7 RID: 46039 RVA: 0x00052F0C File Offset: 0x0005110C
		public LaunderingInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003619 RID: 13849
		// (get) Token: 0x0600B3D8 RID: 46040 RVA: 0x002ECB44 File Offset: 0x002EAD44
		// (set) Token: 0x0600B3D9 RID: 46041 RVA: 0x00052F15 File Offset: 0x00051115
		public unsafe static float FoV
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LaunderingInterface.NativeFieldInfoPtr_FoV, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunderingInterface.NativeFieldInfoPtr_FoV, (void*)(&value));
			}
		}

		// Token: 0x1700361A RID: 13850
		// (get) Token: 0x0600B3DA RID: 46042 RVA: 0x002ECB60 File Offset: 0x002EAD60
		// (set) Token: 0x0600B3DB RID: 46043 RVA: 0x00052F23 File Offset: 0x00051123
		public unsafe static float LerpTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LaunderingInterface.NativeFieldInfoPtr_LerpTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunderingInterface.NativeFieldInfoPtr_LerpTime, (void*)(&value));
			}
		}

		// Token: 0x1700361B RID: 13851
		// (get) Token: 0x0600B3DC RID: 46044 RVA: 0x002ECB7C File Offset: 0x002EAD7C
		// (set) Token: 0x0600B3DD RID: 46045 RVA: 0x00052F31 File Offset: 0x00051131
		public unsafe static int MinLaunderAmount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LaunderingInterface.NativeFieldInfoPtr_MinLaunderAmount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunderingInterface.NativeFieldInfoPtr_MinLaunderAmount, (void*)(&value));
			}
		}

		// Token: 0x1700361C RID: 13852
		// (get) Token: 0x0600B3DE RID: 46046 RVA: 0x002ECB98 File Offset: 0x002EAD98
		// (set) Token: 0x0600B3DF RID: 46047 RVA: 0x00052F3F File Offset: 0x0005113F
		public unsafe Business _Business_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr__Business_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Business>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr__Business_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700361D RID: 13853
		// (get) Token: 0x0600B3E0 RID: 46048 RVA: 0x002ECBC8 File Offset: 0x002EADC8
		// (set) Token: 0x0600B3E1 RID: 46049 RVA: 0x00052F5E File Offset: 0x0005115E
		public unsafe Transform cameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_cameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_cameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700361E RID: 13854
		// (get) Token: 0x0600B3E2 RID: 46050 RVA: 0x002ECBF8 File Offset: 0x002EADF8
		// (set) Token: 0x0600B3E3 RID: 46051 RVA: 0x00052F7D File Offset: 0x0005117D
		public unsafe InteractableObject intObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_intObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700361F RID: 13855
		// (get) Token: 0x0600B3E4 RID: 46052 RVA: 0x002ECC28 File Offset: 0x002EAE28
		// (set) Token: 0x0600B3E5 RID: 46053 RVA: 0x00052F9C File Offset: 0x0005119C
		public unsafe Button launderButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_launderButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_launderButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003620 RID: 13856
		// (get) Token: 0x0600B3E6 RID: 46054 RVA: 0x002ECC58 File Offset: 0x002EAE58
		// (set) Token: 0x0600B3E7 RID: 46055 RVA: 0x00052FBB File Offset: 0x000511BB
		public unsafe GameObject amountSelectorScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountSelectorScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountSelectorScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003621 RID: 13857
		// (get) Token: 0x0600B3E8 RID: 46056 RVA: 0x002ECC88 File Offset: 0x002EAE88
		// (set) Token: 0x0600B3E9 RID: 46057 RVA: 0x00052FDA File Offset: 0x000511DA
		public unsafe Slider amountSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003622 RID: 13858
		// (get) Token: 0x0600B3EA RID: 46058 RVA: 0x002ECCB8 File Offset: 0x002EAEB8
		// (set) Token: 0x0600B3EB RID: 46059 RVA: 0x00052FF9 File Offset: 0x000511F9
		public unsafe TMP_InputField amountInputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountInputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003623 RID: 13859
		// (get) Token: 0x0600B3EC RID: 46060 RVA: 0x002ECCE8 File Offset: 0x002EAEE8
		// (set) Token: 0x0600B3ED RID: 46061 RVA: 0x00053018 File Offset: 0x00051218
		public unsafe RectTransform notchContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_notchContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_notchContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003624 RID: 13860
		// (get) Token: 0x0600B3EE RID: 46062 RVA: 0x002ECD18 File Offset: 0x002EAF18
		// (set) Token: 0x0600B3EF RID: 46063 RVA: 0x00053037 File Offset: 0x00051237
		public unsafe TextMeshProUGUI currentTotalAmountLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_currentTotalAmountLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_currentTotalAmountLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003625 RID: 13861
		// (get) Token: 0x0600B3F0 RID: 46064 RVA: 0x002ECD48 File Offset: 0x002EAF48
		// (set) Token: 0x0600B3F1 RID: 46065 RVA: 0x00053056 File Offset: 0x00051256
		public unsafe TextMeshProUGUI launderCapacityLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_launderCapacityLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_launderCapacityLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003626 RID: 13862
		// (get) Token: 0x0600B3F2 RID: 46066 RVA: 0x002ECD78 File Offset: 0x002EAF78
		// (set) Token: 0x0600B3F3 RID: 46067 RVA: 0x00053075 File Offset: 0x00051275
		public unsafe TextMeshProUGUI insufficientCashLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_insufficientCashLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_insufficientCashLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003627 RID: 13863
		// (get) Token: 0x0600B3F4 RID: 46068 RVA: 0x002ECDA8 File Offset: 0x002EAFA8
		// (set) Token: 0x0600B3F5 RID: 46069 RVA: 0x00053094 File Offset: 0x00051294
		public unsafe RectTransform entryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_entryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_entryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003628 RID: 13864
		// (get) Token: 0x0600B3F6 RID: 46070 RVA: 0x002ECDD8 File Offset: 0x002EAFD8
		// (set) Token: 0x0600B3F7 RID: 46071 RVA: 0x000530B3 File Offset: 0x000512B3
		public unsafe RectTransform noEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_noEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_noEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003629 RID: 13865
		// (get) Token: 0x0600B3F8 RID: 46072 RVA: 0x002ECE08 File Offset: 0x002EB008
		// (set) Token: 0x0600B3F9 RID: 46073 RVA: 0x000530D2 File Offset: 0x000512D2
		public unsafe RectTransform container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700362A RID: 13866
		// (get) Token: 0x0600B3FA RID: 46074 RVA: 0x002ECE38 File Offset: 0x002EB038
		// (set) Token: 0x0600B3FB RID: 46075 RVA: 0x000530F1 File Offset: 0x000512F1
		public unsafe Il2CppReferenceArray<CashStackVisuals> cashStacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_cashStacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CashStackVisuals>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_cashStacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700362B RID: 13867
		// (get) Token: 0x0600B3FC RID: 46076 RVA: 0x002ECE68 File Offset: 0x002EB068
		// (set) Token: 0x0600B3FD RID: 46077 RVA: 0x00053110 File Offset: 0x00051310
		public unsafe MonoState mainState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_mainState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_mainState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700362C RID: 13868
		// (get) Token: 0x0600B3FE RID: 46078 RVA: 0x002ECE98 File Offset: 0x002EB098
		// (set) Token: 0x0600B3FF RID: 46079 RVA: 0x0005312F File Offset: 0x0005132F
		public unsafe MonoState amountSelectorState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountSelectorState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountSelectorState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700362D RID: 13869
		// (get) Token: 0x0600B400 RID: 46080 RVA: 0x002ECEC8 File Offset: 0x002EB0C8
		// (set) Token: 0x0600B401 RID: 46081 RVA: 0x0005314E File Offset: 0x0005134E
		public unsafe GameObject timelineNotchPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_timelineNotchPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_timelineNotchPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700362E RID: 13870
		// (get) Token: 0x0600B402 RID: 46082 RVA: 0x002ECEF8 File Offset: 0x002EB0F8
		// (set) Token: 0x0600B403 RID: 46083 RVA: 0x0005316D File Offset: 0x0005136D
		public unsafe GameObject entryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_entryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_entryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700362F RID: 13871
		// (get) Token: 0x0600B404 RID: 46084 RVA: 0x002ECF28 File Offset: 0x002EB128
		// (set) Token: 0x0600B405 RID: 46085 RVA: 0x0005318C File Offset: 0x0005138C
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003630 RID: 13872
		// (get) Token: 0x0600B406 RID: 46086 RVA: 0x002ECF58 File Offset: 0x002EB158
		// (set) Token: 0x0600B407 RID: 46087 RVA: 0x000531AB File Offset: 0x000513AB
		public unsafe ScrollRect scrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_scrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003631 RID: 13873
		// (get) Token: 0x0600B408 RID: 46088 RVA: 0x002ECF88 File Offset: 0x002EB188
		// (set) Token: 0x0600B409 RID: 46089 RVA: 0x000531CA File Offset: 0x000513CA
		public unsafe int selectedAmountToLaunder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_selectedAmountToLaunder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_selectedAmountToLaunder)) = value;
			}
		}

		// Token: 0x17003632 RID: 13874
		// (get) Token: 0x0600B40A RID: 46090 RVA: 0x002ECFB0 File Offset: 0x002EB1B0
		// (set) Token: 0x0600B40B RID: 46091 RVA: 0x000531E5 File Offset: 0x000513E5
		public unsafe Dictionary<LaunderingOperation, RectTransform> operationToNotch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_operationToNotch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<LaunderingOperation, RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_operationToNotch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003633 RID: 13875
		// (get) Token: 0x0600B40C RID: 46092 RVA: 0x002ECFE0 File Offset: 0x002EB1E0
		// (set) Token: 0x0600B40D RID: 46093 RVA: 0x00053204 File Offset: 0x00051404
		public unsafe List<RectTransform> notches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_notches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_notches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003634 RID: 13876
		// (get) Token: 0x0600B40E RID: 46094 RVA: 0x002ED010 File Offset: 0x002EB210
		// (set) Token: 0x0600B40F RID: 46095 RVA: 0x00053223 File Offset: 0x00051423
		public unsafe bool ignoreSliderChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_ignoreSliderChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_ignoreSliderChange)) = value;
			}
		}

		// Token: 0x17003635 RID: 13877
		// (get) Token: 0x0600B410 RID: 46096 RVA: 0x002ED038 File Offset: 0x002EB238
		// (set) Token: 0x0600B411 RID: 46097 RVA: 0x0005323E File Offset: 0x0005143E
		public unsafe Dictionary<LaunderingOperation, RectTransform> operationToEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_operationToEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<LaunderingOperation, RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_operationToEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007BB1 RID: 31665
		private static readonly IntPtr NativeFieldInfoPtr_FoV;

		// Token: 0x04007BB2 RID: 31666
		private static readonly IntPtr NativeFieldInfoPtr_LerpTime;

		// Token: 0x04007BB3 RID: 31667
		private static readonly IntPtr NativeFieldInfoPtr_MinLaunderAmount;

		// Token: 0x04007BB4 RID: 31668
		private static readonly IntPtr NativeFieldInfoPtr__Business_k__BackingField;

		// Token: 0x04007BB5 RID: 31669
		private static readonly IntPtr NativeFieldInfoPtr_cameraPosition;

		// Token: 0x04007BB6 RID: 31670
		private static readonly IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x04007BB7 RID: 31671
		private static readonly IntPtr NativeFieldInfoPtr_launderButton;

		// Token: 0x04007BB8 RID: 31672
		private static readonly IntPtr NativeFieldInfoPtr_amountSelectorScreen;

		// Token: 0x04007BB9 RID: 31673
		private static readonly IntPtr NativeFieldInfoPtr_amountSlider;

		// Token: 0x04007BBA RID: 31674
		private static readonly IntPtr NativeFieldInfoPtr_amountInputField;

		// Token: 0x04007BBB RID: 31675
		private static readonly IntPtr NativeFieldInfoPtr_notchContainer;

		// Token: 0x04007BBC RID: 31676
		private static readonly IntPtr NativeFieldInfoPtr_currentTotalAmountLabel;

		// Token: 0x04007BBD RID: 31677
		private static readonly IntPtr NativeFieldInfoPtr_launderCapacityLabel;

		// Token: 0x04007BBE RID: 31678
		private static readonly IntPtr NativeFieldInfoPtr_insufficientCashLabel;

		// Token: 0x04007BBF RID: 31679
		private static readonly IntPtr NativeFieldInfoPtr_entryContainer;

		// Token: 0x04007BC0 RID: 31680
		private static readonly IntPtr NativeFieldInfoPtr_noEntries;

		// Token: 0x04007BC1 RID: 31681
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04007BC2 RID: 31682
		private static readonly IntPtr NativeFieldInfoPtr_cashStacks;

		// Token: 0x04007BC3 RID: 31683
		private static readonly IntPtr NativeFieldInfoPtr_mainState;

		// Token: 0x04007BC4 RID: 31684
		private static readonly IntPtr NativeFieldInfoPtr_amountSelectorState;

		// Token: 0x04007BC5 RID: 31685
		private static readonly IntPtr NativeFieldInfoPtr_timelineNotchPrefab;

		// Token: 0x04007BC6 RID: 31686
		private static readonly IntPtr NativeFieldInfoPtr_entryPrefab;

		// Token: 0x04007BC7 RID: 31687
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04007BC8 RID: 31688
		private static readonly IntPtr NativeFieldInfoPtr_scrollRect;

		// Token: 0x04007BC9 RID: 31689
		private static readonly IntPtr NativeFieldInfoPtr_selectedAmountToLaunder;

		// Token: 0x04007BCA RID: 31690
		private static readonly IntPtr NativeFieldInfoPtr_operationToNotch;

		// Token: 0x04007BCB RID: 31691
		private static readonly IntPtr NativeFieldInfoPtr_notches;

		// Token: 0x04007BCC RID: 31692
		private static readonly IntPtr NativeFieldInfoPtr_ignoreSliderChange;

		// Token: 0x04007BCD RID: 31693
		private static readonly IntPtr NativeFieldInfoPtr_operationToEntry;

		// Token: 0x04007BCE RID: 31694
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04007BCF RID: 31695
		private static readonly IntPtr NativeMethodInfoPtr_get_Business_Public_get_Business_0;

		// Token: 0x04007BD0 RID: 31696
		private static readonly IntPtr NativeMethodInfoPtr_set_Business_Private_set_Void_Business_0;

		// Token: 0x04007BD1 RID: 31697
		private static readonly IntPtr NativeMethodInfoPtr_get_maxLaunderAmount_Private_get_Int32_0;

		// Token: 0x04007BD2 RID: 31698
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007BD3 RID: 31699
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Business_0;

		// Token: 0x04007BD4 RID: 31700
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04007BD5 RID: 31701
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04007BD6 RID: 31702
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTimeline_Protected_Void_0;

		// Token: 0x04007BD7 RID: 31703
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentTotal_Protected_Void_0;

		// Token: 0x04007BD8 RID: 31704
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntry_Private_Void_LaunderingOperation_0;

		// Token: 0x04007BD9 RID: 31705
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEntry_Private_Void_LaunderingOperation_0;

		// Token: 0x04007BDA RID: 31706
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEntryTimes_Private_Void_0;

		// Token: 0x04007BDB RID: 31707
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCashStacks_Private_Void_LaunderingOperation_0;

		// Token: 0x04007BDC RID: 31708
		private static readonly IntPtr NativeMethodInfoPtr_RefreshLaunderButton_Private_Void_0;

		// Token: 0x04007BDD RID: 31709
		private static readonly IntPtr NativeMethodInfoPtr_OpenAmountSelector_Public_Void_0;

		// Token: 0x04007BDE RID: 31710
		private static readonly IntPtr NativeMethodInfoPtr_CloseAmountSelector_Public_Void_0;

		// Token: 0x04007BDF RID: 31711
		private static readonly IntPtr NativeMethodInfoPtr_OnAmountSelectorClose_Private_Void_0;

		// Token: 0x04007BE0 RID: 31712
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmAmount_Public_Void_0;

		// Token: 0x04007BE1 RID: 31713
		private static readonly IntPtr NativeMethodInfoPtr_SliderValueChanged_Public_Void_0;

		// Token: 0x04007BE2 RID: 31714
		private static readonly IntPtr NativeMethodInfoPtr_InputValueChanged_Public_Void_0;

		// Token: 0x04007BE3 RID: 31715
		private static readonly IntPtr NativeMethodInfoPtr_ChangeSelectorValue_Public_Void_Int32_0;

		// Token: 0x04007BE4 RID: 31716
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04007BE5 RID: 31717
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04007BE6 RID: 31718
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04007BE7 RID: 31719
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Private_Void_0;

		// Token: 0x04007BE8 RID: 31720
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007BE9 RID: 31721
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__37_0_Private_Void_0;

		// Token: 0x04007BEA RID: 31722
		private static readonly IntPtr NativeMethodInfoPtr__UpdateTimeline_b__40_0_Private_Boolean_KeyValuePair_2_LaunderingOperation_RectTransform_0;

		// Token: 0x02000CD2 RID: 3282
		[ObfuscatedName("ScheduleOne.UI.LaunderingInterface+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F544 RID: 62788 RVA: 0x003AE984 File Offset: 0x003ACB84
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr);
				LaunderingInterface.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr, "<>9");
				LaunderingInterface.__c.NativeFieldInfoPtr___9__40_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr, "<>9__40_1");
				LaunderingInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr, 100686902);
				LaunderingInterface.__c.NativeMethodInfoPtr__UpdateTimeline_b__40_1_Internal_RectTransform_KeyValuePair_2_LaunderingOperation_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr, 100686903);
			}

			// Token: 0x0600F545 RID: 62789 RVA: 0x003AEA00 File Offset: 0x003ACC00
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F546 RID: 62790 RVA: 0x003AEA3C File Offset: 0x003ACC3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303085, XrefRangeEnd = 303086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RectTransform _UpdateTimeline_b__40_1(KeyValuePair<LaunderingOperation, RectTransform> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.__c.NativeMethodInfoPtr__UpdateTimeline_b__40_1_Internal_RectTransform_KeyValuePair_2_LaunderingOperation_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}

			// Token: 0x0600F547 RID: 62791 RVA: 0x00073EE6 File Offset: 0x000720E6
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A83 RID: 19075
			// (get) Token: 0x0600F548 RID: 62792 RVA: 0x003AEA94 File Offset: 0x003ACC94
			// (set) Token: 0x0600F549 RID: 62793 RVA: 0x00073EEF File Offset: 0x000720EF
			public unsafe static LaunderingInterface.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LaunderingInterface.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LaunderingInterface.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LaunderingInterface.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A84 RID: 19076
			// (get) Token: 0x0600F54A RID: 62794 RVA: 0x003AEABC File Offset: 0x003ACCBC
			// (set) Token: 0x0600F54B RID: 62795 RVA: 0x00073F01 File Offset: 0x00072101
			public unsafe static Func<KeyValuePair<LaunderingOperation, RectTransform>, RectTransform> __9__40_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LaunderingInterface.__c.NativeFieldInfoPtr___9__40_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<LaunderingOperation, RectTransform>, RectTransform>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LaunderingInterface.__c.NativeFieldInfoPtr___9__40_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A5F3 RID: 42483
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A5F4 RID: 42484
			private static readonly IntPtr NativeFieldInfoPtr___9__40_1;

			// Token: 0x0400A5F5 RID: 42485
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A5F6 RID: 42486
			private static readonly IntPtr NativeMethodInfoPtr__UpdateTimeline_b__40_1_Internal_RectTransform_KeyValuePair_2_LaunderingOperation_RectTransform_0;
		}
	}
}
