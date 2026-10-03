using System;

namespace Unity.Profiling
{
	// Token: 0x0200001D RID: 29
	[Flags]
	public enum ProfilerCounterOptions : ushort
	{
		// Token: 0x04000093 RID: 147
		None = 0,
		// Token: 0x04000094 RID: 148
		FlushOnEndOfFrame = 2,
		// Token: 0x04000095 RID: 149
		ResetToZeroOnFlush = 4
	}
}
