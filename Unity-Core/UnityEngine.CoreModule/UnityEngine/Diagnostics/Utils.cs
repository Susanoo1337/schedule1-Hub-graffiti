using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Diagnostics
{
	// Token: 0x02000358 RID: 856
	public static class Utils
	{
		// Token: 0x06002E05 RID: 11781 RVA: 0x000147C9 File Offset: 0x000129C9
		public static void ForceCrash(ForcedCrashCategory crashCategory)
		{
			Utils.ForceCrashDelegateField(crashCategory);
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x000147D6 File Offset: 0x000129D6
		public static void NativeAssert(string message)
		{
			Utils.NativeAssertDelegateField(IL2CPP.ManagedStringToIl2Cpp(message));
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x000147E8 File Offset: 0x000129E8
		public static void NativeError(string message)
		{
			Utils.NativeErrorDelegateField(IL2CPP.ManagedStringToIl2Cpp(message));
		}

		// Token: 0x06002E08 RID: 11784 RVA: 0x000147FA File Offset: 0x000129FA
		public static void NativeWarning(string message)
		{
			Utils.NativeWarningDelegateField(IL2CPP.ManagedStringToIl2Cpp(message));
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x0001480C File Offset: 0x00012A0C
		public static void ValidateHeap()
		{
			Utils.ValidateHeapDelegateField();
		}

		// Token: 0x04002955 RID: 10581
		private static readonly Utils.ForceCrashDelegate ForceCrashDelegateField = IL2CPP.ResolveICall<Utils.ForceCrashDelegate>("UnityEngine.Diagnostics.Utils::ForceCrash");

		// Token: 0x04002956 RID: 10582
		private static readonly Utils.NativeAssertDelegate NativeAssertDelegateField = IL2CPP.ResolveICall<Utils.NativeAssertDelegate>("UnityEngine.Diagnostics.Utils::NativeAssert");

		// Token: 0x04002957 RID: 10583
		private static readonly Utils.NativeErrorDelegate NativeErrorDelegateField = IL2CPP.ResolveICall<Utils.NativeErrorDelegate>("UnityEngine.Diagnostics.Utils::NativeError");

		// Token: 0x04002958 RID: 10584
		private static readonly Utils.NativeWarningDelegate NativeWarningDelegateField = IL2CPP.ResolveICall<Utils.NativeWarningDelegate>("UnityEngine.Diagnostics.Utils::NativeWarning");

		// Token: 0x04002959 RID: 10585
		private static readonly Utils.ValidateHeapDelegate ValidateHeapDelegateField = IL2CPP.ResolveICall<Utils.ValidateHeapDelegate>("UnityEngine.Diagnostics.Utils::ValidateHeap");

		// Token: 0x02000D07 RID: 3335
		// (Invoke) Token: 0x060042A7 RID: 17063
		private delegate void ForceCrashDelegate(ForcedCrashCategory crashCategory);

		// Token: 0x02000D08 RID: 3336
		// (Invoke) Token: 0x060042A9 RID: 17065
		private delegate void NativeAssertDelegate(IntPtr message);

		// Token: 0x02000D09 RID: 3337
		// (Invoke) Token: 0x060042AB RID: 17067
		private delegate void NativeErrorDelegate(IntPtr message);

		// Token: 0x02000D0A RID: 3338
		// (Invoke) Token: 0x060042AD RID: 17069
		private delegate void NativeWarningDelegate(IntPtr message);

		// Token: 0x02000D0B RID: 3339
		// (Invoke) Token: 0x060042AF RID: 17071
		private delegate void ValidateHeapDelegate();
	}
}
