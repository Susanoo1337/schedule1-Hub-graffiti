using System;

namespace Unity.Collections
{
	// Token: 0x0200003C RID: 60
	public enum Allocator
	{
		// Token: 0x04000195 RID: 405
		Invalid,
		// Token: 0x04000196 RID: 406
		None,
		// Token: 0x04000197 RID: 407
		Temp,
		// Token: 0x04000198 RID: 408
		TempJob,
		// Token: 0x04000199 RID: 409
		Persistent,
		// Token: 0x0400019A RID: 410
		AudioKernel,
		// Token: 0x0400019B RID: 411
		FirstUserIndex = 64
	}
}
