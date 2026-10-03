using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppVLB
{
	// Token: 0x02000055 RID: 85
	[OriginalName("Assembly-CSharp.dll", "VLB", "ShadowUpdateRate")]
	[Flags]
	public enum ShadowUpdateRate
	{
		// Token: 0x04000327 RID: 807
		Never = 1,
		// Token: 0x04000328 RID: 808
		OnEnable = 2,
		// Token: 0x04000329 RID: 809
		OnBeamMove = 4,
		// Token: 0x0400032A RID: 810
		EveryXFrames = 8,
		// Token: 0x0400032B RID: 811
		OnBeamMoveAndEveryXFrames = 12
	}
}
