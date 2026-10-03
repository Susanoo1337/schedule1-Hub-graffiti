using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000248 RID: 584
	[Flags]
	public enum ShaderPropertyFlags
	{
		// Token: 0x04002293 RID: 8851
		None = 0,
		// Token: 0x04002294 RID: 8852
		HideInInspector = 1,
		// Token: 0x04002295 RID: 8853
		PerRendererData = 2,
		// Token: 0x04002296 RID: 8854
		NoScaleOffset = 4,
		// Token: 0x04002297 RID: 8855
		Normal = 8,
		// Token: 0x04002298 RID: 8856
		HDR = 16,
		// Token: 0x04002299 RID: 8857
		Gamma = 32,
		// Token: 0x0400229A RID: 8858
		NonModifiableTextureData = 64,
		// Token: 0x0400229B RID: 8859
		MainTexture = 128,
		// Token: 0x0400229C RID: 8860
		MainColor = 256
	}
}
