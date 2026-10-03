using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000093 RID: 147
	public sealed class Screen : Object
	{
		// Token: 0x060007F2 RID: 2034 RVA: 0x00030200 File Offset: 0x0002E400
		// Note: this type is marked as 'beforefieldinit'.
		static Screen()
		{
			Il2CppClassPointerStore<Screen>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Screen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Screen>.NativeClassPtr);
			Screen.NativeMethodInfoPtr_get_width_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664142);
			Screen.NativeMethodInfoPtr_get_height_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664143);
			Screen.NativeMethodInfoPtr_get_dpi_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664144);
			Screen.NativeMethodInfoPtr_GetScreenOrientation_Private_Static_ScreenOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664145);
			Screen.NativeMethodInfoPtr_get_orientation_Public_Static_get_ScreenOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664146);
			Screen.NativeMethodInfoPtr_get_currentResolution_Public_Static_get_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664147);
			Screen.NativeMethodInfoPtr_get_fullScreen_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664148);
			Screen.NativeMethodInfoPtr_get_fullScreenMode_Public_Static_get_FullScreenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664149);
			Screen.NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_RefreshRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664150);
			Screen.NativeMethodInfoPtr_get_mainWindowDisplayInfo_Public_Static_get_DisplayInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664151);
			Screen.NativeMethodInfoPtr_GetDisplayLayout_Public_Static_Void_List_1_DisplayInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664152);
			Screen.NativeMethodInfoPtr_MoveMainWindowTo_Public_Static_AsyncOperation_byref_DisplayInfo_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664153);
			Screen.NativeMethodInfoPtr_GetMainWindowDisplayInfo_Private_Static_DisplayInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664154);
			Screen.NativeMethodInfoPtr_GetDisplayLayoutImpl_Private_Static_Void_List_1_DisplayInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664155);
			Screen.NativeMethodInfoPtr_MoveMainWindowImpl_Private_Static_AsyncOperation_byref_DisplayInfo_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664156);
			Screen.NativeMethodInfoPtr_get_resolutions_Public_Static_get_Il2CppStructArray_1_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664157);
			Screen.NativeMethodInfoPtr_get_currentResolution_Injected_Private_Static_Void_byref_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664158);
			Screen.NativeMethodInfoPtr_SetResolution_Injected_Private_Static_Void_Int32_Int32_FullScreenMode_byref_RefreshRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664159);
			Screen.NativeMethodInfoPtr_GetMainWindowDisplayInfo_Injected_Private_Static_Void_byref_DisplayInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664160);
			Screen.NativeMethodInfoPtr_MoveMainWindowImpl_Injected_Private_Static_AsyncOperation_byref_DisplayInfo_byref_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664161);
			Screen.RequestOrientationDelegateField = IL2CPP.ResolveICall<Screen.RequestOrientationDelegate>("UnityEngine.Screen::RequestOrientation");
			Screen.get_sleepTimeoutDelegateField = IL2CPP.ResolveICall<Screen.get_sleepTimeoutDelegate>("UnityEngine.Screen::get_sleepTimeout");
			Screen.set_sleepTimeoutDelegateField = IL2CPP.ResolveICall<Screen.set_sleepTimeoutDelegate>("UnityEngine.Screen::set_sleepTimeout");
			Screen.IsOrientationEnabledDelegateField = IL2CPP.ResolveICall<Screen.IsOrientationEnabledDelegate>("UnityEngine.Screen::IsOrientationEnabled");
			Screen.SetOrientationEnabledDelegateField = IL2CPP.ResolveICall<Screen.SetOrientationEnabledDelegate>("UnityEngine.Screen::SetOrientationEnabled");
			Screen.set_fullScreenDelegateField = IL2CPP.ResolveICall<Screen.set_fullScreenDelegate>("UnityEngine.Screen::set_fullScreen");
			Screen.set_fullScreenModeDelegateField = IL2CPP.ResolveICall<Screen.set_fullScreenModeDelegate>("UnityEngine.Screen::set_fullScreenMode");
			Screen.get_cutoutsDelegateField = IL2CPP.ResolveICall<Screen.get_cutoutsDelegate>("UnityEngine.Screen::get_cutouts");
			Screen.get_brightnessDelegateField = IL2CPP.ResolveICall<Screen.get_brightnessDelegate>("UnityEngine.Screen::get_brightness");
			Screen.set_brightnessDelegateField = IL2CPP.ResolveICall<Screen.set_brightnessDelegate>("UnityEngine.Screen::set_brightness");
			Screen.get_safeArea_InjectedDelegateField = IL2CPP.ResolveICall<Screen.get_safeArea_InjectedDelegate>("UnityEngine.Screen::get_safeArea_Injected");
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x00030468 File Offset: 0x0002E668
		public unsafe static int width
		{
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 1233664, RefRangeEnd = 1233692, XrefRangeStart = 1233662, XrefRangeEnd = 1233664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_width_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x00030498 File Offset: 0x0002E698
		public unsafe static int height
		{
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 1233694, RefRangeEnd = 1233736, XrefRangeStart = 1233692, XrefRangeEnd = 1233694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_height_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x000304C8 File Offset: 0x0002E6C8
		public unsafe static float dpi
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1233738, RefRangeEnd = 1233746, XrefRangeStart = 1233736, XrefRangeEnd = 1233738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_dpi_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x000304F8 File Offset: 0x0002E6F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1233748, RefRangeEnd = 1233752, XrefRangeStart = 1233746, XrefRangeEnd = 1233748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScreenOrientation GetScreenOrientation()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_GetScreenOrientation_Private_Static_ScreenOrientation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x00030528 File Offset: 0x0002E728
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x00030920 File Offset: 0x0002EB20
		public unsafe static ScreenOrientation orientation
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1233748, RefRangeEnd = 1233752, XrefRangeStart = 1233748, XrefRangeEnd = 1233752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_orientation_Public_Static_get_ScreenOrientation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = value == ScreenOrientation.Unknown;
				if (flag)
				{
					Debug.Log("ScreenOrientation.Unknown is deprecated. Please use ScreenOrientation.AutoRotation");
					value = ScreenOrientation.AutoRotation;
				}
				Screen.RequestOrientation(value);
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x00030558 File Offset: 0x0002E758
		public unsafe static Resolution currentResolution
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1233754, RefRangeEnd = 1233756, XrefRangeStart = 1233752, XrefRangeEnd = 1233754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_currentResolution_Public_Static_get_Resolution_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x00030588 File Offset: 0x0002E788
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x00005937 File Offset: 0x00003B37
		public unsafe static bool fullScreen
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1233758, RefRangeEnd = 1233760, XrefRangeStart = 1233756, XrefRangeEnd = 1233758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_fullScreen_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Screen.set_fullScreenDelegateField(value);
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x000305B8 File Offset: 0x0002E7B8
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x00005944 File Offset: 0x00003B44
		public unsafe static FullScreenMode fullScreenMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1233762, RefRangeEnd = 1233763, XrefRangeStart = 1233760, XrefRangeEnd = 1233762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_fullScreenMode_Public_Static_get_FullScreenMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Screen.set_fullScreenModeDelegateField(value);
			}
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x000305E8 File Offset: 0x0002E7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233763, XrefRangeEnd = 1233765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fullscreenMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preferredRefreshRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_RefreshRate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x00030644 File Offset: 0x0002E844
		public unsafe static DisplayInfo mainWindowDisplayInfo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1233767, RefRangeEnd = 1233768, XrefRangeStart = 1233765, XrefRangeEnd = 1233767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_mainWindowDisplayInfo_Public_Static_get_DisplayInfo_0, 0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new DisplayInfo(pointer);
			}
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00030670 File Offset: 0x0002E870
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1233775, RefRangeEnd = 1233777, XrefRangeStart = 1233768, XrefRangeEnd = 1233775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetDisplayLayout(List<DisplayInfo> displayLayout)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(displayLayout);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_GetDisplayLayout_Public_Static_Void_List_1_DisplayInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x000306A8 File Offset: 0x0002E8A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1233779, RefRangeEnd = 1233781, XrefRangeStart = 1233777, XrefRangeEnd = 1233779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation MoveMainWindowTo([In] ref DisplayInfo display, Vector2Int position)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(display));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_MoveMainWindowTo_Public_Static_AsyncOperation_byref_DisplayInfo_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00030700 File Offset: 0x0002E900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233781, XrefRangeEnd = 1233783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DisplayInfo GetMainWindowDisplayInfo()
		{
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_GetMainWindowDisplayInfo_Private_Static_DisplayInfo_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DisplayInfo(pointer);
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x0003072C File Offset: 0x0002E92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233783, XrefRangeEnd = 1233785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetDisplayLayoutImpl(List<DisplayInfo> displayLayout)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(displayLayout);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_GetDisplayLayoutImpl_Private_Static_Void_List_1_DisplayInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00030764 File Offset: 0x0002E964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233785, XrefRangeEnd = 1233787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation MoveMainWindowImpl([In] ref DisplayInfo display, Vector2Int position)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(display));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_MoveMainWindowImpl_Private_Static_AsyncOperation_byref_DisplayInfo_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x000307BC File Offset: 0x0002E9BC
		public unsafe static Il2CppStructArray<Resolution> resolutions
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1233789, RefRangeEnd = 1233791, XrefRangeStart = 1233787, XrefRangeEnd = 1233789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_resolutions_Public_Static_get_Il2CppStructArray_1_Resolution_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Resolution>>(intPtr3) : null;
			}
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x000307F0 File Offset: 0x0002E9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233791, XrefRangeEnd = 1233793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_currentResolution_Injected(out Resolution ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_currentResolution_Injected_Private_Static_Void_byref_Resolution_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00030824 File Offset: 0x0002EA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233793, XrefRangeEnd = 1233795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetResolution_Injected(int width, int height, FullScreenMode fullscreenMode, ref RefreshRate preferredRefreshRate)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fullscreenMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &preferredRefreshRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_SetResolution_Injected_Private_Static_Void_Int32_Int32_FullScreenMode_byref_RefreshRate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00030880 File Offset: 0x0002EA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233795, XrefRangeEnd = 1233797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetMainWindowDisplayInfo_Injected(out DisplayInfo ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_GetMainWindowDisplayInfo_Injected_Private_Static_Void_byref_DisplayInfo_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ret = ((intPtr4 == 0) ? null : new DisplayInfo(intPtr4));
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x000308C8 File Offset: 0x0002EAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233797, XrefRangeEnd = 1233799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation MoveMainWindowImpl_Injected([In] ref DisplayInfo display, ref Vector2Int position)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(display));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_MoveMainWindowImpl_Injected_Private_Static_AsyncOperation_byref_DisplayInfo_byref_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x000058C1 File Offset: 0x00003AC1
		public Screen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x000058CA File Offset: 0x00003ACA
		public static void RequestOrientation(ScreenOrientation orient)
		{
			Screen.RequestOrientationDelegateField(orient);
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x000058D7 File Offset: 0x00003AD7
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x000058E3 File Offset: 0x00003AE3
		public static int sleepTimeout
		{
			get
			{
				return Screen.get_sleepTimeoutDelegateField();
			}
			set
			{
				Screen.set_sleepTimeoutDelegateField(value);
			}
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x000058F0 File Offset: 0x00003AF0
		public static bool IsOrientationEnabled(EnabledOrientation orient)
		{
			return Screen.IsOrientationEnabledDelegateField(orient);
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x000058FD File Offset: 0x00003AFD
		public static void SetOrientationEnabled(EnabledOrientation orient, bool enabled)
		{
			Screen.SetOrientationEnabledDelegateField(orient, enabled);
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x00030950 File Offset: 0x0002EB50
		// (set) Token: 0x0600080F RID: 2063 RVA: 0x0000590B File Offset: 0x00003B0B
		public static bool autorotateToPortrait
		{
			get
			{
				return Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToPortrait);
			}
			set
			{
				Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToPortrait, value);
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x00030968 File Offset: 0x0002EB68
		// (set) Token: 0x06000811 RID: 2065 RVA: 0x00005916 File Offset: 0x00003B16
		public static bool autorotateToPortraitUpsideDown
		{
			get
			{
				return Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToPortraitUpsideDown);
			}
			set
			{
				Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToPortraitUpsideDown, value);
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x00030980 File Offset: 0x0002EB80
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x00005921 File Offset: 0x00003B21
		public static bool autorotateToLandscapeLeft
		{
			get
			{
				return Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeLeft);
			}
			set
			{
				Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeLeft, value);
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x00030998 File Offset: 0x0002EB98
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x0000592C File Offset: 0x00003B2C
		public static bool autorotateToLandscapeRight
		{
			get
			{
				return Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeRight);
			}
			set
			{
				Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeRight, value);
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x000309B0 File Offset: 0x0002EBB0
		public static Rect safeArea
		{
			get
			{
				Rect result;
				Screen.get_safeArea_Injected(out result);
				return result;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x000309C8 File Offset: 0x0002EBC8
		public static Il2CppStructArray<Rect> cutouts
		{
			get
			{
				IntPtr intPtr = Screen.get_cutoutsDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Rect>>(intPtr2) : null;
			}
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x000309F0 File Offset: 0x0002EBF0
		public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate)
		{
			bool flag = preferredRefreshRate < 0;
			if (flag)
			{
				preferredRefreshRate = 0;
			}
			Screen.SetResolution(width, height, fullscreenMode, new RefreshRate
			{
				numerator = (uint)preferredRefreshRate,
				denominator = 1U
			});
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00030A2C File Offset: 0x0002EC2C
		public static void SetResolution(int width, int height, FullScreenMode fullscreenMode)
		{
			Screen.SetResolution(width, height, fullscreenMode, new RefreshRate
			{
				numerator = 0U,
				denominator = 1U
			});
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00030A5C File Offset: 0x0002EC5C
		public static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate)
		{
			bool flag = preferredRefreshRate < 0;
			if (flag)
			{
				preferredRefreshRate = 0;
			}
			Screen.SetResolution(width, height, fullscreen ? FullScreenMode.FullScreenWindow : FullScreenMode.Windowed, new RefreshRate
			{
				numerator = (uint)preferredRefreshRate,
				denominator = 1U
			});
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00005951 File Offset: 0x00003B51
		public static void SetResolution(int width, int height, bool fullscreen)
		{
			Screen.SetResolution(width, height, fullscreen, 0);
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x00030AA0 File Offset: 0x0002ECA0
		public static Vector2Int mainWindowPosition
		{
			get
			{
				return Vector2Int.zero;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x0000595E File Offset: 0x00003B5E
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x0000596A File Offset: 0x00003B6A
		public static float brightness
		{
			get
			{
				return Screen.get_brightnessDelegateField();
			}
			set
			{
				Screen.set_brightnessDelegateField(value);
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x00030AB8 File Offset: 0x0002ECB8
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x00030AD4 File Offset: 0x0002ECD4
		public static bool lockCursor
		{
			get
			{
				return CursorLockMode.Locked == Cursor.lockState;
			}
			set
			{
				if (value)
				{
					Cursor.visible = false;
					Cursor.lockState = CursorLockMode.Locked;
				}
				else
				{
					Cursor.lockState = CursorLockMode.None;
					Cursor.visible = true;
				}
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00005977 File Offset: 0x00003B77
		public static void get_safeArea_Injected(out Rect ret)
		{
			Screen.get_safeArea_InjectedDelegateField(out ret);
		}

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_Static_get_Int32_0;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_Static_get_Int32_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_get_dpi_Public_Static_get_Single_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr_GetScreenOrientation_Private_Static_ScreenOrientation_0;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_get_orientation_Public_Static_get_ScreenOrientation_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr_get_currentResolution_Public_Static_get_Resolution_0;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_get_fullScreen_Public_Static_get_Boolean_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_get_fullScreenMode_Public_Static_get_FullScreenMode_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_RefreshRate_0;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_get_mainWindowDisplayInfo_Public_Static_get_DisplayInfo_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayLayout_Public_Static_Void_List_1_DisplayInfo_0;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr_MoveMainWindowTo_Public_Static_AsyncOperation_byref_DisplayInfo_Vector2Int_0;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr_GetMainWindowDisplayInfo_Private_Static_DisplayInfo_0;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayLayoutImpl_Private_Static_Void_List_1_DisplayInfo_0;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_MoveMainWindowImpl_Private_Static_AsyncOperation_byref_DisplayInfo_Vector2Int_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr_get_resolutions_Public_Static_get_Il2CppStructArray_1_Resolution_0;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr_get_currentResolution_Injected_Private_Static_Void_byref_Resolution_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr_SetResolution_Injected_Private_Static_Void_Int32_Int32_FullScreenMode_byref_RefreshRate_0;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeMethodInfoPtr_GetMainWindowDisplayInfo_Injected_Private_Static_Void_byref_DisplayInfo_0;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeMethodInfoPtr_MoveMainWindowImpl_Injected_Private_Static_AsyncOperation_byref_DisplayInfo_byref_Vector2Int_0;

		// Token: 0x04000679 RID: 1657
		private static readonly Screen.RequestOrientationDelegate RequestOrientationDelegateField;

		// Token: 0x0400067A RID: 1658
		private static readonly Screen.get_sleepTimeoutDelegate get_sleepTimeoutDelegateField;

		// Token: 0x0400067B RID: 1659
		private static readonly Screen.set_sleepTimeoutDelegate set_sleepTimeoutDelegateField;

		// Token: 0x0400067C RID: 1660
		private static readonly Screen.IsOrientationEnabledDelegate IsOrientationEnabledDelegateField;

		// Token: 0x0400067D RID: 1661
		private static readonly Screen.SetOrientationEnabledDelegate SetOrientationEnabledDelegateField;

		// Token: 0x0400067E RID: 1662
		private static readonly Screen.set_fullScreenDelegate set_fullScreenDelegateField;

		// Token: 0x0400067F RID: 1663
		private static readonly Screen.set_fullScreenModeDelegate set_fullScreenModeDelegateField;

		// Token: 0x04000680 RID: 1664
		private static readonly Screen.get_cutoutsDelegate get_cutoutsDelegateField;

		// Token: 0x04000681 RID: 1665
		private static readonly Screen.get_brightnessDelegate get_brightnessDelegateField;

		// Token: 0x04000682 RID: 1666
		private static readonly Screen.set_brightnessDelegate set_brightnessDelegateField;

		// Token: 0x04000683 RID: 1667
		private static readonly Screen.get_safeArea_InjectedDelegate get_safeArea_InjectedDelegateField;

		// Token: 0x02000519 RID: 1305
		// (Invoke) Token: 0x060032EC RID: 13036
		private delegate void RequestOrientationDelegate(ScreenOrientation orient);

		// Token: 0x0200051A RID: 1306
		// (Invoke) Token: 0x060032EE RID: 13038
		private delegate int get_sleepTimeoutDelegate();

		// Token: 0x0200051B RID: 1307
		// (Invoke) Token: 0x060032F0 RID: 13040
		private delegate void set_sleepTimeoutDelegate(int value);

		// Token: 0x0200051C RID: 1308
		// (Invoke) Token: 0x060032F2 RID: 13042
		private delegate bool IsOrientationEnabledDelegate(EnabledOrientation orient);

		// Token: 0x0200051D RID: 1309
		// (Invoke) Token: 0x060032F4 RID: 13044
		private delegate void SetOrientationEnabledDelegate(EnabledOrientation orient, bool enabled);

		// Token: 0x0200051E RID: 1310
		// (Invoke) Token: 0x060032F6 RID: 13046
		private delegate void set_fullScreenDelegate(bool value);

		// Token: 0x0200051F RID: 1311
		// (Invoke) Token: 0x060032F8 RID: 13048
		private delegate void set_fullScreenModeDelegate(FullScreenMode value);

		// Token: 0x02000520 RID: 1312
		// (Invoke) Token: 0x060032FA RID: 13050
		private delegate IntPtr get_cutoutsDelegate();

		// Token: 0x02000521 RID: 1313
		// (Invoke) Token: 0x060032FC RID: 13052
		private delegate float get_brightnessDelegate();

		// Token: 0x02000522 RID: 1314
		// (Invoke) Token: 0x060032FE RID: 13054
		private delegate void set_brightnessDelegate(float value);

		// Token: 0x02000523 RID: 1315
		// (Invoke) Token: 0x06003300 RID: 13056
		private delegate void get_safeArea_InjectedDelegate([Out] IntPtr ret);
	}
}
