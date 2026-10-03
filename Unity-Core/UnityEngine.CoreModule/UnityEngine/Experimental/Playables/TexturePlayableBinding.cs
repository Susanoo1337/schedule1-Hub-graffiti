using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x02000360 RID: 864
	public static class TexturePlayableBinding
	{
		// Token: 0x06002EE1 RID: 12001 RVA: 0x000AD5D4 File Offset: 0x000AB7D4
		public static UnityEngine.Playables.PlayableBinding Create(string name, Object key)
		{
			return UnityEngine.Playables.PlayableBinding.CreateInternal(name, key, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<RenderTexture>()), new UnityEngine.Playables.PlayableBinding.CreateOutputMethod(TexturePlayableBinding.CreateTextureOutput));
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x000AD604 File Offset: 0x000AB804
		public static UnityEngine.Playables.PlayableOutput CreateTextureOutput(UnityEngine.Playables.PlayableGraph graph, string name)
		{
			return TexturePlayableOutput.Create(graph, name, null);
		}
	}
}
