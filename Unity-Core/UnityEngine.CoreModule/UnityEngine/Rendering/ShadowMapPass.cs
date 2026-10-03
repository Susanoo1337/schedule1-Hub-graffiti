using System;

namespace UnityEngine.Rendering
{
	// Token: 0x0200033D RID: 829
	public enum ShadowMapPass
	{
		// Token: 0x040028CB RID: 10443
		PointlightPositiveX = 1,
		// Token: 0x040028CC RID: 10444
		PointlightNegativeX,
		// Token: 0x040028CD RID: 10445
		PointlightPositiveY = 4,
		// Token: 0x040028CE RID: 10446
		PointlightNegativeY = 8,
		// Token: 0x040028CF RID: 10447
		PointlightPositiveZ = 16,
		// Token: 0x040028D0 RID: 10448
		PointlightNegativeZ = 32,
		// Token: 0x040028D1 RID: 10449
		DirectionalCascade0 = 64,
		// Token: 0x040028D2 RID: 10450
		DirectionalCascade1 = 128,
		// Token: 0x040028D3 RID: 10451
		DirectionalCascade2 = 256,
		// Token: 0x040028D4 RID: 10452
		DirectionalCascade3 = 512,
		// Token: 0x040028D5 RID: 10453
		Spotlight = 1024,
		// Token: 0x040028D6 RID: 10454
		Pointlight = 63,
		// Token: 0x040028D7 RID: 10455
		Directional = 960,
		// Token: 0x040028D8 RID: 10456
		All = 2047
	}
}
