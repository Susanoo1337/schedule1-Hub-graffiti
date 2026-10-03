using System;

namespace UnityEngine.Rendering
{
	// Token: 0x0200033E RID: 830
	public enum PassType
	{
		// Token: 0x040028DA RID: 10458
		Normal,
		// Token: 0x040028DB RID: 10459
		Vertex,
		// Token: 0x040028DC RID: 10460
		VertexLM,
		// Token: 0x040028DD RID: 10461
		VertexLMRGBM,
		// Token: 0x040028DE RID: 10462
		ForwardBase,
		// Token: 0x040028DF RID: 10463
		ForwardAdd,
		// Token: 0x040028E0 RID: 10464
		LightPrePassBase,
		// Token: 0x040028E1 RID: 10465
		LightPrePassFinal,
		// Token: 0x040028E2 RID: 10466
		ShadowCaster,
		// Token: 0x040028E3 RID: 10467
		Deferred = 10,
		// Token: 0x040028E4 RID: 10468
		Meta,
		// Token: 0x040028E5 RID: 10469
		MotionVectors,
		// Token: 0x040028E6 RID: 10470
		ScriptableRenderPipeline,
		// Token: 0x040028E7 RID: 10471
		ScriptableRenderPipelineDefaultUnlit,
		// Token: 0x040028E8 RID: 10472
		GrabPass
	}
}
