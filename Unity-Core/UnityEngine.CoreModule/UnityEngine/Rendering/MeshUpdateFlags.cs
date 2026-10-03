using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020001D7 RID: 471
	[Flags]
	public enum MeshUpdateFlags
	{
		// Token: 0x04001AD4 RID: 6868
		Default = 0,
		// Token: 0x04001AD5 RID: 6869
		DontValidateIndices = 1,
		// Token: 0x04001AD6 RID: 6870
		DontResetBoneBounds = 2,
		// Token: 0x04001AD7 RID: 6871
		DontNotifyMeshUsers = 4,
		// Token: 0x04001AD8 RID: 6872
		DontRecalculateBounds = 8
	}
}
