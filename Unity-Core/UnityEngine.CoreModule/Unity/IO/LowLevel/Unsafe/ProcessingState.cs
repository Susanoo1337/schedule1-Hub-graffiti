using System;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x0200002E RID: 46
	public enum ProcessingState
	{
		// Token: 0x04000164 RID: 356
		Unknown,
		// Token: 0x04000165 RID: 357
		InQueue,
		// Token: 0x04000166 RID: 358
		Reading,
		// Token: 0x04000167 RID: 359
		Completed,
		// Token: 0x04000168 RID: 360
		Failed,
		// Token: 0x04000169 RID: 361
		Canceled
	}
}
