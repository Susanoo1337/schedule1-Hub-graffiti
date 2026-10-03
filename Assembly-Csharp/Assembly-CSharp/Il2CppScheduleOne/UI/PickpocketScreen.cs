using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.State;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200074A RID: 1866
	public class PickpocketScreen : Singleton<PickpocketScreen>
	{
		// Token: 0x0600B5A2 RID: 46498 RVA: 0x002F1948 File Offset: 0x002EFB48
		// Note: this type is marked as 'beforefieldinit'.
		static PickpocketScreen()
		{
			Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PickpocketScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr);
			PickpocketScreen.NativeFieldInfoPtr_PICKPOCKET_XP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "PICKPOCKET_XP");
			PickpocketScreen.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "<IsOpen>k__BackingField");
			PickpocketScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "<TutorialOpen>k__BackingField");
			PickpocketScreen.NativeFieldInfoPtr_GreenAreaMaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "GreenAreaMaxWidth");
			PickpocketScreen.NativeFieldInfoPtr_GreenAreaMinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "GreenAreaMinWidth");
			PickpocketScreen.NativeFieldInfoPtr_SlideTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "SlideTime");
			PickpocketScreen.NativeFieldInfoPtr_SlideTimeMaxMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "SlideTimeMaxMultiplier");
			PickpocketScreen.NativeFieldInfoPtr_ValueDivisor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "ValueDivisor");
			PickpocketScreen.NativeFieldInfoPtr_Tolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "Tolerance");
			PickpocketScreen.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "Canvas");
			PickpocketScreen.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "Container");
			PickpocketScreen.NativeFieldInfoPtr_Slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "Slots");
			PickpocketScreen.NativeFieldInfoPtr_GreenAreas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "GreenAreas");
			PickpocketScreen.NativeFieldInfoPtr_TutorialAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "TutorialAnimation");
			PickpocketScreen.NativeFieldInfoPtr_TutorialContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "TutorialContainer");
			PickpocketScreen.NativeFieldInfoPtr_SliderContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "SliderContainer");
			PickpocketScreen.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "Slider");
			PickpocketScreen.NativeFieldInfoPtr_ActionsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "ActionsContainer");
			PickpocketScreen.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "State");
			PickpocketScreen.NativeFieldInfoPtr_Screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "Screen");
			PickpocketScreen.NativeFieldInfoPtr_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "Panel");
			PickpocketScreen.NativeFieldInfoPtr_ActionButtonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "ActionButtonContainer");
			PickpocketScreen.NativeFieldInfoPtr_ActionButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "ActionButton");
			PickpocketScreen.NativeFieldInfoPtr_ActionButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "ActionButtonLabel");
			PickpocketScreen.NativeFieldInfoPtr_StopPickpocketAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "StopPickpocketAction");
			PickpocketScreen.NativeFieldInfoPtr_onFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "onFail");
			PickpocketScreen.NativeFieldInfoPtr_onStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "onStop");
			PickpocketScreen.NativeFieldInfoPtr_onHitGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "onHitGreen");
			PickpocketScreen.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "npc");
			PickpocketScreen.NativeFieldInfoPtr_isSliding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "isSliding");
			PickpocketScreen.NativeFieldInfoPtr_slideDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "slideDirection");
			PickpocketScreen.NativeFieldInfoPtr_sliderPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "sliderPosition");
			PickpocketScreen.NativeFieldInfoPtr_slideTimeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "slideTimeMultiplier");
			PickpocketScreen.NativeFieldInfoPtr_isFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "isFail");
			PickpocketScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687070);
			PickpocketScreen.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687071);
			PickpocketScreen.NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687072);
			PickpocketScreen.NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687073);
			PickpocketScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687074);
			PickpocketScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687075);
			PickpocketScreen.NativeMethodInfoPtr_Open_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687076);
			PickpocketScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687077);
			PickpocketScreen.NativeMethodInfoPtr_StartSliding_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687078);
			PickpocketScreen.NativeMethodInfoPtr_StopArrow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687079);
			PickpocketScreen.NativeMethodInfoPtr_SetSlotLocked_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687080);
			PickpocketScreen.NativeMethodInfoPtr_AreAllSlotsUnlocked_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687081);
			PickpocketScreen.NativeMethodInfoPtr_GetHoveredSlot_Private_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687082);
			PickpocketScreen.NativeMethodInfoPtr_Fail_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687083);
			PickpocketScreen.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687084);
			PickpocketScreen.NativeMethodInfoPtr_OnClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687085);
			PickpocketScreen.NativeMethodInfoPtr_OpenTutorial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687086);
			PickpocketScreen.NativeMethodInfoPtr_CloseTutorial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687087);
			PickpocketScreen.NativeMethodInfoPtr_GetGreenAreaNormalizedPosition_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687088);
			PickpocketScreen.NativeMethodInfoPtr_GetGreenAreaNormalizedWidth_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687089);
			PickpocketScreen.NativeMethodInfoPtr_SetActionButtonState_Private_Void_EActionButtonState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687090);
			PickpocketScreen.NativeMethodInfoPtr_ActionButtonClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687091);
			PickpocketScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687092);
			PickpocketScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100687093);
		}

		// Token: 0x170036E7 RID: 14055
		// (get) Token: 0x0600B5A3 RID: 46499 RVA: 0x002F1E00 File Offset: 0x002F0000
		// (set) Token: 0x0600B5A4 RID: 46500 RVA: 0x002F1E3C File Offset: 0x002F003C
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170036E8 RID: 14056
		// (get) Token: 0x0600B5A5 RID: 46501 RVA: 0x002F1E7C File Offset: 0x002F007C
		// (set) Token: 0x0600B5A6 RID: 46502 RVA: 0x002F1EB8 File Offset: 0x002F00B8
		public unsafe bool TutorialOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B5A7 RID: 46503 RVA: 0x002F1EF8 File Offset: 0x002F00F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305625, XrefRangeEnd = 305649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PickpocketScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5A8 RID: 46504 RVA: 0x002F1F34 File Offset: 0x002F0134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305649, XrefRangeEnd = 305661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PickpocketScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5A9 RID: 46505 RVA: 0x002F1F70 File Offset: 0x002F0170
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 305734, RefRangeEnd = 305736, XrefRangeStart = 305661, XrefRangeEnd = 305734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(NPC _npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_Open_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5AA RID: 46506 RVA: 0x002F1FB4 File Offset: 0x002F01B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305736, XrefRangeEnd = 305761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5AB RID: 46507 RVA: 0x002F1FE8 File Offset: 0x002F01E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305761, XrefRangeEnd = 305773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSliding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_StartSliding_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5AC RID: 46508 RVA: 0x002F201C File Offset: 0x002F021C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 305818, RefRangeEnd = 305819, XrefRangeStart = 305773, XrefRangeEnd = 305818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopArrow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_StopArrow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5AD RID: 46509 RVA: 0x002F2050 File Offset: 0x002F0250
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 305833, RefRangeEnd = 305836, XrefRangeStart = 305819, XrefRangeEnd = 305833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSlotLocked(int index, bool locked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_SetSlotLocked_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5AE RID: 46510 RVA: 0x002F209C File Offset: 0x002F029C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 305838, RefRangeEnd = 305841, XrefRangeStart = 305836, XrefRangeEnd = 305838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreAllSlotsUnlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_AreAllSlotsUnlocked_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B5AF RID: 46511 RVA: 0x002F20D8 File Offset: 0x002F02D8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 305848, RefRangeEnd = 305855, XrefRangeStart = 305841, XrefRangeEnd = 305848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlotUI GetHoveredSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_GetHoveredSlot_Private_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr3) : null;
		}

		// Token: 0x0600B5B0 RID: 46512 RVA: 0x002F2118 File Offset: 0x002F0318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305855, XrefRangeEnd = 305862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Fail()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_Fail_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5B1 RID: 46513 RVA: 0x002F214C File Offset: 0x002F034C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305862, XrefRangeEnd = 305864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5B2 RID: 46514 RVA: 0x002F2180 File Offset: 0x002F0380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305864, XrefRangeEnd = 305892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_OnClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5B3 RID: 46515 RVA: 0x002F21B4 File Offset: 0x002F03B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305892, XrefRangeEnd = 305896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_OpenTutorial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5B4 RID: 46516 RVA: 0x002F21E8 File Offset: 0x002F03E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305896, XrefRangeEnd = 305899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_CloseTutorial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5B5 RID: 46517 RVA: 0x002F221C File Offset: 0x002F041C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 305901, RefRangeEnd = 305903, XrefRangeStart = 305899, XrefRangeEnd = 305901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetGreenAreaNormalizedPosition(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_GetGreenAreaNormalizedPosition_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B5B6 RID: 46518 RVA: 0x002F2268 File Offset: 0x002F0468
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 305905, RefRangeEnd = 305907, XrefRangeStart = 305903, XrefRangeEnd = 305905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetGreenAreaNormalizedWidth(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_GetGreenAreaNormalizedWidth_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B5B7 RID: 46519 RVA: 0x002F22B4 File Offset: 0x002F04B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 305911, RefRangeEnd = 305913, XrefRangeStart = 305907, XrefRangeEnd = 305911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActionButtonState(PickpocketScreen.EActionButtonState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_SetActionButtonState_Private_Void_EActionButtonState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5B8 RID: 46520 RVA: 0x002F22F4 File Offset: 0x002F04F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305913, XrefRangeEnd = 305925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActionButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_ActionButtonClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5B9 RID: 46521 RVA: 0x002F2328 File Offset: 0x002F0528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305925, XrefRangeEnd = 305928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PickpocketScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5BA RID: 46522 RVA: 0x002F2364 File Offset: 0x002F0564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305928, XrefRangeEnd = 305933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B5BB RID: 46523 RVA: 0x00054199 File Offset: 0x00052399
		public PickpocketScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170036C5 RID: 14021
		// (get) Token: 0x0600B5BC RID: 46524 RVA: 0x002F23A4 File Offset: 0x002F05A4
		// (set) Token: 0x0600B5BD RID: 46525 RVA: 0x000541A2 File Offset: 0x000523A2
		public unsafe static int PICKPOCKET_XP
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PickpocketScreen.NativeFieldInfoPtr_PICKPOCKET_XP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PickpocketScreen.NativeFieldInfoPtr_PICKPOCKET_XP, (void*)(&value));
			}
		}

		// Token: 0x170036C6 RID: 14022
		// (get) Token: 0x0600B5BE RID: 46526 RVA: 0x002F23C0 File Offset: 0x002F05C0
		// (set) Token: 0x0600B5BF RID: 46527 RVA: 0x000541B0 File Offset: 0x000523B0
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170036C7 RID: 14023
		// (get) Token: 0x0600B5C0 RID: 46528 RVA: 0x002F23E8 File Offset: 0x002F05E8
		// (set) Token: 0x0600B5C1 RID: 46529 RVA: 0x000541CB File Offset: 0x000523CB
		public unsafe bool _TutorialOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170036C8 RID: 14024
		// (get) Token: 0x0600B5C2 RID: 46530 RVA: 0x002F2410 File Offset: 0x002F0610
		// (set) Token: 0x0600B5C3 RID: 46531 RVA: 0x000541E6 File Offset: 0x000523E6
		public unsafe float GreenAreaMaxWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreaMaxWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreaMaxWidth)) = value;
			}
		}

		// Token: 0x170036C9 RID: 14025
		// (get) Token: 0x0600B5C4 RID: 46532 RVA: 0x002F2438 File Offset: 0x002F0638
		// (set) Token: 0x0600B5C5 RID: 46533 RVA: 0x00054201 File Offset: 0x00052401
		public unsafe float GreenAreaMinWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreaMinWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreaMinWidth)) = value;
			}
		}

		// Token: 0x170036CA RID: 14026
		// (get) Token: 0x0600B5C6 RID: 46534 RVA: 0x002F2460 File Offset: 0x002F0660
		// (set) Token: 0x0600B5C7 RID: 46535 RVA: 0x0005421C File Offset: 0x0005241C
		public unsafe float SlideTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SlideTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SlideTime)) = value;
			}
		}

		// Token: 0x170036CB RID: 14027
		// (get) Token: 0x0600B5C8 RID: 46536 RVA: 0x002F2488 File Offset: 0x002F0688
		// (set) Token: 0x0600B5C9 RID: 46537 RVA: 0x00054237 File Offset: 0x00052437
		public unsafe float SlideTimeMaxMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SlideTimeMaxMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SlideTimeMaxMultiplier)) = value;
			}
		}

		// Token: 0x170036CC RID: 14028
		// (get) Token: 0x0600B5CA RID: 46538 RVA: 0x002F24B0 File Offset: 0x002F06B0
		// (set) Token: 0x0600B5CB RID: 46539 RVA: 0x00054252 File Offset: 0x00052452
		public unsafe float ValueDivisor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_ValueDivisor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_ValueDivisor)) = value;
			}
		}

		// Token: 0x170036CD RID: 14029
		// (get) Token: 0x0600B5CC RID: 46540 RVA: 0x002F24D8 File Offset: 0x002F06D8
		// (set) Token: 0x0600B5CD RID: 46541 RVA: 0x0005426D File Offset: 0x0005246D
		public unsafe float Tolerance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Tolerance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Tolerance)) = value;
			}
		}

		// Token: 0x170036CE RID: 14030
		// (get) Token: 0x0600B5CE RID: 46542 RVA: 0x002F2500 File Offset: 0x002F0700
		// (set) Token: 0x0600B5CF RID: 46543 RVA: 0x00054288 File Offset: 0x00052488
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036CF RID: 14031
		// (get) Token: 0x0600B5D0 RID: 46544 RVA: 0x002F2530 File Offset: 0x002F0730
		// (set) Token: 0x0600B5D1 RID: 46545 RVA: 0x000542A7 File Offset: 0x000524A7
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036D0 RID: 14032
		// (get) Token: 0x0600B5D2 RID: 46546 RVA: 0x002F2560 File Offset: 0x002F0760
		// (set) Token: 0x0600B5D3 RID: 46547 RVA: 0x000542C6 File Offset: 0x000524C6
		public unsafe Il2CppReferenceArray<ItemSlotUI> Slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036D1 RID: 14033
		// (get) Token: 0x0600B5D4 RID: 46548 RVA: 0x002F2590 File Offset: 0x002F0790
		// (set) Token: 0x0600B5D5 RID: 46549 RVA: 0x000542E5 File Offset: 0x000524E5
		public unsafe Il2CppReferenceArray<RectTransform> GreenAreas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036D2 RID: 14034
		// (get) Token: 0x0600B5D6 RID: 46550 RVA: 0x002F25C0 File Offset: 0x002F07C0
		// (set) Token: 0x0600B5D7 RID: 46551 RVA: 0x00054304 File Offset: 0x00052504
		public unsafe Animation TutorialAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_TutorialAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_TutorialAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036D3 RID: 14035
		// (get) Token: 0x0600B5D8 RID: 46552 RVA: 0x002F25F0 File Offset: 0x002F07F0
		// (set) Token: 0x0600B5D9 RID: 46553 RVA: 0x00054323 File Offset: 0x00052523
		public unsafe RectTransform TutorialContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_TutorialContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_TutorialContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036D4 RID: 14036
		// (get) Token: 0x0600B5DA RID: 46554 RVA: 0x002F2620 File Offset: 0x002F0820
		// (set) Token: 0x0600B5DB RID: 46555 RVA: 0x00054342 File Offset: 0x00052542
		public unsafe RectTransform SliderContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SliderContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SliderContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036D5 RID: 14037
		// (get) Token: 0x0600B5DC RID: 46556 RVA: 0x002F2650 File Offset: 0x002F0850
		// (set) Token: 0x0600B5DD RID: 46557 RVA: 0x00054361 File Offset: 0x00052561
		public unsafe Slider Slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036D6 RID: 14038
		// (get) Token: 0x0600B5DE RID: 46558 RVA: 0x002F2680 File Offset: 0x002F0880
		// (set) Token: 0x0600B5DF RID: 46559 RVA: 0x00054380 File Offset: 0x00052580
		public unsafe RectTransform ActionsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_ActionsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_ActionsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036D7 RID: 14039
		// (get) Token: 0x0600B5E0 RID: 46560 RVA: 0x002F26B0 File Offset: 0x002F08B0
		// (set) Token: 0x0600B5E1 RID: 46561 RVA: 0x0005439F File Offset: 0x0005259F
		public unsafe MonoState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036D8 RID: 14040
		// (get) Token: 0x0600B5E2 RID: 46562 RVA: 0x002F26E0 File Offset: 0x002F08E0
		// (set) Token: 0x0600B5E3 RID: 46563 RVA: 0x000543BE File Offset: 0x000525BE
		public unsafe UIScreen Screen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Screen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Screen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036D9 RID: 14041
		// (get) Token: 0x0600B5E4 RID: 46564 RVA: 0x002F2710 File Offset: 0x002F0910
		// (set) Token: 0x0600B5E5 RID: 46565 RVA: 0x000543DD File Offset: 0x000525DD
		public unsafe UIPanel Panel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Panel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036DA RID: 14042
		// (get) Token: 0x0600B5E6 RID: 46566 RVA: 0x002F2740 File Offset: 0x002F0940
		// (set) Token: 0x0600B5E7 RID: 46567 RVA: 0x000543FC File Offset: 0x000525FC
		public unsafe GameObject ActionButtonContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_ActionButtonContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_ActionButtonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036DB RID: 14043
		// (get) Token: 0x0600B5E8 RID: 46568 RVA: 0x002F2770 File Offset: 0x002F0970
		// (set) Token: 0x0600B5E9 RID: 46569 RVA: 0x0005441B File Offset: 0x0005261B
		public unsafe Button ActionButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_ActionButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_ActionButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036DC RID: 14044
		// (get) Token: 0x0600B5EA RID: 46570 RVA: 0x002F27A0 File Offset: 0x002F09A0
		// (set) Token: 0x0600B5EB RID: 46571 RVA: 0x0005443A File Offset: 0x0005263A
		public unsafe TextMeshProUGUI ActionButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_ActionButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_ActionButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036DD RID: 14045
		// (get) Token: 0x0600B5EC RID: 46572 RVA: 0x002F27D0 File Offset: 0x002F09D0
		// (set) Token: 0x0600B5ED RID: 46573 RVA: 0x00054459 File Offset: 0x00052659
		public unsafe InputActionReference StopPickpocketAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_StopPickpocketAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_StopPickpocketAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036DE RID: 14046
		// (get) Token: 0x0600B5EE RID: 46574 RVA: 0x002F2800 File Offset: 0x002F0A00
		// (set) Token: 0x0600B5EF RID: 46575 RVA: 0x00054478 File Offset: 0x00052678
		public unsafe UnityEvent onFail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onFail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onFail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036DF RID: 14047
		// (get) Token: 0x0600B5F0 RID: 46576 RVA: 0x002F2830 File Offset: 0x002F0A30
		// (set) Token: 0x0600B5F1 RID: 46577 RVA: 0x00054497 File Offset: 0x00052697
		public unsafe UnityEvent onStop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onStop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onStop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036E0 RID: 14048
		// (get) Token: 0x0600B5F2 RID: 46578 RVA: 0x002F2860 File Offset: 0x002F0A60
		// (set) Token: 0x0600B5F3 RID: 46579 RVA: 0x000544B6 File Offset: 0x000526B6
		public unsafe UnityEvent onHitGreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onHitGreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onHitGreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036E1 RID: 14049
		// (get) Token: 0x0600B5F4 RID: 46580 RVA: 0x002F2890 File Offset: 0x002F0A90
		// (set) Token: 0x0600B5F5 RID: 46581 RVA: 0x000544D5 File Offset: 0x000526D5
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036E2 RID: 14050
		// (get) Token: 0x0600B5F6 RID: 46582 RVA: 0x002F28C0 File Offset: 0x002F0AC0
		// (set) Token: 0x0600B5F7 RID: 46583 RVA: 0x000544F4 File Offset: 0x000526F4
		public unsafe bool isSliding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_isSliding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_isSliding)) = value;
			}
		}

		// Token: 0x170036E3 RID: 14051
		// (get) Token: 0x0600B5F8 RID: 46584 RVA: 0x002F28E8 File Offset: 0x002F0AE8
		// (set) Token: 0x0600B5F9 RID: 46585 RVA: 0x0005450F File Offset: 0x0005270F
		public unsafe int slideDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_slideDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_slideDirection)) = value;
			}
		}

		// Token: 0x170036E4 RID: 14052
		// (get) Token: 0x0600B5FA RID: 46586 RVA: 0x002F2910 File Offset: 0x002F0B10
		// (set) Token: 0x0600B5FB RID: 46587 RVA: 0x0005452A File Offset: 0x0005272A
		public unsafe float sliderPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_sliderPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_sliderPosition)) = value;
			}
		}

		// Token: 0x170036E5 RID: 14053
		// (get) Token: 0x0600B5FC RID: 46588 RVA: 0x002F2938 File Offset: 0x002F0B38
		// (set) Token: 0x0600B5FD RID: 46589 RVA: 0x00054545 File Offset: 0x00052745
		public unsafe float slideTimeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_slideTimeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_slideTimeMultiplier)) = value;
			}
		}

		// Token: 0x170036E6 RID: 14054
		// (get) Token: 0x0600B5FE RID: 46590 RVA: 0x002F2960 File Offset: 0x002F0B60
		// (set) Token: 0x0600B5FF RID: 46591 RVA: 0x00054560 File Offset: 0x00052760
		public unsafe bool isFail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_isFail);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_isFail)) = value;
			}
		}

		// Token: 0x04007CE5 RID: 31973
		private static readonly IntPtr NativeFieldInfoPtr_PICKPOCKET_XP;

		// Token: 0x04007CE6 RID: 31974
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04007CE7 RID: 31975
		private static readonly IntPtr NativeFieldInfoPtr__TutorialOpen_k__BackingField;

		// Token: 0x04007CE8 RID: 31976
		private static readonly IntPtr NativeFieldInfoPtr_GreenAreaMaxWidth;

		// Token: 0x04007CE9 RID: 31977
		private static readonly IntPtr NativeFieldInfoPtr_GreenAreaMinWidth;

		// Token: 0x04007CEA RID: 31978
		private static readonly IntPtr NativeFieldInfoPtr_SlideTime;

		// Token: 0x04007CEB RID: 31979
		private static readonly IntPtr NativeFieldInfoPtr_SlideTimeMaxMultiplier;

		// Token: 0x04007CEC RID: 31980
		private static readonly IntPtr NativeFieldInfoPtr_ValueDivisor;

		// Token: 0x04007CED RID: 31981
		private static readonly IntPtr NativeFieldInfoPtr_Tolerance;

		// Token: 0x04007CEE RID: 31982
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04007CEF RID: 31983
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04007CF0 RID: 31984
		private static readonly IntPtr NativeFieldInfoPtr_Slots;

		// Token: 0x04007CF1 RID: 31985
		private static readonly IntPtr NativeFieldInfoPtr_GreenAreas;

		// Token: 0x04007CF2 RID: 31986
		private static readonly IntPtr NativeFieldInfoPtr_TutorialAnimation;

		// Token: 0x04007CF3 RID: 31987
		private static readonly IntPtr NativeFieldInfoPtr_TutorialContainer;

		// Token: 0x04007CF4 RID: 31988
		private static readonly IntPtr NativeFieldInfoPtr_SliderContainer;

		// Token: 0x04007CF5 RID: 31989
		private static readonly IntPtr NativeFieldInfoPtr_Slider;

		// Token: 0x04007CF6 RID: 31990
		private static readonly IntPtr NativeFieldInfoPtr_ActionsContainer;

		// Token: 0x04007CF7 RID: 31991
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04007CF8 RID: 31992
		private static readonly IntPtr NativeFieldInfoPtr_Screen;

		// Token: 0x04007CF9 RID: 31993
		private static readonly IntPtr NativeFieldInfoPtr_Panel;

		// Token: 0x04007CFA RID: 31994
		private static readonly IntPtr NativeFieldInfoPtr_ActionButtonContainer;

		// Token: 0x04007CFB RID: 31995
		private static readonly IntPtr NativeFieldInfoPtr_ActionButton;

		// Token: 0x04007CFC RID: 31996
		private static readonly IntPtr NativeFieldInfoPtr_ActionButtonLabel;

		// Token: 0x04007CFD RID: 31997
		private static readonly IntPtr NativeFieldInfoPtr_StopPickpocketAction;

		// Token: 0x04007CFE RID: 31998
		private static readonly IntPtr NativeFieldInfoPtr_onFail;

		// Token: 0x04007CFF RID: 31999
		private static readonly IntPtr NativeFieldInfoPtr_onStop;

		// Token: 0x04007D00 RID: 32000
		private static readonly IntPtr NativeFieldInfoPtr_onHitGreen;

		// Token: 0x04007D01 RID: 32001
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x04007D02 RID: 32002
		private static readonly IntPtr NativeFieldInfoPtr_isSliding;

		// Token: 0x04007D03 RID: 32003
		private static readonly IntPtr NativeFieldInfoPtr_slideDirection;

		// Token: 0x04007D04 RID: 32004
		private static readonly IntPtr NativeFieldInfoPtr_sliderPosition;

		// Token: 0x04007D05 RID: 32005
		private static readonly IntPtr NativeFieldInfoPtr_slideTimeMultiplier;

		// Token: 0x04007D06 RID: 32006
		private static readonly IntPtr NativeFieldInfoPtr_isFail;

		// Token: 0x04007D07 RID: 32007
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04007D08 RID: 32008
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04007D09 RID: 32009
		private static readonly IntPtr NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0;

		// Token: 0x04007D0A RID: 32010
		private static readonly IntPtr NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0;

		// Token: 0x04007D0B RID: 32011
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007D0C RID: 32012
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04007D0D RID: 32013
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_NPC_0;

		// Token: 0x04007D0E RID: 32014
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007D0F RID: 32015
		private static readonly IntPtr NativeMethodInfoPtr_StartSliding_Private_Void_0;

		// Token: 0x04007D10 RID: 32016
		private static readonly IntPtr NativeMethodInfoPtr_StopArrow_Private_Void_0;

		// Token: 0x04007D11 RID: 32017
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotLocked_Public_Void_Int32_Boolean_0;

		// Token: 0x04007D12 RID: 32018
		private static readonly IntPtr NativeMethodInfoPtr_AreAllSlotsUnlocked_Private_Boolean_0;

		// Token: 0x04007D13 RID: 32019
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredSlot_Private_ItemSlotUI_0;

		// Token: 0x04007D14 RID: 32020
		private static readonly IntPtr NativeMethodInfoPtr_Fail_Private_Void_0;

		// Token: 0x04007D15 RID: 32021
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04007D16 RID: 32022
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Private_Void_0;

		// Token: 0x04007D17 RID: 32023
		private static readonly IntPtr NativeMethodInfoPtr_OpenTutorial_Private_Void_0;

		// Token: 0x04007D18 RID: 32024
		private static readonly IntPtr NativeMethodInfoPtr_CloseTutorial_Public_Void_0;

		// Token: 0x04007D19 RID: 32025
		private static readonly IntPtr NativeMethodInfoPtr_GetGreenAreaNormalizedPosition_Private_Single_Int32_0;

		// Token: 0x04007D1A RID: 32026
		private static readonly IntPtr NativeMethodInfoPtr_GetGreenAreaNormalizedWidth_Private_Single_Int32_0;

		// Token: 0x04007D1B RID: 32027
		private static readonly IntPtr NativeMethodInfoPtr_SetActionButtonState_Private_Void_EActionButtonState_0;

		// Token: 0x04007D1C RID: 32028
		private static readonly IntPtr NativeMethodInfoPtr_ActionButtonClicked_Private_Void_0;

		// Token: 0x04007D1D RID: 32029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007D1E RID: 32030
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000CDF RID: 3295
		[OriginalName("Assembly-CSharp.dll", "", "EActionButtonState")]
		public enum EActionButtonState
		{
			// Token: 0x0400A63F RID: 42559
			Hidden,
			// Token: 0x0400A640 RID: 42560
			StopArrow,
			// Token: 0x0400A641 RID: 42561
			Continue
		}

		// Token: 0x02000CE0 RID: 3296
		[ObfuscatedName("ScheduleOne.UI.PickpocketScreen+<<Fail>g__FailCoroutine|50_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600F5B0 RID: 62896 RVA: 0x003AFC3C File Offset: 0x003ADE3C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique()
			{
				Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "<<Fail>g__FailCoroutine|50_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, "<>1__state");
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, "<>2__current");
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, "<>4__this");
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100687094);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100687095);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100687096);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100687097);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100687098);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100687099);
			}

			// Token: 0x0600F5B1 RID: 62897 RVA: 0x003AFD1C File Offset: 0x003ADF1C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F5B2 RID: 62898 RVA: 0x003AFD64 File Offset: 0x003ADF64
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F5B3 RID: 62899 RVA: 0x003AFD98 File Offset: 0x003ADF98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305615, XrefRangeEnd = 305620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004AAA RID: 19114
			// (get) Token: 0x0600F5B4 RID: 62900 RVA: 0x003AFDD4 File Offset: 0x003ADFD4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F5B5 RID: 62901 RVA: 0x003AFE14 File Offset: 0x003AE014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305620, XrefRangeEnd = 305625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004AAB RID: 19115
			// (get) Token: 0x0600F5B6 RID: 62902 RVA: 0x003AFE48 File Offset: 0x003AE048
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F5B7 RID: 62903 RVA: 0x00074279 File Offset: 0x00072479
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004AA7 RID: 19111
			// (get) Token: 0x0600F5B8 RID: 62904 RVA: 0x003AFE88 File Offset: 0x003AE088
			// (set) Token: 0x0600F5B9 RID: 62905 RVA: 0x00074282 File Offset: 0x00072482
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004AA8 RID: 19112
			// (get) Token: 0x0600F5BA RID: 62906 RVA: 0x003AFEB0 File Offset: 0x003AE0B0
			// (set) Token: 0x0600F5BB RID: 62907 RVA: 0x0007429D File Offset: 0x0007249D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AA9 RID: 19113
			// (get) Token: 0x0600F5BC RID: 62908 RVA: 0x003AFEE0 File Offset: 0x003AE0E0
			// (set) Token: 0x0600F5BD RID: 62909 RVA: 0x000742BC File Offset: 0x000724BC
			public unsafe PickpocketScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PickpocketScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A642 RID: 42562
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A643 RID: 42563
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A644 RID: 42564
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A645 RID: 42565
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A646 RID: 42566
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A647 RID: 42567
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A648 RID: 42568
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A649 RID: 42569
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A64A RID: 42570
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
