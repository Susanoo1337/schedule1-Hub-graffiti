using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000235 RID: 565
	[Flags]
	public enum RenderStateMask
	{
		// Token: 0x040020E3 RID: 8419
		Nothing = 0,
		// Token: 0x040020E4 RID: 8420
		Blend = 1,
		// Token: 0x040020E5 RID: 8421
		Raster = 2,
		// Token: 0x040020E6 RID: 8422
		Depth = 4,
		// Token: 0x040020E7 RID: 8423
		Stencil = 8,
		// Token: 0x040020E8 RID: 8424
		Everything = 15
	}
}
