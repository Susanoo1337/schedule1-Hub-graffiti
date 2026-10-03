using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Threading;
using UnityEngine.Events;

namespace UnityEngine.Device
{
	// Token: 0x0200035A RID: 858
	public static class Application
	{
		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06002E0C RID: 11788 RVA: 0x0001481B File Offset: 0x00012A1B
		public static string absoluteURL
		{
			get
			{
				return Application.absoluteURL;
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06002E0D RID: 11789 RVA: 0x00014822 File Offset: 0x00012A22
		// (set) Token: 0x06002E0E RID: 11790 RVA: 0x00014829 File Offset: 0x00012A29
		public static ThreadPriority backgroundLoadingPriority
		{
			get
			{
				return Application.backgroundLoadingPriority;
			}
			set
			{
				Application.backgroundLoadingPriority = value;
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06002E0F RID: 11791 RVA: 0x00014832 File Offset: 0x00012A32
		public static string buildGUID
		{
			get
			{
				return Application.buildGUID;
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06002E10 RID: 11792 RVA: 0x00014839 File Offset: 0x00012A39
		public static string cloudProjectId
		{
			get
			{
				return Application.cloudProjectId;
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06002E11 RID: 11793 RVA: 0x00014840 File Offset: 0x00012A40
		public static string companyName
		{
			get
			{
				return Application.companyName;
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06002E12 RID: 11794 RVA: 0x00014847 File Offset: 0x00012A47
		public static string consoleLogPath
		{
			get
			{
				return Application.consoleLogPath;
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06002E13 RID: 11795 RVA: 0x0001484E File Offset: 0x00012A4E
		public static string dataPath
		{
			get
			{
				return Application.dataPath;
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06002E14 RID: 11796 RVA: 0x00014855 File Offset: 0x00012A55
		public static bool genuine
		{
			get
			{
				return Application.genuine;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06002E15 RID: 11797 RVA: 0x0001485C File Offset: 0x00012A5C
		public static bool genuineCheckAvailable
		{
			get
			{
				return Application.genuineCheckAvailable;
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06002E16 RID: 11798 RVA: 0x00014863 File Offset: 0x00012A63
		public static string identifier
		{
			get
			{
				return Application.identifier;
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06002E17 RID: 11799 RVA: 0x0001486A File Offset: 0x00012A6A
		public static string installerName
		{
			get
			{
				return Application.installerName;
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06002E18 RID: 11800 RVA: 0x00014871 File Offset: 0x00012A71
		public static ApplicationInstallMode installMode
		{
			get
			{
				return Application.installMode;
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06002E19 RID: 11801 RVA: 0x00014878 File Offset: 0x00012A78
		public static NetworkReachability internetReachability
		{
			get
			{
				return Application.internetReachability;
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06002E1A RID: 11802 RVA: 0x0001487F File Offset: 0x00012A7F
		public static bool isBatchMode
		{
			get
			{
				return Application.isBatchMode;
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06002E1B RID: 11803 RVA: 0x00014886 File Offset: 0x00012A86
		public static bool isConsolePlatform
		{
			get
			{
				return Application.isConsolePlatform;
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06002E1C RID: 11804 RVA: 0x0001488D File Offset: 0x00012A8D
		public static bool isEditor
		{
			get
			{
				return Application.isEditor;
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06002E1D RID: 11805 RVA: 0x00014894 File Offset: 0x00012A94
		public static bool isFocused
		{
			get
			{
				return Application.isFocused;
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06002E1E RID: 11806 RVA: 0x0001489B File Offset: 0x00012A9B
		public static bool isMobilePlatform
		{
			get
			{
				return Application.isMobilePlatform;
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06002E1F RID: 11807 RVA: 0x000148A2 File Offset: 0x00012AA2
		public static bool isPlaying
		{
			get
			{
				return Application.isPlaying;
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06002E20 RID: 11808 RVA: 0x000148A9 File Offset: 0x00012AA9
		public static string persistentDataPath
		{
			get
			{
				return Application.persistentDataPath;
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06002E21 RID: 11809 RVA: 0x000148B0 File Offset: 0x00012AB0
		public static RuntimePlatform platform
		{
			get
			{
				return Application.platform;
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06002E22 RID: 11810 RVA: 0x000148B7 File Offset: 0x00012AB7
		public static string productName
		{
			get
			{
				return Application.productName;
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06002E23 RID: 11811 RVA: 0x000148BE File Offset: 0x00012ABE
		// (set) Token: 0x06002E24 RID: 11812 RVA: 0x000148C5 File Offset: 0x00012AC5
		public static bool runInBackground
		{
			get
			{
				return Application.runInBackground;
			}
			set
			{
				Application.runInBackground = value;
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06002E25 RID: 11813 RVA: 0x000148CE File Offset: 0x00012ACE
		public static ApplicationSandboxType sandboxType
		{
			get
			{
				return Application.sandboxType;
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06002E26 RID: 11814 RVA: 0x000148D5 File Offset: 0x00012AD5
		public static string streamingAssetsPath
		{
			get
			{
				return Application.streamingAssetsPath;
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06002E27 RID: 11815 RVA: 0x000148DC File Offset: 0x00012ADC
		public static SystemLanguage systemLanguage
		{
			get
			{
				return Application.systemLanguage;
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06002E28 RID: 11816 RVA: 0x000148E3 File Offset: 0x00012AE3
		// (set) Token: 0x06002E29 RID: 11817 RVA: 0x000148EA File Offset: 0x00012AEA
		public static int targetFrameRate
		{
			get
			{
				return Application.targetFrameRate;
			}
			set
			{
				Application.targetFrameRate = value;
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06002E2A RID: 11818 RVA: 0x000148F3 File Offset: 0x00012AF3
		public static string temporaryCachePath
		{
			get
			{
				return Application.temporaryCachePath;
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06002E2B RID: 11819 RVA: 0x000148FA File Offset: 0x00012AFA
		public static string unityVersion
		{
			get
			{
				return Application.unityVersion;
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06002E2C RID: 11820 RVA: 0x00014901 File Offset: 0x00012B01
		public static string version
		{
			get
			{
				return Application.version;
			}
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x00014908 File Offset: 0x00012B08
		public static void add_deepLinkActivated(Action<string> value)
		{
			Application.add_deepLinkActivated(value);
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x00014911 File Offset: 0x00012B11
		public static void remove_deepLinkActivated(Action<string> value)
		{
			Application.remove_deepLinkActivated(value);
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x0001491A File Offset: 0x00012B1A
		public static void add_focusChanged(Action<bool> value)
		{
			Application.add_focusChanged(value);
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x00014923 File Offset: 0x00012B23
		public static void remove_focusChanged(Action<bool> value)
		{
			Application.remove_focusChanged(value);
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x0001492C File Offset: 0x00012B2C
		public static void add_logMessageReceived(Application.LogCallback value)
		{
			Application.add_logMessageReceived(value);
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x00014935 File Offset: 0x00012B35
		public static void remove_logMessageReceived(Application.LogCallback value)
		{
			Application.remove_logMessageReceived(value);
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x0001493E File Offset: 0x00012B3E
		public static void add_logMessageReceivedThreaded(Application.LogCallback value)
		{
			Application.add_logMessageReceivedThreaded(value);
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x00014947 File Offset: 0x00012B47
		public static void remove_logMessageReceivedThreaded(Application.LogCallback value)
		{
			Application.remove_logMessageReceivedThreaded(value);
		}

		// Token: 0x06002E35 RID: 11829 RVA: 0x00014950 File Offset: 0x00012B50
		public static void add_lowMemory(Application.LowMemoryCallback value)
		{
			Application.add_lowMemory(value);
		}

		// Token: 0x06002E36 RID: 11830 RVA: 0x00014959 File Offset: 0x00012B59
		public static void remove_lowMemory(Application.LowMemoryCallback value)
		{
			Application.remove_lowMemory(value);
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x00014962 File Offset: 0x00012B62
		public static void add_memoryUsageChanged(Application.MemoryUsageChangedCallback value)
		{
			Application.add_memoryUsageChanged(value);
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x0001496B File Offset: 0x00012B6B
		public static void remove_memoryUsageChanged(Application.MemoryUsageChangedCallback value)
		{
			Application.remove_memoryUsageChanged(value);
		}

		// Token: 0x06002E39 RID: 11833 RVA: 0x00014974 File Offset: 0x00012B74
		public static void add_onBeforeRender(UnityEngine.Events.UnityAction value)
		{
			Application.add_onBeforeRender(value);
		}

		// Token: 0x06002E3A RID: 11834 RVA: 0x0001497D File Offset: 0x00012B7D
		public static void remove_onBeforeRender(UnityEngine.Events.UnityAction value)
		{
			Application.remove_onBeforeRender(value);
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x00014986 File Offset: 0x00012B86
		public static void add_quitting(Action value)
		{
			Application.add_quitting(value);
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x0001498F File Offset: 0x00012B8F
		public static void remove_quitting(Action value)
		{
			Application.remove_quitting(value);
		}

		// Token: 0x06002E3D RID: 11837 RVA: 0x00014998 File Offset: 0x00012B98
		public static void add_wantsToQuit(Func<bool> value)
		{
			Application.add_wantsToQuit(value);
		}

		// Token: 0x06002E3E RID: 11838 RVA: 0x000149A1 File Offset: 0x00012BA1
		public static void remove_wantsToQuit(Func<bool> value)
		{
			Application.remove_wantsToQuit(value);
		}

		// Token: 0x06002E3F RID: 11839 RVA: 0x000149AA File Offset: 0x00012BAA
		public static void add_unloading(Action value)
		{
			Application.add_unloading(value);
		}

		// Token: 0x06002E40 RID: 11840 RVA: 0x000149B3 File Offset: 0x00012BB3
		public static void remove_unloading(Action value)
		{
			Application.remove_unloading(value);
		}

		// Token: 0x06002E41 RID: 11841 RVA: 0x000AD31C File Offset: 0x000AB51C
		public static bool CanStreamedLevelBeLoaded(int levelIndex)
		{
			return Application.CanStreamedLevelBeLoaded(levelIndex);
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x000AD334 File Offset: 0x000AB534
		public static bool CanStreamedLevelBeLoaded(string levelName)
		{
			return Application.CanStreamedLevelBeLoaded(levelName);
		}

		// Token: 0x06002E43 RID: 11843 RVA: 0x000AD34C File Offset: 0x000AB54C
		public static Il2CppStringArray GetBuildTags()
		{
			return Application.GetBuildTags();
		}

		// Token: 0x06002E44 RID: 11844 RVA: 0x000149BC File Offset: 0x00012BBC
		public static void SetBuildTags(Il2CppStringArray buildTags)
		{
			Application.SetBuildTags(buildTags);
		}

		// Token: 0x06002E45 RID: 11845 RVA: 0x000AD364 File Offset: 0x000AB564
		public static StackTraceLogType GetStackTraceLogType(LogType logType)
		{
			return Application.GetStackTraceLogType(logType);
		}

		// Token: 0x06002E46 RID: 11846 RVA: 0x000AD37C File Offset: 0x000AB57C
		public static bool HasProLicense()
		{
			return Application.HasProLicense();
		}

		// Token: 0x06002E47 RID: 11847 RVA: 0x000AD394 File Offset: 0x000AB594
		public static bool HasUserAuthorization(UserAuthorization mode)
		{
			return Application.HasUserAuthorization(mode);
		}

		// Token: 0x06002E48 RID: 11848 RVA: 0x000AD3AC File Offset: 0x000AB5AC
		public static bool IsPlaying(Object obj)
		{
			return Application.IsPlaying(obj);
		}

		// Token: 0x06002E49 RID: 11849 RVA: 0x000149C6 File Offset: 0x00012BC6
		public static void OpenURL(string url)
		{
			Application.OpenURL(url);
		}

		// Token: 0x06002E4A RID: 11850 RVA: 0x000149D0 File Offset: 0x00012BD0
		public static void Quit()
		{
			Application.Quit();
		}

		// Token: 0x06002E4B RID: 11851 RVA: 0x000149D9 File Offset: 0x00012BD9
		public static void Quit(int exitCode)
		{
			Application.Quit(exitCode);
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x000AD3C4 File Offset: 0x000AB5C4
		public static AsyncOperation RequestUserAuthorization(UserAuthorization mode)
		{
			return Application.RequestUserAuthorization(mode);
		}

		// Token: 0x06002E4D RID: 11853 RVA: 0x000149E3 File Offset: 0x00012BE3
		public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType)
		{
			Application.SetStackTraceLogType(logType, stackTraceType);
		}

		// Token: 0x06002E4E RID: 11854 RVA: 0x000149EE File Offset: 0x00012BEE
		public static void Unload()
		{
			Application.Unload();
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06002E4F RID: 11855 RVA: 0x000149F7 File Offset: 0x00012BF7
		public static CancellationToken exitCancellationToken
		{
			get
			{
				return Application.exitCancellationToken;
			}
		}
	}
}
