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
	// Token: 0x020000A5 RID: 165
	public sealed class LineRenderer : Renderer
	{
		// Token: 0x06000AA8 RID: 2728 RVA: 0x0003772C File Offset: 0x0003592C
		// Note: this type is marked as 'beforefieldinit'.
		static LineRenderer()
		{
			Il2CppClassPointerStore<LineRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LineRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr);
			LineRenderer.NativeMethodInfoPtr_get_useWorldSpace_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664309);
			LineRenderer.NativeMethodInfoPtr_set_useWorldSpace_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664310);
			LineRenderer.NativeMethodInfoPtr_set_positionCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664311);
			LineRenderer.NativeMethodInfoPtr_SetPosition_Public_Void_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664312);
			LineRenderer.NativeMethodInfoPtr_set_textureMode_Public_set_Void_LineTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664313);
			LineRenderer.NativeMethodInfoPtr_SetPositions_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664314);
			LineRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664315);
			LineRenderer.NativeMethodInfoPtr_SetPosition_Injected_Private_Void_Int32_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664316);
			LineRenderer.get_startWidthDelegateField = IL2CPP.ResolveICall<LineRenderer.get_startWidthDelegate>("UnityEngine.LineRenderer::get_startWidth");
			LineRenderer.set_startWidthDelegateField = IL2CPP.ResolveICall<LineRenderer.set_startWidthDelegate>("UnityEngine.LineRenderer::set_startWidth");
			LineRenderer.get_endWidthDelegateField = IL2CPP.ResolveICall<LineRenderer.get_endWidthDelegate>("UnityEngine.LineRenderer::get_endWidth");
			LineRenderer.set_endWidthDelegateField = IL2CPP.ResolveICall<LineRenderer.set_endWidthDelegate>("UnityEngine.LineRenderer::set_endWidth");
			LineRenderer.get_widthMultiplierDelegateField = IL2CPP.ResolveICall<LineRenderer.get_widthMultiplierDelegate>("UnityEngine.LineRenderer::get_widthMultiplier");
			LineRenderer.set_widthMultiplierDelegateField = IL2CPP.ResolveICall<LineRenderer.set_widthMultiplierDelegate>("UnityEngine.LineRenderer::set_widthMultiplier");
			LineRenderer.get_numCornerVerticesDelegateField = IL2CPP.ResolveICall<LineRenderer.get_numCornerVerticesDelegate>("UnityEngine.LineRenderer::get_numCornerVertices");
			LineRenderer.set_numCornerVerticesDelegateField = IL2CPP.ResolveICall<LineRenderer.set_numCornerVerticesDelegate>("UnityEngine.LineRenderer::set_numCornerVertices");
			LineRenderer.get_numCapVerticesDelegateField = IL2CPP.ResolveICall<LineRenderer.get_numCapVerticesDelegate>("UnityEngine.LineRenderer::get_numCapVertices");
			LineRenderer.set_numCapVerticesDelegateField = IL2CPP.ResolveICall<LineRenderer.set_numCapVerticesDelegate>("UnityEngine.LineRenderer::set_numCapVertices");
			LineRenderer.get_loopDelegateField = IL2CPP.ResolveICall<LineRenderer.get_loopDelegate>("UnityEngine.LineRenderer::get_loop");
			LineRenderer.set_loopDelegateField = IL2CPP.ResolveICall<LineRenderer.set_loopDelegate>("UnityEngine.LineRenderer::set_loop");
			LineRenderer.get_positionCountDelegateField = IL2CPP.ResolveICall<LineRenderer.get_positionCountDelegate>("UnityEngine.LineRenderer::get_positionCount");
			LineRenderer.get_shadowBiasDelegateField = IL2CPP.ResolveICall<LineRenderer.get_shadowBiasDelegate>("UnityEngine.LineRenderer::get_shadowBias");
			LineRenderer.set_shadowBiasDelegateField = IL2CPP.ResolveICall<LineRenderer.set_shadowBiasDelegate>("UnityEngine.LineRenderer::set_shadowBias");
			LineRenderer.get_generateLightingDataDelegateField = IL2CPP.ResolveICall<LineRenderer.get_generateLightingDataDelegate>("UnityEngine.LineRenderer::get_generateLightingData");
			LineRenderer.set_generateLightingDataDelegateField = IL2CPP.ResolveICall<LineRenderer.set_generateLightingDataDelegate>("UnityEngine.LineRenderer::set_generateLightingData");
			LineRenderer.get_textureModeDelegateField = IL2CPP.ResolveICall<LineRenderer.get_textureModeDelegate>("UnityEngine.LineRenderer::get_textureMode");
			LineRenderer.get_alignmentDelegateField = IL2CPP.ResolveICall<LineRenderer.get_alignmentDelegate>("UnityEngine.LineRenderer::get_alignment");
			LineRenderer.set_alignmentDelegateField = IL2CPP.ResolveICall<LineRenderer.set_alignmentDelegate>("UnityEngine.LineRenderer::set_alignment");
			LineRenderer.get_maskInteractionDelegateField = IL2CPP.ResolveICall<LineRenderer.get_maskInteractionDelegate>("UnityEngine.LineRenderer::get_maskInteraction");
			LineRenderer.set_maskInteractionDelegateField = IL2CPP.ResolveICall<LineRenderer.set_maskInteractionDelegate>("UnityEngine.LineRenderer::set_maskInteraction");
			LineRenderer.SimplifyDelegateField = IL2CPP.ResolveICall<LineRenderer.SimplifyDelegate>("UnityEngine.LineRenderer::Simplify");
			LineRenderer.BakeMeshDelegateField = IL2CPP.ResolveICall<LineRenderer.BakeMeshDelegate>("UnityEngine.LineRenderer::BakeMesh");
			LineRenderer.GetWidthCurveCopyDelegateField = IL2CPP.ResolveICall<LineRenderer.GetWidthCurveCopyDelegate>("UnityEngine.LineRenderer::GetWidthCurveCopy");
			LineRenderer.SetWidthCurveDelegateField = IL2CPP.ResolveICall<LineRenderer.SetWidthCurveDelegate>("UnityEngine.LineRenderer::SetWidthCurve");
			LineRenderer.GetColorGradientCopyDelegateField = IL2CPP.ResolveICall<LineRenderer.GetColorGradientCopyDelegate>("UnityEngine.LineRenderer::GetColorGradientCopy");
			LineRenderer.SetColorGradientDelegateField = IL2CPP.ResolveICall<LineRenderer.SetColorGradientDelegate>("UnityEngine.LineRenderer::SetColorGradient");
			LineRenderer.GetPositionsDelegateField = IL2CPP.ResolveICall<LineRenderer.GetPositionsDelegate>("UnityEngine.LineRenderer::GetPositions");
			LineRenderer.SetPositionsWithNativeContainerDelegateField = IL2CPP.ResolveICall<LineRenderer.SetPositionsWithNativeContainerDelegate>("UnityEngine.LineRenderer::SetPositionsWithNativeContainer");
			LineRenderer.GetPositionsWithNativeContainerDelegateField = IL2CPP.ResolveICall<LineRenderer.GetPositionsWithNativeContainerDelegate>("UnityEngine.LineRenderer::GetPositionsWithNativeContainer");
			LineRenderer.get_startColor_InjectedDelegateField = IL2CPP.ResolveICall<LineRenderer.get_startColor_InjectedDelegate>("UnityEngine.LineRenderer::get_startColor_Injected");
			LineRenderer.set_startColor_InjectedDelegateField = IL2CPP.ResolveICall<LineRenderer.set_startColor_InjectedDelegate>("UnityEngine.LineRenderer::set_startColor_Injected");
			LineRenderer.get_endColor_InjectedDelegateField = IL2CPP.ResolveICall<LineRenderer.get_endColor_InjectedDelegate>("UnityEngine.LineRenderer::get_endColor_Injected");
			LineRenderer.set_endColor_InjectedDelegateField = IL2CPP.ResolveICall<LineRenderer.set_endColor_InjectedDelegate>("UnityEngine.LineRenderer::set_endColor_Injected");
			LineRenderer.GetPosition_InjectedDelegateField = IL2CPP.ResolveICall<LineRenderer.GetPosition_InjectedDelegate>("UnityEngine.LineRenderer::GetPosition_Injected");
			LineRenderer.get_textureScale_InjectedDelegateField = IL2CPP.ResolveICall<LineRenderer.get_textureScale_InjectedDelegate>("UnityEngine.LineRenderer::get_textureScale_Injected");
			LineRenderer.set_textureScale_InjectedDelegateField = IL2CPP.ResolveICall<LineRenderer.set_textureScale_InjectedDelegate>("UnityEngine.LineRenderer::set_textureScale_Injected");
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x00037A38 File Offset: 0x00035C38
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x00037A74 File Offset: 0x00035C74
		public unsafe bool useWorldSpace
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1234638, RefRangeEnd = 1234639, XrefRangeStart = 1234636, XrefRangeEnd = 1234638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_useWorldSpace_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1234641, RefRangeEnd = 1234644, XrefRangeStart = 1234639, XrefRangeEnd = 1234641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_useWorldSpace_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x00006F25 File Offset: 0x00005125
		// (set) Token: 0x06000AAB RID: 2731 RVA: 0x00037AB4 File Offset: 0x00035CB4
		public unsafe int positionCount
		{
			get
			{
				return LineRenderer.get_positionCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1234646, RefRangeEnd = 1234649, XrefRangeStart = 1234644, XrefRangeEnd = 1234646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_positionCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00037AF4 File Offset: 0x00035CF4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1234651, RefRangeEnd = 1234655, XrefRangeStart = 1234649, XrefRangeEnd = 1234651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition(int index, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_SetPosition_Public_Void_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x00006F8B File Offset: 0x0000518B
		// (set) Token: 0x06000AAD RID: 2733 RVA: 0x00037B40 File Offset: 0x00035D40
		public unsafe LineTextureMode textureMode
		{
			get
			{
				return LineRenderer.get_textureModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1234657, RefRangeEnd = 1234658, XrefRangeStart = 1234655, XrefRangeEnd = 1234657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_textureMode_Public_set_Void_LineTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00037B80 File Offset: 0x00035D80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1234660, RefRangeEnd = 1234662, XrefRangeStart = 1234658, XrefRangeEnd = 1234660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPositions(Il2CppStructArray<Vector3> positions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(positions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_SetPositions_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00037BC4 File Offset: 0x00035DC4
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LineRenderer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00037C00 File Offset: 0x00035E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234662, XrefRangeEnd = 1234664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition_Injected(int index, ref Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_SetPosition_Injected_Private_Void_Int32_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00006DEE File Offset: 0x00004FEE
		public LineRenderer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00006DF7 File Offset: 0x00004FF7
		public void SetWidth(float start, float end)
		{
			this.startWidth = start;
			this.endWidth = end;
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00006E0A File Offset: 0x0000500A
		public void SetColors(Color start, Color end)
		{
			this.startColor = start;
			this.endColor = end;
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00006E1D File Offset: 0x0000501D
		public void SetVertexCount(int count)
		{
			this.positionCount = count;
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x00037C4C File Offset: 0x00035E4C
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x00006E28 File Offset: 0x00005028
		public int numPositions
		{
			get
			{
				return this.positionCount;
			}
			set
			{
				this.positionCount = value;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x00006E33 File Offset: 0x00005033
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x00006E45 File Offset: 0x00005045
		public float startWidth
		{
			get
			{
				return LineRenderer.get_startWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_startWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x00006E58 File Offset: 0x00005058
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x00006E6A File Offset: 0x0000506A
		public float endWidth
		{
			get
			{
				return LineRenderer.get_endWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_endWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x00006E7D File Offset: 0x0000507D
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x00006E8F File Offset: 0x0000508F
		public float widthMultiplier
		{
			get
			{
				return LineRenderer.get_widthMultiplierDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_widthMultiplierDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x00006EA2 File Offset: 0x000050A2
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x00006EB4 File Offset: 0x000050B4
		public int numCornerVertices
		{
			get
			{
				return LineRenderer.get_numCornerVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_numCornerVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x00006EC7 File Offset: 0x000050C7
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x00006ED9 File Offset: 0x000050D9
		public int numCapVertices
		{
			get
			{
				return LineRenderer.get_numCapVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_numCapVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x00006EEC File Offset: 0x000050EC
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x00006EFE File Offset: 0x000050FE
		public bool loop
		{
			get
			{
				return LineRenderer.get_loopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_loopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00037C64 File Offset: 0x00035E64
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x00006F11 File Offset: 0x00005111
		public Color startColor
		{
			get
			{
				Color result;
				this.get_startColor_Injected(out result);
				return result;
			}
			set
			{
				this.set_startColor_Injected(ref value);
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x00037C7C File Offset: 0x00035E7C
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x00006F1B File Offset: 0x0000511B
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

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00037C94 File Offset: 0x00035E94
		public Vector3 GetPosition(int index)
		{
			Vector3 result;
			this.GetPosition_Injected(index, out result);
			return result;
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x00037CAC File Offset: 0x00035EAC
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x00006F37 File Offset: 0x00005137
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

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x00006F41 File Offset: 0x00005141
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x00006F53 File Offset: 0x00005153
		public float shadowBias
		{
			get
			{
				return LineRenderer.get_shadowBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_shadowBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x00006F66 File Offset: 0x00005166
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x00006F78 File Offset: 0x00005178
		public bool generateLightingData
		{
			get
			{
				return LineRenderer.get_generateLightingDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_generateLightingDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x00006F9D File Offset: 0x0000519D
		// (set) Token: 0x06000AD1 RID: 2769 RVA: 0x00006FAF File Offset: 0x000051AF
		public LineAlignment alignment
		{
			get
			{
				return LineRenderer.get_alignmentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_alignmentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x00006FC2 File Offset: 0x000051C2
		// (set) Token: 0x06000AD3 RID: 2771 RVA: 0x00006FD4 File Offset: 0x000051D4
		public SpriteMaskInteraction maskInteraction
		{
			get
			{
				return LineRenderer.get_maskInteractionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LineRenderer.set_maskInteractionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00006FE7 File Offset: 0x000051E7
		public void Simplify(float tolerance)
		{
			LineRenderer.SimplifyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), tolerance);
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x00006FFA File Offset: 0x000051FA
		public void BakeMesh(Mesh mesh, [Optional] bool useTransform)
		{
			this.BakeMesh(mesh, Camera.main, useTransform);
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0000700B File Offset: 0x0000520B
		public void BakeMesh(Mesh mesh, Camera camera, [Optional] bool useTransform)
		{
			LineRenderer.BakeMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), IL2CPP.Il2CppObjectBaseToPtr(camera), useTransform);
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x00037CC4 File Offset: 0x00035EC4
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x0000702A File Offset: 0x0000522A
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

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x00037CDC File Offset: 0x00035EDC
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x00007035 File Offset: 0x00005235
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

		// Token: 0x06000ADB RID: 2779 RVA: 0x00037CF4 File Offset: 0x00035EF4
		public AnimationCurve GetWidthCurveCopy()
		{
			IntPtr intPtr = LineRenderer.GetWidthCurveCopyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00007040 File Offset: 0x00005240
		public void SetWidthCurve(AnimationCurve curve)
		{
			LineRenderer.SetWidthCurveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(curve));
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00037D20 File Offset: 0x00035F20
		public Gradient GetColorGradientCopy()
		{
			IntPtr intPtr = LineRenderer.GetColorGradientCopyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00007058 File Offset: 0x00005258
		public void SetColorGradient(Gradient curve)
		{
			LineRenderer.SetColorGradientDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(curve));
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00007070 File Offset: 0x00005270
		public int GetPositions([Out] Il2CppStructArray<Vector3> positions)
		{
			return LineRenderer.GetPositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x00007088 File Offset: 0x00005288
		public void SetPositions(Unity.Collections.NativeArray<Vector3> positions)
		{
			this.SetPositionsWithNativeContainer((IntPtr)positions.GetUnsafeReadOnlyPtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x000070A6 File Offset: 0x000052A6
		public void SetPositions(Unity.Collections.NativeSlice<Vector3> positions)
		{
			this.SetPositionsWithNativeContainer((IntPtr)positions.GetUnsafeReadOnlyPtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00037D4C File Offset: 0x00035F4C
		public int GetPositions([Out] Unity.Collections.NativeArray<Vector3> positions)
		{
			return this.GetPositionsWithNativeContainer((IntPtr)positions.GetUnsafePtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00037D78 File Offset: 0x00035F78
		public int GetPositions([Out] Unity.Collections.NativeSlice<Vector3> positions)
		{
			return this.GetPositionsWithNativeContainer((IntPtr)positions.GetUnsafePtr<Vector3>(), positions.Length);
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x000070C4 File Offset: 0x000052C4
		public void SetPositionsWithNativeContainer(IntPtr positions, int count)
		{
			LineRenderer.SetPositionsWithNativeContainerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), positions, count);
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x000070D8 File Offset: 0x000052D8
		public int GetPositionsWithNativeContainer(IntPtr positions, int length)
		{
			return LineRenderer.GetPositionsWithNativeContainerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), positions, length);
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x000070EC File Offset: 0x000052EC
		public void get_startColor_Injected(out Color ret)
		{
			LineRenderer.get_startColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x000070FF File Offset: 0x000052FF
		public void set_startColor_Injected(ref Color value)
		{
			LineRenderer.set_startColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00007112 File Offset: 0x00005312
		public void get_endColor_Injected(out Color ret)
		{
			LineRenderer.get_endColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00007125 File Offset: 0x00005325
		public void set_endColor_Injected(ref Color value)
		{
			LineRenderer.set_endColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00007138 File Offset: 0x00005338
		public void GetPosition_Injected(int index, out Vector3 ret)
		{
			LineRenderer.GetPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, out ret);
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0000714C File Offset: 0x0000534C
		public void get_textureScale_Injected(out Vector2 ret)
		{
			LineRenderer.get_textureScale_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x0000715F File Offset: 0x0000535F
		public void set_textureScale_Injected(ref Vector2 value)
		{
			LineRenderer.set_textureScale_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeMethodInfoPtr_get_useWorldSpace_Public_get_Boolean_0;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeMethodInfoPtr_set_useWorldSpace_Public_set_Void_Boolean_0;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeMethodInfoPtr_set_positionCount_Public_set_Void_Int32_0;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Int32_Vector3_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr_set_textureMode_Public_set_Void_LineTextureMode_0;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr_SetPositions_Public_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Injected_Private_Void_Int32_byref_Vector3_0;

		// Token: 0x0400084A RID: 2122
		private static readonly LineRenderer.get_startWidthDelegate get_startWidthDelegateField;

		// Token: 0x0400084B RID: 2123
		private static readonly LineRenderer.set_startWidthDelegate set_startWidthDelegateField;

		// Token: 0x0400084C RID: 2124
		private static readonly LineRenderer.get_endWidthDelegate get_endWidthDelegateField;

		// Token: 0x0400084D RID: 2125
		private static readonly LineRenderer.set_endWidthDelegate set_endWidthDelegateField;

		// Token: 0x0400084E RID: 2126
		private static readonly LineRenderer.get_widthMultiplierDelegate get_widthMultiplierDelegateField;

		// Token: 0x0400084F RID: 2127
		private static readonly LineRenderer.set_widthMultiplierDelegate set_widthMultiplierDelegateField;

		// Token: 0x04000850 RID: 2128
		private static readonly LineRenderer.get_numCornerVerticesDelegate get_numCornerVerticesDelegateField;

		// Token: 0x04000851 RID: 2129
		private static readonly LineRenderer.set_numCornerVerticesDelegate set_numCornerVerticesDelegateField;

		// Token: 0x04000852 RID: 2130
		private static readonly LineRenderer.get_numCapVerticesDelegate get_numCapVerticesDelegateField;

		// Token: 0x04000853 RID: 2131
		private static readonly LineRenderer.set_numCapVerticesDelegate set_numCapVerticesDelegateField;

		// Token: 0x04000854 RID: 2132
		private static readonly LineRenderer.get_loopDelegate get_loopDelegateField;

		// Token: 0x04000855 RID: 2133
		private static readonly LineRenderer.set_loopDelegate set_loopDelegateField;

		// Token: 0x04000856 RID: 2134
		private static readonly LineRenderer.get_positionCountDelegate get_positionCountDelegateField;

		// Token: 0x04000857 RID: 2135
		private static readonly LineRenderer.get_shadowBiasDelegate get_shadowBiasDelegateField;

		// Token: 0x04000858 RID: 2136
		private static readonly LineRenderer.set_shadowBiasDelegate set_shadowBiasDelegateField;

		// Token: 0x04000859 RID: 2137
		private static readonly LineRenderer.get_generateLightingDataDelegate get_generateLightingDataDelegateField;

		// Token: 0x0400085A RID: 2138
		private static readonly LineRenderer.set_generateLightingDataDelegate set_generateLightingDataDelegateField;

		// Token: 0x0400085B RID: 2139
		private static readonly LineRenderer.get_textureModeDelegate get_textureModeDelegateField;

		// Token: 0x0400085C RID: 2140
		private static readonly LineRenderer.get_alignmentDelegate get_alignmentDelegateField;

		// Token: 0x0400085D RID: 2141
		private static readonly LineRenderer.set_alignmentDelegate set_alignmentDelegateField;

		// Token: 0x0400085E RID: 2142
		private static readonly LineRenderer.get_maskInteractionDelegate get_maskInteractionDelegateField;

		// Token: 0x0400085F RID: 2143
		private static readonly LineRenderer.set_maskInteractionDelegate set_maskInteractionDelegateField;

		// Token: 0x04000860 RID: 2144
		private static readonly LineRenderer.SimplifyDelegate SimplifyDelegateField;

		// Token: 0x04000861 RID: 2145
		private static readonly LineRenderer.BakeMeshDelegate BakeMeshDelegateField;

		// Token: 0x04000862 RID: 2146
		private static readonly LineRenderer.GetWidthCurveCopyDelegate GetWidthCurveCopyDelegateField;

		// Token: 0x04000863 RID: 2147
		private static readonly LineRenderer.SetWidthCurveDelegate SetWidthCurveDelegateField;

		// Token: 0x04000864 RID: 2148
		private static readonly LineRenderer.GetColorGradientCopyDelegate GetColorGradientCopyDelegateField;

		// Token: 0x04000865 RID: 2149
		private static readonly LineRenderer.SetColorGradientDelegate SetColorGradientDelegateField;

		// Token: 0x04000866 RID: 2150
		private static readonly LineRenderer.GetPositionsDelegate GetPositionsDelegateField;

		// Token: 0x04000867 RID: 2151
		private static readonly LineRenderer.SetPositionsWithNativeContainerDelegate SetPositionsWithNativeContainerDelegateField;

		// Token: 0x04000868 RID: 2152
		private static readonly LineRenderer.GetPositionsWithNativeContainerDelegate GetPositionsWithNativeContainerDelegateField;

		// Token: 0x04000869 RID: 2153
		private static readonly LineRenderer.get_startColor_InjectedDelegate get_startColor_InjectedDelegateField;

		// Token: 0x0400086A RID: 2154
		private static readonly LineRenderer.set_startColor_InjectedDelegate set_startColor_InjectedDelegateField;

		// Token: 0x0400086B RID: 2155
		private static readonly LineRenderer.get_endColor_InjectedDelegate get_endColor_InjectedDelegateField;

		// Token: 0x0400086C RID: 2156
		private static readonly LineRenderer.set_endColor_InjectedDelegate set_endColor_InjectedDelegateField;

		// Token: 0x0400086D RID: 2157
		private static readonly LineRenderer.GetPosition_InjectedDelegate GetPosition_InjectedDelegateField;

		// Token: 0x0400086E RID: 2158
		private static readonly LineRenderer.get_textureScale_InjectedDelegate get_textureScale_InjectedDelegateField;

		// Token: 0x0400086F RID: 2159
		private static readonly LineRenderer.set_textureScale_InjectedDelegate set_textureScale_InjectedDelegateField;

		// Token: 0x02000602 RID: 1538
		// (Invoke) Token: 0x060034BE RID: 13502
		private delegate float get_startWidthDelegate(IntPtr @this);

		// Token: 0x02000603 RID: 1539
		// (Invoke) Token: 0x060034C0 RID: 13504
		private delegate void set_startWidthDelegate(IntPtr @this, float value);

		// Token: 0x02000604 RID: 1540
		// (Invoke) Token: 0x060034C2 RID: 13506
		private delegate float get_endWidthDelegate(IntPtr @this);

		// Token: 0x02000605 RID: 1541
		// (Invoke) Token: 0x060034C4 RID: 13508
		private delegate void set_endWidthDelegate(IntPtr @this, float value);

		// Token: 0x02000606 RID: 1542
		// (Invoke) Token: 0x060034C6 RID: 13510
		private delegate float get_widthMultiplierDelegate(IntPtr @this);

		// Token: 0x02000607 RID: 1543
		// (Invoke) Token: 0x060034C8 RID: 13512
		private delegate void set_widthMultiplierDelegate(IntPtr @this, float value);

		// Token: 0x02000608 RID: 1544
		// (Invoke) Token: 0x060034CA RID: 13514
		private delegate int get_numCornerVerticesDelegate(IntPtr @this);

		// Token: 0x02000609 RID: 1545
		// (Invoke) Token: 0x060034CC RID: 13516
		private delegate void set_numCornerVerticesDelegate(IntPtr @this, int value);

		// Token: 0x0200060A RID: 1546
		// (Invoke) Token: 0x060034CE RID: 13518
		private delegate int get_numCapVerticesDelegate(IntPtr @this);

		// Token: 0x0200060B RID: 1547
		// (Invoke) Token: 0x060034D0 RID: 13520
		private delegate void set_numCapVerticesDelegate(IntPtr @this, int value);

		// Token: 0x0200060C RID: 1548
		// (Invoke) Token: 0x060034D2 RID: 13522
		private delegate bool get_loopDelegate(IntPtr @this);

		// Token: 0x0200060D RID: 1549
		// (Invoke) Token: 0x060034D4 RID: 13524
		private delegate void set_loopDelegate(IntPtr @this, bool value);

		// Token: 0x0200060E RID: 1550
		// (Invoke) Token: 0x060034D6 RID: 13526
		private delegate int get_positionCountDelegate(IntPtr @this);

		// Token: 0x0200060F RID: 1551
		// (Invoke) Token: 0x060034D8 RID: 13528
		private delegate float get_shadowBiasDelegate(IntPtr @this);

		// Token: 0x02000610 RID: 1552
		// (Invoke) Token: 0x060034DA RID: 13530
		private delegate void set_shadowBiasDelegate(IntPtr @this, float value);

		// Token: 0x02000611 RID: 1553
		// (Invoke) Token: 0x060034DC RID: 13532
		private delegate bool get_generateLightingDataDelegate(IntPtr @this);

		// Token: 0x02000612 RID: 1554
		// (Invoke) Token: 0x060034DE RID: 13534
		private delegate void set_generateLightingDataDelegate(IntPtr @this, bool value);

		// Token: 0x02000613 RID: 1555
		// (Invoke) Token: 0x060034E0 RID: 13536
		private delegate LineTextureMode get_textureModeDelegate(IntPtr @this);

		// Token: 0x02000614 RID: 1556
		// (Invoke) Token: 0x060034E2 RID: 13538
		private delegate LineAlignment get_alignmentDelegate(IntPtr @this);

		// Token: 0x02000615 RID: 1557
		// (Invoke) Token: 0x060034E4 RID: 13540
		private delegate void set_alignmentDelegate(IntPtr @this, LineAlignment value);

		// Token: 0x02000616 RID: 1558
		// (Invoke) Token: 0x060034E6 RID: 13542
		private delegate SpriteMaskInteraction get_maskInteractionDelegate(IntPtr @this);

		// Token: 0x02000617 RID: 1559
		// (Invoke) Token: 0x060034E8 RID: 13544
		private delegate void set_maskInteractionDelegate(IntPtr @this, SpriteMaskInteraction value);

		// Token: 0x02000618 RID: 1560
		// (Invoke) Token: 0x060034EA RID: 13546
		private delegate void SimplifyDelegate(IntPtr @this, float tolerance);

		// Token: 0x02000619 RID: 1561
		// (Invoke) Token: 0x060034EC RID: 13548
		private delegate void BakeMeshDelegate(IntPtr @this, IntPtr mesh, IntPtr camera, bool useTransform);

		// Token: 0x0200061A RID: 1562
		// (Invoke) Token: 0x060034EE RID: 13550
		private delegate IntPtr GetWidthCurveCopyDelegate(IntPtr @this);

		// Token: 0x0200061B RID: 1563
		// (Invoke) Token: 0x060034F0 RID: 13552
		private delegate void SetWidthCurveDelegate(IntPtr @this, IntPtr curve);

		// Token: 0x0200061C RID: 1564
		// (Invoke) Token: 0x060034F2 RID: 13554
		private delegate IntPtr GetColorGradientCopyDelegate(IntPtr @this);

		// Token: 0x0200061D RID: 1565
		// (Invoke) Token: 0x060034F4 RID: 13556
		private delegate void SetColorGradientDelegate(IntPtr @this, IntPtr curve);

		// Token: 0x0200061E RID: 1566
		// (Invoke) Token: 0x060034F6 RID: 13558
		private delegate int GetPositionsDelegate(IntPtr @this, [Out] IntPtr positions);

		// Token: 0x0200061F RID: 1567
		// (Invoke) Token: 0x060034F8 RID: 13560
		private delegate void SetPositionsWithNativeContainerDelegate(IntPtr @this, IntPtr positions, int count);

		// Token: 0x02000620 RID: 1568
		// (Invoke) Token: 0x060034FA RID: 13562
		private delegate int GetPositionsWithNativeContainerDelegate(IntPtr @this, IntPtr positions, int length);

		// Token: 0x02000621 RID: 1569
		// (Invoke) Token: 0x060034FC RID: 13564
		private delegate void get_startColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000622 RID: 1570
		// (Invoke) Token: 0x060034FE RID: 13566
		private delegate void set_startColor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000623 RID: 1571
		// (Invoke) Token: 0x06003500 RID: 13568
		private delegate void get_endColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000624 RID: 1572
		// (Invoke) Token: 0x06003502 RID: 13570
		private delegate void set_endColor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000625 RID: 1573
		// (Invoke) Token: 0x06003504 RID: 13572
		private delegate void GetPosition_InjectedDelegate(IntPtr @this, int index, [Out] IntPtr ret);

		// Token: 0x02000626 RID: 1574
		// (Invoke) Token: 0x06003506 RID: 13574
		private delegate void get_textureScale_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000627 RID: 1575
		// (Invoke) Token: 0x06003508 RID: 13576
		private delegate void set_textureScale_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
