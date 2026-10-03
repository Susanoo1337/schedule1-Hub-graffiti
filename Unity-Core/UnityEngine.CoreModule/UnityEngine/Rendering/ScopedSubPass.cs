using System;

namespace UnityEngine.Rendering
{
	// Token: 0x0200034E RID: 846
	public struct ScopedSubPass
	{
		// Token: 0x06002DE5 RID: 11749 RVA: 0x000146F1 File Offset: 0x000128F1
		public void Dispose()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04002920 RID: 10528
		public ScriptableRenderContext m_Context;
	}
}
