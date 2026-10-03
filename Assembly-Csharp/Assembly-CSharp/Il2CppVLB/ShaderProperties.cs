using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppVLB
{
	// Token: 0x02000071 RID: 113
	public static class ShaderProperties : Object
	{
		// Token: 0x06000845 RID: 2117 RVA: 0x00095E98 File Offset: 0x00094098
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderProperties()
		{
			Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "ShaderProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr);
			ShaderProperties.NativeFieldInfoPtr_ConeRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ConeRadius");
			ShaderProperties.NativeFieldInfoPtr_ConeGeomProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ConeGeomProps");
			ShaderProperties.NativeFieldInfoPtr_ColorFlat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ColorFlat");
			ShaderProperties.NativeFieldInfoPtr_DistanceFallOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "DistanceFallOff");
			ShaderProperties.NativeFieldInfoPtr_NoiseVelocityAndScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "NoiseVelocityAndScale");
			ShaderProperties.NativeFieldInfoPtr_NoiseParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "NoiseParam");
			ShaderProperties.NativeFieldInfoPtr_ColorGradientMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ColorGradientMatrix");
			ShaderProperties.NativeFieldInfoPtr_LocalToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "LocalToWorldMatrix");
			ShaderProperties.NativeFieldInfoPtr_WorldToLocalMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "WorldToLocalMatrix");
			ShaderProperties.NativeFieldInfoPtr_BlendSrcFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "BlendSrcFactor");
			ShaderProperties.NativeFieldInfoPtr_BlendDstFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "BlendDstFactor");
			ShaderProperties.NativeFieldInfoPtr_ZTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ZTest");
			ShaderProperties.NativeFieldInfoPtr_ParticlesTintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ParticlesTintColor");
			ShaderProperties.NativeFieldInfoPtr_HDRPExposureWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "HDRPExposureWeight");
			ShaderProperties.NativeFieldInfoPtr_GlobalUsesReversedZBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "GlobalUsesReversedZBuffer");
			ShaderProperties.NativeFieldInfoPtr_GlobalNoiseTex3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "GlobalNoiseTex3D");
			ShaderProperties.NativeFieldInfoPtr_GlobalNoiseCustomTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "GlobalNoiseCustomTime");
			ShaderProperties.NativeFieldInfoPtr_GlobalDitheringFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "GlobalDitheringFactor");
			ShaderProperties.NativeFieldInfoPtr_GlobalDitheringNoiseTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "GlobalDitheringNoiseTex");
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00005F1B File Offset: 0x0000411B
		public ShaderProperties(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x00096044 File Offset: 0x00094244
		// (set) Token: 0x06000848 RID: 2120 RVA: 0x00005F24 File Offset: 0x00004124
		public unsafe static int ConeRadius
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ConeRadius, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ConeRadius, (void*)(&value));
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x00096060 File Offset: 0x00094260
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x00005F32 File Offset: 0x00004132
		public unsafe static int ConeGeomProps
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ConeGeomProps, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ConeGeomProps, (void*)(&value));
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x0009607C File Offset: 0x0009427C
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x00005F40 File Offset: 0x00004140
		public unsafe static int ColorFlat
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ColorFlat, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ColorFlat, (void*)(&value));
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x00096098 File Offset: 0x00094298
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x00005F4E File Offset: 0x0000414E
		public unsafe static int DistanceFallOff
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_DistanceFallOff, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_DistanceFallOff, (void*)(&value));
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x000960B4 File Offset: 0x000942B4
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x00005F5C File Offset: 0x0000415C
		public unsafe static int NoiseVelocityAndScale
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_NoiseVelocityAndScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_NoiseVelocityAndScale, (void*)(&value));
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x000960D0 File Offset: 0x000942D0
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x00005F6A File Offset: 0x0000416A
		public unsafe static int NoiseParam
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_NoiseParam, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_NoiseParam, (void*)(&value));
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x000960EC File Offset: 0x000942EC
		// (set) Token: 0x06000854 RID: 2132 RVA: 0x00005F78 File Offset: 0x00004178
		public unsafe static int ColorGradientMatrix
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ColorGradientMatrix, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ColorGradientMatrix, (void*)(&value));
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x00096108 File Offset: 0x00094308
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x00005F86 File Offset: 0x00004186
		public unsafe static int LocalToWorldMatrix
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_LocalToWorldMatrix, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_LocalToWorldMatrix, (void*)(&value));
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x00096124 File Offset: 0x00094324
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x00005F94 File Offset: 0x00004194
		public unsafe static int WorldToLocalMatrix
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_WorldToLocalMatrix, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_WorldToLocalMatrix, (void*)(&value));
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x00096140 File Offset: 0x00094340
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x00005FA2 File Offset: 0x000041A2
		public unsafe static int BlendSrcFactor
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_BlendSrcFactor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_BlendSrcFactor, (void*)(&value));
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x0009615C File Offset: 0x0009435C
		// (set) Token: 0x0600085C RID: 2140 RVA: 0x00005FB0 File Offset: 0x000041B0
		public unsafe static int BlendDstFactor
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_BlendDstFactor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_BlendDstFactor, (void*)(&value));
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x00096178 File Offset: 0x00094378
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x00005FBE File Offset: 0x000041BE
		public unsafe static int ZTest
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ZTest, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ZTest, (void*)(&value));
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x00096194 File Offset: 0x00094394
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x00005FCC File Offset: 0x000041CC
		public unsafe static int ParticlesTintColor
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ParticlesTintColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ParticlesTintColor, (void*)(&value));
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x000961B0 File Offset: 0x000943B0
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x00005FDA File Offset: 0x000041DA
		public unsafe static int HDRPExposureWeight
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_HDRPExposureWeight, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_HDRPExposureWeight, (void*)(&value));
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x000961CC File Offset: 0x000943CC
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x00005FE8 File Offset: 0x000041E8
		public unsafe static int GlobalUsesReversedZBuffer
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_GlobalUsesReversedZBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_GlobalUsesReversedZBuffer, (void*)(&value));
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x000961E8 File Offset: 0x000943E8
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x00005FF6 File Offset: 0x000041F6
		public unsafe static int GlobalNoiseTex3D
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_GlobalNoiseTex3D, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_GlobalNoiseTex3D, (void*)(&value));
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x00096204 File Offset: 0x00094404
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x00006004 File Offset: 0x00004204
		public unsafe static int GlobalNoiseCustomTime
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_GlobalNoiseCustomTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_GlobalNoiseCustomTime, (void*)(&value));
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x00096220 File Offset: 0x00094420
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x00006012 File Offset: 0x00004212
		public unsafe static int GlobalDitheringFactor
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_GlobalDitheringFactor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_GlobalDitheringFactor, (void*)(&value));
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x0009623C File Offset: 0x0009443C
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x00006020 File Offset: 0x00004220
		public unsafe static int GlobalDitheringNoiseTex
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_GlobalDitheringNoiseTex, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_GlobalDitheringNoiseTex, (void*)(&value));
			}
		}

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeFieldInfoPtr_ConeRadius;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeFieldInfoPtr_ConeGeomProps;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeFieldInfoPtr_ColorFlat;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeFieldInfoPtr_DistanceFallOff;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeFieldInfoPtr_NoiseVelocityAndScale;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeFieldInfoPtr_NoiseParam;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeFieldInfoPtr_ColorGradientMatrix;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeFieldInfoPtr_LocalToWorldMatrix;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeFieldInfoPtr_WorldToLocalMatrix;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeFieldInfoPtr_BlendSrcFactor;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeFieldInfoPtr_BlendDstFactor;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeFieldInfoPtr_ZTest;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeFieldInfoPtr_ParticlesTintColor;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeFieldInfoPtr_HDRPExposureWeight;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeFieldInfoPtr_GlobalUsesReversedZBuffer;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeFieldInfoPtr_GlobalNoiseTex3D;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeFieldInfoPtr_GlobalNoiseCustomTime;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeFieldInfoPtr_GlobalDitheringFactor;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeFieldInfoPtr_GlobalDitheringNoiseTex;

		// Token: 0x02000892 RID: 2194
		public static class SD : Object
		{
			// Token: 0x0600D2BE RID: 53950 RVA: 0x0034AAA8 File Offset: 0x00348CA8
			// Note: this type is marked as 'beforefieldinit'.
			static SD()
			{
				Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "SD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr);
				ShaderProperties.SD.NativeFieldInfoPtr_FadeOutFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "FadeOutFactor");
				ShaderProperties.SD.NativeFieldInfoPtr_ConeSlopeCosSin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "ConeSlopeCosSin");
				ShaderProperties.SD.NativeFieldInfoPtr_AlphaInside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "AlphaInside");
				ShaderProperties.SD.NativeFieldInfoPtr_AlphaOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "AlphaOutside");
				ShaderProperties.SD.NativeFieldInfoPtr_AttenuationLerpLinearQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "AttenuationLerpLinearQuad");
				ShaderProperties.SD.NativeFieldInfoPtr_DistanceCamClipping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "DistanceCamClipping");
				ShaderProperties.SD.NativeFieldInfoPtr_FresnelPow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "FresnelPow");
				ShaderProperties.SD.NativeFieldInfoPtr_GlareBehind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "GlareBehind");
				ShaderProperties.SD.NativeFieldInfoPtr_GlareFrontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "GlareFrontal");
				ShaderProperties.SD.NativeFieldInfoPtr_DrawCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "DrawCap");
				ShaderProperties.SD.NativeFieldInfoPtr_DepthBlendDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "DepthBlendDistance");
				ShaderProperties.SD.NativeFieldInfoPtr_CameraParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "CameraParams");
				ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionClippingPlaneWS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "DynamicOcclusionClippingPlaneWS");
				ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionClippingPlaneProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "DynamicOcclusionClippingPlaneProps");
				ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "DynamicOcclusionDepthTexture");
				ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionDepthProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "DynamicOcclusionDepthProps");
				ShaderProperties.SD.NativeFieldInfoPtr_LocalForwardDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "LocalForwardDirection");
				ShaderProperties.SD.NativeFieldInfoPtr_TiltVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "TiltVector");
				ShaderProperties.SD.NativeFieldInfoPtr_AdditionalClippingPlaneWS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "AdditionalClippingPlaneWS");
			}

			// Token: 0x0600D2BF RID: 53951 RVA: 0x00063AF5 File Offset: 0x00061CF5
			public SD(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004006 RID: 16390
			// (get) Token: 0x0600D2C0 RID: 53952 RVA: 0x0034AC50 File Offset: 0x00348E50
			// (set) Token: 0x0600D2C1 RID: 53953 RVA: 0x00063AFE File Offset: 0x00061CFE
			public unsafe static int FadeOutFactor
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_FadeOutFactor, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_FadeOutFactor, (void*)(&value));
				}
			}

			// Token: 0x17004007 RID: 16391
			// (get) Token: 0x0600D2C2 RID: 53954 RVA: 0x0034AC6C File Offset: 0x00348E6C
			// (set) Token: 0x0600D2C3 RID: 53955 RVA: 0x00063B0C File Offset: 0x00061D0C
			public unsafe static int ConeSlopeCosSin
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_ConeSlopeCosSin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_ConeSlopeCosSin, (void*)(&value));
				}
			}

			// Token: 0x17004008 RID: 16392
			// (get) Token: 0x0600D2C4 RID: 53956 RVA: 0x0034AC88 File Offset: 0x00348E88
			// (set) Token: 0x0600D2C5 RID: 53957 RVA: 0x00063B1A File Offset: 0x00061D1A
			public unsafe static int AlphaInside
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_AlphaInside, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_AlphaInside, (void*)(&value));
				}
			}

			// Token: 0x17004009 RID: 16393
			// (get) Token: 0x0600D2C6 RID: 53958 RVA: 0x0034ACA4 File Offset: 0x00348EA4
			// (set) Token: 0x0600D2C7 RID: 53959 RVA: 0x00063B28 File Offset: 0x00061D28
			public unsafe static int AlphaOutside
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_AlphaOutside, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_AlphaOutside, (void*)(&value));
				}
			}

			// Token: 0x1700400A RID: 16394
			// (get) Token: 0x0600D2C8 RID: 53960 RVA: 0x0034ACC0 File Offset: 0x00348EC0
			// (set) Token: 0x0600D2C9 RID: 53961 RVA: 0x00063B36 File Offset: 0x00061D36
			public unsafe static int AttenuationLerpLinearQuad
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_AttenuationLerpLinearQuad, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_AttenuationLerpLinearQuad, (void*)(&value));
				}
			}

			// Token: 0x1700400B RID: 16395
			// (get) Token: 0x0600D2CA RID: 53962 RVA: 0x0034ACDC File Offset: 0x00348EDC
			// (set) Token: 0x0600D2CB RID: 53963 RVA: 0x00063B44 File Offset: 0x00061D44
			public unsafe static int DistanceCamClipping
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_DistanceCamClipping, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_DistanceCamClipping, (void*)(&value));
				}
			}

			// Token: 0x1700400C RID: 16396
			// (get) Token: 0x0600D2CC RID: 53964 RVA: 0x0034ACF8 File Offset: 0x00348EF8
			// (set) Token: 0x0600D2CD RID: 53965 RVA: 0x00063B52 File Offset: 0x00061D52
			public unsafe static int FresnelPow
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_FresnelPow, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_FresnelPow, (void*)(&value));
				}
			}

			// Token: 0x1700400D RID: 16397
			// (get) Token: 0x0600D2CE RID: 53966 RVA: 0x0034AD14 File Offset: 0x00348F14
			// (set) Token: 0x0600D2CF RID: 53967 RVA: 0x00063B60 File Offset: 0x00061D60
			public unsafe static int GlareBehind
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_GlareBehind, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_GlareBehind, (void*)(&value));
				}
			}

			// Token: 0x1700400E RID: 16398
			// (get) Token: 0x0600D2D0 RID: 53968 RVA: 0x0034AD30 File Offset: 0x00348F30
			// (set) Token: 0x0600D2D1 RID: 53969 RVA: 0x00063B6E File Offset: 0x00061D6E
			public unsafe static int GlareFrontal
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_GlareFrontal, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_GlareFrontal, (void*)(&value));
				}
			}

			// Token: 0x1700400F RID: 16399
			// (get) Token: 0x0600D2D2 RID: 53970 RVA: 0x0034AD4C File Offset: 0x00348F4C
			// (set) Token: 0x0600D2D3 RID: 53971 RVA: 0x00063B7C File Offset: 0x00061D7C
			public unsafe static int DrawCap
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_DrawCap, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_DrawCap, (void*)(&value));
				}
			}

			// Token: 0x17004010 RID: 16400
			// (get) Token: 0x0600D2D4 RID: 53972 RVA: 0x0034AD68 File Offset: 0x00348F68
			// (set) Token: 0x0600D2D5 RID: 53973 RVA: 0x00063B8A File Offset: 0x00061D8A
			public unsafe static int DepthBlendDistance
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_DepthBlendDistance, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_DepthBlendDistance, (void*)(&value));
				}
			}

			// Token: 0x17004011 RID: 16401
			// (get) Token: 0x0600D2D6 RID: 53974 RVA: 0x0034AD84 File Offset: 0x00348F84
			// (set) Token: 0x0600D2D7 RID: 53975 RVA: 0x00063B98 File Offset: 0x00061D98
			public unsafe static int CameraParams
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_CameraParams, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_CameraParams, (void*)(&value));
				}
			}

			// Token: 0x17004012 RID: 16402
			// (get) Token: 0x0600D2D8 RID: 53976 RVA: 0x0034ADA0 File Offset: 0x00348FA0
			// (set) Token: 0x0600D2D9 RID: 53977 RVA: 0x00063BA6 File Offset: 0x00061DA6
			public unsafe static int DynamicOcclusionClippingPlaneWS
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionClippingPlaneWS, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionClippingPlaneWS, (void*)(&value));
				}
			}

			// Token: 0x17004013 RID: 16403
			// (get) Token: 0x0600D2DA RID: 53978 RVA: 0x0034ADBC File Offset: 0x00348FBC
			// (set) Token: 0x0600D2DB RID: 53979 RVA: 0x00063BB4 File Offset: 0x00061DB4
			public unsafe static int DynamicOcclusionClippingPlaneProps
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionClippingPlaneProps, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionClippingPlaneProps, (void*)(&value));
				}
			}

			// Token: 0x17004014 RID: 16404
			// (get) Token: 0x0600D2DC RID: 53980 RVA: 0x0034ADD8 File Offset: 0x00348FD8
			// (set) Token: 0x0600D2DD RID: 53981 RVA: 0x00063BC2 File Offset: 0x00061DC2
			public unsafe static int DynamicOcclusionDepthTexture
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionDepthTexture, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionDepthTexture, (void*)(&value));
				}
			}

			// Token: 0x17004015 RID: 16405
			// (get) Token: 0x0600D2DE RID: 53982 RVA: 0x0034ADF4 File Offset: 0x00348FF4
			// (set) Token: 0x0600D2DF RID: 53983 RVA: 0x00063BD0 File Offset: 0x00061DD0
			public unsafe static int DynamicOcclusionDepthProps
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionDepthProps, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionDepthProps, (void*)(&value));
				}
			}

			// Token: 0x17004016 RID: 16406
			// (get) Token: 0x0600D2E0 RID: 53984 RVA: 0x0034AE10 File Offset: 0x00349010
			// (set) Token: 0x0600D2E1 RID: 53985 RVA: 0x00063BDE File Offset: 0x00061DDE
			public unsafe static int LocalForwardDirection
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_LocalForwardDirection, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_LocalForwardDirection, (void*)(&value));
				}
			}

			// Token: 0x17004017 RID: 16407
			// (get) Token: 0x0600D2E2 RID: 53986 RVA: 0x0034AE2C File Offset: 0x0034902C
			// (set) Token: 0x0600D2E3 RID: 53987 RVA: 0x00063BEC File Offset: 0x00061DEC
			public unsafe static int TiltVector
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_TiltVector, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_TiltVector, (void*)(&value));
				}
			}

			// Token: 0x17004018 RID: 16408
			// (get) Token: 0x0600D2E4 RID: 53988 RVA: 0x0034AE48 File Offset: 0x00349048
			// (set) Token: 0x0600D2E5 RID: 53989 RVA: 0x00063BFA File Offset: 0x00061DFA
			public unsafe static int AdditionalClippingPlaneWS
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_AdditionalClippingPlaneWS, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_AdditionalClippingPlaneWS, (void*)(&value));
				}
			}

			// Token: 0x04008F99 RID: 36761
			private static readonly IntPtr NativeFieldInfoPtr_FadeOutFactor;

			// Token: 0x04008F9A RID: 36762
			private static readonly IntPtr NativeFieldInfoPtr_ConeSlopeCosSin;

			// Token: 0x04008F9B RID: 36763
			private static readonly IntPtr NativeFieldInfoPtr_AlphaInside;

			// Token: 0x04008F9C RID: 36764
			private static readonly IntPtr NativeFieldInfoPtr_AlphaOutside;

			// Token: 0x04008F9D RID: 36765
			private static readonly IntPtr NativeFieldInfoPtr_AttenuationLerpLinearQuad;

			// Token: 0x04008F9E RID: 36766
			private static readonly IntPtr NativeFieldInfoPtr_DistanceCamClipping;

			// Token: 0x04008F9F RID: 36767
			private static readonly IntPtr NativeFieldInfoPtr_FresnelPow;

			// Token: 0x04008FA0 RID: 36768
			private static readonly IntPtr NativeFieldInfoPtr_GlareBehind;

			// Token: 0x04008FA1 RID: 36769
			private static readonly IntPtr NativeFieldInfoPtr_GlareFrontal;

			// Token: 0x04008FA2 RID: 36770
			private static readonly IntPtr NativeFieldInfoPtr_DrawCap;

			// Token: 0x04008FA3 RID: 36771
			private static readonly IntPtr NativeFieldInfoPtr_DepthBlendDistance;

			// Token: 0x04008FA4 RID: 36772
			private static readonly IntPtr NativeFieldInfoPtr_CameraParams;

			// Token: 0x04008FA5 RID: 36773
			private static readonly IntPtr NativeFieldInfoPtr_DynamicOcclusionClippingPlaneWS;

			// Token: 0x04008FA6 RID: 36774
			private static readonly IntPtr NativeFieldInfoPtr_DynamicOcclusionClippingPlaneProps;

			// Token: 0x04008FA7 RID: 36775
			private static readonly IntPtr NativeFieldInfoPtr_DynamicOcclusionDepthTexture;

			// Token: 0x04008FA8 RID: 36776
			private static readonly IntPtr NativeFieldInfoPtr_DynamicOcclusionDepthProps;

			// Token: 0x04008FA9 RID: 36777
			private static readonly IntPtr NativeFieldInfoPtr_LocalForwardDirection;

			// Token: 0x04008FAA RID: 36778
			private static readonly IntPtr NativeFieldInfoPtr_TiltVector;

			// Token: 0x04008FAB RID: 36779
			private static readonly IntPtr NativeFieldInfoPtr_AdditionalClippingPlaneWS;
		}

		// Token: 0x02000893 RID: 2195
		public static class HD : Object
		{
			// Token: 0x0600D2E6 RID: 53990 RVA: 0x0034AE64 File Offset: 0x00349064
			// Note: this type is marked as 'beforefieldinit'.
			static HD()
			{
				Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "HD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr);
				ShaderProperties.HD.NativeFieldInfoPtr_Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "Intensity");
				ShaderProperties.HD.NativeFieldInfoPtr_SideSoftness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "SideSoftness");
				ShaderProperties.HD.NativeFieldInfoPtr_CameraForwardOS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "CameraForwardOS");
				ShaderProperties.HD.NativeFieldInfoPtr_CameraForwardWS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "CameraForwardWS");
				ShaderProperties.HD.NativeFieldInfoPtr_TransformScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "TransformScale");
				ShaderProperties.HD.NativeFieldInfoPtr_ShadowDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "ShadowDepthTexture");
				ShaderProperties.HD.NativeFieldInfoPtr_ShadowProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "ShadowProps");
				ShaderProperties.HD.NativeFieldInfoPtr_Jittering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "Jittering");
				ShaderProperties.HD.NativeFieldInfoPtr_CookieTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "CookieTexture");
				ShaderProperties.HD.NativeFieldInfoPtr_CookieProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "CookieProperties");
				ShaderProperties.HD.NativeFieldInfoPtr_CookiePosAndScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "CookiePosAndScale");
				ShaderProperties.HD.NativeFieldInfoPtr_GlobalCameraBlendingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "GlobalCameraBlendingDistance");
				ShaderProperties.HD.NativeFieldInfoPtr_GlobalJitteringNoiseTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "GlobalJitteringNoiseTex");
			}

			// Token: 0x0600D2E7 RID: 53991 RVA: 0x00063C08 File Offset: 0x00061E08
			public HD(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004019 RID: 16409
			// (get) Token: 0x0600D2E8 RID: 53992 RVA: 0x0034AF94 File Offset: 0x00349194
			// (set) Token: 0x0600D2E9 RID: 53993 RVA: 0x00063C11 File Offset: 0x00061E11
			public unsafe static int Intensity
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_Intensity, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_Intensity, (void*)(&value));
				}
			}

			// Token: 0x1700401A RID: 16410
			// (get) Token: 0x0600D2EA RID: 53994 RVA: 0x0034AFB0 File Offset: 0x003491B0
			// (set) Token: 0x0600D2EB RID: 53995 RVA: 0x00063C1F File Offset: 0x00061E1F
			public unsafe static int SideSoftness
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_SideSoftness, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_SideSoftness, (void*)(&value));
				}
			}

			// Token: 0x1700401B RID: 16411
			// (get) Token: 0x0600D2EC RID: 53996 RVA: 0x0034AFCC File Offset: 0x003491CC
			// (set) Token: 0x0600D2ED RID: 53997 RVA: 0x00063C2D File Offset: 0x00061E2D
			public unsafe static int CameraForwardOS
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_CameraForwardOS, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_CameraForwardOS, (void*)(&value));
				}
			}

			// Token: 0x1700401C RID: 16412
			// (get) Token: 0x0600D2EE RID: 53998 RVA: 0x0034AFE8 File Offset: 0x003491E8
			// (set) Token: 0x0600D2EF RID: 53999 RVA: 0x00063C3B File Offset: 0x00061E3B
			public unsafe static int CameraForwardWS
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_CameraForwardWS, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_CameraForwardWS, (void*)(&value));
				}
			}

			// Token: 0x1700401D RID: 16413
			// (get) Token: 0x0600D2F0 RID: 54000 RVA: 0x0034B004 File Offset: 0x00349204
			// (set) Token: 0x0600D2F1 RID: 54001 RVA: 0x00063C49 File Offset: 0x00061E49
			public unsafe static int TransformScale
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_TransformScale, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_TransformScale, (void*)(&value));
				}
			}

			// Token: 0x1700401E RID: 16414
			// (get) Token: 0x0600D2F2 RID: 54002 RVA: 0x0034B020 File Offset: 0x00349220
			// (set) Token: 0x0600D2F3 RID: 54003 RVA: 0x00063C57 File Offset: 0x00061E57
			public unsafe static int ShadowDepthTexture
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_ShadowDepthTexture, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_ShadowDepthTexture, (void*)(&value));
				}
			}

			// Token: 0x1700401F RID: 16415
			// (get) Token: 0x0600D2F4 RID: 54004 RVA: 0x0034B03C File Offset: 0x0034923C
			// (set) Token: 0x0600D2F5 RID: 54005 RVA: 0x00063C65 File Offset: 0x00061E65
			public unsafe static int ShadowProps
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_ShadowProps, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_ShadowProps, (void*)(&value));
				}
			}

			// Token: 0x17004020 RID: 16416
			// (get) Token: 0x0600D2F6 RID: 54006 RVA: 0x0034B058 File Offset: 0x00349258
			// (set) Token: 0x0600D2F7 RID: 54007 RVA: 0x00063C73 File Offset: 0x00061E73
			public unsafe static int Jittering
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_Jittering, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_Jittering, (void*)(&value));
				}
			}

			// Token: 0x17004021 RID: 16417
			// (get) Token: 0x0600D2F8 RID: 54008 RVA: 0x0034B074 File Offset: 0x00349274
			// (set) Token: 0x0600D2F9 RID: 54009 RVA: 0x00063C81 File Offset: 0x00061E81
			public unsafe static int CookieTexture
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_CookieTexture, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_CookieTexture, (void*)(&value));
				}
			}

			// Token: 0x17004022 RID: 16418
			// (get) Token: 0x0600D2FA RID: 54010 RVA: 0x0034B090 File Offset: 0x00349290
			// (set) Token: 0x0600D2FB RID: 54011 RVA: 0x00063C8F File Offset: 0x00061E8F
			public unsafe static int CookieProperties
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_CookieProperties, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_CookieProperties, (void*)(&value));
				}
			}

			// Token: 0x17004023 RID: 16419
			// (get) Token: 0x0600D2FC RID: 54012 RVA: 0x0034B0AC File Offset: 0x003492AC
			// (set) Token: 0x0600D2FD RID: 54013 RVA: 0x00063C9D File Offset: 0x00061E9D
			public unsafe static int CookiePosAndScale
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_CookiePosAndScale, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_CookiePosAndScale, (void*)(&value));
				}
			}

			// Token: 0x17004024 RID: 16420
			// (get) Token: 0x0600D2FE RID: 54014 RVA: 0x0034B0C8 File Offset: 0x003492C8
			// (set) Token: 0x0600D2FF RID: 54015 RVA: 0x00063CAB File Offset: 0x00061EAB
			public unsafe static int GlobalCameraBlendingDistance
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_GlobalCameraBlendingDistance, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_GlobalCameraBlendingDistance, (void*)(&value));
				}
			}

			// Token: 0x17004025 RID: 16421
			// (get) Token: 0x0600D300 RID: 54016 RVA: 0x0034B0E4 File Offset: 0x003492E4
			// (set) Token: 0x0600D301 RID: 54017 RVA: 0x00063CB9 File Offset: 0x00061EB9
			public unsafe static int GlobalJitteringNoiseTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_GlobalJitteringNoiseTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_GlobalJitteringNoiseTex, (void*)(&value));
				}
			}

			// Token: 0x04008FAC RID: 36780
			private static readonly IntPtr NativeFieldInfoPtr_Intensity;

			// Token: 0x04008FAD RID: 36781
			private static readonly IntPtr NativeFieldInfoPtr_SideSoftness;

			// Token: 0x04008FAE RID: 36782
			private static readonly IntPtr NativeFieldInfoPtr_CameraForwardOS;

			// Token: 0x04008FAF RID: 36783
			private static readonly IntPtr NativeFieldInfoPtr_CameraForwardWS;

			// Token: 0x04008FB0 RID: 36784
			private static readonly IntPtr NativeFieldInfoPtr_TransformScale;

			// Token: 0x04008FB1 RID: 36785
			private static readonly IntPtr NativeFieldInfoPtr_ShadowDepthTexture;

			// Token: 0x04008FB2 RID: 36786
			private static readonly IntPtr NativeFieldInfoPtr_ShadowProps;

			// Token: 0x04008FB3 RID: 36787
			private static readonly IntPtr NativeFieldInfoPtr_Jittering;

			// Token: 0x04008FB4 RID: 36788
			private static readonly IntPtr NativeFieldInfoPtr_CookieTexture;

			// Token: 0x04008FB5 RID: 36789
			private static readonly IntPtr NativeFieldInfoPtr_CookieProperties;

			// Token: 0x04008FB6 RID: 36790
			private static readonly IntPtr NativeFieldInfoPtr_CookiePosAndScale;

			// Token: 0x04008FB7 RID: 36791
			private static readonly IntPtr NativeFieldInfoPtr_GlobalCameraBlendingDistance;

			// Token: 0x04008FB8 RID: 36792
			private static readonly IntPtr NativeFieldInfoPtr_GlobalJitteringNoiseTex;
		}
	}
}
