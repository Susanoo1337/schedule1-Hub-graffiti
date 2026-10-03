using System;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine.Device
{
	// Token: 0x0200035C RID: 860
	public static class SystemInfo
	{
		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06002E72 RID: 11890 RVA: 0x00014AEC File Offset: 0x00012CEC
		public static float batteryLevel
		{
			get
			{
				return SystemInfo.batteryLevel;
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06002E73 RID: 11891 RVA: 0x00014AF3 File Offset: 0x00012CF3
		public static BatteryStatus batteryStatus
		{
			get
			{
				return SystemInfo.batteryStatus;
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06002E74 RID: 11892 RVA: 0x00014AFA File Offset: 0x00012CFA
		public static string operatingSystem
		{
			get
			{
				return SystemInfo.operatingSystem;
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06002E75 RID: 11893 RVA: 0x00014B01 File Offset: 0x00012D01
		public static OperatingSystemFamily operatingSystemFamily
		{
			get
			{
				return SystemInfo.operatingSystemFamily;
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06002E76 RID: 11894 RVA: 0x00014B08 File Offset: 0x00012D08
		public static string processorType
		{
			get
			{
				return SystemInfo.processorType;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06002E77 RID: 11895 RVA: 0x00014B0F File Offset: 0x00012D0F
		public static int processorFrequency
		{
			get
			{
				return SystemInfo.processorFrequency;
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06002E78 RID: 11896 RVA: 0x00014B16 File Offset: 0x00012D16
		public static int processorCount
		{
			get
			{
				return SystemInfo.processorCount;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06002E79 RID: 11897 RVA: 0x00014B1D File Offset: 0x00012D1D
		public static int systemMemorySize
		{
			get
			{
				return SystemInfo.systemMemorySize;
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06002E7A RID: 11898 RVA: 0x00014B24 File Offset: 0x00012D24
		public static string deviceUniqueIdentifier
		{
			get
			{
				return SystemInfo.deviceUniqueIdentifier;
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06002E7B RID: 11899 RVA: 0x00014B2B File Offset: 0x00012D2B
		public static string deviceName
		{
			get
			{
				return SystemInfo.deviceName;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06002E7C RID: 11900 RVA: 0x00014B32 File Offset: 0x00012D32
		public static string deviceModel
		{
			get
			{
				return SystemInfo.deviceModel;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06002E7D RID: 11901 RVA: 0x00014B39 File Offset: 0x00012D39
		public static bool supportsAccelerometer
		{
			get
			{
				return SystemInfo.supportsAccelerometer;
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06002E7E RID: 11902 RVA: 0x00014B40 File Offset: 0x00012D40
		public static bool supportsGyroscope
		{
			get
			{
				return SystemInfo.supportsGyroscope;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06002E7F RID: 11903 RVA: 0x00014B47 File Offset: 0x00012D47
		public static bool supportsLocationService
		{
			get
			{
				return SystemInfo.supportsLocationService;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06002E80 RID: 11904 RVA: 0x00014B4E File Offset: 0x00012D4E
		public static bool supportsVibration
		{
			get
			{
				return SystemInfo.supportsVibration;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06002E81 RID: 11905 RVA: 0x00014B55 File Offset: 0x00012D55
		public static bool supportsAudio
		{
			get
			{
				return SystemInfo.supportsAudio;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06002E82 RID: 11906 RVA: 0x00014B5C File Offset: 0x00012D5C
		public static DeviceType deviceType
		{
			get
			{
				return SystemInfo.deviceType;
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06002E83 RID: 11907 RVA: 0x00014B63 File Offset: 0x00012D63
		public static int graphicsMemorySize
		{
			get
			{
				return SystemInfo.graphicsMemorySize;
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06002E84 RID: 11908 RVA: 0x00014B6A File Offset: 0x00012D6A
		public static string graphicsDeviceName
		{
			get
			{
				return SystemInfo.graphicsDeviceName;
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06002E85 RID: 11909 RVA: 0x00014B71 File Offset: 0x00012D71
		public static string graphicsDeviceVendor
		{
			get
			{
				return SystemInfo.graphicsDeviceVendor;
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06002E86 RID: 11910 RVA: 0x00014B78 File Offset: 0x00012D78
		public static int graphicsDeviceID
		{
			get
			{
				return SystemInfo.graphicsDeviceID;
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06002E87 RID: 11911 RVA: 0x00014B7F File Offset: 0x00012D7F
		public static int graphicsDeviceVendorID
		{
			get
			{
				return SystemInfo.graphicsDeviceVendorID;
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06002E88 RID: 11912 RVA: 0x00014B86 File Offset: 0x00012D86
		public static UnityEngine.Rendering.GraphicsDeviceType graphicsDeviceType
		{
			get
			{
				return SystemInfo.graphicsDeviceType;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06002E89 RID: 11913 RVA: 0x00014B8D File Offset: 0x00012D8D
		public static bool graphicsUVStartsAtTop
		{
			get
			{
				return SystemInfo.graphicsUVStartsAtTop;
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06002E8A RID: 11914 RVA: 0x00014B94 File Offset: 0x00012D94
		public static string graphicsDeviceVersion
		{
			get
			{
				return SystemInfo.graphicsDeviceVersion;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06002E8B RID: 11915 RVA: 0x00014B9B File Offset: 0x00012D9B
		public static int graphicsShaderLevel
		{
			get
			{
				return SystemInfo.graphicsShaderLevel;
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06002E8C RID: 11916 RVA: 0x00014BA2 File Offset: 0x00012DA2
		public static bool graphicsMultiThreaded
		{
			get
			{
				return SystemInfo.graphicsMultiThreaded;
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06002E8D RID: 11917 RVA: 0x00014BA9 File Offset: 0x00012DA9
		public static UnityEngine.Rendering.RenderingThreadingMode renderingThreadingMode
		{
			get
			{
				return SystemInfo.renderingThreadingMode;
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06002E8E RID: 11918 RVA: 0x00014BB0 File Offset: 0x00012DB0
		public static UnityEngine.Rendering.FoveatedRenderingCaps foveatedRenderingCaps
		{
			get
			{
				return SystemInfo.foveatedRenderingCaps;
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06002E8F RID: 11919 RVA: 0x00014BB7 File Offset: 0x00012DB7
		public static bool hasHiddenSurfaceRemovalOnGPU
		{
			get
			{
				return SystemInfo.hasHiddenSurfaceRemovalOnGPU;
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06002E90 RID: 11920 RVA: 0x00014BBE File Offset: 0x00012DBE
		public static bool hasDynamicUniformArrayIndexingInFragmentShaders
		{
			get
			{
				return SystemInfo.hasDynamicUniformArrayIndexingInFragmentShaders;
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06002E91 RID: 11921 RVA: 0x00014BC5 File Offset: 0x00012DC5
		public static bool supportsShadows
		{
			get
			{
				return SystemInfo.supportsShadows;
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06002E92 RID: 11922 RVA: 0x00014BCC File Offset: 0x00012DCC
		public static bool supportsRawShadowDepthSampling
		{
			get
			{
				return SystemInfo.supportsRawShadowDepthSampling;
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06002E93 RID: 11923 RVA: 0x00014BD3 File Offset: 0x00012DD3
		public static bool supportsMotionVectors
		{
			get
			{
				return SystemInfo.supportsMotionVectors;
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06002E94 RID: 11924 RVA: 0x00014BDA File Offset: 0x00012DDA
		public static bool supports3DTextures
		{
			get
			{
				return SystemInfo.supports3DTextures;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06002E95 RID: 11925 RVA: 0x00014BE1 File Offset: 0x00012DE1
		public static bool supportsCompressed3DTextures
		{
			get
			{
				return SystemInfo.supportsCompressed3DTextures;
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06002E96 RID: 11926 RVA: 0x00014BE8 File Offset: 0x00012DE8
		public static bool supports2DArrayTextures
		{
			get
			{
				return SystemInfo.supports2DArrayTextures;
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06002E97 RID: 11927 RVA: 0x00014BEF File Offset: 0x00012DEF
		public static bool supports3DRenderTextures
		{
			get
			{
				return SystemInfo.supports3DRenderTextures;
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06002E98 RID: 11928 RVA: 0x00014BF6 File Offset: 0x00012DF6
		public static bool supportsCubemapArrayTextures
		{
			get
			{
				return SystemInfo.supportsCubemapArrayTextures;
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06002E99 RID: 11929 RVA: 0x00014BFD File Offset: 0x00012DFD
		public static bool supportsAnisotropicFilter
		{
			get
			{
				return SystemInfo.supportsAnisotropicFilter;
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06002E9A RID: 11930 RVA: 0x00014C04 File Offset: 0x00012E04
		public static UnityEngine.Rendering.CopyTextureSupport copyTextureSupport
		{
			get
			{
				return SystemInfo.copyTextureSupport;
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06002E9B RID: 11931 RVA: 0x00014C0B File Offset: 0x00012E0B
		public static bool supportsComputeShaders
		{
			get
			{
				return SystemInfo.supportsComputeShaders;
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06002E9C RID: 11932 RVA: 0x00014C12 File Offset: 0x00012E12
		public static bool supportsGeometryShaders
		{
			get
			{
				return SystemInfo.supportsGeometryShaders;
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06002E9D RID: 11933 RVA: 0x00014C19 File Offset: 0x00012E19
		public static bool supportsTessellationShaders
		{
			get
			{
				return SystemInfo.supportsTessellationShaders;
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06002E9E RID: 11934 RVA: 0x00014C20 File Offset: 0x00012E20
		public static bool supportsRenderTargetArrayIndexFromVertexShader
		{
			get
			{
				return SystemInfo.supportsRenderTargetArrayIndexFromVertexShader;
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06002E9F RID: 11935 RVA: 0x00014C27 File Offset: 0x00012E27
		public static bool supportsInstancing
		{
			get
			{
				return SystemInfo.supportsInstancing;
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06002EA0 RID: 11936 RVA: 0x00014C2E File Offset: 0x00012E2E
		public static bool supportsHardwareQuadTopology
		{
			get
			{
				return SystemInfo.supportsHardwareQuadTopology;
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06002EA1 RID: 11937 RVA: 0x00014C35 File Offset: 0x00012E35
		public static bool supports32bitsIndexBuffer
		{
			get
			{
				return SystemInfo.supports32bitsIndexBuffer;
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06002EA2 RID: 11938 RVA: 0x00014C3C File Offset: 0x00012E3C
		public static bool supportsSparseTextures
		{
			get
			{
				return SystemInfo.supportsSparseTextures;
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06002EA3 RID: 11939 RVA: 0x00014C43 File Offset: 0x00012E43
		public static int supportedRenderTargetCount
		{
			get
			{
				return SystemInfo.supportedRenderTargetCount;
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06002EA4 RID: 11940 RVA: 0x00014C4A File Offset: 0x00012E4A
		public static bool supportsSeparatedRenderTargetsBlend
		{
			get
			{
				return SystemInfo.supportsSeparatedRenderTargetsBlend;
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06002EA5 RID: 11941 RVA: 0x00014C51 File Offset: 0x00012E51
		public static int supportedRandomWriteTargetCount
		{
			get
			{
				return SystemInfo.supportedRandomWriteTargetCount;
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06002EA6 RID: 11942 RVA: 0x00014C58 File Offset: 0x00012E58
		public static int supportsMultisampledTextures
		{
			get
			{
				return SystemInfo.supportsMultisampledTextures;
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06002EA7 RID: 11943 RVA: 0x00014C5F File Offset: 0x00012E5F
		public static bool supportsMultisampled2DArrayTextures
		{
			get
			{
				return SystemInfo.supportsMultisampled2DArrayTextures;
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06002EA8 RID: 11944 RVA: 0x00014C66 File Offset: 0x00012E66
		public static bool supportsMultisampleAutoResolve
		{
			get
			{
				return SystemInfo.supportsMultisampleAutoResolve;
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06002EA9 RID: 11945 RVA: 0x00014C6D File Offset: 0x00012E6D
		public static int supportsTextureWrapMirrorOnce
		{
			get
			{
				return SystemInfo.supportsTextureWrapMirrorOnce;
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06002EAA RID: 11946 RVA: 0x00014C74 File Offset: 0x00012E74
		public static bool usesReversedZBuffer
		{
			get
			{
				return SystemInfo.usesReversedZBuffer;
			}
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x000AD4C4 File Offset: 0x000AB6C4
		public static bool SupportsRenderTextureFormat(RenderTextureFormat format)
		{
			return SystemInfo.SupportsRenderTextureFormat(format);
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x000AD4DC File Offset: 0x000AB6DC
		public static bool SupportsBlendingOnRenderTextureFormat(RenderTextureFormat format)
		{
			return SystemInfo.SupportsBlendingOnRenderTextureFormat(format);
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x000AD4F4 File Offset: 0x000AB6F4
		public static bool SupportsTextureFormat(TextureFormat format)
		{
			return SystemInfo.SupportsTextureFormat(format);
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x000AD50C File Offset: 0x000AB70C
		public static bool SupportsVertexAttributeFormat(UnityEngine.Rendering.VertexAttributeFormat format, int dimension)
		{
			return SystemInfo.SupportsVertexAttributeFormat(format, dimension);
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06002EAF RID: 11951 RVA: 0x00014C7B File Offset: 0x00012E7B
		public static NPOTSupport npotSupport
		{
			get
			{
				return SystemInfo.npotSupport;
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06002EB0 RID: 11952 RVA: 0x00014C82 File Offset: 0x00012E82
		public static int maxTextureSize
		{
			get
			{
				return SystemInfo.maxTextureSize;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06002EB1 RID: 11953 RVA: 0x00014C89 File Offset: 0x00012E89
		public static int maxTexture3DSize
		{
			get
			{
				return SystemInfo.maxTexture3DSize;
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06002EB2 RID: 11954 RVA: 0x00014C90 File Offset: 0x00012E90
		public static int maxTextureArraySlices
		{
			get
			{
				return SystemInfo.maxTextureArraySlices;
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06002EB3 RID: 11955 RVA: 0x00014C97 File Offset: 0x00012E97
		public static int maxCubemapSize
		{
			get
			{
				return SystemInfo.maxCubemapSize;
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06002EB4 RID: 11956 RVA: 0x00014C9E File Offset: 0x00012E9E
		public static int maxAnisotropyLevel
		{
			get
			{
				return SystemInfo.maxAnisotropyLevel;
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06002EB5 RID: 11957 RVA: 0x00014CA5 File Offset: 0x00012EA5
		public static int maxComputeBufferInputsVertex
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsVertex;
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06002EB6 RID: 11958 RVA: 0x00014CAC File Offset: 0x00012EAC
		public static int maxComputeBufferInputsFragment
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsFragment;
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06002EB7 RID: 11959 RVA: 0x00014CB3 File Offset: 0x00012EB3
		public static int maxComputeBufferInputsGeometry
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsGeometry;
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06002EB8 RID: 11960 RVA: 0x00014CBA File Offset: 0x00012EBA
		public static int maxComputeBufferInputsDomain
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsDomain;
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06002EB9 RID: 11961 RVA: 0x00014CC1 File Offset: 0x00012EC1
		public static int maxComputeBufferInputsHull
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsHull;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06002EBA RID: 11962 RVA: 0x00014CC8 File Offset: 0x00012EC8
		public static int maxComputeBufferInputsCompute
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsCompute;
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06002EBB RID: 11963 RVA: 0x00014CCF File Offset: 0x00012ECF
		public static int maxComputeWorkGroupSize
		{
			get
			{
				return SystemInfo.maxComputeWorkGroupSize;
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06002EBC RID: 11964 RVA: 0x00014CD6 File Offset: 0x00012ED6
		public static int maxComputeWorkGroupSizeX
		{
			get
			{
				return SystemInfo.maxComputeWorkGroupSizeX;
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06002EBD RID: 11965 RVA: 0x00014CDD File Offset: 0x00012EDD
		public static int maxComputeWorkGroupSizeY
		{
			get
			{
				return SystemInfo.maxComputeWorkGroupSizeY;
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06002EBE RID: 11966 RVA: 0x00014CE4 File Offset: 0x00012EE4
		public static int maxComputeWorkGroupSizeZ
		{
			get
			{
				return SystemInfo.maxComputeWorkGroupSizeZ;
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06002EBF RID: 11967 RVA: 0x00014CEB File Offset: 0x00012EEB
		public static int computeSubGroupSize
		{
			get
			{
				return SystemInfo.computeSubGroupSize;
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06002EC0 RID: 11968 RVA: 0x00014CF2 File Offset: 0x00012EF2
		public static bool supportsAsyncCompute
		{
			get
			{
				return SystemInfo.supportsAsyncCompute;
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06002EC1 RID: 11969 RVA: 0x00014CF9 File Offset: 0x00012EF9
		public static bool supportsGpuRecorder
		{
			get
			{
				return SystemInfo.supportsGpuRecorder;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06002EC2 RID: 11970 RVA: 0x00014D00 File Offset: 0x00012F00
		public static bool supportsGraphicsFence
		{
			get
			{
				return SystemInfo.supportsGraphicsFence;
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06002EC3 RID: 11971 RVA: 0x00014D07 File Offset: 0x00012F07
		public static bool supportsAsyncGPUReadback
		{
			get
			{
				return SystemInfo.supportsAsyncGPUReadback;
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06002EC4 RID: 11972 RVA: 0x00014D0E File Offset: 0x00012F0E
		public static bool supportsRayTracing
		{
			get
			{
				return SystemInfo.supportsRayTracing;
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06002EC5 RID: 11973 RVA: 0x00014D15 File Offset: 0x00012F15
		public static bool supportsSetConstantBuffer
		{
			get
			{
				return SystemInfo.supportsSetConstantBuffer;
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06002EC6 RID: 11974 RVA: 0x00014D1C File Offset: 0x00012F1C
		public static int constantBufferOffsetAlignment
		{
			get
			{
				return SystemInfo.constantBufferOffsetAlignment;
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06002EC7 RID: 11975 RVA: 0x00014D23 File Offset: 0x00012F23
		public static int maxConstantBufferSize
		{
			get
			{
				return SystemInfo.maxConstantBufferSize;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06002EC8 RID: 11976 RVA: 0x00014D2A File Offset: 0x00012F2A
		public static long maxGraphicsBufferSize
		{
			get
			{
				return SystemInfo.maxGraphicsBufferSize;
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06002EC9 RID: 11977 RVA: 0x00014D31 File Offset: 0x00012F31
		public static bool hasMipMaxLevel
		{
			get
			{
				return SystemInfo.hasMipMaxLevel;
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06002ECA RID: 11978 RVA: 0x00014D38 File Offset: 0x00012F38
		public static bool supportsMipStreaming
		{
			get
			{
				return SystemInfo.supportsMipStreaming;
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06002ECB RID: 11979 RVA: 0x00014D3F File Offset: 0x00012F3F
		public static bool usesLoadStoreActions
		{
			get
			{
				return SystemInfo.usesLoadStoreActions;
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06002ECC RID: 11980 RVA: 0x00014D46 File Offset: 0x00012F46
		public static HDRDisplaySupportFlags hdrDisplaySupportFlags
		{
			get
			{
				return SystemInfo.hdrDisplaySupportFlags;
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06002ECD RID: 11981 RVA: 0x00014D4D File Offset: 0x00012F4D
		public static bool supportsConservativeRaster
		{
			get
			{
				return SystemInfo.supportsConservativeRaster;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06002ECE RID: 11982 RVA: 0x00014D54 File Offset: 0x00012F54
		public static bool supportsMultiview
		{
			get
			{
				return SystemInfo.supportsMultiview;
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06002ECF RID: 11983 RVA: 0x00014D5B File Offset: 0x00012F5B
		public static bool supportsStoreAndResolveAction
		{
			get
			{
				return SystemInfo.supportsStoreAndResolveAction;
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06002ED0 RID: 11984 RVA: 0x00014D62 File Offset: 0x00012F62
		public static bool supportsMultisampleResolveDepth
		{
			get
			{
				return SystemInfo.supportsMultisampleResolveDepth;
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06002ED1 RID: 11985 RVA: 0x00014D69 File Offset: 0x00012F69
		public static bool supportsMultisampleResolveStencil
		{
			get
			{
				return SystemInfo.supportsMultisampleResolveStencil;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06002ED2 RID: 11986 RVA: 0x00014D70 File Offset: 0x00012F70
		public static bool supportsIndirectArgumentsBuffer
		{
			get
			{
				return SystemInfo.supportsIndirectArgumentsBuffer;
			}
		}

		// Token: 0x06002ED3 RID: 11987 RVA: 0x000AD528 File Offset: 0x000AB728
		public static bool IsFormatSupported(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage)
		{
			return SystemInfo.IsFormatSupported(format, usage);
		}

		// Token: 0x06002ED4 RID: 11988 RVA: 0x000AD544 File Offset: 0x000AB744
		public static UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage)
		{
			return SystemInfo.GetCompatibleFormat(format, usage);
		}

		// Token: 0x06002ED5 RID: 11989 RVA: 0x000AD560 File Offset: 0x000AB760
		public static UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.Experimental.Rendering.DefaultFormat format)
		{
			return SystemInfo.GetGraphicsFormat(format);
		}

		// Token: 0x06002ED6 RID: 11990 RVA: 0x000AD578 File Offset: 0x000AB778
		public static int GetRenderTextureSupportedMSAASampleCount(RenderTextureDescriptor desc)
		{
			return SystemInfo.GetRenderTextureSupportedMSAASampleCount(desc);
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x000AD590 File Offset: 0x000AB790
		public static bool SupportsRandomWriteOnRenderTextureFormat(RenderTextureFormat format)
		{
			return SystemInfo.SupportsRandomWriteOnRenderTextureFormat(format);
		}

		// Token: 0x0400295A RID: 10586
		public const string unsupportedIdentifier = "n/a";
	}
}
