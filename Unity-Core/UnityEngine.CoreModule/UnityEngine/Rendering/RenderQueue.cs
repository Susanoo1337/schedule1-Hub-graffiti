using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000339 RID: 825
	public enum RenderQueue
	{
		// Token: 0x040028B6 RID: 10422
		Background = 1000,
		// Token: 0x040028B7 RID: 10423
		Geometry = 2000,
		// Token: 0x040028B8 RID: 10424
		AlphaTest = 2450,
		// Token: 0x040028B9 RID: 10425
		GeometryLast = 2500,
		// Token: 0x040028BA RID: 10426
		Transparent = 3000,
		// Token: 0x040028BB RID: 10427
		Overlay = 4000
	}
}
