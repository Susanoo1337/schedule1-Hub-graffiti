using System;

namespace UnityEngine.Rendering
{
	// Token: 0x0200020D RID: 525
	[Flags]
	public enum BatchDrawCommandFlags
	{
		// Token: 0x04001E1F RID: 7711
		None = 0,
		// Token: 0x04001E20 RID: 7712
		FlipWinding = 1,
		// Token: 0x04001E21 RID: 7713
		HasMotion = 2,
		// Token: 0x04001E22 RID: 7714
		IsLightMapped = 4,
		// Token: 0x04001E23 RID: 7715
		HasSortingPosition = 8,
		// Token: 0x04001E24 RID: 7716
		LODCrossFade = 16
	}
}
