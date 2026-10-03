using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020002F7 RID: 759
	public class Handheld
	{
		// Token: 0x06002D2D RID: 11565 RVA: 0x000AC1A4 File Offset: 0x000AA3A4
		public static bool PlayFullScreenMovie(string path, Color bgColor, FullScreenMovieControlMode controlMode, FullScreenMovieScalingMode scalingMode)
		{
			return Handheld.PlayFullScreenMovie_Bindings(path, bgColor, controlMode, scalingMode);
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x000AC1C0 File Offset: 0x000AA3C0
		public static bool PlayFullScreenMovie(string path, Color bgColor, FullScreenMovieControlMode controlMode)
		{
			FullScreenMovieScalingMode scalingMode = FullScreenMovieScalingMode.AspectFit;
			return Handheld.PlayFullScreenMovie_Bindings(path, bgColor, controlMode, scalingMode);
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x000AC1E0 File Offset: 0x000AA3E0
		public static bool PlayFullScreenMovie(string path, Color bgColor)
		{
			FullScreenMovieScalingMode scalingMode = FullScreenMovieScalingMode.AspectFit;
			FullScreenMovieControlMode controlMode = FullScreenMovieControlMode.Full;
			return Handheld.PlayFullScreenMovie_Bindings(path, bgColor, controlMode, scalingMode);
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x000AC200 File Offset: 0x000AA400
		public static bool PlayFullScreenMovie(string path)
		{
			FullScreenMovieScalingMode scalingMode = FullScreenMovieScalingMode.AspectFit;
			FullScreenMovieControlMode controlMode = FullScreenMovieControlMode.Full;
			Color black = Color.black;
			return Handheld.PlayFullScreenMovie_Bindings(path, black, controlMode, scalingMode);
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x00013F64 File Offset: 0x00012164
		public static bool PlayFullScreenMovie_Bindings(string path, Color bgColor, FullScreenMovieControlMode controlMode, FullScreenMovieScalingMode scalingMode)
		{
			return Handheld.PlayFullScreenMovie_Bindings_Injected(path, ref bgColor, controlMode, scalingMode);
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x00013F70 File Offset: 0x00012170
		public static void Vibrate()
		{
			Handheld.VibrateDelegateField();
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06002D33 RID: 11571 RVA: 0x000AC228 File Offset: 0x000AA428
		// (set) Token: 0x06002D34 RID: 11572 RVA: 0x00013F7C File Offset: 0x0001217C
		public static bool use32BitDisplayBuffer
		{
			get
			{
				return Handheld.GetUse32BitDisplayBuffer_Bindings();
			}
			set
			{
			}
		}

		// Token: 0x06002D35 RID: 11573 RVA: 0x00013F7F File Offset: 0x0001217F
		public static bool GetUse32BitDisplayBuffer_Bindings()
		{
			return Handheld.GetUse32BitDisplayBuffer_BindingsDelegateField();
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x00013F8B File Offset: 0x0001218B
		public static void SetActivityIndicatorStyleImpl_Bindings(int style)
		{
			Handheld.SetActivityIndicatorStyleImpl_BindingsDelegateField(style);
		}

		// Token: 0x06002D37 RID: 11575 RVA: 0x00013F98 File Offset: 0x00012198
		public static void SetActivityIndicatorStyle(AndroidActivityIndicatorStyle style)
		{
			Handheld.SetActivityIndicatorStyleImpl_Bindings((int)style);
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x00013FA2 File Offset: 0x000121A2
		public static int GetActivityIndicatorStyle()
		{
			return Handheld.GetActivityIndicatorStyleDelegateField();
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x00013FAE File Offset: 0x000121AE
		public static void StartActivityIndicator()
		{
			Handheld.StartActivityIndicatorDelegateField();
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x00013FBA File Offset: 0x000121BA
		public static void StopActivityIndicator()
		{
			Handheld.StopActivityIndicatorDelegateField();
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x00013FC6 File Offset: 0x000121C6
		public static void ClearShaderCache()
		{
			Handheld.ClearShaderCacheDelegateField();
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x00013FD2 File Offset: 0x000121D2
		public static bool PlayFullScreenMovie_Bindings_Injected(string path, ref Color bgColor, FullScreenMovieControlMode controlMode, FullScreenMovieScalingMode scalingMode)
		{
			return Handheld.PlayFullScreenMovie_Bindings_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(path), ref bgColor, controlMode, scalingMode);
		}

		// Token: 0x040027EA RID: 10218
		private static readonly Handheld.VibrateDelegate VibrateDelegateField = IL2CPP.ResolveICall<Handheld.VibrateDelegate>("UnityEngine.Handheld::Vibrate");

		// Token: 0x040027EB RID: 10219
		private static readonly Handheld.GetUse32BitDisplayBuffer_BindingsDelegate GetUse32BitDisplayBuffer_BindingsDelegateField = IL2CPP.ResolveICall<Handheld.GetUse32BitDisplayBuffer_BindingsDelegate>("UnityEngine.Handheld::GetUse32BitDisplayBuffer_Bindings");

		// Token: 0x040027EC RID: 10220
		private static readonly Handheld.SetActivityIndicatorStyleImpl_BindingsDelegate SetActivityIndicatorStyleImpl_BindingsDelegateField = IL2CPP.ResolveICall<Handheld.SetActivityIndicatorStyleImpl_BindingsDelegate>("UnityEngine.Handheld::SetActivityIndicatorStyleImpl_Bindings");

		// Token: 0x040027ED RID: 10221
		private static readonly Handheld.GetActivityIndicatorStyleDelegate GetActivityIndicatorStyleDelegateField = IL2CPP.ResolveICall<Handheld.GetActivityIndicatorStyleDelegate>("UnityEngine.Handheld::GetActivityIndicatorStyle");

		// Token: 0x040027EE RID: 10222
		private static readonly Handheld.StartActivityIndicatorDelegate StartActivityIndicatorDelegateField = IL2CPP.ResolveICall<Handheld.StartActivityIndicatorDelegate>("UnityEngine.Handheld::StartActivityIndicator");

		// Token: 0x040027EF RID: 10223
		private static readonly Handheld.StopActivityIndicatorDelegate StopActivityIndicatorDelegateField = IL2CPP.ResolveICall<Handheld.StopActivityIndicatorDelegate>("UnityEngine.Handheld::StopActivityIndicator");

		// Token: 0x040027F0 RID: 10224
		private static readonly Handheld.ClearShaderCacheDelegate ClearShaderCacheDelegateField = IL2CPP.ResolveICall<Handheld.ClearShaderCacheDelegate>("UnityEngine.Handheld::ClearShaderCache");

		// Token: 0x040027F1 RID: 10225
		private static readonly Handheld.PlayFullScreenMovie_Bindings_InjectedDelegate PlayFullScreenMovie_Bindings_InjectedDelegateField = IL2CPP.ResolveICall<Handheld.PlayFullScreenMovie_Bindings_InjectedDelegate>("UnityEngine.Handheld::PlayFullScreenMovie_Bindings_Injected");

		// Token: 0x02000CBB RID: 3259
		// (Invoke) Token: 0x06004213 RID: 16915
		private delegate void VibrateDelegate();

		// Token: 0x02000CBC RID: 3260
		// (Invoke) Token: 0x06004215 RID: 16917
		private delegate bool GetUse32BitDisplayBuffer_BindingsDelegate();

		// Token: 0x02000CBD RID: 3261
		// (Invoke) Token: 0x06004217 RID: 16919
		private delegate void SetActivityIndicatorStyleImpl_BindingsDelegate(int style);

		// Token: 0x02000CBE RID: 3262
		// (Invoke) Token: 0x06004219 RID: 16921
		private delegate int GetActivityIndicatorStyleDelegate();

		// Token: 0x02000CBF RID: 3263
		// (Invoke) Token: 0x0600421B RID: 16923
		private delegate void StartActivityIndicatorDelegate();

		// Token: 0x02000CC0 RID: 3264
		// (Invoke) Token: 0x0600421D RID: 16925
		private delegate void StopActivityIndicatorDelegate();

		// Token: 0x02000CC1 RID: 3265
		// (Invoke) Token: 0x0600421F RID: 16927
		private delegate void ClearShaderCacheDelegate();

		// Token: 0x02000CC2 RID: 3266
		// (Invoke) Token: 0x06004221 RID: 16929
		private delegate bool PlayFullScreenMovie_Bindings_InjectedDelegate(IntPtr path, IntPtr bgColor, FullScreenMovieControlMode controlMode, FullScreenMovieScalingMode scalingMode);
	}
}
