using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x0200009C RID: 156
	public sealed class LightProbes : Object
	{
		// Token: 0x06000955 RID: 2389 RVA: 0x00034F78 File Offset: 0x00033178
		// Note: this type is marked as 'beforefieldinit'.
		static LightProbes()
		{
			Il2CppClassPointerStore<LightProbes>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightProbes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightProbes>.NativeClassPtr);
			LightProbes.NativeFieldInfoPtr_lightProbesUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, "lightProbesUpdated");
			LightProbes.NativeFieldInfoPtr_tetrahedralizationCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, "tetrahedralizationCompleted");
			LightProbes.NativeFieldInfoPtr_needsRetetrahedralization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, "needsRetetrahedralization");
			LightProbes.NativeMethodInfoPtr_Internal_CallLightProbesUpdatedFunction_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, 100664249);
			LightProbes.NativeMethodInfoPtr_Internal_CallTetrahedralizationCompletedFunction_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, 100664250);
			LightProbes.NativeMethodInfoPtr_Internal_CallNeedsRetetrahedralizationFunction_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, 100664251);
			LightProbes.NativeMethodInfoPtr_Tetrahedralize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, 100664252);
			LightProbes.NativeMethodInfoPtr_TetrahedralizeAsync_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, 100664253);
			LightProbes.AreLightProbesAllowedDelegateField = IL2CPP.ResolveICall<LightProbes.AreLightProbesAllowedDelegate>("UnityEngine.LightProbes::AreLightProbesAllowed");
			LightProbes.CalculateInterpolatedLightAndOcclusionProbes_InternalDelegateField = IL2CPP.ResolveICall<LightProbes.CalculateInterpolatedLightAndOcclusionProbes_InternalDelegate>("UnityEngine.LightProbes::CalculateInterpolatedLightAndOcclusionProbes_Internal");
			LightProbes.get_positionsDelegateField = IL2CPP.ResolveICall<LightProbes.get_positionsDelegate>("UnityEngine.LightProbes::get_positions");
			LightProbes.get_bakedProbesDelegateField = IL2CPP.ResolveICall<LightProbes.get_bakedProbesDelegate>("UnityEngine.LightProbes::get_bakedProbes");
			LightProbes.set_bakedProbesDelegateField = IL2CPP.ResolveICall<LightProbes.set_bakedProbesDelegate>("UnityEngine.LightProbes::set_bakedProbes");
			LightProbes.get_countDelegateField = IL2CPP.ResolveICall<LightProbes.get_countDelegate>("UnityEngine.LightProbes::get_count");
			LightProbes.get_cellCountDelegateField = IL2CPP.ResolveICall<LightProbes.get_cellCountDelegate>("UnityEngine.LightProbes::get_cellCount");
			LightProbes.GetCountDelegateField = IL2CPP.ResolveICall<LightProbes.GetCountDelegate>("UnityEngine.LightProbes::GetCount");
			LightProbes.GetInterpolatedProbe_InjectedDelegateField = IL2CPP.ResolveICall<LightProbes.GetInterpolatedProbe_InjectedDelegate>("UnityEngine.LightProbes::GetInterpolatedProbe_Injected");
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x000350D0 File Offset: 0x000332D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234347, XrefRangeEnd = 1234349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CallLightProbesUpdatedFunction()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightProbes.NativeMethodInfoPtr_Internal_CallLightProbesUpdatedFunction_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x000350F8 File Offset: 0x000332F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234349, XrefRangeEnd = 1234351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CallTetrahedralizationCompletedFunction()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightProbes.NativeMethodInfoPtr_Internal_CallTetrahedralizationCompletedFunction_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00035120 File Offset: 0x00033320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234351, XrefRangeEnd = 1234353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CallNeedsRetetrahedralizationFunction()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightProbes.NativeMethodInfoPtr_Internal_CallNeedsRetetrahedralizationFunction_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00035148 File Offset: 0x00033348
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1234355, RefRangeEnd = 1234356, XrefRangeStart = 1234353, XrefRangeEnd = 1234355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Tetrahedralize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightProbes.NativeMethodInfoPtr_Tetrahedralize_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00035170 File Offset: 0x00033370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234356, XrefRangeEnd = 1234358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TetrahedralizeAsync()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightProbes.NativeMethodInfoPtr_TetrahedralizeAsync_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00006021 File Offset: 0x00004221
		public LightProbes(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x00035198 File Offset: 0x00033398
		// (set) Token: 0x0600095D RID: 2397 RVA: 0x0000602A File Offset: 0x0000422A
		public unsafe static Action lightProbesUpdated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LightProbes.NativeFieldInfoPtr_lightProbesUpdated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightProbes.NativeFieldInfoPtr_lightProbesUpdated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x000351C0 File Offset: 0x000333C0
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x0000603C File Offset: 0x0000423C
		public unsafe static Action tetrahedralizationCompleted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LightProbes.NativeFieldInfoPtr_tetrahedralizationCompleted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightProbes.NativeFieldInfoPtr_tetrahedralizationCompleted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x000351E8 File Offset: 0x000333E8
		// (set) Token: 0x06000961 RID: 2401 RVA: 0x0000604E File Offset: 0x0000424E
		public unsafe static Action needsRetetrahedralization
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LightProbes.NativeFieldInfoPtr_needsRetetrahedralization, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightProbes.NativeFieldInfoPtr_needsRetetrahedralization, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00006060 File Offset: 0x00004260
		public static void add_lightProbesUpdated(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0000606D File Offset: 0x0000426D
		public static void remove_lightProbesUpdated(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0000607A File Offset: 0x0000427A
		public static void add_tetrahedralizationCompleted(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00006087 File Offset: 0x00004287
		public static void remove_tetrahedralizationCompleted(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00006094 File Offset: 0x00004294
		public static void add_needsRetetrahedralization(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x000060A1 File Offset: 0x000042A1
		public static void remove_needsRetetrahedralization(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x000060AE File Offset: 0x000042AE
		public static void GetInterpolatedProbe(Vector3 position, Renderer renderer, out UnityEngine.Rendering.SphericalHarmonicsL2 probe)
		{
			LightProbes.GetInterpolatedProbe_Injected(ref position, renderer, out probe);
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x000060B9 File Offset: 0x000042B9
		public static bool AreLightProbesAllowed(Renderer renderer)
		{
			return LightProbes.AreLightProbesAllowedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(renderer));
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00035210 File Offset: 0x00033410
		public static void CalculateInterpolatedLightAndOcclusionProbes(Il2CppStructArray<Vector3> positions, Il2CppStructArray<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes, Il2CppStructArray<Vector4> occlusionProbes)
		{
			bool flag = positions == null;
			if (flag)
			{
				throw new ArgumentNullException("positions");
			}
			bool flag2 = lightProbes == null && occlusionProbes == null;
			if (flag2)
			{
				throw new ArgumentException("Argument lightProbes and occlusionProbes cannot both be null.");
			}
			bool flag3 = lightProbes != null && lightProbes.Length < positions.Length;
			if (flag3)
			{
				throw new ArgumentException("lightProbes", "Argument lightProbes has less elements than positions");
			}
			bool flag4 = occlusionProbes != null && occlusionProbes.Length < positions.Length;
			if (flag4)
			{
				throw new ArgumentException("occlusionProbes", "Argument occlusionProbes has less elements than positions");
			}
			LightProbes.CalculateInterpolatedLightAndOcclusionProbes_Internal(positions, positions.Length, lightProbes, occlusionProbes);
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x000352B0 File Offset: 0x000334B0
		public static void CalculateInterpolatedLightAndOcclusionProbes(List<Vector3> positions, List<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes, List<Vector4> occlusionProbes)
		{
			bool flag = positions == null;
			if (flag)
			{
				throw new ArgumentNullException("positions");
			}
			bool flag2 = lightProbes == null && occlusionProbes == null;
			if (flag2)
			{
				throw new ArgumentException("Argument lightProbes and occlusionProbes cannot both be null.");
			}
			bool flag3 = lightProbes != null;
			if (flag3)
			{
				bool flag4 = lightProbes.Capacity < positions.Count;
				if (flag4)
				{
					lightProbes.Capacity = positions.Count;
				}
				bool flag5 = lightProbes.Count < positions.Count;
				if (flag5)
				{
					NoAllocHelpers.ResizeList<UnityEngine.Rendering.SphericalHarmonicsL2>(lightProbes, positions.Count);
				}
			}
			bool flag6 = occlusionProbes != null;
			if (flag6)
			{
				bool flag7 = occlusionProbes.Capacity < positions.Count;
				if (flag7)
				{
					occlusionProbes.Capacity = positions.Count;
				}
				bool flag8 = occlusionProbes.Count < positions.Count;
				if (flag8)
				{
					NoAllocHelpers.ResizeList<Vector4>(occlusionProbes, positions.Count);
				}
			}
			LightProbes.CalculateInterpolatedLightAndOcclusionProbes_Internal(NoAllocHelpers.ExtractArrayFromListT<Vector3>(positions), positions.Count, NoAllocHelpers.ExtractArrayFromListT<UnityEngine.Rendering.SphericalHarmonicsL2>(lightProbes), NoAllocHelpers.ExtractArrayFromListT<Vector4>(occlusionProbes));
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x000060CB File Offset: 0x000042CB
		public static void CalculateInterpolatedLightAndOcclusionProbes_Internal(Il2CppStructArray<Vector3> positions, int positionsCount, Il2CppStructArray<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes, Il2CppStructArray<Vector4> occlusionProbes)
		{
			LightProbes.CalculateInterpolatedLightAndOcclusionProbes_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(positions), positionsCount, IL2CPP.Il2CppObjectBaseToPtr(lightProbes), IL2CPP.Il2CppObjectBaseToPtr(occlusionProbes));
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x000353A0 File Offset: 0x000335A0
		public Il2CppStructArray<Vector3> positions
		{
			get
			{
				IntPtr intPtr = LightProbes.get_positionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x000353CC File Offset: 0x000335CC
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x000060EA File Offset: 0x000042EA
		public Il2CppStructArray<UnityEngine.Rendering.SphericalHarmonicsL2> bakedProbes
		{
			get
			{
				IntPtr intPtr = LightProbes.get_bakedProbesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<UnityEngine.Rendering.SphericalHarmonicsL2>>(intPtr2) : null;
			}
			set
			{
				LightProbes.set_bakedProbesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x00006102 File Offset: 0x00004302
		public int count
		{
			get
			{
				return LightProbes.get_countDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x00006114 File Offset: 0x00004314
		public int cellCount
		{
			get
			{
				return LightProbes.get_cellCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00006126 File Offset: 0x00004326
		public static int GetCount()
		{
			return LightProbes.GetCountDelegateField();
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00006132 File Offset: 0x00004332
		public void GetInterpolatedLightProbe(Vector3 position, Renderer renderer, Il2CppStructArray<float> coefficients)
		{
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x00006135 File Offset: 0x00004335
		// (set) Token: 0x06000975 RID: 2421 RVA: 0x00006142 File Offset: 0x00004342
		public Il2CppStructArray<float> coefficients
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
			}
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00006145 File Offset: 0x00004345
		public static void GetInterpolatedProbe_Injected(ref Vector3 position, Renderer renderer, out UnityEngine.Rendering.SphericalHarmonicsL2 probe)
		{
			LightProbes.GetInterpolatedProbe_InjectedDelegateField(ref position, IL2CPP.Il2CppObjectBaseToPtr(renderer), out probe);
		}

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeFieldInfoPtr_lightProbesUpdated;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeFieldInfoPtr_tetrahedralizationCompleted;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeFieldInfoPtr_needsRetetrahedralization;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CallLightProbesUpdatedFunction_Private_Static_Void_0;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CallTetrahedralizationCompletedFunction_Private_Static_Void_0;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CallNeedsRetetrahedralizationFunction_Private_Static_Void_0;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr_Tetrahedralize_Public_Static_Void_0;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr_TetrahedralizeAsync_Public_Static_Void_0;

		// Token: 0x04000750 RID: 1872
		private static readonly LightProbes.AreLightProbesAllowedDelegate AreLightProbesAllowedDelegateField;

		// Token: 0x04000751 RID: 1873
		private static readonly LightProbes.CalculateInterpolatedLightAndOcclusionProbes_InternalDelegate CalculateInterpolatedLightAndOcclusionProbes_InternalDelegateField;

		// Token: 0x04000752 RID: 1874
		private static readonly LightProbes.get_positionsDelegate get_positionsDelegateField;

		// Token: 0x04000753 RID: 1875
		private static readonly LightProbes.get_bakedProbesDelegate get_bakedProbesDelegateField;

		// Token: 0x04000754 RID: 1876
		private static readonly LightProbes.set_bakedProbesDelegate set_bakedProbesDelegateField;

		// Token: 0x04000755 RID: 1877
		private static readonly LightProbes.get_countDelegate get_countDelegateField;

		// Token: 0x04000756 RID: 1878
		private static readonly LightProbes.get_cellCountDelegate get_cellCountDelegateField;

		// Token: 0x04000757 RID: 1879
		private static readonly LightProbes.GetCountDelegate GetCountDelegateField;

		// Token: 0x04000758 RID: 1880
		private static readonly LightProbes.GetInterpolatedProbe_InjectedDelegate GetInterpolatedProbe_InjectedDelegateField;

		// Token: 0x02000569 RID: 1385
		// (Invoke) Token: 0x0600338C RID: 13196
		private delegate bool AreLightProbesAllowedDelegate(IntPtr renderer);

		// Token: 0x0200056A RID: 1386
		// (Invoke) Token: 0x0600338E RID: 13198
		private delegate void CalculateInterpolatedLightAndOcclusionProbes_InternalDelegate(IntPtr positions, int positionsCount, IntPtr lightProbes, IntPtr occlusionProbes);

		// Token: 0x0200056B RID: 1387
		// (Invoke) Token: 0x06003390 RID: 13200
		private delegate IntPtr get_positionsDelegate(IntPtr @this);

		// Token: 0x0200056C RID: 1388
		// (Invoke) Token: 0x06003392 RID: 13202
		private delegate IntPtr get_bakedProbesDelegate(IntPtr @this);

		// Token: 0x0200056D RID: 1389
		// (Invoke) Token: 0x06003394 RID: 13204
		private delegate void set_bakedProbesDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200056E RID: 1390
		// (Invoke) Token: 0x06003396 RID: 13206
		private delegate int get_countDelegate(IntPtr @this);

		// Token: 0x0200056F RID: 1391
		// (Invoke) Token: 0x06003398 RID: 13208
		private delegate int get_cellCountDelegate(IntPtr @this);

		// Token: 0x02000570 RID: 1392
		// (Invoke) Token: 0x0600339A RID: 13210
		private delegate int GetCountDelegate();

		// Token: 0x02000571 RID: 1393
		// (Invoke) Token: 0x0600339C RID: 13212
		private delegate void GetInterpolatedProbe_InjectedDelegate(IntPtr position, IntPtr renderer, [Out] IntPtr probe);
	}
}
