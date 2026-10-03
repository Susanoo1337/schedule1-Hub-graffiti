using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x0200009B RID: 155
	public sealed class LightmapSettings : Object
	{
		// Token: 0x06000948 RID: 2376 RVA: 0x00034E60 File Offset: 0x00033060
		// Note: this type is marked as 'beforefieldinit'.
		static LightmapSettings()
		{
			Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightmapSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr);
			LightmapSettings.get_lightmapsDelegateField = IL2CPP.ResolveICall<LightmapSettings.get_lightmapsDelegate>("UnityEngine.LightmapSettings::get_lightmaps");
			LightmapSettings.set_lightmapsDelegateField = IL2CPP.ResolveICall<LightmapSettings.set_lightmapsDelegate>("UnityEngine.LightmapSettings::set_lightmaps");
			LightmapSettings.get_lightmapsModeDelegateField = IL2CPP.ResolveICall<LightmapSettings.get_lightmapsModeDelegate>("UnityEngine.LightmapSettings::get_lightmapsMode");
			LightmapSettings.set_lightmapsModeDelegateField = IL2CPP.ResolveICall<LightmapSettings.set_lightmapsModeDelegate>("UnityEngine.LightmapSettings::set_lightmapsMode");
			LightmapSettings.get_lightProbesDelegateField = IL2CPP.ResolveICall<LightmapSettings.get_lightProbesDelegate>("UnityEngine.LightmapSettings::get_lightProbes");
			LightmapSettings.set_lightProbesDelegateField = IL2CPP.ResolveICall<LightmapSettings.set_lightProbesDelegate>("UnityEngine.LightmapSettings::set_lightProbes");
			LightmapSettings.ResetDelegateField = IL2CPP.ResolveICall<LightmapSettings.ResetDelegate>("UnityEngine.LightmapSettings::Reset");
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00005FC9 File Offset: 0x000041C9
		public LightmapSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x00034EFC File Offset: 0x000330FC
		// (set) Token: 0x0600094B RID: 2379 RVA: 0x00005FD2 File Offset: 0x000041D2
		public static Il2CppReferenceArray<LightmapData> lightmaps
		{
			get
			{
				IntPtr intPtr = LightmapSettings.get_lightmapsDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LightmapData>>(intPtr2) : null;
			}
			set
			{
				LightmapSettings.set_lightmapsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x00005FE4 File Offset: 0x000041E4
		// (set) Token: 0x0600094D RID: 2381 RVA: 0x00005FF0 File Offset: 0x000041F0
		public static LightmapsMode lightmapsMode
		{
			get
			{
				return LightmapSettings.get_lightmapsModeDelegateField();
			}
			set
			{
				LightmapSettings.set_lightmapsModeDelegateField(value);
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x00034F24 File Offset: 0x00033124
		// (set) Token: 0x0600094F RID: 2383 RVA: 0x00005FFD File Offset: 0x000041FD
		public static LightProbes lightProbes
		{
			get
			{
				IntPtr intPtr = LightmapSettings.get_lightProbesDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightProbes>(intPtr2) : null;
			}
			set
			{
				LightmapSettings.set_lightProbesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0000600F File Offset: 0x0000420F
		public static void Reset()
		{
			LightmapSettings.ResetDelegateField();
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x00034F4C File Offset: 0x0003314C
		// (set) Token: 0x06000952 RID: 2386 RVA: 0x0000601B File Offset: 0x0000421B
		public static LightmapsModeLegacy lightmapsModeLegacy
		{
			get
			{
				return LightmapsModeLegacy.Single;
			}
			set
			{
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x00034F60 File Offset: 0x00033160
		// (set) Token: 0x06000954 RID: 2388 RVA: 0x0000601E File Offset: 0x0000421E
		public static ColorSpace bakedColorSpace
		{
			get
			{
				return QualitySettings.desiredColorSpace;
			}
			set
			{
			}
		}

		// Token: 0x04000741 RID: 1857
		private static readonly LightmapSettings.get_lightmapsDelegate get_lightmapsDelegateField;

		// Token: 0x04000742 RID: 1858
		private static readonly LightmapSettings.set_lightmapsDelegate set_lightmapsDelegateField;

		// Token: 0x04000743 RID: 1859
		private static readonly LightmapSettings.get_lightmapsModeDelegate get_lightmapsModeDelegateField;

		// Token: 0x04000744 RID: 1860
		private static readonly LightmapSettings.set_lightmapsModeDelegate set_lightmapsModeDelegateField;

		// Token: 0x04000745 RID: 1861
		private static readonly LightmapSettings.get_lightProbesDelegate get_lightProbesDelegateField;

		// Token: 0x04000746 RID: 1862
		private static readonly LightmapSettings.set_lightProbesDelegate set_lightProbesDelegateField;

		// Token: 0x04000747 RID: 1863
		private static readonly LightmapSettings.ResetDelegate ResetDelegateField;

		// Token: 0x02000562 RID: 1378
		// (Invoke) Token: 0x0600337E RID: 13182
		private delegate IntPtr get_lightmapsDelegate();

		// Token: 0x02000563 RID: 1379
		// (Invoke) Token: 0x06003380 RID: 13184
		private delegate void set_lightmapsDelegate(IntPtr value);

		// Token: 0x02000564 RID: 1380
		// (Invoke) Token: 0x06003382 RID: 13186
		private delegate LightmapsMode get_lightmapsModeDelegate();

		// Token: 0x02000565 RID: 1381
		// (Invoke) Token: 0x06003384 RID: 13188
		private delegate void set_lightmapsModeDelegate(LightmapsMode value);

		// Token: 0x02000566 RID: 1382
		// (Invoke) Token: 0x06003386 RID: 13190
		private delegate IntPtr get_lightProbesDelegate();

		// Token: 0x02000567 RID: 1383
		// (Invoke) Token: 0x06003388 RID: 13192
		private delegate void set_lightProbesDelegate(IntPtr value);

		// Token: 0x02000568 RID: 1384
		// (Invoke) Token: 0x0600338A RID: 13194
		private delegate void ResetDelegate();
	}
}
