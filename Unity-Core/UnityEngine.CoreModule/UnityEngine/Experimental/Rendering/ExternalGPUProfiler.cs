using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000363 RID: 867
	public static class ExternalGPUProfiler
	{
		// Token: 0x06002EE9 RID: 12009 RVA: 0x00014E8E File Offset: 0x0001308E
		public static void BeginGPUCapture()
		{
			ExternalGPUProfiler.BeginGPUCaptureDelegateField();
		}

		// Token: 0x06002EEA RID: 12010 RVA: 0x00014E9A File Offset: 0x0001309A
		public static void EndGPUCapture()
		{
			ExternalGPUProfiler.EndGPUCaptureDelegateField();
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x00014EA6 File Offset: 0x000130A6
		public static bool IsAttached()
		{
			return ExternalGPUProfiler.IsAttachedDelegateField();
		}

		// Token: 0x04002962 RID: 10594
		private static readonly ExternalGPUProfiler.BeginGPUCaptureDelegate BeginGPUCaptureDelegateField = IL2CPP.ResolveICall<ExternalGPUProfiler.BeginGPUCaptureDelegate>("UnityEngine.Experimental.Rendering.ExternalGPUProfiler::BeginGPUCapture");

		// Token: 0x04002963 RID: 10595
		private static readonly ExternalGPUProfiler.EndGPUCaptureDelegate EndGPUCaptureDelegateField = IL2CPP.ResolveICall<ExternalGPUProfiler.EndGPUCaptureDelegate>("UnityEngine.Experimental.Rendering.ExternalGPUProfiler::EndGPUCapture");

		// Token: 0x04002964 RID: 10596
		private static readonly ExternalGPUProfiler.IsAttachedDelegate IsAttachedDelegateField = IL2CPP.ResolveICall<ExternalGPUProfiler.IsAttachedDelegate>("UnityEngine.Experimental.Rendering.ExternalGPUProfiler::IsAttached");

		// Token: 0x02000D13 RID: 3347
		// (Invoke) Token: 0x060042BF RID: 17087
		private delegate void BeginGPUCaptureDelegate();

		// Token: 0x02000D14 RID: 3348
		// (Invoke) Token: 0x060042C1 RID: 17089
		private delegate void EndGPUCaptureDelegate();

		// Token: 0x02000D15 RID: 3349
		// (Invoke) Token: 0x060042C3 RID: 17091
		private delegate bool IsAttachedDelegate();
	}
}
