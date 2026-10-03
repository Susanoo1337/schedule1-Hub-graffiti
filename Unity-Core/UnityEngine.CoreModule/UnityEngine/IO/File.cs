using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.IO
{
	// Token: 0x02000353 RID: 851
	public static class File
	{
		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06002DE7 RID: 11751 RVA: 0x000AD188 File Offset: 0x000AB388
		public static ulong totalOpenCalls
		{
			get
			{
				return File.GetTotalOpenCalls();
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06002DE8 RID: 11752 RVA: 0x000AD1A0 File Offset: 0x000AB3A0
		public static ulong totalCloseCalls
		{
			get
			{
				return File.GetTotalCloseCalls();
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06002DE9 RID: 11753 RVA: 0x000AD1B8 File Offset: 0x000AB3B8
		public static ulong totalReadCalls
		{
			get
			{
				return File.GetTotalReadCalls();
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06002DEA RID: 11754 RVA: 0x000AD1D0 File Offset: 0x000AB3D0
		public static ulong totalWriteCalls
		{
			get
			{
				return File.GetTotalWriteCalls();
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06002DEB RID: 11755 RVA: 0x000AD1E8 File Offset: 0x000AB3E8
		public static ulong totalSeekCalls
		{
			get
			{
				return File.GetTotalSeekCalls();
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06002DEC RID: 11756 RVA: 0x000AD200 File Offset: 0x000AB400
		public static ulong totalZeroSeekCalls
		{
			get
			{
				return File.GetTotalZeroSeekCalls();
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06002DED RID: 11757 RVA: 0x000AD218 File Offset: 0x000AB418
		public static ulong totalFilesOpened
		{
			get
			{
				return File.GetTotalFilesOpened();
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06002DEE RID: 11758 RVA: 0x000AD230 File Offset: 0x000AB430
		public static ulong totalFilesClosed
		{
			get
			{
				return File.GetTotalFilesClosed();
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06002DEF RID: 11759 RVA: 0x000AD248 File Offset: 0x000AB448
		public static ulong totalBytesRead
		{
			get
			{
				return File.GetTotalBytesRead();
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06002DF0 RID: 11760 RVA: 0x000AD260 File Offset: 0x000AB460
		public static ulong totalBytesWritten
		{
			get
			{
				return File.GetTotalBytesWritten();
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06002DF2 RID: 11762 RVA: 0x000AD278 File Offset: 0x000AB478
		// (set) Token: 0x06002DF1 RID: 11761 RVA: 0x000146FE File Offset: 0x000128FE
		public static bool recordZeroSeeks
		{
			get
			{
				return File.GetRecordZeroSeeks();
			}
			set
			{
				File.SetRecordZeroSeeks(value);
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06002DF3 RID: 11763 RVA: 0x000AD290 File Offset: 0x000AB490
		// (set) Token: 0x06002DF4 RID: 11764 RVA: 0x00014708 File Offset: 0x00012908
		public static ThreadIORestrictionMode MainThreadIORestrictionMode
		{
			get
			{
				return File.GetMainThreadFileIORestriction();
			}
			set
			{
				File.SetMainThreadFileIORestriction(value);
			}
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x00014712 File Offset: 0x00012912
		public static void SetRecordZeroSeeks(bool enable)
		{
			File.SetRecordZeroSeeksDelegateField(enable);
		}

		// Token: 0x06002DF6 RID: 11766 RVA: 0x0001471F File Offset: 0x0001291F
		public static bool GetRecordZeroSeeks()
		{
			return File.GetRecordZeroSeeksDelegateField();
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x0001472B File Offset: 0x0001292B
		public static ulong GetTotalOpenCalls()
		{
			return File.GetTotalOpenCallsDelegateField();
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x00014737 File Offset: 0x00012937
		public static ulong GetTotalCloseCalls()
		{
			return File.GetTotalCloseCallsDelegateField();
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x00014743 File Offset: 0x00012943
		public static ulong GetTotalReadCalls()
		{
			return File.GetTotalReadCallsDelegateField();
		}

		// Token: 0x06002DFA RID: 11770 RVA: 0x0001474F File Offset: 0x0001294F
		public static ulong GetTotalWriteCalls()
		{
			return File.GetTotalWriteCallsDelegateField();
		}

		// Token: 0x06002DFB RID: 11771 RVA: 0x0001475B File Offset: 0x0001295B
		public static ulong GetTotalSeekCalls()
		{
			return File.GetTotalSeekCallsDelegateField();
		}

		// Token: 0x06002DFC RID: 11772 RVA: 0x00014767 File Offset: 0x00012967
		public static ulong GetTotalZeroSeekCalls()
		{
			return File.GetTotalZeroSeekCallsDelegateField();
		}

		// Token: 0x06002DFD RID: 11773 RVA: 0x00014773 File Offset: 0x00012973
		public static ulong GetTotalFilesOpened()
		{
			return File.GetTotalFilesOpenedDelegateField();
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x0001477F File Offset: 0x0001297F
		public static ulong GetTotalFilesClosed()
		{
			return File.GetTotalFilesClosedDelegateField();
		}

		// Token: 0x06002DFF RID: 11775 RVA: 0x0001478B File Offset: 0x0001298B
		public static ulong GetTotalBytesRead()
		{
			return File.GetTotalBytesReadDelegateField();
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x00014797 File Offset: 0x00012997
		public static ulong GetTotalBytesWritten()
		{
			return File.GetTotalBytesWrittenDelegateField();
		}

		// Token: 0x06002E01 RID: 11777 RVA: 0x000147A3 File Offset: 0x000129A3
		public static void SetMainThreadFileIORestriction(ThreadIORestrictionMode mode)
		{
			File.SetMainThreadFileIORestrictionDelegateField(mode);
		}

		// Token: 0x06002E02 RID: 11778 RVA: 0x000147B0 File Offset: 0x000129B0
		public static ThreadIORestrictionMode GetMainThreadFileIORestriction()
		{
			return File.GetMainThreadFileIORestrictionDelegateField();
		}

		// Token: 0x04002937 RID: 10551
		private static readonly File.SetRecordZeroSeeksDelegate SetRecordZeroSeeksDelegateField = IL2CPP.ResolveICall<File.SetRecordZeroSeeksDelegate>("UnityEngine.IO.File::SetRecordZeroSeeks");

		// Token: 0x04002938 RID: 10552
		private static readonly File.GetRecordZeroSeeksDelegate GetRecordZeroSeeksDelegateField = IL2CPP.ResolveICall<File.GetRecordZeroSeeksDelegate>("UnityEngine.IO.File::GetRecordZeroSeeks");

		// Token: 0x04002939 RID: 10553
		private static readonly File.GetTotalOpenCallsDelegate GetTotalOpenCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalOpenCallsDelegate>("UnityEngine.IO.File::GetTotalOpenCalls");

		// Token: 0x0400293A RID: 10554
		private static readonly File.GetTotalCloseCallsDelegate GetTotalCloseCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalCloseCallsDelegate>("UnityEngine.IO.File::GetTotalCloseCalls");

		// Token: 0x0400293B RID: 10555
		private static readonly File.GetTotalReadCallsDelegate GetTotalReadCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalReadCallsDelegate>("UnityEngine.IO.File::GetTotalReadCalls");

		// Token: 0x0400293C RID: 10556
		private static readonly File.GetTotalWriteCallsDelegate GetTotalWriteCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalWriteCallsDelegate>("UnityEngine.IO.File::GetTotalWriteCalls");

		// Token: 0x0400293D RID: 10557
		private static readonly File.GetTotalSeekCallsDelegate GetTotalSeekCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalSeekCallsDelegate>("UnityEngine.IO.File::GetTotalSeekCalls");

		// Token: 0x0400293E RID: 10558
		private static readonly File.GetTotalZeroSeekCallsDelegate GetTotalZeroSeekCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalZeroSeekCallsDelegate>("UnityEngine.IO.File::GetTotalZeroSeekCalls");

		// Token: 0x0400293F RID: 10559
		private static readonly File.GetTotalFilesOpenedDelegate GetTotalFilesOpenedDelegateField = IL2CPP.ResolveICall<File.GetTotalFilesOpenedDelegate>("UnityEngine.IO.File::GetTotalFilesOpened");

		// Token: 0x04002940 RID: 10560
		private static readonly File.GetTotalFilesClosedDelegate GetTotalFilesClosedDelegateField = IL2CPP.ResolveICall<File.GetTotalFilesClosedDelegate>("UnityEngine.IO.File::GetTotalFilesClosed");

		// Token: 0x04002941 RID: 10561
		private static readonly File.GetTotalBytesReadDelegate GetTotalBytesReadDelegateField = IL2CPP.ResolveICall<File.GetTotalBytesReadDelegate>("UnityEngine.IO.File::GetTotalBytesRead");

		// Token: 0x04002942 RID: 10562
		private static readonly File.GetTotalBytesWrittenDelegate GetTotalBytesWrittenDelegateField = IL2CPP.ResolveICall<File.GetTotalBytesWrittenDelegate>("UnityEngine.IO.File::GetTotalBytesWritten");

		// Token: 0x04002943 RID: 10563
		private static readonly File.SetMainThreadFileIORestrictionDelegate SetMainThreadFileIORestrictionDelegateField = IL2CPP.ResolveICall<File.SetMainThreadFileIORestrictionDelegate>("UnityEngine.IO.File::SetMainThreadFileIORestriction");

		// Token: 0x04002944 RID: 10564
		private static readonly File.GetMainThreadFileIORestrictionDelegate GetMainThreadFileIORestrictionDelegateField = IL2CPP.ResolveICall<File.GetMainThreadFileIORestrictionDelegate>("UnityEngine.IO.File::GetMainThreadFileIORestriction");

		// Token: 0x02000CF9 RID: 3321
		// (Invoke) Token: 0x0600428B RID: 17035
		private delegate void SetRecordZeroSeeksDelegate(bool enable);

		// Token: 0x02000CFA RID: 3322
		// (Invoke) Token: 0x0600428D RID: 17037
		private delegate bool GetRecordZeroSeeksDelegate();

		// Token: 0x02000CFB RID: 3323
		// (Invoke) Token: 0x0600428F RID: 17039
		private delegate ulong GetTotalOpenCallsDelegate();

		// Token: 0x02000CFC RID: 3324
		// (Invoke) Token: 0x06004291 RID: 17041
		private delegate ulong GetTotalCloseCallsDelegate();

		// Token: 0x02000CFD RID: 3325
		// (Invoke) Token: 0x06004293 RID: 17043
		private delegate ulong GetTotalReadCallsDelegate();

		// Token: 0x02000CFE RID: 3326
		// (Invoke) Token: 0x06004295 RID: 17045
		private delegate ulong GetTotalWriteCallsDelegate();

		// Token: 0x02000CFF RID: 3327
		// (Invoke) Token: 0x06004297 RID: 17047
		private delegate ulong GetTotalSeekCallsDelegate();

		// Token: 0x02000D00 RID: 3328
		// (Invoke) Token: 0x06004299 RID: 17049
		private delegate ulong GetTotalZeroSeekCallsDelegate();

		// Token: 0x02000D01 RID: 3329
		// (Invoke) Token: 0x0600429B RID: 17051
		private delegate ulong GetTotalFilesOpenedDelegate();

		// Token: 0x02000D02 RID: 3330
		// (Invoke) Token: 0x0600429D RID: 17053
		private delegate ulong GetTotalFilesClosedDelegate();

		// Token: 0x02000D03 RID: 3331
		// (Invoke) Token: 0x0600429F RID: 17055
		private delegate ulong GetTotalBytesReadDelegate();

		// Token: 0x02000D04 RID: 3332
		// (Invoke) Token: 0x060042A1 RID: 17057
		private delegate ulong GetTotalBytesWrittenDelegate();

		// Token: 0x02000D05 RID: 3333
		// (Invoke) Token: 0x060042A3 RID: 17059
		private delegate void SetMainThreadFileIORestrictionDelegate(ThreadIORestrictionMode mode);

		// Token: 0x02000D06 RID: 3334
		// (Invoke) Token: 0x060042A5 RID: 17061
		private delegate ThreadIORestrictionMode GetMainThreadFileIORestrictionDelegate();
	}
}
