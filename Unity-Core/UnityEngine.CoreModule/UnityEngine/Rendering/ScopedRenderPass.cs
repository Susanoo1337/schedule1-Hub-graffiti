using System;

namespace UnityEngine.Rendering
{
	// Token: 0x0200034D RID: 845
	public struct ScopedRenderPass
	{
		// Token: 0x06002DE4 RID: 11748 RVA: 0x000146E4 File Offset: 0x000128E4
		public void Dispose()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400291F RID: 10527
		public ScriptableRenderContext m_Context;
	}
}
