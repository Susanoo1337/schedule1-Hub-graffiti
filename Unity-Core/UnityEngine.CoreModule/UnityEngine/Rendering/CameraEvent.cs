using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020001E5 RID: 485
	public enum CameraEvent
	{
		// Token: 0x04001B5A RID: 7002
		BeforeDepthTexture,
		// Token: 0x04001B5B RID: 7003
		AfterDepthTexture,
		// Token: 0x04001B5C RID: 7004
		BeforeDepthNormalsTexture,
		// Token: 0x04001B5D RID: 7005
		AfterDepthNormalsTexture,
		// Token: 0x04001B5E RID: 7006
		BeforeGBuffer,
		// Token: 0x04001B5F RID: 7007
		AfterGBuffer,
		// Token: 0x04001B60 RID: 7008
		BeforeLighting,
		// Token: 0x04001B61 RID: 7009
		AfterLighting,
		// Token: 0x04001B62 RID: 7010
		BeforeFinalPass,
		// Token: 0x04001B63 RID: 7011
		AfterFinalPass,
		// Token: 0x04001B64 RID: 7012
		BeforeForwardOpaque,
		// Token: 0x04001B65 RID: 7013
		AfterForwardOpaque,
		// Token: 0x04001B66 RID: 7014
		BeforeImageEffectsOpaque,
		// Token: 0x04001B67 RID: 7015
		AfterImageEffectsOpaque,
		// Token: 0x04001B68 RID: 7016
		BeforeSkybox,
		// Token: 0x04001B69 RID: 7017
		AfterSkybox,
		// Token: 0x04001B6A RID: 7018
		BeforeForwardAlpha,
		// Token: 0x04001B6B RID: 7019
		AfterForwardAlpha,
		// Token: 0x04001B6C RID: 7020
		BeforeImageEffects,
		// Token: 0x04001B6D RID: 7021
		AfterImageEffects,
		// Token: 0x04001B6E RID: 7022
		AfterEverything,
		// Token: 0x04001B6F RID: 7023
		BeforeReflections,
		// Token: 0x04001B70 RID: 7024
		AfterReflections,
		// Token: 0x04001B71 RID: 7025
		BeforeHaloAndLensFlares,
		// Token: 0x04001B72 RID: 7026
		AfterHaloAndLensFlares
	}
}
