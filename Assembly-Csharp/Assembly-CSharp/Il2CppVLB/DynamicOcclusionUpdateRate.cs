using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppVLB
{
	// Token: 0x02000053 RID: 83
	[OriginalName("Assembly-CSharp.dll", "VLB", "DynamicOcclusionUpdateRate")]
	[Flags]
	public enum DynamicOcclusionUpdateRate
	{
		// Token: 0x0400031D RID: 797
		Never = 1,
		// Token: 0x0400031E RID: 798
		OnEnable = 2,
		// Token: 0x0400031F RID: 799
		OnBeamMove = 4,
		// Token: 0x04000320 RID: 800
		EveryXFrames = 8,
		// Token: 0x04000321 RID: 801
		OnBeamMoveAndEveryXFrames = 12
	}
}
