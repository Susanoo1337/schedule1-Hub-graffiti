using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x02000361 RID: 865
	public static class TexturePlayableGraphExtensions
	{
		// Token: 0x06002EE4 RID: 12004 RVA: 0x00014E36 File Offset: 0x00013036
		public static bool InternalCreateTextureOutput(ref UnityEngine.Playables.PlayableGraph graph, string name, out UnityEngine.Playables.PlayableOutputHandle handle)
		{
			return TexturePlayableGraphExtensions.InternalCreateTextureOutputDelegateField(ref graph, IL2CPP.ManagedStringToIl2Cpp(name), out handle);
		}

		// Token: 0x04002961 RID: 10593
		private static readonly TexturePlayableGraphExtensions.InternalCreateTextureOutputDelegate InternalCreateTextureOutputDelegateField = IL2CPP.ResolveICall<TexturePlayableGraphExtensions.InternalCreateTextureOutputDelegate>("UnityEngine.Experimental.Playables.TexturePlayableGraphExtensions::InternalCreateTextureOutput");

		// Token: 0x02000D12 RID: 3346
		// (Invoke) Token: 0x060042BD RID: 17085
		private delegate bool InternalCreateTextureOutputDelegate(IntPtr graph, IntPtr name, [Out] IntPtr handle);
	}
}
