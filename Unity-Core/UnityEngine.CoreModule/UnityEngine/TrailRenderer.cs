using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x020000A4 RID: 164
	public sealed class TrailRenderer : Renderer
	{
		// Token: 0x06000A5A RID: 2650 RVA: 0x000370D8 File Offset: 0x000352D8
		// Note: this type is marked as 'beforefieldinit'.
		static TrailRenderer()
		{
			Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TrailRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr);
			TrailRenderer.NativeMethodInfoPtr_get_startColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664304);
			TrailRenderer.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664305);
			TrailRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664306);
			TrailRenderer.NativeMethodInfoPtr_get_startColor_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664307);
			TrailRenderer.NativeMethodInfoPtr_set_startColor_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664308);
			TrailRenderer.get_timeDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_timeDelegate>("UnityEngine.TrailRenderer::get_time");
			TrailRenderer.set_timeDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_timeDelegate>("UnityEngine.TrailRenderer::set_time");
			TrailRenderer.get_startWidthDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_startWidthDelegate>("UnityEngine.TrailRenderer::get_startWidth");
			TrailRenderer.set_startWidthDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_startWidthDelegate>("UnityEngine.TrailRenderer::set_startWidth");
			TrailRenderer.get_endWidthDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_endWidthDelegate>("UnityEngine.TrailRenderer::get_endWidth");
			TrailRenderer.set_endWidthDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_endWidthDelegate>("UnityEngine.TrailRenderer::set_endWidth");
			TrailRenderer.get_widthMultiplierDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_widthMultiplierDelegate>("UnityEngine.TrailRenderer::get_widthMultiplier");
			TrailRenderer.set_widthMultiplierDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_widthMultiplierDelegate>("UnityEngine.TrailRenderer::set_widthMultiplier");
			TrailRenderer.get_autodestructDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_autodestructDelegate>("UnityEngine.TrailRenderer::get_autodestruct");
			TrailRenderer.set_autodestructDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_autodestructDelegate>("UnityEngine.TrailRenderer::set_autodestruct");
			TrailRenderer.get_emittingDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_emittingDelegate>("UnityEngine.TrailRenderer::get_emitting");
			TrailRenderer.set_emittingDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_emittingDelegate>("UnityEngine.TrailRenderer::set_emitting");
			TrailRenderer.get_numCornerVerticesDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_numCornerVerticesDelegate>("UnityEngine.TrailRenderer::get_numCornerVertices");
			TrailRenderer.set_numCornerVerticesDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_numCornerVerticesDelegate>("UnityEngine.TrailRenderer::set_numCornerVertices");
			TrailRenderer.get_numCapVerticesDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_numCapVerticesDelegate>("UnityEngine.TrailRenderer::get_numCapVertices");
			TrailRenderer.set_numCapVerticesDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_numCapVerticesDelegate>("UnityEngine.TrailRenderer::set_numCapVertices");
			TrailRenderer.get_minVertexDistanceDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_minVertexDistanceDelegate>("UnityEngine.TrailRenderer::get_minVertexDistance");
			TrailRenderer.set_minVertexDistanceDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_minVertexDistanceDelegate>("UnityEngine.TrailRenderer::set_minVertexDistance");
			TrailRenderer.get_positionCountDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_positionCountDelegate>("UnityEngine.TrailRenderer::get_positionCount");
			TrailRenderer.get_shadowBiasDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_shadowBiasDelegate>("UnityEngine.TrailRenderer::get_shadowBias");
			TrailRenderer.set_shadowBiasDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_shadowBiasDelegate>("UnityEngine.TrailRenderer::set_shadowBias");
			TrailRenderer.get_generateLightingDataDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_generateLightingDataDelegate>("UnityEngine.TrailRenderer::get_generateLightingData");
			TrailRenderer.set_generateLightingDataDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_generateLightingDataDelegate>("UnityEngine.TrailRenderer::set_generateLightingData");
			TrailRenderer.get_textureModeDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_textureModeDelegate>("UnityEngine.TrailRenderer::get_textureMode");
			TrailRenderer.set_textureModeDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_textureModeDelegate>("UnityEngine.TrailRenderer::set_textureMode");
			TrailRenderer.get_alignmentDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_alignmentDelegate>("UnityEngine.TrailRenderer::get_alignment");
			TrailRenderer.set_alignmentDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_alignmentDelegate>("UnityEngine.TrailRenderer::set_alignment");
			TrailRenderer.get_maskInteractionDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_maskInteractionDelegate>("UnityEngine.TrailRenderer::get_maskInteraction");
			TrailRenderer.set_maskInteractionDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_maskInteractionDelegate>("UnityEngine.TrailRenderer::set_maskInteraction");
			TrailRenderer.ClearDelegateField = IL2CPP.ResolveICall<TrailRenderer.ClearDelegate>("UnityEngine.TrailRenderer::Clear");
			TrailRenderer.BakeMeshDelegateField = IL2CPP.ResolveICall<TrailRenderer.BakeMeshDelegate>("UnityEngine.TrailRenderer::BakeMesh");
			TrailRenderer.GetWidthCurveCopyDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetWidthCurveCopyDelegate>("UnityEngine.TrailRenderer::GetWidthCurveCopy");
			TrailRenderer.SetWidthCurveDelegateField = IL2CPP.ResolveICall<TrailRenderer.SetWidthCurveDelegate>("UnityEngine.TrailRenderer::SetWidthCurve");
			TrailRenderer.GetColorGradientCopyDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetColorGradientCopyDelegate>("UnityEngine.TrailRenderer::GetColorGradientCopy");
			TrailRenderer.SetColorGradientDelegateField = IL2CPP.ResolveICall<TrailRenderer.SetColorGradientDelegate>("UnityEngine.TrailRenderer::SetColorGradient");
			TrailRenderer.GetPositionsDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetPositionsDelegate>("UnityEngine.TrailRenderer::GetPositions");
			TrailRenderer.GetVisiblePositionsDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetVisiblePositionsDelegate>("UnityEngine.TrailRenderer::GetVisiblePositions");
			TrailRenderer.SetPositionsDelegateField = IL2CPP.ResolveICall<TrailRenderer.SetPositionsDelegate>("UnityEngine.TrailRenderer::SetPositions");
			TrailRenderer.AddPositionsDelegateField = IL2CPP.ResolveICall<TrailRenderer.AddPositionsDelegate>("UnityEngine.TrailRenderer::AddPositions");
			TrailRenderer.SetPositionsWithNativeContainerDelegateField = IL2CPP.ResolveICall<TrailRenderer.SetPositionsWithNativeContainerDelegate>("UnityEngine.TrailRenderer::SetPositionsWithNativeContainer");
			TrailRenderer.GetPositionsWithNativeContainerDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetPositionsWithNativeContainerDelegate>("UnityEngine.TrailRenderer::GetPositionsWithNativeContainer");
			TrailRenderer.GetVisiblePositionsWithNativeContainerDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetVisiblePositionsWithNativeContainerDelegate>("UnityEngine.TrailRenderer::GetVisiblePositionsWithNativeContainer");
			TrailRenderer.AddPositionsWithNativeContainerDelegateField = IL2CPP.ResolveICall<TrailRenderer.AddPositionsWithNativeContainerDelegate>("UnityEngine.TrailRenderer::AddPositionsWithNativeContainer");
			TrailRenderer.get_endColor_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_endColor_InjectedDelegate>("UnityEngine.TrailRenderer::get_endColor_Injected");
			TrailRenderer.set_endColor_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_endColor_InjectedDelegate>("UnityEngine.TrailRenderer::set_endColor_Injected");
			TrailRenderer.SetPosition_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.SetPosition_InjectedDelegate>("UnityEngine.TrailRenderer::SetPosition_Injected");
			TrailRenderer.GetPosition_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.GetPosition_InjectedDelegate>("UnityEngine.TrailRenderer::GetPosition_Injected");
			TrailRenderer.get_textureScale_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.get_textureScale_InjectedDelegate>("UnityEngine.TrailRenderer::get_textureScale_Injected");
			TrailRenderer.set_textureScale_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.set_textureScale_InjectedDelegate>("UnityEngine.TrailRenderer::set_textureScale_Injected");
			TrailRenderer.AddPosition_InjectedDelegateField = IL2CPP.ResolveICall<TrailRenderer.AddPosition_InjectedDelegate>("UnityEngine.TrailRenderer::AddPosition_Injected");
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x0003745C File Offset: 0x0003565C
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x00037498 File Offset: 0x00035698
		public unsafe Color startColor
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1234627, RefRangeEnd = 1234629, XrefRangeStart = 1234625, XrefRangeEnd = 1234627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_startColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1234631, RefRangeEnd = 1234632, XrefRangeStart = 1234629, XrefRangeEnd = 1234631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x000374D8 File Offset: 0x000356D8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrailRenderer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00037514 File Offset: 0x00035714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234632, XrefRangeEnd = 1234634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_startColor_Injected(out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_startColor_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00037554 File Offset: 0x00035754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234634, XrefRangeEnd = 1234636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_startColor_Injected(ref Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_startColor_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0000696D File Offset: 0x00004B6D
		public TrailRenderer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x00037594 File Offset: 0x00035794
		public int numPositions
		{
			get
			{
				return this.positionCount;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x00006976 File Offset: 0x00004B76
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x00006988 File Offset: 0x00004B88
		public float time
		{
			get
			{
				return TrailRenderer.get_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x0000699B File Offset: 0x00004B9B
		// (set) Token: 0x06000A65 RID: 2661 RVA: 0x000069AD File Offset: 0x00004BAD
		public float startWidth
		{
			get
			{
				return TrailRenderer.get_startWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_startWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x000069C0 File Offset: 0x00004BC0
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x000069D2 File Offset: 0x00004BD2
		public float endWidth
		{
			get
			{
				return TrailRenderer.get_endWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_endWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x000069E5 File Offset: 0x00004BE5
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x000069F7 File Offset: 0x00004BF7
		public float widthMultiplier
		{
			get
			{
				return TrailRenderer.get_widthMultiplierDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_widthMultiplierDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x00006A0A File Offset: 0x00004C0A
		// (set) Token: 0x06000A6B RID: 2667 RVA: 0x00006A1C File Offset: 0x00004C1C
		public bool autodestruct
		{
			get
			{
				return TrailRenderer.get_autodestructDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_autodestructDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x00006A2F File Offset: 0x00004C2F
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x00006A41 File Offset: 0x00004C41
		public bool emitting
		{
			get
			{
				return TrailRenderer.get_emittingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_emittingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x00006A54 File Offset: 0x00004C54
		// (set) Token: 0x06000A6F RID: 2671 RVA: 0x00006A66 File Offset: 0x00004C66
		public int numCornerVertices
		{
			get
			{
				return TrailRenderer.get_numCornerVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_numCornerVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x00006A79 File Offset: 0x00004C79
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x00006A8B File Offset: 0x00004C8B
		public int numCapVertices
		{
			get
			{
				return TrailRenderer.get_numCapVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_numCapVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x00006A9E File Offset: 0x00004C9E
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x00006AB0 File Offset: 0x00004CB0
		public float minVertexDistance
		{
			get
			{
				return TrailRenderer.get_minVertexDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_minVertexDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x000375AC File Offset: 0x000357AC
		// (set) Token: 0x06000A75 RID: 2677 RVA: 0x00006AC3 File Offset: 0x00004CC3
		public Color endColor
		{
			get
			{
				Color result;
				this.get_endColor_Injected(out result);
				return result;
			}
			set
			{
				this.set_endColor_Injected(ref value);
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x00006ACD File Offset: 0x00004CCD
		public int positionCount
		{
			get
			{
				return TrailRenderer.get_positionCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00006ADF File Offset: 0x00004CDF
		public void SetPosition(int index, Vector3 position)
		{
			this.SetPosition_Injected(index, ref position);
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x000375C4 File Offset: 0x000357C4
		public Vector3 GetPosition(int index)
		{
			Vector3 result;
			this.GetPosition_Injected(index, out result);
			return result;
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x000375DC File Offset: 0x000357DC
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x00006AEA File Offset: 0x00004CEA
		public Vector2 textureScale
		{
			get
			{
				Vector2 result;
				this.get_textureScale_Injected(out result);
				return result;
			}
			set
			{
				this.set_textureScale_Injected(ref value);
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x00006AF4 File Offset: 0x00004CF4
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x00006B06 File Offset: 0x00004D06
		public float shadowBias
		{
			get
			{
				return TrailRenderer.get_shadowBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_shadowBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x00006B19 File Offset: 0x00004D19
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x00006B2B File Offset: 0x00004D2B
		public bool generateLightingData
		{
			get
			{
				return TrailRenderer.get_generateLightingDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_generateLightingDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x00006B3E File Offset: 0x00004D3E
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x00006B50 File Offset: 0x00004D50
		public LineTextureMode textureMode
		{
			get
			{
				return TrailRenderer.get_textureModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_textureModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x00006B63 File Offset: 0x00004D63
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x00006B75 File Offset: 0x00004D75
		public LineAlignment alignment
		{
			get
			{
				return TrailRenderer.get_alignmentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_alignmentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x00006B88 File Offset: 0x00004D88
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x00006B9A File Offset: 0x00004D9A
		public SpriteMaskInteraction maskInteraction
		{
			get
			{
				return TrailRenderer.get_maskInteractionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TrailRenderer.set_maskInteractionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00006BAD File Offset: 0x00004DAD
		public void Clear()
		{
			TrailRenderer.ClearDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00006BBF File Offset: 0x00004DBF
		public void BakeMesh(Mesh mesh, [Optional] bool useTransform)
		{
			this.BakeMesh(mesh, Camera.main, useTransform);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00006BD0 File Offset: 0x00004DD0
		public void BakeMesh(Mesh mesh, Camera camera, [Optional] bool useTransform)
		{
			TrailRenderer.BakeMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), IL2CPP.Il2CppObjectBaseToPtr(camera), useTransform);
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x000375F4 File Offset: 0x000357F4
		// (set) Token: 0x06000A89 RID: 2697 RVA: 0x00006BEF File Offset: 0x00004DEF
		public AnimationCurve widthCurve
		{
			get
			{
				return this.GetWidthCurveCopy();
			}
			set
			{
				this.SetWidthCurve(value);
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x0003760C File Offset: 0x0003580C
		// (set) Token: 0x06000A8B RID: 2699 RVA: 0x00006BFA File Offset: 0x00004DFA
		public Gradient colorGradient
		{
			get
			{
				return this.GetColorGradientCopy();
			}
			set
			{
				this.SetColorGradient(value);
			}
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00037624 File Offset: 0x00035824
		public AnimationCurve GetWidthCurveCopy()
		{
			IntPtr intPtr = TrailRenderer.GetWidthCurveCopyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00006C05 File Offset: 0x00004E05
		public void SetWidthCurve(AnimationCurve curve)
		{
			TrailRenderer.SetWidthCurveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(curve));
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00037650 File Offset: 0x00035850
		public Gradient GetColorGradientCopy()
		{
			IntPtr intPtr = TrailRenderer.GetColorGradientCopyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00006C1D File Offset: 0x00004E1D
		public void SetColorGradient(Gradient curve)
		{
			TrailRenderer.SetColorGradientDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(curve));
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00006C35 File Offset: 0x00004E35
		public int GetPositions([Out] Il2CppStructArray<Vector3> positions)
		{
			return TrailRenderer.GetPositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00006C4D File Offset: 0x00004E4D
		public int GetVisiblePositions([Out] Il2CppStructArray<Vector3> positions)
		{
			return TrailRenderer.GetVisiblePositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00006C65 File Offset: 0x00004E65
		public void SetPositions(Il2CppStructArray<Vector3> positions)
		{
			TrailRenderer.SetPositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00006C7D File Offset: 0x00004E7D
		public void AddPosition(Vector3 position)
		{
			this.AddPosition_Injected(ref position);
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00006C87 File Offset: 0x00004E87
		public void AddPositions(Il2CppStructArray<Vector3> positions)
		{
			TrailRenderer.AddPositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00006C9F File Offset: 0x00004E9F
		public void SetPositions(Unity.Collections.NativeArray<Vector3> positions)
		{
			this.SetPositionsWithNativeContainer((IntPtr)positions.GetUnsafeReadOnlyPtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00006CBD File Offset: 0x00004EBD
		public void SetPositions(Unity.Collections.NativeSlice<Vector3> positions)
		{
			this.SetPositionsWithNativeContainer((IntPtr)positions.GetUnsafeReadOnlyPtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x0003767C File Offset: 0x0003587C
		public int GetPositions([Out] Unity.Collections.NativeArray<Vector3> positions)
		{
			return this.GetPositionsWithNativeContainer((IntPtr)positions.GetUnsafePtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x000376A8 File Offset: 0x000358A8
		public int GetPositions([Out] Unity.Collections.NativeSlice<Vector3> positions)
		{
			return this.GetPositionsWithNativeContainer((IntPtr)positions.GetUnsafePtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x000376D4 File Offset: 0x000358D4
		public int GetVisiblePositions([Out] Unity.Collections.NativeArray<Vector3> positions)
		{
			return this.GetVisiblePositionsWithNativeContainer((IntPtr)positions.GetUnsafePtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00037700 File Offset: 0x00035900
		public int GetVisiblePositions([Out] Unity.Collections.NativeSlice<Vector3> positions)
		{
			return this.GetVisiblePositionsWithNativeContainer((IntPtr)positions.GetUnsafePtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00006CDB File Offset: 0x00004EDB
		public void AddPositions([Out] Unity.Collections.NativeArray<Vector3> positions)
		{
			this.AddPositionsWithNativeContainer((IntPtr)positions.GetUnsafePtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00006CF9 File Offset: 0x00004EF9
		public void AddPositions([Out] Unity.Collections.NativeSlice<Vector3> positions)
		{
			this.AddPositionsWithNativeContainer((IntPtr)positions.GetUnsafePtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x00006D17 File Offset: 0x00004F17
		public void SetPositionsWithNativeContainer(IntPtr positions, int count)
		{
			TrailRenderer.SetPositionsWithNativeContainerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), positions, count);
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00006D2B File Offset: 0x00004F2B
		public int GetPositionsWithNativeContainer(IntPtr positions, int length)
		{
			return TrailRenderer.GetPositionsWithNativeContainerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), positions, length);
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00006D3F File Offset: 0x00004F3F
		public int GetVisiblePositionsWithNativeContainer(IntPtr positions, int length)
		{
			return TrailRenderer.GetVisiblePositionsWithNativeContainerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), positions, length);
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00006D53 File Offset: 0x00004F53
		public void AddPositionsWithNativeContainer(IntPtr positions, int length)
		{
			TrailRenderer.AddPositionsWithNativeContainerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), positions, length);
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00006D67 File Offset: 0x00004F67
		public void get_endColor_Injected(out Color ret)
		{
			TrailRenderer.get_endColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00006D7A File Offset: 0x00004F7A
		public void set_endColor_Injected(ref Color value)
		{
			TrailRenderer.set_endColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00006D8D File Offset: 0x00004F8D
		public void SetPosition_Injected(int index, ref Vector3 position)
		{
			TrailRenderer.SetPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, ref position);
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00006DA1 File Offset: 0x00004FA1
		public void GetPosition_Injected(int index, out Vector3 ret)
		{
			TrailRenderer.GetPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, out ret);
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00006DB5 File Offset: 0x00004FB5
		public void get_textureScale_Injected(out Vector2 ret)
		{
			TrailRenderer.get_textureScale_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00006DC8 File Offset: 0x00004FC8
		public void set_textureScale_Injected(ref Vector2 value)
		{
			TrailRenderer.set_textureScale_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00006DDB File Offset: 0x00004FDB
		public void AddPosition_Injected(ref Vector3 position)
		{
			TrailRenderer.AddPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position);
		}

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeMethodInfoPtr_get_startColor_Public_get_Color_0;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_get_startColor_Injected_Private_Void_byref_Color_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr_set_startColor_Injected_Private_Void_byref_Color_0;

		// Token: 0x04000810 RID: 2064
		private static readonly TrailRenderer.get_timeDelegate get_timeDelegateField;

		// Token: 0x04000811 RID: 2065
		private static readonly TrailRenderer.set_timeDelegate set_timeDelegateField;

		// Token: 0x04000812 RID: 2066
		private static readonly TrailRenderer.get_startWidthDelegate get_startWidthDelegateField;

		// Token: 0x04000813 RID: 2067
		private static readonly TrailRenderer.set_startWidthDelegate set_startWidthDelegateField;

		// Token: 0x04000814 RID: 2068
		private static readonly TrailRenderer.get_endWidthDelegate get_endWidthDelegateField;

		// Token: 0x04000815 RID: 2069
		private static readonly TrailRenderer.set_endWidthDelegate set_endWidthDelegateField;

		// Token: 0x04000816 RID: 2070
		private static readonly TrailRenderer.get_widthMultiplierDelegate get_widthMultiplierDelegateField;

		// Token: 0x04000817 RID: 2071
		private static readonly TrailRenderer.set_widthMultiplierDelegate set_widthMultiplierDelegateField;

		// Token: 0x04000818 RID: 2072
		private static readonly TrailRenderer.get_autodestructDelegate get_autodestructDelegateField;

		// Token: 0x04000819 RID: 2073
		private static readonly TrailRenderer.set_autodestructDelegate set_autodestructDelegateField;

		// Token: 0x0400081A RID: 2074
		private static readonly TrailRenderer.get_emittingDelegate get_emittingDelegateField;

		// Token: 0x0400081B RID: 2075
		private static readonly TrailRenderer.set_emittingDelegate set_emittingDelegateField;

		// Token: 0x0400081C RID: 2076
		private static readonly TrailRenderer.get_numCornerVerticesDelegate get_numCornerVerticesDelegateField;

		// Token: 0x0400081D RID: 2077
		private static readonly TrailRenderer.set_numCornerVerticesDelegate set_numCornerVerticesDelegateField;

		// Token: 0x0400081E RID: 2078
		private static readonly TrailRenderer.get_numCapVerticesDelegate get_numCapVerticesDelegateField;

		// Token: 0x0400081F RID: 2079
		private static readonly TrailRenderer.set_numCapVerticesDelegate set_numCapVerticesDelegateField;

		// Token: 0x04000820 RID: 2080
		private static readonly TrailRenderer.get_minVertexDistanceDelegate get_minVertexDistanceDelegateField;

		// Token: 0x04000821 RID: 2081
		private static readonly TrailRenderer.set_minVertexDistanceDelegate set_minVertexDistanceDelegateField;

		// Token: 0x04000822 RID: 2082
		private static readonly TrailRenderer.get_positionCountDelegate get_positionCountDelegateField;

		// Token: 0x04000823 RID: 2083
		private static readonly TrailRenderer.get_shadowBiasDelegate get_shadowBiasDelegateField;

		// Token: 0x04000824 RID: 2084
		private static readonly TrailRenderer.set_shadowBiasDelegate set_shadowBiasDelegateField;

		// Token: 0x04000825 RID: 2085
		private static readonly TrailRenderer.get_generateLightingDataDelegate get_generateLightingDataDelegateField;

		// Token: 0x04000826 RID: 2086
		private static readonly TrailRenderer.set_generateLightingDataDelegate set_generateLightingDataDelegateField;

		// Token: 0x04000827 RID: 2087
		private static readonly TrailRenderer.get_textureModeDelegate get_textureModeDelegateField;

		// Token: 0x04000828 RID: 2088
		private static readonly TrailRenderer.set_textureModeDelegate set_textureModeDelegateField;

		// Token: 0x04000829 RID: 2089
		private static readonly TrailRenderer.get_alignmentDelegate get_alignmentDelegateField;

		// Token: 0x0400082A RID: 2090
		private static readonly TrailRenderer.set_alignmentDelegate set_alignmentDelegateField;

		// Token: 0x0400082B RID: 2091
		private static readonly TrailRenderer.get_maskInteractionDelegate get_maskInteractionDelegateField;

		// Token: 0x0400082C RID: 2092
		private static readonly TrailRenderer.set_maskInteractionDelegate set_maskInteractionDelegateField;

		// Token: 0x0400082D RID: 2093
		private static readonly TrailRenderer.ClearDelegate ClearDelegateField;

		// Token: 0x0400082E RID: 2094
		private static readonly TrailRenderer.BakeMeshDelegate BakeMeshDelegateField;

		// Token: 0x0400082F RID: 2095
		private static readonly TrailRenderer.GetWidthCurveCopyDelegate GetWidthCurveCopyDelegateField;

		// Token: 0x04000830 RID: 2096
		private static readonly TrailRenderer.SetWidthCurveDelegate SetWidthCurveDelegateField;

		// Token: 0x04000831 RID: 2097
		private static readonly TrailRenderer.GetColorGradientCopyDelegate GetColorGradientCopyDelegateField;

		// Token: 0x04000832 RID: 2098
		private static readonly TrailRenderer.SetColorGradientDelegate SetColorGradientDelegateField;

		// Token: 0x04000833 RID: 2099
		private static readonly TrailRenderer.GetPositionsDelegate GetPositionsDelegateField;

		// Token: 0x04000834 RID: 2100
		private static readonly TrailRenderer.GetVisiblePositionsDelegate GetVisiblePositionsDelegateField;

		// Token: 0x04000835 RID: 2101
		private static readonly TrailRenderer.SetPositionsDelegate SetPositionsDelegateField;

		// Token: 0x04000836 RID: 2102
		private static readonly TrailRenderer.AddPositionsDelegate AddPositionsDelegateField;

		// Token: 0x04000837 RID: 2103
		private static readonly TrailRenderer.SetPositionsWithNativeContainerDelegate SetPositionsWithNativeContainerDelegateField;

		// Token: 0x04000838 RID: 2104
		private static readonly TrailRenderer.GetPositionsWithNativeContainerDelegate GetPositionsWithNativeContainerDelegateField;

		// Token: 0x04000839 RID: 2105
		private static readonly TrailRenderer.GetVisiblePositionsWithNativeContainerDelegate GetVisiblePositionsWithNativeContainerDelegateField;

		// Token: 0x0400083A RID: 2106
		private static readonly TrailRenderer.AddPositionsWithNativeContainerDelegate AddPositionsWithNativeContainerDelegateField;

		// Token: 0x0400083B RID: 2107
		private static readonly TrailRenderer.get_endColor_InjectedDelegate get_endColor_InjectedDelegateField;

		// Token: 0x0400083C RID: 2108
		private static readonly TrailRenderer.set_endColor_InjectedDelegate set_endColor_InjectedDelegateField;

		// Token: 0x0400083D RID: 2109
		private static readonly TrailRenderer.SetPosition_InjectedDelegate SetPosition_InjectedDelegateField;

		// Token: 0x0400083E RID: 2110
		private static readonly TrailRenderer.GetPosition_InjectedDelegate GetPosition_InjectedDelegateField;

		// Token: 0x0400083F RID: 2111
		private static readonly TrailRenderer.get_textureScale_InjectedDelegate get_textureScale_InjectedDelegateField;

		// Token: 0x04000840 RID: 2112
		private static readonly TrailRenderer.set_textureScale_InjectedDelegate set_textureScale_InjectedDelegateField;

		// Token: 0x04000841 RID: 2113
		private static readonly TrailRenderer.AddPosition_InjectedDelegate AddPosition_InjectedDelegateField;

		// Token: 0x020005D0 RID: 1488
		// (Invoke) Token: 0x0600345A RID: 13402
		private delegate float get_timeDelegate(IntPtr @this);

		// Token: 0x020005D1 RID: 1489
		// (Invoke) Token: 0x0600345C RID: 13404
		private delegate void set_timeDelegate(IntPtr @this, float value);

		// Token: 0x020005D2 RID: 1490
		// (Invoke) Token: 0x0600345E RID: 13406
		private delegate float get_startWidthDelegate(IntPtr @this);

		// Token: 0x020005D3 RID: 1491
		// (Invoke) Token: 0x06003460 RID: 13408
		private delegate void set_startWidthDelegate(IntPtr @this, float value);

		// Token: 0x020005D4 RID: 1492
		// (Invoke) Token: 0x06003462 RID: 13410
		private delegate float get_endWidthDelegate(IntPtr @this);

		// Token: 0x020005D5 RID: 1493
		// (Invoke) Token: 0x06003464 RID: 13412
		private delegate void set_endWidthDelegate(IntPtr @this, float value);

		// Token: 0x020005D6 RID: 1494
		// (Invoke) Token: 0x06003466 RID: 13414
		private delegate float get_widthMultiplierDelegate(IntPtr @this);

		// Token: 0x020005D7 RID: 1495
		// (Invoke) Token: 0x06003468 RID: 13416
		private delegate void set_widthMultiplierDelegate(IntPtr @this, float value);

		// Token: 0x020005D8 RID: 1496
		// (Invoke) Token: 0x0600346A RID: 13418
		private delegate bool get_autodestructDelegate(IntPtr @this);

		// Token: 0x020005D9 RID: 1497
		// (Invoke) Token: 0x0600346C RID: 13420
		private delegate void set_autodestructDelegate(IntPtr @this, bool value);

		// Token: 0x020005DA RID: 1498
		// (Invoke) Token: 0x0600346E RID: 13422
		private delegate bool get_emittingDelegate(IntPtr @this);

		// Token: 0x020005DB RID: 1499
		// (Invoke) Token: 0x06003470 RID: 13424
		private delegate void set_emittingDelegate(IntPtr @this, bool value);

		// Token: 0x020005DC RID: 1500
		// (Invoke) Token: 0x06003472 RID: 13426
		private delegate int get_numCornerVerticesDelegate(IntPtr @this);

		// Token: 0x020005DD RID: 1501
		// (Invoke) Token: 0x06003474 RID: 13428
		private delegate void set_numCornerVerticesDelegate(IntPtr @this, int value);

		// Token: 0x020005DE RID: 1502
		// (Invoke) Token: 0x06003476 RID: 13430
		private delegate int get_numCapVerticesDelegate(IntPtr @this);

		// Token: 0x020005DF RID: 1503
		// (Invoke) Token: 0x06003478 RID: 13432
		private delegate void set_numCapVerticesDelegate(IntPtr @this, int value);

		// Token: 0x020005E0 RID: 1504
		// (Invoke) Token: 0x0600347A RID: 13434
		private delegate float get_minVertexDistanceDelegate(IntPtr @this);

		// Token: 0x020005E1 RID: 1505
		// (Invoke) Token: 0x0600347C RID: 13436
		private delegate void set_minVertexDistanceDelegate(IntPtr @this, float value);

		// Token: 0x020005E2 RID: 1506
		// (Invoke) Token: 0x0600347E RID: 13438
		private delegate int get_positionCountDelegate(IntPtr @this);

		// Token: 0x020005E3 RID: 1507
		// (Invoke) Token: 0x06003480 RID: 13440
		private delegate float get_shadowBiasDelegate(IntPtr @this);

		// Token: 0x020005E4 RID: 1508
		// (Invoke) Token: 0x06003482 RID: 13442
		private delegate void set_shadowBiasDelegate(IntPtr @this, float value);

		// Token: 0x020005E5 RID: 1509
		// (Invoke) Token: 0x06003484 RID: 13444
		private delegate bool get_generateLightingDataDelegate(IntPtr @this);

		// Token: 0x020005E6 RID: 1510
		// (Invoke) Token: 0x06003486 RID: 13446
		private delegate void set_generateLightingDataDelegate(IntPtr @this, bool value);

		// Token: 0x020005E7 RID: 1511
		// (Invoke) Token: 0x06003488 RID: 13448
		private delegate LineTextureMode get_textureModeDelegate(IntPtr @this);

		// Token: 0x020005E8 RID: 1512
		// (Invoke) Token: 0x0600348A RID: 13450
		private delegate void set_textureModeDelegate(IntPtr @this, LineTextureMode value);

		// Token: 0x020005E9 RID: 1513
		// (Invoke) Token: 0x0600348C RID: 13452
		private delegate LineAlignment get_alignmentDelegate(IntPtr @this);

		// Token: 0x020005EA RID: 1514
		// (Invoke) Token: 0x0600348E RID: 13454
		private delegate void set_alignmentDelegate(IntPtr @this, LineAlignment value);

		// Token: 0x020005EB RID: 1515
		// (Invoke) Token: 0x06003490 RID: 13456
		private delegate SpriteMaskInteraction get_maskInteractionDelegate(IntPtr @this);

		// Token: 0x020005EC RID: 1516
		// (Invoke) Token: 0x06003492 RID: 13458
		private delegate void set_maskInteractionDelegate(IntPtr @this, SpriteMaskInteraction value);

		// Token: 0x020005ED RID: 1517
		// (Invoke) Token: 0x06003494 RID: 13460
		private delegate void ClearDelegate(IntPtr @this);

		// Token: 0x020005EE RID: 1518
		// (Invoke) Token: 0x06003496 RID: 13462
		private delegate void BakeMeshDelegate(IntPtr @this, IntPtr mesh, IntPtr camera, bool useTransform);

		// Token: 0x020005EF RID: 1519
		// (Invoke) Token: 0x06003498 RID: 13464
		private delegate IntPtr GetWidthCurveCopyDelegate(IntPtr @this);

		// Token: 0x020005F0 RID: 1520
		// (Invoke) Token: 0x0600349A RID: 13466
		private delegate void SetWidthCurveDelegate(IntPtr @this, IntPtr curve);

		// Token: 0x020005F1 RID: 1521
		// (Invoke) Token: 0x0600349C RID: 13468
		private delegate IntPtr GetColorGradientCopyDelegate(IntPtr @this);

		// Token: 0x020005F2 RID: 1522
		// (Invoke) Token: 0x0600349E RID: 13470
		private delegate void SetColorGradientDelegate(IntPtr @this, IntPtr curve);

		// Token: 0x020005F3 RID: 1523
		// (Invoke) Token: 0x060034A0 RID: 13472
		private delegate int GetPositionsDelegate(IntPtr @this, [Out] IntPtr positions);

		// Token: 0x020005F4 RID: 1524
		// (Invoke) Token: 0x060034A2 RID: 13474
		private delegate int GetVisiblePositionsDelegate(IntPtr @this, [Out] IntPtr positions);

		// Token: 0x020005F5 RID: 1525
		// (Invoke) Token: 0x060034A4 RID: 13476
		private delegate void SetPositionsDelegate(IntPtr @this, IntPtr positions);

		// Token: 0x020005F6 RID: 1526
		// (Invoke) Token: 0x060034A6 RID: 13478
		private delegate void AddPositionsDelegate(IntPtr @this, IntPtr positions);

		// Token: 0x020005F7 RID: 1527
		// (Invoke) Token: 0x060034A8 RID: 13480
		private delegate void SetPositionsWithNativeContainerDelegate(IntPtr @this, IntPtr positions, int count);

		// Token: 0x020005F8 RID: 1528
		// (Invoke) Token: 0x060034AA RID: 13482
		private delegate int GetPositionsWithNativeContainerDelegate(IntPtr @this, IntPtr positions, int length);

		// Token: 0x020005F9 RID: 1529
		// (Invoke) Token: 0x060034AC RID: 13484
		private delegate int GetVisiblePositionsWithNativeContainerDelegate(IntPtr @this, IntPtr positions, int length);

		// Token: 0x020005FA RID: 1530
		// (Invoke) Token: 0x060034AE RID: 13486
		private delegate void AddPositionsWithNativeContainerDelegate(IntPtr @this, IntPtr positions, int length);

		// Token: 0x020005FB RID: 1531
		// (Invoke) Token: 0x060034B0 RID: 13488
		private delegate void get_endColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020005FC RID: 1532
		// (Invoke) Token: 0x060034B2 RID: 13490
		private delegate void set_endColor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020005FD RID: 1533
		// (Invoke) Token: 0x060034B4 RID: 13492
		private delegate void SetPosition_InjectedDelegate(IntPtr @this, int index, IntPtr position);

		// Token: 0x020005FE RID: 1534
		// (Invoke) Token: 0x060034B6 RID: 13494
		private delegate void GetPosition_InjectedDelegate(IntPtr @this, int index, [Out] IntPtr ret);

		// Token: 0x020005FF RID: 1535
		// (Invoke) Token: 0x060034B8 RID: 13496
		private delegate void get_textureScale_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000600 RID: 1536
		// (Invoke) Token: 0x060034BA RID: 13498
		private delegate void set_textureScale_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000601 RID: 1537
		// (Invoke) Token: 0x060034BC RID: 13500
		private delegate void AddPosition_InjectedDelegate(IntPtr @this, IntPtr position);
	}
}
