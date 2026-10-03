using System;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200027B RID: 635
	[Flags]
	public enum TextureCreationFlags
	{
		// Token: 0x0400253F RID: 9535
		None = 0,
		// Token: 0x04002540 RID: 9536
		MipChain = 1,
		// Token: 0x04002541 RID: 9537
		DontInitializePixels = 4,
		// Token: 0x04002542 RID: 9538
		Crunch = 64,
		// Token: 0x04002543 RID: 9539
		DontUploadUponCreate = 1024,
		// Token: 0x04002544 RID: 9540
		IgnoreMipmapLimit = 2048
	}
}
