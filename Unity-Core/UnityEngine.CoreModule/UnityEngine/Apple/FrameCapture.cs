using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Apple
{
	// Token: 0x02000372 RID: 882
	public class FrameCapture
	{
		// Token: 0x06002F5E RID: 12126 RVA: 0x000155A2 File Offset: 0x000137A2
		public static bool IsDestinationSupportedImpl(FrameCaptureDestination dest)
		{
			return FrameCapture.IsDestinationSupportedImplDelegateField(dest);
		}

		// Token: 0x06002F5F RID: 12127 RVA: 0x000155AF File Offset: 0x000137AF
		public static void BeginCaptureImpl(FrameCaptureDestination dest, string path)
		{
			FrameCapture.BeginCaptureImplDelegateField(dest, IL2CPP.ManagedStringToIl2Cpp(path));
		}

		// Token: 0x06002F60 RID: 12128 RVA: 0x000155C2 File Offset: 0x000137C2
		public static void EndCaptureImpl()
		{
			FrameCapture.EndCaptureImplDelegateField();
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x000155CE File Offset: 0x000137CE
		public static void CaptureNextFrameImpl(FrameCaptureDestination dest, string path)
		{
			FrameCapture.CaptureNextFrameImplDelegateField(dest, IL2CPP.ManagedStringToIl2Cpp(path));
		}

		// Token: 0x06002F62 RID: 12130 RVA: 0x000ADA84 File Offset: 0x000ABC84
		public static bool IsDestinationSupported(FrameCaptureDestination dest)
		{
			bool flag = dest != FrameCaptureDestination.DevTools && dest != FrameCaptureDestination.GPUTraceDocument;
			if (flag)
			{
				throw new ArgumentException("dest", "Argument dest has bad value (not one of FrameCaptureDestination enum values)");
			}
			return FrameCapture.IsDestinationSupportedImpl(dest);
		}

		// Token: 0x06002F63 RID: 12131 RVA: 0x000ADAC0 File Offset: 0x000ABCC0
		public static void BeginCaptureToXcode()
		{
			bool flag = !FrameCapture.IsDestinationSupported(FrameCaptureDestination.DevTools);
			if (flag)
			{
				throw new InvalidOperationException("Frame Capture with DevTools is not supported.");
			}
			FrameCapture.BeginCaptureImpl(FrameCaptureDestination.DevTools, null);
		}

		// Token: 0x06002F64 RID: 12132 RVA: 0x000155E1 File Offset: 0x000137E1
		public static void BeginCaptureToFile(string path)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002F65 RID: 12133 RVA: 0x000155EE File Offset: 0x000137EE
		public static void EndCapture()
		{
			FrameCapture.EndCaptureImpl();
		}

		// Token: 0x06002F66 RID: 12134 RVA: 0x000ADAF0 File Offset: 0x000ABCF0
		public static void CaptureNextFrameToXcode()
		{
			bool flag = !FrameCapture.IsDestinationSupported(FrameCaptureDestination.DevTools);
			if (flag)
			{
				throw new InvalidOperationException("Frame Capture with DevTools is not supported.");
			}
			FrameCapture.CaptureNextFrameImpl(FrameCaptureDestination.DevTools, null);
		}

		// Token: 0x06002F67 RID: 12135 RVA: 0x000155F7 File Offset: 0x000137F7
		public static void CaptureNextFrameToFile(string path)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040029AE RID: 10670
		private static readonly FrameCapture.IsDestinationSupportedImplDelegate IsDestinationSupportedImplDelegateField = IL2CPP.ResolveICall<FrameCapture.IsDestinationSupportedImplDelegate>("UnityEngine.Apple.FrameCapture::IsDestinationSupportedImpl");

		// Token: 0x040029AF RID: 10671
		private static readonly FrameCapture.BeginCaptureImplDelegate BeginCaptureImplDelegateField = IL2CPP.ResolveICall<FrameCapture.BeginCaptureImplDelegate>("UnityEngine.Apple.FrameCapture::BeginCaptureImpl");

		// Token: 0x040029B0 RID: 10672
		private static readonly FrameCapture.EndCaptureImplDelegate EndCaptureImplDelegateField = IL2CPP.ResolveICall<FrameCapture.EndCaptureImplDelegate>("UnityEngine.Apple.FrameCapture::EndCaptureImpl");

		// Token: 0x040029B1 RID: 10673
		private static readonly FrameCapture.CaptureNextFrameImplDelegate CaptureNextFrameImplDelegateField = IL2CPP.ResolveICall<FrameCapture.CaptureNextFrameImplDelegate>("UnityEngine.Apple.FrameCapture::CaptureNextFrameImpl");

		// Token: 0x02000D3F RID: 3391
		// (Invoke) Token: 0x06004313 RID: 17171
		private delegate bool IsDestinationSupportedImplDelegate(FrameCaptureDestination dest);

		// Token: 0x02000D40 RID: 3392
		// (Invoke) Token: 0x06004315 RID: 17173
		private delegate void BeginCaptureImplDelegate(FrameCaptureDestination dest, IntPtr path);

		// Token: 0x02000D41 RID: 3393
		// (Invoke) Token: 0x06004317 RID: 17175
		private delegate void EndCaptureImplDelegate();

		// Token: 0x02000D42 RID: 3394
		// (Invoke) Token: 0x06004319 RID: 17177
		private delegate void CaptureNextFrameImplDelegate(FrameCaptureDestination dest, IntPtr path);
	}
}
