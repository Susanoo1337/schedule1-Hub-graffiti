using System;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200027C RID: 636
	public enum FormatUsage
	{
		// Token: 0x04002546 RID: 9542
		Sample,
		// Token: 0x04002547 RID: 9543
		Linear,
		// Token: 0x04002548 RID: 9544
		Sparse,
		// Token: 0x04002549 RID: 9545
		Render = 4,
		// Token: 0x0400254A RID: 9546
		Blend,
		// Token: 0x0400254B RID: 9547
		GetPixels,
		// Token: 0x0400254C RID: 9548
		SetPixels,
		// Token: 0x0400254D RID: 9549
		SetPixels32,
		// Token: 0x0400254E RID: 9550
		ReadPixels,
		// Token: 0x0400254F RID: 9551
		LoadStore,
		// Token: 0x04002550 RID: 9552
		MSAA2x,
		// Token: 0x04002551 RID: 9553
		MSAA4x,
		// Token: 0x04002552 RID: 9554
		MSAA8x,
		// Token: 0x04002553 RID: 9555
		StencilSampling = 16
	}
}
