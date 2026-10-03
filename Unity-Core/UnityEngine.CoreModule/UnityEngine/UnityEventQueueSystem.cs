using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000311 RID: 785
	public class UnityEventQueueSystem
	{
		// Token: 0x06002D82 RID: 11650 RVA: 0x00014279 File Offset: 0x00012479
		public static string GenerateEventIdForPayload(string eventPayloadName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x00014286 File Offset: 0x00012486
		public static IntPtr GetGlobalEventQueue()
		{
			return UnityEventQueueSystem.GetGlobalEventQueueDelegateField();
		}

		// Token: 0x04002831 RID: 10289
		private static readonly UnityEventQueueSystem.GetGlobalEventQueueDelegate GetGlobalEventQueueDelegateField = IL2CPP.ResolveICall<UnityEventQueueSystem.GetGlobalEventQueueDelegate>("UnityEngine.UnityEventQueueSystem::GetGlobalEventQueue");

		// Token: 0x02000CD7 RID: 3287
		// (Invoke) Token: 0x0600424B RID: 16971
		private delegate IntPtr GetGlobalEventQueueDelegate();
	}
}
