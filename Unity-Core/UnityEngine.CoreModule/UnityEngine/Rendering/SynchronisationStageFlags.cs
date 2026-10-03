using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000202 RID: 514
	public enum SynchronisationStageFlags
	{
		// Token: 0x04001C90 RID: 7312
		VertexProcessing = 1,
		// Token: 0x04001C91 RID: 7313
		PixelProcessing,
		// Token: 0x04001C92 RID: 7314
		ComputeProcessing = 4,
		// Token: 0x04001C93 RID: 7315
		AllGPUOperations = 7
	}
}
