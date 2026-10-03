using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000089 RID: 137
	public sealed class LightingSettings : Object
	{
		// Token: 0x06000729 RID: 1833 RVA: 0x0002E638 File Offset: 0x0002C838
		// Note: this type is marked as 'beforefieldinit'.
		static LightingSettings()
		{
			Il2CppClassPointerStore<LightingSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightingSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr);
			LightingSettings.NativeMethodInfoPtr_LightingSettingsDontStripMe_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100664093);
			LightingSettings.Internal_CreateDelegateField = IL2CPP.ResolveICall<LightingSettings.Internal_CreateDelegate>("UnityEngine.LightingSettings::Internal_Create");
			LightingSettings.get_bakedGIDelegateField = IL2CPP.ResolveICall<LightingSettings.get_bakedGIDelegate>("UnityEngine.LightingSettings::get_bakedGI");
			LightingSettings.set_bakedGIDelegateField = IL2CPP.ResolveICall<LightingSettings.set_bakedGIDelegate>("UnityEngine.LightingSettings::set_bakedGI");
			LightingSettings.get_realtimeGIDelegateField = IL2CPP.ResolveICall<LightingSettings.get_realtimeGIDelegate>("UnityEngine.LightingSettings::get_realtimeGI");
			LightingSettings.set_realtimeGIDelegateField = IL2CPP.ResolveICall<LightingSettings.set_realtimeGIDelegate>("UnityEngine.LightingSettings::set_realtimeGI");
			LightingSettings.get_realtimeEnvironmentLightingDelegateField = IL2CPP.ResolveICall<LightingSettings.get_realtimeEnvironmentLightingDelegate>("UnityEngine.LightingSettings::get_realtimeEnvironmentLighting");
			LightingSettings.set_realtimeEnvironmentLightingDelegateField = IL2CPP.ResolveICall<LightingSettings.set_realtimeEnvironmentLightingDelegate>("UnityEngine.LightingSettings::set_realtimeEnvironmentLighting");
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0002E6E8 File Offset: 0x0002C8E8
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LightingSettingsDontStripMe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_LightingSettingsDontStripMe_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x000051FB File Offset: 0x000033FB
		public LightingSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00005204 File Offset: 0x00003404
		public static void Internal_Create(LightingSettings self)
		{
			LightingSettings.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x00005216 File Offset: 0x00003416
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x00005228 File Offset: 0x00003428
		public bool bakedGI
		{
			get
			{
				return LightingSettings.get_bakedGIDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightingSettings.set_bakedGIDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x0000523B File Offset: 0x0000343B
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x0000524D File Offset: 0x0000344D
		public bool realtimeGI
		{
			get
			{
				return LightingSettings.get_realtimeGIDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightingSettings.set_realtimeGIDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x00005260 File Offset: 0x00003460
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x00005272 File Offset: 0x00003472
		public bool realtimeEnvironmentLighting
		{
			get
			{
				return LightingSettings.get_realtimeEnvironmentLightingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightingSettings.set_realtimeEnvironmentLightingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_LightingSettingsDontStripMe_Internal_Void_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly LightingSettings.Internal_CreateDelegate Internal_CreateDelegateField;

		// Token: 0x040005F2 RID: 1522
		private static readonly LightingSettings.get_bakedGIDelegate get_bakedGIDelegateField;

		// Token: 0x040005F3 RID: 1523
		private static readonly LightingSettings.set_bakedGIDelegate set_bakedGIDelegateField;

		// Token: 0x040005F4 RID: 1524
		private static readonly LightingSettings.get_realtimeGIDelegate get_realtimeGIDelegateField;

		// Token: 0x040005F5 RID: 1525
		private static readonly LightingSettings.set_realtimeGIDelegate set_realtimeGIDelegateField;

		// Token: 0x040005F6 RID: 1526
		private static readonly LightingSettings.get_realtimeEnvironmentLightingDelegate get_realtimeEnvironmentLightingDelegateField;

		// Token: 0x040005F7 RID: 1527
		private static readonly LightingSettings.set_realtimeEnvironmentLightingDelegate set_realtimeEnvironmentLightingDelegateField;

		// Token: 0x020004E5 RID: 1253
		// (Invoke) Token: 0x0600327A RID: 12922
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x020004E6 RID: 1254
		// (Invoke) Token: 0x0600327C RID: 12924
		private delegate bool get_bakedGIDelegate(IntPtr @this);

		// Token: 0x020004E7 RID: 1255
		// (Invoke) Token: 0x0600327E RID: 12926
		private delegate void set_bakedGIDelegate(IntPtr @this, bool value);

		// Token: 0x020004E8 RID: 1256
		// (Invoke) Token: 0x06003280 RID: 12928
		private delegate bool get_realtimeGIDelegate(IntPtr @this);

		// Token: 0x020004E9 RID: 1257
		// (Invoke) Token: 0x06003282 RID: 12930
		private delegate void set_realtimeGIDelegate(IntPtr @this, bool value);

		// Token: 0x020004EA RID: 1258
		// (Invoke) Token: 0x06003284 RID: 12932
		private delegate bool get_realtimeEnvironmentLightingDelegate(IntPtr @this);

		// Token: 0x020004EB RID: 1259
		// (Invoke) Token: 0x06003286 RID: 12934
		private delegate void set_realtimeEnvironmentLightingDelegate(IntPtr @this, bool value);
	}
}
