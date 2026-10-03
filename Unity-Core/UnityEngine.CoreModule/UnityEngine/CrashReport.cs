using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x020002C0 RID: 704
	public sealed class CrashReport
	{
		// Token: 0x06002CC0 RID: 11456 RVA: 0x000139ED File Offset: 0x00011BED
		public static int Compare(CrashReport c1, CrashReport c2)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002CC1 RID: 11457 RVA: 0x000139FA File Offset: 0x00011BFA
		public static void PopulateReports()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06002CC2 RID: 11458 RVA: 0x00013A07 File Offset: 0x00011C07
		public static Il2CppReferenceArray<CrashReport> reports
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06002CC3 RID: 11459 RVA: 0x00013A14 File Offset: 0x00011C14
		public static CrashReport lastReport
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x00013A21 File Offset: 0x00011C21
		public static void RemoveAll()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x00013A2E File Offset: 0x00011C2E
		public void Remove()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x000AB9B4 File Offset: 0x000A9BB4
		public static Il2CppStringArray GetReports()
		{
			IntPtr intPtr = CrashReport.GetReportsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x000AB9DC File Offset: 0x000A9BDC
		public static string GetReportData(string id, out double secondsSinceUnixEpoch)
		{
			IntPtr intPtr = CrashReport.GetReportDataDelegateField(IL2CPP.ManagedStringToIl2Cpp(id), out secondsSinceUnixEpoch);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x00013A3B File Offset: 0x00011C3B
		public static bool RemoveReport(string id)
		{
			return CrashReport.RemoveReportDelegateField(IL2CPP.ManagedStringToIl2Cpp(id));
		}

		// Token: 0x04002707 RID: 9991
		private static readonly CrashReport.GetReportsDelegate GetReportsDelegateField = IL2CPP.ResolveICall<CrashReport.GetReportsDelegate>("UnityEngine.CrashReport::GetReports");

		// Token: 0x04002708 RID: 9992
		private static readonly CrashReport.GetReportDataDelegate GetReportDataDelegateField = IL2CPP.ResolveICall<CrashReport.GetReportDataDelegate>("UnityEngine.CrashReport::GetReportData");

		// Token: 0x04002709 RID: 9993
		private static readonly CrashReport.RemoveReportDelegate RemoveReportDelegateField = IL2CPP.ResolveICall<CrashReport.RemoveReportDelegate>("UnityEngine.CrashReport::RemoveReport");

		// Token: 0x02000C7C RID: 3196
		// (Invoke) Token: 0x06004197 RID: 16791
		private delegate IntPtr GetReportsDelegate();

		// Token: 0x02000C7D RID: 3197
		// (Invoke) Token: 0x06004199 RID: 16793
		private delegate IntPtr GetReportDataDelegate(IntPtr id, [Out] IntPtr secondsSinceUnixEpoch);

		// Token: 0x02000C7E RID: 3198
		// (Invoke) Token: 0x0600419B RID: 16795
		private delegate bool RemoveReportDelegate(IntPtr id);
	}
}
