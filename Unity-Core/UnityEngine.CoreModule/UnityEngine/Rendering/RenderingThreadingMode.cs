using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000348 RID: 840
	public enum RenderingThreadingMode
	{
		// Token: 0x04002910 RID: 10512
		Direct,
		// Token: 0x04002911 RID: 10513
		SingleThreaded,
		// Token: 0x04002912 RID: 10514
		MultiThreaded,
		// Token: 0x04002913 RID: 10515
		LegacyJobified,
		// Token: 0x04002914 RID: 10516
		NativeGraphicsJobs,
		// Token: 0x04002915 RID: 10517
		NativeGraphicsJobsWithoutRenderThread
	}
}
