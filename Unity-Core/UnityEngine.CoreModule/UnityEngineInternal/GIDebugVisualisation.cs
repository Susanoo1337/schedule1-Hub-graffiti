using System;
using Il2CppInterop.Runtime;

namespace UnityEngineInternal
{
	// Token: 0x02000286 RID: 646
	public static class GIDebugVisualisation
	{
		// Token: 0x06002C24 RID: 11300 RVA: 0x0001340D File Offset: 0x0001160D
		public static void ResetRuntimeInputTextures()
		{
			GIDebugVisualisation.ResetRuntimeInputTexturesDelegateField();
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x00013419 File Offset: 0x00011619
		public static void PlayCycleMode()
		{
			GIDebugVisualisation.PlayCycleModeDelegateField();
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x00013425 File Offset: 0x00011625
		public static void PauseCycleMode()
		{
			GIDebugVisualisation.PauseCycleModeDelegateField();
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x00013431 File Offset: 0x00011631
		public static void StopCycleMode()
		{
			GIDebugVisualisation.StopCycleModeDelegateField();
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x0001343D File Offset: 0x0001163D
		public static void CycleSkipSystems(int skip)
		{
			GIDebugVisualisation.CycleSkipSystemsDelegateField(skip);
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x0001344A File Offset: 0x0001164A
		public static void CycleSkipInstances(int skip)
		{
			GIDebugVisualisation.CycleSkipInstancesDelegateField(skip);
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06002C2A RID: 11306 RVA: 0x00013457 File Offset: 0x00011657
		public static bool cycleMode
		{
			get
			{
				return GIDebugVisualisation.get_cycleModeDelegateField();
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06002C2B RID: 11307 RVA: 0x00013463 File Offset: 0x00011663
		public static bool pauseCycleMode
		{
			get
			{
				return GIDebugVisualisation.get_pauseCycleModeDelegateField();
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06002C2C RID: 11308 RVA: 0x0001346F File Offset: 0x0001166F
		// (set) Token: 0x06002C2D RID: 11309 RVA: 0x0001347B File Offset: 0x0001167B
		public static GITextureType texType
		{
			get
			{
				return GIDebugVisualisation.get_texTypeDelegateField();
			}
			set
			{
				GIDebugVisualisation.set_texTypeDelegateField(value);
			}
		}

		// Token: 0x04002665 RID: 9829
		private static readonly GIDebugVisualisation.ResetRuntimeInputTexturesDelegate ResetRuntimeInputTexturesDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.ResetRuntimeInputTexturesDelegate>("UnityEngineInternal.GIDebugVisualisation::ResetRuntimeInputTextures");

		// Token: 0x04002666 RID: 9830
		private static readonly GIDebugVisualisation.PlayCycleModeDelegate PlayCycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.PlayCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::PlayCycleMode");

		// Token: 0x04002667 RID: 9831
		private static readonly GIDebugVisualisation.PauseCycleModeDelegate PauseCycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.PauseCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::PauseCycleMode");

		// Token: 0x04002668 RID: 9832
		private static readonly GIDebugVisualisation.StopCycleModeDelegate StopCycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.StopCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::StopCycleMode");

		// Token: 0x04002669 RID: 9833
		private static readonly GIDebugVisualisation.CycleSkipSystemsDelegate CycleSkipSystemsDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.CycleSkipSystemsDelegate>("UnityEngineInternal.GIDebugVisualisation::CycleSkipSystems");

		// Token: 0x0400266A RID: 9834
		private static readonly GIDebugVisualisation.CycleSkipInstancesDelegate CycleSkipInstancesDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.CycleSkipInstancesDelegate>("UnityEngineInternal.GIDebugVisualisation::CycleSkipInstances");

		// Token: 0x0400266B RID: 9835
		private static readonly GIDebugVisualisation.get_cycleModeDelegate get_cycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.get_cycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::get_cycleMode");

		// Token: 0x0400266C RID: 9836
		private static readonly GIDebugVisualisation.get_pauseCycleModeDelegate get_pauseCycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.get_pauseCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::get_pauseCycleMode");

		// Token: 0x0400266D RID: 9837
		private static readonly GIDebugVisualisation.get_texTypeDelegate get_texTypeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.get_texTypeDelegate>("UnityEngineInternal.GIDebugVisualisation::get_texType");

		// Token: 0x0400266E RID: 9838
		private static readonly GIDebugVisualisation.set_texTypeDelegate set_texTypeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.set_texTypeDelegate>("UnityEngineInternal.GIDebugVisualisation::set_texType");

		// Token: 0x02000C2C RID: 3116
		// (Invoke) Token: 0x06004119 RID: 16665
		private delegate void ResetRuntimeInputTexturesDelegate();

		// Token: 0x02000C2D RID: 3117
		// (Invoke) Token: 0x0600411B RID: 16667
		private delegate void PlayCycleModeDelegate();

		// Token: 0x02000C2E RID: 3118
		// (Invoke) Token: 0x0600411D RID: 16669
		private delegate void PauseCycleModeDelegate();

		// Token: 0x02000C2F RID: 3119
		// (Invoke) Token: 0x0600411F RID: 16671
		private delegate void StopCycleModeDelegate();

		// Token: 0x02000C30 RID: 3120
		// (Invoke) Token: 0x06004121 RID: 16673
		private delegate void CycleSkipSystemsDelegate(int skip);

		// Token: 0x02000C31 RID: 3121
		// (Invoke) Token: 0x06004123 RID: 16675
		private delegate void CycleSkipInstancesDelegate(int skip);

		// Token: 0x02000C32 RID: 3122
		// (Invoke) Token: 0x06004125 RID: 16677
		private delegate bool get_cycleModeDelegate();

		// Token: 0x02000C33 RID: 3123
		// (Invoke) Token: 0x06004127 RID: 16679
		private delegate bool get_pauseCycleModeDelegate();

		// Token: 0x02000C34 RID: 3124
		// (Invoke) Token: 0x06004129 RID: 16681
		private delegate GITextureType get_texTypeDelegate();

		// Token: 0x02000C35 RID: 3125
		// (Invoke) Token: 0x0600412B RID: 16683
		private delegate void set_texTypeDelegate(GITextureType value);
	}
}
