using System;

namespace UnityEngine
{
	// Token: 0x020000CD RID: 205
	[Flags]
	public enum RenderTextureCreationFlags
	{
		// Token: 0x04000BA9 RID: 2985
		MipMap = 1,
		// Token: 0x04000BAA RID: 2986
		AutoGenerateMips = 2,
		// Token: 0x04000BAB RID: 2987
		SRGB = 4,
		// Token: 0x04000BAC RID: 2988
		EyeTexture = 8,
		// Token: 0x04000BAD RID: 2989
		EnableRandomWrite = 16,
		// Token: 0x04000BAE RID: 2990
		CreatedFromScript = 32,
		// Token: 0x04000BAF RID: 2991
		AllowVerticalFlip = 128,
		// Token: 0x04000BB0 RID: 2992
		NoResolvedColorSurface = 256,
		// Token: 0x04000BB1 RID: 2993
		DynamicallyScalable = 1024,
		// Token: 0x04000BB2 RID: 2994
		BindMS = 2048
	}
}
