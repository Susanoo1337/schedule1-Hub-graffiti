using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020001F0 RID: 496
	[Flags]
	public enum RenderTargetFlags
	{
		// Token: 0x04001C13 RID: 7187
		None = 0,
		// Token: 0x04001C14 RID: 7188
		ReadOnlyDepth = 1,
		// Token: 0x04001C15 RID: 7189
		ReadOnlyStencil = 2,
		// Token: 0x04001C16 RID: 7190
		ReadOnlyDepthStencil = 3
	}
}
