using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

namespace Il2CppScheduleOne
{
	// Token: 0x020000B0 RID: 176
	public class UIScreenManager : PersistentSingleton<UIScreenManager>
	{
		// Token: 0x06000FC1 RID: 4033 RVA: 0x000AFC80 File Offset: 0x000ADE80
		// Note: this type is marked as 'beforefieldinit'.
		static UIScreenManager()
		{
			Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "UIScreenManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr);
			UIScreenManager.NativeFieldInfoPtr_NavigationRepeatDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, "NavigationRepeatDelay");
			UIScreenManager.NativeFieldInfoPtr_NavigationRepeatRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, "NavigationRepeatRate");
			UIScreenManager.NativeFieldInfoPtr_DefaultScrollSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, "DefaultScrollSpeed");
			UIScreenManager.NativeFieldInfoPtr_ScrollbarScrollSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, "ScrollbarScrollSpeed");
			UIScreenManager.NativeFieldInfoPtr_NavigationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, "NavigationThreshold");
			UIScreenManager.NativeFieldInfoPtr_popupScreenPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, "popupScreenPrefabs");
			UIScreenManager.NativeFieldInfoPtr_submitInputAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, "submitInputAction");
			UIScreenManager.NativeFieldInfoPtr_backInputAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, "backInputAction");
			UIScreenManager.NativeFieldInfoPtr_escapeInputAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, "escapeInputAction");
			UIScreenManager.NativeFieldInfoPtr_popupScreenInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, "popupScreenInstances");
			UIScreenManager.NativeFieldInfoPtr_screenStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, "screenStack");
			UIScreenManager.NativeFieldInfoPtr_lastSelectedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, "lastSelectedObject");
			UIScreenManager.NativeFieldInfoPtr_isBackTriggeredThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, "isBackTriggeredThisFrame");
			UIScreenManager.NativeMethodInfoPtr_get_SubmitInputAction_Public_get_InputActionReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665293);
			UIScreenManager.NativeMethodInfoPtr_get_TopScreen_Public_get_UIScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665294);
			UIScreenManager.NativeMethodInfoPtr_get_HasActiveScreen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665295);
			UIScreenManager.NativeMethodInfoPtr_get_LastSelectedObject_Public_Static_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665296);
			UIScreenManager.NativeMethodInfoPtr_set_LastSelectedObject_Public_Static_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665297);
			UIScreenManager.NativeMethodInfoPtr_get_IsBackTriggeredThisFrame_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665298);
			UIScreenManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665299);
			UIScreenManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665300);
			UIScreenManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665301);
			UIScreenManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665302);
			UIScreenManager.NativeMethodInfoPtr_BackToCloseCurrentScreen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665303);
			UIScreenManager.NativeMethodInfoPtr_IsActiveScreenRegisteredForBack_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665304);
			UIScreenManager.NativeMethodInfoPtr_HandleInputDeviceChanged_Private_Void_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665305);
			UIScreenManager.NativeMethodInfoPtr_CheckInputDeviceMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665306);
			UIScreenManager.NativeMethodInfoPtr_OnSceneLoaded_Private_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665307);
			UIScreenManager.NativeMethodInfoPtr_AddScreen_Public_Void_UIScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665308);
			UIScreenManager.NativeMethodInfoPtr_AddScreen_Public_Void_UIScreen_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665309);
			UIScreenManager.NativeMethodInfoPtr_RemoveScreen_Public_Void_UIScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665310);
			UIScreenManager.NativeMethodInfoPtr_IsScreenInStack_Private_Boolean_UIScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665311);
			UIScreenManager.NativeMethodInfoPtr_IsAnyScreenActive_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665312);
			UIScreenManager.NativeMethodInfoPtr_IsAnyPopupScreenActive_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665313);
			UIScreenManager.NativeMethodInfoPtr_OpenPopupScreen_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665314);
			UIScreenManager.NativeMethodInfoPtr_OpenPopupScreen_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665315);
			UIScreenManager.NativeMethodInfoPtr_ClosePopupScreen_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665316);
			UIScreenManager.NativeMethodInfoPtr_FindPopupScreen_Private_UIPopupScreen_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665317);
			UIScreenManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, 100665318);
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x000AFFBC File Offset: 0x000AE1BC
		public unsafe InputActionReference SubmitInputAction
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr_get_SubmitInputAction_Public_get_InputActionReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr3) : null;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x000AFFFC File Offset: 0x000AE1FC
		public unsafe UIScreen TopScreen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83923, RefRangeEnd = 83924, XrefRangeStart = 83920, XrefRangeEnd = 83923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr_get_TopScreen_Public_get_UIScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr3) : null;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x000B003C File Offset: 0x000AE23C
		public unsafe bool HasActiveScreen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83925, RefRangeEnd = 83926, XrefRangeStart = 83924, XrefRangeEnd = 83925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr_get_HasActiveScreen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x000B0078 File Offset: 0x000AE278
		// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x000B00AC File Offset: 0x000AE2AC
		public unsafe static GameObject LastSelectedObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83926, XrefRangeEnd = 83928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr_get_LastSelectedObject_Public_Static_get_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 83949, RefRangeEnd = 83958, XrefRangeStart = 83928, XrefRangeEnd = 83949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr_set_LastSelectedObject_Public_Static_set_Void_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x000B00E4 File Offset: 0x000AE2E4
		public unsafe static bool IsBackTriggeredThisFrame
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83958, XrefRangeEnd = 83960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr_get_IsBackTriggeredThisFrame_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x000B0114 File Offset: 0x000AE314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83960, XrefRangeEnd = 84004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIScreenManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x000B0150 File Offset: 0x000AE350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84004, XrefRangeEnd = 84039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIScreenManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x000B018C File Offset: 0x000AE38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84039, XrefRangeEnd = 84040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x000B01C0 File Offset: 0x000AE3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84040, XrefRangeEnd = 84042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x000B01F4 File Offset: 0x000AE3F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84081, RefRangeEnd = 84082, XrefRangeStart = 84042, XrefRangeEnd = 84081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BackToCloseCurrentScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr_BackToCloseCurrentScreen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x000B0228 File Offset: 0x000AE428
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84090, RefRangeEnd = 84091, XrefRangeStart = 84082, XrefRangeEnd = 84090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsActiveScreenRegisteredForBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr_IsActiveScreenRegisteredForBack_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x000B0264 File Offset: 0x000AE464
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84121, RefRangeEnd = 84124, XrefRangeStart = 84091, XrefRangeEnd = 84121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleInputDeviceChanged(GameInput.InputDeviceType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr_HandleInputDeviceChanged_Private_Void_InputDeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x000B02A4 File Offset: 0x000AE4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84124, XrefRangeEnd = 84132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckInputDeviceMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr_CheckInputDeviceMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x000B02D8 File Offset: 0x000AE4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84132, XrefRangeEnd = 84140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref scene;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr_OnSceneLoaded_Private_Void_Scene_LoadSceneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x000B0324 File Offset: 0x000AE524
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 84141, RefRangeEnd = 84165, XrefRangeStart = 84140, XrefRangeEnd = 84141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScreen(UIScreen screen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(screen);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr_AddScreen_Public_Void_UIScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x000B0368 File Offset: 0x000AE568
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 84189, RefRangeEnd = 84197, XrefRangeStart = 84165, XrefRangeEnd = 84189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScreen(UIScreen screen, Action onCloseCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(screen);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onCloseCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr_AddScreen_Public_Void_UIScreen_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x000B03BC File Offset: 0x000AE5BC
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 84258, RefRangeEnd = 84291, XrefRangeStart = 84197, XrefRangeEnd = 84258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveScreen(UIScreen screen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(screen);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr_RemoveScreen_Public_Void_UIScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x000B0400 File Offset: 0x000AE600
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84307, RefRangeEnd = 84310, XrefRangeStart = 84291, XrefRangeEnd = 84307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsScreenInStack(UIScreen screen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(screen);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr_IsScreenInStack_Private_Boolean_UIScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x000B0450 File Offset: 0x000AE650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84310, XrefRangeEnd = 84311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAnyScreenActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr_IsAnyScreenActive_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x000B048C File Offset: 0x000AE68C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84311, XrefRangeEnd = 84330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAnyPopupScreenActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr_IsAnyPopupScreenActive_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x000B04C8 File Offset: 0x000AE6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84330, XrefRangeEnd = 84341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenPopupScreen(string popupID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(popupID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr_OpenPopupScreen_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x000B050C File Offset: 0x000AE70C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 84346, RefRangeEnd = 84350, XrefRangeStart = 84341, XrefRangeEnd = 84346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenPopupScreen(string popupID, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(popupID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr_OpenPopupScreen_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x000B0570 File Offset: 0x000AE770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84350, XrefRangeEnd = 84368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClosePopupScreen(string popupID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(popupID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr_ClosePopupScreen_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x000B05B4 File Offset: 0x000AE7B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84409, RefRangeEnd = 84412, XrefRangeStart = 84368, XrefRangeEnd = 84409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIPopupScreen FindPopupScreen(string popupID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(popupID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr_FindPopupScreen_Private_UIPopupScreen_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIPopupScreen>(intPtr3) : null;
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x000B0604 File Offset: 0x000AE804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84412, XrefRangeEnd = 84429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIScreenManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x000094DC File Offset: 0x000076DC
		public void OpenPopupScreen(string popupID, params Il2CppSystem.Object[] args)
		{
			this.OpenPopupScreen(popupID, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x000094EB File Offset: 0x000076EB
		public UIScreenManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x000B0640 File Offset: 0x000AE840
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x000094F4 File Offset: 0x000076F4
		public unsafe static float NavigationRepeatDelay
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UIScreenManager.NativeFieldInfoPtr_NavigationRepeatDelay, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIScreenManager.NativeFieldInfoPtr_NavigationRepeatDelay, (void*)(&value));
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x000B065C File Offset: 0x000AE85C
		// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x00009502 File Offset: 0x00007702
		public unsafe static float NavigationRepeatRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UIScreenManager.NativeFieldInfoPtr_NavigationRepeatRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIScreenManager.NativeFieldInfoPtr_NavigationRepeatRate, (void*)(&value));
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x000B0678 File Offset: 0x000AE878
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x00009510 File Offset: 0x00007710
		public unsafe static float DefaultScrollSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UIScreenManager.NativeFieldInfoPtr_DefaultScrollSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIScreenManager.NativeFieldInfoPtr_DefaultScrollSpeed, (void*)(&value));
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x000B0694 File Offset: 0x000AE894
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x0000951E File Offset: 0x0000771E
		public unsafe static float ScrollbarScrollSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UIScreenManager.NativeFieldInfoPtr_ScrollbarScrollSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIScreenManager.NativeFieldInfoPtr_ScrollbarScrollSpeed, (void*)(&value));
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x000B06B0 File Offset: 0x000AE8B0
		// (set) Token: 0x06000FE7 RID: 4071 RVA: 0x0000952C File Offset: 0x0000772C
		public unsafe static float NavigationThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UIScreenManager.NativeFieldInfoPtr_NavigationThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIScreenManager.NativeFieldInfoPtr_NavigationThreshold, (void*)(&value));
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x000B06CC File Offset: 0x000AE8CC
		// (set) Token: 0x06000FE9 RID: 4073 RVA: 0x0000953A File Offset: 0x0000773A
		public unsafe Il2CppReferenceArray<UIPopupScreen> popupScreenPrefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenManager.NativeFieldInfoPtr_popupScreenPrefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UIPopupScreen>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenManager.NativeFieldInfoPtr_popupScreenPrefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000FEA RID: 4074 RVA: 0x000B06FC File Offset: 0x000AE8FC
		// (set) Token: 0x06000FEB RID: 4075 RVA: 0x00009559 File Offset: 0x00007759
		public unsafe InputActionReference submitInputAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenManager.NativeFieldInfoPtr_submitInputAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenManager.NativeFieldInfoPtr_submitInputAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x000B072C File Offset: 0x000AE92C
		// (set) Token: 0x06000FED RID: 4077 RVA: 0x00009578 File Offset: 0x00007778
		public unsafe InputActionReference backInputAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenManager.NativeFieldInfoPtr_backInputAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenManager.NativeFieldInfoPtr_backInputAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x000B075C File Offset: 0x000AE95C
		// (set) Token: 0x06000FEF RID: 4079 RVA: 0x00009597 File Offset: 0x00007797
		public unsafe InputActionReference escapeInputAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenManager.NativeFieldInfoPtr_escapeInputAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenManager.NativeFieldInfoPtr_escapeInputAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x000B078C File Offset: 0x000AE98C
		// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x000095B6 File Offset: 0x000077B6
		public unsafe List<UIPopupScreen> popupScreenInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenManager.NativeFieldInfoPtr_popupScreenInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIPopupScreen>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenManager.NativeFieldInfoPtr_popupScreenInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x000B07BC File Offset: 0x000AE9BC
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x000095D5 File Offset: 0x000077D5
		public unsafe Stack<UIScreenManager.UIScreenInfo> screenStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenManager.NativeFieldInfoPtr_screenStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<UIScreenManager.UIScreenInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenManager.NativeFieldInfoPtr_screenStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x000B07EC File Offset: 0x000AE9EC
		// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x000095F4 File Offset: 0x000077F4
		public unsafe static GameObject lastSelectedObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIScreenManager.NativeFieldInfoPtr_lastSelectedObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIScreenManager.NativeFieldInfoPtr_lastSelectedObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x000B0814 File Offset: 0x000AEA14
		// (set) Token: 0x06000FF7 RID: 4087 RVA: 0x00009606 File Offset: 0x00007806
		public unsafe static bool isBackTriggeredThisFrame
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(UIScreenManager.NativeFieldInfoPtr_isBackTriggeredThisFrame, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIScreenManager.NativeFieldInfoPtr_isBackTriggeredThisFrame, (void*)(&value));
			}
		}

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeFieldInfoPtr_NavigationRepeatDelay;

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeFieldInfoPtr_NavigationRepeatRate;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeFieldInfoPtr_DefaultScrollSpeed;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeFieldInfoPtr_ScrollbarScrollSpeed;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeFieldInfoPtr_NavigationThreshold;

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeFieldInfoPtr_popupScreenPrefabs;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeFieldInfoPtr_submitInputAction;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeFieldInfoPtr_backInputAction;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeFieldInfoPtr_escapeInputAction;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeFieldInfoPtr_popupScreenInstances;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeFieldInfoPtr_screenStack;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeFieldInfoPtr_lastSelectedObject;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeFieldInfoPtr_isBackTriggeredThisFrame;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeMethodInfoPtr_get_SubmitInputAction_Public_get_InputActionReference_0;

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeMethodInfoPtr_get_TopScreen_Public_get_UIScreen_0;

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeMethodInfoPtr_get_HasActiveScreen_Public_get_Boolean_0;

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeMethodInfoPtr_get_LastSelectedObject_Public_Static_get_GameObject_0;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeMethodInfoPtr_set_LastSelectedObject_Public_Static_set_Void_GameObject_0;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBackTriggeredThisFrame_Public_Static_get_Boolean_0;

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeMethodInfoPtr_BackToCloseCurrentScreen_Private_Void_0;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeMethodInfoPtr_IsActiveScreenRegisteredForBack_Public_Boolean_0;

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeMethodInfoPtr_HandleInputDeviceChanged_Private_Void_InputDeviceType_0;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeMethodInfoPtr_CheckInputDeviceMode_Private_Void_0;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeMethodInfoPtr_OnSceneLoaded_Private_Void_Scene_LoadSceneMode_0;

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeMethodInfoPtr_AddScreen_Public_Void_UIScreen_0;

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeMethodInfoPtr_AddScreen_Public_Void_UIScreen_Action_0;

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeMethodInfoPtr_RemoveScreen_Public_Void_UIScreen_0;

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeMethodInfoPtr_IsScreenInStack_Private_Boolean_UIScreen_0;

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeMethodInfoPtr_IsAnyScreenActive_Public_Boolean_0;

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeMethodInfoPtr_IsAnyPopupScreenActive_Public_Boolean_0;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeMethodInfoPtr_OpenPopupScreen_Public_Void_String_0;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeMethodInfoPtr_OpenPopupScreen_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeMethodInfoPtr_ClosePopupScreen_Public_Void_String_0;

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeMethodInfoPtr_FindPopupScreen_Private_UIPopupScreen_String_0;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008C7 RID: 2247
		public sealed class UIScreenInfo : ValueType
		{
			// Token: 0x0600D4E0 RID: 54496 RVA: 0x0034FCB0 File Offset: 0x0034DEB0
			// Note: this type is marked as 'beforefieldinit'.
			static UIScreenInfo()
			{
				Il2CppClassPointerStore<UIScreenManager.UIScreenInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, "UIScreenInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIScreenManager.UIScreenInfo>.NativeClassPtr);
				UIScreenManager.UIScreenInfo.NativeFieldInfoPtr_screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreenManager.UIScreenInfo>.NativeClassPtr, "screen");
				UIScreenManager.UIScreenInfo.NativeFieldInfoPtr_onCloseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreenManager.UIScreenInfo>.NativeClassPtr, "onCloseCallback");
			}

			// Token: 0x0600D4E1 RID: 54497 RVA: 0x00064B7F File Offset: 0x00062D7F
			public UIScreenInfo(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D4E2 RID: 54498 RVA: 0x00064B88 File Offset: 0x00062D88
			public UIScreenInfo() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIScreenManager.UIScreenInfo>.NativeClassPtr))
			{
			}

			// Token: 0x170040D2 RID: 16594
			// (get) Token: 0x0600D4E3 RID: 54499 RVA: 0x0034FD04 File Offset: 0x0034DF04
			// (set) Token: 0x0600D4E4 RID: 54500 RVA: 0x00064B9A File Offset: 0x00062D9A
			public unsafe UIScreen screen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenManager.UIScreenInfo.NativeFieldInfoPtr_screen);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenManager.UIScreenInfo.NativeFieldInfoPtr_screen), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040D3 RID: 16595
			// (get) Token: 0x0600D4E5 RID: 54501 RVA: 0x0034FD34 File Offset: 0x0034DF34
			// (set) Token: 0x0600D4E6 RID: 54502 RVA: 0x00064BB9 File Offset: 0x00062DB9
			public unsafe Action onCloseCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenManager.UIScreenInfo.NativeFieldInfoPtr_onCloseCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenManager.UIScreenInfo.NativeFieldInfoPtr_onCloseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090F6 RID: 37110
			private static readonly IntPtr NativeFieldInfoPtr_screen;

			// Token: 0x040090F7 RID: 37111
			private static readonly IntPtr NativeFieldInfoPtr_onCloseCallback;
		}

		// Token: 0x020008C8 RID: 2248
		[ObfuscatedName("ScheduleOne.UIScreenManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D4E7 RID: 54503 RVA: 0x0034FD64 File Offset: 0x0034DF64
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UIScreenManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIScreenManager.__c>.NativeClassPtr);
				UIScreenManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreenManager.__c>.NativeClassPtr, "<>9");
				UIScreenManager.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreenManager.__c>.NativeClassPtr, "<>9__39_0");
				UIScreenManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager.__c>.NativeClassPtr, 100665320);
				UIScreenManager.__c.NativeMethodInfoPtr__IsAnyPopupScreenActive_b__39_0_Internal_Boolean_UIPopupScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager.__c>.NativeClassPtr, 100665321);
			}

			// Token: 0x0600D4E8 RID: 54504 RVA: 0x0034FDE0 File Offset: 0x0034DFE0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIScreenManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4E9 RID: 54505 RVA: 0x0034FE1C File Offset: 0x0034E01C
			[CallerCount(0)]
			public unsafe bool _IsAnyPopupScreenActive_b__39_0(UIPopupScreen p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.__c.NativeMethodInfoPtr__IsAnyPopupScreenActive_b__39_0_Internal_Boolean_UIPopupScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D4EA RID: 54506 RVA: 0x00064BD8 File Offset: 0x00062DD8
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040D4 RID: 16596
			// (get) Token: 0x0600D4EB RID: 54507 RVA: 0x0034FE6C File Offset: 0x0034E06C
			// (set) Token: 0x0600D4EC RID: 54508 RVA: 0x00064BE1 File Offset: 0x00062DE1
			public unsafe static UIScreenManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIScreenManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreenManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIScreenManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040D5 RID: 16597
			// (get) Token: 0x0600D4ED RID: 54509 RVA: 0x0034FE94 File Offset: 0x0034E094
			// (set) Token: 0x0600D4EE RID: 54510 RVA: 0x00064BF3 File Offset: 0x00062DF3
			public unsafe static Predicate<UIPopupScreen> __9__39_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIScreenManager.__c.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<UIPopupScreen>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIScreenManager.__c.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090F8 RID: 37112
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040090F9 RID: 37113
			private static readonly IntPtr NativeFieldInfoPtr___9__39_0;

			// Token: 0x040090FA RID: 37114
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090FB RID: 37115
			private static readonly IntPtr NativeMethodInfoPtr__IsAnyPopupScreenActive_b__39_0_Internal_Boolean_UIPopupScreen_0;
		}

		// Token: 0x020008C9 RID: 2249
		[ObfuscatedName("ScheduleOne.UIScreenManager+<>c__DisplayClass42_0")]
		public sealed class __c__DisplayClass42_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4EF RID: 54511 RVA: 0x0034FEBC File Offset: 0x0034E0BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass42_0()
			{
				Il2CppClassPointerStore<UIScreenManager.__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, "<>c__DisplayClass42_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIScreenManager.__c__DisplayClass42_0>.NativeClassPtr);
				UIScreenManager.__c__DisplayClass42_0.NativeFieldInfoPtr_popupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreenManager.__c__DisplayClass42_0>.NativeClassPtr, "popupID");
				UIScreenManager.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager.__c__DisplayClass42_0>.NativeClassPtr, 100665322);
				UIScreenManager.__c__DisplayClass42_0.NativeMethodInfoPtr__ClosePopupScreen_b__0_Internal_Boolean_UIPopupScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager.__c__DisplayClass42_0>.NativeClassPtr, 100665323);
			}

			// Token: 0x0600D4F0 RID: 54512 RVA: 0x0034FF24 File Offset: 0x0034E124
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass42_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIScreenManager.__c__DisplayClass42_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4F1 RID: 54513 RVA: 0x0034FF60 File Offset: 0x0034E160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83918, XrefRangeEnd = 83920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ClosePopupScreen_b__0(UIPopupScreen p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.__c__DisplayClass42_0.NativeMethodInfoPtr__ClosePopupScreen_b__0_Internal_Boolean_UIPopupScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D4F2 RID: 54514 RVA: 0x00064C05 File Offset: 0x00062E05
			public __c__DisplayClass42_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040D6 RID: 16598
			// (get) Token: 0x0600D4F3 RID: 54515 RVA: 0x0034FFB0 File Offset: 0x0034E1B0
			// (set) Token: 0x0600D4F4 RID: 54516 RVA: 0x00064C0E File Offset: 0x00062E0E
			public unsafe string popupID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenManager.__c__DisplayClass42_0.NativeFieldInfoPtr_popupID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenManager.__c__DisplayClass42_0.NativeFieldInfoPtr_popupID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040090FC RID: 37116
			private static readonly IntPtr NativeFieldInfoPtr_popupID;

			// Token: 0x040090FD RID: 37117
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090FE RID: 37118
			private static readonly IntPtr NativeMethodInfoPtr__ClosePopupScreen_b__0_Internal_Boolean_UIPopupScreen_0;
		}

		// Token: 0x020008CA RID: 2250
		[ObfuscatedName("ScheduleOne.UIScreenManager+<>c__DisplayClass43_0")]
		public sealed class __c__DisplayClass43_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4F5 RID: 54517 RVA: 0x0034FFD8 File Offset: 0x0034E1D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass43_0()
			{
				Il2CppClassPointerStore<UIScreenManager.__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIScreenManager>.NativeClassPtr, "<>c__DisplayClass43_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIScreenManager.__c__DisplayClass43_0>.NativeClassPtr);
				UIScreenManager.__c__DisplayClass43_0.NativeFieldInfoPtr_popupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreenManager.__c__DisplayClass43_0>.NativeClassPtr, "popupID");
				UIScreenManager.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager.__c__DisplayClass43_0>.NativeClassPtr, 100665324);
				UIScreenManager.__c__DisplayClass43_0.NativeMethodInfoPtr__FindPopupScreen_b__0_Internal_Boolean_UIPopupScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager.__c__DisplayClass43_0>.NativeClassPtr, 100665325);
				UIScreenManager.__c__DisplayClass43_0.NativeMethodInfoPtr__FindPopupScreen_b__1_Internal_Boolean_UIPopupScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreenManager.__c__DisplayClass43_0>.NativeClassPtr, 100665326);
			}

			// Token: 0x0600D4F6 RID: 54518 RVA: 0x00350054 File Offset: 0x0034E254
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass43_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIScreenManager.__c__DisplayClass43_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4F7 RID: 54519 RVA: 0x00350090 File Offset: 0x0034E290
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FindPopupScreen_b__0(UIPopupScreen p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.__c__DisplayClass43_0.NativeMethodInfoPtr__FindPopupScreen_b__0_Internal_Boolean_UIPopupScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D4F8 RID: 54520 RVA: 0x003500E0 File Offset: 0x0034E2E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FindPopupScreen_b__1(UIPopupScreen p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreenManager.__c__DisplayClass43_0.NativeMethodInfoPtr__FindPopupScreen_b__1_Internal_Boolean_UIPopupScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D4F9 RID: 54521 RVA: 0x00064C2D File Offset: 0x00062E2D
			public __c__DisplayClass43_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040D7 RID: 16599
			// (get) Token: 0x0600D4FA RID: 54522 RVA: 0x00350130 File Offset: 0x0034E330
			// (set) Token: 0x0600D4FB RID: 54523 RVA: 0x00064C36 File Offset: 0x00062E36
			public unsafe string popupID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenManager.__c__DisplayClass43_0.NativeFieldInfoPtr_popupID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreenManager.__c__DisplayClass43_0.NativeFieldInfoPtr_popupID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040090FF RID: 37119
			private static readonly IntPtr NativeFieldInfoPtr_popupID;

			// Token: 0x04009100 RID: 37120
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009101 RID: 37121
			private static readonly IntPtr NativeMethodInfoPtr__FindPopupScreen_b__0_Internal_Boolean_UIPopupScreen_0;

			// Token: 0x04009102 RID: 37122
			private static readonly IntPtr NativeMethodInfoPtr__FindPopupScreen_b__1_Internal_Boolean_UIPopupScreen_0;
		}
	}
}
