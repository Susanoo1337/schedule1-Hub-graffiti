using System;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000369 RID: 873
	public enum RayTracingInstanceCullingFlags
	{
		// Token: 0x0400297C RID: 10620
		None,
		// Token: 0x0400297D RID: 10621
		EnableSphereCulling,
		// Token: 0x0400297E RID: 10622
		EnablePlaneCulling,
		// Token: 0x0400297F RID: 10623
		EnableLODCulling = 4,
		// Token: 0x04002980 RID: 10624
		ComputeMaterialsCRC = 8,
		// Token: 0x04002981 RID: 10625
		IgnoreReflectionProbes = 16
	}
}
