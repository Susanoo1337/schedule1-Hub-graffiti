using System;

namespace UnityEngine
{
	// Token: 0x0200016C RID: 364
	[Flags]
	public enum DrivenTransformProperties
	{
		// Token: 0x040016D1 RID: 5841
		None = 0,
		// Token: 0x040016D2 RID: 5842
		All = -1,
		// Token: 0x040016D3 RID: 5843
		AnchoredPositionX = 2,
		// Token: 0x040016D4 RID: 5844
		AnchoredPositionY = 4,
		// Token: 0x040016D5 RID: 5845
		AnchoredPositionZ = 8,
		// Token: 0x040016D6 RID: 5846
		Rotation = 16,
		// Token: 0x040016D7 RID: 5847
		ScaleX = 32,
		// Token: 0x040016D8 RID: 5848
		ScaleY = 64,
		// Token: 0x040016D9 RID: 5849
		ScaleZ = 128,
		// Token: 0x040016DA RID: 5850
		AnchorMinX = 256,
		// Token: 0x040016DB RID: 5851
		AnchorMinY = 512,
		// Token: 0x040016DC RID: 5852
		AnchorMaxX = 1024,
		// Token: 0x040016DD RID: 5853
		AnchorMaxY = 2048,
		// Token: 0x040016DE RID: 5854
		SizeDeltaX = 4096,
		// Token: 0x040016DF RID: 5855
		SizeDeltaY = 8192,
		// Token: 0x040016E0 RID: 5856
		PivotX = 16384,
		// Token: 0x040016E1 RID: 5857
		PivotY = 32768,
		// Token: 0x040016E2 RID: 5858
		AnchoredPosition = 6,
		// Token: 0x040016E3 RID: 5859
		AnchoredPosition3D = 14,
		// Token: 0x040016E4 RID: 5860
		Scale = 224,
		// Token: 0x040016E5 RID: 5861
		AnchorMin = 768,
		// Token: 0x040016E6 RID: 5862
		AnchorMax = 3072,
		// Token: 0x040016E7 RID: 5863
		Anchors = 3840,
		// Token: 0x040016E8 RID: 5864
		SizeDelta = 12288,
		// Token: 0x040016E9 RID: 5865
		Pivot = 49152
	}
}
