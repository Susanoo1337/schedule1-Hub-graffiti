using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.State;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000732 RID: 1842
	public class GameplayMenu : Singleton<GameplayMenu>
	{
		// Token: 0x0600B198 RID: 45464 RVA: 0x002E5AC4 File Offset: 0x002E3CC4
		// Note: this type is marked as 'beforefieldinit'.
		static GameplayMenu()
		{
			Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "GameplayMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr);
			GameplayMenu.NativeFieldInfoPtr_OpenVerticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "OpenVerticalOffset");
			GameplayMenu.NativeFieldInfoPtr_ClosedVerticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "ClosedVerticalOffset");
			GameplayMenu.NativeFieldInfoPtr_OpenTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "OpenTime");
			GameplayMenu.NativeFieldInfoPtr_SlideTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "SlideTime");
			GameplayMenu.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "<IsOpen>k__BackingField");
			GameplayMenu.NativeFieldInfoPtr__CurrentScreen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "<CurrentScreen>k__BackingField");
			GameplayMenu.NativeFieldInfoPtr_OverlayCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "OverlayCamera");
			GameplayMenu.NativeFieldInfoPtr_OverlayLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "OverlayLight");
			GameplayMenu.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "State");
			GameplayMenu.NativeFieldInfoPtr_ContainerOffset_PhoneScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "ContainerOffset_PhoneScreen");
			GameplayMenu.NativeFieldInfoPtr__toggleAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "_toggleAction");
			GameplayMenu.NativeFieldInfoPtr__mapShortcutAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "_mapShortcutAction");
			GameplayMenu.NativeFieldInfoPtr__journalShortcutAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "_journalShortcutAction");
			GameplayMenu.NativeFieldInfoPtr__messagesShortcutAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "_messagesShortcutAction");
			GameplayMenu.NativeFieldInfoPtr_openCloseRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "openCloseRoutine");
			GameplayMenu.NativeFieldInfoPtr_screenChangeRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "screenChangeRoutine");
			GameplayMenu.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100686642);
			GameplayMenu.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100686643);
			GameplayMenu.NativeMethodInfoPtr_get_CharacterScreenEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100686644);
			GameplayMenu.NativeMethodInfoPtr_get_CurrentScreen_Public_get_EGameplayScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100686645);
			GameplayMenu.NativeMethodInfoPtr_set_CurrentScreen_Protected_set_Void_EGameplayScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100686646);
			GameplayMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100686647);
			GameplayMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100686648);
			GameplayMenu.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100686649);
			GameplayMenu.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100686650);
			GameplayMenu.NativeMethodInfoPtr_AcceptInputFromCurrentState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100686651);
			GameplayMenu.NativeMethodInfoPtr_SetScreen_Public_Void_EGameplayScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100686652);
			GameplayMenu.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100686653);
			GameplayMenu.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100686654);
			GameplayMenu.NativeMethodInfoPtr_OnOpen_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100686655);
			GameplayMenu.NativeMethodInfoPtr_OnClose_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100686656);
			GameplayMenu.NativeMethodInfoPtr_SetIsOpenRoutine_Private_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100686657);
			GameplayMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100686658);
			GameplayMenu.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100686659);
		}

		// Token: 0x17003570 RID: 13680
		// (get) Token: 0x0600B199 RID: 45465 RVA: 0x002E5D9C File Offset: 0x002E3F9C
		// (set) Token: 0x0600B19A RID: 45466 RVA: 0x002E5DD8 File Offset: 0x002E3FD8
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003571 RID: 13681
		// (get) Token: 0x0600B19B RID: 45467 RVA: 0x002E5E18 File Offset: 0x002E4018
		public unsafe bool CharacterScreenEnabled
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_get_CharacterScreenEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003572 RID: 13682
		// (get) Token: 0x0600B19C RID: 45468 RVA: 0x002E5E54 File Offset: 0x002E4054
		// (set) Token: 0x0600B19D RID: 45469 RVA: 0x002E5E90 File Offset: 0x002E4090
		public unsafe GameplayMenu.EGameplayScreen CurrentScreen
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 70643, RefRangeEnd = 70670, XrefRangeStart = 70643, XrefRangeEnd = 70670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_get_CurrentScreen_Public_get_EGameplayScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 165205, RefRangeEnd = 165206, XrefRangeStart = 165205, XrefRangeEnd = 165206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_set_CurrentScreen_Protected_set_Void_EGameplayScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B19E RID: 45470 RVA: 0x002E5ED0 File Offset: 0x002E40D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301147, XrefRangeEnd = 301150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameplayMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B19F RID: 45471 RVA: 0x002E5F0C File Offset: 0x002E410C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301150, XrefRangeEnd = 301193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameplayMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1A0 RID: 45472 RVA: 0x002E5F48 File Offset: 0x002E4148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301193, XrefRangeEnd = 301205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1A1 RID: 45473 RVA: 0x002E5F8C File Offset: 0x002E418C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301205, XrefRangeEnd = 301295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameplayMenu.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1A2 RID: 45474 RVA: 0x002E5FC8 File Offset: 0x002E41C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301295, XrefRangeEnd = 301318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AcceptInputFromCurrentState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_AcceptInputFromCurrentState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B1A3 RID: 45475 RVA: 0x002E6004 File Offset: 0x002E4204
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 301359, RefRangeEnd = 301362, XrefRangeStart = 301318, XrefRangeEnd = 301359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScreen(GameplayMenu.EGameplayScreen screen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref screen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_SetScreen_Public_Void_EGameplayScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1A4 RID: 45476 RVA: 0x002E6044 File Offset: 0x002E4244
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301364, RefRangeEnd = 301365, XrefRangeStart = 301362, XrefRangeEnd = 301364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1A5 RID: 45477 RVA: 0x002E6078 File Offset: 0x002E4278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1A6 RID: 45478 RVA: 0x002E60AC File Offset: 0x002E42AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301365, XrefRangeEnd = 301401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_OnOpen_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1A7 RID: 45479 RVA: 0x002E60E0 File Offset: 0x002E42E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301401, XrefRangeEnd = 301436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_OnClose_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1A8 RID: 45480 RVA: 0x002E6114 File Offset: 0x002E4314
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301441, RefRangeEnd = 301443, XrefRangeStart = 301436, XrefRangeEnd = 301441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SetIsOpenRoutine(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_SetIsOpenRoutine_Private_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B1A9 RID: 45481 RVA: 0x002E6160 File Offset: 0x002E4360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301443, XrefRangeEnd = 301446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameplayMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1AA RID: 45482 RVA: 0x002E619C File Offset: 0x002E439C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301459, RefRangeEnd = 301461, XrefRangeStart = 301446, XrefRangeEnd = 301459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1AB RID: 45483 RVA: 0x00051A54 File Offset: 0x0004FC54
		public GameplayMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003560 RID: 13664
		// (get) Token: 0x0600B1AC RID: 45484 RVA: 0x002E61D0 File Offset: 0x002E43D0
		// (set) Token: 0x0600B1AD RID: 45485 RVA: 0x00051A5D File Offset: 0x0004FC5D
		public unsafe static float OpenVerticalOffset
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GameplayMenu.NativeFieldInfoPtr_OpenVerticalOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameplayMenu.NativeFieldInfoPtr_OpenVerticalOffset, (void*)(&value));
			}
		}

		// Token: 0x17003561 RID: 13665
		// (get) Token: 0x0600B1AE RID: 45486 RVA: 0x002E61EC File Offset: 0x002E43EC
		// (set) Token: 0x0600B1AF RID: 45487 RVA: 0x00051A6B File Offset: 0x0004FC6B
		public unsafe static float ClosedVerticalOffset
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GameplayMenu.NativeFieldInfoPtr_ClosedVerticalOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameplayMenu.NativeFieldInfoPtr_ClosedVerticalOffset, (void*)(&value));
			}
		}

		// Token: 0x17003562 RID: 13666
		// (get) Token: 0x0600B1B0 RID: 45488 RVA: 0x002E6208 File Offset: 0x002E4408
		// (set) Token: 0x0600B1B1 RID: 45489 RVA: 0x00051A79 File Offset: 0x0004FC79
		public unsafe static float OpenTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GameplayMenu.NativeFieldInfoPtr_OpenTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameplayMenu.NativeFieldInfoPtr_OpenTime, (void*)(&value));
			}
		}

		// Token: 0x17003563 RID: 13667
		// (get) Token: 0x0600B1B2 RID: 45490 RVA: 0x002E6224 File Offset: 0x002E4424
		// (set) Token: 0x0600B1B3 RID: 45491 RVA: 0x00051A87 File Offset: 0x0004FC87
		public unsafe static float SlideTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GameplayMenu.NativeFieldInfoPtr_SlideTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameplayMenu.NativeFieldInfoPtr_SlideTime, (void*)(&value));
			}
		}

		// Token: 0x17003564 RID: 13668
		// (get) Token: 0x0600B1B4 RID: 45492 RVA: 0x002E6240 File Offset: 0x002E4440
		// (set) Token: 0x0600B1B5 RID: 45493 RVA: 0x00051A95 File Offset: 0x0004FC95
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003565 RID: 13669
		// (get) Token: 0x0600B1B6 RID: 45494 RVA: 0x002E6268 File Offset: 0x002E4468
		// (set) Token: 0x0600B1B7 RID: 45495 RVA: 0x00051AB0 File Offset: 0x0004FCB0
		public unsafe GameplayMenu.EGameplayScreen _CurrentScreen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr__CurrentScreen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr__CurrentScreen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003566 RID: 13670
		// (get) Token: 0x0600B1B8 RID: 45496 RVA: 0x002E6290 File Offset: 0x002E4490
		// (set) Token: 0x0600B1B9 RID: 45497 RVA: 0x00051ACB File Offset: 0x0004FCCB
		public unsafe Camera OverlayCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_OverlayCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_OverlayCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003567 RID: 13671
		// (get) Token: 0x0600B1BA RID: 45498 RVA: 0x002E62C0 File Offset: 0x002E44C0
		// (set) Token: 0x0600B1BB RID: 45499 RVA: 0x00051AEA File Offset: 0x0004FCEA
		public unsafe Light OverlayLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_OverlayLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_OverlayLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003568 RID: 13672
		// (get) Token: 0x0600B1BC RID: 45500 RVA: 0x002E62F0 File Offset: 0x002E44F0
		// (set) Token: 0x0600B1BD RID: 45501 RVA: 0x00051B09 File Offset: 0x0004FD09
		public unsafe MonoStateMachine State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoStateMachine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003569 RID: 13673
		// (get) Token: 0x0600B1BE RID: 45502 RVA: 0x002E6320 File Offset: 0x002E4520
		// (set) Token: 0x0600B1BF RID: 45503 RVA: 0x00051B28 File Offset: 0x0004FD28
		public unsafe float ContainerOffset_PhoneScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_ContainerOffset_PhoneScreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_ContainerOffset_PhoneScreen)) = value;
			}
		}

		// Token: 0x1700356A RID: 13674
		// (get) Token: 0x0600B1C0 RID: 45504 RVA: 0x002E6348 File Offset: 0x002E4548
		// (set) Token: 0x0600B1C1 RID: 45505 RVA: 0x00051B43 File Offset: 0x0004FD43
		public unsafe InputActionReference _toggleAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr__toggleAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr__toggleAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700356B RID: 13675
		// (get) Token: 0x0600B1C2 RID: 45506 RVA: 0x002E6378 File Offset: 0x002E4578
		// (set) Token: 0x0600B1C3 RID: 45507 RVA: 0x00051B62 File Offset: 0x0004FD62
		public unsafe InputActionReference _mapShortcutAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr__mapShortcutAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr__mapShortcutAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700356C RID: 13676
		// (get) Token: 0x0600B1C4 RID: 45508 RVA: 0x002E63A8 File Offset: 0x002E45A8
		// (set) Token: 0x0600B1C5 RID: 45509 RVA: 0x00051B81 File Offset: 0x0004FD81
		public unsafe InputActionReference _journalShortcutAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr__journalShortcutAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr__journalShortcutAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700356D RID: 13677
		// (get) Token: 0x0600B1C6 RID: 45510 RVA: 0x002E63D8 File Offset: 0x002E45D8
		// (set) Token: 0x0600B1C7 RID: 45511 RVA: 0x00051BA0 File Offset: 0x0004FDA0
		public unsafe InputActionReference _messagesShortcutAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr__messagesShortcutAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr__messagesShortcutAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700356E RID: 13678
		// (get) Token: 0x0600B1C8 RID: 45512 RVA: 0x002E6408 File Offset: 0x002E4608
		// (set) Token: 0x0600B1C9 RID: 45513 RVA: 0x00051BBF File Offset: 0x0004FDBF
		public unsafe Coroutine openCloseRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_openCloseRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_openCloseRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700356F RID: 13679
		// (get) Token: 0x0600B1CA RID: 45514 RVA: 0x002E6438 File Offset: 0x002E4638
		// (set) Token: 0x0600B1CB RID: 45515 RVA: 0x00051BDE File Offset: 0x0004FDDE
		public unsafe Coroutine screenChangeRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_screenChangeRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_screenChangeRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007A5A RID: 31322
		private static readonly IntPtr NativeFieldInfoPtr_OpenVerticalOffset;

		// Token: 0x04007A5B RID: 31323
		private static readonly IntPtr NativeFieldInfoPtr_ClosedVerticalOffset;

		// Token: 0x04007A5C RID: 31324
		private static readonly IntPtr NativeFieldInfoPtr_OpenTime;

		// Token: 0x04007A5D RID: 31325
		private static readonly IntPtr NativeFieldInfoPtr_SlideTime;

		// Token: 0x04007A5E RID: 31326
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04007A5F RID: 31327
		private static readonly IntPtr NativeFieldInfoPtr__CurrentScreen_k__BackingField;

		// Token: 0x04007A60 RID: 31328
		private static readonly IntPtr NativeFieldInfoPtr_OverlayCamera;

		// Token: 0x04007A61 RID: 31329
		private static readonly IntPtr NativeFieldInfoPtr_OverlayLight;

		// Token: 0x04007A62 RID: 31330
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04007A63 RID: 31331
		private static readonly IntPtr NativeFieldInfoPtr_ContainerOffset_PhoneScreen;

		// Token: 0x04007A64 RID: 31332
		private static readonly IntPtr NativeFieldInfoPtr__toggleAction;

		// Token: 0x04007A65 RID: 31333
		private static readonly IntPtr NativeFieldInfoPtr__mapShortcutAction;

		// Token: 0x04007A66 RID: 31334
		private static readonly IntPtr NativeFieldInfoPtr__journalShortcutAction;

		// Token: 0x04007A67 RID: 31335
		private static readonly IntPtr NativeFieldInfoPtr__messagesShortcutAction;

		// Token: 0x04007A68 RID: 31336
		private static readonly IntPtr NativeFieldInfoPtr_openCloseRoutine;

		// Token: 0x04007A69 RID: 31337
		private static readonly IntPtr NativeFieldInfoPtr_screenChangeRoutine;

		// Token: 0x04007A6A RID: 31338
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04007A6B RID: 31339
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04007A6C RID: 31340
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterScreenEnabled_Public_get_Boolean_0;

		// Token: 0x04007A6D RID: 31341
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentScreen_Public_get_EGameplayScreen_0;

		// Token: 0x04007A6E RID: 31342
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentScreen_Protected_set_Void_EGameplayScreen_0;

		// Token: 0x04007A6F RID: 31343
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007A70 RID: 31344
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04007A71 RID: 31345
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x04007A72 RID: 31346
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04007A73 RID: 31347
		private static readonly IntPtr NativeMethodInfoPtr_AcceptInputFromCurrentState_Private_Boolean_0;

		// Token: 0x04007A74 RID: 31348
		private static readonly IntPtr NativeMethodInfoPtr_SetScreen_Public_Void_EGameplayScreen_0;

		// Token: 0x04007A75 RID: 31349
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04007A76 RID: 31350
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04007A77 RID: 31351
		private static readonly IntPtr NativeMethodInfoPtr_OnOpen_Private_Void_1;

		// Token: 0x04007A78 RID: 31352
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Private_Void_1;

		// Token: 0x04007A79 RID: 31353
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpenRoutine_Private_IEnumerator_Boolean_0;

		// Token: 0x04007A7A RID: 31354
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007A7B RID: 31355
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x02000CC4 RID: 3268
		[OriginalName("Assembly-CSharp.dll", "", "EGameplayScreen")]
		public enum EGameplayScreen
		{
			// Token: 0x0400A599 RID: 42393
			Phone,
			// Token: 0x0400A59A RID: 42394
			Character
		}

		// Token: 0x02000CC5 RID: 3269
		[ObfuscatedName("ScheduleOne.UI.GameplayMenu+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F4A3 RID: 62627 RVA: 0x003ACEB0 File Offset: 0x003AB0B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0>.NativeClassPtr);
				GameplayMenu.__c__DisplayClass30_0.NativeFieldInfoPtr_screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0>.NativeClassPtr, "screen");
				GameplayMenu.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0>.NativeClassPtr, "<>4__this");
				GameplayMenu.__c__DisplayClass30_0.NativeFieldInfoPtr_previousScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0>.NativeClassPtr, "previousScreen");
				GameplayMenu.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0>.NativeClassPtr, 100686660);
				GameplayMenu.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0>.NativeClassPtr, 100686661);
			}

			// Token: 0x0600F4A4 RID: 62628 RVA: 0x003ACF40 File Offset: 0x003AB140
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4A5 RID: 62629 RVA: 0x003ACF7C File Offset: 0x003AB17C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301107, XrefRangeEnd = 301112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F4A6 RID: 62630 RVA: 0x00073960 File Offset: 0x00071B60
			public __c__DisplayClass30_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A4C RID: 19020
			// (get) Token: 0x0600F4A7 RID: 62631 RVA: 0x003ACFBC File Offset: 0x003AB1BC
			// (set) Token: 0x0600F4A8 RID: 62632 RVA: 0x00073969 File Offset: 0x00071B69
			public unsafe GameplayMenu.EGameplayScreen screen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass30_0.NativeFieldInfoPtr_screen);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass30_0.NativeFieldInfoPtr_screen)) = value;
				}
			}

			// Token: 0x17004A4D RID: 19021
			// (get) Token: 0x0600F4A9 RID: 62633 RVA: 0x003ACFE4 File Offset: 0x003AB1E4
			// (set) Token: 0x0600F4AA RID: 62634 RVA: 0x00073984 File Offset: 0x00071B84
			public unsafe GameplayMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameplayMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A4E RID: 19022
			// (get) Token: 0x0600F4AB RID: 62635 RVA: 0x003AD014 File Offset: 0x003AB214
			// (set) Token: 0x0600F4AC RID: 62636 RVA: 0x000739A3 File Offset: 0x00071BA3
			public unsafe GameplayMenu.EGameplayScreen previousScreen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass30_0.NativeFieldInfoPtr_previousScreen);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass30_0.NativeFieldInfoPtr_previousScreen)) = value;
				}
			}

			// Token: 0x0400A59B RID: 42395
			private static readonly IntPtr NativeFieldInfoPtr_screen;

			// Token: 0x0400A59C RID: 42396
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A59D RID: 42397
			private static readonly IntPtr NativeFieldInfoPtr_previousScreen;

			// Token: 0x0400A59E RID: 42398
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A59F RID: 42399
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000E08 RID: 3592
			[ObfuscatedName("ScheduleOne.UI.GameplayMenu+<>c__DisplayClass30_0+<<SetScreen>g__ScreenChange|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique : Il2CppSystem.Object
			{
				// Token: 0x060102CA RID: 66250 RVA: 0x003D60D4 File Offset: 0x003D42D4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique()
				{
					Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0>.NativeClassPtr, "<<SetScreen>g__ScreenChange|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr);
					GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>1__state");
					GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>2__current");
					GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>4__this");
					GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__endXPos_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<endXPos>5__2");
					GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startXPos_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<startXPos>5__3");
					GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__t_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<t>5__4");
					GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100686662);
					GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100686663);
					GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100686664);
					GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100686665);
					GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100686666);
					GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100686667);
				}

				// Token: 0x060102CB RID: 66251 RVA: 0x003D61F0 File Offset: 0x003D43F0
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060102CC RID: 66252 RVA: 0x003D6238 File Offset: 0x003D4438
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060102CD RID: 66253 RVA: 0x003D626C File Offset: 0x003D446C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301069, XrefRangeEnd = 301102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004F0A RID: 20234
				// (get) Token: 0x060102CE RID: 66254 RVA: 0x003D62A8 File Offset: 0x003D44A8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060102CF RID: 66255 RVA: 0x003D62E8 File Offset: 0x003D44E8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301102, XrefRangeEnd = 301107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004F0B RID: 20235
				// (get) Token: 0x060102D0 RID: 66256 RVA: 0x003D631C File Offset: 0x003D451C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060102D1 RID: 66257 RVA: 0x0007AAF8 File Offset: 0x00078CF8
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004F04 RID: 20228
				// (get) Token: 0x060102D2 RID: 66258 RVA: 0x003D635C File Offset: 0x003D455C
				// (set) Token: 0x060102D3 RID: 66259 RVA: 0x0007AB01 File Offset: 0x00078D01
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004F05 RID: 20229
				// (get) Token: 0x060102D4 RID: 66260 RVA: 0x003D6384 File Offset: 0x003D4584
				// (set) Token: 0x060102D5 RID: 66261 RVA: 0x0007AB1C File Offset: 0x00078D1C
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F06 RID: 20230
				// (get) Token: 0x060102D6 RID: 66262 RVA: 0x003D63B4 File Offset: 0x003D45B4
				// (set) Token: 0x060102D7 RID: 66263 RVA: 0x0007AB3B File Offset: 0x00078D3B
				public unsafe GameplayMenu.__c__DisplayClass30_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameplayMenu.__c__DisplayClass30_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F07 RID: 20231
				// (get) Token: 0x060102D8 RID: 66264 RVA: 0x003D63E4 File Offset: 0x003D45E4
				// (set) Token: 0x060102D9 RID: 66265 RVA: 0x0007AB5A File Offset: 0x00078D5A
				public unsafe float _endXPos_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__endXPos_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__endXPos_5__2)) = value;
					}
				}

				// Token: 0x17004F08 RID: 20232
				// (get) Token: 0x060102DA RID: 66266 RVA: 0x003D640C File Offset: 0x003D460C
				// (set) Token: 0x060102DB RID: 66267 RVA: 0x0007AB75 File Offset: 0x00078D75
				public unsafe float _startXPos_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startXPos_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startXPos_5__3)) = value;
					}
				}

				// Token: 0x17004F09 RID: 20233
				// (get) Token: 0x060102DC RID: 66268 RVA: 0x003D6434 File Offset: 0x003D4634
				// (set) Token: 0x060102DD RID: 66269 RVA: 0x0007AB90 File Offset: 0x00078D90
				public unsafe float _t_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__t_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__t_5__4)) = value;
					}
				}

				// Token: 0x0400AE32 RID: 44594
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AE33 RID: 44595
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AE34 RID: 44596
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AE35 RID: 44597
				private static readonly IntPtr NativeFieldInfoPtr__endXPos_5__2;

				// Token: 0x0400AE36 RID: 44598
				private static readonly IntPtr NativeFieldInfoPtr__startXPos_5__3;

				// Token: 0x0400AE37 RID: 44599
				private static readonly IntPtr NativeFieldInfoPtr__t_5__4;

				// Token: 0x0400AE38 RID: 44600
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AE39 RID: 44601
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AE3A RID: 44602
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AE3B RID: 44603
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AE3C RID: 44604
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AE3D RID: 44605
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000CC6 RID: 3270
		[ObfuscatedName("ScheduleOne.UI.GameplayMenu+<SetIsOpenRoutine>d__35")]
		public sealed class _SetIsOpenRoutine_d__35 : Il2CppSystem.Object
		{
			// Token: 0x0600F4AD RID: 62637 RVA: 0x003AD03C File Offset: 0x003AB23C
			// Note: this type is marked as 'beforefieldinit'.
			static _SetIsOpenRoutine_d__35()
			{
				Il2CppClassPointerStore<GameplayMenu._SetIsOpenRoutine_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "<SetIsOpenRoutine>d__35");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayMenu._SetIsOpenRoutine_d__35>.NativeClassPtr);
				GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu._SetIsOpenRoutine_d__35>.NativeClassPtr, "<>1__state");
				GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu._SetIsOpenRoutine_d__35>.NativeClassPtr, "<>2__current");
				GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr_open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu._SetIsOpenRoutine_d__35>.NativeClassPtr, "open");
				GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu._SetIsOpenRoutine_d__35>.NativeClassPtr, "<>4__this");
				GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr__adjustedLerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu._SetIsOpenRoutine_d__35>.NativeClassPtr, "<adjustedLerpTime>5__2");
				GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr__startVert_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu._SetIsOpenRoutine_d__35>.NativeClassPtr, "<startVert>5__3");
				GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr__endVert_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu._SetIsOpenRoutine_d__35>.NativeClassPtr, "<endVert>5__4");
				GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu._SetIsOpenRoutine_d__35>.NativeClassPtr, "<i>5__5");
				GameplayMenu._SetIsOpenRoutine_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu._SetIsOpenRoutine_d__35>.NativeClassPtr, 100686668);
				GameplayMenu._SetIsOpenRoutine_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu._SetIsOpenRoutine_d__35>.NativeClassPtr, 100686669);
				GameplayMenu._SetIsOpenRoutine_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu._SetIsOpenRoutine_d__35>.NativeClassPtr, 100686670);
				GameplayMenu._SetIsOpenRoutine_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu._SetIsOpenRoutine_d__35>.NativeClassPtr, 100686671);
				GameplayMenu._SetIsOpenRoutine_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu._SetIsOpenRoutine_d__35>.NativeClassPtr, 100686672);
				GameplayMenu._SetIsOpenRoutine_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu._SetIsOpenRoutine_d__35>.NativeClassPtr, 100686673);
			}

			// Token: 0x0600F4AE RID: 62638 RVA: 0x003AD180 File Offset: 0x003AB380
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SetIsOpenRoutine_d__35(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayMenu._SetIsOpenRoutine_d__35>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu._SetIsOpenRoutine_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4AF RID: 62639 RVA: 0x003AD1C8 File Offset: 0x003AB3C8
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu._SetIsOpenRoutine_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4B0 RID: 62640 RVA: 0x003AD1FC File Offset: 0x003AB3FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301112, XrefRangeEnd = 301142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu._SetIsOpenRoutine_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004A57 RID: 19031
			// (get) Token: 0x0600F4B1 RID: 62641 RVA: 0x003AD238 File Offset: 0x003AB438
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu._SetIsOpenRoutine_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F4B2 RID: 62642 RVA: 0x003AD278 File Offset: 0x003AB478
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301142, XrefRangeEnd = 301147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu._SetIsOpenRoutine_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004A58 RID: 19032
			// (get) Token: 0x0600F4B3 RID: 62643 RVA: 0x003AD2AC File Offset: 0x003AB4AC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu._SetIsOpenRoutine_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F4B4 RID: 62644 RVA: 0x000739BE File Offset: 0x00071BBE
			public _SetIsOpenRoutine_d__35(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A4F RID: 19023
			// (get) Token: 0x0600F4B5 RID: 62645 RVA: 0x003AD2EC File Offset: 0x003AB4EC
			// (set) Token: 0x0600F4B6 RID: 62646 RVA: 0x000739C7 File Offset: 0x00071BC7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004A50 RID: 19024
			// (get) Token: 0x0600F4B7 RID: 62647 RVA: 0x003AD314 File Offset: 0x003AB514
			// (set) Token: 0x0600F4B8 RID: 62648 RVA: 0x000739E2 File Offset: 0x00071BE2
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A51 RID: 19025
			// (get) Token: 0x0600F4B9 RID: 62649 RVA: 0x003AD344 File Offset: 0x003AB544
			// (set) Token: 0x0600F4BA RID: 62650 RVA: 0x00073A01 File Offset: 0x00071C01
			public unsafe bool open
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr_open);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr_open)) = value;
				}
			}

			// Token: 0x17004A52 RID: 19026
			// (get) Token: 0x0600F4BB RID: 62651 RVA: 0x003AD36C File Offset: 0x003AB56C
			// (set) Token: 0x0600F4BC RID: 62652 RVA: 0x00073A1C File Offset: 0x00071C1C
			public unsafe GameplayMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameplayMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A53 RID: 19027
			// (get) Token: 0x0600F4BD RID: 62653 RVA: 0x003AD39C File Offset: 0x003AB59C
			// (set) Token: 0x0600F4BE RID: 62654 RVA: 0x00073A3B File Offset: 0x00071C3B
			public unsafe float _adjustedLerpTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr__adjustedLerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr__adjustedLerpTime_5__2)) = value;
				}
			}

			// Token: 0x17004A54 RID: 19028
			// (get) Token: 0x0600F4BF RID: 62655 RVA: 0x003AD3C4 File Offset: 0x003AB5C4
			// (set) Token: 0x0600F4C0 RID: 62656 RVA: 0x00073A56 File Offset: 0x00071C56
			public unsafe float _startVert_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr__startVert_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr__startVert_5__3)) = value;
				}
			}

			// Token: 0x17004A55 RID: 19029
			// (get) Token: 0x0600F4C1 RID: 62657 RVA: 0x003AD3EC File Offset: 0x003AB5EC
			// (set) Token: 0x0600F4C2 RID: 62658 RVA: 0x00073A71 File Offset: 0x00071C71
			public unsafe float _endVert_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr__endVert_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr__endVert_5__4)) = value;
				}
			}

			// Token: 0x17004A56 RID: 19030
			// (get) Token: 0x0600F4C3 RID: 62659 RVA: 0x003AD414 File Offset: 0x003AB614
			// (set) Token: 0x0600F4C4 RID: 62660 RVA: 0x00073A8C File Offset: 0x00071C8C
			public unsafe float _i_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu._SetIsOpenRoutine_d__35.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x0400A5A0 RID: 42400
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A5A1 RID: 42401
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A5A2 RID: 42402
			private static readonly IntPtr NativeFieldInfoPtr_open;

			// Token: 0x0400A5A3 RID: 42403
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A5A4 RID: 42404
			private static readonly IntPtr NativeFieldInfoPtr__adjustedLerpTime_5__2;

			// Token: 0x0400A5A5 RID: 42405
			private static readonly IntPtr NativeFieldInfoPtr__startVert_5__3;

			// Token: 0x0400A5A6 RID: 42406
			private static readonly IntPtr NativeFieldInfoPtr__endVert_5__4;

			// Token: 0x0400A5A7 RID: 42407
			private static readonly IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x0400A5A8 RID: 42408
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A5A9 RID: 42409
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A5AA RID: 42410
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A5AB RID: 42411
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A5AC RID: 42412
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A5AD RID: 42413
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
