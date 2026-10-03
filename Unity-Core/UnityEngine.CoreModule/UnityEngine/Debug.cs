using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200007C RID: 124
	public class Debug : Object
	{
		// Token: 0x060005BB RID: 1467 RVA: 0x00028BF8 File Offset: 0x00026DF8
		// Note: this type is marked as 'beforefieldinit'.
		static Debug()
		{
			Il2CppClassPointerStore<Debug>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Debug");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Debug>.NativeClassPtr);
			Debug.NativeFieldInfoPtr_s_DefaultLogger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug>.NativeClassPtr, "s_DefaultLogger");
			Debug.NativeFieldInfoPtr_s_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug>.NativeClassPtr, "s_Logger");
			Debug.NativeMethodInfoPtr_get_unityLogger_Public_Static_get_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663875);
			Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663876);
			Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663877);
			Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663878);
			Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663879);
			Debug.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663880);
			Debug.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663881);
			Debug.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663882);
			Debug.NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Public_Static_Int32_ptr_Byte_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663883);
			Debug.NativeMethodInfoPtr_Log_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663884);
			Debug.NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663885);
			Debug.NativeMethodInfoPtr_LogFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663886);
			Debug.NativeMethodInfoPtr_LogFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663887);
			Debug.NativeMethodInfoPtr_LogFormat_Public_Static_Void_LogType_LogOption_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663888);
			Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663889);
			Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663890);
			Debug.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663891);
			Debug.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663892);
			Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663893);
			Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663894);
			Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663895);
			Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663896);
			Debug.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663897);
			Debug.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663898);
			Debug.NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663899);
			Debug.NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663900);
			Debug.NativeMethodInfoPtr_LogAssertion_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663901);
			Debug.NativeMethodInfoPtr_LogAssertionFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663902);
			Debug.NativeMethodInfoPtr_get_isDebugBuild_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663903);
			Debug.NativeMethodInfoPtr_CallOverridenDebugHandler_Internal_Static_Boolean_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663904);
			Debug.NativeMethodInfoPtr_IsLoggingEnabled_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663905);
			Debug.NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663907);
			Debug.BreakDelegateField = IL2CPP.ResolveICall<Debug.BreakDelegate>("UnityEngine.Debug::Break");
			Debug.DebugBreakDelegateField = IL2CPP.ResolveICall<Debug.DebugBreakDelegate>("UnityEngine.Debug::DebugBreak");
			Debug.ClearDeveloperConsoleDelegateField = IL2CPP.ResolveICall<Debug.ClearDeveloperConsoleDelegate>("UnityEngine.Debug::ClearDeveloperConsole");
			Debug.get_developerConsoleEnabledDelegateField = IL2CPP.ResolveICall<Debug.get_developerConsoleEnabledDelegate>("UnityEngine.Debug::get_developerConsoleEnabled");
			Debug.set_developerConsoleEnabledDelegateField = IL2CPP.ResolveICall<Debug.set_developerConsoleEnabledDelegate>("UnityEngine.Debug::set_developerConsoleEnabled");
			Debug.get_developerConsoleVisibleDelegateField = IL2CPP.ResolveICall<Debug.get_developerConsoleVisibleDelegate>("UnityEngine.Debug::get_developerConsoleVisible");
			Debug.set_developerConsoleVisibleDelegateField = IL2CPP.ResolveICall<Debug.set_developerConsoleVisibleDelegate>("UnityEngine.Debug::set_developerConsoleVisible");
			Debug.OpenConsoleFileDelegateField = IL2CPP.ResolveICall<Debug.OpenConsoleFileDelegate>("UnityEngine.Debug::OpenConsoleFile");
			Debug.get_diagnosticSwitchesDelegateField = IL2CPP.ResolveICall<Debug.get_diagnosticSwitchesDelegate>("UnityEngine.Debug::get_diagnosticSwitches");
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x00028F58 File Offset: 0x00027158
		public unsafe static ILogger unityLogger
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229385, XrefRangeEnd = 1229389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_get_unityLogger_Public_Static_get_ILogger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
			}
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00028F8C File Offset: 0x0002718C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1229397, RefRangeEnd = 1229416, XrefRangeStart = 1229389, XrefRangeEnd = 1229397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00028FE8 File Offset: 0x000271E8
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 1229424, RefRangeEnd = 1229472, XrefRangeStart = 1229416, XrefRangeEnd = 1229424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine(Vector3 start, Vector3 end, Color color)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00029038 File Offset: 0x00027238
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1229480, RefRangeEnd = 1229482, XrefRangeStart = 1229472, XrefRangeEnd = 1229480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine(Vector3 start, Vector3 end)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00029078 File Offset: 0x00027278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229482, XrefRangeEnd = 1229487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthTest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x000290E4 File Offset: 0x000272E4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1229491, RefRangeEnd = 1229496, XrefRangeStart = 1229487, XrefRangeEnd = 1229491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00029140 File Offset: 0x00027340
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1229500, RefRangeEnd = 1229508, XrefRangeStart = 1229496, XrefRangeEnd = 1229500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawRay(Vector3 start, Vector3 dir, Color color)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00029190 File Offset: 0x00027390
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1229516, RefRangeEnd = 1229518, XrefRangeStart = 1229508, XrefRangeEnd = 1229516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthTest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x000291FC File Offset: 0x000273FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1229520, RefRangeEnd = 1229521, XrefRangeStart = 1229518, XrefRangeEnd = 1229520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = buffer;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferMax;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(projectFolder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Public_Static_Int32_ptr_Byte_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00029258 File Offset: 0x00027458
		[CallerCount(398)]
		[CachedScanResults(RefRangeStart = 1229531, RefRangeEnd = 1229929, XrefRangeStart = 1229521, XrefRangeEnd = 1229531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(Object message)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_Log_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00029290 File Offset: 0x00027490
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 1229939, RefRangeEnd = 1229986, XrefRangeStart = 1229929, XrefRangeEnd = 1229939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(Object message, Object context)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x000292D8 File Offset: 0x000274D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1229996, RefRangeEnd = 1229998, XrefRangeStart = 1229986, XrefRangeEnd = 1229996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00029330 File Offset: 0x00027530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1230008, RefRangeEnd = 1230009, XrefRangeStart = 1229998, XrefRangeEnd = 1230008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogFormat(Object context, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00029398 File Offset: 0x00027598
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1230032, RefRangeEnd = 1230033, XrefRangeStart = 1230009, XrefRangeEnd = 1230032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogFormat(LogType logType, LogOption logOptions, Object context, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref logType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogFormat_Public_Static_Void_LogType_LogOption_Object_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00029420 File Offset: 0x00027620
		[CallerCount(367)]
		[CachedScanResults(RefRangeStart = 1230043, RefRangeEnd = 1230410, XrefRangeStart = 1230033, XrefRangeEnd = 1230043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(Object message)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00029458 File Offset: 0x00027658
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 1230420, RefRangeEnd = 1230459, XrefRangeStart = 1230410, XrefRangeEnd = 1230420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(Object message, Object context)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x000294A0 File Offset: 0x000276A0
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1230469, RefRangeEnd = 1230489, XrefRangeStart = 1230459, XrefRangeEnd = 1230469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogErrorFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x000294F8 File Offset: 0x000276F8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1230499, RefRangeEnd = 1230505, XrefRangeStart = 1230489, XrefRangeEnd = 1230499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogErrorFormat(Object context, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00029560 File Offset: 0x00027760
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 1230515, RefRangeEnd = 1230557, XrefRangeStart = 1230505, XrefRangeEnd = 1230515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogException(Exception exception)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00029598 File Offset: 0x00027798
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1230567, RefRangeEnd = 1230573, XrefRangeStart = 1230557, XrefRangeEnd = 1230567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogException(Exception exception, Object context)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x000295E0 File Offset: 0x000277E0
		[CallerCount(1019)]
		[CachedScanResults(RefRangeStart = 1230583, RefRangeEnd = 1231602, XrefRangeStart = 1230573, XrefRangeEnd = 1230583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarning(Object message)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00029618 File Offset: 0x00027818
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 1231612, RefRangeEnd = 1231666, XrefRangeStart = 1231602, XrefRangeEnd = 1231612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarning(Object message, Object context)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00029660 File Offset: 0x00027860
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1231676, RefRangeEnd = 1231687, XrefRangeStart = 1231666, XrefRangeEnd = 1231676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarningFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x000296B8 File Offset: 0x000278B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1231697, RefRangeEnd = 1231700, XrefRangeStart = 1231687, XrefRangeEnd = 1231697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarningFormat(Object context, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00029720 File Offset: 0x00027920
		[CallerCount(165)]
		[CachedScanResults(RefRangeStart = 1231712, RefRangeEnd = 1231877, XrefRangeStart = 1231700, XrefRangeEnd = 1231712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Assert(bool condition)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref condition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00029754 File Offset: 0x00027954
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 1231887, RefRangeEnd = 1231914, XrefRangeStart = 1231877, XrefRangeEnd = 1231887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Assert(bool condition, string message)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref condition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00029798 File Offset: 0x00027998
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1231924, RefRangeEnd = 1231928, XrefRangeStart = 1231914, XrefRangeEnd = 1231924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogAssertion(Object message)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogAssertion_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x000297D0 File Offset: 0x000279D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1231938, RefRangeEnd = 1231940, XrefRangeStart = 1231928, XrefRangeEnd = 1231938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogAssertionFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogAssertionFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x00029828 File Offset: 0x00027A28
		public unsafe static bool isDebugBuild
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 1231942, RefRangeEnd = 1231958, XrefRangeStart = 1231940, XrefRangeEnd = 1231942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_get_isDebugBuild_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00029858 File Offset: 0x00027A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231958, XrefRangeEnd = 1231978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CallOverridenDebugHandler(Exception exception, Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_CallOverridenDebugHandler_Internal_Static_Boolean_Exception_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x000298AC File Offset: 0x00027AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231978, XrefRangeEnd = 1232001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLoggingEnabled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_IsLoggingEnabled_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x000298DC File Offset: 0x00027ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232001, XrefRangeEnd = 1232003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine_Injected(ref Vector3 start, ref Vector3 end, ref Color color, float duration, bool depthTest)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &color;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthTest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Color_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00004C50 File Offset: 0x00002E50
		public static void LogFormat(string format, params Object[] args)
		{
			Debug.LogFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00004C5E File Offset: 0x00002E5E
		public static void LogFormat(Object context, string format, params Object[] args)
		{
			Debug.LogFormat(context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00004C6D File Offset: 0x00002E6D
		public static void LogFormat(LogType logType, LogOption logOptions, Object context, string format, params Object[] args)
		{
			Debug.LogFormat(logType, logOptions, context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00004C7F File Offset: 0x00002E7F
		public static void LogErrorFormat(string format, params Object[] args)
		{
			Debug.LogErrorFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00004C8D File Offset: 0x00002E8D
		public static void LogErrorFormat(Object context, string format, params Object[] args)
		{
			Debug.LogErrorFormat(context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00004C9C File Offset: 0x00002E9C
		public static void LogWarningFormat(string format, params Object[] args)
		{
			Debug.LogWarningFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00004CAA File Offset: 0x00002EAA
		public static void LogWarningFormat(Object context, string format, params Object[] args)
		{
			Debug.LogWarningFormat(context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00004CB9 File Offset: 0x00002EB9
		public static void LogAssertionFormat(string format, params Object[] args)
		{
			Debug.LogAssertionFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00004CC7 File Offset: 0x00002EC7
		public Debug(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00029948 File Offset: 0x00027B48
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x00004CD0 File Offset: 0x00002ED0
		public unsafe static ILogger s_DefaultLogger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Debug.NativeFieldInfoPtr_s_DefaultLogger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Debug.NativeFieldInfoPtr_s_DefaultLogger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x00029970 File Offset: 0x00027B70
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x00004CE2 File Offset: 0x00002EE2
		public unsafe static ILogger s_Logger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Debug.NativeFieldInfoPtr_s_Logger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Debug.NativeFieldInfoPtr_s_Logger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00029998 File Offset: 0x00027B98
		public static void DrawRay(Vector3 start, Vector3 dir)
		{
			bool depthTest = true;
			float duration = 0f;
			Color white = Color.white;
			Debug.DrawRay(start, dir, white, duration, depthTest);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00004CF4 File Offset: 0x00002EF4
		public static void Break()
		{
			Debug.BreakDelegateField();
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00004D00 File Offset: 0x00002F00
		public static void DebugBreak()
		{
			Debug.DebugBreakDelegateField();
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00004D0C File Offset: 0x00002F0C
		public static void ClearDeveloperConsole()
		{
			Debug.ClearDeveloperConsoleDelegateField();
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00004D18 File Offset: 0x00002F18
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x00004D24 File Offset: 0x00002F24
		public static bool developerConsoleEnabled
		{
			get
			{
				return Debug.get_developerConsoleEnabledDelegateField();
			}
			set
			{
				Debug.set_developerConsoleEnabledDelegateField(value);
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x00004D31 File Offset: 0x00002F31
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x00004D3D File Offset: 0x00002F3D
		public static bool developerConsoleVisible
		{
			get
			{
				return Debug.get_developerConsoleVisibleDelegateField();
			}
			set
			{
				Debug.set_developerConsoleVisibleDelegateField(value);
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x000299C0 File Offset: 0x00027BC0
		public static void Assert(bool condition, Object context)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, "Assertion failed", context);
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x000299E8 File Offset: 0x00027BE8
		public static void Assert(bool condition, Object message)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, message);
			}
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00029A0C File Offset: 0x00027C0C
		public static void Assert(bool condition, Object message, Object context)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, message, context);
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00029A30 File Offset: 0x00027C30
		public static void Assert(bool condition, string message, Object context)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, message, context);
			}
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00029A54 File Offset: 0x00027C54
		public static void AssertFormat(bool condition, string format, Il2CppReferenceArray<Object> args)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.LogFormat(LogType.Assert, format, args);
			}
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00004D4A File Offset: 0x00002F4A
		public static void AssertFormat(bool condition, string format, params Object[] args)
		{
			Debug.AssertFormat(condition, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00029A78 File Offset: 0x00027C78
		public static void AssertFormat(bool condition, Object context, string format, Il2CppReferenceArray<Object> args)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.LogFormat(LogType.Assert, context, format, args);
			}
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00004D59 File Offset: 0x00002F59
		public static void AssertFormat(bool condition, Object context, string format, params Object[] args)
		{
			Debug.AssertFormat(condition, context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00004D69 File Offset: 0x00002F69
		public static void LogAssertion(Object message, Object context)
		{
			Debug.unityLogger.Log(LogType.Assert, message, context);
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00004D7A File Offset: 0x00002F7A
		public static void LogAssertionFormat(Object context, string format, Il2CppReferenceArray<Object> args)
		{
			Debug.unityLogger.LogFormat(LogType.Assert, context, format, args);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00004D8C File Offset: 0x00002F8C
		public static void LogAssertionFormat(Object context, string format, params Object[] args)
		{
			Debug.LogAssertionFormat(context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00004D9B File Offset: 0x00002F9B
		public static void OpenConsoleFile()
		{
			Debug.OpenConsoleFileDelegateField();
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x00029AA0 File Offset: 0x00027CA0
		public static Il2CppReferenceArray<DiagnosticSwitch> diagnosticSwitches
		{
			get
			{
				IntPtr intPtr = Debug.get_diagnosticSwitchesDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DiagnosticSwitch>>(intPtr2) : null;
			}
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00004DA7 File Offset: 0x00002FA7
		public static DiagnosticSwitch GetDiagnosticSwitch(string name)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00029AC8 File Offset: 0x00027CC8
		public static void Assert(bool condition, string format, Il2CppReferenceArray<Object> args)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.LogFormat(LogType.Assert, format, args);
			}
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00004DB4 File Offset: 0x00002FB4
		public static void Assert(bool condition, string format, params Object[] args)
		{
			Debug.Assert(condition, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x00029AEC File Offset: 0x00027CEC
		public static ILogger logger
		{
			get
			{
				return Debug.s_Logger;
			}
		}

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultLogger;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeFieldInfoPtr_s_Logger;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr_get_unityLogger_Public_Static_get_ILogger_0;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_0;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_0;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_0;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_Single_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_DrawRay_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Public_Static_Int32_ptr_Byte_Int32_String_0;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_Object_0;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr_LogFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeMethodInfoPtr_LogFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeMethodInfoPtr_LogFormat_Public_Static_Void_LogType_LogOption_Object_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_Object_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_0;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_String_0;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeMethodInfoPtr_LogAssertion_Public_Static_Void_Object_0;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr_LogAssertionFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_get_isDebugBuild_Public_Static_get_Boolean_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr_CallOverridenDebugHandler_Internal_Static_Boolean_Exception_Object_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_IsLoggingEnabled_Internal_Static_Boolean_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Color_Single_Boolean_0;

		// Token: 0x0400050F RID: 1295
		private static readonly Debug.BreakDelegate BreakDelegateField;

		// Token: 0x04000510 RID: 1296
		private static readonly Debug.DebugBreakDelegate DebugBreakDelegateField;

		// Token: 0x04000511 RID: 1297
		private static readonly Debug.ClearDeveloperConsoleDelegate ClearDeveloperConsoleDelegateField;

		// Token: 0x04000512 RID: 1298
		private static readonly Debug.get_developerConsoleEnabledDelegate get_developerConsoleEnabledDelegateField;

		// Token: 0x04000513 RID: 1299
		private static readonly Debug.set_developerConsoleEnabledDelegate set_developerConsoleEnabledDelegateField;

		// Token: 0x04000514 RID: 1300
		private static readonly Debug.get_developerConsoleVisibleDelegate get_developerConsoleVisibleDelegateField;

		// Token: 0x04000515 RID: 1301
		private static readonly Debug.set_developerConsoleVisibleDelegate set_developerConsoleVisibleDelegateField;

		// Token: 0x04000516 RID: 1302
		private static readonly Debug.OpenConsoleFileDelegate OpenConsoleFileDelegateField;

		// Token: 0x04000517 RID: 1303
		private static readonly Debug.get_diagnosticSwitchesDelegate get_diagnosticSwitchesDelegateField;

		// Token: 0x020004CD RID: 1229
		// (Invoke) Token: 0x0600323A RID: 12858
		private delegate void BreakDelegate();

		// Token: 0x020004CE RID: 1230
		// (Invoke) Token: 0x0600323C RID: 12860
		private delegate void DebugBreakDelegate();

		// Token: 0x020004CF RID: 1231
		// (Invoke) Token: 0x0600323E RID: 12862
		private delegate void ClearDeveloperConsoleDelegate();

		// Token: 0x020004D0 RID: 1232
		// (Invoke) Token: 0x06003240 RID: 12864
		private delegate bool get_developerConsoleEnabledDelegate();

		// Token: 0x020004D1 RID: 1233
		// (Invoke) Token: 0x06003242 RID: 12866
		private delegate void set_developerConsoleEnabledDelegate(bool value);

		// Token: 0x020004D2 RID: 1234
		// (Invoke) Token: 0x06003244 RID: 12868
		private delegate bool get_developerConsoleVisibleDelegate();

		// Token: 0x020004D3 RID: 1235
		// (Invoke) Token: 0x06003246 RID: 12870
		private delegate void set_developerConsoleVisibleDelegate(bool value);

		// Token: 0x020004D4 RID: 1236
		// (Invoke) Token: 0x06003248 RID: 12872
		private delegate void OpenConsoleFileDelegate();

		// Token: 0x020004D5 RID: 1237
		// (Invoke) Token: 0x0600324A RID: 12874
		private delegate IntPtr get_diagnosticSwitchesDelegate();
	}
}
