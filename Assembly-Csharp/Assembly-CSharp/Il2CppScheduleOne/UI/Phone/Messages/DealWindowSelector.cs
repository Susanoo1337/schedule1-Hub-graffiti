using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Messaging;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020007B8 RID: 1976
	public class DealWindowSelector : MonoBehaviour
	{
		// Token: 0x0600C11D RID: 49437 RVA: 0x0031465C File Offset: 0x0031285C
		// Note: this type is marked as 'beforefieldinit'.
		static DealWindowSelector()
		{
			Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "DealWindowSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr);
			DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_0000 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "TIME_ARM_ROTATION_0000");
			DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_2400 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "TIME_ARM_ROTATION_2400");
			DealWindowSelector.NativeFieldInfoPtr_WINDOW_CUTOFF_MINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "WINDOW_CUTOFF_MINS");
			DealWindowSelector.NativeFieldInfoPtr_OnSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "OnSelected");
			DealWindowSelector.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "<IsOpen>k__BackingField");
			DealWindowSelector.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "Container");
			DealWindowSelector.NativeFieldInfoPtr_MorningButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "MorningButton");
			DealWindowSelector.NativeFieldInfoPtr_AfternoonButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "AfternoonButton");
			DealWindowSelector.NativeFieldInfoPtr_NightButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "NightButton");
			DealWindowSelector.NativeFieldInfoPtr_LateNightButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "LateNightButton");
			DealWindowSelector.NativeFieldInfoPtr_CurrentTimeArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "CurrentTimeArm");
			DealWindowSelector.NativeFieldInfoPtr_CurrentTimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "CurrentTimeLabel");
			DealWindowSelector.NativeFieldInfoPtr_uiScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "uiScreen");
			DealWindowSelector.NativeFieldInfoPtr_uiPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "uiPanel");
			DealWindowSelector.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "callback");
			DealWindowSelector.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "buttons");
			DealWindowSelector.NativeFieldInfoPtr_hintShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "hintShown");
			DealWindowSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100688440);
			DealWindowSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100688441);
			DealWindowSelector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100688442);
			DealWindowSelector.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100688443);
			DealWindowSelector.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100688444);
			DealWindowSelector.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_MSGConversation_Action_1_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100688445);
			DealWindowSelector.NativeMethodInfoPtr_DelaySelectPanel_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100688446);
			DealWindowSelector.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100688447);
			DealWindowSelector.NativeMethodInfoPtr_UpdateTime_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100688448);
			DealWindowSelector.NativeMethodInfoPtr_UpdateWindowValidity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100688449);
			DealWindowSelector.NativeMethodInfoPtr_IsWindowValid_Private_Boolean_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100688450);
			DealWindowSelector.NativeMethodInfoPtr_Close_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100688451);
			DealWindowSelector.NativeMethodInfoPtr_ButtonClicked_Private_Void_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100688452);
			DealWindowSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100688453);
		}

		// Token: 0x17003A89 RID: 14985
		// (get) Token: 0x0600C11E RID: 49438 RVA: 0x003148F8 File Offset: 0x00312AF8
		// (set) Token: 0x0600C11F RID: 49439 RVA: 0x00314934 File Offset: 0x00312B34
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C120 RID: 49440 RVA: 0x00314974 File Offset: 0x00312B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320764, XrefRangeEnd = 320801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C121 RID: 49441 RVA: 0x003149A8 File Offset: 0x00312BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320801, XrefRangeEnd = 320806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C122 RID: 49442 RVA: 0x003149EC File Offset: 0x00312BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320806, XrefRangeEnd = 320807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C123 RID: 49443 RVA: 0x00314A2C File Offset: 0x00312C2C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 320898, RefRangeEnd = 320905, XrefRangeStart = 320807, XrefRangeEnd = 320898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool open, MSGConversation conversation, Action<EDealWindow> callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conversation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_MSGConversation_Action_1_EDealWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C124 RID: 49444 RVA: 0x00314A90 File Offset: 0x00312C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320905, XrefRangeEnd = 320910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelaySelectPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_DelaySelectPanel_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600C125 RID: 49445 RVA: 0x00314AD0 File Offset: 0x00312CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320910, XrefRangeEnd = 320912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C126 RID: 49446 RVA: 0x00314B04 File Offset: 0x00312D04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320927, RefRangeEnd = 320929, XrefRangeStart = 320912, XrefRangeEnd = 320927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_UpdateTime_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C127 RID: 49447 RVA: 0x00314B38 File Offset: 0x00312D38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320954, RefRangeEnd = 320956, XrefRangeStart = 320929, XrefRangeEnd = 320954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWindowValidity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_UpdateWindowValidity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C128 RID: 49448 RVA: 0x00314B6C File Offset: 0x00312D6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320968, RefRangeEnd = 320970, XrefRangeStart = 320956, XrefRangeEnd = 320968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsWindowValid(EDealWindow window)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_IsWindowValid_Private_Boolean_EDealWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C129 RID: 49449 RVA: 0x00314BB8 File Offset: 0x00312DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320970, XrefRangeEnd = 320971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_Close_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C12A RID: 49450 RVA: 0x00314BEC File Offset: 0x00312DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320971, XrefRangeEnd = 320975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ButtonClicked(EDealWindow window)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_ButtonClicked_Private_Void_EDealWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C12B RID: 49451 RVA: 0x00314C2C File Offset: 0x00312E2C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealWindowSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C12C RID: 49452 RVA: 0x0005A909 File Offset: 0x00058B09
		public DealWindowSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003A78 RID: 14968
		// (get) Token: 0x0600C12D RID: 49453 RVA: 0x00314C68 File Offset: 0x00312E68
		// (set) Token: 0x0600C12E RID: 49454 RVA: 0x0005A912 File Offset: 0x00058B12
		public unsafe static float TIME_ARM_ROTATION_0000
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_0000, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_0000, (void*)(&value));
			}
		}

		// Token: 0x17003A79 RID: 14969
		// (get) Token: 0x0600C12F RID: 49455 RVA: 0x00314C84 File Offset: 0x00312E84
		// (set) Token: 0x0600C130 RID: 49456 RVA: 0x0005A920 File Offset: 0x00058B20
		public unsafe static float TIME_ARM_ROTATION_2400
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_2400, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_2400, (void*)(&value));
			}
		}

		// Token: 0x17003A7A RID: 14970
		// (get) Token: 0x0600C131 RID: 49457 RVA: 0x00314CA0 File Offset: 0x00312EA0
		// (set) Token: 0x0600C132 RID: 49458 RVA: 0x0005A92E File Offset: 0x00058B2E
		public unsafe static int WINDOW_CUTOFF_MINS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowSelector.NativeFieldInfoPtr_WINDOW_CUTOFF_MINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowSelector.NativeFieldInfoPtr_WINDOW_CUTOFF_MINS, (void*)(&value));
			}
		}

		// Token: 0x17003A7B RID: 14971
		// (get) Token: 0x0600C133 RID: 49459 RVA: 0x00314CBC File Offset: 0x00312EBC
		// (set) Token: 0x0600C134 RID: 49460 RVA: 0x0005A93C File Offset: 0x00058B3C
		public unsafe UnityEvent<EDealWindow> OnSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_OnSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EDealWindow>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_OnSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A7C RID: 14972
		// (get) Token: 0x0600C135 RID: 49461 RVA: 0x00314CEC File Offset: 0x00312EEC
		// (set) Token: 0x0600C136 RID: 49462 RVA: 0x0005A95B File Offset: 0x00058B5B
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003A7D RID: 14973
		// (get) Token: 0x0600C137 RID: 49463 RVA: 0x00314D14 File Offset: 0x00312F14
		// (set) Token: 0x0600C138 RID: 49464 RVA: 0x0005A976 File Offset: 0x00058B76
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A7E RID: 14974
		// (get) Token: 0x0600C139 RID: 49465 RVA: 0x00314D44 File Offset: 0x00312F44
		// (set) Token: 0x0600C13A RID: 49466 RVA: 0x0005A995 File Offset: 0x00058B95
		public unsafe WindowSelectorButton MorningButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_MorningButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_MorningButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A7F RID: 14975
		// (get) Token: 0x0600C13B RID: 49467 RVA: 0x00314D74 File Offset: 0x00312F74
		// (set) Token: 0x0600C13C RID: 49468 RVA: 0x0005A9B4 File Offset: 0x00058BB4
		public unsafe WindowSelectorButton AfternoonButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_AfternoonButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_AfternoonButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A80 RID: 14976
		// (get) Token: 0x0600C13D RID: 49469 RVA: 0x00314DA4 File Offset: 0x00312FA4
		// (set) Token: 0x0600C13E RID: 49470 RVA: 0x0005A9D3 File Offset: 0x00058BD3
		public unsafe WindowSelectorButton NightButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_NightButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_NightButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A81 RID: 14977
		// (get) Token: 0x0600C13F RID: 49471 RVA: 0x00314DD4 File Offset: 0x00312FD4
		// (set) Token: 0x0600C140 RID: 49472 RVA: 0x0005A9F2 File Offset: 0x00058BF2
		public unsafe WindowSelectorButton LateNightButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_LateNightButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_LateNightButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A82 RID: 14978
		// (get) Token: 0x0600C141 RID: 49473 RVA: 0x00314E04 File Offset: 0x00313004
		// (set) Token: 0x0600C142 RID: 49474 RVA: 0x0005AA11 File Offset: 0x00058C11
		public unsafe RectTransform CurrentTimeArm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_CurrentTimeArm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_CurrentTimeArm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A83 RID: 14979
		// (get) Token: 0x0600C143 RID: 49475 RVA: 0x00314E34 File Offset: 0x00313034
		// (set) Token: 0x0600C144 RID: 49476 RVA: 0x0005AA30 File Offset: 0x00058C30
		public unsafe Text CurrentTimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_CurrentTimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_CurrentTimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A84 RID: 14980
		// (get) Token: 0x0600C145 RID: 49477 RVA: 0x00314E64 File Offset: 0x00313064
		// (set) Token: 0x0600C146 RID: 49478 RVA: 0x0005AA4F File Offset: 0x00058C4F
		public unsafe UIScreen uiScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_uiScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_uiScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A85 RID: 14981
		// (get) Token: 0x0600C147 RID: 49479 RVA: 0x00314E94 File Offset: 0x00313094
		// (set) Token: 0x0600C148 RID: 49480 RVA: 0x0005AA6E File Offset: 0x00058C6E
		public unsafe UIPanel uiPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_uiPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_uiPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A86 RID: 14982
		// (get) Token: 0x0600C149 RID: 49481 RVA: 0x00314EC4 File Offset: 0x003130C4
		// (set) Token: 0x0600C14A RID: 49482 RVA: 0x0005AA8D File Offset: 0x00058C8D
		public unsafe Action<EDealWindow> callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<EDealWindow>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A87 RID: 14983
		// (get) Token: 0x0600C14B RID: 49483 RVA: 0x00314EF4 File Offset: 0x003130F4
		// (set) Token: 0x0600C14C RID: 49484 RVA: 0x0005AAAC File Offset: 0x00058CAC
		public unsafe Il2CppReferenceArray<WindowSelectorButton> buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WindowSelectorButton>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A88 RID: 14984
		// (get) Token: 0x0600C14D RID: 49485 RVA: 0x00314F24 File Offset: 0x00313124
		// (set) Token: 0x0600C14E RID: 49486 RVA: 0x0005AACB File Offset: 0x00058CCB
		public unsafe bool hintShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_hintShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_hintShown)) = value;
			}
		}

		// Token: 0x0400841D RID: 33821
		private static readonly IntPtr NativeFieldInfoPtr_TIME_ARM_ROTATION_0000;

		// Token: 0x0400841E RID: 33822
		private static readonly IntPtr NativeFieldInfoPtr_TIME_ARM_ROTATION_2400;

		// Token: 0x0400841F RID: 33823
		private static readonly IntPtr NativeFieldInfoPtr_WINDOW_CUTOFF_MINS;

		// Token: 0x04008420 RID: 33824
		private static readonly IntPtr NativeFieldInfoPtr_OnSelected;

		// Token: 0x04008421 RID: 33825
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04008422 RID: 33826
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04008423 RID: 33827
		private static readonly IntPtr NativeFieldInfoPtr_MorningButton;

		// Token: 0x04008424 RID: 33828
		private static readonly IntPtr NativeFieldInfoPtr_AfternoonButton;

		// Token: 0x04008425 RID: 33829
		private static readonly IntPtr NativeFieldInfoPtr_NightButton;

		// Token: 0x04008426 RID: 33830
		private static readonly IntPtr NativeFieldInfoPtr_LateNightButton;

		// Token: 0x04008427 RID: 33831
		private static readonly IntPtr NativeFieldInfoPtr_CurrentTimeArm;

		// Token: 0x04008428 RID: 33832
		private static readonly IntPtr NativeFieldInfoPtr_CurrentTimeLabel;

		// Token: 0x04008429 RID: 33833
		private static readonly IntPtr NativeFieldInfoPtr_uiScreen;

		// Token: 0x0400842A RID: 33834
		private static readonly IntPtr NativeFieldInfoPtr_uiPanel;

		// Token: 0x0400842B RID: 33835
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x0400842C RID: 33836
		private static readonly IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x0400842D RID: 33837
		private static readonly IntPtr NativeFieldInfoPtr_hintShown;

		// Token: 0x0400842E RID: 33838
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400842F RID: 33839
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04008430 RID: 33840
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04008431 RID: 33841
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x04008432 RID: 33842
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x04008433 RID: 33843
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_MSGConversation_Action_1_EDealWindow_0;

		// Token: 0x04008434 RID: 33844
		private static readonly IntPtr NativeMethodInfoPtr_DelaySelectPanel_Private_IEnumerator_0;

		// Token: 0x04008435 RID: 33845
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04008436 RID: 33846
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTime_Private_Void_0;

		// Token: 0x04008437 RID: 33847
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWindowValidity_Private_Void_0;

		// Token: 0x04008438 RID: 33848
		private static readonly IntPtr NativeMethodInfoPtr_IsWindowValid_Private_Boolean_EDealWindow_0;

		// Token: 0x04008439 RID: 33849
		private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_0;

		// Token: 0x0400843A RID: 33850
		private static readonly IntPtr NativeMethodInfoPtr_ButtonClicked_Private_Void_EDealWindow_0;

		// Token: 0x0400843B RID: 33851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D40 RID: 3392
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.DealWindowSelector+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F9AB RID: 63915 RVA: 0x003BB5B8 File Offset: 0x003B97B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass20_0>.NativeClassPtr);
				DealWindowSelector.__c__DisplayClass20_0.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass20_0>.NativeClassPtr, "button");
				DealWindowSelector.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
				DealWindowSelector.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass20_0>.NativeClassPtr, 100688454);
				DealWindowSelector.__c__DisplayClass20_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass20_0>.NativeClassPtr, 100688455);
			}

			// Token: 0x0600F9AC RID: 63916 RVA: 0x003BB634 File Offset: 0x003B9834
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F9AD RID: 63917 RVA: 0x003BB670 File Offset: 0x003B9870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320754, XrefRangeEnd = 320758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.__c__DisplayClass20_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F9AE RID: 63918 RVA: 0x0007618D File Offset: 0x0007438D
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BE6 RID: 19430
			// (get) Token: 0x0600F9AF RID: 63919 RVA: 0x003BB6A4 File Offset: 0x003B98A4
			// (set) Token: 0x0600F9B0 RID: 63920 RVA: 0x00076196 File Offset: 0x00074396
			public unsafe WindowSelectorButton button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.__c__DisplayClass20_0.NativeFieldInfoPtr_button);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.__c__DisplayClass20_0.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BE7 RID: 19431
			// (get) Token: 0x0600F9B1 RID: 63921 RVA: 0x003BB6D4 File Offset: 0x003B98D4
			// (set) Token: 0x0600F9B2 RID: 63922 RVA: 0x000761B5 File Offset: 0x000743B5
			public unsafe DealWindowSelector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealWindowSelector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A89A RID: 43162
			private static readonly IntPtr NativeFieldInfoPtr_button;

			// Token: 0x0400A89B RID: 43163
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A89C RID: 43164
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A89D RID: 43165
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}

		// Token: 0x02000D41 RID: 3393
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.DealWindowSelector+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F9B3 RID: 63923 RVA: 0x003BB704 File Offset: 0x003B9904
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass23_0>.NativeClassPtr);
				DealWindowSelector.__c__DisplayClass23_0.NativeFieldInfoPtr_windowToSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass23_0>.NativeClassPtr, "windowToSelect");
				DealWindowSelector.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass23_0>.NativeClassPtr, 100688456);
				DealWindowSelector.__c__DisplayClass23_0.NativeMethodInfoPtr__SetIsOpen_b__0_Internal_Boolean_WindowSelectorButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass23_0>.NativeClassPtr, 100688457);
			}

			// Token: 0x0600F9B4 RID: 63924 RVA: 0x003BB76C File Offset: 0x003B996C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F9B5 RID: 63925 RVA: 0x003BB7A8 File Offset: 0x003B99A8
			[CallerCount(0)]
			public unsafe bool _SetIsOpen_b__0(WindowSelectorButton x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.__c__DisplayClass23_0.NativeMethodInfoPtr__SetIsOpen_b__0_Internal_Boolean_WindowSelectorButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F9B6 RID: 63926 RVA: 0x000761D4 File Offset: 0x000743D4
			public __c__DisplayClass23_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BE8 RID: 19432
			// (get) Token: 0x0600F9B7 RID: 63927 RVA: 0x003BB7F8 File Offset: 0x003B99F8
			// (set) Token: 0x0600F9B8 RID: 63928 RVA: 0x000761DD File Offset: 0x000743DD
			public unsafe EDealWindow windowToSelect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.__c__DisplayClass23_0.NativeFieldInfoPtr_windowToSelect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.__c__DisplayClass23_0.NativeFieldInfoPtr_windowToSelect)) = value;
				}
			}

			// Token: 0x0400A89E RID: 43166
			private static readonly IntPtr NativeFieldInfoPtr_windowToSelect;

			// Token: 0x0400A89F RID: 43167
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A8A0 RID: 43168
			private static readonly IntPtr NativeMethodInfoPtr__SetIsOpen_b__0_Internal_Boolean_WindowSelectorButton_0;
		}

		// Token: 0x02000D42 RID: 3394
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.DealWindowSelector+<DelaySelectPanel>d__24")]
		public sealed class _DelaySelectPanel_d__24 : Il2CppSystem.Object
		{
			// Token: 0x0600F9B9 RID: 63929 RVA: 0x003BB820 File Offset: 0x003B9A20
			// Note: this type is marked as 'beforefieldinit'.
			static _DelaySelectPanel_d__24()
			{
				Il2CppClassPointerStore<DealWindowSelector._DelaySelectPanel_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "<DelaySelectPanel>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealWindowSelector._DelaySelectPanel_d__24>.NativeClassPtr);
				DealWindowSelector._DelaySelectPanel_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector._DelaySelectPanel_d__24>.NativeClassPtr, "<>1__state");
				DealWindowSelector._DelaySelectPanel_d__24.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector._DelaySelectPanel_d__24>.NativeClassPtr, "<>2__current");
				DealWindowSelector._DelaySelectPanel_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector._DelaySelectPanel_d__24>.NativeClassPtr, "<>4__this");
				DealWindowSelector._DelaySelectPanel_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector._DelaySelectPanel_d__24>.NativeClassPtr, 100688458);
				DealWindowSelector._DelaySelectPanel_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector._DelaySelectPanel_d__24>.NativeClassPtr, 100688459);
				DealWindowSelector._DelaySelectPanel_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector._DelaySelectPanel_d__24>.NativeClassPtr, 100688460);
				DealWindowSelector._DelaySelectPanel_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector._DelaySelectPanel_d__24>.NativeClassPtr, 100688461);
				DealWindowSelector._DelaySelectPanel_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector._DelaySelectPanel_d__24>.NativeClassPtr, 100688462);
				DealWindowSelector._DelaySelectPanel_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector._DelaySelectPanel_d__24>.NativeClassPtr, 100688463);
			}

			// Token: 0x0600F9BA RID: 63930 RVA: 0x003BB900 File Offset: 0x003B9B00
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelaySelectPanel_d__24(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealWindowSelector._DelaySelectPanel_d__24>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector._DelaySelectPanel_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F9BB RID: 63931 RVA: 0x003BB948 File Offset: 0x003B9B48
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector._DelaySelectPanel_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F9BC RID: 63932 RVA: 0x003BB97C File Offset: 0x003B9B7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320758, XrefRangeEnd = 320759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector._DelaySelectPanel_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004BEC RID: 19436
			// (get) Token: 0x0600F9BD RID: 63933 RVA: 0x003BB9B8 File Offset: 0x003B9BB8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector._DelaySelectPanel_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F9BE RID: 63934 RVA: 0x003BB9F8 File Offset: 0x003B9BF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320759, XrefRangeEnd = 320764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector._DelaySelectPanel_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004BED RID: 19437
			// (get) Token: 0x0600F9BF RID: 63935 RVA: 0x003BBA2C File Offset: 0x003B9C2C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector._DelaySelectPanel_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F9C0 RID: 63936 RVA: 0x000761F8 File Offset: 0x000743F8
			public _DelaySelectPanel_d__24(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BE9 RID: 19433
			// (get) Token: 0x0600F9C1 RID: 63937 RVA: 0x003BBA6C File Offset: 0x003B9C6C
			// (set) Token: 0x0600F9C2 RID: 63938 RVA: 0x00076201 File Offset: 0x00074401
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector._DelaySelectPanel_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector._DelaySelectPanel_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004BEA RID: 19434
			// (get) Token: 0x0600F9C3 RID: 63939 RVA: 0x003BBA94 File Offset: 0x003B9C94
			// (set) Token: 0x0600F9C4 RID: 63940 RVA: 0x0007621C File Offset: 0x0007441C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector._DelaySelectPanel_d__24.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector._DelaySelectPanel_d__24.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BEB RID: 19435
			// (get) Token: 0x0600F9C5 RID: 63941 RVA: 0x003BBAC4 File Offset: 0x003B9CC4
			// (set) Token: 0x0600F9C6 RID: 63942 RVA: 0x0007623B File Offset: 0x0007443B
			public unsafe DealWindowSelector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector._DelaySelectPanel_d__24.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealWindowSelector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector._DelaySelectPanel_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A8A1 RID: 43169
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A8A2 RID: 43170
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A8A3 RID: 43171
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A8A4 RID: 43172
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A8A5 RID: 43173
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A8A6 RID: 43174
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A8A7 RID: 43175
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A8A8 RID: 43176
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A8A9 RID: 43177
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
