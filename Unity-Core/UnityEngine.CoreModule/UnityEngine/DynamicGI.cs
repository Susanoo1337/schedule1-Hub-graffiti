using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine
{
	// Token: 0x020002C4 RID: 708
	public sealed class DynamicGI
	{
		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06002CDC RID: 11484 RVA: 0x00013AC7 File Offset: 0x00011CC7
		// (set) Token: 0x06002CDD RID: 11485 RVA: 0x00013AD3 File Offset: 0x00011CD3
		public static float indirectScale
		{
			get
			{
				return DynamicGI.get_indirectScaleDelegateField();
			}
			set
			{
				DynamicGI.set_indirectScaleDelegateField(value);
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06002CDE RID: 11486 RVA: 0x00013AE0 File Offset: 0x00011CE0
		// (set) Token: 0x06002CDF RID: 11487 RVA: 0x00013AEC File Offset: 0x00011CEC
		public static float updateThreshold
		{
			get
			{
				return DynamicGI.get_updateThresholdDelegateField();
			}
			set
			{
				DynamicGI.set_updateThresholdDelegateField(value);
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06002CE0 RID: 11488 RVA: 0x00013AF9 File Offset: 0x00011CF9
		// (set) Token: 0x06002CE1 RID: 11489 RVA: 0x00013B05 File Offset: 0x00011D05
		public static int materialUpdateTimeSlice
		{
			get
			{
				return DynamicGI.get_materialUpdateTimeSliceDelegateField();
			}
			set
			{
				DynamicGI.set_materialUpdateTimeSliceDelegateField(value);
			}
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x00013B12 File Offset: 0x00011D12
		public static void SetEmissive(Renderer renderer, Color color)
		{
			DynamicGI.SetEmissive_Injected(renderer, ref color);
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x00013B1C File Offset: 0x00011D1C
		public static void SetEnvironmentData(Il2CppStructArray<float> input)
		{
			DynamicGI.SetEnvironmentDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(input));
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06002CE4 RID: 11492 RVA: 0x00013B2E File Offset: 0x00011D2E
		// (set) Token: 0x06002CE5 RID: 11493 RVA: 0x00013B3A File Offset: 0x00011D3A
		public static bool synchronousMode
		{
			get
			{
				return DynamicGI.get_synchronousModeDelegateField();
			}
			set
			{
				DynamicGI.set_synchronousModeDelegateField(value);
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06002CE6 RID: 11494 RVA: 0x00013B47 File Offset: 0x00011D47
		public static bool isConverged
		{
			get
			{
				return DynamicGI.get_isConvergedDelegateField();
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06002CE7 RID: 11495 RVA: 0x00013B53 File Offset: 0x00011D53
		public static int scheduledMaterialUpdatesCount
		{
			get
			{
				return DynamicGI.get_scheduledMaterialUpdatesCountDelegateField();
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06002CE8 RID: 11496 RVA: 0x00013B5F File Offset: 0x00011D5F
		// (set) Token: 0x06002CE9 RID: 11497 RVA: 0x00013B6B File Offset: 0x00011D6B
		public static bool asyncMaterialUpdates
		{
			get
			{
				return DynamicGI.get_asyncMaterialUpdatesDelegateField();
			}
			set
			{
				DynamicGI.set_asyncMaterialUpdatesDelegateField(value);
			}
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x00013B78 File Offset: 0x00011D78
		public static void UpdateEnvironment()
		{
			DynamicGI.UpdateEnvironmentDelegateField();
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x00013B84 File Offset: 0x00011D84
		public static void UpdateMaterials(Renderer renderer)
		{
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x00013B87 File Offset: 0x00011D87
		public static void UpdateMaterials(Object renderer)
		{
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x00013B8A File Offset: 0x00011D8A
		public static void UpdateMaterials(Object renderer, int x, int y, int width, int height)
		{
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x00013B8D File Offset: 0x00011D8D
		public static void SetEmissive_Injected(Renderer renderer, ref Color color)
		{
			DynamicGI.SetEmissive_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(renderer), ref color);
		}

		// Token: 0x04002721 RID: 10017
		private static readonly DynamicGI.get_indirectScaleDelegate get_indirectScaleDelegateField = IL2CPP.ResolveICall<DynamicGI.get_indirectScaleDelegate>("UnityEngine.DynamicGI::get_indirectScale");

		// Token: 0x04002722 RID: 10018
		private static readonly DynamicGI.set_indirectScaleDelegate set_indirectScaleDelegateField = IL2CPP.ResolveICall<DynamicGI.set_indirectScaleDelegate>("UnityEngine.DynamicGI::set_indirectScale");

		// Token: 0x04002723 RID: 10019
		private static readonly DynamicGI.get_updateThresholdDelegate get_updateThresholdDelegateField = IL2CPP.ResolveICall<DynamicGI.get_updateThresholdDelegate>("UnityEngine.DynamicGI::get_updateThreshold");

		// Token: 0x04002724 RID: 10020
		private static readonly DynamicGI.set_updateThresholdDelegate set_updateThresholdDelegateField = IL2CPP.ResolveICall<DynamicGI.set_updateThresholdDelegate>("UnityEngine.DynamicGI::set_updateThreshold");

		// Token: 0x04002725 RID: 10021
		private static readonly DynamicGI.get_materialUpdateTimeSliceDelegate get_materialUpdateTimeSliceDelegateField = IL2CPP.ResolveICall<DynamicGI.get_materialUpdateTimeSliceDelegate>("UnityEngine.DynamicGI::get_materialUpdateTimeSlice");

		// Token: 0x04002726 RID: 10022
		private static readonly DynamicGI.set_materialUpdateTimeSliceDelegate set_materialUpdateTimeSliceDelegateField = IL2CPP.ResolveICall<DynamicGI.set_materialUpdateTimeSliceDelegate>("UnityEngine.DynamicGI::set_materialUpdateTimeSlice");

		// Token: 0x04002727 RID: 10023
		private static readonly DynamicGI.SetEnvironmentDataDelegate SetEnvironmentDataDelegateField = IL2CPP.ResolveICall<DynamicGI.SetEnvironmentDataDelegate>("UnityEngine.DynamicGI::SetEnvironmentData");

		// Token: 0x04002728 RID: 10024
		private static readonly DynamicGI.get_synchronousModeDelegate get_synchronousModeDelegateField = IL2CPP.ResolveICall<DynamicGI.get_synchronousModeDelegate>("UnityEngine.DynamicGI::get_synchronousMode");

		// Token: 0x04002729 RID: 10025
		private static readonly DynamicGI.set_synchronousModeDelegate set_synchronousModeDelegateField = IL2CPP.ResolveICall<DynamicGI.set_synchronousModeDelegate>("UnityEngine.DynamicGI::set_synchronousMode");

		// Token: 0x0400272A RID: 10026
		private static readonly DynamicGI.get_isConvergedDelegate get_isConvergedDelegateField = IL2CPP.ResolveICall<DynamicGI.get_isConvergedDelegate>("UnityEngine.DynamicGI::get_isConverged");

		// Token: 0x0400272B RID: 10027
		private static readonly DynamicGI.get_scheduledMaterialUpdatesCountDelegate get_scheduledMaterialUpdatesCountDelegateField = IL2CPP.ResolveICall<DynamicGI.get_scheduledMaterialUpdatesCountDelegate>("UnityEngine.DynamicGI::get_scheduledMaterialUpdatesCount");

		// Token: 0x0400272C RID: 10028
		private static readonly DynamicGI.get_asyncMaterialUpdatesDelegate get_asyncMaterialUpdatesDelegateField = IL2CPP.ResolveICall<DynamicGI.get_asyncMaterialUpdatesDelegate>("UnityEngine.DynamicGI::get_asyncMaterialUpdates");

		// Token: 0x0400272D RID: 10029
		private static readonly DynamicGI.set_asyncMaterialUpdatesDelegate set_asyncMaterialUpdatesDelegateField = IL2CPP.ResolveICall<DynamicGI.set_asyncMaterialUpdatesDelegate>("UnityEngine.DynamicGI::set_asyncMaterialUpdates");

		// Token: 0x0400272E RID: 10030
		private static readonly DynamicGI.UpdateEnvironmentDelegate UpdateEnvironmentDelegateField = IL2CPP.ResolveICall<DynamicGI.UpdateEnvironmentDelegate>("UnityEngine.DynamicGI::UpdateEnvironment");

		// Token: 0x0400272F RID: 10031
		private static readonly DynamicGI.SetEmissive_InjectedDelegate SetEmissive_InjectedDelegateField = IL2CPP.ResolveICall<DynamicGI.SetEmissive_InjectedDelegate>("UnityEngine.DynamicGI::SetEmissive_Injected");

		// Token: 0x02000C8B RID: 3211
		// (Invoke) Token: 0x060041B3 RID: 16819
		private delegate float get_indirectScaleDelegate();

		// Token: 0x02000C8C RID: 3212
		// (Invoke) Token: 0x060041B5 RID: 16821
		private delegate void set_indirectScaleDelegate(float value);

		// Token: 0x02000C8D RID: 3213
		// (Invoke) Token: 0x060041B7 RID: 16823
		private delegate float get_updateThresholdDelegate();

		// Token: 0x02000C8E RID: 3214
		// (Invoke) Token: 0x060041B9 RID: 16825
		private delegate void set_updateThresholdDelegate(float value);

		// Token: 0x02000C8F RID: 3215
		// (Invoke) Token: 0x060041BB RID: 16827
		private delegate int get_materialUpdateTimeSliceDelegate();

		// Token: 0x02000C90 RID: 3216
		// (Invoke) Token: 0x060041BD RID: 16829
		private delegate void set_materialUpdateTimeSliceDelegate(int value);

		// Token: 0x02000C91 RID: 3217
		// (Invoke) Token: 0x060041BF RID: 16831
		private delegate void SetEnvironmentDataDelegate(IntPtr input);

		// Token: 0x02000C92 RID: 3218
		// (Invoke) Token: 0x060041C1 RID: 16833
		private delegate bool get_synchronousModeDelegate();

		// Token: 0x02000C93 RID: 3219
		// (Invoke) Token: 0x060041C3 RID: 16835
		private delegate void set_synchronousModeDelegate(bool value);

		// Token: 0x02000C94 RID: 3220
		// (Invoke) Token: 0x060041C5 RID: 16837
		private delegate bool get_isConvergedDelegate();

		// Token: 0x02000C95 RID: 3221
		// (Invoke) Token: 0x060041C7 RID: 16839
		private delegate int get_scheduledMaterialUpdatesCountDelegate();

		// Token: 0x02000C96 RID: 3222
		// (Invoke) Token: 0x060041C9 RID: 16841
		private delegate bool get_asyncMaterialUpdatesDelegate();

		// Token: 0x02000C97 RID: 3223
		// (Invoke) Token: 0x060041CB RID: 16843
		private delegate void set_asyncMaterialUpdatesDelegate(bool value);

		// Token: 0x02000C98 RID: 3224
		// (Invoke) Token: 0x060041CD RID: 16845
		private delegate void UpdateEnvironmentDelegate();

		// Token: 0x02000C99 RID: 3225
		// (Invoke) Token: 0x060041CF RID: 16847
		private delegate void SetEmissive_InjectedDelegate(IntPtr renderer, IntPtr color);
	}
}
