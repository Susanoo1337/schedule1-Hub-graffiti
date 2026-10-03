using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000333 RID: 819
	public class PIX
	{
		// Token: 0x06002DCA RID: 11722 RVA: 0x000145AF File Offset: 0x000127AF
		public static void BeginGPUCapture()
		{
			PIX.BeginGPUCaptureDelegateField();
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x000145BB File Offset: 0x000127BB
		public static void EndGPUCapture()
		{
			PIX.EndGPUCaptureDelegateField();
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x000145C7 File Offset: 0x000127C7
		public static bool IsAttached()
		{
			return PIX.IsAttachedDelegateField();
		}

		// Token: 0x0400289E RID: 10398
		private static readonly PIX.BeginGPUCaptureDelegate BeginGPUCaptureDelegateField = IL2CPP.ResolveICall<PIX.BeginGPUCaptureDelegate>("UnityEngine.Rendering.PIX::BeginGPUCapture");

		// Token: 0x0400289F RID: 10399
		private static readonly PIX.EndGPUCaptureDelegate EndGPUCaptureDelegateField = IL2CPP.ResolveICall<PIX.EndGPUCaptureDelegate>("UnityEngine.Rendering.PIX::EndGPUCapture");

		// Token: 0x040028A0 RID: 10400
		private static readonly PIX.IsAttachedDelegate IsAttachedDelegateField = IL2CPP.ResolveICall<PIX.IsAttachedDelegate>("UnityEngine.Rendering.PIX::IsAttached");

		// Token: 0x02000CED RID: 3309
		// (Invoke) Token: 0x06004275 RID: 17013
		private delegate void BeginGPUCaptureDelegate();

		// Token: 0x02000CEE RID: 3310
		// (Invoke) Token: 0x06004277 RID: 17015
		private delegate void EndGPUCaptureDelegate();

		// Token: 0x02000CEF RID: 3311
		// (Invoke) Token: 0x06004279 RID: 17017
		private delegate bool IsAttachedDelegate();
	}
}
