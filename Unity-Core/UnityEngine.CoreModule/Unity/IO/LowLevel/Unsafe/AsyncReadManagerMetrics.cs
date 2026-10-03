using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x02000298 RID: 664
	public static class AsyncReadManagerMetrics
	{
		// Token: 0x06002C51 RID: 11345 RVA: 0x000135F2 File Offset: 0x000117F2
		public static bool IsEnabled()
		{
			return AsyncReadManagerMetrics.IsEnabledDelegateField();
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x000135FE File Offset: 0x000117FE
		public static void ClearMetrics_Internal()
		{
			AsyncReadManagerMetrics.ClearMetrics_InternalDelegateField();
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x0001360A File Offset: 0x0001180A
		public static void ClearCompletedMetrics()
		{
			AsyncReadManagerMetrics.ClearMetrics_Internal();
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x000AB204 File Offset: 0x000A9404
		public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics_Internal(bool clear)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetMetrics_InternalDelegateField(clear);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AsyncReadManagerRequestMetric>>(intPtr2) : null;
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x00013613 File Offset: 0x00011813
		public static void GetMetrics_NoAlloc_Internal(List<AsyncReadManagerRequestMetric> metrics, bool clear)
		{
			AsyncReadManagerMetrics.GetMetrics_NoAlloc_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics), clear);
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x000AB22C File Offset: 0x000A942C
		public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics_Filtered_Internal(AsyncReadManagerMetricsFilters filters, bool clear)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetMetrics_Filtered_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(filters), clear);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AsyncReadManagerRequestMetric>>(intPtr2) : null;
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x00013626 File Offset: 0x00011826
		public static void GetMetrics_NoAlloc_Filtered_Internal(List<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters filters, bool clear)
		{
			AsyncReadManagerMetrics.GetMetrics_NoAlloc_Filtered_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics), IL2CPP.Il2CppObjectBaseToPtr(filters), clear);
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x000AB25C File Offset: 0x000A945C
		public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics(AsyncReadManagerMetricsFilters filters, AsyncReadManagerMetrics.Flags flags)
		{
			bool clear = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			return AsyncReadManagerMetrics.GetMetrics_Filtered_Internal(filters, clear);
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x000AB280 File Offset: 0x000A9480
		public static void GetMetrics(List<AsyncReadManagerRequestMetric> outMetrics, AsyncReadManagerMetricsFilters filters, AsyncReadManagerMetrics.Flags flags)
		{
			bool clear = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			AsyncReadManagerMetrics.GetMetrics_NoAlloc_Filtered_Internal(outMetrics, filters, clear);
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x000AB2A4 File Offset: 0x000A94A4
		public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics(AsyncReadManagerMetrics.Flags flags)
		{
			bool clear = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			return AsyncReadManagerMetrics.GetMetrics_Internal(clear);
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x000AB2C8 File Offset: 0x000A94C8
		public static void GetMetrics(List<AsyncReadManagerRequestMetric> outMetrics, AsyncReadManagerMetrics.Flags flags)
		{
			bool clear = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			AsyncReadManagerMetrics.GetMetrics_NoAlloc_Internal(outMetrics, clear);
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x0001363F File Offset: 0x0001183F
		public static void StartCollectingMetrics()
		{
			AsyncReadManagerMetrics.StartCollectingMetricsDelegateField();
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x0001364B File Offset: 0x0001184B
		public static void StopCollectingMetrics()
		{
			AsyncReadManagerMetrics.StopCollectingMetricsDelegateField();
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x000AB2EC File Offset: 0x000A94EC
		public static AsyncReadManagerSummaryMetrics GetSummaryMetrics_Internal(bool clear)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryMetrics_InternalDelegateField(clear);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x000AB314 File Offset: 0x000A9514
		public static AsyncReadManagerSummaryMetrics GetCurrentSummaryMetrics(AsyncReadManagerMetrics.Flags flags)
		{
			bool clear = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			return AsyncReadManagerMetrics.GetSummaryMetrics_Internal(clear);
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x000AB338 File Offset: 0x000A9538
		public static AsyncReadManagerSummaryMetrics GetSummaryMetricsWithFilters_Internal(AsyncReadManagerMetricsFilters metricsFilters, bool clear)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryMetricsWithFilters_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metricsFilters), clear);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x000AB368 File Offset: 0x000A9568
		public static AsyncReadManagerSummaryMetrics GetCurrentSummaryMetrics(AsyncReadManagerMetricsFilters metricsFilters, AsyncReadManagerMetrics.Flags flags)
		{
			bool clear = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
			return AsyncReadManagerMetrics.GetSummaryMetricsWithFilters_Internal(metricsFilters, clear);
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x000AB38C File Offset: 0x000A958C
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics_Internal(Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryOfMetrics_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x000AB3B8 File Offset: 0x000A95B8
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics)
		{
			return AsyncReadManagerMetrics.GetSummaryOfMetrics_Internal(metrics);
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x000AB3D0 File Offset: 0x000A95D0
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics_FromContainer_Internal(List<AsyncReadManagerRequestMetric> metrics)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryOfMetrics_FromContainer_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x000AB3FC File Offset: 0x000A95FC
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(List<AsyncReadManagerRequestMetric> metrics)
		{
			return AsyncReadManagerMetrics.GetSummaryOfMetrics_FromContainer_Internal(metrics);
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x000AB414 File Offset: 0x000A9614
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetricsWithFilters_Internal(Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters metricsFilters)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics), IL2CPP.Il2CppObjectBaseToPtr(metricsFilters));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x000AB448 File Offset: 0x000A9648
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters metricsFilters)
		{
			return AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_Internal(metrics, metricsFilters);
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x000AB464 File Offset: 0x000A9664
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetricsWithFilters_FromContainer_Internal(List<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters metricsFilters)
		{
			IntPtr intPtr = AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(metrics), IL2CPP.Il2CppObjectBaseToPtr(metricsFilters));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(intPtr2) : null;
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x000AB498 File Offset: 0x000A9698
		public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(List<AsyncReadManagerRequestMetric> metrics, AsyncReadManagerMetricsFilters metricsFilters)
		{
			return AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_FromContainer_Internal(metrics, metricsFilters);
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x00013657 File Offset: 0x00011857
		public static ulong GetTotalSizeOfNonASRMReadsBytes(bool emptyAfterRead)
		{
			return AsyncReadManagerMetrics.GetTotalSizeOfNonASRMReadsBytesDelegateField(emptyAfterRead);
		}

		// Token: 0x040026B2 RID: 9906
		private static readonly AsyncReadManagerMetrics.IsEnabledDelegate IsEnabledDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.IsEnabledDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::IsEnabled");

		// Token: 0x040026B3 RID: 9907
		private static readonly AsyncReadManagerMetrics.ClearMetrics_InternalDelegate ClearMetrics_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.ClearMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::ClearMetrics_Internal");

		// Token: 0x040026B4 RID: 9908
		private static readonly AsyncReadManagerMetrics.GetMetrics_InternalDelegate GetMetrics_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_Internal");

		// Token: 0x040026B5 RID: 9909
		private static readonly AsyncReadManagerMetrics.GetMetrics_NoAlloc_InternalDelegate GetMetrics_NoAlloc_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetMetrics_NoAlloc_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_NoAlloc_Internal");

		// Token: 0x040026B6 RID: 9910
		private static readonly AsyncReadManagerMetrics.GetMetrics_Filtered_InternalDelegate GetMetrics_Filtered_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetMetrics_Filtered_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_Filtered_Internal");

		// Token: 0x040026B7 RID: 9911
		private static readonly AsyncReadManagerMetrics.GetMetrics_NoAlloc_Filtered_InternalDelegate GetMetrics_NoAlloc_Filtered_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetMetrics_NoAlloc_Filtered_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_NoAlloc_Filtered_Internal");

		// Token: 0x040026B8 RID: 9912
		private static readonly AsyncReadManagerMetrics.StartCollectingMetricsDelegate StartCollectingMetricsDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.StartCollectingMetricsDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::StartCollectingMetrics");

		// Token: 0x040026B9 RID: 9913
		private static readonly AsyncReadManagerMetrics.StopCollectingMetricsDelegate StopCollectingMetricsDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.StopCollectingMetricsDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::StopCollectingMetrics");

		// Token: 0x040026BA RID: 9914
		private static readonly AsyncReadManagerMetrics.GetSummaryMetrics_InternalDelegate GetSummaryMetrics_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryMetrics_Internal");

		// Token: 0x040026BB RID: 9915
		private static readonly AsyncReadManagerMetrics.GetSummaryMetricsWithFilters_InternalDelegate GetSummaryMetricsWithFilters_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryMetricsWithFilters_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryMetricsWithFilters_Internal");

		// Token: 0x040026BC RID: 9916
		private static readonly AsyncReadManagerMetrics.GetSummaryOfMetrics_InternalDelegate GetSummaryOfMetrics_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryOfMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetrics_Internal");

		// Token: 0x040026BD RID: 9917
		private static readonly AsyncReadManagerMetrics.GetSummaryOfMetrics_FromContainer_InternalDelegate GetSummaryOfMetrics_FromContainer_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryOfMetrics_FromContainer_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetrics_FromContainer_Internal");

		// Token: 0x040026BE RID: 9918
		private static readonly AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_InternalDelegate GetSummaryOfMetricsWithFilters_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetricsWithFilters_Internal");

		// Token: 0x040026BF RID: 9919
		private static readonly AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegate GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetricsWithFilters_FromContainer_Internal");

		// Token: 0x040026C0 RID: 9920
		private static readonly AsyncReadManagerMetrics.GetTotalSizeOfNonASRMReadsBytesDelegate GetTotalSizeOfNonASRMReadsBytesDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetTotalSizeOfNonASRMReadsBytesDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetTotalSizeOfNonASRMReadsBytes");

		// Token: 0x02000C59 RID: 3161
		public enum Flags
		{
			// Token: 0x04002C7D RID: 11389
			None,
			// Token: 0x04002C7E RID: 11390
			ClearOnRead
		}

		// Token: 0x02000C5A RID: 3162
		// (Invoke) Token: 0x06004153 RID: 16723
		private delegate bool IsEnabledDelegate();

		// Token: 0x02000C5B RID: 3163
		// (Invoke) Token: 0x06004155 RID: 16725
		private delegate void ClearMetrics_InternalDelegate();

		// Token: 0x02000C5C RID: 3164
		// (Invoke) Token: 0x06004157 RID: 16727
		private delegate IntPtr GetMetrics_InternalDelegate(bool clear);

		// Token: 0x02000C5D RID: 3165
		// (Invoke) Token: 0x06004159 RID: 16729
		private delegate void GetMetrics_NoAlloc_InternalDelegate(IntPtr metrics, bool clear);

		// Token: 0x02000C5E RID: 3166
		// (Invoke) Token: 0x0600415B RID: 16731
		private delegate IntPtr GetMetrics_Filtered_InternalDelegate(IntPtr filters, bool clear);

		// Token: 0x02000C5F RID: 3167
		// (Invoke) Token: 0x0600415D RID: 16733
		private delegate void GetMetrics_NoAlloc_Filtered_InternalDelegate(IntPtr metrics, IntPtr filters, bool clear);

		// Token: 0x02000C60 RID: 3168
		// (Invoke) Token: 0x0600415F RID: 16735
		private delegate void StartCollectingMetricsDelegate();

		// Token: 0x02000C61 RID: 3169
		// (Invoke) Token: 0x06004161 RID: 16737
		private delegate void StopCollectingMetricsDelegate();

		// Token: 0x02000C62 RID: 3170
		// (Invoke) Token: 0x06004163 RID: 16739
		private delegate IntPtr GetSummaryMetrics_InternalDelegate(bool clear);

		// Token: 0x02000C63 RID: 3171
		// (Invoke) Token: 0x06004165 RID: 16741
		private delegate IntPtr GetSummaryMetricsWithFilters_InternalDelegate(IntPtr metricsFilters, bool clear);

		// Token: 0x02000C64 RID: 3172
		// (Invoke) Token: 0x06004167 RID: 16743
		private delegate IntPtr GetSummaryOfMetrics_InternalDelegate(IntPtr metrics);

		// Token: 0x02000C65 RID: 3173
		// (Invoke) Token: 0x06004169 RID: 16745
		private delegate IntPtr GetSummaryOfMetrics_FromContainer_InternalDelegate(IntPtr metrics);

		// Token: 0x02000C66 RID: 3174
		// (Invoke) Token: 0x0600416B RID: 16747
		private delegate IntPtr GetSummaryOfMetricsWithFilters_InternalDelegate(IntPtr metrics, IntPtr metricsFilters);

		// Token: 0x02000C67 RID: 3175
		// (Invoke) Token: 0x0600416D RID: 16749
		private delegate IntPtr GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegate(IntPtr metrics, IntPtr metricsFilters);

		// Token: 0x02000C68 RID: 3176
		// (Invoke) Token: 0x0600416F RID: 16751
		private delegate ulong GetTotalSizeOfNonASRMReadsBytesDelegate(bool emptyAfterRead);
	}
}
