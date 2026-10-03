using System;

namespace UnityEngine.Rendering
{
	// Token: 0x0200021F RID: 543
	[Flags]
	public enum CullingOptions
	{
		// Token: 0x04001F4A RID: 8010
		None = 0,
		// Token: 0x04001F4B RID: 8011
		ForceEvenIfCameraIsNotActive = 1,
		// Token: 0x04001F4C RID: 8012
		OcclusionCull = 2,
		// Token: 0x04001F4D RID: 8013
		NeedsLighting = 4,
		// Token: 0x04001F4E RID: 8014
		NeedsReflectionProbes = 8,
		// Token: 0x04001F4F RID: 8015
		Stereo = 16,
		// Token: 0x04001F50 RID: 8016
		DisablePerObjectCulling = 32,
		// Token: 0x04001F51 RID: 8017
		ShadowCasters = 64
	}
}
