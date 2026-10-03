using System;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000362 RID: 866
	public abstract class ScriptableRuntimeReflectionSystem
	{
		// Token: 0x06002EE5 RID: 12005 RVA: 0x000AD624 File Offset: 0x000AB824
		public virtual bool TickRealtimeProbes()
		{
			return false;
		}

		// Token: 0x06002EE6 RID: 12006 RVA: 0x00014E4A File Offset: 0x0001304A
		public virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06002EE7 RID: 12007 RVA: 0x00014E4D File Offset: 0x0001304D
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
