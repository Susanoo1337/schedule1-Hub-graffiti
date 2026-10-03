using System;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;

namespace UnityEngine.Serialization
{
	// Token: 0x02000320 RID: 800
	public class UnitySurrogateSelector
	{
		// Token: 0x06002DA5 RID: 11685 RVA: 0x000143EB File Offset: 0x000125EB
		public ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x000143F8 File Offset: 0x000125F8
		public void ChainSelector(ISurrogateSelector selector)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x00014400 File Offset: 0x00012600
		public ISurrogateSelector GetNextSelector()
		{
			throw new NotImplementedException();
		}
	}
}
