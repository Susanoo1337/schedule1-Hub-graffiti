using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000749 RID: 1865
	public class App<T> : PlayerSingleton<T> where T : PlayerSingleton<T>
	{
		// Token: 0x0600B577 RID: 46455 RVA: 0x002F105C File Offset: 0x002EF25C
		// Note: this type is marked as 'beforefieldinit'.
		static App()
		{
			Il2CppClassPointerStore<App<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "App`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<App<T>>.NativeClassPtr);
			App<T>.NativeFieldInfoPtr_Apps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "Apps");
			App<T>.NativeFieldInfoPtr_AppName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "AppName");
			App<T>.NativeFieldInfoPtr_IconLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "IconLabel");
			App<T>.NativeFieldInfoPtr_AppIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "AppIcon");
			App<T>.NativeFieldInfoPtr_Orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "Orientation");
			App<T>.NativeFieldInfoPtr_AvailableInTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "AvailableInTutorial");
			App<T>.NativeFieldInfoPtr_appContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "appContainer");
			App<T>.NativeFieldInfoPtr_notificationContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "notificationContainer");
			App<T>.NativeFieldInfoPtr_notificationText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "notificationText");
			App<T>.NativeFieldInfoPtr__screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "_screen");
			App<T>.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "<isOpen>k__BackingField");
			App<T>.NativeFieldInfoPtr_appIconButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "appIconButton");
			App<T>.NativeMethodInfoPtr_GetApp_Public_Static_App_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100687052);
			App<T>.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100687053);
			App<T>.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100687054);
			App<T>.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100687055);
			App<T>.NativeMethodInfoPtr_AvailableInCurrentScene_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100687056);
			App<T>.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100687057);
			App<T>.NativeMethodInfoPtr_Close_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100687058);
			App<T>.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100687059);
			App<T>.NativeMethodInfoPtr_IsHoveringButton_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100687060);
			App<T>.NativeMethodInfoPtr_GenerateHomeScreenIcon_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100687061);
			App<T>.NativeMethodInfoPtr_SetNotificationCount_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100687062);
			App<T>.NativeMethodInfoPtr_OnPhoneOpened_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100687063);
			App<T>.NativeMethodInfoPtr_ShortcutClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100687064);
			App<T>.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100687065);
			App<T>.NativeMethodInfoPtr_OnExit_Protected_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100687066);
			App<T>.NativeMethodInfoPtr_SetOpen_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100687067);
			App<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100687068);
		}

		// Token: 0x0600B578 RID: 46456 RVA: 0x002F130C File Offset: 0x002EF50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305355, XrefRangeEnd = 305368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static App<T> GetApp(int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_GetApp_Public_Static_App_1_T_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<App<T>>(intPtr3) : null;
		}

		// Token: 0x170036C4 RID: 14020
		// (get) Token: 0x0600B579 RID: 46457 RVA: 0x002F134C File Offset: 0x002EF54C
		// (set) Token: 0x0600B57A RID: 46458 RVA: 0x002F1388 File Offset: 0x002EF588
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B57B RID: 46459 RVA: 0x002F13C8 File Offset: 0x002EF5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305368, XrefRangeEnd = 305375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref IsOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), App<T>.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B57C RID: 46460 RVA: 0x002F1414 File Offset: 0x002EF614
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 305380, RefRangeEnd = 305383, XrefRangeStart = 305375, XrefRangeEnd = 305380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AvailableInCurrentScene()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_AvailableInCurrentScene_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B57D RID: 46461 RVA: 0x002F1450 File Offset: 0x002EF650
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 305421, RefRangeEnd = 305428, XrefRangeStart = 305383, XrefRangeEnd = 305421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), App<T>.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B57E RID: 46462 RVA: 0x002F148C File Offset: 0x002EF68C
		[CallerCount(0)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_Close_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B57F RID: 46463 RVA: 0x002F14C0 File Offset: 0x002EF6C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 305437, RefRangeEnd = 305441, XrefRangeStart = 305428, XrefRangeEnd = 305437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), App<T>.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B580 RID: 46464 RVA: 0x002F14FC File Offset: 0x002EF6FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 305463, RefRangeEnd = 305464, XrefRangeStart = 305441, XrefRangeEnd = 305463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsHoveringButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_IsHoveringButton_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B581 RID: 46465 RVA: 0x002F1538 File Offset: 0x002EF738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305464, XrefRangeEnd = 305493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateHomeScreenIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_GenerateHomeScreenIcon_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B582 RID: 46466 RVA: 0x002F156C File Offset: 0x002EF76C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 305496, RefRangeEnd = 305498, XrefRangeStart = 305493, XrefRangeEnd = 305496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNotificationCount(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_SetNotificationCount_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B583 RID: 46467 RVA: 0x002F15AC File Offset: 0x002EF7AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 305502, RefRangeEnd = 305503, XrefRangeStart = 305498, XrefRangeEnd = 305502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPhoneOpened()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), App<T>.NativeMethodInfoPtr_OnPhoneOpened_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B584 RID: 46468 RVA: 0x002F15E8 File Offset: 0x002EF7E8
		[CallerCount(0)]
		public unsafe void ShortcutClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_ShortcutClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B585 RID: 46469 RVA: 0x002F161C File Offset: 0x002EF81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305503, XrefRangeEnd = 305510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B586 RID: 46470 RVA: 0x002F1660 File Offset: 0x002EF860
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 305511, RefRangeEnd = 305514, XrefRangeStart = 305510, XrefRangeEnd = 305511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnExit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), App<T>.NativeMethodInfoPtr_OnExit_Protected_Virtual_New_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B587 RID: 46471 RVA: 0x002F16B0 File Offset: 0x002EF8B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 305600, RefRangeEnd = 305607, XrefRangeStart = 305514, XrefRangeEnd = 305600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), App<T>.NativeMethodInfoPtr_SetOpen_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B588 RID: 46472 RVA: 0x002F16FC File Offset: 0x002EF8FC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 305608, RefRangeEnd = 305615, XrefRangeStart = 305607, XrefRangeEnd = 305608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe App() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<App<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B589 RID: 46473 RVA: 0x00054022 File Offset: 0x00052222
		public App(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170036B8 RID: 14008
		// (get) Token: 0x0600B58A RID: 46474 RVA: 0x002F1738 File Offset: 0x002EF938
		// (set) Token: 0x0600B58B RID: 46475 RVA: 0x0005402B File Offset: 0x0005222B
		public unsafe static List<App<T>> Apps
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(App<T>.NativeFieldInfoPtr_Apps, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<App<T>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(App<T>.NativeFieldInfoPtr_Apps, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036B9 RID: 14009
		// (get) Token: 0x0600B58C RID: 46476 RVA: 0x002F1760 File Offset: 0x002EF960
		// (set) Token: 0x0600B58D RID: 46477 RVA: 0x0005403D File Offset: 0x0005223D
		public unsafe string AppName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_AppName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_AppName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170036BA RID: 14010
		// (get) Token: 0x0600B58E RID: 46478 RVA: 0x002F1788 File Offset: 0x002EF988
		// (set) Token: 0x0600B58F RID: 46479 RVA: 0x0005405C File Offset: 0x0005225C
		public unsafe string IconLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_IconLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_IconLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170036BB RID: 14011
		// (get) Token: 0x0600B590 RID: 46480 RVA: 0x002F17B0 File Offset: 0x002EF9B0
		// (set) Token: 0x0600B591 RID: 46481 RVA: 0x0005407B File Offset: 0x0005227B
		public unsafe Sprite AppIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_AppIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_AppIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036BC RID: 14012
		// (get) Token: 0x0600B592 RID: 46482 RVA: 0x002F17E0 File Offset: 0x002EF9E0
		// (set) Token: 0x0600B593 RID: 46483 RVA: 0x0005409A File Offset: 0x0005229A
		public unsafe App<T>.EOrientation Orientation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_Orientation);
				return *intPtr;
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_Orientation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<App<T>.EOrientation>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170036BD RID: 14013
		// (get) Token: 0x0600B594 RID: 46484 RVA: 0x002F1808 File Offset: 0x002EFA08
		// (set) Token: 0x0600B595 RID: 46485 RVA: 0x000540C8 File Offset: 0x000522C8
		public unsafe bool AvailableInTutorial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_AvailableInTutorial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_AvailableInTutorial)) = value;
			}
		}

		// Token: 0x170036BE RID: 14014
		// (get) Token: 0x0600B596 RID: 46486 RVA: 0x002F1830 File Offset: 0x002EFA30
		// (set) Token: 0x0600B597 RID: 46487 RVA: 0x000540E3 File Offset: 0x000522E3
		public unsafe RectTransform appContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_appContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_appContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036BF RID: 14015
		// (get) Token: 0x0600B598 RID: 46488 RVA: 0x002F1860 File Offset: 0x002EFA60
		// (set) Token: 0x0600B599 RID: 46489 RVA: 0x00054102 File Offset: 0x00052302
		public unsafe RectTransform notificationContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_notificationContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_notificationContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036C0 RID: 14016
		// (get) Token: 0x0600B59A RID: 46490 RVA: 0x002F1890 File Offset: 0x002EFA90
		// (set) Token: 0x0600B59B RID: 46491 RVA: 0x00054121 File Offset: 0x00052321
		public unsafe Text notificationText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_notificationText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_notificationText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036C1 RID: 14017
		// (get) Token: 0x0600B59C RID: 46492 RVA: 0x002F18C0 File Offset: 0x002EFAC0
		// (set) Token: 0x0600B59D RID: 46493 RVA: 0x00054140 File Offset: 0x00052340
		public unsafe UIScreen _screen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr__screen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr__screen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036C2 RID: 14018
		// (get) Token: 0x0600B59E RID: 46494 RVA: 0x002F18F0 File Offset: 0x002EFAF0
		// (set) Token: 0x0600B59F RID: 46495 RVA: 0x0005415F File Offset: 0x0005235F
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170036C3 RID: 14019
		// (get) Token: 0x0600B5A0 RID: 46496 RVA: 0x002F1918 File Offset: 0x002EFB18
		// (set) Token: 0x0600B5A1 RID: 46497 RVA: 0x0005417A File Offset: 0x0005237A
		public unsafe Button appIconButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_appIconButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_appIconButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007CC8 RID: 31944
		private static readonly IntPtr NativeFieldInfoPtr_Apps;

		// Token: 0x04007CC9 RID: 31945
		private static readonly IntPtr NativeFieldInfoPtr_AppName;

		// Token: 0x04007CCA RID: 31946
		private static readonly IntPtr NativeFieldInfoPtr_IconLabel;

		// Token: 0x04007CCB RID: 31947
		private static readonly IntPtr NativeFieldInfoPtr_AppIcon;

		// Token: 0x04007CCC RID: 31948
		private static readonly IntPtr NativeFieldInfoPtr_Orientation;

		// Token: 0x04007CCD RID: 31949
		private static readonly IntPtr NativeFieldInfoPtr_AvailableInTutorial;

		// Token: 0x04007CCE RID: 31950
		private static readonly IntPtr NativeFieldInfoPtr_appContainer;

		// Token: 0x04007CCF RID: 31951
		private static readonly IntPtr NativeFieldInfoPtr_notificationContainer;

		// Token: 0x04007CD0 RID: 31952
		private static readonly IntPtr NativeFieldInfoPtr_notificationText;

		// Token: 0x04007CD1 RID: 31953
		private static readonly IntPtr NativeFieldInfoPtr__screen;

		// Token: 0x04007CD2 RID: 31954
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04007CD3 RID: 31955
		private static readonly IntPtr NativeFieldInfoPtr_appIconButton;

		// Token: 0x04007CD4 RID: 31956
		private static readonly IntPtr NativeMethodInfoPtr_GetApp_Public_Static_App_1_T_Int32_0;

		// Token: 0x04007CD5 RID: 31957
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04007CD6 RID: 31958
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04007CD7 RID: 31959
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0;

		// Token: 0x04007CD8 RID: 31960
		private static readonly IntPtr NativeMethodInfoPtr_AvailableInCurrentScene_Public_Boolean_0;

		// Token: 0x04007CD9 RID: 31961
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04007CDA RID: 31962
		private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_0;

		// Token: 0x04007CDB RID: 31963
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04007CDC RID: 31964
		private static readonly IntPtr NativeMethodInfoPtr_IsHoveringButton_Private_Boolean_0;

		// Token: 0x04007CDD RID: 31965
		private static readonly IntPtr NativeMethodInfoPtr_GenerateHomeScreenIcon_Private_Void_0;

		// Token: 0x04007CDE RID: 31966
		private static readonly IntPtr NativeMethodInfoPtr_SetNotificationCount_Public_Void_Int32_0;

		// Token: 0x04007CDF RID: 31967
		private static readonly IntPtr NativeMethodInfoPtr_OnPhoneOpened_Protected_Virtual_New_Void_0;

		// Token: 0x04007CE0 RID: 31968
		private static readonly IntPtr NativeMethodInfoPtr_ShortcutClicked_Private_Void_0;

		// Token: 0x04007CE1 RID: 31969
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04007CE2 RID: 31970
		private static readonly IntPtr NativeMethodInfoPtr_OnExit_Protected_Virtual_New_Void_ExitAction_0;

		// Token: 0x04007CE3 RID: 31971
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04007CE4 RID: 31972
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000CDE RID: 3294
		[OriginalName("Assembly-CSharp.dll", "", "EOrientation")]
		public enum EOrientation
		{
			// Token: 0x0400A63C RID: 42556
			Horizontal,
			// Token: 0x0400A63D RID: 42557
			Vertical
		}
	}
}
