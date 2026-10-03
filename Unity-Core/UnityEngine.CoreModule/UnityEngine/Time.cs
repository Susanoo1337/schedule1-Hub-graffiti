using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000166 RID: 358
	public class Time : Object
	{
		// Token: 0x06001B3C RID: 6972 RVA: 0x00071B88 File Offset: 0x0006FD88
		// Note: this type is marked as 'beforefieldinit'.
		static Time()
		{
			Il2CppClassPointerStore<Time>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Time");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Time>.NativeClassPtr);
			Time.NativeMethodInfoPtr_get_time_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666202);
			Time.NativeMethodInfoPtr_get_timeSinceLevelLoad_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666203);
			Time.NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666204);
			Time.NativeMethodInfoPtr_get_unscaledTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666205);
			Time.NativeMethodInfoPtr_get_fixedUnscaledTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666206);
			Time.NativeMethodInfoPtr_get_unscaledDeltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666207);
			Time.NativeMethodInfoPtr_get_fixedDeltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666208);
			Time.NativeMethodInfoPtr_set_fixedDeltaTime_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666209);
			Time.NativeMethodInfoPtr_get_maximumDeltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666210);
			Time.NativeMethodInfoPtr_get_smoothDeltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666211);
			Time.NativeMethodInfoPtr_get_timeScale_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666212);
			Time.NativeMethodInfoPtr_set_timeScale_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666213);
			Time.NativeMethodInfoPtr_get_frameCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666214);
			Time.NativeMethodInfoPtr_get_renderedFrameCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666215);
			Time.NativeMethodInfoPtr_get_realtimeSinceStartup_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666216);
			Time.NativeMethodInfoPtr_get_realtimeSinceStartupAsDouble_Public_Static_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666217);
			Time.get_timeAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_timeAsDoubleDelegate>("UnityEngine.Time::get_timeAsDouble");
			Time.get_timeSinceLevelLoadAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_timeSinceLevelLoadAsDoubleDelegate>("UnityEngine.Time::get_timeSinceLevelLoadAsDouble");
			Time.get_fixedTimeDelegateField = IL2CPP.ResolveICall<Time.get_fixedTimeDelegate>("UnityEngine.Time::get_fixedTime");
			Time.get_fixedTimeAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_fixedTimeAsDoubleDelegate>("UnityEngine.Time::get_fixedTimeAsDouble");
			Time.get_unscaledTimeAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_unscaledTimeAsDoubleDelegate>("UnityEngine.Time::get_unscaledTimeAsDouble");
			Time.get_fixedUnscaledTimeAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_fixedUnscaledTimeAsDoubleDelegate>("UnityEngine.Time::get_fixedUnscaledTimeAsDouble");
			Time.get_fixedUnscaledDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.get_fixedUnscaledDeltaTimeDelegate>("UnityEngine.Time::get_fixedUnscaledDeltaTime");
			Time.set_maximumDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.set_maximumDeltaTimeDelegate>("UnityEngine.Time::set_maximumDeltaTime");
			Time.get_maximumParticleDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.get_maximumParticleDeltaTimeDelegate>("UnityEngine.Time::get_maximumParticleDeltaTime");
			Time.set_maximumParticleDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.set_maximumParticleDeltaTimeDelegate>("UnityEngine.Time::set_maximumParticleDeltaTime");
			Time.get_captureDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.get_captureDeltaTimeDelegate>("UnityEngine.Time::get_captureDeltaTime");
			Time.set_captureDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.set_captureDeltaTimeDelegate>("UnityEngine.Time::set_captureDeltaTime");
			Time.get_inFixedTimeStepDelegateField = IL2CPP.ResolveICall<Time.get_inFixedTimeStepDelegate>("UnityEngine.Time::get_inFixedTimeStep");
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001B3D RID: 6973 RVA: 0x00071DBC File Offset: 0x0006FFBC
		public unsafe static float time
		{
			[CallerCount(197)]
			[CachedScanResults(RefRangeStart = 1272165, RefRangeEnd = 1272362, XrefRangeStart = 1272163, XrefRangeEnd = 1272165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_time_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001B3E RID: 6974 RVA: 0x00071DEC File Offset: 0x0006FFEC
		public unsafe static float timeSinceLevelLoad
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 1272364, RefRangeEnd = 1272412, XrefRangeStart = 1272362, XrefRangeEnd = 1272364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_timeSinceLevelLoad_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001B3F RID: 6975 RVA: 0x00071E1C File Offset: 0x0007001C
		public unsafe static float deltaTime
		{
			[CallerCount(566)]
			[CachedScanResults(RefRangeStart = 1272414, RefRangeEnd = 1272980, XrefRangeStart = 1272412, XrefRangeEnd = 1272414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001B40 RID: 6976 RVA: 0x00071E4C File Offset: 0x0007004C
		public unsafe static float unscaledTime
		{
			[CallerCount(69)]
			[CachedScanResults(RefRangeStart = 1272982, RefRangeEnd = 1273051, XrefRangeStart = 1272980, XrefRangeEnd = 1272982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_unscaledTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001B41 RID: 6977 RVA: 0x00071E7C File Offset: 0x0007007C
		public unsafe static float fixedUnscaledTime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1273053, RefRangeEnd = 1273054, XrefRangeStart = 1273051, XrefRangeEnd = 1273053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_fixedUnscaledTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001B42 RID: 6978 RVA: 0x00071EAC File Offset: 0x000700AC
		public unsafe static float unscaledDeltaTime
		{
			[CallerCount(55)]
			[CachedScanResults(RefRangeStart = 1273056, RefRangeEnd = 1273111, XrefRangeStart = 1273054, XrefRangeEnd = 1273056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_unscaledDeltaTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001B43 RID: 6979 RVA: 0x00071EDC File Offset: 0x000700DC
		// (set) Token: 0x06001B44 RID: 6980 RVA: 0x00071F0C File Offset: 0x0007010C
		public unsafe static float fixedDeltaTime
		{
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 1273113, RefRangeEnd = 1273152, XrefRangeStart = 1273111, XrefRangeEnd = 1273113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_fixedDeltaTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1273154, RefRangeEnd = 1273157, XrefRangeStart = 1273152, XrefRangeEnd = 1273154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_set_fixedDeltaTime_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001B45 RID: 6981 RVA: 0x00071F40 File Offset: 0x00070140
		// (set) Token: 0x06001B55 RID: 6997 RVA: 0x0000D10D File Offset: 0x0000B30D
		public unsafe static float maximumDeltaTime
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1273159, RefRangeEnd = 1273161, XrefRangeStart = 1273157, XrefRangeEnd = 1273159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_maximumDeltaTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Time.set_maximumDeltaTimeDelegateField(value);
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001B46 RID: 6982 RVA: 0x00071F70 File Offset: 0x00070170
		public unsafe static float smoothDeltaTime
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1273163, RefRangeEnd = 1273167, XrefRangeStart = 1273161, XrefRangeEnd = 1273163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_smoothDeltaTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x00071FA0 File Offset: 0x000701A0
		// (set) Token: 0x06001B48 RID: 6984 RVA: 0x00071FD0 File Offset: 0x000701D0
		public unsafe static float timeScale
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1273169, RefRangeEnd = 1273179, XrefRangeStart = 1273167, XrefRangeEnd = 1273169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_timeScale_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1273181, RefRangeEnd = 1273187, XrefRangeStart = 1273179, XrefRangeEnd = 1273181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_set_timeScale_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x00072004 File Offset: 0x00070204
		public unsafe static int frameCount
		{
			[CallerCount(56)]
			[CachedScanResults(RefRangeStart = 1273189, RefRangeEnd = 1273245, XrefRangeStart = 1273187, XrefRangeEnd = 1273189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_frameCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001B4A RID: 6986 RVA: 0x00072034 File Offset: 0x00070234
		public unsafe static int renderedFrameCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1273247, RefRangeEnd = 1273248, XrefRangeStart = 1273245, XrefRangeEnd = 1273247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_renderedFrameCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x00072064 File Offset: 0x00070264
		public unsafe static float realtimeSinceStartup
		{
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 1273250, RefRangeEnd = 1273283, XrefRangeStart = 1273248, XrefRangeEnd = 1273250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_realtimeSinceStartup_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001B4C RID: 6988 RVA: 0x00072094 File Offset: 0x00070294
		public unsafe static double realtimeSinceStartupAsDouble
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1273285, RefRangeEnd = 1273287, XrefRangeStart = 1273283, XrefRangeEnd = 1273285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_realtimeSinceStartupAsDouble_Public_Static_get_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
		public Time(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001B4E RID: 6990 RVA: 0x0000D0B9 File Offset: 0x0000B2B9
		public static double timeAsDouble
		{
			get
			{
				return Time.get_timeAsDoubleDelegateField();
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x0000D0C5 File Offset: 0x0000B2C5
		public static double timeSinceLevelLoadAsDouble
		{
			get
			{
				return Time.get_timeSinceLevelLoadAsDoubleDelegateField();
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x0000D0D1 File Offset: 0x0000B2D1
		public static float fixedTime
		{
			get
			{
				return Time.get_fixedTimeDelegateField();
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x0000D0DD File Offset: 0x0000B2DD
		public static double fixedTimeAsDouble
		{
			get
			{
				return Time.get_fixedTimeAsDoubleDelegateField();
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001B52 RID: 6994 RVA: 0x0000D0E9 File Offset: 0x0000B2E9
		public static double unscaledTimeAsDouble
		{
			get
			{
				return Time.get_unscaledTimeAsDoubleDelegateField();
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x0000D0F5 File Offset: 0x0000B2F5
		public static double fixedUnscaledTimeAsDouble
		{
			get
			{
				return Time.get_fixedUnscaledTimeAsDoubleDelegateField();
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001B54 RID: 6996 RVA: 0x0000D101 File Offset: 0x0000B301
		public static float fixedUnscaledDeltaTime
		{
			get
			{
				return Time.get_fixedUnscaledDeltaTimeDelegateField();
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001B56 RID: 6998 RVA: 0x0000D11A File Offset: 0x0000B31A
		// (set) Token: 0x06001B57 RID: 6999 RVA: 0x0000D126 File Offset: 0x0000B326
		public static float maximumParticleDeltaTime
		{
			get
			{
				return Time.get_maximumParticleDeltaTimeDelegateField();
			}
			set
			{
				Time.set_maximumParticleDeltaTimeDelegateField(value);
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001B58 RID: 7000 RVA: 0x0000D133 File Offset: 0x0000B333
		// (set) Token: 0x06001B59 RID: 7001 RVA: 0x0000D13F File Offset: 0x0000B33F
		public static float captureDeltaTime
		{
			get
			{
				return Time.get_captureDeltaTimeDelegateField();
			}
			set
			{
				Time.set_captureDeltaTimeDelegateField(value);
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001B5A RID: 7002 RVA: 0x000720C4 File Offset: 0x000702C4
		// (set) Token: 0x06001B5B RID: 7003 RVA: 0x0000D14C File Offset: 0x0000B34C
		public static int captureFramerate
		{
			get
			{
				return (Time.captureDeltaTime == 0f) ? 0 : ((int)Mathf.Round(1f / Time.captureDeltaTime));
			}
			set
			{
				Time.captureDeltaTime = ((value == 0) ? 0f : (1f / (float)value));
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001B5C RID: 7004 RVA: 0x0000D167 File Offset: 0x0000B367
		public static bool inFixedTimeStep
		{
			get
			{
				return Time.get_inFixedTimeStepDelegateField();
			}
		}

		// Token: 0x0400165F RID: 5727
		private static readonly IntPtr NativeMethodInfoPtr_get_time_Public_Static_get_Single_0;

		// Token: 0x04001660 RID: 5728
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSinceLevelLoad_Public_Static_get_Single_0;

		// Token: 0x04001661 RID: 5729
		private static readonly IntPtr NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0;

		// Token: 0x04001662 RID: 5730
		private static readonly IntPtr NativeMethodInfoPtr_get_unscaledTime_Public_Static_get_Single_0;

		// Token: 0x04001663 RID: 5731
		private static readonly IntPtr NativeMethodInfoPtr_get_fixedUnscaledTime_Public_Static_get_Single_0;

		// Token: 0x04001664 RID: 5732
		private static readonly IntPtr NativeMethodInfoPtr_get_unscaledDeltaTime_Public_Static_get_Single_0;

		// Token: 0x04001665 RID: 5733
		private static readonly IntPtr NativeMethodInfoPtr_get_fixedDeltaTime_Public_Static_get_Single_0;

		// Token: 0x04001666 RID: 5734
		private static readonly IntPtr NativeMethodInfoPtr_set_fixedDeltaTime_Public_Static_set_Void_Single_0;

		// Token: 0x04001667 RID: 5735
		private static readonly IntPtr NativeMethodInfoPtr_get_maximumDeltaTime_Public_Static_get_Single_0;

		// Token: 0x04001668 RID: 5736
		private static readonly IntPtr NativeMethodInfoPtr_get_smoothDeltaTime_Public_Static_get_Single_0;

		// Token: 0x04001669 RID: 5737
		private static readonly IntPtr NativeMethodInfoPtr_get_timeScale_Public_Static_get_Single_0;

		// Token: 0x0400166A RID: 5738
		private static readonly IntPtr NativeMethodInfoPtr_set_timeScale_Public_Static_set_Void_Single_0;

		// Token: 0x0400166B RID: 5739
		private static readonly IntPtr NativeMethodInfoPtr_get_frameCount_Public_Static_get_Int32_0;

		// Token: 0x0400166C RID: 5740
		private static readonly IntPtr NativeMethodInfoPtr_get_renderedFrameCount_Public_Static_get_Int32_0;

		// Token: 0x0400166D RID: 5741
		private static readonly IntPtr NativeMethodInfoPtr_get_realtimeSinceStartup_Public_Static_get_Single_0;

		// Token: 0x0400166E RID: 5742
		private static readonly IntPtr NativeMethodInfoPtr_get_realtimeSinceStartupAsDouble_Public_Static_get_Double_0;

		// Token: 0x0400166F RID: 5743
		private static readonly Time.get_timeAsDoubleDelegate get_timeAsDoubleDelegateField;

		// Token: 0x04001670 RID: 5744
		private static readonly Time.get_timeSinceLevelLoadAsDoubleDelegate get_timeSinceLevelLoadAsDoubleDelegateField;

		// Token: 0x04001671 RID: 5745
		private static readonly Time.get_fixedTimeDelegate get_fixedTimeDelegateField;

		// Token: 0x04001672 RID: 5746
		private static readonly Time.get_fixedTimeAsDoubleDelegate get_fixedTimeAsDoubleDelegateField;

		// Token: 0x04001673 RID: 5747
		private static readonly Time.get_unscaledTimeAsDoubleDelegate get_unscaledTimeAsDoubleDelegateField;

		// Token: 0x04001674 RID: 5748
		private static readonly Time.get_fixedUnscaledTimeAsDoubleDelegate get_fixedUnscaledTimeAsDoubleDelegateField;

		// Token: 0x04001675 RID: 5749
		private static readonly Time.get_fixedUnscaledDeltaTimeDelegate get_fixedUnscaledDeltaTimeDelegateField;

		// Token: 0x04001676 RID: 5750
		private static readonly Time.set_maximumDeltaTimeDelegate set_maximumDeltaTimeDelegateField;

		// Token: 0x04001677 RID: 5751
		private static readonly Time.get_maximumParticleDeltaTimeDelegate get_maximumParticleDeltaTimeDelegateField;

		// Token: 0x04001678 RID: 5752
		private static readonly Time.set_maximumParticleDeltaTimeDelegate set_maximumParticleDeltaTimeDelegateField;

		// Token: 0x04001679 RID: 5753
		private static readonly Time.get_captureDeltaTimeDelegate get_captureDeltaTimeDelegateField;

		// Token: 0x0400167A RID: 5754
		private static readonly Time.set_captureDeltaTimeDelegate set_captureDeltaTimeDelegateField;

		// Token: 0x0400167B RID: 5755
		private static readonly Time.get_inFixedTimeStepDelegate get_inFixedTimeStepDelegateField;

		// Token: 0x0200095D RID: 2397
		// (Invoke) Token: 0x06003B36 RID: 15158
		private delegate double get_timeAsDoubleDelegate();

		// Token: 0x0200095E RID: 2398
		// (Invoke) Token: 0x06003B38 RID: 15160
		private delegate double get_timeSinceLevelLoadAsDoubleDelegate();

		// Token: 0x0200095F RID: 2399
		// (Invoke) Token: 0x06003B3A RID: 15162
		private delegate float get_fixedTimeDelegate();

		// Token: 0x02000960 RID: 2400
		// (Invoke) Token: 0x06003B3C RID: 15164
		private delegate double get_fixedTimeAsDoubleDelegate();

		// Token: 0x02000961 RID: 2401
		// (Invoke) Token: 0x06003B3E RID: 15166
		private delegate double get_unscaledTimeAsDoubleDelegate();

		// Token: 0x02000962 RID: 2402
		// (Invoke) Token: 0x06003B40 RID: 15168
		private delegate double get_fixedUnscaledTimeAsDoubleDelegate();

		// Token: 0x02000963 RID: 2403
		// (Invoke) Token: 0x06003B42 RID: 15170
		private delegate float get_fixedUnscaledDeltaTimeDelegate();

		// Token: 0x02000964 RID: 2404
		// (Invoke) Token: 0x06003B44 RID: 15172
		private delegate void set_maximumDeltaTimeDelegate(float value);

		// Token: 0x02000965 RID: 2405
		// (Invoke) Token: 0x06003B46 RID: 15174
		private delegate float get_maximumParticleDeltaTimeDelegate();

		// Token: 0x02000966 RID: 2406
		// (Invoke) Token: 0x06003B48 RID: 15176
		private delegate void set_maximumParticleDeltaTimeDelegate(float value);

		// Token: 0x02000967 RID: 2407
		// (Invoke) Token: 0x06003B4A RID: 15178
		private delegate float get_captureDeltaTimeDelegate();

		// Token: 0x02000968 RID: 2408
		// (Invoke) Token: 0x06003B4C RID: 15180
		private delegate void set_captureDeltaTimeDelegate(float value);

		// Token: 0x02000969 RID: 2409
		// (Invoke) Token: 0x06003B4E RID: 15182
		private delegate bool get_inFixedTimeStepDelegate();
	}
}
