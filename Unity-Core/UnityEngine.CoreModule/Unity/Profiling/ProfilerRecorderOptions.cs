using System;

namespace Unity.Profiling
{
	// Token: 0x0200001E RID: 30
	[Flags]
	public enum ProfilerRecorderOptions
	{
		// Token: 0x04000097 RID: 151
		None = 0,
		// Token: 0x04000098 RID: 152
		StartImmediately = 1,
		// Token: 0x04000099 RID: 153
		KeepAliveDuringDomainReload = 2,
		// Token: 0x0400009A RID: 154
		CollectOnlyOnCurrentThread = 4,
		// Token: 0x0400009B RID: 155
		WrapAroundWhenCapacityReached = 8,
		// Token: 0x0400009C RID: 156
		SumAllSamplesInFrame = 16,
		// Token: 0x0400009D RID: 157
		GpuRecorder = 64,
		// Token: 0x0400009E RID: 158
		Default = 24
	}
}
