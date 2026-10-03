using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x0200034A RID: 842
	public class SplashScreen
	{
		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06002DD1 RID: 11729 RVA: 0x0001460C File Offset: 0x0001280C
		public static bool isFinished
		{
			get
			{
				return SplashScreen.get_isFinishedDelegateField();
			}
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x00014618 File Offset: 0x00012818
		public static void CancelSplashScreen()
		{
			SplashScreen.CancelSplashScreenDelegateField();
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x00014624 File Offset: 0x00012824
		public static void BeginSplashScreenFade()
		{
			SplashScreen.BeginSplashScreenFadeDelegateField();
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x00014630 File Offset: 0x00012830
		public static void Begin()
		{
			SplashScreen.BeginDelegateField();
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x000AD030 File Offset: 0x000AB230
		public static void Stop(SplashScreen.StopBehavior stopBehavior)
		{
			bool flag = stopBehavior == SplashScreen.StopBehavior.FadeOut;
			if (flag)
			{
				SplashScreen.BeginSplashScreenFade();
			}
			else
			{
				SplashScreen.CancelSplashScreen();
			}
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x0001463C File Offset: 0x0001283C
		public static void Draw()
		{
			SplashScreen.DrawDelegateField();
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x00014648 File Offset: 0x00012848
		public static void SetTime(float time)
		{
			SplashScreen.SetTimeDelegateField(time);
		}

		// Token: 0x04002919 RID: 10521
		private static readonly SplashScreen.get_isFinishedDelegate get_isFinishedDelegateField = IL2CPP.ResolveICall<SplashScreen.get_isFinishedDelegate>("UnityEngine.Rendering.SplashScreen::get_isFinished");

		// Token: 0x0400291A RID: 10522
		private static readonly SplashScreen.CancelSplashScreenDelegate CancelSplashScreenDelegateField = IL2CPP.ResolveICall<SplashScreen.CancelSplashScreenDelegate>("UnityEngine.Rendering.SplashScreen::CancelSplashScreen");

		// Token: 0x0400291B RID: 10523
		private static readonly SplashScreen.BeginSplashScreenFadeDelegate BeginSplashScreenFadeDelegateField = IL2CPP.ResolveICall<SplashScreen.BeginSplashScreenFadeDelegate>("UnityEngine.Rendering.SplashScreen::BeginSplashScreenFade");

		// Token: 0x0400291C RID: 10524
		private static readonly SplashScreen.BeginDelegate BeginDelegateField = IL2CPP.ResolveICall<SplashScreen.BeginDelegate>("UnityEngine.Rendering.SplashScreen::Begin");

		// Token: 0x0400291D RID: 10525
		private static readonly SplashScreen.DrawDelegate DrawDelegateField = IL2CPP.ResolveICall<SplashScreen.DrawDelegate>("UnityEngine.Rendering.SplashScreen::Draw");

		// Token: 0x0400291E RID: 10526
		private static readonly SplashScreen.SetTimeDelegate SetTimeDelegateField = IL2CPP.ResolveICall<SplashScreen.SetTimeDelegate>("UnityEngine.Rendering.SplashScreen::SetTime");

		// Token: 0x02000CF2 RID: 3314
		public enum StopBehavior
		{
			// Token: 0x04002C88 RID: 11400
			StopImmediate,
			// Token: 0x04002C89 RID: 11401
			FadeOut
		}

		// Token: 0x02000CF3 RID: 3315
		// (Invoke) Token: 0x0600427F RID: 17023
		private delegate bool get_isFinishedDelegate();

		// Token: 0x02000CF4 RID: 3316
		// (Invoke) Token: 0x06004281 RID: 17025
		private delegate void CancelSplashScreenDelegate();

		// Token: 0x02000CF5 RID: 3317
		// (Invoke) Token: 0x06004283 RID: 17027
		private delegate void BeginSplashScreenFadeDelegate();

		// Token: 0x02000CF6 RID: 3318
		// (Invoke) Token: 0x06004285 RID: 17029
		private delegate void BeginDelegate();

		// Token: 0x02000CF7 RID: 3319
		// (Invoke) Token: 0x06004287 RID: 17031
		private delegate void DrawDelegate();

		// Token: 0x02000CF8 RID: 3320
		// (Invoke) Token: 0x06004289 RID: 17033
		private delegate void SetTimeDelegate(float time);
	}
}
