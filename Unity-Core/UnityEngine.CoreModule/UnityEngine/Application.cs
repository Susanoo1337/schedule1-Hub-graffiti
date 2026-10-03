using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;
using Il2CppSystem.Threading;
using UnityEngine.Diagnostics;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace UnityEngine
{
	// Token: 0x0200006A RID: 106
	public class Application : Object
	{
		// Token: 0x06000374 RID: 884 RVA: 0x00022950 File Offset: 0x00020B50
		// Note: this type is marked as 'beforefieldinit'.
		static Application()
		{
			Il2CppClassPointerStore<Application>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Application");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Application>.NativeClassPtr);
			Application.NativeFieldInfoPtr_lowMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "lowMemory");
			Application.NativeFieldInfoPtr_memoryUsageChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "memoryUsageChanged");
			Application.NativeFieldInfoPtr_s_LogCallbackHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "s_LogCallbackHandler");
			Application.NativeFieldInfoPtr_s_LogCallbackHandlerThreaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "s_LogCallbackHandlerThreaded");
			Application.NativeFieldInfoPtr_focusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "focusChanged");
			Application.NativeFieldInfoPtr_deepLinkActivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "deepLinkActivated");
			Application.NativeFieldInfoPtr_wantsToQuit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "wantsToQuit");
			Application.NativeFieldInfoPtr_quitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "quitting");
			Application.NativeFieldInfoPtr_unloading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "unloading");
			Application.NativeFieldInfoPtr_s_currentCancellationTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "s_currentCancellationTokenSource");
			Application.NativeMethodInfoPtr_Quit_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663664);
			Application.NativeMethodInfoPtr_Quit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663665);
			Application.NativeMethodInfoPtr_get_isPlaying_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663666);
			Application.NativeMethodInfoPtr_get_isFocused_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663667);
			Application.NativeMethodInfoPtr_get_buildGUID_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663668);
			Application.NativeMethodInfoPtr_get_runInBackground_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663669);
			Application.NativeMethodInfoPtr_set_runInBackground_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663670);
			Application.NativeMethodInfoPtr_get_isBatchMode_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663671);
			Application.NativeMethodInfoPtr_get_dataPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663672);
			Application.NativeMethodInfoPtr_get_streamingAssetsPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663673);
			Application.NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663674);
			Application.NativeMethodInfoPtr_get_version_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663675);
			Application.NativeMethodInfoPtr_get_identifier_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663676);
			Application.NativeMethodInfoPtr_get_productName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663677);
			Application.NativeMethodInfoPtr_get_cloudProjectId_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663678);
			Application.NativeMethodInfoPtr_OpenURL_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663679);
			Application.NativeMethodInfoPtr_set_targetFrameRate_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663680);
			Application.NativeMethodInfoPtr_SetLogCallbackDefined_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663681);
			Application.NativeMethodInfoPtr_get_genuine_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663682);
			Application.NativeMethodInfoPtr_get_genuineCheckAvailable_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663683);
			Application.NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663684);
			Application.NativeMethodInfoPtr_get_isMobilePlatform_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663685);
			Application.NativeMethodInfoPtr_CallLowMemory_Internal_Static_Void_ApplicationMemoryUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663686);
			Application.NativeMethodInfoPtr_HasLogCallback_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663687);
			Application.NativeMethodInfoPtr_add_logMessageReceived_Public_Static_add_Void_LogCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663688);
			Application.NativeMethodInfoPtr_remove_logMessageReceived_Public_Static_rem_Void_LogCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663689);
			Application.NativeMethodInfoPtr_CallLogCallback_Private_Static_Void_String_String_LogType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663690);
			Application.NativeMethodInfoPtr_add_focusChanged_Public_Static_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663691);
			Application.NativeMethodInfoPtr_remove_focusChanged_Public_Static_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663692);
			Application.NativeMethodInfoPtr_add_quitting_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663693);
			Application.NativeMethodInfoPtr_remove_quitting_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663694);
			Application.NativeMethodInfoPtr_Internal_ApplicationWantsToQuit_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663695);
			Application.NativeMethodInfoPtr_Internal_ApplicationInit_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663696);
			Application.NativeMethodInfoPtr_Internal_ApplicationQuit_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663697);
			Application.NativeMethodInfoPtr_Internal_ApplicationUnload_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663698);
			Application.NativeMethodInfoPtr_InvokeOnBeforeRender_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663699);
			Application.NativeMethodInfoPtr_InvokeFocusChanged_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663700);
			Application.NativeMethodInfoPtr_InvokeDeepLinkActivated_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663701);
			Application.NativeMethodInfoPtr_get_isEditor_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663702);
			Application.CancelQuitDelegateField = IL2CPP.ResolveICall<Application.CancelQuitDelegate>("UnityEngine.Application::CancelQuit");
			Application.UnloadDelegateField = IL2CPP.ResolveICall<Application.UnloadDelegate>("UnityEngine.Application::Unload");
			Application.get_isLoadingLevelDelegateField = IL2CPP.ResolveICall<Application.get_isLoadingLevelDelegate>("UnityEngine.Application::get_isLoadingLevel");
			Application.SimulateMemoryUsageDelegateField = IL2CPP.ResolveICall<Application.SimulateMemoryUsageDelegate>("UnityEngine.Application::SimulateMemoryUsage");
			Application.CanStreamedLevelBeLoadedDelegateField = IL2CPP.ResolveICall<Application.CanStreamedLevelBeLoadedDelegate>("UnityEngine.Application::CanStreamedLevelBeLoaded");
			Application.IsPlayingDelegateField = IL2CPP.ResolveICall<Application.IsPlayingDelegate>("UnityEngine.Application::IsPlaying");
			Application.GetBuildTagsDelegateField = IL2CPP.ResolveICall<Application.GetBuildTagsDelegate>("UnityEngine.Application::GetBuildTags");
			Application.SetBuildTagsDelegateField = IL2CPP.ResolveICall<Application.SetBuildTagsDelegate>("UnityEngine.Application::SetBuildTags");
			Application.HasProLicenseDelegateField = IL2CPP.ResolveICall<Application.HasProLicenseDelegate>("UnityEngine.Application::HasProLicense");
			Application.get_isTestRunDelegateField = IL2CPP.ResolveICall<Application.get_isTestRunDelegate>("UnityEngine.Application::get_isTestRun");
			Application.get_isHumanControllingUsDelegateField = IL2CPP.ResolveICall<Application.get_isHumanControllingUsDelegate>("UnityEngine.Application::get_isHumanControllingUs");
			Application.HasARGVDelegateField = IL2CPP.ResolveICall<Application.HasARGVDelegate>("UnityEngine.Application::HasARGV");
			Application.GetValueForARGVDelegateField = IL2CPP.ResolveICall<Application.GetValueForARGVDelegate>("UnityEngine.Application::GetValueForARGV");
			Application.get_temporaryCachePathDelegateField = IL2CPP.ResolveICall<Application.get_temporaryCachePathDelegate>("UnityEngine.Application::get_temporaryCachePath");
			Application.get_absoluteURLDelegateField = IL2CPP.ResolveICall<Application.get_absoluteURLDelegate>("UnityEngine.Application::get_absoluteURL");
			Application.Internal_ExternalCallDelegateField = IL2CPP.ResolveICall<Application.Internal_ExternalCallDelegate>("UnityEngine.Application::Internal_ExternalCall");
			Application.get_unityVersionDelegateField = IL2CPP.ResolveICall<Application.get_unityVersionDelegate>("UnityEngine.Application::get_unityVersion");
			Application.get_unityVersionVerDelegateField = IL2CPP.ResolveICall<Application.get_unityVersionVerDelegate>("UnityEngine.Application::get_unityVersionVer");
			Application.get_unityVersionMajDelegateField = IL2CPP.ResolveICall<Application.get_unityVersionMajDelegate>("UnityEngine.Application::get_unityVersionMaj");
			Application.get_unityVersionMinDelegateField = IL2CPP.ResolveICall<Application.get_unityVersionMinDelegate>("UnityEngine.Application::get_unityVersionMin");
			Application.get_installerNameDelegateField = IL2CPP.ResolveICall<Application.get_installerNameDelegate>("UnityEngine.Application::get_installerName");
			Application.get_installModeDelegateField = IL2CPP.ResolveICall<Application.get_installModeDelegate>("UnityEngine.Application::get_installMode");
			Application.get_sandboxTypeDelegateField = IL2CPP.ResolveICall<Application.get_sandboxTypeDelegate>("UnityEngine.Application::get_sandboxType");
			Application.get_companyNameDelegateField = IL2CPP.ResolveICall<Application.get_companyNameDelegate>("UnityEngine.Application::get_companyName");
			Application.get_targetFrameRateDelegateField = IL2CPP.ResolveICall<Application.get_targetFrameRateDelegate>("UnityEngine.Application::get_targetFrameRate");
			Application.get_stackTraceLogTypeDelegateField = IL2CPP.ResolveICall<Application.get_stackTraceLogTypeDelegate>("UnityEngine.Application::get_stackTraceLogType");
			Application.set_stackTraceLogTypeDelegateField = IL2CPP.ResolveICall<Application.set_stackTraceLogTypeDelegate>("UnityEngine.Application::set_stackTraceLogType");
			Application.GetStackTraceLogTypeDelegateField = IL2CPP.ResolveICall<Application.GetStackTraceLogTypeDelegate>("UnityEngine.Application::GetStackTraceLogType");
			Application.SetStackTraceLogTypeDelegateField = IL2CPP.ResolveICall<Application.SetStackTraceLogTypeDelegate>("UnityEngine.Application::SetStackTraceLogType");
			Application.get_consoleLogPathDelegateField = IL2CPP.ResolveICall<Application.get_consoleLogPathDelegate>("UnityEngine.Application::get_consoleLogPath");
			Application.get_backgroundLoadingPriorityDelegateField = IL2CPP.ResolveICall<Application.get_backgroundLoadingPriorityDelegate>("UnityEngine.Application::get_backgroundLoadingPriority");
			Application.set_backgroundLoadingPriorityDelegateField = IL2CPP.ResolveICall<Application.set_backgroundLoadingPriorityDelegate>("UnityEngine.Application::set_backgroundLoadingPriority");
			Application.RequestUserAuthorizationDelegateField = IL2CPP.ResolveICall<Application.RequestUserAuthorizationDelegate>("UnityEngine.Application::RequestUserAuthorization");
			Application.HasUserAuthorizationDelegateField = IL2CPP.ResolveICall<Application.HasUserAuthorizationDelegate>("UnityEngine.Application::HasUserAuthorization");
			Application.get_submitAnalyticsDelegateField = IL2CPP.ResolveICall<Application.get_submitAnalyticsDelegate>("UnityEngine.Application::get_submitAnalytics");
			Application.get_systemLanguageDelegateField = IL2CPP.ResolveICall<Application.get_systemLanguageDelegate>("UnityEngine.Application::get_systemLanguage");
			Application.get_internetReachabilityDelegateField = IL2CPP.ResolveICall<Application.get_internetReachabilityDelegate>("UnityEngine.Application::get_internetReachability");
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00022F80 File Offset: 0x00021180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227348, XrefRangeEnd = 1227350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Quit(int exitCode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref exitCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Quit_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00022FB4 File Offset: 0x000211B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1227355, RefRangeEnd = 1227359, XrefRangeStart = 1227350, XrefRangeEnd = 1227355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Quit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Quit_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000377 RID: 887 RVA: 0x00022FDC File Offset: 0x000211DC
		public unsafe static bool isPlaying
		{
			[CallerCount(462)]
			[CachedScanResults(RefRangeStart = 1227361, RefRangeEnd = 1227823, XrefRangeStart = 1227359, XrefRangeEnd = 1227361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_isPlaying_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000378 RID: 888 RVA: 0x0002300C File Offset: 0x0002120C
		public unsafe static bool isFocused
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1227825, RefRangeEnd = 1227829, XrefRangeStart = 1227823, XrefRangeEnd = 1227825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_isFocused_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0002303C File Offset: 0x0002123C
		public unsafe static string buildGUID
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1227831, RefRangeEnd = 1227832, XrefRangeStart = 1227829, XrefRangeEnd = 1227831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_buildGUID_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00023068 File Offset: 0x00021268
		// (set) Token: 0x0600037B RID: 891 RVA: 0x00023098 File Offset: 0x00021298
		public unsafe static bool runInBackground
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1227834, RefRangeEnd = 1227835, XrefRangeStart = 1227832, XrefRangeEnd = 1227834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_runInBackground_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1227837, RefRangeEnd = 1227840, XrefRangeStart = 1227835, XrefRangeEnd = 1227837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_set_runInBackground_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600037C RID: 892 RVA: 0x000230CC File Offset: 0x000212CC
		public unsafe static bool isBatchMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1227842, RefRangeEnd = 1227843, XrefRangeStart = 1227840, XrefRangeEnd = 1227842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_isBatchMode_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600037D RID: 893 RVA: 0x000230FC File Offset: 0x000212FC
		public unsafe static string dataPath
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1227845, RefRangeEnd = 1227852, XrefRangeStart = 1227843, XrefRangeEnd = 1227845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_dataPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00023128 File Offset: 0x00021328
		public unsafe static string streamingAssetsPath
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1227854, RefRangeEnd = 1227861, XrefRangeStart = 1227852, XrefRangeEnd = 1227854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_streamingAssetsPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00023154 File Offset: 0x00021354
		public unsafe static string persistentDataPath
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1227863, RefRangeEnd = 1227870, XrefRangeStart = 1227861, XrefRangeEnd = 1227863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00023180 File Offset: 0x00021380
		public unsafe static string version
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 1227872, RefRangeEnd = 1227891, XrefRangeStart = 1227870, XrefRangeEnd = 1227872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_version_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000381 RID: 897 RVA: 0x000231AC File Offset: 0x000213AC
		public unsafe static string identifier
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1227893, RefRangeEnd = 1227894, XrefRangeStart = 1227891, XrefRangeEnd = 1227893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_identifier_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000382 RID: 898 RVA: 0x000231D8 File Offset: 0x000213D8
		public unsafe static string productName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1227896, RefRangeEnd = 1227897, XrefRangeStart = 1227894, XrefRangeEnd = 1227896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_productName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00023204 File Offset: 0x00021404
		public unsafe static string cloudProjectId
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1227899, RefRangeEnd = 1227901, XrefRangeStart = 1227897, XrefRangeEnd = 1227899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_cloudProjectId_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00023230 File Offset: 0x00021430
		[CallerCount(111)]
		[CachedScanResults(RefRangeStart = 1227903, RefRangeEnd = 1228014, XrefRangeStart = 1227901, XrefRangeEnd = 1227903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenURL(string url)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_OpenURL_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00003C80 File Offset: 0x00001E80
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00023268 File Offset: 0x00021468
		public unsafe static int targetFrameRate
		{
			get
			{
				return Application.get_targetFrameRateDelegateField();
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1228016, RefRangeEnd = 1228019, XrefRangeStart = 1228014, XrefRangeEnd = 1228016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_set_targetFrameRate_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0002329C File Offset: 0x0002149C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228019, XrefRangeEnd = 1228029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLogCallbackDefined(bool defined)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref defined;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_SetLogCallbackDefined_Private_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000387 RID: 903 RVA: 0x000232D0 File Offset: 0x000214D0
		public unsafe static bool genuine
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1228031, RefRangeEnd = 1228033, XrefRangeStart = 1228029, XrefRangeEnd = 1228031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_genuine_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00023300 File Offset: 0x00021500
		public unsafe static bool genuineCheckAvailable
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1228035, RefRangeEnd = 1228037, XrefRangeStart = 1228033, XrefRangeEnd = 1228035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_genuineCheckAvailable_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00023330 File Offset: 0x00021530
		public unsafe static RuntimePlatform platform
		{
			[CallerCount(60)]
			[CachedScanResults(RefRangeStart = 1228039, RefRangeEnd = 1228099, XrefRangeStart = 1228037, XrefRangeEnd = 1228039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600038A RID: 906 RVA: 0x00023360 File Offset: 0x00021560
		public unsafe static bool isMobilePlatform
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1228105, RefRangeEnd = 1228108, XrefRangeStart = 1228099, XrefRangeEnd = 1228105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_isMobilePlatform_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00023390 File Offset: 0x00021590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228108, XrefRangeEnd = 1228115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallLowMemory(ApplicationMemoryUsage usage)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref usage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_CallLowMemory_Internal_Static_Void_ApplicationMemoryUsage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x000233C4 File Offset: 0x000215C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228115, XrefRangeEnd = 1228119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasLogCallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_HasLogCallback_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x000233F4 File Offset: 0x000215F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1228136, RefRangeEnd = 1228137, XrefRangeStart = 1228119, XrefRangeEnd = 1228136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_logMessageReceived(Application.LogCallback value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_add_logMessageReceived_Public_Static_add_Void_LogCallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0002342C File Offset: 0x0002162C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228137, XrefRangeEnd = 1228152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_logMessageReceived(Application.LogCallback value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_remove_logMessageReceived_Public_Static_rem_Void_LogCallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00023464 File Offset: 0x00021664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228152, XrefRangeEnd = 1228159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(logString);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invokedOnMainThread;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_CallLogCallback_Private_Static_Void_String_String_LogType_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x000234C8 File Offset: 0x000216C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1228172, RefRangeEnd = 1228174, XrefRangeStart = 1228159, XrefRangeEnd = 1228172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_focusChanged(Action<bool> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_add_focusChanged_Public_Static_add_Void_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00023500 File Offset: 0x00021700
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1228187, RefRangeEnd = 1228188, XrefRangeStart = 1228174, XrefRangeEnd = 1228187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_focusChanged(Action<bool> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_remove_focusChanged_Public_Static_rem_Void_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00023538 File Offset: 0x00021738
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1228199, RefRangeEnd = 1228202, XrefRangeStart = 1228188, XrefRangeEnd = 1228199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_quitting(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_add_quitting_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00023570 File Offset: 0x00021770
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1228213, RefRangeEnd = 1228216, XrefRangeStart = 1228202, XrefRangeEnd = 1228213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_quitting(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_remove_quitting_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x000235A8 File Offset: 0x000217A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228216, XrefRangeEnd = 1228232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_ApplicationWantsToQuit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Internal_ApplicationWantsToQuit_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x000235D8 File Offset: 0x000217D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228232, XrefRangeEnd = 1228242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ApplicationInit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Internal_ApplicationInit_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00023600 File Offset: 0x00021800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228242, XrefRangeEnd = 1228250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ApplicationQuit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Internal_ApplicationQuit_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00023628 File Offset: 0x00021828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228250, XrefRangeEnd = 1228256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ApplicationUnload()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Internal_ApplicationUnload_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00023650 File Offset: 0x00021850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228256, XrefRangeEnd = 1228260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnBeforeRender()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_InvokeOnBeforeRender_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00023678 File Offset: 0x00021878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228260, XrefRangeEnd = 1228266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeFocusChanged(bool focus)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref focus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_InvokeFocusChanged_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000236AC File Offset: 0x000218AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228266, XrefRangeEnd = 1228272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeDeepLinkActivated(string url)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_InvokeDeepLinkActivated_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600039B RID: 923 RVA: 0x000236E4 File Offset: 0x000218E4
		public unsafe static bool isEditor
		{
			[CallerCount(37)]
			[CachedScanResults(RefRangeStart = 1228272, RefRangeEnd = 1228309, XrefRangeStart = 1228272, XrefRangeEnd = 1228272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_isEditor_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00003ACE File Offset: 0x00001CCE
		public Application(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600039D RID: 925 RVA: 0x00023714 File Offset: 0x00021914
		// (set) Token: 0x0600039E RID: 926 RVA: 0x00003AD7 File Offset: 0x00001CD7
		public unsafe static Application.LowMemoryCallback lowMemory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_lowMemory, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Application.LowMemoryCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_lowMemory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600039F RID: 927 RVA: 0x0002373C File Offset: 0x0002193C
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x00003AE9 File Offset: 0x00001CE9
		public unsafe static Application.MemoryUsageChangedCallback memoryUsageChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_memoryUsageChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Application.MemoryUsageChangedCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_memoryUsageChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x00023764 File Offset: 0x00021964
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x00003AFB File Offset: 0x00001CFB
		public unsafe static Application.LogCallback s_LogCallbackHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_s_LogCallbackHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Application.LogCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_s_LogCallbackHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x0002378C File Offset: 0x0002198C
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x00003B0D File Offset: 0x00001D0D
		public unsafe static Application.LogCallback s_LogCallbackHandlerThreaded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_s_LogCallbackHandlerThreaded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Application.LogCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_s_LogCallbackHandlerThreaded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x000237B4 File Offset: 0x000219B4
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x00003B1F File Offset: 0x00001D1F
		public unsafe static Action<bool> focusChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_focusChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_focusChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x000237DC File Offset: 0x000219DC
		// (set) Token: 0x060003A8 RID: 936 RVA: 0x00003B31 File Offset: 0x00001D31
		public unsafe static Action<string> deepLinkActivated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_deepLinkActivated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_deepLinkActivated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x00023804 File Offset: 0x00021A04
		// (set) Token: 0x060003AA RID: 938 RVA: 0x00003B43 File Offset: 0x00001D43
		public unsafe static Func<bool> wantsToQuit
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_wantsToQuit, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_wantsToQuit, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060003AB RID: 939 RVA: 0x0002382C File Offset: 0x00021A2C
		// (set) Token: 0x060003AC RID: 940 RVA: 0x00003B55 File Offset: 0x00001D55
		public unsafe static Action quitting
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_quitting, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_quitting, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060003AD RID: 941 RVA: 0x00023854 File Offset: 0x00021A54
		// (set) Token: 0x060003AE RID: 942 RVA: 0x00003B67 File Offset: 0x00001D67
		public unsafe static Action unloading
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_unloading, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_unloading, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060003AF RID: 943 RVA: 0x0002387C File Offset: 0x00021A7C
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00003B79 File Offset: 0x00001D79
		public unsafe static CancellationTokenSource s_currentCancellationTokenSource
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_s_currentCancellationTokenSource, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_s_currentCancellationTokenSource, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00003B8B File Offset: 0x00001D8B
		public static void CancelQuit()
		{
			Application.CancelQuitDelegateField();
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00003B97 File Offset: 0x00001D97
		public static void Unload()
		{
			Application.UnloadDelegateField();
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00003BA3 File Offset: 0x00001DA3
		public static bool isLoadingLevel
		{
			get
			{
				return Application.get_isLoadingLevelDelegateField();
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00003BAF File Offset: 0x00001DAF
		public static void SimulateMemoryUsage(ApplicationMemoryUsage usage)
		{
			Application.SimulateMemoryUsageDelegateField(usage);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x000238A4 File Offset: 0x00021AA4
		public static float GetStreamProgressForLevel(int levelIndex)
		{
			bool flag = levelIndex >= 0 && levelIndex < UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
			float result;
			if (flag)
			{
				result = 1f;
			}
			else
			{
				result = 0f;
			}
			return result;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x000238D8 File Offset: 0x00021AD8
		public static float GetStreamProgressForLevel(string levelName)
		{
			return 1f;
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x000238F0 File Offset: 0x00021AF0
		public static int streamedBytes
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00023904 File Offset: 0x00021B04
		public static bool webSecurityEnabled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00023918 File Offset: 0x00021B18
		public static bool CanStreamedLevelBeLoaded(int levelIndex)
		{
			return levelIndex >= 0 && levelIndex < UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00003BBC File Offset: 0x00001DBC
		public static bool CanStreamedLevelBeLoaded(string levelName)
		{
			return Application.CanStreamedLevelBeLoadedDelegateField(IL2CPP.ManagedStringToIl2Cpp(levelName));
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00003BCE File Offset: 0x00001DCE
		public static bool IsPlaying(Object obj)
		{
			return Application.IsPlayingDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj));
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0002393C File Offset: 0x00021B3C
		public static Il2CppStringArray GetBuildTags()
		{
			IntPtr intPtr = Application.GetBuildTagsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00003BE0 File Offset: 0x00001DE0
		public static void SetBuildTags(Il2CppStringArray buildTags)
		{
			Application.SetBuildTagsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(buildTags));
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00003BF2 File Offset: 0x00001DF2
		public static bool HasProLicense()
		{
			return Application.HasProLicenseDelegateField();
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00003BFE File Offset: 0x00001DFE
		public static bool isTestRun
		{
			get
			{
				return Application.get_isTestRunDelegateField();
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00003C0A File Offset: 0x00001E0A
		public static bool isHumanControllingUs
		{
			get
			{
				return Application.get_isHumanControllingUsDelegateField();
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00003C16 File Offset: 0x00001E16
		public static bool HasARGV(string name)
		{
			return Application.HasARGVDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00023964 File Offset: 0x00021B64
		public static string GetValueForARGV(string name)
		{
			IntPtr intPtr = Application.GetValueForARGVDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00023988 File Offset: 0x00021B88
		public static string temporaryCachePath
		{
			get
			{
				IntPtr intPtr = Application.get_temporaryCachePathDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x000239A8 File Offset: 0x00021BA8
		public static string absoluteURL
		{
			get
			{
				IntPtr intPtr = Application.get_absoluteURLDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x000239C8 File Offset: 0x00021BC8
		public static void ExternalEval(string script)
		{
			bool flag = script.Length > 0 && script.get_Chars(script.Length - 1) != ';';
			if (flag)
			{
				script = String.Concat(script, ";");
			}
			Application.Internal_ExternalCall(script);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00003C28 File Offset: 0x00001E28
		public static void Internal_ExternalCall(string script)
		{
			Application.Internal_ExternalCallDelegateField(IL2CPP.ManagedStringToIl2Cpp(script));
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00023A10 File Offset: 0x00021C10
		public static string unityVersion
		{
			get
			{
				IntPtr intPtr = Application.get_unityVersionDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00003C3A File Offset: 0x00001E3A
		public static int unityVersionVer
		{
			get
			{
				return Application.get_unityVersionVerDelegateField();
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00003C46 File Offset: 0x00001E46
		public static int unityVersionMaj
		{
			get
			{
				return Application.get_unityVersionMajDelegateField();
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00003C52 File Offset: 0x00001E52
		public static int unityVersionMin
		{
			get
			{
				return Application.get_unityVersionMinDelegateField();
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00023A30 File Offset: 0x00021C30
		public static string installerName
		{
			get
			{
				IntPtr intPtr = Application.get_installerNameDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00003C5E File Offset: 0x00001E5E
		public static ApplicationInstallMode installMode
		{
			get
			{
				return Application.get_installModeDelegateField();
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00003C6A File Offset: 0x00001E6A
		public static ApplicationSandboxType sandboxType
		{
			get
			{
				return Application.get_sandboxTypeDelegateField();
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00023A50 File Offset: 0x00021C50
		public static string companyName
		{
			get
			{
				IntPtr intPtr = Application.get_companyNameDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00003C76 File Offset: 0x00001E76
		public static void ForceCrash(int mode)
		{
			UnityEngine.Diagnostics.Utils.ForceCrash((UnityEngine.Diagnostics.ForcedCrashCategory)mode);
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x00003C8C File Offset: 0x00001E8C
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x00003C98 File Offset: 0x00001E98
		public static StackTraceLogType stackTraceLogType
		{
			get
			{
				return Application.get_stackTraceLogTypeDelegateField();
			}
			set
			{
				Application.set_stackTraceLogTypeDelegateField(value);
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00003CA5 File Offset: 0x00001EA5
		public static StackTraceLogType GetStackTraceLogType(LogType logType)
		{
			return Application.GetStackTraceLogTypeDelegateField(logType);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00003CB2 File Offset: 0x00001EB2
		public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType)
		{
			Application.SetStackTraceLogTypeDelegateField(logType, stackTraceType);
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00023A70 File Offset: 0x00021C70
		public static string consoleLogPath
		{
			get
			{
				IntPtr intPtr = Application.get_consoleLogPathDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00003CC0 File Offset: 0x00001EC0
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x00003CCC File Offset: 0x00001ECC
		public static ThreadPriority backgroundLoadingPriority
		{
			get
			{
				return Application.get_backgroundLoadingPriorityDelegateField();
			}
			set
			{
				Application.set_backgroundLoadingPriorityDelegateField(value);
			}
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00023A90 File Offset: 0x00021C90
		public static AsyncOperation RequestUserAuthorization(UserAuthorization mode)
		{
			IntPtr intPtr = Application.RequestUserAuthorizationDelegateField(mode);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00003CD9 File Offset: 0x00001ED9
		public static bool HasUserAuthorization(UserAuthorization mode)
		{
			return Application.HasUserAuthorizationDelegateField(mode);
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00003CE6 File Offset: 0x00001EE6
		public static bool submitAnalytics
		{
			get
			{
				return Application.get_submitAnalyticsDelegateField();
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060003DB RID: 987 RVA: 0x00023AB8 File Offset: 0x00021CB8
		public static bool isShowingSplashScreen
		{
			get
			{
				return !UnityEngine.Rendering.SplashScreen.isFinished;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00023AD4 File Offset: 0x00021CD4
		public static bool isConsolePlatform
		{
			get
			{
				RuntimePlatform platform = Application.platform;
				return platform == RuntimePlatform.GameCoreXboxOne || platform == RuntimePlatform.GameCoreXboxSeries || platform == RuntimePlatform.PS4 || platform == RuntimePlatform.PS5 || platform == RuntimePlatform.Switch || platform == RuntimePlatform.XboxOne;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060003DD RID: 989 RVA: 0x00003CF2 File Offset: 0x00001EF2
		public static SystemLanguage systemLanguage
		{
			get
			{
				return Application.get_systemLanguageDelegateField();
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00003CFE File Offset: 0x00001EFE
		public static NetworkReachability internetReachability
		{
			get
			{
				return Application.get_internetReachabilityDelegateField();
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00003D0A File Offset: 0x00001F0A
		public static void add_lowMemory(Application.LowMemoryCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00003D17 File Offset: 0x00001F17
		public static void remove_lowMemory(Application.LowMemoryCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00003D24 File Offset: 0x00001F24
		public static void add_memoryUsageChanged(Application.MemoryUsageChangedCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00003D31 File Offset: 0x00001F31
		public static void remove_memoryUsageChanged(Application.MemoryUsageChangedCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00003D3E File Offset: 0x00001F3E
		public static void add_logMessageReceivedThreaded(Application.LogCallback value)
		{
			Application.s_LogCallbackHandlerThreaded = Delegate.Combine(Application.s_LogCallbackHandlerThreaded, value).Cast<Application.LogCallback>();
			Application.SetLogCallbackDefined(true);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00003D5D File Offset: 0x00001F5D
		public static void remove_logMessageReceivedThreaded(Application.LogCallback value)
		{
			Application.s_LogCallbackHandlerThreaded = Delegate.Remove(Application.s_LogCallbackHandlerThreaded, value).Cast<Application.LogCallback>();
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00003D75 File Offset: 0x00001F75
		public static void InvokeOnAdvertisingIdentifierCallback(string advertisingId, bool trackingEnabled)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00023B10 File Offset: 0x00021D10
		public static string ObjectToJSString(Object o)
		{
			bool flag = o == null;
			string result;
			if (flag)
			{
				result = "null";
			}
			else
			{
				bool flag2 = o.TryCast<string>() != null;
				if (flag2)
				{
					string text = o.ToString().Replace("\\", "\\\\");
					text = text.Replace("\"", "\\\"");
					text = text.Replace("\n", "\\n");
					text = text.Replace("\r", "\\r");
					text = text.Replace("\0", "");
					text = text.Replace("\u2028", "");
					text = text.Replace("\u2029", "");
					result = String.Concat("\"", text, "\"");
				}
				else
				{
					bool flag3 = o is int || o is short || o is uint || o is ushort || o is byte;
					if (flag3)
					{
						result = o.ToString();
					}
					else
					{
						bool flag4 = o is float;
						if (flag4)
						{
							NumberFormatInfo numberFormat = CultureInfo.InvariantCulture.NumberFormat;
							result = ((float)o).ToString(numberFormat);
						}
						else
						{
							bool flag5 = o is double;
							if (flag5)
							{
								NumberFormatInfo numberFormat2 = CultureInfo.InvariantCulture.NumberFormat;
								result = ((double)o).ToString(numberFormat2);
							}
							else
							{
								bool flag6 = o is char;
								if (flag6)
								{
									bool flag7 = (char)o == '"';
									if (flag7)
									{
										result = "\"\\\"\"";
									}
									else
									{
										result = String.Concat("\"", o.ToString(), "\"");
									}
								}
								else
								{
									bool flag8 = o.TryCast<IList>() != null;
									if (flag8)
									{
										IList list = o.Cast<IList>();
										StringBuilder stringBuilder = new StringBuilder();
										stringBuilder.Append("new Array(");
										int count = list.Count;
										for (int i = 0; i < count; i++)
										{
											bool flag9 = i != 0;
											if (flag9)
											{
												stringBuilder.Append(", ");
											}
											stringBuilder.Append(Application.ObjectToJSString(list[i]));
										}
										stringBuilder.Append(")");
										result = stringBuilder.ToString();
									}
									else
									{
										result = Application.ObjectToJSString(o.ToString());
									}
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00003D82 File Offset: 0x00001F82
		public static void ExternalCall(string functionName, Il2CppReferenceArray<Object> args)
		{
			Application.Internal_ExternalCall(Application.BuildInvocationForArguments(functionName, args));
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00003D92 File Offset: 0x00001F92
		public static void ExternalCall(string functionName, params Object[] args)
		{
			Application.ExternalCall(functionName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00003DA0 File Offset: 0x00001FA0
		public static string BuildInvocationForArguments(string functionName, Il2CppReferenceArray<Object> args)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00003DAD File Offset: 0x00001FAD
		public static string BuildInvocationForArguments(string functionName, params Object[] args)
		{
			return Application.BuildInvocationForArguments(functionName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00023D68 File Offset: 0x00021F68
		public static bool isPlayer
		{
			get
			{
				return !Application.isEditor;
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00023D84 File Offset: 0x00021F84
		public static void DontDestroyOnLoad(Object o)
		{
			bool flag = o != null;
			if (flag)
			{
				Object.DontDestroyOnLoad(o);
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00003DBB File Offset: 0x00001FBB
		public static void CaptureScreenshot(string filename, int superSize)
		{
			throw new NotSupportedException("Application.CaptureScreenshot is obsolete. Use ScreenCapture.CaptureScreenshot instead.");
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00003DC8 File Offset: 0x00001FC8
		public static void CaptureScreenshot(string filename)
		{
			throw new NotSupportedException("Application.CaptureScreenshot is obsolete. Use ScreenCapture.CaptureScreenshot instead.");
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00003DD5 File Offset: 0x00001FD5
		public static void add_onBeforeRender(UnityEngine.Events.UnityAction value)
		{
			BeforeRenderHelper.RegisterCallback(value);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00003DDF File Offset: 0x00001FDF
		public static void remove_onBeforeRender(UnityEngine.Events.UnityAction value)
		{
			BeforeRenderHelper.UnregisterCallback(value);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00003DE9 File Offset: 0x00001FE9
		public static void add_deepLinkActivated(Action<string> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00003DF6 File Offset: 0x00001FF6
		public static void remove_deepLinkActivated(Action<string> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00003E03 File Offset: 0x00002003
		public static void add_wantsToQuit(Func<bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00003E10 File Offset: 0x00002010
		public static void remove_wantsToQuit(Func<bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00003E1D File Offset: 0x0000201D
		public static void add_unloading(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00003E2A File Offset: 0x0000202A
		public static void remove_unloading(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00003E37 File Offset: 0x00002037
		public static CancellationToken exitCancellationToken
		{
			get
			{
				return Application.s_currentCancellationTokenSource.Token;
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00003E43 File Offset: 0x00002043
		public static void RegisterLogCallback(Application.LogCallback handler)
		{
			Application.RegisterLogCallback(handler, false);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00003E4E File Offset: 0x0000204E
		public static void RegisterLogCallbackThreaded(Application.LogCallback handler)
		{
			Application.RegisterLogCallback(handler, true);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00003E59 File Offset: 0x00002059
		public static void RegisterLogCallback(Application.LogCallback handler, bool threaded)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x00023DA4 File Offset: 0x00021FA4
		public static int levelCount
		{
			get
			{
				return UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x00023DBC File Offset: 0x00021FBC
		public static int loadedLevel
		{
			get
			{
				return UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x00023DDC File Offset: 0x00021FDC
		public static string loadedLevelName
		{
			get
			{
				return UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
			}
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00003E66 File Offset: 0x00002066
		public static void LoadLevel(int index)
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(index, UnityEngine.SceneManagement.LoadSceneMode.Single);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00003E71 File Offset: 0x00002071
		public static void LoadLevel(string name)
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(name, UnityEngine.SceneManagement.LoadSceneMode.Single);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00003E7C File Offset: 0x0000207C
		public static void LoadLevelAdditive(int index)
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(index, UnityEngine.SceneManagement.LoadSceneMode.Additive);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00003E87 File Offset: 0x00002087
		public static void LoadLevelAdditive(string name)
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(name, UnityEngine.SceneManagement.LoadSceneMode.Additive);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00023DFC File Offset: 0x00021FFC
		public static AsyncOperation LoadLevelAsync(int index)
		{
			return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(index, UnityEngine.SceneManagement.LoadSceneMode.Single);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00023E18 File Offset: 0x00022018
		public static AsyncOperation LoadLevelAsync(string levelName)
		{
			return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(levelName, UnityEngine.SceneManagement.LoadSceneMode.Single);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00023E34 File Offset: 0x00022034
		public static AsyncOperation LoadLevelAdditiveAsync(int index)
		{
			return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(index, UnityEngine.SceneManagement.LoadSceneMode.Additive);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00023E50 File Offset: 0x00022050
		public static AsyncOperation LoadLevelAdditiveAsync(string levelName)
		{
			return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(levelName, UnityEngine.SceneManagement.LoadSceneMode.Additive);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00023E6C File Offset: 0x0002206C
		public static bool UnloadLevel(int index)
		{
			return UnityEngine.SceneManagement.SceneManager.UnloadScene(index);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00023E84 File Offset: 0x00022084
		public static bool UnloadLevel(string scenePath)
		{
			return UnityEngine.SceneManagement.SceneManager.UnloadScene(scenePath);
		}

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeFieldInfoPtr_lowMemory;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeFieldInfoPtr_memoryUsageChanged;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeFieldInfoPtr_s_LogCallbackHandler;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeFieldInfoPtr_s_LogCallbackHandlerThreaded;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeFieldInfoPtr_focusChanged;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeFieldInfoPtr_deepLinkActivated;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeFieldInfoPtr_wantsToQuit;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeFieldInfoPtr_quitting;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeFieldInfoPtr_unloading;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeFieldInfoPtr_s_currentCancellationTokenSource;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr_Quit_Public_Static_Void_Int32_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_Quit_Public_Static_Void_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_get_isPlaying_Public_Static_get_Boolean_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_get_isFocused_Public_Static_get_Boolean_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_get_buildGUID_Public_Static_get_String_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_get_runInBackground_Public_Static_get_Boolean_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_set_runInBackground_Public_Static_set_Void_Boolean_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr_get_isBatchMode_Public_Static_get_Boolean_0;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr_get_dataPath_Public_Static_get_String_0;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeMethodInfoPtr_get_streamingAssetsPath_Public_Static_get_String_0;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_get_version_Public_Static_get_String_0;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr_get_identifier_Public_Static_get_String_0;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr_get_productName_Public_Static_get_String_0;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr_get_cloudProjectId_Public_Static_get_String_0;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr_OpenURL_Public_Static_Void_String_0;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeMethodInfoPtr_set_targetFrameRate_Public_Static_set_Void_Int32_0;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr_SetLogCallbackDefined_Private_Static_Void_Boolean_0;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr_get_genuine_Public_Static_get_Boolean_0;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_get_genuineCheckAvailable_Public_Static_get_Boolean_0;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_get_isMobilePlatform_Public_Static_get_Boolean_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr_CallLowMemory_Internal_Static_Void_ApplicationMemoryUsage_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_HasLogCallback_Internal_Static_Boolean_0;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr_add_logMessageReceived_Public_Static_add_Void_LogCallback_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_remove_logMessageReceived_Public_Static_rem_Void_LogCallback_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_CallLogCallback_Private_Static_Void_String_String_LogType_Boolean_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_add_focusChanged_Public_Static_add_Void_Action_1_Boolean_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_remove_focusChanged_Public_Static_rem_Void_Action_1_Boolean_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr_add_quitting_Public_Static_add_Void_Action_0;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr_remove_quitting_Public_Static_rem_Void_Action_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ApplicationWantsToQuit_Private_Static_Boolean_0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ApplicationInit_Private_Static_Void_0;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ApplicationQuit_Private_Static_Void_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ApplicationUnload_Private_Static_Void_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnBeforeRender_Internal_Static_Void_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_InvokeFocusChanged_Internal_Static_Void_Boolean_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_InvokeDeepLinkActivated_Internal_Static_Void_String_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_get_isEditor_Public_Static_get_Boolean_0;

		// Token: 0x040002ED RID: 749
		private static readonly Application.CancelQuitDelegate CancelQuitDelegateField;

		// Token: 0x040002EE RID: 750
		private static readonly Application.UnloadDelegate UnloadDelegateField;

		// Token: 0x040002EF RID: 751
		private static readonly Application.get_isLoadingLevelDelegate get_isLoadingLevelDelegateField;

		// Token: 0x040002F0 RID: 752
		private static readonly Application.SimulateMemoryUsageDelegate SimulateMemoryUsageDelegateField;

		// Token: 0x040002F1 RID: 753
		private static readonly Application.CanStreamedLevelBeLoadedDelegate CanStreamedLevelBeLoadedDelegateField;

		// Token: 0x040002F2 RID: 754
		private static readonly Application.IsPlayingDelegate IsPlayingDelegateField;

		// Token: 0x040002F3 RID: 755
		private static readonly Application.GetBuildTagsDelegate GetBuildTagsDelegateField;

		// Token: 0x040002F4 RID: 756
		private static readonly Application.SetBuildTagsDelegate SetBuildTagsDelegateField;

		// Token: 0x040002F5 RID: 757
		private static readonly Application.HasProLicenseDelegate HasProLicenseDelegateField;

		// Token: 0x040002F6 RID: 758
		private static readonly Application.get_isTestRunDelegate get_isTestRunDelegateField;

		// Token: 0x040002F7 RID: 759
		private static readonly Application.get_isHumanControllingUsDelegate get_isHumanControllingUsDelegateField;

		// Token: 0x040002F8 RID: 760
		private static readonly Application.HasARGVDelegate HasARGVDelegateField;

		// Token: 0x040002F9 RID: 761
		private static readonly Application.GetValueForARGVDelegate GetValueForARGVDelegateField;

		// Token: 0x040002FA RID: 762
		private static readonly Application.get_temporaryCachePathDelegate get_temporaryCachePathDelegateField;

		// Token: 0x040002FB RID: 763
		private static readonly Application.get_absoluteURLDelegate get_absoluteURLDelegateField;

		// Token: 0x040002FC RID: 764
		private static readonly Application.Internal_ExternalCallDelegate Internal_ExternalCallDelegateField;

		// Token: 0x040002FD RID: 765
		private static readonly Application.get_unityVersionDelegate get_unityVersionDelegateField;

		// Token: 0x040002FE RID: 766
		private static readonly Application.get_unityVersionVerDelegate get_unityVersionVerDelegateField;

		// Token: 0x040002FF RID: 767
		private static readonly Application.get_unityVersionMajDelegate get_unityVersionMajDelegateField;

		// Token: 0x04000300 RID: 768
		private static readonly Application.get_unityVersionMinDelegate get_unityVersionMinDelegateField;

		// Token: 0x04000301 RID: 769
		private static readonly Application.get_installerNameDelegate get_installerNameDelegateField;

		// Token: 0x04000302 RID: 770
		private static readonly Application.get_installModeDelegate get_installModeDelegateField;

		// Token: 0x04000303 RID: 771
		private static readonly Application.get_sandboxTypeDelegate get_sandboxTypeDelegateField;

		// Token: 0x04000304 RID: 772
		private static readonly Application.get_companyNameDelegate get_companyNameDelegateField;

		// Token: 0x04000305 RID: 773
		private static readonly Application.get_targetFrameRateDelegate get_targetFrameRateDelegateField;

		// Token: 0x04000306 RID: 774
		private static readonly Application.get_stackTraceLogTypeDelegate get_stackTraceLogTypeDelegateField;

		// Token: 0x04000307 RID: 775
		private static readonly Application.set_stackTraceLogTypeDelegate set_stackTraceLogTypeDelegateField;

		// Token: 0x04000308 RID: 776
		private static readonly Application.GetStackTraceLogTypeDelegate GetStackTraceLogTypeDelegateField;

		// Token: 0x04000309 RID: 777
		private static readonly Application.SetStackTraceLogTypeDelegate SetStackTraceLogTypeDelegateField;

		// Token: 0x0400030A RID: 778
		private static readonly Application.get_consoleLogPathDelegate get_consoleLogPathDelegateField;

		// Token: 0x0400030B RID: 779
		private static readonly Application.get_backgroundLoadingPriorityDelegate get_backgroundLoadingPriorityDelegateField;

		// Token: 0x0400030C RID: 780
		private static readonly Application.set_backgroundLoadingPriorityDelegate set_backgroundLoadingPriorityDelegateField;

		// Token: 0x0400030D RID: 781
		private static readonly Application.RequestUserAuthorizationDelegate RequestUserAuthorizationDelegateField;

		// Token: 0x0400030E RID: 782
		private static readonly Application.HasUserAuthorizationDelegate HasUserAuthorizationDelegateField;

		// Token: 0x0400030F RID: 783
		private static readonly Application.get_submitAnalyticsDelegate get_submitAnalyticsDelegateField;

		// Token: 0x04000310 RID: 784
		private static readonly Application.get_systemLanguageDelegate get_systemLanguageDelegateField;

		// Token: 0x04000311 RID: 785
		private static readonly Application.get_internetReachabilityDelegate get_internetReachabilityDelegateField;

		// Token: 0x020003F9 RID: 1017
		public sealed class LowMemoryCallback : MulticastDelegate
		{
			// Token: 0x06003091 RID: 12433 RVA: 0x00015940 File Offset: 0x00013B40
			// Note: this type is marked as 'beforefieldinit'.
			static LowMemoryCallback()
			{
				Il2CppClassPointerStore<Application.LowMemoryCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Application>.NativeClassPtr, "LowMemoryCallback");
				Application.LowMemoryCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LowMemoryCallback>.NativeClassPtr, 100663704);
				Application.LowMemoryCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LowMemoryCallback>.NativeClassPtr, 100663705);
			}

			// Token: 0x06003092 RID: 12434 RVA: 0x000AFE00 File Offset: 0x000AE000
			[CallerCount(1472)]
			[CachedScanResults(RefRangeStart = 20074, RefRangeEnd = 21546, XrefRangeStart = 20074, XrefRangeEnd = 21546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LowMemoryCallback(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Application.LowMemoryCallback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.LowMemoryCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003093 RID: 12435 RVA: 0x000AFE5C File Offset: 0x000AE05C
			[CallerCount(0)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.LowMemoryCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003094 RID: 12436 RVA: 0x0001597E File Offset: 0x00013B7E
			public LowMemoryCallback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003095 RID: 12437 RVA: 0x00015987 File Offset: 0x00013B87
			public static implicit operator Application.LowMemoryCallback(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<Application.LowMemoryCallback>(A_0);
			}

			// Token: 0x06003096 RID: 12438 RVA: 0x0001598F File Offset: 0x00013B8F
			public static Application.LowMemoryCallback operator +(Application.LowMemoryCallback A_0, Application.LowMemoryCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Application.LowMemoryCallback>();
			}

			// Token: 0x06003097 RID: 12439 RVA: 0x0001599D File Offset: 0x00013B9D
			public static Application.LowMemoryCallback operator -(Application.LowMemoryCallback A_0, Application.LowMemoryCallback A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Application.LowMemoryCallback>();
				}
				return result;
			}

			// Token: 0x04002A23 RID: 10787
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002A24 RID: 10788
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
		}

		// Token: 0x020003FA RID: 1018
		public sealed class MemoryUsageChangedCallback : MulticastDelegate
		{
			// Token: 0x06003098 RID: 12440 RVA: 0x000159AE File Offset: 0x00013BAE
			// Note: this type is marked as 'beforefieldinit'.
			static MemoryUsageChangedCallback()
			{
				Il2CppClassPointerStore<Application.MemoryUsageChangedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Application>.NativeClassPtr, "MemoryUsageChangedCallback");
				Application.MemoryUsageChangedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.MemoryUsageChangedCallback>.NativeClassPtr, 100663706);
				Application.MemoryUsageChangedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ApplicationMemoryUsageChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.MemoryUsageChangedCallback>.NativeClassPtr, 100663707);
			}

			// Token: 0x06003099 RID: 12441 RVA: 0x000AFE90 File Offset: 0x000AE090
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 73307, RefRangeEnd = 73313, XrefRangeStart = 73307, XrefRangeEnd = 73313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MemoryUsageChangedCallback(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Application.MemoryUsageChangedCallback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.MemoryUsageChangedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600309A RID: 12442 RVA: 0x000AFEEC File Offset: 0x000AE0EC
			[CallerCount(0)]
			public unsafe void Invoke([In] ref ApplicationMemoryUsageChange usage)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = &usage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.MemoryUsageChangedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ApplicationMemoryUsageChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600309B RID: 12443 RVA: 0x000159EC File Offset: 0x00013BEC
			public MemoryUsageChangedCallback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04002A25 RID: 10789
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002A26 RID: 10790
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ApplicationMemoryUsageChange_0;
		}

		// Token: 0x020003FB RID: 1019
		public sealed class LogCallback : MulticastDelegate
		{
			// Token: 0x0600309C RID: 12444 RVA: 0x000159F5 File Offset: 0x00013BF5
			// Note: this type is marked as 'beforefieldinit'.
			static LogCallback()
			{
				Il2CppClassPointerStore<Application.LogCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Application>.NativeClassPtr, "LogCallback");
				Application.LogCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LogCallback>.NativeClassPtr, 100663708);
				Application.LogCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LogCallback>.NativeClassPtr, 100663709);
			}

			// Token: 0x0600309D RID: 12445 RVA: 0x000AFF2C File Offset: 0x000AE12C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1227347, RefRangeEnd = 1227348, XrefRangeStart = 1227343, XrefRangeEnd = 1227347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LogCallback(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Application.LogCallback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.LogCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600309E RID: 12446 RVA: 0x000AFF88 File Offset: 0x000AE188
			[CallerCount(0)]
			public unsafe void Invoke(string condition, string stackTrace, LogType type)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(condition);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.LogCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600309F RID: 12447 RVA: 0x00015A33 File Offset: 0x00013C33
			public LogCallback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x060030A0 RID: 12448 RVA: 0x00015A3C File Offset: 0x00013C3C
			public static implicit operator Application.LogCallback(Action<string, string, LogType> A_0)
			{
				return DelegateSupport.ConvertDelegate<Application.LogCallback>(A_0);
			}

			// Token: 0x060030A1 RID: 12449 RVA: 0x00015A44 File Offset: 0x00013C44
			public static Application.LogCallback operator +(Application.LogCallback A_0, Application.LogCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Application.LogCallback>();
			}

			// Token: 0x060030A2 RID: 12450 RVA: 0x00015A52 File Offset: 0x00013C52
			public static Application.LogCallback operator -(Application.LogCallback A_0, Application.LogCallback A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Application.LogCallback>();
				}
				return result;
			}

			// Token: 0x04002A27 RID: 10791
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002A28 RID: 10792
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_LogType_0;
		}

		// Token: 0x020003FC RID: 1020
		// (Invoke) Token: 0x060030A4 RID: 12452
		private delegate void CancelQuitDelegate();

		// Token: 0x020003FD RID: 1021
		// (Invoke) Token: 0x060030A6 RID: 12454
		private delegate void UnloadDelegate();

		// Token: 0x020003FE RID: 1022
		// (Invoke) Token: 0x060030A8 RID: 12456
		private delegate bool get_isLoadingLevelDelegate();

		// Token: 0x020003FF RID: 1023
		// (Invoke) Token: 0x060030AA RID: 12458
		private delegate void SimulateMemoryUsageDelegate(ApplicationMemoryUsage usage);

		// Token: 0x02000400 RID: 1024
		// (Invoke) Token: 0x060030AC RID: 12460
		private delegate bool CanStreamedLevelBeLoadedDelegate(IntPtr levelName);

		// Token: 0x02000401 RID: 1025
		// (Invoke) Token: 0x060030AE RID: 12462
		private delegate bool IsPlayingDelegate(IntPtr obj);

		// Token: 0x02000402 RID: 1026
		// (Invoke) Token: 0x060030B0 RID: 12464
		private delegate IntPtr GetBuildTagsDelegate();

		// Token: 0x02000403 RID: 1027
		// (Invoke) Token: 0x060030B2 RID: 12466
		private delegate void SetBuildTagsDelegate(IntPtr buildTags);

		// Token: 0x02000404 RID: 1028
		// (Invoke) Token: 0x060030B4 RID: 12468
		private delegate bool HasProLicenseDelegate();

		// Token: 0x02000405 RID: 1029
		// (Invoke) Token: 0x060030B6 RID: 12470
		private delegate bool get_isTestRunDelegate();

		// Token: 0x02000406 RID: 1030
		// (Invoke) Token: 0x060030B8 RID: 12472
		private delegate bool get_isHumanControllingUsDelegate();

		// Token: 0x02000407 RID: 1031
		// (Invoke) Token: 0x060030BA RID: 12474
		private delegate bool HasARGVDelegate(IntPtr name);

		// Token: 0x02000408 RID: 1032
		// (Invoke) Token: 0x060030BC RID: 12476
		private delegate IntPtr GetValueForARGVDelegate(IntPtr name);

		// Token: 0x02000409 RID: 1033
		// (Invoke) Token: 0x060030BE RID: 12478
		private delegate IntPtr get_temporaryCachePathDelegate();

		// Token: 0x0200040A RID: 1034
		// (Invoke) Token: 0x060030C0 RID: 12480
		private delegate IntPtr get_absoluteURLDelegate();

		// Token: 0x0200040B RID: 1035
		// (Invoke) Token: 0x060030C2 RID: 12482
		private delegate void Internal_ExternalCallDelegate(IntPtr script);

		// Token: 0x0200040C RID: 1036
		// (Invoke) Token: 0x060030C4 RID: 12484
		private delegate IntPtr get_unityVersionDelegate();

		// Token: 0x0200040D RID: 1037
		// (Invoke) Token: 0x060030C6 RID: 12486
		private delegate int get_unityVersionVerDelegate();

		// Token: 0x0200040E RID: 1038
		// (Invoke) Token: 0x060030C8 RID: 12488
		private delegate int get_unityVersionMajDelegate();

		// Token: 0x0200040F RID: 1039
		// (Invoke) Token: 0x060030CA RID: 12490
		private delegate int get_unityVersionMinDelegate();

		// Token: 0x02000410 RID: 1040
		// (Invoke) Token: 0x060030CC RID: 12492
		private delegate IntPtr get_installerNameDelegate();

		// Token: 0x02000411 RID: 1041
		// (Invoke) Token: 0x060030CE RID: 12494
		private delegate ApplicationInstallMode get_installModeDelegate();

		// Token: 0x02000412 RID: 1042
		// (Invoke) Token: 0x060030D0 RID: 12496
		private delegate ApplicationSandboxType get_sandboxTypeDelegate();

		// Token: 0x02000413 RID: 1043
		// (Invoke) Token: 0x060030D2 RID: 12498
		private delegate IntPtr get_companyNameDelegate();

		// Token: 0x02000414 RID: 1044
		// (Invoke) Token: 0x060030D4 RID: 12500
		private delegate int get_targetFrameRateDelegate();

		// Token: 0x02000415 RID: 1045
		// (Invoke) Token: 0x060030D6 RID: 12502
		private delegate StackTraceLogType get_stackTraceLogTypeDelegate();

		// Token: 0x02000416 RID: 1046
		// (Invoke) Token: 0x060030D8 RID: 12504
		private delegate void set_stackTraceLogTypeDelegate(StackTraceLogType value);

		// Token: 0x02000417 RID: 1047
		// (Invoke) Token: 0x060030DA RID: 12506
		private delegate StackTraceLogType GetStackTraceLogTypeDelegate(LogType logType);

		// Token: 0x02000418 RID: 1048
		// (Invoke) Token: 0x060030DC RID: 12508
		private delegate void SetStackTraceLogTypeDelegate(LogType logType, StackTraceLogType stackTraceType);

		// Token: 0x02000419 RID: 1049
		// (Invoke) Token: 0x060030DE RID: 12510
		private delegate IntPtr get_consoleLogPathDelegate();

		// Token: 0x0200041A RID: 1050
		// (Invoke) Token: 0x060030E0 RID: 12512
		private delegate ThreadPriority get_backgroundLoadingPriorityDelegate();

		// Token: 0x0200041B RID: 1051
		// (Invoke) Token: 0x060030E2 RID: 12514
		private delegate void set_backgroundLoadingPriorityDelegate(ThreadPriority value);

		// Token: 0x0200041C RID: 1052
		// (Invoke) Token: 0x060030E4 RID: 12516
		private delegate IntPtr RequestUserAuthorizationDelegate(UserAuthorization mode);

		// Token: 0x0200041D RID: 1053
		// (Invoke) Token: 0x060030E6 RID: 12518
		private delegate bool HasUserAuthorizationDelegate(UserAuthorization mode);

		// Token: 0x0200041E RID: 1054
		// (Invoke) Token: 0x060030E8 RID: 12520
		private delegate bool get_submitAnalyticsDelegate();

		// Token: 0x0200041F RID: 1055
		// (Invoke) Token: 0x060030EA RID: 12522
		private delegate SystemLanguage get_systemLanguageDelegate();

		// Token: 0x02000420 RID: 1056
		// (Invoke) Token: 0x060030EC RID: 12524
		private delegate NetworkReachability get_internetReachabilityDelegate();
	}
}
