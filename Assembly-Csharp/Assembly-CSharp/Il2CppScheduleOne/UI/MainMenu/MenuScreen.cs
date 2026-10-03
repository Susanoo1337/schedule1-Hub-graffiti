using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.State;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020007FB RID: 2043
	public class MenuScreen : MonoBehaviour
	{
		// Token: 0x0600C6A7 RID: 50855 RVA: 0x003250BC File Offset: 0x003232BC
		// Note: this type is marked as 'beforefieldinit'.
		static MenuScreen()
		{
			Il2CppClassPointerStore<MenuScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "MenuScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr);
			MenuScreen.NativeFieldInfoPtr__Current_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, "<Current>k__BackingField");
			MenuScreen.NativeFieldInfoPtr_LerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, "LerpTime");
			MenuScreen.NativeFieldInfoPtr_LerpScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, "LerpScale");
			MenuScreen.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, "<IsOpen>k__BackingField");
			MenuScreen.NativeFieldInfoPtr_ExitInputPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, "ExitInputPriority");
			MenuScreen.NativeFieldInfoPtr_OpenOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, "OpenOnStart");
			MenuScreen.NativeFieldInfoPtr_AttachLobbyToScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, "AttachLobbyToScreen");
			MenuScreen.NativeFieldInfoPtr_PreviousScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, "PreviousScreen");
			MenuScreen.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, "Group");
			MenuScreen.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, "State");
			MenuScreen.NativeFieldInfoPtr_uiScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, "uiScreen");
			MenuScreen.NativeFieldInfoPtr_uiPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, "uiPanel");
			MenuScreen.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, "rect");
			MenuScreen.NativeFieldInfoPtr_lerpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, "lerpRoutine");
			MenuScreen.NativeMethodInfoPtr_get_Current_Public_Static_get_MenuScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, 100689025);
			MenuScreen.NativeMethodInfoPtr_set_Current_Private_Static_set_Void_MenuScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, 100689026);
			MenuScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, 100689027);
			MenuScreen.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, 100689028);
			MenuScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, 100689029);
			MenuScreen.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, 100689030);
			MenuScreen.NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, 100689031);
			MenuScreen.NativeMethodInfoPtr_Open_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, 100689032);
			MenuScreen.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, 100689033);
			MenuScreen.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, 100689034);
			MenuScreen.NativeMethodInfoPtr_OnOpen_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, 100689035);
			MenuScreen.NativeMethodInfoPtr_OnClose_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, 100689036);
			MenuScreen.NativeMethodInfoPtr_Lerp_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, 100689037);
			MenuScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, 100689038);
		}

		// Token: 0x17003C55 RID: 15445
		// (get) Token: 0x0600C6A8 RID: 50856 RVA: 0x0032531C File Offset: 0x0032351C
		// (set) Token: 0x0600C6A9 RID: 50857 RVA: 0x00325350 File Offset: 0x00323550
		public unsafe static MenuScreen Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327947, XrefRangeEnd = 327949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuScreen.NativeMethodInfoPtr_get_Current_Public_Static_get_MenuScreen_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MenuScreen>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327949, XrefRangeEnd = 327953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuScreen.NativeMethodInfoPtr_set_Current_Private_Static_set_Void_MenuScreen_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003C56 RID: 15446
		// (get) Token: 0x0600C6AA RID: 50858 RVA: 0x00325388 File Offset: 0x00323588
		// (set) Token: 0x0600C6AB RID: 50859 RVA: 0x003253C4 File Offset: 0x003235C4
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuScreen.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C6AC RID: 50860 RVA: 0x00325404 File Offset: 0x00323604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327984, RefRangeEnd = 327985, XrefRangeStart = 327953, XrefRangeEnd = 327984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MenuScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6AD RID: 50861 RVA: 0x00325440 File Offset: 0x00323640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327985, XrefRangeEnd = 327986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuScreen.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6AE RID: 50862 RVA: 0x00325474 File Offset: 0x00323674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327986, XrefRangeEnd = 327992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MenuScreen.NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6AF RID: 50863 RVA: 0x003254C4 File Offset: 0x003236C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301364, RefRangeEnd = 301365, XrefRangeStart = 301364, XrefRangeEnd = 301365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuScreen.NativeMethodInfoPtr_Open_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6B0 RID: 50864 RVA: 0x00325504 File Offset: 0x00323704
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301364, RefRangeEnd = 301365, XrefRangeStart = 301364, XrefRangeEnd = 301365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuScreen.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6B1 RID: 50865 RVA: 0x00325538 File Offset: 0x00323738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuScreen.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6B2 RID: 50866 RVA: 0x0032556C File Offset: 0x0032376C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328050, RefRangeEnd = 328051, XrefRangeStart = 327992, XrefRangeEnd = 328050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MenuScreen.NativeMethodInfoPtr_OnOpen_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6B3 RID: 50867 RVA: 0x003255A8 File Offset: 0x003237A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328051, XrefRangeEnd = 328084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MenuScreen.NativeMethodInfoPtr_OnClose_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6B4 RID: 50868 RVA: 0x003255E4 File Offset: 0x003237E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328115, RefRangeEnd = 328117, XrefRangeStart = 328084, XrefRangeEnd = 328115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Lerp(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuScreen.NativeMethodInfoPtr_Lerp_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6B5 RID: 50869 RVA: 0x00325624 File Offset: 0x00323824
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327636, RefRangeEnd = 327637, XrefRangeStart = 327636, XrefRangeEnd = 327637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MenuScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6B6 RID: 50870 RVA: 0x0005DC9D File Offset: 0x0005BE9D
		public MenuScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C47 RID: 15431
		// (get) Token: 0x0600C6B7 RID: 50871 RVA: 0x00325660 File Offset: 0x00323860
		// (set) Token: 0x0600C6B8 RID: 50872 RVA: 0x0005DCA6 File Offset: 0x0005BEA6
		public unsafe static MenuScreen _Current_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MenuScreen.NativeFieldInfoPtr__Current_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MenuScreen>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MenuScreen.NativeFieldInfoPtr__Current_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C48 RID: 15432
		// (get) Token: 0x0600C6B9 RID: 50873 RVA: 0x00325688 File Offset: 0x00323888
		// (set) Token: 0x0600C6BA RID: 50874 RVA: 0x0005DCB8 File Offset: 0x0005BEB8
		public unsafe static float LerpTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MenuScreen.NativeFieldInfoPtr_LerpTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MenuScreen.NativeFieldInfoPtr_LerpTime, (void*)(&value));
			}
		}

		// Token: 0x17003C49 RID: 15433
		// (get) Token: 0x0600C6BB RID: 50875 RVA: 0x003256A4 File Offset: 0x003238A4
		// (set) Token: 0x0600C6BC RID: 50876 RVA: 0x0005DCC6 File Offset: 0x0005BEC6
		public unsafe static float LerpScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MenuScreen.NativeFieldInfoPtr_LerpScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MenuScreen.NativeFieldInfoPtr_LerpScale, (void*)(&value));
			}
		}

		// Token: 0x17003C4A RID: 15434
		// (get) Token: 0x0600C6BD RID: 50877 RVA: 0x003256C0 File Offset: 0x003238C0
		// (set) Token: 0x0600C6BE RID: 50878 RVA: 0x0005DCD4 File Offset: 0x0005BED4
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003C4B RID: 15435
		// (get) Token: 0x0600C6BF RID: 50879 RVA: 0x003256E8 File Offset: 0x003238E8
		// (set) Token: 0x0600C6C0 RID: 50880 RVA: 0x0005DCEF File Offset: 0x0005BEEF
		public unsafe int ExitInputPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.NativeFieldInfoPtr_ExitInputPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.NativeFieldInfoPtr_ExitInputPriority)) = value;
			}
		}

		// Token: 0x17003C4C RID: 15436
		// (get) Token: 0x0600C6C1 RID: 50881 RVA: 0x00325710 File Offset: 0x00323910
		// (set) Token: 0x0600C6C2 RID: 50882 RVA: 0x0005DD0A File Offset: 0x0005BF0A
		public unsafe bool OpenOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.NativeFieldInfoPtr_OpenOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.NativeFieldInfoPtr_OpenOnStart)) = value;
			}
		}

		// Token: 0x17003C4D RID: 15437
		// (get) Token: 0x0600C6C3 RID: 50883 RVA: 0x00325738 File Offset: 0x00323938
		// (set) Token: 0x0600C6C4 RID: 50884 RVA: 0x0005DD25 File Offset: 0x0005BF25
		public unsafe bool AttachLobbyToScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.NativeFieldInfoPtr_AttachLobbyToScreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.NativeFieldInfoPtr_AttachLobbyToScreen)) = value;
			}
		}

		// Token: 0x17003C4E RID: 15438
		// (get) Token: 0x0600C6C5 RID: 50885 RVA: 0x00325760 File Offset: 0x00323960
		// (set) Token: 0x0600C6C6 RID: 50886 RVA: 0x0005DD40 File Offset: 0x0005BF40
		public unsafe MenuScreen PreviousScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.NativeFieldInfoPtr_PreviousScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MenuScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.NativeFieldInfoPtr_PreviousScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C4F RID: 15439
		// (get) Token: 0x0600C6C7 RID: 50887 RVA: 0x00325790 File Offset: 0x00323990
		// (set) Token: 0x0600C6C8 RID: 50888 RVA: 0x0005DD5F File Offset: 0x0005BF5F
		public unsafe CanvasGroup Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.NativeFieldInfoPtr_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C50 RID: 15440
		// (get) Token: 0x0600C6C9 RID: 50889 RVA: 0x003257C0 File Offset: 0x003239C0
		// (set) Token: 0x0600C6CA RID: 50890 RVA: 0x0005DD7E File Offset: 0x0005BF7E
		public unsafe MonoState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C51 RID: 15441
		// (get) Token: 0x0600C6CB RID: 50891 RVA: 0x003257F0 File Offset: 0x003239F0
		// (set) Token: 0x0600C6CC RID: 50892 RVA: 0x0005DD9D File Offset: 0x0005BF9D
		public unsafe UIScreen uiScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.NativeFieldInfoPtr_uiScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.NativeFieldInfoPtr_uiScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C52 RID: 15442
		// (get) Token: 0x0600C6CD RID: 50893 RVA: 0x00325820 File Offset: 0x00323A20
		// (set) Token: 0x0600C6CE RID: 50894 RVA: 0x0005DDBC File Offset: 0x0005BFBC
		public unsafe UIPanel uiPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.NativeFieldInfoPtr_uiPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.NativeFieldInfoPtr_uiPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C53 RID: 15443
		// (get) Token: 0x0600C6CF RID: 50895 RVA: 0x00325850 File Offset: 0x00323A50
		// (set) Token: 0x0600C6D0 RID: 50896 RVA: 0x0005DDDB File Offset: 0x0005BFDB
		public unsafe RectTransform rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.NativeFieldInfoPtr_rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.NativeFieldInfoPtr_rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C54 RID: 15444
		// (get) Token: 0x0600C6D1 RID: 50897 RVA: 0x00325880 File Offset: 0x00323A80
		// (set) Token: 0x0600C6D2 RID: 50898 RVA: 0x0005DDFA File Offset: 0x0005BFFA
		public unsafe Coroutine lerpRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.NativeFieldInfoPtr_lerpRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.NativeFieldInfoPtr_lerpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400877B RID: 34683
		private static readonly IntPtr NativeFieldInfoPtr__Current_k__BackingField;

		// Token: 0x0400877C RID: 34684
		private static readonly IntPtr NativeFieldInfoPtr_LerpTime;

		// Token: 0x0400877D RID: 34685
		private static readonly IntPtr NativeFieldInfoPtr_LerpScale;

		// Token: 0x0400877E RID: 34686
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400877F RID: 34687
		private static readonly IntPtr NativeFieldInfoPtr_ExitInputPriority;

		// Token: 0x04008780 RID: 34688
		private static readonly IntPtr NativeFieldInfoPtr_OpenOnStart;

		// Token: 0x04008781 RID: 34689
		private static readonly IntPtr NativeFieldInfoPtr_AttachLobbyToScreen;

		// Token: 0x04008782 RID: 34690
		private static readonly IntPtr NativeFieldInfoPtr_PreviousScreen;

		// Token: 0x04008783 RID: 34691
		private static readonly IntPtr NativeFieldInfoPtr_Group;

		// Token: 0x04008784 RID: 34692
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04008785 RID: 34693
		private static readonly IntPtr NativeFieldInfoPtr_uiScreen;

		// Token: 0x04008786 RID: 34694
		private static readonly IntPtr NativeFieldInfoPtr_uiPanel;

		// Token: 0x04008787 RID: 34695
		private static readonly IntPtr NativeFieldInfoPtr_rect;

		// Token: 0x04008788 RID: 34696
		private static readonly IntPtr NativeFieldInfoPtr_lerpRoutine;

		// Token: 0x04008789 RID: 34697
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Static_get_MenuScreen_0;

		// Token: 0x0400878A RID: 34698
		private static readonly IntPtr NativeMethodInfoPtr_set_Current_Private_Static_set_Void_MenuScreen_0;

		// Token: 0x0400878B RID: 34699
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400878C RID: 34700
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x0400878D RID: 34701
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400878E RID: 34702
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400878F RID: 34703
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0;

		// Token: 0x04008790 RID: 34704
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_Boolean_0;

		// Token: 0x04008791 RID: 34705
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04008792 RID: 34706
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04008793 RID: 34707
		private static readonly IntPtr NativeMethodInfoPtr_OnOpen_Protected_Virtual_New_Void_0;

		// Token: 0x04008794 RID: 34708
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Protected_Virtual_New_Void_0;

		// Token: 0x04008795 RID: 34709
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Private_Void_Boolean_0;

		// Token: 0x04008796 RID: 34710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D69 RID: 3433
		[ObfuscatedName("ScheduleOne.UI.MainMenu.MenuScreen+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FB22 RID: 64290 RVA: 0x003BF984 File Offset: 0x003BDB84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MenuScreen>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0>.NativeClassPtr);
				MenuScreen.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0>.NativeClassPtr, "<>4__this");
				MenuScreen.__c__DisplayClass28_0.NativeFieldInfoPtr_open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0>.NativeClassPtr, "open");
				MenuScreen.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0>.NativeClassPtr, 100689039);
				MenuScreen.__c__DisplayClass28_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0>.NativeClassPtr, 100689040);
			}

			// Token: 0x0600FB23 RID: 64291 RVA: 0x003BFA00 File Offset: 0x003BDC00
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuScreen.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FB24 RID: 64292 RVA: 0x003BFA3C File Offset: 0x003BDC3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327942, XrefRangeEnd = 327947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuScreen.__c__DisplayClass28_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600FB25 RID: 64293 RVA: 0x00076D14 File Offset: 0x00074F14
			public __c__DisplayClass28_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C4F RID: 19535
			// (get) Token: 0x0600FB26 RID: 64294 RVA: 0x003BFA7C File Offset: 0x003BDC7C
			// (set) Token: 0x0600FB27 RID: 64295 RVA: 0x00076D1D File Offset: 0x00074F1D
			public unsafe MenuScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MenuScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C50 RID: 19536
			// (get) Token: 0x0600FB28 RID: 64296 RVA: 0x003BFAAC File Offset: 0x003BDCAC
			// (set) Token: 0x0600FB29 RID: 64297 RVA: 0x00076D3C File Offset: 0x00074F3C
			public unsafe bool open
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.__c__DisplayClass28_0.NativeFieldInfoPtr_open);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.__c__DisplayClass28_0.NativeFieldInfoPtr_open)) = value;
				}
			}

			// Token: 0x0400A96F RID: 43375
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A970 RID: 43376
			private static readonly IntPtr NativeFieldInfoPtr_open;

			// Token: 0x0400A971 RID: 43377
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A972 RID: 43378
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000E1A RID: 3610
			[ObfuscatedName("ScheduleOne.UI.MainMenu.MenuScreen+<>c__DisplayClass28_0+<<Lerp>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique : Il2CppSystem.Object
			{
				// Token: 0x0601042D RID: 66605 RVA: 0x003DA010 File Offset: 0x003D8210
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique()
				{
					Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0>.NativeClassPtr, "<<Lerp>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr);
					MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<>1__state");
					MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<>2__current");
					MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<>4__this");
					MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startAlpha_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<startAlpha>5__2");
					MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startScale_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<startScale>5__3");
					MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endAlpha_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<endAlpha>5__4");
					MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endScale_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<endScale>5__5");
					MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__lerpTime_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<lerpTime>5__6");
					MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__i_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<i>5__7");
					MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100689041);
					MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100689042);
					MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100689043);
					MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100689044);
					MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100689045);
					MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100689046);
				}

				// Token: 0x0601042E RID: 66606 RVA: 0x003DA168 File Offset: 0x003D8368
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601042F RID: 66607 RVA: 0x003DA1B0 File Offset: 0x003D83B0
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06010430 RID: 66608 RVA: 0x003DA1E4 File Offset: 0x003D83E4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327916, XrefRangeEnd = 327937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004F9A RID: 20378
				// (get) Token: 0x06010431 RID: 66609 RVA: 0x003DA220 File Offset: 0x003D8420
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010432 RID: 66610 RVA: 0x003DA260 File Offset: 0x003D8460
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327937, XrefRangeEnd = 327942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004F9B RID: 20379
				// (get) Token: 0x06010433 RID: 66611 RVA: 0x003DA294 File Offset: 0x003D8494
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010434 RID: 66612 RVA: 0x0007B75C File Offset: 0x0007995C
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004F91 RID: 20369
				// (get) Token: 0x06010435 RID: 66613 RVA: 0x003DA2D4 File Offset: 0x003D84D4
				// (set) Token: 0x06010436 RID: 66614 RVA: 0x0007B765 File Offset: 0x00079965
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004F92 RID: 20370
				// (get) Token: 0x06010437 RID: 66615 RVA: 0x003DA2FC File Offset: 0x003D84FC
				// (set) Token: 0x06010438 RID: 66616 RVA: 0x0007B780 File Offset: 0x00079980
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F93 RID: 20371
				// (get) Token: 0x06010439 RID: 66617 RVA: 0x003DA32C File Offset: 0x003D852C
				// (set) Token: 0x0601043A RID: 66618 RVA: 0x0007B79F File Offset: 0x0007999F
				public unsafe MenuScreen.__c__DisplayClass28_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MenuScreen.__c__DisplayClass28_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F94 RID: 20372
				// (get) Token: 0x0601043B RID: 66619 RVA: 0x003DA35C File Offset: 0x003D855C
				// (set) Token: 0x0601043C RID: 66620 RVA: 0x0007B7BE File Offset: 0x000799BE
				public unsafe float _startAlpha_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startAlpha_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startAlpha_5__2)) = value;
					}
				}

				// Token: 0x17004F95 RID: 20373
				// (get) Token: 0x0601043D RID: 66621 RVA: 0x003DA384 File Offset: 0x003D8584
				// (set) Token: 0x0601043E RID: 66622 RVA: 0x0007B7D9 File Offset: 0x000799D9
				public unsafe float _startScale_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startScale_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startScale_5__3)) = value;
					}
				}

				// Token: 0x17004F96 RID: 20374
				// (get) Token: 0x0601043F RID: 66623 RVA: 0x003DA3AC File Offset: 0x003D85AC
				// (set) Token: 0x06010440 RID: 66624 RVA: 0x0007B7F4 File Offset: 0x000799F4
				public unsafe float _endAlpha_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endAlpha_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endAlpha_5__4)) = value;
					}
				}

				// Token: 0x17004F97 RID: 20375
				// (get) Token: 0x06010441 RID: 66625 RVA: 0x003DA3D4 File Offset: 0x003D85D4
				// (set) Token: 0x06010442 RID: 66626 RVA: 0x0007B80F File Offset: 0x00079A0F
				public unsafe float _endScale_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endScale_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endScale_5__5)) = value;
					}
				}

				// Token: 0x17004F98 RID: 20376
				// (get) Token: 0x06010443 RID: 66627 RVA: 0x003DA3FC File Offset: 0x003D85FC
				// (set) Token: 0x06010444 RID: 66628 RVA: 0x0007B82A File Offset: 0x00079A2A
				public unsafe float _lerpTime_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__lerpTime_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__lerpTime_5__6)) = value;
					}
				}

				// Token: 0x17004F99 RID: 20377
				// (get) Token: 0x06010445 RID: 66629 RVA: 0x003DA424 File Offset: 0x003D8624
				// (set) Token: 0x06010446 RID: 66630 RVA: 0x0007B845 File Offset: 0x00079A45
				public unsafe float _i_5__7
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__i_5__7);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuScreen.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__i_5__7)) = value;
					}
				}

				// Token: 0x0400AF08 RID: 44808
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AF09 RID: 44809
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AF0A RID: 44810
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AF0B RID: 44811
				private static readonly IntPtr NativeFieldInfoPtr__startAlpha_5__2;

				// Token: 0x0400AF0C RID: 44812
				private static readonly IntPtr NativeFieldInfoPtr__startScale_5__3;

				// Token: 0x0400AF0D RID: 44813
				private static readonly IntPtr NativeFieldInfoPtr__endAlpha_5__4;

				// Token: 0x0400AF0E RID: 44814
				private static readonly IntPtr NativeFieldInfoPtr__endScale_5__5;

				// Token: 0x0400AF0F RID: 44815
				private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__6;

				// Token: 0x0400AF10 RID: 44816
				private static readonly IntPtr NativeFieldInfoPtr__i_5__7;

				// Token: 0x0400AF11 RID: 44817
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AF12 RID: 44818
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AF13 RID: 44819
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AF14 RID: 44820
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AF15 RID: 44821
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AF16 RID: 44822
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
