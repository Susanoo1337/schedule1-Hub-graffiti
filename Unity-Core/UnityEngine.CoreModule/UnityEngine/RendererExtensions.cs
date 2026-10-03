using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020002CB RID: 715
	public static class RendererExtensions
	{
		// Token: 0x06002CFA RID: 11514 RVA: 0x00013C33 File Offset: 0x00011E33
		public static void UpdateGIMaterials(Renderer renderer)
		{
			RendererExtensions.UpdateGIMaterialsForRenderer(renderer);
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x00013C3D File Offset: 0x00011E3D
		public static void UpdateGIMaterialsForRenderer(Renderer renderer)
		{
			RendererExtensions.UpdateGIMaterialsForRendererDelegateField(IL2CPP.Il2CppObjectBaseToPtr(renderer));
		}

		// Token: 0x0400273A RID: 10042
		private static readonly RendererExtensions.UpdateGIMaterialsForRendererDelegate UpdateGIMaterialsForRendererDelegateField = IL2CPP.ResolveICall<RendererExtensions.UpdateGIMaterialsForRendererDelegate>("UnityEngine.RendererExtensions::UpdateGIMaterialsForRenderer");

		// Token: 0x02000C9A RID: 3226
		// (Invoke) Token: 0x060041D1 RID: 16849
		private delegate void UpdateGIMaterialsForRendererDelegate(IntPtr renderer);
	}
}
