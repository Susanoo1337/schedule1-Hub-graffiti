using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppVLB
{
	// Token: 0x02000070 RID: 112
	public static class ShaderKeywords : Object
	{
		// Token: 0x0600083B RID: 2107 RVA: 0x00095D98 File Offset: 0x00093F98
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderKeywords()
		{
			Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "ShaderKeywords");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr);
			ShaderKeywords.NativeFieldInfoPtr_AlphaAsBlack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "AlphaAsBlack");
			ShaderKeywords.NativeFieldInfoPtr_ColorGradientMatrixLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "ColorGradientMatrixLow");
			ShaderKeywords.NativeFieldInfoPtr_ColorGradientMatrixHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "ColorGradientMatrixHigh");
			ShaderKeywords.NativeFieldInfoPtr_Noise3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "Noise3D");
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00005ECA File Offset: 0x000040CA
		public ShaderKeywords(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x00095E18 File Offset: 0x00094018
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x00005ED3 File Offset: 0x000040D3
		public unsafe static string AlphaAsBlack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.NativeFieldInfoPtr_AlphaAsBlack, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.NativeFieldInfoPtr_AlphaAsBlack, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x00095E38 File Offset: 0x00094038
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x00005EE5 File Offset: 0x000040E5
		public unsafe static string ColorGradientMatrixLow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.NativeFieldInfoPtr_ColorGradientMatrixLow, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.NativeFieldInfoPtr_ColorGradientMatrixLow, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x00095E58 File Offset: 0x00094058
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x00005EF7 File Offset: 0x000040F7
		public unsafe static string ColorGradientMatrixHigh
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.NativeFieldInfoPtr_ColorGradientMatrixHigh, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.NativeFieldInfoPtr_ColorGradientMatrixHigh, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x00095E78 File Offset: 0x00094078
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x00005F09 File Offset: 0x00004109
		public unsafe static string Noise3D
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.NativeFieldInfoPtr_Noise3D, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.NativeFieldInfoPtr_Noise3D, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeFieldInfoPtr_AlphaAsBlack;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeFieldInfoPtr_ColorGradientMatrixLow;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeFieldInfoPtr_ColorGradientMatrixHigh;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeFieldInfoPtr_Noise3D;

		// Token: 0x02000890 RID: 2192
		public static class SD : Object
		{
			// Token: 0x0600D2A3 RID: 53923 RVA: 0x0034A7C8 File Offset: 0x003489C8
			// Note: this type is marked as 'beforefieldinit'.
			static SD()
			{
				Il2CppClassPointerStore<ShaderKeywords.SD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "SD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderKeywords.SD>.NativeClassPtr);
				ShaderKeywords.SD.NativeFieldInfoPtr_DepthBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.SD>.NativeClassPtr, "DepthBlend");
				ShaderKeywords.SD.NativeFieldInfoPtr_OcclusionClippingPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.SD>.NativeClassPtr, "OcclusionClippingPlane");
				ShaderKeywords.SD.NativeFieldInfoPtr_OcclusionDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.SD>.NativeClassPtr, "OcclusionDepthTexture");
				ShaderKeywords.SD.NativeFieldInfoPtr_MeshSkewing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.SD>.NativeClassPtr, "MeshSkewing");
				ShaderKeywords.SD.NativeFieldInfoPtr_ShaderAccuracyHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.SD>.NativeClassPtr, "ShaderAccuracyHigh");
			}

			// Token: 0x0600D2A4 RID: 53924 RVA: 0x00063A1D File Offset: 0x00061C1D
			public SD(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FFB RID: 16379
			// (get) Token: 0x0600D2A5 RID: 53925 RVA: 0x0034A858 File Offset: 0x00348A58
			// (set) Token: 0x0600D2A6 RID: 53926 RVA: 0x00063A26 File Offset: 0x00061C26
			public unsafe static string DepthBlend
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.SD.NativeFieldInfoPtr_DepthBlend, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.SD.NativeFieldInfoPtr_DepthBlend, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003FFC RID: 16380
			// (get) Token: 0x0600D2A7 RID: 53927 RVA: 0x0034A878 File Offset: 0x00348A78
			// (set) Token: 0x0600D2A8 RID: 53928 RVA: 0x00063A38 File Offset: 0x00061C38
			public unsafe static string OcclusionClippingPlane
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.SD.NativeFieldInfoPtr_OcclusionClippingPlane, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.SD.NativeFieldInfoPtr_OcclusionClippingPlane, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003FFD RID: 16381
			// (get) Token: 0x0600D2A9 RID: 53929 RVA: 0x0034A898 File Offset: 0x00348A98
			// (set) Token: 0x0600D2AA RID: 53930 RVA: 0x00063A4A File Offset: 0x00061C4A
			public unsafe static string OcclusionDepthTexture
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.SD.NativeFieldInfoPtr_OcclusionDepthTexture, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.SD.NativeFieldInfoPtr_OcclusionDepthTexture, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003FFE RID: 16382
			// (get) Token: 0x0600D2AB RID: 53931 RVA: 0x0034A8B8 File Offset: 0x00348AB8
			// (set) Token: 0x0600D2AC RID: 53932 RVA: 0x00063A5C File Offset: 0x00061C5C
			public unsafe static string MeshSkewing
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.SD.NativeFieldInfoPtr_MeshSkewing, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.SD.NativeFieldInfoPtr_MeshSkewing, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003FFF RID: 16383
			// (get) Token: 0x0600D2AD RID: 53933 RVA: 0x0034A8D8 File Offset: 0x00348AD8
			// (set) Token: 0x0600D2AE RID: 53934 RVA: 0x00063A6E File Offset: 0x00061C6E
			public unsafe static string ShaderAccuracyHigh
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.SD.NativeFieldInfoPtr_ShaderAccuracyHigh, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.SD.NativeFieldInfoPtr_ShaderAccuracyHigh, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008F8D RID: 36749
			private static readonly IntPtr NativeFieldInfoPtr_DepthBlend;

			// Token: 0x04008F8E RID: 36750
			private static readonly IntPtr NativeFieldInfoPtr_OcclusionClippingPlane;

			// Token: 0x04008F8F RID: 36751
			private static readonly IntPtr NativeFieldInfoPtr_OcclusionDepthTexture;

			// Token: 0x04008F90 RID: 36752
			private static readonly IntPtr NativeFieldInfoPtr_MeshSkewing;

			// Token: 0x04008F91 RID: 36753
			private static readonly IntPtr NativeFieldInfoPtr_ShaderAccuracyHigh;
		}

		// Token: 0x02000891 RID: 2193
		public static class HD : Object
		{
			// Token: 0x0600D2AF RID: 53935 RVA: 0x0034A8F8 File Offset: 0x00348AF8
			// Note: this type is marked as 'beforefieldinit'.
			static HD()
			{
				Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "HD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr);
				ShaderKeywords.HD.NativeFieldInfoPtr_AttenuationLinear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr, "AttenuationLinear");
				ShaderKeywords.HD.NativeFieldInfoPtr_AttenuationQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr, "AttenuationQuad");
				ShaderKeywords.HD.NativeFieldInfoPtr_Shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr, "Shadow");
				ShaderKeywords.HD.NativeFieldInfoPtr_CookieSingleChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr, "CookieSingleChannel");
				ShaderKeywords.HD.NativeFieldInfoPtr_CookieRGBA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr, "CookieRGBA");
				ShaderKeywords.HD.NativeFieldInfoPtr_RaymarchingStepCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr, "RaymarchingStepCount");
				ShaderKeywords.HD.NativeMethodInfoPtr_GetRaymarchingQuality_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr, 100664359);
			}

			// Token: 0x0600D2B0 RID: 53936 RVA: 0x0034A9B0 File Offset: 0x00348BB0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73746, RefRangeEnd = 73747, XrefRangeStart = 73742, XrefRangeEnd = 73746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string GetRaymarchingQuality(int id)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderKeywords.HD.NativeMethodInfoPtr_GetRaymarchingQuality_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600D2B1 RID: 53937 RVA: 0x00063A80 File Offset: 0x00061C80
			public HD(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004000 RID: 16384
			// (get) Token: 0x0600D2B2 RID: 53938 RVA: 0x0034A9E8 File Offset: 0x00348BE8
			// (set) Token: 0x0600D2B3 RID: 53939 RVA: 0x00063A89 File Offset: 0x00061C89
			public unsafe static string AttenuationLinear
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.HD.NativeFieldInfoPtr_AttenuationLinear, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.HD.NativeFieldInfoPtr_AttenuationLinear, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004001 RID: 16385
			// (get) Token: 0x0600D2B4 RID: 53940 RVA: 0x0034AA08 File Offset: 0x00348C08
			// (set) Token: 0x0600D2B5 RID: 53941 RVA: 0x00063A9B File Offset: 0x00061C9B
			public unsafe static string AttenuationQuad
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.HD.NativeFieldInfoPtr_AttenuationQuad, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.HD.NativeFieldInfoPtr_AttenuationQuad, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004002 RID: 16386
			// (get) Token: 0x0600D2B6 RID: 53942 RVA: 0x0034AA28 File Offset: 0x00348C28
			// (set) Token: 0x0600D2B7 RID: 53943 RVA: 0x00063AAD File Offset: 0x00061CAD
			public unsafe static string Shadow
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.HD.NativeFieldInfoPtr_Shadow, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.HD.NativeFieldInfoPtr_Shadow, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004003 RID: 16387
			// (get) Token: 0x0600D2B8 RID: 53944 RVA: 0x0034AA48 File Offset: 0x00348C48
			// (set) Token: 0x0600D2B9 RID: 53945 RVA: 0x00063ABF File Offset: 0x00061CBF
			public unsafe static string CookieSingleChannel
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.HD.NativeFieldInfoPtr_CookieSingleChannel, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.HD.NativeFieldInfoPtr_CookieSingleChannel, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004004 RID: 16388
			// (get) Token: 0x0600D2BA RID: 53946 RVA: 0x0034AA68 File Offset: 0x00348C68
			// (set) Token: 0x0600D2BB RID: 53947 RVA: 0x00063AD1 File Offset: 0x00061CD1
			public unsafe static string CookieRGBA
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.HD.NativeFieldInfoPtr_CookieRGBA, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.HD.NativeFieldInfoPtr_CookieRGBA, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004005 RID: 16389
			// (get) Token: 0x0600D2BC RID: 53948 RVA: 0x0034AA88 File Offset: 0x00348C88
			// (set) Token: 0x0600D2BD RID: 53949 RVA: 0x00063AE3 File Offset: 0x00061CE3
			public unsafe static string RaymarchingStepCount
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.HD.NativeFieldInfoPtr_RaymarchingStepCount, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.HD.NativeFieldInfoPtr_RaymarchingStepCount, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008F92 RID: 36754
			private static readonly IntPtr NativeFieldInfoPtr_AttenuationLinear;

			// Token: 0x04008F93 RID: 36755
			private static readonly IntPtr NativeFieldInfoPtr_AttenuationQuad;

			// Token: 0x04008F94 RID: 36756
			private static readonly IntPtr NativeFieldInfoPtr_Shadow;

			// Token: 0x04008F95 RID: 36757
			private static readonly IntPtr NativeFieldInfoPtr_CookieSingleChannel;

			// Token: 0x04008F96 RID: 36758
			private static readonly IntPtr NativeFieldInfoPtr_CookieRGBA;

			// Token: 0x04008F97 RID: 36759
			private static readonly IntPtr NativeFieldInfoPtr_RaymarchingStepCount;

			// Token: 0x04008F98 RID: 36760
			private static readonly IntPtr NativeMethodInfoPtr_GetRaymarchingQuality_Public_Static_String_Int32_0;
		}
	}
}
