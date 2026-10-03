using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200009A RID: 154
	public static class FrameTimingManager : Object
	{
		// Token: 0x06000940 RID: 2368 RVA: 0x00034D54 File Offset: 0x00032F54
		// Note: this type is marked as 'beforefieldinit'.
		static FrameTimingManager()
		{
			Il2CppClassPointerStore<FrameTimingManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "FrameTimingManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameTimingManager>.NativeClassPtr);
			FrameTimingManager.NativeMethodInfoPtr_CaptureFrameTimings_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimingManager>.NativeClassPtr, 100664247);
			FrameTimingManager.NativeMethodInfoPtr_GetLatestTimings_Public_Static_UInt32_UInt32_Il2CppStructArray_1_FrameTiming_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimingManager>.NativeClassPtr, 100664248);
			FrameTimingManager.IsFeatureEnabledDelegateField = IL2CPP.ResolveICall<FrameTimingManager.IsFeatureEnabledDelegate>("UnityEngine.FrameTimingManager::IsFeatureEnabled");
			FrameTimingManager.GetVSyncsPerSecondDelegateField = IL2CPP.ResolveICall<FrameTimingManager.GetVSyncsPerSecondDelegate>("UnityEngine.FrameTimingManager::GetVSyncsPerSecond");
			FrameTimingManager.GetGpuTimerFrequencyDelegateField = IL2CPP.ResolveICall<FrameTimingManager.GetGpuTimerFrequencyDelegate>("UnityEngine.FrameTimingManager::GetGpuTimerFrequency");
			FrameTimingManager.GetCpuTimerFrequencyDelegateField = IL2CPP.ResolveICall<FrameTimingManager.GetCpuTimerFrequencyDelegate>("UnityEngine.FrameTimingManager::GetCpuTimerFrequency");
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00034DE8 File Offset: 0x00032FE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1234339, RefRangeEnd = 1234342, XrefRangeStart = 1234337, XrefRangeEnd = 1234339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CaptureFrameTimings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimingManager.NativeMethodInfoPtr_CaptureFrameTimings_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00034E10 File Offset: 0x00033010
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1234344, RefRangeEnd = 1234347, XrefRangeStart = 1234342, XrefRangeEnd = 1234344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetLatestTimings(uint numFrames, Il2CppStructArray<FrameTiming> timings)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref numFrames;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(timings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimingManager.NativeMethodInfoPtr_GetLatestTimings_Public_Static_UInt32_UInt32_Il2CppStructArray_1_FrameTiming_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00005F90 File Offset: 0x00004190
		public FrameTimingManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00005F99 File Offset: 0x00004199
		public static bool IsFeatureEnabled()
		{
			return FrameTimingManager.IsFeatureEnabledDelegateField();
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00005FA5 File Offset: 0x000041A5
		public static float GetVSyncsPerSecond()
		{
			return FrameTimingManager.GetVSyncsPerSecondDelegateField();
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00005FB1 File Offset: 0x000041B1
		public static ulong GetGpuTimerFrequency()
		{
			return FrameTimingManager.GetGpuTimerFrequencyDelegateField();
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00005FBD File Offset: 0x000041BD
		public static ulong GetCpuTimerFrequency()
		{
			return FrameTimingManager.GetCpuTimerFrequencyDelegateField();
		}

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeMethodInfoPtr_CaptureFrameTimings_Public_Static_Void_0;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeMethodInfoPtr_GetLatestTimings_Public_Static_UInt32_UInt32_Il2CppStructArray_1_FrameTiming_0;

		// Token: 0x0400073D RID: 1853
		private static readonly FrameTimingManager.IsFeatureEnabledDelegate IsFeatureEnabledDelegateField;

		// Token: 0x0400073E RID: 1854
		private static readonly FrameTimingManager.GetVSyncsPerSecondDelegate GetVSyncsPerSecondDelegateField;

		// Token: 0x0400073F RID: 1855
		private static readonly FrameTimingManager.GetGpuTimerFrequencyDelegate GetGpuTimerFrequencyDelegateField;

		// Token: 0x04000740 RID: 1856
		private static readonly FrameTimingManager.GetCpuTimerFrequencyDelegate GetCpuTimerFrequencyDelegateField;

		// Token: 0x0200055E RID: 1374
		// (Invoke) Token: 0x06003376 RID: 13174
		private delegate bool IsFeatureEnabledDelegate();

		// Token: 0x0200055F RID: 1375
		// (Invoke) Token: 0x06003378 RID: 13176
		private delegate float GetVSyncsPerSecondDelegate();

		// Token: 0x02000560 RID: 1376
		// (Invoke) Token: 0x0600337A RID: 13178
		private delegate ulong GetGpuTimerFrequencyDelegate();

		// Token: 0x02000561 RID: 1377
		// (Invoke) Token: 0x0600337C RID: 13180
		private delegate ulong GetCpuTimerFrequencyDelegate();
	}
}
