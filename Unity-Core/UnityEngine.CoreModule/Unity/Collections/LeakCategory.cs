using System;

namespace Unity.Collections
{
	// Token: 0x0200003D RID: 61
	public enum LeakCategory
	{
		// Token: 0x0400019D RID: 413
		Invalid,
		// Token: 0x0400019E RID: 414
		Malloc,
		// Token: 0x0400019F RID: 415
		TempJob,
		// Token: 0x040001A0 RID: 416
		Persistent,
		// Token: 0x040001A1 RID: 417
		LightProbesQuery,
		// Token: 0x040001A2 RID: 418
		NativeTest,
		// Token: 0x040001A3 RID: 419
		MeshDataArray,
		// Token: 0x040001A4 RID: 420
		TransformAccessArray,
		// Token: 0x040001A5 RID: 421
		NavMeshQuery
	}
}
