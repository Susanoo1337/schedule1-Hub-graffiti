using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200008F RID: 143
	public class Display : Object
	{
		// Token: 0x060007AD RID: 1965 RVA: 0x0002F724 File Offset: 0x0002D924
		// Note: this type is marked as 'beforefieldinit'.
		static Display()
		{
			Il2CppClassPointerStore<Display>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Display");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Display>.NativeClassPtr);
			Display.NativeFieldInfoPtr_nativeDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "nativeDisplay");
			Display.NativeFieldInfoPtr_displays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "displays");
			Display.NativeFieldInfoPtr__mainDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "_mainDisplay");
			Display.NativeFieldInfoPtr_m_ActiveEditorGameViewTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "m_ActiveEditorGameViewTarget");
			Display.NativeFieldInfoPtr_onDisplaysUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "onDisplaysUpdated");
			Display.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664119);
			Display.NativeMethodInfoPtr_get_renderingWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664121);
			Display.NativeMethodInfoPtr_get_renderingHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664122);
			Display.NativeMethodInfoPtr_get_systemWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664123);
			Display.NativeMethodInfoPtr_get_systemHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664124);
			Display.NativeMethodInfoPtr_get_requiresSrgbBlitToBackbuffer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664125);
			Display.NativeMethodInfoPtr_RelativeMouseAt_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664126);
			Display.NativeMethodInfoPtr_get_main_Public_Static_get_Display_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664127);
			Display.NativeMethodInfoPtr_RecreateDisplayList_Internal_Static_Void_Il2CppStructArray_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664128);
			Display.NativeMethodInfoPtr_FireDisplaysUpdated_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664129);
			Display.NativeMethodInfoPtr_GetSystemExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664130);
			Display.NativeMethodInfoPtr_GetRenderingExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664131);
			Display.NativeMethodInfoPtr_RelativeMouseAtImpl_Private_Static_Int32_Int32_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664132);
			Display.NativeMethodInfoPtr_RequiresSrgbBlitToBackbufferImpl_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100664133);
			Display.GetRenderingBuffersImplDelegateField = IL2CPP.ResolveICall<Display.GetRenderingBuffersImplDelegate>("UnityEngine.Display::GetRenderingBuffersImpl");
			Display.SetRenderingResolutionImplDelegateField = IL2CPP.ResolveICall<Display.SetRenderingResolutionImplDelegate>("UnityEngine.Display::SetRenderingResolutionImpl");
			Display.SetParamsImplDelegateField = IL2CPP.ResolveICall<Display.SetParamsImplDelegate>("UnityEngine.Display::SetParamsImpl");
			Display.GetActiveImplDelegateField = IL2CPP.ResolveICall<Display.GetActiveImplDelegate>("UnityEngine.Display::GetActiveImpl");
			Display.RequiresBlitToBackbufferImplDelegateField = IL2CPP.ResolveICall<Display.RequiresBlitToBackbufferImplDelegate>("UnityEngine.Display::RequiresBlitToBackbufferImpl");
			Display.ActivateDisplayImpl_InjectedDelegateField = IL2CPP.ResolveICall<Display.ActivateDisplayImpl_InjectedDelegate>("UnityEngine.Display::ActivateDisplayImpl_Injected");
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0002F92C File Offset: 0x0002DB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233516, XrefRangeEnd = 1233518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Display() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Display>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x0002F968 File Offset: 0x0002DB68
		public unsafe int renderingWidth
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1233523, RefRangeEnd = 1233532, XrefRangeStart = 1233518, XrefRangeEnd = 1233523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_renderingWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x0002F9A4 File Offset: 0x0002DBA4
		public unsafe int renderingHeight
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1233537, RefRangeEnd = 1233547, XrefRangeStart = 1233532, XrefRangeEnd = 1233537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_renderingHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x0002F9E0 File Offset: 0x0002DBE0
		public unsafe int systemWidth
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1233552, RefRangeEnd = 1233559, XrefRangeStart = 1233547, XrefRangeEnd = 1233552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_systemWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x0002FA1C File Offset: 0x0002DC1C
		public unsafe int systemHeight
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1233564, RefRangeEnd = 1233575, XrefRangeStart = 1233559, XrefRangeEnd = 1233564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_systemHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x0002FA58 File Offset: 0x0002DC58
		public unsafe bool requiresSrgbBlitToBackbuffer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1233580, RefRangeEnd = 1233581, XrefRangeStart = 1233575, XrefRangeEnd = 1233580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_requiresSrgbBlitToBackbuffer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0002FA94 File Offset: 0x0002DC94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1233586, RefRangeEnd = 1233589, XrefRangeStart = 1233581, XrefRangeEnd = 1233586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inputMouseCoordinates;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_RelativeMouseAt_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x0002FAD4 File Offset: 0x0002DCD4
		public unsafe static Display main
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1233593, RefRangeEnd = 1233595, XrefRangeStart = 1233589, XrefRangeEnd = 1233593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_main_Public_Static_get_Display_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Display>(intPtr3) : null;
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0002FB08 File Offset: 0x0002DD08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233595, XrefRangeEnd = 1233616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecreateDisplayList(Il2CppStructArray<IntPtr> nativeDisplay)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(nativeDisplay);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_RecreateDisplayList_Internal_Static_Void_Il2CppStructArray_1_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0002FB40 File Offset: 0x0002DD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233616, XrefRangeEnd = 1233622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FireDisplaysUpdated()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_FireDisplaysUpdated_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0002FB68 File Offset: 0x0002DD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233622, XrefRangeEnd = 1233624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nativeDisplay;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_GetSystemExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x0002FBB8 File Offset: 0x0002DDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233624, XrefRangeEnd = 1233626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nativeDisplay;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_GetRenderingExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x0002FC08 File Offset: 0x0002DE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233626, XrefRangeEnd = 1233628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rx;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ry;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_RelativeMouseAtImpl_Private_Static_Int32_Int32_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0002FC70 File Offset: 0x0002DE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233628, XrefRangeEnd = 1233654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RequiresSrgbBlitToBackbufferImpl(IntPtr nativeDisplay)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nativeDisplay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_RequiresSrgbBlitToBackbufferImpl_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x000056B9 File Offset: 0x000038B9
		public Display(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x0002FCB0 File Offset: 0x0002DEB0
		// (set) Token: 0x060007BE RID: 1982 RVA: 0x000056C2 File Offset: 0x000038C2
		public unsafe IntPtr nativeDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Display.NativeFieldInfoPtr_nativeDisplay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Display.NativeFieldInfoPtr_nativeDisplay)) = value;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x0002FCD8 File Offset: 0x0002DED8
		// (set) Token: 0x060007C0 RID: 1984 RVA: 0x000056DD File Offset: 0x000038DD
		public unsafe static Il2CppReferenceArray<Display> displays
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Display.NativeFieldInfoPtr_displays, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Display>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Display.NativeFieldInfoPtr_displays, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x0002FD00 File Offset: 0x0002DF00
		// (set) Token: 0x060007C2 RID: 1986 RVA: 0x000056EF File Offset: 0x000038EF
		public unsafe static Display _mainDisplay
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Display.NativeFieldInfoPtr__mainDisplay, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Display>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Display.NativeFieldInfoPtr__mainDisplay, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x0002FD28 File Offset: 0x0002DF28
		// (set) Token: 0x060007C4 RID: 1988 RVA: 0x00005701 File Offset: 0x00003901
		public unsafe static int m_ActiveEditorGameViewTarget
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Display.NativeFieldInfoPtr_m_ActiveEditorGameViewTarget, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Display.NativeFieldInfoPtr_m_ActiveEditorGameViewTarget, (void*)(&value));
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x0002FD44 File Offset: 0x0002DF44
		// (set) Token: 0x060007C6 RID: 1990 RVA: 0x0000570F File Offset: 0x0000390F
		public unsafe static Display.DisplaysUpdatedDelegate onDisplaysUpdated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Display.NativeFieldInfoPtr_onDisplaysUpdated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Display.DisplaysUpdatedDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Display.NativeFieldInfoPtr_onDisplaysUpdated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x0002FD6C File Offset: 0x0002DF6C
		public RenderBuffer colorBuffer
		{
			get
			{
				RenderBuffer result;
				RenderBuffer renderBuffer;
				Display.GetRenderingBuffersImpl(this.nativeDisplay, out result, out renderBuffer);
				return result;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x0002FD90 File Offset: 0x0002DF90
		public RenderBuffer depthBuffer
		{
			get
			{
				RenderBuffer renderBuffer;
				RenderBuffer result;
				Display.GetRenderingBuffersImpl(this.nativeDisplay, out renderBuffer, out result);
				return result;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x0002FDB4 File Offset: 0x0002DFB4
		public bool active
		{
			get
			{
				return Display.GetActiveImpl(this.nativeDisplay);
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x00005721 File Offset: 0x00003921
		public bool requiresBlitToBackbuffer
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0002FDD4 File Offset: 0x0002DFD4
		public void Activate()
		{
			Display.ActivateDisplayImpl(this.nativeDisplay, 0, 0, new RefreshRate
			{
				numerator = 60U,
				denominator = 1U
			});
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x0000572E File Offset: 0x0000392E
		public void Activate(int width, int height, RefreshRate refreshRate)
		{
			Display.ActivateDisplayImpl(this.nativeDisplay, width, height, refreshRate);
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0002FE0C File Offset: 0x0002E00C
		public void Activate(int width, int height, int refreshRate)
		{
			bool flag = refreshRate < 0;
			if (flag)
			{
				refreshRate = 0;
			}
			Display.ActivateDisplayImpl(this.nativeDisplay, width, height, new RefreshRate
			{
				numerator = (uint)refreshRate,
				denominator = 1U
			});
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00005740 File Offset: 0x00003940
		public void SetParams(int width, int height, int x, int y)
		{
			Display.SetParamsImpl(this.nativeDisplay, width, height, x, y);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00005754 File Offset: 0x00003954
		public void SetRenderingResolution(int w, int h)
		{
			Display.SetRenderingResolutionImpl(this.nativeDisplay, w, h);
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0002FE4C File Offset: 0x0002E04C
		public static bool MultiDisplayLicense()
		{
			return true;
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x0002FE60 File Offset: 0x0002E060
		// (set) Token: 0x060007D2 RID: 2002 RVA: 0x00005765 File Offset: 0x00003965
		public static int activeEditorGameViewTarget
		{
			get
			{
				return Display.m_ActiveEditorGameViewTarget;
			}
			set
			{
				Display.m_ActiveEditorGameViewTarget = value;
			}
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0000576E File Offset: 0x0000396E
		public static void add_onDisplaysUpdated(Display.DisplaysUpdatedDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x0000577B File Offset: 0x0000397B
		public static void remove_onDisplaysUpdated(Display.DisplaysUpdatedDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00005788 File Offset: 0x00003988
		public static void GetRenderingBuffersImpl(IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth)
		{
			Display.GetRenderingBuffersImplDelegateField(nativeDisplay, out color, out depth);
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00005797 File Offset: 0x00003997
		public static void SetRenderingResolutionImpl(IntPtr nativeDisplay, int w, int h)
		{
			Display.SetRenderingResolutionImplDelegateField(nativeDisplay, w, h);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x000057A6 File Offset: 0x000039A6
		public static void ActivateDisplayImpl(IntPtr nativeDisplay, int width, int height, RefreshRate refreshRate)
		{
			Display.ActivateDisplayImpl_Injected(nativeDisplay, width, height, ref refreshRate);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x000057B2 File Offset: 0x000039B2
		public static void SetParamsImpl(IntPtr nativeDisplay, int width, int height, int x, int y)
		{
			Display.SetParamsImplDelegateField(nativeDisplay, width, height, x, y);
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x000057C4 File Offset: 0x000039C4
		public static bool GetActiveImpl(IntPtr nativeDisplay)
		{
			return Display.GetActiveImplDelegateField(nativeDisplay);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x000057D1 File Offset: 0x000039D1
		public static bool RequiresBlitToBackbufferImpl(IntPtr nativeDisplay)
		{
			return Display.RequiresBlitToBackbufferImplDelegateField(nativeDisplay);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x000057DE File Offset: 0x000039DE
		public static void ActivateDisplayImpl_Injected(IntPtr nativeDisplay, int width, int height, ref RefreshRate refreshRate)
		{
			Display.ActivateDisplayImpl_InjectedDelegateField(nativeDisplay, width, height, ref refreshRate);
		}

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeFieldInfoPtr_nativeDisplay;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeFieldInfoPtr_displays;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeFieldInfoPtr__mainDisplay;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveEditorGameViewTarget;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeFieldInfoPtr_onDisplaysUpdated;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingWidth_Public_get_Int32_0;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingHeight_Public_get_Int32_0;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeMethodInfoPtr_get_systemWidth_Public_get_Int32_0;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeMethodInfoPtr_get_systemHeight_Public_get_Int32_0;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeMethodInfoPtr_get_requiresSrgbBlitToBackbuffer_Public_get_Boolean_0;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeMethodInfoPtr_RelativeMouseAt_Public_Static_Vector3_Vector3_0;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeMethodInfoPtr_get_main_Public_Static_get_Display_0;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr_RecreateDisplayList_Internal_Static_Void_Il2CppStructArray_1_IntPtr_0;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr_FireDisplaysUpdated_Internal_Static_Void_0;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderingExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeMethodInfoPtr_RelativeMouseAtImpl_Private_Static_Int32_Int32_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeMethodInfoPtr_RequiresSrgbBlitToBackbufferImpl_Private_Static_Boolean_IntPtr_0;

		// Token: 0x0400064B RID: 1611
		private static readonly Display.GetRenderingBuffersImplDelegate GetRenderingBuffersImplDelegateField;

		// Token: 0x0400064C RID: 1612
		private static readonly Display.SetRenderingResolutionImplDelegate SetRenderingResolutionImplDelegateField;

		// Token: 0x0400064D RID: 1613
		private static readonly Display.SetParamsImplDelegate SetParamsImplDelegateField;

		// Token: 0x0400064E RID: 1614
		private static readonly Display.GetActiveImplDelegate GetActiveImplDelegateField;

		// Token: 0x0400064F RID: 1615
		private static readonly Display.RequiresBlitToBackbufferImplDelegate RequiresBlitToBackbufferImplDelegateField;

		// Token: 0x04000650 RID: 1616
		private static readonly Display.ActivateDisplayImpl_InjectedDelegate ActivateDisplayImpl_InjectedDelegateField;

		// Token: 0x02000512 RID: 1298
		public sealed class DisplaysUpdatedDelegate : MulticastDelegate
		{
			// Token: 0x060032D8 RID: 13016 RVA: 0x00015C8B File Offset: 0x00013E8B
			// Note: this type is marked as 'beforefieldinit'.
			static DisplaysUpdatedDelegate()
			{
				Il2CppClassPointerStore<Display.DisplaysUpdatedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Display>.NativeClassPtr, "DisplaysUpdatedDelegate");
				Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display.DisplaysUpdatedDelegate>.NativeClassPtr, 100664135);
				Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display.DisplaysUpdatedDelegate>.NativeClassPtr, 100664136);
			}

			// Token: 0x060032D9 RID: 13017 RVA: 0x000B0A6C File Offset: 0x000AEC6C
			[CallerCount(1472)]
			[CachedScanResults(RefRangeStart = 20074, RefRangeEnd = 21546, XrefRangeStart = 20074, XrefRangeEnd = 21546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DisplaysUpdatedDelegate(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Display.DisplaysUpdatedDelegate>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032DA RID: 13018 RVA: 0x000B0AC8 File Offset: 0x000AECC8
			[CallerCount(0)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032DB RID: 13019 RVA: 0x00015CC9 File Offset: 0x00013EC9
			public DisplaysUpdatedDelegate(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x060032DC RID: 13020 RVA: 0x00015CD2 File Offset: 0x00013ED2
			public static implicit operator Display.DisplaysUpdatedDelegate(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<Display.DisplaysUpdatedDelegate>(A_0);
			}

			// Token: 0x060032DD RID: 13021 RVA: 0x00015CDA File Offset: 0x00013EDA
			public static Display.DisplaysUpdatedDelegate operator +(Display.DisplaysUpdatedDelegate A_0, Display.DisplaysUpdatedDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Display.DisplaysUpdatedDelegate>();
			}

			// Token: 0x060032DE RID: 13022 RVA: 0x00015CE8 File Offset: 0x00013EE8
			public static Display.DisplaysUpdatedDelegate operator -(Display.DisplaysUpdatedDelegate A_0, Display.DisplaysUpdatedDelegate A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Display.DisplaysUpdatedDelegate>();
				}
				return result;
			}

			// Token: 0x04002A93 RID: 10899
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002A94 RID: 10900
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
		}

		// Token: 0x02000513 RID: 1299
		// (Invoke) Token: 0x060032E0 RID: 13024
		private delegate void GetRenderingBuffersImplDelegate(IntPtr nativeDisplay, [Out] IntPtr color, [Out] IntPtr depth);

		// Token: 0x02000514 RID: 1300
		// (Invoke) Token: 0x060032E2 RID: 13026
		private delegate void SetRenderingResolutionImplDelegate(IntPtr nativeDisplay, int w, int h);

		// Token: 0x02000515 RID: 1301
		// (Invoke) Token: 0x060032E4 RID: 13028
		private delegate void SetParamsImplDelegate(IntPtr nativeDisplay, int width, int height, int x, int y);

		// Token: 0x02000516 RID: 1302
		// (Invoke) Token: 0x060032E6 RID: 13030
		private delegate bool GetActiveImplDelegate(IntPtr nativeDisplay);

		// Token: 0x02000517 RID: 1303
		// (Invoke) Token: 0x060032E8 RID: 13032
		private delegate bool RequiresBlitToBackbufferImplDelegate(IntPtr nativeDisplay);

		// Token: 0x02000518 RID: 1304
		// (Invoke) Token: 0x060032EA RID: 13034
		private delegate void ActivateDisplayImpl_InjectedDelegate(IntPtr nativeDisplay, int width, int height, IntPtr refreshRate);
	}
}
