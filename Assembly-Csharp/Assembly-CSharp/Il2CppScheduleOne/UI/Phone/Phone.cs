using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.State;
using Il2CppScheduleOne.Vision;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020007AC RID: 1964
	public class Phone : PlayerSingleton<Phone>
	{
		// Token: 0x0600BEA6 RID: 48806 RVA: 0x0030CD20 File Offset: 0x0030AF20
		// Note: this type is marked as 'beforefieldinit'.
		static Phone()
		{
			Il2CppClassPointerStore<Phone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "Phone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Phone>.NativeClassPtr);
			Phone.NativeFieldInfoPtr_MinLookOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "MinLookOffset");
			Phone.NativeFieldInfoPtr_MaxLookOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "MaxLookOffset");
			Phone.NativeFieldInfoPtr_RotationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "RotationTime");
			Phone.NativeFieldInfoPtr_ActiveApp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "ActiveApp");
			Phone.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<IsOpen>k__BackingField");
			Phone.NativeFieldInfoPtr__isHorizontal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<isHorizontal>k__BackingField");
			Phone.NativeFieldInfoPtr__isOpenable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<isOpenable>k__BackingField");
			Phone.NativeFieldInfoPtr__FlashlightOn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<FlashlightOn>k__BackingField");
			Phone.NativeFieldInfoPtr_phoneModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "phoneModel");
			Phone.NativeFieldInfoPtr_orientation_Vertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "orientation_Vertical");
			Phone.NativeFieldInfoPtr_orientation_Horizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "orientation_Horizontal");
			Phone.NativeFieldInfoPtr_raycaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "raycaster");
			Phone.NativeFieldInfoPtr_PhoneFlashlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "PhoneFlashlight");
			Phone.NativeFieldInfoPtr_FlashlightToggleSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "FlashlightToggleSound");
			Phone.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "state");
			Phone.NativeFieldInfoPtr__generalColorFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "_generalColorFont");
			Phone.NativeFieldInfoPtr__productColorFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "_productColorFont");
			Phone.NativeFieldInfoPtr__toggleFlashlightInputAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "_toggleFlashlightInputAction");
			Phone.NativeFieldInfoPtr_onPhoneOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "onPhoneOpened");
			Phone.NativeFieldInfoPtr_onPhoneClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "onPhoneClosed");
			Phone.NativeFieldInfoPtr_closeApps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "closeApps");
			Phone.NativeFieldInfoPtr_eventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "eventSystem");
			Phone.NativeFieldInfoPtr_flashlightVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "flashlightVisibility");
			Phone.NativeFieldInfoPtr_rotationCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "rotationCoroutine");
			Phone.NativeFieldInfoPtr_lookOffsetCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "lookOffsetCoroutine");
			Phone.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688167);
			Phone.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688168);
			Phone.NativeMethodInfoPtr_get_isHorizontal_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688169);
			Phone.NativeMethodInfoPtr_set_isHorizontal_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688170);
			Phone.NativeMethodInfoPtr_get_isOpenable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688171);
			Phone.NativeMethodInfoPtr_set_isOpenable_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688172);
			Phone.NativeMethodInfoPtr_get_FlashlightOn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688173);
			Phone.NativeMethodInfoPtr_set_FlashlightOn_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688174);
			Phone.NativeMethodInfoPtr_get_IsAnyAppOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688175);
			Phone.NativeMethodInfoPtr_get_State_Public_get_MonoState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688176);
			Phone.NativeMethodInfoPtr_get_ScaledLookOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688177);
			Phone.NativeMethodInfoPtr_get_GeneralColorFont_Public_get_ColorFont_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688178);
			Phone.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688179);
			Phone.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688180);
			Phone.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688181);
			Phone.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688182);
			Phone.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688183);
			Phone.NativeMethodInfoPtr_ToggleFlashlight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688184);
			Phone.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688185);
			Phone.NativeMethodInfoPtr_SetIsActiveGameplayScreen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688186);
			Phone.NativeMethodInfoPtr_SetIsHorizontal_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688187);
			Phone.NativeMethodInfoPtr_SetIsHorizontal_Process_Protected_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688188);
			Phone.NativeMethodInfoPtr_SetLookOffsetMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688189);
			Phone.NativeMethodInfoPtr_RequestCloseApp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688190);
			Phone.NativeMethodInfoPtr_SetLookOffset_Process_Protected_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688191);
			Phone.NativeMethodInfoPtr_MouseRaycast_Public_Boolean_byref_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688192);
			Phone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100688193);
		}

		// Token: 0x170039B0 RID: 14768
		// (get) Token: 0x0600BEA7 RID: 48807 RVA: 0x0030D160 File Offset: 0x0030B360
		// (set) Token: 0x0600BEA8 RID: 48808 RVA: 0x0030D19C File Offset: 0x0030B39C
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170039B1 RID: 14769
		// (get) Token: 0x0600BEA9 RID: 48809 RVA: 0x0030D1DC File Offset: 0x0030B3DC
		// (set) Token: 0x0600BEAA RID: 48810 RVA: 0x0030D218 File Offset: 0x0030B418
		public unsafe bool isHorizontal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_get_isHorizontal_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_set_isHorizontal_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170039B2 RID: 14770
		// (get) Token: 0x0600BEAB RID: 48811 RVA: 0x0030D258 File Offset: 0x0030B458
		// (set) Token: 0x0600BEAC RID: 48812 RVA: 0x0030D294 File Offset: 0x0030B494
		public unsafe bool isOpenable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_get_isOpenable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_set_isOpenable_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170039B3 RID: 14771
		// (get) Token: 0x0600BEAD RID: 48813 RVA: 0x0030D2D4 File Offset: 0x0030B4D4
		// (set) Token: 0x0600BEAE RID: 48814 RVA: 0x0030D310 File Offset: 0x0030B510
		public unsafe bool FlashlightOn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_get_FlashlightOn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_set_FlashlightOn_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170039B4 RID: 14772
		// (get) Token: 0x0600BEAF RID: 48815 RVA: 0x0030D350 File Offset: 0x0030B550
		public unsafe bool IsAnyAppOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 317263, RefRangeEnd = 317264, XrefRangeStart = 317257, XrefRangeEnd = 317263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_get_IsAnyAppOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170039B5 RID: 14773
		// (get) Token: 0x0600BEB0 RID: 48816 RVA: 0x0030D38C File Offset: 0x0030B58C
		public unsafe MonoState State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_get_State_Public_get_MonoState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr3) : null;
			}
		}

		// Token: 0x170039B6 RID: 14774
		// (get) Token: 0x0600BEB1 RID: 48817 RVA: 0x0030D3CC File Offset: 0x0030B5CC
		public unsafe float ScaledLookOffset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317264, XrefRangeEnd = 317269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_get_ScaledLookOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170039B7 RID: 14775
		// (get) Token: 0x0600BEB2 RID: 48818 RVA: 0x0030D408 File Offset: 0x0030B608
		public unsafe ColorFont GeneralColorFont
		{
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 43093, RefRangeEnd = 43137, XrefRangeStart = 43093, XrefRangeEnd = 43137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_get_GeneralColorFont_Public_get_ColorFont_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ColorFont>(intPtr3) : null;
			}
		}

		// Token: 0x0600BEB3 RID: 48819 RVA: 0x0030D448 File Offset: 0x0030B648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317269, XrefRangeEnd = 317277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Phone.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BEB4 RID: 48820 RVA: 0x0030D484 File Offset: 0x0030B684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317277, XrefRangeEnd = 317285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref IsOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Phone.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BEB5 RID: 48821 RVA: 0x0030D4D0 File Offset: 0x0030B6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317285, XrefRangeEnd = 317298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Phone.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BEB6 RID: 48822 RVA: 0x0030D50C File Offset: 0x0030B70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317298, XrefRangeEnd = 317337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Phone.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BEB7 RID: 48823 RVA: 0x0030D548 File Offset: 0x0030B748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317337, XrefRangeEnd = 317344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Phone.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BEB8 RID: 48824 RVA: 0x0030D584 File Offset: 0x0030B784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317344, XrefRangeEnd = 317353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleFlashlight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_ToggleFlashlight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BEB9 RID: 48825 RVA: 0x0030D5B8 File Offset: 0x0030B7B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 317372, RefRangeEnd = 317376, XrefRangeStart = 317353, XrefRangeEnd = 317372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref o;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BEBA RID: 48826 RVA: 0x0030D5F8 File Offset: 0x0030B7F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317379, RefRangeEnd = 317381, XrefRangeStart = 317376, XrefRangeEnd = 317379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsActiveGameplayScreen(bool isActive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isActive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetIsActiveGameplayScreen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BEBB RID: 48827 RVA: 0x0030D638 File Offset: 0x0030B838
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317389, RefRangeEnd = 317391, XrefRangeStart = 317381, XrefRangeEnd = 317389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsHorizontal(bool h)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetIsHorizontal_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BEBC RID: 48828 RVA: 0x0030D678 File Offset: 0x0030B878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317391, XrefRangeEnd = 317396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SetIsHorizontal_Process(bool h)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetIsHorizontal_Process_Protected_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600BEBD RID: 48829 RVA: 0x0030D6C4 File Offset: 0x0030B8C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317409, RefRangeEnd = 317412, XrefRangeStart = 317396, XrefRangeEnd = 317409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLookOffsetMultiplier(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetLookOffsetMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BEBE RID: 48830 RVA: 0x0030D704 File Offset: 0x0030B904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317418, RefRangeEnd = 317419, XrefRangeStart = 317412, XrefRangeEnd = 317418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestCloseApp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_RequestCloseApp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BEBF RID: 48831 RVA: 0x0030D738 File Offset: 0x0030B938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317419, XrefRangeEnd = 317424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SetLookOffset_Process(float lookOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lookOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetLookOffset_Process_Protected_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600BEC0 RID: 48832 RVA: 0x0030D784 File Offset: 0x0030B984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317424, XrefRangeEnd = 317444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MouseRaycast(out RaycastResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_MouseRaycast_Public_Boolean_byref_RaycastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new RaycastResult(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600BEC1 RID: 48833 RVA: 0x0030D7E4 File Offset: 0x0030B9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317444, XrefRangeEnd = 317447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Phone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Phone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BEC2 RID: 48834 RVA: 0x00059107 File Offset: 0x00057307
		public Phone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003997 RID: 14743
		// (get) Token: 0x0600BEC3 RID: 48835 RVA: 0x0030D820 File Offset: 0x0030BA20
		// (set) Token: 0x0600BEC4 RID: 48836 RVA: 0x00059110 File Offset: 0x00057310
		public unsafe static float MinLookOffset
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Phone.NativeFieldInfoPtr_MinLookOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Phone.NativeFieldInfoPtr_MinLookOffset, (void*)(&value));
			}
		}

		// Token: 0x17003998 RID: 14744
		// (get) Token: 0x0600BEC5 RID: 48837 RVA: 0x0030D83C File Offset: 0x0030BA3C
		// (set) Token: 0x0600BEC6 RID: 48838 RVA: 0x0005911E File Offset: 0x0005731E
		public unsafe static float MaxLookOffset
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Phone.NativeFieldInfoPtr_MaxLookOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Phone.NativeFieldInfoPtr_MaxLookOffset, (void*)(&value));
			}
		}

		// Token: 0x17003999 RID: 14745
		// (get) Token: 0x0600BEC7 RID: 48839 RVA: 0x0030D858 File Offset: 0x0030BA58
		// (set) Token: 0x0600BEC8 RID: 48840 RVA: 0x0005912C File Offset: 0x0005732C
		public unsafe static float RotationTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Phone.NativeFieldInfoPtr_RotationTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Phone.NativeFieldInfoPtr_RotationTime, (void*)(&value));
			}
		}

		// Token: 0x1700399A RID: 14746
		// (get) Token: 0x0600BEC9 RID: 48841 RVA: 0x0030D874 File Offset: 0x0030BA74
		// (set) Token: 0x0600BECA RID: 48842 RVA: 0x0005913A File Offset: 0x0005733A
		public unsafe static GameObject ActiveApp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Phone.NativeFieldInfoPtr_ActiveApp, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Phone.NativeFieldInfoPtr_ActiveApp, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700399B RID: 14747
		// (get) Token: 0x0600BECB RID: 48843 RVA: 0x0030D89C File Offset: 0x0030BA9C
		// (set) Token: 0x0600BECC RID: 48844 RVA: 0x0005914C File Offset: 0x0005734C
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700399C RID: 14748
		// (get) Token: 0x0600BECD RID: 48845 RVA: 0x0030D8C4 File Offset: 0x0030BAC4
		// (set) Token: 0x0600BECE RID: 48846 RVA: 0x00059167 File Offset: 0x00057367
		public unsafe bool _isHorizontal_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__isHorizontal_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__isHorizontal_k__BackingField)) = value;
			}
		}

		// Token: 0x1700399D RID: 14749
		// (get) Token: 0x0600BECF RID: 48847 RVA: 0x0030D8EC File Offset: 0x0030BAEC
		// (set) Token: 0x0600BED0 RID: 48848 RVA: 0x00059182 File Offset: 0x00057382
		public unsafe bool _isOpenable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__isOpenable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__isOpenable_k__BackingField)) = value;
			}
		}

		// Token: 0x1700399E RID: 14750
		// (get) Token: 0x0600BED1 RID: 48849 RVA: 0x0030D914 File Offset: 0x0030BB14
		// (set) Token: 0x0600BED2 RID: 48850 RVA: 0x0005919D File Offset: 0x0005739D
		public unsafe bool _FlashlightOn_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__FlashlightOn_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__FlashlightOn_k__BackingField)) = value;
			}
		}

		// Token: 0x1700399F RID: 14751
		// (get) Token: 0x0600BED3 RID: 48851 RVA: 0x0030D93C File Offset: 0x0030BB3C
		// (set) Token: 0x0600BED4 RID: 48852 RVA: 0x000591B8 File Offset: 0x000573B8
		public unsafe GameObject phoneModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_phoneModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_phoneModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039A0 RID: 14752
		// (get) Token: 0x0600BED5 RID: 48853 RVA: 0x0030D96C File Offset: 0x0030BB6C
		// (set) Token: 0x0600BED6 RID: 48854 RVA: 0x000591D7 File Offset: 0x000573D7
		public unsafe Transform orientation_Vertical
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_orientation_Vertical);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_orientation_Vertical), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039A1 RID: 14753
		// (get) Token: 0x0600BED7 RID: 48855 RVA: 0x0030D99C File Offset: 0x0030BB9C
		// (set) Token: 0x0600BED8 RID: 48856 RVA: 0x000591F6 File Offset: 0x000573F6
		public unsafe Transform orientation_Horizontal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_orientation_Horizontal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_orientation_Horizontal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039A2 RID: 14754
		// (get) Token: 0x0600BED9 RID: 48857 RVA: 0x0030D9CC File Offset: 0x0030BBCC
		// (set) Token: 0x0600BEDA RID: 48858 RVA: 0x00059215 File Offset: 0x00057415
		public unsafe GraphicRaycaster raycaster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_raycaster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicRaycaster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_raycaster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039A3 RID: 14755
		// (get) Token: 0x0600BEDB RID: 48859 RVA: 0x0030D9FC File Offset: 0x0030BBFC
		// (set) Token: 0x0600BEDC RID: 48860 RVA: 0x00059234 File Offset: 0x00057434
		public unsafe GameObject PhoneFlashlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_PhoneFlashlight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_PhoneFlashlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039A4 RID: 14756
		// (get) Token: 0x0600BEDD RID: 48861 RVA: 0x0030DA2C File Offset: 0x0030BC2C
		// (set) Token: 0x0600BEDE RID: 48862 RVA: 0x00059253 File Offset: 0x00057453
		public unsafe AudioSourceController FlashlightToggleSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_FlashlightToggleSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_FlashlightToggleSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039A5 RID: 14757
		// (get) Token: 0x0600BEDF RID: 48863 RVA: 0x0030DA5C File Offset: 0x0030BC5C
		// (set) Token: 0x0600BEE0 RID: 48864 RVA: 0x00059272 File Offset: 0x00057472
		public unsafe MonoState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039A6 RID: 14758
		// (get) Token: 0x0600BEE1 RID: 48865 RVA: 0x0030DA8C File Offset: 0x0030BC8C
		// (set) Token: 0x0600BEE2 RID: 48866 RVA: 0x00059291 File Offset: 0x00057491
		public unsafe ColorFont _generalColorFont
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__generalColorFont);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorFont>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__generalColorFont), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039A7 RID: 14759
		// (get) Token: 0x0600BEE3 RID: 48867 RVA: 0x0030DABC File Offset: 0x0030BCBC
		// (set) Token: 0x0600BEE4 RID: 48868 RVA: 0x000592B0 File Offset: 0x000574B0
		public unsafe ColorFont _productColorFont
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__productColorFont);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorFont>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__productColorFont), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039A8 RID: 14760
		// (get) Token: 0x0600BEE5 RID: 48869 RVA: 0x0030DAEC File Offset: 0x0030BCEC
		// (set) Token: 0x0600BEE6 RID: 48870 RVA: 0x000592CF File Offset: 0x000574CF
		public unsafe InputActionReference _toggleFlashlightInputAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__toggleFlashlightInputAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__toggleFlashlightInputAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039A9 RID: 14761
		// (get) Token: 0x0600BEE7 RID: 48871 RVA: 0x0030DB1C File Offset: 0x0030BD1C
		// (set) Token: 0x0600BEE8 RID: 48872 RVA: 0x000592EE File Offset: 0x000574EE
		public unsafe Action onPhoneOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_onPhoneOpened);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_onPhoneOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039AA RID: 14762
		// (get) Token: 0x0600BEE9 RID: 48873 RVA: 0x0030DB4C File Offset: 0x0030BD4C
		// (set) Token: 0x0600BEEA RID: 48874 RVA: 0x0005930D File Offset: 0x0005750D
		public unsafe Action onPhoneClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_onPhoneClosed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_onPhoneClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039AB RID: 14763
		// (get) Token: 0x0600BEEB RID: 48875 RVA: 0x0030DB7C File Offset: 0x0030BD7C
		// (set) Token: 0x0600BEEC RID: 48876 RVA: 0x0005932C File Offset: 0x0005752C
		public unsafe Action closeApps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_closeApps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_closeApps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039AC RID: 14764
		// (get) Token: 0x0600BEED RID: 48877 RVA: 0x0030DBAC File Offset: 0x0030BDAC
		// (set) Token: 0x0600BEEE RID: 48878 RVA: 0x0005934B File Offset: 0x0005754B
		public unsafe EventSystem eventSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_eventSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_eventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039AD RID: 14765
		// (get) Token: 0x0600BEEF RID: 48879 RVA: 0x0030DBDC File Offset: 0x0030BDDC
		// (set) Token: 0x0600BEF0 RID: 48880 RVA: 0x0005936A File Offset: 0x0005756A
		public unsafe VisibilityAttribute flashlightVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_flashlightVisibility);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisibilityAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_flashlightVisibility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039AE RID: 14766
		// (get) Token: 0x0600BEF1 RID: 48881 RVA: 0x0030DC0C File Offset: 0x0030BE0C
		// (set) Token: 0x0600BEF2 RID: 48882 RVA: 0x00059389 File Offset: 0x00057589
		public unsafe Coroutine rotationCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_rotationCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_rotationCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039AF RID: 14767
		// (get) Token: 0x0600BEF3 RID: 48883 RVA: 0x0030DC3C File Offset: 0x0030BE3C
		// (set) Token: 0x0600BEF4 RID: 48884 RVA: 0x000593A8 File Offset: 0x000575A8
		public unsafe Coroutine lookOffsetCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_lookOffsetCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_lookOffsetCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008287 RID: 33415
		private static readonly IntPtr NativeFieldInfoPtr_MinLookOffset;

		// Token: 0x04008288 RID: 33416
		private static readonly IntPtr NativeFieldInfoPtr_MaxLookOffset;

		// Token: 0x04008289 RID: 33417
		private static readonly IntPtr NativeFieldInfoPtr_RotationTime;

		// Token: 0x0400828A RID: 33418
		private static readonly IntPtr NativeFieldInfoPtr_ActiveApp;

		// Token: 0x0400828B RID: 33419
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400828C RID: 33420
		private static readonly IntPtr NativeFieldInfoPtr__isHorizontal_k__BackingField;

		// Token: 0x0400828D RID: 33421
		private static readonly IntPtr NativeFieldInfoPtr__isOpenable_k__BackingField;

		// Token: 0x0400828E RID: 33422
		private static readonly IntPtr NativeFieldInfoPtr__FlashlightOn_k__BackingField;

		// Token: 0x0400828F RID: 33423
		private static readonly IntPtr NativeFieldInfoPtr_phoneModel;

		// Token: 0x04008290 RID: 33424
		private static readonly IntPtr NativeFieldInfoPtr_orientation_Vertical;

		// Token: 0x04008291 RID: 33425
		private static readonly IntPtr NativeFieldInfoPtr_orientation_Horizontal;

		// Token: 0x04008292 RID: 33426
		private static readonly IntPtr NativeFieldInfoPtr_raycaster;

		// Token: 0x04008293 RID: 33427
		private static readonly IntPtr NativeFieldInfoPtr_PhoneFlashlight;

		// Token: 0x04008294 RID: 33428
		private static readonly IntPtr NativeFieldInfoPtr_FlashlightToggleSound;

		// Token: 0x04008295 RID: 33429
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04008296 RID: 33430
		private static readonly IntPtr NativeFieldInfoPtr__generalColorFont;

		// Token: 0x04008297 RID: 33431
		private static readonly IntPtr NativeFieldInfoPtr__productColorFont;

		// Token: 0x04008298 RID: 33432
		private static readonly IntPtr NativeFieldInfoPtr__toggleFlashlightInputAction;

		// Token: 0x04008299 RID: 33433
		private static readonly IntPtr NativeFieldInfoPtr_onPhoneOpened;

		// Token: 0x0400829A RID: 33434
		private static readonly IntPtr NativeFieldInfoPtr_onPhoneClosed;

		// Token: 0x0400829B RID: 33435
		private static readonly IntPtr NativeFieldInfoPtr_closeApps;

		// Token: 0x0400829C RID: 33436
		private static readonly IntPtr NativeFieldInfoPtr_eventSystem;

		// Token: 0x0400829D RID: 33437
		private static readonly IntPtr NativeFieldInfoPtr_flashlightVisibility;

		// Token: 0x0400829E RID: 33438
		private static readonly IntPtr NativeFieldInfoPtr_rotationCoroutine;

		// Token: 0x0400829F RID: 33439
		private static readonly IntPtr NativeFieldInfoPtr_lookOffsetCoroutine;

		// Token: 0x040082A0 RID: 33440
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040082A1 RID: 33441
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040082A2 RID: 33442
		private static readonly IntPtr NativeMethodInfoPtr_get_isHorizontal_Public_get_Boolean_0;

		// Token: 0x040082A3 RID: 33443
		private static readonly IntPtr NativeMethodInfoPtr_set_isHorizontal_Protected_set_Void_Boolean_0;

		// Token: 0x040082A4 RID: 33444
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpenable_Public_get_Boolean_0;

		// Token: 0x040082A5 RID: 33445
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpenable_Protected_set_Void_Boolean_0;

		// Token: 0x040082A6 RID: 33446
		private static readonly IntPtr NativeMethodInfoPtr_get_FlashlightOn_Public_get_Boolean_0;

		// Token: 0x040082A7 RID: 33447
		private static readonly IntPtr NativeMethodInfoPtr_set_FlashlightOn_Protected_set_Void_Boolean_0;

		// Token: 0x040082A8 RID: 33448
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAnyAppOpen_Public_get_Boolean_0;

		// Token: 0x040082A9 RID: 33449
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_MonoState_0;

		// Token: 0x040082AA RID: 33450
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaledLookOffset_Public_get_Single_0;

		// Token: 0x040082AB RID: 33451
		private static readonly IntPtr NativeMethodInfoPtr_get_GeneralColorFont_Public_get_ColorFont_0;

		// Token: 0x040082AC RID: 33452
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040082AD RID: 33453
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0;

		// Token: 0x040082AE RID: 33454
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040082AF RID: 33455
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040082B0 RID: 33456
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x040082B1 RID: 33457
		private static readonly IntPtr NativeMethodInfoPtr_ToggleFlashlight_Private_Void_0;

		// Token: 0x040082B2 RID: 33458
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x040082B3 RID: 33459
		private static readonly IntPtr NativeMethodInfoPtr_SetIsActiveGameplayScreen_Public_Void_Boolean_0;

		// Token: 0x040082B4 RID: 33460
		private static readonly IntPtr NativeMethodInfoPtr_SetIsHorizontal_Public_Void_Boolean_0;

		// Token: 0x040082B5 RID: 33461
		private static readonly IntPtr NativeMethodInfoPtr_SetIsHorizontal_Process_Protected_IEnumerator_Boolean_0;

		// Token: 0x040082B6 RID: 33462
		private static readonly IntPtr NativeMethodInfoPtr_SetLookOffsetMultiplier_Public_Void_Single_0;

		// Token: 0x040082B7 RID: 33463
		private static readonly IntPtr NativeMethodInfoPtr_RequestCloseApp_Public_Void_0;

		// Token: 0x040082B8 RID: 33464
		private static readonly IntPtr NativeMethodInfoPtr_SetLookOffset_Process_Protected_IEnumerator_Single_0;

		// Token: 0x040082B9 RID: 33465
		private static readonly IntPtr NativeMethodInfoPtr_MouseRaycast_Public_Boolean_byref_RaycastResult_0;

		// Token: 0x040082BA RID: 33466
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D28 RID: 3368
		[ObfuscatedName("ScheduleOne.UI.Phone.Phone+<SetIsHorizontal_Process>d__53")]
		public sealed class _SetIsHorizontal_Process_d__53 : Il2CppSystem.Object
		{
			// Token: 0x0600F8BC RID: 63676 RVA: 0x003B8BF8 File Offset: 0x003B6DF8
			// Note: this type is marked as 'beforefieldinit'.
			static _SetIsHorizontal_Process_d__53()
			{
				Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__53>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<SetIsHorizontal_Process>d__53");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__53>.NativeClassPtr);
				Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__53>.NativeClassPtr, "<>1__state");
				Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__53>.NativeClassPtr, "<>2__current");
				Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__53>.NativeClassPtr, "<>4__this");
				Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__53>.NativeClassPtr, "h");
				Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr__adjustedRotationTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__53>.NativeClassPtr, "<adjustedRotationTime>5__2");
				Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr__startRotation_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__53>.NativeClassPtr, "<startRotation>5__3");
				Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr__endRotation_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__53>.NativeClassPtr, "<endRotation>5__4");
				Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__53>.NativeClassPtr, "<i>5__5");
				Phone._SetIsHorizontal_Process_d__53.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__53>.NativeClassPtr, 100688194);
				Phone._SetIsHorizontal_Process_d__53.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__53>.NativeClassPtr, 100688195);
				Phone._SetIsHorizontal_Process_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__53>.NativeClassPtr, 100688196);
				Phone._SetIsHorizontal_Process_d__53.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__53>.NativeClassPtr, 100688197);
				Phone._SetIsHorizontal_Process_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__53>.NativeClassPtr, 100688198);
				Phone._SetIsHorizontal_Process_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__53>.NativeClassPtr, 100688199);
			}

			// Token: 0x0600F8BD RID: 63677 RVA: 0x003B8D3C File Offset: 0x003B6F3C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SetIsHorizontal_Process_d__53(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__53>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__53.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F8BE RID: 63678 RVA: 0x003B8D84 File Offset: 0x003B6F84
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__53.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F8BF RID: 63679 RVA: 0x003B8DB8 File Offset: 0x003B6FB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317195, XrefRangeEnd = 317223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004BA6 RID: 19366
			// (get) Token: 0x0600F8C0 RID: 63680 RVA: 0x003B8DF4 File Offset: 0x003B6FF4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__53.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F8C1 RID: 63681 RVA: 0x003B8E34 File Offset: 0x003B7034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317223, XrefRangeEnd = 317228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004BA7 RID: 19367
			// (get) Token: 0x0600F8C2 RID: 63682 RVA: 0x003B8E68 File Offset: 0x003B7068
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F8C3 RID: 63683 RVA: 0x000759DD File Offset: 0x00073BDD
			public _SetIsHorizontal_Process_d__53(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B9E RID: 19358
			// (get) Token: 0x0600F8C4 RID: 63684 RVA: 0x003B8EA8 File Offset: 0x003B70A8
			// (set) Token: 0x0600F8C5 RID: 63685 RVA: 0x000759E6 File Offset: 0x00073BE6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004B9F RID: 19359
			// (get) Token: 0x0600F8C6 RID: 63686 RVA: 0x003B8ED0 File Offset: 0x003B70D0
			// (set) Token: 0x0600F8C7 RID: 63687 RVA: 0x00075A01 File Offset: 0x00073C01
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BA0 RID: 19360
			// (get) Token: 0x0600F8C8 RID: 63688 RVA: 0x003B8F00 File Offset: 0x003B7100
			// (set) Token: 0x0600F8C9 RID: 63689 RVA: 0x00075A20 File Offset: 0x00073C20
			public unsafe Phone __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Phone>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BA1 RID: 19361
			// (get) Token: 0x0600F8CA RID: 63690 RVA: 0x003B8F30 File Offset: 0x003B7130
			// (set) Token: 0x0600F8CB RID: 63691 RVA: 0x00075A3F File Offset: 0x00073C3F
			public unsafe bool h
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr_h);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr_h)) = value;
				}
			}

			// Token: 0x17004BA2 RID: 19362
			// (get) Token: 0x0600F8CC RID: 63692 RVA: 0x003B8F58 File Offset: 0x003B7158
			// (set) Token: 0x0600F8CD RID: 63693 RVA: 0x00075A5A File Offset: 0x00073C5A
			public unsafe float _adjustedRotationTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr__adjustedRotationTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr__adjustedRotationTime_5__2)) = value;
				}
			}

			// Token: 0x17004BA3 RID: 19363
			// (get) Token: 0x0600F8CE RID: 63694 RVA: 0x003B8F80 File Offset: 0x003B7180
			// (set) Token: 0x0600F8CF RID: 63695 RVA: 0x00075A75 File Offset: 0x00073C75
			public unsafe Quaternion _startRotation_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr__startRotation_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr__startRotation_5__3)) = value;
				}
			}

			// Token: 0x17004BA4 RID: 19364
			// (get) Token: 0x0600F8D0 RID: 63696 RVA: 0x003B8FA8 File Offset: 0x003B71A8
			// (set) Token: 0x0600F8D1 RID: 63697 RVA: 0x00075A90 File Offset: 0x00073C90
			public unsafe Quaternion _endRotation_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr__endRotation_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr__endRotation_5__4)) = value;
				}
			}

			// Token: 0x17004BA5 RID: 19365
			// (get) Token: 0x0600F8D2 RID: 63698 RVA: 0x003B8FD0 File Offset: 0x003B71D0
			// (set) Token: 0x0600F8D3 RID: 63699 RVA: 0x00075AAB File Offset: 0x00073CAB
			public unsafe float _i_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__53.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x0400A816 RID: 43030
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A817 RID: 43031
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A818 RID: 43032
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A819 RID: 43033
			private static readonly IntPtr NativeFieldInfoPtr_h;

			// Token: 0x0400A81A RID: 43034
			private static readonly IntPtr NativeFieldInfoPtr__adjustedRotationTime_5__2;

			// Token: 0x0400A81B RID: 43035
			private static readonly IntPtr NativeFieldInfoPtr__startRotation_5__3;

			// Token: 0x0400A81C RID: 43036
			private static readonly IntPtr NativeFieldInfoPtr__endRotation_5__4;

			// Token: 0x0400A81D RID: 43037
			private static readonly IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x0400A81E RID: 43038
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A81F RID: 43039
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A820 RID: 43040
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A821 RID: 43041
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A822 RID: 43042
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A823 RID: 43043
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000D29 RID: 3369
		[ObfuscatedName("ScheduleOne.UI.Phone.Phone+<SetLookOffset_Process>d__57")]
		public sealed class _SetLookOffset_Process_d__57 : Il2CppSystem.Object
		{
			// Token: 0x0600F8D4 RID: 63700 RVA: 0x003B8FF8 File Offset: 0x003B71F8
			// Note: this type is marked as 'beforefieldinit'.
			static _SetLookOffset_Process_d__57()
			{
				Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__57>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<SetLookOffset_Process>d__57");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__57>.NativeClassPtr);
				Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__57>.NativeClassPtr, "<>1__state");
				Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__57>.NativeClassPtr, "<>2__current");
				Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__57>.NativeClassPtr, "<>4__this");
				Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr_lookOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__57>.NativeClassPtr, "lookOffset");
				Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr__startOffset_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__57>.NativeClassPtr, "<startOffset>5__2");
				Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr__endOffset_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__57>.NativeClassPtr, "<endOffset>5__3");
				Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr__moveTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__57>.NativeClassPtr, "<moveTime>5__4");
				Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__57>.NativeClassPtr, "<i>5__5");
				Phone._SetLookOffset_Process_d__57.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__57>.NativeClassPtr, 100688200);
				Phone._SetLookOffset_Process_d__57.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__57>.NativeClassPtr, 100688201);
				Phone._SetLookOffset_Process_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__57>.NativeClassPtr, 100688202);
				Phone._SetLookOffset_Process_d__57.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__57>.NativeClassPtr, 100688203);
				Phone._SetLookOffset_Process_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__57>.NativeClassPtr, 100688204);
				Phone._SetLookOffset_Process_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__57>.NativeClassPtr, 100688205);
			}

			// Token: 0x0600F8D5 RID: 63701 RVA: 0x003B913C File Offset: 0x003B733C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SetLookOffset_Process_d__57(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__57>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__57.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F8D6 RID: 63702 RVA: 0x003B9184 File Offset: 0x003B7384
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__57.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F8D7 RID: 63703 RVA: 0x003B91B8 File Offset: 0x003B73B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317228, XrefRangeEnd = 317252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004BB0 RID: 19376
			// (get) Token: 0x0600F8D8 RID: 63704 RVA: 0x003B91F4 File Offset: 0x003B73F4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__57.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F8D9 RID: 63705 RVA: 0x003B9234 File Offset: 0x003B7434
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317252, XrefRangeEnd = 317257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004BB1 RID: 19377
			// (get) Token: 0x0600F8DA RID: 63706 RVA: 0x003B9268 File Offset: 0x003B7468
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F8DB RID: 63707 RVA: 0x00075AC6 File Offset: 0x00073CC6
			public _SetLookOffset_Process_d__57(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BA8 RID: 19368
			// (get) Token: 0x0600F8DC RID: 63708 RVA: 0x003B92A8 File Offset: 0x003B74A8
			// (set) Token: 0x0600F8DD RID: 63709 RVA: 0x00075ACF File Offset: 0x00073CCF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004BA9 RID: 19369
			// (get) Token: 0x0600F8DE RID: 63710 RVA: 0x003B92D0 File Offset: 0x003B74D0
			// (set) Token: 0x0600F8DF RID: 63711 RVA: 0x00075AEA File Offset: 0x00073CEA
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BAA RID: 19370
			// (get) Token: 0x0600F8E0 RID: 63712 RVA: 0x003B9300 File Offset: 0x003B7500
			// (set) Token: 0x0600F8E1 RID: 63713 RVA: 0x00075B09 File Offset: 0x00073D09
			public unsafe Phone __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Phone>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BAB RID: 19371
			// (get) Token: 0x0600F8E2 RID: 63714 RVA: 0x003B9330 File Offset: 0x003B7530
			// (set) Token: 0x0600F8E3 RID: 63715 RVA: 0x00075B28 File Offset: 0x00073D28
			public unsafe float lookOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr_lookOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr_lookOffset)) = value;
				}
			}

			// Token: 0x17004BAC RID: 19372
			// (get) Token: 0x0600F8E4 RID: 63716 RVA: 0x003B9358 File Offset: 0x003B7558
			// (set) Token: 0x0600F8E5 RID: 63717 RVA: 0x00075B43 File Offset: 0x00073D43
			public unsafe float _startOffset_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr__startOffset_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr__startOffset_5__2)) = value;
				}
			}

			// Token: 0x17004BAD RID: 19373
			// (get) Token: 0x0600F8E6 RID: 63718 RVA: 0x003B9380 File Offset: 0x003B7580
			// (set) Token: 0x0600F8E7 RID: 63719 RVA: 0x00075B5E File Offset: 0x00073D5E
			public unsafe float _endOffset_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr__endOffset_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr__endOffset_5__3)) = value;
				}
			}

			// Token: 0x17004BAE RID: 19374
			// (get) Token: 0x0600F8E8 RID: 63720 RVA: 0x003B93A8 File Offset: 0x003B75A8
			// (set) Token: 0x0600F8E9 RID: 63721 RVA: 0x00075B79 File Offset: 0x00073D79
			public unsafe float _moveTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr__moveTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr__moveTime_5__4)) = value;
				}
			}

			// Token: 0x17004BAF RID: 19375
			// (get) Token: 0x0600F8EA RID: 63722 RVA: 0x003B93D0 File Offset: 0x003B75D0
			// (set) Token: 0x0600F8EB RID: 63723 RVA: 0x00075B94 File Offset: 0x00073D94
			public unsafe float _i_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__57.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x0400A824 RID: 43044
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A825 RID: 43045
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A826 RID: 43046
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A827 RID: 43047
			private static readonly IntPtr NativeFieldInfoPtr_lookOffset;

			// Token: 0x0400A828 RID: 43048
			private static readonly IntPtr NativeFieldInfoPtr__startOffset_5__2;

			// Token: 0x0400A829 RID: 43049
			private static readonly IntPtr NativeFieldInfoPtr__endOffset_5__3;

			// Token: 0x0400A82A RID: 43050
			private static readonly IntPtr NativeFieldInfoPtr__moveTime_5__4;

			// Token: 0x0400A82B RID: 43051
			private static readonly IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x0400A82C RID: 43052
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A82D RID: 43053
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A82E RID: 43054
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A82F RID: 43055
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A830 RID: 43056
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A831 RID: 43057
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
