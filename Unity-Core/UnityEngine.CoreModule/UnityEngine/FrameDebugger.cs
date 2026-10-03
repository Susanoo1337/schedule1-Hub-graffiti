using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000313 RID: 787
	public static class FrameDebugger
	{
		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06002D8C RID: 11660 RVA: 0x000142BE File Offset: 0x000124BE
		public static bool enabled
		{
			get
			{
				return FrameDebugger.IsLocalEnabled() || FrameDebugger.IsRemoteEnabled();
			}
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x000142CF File Offset: 0x000124CF
		public static bool IsLocalEnabled()
		{
			return FrameDebugger.IsLocalEnabledDelegateField();
		}

		// Token: 0x06002D8E RID: 11662 RVA: 0x000142DB File Offset: 0x000124DB
		public static bool IsRemoteEnabled()
		{
			return FrameDebugger.IsRemoteEnabledDelegateField();
		}

		// Token: 0x04002832 RID: 10290
		private static readonly FrameDebugger.IsLocalEnabledDelegate IsLocalEnabledDelegateField = IL2CPP.ResolveICall<FrameDebugger.IsLocalEnabledDelegate>("UnityEngine.FrameDebugger::IsLocalEnabled");

		// Token: 0x04002833 RID: 10291
		private static readonly FrameDebugger.IsRemoteEnabledDelegate IsRemoteEnabledDelegateField = IL2CPP.ResolveICall<FrameDebugger.IsRemoteEnabledDelegate>("UnityEngine.FrameDebugger::IsRemoteEnabled");

		// Token: 0x02000CD8 RID: 3288
		// (Invoke) Token: 0x0600424D RID: 16973
		private delegate bool IsLocalEnabledDelegate();

		// Token: 0x02000CD9 RID: 3289
		// (Invoke) Token: 0x0600424F RID: 16975
		private delegate bool IsRemoteEnabledDelegate();
	}
}
