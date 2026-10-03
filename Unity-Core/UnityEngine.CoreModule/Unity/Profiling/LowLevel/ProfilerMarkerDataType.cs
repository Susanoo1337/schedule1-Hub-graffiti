using System;

namespace Unity.Profiling.LowLevel
{
	// Token: 0x02000024 RID: 36
	public enum ProfilerMarkerDataType : byte
	{
		// Token: 0x040000DC RID: 220
		InstanceId = 1,
		// Token: 0x040000DD RID: 221
		Int32,
		// Token: 0x040000DE RID: 222
		UInt32,
		// Token: 0x040000DF RID: 223
		Int64,
		// Token: 0x040000E0 RID: 224
		UInt64,
		// Token: 0x040000E1 RID: 225
		Float,
		// Token: 0x040000E2 RID: 226
		Double,
		// Token: 0x040000E3 RID: 227
		String16 = 9,
		// Token: 0x040000E4 RID: 228
		Blob8 = 11,
		// Token: 0x040000E5 RID: 229
		GfxResourceId
	}
}
