using System;

namespace Unity.Profiling.LowLevel
{
	// Token: 0x02000023 RID: 35
	[Flags]
	public enum MarkerFlags : ushort
	{
		// Token: 0x040000D2 RID: 210
		Default = 0,
		// Token: 0x040000D3 RID: 211
		Script = 2,
		// Token: 0x040000D4 RID: 212
		ScriptInvoke = 32,
		// Token: 0x040000D5 RID: 213
		ScriptDeepProfiler = 64,
		// Token: 0x040000D6 RID: 214
		AvailabilityEditor = 4,
		// Token: 0x040000D7 RID: 215
		AvailabilityNonDevelopment = 8,
		// Token: 0x040000D8 RID: 216
		Warning = 16,
		// Token: 0x040000D9 RID: 217
		Counter = 128,
		// Token: 0x040000DA RID: 218
		SampleGPU = 256
	}
}
