using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Scripting
{
	// Token: 0x02000326 RID: 806
	public static class GarbageCollector
	{
		// Token: 0x06002DB7 RID: 11703 RVA: 0x000144A4 File Offset: 0x000126A4
		public static void add_GCModeChanged(Action<GarbageCollector.Mode> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x000144B1 File Offset: 0x000126B1
		public static void remove_GCModeChanged(Action<GarbageCollector.Mode> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06002DB9 RID: 11705 RVA: 0x000ACF7C File Offset: 0x000AB17C
		// (set) Token: 0x06002DBA RID: 11706 RVA: 0x000144BE File Offset: 0x000126BE
		public static GarbageCollector.Mode GCMode
		{
			get
			{
				return GarbageCollector.GetMode();
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x000144CB File Offset: 0x000126CB
		public static void SetMode(GarbageCollector.Mode mode)
		{
			GarbageCollector.SetModeDelegateField(mode);
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x000144D8 File Offset: 0x000126D8
		public static GarbageCollector.Mode GetMode()
		{
			return GarbageCollector.GetModeDelegateField();
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06002DBD RID: 11709 RVA: 0x000144E4 File Offset: 0x000126E4
		public static bool isIncremental
		{
			get
			{
				return GarbageCollector.get_isIncrementalDelegateField();
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06002DBE RID: 11710 RVA: 0x000144F0 File Offset: 0x000126F0
		// (set) Token: 0x06002DBF RID: 11711 RVA: 0x000144FC File Offset: 0x000126FC
		public static ulong incrementalTimeSliceNanoseconds
		{
			get
			{
				return GarbageCollector.get_incrementalTimeSliceNanosecondsDelegateField();
			}
			set
			{
				GarbageCollector.set_incrementalTimeSliceNanosecondsDelegateField(value);
			}
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x00014509 File Offset: 0x00012709
		public static bool CollectIncremental([Optional] ulong nanoseconds)
		{
			return GarbageCollector.CollectIncrementalDelegateField(nanoseconds);
		}

		// Token: 0x04002891 RID: 10385
		private static readonly GarbageCollector.SetModeDelegate SetModeDelegateField = IL2CPP.ResolveICall<GarbageCollector.SetModeDelegate>("UnityEngine.Scripting.GarbageCollector::SetMode");

		// Token: 0x04002892 RID: 10386
		private static readonly GarbageCollector.GetModeDelegate GetModeDelegateField = IL2CPP.ResolveICall<GarbageCollector.GetModeDelegate>("UnityEngine.Scripting.GarbageCollector::GetMode");

		// Token: 0x04002893 RID: 10387
		private static readonly GarbageCollector.get_isIncrementalDelegate get_isIncrementalDelegateField = IL2CPP.ResolveICall<GarbageCollector.get_isIncrementalDelegate>("UnityEngine.Scripting.GarbageCollector::get_isIncremental");

		// Token: 0x04002894 RID: 10388
		private static readonly GarbageCollector.get_incrementalTimeSliceNanosecondsDelegate get_incrementalTimeSliceNanosecondsDelegateField = IL2CPP.ResolveICall<GarbageCollector.get_incrementalTimeSliceNanosecondsDelegate>("UnityEngine.Scripting.GarbageCollector::get_incrementalTimeSliceNanoseconds");

		// Token: 0x04002895 RID: 10389
		private static readonly GarbageCollector.set_incrementalTimeSliceNanosecondsDelegate set_incrementalTimeSliceNanosecondsDelegateField = IL2CPP.ResolveICall<GarbageCollector.set_incrementalTimeSliceNanosecondsDelegate>("UnityEngine.Scripting.GarbageCollector::set_incrementalTimeSliceNanoseconds");

		// Token: 0x04002896 RID: 10390
		private static readonly GarbageCollector.CollectIncrementalDelegate CollectIncrementalDelegateField = IL2CPP.ResolveICall<GarbageCollector.CollectIncrementalDelegate>("UnityEngine.Scripting.GarbageCollector::CollectIncremental");

		// Token: 0x02000CE3 RID: 3299
		public enum Mode
		{
			// Token: 0x04002C84 RID: 11396
			Disabled,
			// Token: 0x04002C85 RID: 11397
			Enabled,
			// Token: 0x04002C86 RID: 11398
			Manual
		}

		// Token: 0x02000CE4 RID: 3300
		// (Invoke) Token: 0x06004263 RID: 16995
		private delegate void SetModeDelegate(GarbageCollector.Mode mode);

		// Token: 0x02000CE5 RID: 3301
		// (Invoke) Token: 0x06004265 RID: 16997
		private delegate GarbageCollector.Mode GetModeDelegate();

		// Token: 0x02000CE6 RID: 3302
		// (Invoke) Token: 0x06004267 RID: 16999
		private delegate bool get_isIncrementalDelegate();

		// Token: 0x02000CE7 RID: 3303
		// (Invoke) Token: 0x06004269 RID: 17001
		private delegate ulong get_incrementalTimeSliceNanosecondsDelegate();

		// Token: 0x02000CE8 RID: 3304
		// (Invoke) Token: 0x0600426B RID: 17003
		private delegate void set_incrementalTimeSliceNanosecondsDelegate(ulong value);

		// Token: 0x02000CE9 RID: 3305
		// (Invoke) Token: 0x0600426D RID: 17005
		private delegate bool CollectIncrementalDelegate(ulong nanoseconds);
	}
}
