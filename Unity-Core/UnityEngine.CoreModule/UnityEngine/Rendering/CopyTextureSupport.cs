using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020001F8 RID: 504
	[Flags]
	public enum CopyTextureSupport
	{
		// Token: 0x04001C5C RID: 7260
		None = 0,
		// Token: 0x04001C5D RID: 7261
		Basic = 1,
		// Token: 0x04001C5E RID: 7262
		Copy3D = 2,
		// Token: 0x04001C5F RID: 7263
		DifferentTypes = 4,
		// Token: 0x04001C60 RID: 7264
		TextureToRT = 8,
		// Token: 0x04001C61 RID: 7265
		RTToTexture = 16
	}
}
