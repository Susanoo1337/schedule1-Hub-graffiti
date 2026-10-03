using System;

namespace Unity.Profiling.Memory
{
	// Token: 0x02000294 RID: 660
	public enum CaptureFlags : uint
	{
		// Token: 0x040026A1 RID: 9889
		ManagedObjects = 1U,
		// Token: 0x040026A2 RID: 9890
		NativeObjects,
		// Token: 0x040026A3 RID: 9891
		NativeAllocations = 4U,
		// Token: 0x040026A4 RID: 9892
		NativeAllocationSites = 8U,
		// Token: 0x040026A5 RID: 9893
		NativeStackTraces = 16U
	}
}
