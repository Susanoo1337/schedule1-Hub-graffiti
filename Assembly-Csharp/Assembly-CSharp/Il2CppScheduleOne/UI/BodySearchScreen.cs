using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.State;
using Il2CppScheduleOne.UI.Input;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200071A RID: 1818
	public class BodySearchScreen : Singleton<BodySearchScreen>
	{
		// Token: 0x0600AF47 RID: 44871 RVA: 0x002DE940 File Offset: 0x002DCB40
		// Note: this type is marked as 'beforefieldinit'.
		static BodySearchScreen()
		{
			Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "BodySearchScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr);
			BodySearchScreen.NativeFieldInfoPtr_MAX_SPEED_BOOST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "MAX_SPEED_BOOST");
			BodySearchScreen.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "<IsOpen>k__BackingField");
			BodySearchScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "<TutorialOpen>k__BackingField");
			BodySearchScreen.NativeFieldInfoPtr_SlotRedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SlotRedColor");
			BodySearchScreen.NativeFieldInfoPtr_SlotHighlightRedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SlotHighlightRedColor");
			BodySearchScreen.NativeFieldInfoPtr_GapTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "GapTime");
			BodySearchScreen.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "Canvas");
			BodySearchScreen.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "Container");
			BodySearchScreen.NativeFieldInfoPtr_MinigameController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "MinigameController");
			BodySearchScreen.NativeFieldInfoPtr_SlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SlotContainer");
			BodySearchScreen.NativeFieldInfoPtr_ItemSlotPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "ItemSlotPrefab");
			BodySearchScreen.NativeFieldInfoPtr_SearchIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SearchIndicator");
			BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SearchIndicatorStart");
			BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SearchIndicatorEnd");
			BodySearchScreen.NativeFieldInfoPtr_IndicatorAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "IndicatorAnimation");
			BodySearchScreen.NativeFieldInfoPtr_TutorialAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "TutorialAnimation");
			BodySearchScreen.NativeFieldInfoPtr_TutorialContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "TutorialContainer");
			BodySearchScreen.NativeFieldInfoPtr_ResetAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "ResetAnimation");
			BodySearchScreen.NativeFieldInfoPtr_FailSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "FailSound");
			BodySearchScreen.NativeFieldInfoPtr_SpeedUpInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "SpeedUpInput");
			BodySearchScreen.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "State");
			BodySearchScreen.NativeFieldInfoPtr_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "Panel");
			BodySearchScreen.NativeFieldInfoPtr__inputPromptObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "_inputPromptObj");
			BodySearchScreen.NativeFieldInfoPtr_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "slots");
			BodySearchScreen.NativeFieldInfoPtr_onSearchClear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "onSearchClear");
			BodySearchScreen.NativeFieldInfoPtr_onSearchFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "onSearchFail");
			BodySearchScreen.NativeFieldInfoPtr_defaultSlotColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "defaultSlotColor");
			BodySearchScreen.NativeFieldInfoPtr_defaultSlotHighlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "defaultSlotHighlightColor");
			BodySearchScreen.NativeFieldInfoPtr_concealedSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "concealedSlot");
			BodySearchScreen.NativeFieldInfoPtr_hoveredSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "hoveredSlot");
			BodySearchScreen.NativeFieldInfoPtr_defaultItemIconColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "defaultItemIconColors");
			BodySearchScreen.NativeFieldInfoPtr_speedBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "speedBoost");
			BodySearchScreen.NativeFieldInfoPtr__caught = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "_caught");
			BodySearchScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100686351);
			BodySearchScreen.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100686352);
			BodySearchScreen.NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100686353);
			BodySearchScreen.NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100686354);
			BodySearchScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100686355);
			BodySearchScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100686356);
			BodySearchScreen.NativeMethodInfoPtr_SetupSlots_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100686357);
			BodySearchScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100686358);
			BodySearchScreen.NativeMethodInfoPtr_Open_Public_Void_NPC_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100686359);
			BodySearchScreen.NativeMethodInfoPtr_IsSlotConcealed_Private_Boolean_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100686360);
			BodySearchScreen.NativeMethodInfoPtr_ItemDetected_Private_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100686361);
			BodySearchScreen.NativeMethodInfoPtr_SlotHeld_Public_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100686362);
			BodySearchScreen.NativeMethodInfoPtr_SlotReleased_Public_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100686363);
			BodySearchScreen.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100686364);
			BodySearchScreen.NativeMethodInfoPtr_OpenTutorial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100686365);
			BodySearchScreen.NativeMethodInfoPtr_CloseTutorial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100686366);
			BodySearchScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100686367);
			BodySearchScreen.NativeMethodInfoPtr_Method_Private_Void_ItemSlotUI_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100686368);
			BodySearchScreen.NativeMethodInfoPtr_Method_Private_Void_ItemSlotUI_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, 100686369);
		}

		// Token: 0x170034BD RID: 13501
		// (get) Token: 0x0600AF48 RID: 44872 RVA: 0x002DED80 File Offset: 0x002DCF80
		// (set) Token: 0x0600AF49 RID: 44873 RVA: 0x002DEDBC File Offset: 0x002DCFBC
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170034BE RID: 13502
		// (get) Token: 0x0600AF4A RID: 44874 RVA: 0x002DEDFC File Offset: 0x002DCFFC
		// (set) Token: 0x0600AF4B RID: 44875 RVA: 0x002DEE38 File Offset: 0x002DD038
		public unsafe bool TutorialOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600AF4C RID: 44876 RVA: 0x002DEE78 File Offset: 0x002DD078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298863, XrefRangeEnd = 298870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF4D RID: 44877 RVA: 0x002DEEB4 File Offset: 0x002DD0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298870, XrefRangeEnd = 298906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF4E RID: 44878 RVA: 0x002DEEF0 File Offset: 0x002DD0F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299016, RefRangeEnd = 299017, XrefRangeStart = 298906, XrefRangeEnd = 299016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupSlots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_SetupSlots_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF4F RID: 44879 RVA: 0x002DEF24 File Offset: 0x002DD124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299017, XrefRangeEnd = 299046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF50 RID: 44880 RVA: 0x002DEF58 File Offset: 0x002DD158
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299094, RefRangeEnd = 299095, XrefRangeStart = 299046, XrefRangeEnd = 299094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(NPC _searcher, float searchTime = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_searcher);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_Open_Public_Void_NPC_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF51 RID: 44881 RVA: 0x002DEFA8 File Offset: 0x002DD1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299095, XrefRangeEnd = 299099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSlotConcealed(ItemSlotUI slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_IsSlotConcealed_Private_Boolean_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AF52 RID: 44882 RVA: 0x002DEFF8 File Offset: 0x002DD1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299099, XrefRangeEnd = 299100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ItemDetected(ItemSlotUI slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_ItemDetected_Private_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF53 RID: 44883 RVA: 0x002DF03C File Offset: 0x002DD23C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 299118, RefRangeEnd = 299121, XrefRangeStart = 299100, XrefRangeEnd = 299118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SlotHeld(ItemSlotUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_SlotHeld_Public_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF54 RID: 44884 RVA: 0x002DF080 File Offset: 0x002DD280
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 299135, RefRangeEnd = 299138, XrefRangeStart = 299121, XrefRangeEnd = 299135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SlotReleased(ItemSlotUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_SlotReleased_Public_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF55 RID: 44885 RVA: 0x002DF0C4 File Offset: 0x002DD2C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 299150, RefRangeEnd = 299152, XrefRangeStart = 299138, XrefRangeEnd = 299150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool clear)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref clear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF56 RID: 44886 RVA: 0x002DF104 File Offset: 0x002DD304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299152, XrefRangeEnd = 299156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_OpenTutorial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF57 RID: 44887 RVA: 0x002DF138 File Offset: 0x002DD338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299156, XrefRangeEnd = 299159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_CloseTutorial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF58 RID: 44888 RVA: 0x002DF16C File Offset: 0x002DD36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299159, XrefRangeEnd = 299169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BodySearchScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF59 RID: 44889 RVA: 0x002DF1A8 File Offset: 0x002DD3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299169, XrefRangeEnd = 299177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_ItemSlotUI_PDM_0(ItemSlotUI slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_Method_Private_Void_ItemSlotUI_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF5A RID: 44890 RVA: 0x002DF1EC File Offset: 0x002DD3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299177, XrefRangeEnd = 299185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_ItemSlotUI_PDM_1(ItemSlotUI slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.NativeMethodInfoPtr_Method_Private_Void_ItemSlotUI_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF5B RID: 44891 RVA: 0x000505BE File Offset: 0x0004E7BE
		public BodySearchScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700349C RID: 13468
		// (get) Token: 0x0600AF5C RID: 44892 RVA: 0x002DF230 File Offset: 0x002DD430
		// (set) Token: 0x0600AF5D RID: 44893 RVA: 0x000505C7 File Offset: 0x0004E7C7
		public unsafe static float MAX_SPEED_BOOST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchScreen.NativeFieldInfoPtr_MAX_SPEED_BOOST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchScreen.NativeFieldInfoPtr_MAX_SPEED_BOOST, (void*)(&value));
			}
		}

		// Token: 0x1700349D RID: 13469
		// (get) Token: 0x0600AF5E RID: 44894 RVA: 0x002DF24C File Offset: 0x002DD44C
		// (set) Token: 0x0600AF5F RID: 44895 RVA: 0x000505D5 File Offset: 0x0004E7D5
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700349E RID: 13470
		// (get) Token: 0x0600AF60 RID: 44896 RVA: 0x002DF274 File Offset: 0x002DD474
		// (set) Token: 0x0600AF61 RID: 44897 RVA: 0x000505F0 File Offset: 0x0004E7F0
		public unsafe bool _TutorialOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700349F RID: 13471
		// (get) Token: 0x0600AF62 RID: 44898 RVA: 0x002DF29C File Offset: 0x002DD49C
		// (set) Token: 0x0600AF63 RID: 44899 RVA: 0x0005060B File Offset: 0x0004E80B
		public unsafe Color SlotRedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotRedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotRedColor)) = value;
			}
		}

		// Token: 0x170034A0 RID: 13472
		// (get) Token: 0x0600AF64 RID: 44900 RVA: 0x002DF2C4 File Offset: 0x002DD4C4
		// (set) Token: 0x0600AF65 RID: 44901 RVA: 0x00050626 File Offset: 0x0004E826
		public unsafe Color SlotHighlightRedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotHighlightRedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotHighlightRedColor)) = value;
			}
		}

		// Token: 0x170034A1 RID: 13473
		// (get) Token: 0x0600AF66 RID: 44902 RVA: 0x002DF2EC File Offset: 0x002DD4EC
		// (set) Token: 0x0600AF67 RID: 44903 RVA: 0x00050641 File Offset: 0x0004E841
		public unsafe float GapTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_GapTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_GapTime)) = value;
			}
		}

		// Token: 0x170034A2 RID: 13474
		// (get) Token: 0x0600AF68 RID: 44904 RVA: 0x002DF314 File Offset: 0x002DD514
		// (set) Token: 0x0600AF69 RID: 44905 RVA: 0x0005065C File Offset: 0x0004E85C
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034A3 RID: 13475
		// (get) Token: 0x0600AF6A RID: 44906 RVA: 0x002DF344 File Offset: 0x002DD544
		// (set) Token: 0x0600AF6B RID: 44907 RVA: 0x0005067B File Offset: 0x0004E87B
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034A4 RID: 13476
		// (get) Token: 0x0600AF6C RID: 44908 RVA: 0x002DF374 File Offset: 0x002DD574
		// (set) Token: 0x0600AF6D RID: 44909 RVA: 0x0005069A File Offset: 0x0004E89A
		public unsafe RectTransform MinigameController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_MinigameController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_MinigameController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034A5 RID: 13477
		// (get) Token: 0x0600AF6E RID: 44910 RVA: 0x002DF3A4 File Offset: 0x002DD5A4
		// (set) Token: 0x0600AF6F RID: 44911 RVA: 0x000506B9 File Offset: 0x0004E8B9
		public unsafe RectTransform SlotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034A6 RID: 13478
		// (get) Token: 0x0600AF70 RID: 44912 RVA: 0x002DF3D4 File Offset: 0x002DD5D4
		// (set) Token: 0x0600AF71 RID: 44913 RVA: 0x000506D8 File Offset: 0x0004E8D8
		public unsafe ItemSlotUI ItemSlotPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_ItemSlotPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_ItemSlotPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034A7 RID: 13479
		// (get) Token: 0x0600AF72 RID: 44914 RVA: 0x002DF404 File Offset: 0x002DD604
		// (set) Token: 0x0600AF73 RID: 44915 RVA: 0x000506F7 File Offset: 0x0004E8F7
		public unsafe RectTransform SearchIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034A8 RID: 13480
		// (get) Token: 0x0600AF74 RID: 44916 RVA: 0x002DF434 File Offset: 0x002DD634
		// (set) Token: 0x0600AF75 RID: 44917 RVA: 0x00050716 File Offset: 0x0004E916
		public unsafe RectTransform SearchIndicatorStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034A9 RID: 13481
		// (get) Token: 0x0600AF76 RID: 44918 RVA: 0x002DF464 File Offset: 0x002DD664
		// (set) Token: 0x0600AF77 RID: 44919 RVA: 0x00050735 File Offset: 0x0004E935
		public unsafe RectTransform SearchIndicatorEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SearchIndicatorEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034AA RID: 13482
		// (get) Token: 0x0600AF78 RID: 44920 RVA: 0x002DF494 File Offset: 0x002DD694
		// (set) Token: 0x0600AF79 RID: 44921 RVA: 0x00050754 File Offset: 0x0004E954
		public unsafe Animation IndicatorAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_IndicatorAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_IndicatorAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034AB RID: 13483
		// (get) Token: 0x0600AF7A RID: 44922 RVA: 0x002DF4C4 File Offset: 0x002DD6C4
		// (set) Token: 0x0600AF7B RID: 44923 RVA: 0x00050773 File Offset: 0x0004E973
		public unsafe Animation TutorialAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_TutorialAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_TutorialAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034AC RID: 13484
		// (get) Token: 0x0600AF7C RID: 44924 RVA: 0x002DF4F4 File Offset: 0x002DD6F4
		// (set) Token: 0x0600AF7D RID: 44925 RVA: 0x00050792 File Offset: 0x0004E992
		public unsafe RectTransform TutorialContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_TutorialContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_TutorialContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034AD RID: 13485
		// (get) Token: 0x0600AF7E RID: 44926 RVA: 0x002DF524 File Offset: 0x002DD724
		// (set) Token: 0x0600AF7F RID: 44927 RVA: 0x000507B1 File Offset: 0x0004E9B1
		public unsafe Animation ResetAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_ResetAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_ResetAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034AE RID: 13486
		// (get) Token: 0x0600AF80 RID: 44928 RVA: 0x002DF554 File Offset: 0x002DD754
		// (set) Token: 0x0600AF81 RID: 44929 RVA: 0x000507D0 File Offset: 0x0004E9D0
		public unsafe AudioSourceController FailSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_FailSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_FailSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034AF RID: 13487
		// (get) Token: 0x0600AF82 RID: 44930 RVA: 0x002DF584 File Offset: 0x002DD784
		// (set) Token: 0x0600AF83 RID: 44931 RVA: 0x000507EF File Offset: 0x0004E9EF
		public unsafe InputActionReference SpeedUpInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SpeedUpInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_SpeedUpInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034B0 RID: 13488
		// (get) Token: 0x0600AF84 RID: 44932 RVA: 0x002DF5B4 File Offset: 0x002DD7B4
		// (set) Token: 0x0600AF85 RID: 44933 RVA: 0x0005080E File Offset: 0x0004EA0E
		public unsafe MonoState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034B1 RID: 13489
		// (get) Token: 0x0600AF86 RID: 44934 RVA: 0x002DF5E4 File Offset: 0x002DD7E4
		// (set) Token: 0x0600AF87 RID: 44935 RVA: 0x0005082D File Offset: 0x0004EA2D
		public unsafe UIPanel Panel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_Panel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034B2 RID: 13490
		// (get) Token: 0x0600AF88 RID: 44936 RVA: 0x002DF614 File Offset: 0x002DD814
		// (set) Token: 0x0600AF89 RID: 44937 RVA: 0x0005084C File Offset: 0x0004EA4C
		public unsafe InputPromptObj _inputPromptObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr__inputPromptObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptObj>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr__inputPromptObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034B3 RID: 13491
		// (get) Token: 0x0600AF8A RID: 44938 RVA: 0x002DF644 File Offset: 0x002DD844
		// (set) Token: 0x0600AF8B RID: 44939 RVA: 0x0005086B File Offset: 0x0004EA6B
		public unsafe List<ItemSlotUI> slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034B4 RID: 13492
		// (get) Token: 0x0600AF8C RID: 44940 RVA: 0x002DF674 File Offset: 0x002DD874
		// (set) Token: 0x0600AF8D RID: 44941 RVA: 0x0005088A File Offset: 0x0004EA8A
		public unsafe UnityEvent onSearchClear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_onSearchClear);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_onSearchClear), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034B5 RID: 13493
		// (get) Token: 0x0600AF8E RID: 44942 RVA: 0x002DF6A4 File Offset: 0x002DD8A4
		// (set) Token: 0x0600AF8F RID: 44943 RVA: 0x000508A9 File Offset: 0x0004EAA9
		public unsafe UnityEvent onSearchFail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_onSearchFail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_onSearchFail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034B6 RID: 13494
		// (get) Token: 0x0600AF90 RID: 44944 RVA: 0x002DF6D4 File Offset: 0x002DD8D4
		// (set) Token: 0x0600AF91 RID: 44945 RVA: 0x000508C8 File Offset: 0x0004EAC8
		public unsafe Color defaultSlotColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultSlotColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultSlotColor)) = value;
			}
		}

		// Token: 0x170034B7 RID: 13495
		// (get) Token: 0x0600AF92 RID: 44946 RVA: 0x002DF6FC File Offset: 0x002DD8FC
		// (set) Token: 0x0600AF93 RID: 44947 RVA: 0x000508E3 File Offset: 0x0004EAE3
		public unsafe Color defaultSlotHighlightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultSlotHighlightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultSlotHighlightColor)) = value;
			}
		}

		// Token: 0x170034B8 RID: 13496
		// (get) Token: 0x0600AF94 RID: 44948 RVA: 0x002DF724 File Offset: 0x002DD924
		// (set) Token: 0x0600AF95 RID: 44949 RVA: 0x000508FE File Offset: 0x0004EAFE
		public unsafe ItemSlotUI concealedSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_concealedSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_concealedSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034B9 RID: 13497
		// (get) Token: 0x0600AF96 RID: 44950 RVA: 0x002DF754 File Offset: 0x002DD954
		// (set) Token: 0x0600AF97 RID: 44951 RVA: 0x0005091D File Offset: 0x0004EB1D
		public unsafe ItemSlotUI hoveredSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_hoveredSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_hoveredSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034BA RID: 13498
		// (get) Token: 0x0600AF98 RID: 44952 RVA: 0x002DF784 File Offset: 0x002DD984
		// (set) Token: 0x0600AF99 RID: 44953 RVA: 0x0005093C File Offset: 0x0004EB3C
		public unsafe Il2CppStructArray<Color> defaultItemIconColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultItemIconColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_defaultItemIconColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034BB RID: 13499
		// (get) Token: 0x0600AF9A RID: 44954 RVA: 0x002DF7B4 File Offset: 0x002DD9B4
		// (set) Token: 0x0600AF9B RID: 44955 RVA: 0x0005095B File Offset: 0x0004EB5B
		public unsafe float speedBoost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_speedBoost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr_speedBoost)) = value;
			}
		}

		// Token: 0x170034BC RID: 13500
		// (get) Token: 0x0600AF9C RID: 44956 RVA: 0x002DF7DC File Offset: 0x002DD9DC
		// (set) Token: 0x0600AF9D RID: 44957 RVA: 0x00050976 File Offset: 0x0004EB76
		public unsafe bool _caught
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr__caught);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.NativeFieldInfoPtr__caught)) = value;
			}
		}

		// Token: 0x040078E7 RID: 30951
		private static readonly IntPtr NativeFieldInfoPtr_MAX_SPEED_BOOST;

		// Token: 0x040078E8 RID: 30952
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040078E9 RID: 30953
		private static readonly IntPtr NativeFieldInfoPtr__TutorialOpen_k__BackingField;

		// Token: 0x040078EA RID: 30954
		private static readonly IntPtr NativeFieldInfoPtr_SlotRedColor;

		// Token: 0x040078EB RID: 30955
		private static readonly IntPtr NativeFieldInfoPtr_SlotHighlightRedColor;

		// Token: 0x040078EC RID: 30956
		private static readonly IntPtr NativeFieldInfoPtr_GapTime;

		// Token: 0x040078ED RID: 30957
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040078EE RID: 30958
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040078EF RID: 30959
		private static readonly IntPtr NativeFieldInfoPtr_MinigameController;

		// Token: 0x040078F0 RID: 30960
		private static readonly IntPtr NativeFieldInfoPtr_SlotContainer;

		// Token: 0x040078F1 RID: 30961
		private static readonly IntPtr NativeFieldInfoPtr_ItemSlotPrefab;

		// Token: 0x040078F2 RID: 30962
		private static readonly IntPtr NativeFieldInfoPtr_SearchIndicator;

		// Token: 0x040078F3 RID: 30963
		private static readonly IntPtr NativeFieldInfoPtr_SearchIndicatorStart;

		// Token: 0x040078F4 RID: 30964
		private static readonly IntPtr NativeFieldInfoPtr_SearchIndicatorEnd;

		// Token: 0x040078F5 RID: 30965
		private static readonly IntPtr NativeFieldInfoPtr_IndicatorAnimation;

		// Token: 0x040078F6 RID: 30966
		private static readonly IntPtr NativeFieldInfoPtr_TutorialAnimation;

		// Token: 0x040078F7 RID: 30967
		private static readonly IntPtr NativeFieldInfoPtr_TutorialContainer;

		// Token: 0x040078F8 RID: 30968
		private static readonly IntPtr NativeFieldInfoPtr_ResetAnimation;

		// Token: 0x040078F9 RID: 30969
		private static readonly IntPtr NativeFieldInfoPtr_FailSound;

		// Token: 0x040078FA RID: 30970
		private static readonly IntPtr NativeFieldInfoPtr_SpeedUpInput;

		// Token: 0x040078FB RID: 30971
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x040078FC RID: 30972
		private static readonly IntPtr NativeFieldInfoPtr_Panel;

		// Token: 0x040078FD RID: 30973
		private static readonly IntPtr NativeFieldInfoPtr__inputPromptObj;

		// Token: 0x040078FE RID: 30974
		private static readonly IntPtr NativeFieldInfoPtr_slots;

		// Token: 0x040078FF RID: 30975
		private static readonly IntPtr NativeFieldInfoPtr_onSearchClear;

		// Token: 0x04007900 RID: 30976
		private static readonly IntPtr NativeFieldInfoPtr_onSearchFail;

		// Token: 0x04007901 RID: 30977
		private static readonly IntPtr NativeFieldInfoPtr_defaultSlotColor;

		// Token: 0x04007902 RID: 30978
		private static readonly IntPtr NativeFieldInfoPtr_defaultSlotHighlightColor;

		// Token: 0x04007903 RID: 30979
		private static readonly IntPtr NativeFieldInfoPtr_concealedSlot;

		// Token: 0x04007904 RID: 30980
		private static readonly IntPtr NativeFieldInfoPtr_hoveredSlot;

		// Token: 0x04007905 RID: 30981
		private static readonly IntPtr NativeFieldInfoPtr_defaultItemIconColors;

		// Token: 0x04007906 RID: 30982
		private static readonly IntPtr NativeFieldInfoPtr_speedBoost;

		// Token: 0x04007907 RID: 30983
		private static readonly IntPtr NativeFieldInfoPtr__caught;

		// Token: 0x04007908 RID: 30984
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04007909 RID: 30985
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x0400790A RID: 30986
		private static readonly IntPtr NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0;

		// Token: 0x0400790B RID: 30987
		private static readonly IntPtr NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0;

		// Token: 0x0400790C RID: 30988
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400790D RID: 30989
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400790E RID: 30990
		private static readonly IntPtr NativeMethodInfoPtr_SetupSlots_Private_Void_0;

		// Token: 0x0400790F RID: 30991
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007910 RID: 30992
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_NPC_Single_0;

		// Token: 0x04007911 RID: 30993
		private static readonly IntPtr NativeMethodInfoPtr_IsSlotConcealed_Private_Boolean_ItemSlotUI_0;

		// Token: 0x04007912 RID: 30994
		private static readonly IntPtr NativeMethodInfoPtr_ItemDetected_Private_Void_ItemSlotUI_0;

		// Token: 0x04007913 RID: 30995
		private static readonly IntPtr NativeMethodInfoPtr_SlotHeld_Public_Void_ItemSlotUI_0;

		// Token: 0x04007914 RID: 30996
		private static readonly IntPtr NativeMethodInfoPtr_SlotReleased_Public_Void_ItemSlotUI_0;

		// Token: 0x04007915 RID: 30997
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x04007916 RID: 30998
		private static readonly IntPtr NativeMethodInfoPtr_OpenTutorial_Private_Void_0;

		// Token: 0x04007917 RID: 30999
		private static readonly IntPtr NativeMethodInfoPtr_CloseTutorial_Public_Void_0;

		// Token: 0x04007918 RID: 31000
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007919 RID: 31001
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_ItemSlotUI_PDM_0;

		// Token: 0x0400791A RID: 31002
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_ItemSlotUI_PDM_1;

		// Token: 0x02000CB4 RID: 3252
		[ObfuscatedName("ScheduleOne.UI.BodySearchScreen+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F3D0 RID: 62416 RVA: 0x003AAAC8 File Offset: 0x003A8CC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass41_0>.NativeClassPtr);
				BodySearchScreen.__c__DisplayClass41_0.NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass41_0>.NativeClassPtr, "slot");
				BodySearchScreen.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass41_0>.NativeClassPtr, "<>4__this");
				BodySearchScreen.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass41_0>.NativeClassPtr, 100686370);
				BodySearchScreen.__c__DisplayClass41_0.NativeMethodInfoPtr__SetupSlots_b__0_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass41_0>.NativeClassPtr, 100686371);
				BodySearchScreen.__c__DisplayClass41_0.NativeMethodInfoPtr__SetupSlots_b__1_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass41_0>.NativeClassPtr, 100686372);
				BodySearchScreen.__c__DisplayClass41_0.NativeMethodInfoPtr__SetupSlots_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass41_0>.NativeClassPtr, 100686373);
				BodySearchScreen.__c__DisplayClass41_0.NativeMethodInfoPtr__SetupSlots_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass41_0>.NativeClassPtr, 100686374);
			}

			// Token: 0x0600F3D1 RID: 62417 RVA: 0x003AAB80 File Offset: 0x003A8D80
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass41_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3D2 RID: 62418 RVA: 0x003AABBC File Offset: 0x003A8DBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298756, XrefRangeEnd = 298758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetupSlots_b__0(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass41_0.NativeMethodInfoPtr__SetupSlots_b__0_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3D3 RID: 62419 RVA: 0x003AAC00 File Offset: 0x003A8E00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298758, XrefRangeEnd = 298760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetupSlots_b__1(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass41_0.NativeMethodInfoPtr__SetupSlots_b__1_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3D4 RID: 62420 RVA: 0x003AAC44 File Offset: 0x003A8E44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298760, XrefRangeEnd = 298768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetupSlots_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass41_0.NativeMethodInfoPtr__SetupSlots_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3D5 RID: 62421 RVA: 0x003AAC78 File Offset: 0x003A8E78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298768, XrefRangeEnd = 298776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetupSlots_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass41_0.NativeMethodInfoPtr__SetupSlots_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3D6 RID: 62422 RVA: 0x00073227 File Offset: 0x00071427
			public __c__DisplayClass41_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A05 RID: 18949
			// (get) Token: 0x0600F3D7 RID: 62423 RVA: 0x003AACAC File Offset: 0x003A8EAC
			// (set) Token: 0x0600F3D8 RID: 62424 RVA: 0x00073230 File Offset: 0x00071430
			public unsafe ItemSlotUI slot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass41_0.NativeFieldInfoPtr_slot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass41_0.NativeFieldInfoPtr_slot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A06 RID: 18950
			// (get) Token: 0x0600F3D9 RID: 62425 RVA: 0x003AACDC File Offset: 0x003A8EDC
			// (set) Token: 0x0600F3DA RID: 62426 RVA: 0x0007324F File Offset: 0x0007144F
			public unsafe BodySearchScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BodySearchScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A522 RID: 42274
			private static readonly IntPtr NativeFieldInfoPtr_slot;

			// Token: 0x0400A523 RID: 42275
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A524 RID: 42276
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A525 RID: 42277
			private static readonly IntPtr NativeMethodInfoPtr__SetupSlots_b__0_Internal_Void_BaseEventData_0;

			// Token: 0x0400A526 RID: 42278
			private static readonly IntPtr NativeMethodInfoPtr__SetupSlots_b__1_Internal_Void_BaseEventData_0;

			// Token: 0x0400A527 RID: 42279
			private static readonly IntPtr NativeMethodInfoPtr__SetupSlots_b__2_Internal_Void_0;

			// Token: 0x0400A528 RID: 42280
			private static readonly IntPtr NativeMethodInfoPtr__SetupSlots_b__3_Internal_Void_0;
		}

		// Token: 0x02000CB5 RID: 3253
		[ObfuscatedName("ScheduleOne.UI.BodySearchScreen+<>c__DisplayClass43_0")]
		public sealed class __c__DisplayClass43_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F3DB RID: 62427 RVA: 0x003AAD0C File Offset: 0x003A8F0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass43_0()
			{
				Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BodySearchScreen>.NativeClassPtr, "<>c__DisplayClass43_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0>.NativeClassPtr);
				BodySearchScreen.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0>.NativeClassPtr, "<>4__this");
				BodySearchScreen.__c__DisplayClass43_0.NativeFieldInfoPtr_searchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0>.NativeClassPtr, "searchTime");
				BodySearchScreen.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0>.NativeClassPtr, 100686375);
				BodySearchScreen.__c__DisplayClass43_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0>.NativeClassPtr, 100686376);
				BodySearchScreen.__c__DisplayClass43_0.NativeMethodInfoPtr__Open_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0>.NativeClassPtr, 100686377);
			}

			// Token: 0x0600F3DC RID: 62428 RVA: 0x003AAD9C File Offset: 0x003A8F9C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass43_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3DD RID: 62429 RVA: 0x003AADD8 File Offset: 0x003A8FD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298858, XrefRangeEnd = 298863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass43_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F3DE RID: 62430 RVA: 0x003AAE18 File Offset: 0x003A9018
			[CallerCount(0)]
			public unsafe bool _Open_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass43_0.NativeMethodInfoPtr__Open_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F3DF RID: 62431 RVA: 0x0007326E File Offset: 0x0007146E
			public __c__DisplayClass43_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A07 RID: 18951
			// (get) Token: 0x0600F3E0 RID: 62432 RVA: 0x003AAE54 File Offset: 0x003A9054
			// (set) Token: 0x0600F3E1 RID: 62433 RVA: 0x00073277 File Offset: 0x00071477
			public unsafe BodySearchScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BodySearchScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A08 RID: 18952
			// (get) Token: 0x0600F3E2 RID: 62434 RVA: 0x003AAE84 File Offset: 0x003A9084
			// (set) Token: 0x0600F3E3 RID: 62435 RVA: 0x00073296 File Offset: 0x00071496
			public unsafe float searchTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass43_0.NativeFieldInfoPtr_searchTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass43_0.NativeFieldInfoPtr_searchTime)) = value;
				}
			}

			// Token: 0x0400A529 RID: 42281
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A52A RID: 42282
			private static readonly IntPtr NativeFieldInfoPtr_searchTime;

			// Token: 0x0400A52B RID: 42283
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A52C RID: 42284
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0400A52D RID: 42285
			private static readonly IntPtr NativeMethodInfoPtr__Open_b__1_Internal_Boolean_0;

			// Token: 0x02000E03 RID: 3587
			[ObfuscatedName("ScheduleOne.UI.BodySearchScreen+<>c__DisplayClass43_0+<<Open>g__Search|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique : Il2CppSystem.Object
			{
				// Token: 0x06010272 RID: 66162 RVA: 0x003D5094 File Offset: 0x003D3294
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique()
				{
					Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0>.NativeClassPtr, "<<Open>g__Search|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr);
					BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>1__state");
					BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>2__current");
					BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>4__this");
					BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perGap_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<perGap>5__2");
					BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perBlock_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<perBlock>5__3");
					BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<i>5__4");
					BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100686378);
					BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100686379);
					BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100686380);
					BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100686381);
					BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100686382);
					BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100686383);
				}

				// Token: 0x06010273 RID: 66163 RVA: 0x003D51B0 File Offset: 0x003D33B0
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06010274 RID: 66164 RVA: 0x003D51F8 File Offset: 0x003D33F8
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06010275 RID: 66165 RVA: 0x003D522C File Offset: 0x003D342C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298776, XrefRangeEnd = 298853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004EE8 RID: 20200
				// (get) Token: 0x06010276 RID: 66166 RVA: 0x003D5268 File Offset: 0x003D3468
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010277 RID: 66167 RVA: 0x003D52A8 File Offset: 0x003D34A8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298853, XrefRangeEnd = 298858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004EE9 RID: 20201
				// (get) Token: 0x06010278 RID: 66168 RVA: 0x003D52DC File Offset: 0x003D34DC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010279 RID: 66169 RVA: 0x0007A81B File Offset: 0x00078A1B
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004EE2 RID: 20194
				// (get) Token: 0x0601027A RID: 66170 RVA: 0x003D531C File Offset: 0x003D351C
				// (set) Token: 0x0601027B RID: 66171 RVA: 0x0007A824 File Offset: 0x00078A24
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004EE3 RID: 20195
				// (get) Token: 0x0601027C RID: 66172 RVA: 0x003D5344 File Offset: 0x003D3544
				// (set) Token: 0x0601027D RID: 66173 RVA: 0x0007A83F File Offset: 0x00078A3F
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004EE4 RID: 20196
				// (get) Token: 0x0601027E RID: 66174 RVA: 0x003D5374 File Offset: 0x003D3574
				// (set) Token: 0x0601027F RID: 66175 RVA: 0x0007A85E File Offset: 0x00078A5E
				public unsafe BodySearchScreen.__c__DisplayClass43_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BodySearchScreen.__c__DisplayClass43_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004EE5 RID: 20197
				// (get) Token: 0x06010280 RID: 66176 RVA: 0x003D53A4 File Offset: 0x003D35A4
				// (set) Token: 0x06010281 RID: 66177 RVA: 0x0007A87D File Offset: 0x00078A7D
				public unsafe float _perGap_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perGap_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perGap_5__2)) = value;
					}
				}

				// Token: 0x17004EE6 RID: 20198
				// (get) Token: 0x06010282 RID: 66178 RVA: 0x003D53CC File Offset: 0x003D35CC
				// (set) Token: 0x06010283 RID: 66179 RVA: 0x0007A898 File Offset: 0x00078A98
				public unsafe float _perBlock_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perBlock_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__perBlock_5__3)) = value;
					}
				}

				// Token: 0x17004EE7 RID: 20199
				// (get) Token: 0x06010284 RID: 66180 RVA: 0x003D53F4 File Offset: 0x003D35F4
				// (set) Token: 0x06010285 RID: 66181 RVA: 0x0007A8B3 File Offset: 0x00078AB3
				public unsafe float _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchScreen.__c__DisplayClass43_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x0400ADFC RID: 44540
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ADFD RID: 44541
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400ADFE RID: 44542
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400ADFF RID: 44543
				private static readonly IntPtr NativeFieldInfoPtr__perGap_5__2;

				// Token: 0x0400AE00 RID: 44544
				private static readonly IntPtr NativeFieldInfoPtr__perBlock_5__3;

				// Token: 0x0400AE01 RID: 44545
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x0400AE02 RID: 44546
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AE03 RID: 44547
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AE04 RID: 44548
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AE05 RID: 44549
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AE06 RID: 44550
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AE07 RID: 44551
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
