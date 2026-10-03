using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000229 RID: 553
	[Flags]
	public enum PerObjectData
	{
		// Token: 0x04002027 RID: 8231
		None = 0,
		// Token: 0x04002028 RID: 8232
		LightProbe = 1,
		// Token: 0x04002029 RID: 8233
		ReflectionProbes = 2,
		// Token: 0x0400202A RID: 8234
		LightProbeProxyVolume = 4,
		// Token: 0x0400202B RID: 8235
		Lightmaps = 8,
		// Token: 0x0400202C RID: 8236
		LightData = 16,
		// Token: 0x0400202D RID: 8237
		MotionVectors = 32,
		// Token: 0x0400202E RID: 8238
		LightIndices = 64,
		// Token: 0x0400202F RID: 8239
		ReflectionProbeData = 128,
		// Token: 0x04002030 RID: 8240
		OcclusionProbe = 256,
		// Token: 0x04002031 RID: 8241
		OcclusionProbeProxyVolume = 512,
		// Token: 0x04002032 RID: 8242
		ShadowMask = 1024
	}
}
