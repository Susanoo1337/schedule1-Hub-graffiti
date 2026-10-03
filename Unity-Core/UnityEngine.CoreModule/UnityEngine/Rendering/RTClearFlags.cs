using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020001FE RID: 510
	[Flags]
	public enum RTClearFlags
	{
		// Token: 0x04001C76 RID: 7286
		None = 0,
		// Token: 0x04001C77 RID: 7287
		Color = 1,
		// Token: 0x04001C78 RID: 7288
		Depth = 2,
		// Token: 0x04001C79 RID: 7289
		Stencil = 4,
		// Token: 0x04001C7A RID: 7290
		All = 7,
		// Token: 0x04001C7B RID: 7291
		DepthStencil = 6,
		// Token: 0x04001C7C RID: 7292
		ColorDepth = 3,
		// Token: 0x04001C7D RID: 7293
		ColorStencil = 5
	}
}
