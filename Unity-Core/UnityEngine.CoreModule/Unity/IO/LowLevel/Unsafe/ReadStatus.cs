using System;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x02000296 RID: 662
	public enum ReadStatus
	{
		// Token: 0x040026AC RID: 9900
		Complete,
		// Token: 0x040026AD RID: 9901
		InProgress,
		// Token: 0x040026AE RID: 9902
		Failed,
		// Token: 0x040026AF RID: 9903
		Truncated = 4,
		// Token: 0x040026B0 RID: 9904
		Canceled
	}
}
