using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000D4 RID: 212
	public class SkinnedMeshRenderer : Renderer
	{
		// Token: 0x06000EB4 RID: 3764 RVA: 0x0004211C File Offset: 0x0004031C
		// Note: this type is marked as 'beforefieldinit'.
		static SkinnedMeshRenderer()
		{
			Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SkinnedMeshRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr);
			SkinnedMeshRenderer.NativeMethodInfoPtr_set_updateWhenOffscreen_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100664614);
			SkinnedMeshRenderer.NativeMethodInfoPtr_get_bones_Public_get_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100664615);
			SkinnedMeshRenderer.NativeMethodInfoPtr_set_bones_Public_set_Void_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100664616);
			SkinnedMeshRenderer.NativeMethodInfoPtr_get_sharedMesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100664617);
			SkinnedMeshRenderer.NativeMethodInfoPtr_SetBlendShapeWeight_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100664618);
			SkinnedMeshRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100664619);
			SkinnedMeshRenderer.get_qualityDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.get_qualityDelegate>("UnityEngine.SkinnedMeshRenderer::get_quality");
			SkinnedMeshRenderer.set_qualityDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.set_qualityDelegate>("UnityEngine.SkinnedMeshRenderer::set_quality");
			SkinnedMeshRenderer.get_updateWhenOffscreenDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.get_updateWhenOffscreenDelegate>("UnityEngine.SkinnedMeshRenderer::get_updateWhenOffscreen");
			SkinnedMeshRenderer.get_forceMatrixRecalculationPerRenderDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.get_forceMatrixRecalculationPerRenderDelegate>("UnityEngine.SkinnedMeshRenderer::get_forceMatrixRecalculationPerRender");
			SkinnedMeshRenderer.set_forceMatrixRecalculationPerRenderDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.set_forceMatrixRecalculationPerRenderDelegate>("UnityEngine.SkinnedMeshRenderer::set_forceMatrixRecalculationPerRender");
			SkinnedMeshRenderer.get_rootBoneDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.get_rootBoneDelegate>("UnityEngine.SkinnedMeshRenderer::get_rootBone");
			SkinnedMeshRenderer.set_rootBoneDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.set_rootBoneDelegate>("UnityEngine.SkinnedMeshRenderer::set_rootBone");
			SkinnedMeshRenderer.set_sharedMeshDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.set_sharedMeshDelegate>("UnityEngine.SkinnedMeshRenderer::set_sharedMesh");
			SkinnedMeshRenderer.get_skinnedMotionVectorsDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.get_skinnedMotionVectorsDelegate>("UnityEngine.SkinnedMeshRenderer::get_skinnedMotionVectors");
			SkinnedMeshRenderer.set_skinnedMotionVectorsDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.set_skinnedMotionVectorsDelegate>("UnityEngine.SkinnedMeshRenderer::set_skinnedMotionVectors");
			SkinnedMeshRenderer.GetBlendShapeWeightDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.GetBlendShapeWeightDelegate>("UnityEngine.SkinnedMeshRenderer::GetBlendShapeWeight");
			SkinnedMeshRenderer.BakeMeshDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.BakeMeshDelegate>("UnityEngine.SkinnedMeshRenderer::BakeMesh");
			SkinnedMeshRenderer.GetVertexBufferImplDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.GetVertexBufferImplDelegate>("UnityEngine.SkinnedMeshRenderer::GetVertexBufferImpl");
			SkinnedMeshRenderer.GetPreviousVertexBufferImplDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.GetPreviousVertexBufferImplDelegate>("UnityEngine.SkinnedMeshRenderer::GetPreviousVertexBufferImpl");
			SkinnedMeshRenderer.get_vertexBufferTargetDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.get_vertexBufferTargetDelegate>("UnityEngine.SkinnedMeshRenderer::get_vertexBufferTarget");
			SkinnedMeshRenderer.set_vertexBufferTargetDelegateField = IL2CPP.ResolveICall<SkinnedMeshRenderer.set_vertexBufferTargetDelegate>("UnityEngine.SkinnedMeshRenderer::set_vertexBufferTarget");
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x00008EDF File Offset: 0x000070DF
		// (set) Token: 0x06000EB5 RID: 3765 RVA: 0x000422B4 File Offset: 0x000404B4
		public unsafe bool updateWhenOffscreen
		{
			get
			{
				return SkinnedMeshRenderer.get_updateWhenOffscreenDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1238209, RefRangeEnd = 1238211, XrefRangeStart = 1238207, XrefRangeEnd = 1238209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_updateWhenOffscreen_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x000422F4 File Offset: 0x000404F4
		// (set) Token: 0x06000EB7 RID: 3767 RVA: 0x00042334 File Offset: 0x00040534
		public unsafe Il2CppReferenceArray<Transform> bones
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1238213, RefRangeEnd = 1238214, XrefRangeStart = 1238211, XrefRangeEnd = 1238213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_bones_Public_get_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1238216, RefRangeEnd = 1238217, XrefRangeStart = 1238214, XrefRangeEnd = 1238216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_bones_Public_set_Void_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x00042378 File Offset: 0x00040578
		// (set) Token: 0x06000EC3 RID: 3779 RVA: 0x00008F2E File Offset: 0x0000712E
		public unsafe Mesh sharedMesh
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1238219, RefRangeEnd = 1238224, XrefRangeStart = 1238217, XrefRangeEnd = 1238219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_sharedMesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
			set
			{
				SkinnedMeshRenderer.set_sharedMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x000423B8 File Offset: 0x000405B8
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1238226, RefRangeEnd = 1238247, XrefRangeStart = 1238224, XrefRangeEnd = 1238226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBlendShapeWeight(int index, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_SetBlendShapeWeight_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00042404 File Offset: 0x00040604
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkinnedMeshRenderer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00008EB1 File Offset: 0x000070B1
		public SkinnedMeshRenderer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x00008EBA File Offset: 0x000070BA
		// (set) Token: 0x06000EBD RID: 3773 RVA: 0x00008ECC File Offset: 0x000070CC
		public SkinQuality quality
		{
			get
			{
				return SkinnedMeshRenderer.get_qualityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SkinnedMeshRenderer.set_qualityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x00008EF1 File Offset: 0x000070F1
		// (set) Token: 0x06000EC0 RID: 3776 RVA: 0x00008F03 File Offset: 0x00007103
		public bool forceMatrixRecalculationPerRender
		{
			get
			{
				return SkinnedMeshRenderer.get_forceMatrixRecalculationPerRenderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SkinnedMeshRenderer.set_forceMatrixRecalculationPerRenderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x00042440 File Offset: 0x00040640
		// (set) Token: 0x06000EC2 RID: 3778 RVA: 0x00008F16 File Offset: 0x00007116
		public Transform rootBone
		{
			get
			{
				IntPtr intPtr = SkinnedMeshRenderer.get_rootBoneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				SkinnedMeshRenderer.set_rootBoneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x00008F46 File Offset: 0x00007146
		// (set) Token: 0x06000EC5 RID: 3781 RVA: 0x00008F58 File Offset: 0x00007158
		public bool skinnedMotionVectors
		{
			get
			{
				return SkinnedMeshRenderer.get_skinnedMotionVectorsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SkinnedMeshRenderer.set_skinnedMotionVectorsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x00008F6B File Offset: 0x0000716B
		public float GetBlendShapeWeight(int index)
		{
			return SkinnedMeshRenderer.GetBlendShapeWeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00008F7E File Offset: 0x0000717E
		public void BakeMesh(Mesh mesh)
		{
			this.BakeMesh(mesh, false);
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x00008F8A File Offset: 0x0000718A
		public void BakeMesh(Mesh mesh, bool useScale)
		{
			SkinnedMeshRenderer.BakeMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), useScale);
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x0004246C File Offset: 0x0004066C
		public GraphicsBuffer GetVertexBuffer()
		{
			bool flag = this == null;
			if (flag)
			{
				throw new NullReferenceException();
			}
			return this.GetVertexBufferImpl();
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x00042498 File Offset: 0x00040698
		public GraphicsBuffer GetPreviousVertexBuffer()
		{
			bool flag = this == null;
			if (flag)
			{
				throw new NullReferenceException();
			}
			return this.GetPreviousVertexBufferImpl();
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x000424C4 File Offset: 0x000406C4
		public GraphicsBuffer GetVertexBufferImpl()
		{
			IntPtr intPtr = SkinnedMeshRenderer.GetVertexBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr2) : null;
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x000424F0 File Offset: 0x000406F0
		public GraphicsBuffer GetPreviousVertexBufferImpl()
		{
			IntPtr intPtr = SkinnedMeshRenderer.GetPreviousVertexBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr2) : null;
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x00008FA3 File Offset: 0x000071A3
		// (set) Token: 0x06000ECE RID: 3790 RVA: 0x00008FB5 File Offset: 0x000071B5
		public GraphicsBuffer.Target vertexBufferTarget
		{
			get
			{
				return SkinnedMeshRenderer.get_vertexBufferTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SkinnedMeshRenderer.set_vertexBufferTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000BE5 RID: 3045
		private static readonly IntPtr NativeMethodInfoPtr_set_updateWhenOffscreen_Public_set_Void_Boolean_0;

		// Token: 0x04000BE6 RID: 3046
		private static readonly IntPtr NativeMethodInfoPtr_get_bones_Public_get_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeMethodInfoPtr_set_bones_Public_set_Void_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04000BE8 RID: 3048
		private static readonly IntPtr NativeMethodInfoPtr_get_sharedMesh_Public_get_Mesh_0;

		// Token: 0x04000BE9 RID: 3049
		private static readonly IntPtr NativeMethodInfoPtr_SetBlendShapeWeight_Public_Void_Int32_Single_0;

		// Token: 0x04000BEA RID: 3050
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BEB RID: 3051
		private static readonly SkinnedMeshRenderer.get_qualityDelegate get_qualityDelegateField;

		// Token: 0x04000BEC RID: 3052
		private static readonly SkinnedMeshRenderer.set_qualityDelegate set_qualityDelegateField;

		// Token: 0x04000BED RID: 3053
		private static readonly SkinnedMeshRenderer.get_updateWhenOffscreenDelegate get_updateWhenOffscreenDelegateField;

		// Token: 0x04000BEE RID: 3054
		private static readonly SkinnedMeshRenderer.get_forceMatrixRecalculationPerRenderDelegate get_forceMatrixRecalculationPerRenderDelegateField;

		// Token: 0x04000BEF RID: 3055
		private static readonly SkinnedMeshRenderer.set_forceMatrixRecalculationPerRenderDelegate set_forceMatrixRecalculationPerRenderDelegateField;

		// Token: 0x04000BF0 RID: 3056
		private static readonly SkinnedMeshRenderer.get_rootBoneDelegate get_rootBoneDelegateField;

		// Token: 0x04000BF1 RID: 3057
		private static readonly SkinnedMeshRenderer.set_rootBoneDelegate set_rootBoneDelegateField;

		// Token: 0x04000BF2 RID: 3058
		private static readonly SkinnedMeshRenderer.set_sharedMeshDelegate set_sharedMeshDelegateField;

		// Token: 0x04000BF3 RID: 3059
		private static readonly SkinnedMeshRenderer.get_skinnedMotionVectorsDelegate get_skinnedMotionVectorsDelegateField;

		// Token: 0x04000BF4 RID: 3060
		private static readonly SkinnedMeshRenderer.set_skinnedMotionVectorsDelegate set_skinnedMotionVectorsDelegateField;

		// Token: 0x04000BF5 RID: 3061
		private static readonly SkinnedMeshRenderer.GetBlendShapeWeightDelegate GetBlendShapeWeightDelegateField;

		// Token: 0x04000BF6 RID: 3062
		private static readonly SkinnedMeshRenderer.BakeMeshDelegate BakeMeshDelegateField;

		// Token: 0x04000BF7 RID: 3063
		private static readonly SkinnedMeshRenderer.GetVertexBufferImplDelegate GetVertexBufferImplDelegateField;

		// Token: 0x04000BF8 RID: 3064
		private static readonly SkinnedMeshRenderer.GetPreviousVertexBufferImplDelegate GetPreviousVertexBufferImplDelegateField;

		// Token: 0x04000BF9 RID: 3065
		private static readonly SkinnedMeshRenderer.get_vertexBufferTargetDelegate get_vertexBufferTargetDelegateField;

		// Token: 0x04000BFA RID: 3066
		private static readonly SkinnedMeshRenderer.set_vertexBufferTargetDelegate set_vertexBufferTargetDelegateField;

		// Token: 0x02000764 RID: 1892
		// (Invoke) Token: 0x06003770 RID: 14192
		private delegate SkinQuality get_qualityDelegate(IntPtr @this);

		// Token: 0x02000765 RID: 1893
		// (Invoke) Token: 0x06003772 RID: 14194
		private delegate void set_qualityDelegate(IntPtr @this, SkinQuality value);

		// Token: 0x02000766 RID: 1894
		// (Invoke) Token: 0x06003774 RID: 14196
		private delegate bool get_updateWhenOffscreenDelegate(IntPtr @this);

		// Token: 0x02000767 RID: 1895
		// (Invoke) Token: 0x06003776 RID: 14198
		private delegate bool get_forceMatrixRecalculationPerRenderDelegate(IntPtr @this);

		// Token: 0x02000768 RID: 1896
		// (Invoke) Token: 0x06003778 RID: 14200
		private delegate void set_forceMatrixRecalculationPerRenderDelegate(IntPtr @this, bool value);

		// Token: 0x02000769 RID: 1897
		// (Invoke) Token: 0x0600377A RID: 14202
		private delegate IntPtr get_rootBoneDelegate(IntPtr @this);

		// Token: 0x0200076A RID: 1898
		// (Invoke) Token: 0x0600377C RID: 14204
		private delegate void set_rootBoneDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200076B RID: 1899
		// (Invoke) Token: 0x0600377E RID: 14206
		private delegate void set_sharedMeshDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200076C RID: 1900
		// (Invoke) Token: 0x06003780 RID: 14208
		private delegate bool get_skinnedMotionVectorsDelegate(IntPtr @this);

		// Token: 0x0200076D RID: 1901
		// (Invoke) Token: 0x06003782 RID: 14210
		private delegate void set_skinnedMotionVectorsDelegate(IntPtr @this, bool value);

		// Token: 0x0200076E RID: 1902
		// (Invoke) Token: 0x06003784 RID: 14212
		private delegate float GetBlendShapeWeightDelegate(IntPtr @this, int index);

		// Token: 0x0200076F RID: 1903
		// (Invoke) Token: 0x06003786 RID: 14214
		private delegate void BakeMeshDelegate(IntPtr @this, IntPtr mesh, bool useScale);

		// Token: 0x02000770 RID: 1904
		// (Invoke) Token: 0x06003788 RID: 14216
		private delegate IntPtr GetVertexBufferImplDelegate(IntPtr @this);

		// Token: 0x02000771 RID: 1905
		// (Invoke) Token: 0x0600378A RID: 14218
		private delegate IntPtr GetPreviousVertexBufferImplDelegate(IntPtr @this);

		// Token: 0x02000772 RID: 1906
		// (Invoke) Token: 0x0600378C RID: 14220
		private delegate GraphicsBuffer.Target get_vertexBufferTargetDelegate(IntPtr @this);

		// Token: 0x02000773 RID: 1907
		// (Invoke) Token: 0x0600378E RID: 14222
		private delegate void set_vertexBufferTargetDelegate(IntPtr @this, GraphicsBuffer.Target value);
	}
}
