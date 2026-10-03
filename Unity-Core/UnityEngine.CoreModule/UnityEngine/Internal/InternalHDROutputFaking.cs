using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Internal
{
	// Token: 0x02000330 RID: 816
	public static class InternalHDROutputFaking
	{
		// Token: 0x06002DC7 RID: 11719 RVA: 0x00014573 File Offset: 0x00012773
		public static void SetEnabled(bool enabled)
		{
			InternalHDROutputFaking.SetEnabledDelegateField(enabled);
		}

		// Token: 0x0400289D RID: 10397
		private static readonly InternalHDROutputFaking.SetEnabledDelegate SetEnabledDelegateField = IL2CPP.ResolveICall<InternalHDROutputFaking.SetEnabledDelegate>("UnityEngine.Internal.InternalHDROutputFaking::SetEnabled");

		// Token: 0x02000CEC RID: 3308
		// (Invoke) Token: 0x06004273 RID: 17011
		private delegate void SetEnabledDelegate(bool enabled);
	}
}
