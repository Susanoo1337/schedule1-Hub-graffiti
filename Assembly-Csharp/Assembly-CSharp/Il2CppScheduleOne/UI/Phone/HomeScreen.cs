using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020007AB RID: 1963
	public class HomeScreen : PlayerSingleton<HomeScreen>
	{
		// Token: 0x0600BE7F RID: 48767 RVA: 0x0030C4B0 File Offset: 0x0030A6B0
		// Note: this type is marked as 'beforefieldinit'.
		static HomeScreen()
		{
			Il2CppClassPointerStore<HomeScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "HomeScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr);
			HomeScreen.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "<isOpen>k__BackingField");
			HomeScreen.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "canvas");
			HomeScreen.NativeFieldInfoPtr_timeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "timeText");
			HomeScreen.NativeFieldInfoPtr_appIconContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "appIconContainer");
			HomeScreen.NativeFieldInfoPtr_appIconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "appIconPrefab");
			HomeScreen.NativeFieldInfoPtr_uiScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "uiScreen");
			HomeScreen.NativeFieldInfoPtr_uiPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "uiPanel");
			HomeScreen.NativeFieldInfoPtr_appIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "appIcons");
			HomeScreen.NativeFieldInfoPtr_delayedSetOpenRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "delayedSetOpenRoutine");
			HomeScreen.NativeFieldInfoPtr_lastSelectedSelectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "lastSelectedSelectable");
			HomeScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100688138);
			HomeScreen.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100688139);
			HomeScreen.NativeMethodInfoPtr_get_LastSelectedSelectable_Public_get_UISelectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100688140);
			HomeScreen.NativeMethodInfoPtr_set_LastSelectedSelectable_Public_set_Void_UISelectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100688141);
			HomeScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100688142);
			HomeScreen.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100688143);
			HomeScreen.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100688144);
			HomeScreen.NativeMethodInfoPtr_PhoneOpened_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100688145);
			HomeScreen.NativeMethodInfoPtr_PhoneClosed_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100688146);
			HomeScreen.NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100688147);
			HomeScreen.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100688148);
			HomeScreen.NativeMethodInfoPtr_SetCanvasActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100688149);
			HomeScreen.NativeMethodInfoPtr_SelectUIPanel_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100688150);
			HomeScreen.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100688151);
			HomeScreen.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100688152);
			HomeScreen.NativeMethodInfoPtr_GenerateAppIcon_Public_Button_App_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100688153);
			HomeScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100688154);
		}

		// Token: 0x17003995 RID: 14741
		// (get) Token: 0x0600BE80 RID: 48768 RVA: 0x0030C6FC File Offset: 0x0030A8FC
		// (set) Token: 0x0600BE81 RID: 48769 RVA: 0x0030C738 File Offset: 0x0030A938
		public unsafe bool isOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003996 RID: 14742
		// (get) Token: 0x0600BE82 RID: 48770 RVA: 0x0030C778 File Offset: 0x0030A978
		// (set) Token: 0x0600BE83 RID: 48771 RVA: 0x0030C7B8 File Offset: 0x0030A9B8
		public unsafe UISelectable LastSelectedSelectable
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 21999, RefRangeEnd = 22015, XrefRangeStart = 21999, XrefRangeEnd = 22015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_get_LastSelectedSelectable_Public_get_UISelectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_set_LastSelectedSelectable_Public_set_Void_UISelectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600BE84 RID: 48772 RVA: 0x0030C7FC File Offset: 0x0030A9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316953, XrefRangeEnd = 316962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HomeScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE85 RID: 48773 RVA: 0x0030C838 File Offset: 0x0030AA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316962, XrefRangeEnd = 317002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref IsOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HomeScreen.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE86 RID: 48774 RVA: 0x0030C884 File Offset: 0x0030AA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317002, XrefRangeEnd = 317018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HomeScreen.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE87 RID: 48775 RVA: 0x0030C8C0 File Offset: 0x0030AAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317018, XrefRangeEnd = 317019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PhoneOpened()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_PhoneOpened_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE88 RID: 48776 RVA: 0x0030C8F4 File Offset: 0x0030AAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317019, XrefRangeEnd = 317032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PhoneClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_PhoneClosed_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE89 RID: 48777 RVA: 0x0030C928 File Offset: 0x0030AB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317032, XrefRangeEnd = 317037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayedSetCanvasActive(bool active, float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600BE8A RID: 48778 RVA: 0x0030C984 File Offset: 0x0030AB84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317044, RefRangeEnd = 317045, XrefRangeStart = 317037, XrefRangeEnd = 317044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref o;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE8B RID: 48779 RVA: 0x0030C9C4 File Offset: 0x0030ABC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317063, RefRangeEnd = 317066, XrefRangeStart = 317045, XrefRangeEnd = 317063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanvasActive(bool a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_SetCanvasActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE8C RID: 48780 RVA: 0x0030CA04 File Offset: 0x0030AC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317066, XrefRangeEnd = 317071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SelectUIPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_SelectUIPanel_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600BE8D RID: 48781 RVA: 0x0030CA44 File Offset: 0x0030AC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317071, XrefRangeEnd = 317100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HomeScreen.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE8E RID: 48782 RVA: 0x0030CA80 File Offset: 0x0030AC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317100, XrefRangeEnd = 317146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HomeScreen.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE8F RID: 48783 RVA: 0x0030CABC File Offset: 0x0030ACBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317184, RefRangeEnd = 317185, XrefRangeStart = 317146, XrefRangeEnd = 317184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Button GenerateAppIcon<T>(App<T> prog) where T : PlayerSingleton<T>
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prog);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.MethodInfoStoreGeneric_GenerateAppIcon_Public_Button_App_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Button>(intPtr3) : null;
		}

		// Token: 0x0600BE90 RID: 48784 RVA: 0x0030CB0C File Offset: 0x0030AD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317185, XrefRangeEnd = 317195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HomeScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE91 RID: 48785 RVA: 0x00058FCC File Offset: 0x000571CC
		public HomeScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700398B RID: 14731
		// (get) Token: 0x0600BE92 RID: 48786 RVA: 0x0030CB48 File Offset: 0x0030AD48
		// (set) Token: 0x0600BE93 RID: 48787 RVA: 0x00058FD5 File Offset: 0x000571D5
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700398C RID: 14732
		// (get) Token: 0x0600BE94 RID: 48788 RVA: 0x0030CB70 File Offset: 0x0030AD70
		// (set) Token: 0x0600BE95 RID: 48789 RVA: 0x00058FF0 File Offset: 0x000571F0
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700398D RID: 14733
		// (get) Token: 0x0600BE96 RID: 48790 RVA: 0x0030CBA0 File Offset: 0x0030ADA0
		// (set) Token: 0x0600BE97 RID: 48791 RVA: 0x0005900F File Offset: 0x0005720F
		public unsafe Text timeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_timeText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_timeText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700398E RID: 14734
		// (get) Token: 0x0600BE98 RID: 48792 RVA: 0x0030CBD0 File Offset: 0x0030ADD0
		// (set) Token: 0x0600BE99 RID: 48793 RVA: 0x0005902E File Offset: 0x0005722E
		public unsafe RectTransform appIconContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIconContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIconContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700398F RID: 14735
		// (get) Token: 0x0600BE9A RID: 48794 RVA: 0x0030CC00 File Offset: 0x0030AE00
		// (set) Token: 0x0600BE9B RID: 48795 RVA: 0x0005904D File Offset: 0x0005724D
		public unsafe GameObject appIconPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIconPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIconPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003990 RID: 14736
		// (get) Token: 0x0600BE9C RID: 48796 RVA: 0x0030CC30 File Offset: 0x0030AE30
		// (set) Token: 0x0600BE9D RID: 48797 RVA: 0x0005906C File Offset: 0x0005726C
		public unsafe UIScreen uiScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_uiScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_uiScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003991 RID: 14737
		// (get) Token: 0x0600BE9E RID: 48798 RVA: 0x0030CC60 File Offset: 0x0030AE60
		// (set) Token: 0x0600BE9F RID: 48799 RVA: 0x0005908B File Offset: 0x0005728B
		public unsafe UIPanel uiPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_uiPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_uiPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003992 RID: 14738
		// (get) Token: 0x0600BEA0 RID: 48800 RVA: 0x0030CC90 File Offset: 0x0030AE90
		// (set) Token: 0x0600BEA1 RID: 48801 RVA: 0x000590AA File Offset: 0x000572AA
		public unsafe List<Button> appIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003993 RID: 14739
		// (get) Token: 0x0600BEA2 RID: 48802 RVA: 0x0030CCC0 File Offset: 0x0030AEC0
		// (set) Token: 0x0600BEA3 RID: 48803 RVA: 0x000590C9 File Offset: 0x000572C9
		public unsafe Coroutine delayedSetOpenRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_delayedSetOpenRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_delayedSetOpenRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003994 RID: 14740
		// (get) Token: 0x0600BEA4 RID: 48804 RVA: 0x0030CCF0 File Offset: 0x0030AEF0
		// (set) Token: 0x0600BEA5 RID: 48805 RVA: 0x000590E8 File Offset: 0x000572E8
		public unsafe UISelectable lastSelectedSelectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_lastSelectedSelectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_lastSelectedSelectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400826C RID: 33388
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x0400826D RID: 33389
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x0400826E RID: 33390
		private static readonly IntPtr NativeFieldInfoPtr_timeText;

		// Token: 0x0400826F RID: 33391
		private static readonly IntPtr NativeFieldInfoPtr_appIconContainer;

		// Token: 0x04008270 RID: 33392
		private static readonly IntPtr NativeFieldInfoPtr_appIconPrefab;

		// Token: 0x04008271 RID: 33393
		private static readonly IntPtr NativeFieldInfoPtr_uiScreen;

		// Token: 0x04008272 RID: 33394
		private static readonly IntPtr NativeFieldInfoPtr_uiPanel;

		// Token: 0x04008273 RID: 33395
		private static readonly IntPtr NativeFieldInfoPtr_appIcons;

		// Token: 0x04008274 RID: 33396
		private static readonly IntPtr NativeFieldInfoPtr_delayedSetOpenRoutine;

		// Token: 0x04008275 RID: 33397
		private static readonly IntPtr NativeFieldInfoPtr_lastSelectedSelectable;

		// Token: 0x04008276 RID: 33398
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04008277 RID: 33399
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04008278 RID: 33400
		private static readonly IntPtr NativeMethodInfoPtr_get_LastSelectedSelectable_Public_get_UISelectable_0;

		// Token: 0x04008279 RID: 33401
		private static readonly IntPtr NativeMethodInfoPtr_set_LastSelectedSelectable_Public_set_Void_UISelectable_0;

		// Token: 0x0400827A RID: 33402
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400827B RID: 33403
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400827C RID: 33404
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x0400827D RID: 33405
		private static readonly IntPtr NativeMethodInfoPtr_PhoneOpened_Protected_Void_0;

		// Token: 0x0400827E RID: 33406
		private static readonly IntPtr NativeMethodInfoPtr_PhoneClosed_Protected_Void_0;

		// Token: 0x0400827F RID: 33407
		private static readonly IntPtr NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0;

		// Token: 0x04008280 RID: 33408
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x04008281 RID: 33409
		private static readonly IntPtr NativeMethodInfoPtr_SetCanvasActive_Public_Void_Boolean_0;

		// Token: 0x04008282 RID: 33410
		private static readonly IntPtr NativeMethodInfoPtr_SelectUIPanel_Private_IEnumerator_0;

		// Token: 0x04008283 RID: 33411
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04008284 RID: 33412
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04008285 RID: 33413
		private static readonly IntPtr NativeMethodInfoPtr_GenerateAppIcon_Public_Button_App_1_T_0;

		// Token: 0x04008286 RID: 33414
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D25 RID: 3365
		[ObfuscatedName("ScheduleOne.UI.Phone.HomeScreen+<DelayedSetCanvasActive>d__21")]
		public sealed class _DelayedSetCanvasActive_d__21 : Il2CppSystem.Object
		{
			// Token: 0x0600F89B RID: 63643 RVA: 0x003B8584 File Offset: 0x003B6784
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayedSetCanvasActive_d__21()
			{
				Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "<DelayedSetCanvasActive>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__21>.NativeClassPtr);
				HomeScreen._DelayedSetCanvasActive_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__21>.NativeClassPtr, "<>1__state");
				HomeScreen._DelayedSetCanvasActive_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__21>.NativeClassPtr, "<>2__current");
				HomeScreen._DelayedSetCanvasActive_d__21.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__21>.NativeClassPtr, "delay");
				HomeScreen._DelayedSetCanvasActive_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__21>.NativeClassPtr, "<>4__this");
				HomeScreen._DelayedSetCanvasActive_d__21.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__21>.NativeClassPtr, "active");
				HomeScreen._DelayedSetCanvasActive_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__21>.NativeClassPtr, 100688155);
				HomeScreen._DelayedSetCanvasActive_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__21>.NativeClassPtr, 100688156);
				HomeScreen._DelayedSetCanvasActive_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__21>.NativeClassPtr, 100688157);
				HomeScreen._DelayedSetCanvasActive_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__21>.NativeClassPtr, 100688158);
				HomeScreen._DelayedSetCanvasActive_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__21>.NativeClassPtr, 100688159);
				HomeScreen._DelayedSetCanvasActive_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__21>.NativeClassPtr, 100688160);
			}

			// Token: 0x0600F89C RID: 63644 RVA: 0x003B868C File Offset: 0x003B688C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayedSetCanvasActive_d__21(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__21>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F89D RID: 63645 RVA: 0x003B86D4 File Offset: 0x003B68D4
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F89E RID: 63646 RVA: 0x003B8708 File Offset: 0x003B6908
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316936, XrefRangeEnd = 316941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004B97 RID: 19351
			// (get) Token: 0x0600F89F RID: 63647 RVA: 0x003B8744 File Offset: 0x003B6944
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F8A0 RID: 63648 RVA: 0x003B8784 File Offset: 0x003B6984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316941, XrefRangeEnd = 316946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004B98 RID: 19352
			// (get) Token: 0x0600F8A1 RID: 63649 RVA: 0x003B87B8 File Offset: 0x003B69B8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F8A2 RID: 63650 RVA: 0x000758E3 File Offset: 0x00073AE3
			public _DelayedSetCanvasActive_d__21(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B92 RID: 19346
			// (get) Token: 0x0600F8A3 RID: 63651 RVA: 0x003B87F8 File Offset: 0x003B69F8
			// (set) Token: 0x0600F8A4 RID: 63652 RVA: 0x000758EC File Offset: 0x00073AEC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004B93 RID: 19347
			// (get) Token: 0x0600F8A5 RID: 63653 RVA: 0x003B8820 File Offset: 0x003B6A20
			// (set) Token: 0x0600F8A6 RID: 63654 RVA: 0x00075907 File Offset: 0x00073B07
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B94 RID: 19348
			// (get) Token: 0x0600F8A7 RID: 63655 RVA: 0x003B8850 File Offset: 0x003B6A50
			// (set) Token: 0x0600F8A8 RID: 63656 RVA: 0x00075926 File Offset: 0x00073B26
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__21.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__21.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x17004B95 RID: 19349
			// (get) Token: 0x0600F8A9 RID: 63657 RVA: 0x003B8878 File Offset: 0x003B6A78
			// (set) Token: 0x0600F8AA RID: 63658 RVA: 0x00075941 File Offset: 0x00073B41
			public unsafe HomeScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HomeScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B96 RID: 19350
			// (get) Token: 0x0600F8AB RID: 63659 RVA: 0x003B88A8 File Offset: 0x003B6AA8
			// (set) Token: 0x0600F8AC RID: 63660 RVA: 0x00075960 File Offset: 0x00073B60
			public unsafe bool active
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__21.NativeFieldInfoPtr_active);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__21.NativeFieldInfoPtr_active)) = value;
				}
			}

			// Token: 0x0400A801 RID: 43009
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A802 RID: 43010
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A803 RID: 43011
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x0400A804 RID: 43012
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A805 RID: 43013
			private static readonly IntPtr NativeFieldInfoPtr_active;

			// Token: 0x0400A806 RID: 43014
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A807 RID: 43015
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A808 RID: 43016
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A809 RID: 43017
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A80A RID: 43018
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A80B RID: 43019
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000D26 RID: 3366
		[ObfuscatedName("ScheduleOne.UI.Phone.HomeScreen+<SelectUIPanel>d__24")]
		public sealed class _SelectUIPanel_d__24 : Il2CppSystem.Object
		{
			// Token: 0x0600F8AD RID: 63661 RVA: 0x003B88D0 File Offset: 0x003B6AD0
			// Note: this type is marked as 'beforefieldinit'.
			static _SelectUIPanel_d__24()
			{
				Il2CppClassPointerStore<HomeScreen._SelectUIPanel_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "<SelectUIPanel>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HomeScreen._SelectUIPanel_d__24>.NativeClassPtr);
				HomeScreen._SelectUIPanel_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen._SelectUIPanel_d__24>.NativeClassPtr, "<>1__state");
				HomeScreen._SelectUIPanel_d__24.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen._SelectUIPanel_d__24>.NativeClassPtr, "<>2__current");
				HomeScreen._SelectUIPanel_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen._SelectUIPanel_d__24>.NativeClassPtr, "<>4__this");
				HomeScreen._SelectUIPanel_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._SelectUIPanel_d__24>.NativeClassPtr, 100688161);
				HomeScreen._SelectUIPanel_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._SelectUIPanel_d__24>.NativeClassPtr, 100688162);
				HomeScreen._SelectUIPanel_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._SelectUIPanel_d__24>.NativeClassPtr, 100688163);
				HomeScreen._SelectUIPanel_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._SelectUIPanel_d__24>.NativeClassPtr, 100688164);
				HomeScreen._SelectUIPanel_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._SelectUIPanel_d__24>.NativeClassPtr, 100688165);
				HomeScreen._SelectUIPanel_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._SelectUIPanel_d__24>.NativeClassPtr, 100688166);
			}

			// Token: 0x0600F8AE RID: 63662 RVA: 0x003B89B0 File Offset: 0x003B6BB0
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SelectUIPanel_d__24(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HomeScreen._SelectUIPanel_d__24>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._SelectUIPanel_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F8AF RID: 63663 RVA: 0x003B89F8 File Offset: 0x003B6BF8
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._SelectUIPanel_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F8B0 RID: 63664 RVA: 0x003B8A2C File Offset: 0x003B6C2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316946, XrefRangeEnd = 316948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._SelectUIPanel_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004B9C RID: 19356
			// (get) Token: 0x0600F8B1 RID: 63665 RVA: 0x003B8A68 File Offset: 0x003B6C68
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._SelectUIPanel_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F8B2 RID: 63666 RVA: 0x003B8AA8 File Offset: 0x003B6CA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316948, XrefRangeEnd = 316953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._SelectUIPanel_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004B9D RID: 19357
			// (get) Token: 0x0600F8B3 RID: 63667 RVA: 0x003B8ADC File Offset: 0x003B6CDC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._SelectUIPanel_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F8B4 RID: 63668 RVA: 0x0007597B File Offset: 0x00073B7B
			public _SelectUIPanel_d__24(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B99 RID: 19353
			// (get) Token: 0x0600F8B5 RID: 63669 RVA: 0x003B8B1C File Offset: 0x003B6D1C
			// (set) Token: 0x0600F8B6 RID: 63670 RVA: 0x00075984 File Offset: 0x00073B84
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._SelectUIPanel_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._SelectUIPanel_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004B9A RID: 19354
			// (get) Token: 0x0600F8B7 RID: 63671 RVA: 0x003B8B44 File Offset: 0x003B6D44
			// (set) Token: 0x0600F8B8 RID: 63672 RVA: 0x0007599F File Offset: 0x00073B9F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._SelectUIPanel_d__24.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._SelectUIPanel_d__24.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B9B RID: 19355
			// (get) Token: 0x0600F8B9 RID: 63673 RVA: 0x003B8B74 File Offset: 0x003B6D74
			// (set) Token: 0x0600F8BA RID: 63674 RVA: 0x000759BE File Offset: 0x00073BBE
			public unsafe HomeScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._SelectUIPanel_d__24.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HomeScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._SelectUIPanel_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A80C RID: 43020
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A80D RID: 43021
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A80E RID: 43022
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A80F RID: 43023
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A810 RID: 43024
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A811 RID: 43025
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A812 RID: 43026
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A813 RID: 43027
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A814 RID: 43028
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000D27 RID: 3367
		private sealed class MethodInfoStoreGeneric_GenerateAppIcon_Public_Button_App_1_T_0<T>
		{
			// Token: 0x0400A815 RID: 43029
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HomeScreen.NativeMethodInfoPtr_GenerateAppIcon_Public_Button_App_1_T_0, Il2CppClassPointerStore<HomeScreen>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
