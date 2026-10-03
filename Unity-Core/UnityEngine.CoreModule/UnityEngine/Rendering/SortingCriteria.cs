using System;

namespace UnityEngine.Rendering
{
	// Token: 0x0200023B RID: 571
	[Flags]
	public enum SortingCriteria
	{
		// Token: 0x0400217E RID: 8574
		None = 0,
		// Token: 0x0400217F RID: 8575
		SortingLayer = 1,
		// Token: 0x04002180 RID: 8576
		RenderQueue = 2,
		// Token: 0x04002181 RID: 8577
		BackToFront = 4,
		// Token: 0x04002182 RID: 8578
		QuantizedFrontToBack = 8,
		// Token: 0x04002183 RID: 8579
		OptimizeStateChanges = 16,
		// Token: 0x04002184 RID: 8580
		CanvasOrder = 32,
		// Token: 0x04002185 RID: 8581
		RendererPriority = 64,
		// Token: 0x04002186 RID: 8582
		CommonOpaque = 59,
		// Token: 0x04002187 RID: 8583
		CommonTransparent = 23
	}
}
