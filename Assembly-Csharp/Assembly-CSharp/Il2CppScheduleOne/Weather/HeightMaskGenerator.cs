using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Weather
{
	// Token: 0x020006D5 RID: 1749
	public class HeightMaskGenerator : MonoBehaviour
	{
		// Token: 0x0600A892 RID: 43154 RVA: 0x002C9CF8 File Offset: 0x002C7EF8
		// Note: this type is marked as 'beforefieldinit'.
		static HeightMaskGenerator()
		{
			Il2CppClassPointerStore<HeightMaskGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Weather", "HeightMaskGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeightMaskGenerator>.NativeClassPtr);
			HeightMaskGenerator.NativeFieldInfoPtr__maskShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightMaskGenerator>.NativeClassPtr, "_maskShader");
			HeightMaskGenerator.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightMaskGenerator>.NativeClassPtr, "_size");
			HeightMaskGenerator.NativeFieldInfoPtr__resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightMaskGenerator>.NativeClassPtr, "_resolution");
			HeightMaskGenerator.NativeFieldInfoPtr__minMaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightMaskGenerator>.NativeClassPtr, "_minMaxHeight");
			HeightMaskGenerator.NativeFieldInfoPtr__heightmapLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightMaskGenerator>.NativeClassPtr, "_heightmapLayerMask");
			HeightMaskGenerator.NativeFieldInfoPtr__debugTileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightMaskGenerator>.NativeClassPtr, "_debugTileSize");
			HeightMaskGenerator.NativeFieldInfoPtr__heightTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightMaskGenerator>.NativeClassPtr, "_heightTexture");
			HeightMaskGenerator.NativeFieldInfoPtr__debugMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightMaskGenerator>.NativeClassPtr, "_debugMaterial");
			HeightMaskGenerator.NativeFieldInfoPtr__kernal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightMaskGenerator>.NativeClassPtr, "_kernal");
			HeightMaskGenerator.NativeFieldInfoPtr__tileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightMaskGenerator>.NativeClassPtr, "_tileSize");
			HeightMaskGenerator.NativeFieldInfoPtr__tileHalfSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightMaskGenerator>.NativeClassPtr, "_tileHalfSize");
			HeightMaskGenerator.NativeFieldInfoPtr__origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightMaskGenerator>.NativeClassPtr, "_origin");
			HeightMaskGenerator.NativeFieldInfoPtr__heightBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightMaskGenerator>.NativeClassPtr, "_heightBuffer");
			HeightMaskGenerator.NativeMethodInfoPtr_InitialiseMaskMap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeightMaskGenerator>.NativeClassPtr, 100685653);
			HeightMaskGenerator.NativeMethodInfoPtr_GenerateMaskMap_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeightMaskGenerator>.NativeClassPtr, 100685654);
			HeightMaskGenerator.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeightMaskGenerator>.NativeClassPtr, 100685655);
			HeightMaskGenerator.NativeMethodInfoPtr_GenerateHeightMapDebug_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeightMaskGenerator>.NativeClassPtr, 100685656);
			HeightMaskGenerator.NativeMethodInfoPtr_Dispose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeightMaskGenerator>.NativeClassPtr, 100685657);
			HeightMaskGenerator.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeightMaskGenerator>.NativeClassPtr, 100685658);
			HeightMaskGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeightMaskGenerator>.NativeClassPtr, 100685659);
		}

		// Token: 0x0600A893 RID: 43155 RVA: 0x002C9EB8 File Offset: 0x002C80B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292473, RefRangeEnd = 292474, XrefRangeStart = 292442, XrefRangeEnd = 292473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitialiseMaskMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeightMaskGenerator.NativeMethodInfoPtr_InitialiseMaskMap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A894 RID: 43156 RVA: 0x002C9EEC File Offset: 0x002C80EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292498, RefRangeEnd = 292499, XrefRangeStart = 292474, XrefRangeEnd = 292498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateMaskMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeightMaskGenerator.NativeMethodInfoPtr_GenerateMaskMap_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A895 RID: 43157 RVA: 0x002C9F20 File Offset: 0x002C8120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292499, XrefRangeEnd = 292506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeightMaskGenerator.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A896 RID: 43158 RVA: 0x002C9F54 File Offset: 0x002C8154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292506, XrefRangeEnd = 292508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateHeightMapDebug()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeightMaskGenerator.NativeMethodInfoPtr_GenerateHeightMapDebug_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A897 RID: 43159 RVA: 0x002C9F88 File Offset: 0x002C8188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292508, XrefRangeEnd = 292513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeightMaskGenerator.NativeMethodInfoPtr_Dispose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A898 RID: 43160 RVA: 0x002C9FBC File Offset: 0x002C81BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292513, XrefRangeEnd = 292521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeightMaskGenerator.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A899 RID: 43161 RVA: 0x002C9FF0 File Offset: 0x002C81F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292521, XrefRangeEnd = 292522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeightMaskGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeightMaskGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeightMaskGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A89A RID: 43162 RVA: 0x0004CBED File Offset: 0x0004ADED
		public HeightMaskGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700325C RID: 12892
		// (get) Token: 0x0600A89B RID: 43163 RVA: 0x002CA02C File Offset: 0x002C822C
		// (set) Token: 0x0600A89C RID: 43164 RVA: 0x0004CBF6 File Offset: 0x0004ADF6
		public unsafe ComputeShader _maskShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__maskShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__maskShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700325D RID: 12893
		// (get) Token: 0x0600A89D RID: 43165 RVA: 0x002CA05C File Offset: 0x002C825C
		// (set) Token: 0x0600A89E RID: 43166 RVA: 0x0004CC15 File Offset: 0x0004AE15
		public unsafe float _size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__size)) = value;
			}
		}

		// Token: 0x1700325E RID: 12894
		// (get) Token: 0x0600A89F RID: 43167 RVA: 0x002CA084 File Offset: 0x002C8284
		// (set) Token: 0x0600A8A0 RID: 43168 RVA: 0x0004CC30 File Offset: 0x0004AE30
		public unsafe int _resolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__resolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__resolution)) = value;
			}
		}

		// Token: 0x1700325F RID: 12895
		// (get) Token: 0x0600A8A1 RID: 43169 RVA: 0x002CA0AC File Offset: 0x002C82AC
		// (set) Token: 0x0600A8A2 RID: 43170 RVA: 0x0004CC4B File Offset: 0x0004AE4B
		public unsafe Vector2 _minMaxHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__minMaxHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__minMaxHeight)) = value;
			}
		}

		// Token: 0x17003260 RID: 12896
		// (get) Token: 0x0600A8A3 RID: 43171 RVA: 0x002CA0D4 File Offset: 0x002C82D4
		// (set) Token: 0x0600A8A4 RID: 43172 RVA: 0x0004CC66 File Offset: 0x0004AE66
		public unsafe LayerMask _heightmapLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__heightmapLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__heightmapLayerMask)) = value;
			}
		}

		// Token: 0x17003261 RID: 12897
		// (get) Token: 0x0600A8A5 RID: 43173 RVA: 0x002CA0FC File Offset: 0x002C82FC
		// (set) Token: 0x0600A8A6 RID: 43174 RVA: 0x0004CC81 File Offset: 0x0004AE81
		public unsafe float _debugTileSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__debugTileSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__debugTileSize)) = value;
			}
		}

		// Token: 0x17003262 RID: 12898
		// (get) Token: 0x0600A8A7 RID: 43175 RVA: 0x002CA124 File Offset: 0x002C8324
		// (set) Token: 0x0600A8A8 RID: 43176 RVA: 0x0004CC9C File Offset: 0x0004AE9C
		public unsafe RenderTexture _heightTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__heightTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__heightTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003263 RID: 12899
		// (get) Token: 0x0600A8A9 RID: 43177 RVA: 0x002CA154 File Offset: 0x002C8354
		// (set) Token: 0x0600A8AA RID: 43178 RVA: 0x0004CCBB File Offset: 0x0004AEBB
		public unsafe Material _debugMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__debugMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__debugMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003264 RID: 12900
		// (get) Token: 0x0600A8AB RID: 43179 RVA: 0x002CA184 File Offset: 0x002C8384
		// (set) Token: 0x0600A8AC RID: 43180 RVA: 0x0004CCDA File Offset: 0x0004AEDA
		public unsafe int _kernal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__kernal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__kernal)) = value;
			}
		}

		// Token: 0x17003265 RID: 12901
		// (get) Token: 0x0600A8AD RID: 43181 RVA: 0x002CA1AC File Offset: 0x002C83AC
		// (set) Token: 0x0600A8AE RID: 43182 RVA: 0x0004CCF5 File Offset: 0x0004AEF5
		public unsafe float _tileSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__tileSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__tileSize)) = value;
			}
		}

		// Token: 0x17003266 RID: 12902
		// (get) Token: 0x0600A8AF RID: 43183 RVA: 0x002CA1D4 File Offset: 0x002C83D4
		// (set) Token: 0x0600A8B0 RID: 43184 RVA: 0x0004CD10 File Offset: 0x0004AF10
		public unsafe float _tileHalfSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__tileHalfSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__tileHalfSize)) = value;
			}
		}

		// Token: 0x17003267 RID: 12903
		// (get) Token: 0x0600A8B1 RID: 43185 RVA: 0x002CA1FC File Offset: 0x002C83FC
		// (set) Token: 0x0600A8B2 RID: 43186 RVA: 0x0004CD2B File Offset: 0x0004AF2B
		public unsafe Vector3 _origin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__origin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__origin)) = value;
			}
		}

		// Token: 0x17003268 RID: 12904
		// (get) Token: 0x0600A8B3 RID: 43187 RVA: 0x002CA224 File Offset: 0x002C8424
		// (set) Token: 0x0600A8B4 RID: 43188 RVA: 0x0004CD46 File Offset: 0x0004AF46
		public unsafe ComputeBuffer _heightBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__heightBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeightMaskGenerator.NativeFieldInfoPtr__heightBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400748D RID: 29837
		private static readonly IntPtr NativeFieldInfoPtr__maskShader;

		// Token: 0x0400748E RID: 29838
		private static readonly IntPtr NativeFieldInfoPtr__size;

		// Token: 0x0400748F RID: 29839
		private static readonly IntPtr NativeFieldInfoPtr__resolution;

		// Token: 0x04007490 RID: 29840
		private static readonly IntPtr NativeFieldInfoPtr__minMaxHeight;

		// Token: 0x04007491 RID: 29841
		private static readonly IntPtr NativeFieldInfoPtr__heightmapLayerMask;

		// Token: 0x04007492 RID: 29842
		private static readonly IntPtr NativeFieldInfoPtr__debugTileSize;

		// Token: 0x04007493 RID: 29843
		private static readonly IntPtr NativeFieldInfoPtr__heightTexture;

		// Token: 0x04007494 RID: 29844
		private static readonly IntPtr NativeFieldInfoPtr__debugMaterial;

		// Token: 0x04007495 RID: 29845
		private static readonly IntPtr NativeFieldInfoPtr__kernal;

		// Token: 0x04007496 RID: 29846
		private static readonly IntPtr NativeFieldInfoPtr__tileSize;

		// Token: 0x04007497 RID: 29847
		private static readonly IntPtr NativeFieldInfoPtr__tileHalfSize;

		// Token: 0x04007498 RID: 29848
		private static readonly IntPtr NativeFieldInfoPtr__origin;

		// Token: 0x04007499 RID: 29849
		private static readonly IntPtr NativeFieldInfoPtr__heightBuffer;

		// Token: 0x0400749A RID: 29850
		private static readonly IntPtr NativeMethodInfoPtr_InitialiseMaskMap_Public_Void_0;

		// Token: 0x0400749B RID: 29851
		private static readonly IntPtr NativeMethodInfoPtr_GenerateMaskMap_Private_Void_0;

		// Token: 0x0400749C RID: 29852
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400749D RID: 29853
		private static readonly IntPtr NativeMethodInfoPtr_GenerateHeightMapDebug_Private_Void_0;

		// Token: 0x0400749E RID: 29854
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_0;

		// Token: 0x0400749F RID: 29855
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x040074A0 RID: 29856
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
