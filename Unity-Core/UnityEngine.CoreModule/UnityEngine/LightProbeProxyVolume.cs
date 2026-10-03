using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020000D2 RID: 210
	public sealed class LightProbeProxyVolume : Behaviour
	{
		// Token: 0x06000E91 RID: 3729 RVA: 0x00041F0C File Offset: 0x0004010C
		// Note: this type is marked as 'beforefieldinit'.
		static LightProbeProxyVolume()
		{
			Il2CppClassPointerStore<LightProbeProxyVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightProbeProxyVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightProbeProxyVolume>.NativeClassPtr);
			LightProbeProxyVolume.get_isFeatureSupportedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_isFeatureSupportedDelegate>("UnityEngine.LightProbeProxyVolume::get_isFeatureSupported");
			LightProbeProxyVolume.get_probeDensityDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_probeDensityDelegate>("UnityEngine.LightProbeProxyVolume::get_probeDensity");
			LightProbeProxyVolume.set_probeDensityDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_probeDensityDelegate>("UnityEngine.LightProbeProxyVolume::set_probeDensity");
			LightProbeProxyVolume.get_gridResolutionXDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_gridResolutionXDelegate>("UnityEngine.LightProbeProxyVolume::get_gridResolutionX");
			LightProbeProxyVolume.set_gridResolutionXDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_gridResolutionXDelegate>("UnityEngine.LightProbeProxyVolume::set_gridResolutionX");
			LightProbeProxyVolume.get_gridResolutionYDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_gridResolutionYDelegate>("UnityEngine.LightProbeProxyVolume::get_gridResolutionY");
			LightProbeProxyVolume.set_gridResolutionYDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_gridResolutionYDelegate>("UnityEngine.LightProbeProxyVolume::set_gridResolutionY");
			LightProbeProxyVolume.get_gridResolutionZDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_gridResolutionZDelegate>("UnityEngine.LightProbeProxyVolume::get_gridResolutionZ");
			LightProbeProxyVolume.set_gridResolutionZDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_gridResolutionZDelegate>("UnityEngine.LightProbeProxyVolume::set_gridResolutionZ");
			LightProbeProxyVolume.get_boundingBoxModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_boundingBoxModeDelegate>("UnityEngine.LightProbeProxyVolume::get_boundingBoxMode");
			LightProbeProxyVolume.set_boundingBoxModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_boundingBoxModeDelegate>("UnityEngine.LightProbeProxyVolume::set_boundingBoxMode");
			LightProbeProxyVolume.get_resolutionModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_resolutionModeDelegate>("UnityEngine.LightProbeProxyVolume::get_resolutionMode");
			LightProbeProxyVolume.set_resolutionModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_resolutionModeDelegate>("UnityEngine.LightProbeProxyVolume::set_resolutionMode");
			LightProbeProxyVolume.get_probePositionModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_probePositionModeDelegate>("UnityEngine.LightProbeProxyVolume::get_probePositionMode");
			LightProbeProxyVolume.set_probePositionModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_probePositionModeDelegate>("UnityEngine.LightProbeProxyVolume::set_probePositionMode");
			LightProbeProxyVolume.get_refreshModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_refreshModeDelegate>("UnityEngine.LightProbeProxyVolume::get_refreshMode");
			LightProbeProxyVolume.set_refreshModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_refreshModeDelegate>("UnityEngine.LightProbeProxyVolume::set_refreshMode");
			LightProbeProxyVolume.get_qualityModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_qualityModeDelegate>("UnityEngine.LightProbeProxyVolume::get_qualityMode");
			LightProbeProxyVolume.set_qualityModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_qualityModeDelegate>("UnityEngine.LightProbeProxyVolume::set_qualityMode");
			LightProbeProxyVolume.get_dataFormatDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_dataFormatDelegate>("UnityEngine.LightProbeProxyVolume::get_dataFormat");
			LightProbeProxyVolume.set_dataFormatDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_dataFormatDelegate>("UnityEngine.LightProbeProxyVolume::set_dataFormat");
			LightProbeProxyVolume.SetDirtyFlagDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.SetDirtyFlagDelegate>("UnityEngine.LightProbeProxyVolume::SetDirtyFlag");
			LightProbeProxyVolume.get_boundsGlobal_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_boundsGlobal_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_boundsGlobal_Injected");
			LightProbeProxyVolume.get_sizeCustom_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_sizeCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_sizeCustom_Injected");
			LightProbeProxyVolume.set_sizeCustom_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_sizeCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_sizeCustom_Injected");
			LightProbeProxyVolume.get_originCustom_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_originCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_originCustom_Injected");
			LightProbeProxyVolume.set_originCustom_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_originCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_originCustom_Injected");
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00008C99 File Offset: 0x00006E99
		public LightProbeProxyVolume(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x00008CA2 File Offset: 0x00006EA2
		public static bool isFeatureSupported
		{
			get
			{
				return LightProbeProxyVolume.get_isFeatureSupportedDelegateField();
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x000420D4 File Offset: 0x000402D4
		public Bounds boundsGlobal
		{
			get
			{
				Bounds result;
				this.get_boundsGlobal_Injected(out result);
				return result;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x000420EC File Offset: 0x000402EC
		// (set) Token: 0x06000E96 RID: 3734 RVA: 0x00008CAE File Offset: 0x00006EAE
		public Vector3 sizeCustom
		{
			get
			{
				Vector3 result;
				this.get_sizeCustom_Injected(out result);
				return result;
			}
			set
			{
				this.set_sizeCustom_Injected(ref value);
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x00042104 File Offset: 0x00040304
		// (set) Token: 0x06000E98 RID: 3736 RVA: 0x00008CB8 File Offset: 0x00006EB8
		public Vector3 originCustom
		{
			get
			{
				Vector3 result;
				this.get_originCustom_Injected(out result);
				return result;
			}
			set
			{
				this.set_originCustom_Injected(ref value);
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x00008CC2 File Offset: 0x00006EC2
		// (set) Token: 0x06000E9A RID: 3738 RVA: 0x00008CD4 File Offset: 0x00006ED4
		public float probeDensity
		{
			get
			{
				return LightProbeProxyVolume.get_probeDensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_probeDensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000E9B RID: 3739 RVA: 0x00008CE7 File Offset: 0x00006EE7
		// (set) Token: 0x06000E9C RID: 3740 RVA: 0x00008CF9 File Offset: 0x00006EF9
		public int gridResolutionX
		{
			get
			{
				return LightProbeProxyVolume.get_gridResolutionXDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_gridResolutionXDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x00008D0C File Offset: 0x00006F0C
		// (set) Token: 0x06000E9E RID: 3742 RVA: 0x00008D1E File Offset: 0x00006F1E
		public int gridResolutionY
		{
			get
			{
				return LightProbeProxyVolume.get_gridResolutionYDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_gridResolutionYDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000E9F RID: 3743 RVA: 0x00008D31 File Offset: 0x00006F31
		// (set) Token: 0x06000EA0 RID: 3744 RVA: 0x00008D43 File Offset: 0x00006F43
		public int gridResolutionZ
		{
			get
			{
				return LightProbeProxyVolume.get_gridResolutionZDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_gridResolutionZDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x00008D56 File Offset: 0x00006F56
		// (set) Token: 0x06000EA2 RID: 3746 RVA: 0x00008D68 File Offset: 0x00006F68
		public LightProbeProxyVolume.BoundingBoxMode boundingBoxMode
		{
			get
			{
				return LightProbeProxyVolume.get_boundingBoxModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_boundingBoxModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x00008D7B File Offset: 0x00006F7B
		// (set) Token: 0x06000EA4 RID: 3748 RVA: 0x00008D8D File Offset: 0x00006F8D
		public LightProbeProxyVolume.ResolutionMode resolutionMode
		{
			get
			{
				return LightProbeProxyVolume.get_resolutionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_resolutionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x00008DA0 File Offset: 0x00006FA0
		// (set) Token: 0x06000EA6 RID: 3750 RVA: 0x00008DB2 File Offset: 0x00006FB2
		public LightProbeProxyVolume.ProbePositionMode probePositionMode
		{
			get
			{
				return LightProbeProxyVolume.get_probePositionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_probePositionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x00008DC5 File Offset: 0x00006FC5
		// (set) Token: 0x06000EA8 RID: 3752 RVA: 0x00008DD7 File Offset: 0x00006FD7
		public LightProbeProxyVolume.RefreshMode refreshMode
		{
			get
			{
				return LightProbeProxyVolume.get_refreshModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_refreshModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x00008DEA File Offset: 0x00006FEA
		// (set) Token: 0x06000EAA RID: 3754 RVA: 0x00008DFC File Offset: 0x00006FFC
		public LightProbeProxyVolume.QualityMode qualityMode
		{
			get
			{
				return LightProbeProxyVolume.get_qualityModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_qualityModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x00008E0F File Offset: 0x0000700F
		// (set) Token: 0x06000EAC RID: 3756 RVA: 0x00008E21 File Offset: 0x00007021
		public LightProbeProxyVolume.DataFormat dataFormat
		{
			get
			{
				return LightProbeProxyVolume.get_dataFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_dataFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00008E34 File Offset: 0x00007034
		public void Update()
		{
			this.SetDirtyFlag(true);
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00008E3F File Offset: 0x0000703F
		public void SetDirtyFlag(bool flag)
		{
			LightProbeProxyVolume.SetDirtyFlagDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), flag);
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00008E52 File Offset: 0x00007052
		public void get_boundsGlobal_Injected(out Bounds ret)
		{
			LightProbeProxyVolume.get_boundsGlobal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00008E65 File Offset: 0x00007065
		public void get_sizeCustom_Injected(out Vector3 ret)
		{
			LightProbeProxyVolume.get_sizeCustom_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00008E78 File Offset: 0x00007078
		public void set_sizeCustom_Injected(ref Vector3 value)
		{
			LightProbeProxyVolume.set_sizeCustom_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00008E8B File Offset: 0x0000708B
		public void get_originCustom_Injected(out Vector3 ret)
		{
			LightProbeProxyVolume.get_originCustom_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00008E9E File Offset: 0x0000709E
		public void set_originCustom_Injected(ref Vector3 value)
		{
			LightProbeProxyVolume.set_originCustom_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000BC4 RID: 3012
		private static readonly LightProbeProxyVolume.get_isFeatureSupportedDelegate get_isFeatureSupportedDelegateField;

		// Token: 0x04000BC5 RID: 3013
		private static readonly LightProbeProxyVolume.get_probeDensityDelegate get_probeDensityDelegateField;

		// Token: 0x04000BC6 RID: 3014
		private static readonly LightProbeProxyVolume.set_probeDensityDelegate set_probeDensityDelegateField;

		// Token: 0x04000BC7 RID: 3015
		private static readonly LightProbeProxyVolume.get_gridResolutionXDelegate get_gridResolutionXDelegateField;

		// Token: 0x04000BC8 RID: 3016
		private static readonly LightProbeProxyVolume.set_gridResolutionXDelegate set_gridResolutionXDelegateField;

		// Token: 0x04000BC9 RID: 3017
		private static readonly LightProbeProxyVolume.get_gridResolutionYDelegate get_gridResolutionYDelegateField;

		// Token: 0x04000BCA RID: 3018
		private static readonly LightProbeProxyVolume.set_gridResolutionYDelegate set_gridResolutionYDelegateField;

		// Token: 0x04000BCB RID: 3019
		private static readonly LightProbeProxyVolume.get_gridResolutionZDelegate get_gridResolutionZDelegateField;

		// Token: 0x04000BCC RID: 3020
		private static readonly LightProbeProxyVolume.set_gridResolutionZDelegate set_gridResolutionZDelegateField;

		// Token: 0x04000BCD RID: 3021
		private static readonly LightProbeProxyVolume.get_boundingBoxModeDelegate get_boundingBoxModeDelegateField;

		// Token: 0x04000BCE RID: 3022
		private static readonly LightProbeProxyVolume.set_boundingBoxModeDelegate set_boundingBoxModeDelegateField;

		// Token: 0x04000BCF RID: 3023
		private static readonly LightProbeProxyVolume.get_resolutionModeDelegate get_resolutionModeDelegateField;

		// Token: 0x04000BD0 RID: 3024
		private static readonly LightProbeProxyVolume.set_resolutionModeDelegate set_resolutionModeDelegateField;

		// Token: 0x04000BD1 RID: 3025
		private static readonly LightProbeProxyVolume.get_probePositionModeDelegate get_probePositionModeDelegateField;

		// Token: 0x04000BD2 RID: 3026
		private static readonly LightProbeProxyVolume.set_probePositionModeDelegate set_probePositionModeDelegateField;

		// Token: 0x04000BD3 RID: 3027
		private static readonly LightProbeProxyVolume.get_refreshModeDelegate get_refreshModeDelegateField;

		// Token: 0x04000BD4 RID: 3028
		private static readonly LightProbeProxyVolume.set_refreshModeDelegate set_refreshModeDelegateField;

		// Token: 0x04000BD5 RID: 3029
		private static readonly LightProbeProxyVolume.get_qualityModeDelegate get_qualityModeDelegateField;

		// Token: 0x04000BD6 RID: 3030
		private static readonly LightProbeProxyVolume.set_qualityModeDelegate set_qualityModeDelegateField;

		// Token: 0x04000BD7 RID: 3031
		private static readonly LightProbeProxyVolume.get_dataFormatDelegate get_dataFormatDelegateField;

		// Token: 0x04000BD8 RID: 3032
		private static readonly LightProbeProxyVolume.set_dataFormatDelegate set_dataFormatDelegateField;

		// Token: 0x04000BD9 RID: 3033
		private static readonly LightProbeProxyVolume.SetDirtyFlagDelegate SetDirtyFlagDelegateField;

		// Token: 0x04000BDA RID: 3034
		private static readonly LightProbeProxyVolume.get_boundsGlobal_InjectedDelegate get_boundsGlobal_InjectedDelegateField;

		// Token: 0x04000BDB RID: 3035
		private static readonly LightProbeProxyVolume.get_sizeCustom_InjectedDelegate get_sizeCustom_InjectedDelegateField;

		// Token: 0x04000BDC RID: 3036
		private static readonly LightProbeProxyVolume.set_sizeCustom_InjectedDelegate set_sizeCustom_InjectedDelegateField;

		// Token: 0x04000BDD RID: 3037
		private static readonly LightProbeProxyVolume.get_originCustom_InjectedDelegate get_originCustom_InjectedDelegateField;

		// Token: 0x04000BDE RID: 3038
		private static readonly LightProbeProxyVolume.set_originCustom_InjectedDelegate set_originCustom_InjectedDelegateField;

		// Token: 0x02000743 RID: 1859
		public enum ResolutionMode
		{
			// Token: 0x04002AA6 RID: 10918
			Automatic,
			// Token: 0x04002AA7 RID: 10919
			Custom
		}

		// Token: 0x02000744 RID: 1860
		public enum BoundingBoxMode
		{
			// Token: 0x04002AA9 RID: 10921
			AutomaticLocal,
			// Token: 0x04002AAA RID: 10922
			AutomaticWorld,
			// Token: 0x04002AAB RID: 10923
			Custom
		}

		// Token: 0x02000745 RID: 1861
		public enum ProbePositionMode
		{
			// Token: 0x04002AAD RID: 10925
			CellCorner,
			// Token: 0x04002AAE RID: 10926
			CellCenter
		}

		// Token: 0x02000746 RID: 1862
		public enum RefreshMode
		{
			// Token: 0x04002AB0 RID: 10928
			Automatic,
			// Token: 0x04002AB1 RID: 10929
			EveryFrame,
			// Token: 0x04002AB2 RID: 10930
			ViaScripting
		}

		// Token: 0x02000747 RID: 1863
		public enum QualityMode
		{
			// Token: 0x04002AB4 RID: 10932
			Low,
			// Token: 0x04002AB5 RID: 10933
			Normal
		}

		// Token: 0x02000748 RID: 1864
		public enum DataFormat
		{
			// Token: 0x04002AB7 RID: 10935
			HalfFloat,
			// Token: 0x04002AB8 RID: 10936
			Float
		}

		// Token: 0x02000749 RID: 1865
		// (Invoke) Token: 0x0600373A RID: 14138
		private delegate bool get_isFeatureSupportedDelegate();

		// Token: 0x0200074A RID: 1866
		// (Invoke) Token: 0x0600373C RID: 14140
		private delegate float get_probeDensityDelegate(IntPtr @this);

		// Token: 0x0200074B RID: 1867
		// (Invoke) Token: 0x0600373E RID: 14142
		private delegate void set_probeDensityDelegate(IntPtr @this, float value);

		// Token: 0x0200074C RID: 1868
		// (Invoke) Token: 0x06003740 RID: 14144
		private delegate int get_gridResolutionXDelegate(IntPtr @this);

		// Token: 0x0200074D RID: 1869
		// (Invoke) Token: 0x06003742 RID: 14146
		private delegate void set_gridResolutionXDelegate(IntPtr @this, int value);

		// Token: 0x0200074E RID: 1870
		// (Invoke) Token: 0x06003744 RID: 14148
		private delegate int get_gridResolutionYDelegate(IntPtr @this);

		// Token: 0x0200074F RID: 1871
		// (Invoke) Token: 0x06003746 RID: 14150
		private delegate void set_gridResolutionYDelegate(IntPtr @this, int value);

		// Token: 0x02000750 RID: 1872
		// (Invoke) Token: 0x06003748 RID: 14152
		private delegate int get_gridResolutionZDelegate(IntPtr @this);

		// Token: 0x02000751 RID: 1873
		// (Invoke) Token: 0x0600374A RID: 14154
		private delegate void set_gridResolutionZDelegate(IntPtr @this, int value);

		// Token: 0x02000752 RID: 1874
		// (Invoke) Token: 0x0600374C RID: 14156
		private delegate LightProbeProxyVolume.BoundingBoxMode get_boundingBoxModeDelegate(IntPtr @this);

		// Token: 0x02000753 RID: 1875
		// (Invoke) Token: 0x0600374E RID: 14158
		private delegate void set_boundingBoxModeDelegate(IntPtr @this, LightProbeProxyVolume.BoundingBoxMode value);

		// Token: 0x02000754 RID: 1876
		// (Invoke) Token: 0x06003750 RID: 14160
		private delegate LightProbeProxyVolume.ResolutionMode get_resolutionModeDelegate(IntPtr @this);

		// Token: 0x02000755 RID: 1877
		// (Invoke) Token: 0x06003752 RID: 14162
		private delegate void set_resolutionModeDelegate(IntPtr @this, LightProbeProxyVolume.ResolutionMode value);

		// Token: 0x02000756 RID: 1878
		// (Invoke) Token: 0x06003754 RID: 14164
		private delegate LightProbeProxyVolume.ProbePositionMode get_probePositionModeDelegate(IntPtr @this);

		// Token: 0x02000757 RID: 1879
		// (Invoke) Token: 0x06003756 RID: 14166
		private delegate void set_probePositionModeDelegate(IntPtr @this, LightProbeProxyVolume.ProbePositionMode value);

		// Token: 0x02000758 RID: 1880
		// (Invoke) Token: 0x06003758 RID: 14168
		private delegate LightProbeProxyVolume.RefreshMode get_refreshModeDelegate(IntPtr @this);

		// Token: 0x02000759 RID: 1881
		// (Invoke) Token: 0x0600375A RID: 14170
		private delegate void set_refreshModeDelegate(IntPtr @this, LightProbeProxyVolume.RefreshMode value);

		// Token: 0x0200075A RID: 1882
		// (Invoke) Token: 0x0600375C RID: 14172
		private delegate LightProbeProxyVolume.QualityMode get_qualityModeDelegate(IntPtr @this);

		// Token: 0x0200075B RID: 1883
		// (Invoke) Token: 0x0600375E RID: 14174
		private delegate void set_qualityModeDelegate(IntPtr @this, LightProbeProxyVolume.QualityMode value);

		// Token: 0x0200075C RID: 1884
		// (Invoke) Token: 0x06003760 RID: 14176
		private delegate LightProbeProxyVolume.DataFormat get_dataFormatDelegate(IntPtr @this);

		// Token: 0x0200075D RID: 1885
		// (Invoke) Token: 0x06003762 RID: 14178
		private delegate void set_dataFormatDelegate(IntPtr @this, LightProbeProxyVolume.DataFormat value);

		// Token: 0x0200075E RID: 1886
		// (Invoke) Token: 0x06003764 RID: 14180
		private delegate void SetDirtyFlagDelegate(IntPtr @this, bool flag);

		// Token: 0x0200075F RID: 1887
		// (Invoke) Token: 0x06003766 RID: 14182
		private delegate void get_boundsGlobal_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000760 RID: 1888
		// (Invoke) Token: 0x06003768 RID: 14184
		private delegate void get_sizeCustom_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000761 RID: 1889
		// (Invoke) Token: 0x0600376A RID: 14186
		private delegate void set_sizeCustom_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000762 RID: 1890
		// (Invoke) Token: 0x0600376C RID: 14188
		private delegate void get_originCustom_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000763 RID: 1891
		// (Invoke) Token: 0x0600376E RID: 14190
		private delegate void set_originCustom_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
