using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.TestTools
{
	// Token: 0x0200035E RID: 862
	public static class Coverage
	{
		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06002ED9 RID: 11993 RVA: 0x00014DB5 File Offset: 0x00012FB5
		// (set) Token: 0x06002EDA RID: 11994 RVA: 0x00014DC1 File Offset: 0x00012FC1
		public static bool enabled
		{
			get
			{
				return Coverage.get_enabledDelegateField();
			}
			set
			{
				Coverage.set_enabledDelegateField(value);
			}
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x00014DCE File Offset: 0x00012FCE
		public static void ResetFor_Internal(MethodBase method)
		{
			Coverage.ResetFor_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(method));
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x000AD5A8 File Offset: 0x000AB7A8
		public static void ResetFor(MethodBase method)
		{
			bool flag = method == null;
			if (flag)
			{
				throw new ArgumentNullException("method");
			}
			Coverage.ResetFor_Internal(method);
		}

		// Token: 0x06002EDD RID: 11997 RVA: 0x00014DE0 File Offset: 0x00012FE0
		public static void ResetAll()
		{
			Coverage.ResetAllDelegateField();
		}

		// Token: 0x0400295B RID: 10587
		private static readonly Coverage.get_enabledDelegate get_enabledDelegateField = IL2CPP.ResolveICall<Coverage.get_enabledDelegate>("UnityEngine.TestTools.Coverage::get_enabled");

		// Token: 0x0400295C RID: 10588
		private static readonly Coverage.set_enabledDelegate set_enabledDelegateField = IL2CPP.ResolveICall<Coverage.set_enabledDelegate>("UnityEngine.TestTools.Coverage::set_enabled");

		// Token: 0x0400295D RID: 10589
		private static readonly Coverage.ResetFor_InternalDelegate ResetFor_InternalDelegateField = IL2CPP.ResolveICall<Coverage.ResetFor_InternalDelegate>("UnityEngine.TestTools.Coverage::ResetFor_Internal");

		// Token: 0x0400295E RID: 10590
		private static readonly Coverage.ResetAllDelegate ResetAllDelegateField = IL2CPP.ResolveICall<Coverage.ResetAllDelegate>("UnityEngine.TestTools.Coverage::ResetAll");

		// Token: 0x02000D0C RID: 3340
		// (Invoke) Token: 0x060042B1 RID: 17073
		private delegate bool get_enabledDelegate();

		// Token: 0x02000D0D RID: 3341
		// (Invoke) Token: 0x060042B3 RID: 17075
		private delegate void set_enabledDelegate(bool value);

		// Token: 0x02000D0E RID: 3342
		// (Invoke) Token: 0x060042B5 RID: 17077
		private delegate void ResetFor_InternalDelegate(IntPtr method);

		// Token: 0x02000D0F RID: 3343
		// (Invoke) Token: 0x060042B7 RID: 17079
		private delegate void ResetAllDelegate();
	}
}
