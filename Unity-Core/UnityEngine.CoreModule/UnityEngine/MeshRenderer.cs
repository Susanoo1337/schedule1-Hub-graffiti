using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x020000D5 RID: 213
	public class MeshRenderer : Renderer
	{
		// Token: 0x06000ECF RID: 3791 RVA: 0x0004251C File Offset: 0x0004071C
		// Note: this type is marked as 'beforefieldinit'.
		static MeshRenderer()
		{
			Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "MeshRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr);
			MeshRenderer.NativeMethodInfoPtr_DontStripMeshRenderer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr, 100664620);
			MeshRenderer.NativeMethodInfoPtr_get_subMeshStartIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr, 100664621);
			MeshRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr, 100664622);
			MeshRenderer.get_additionalVertexStreamsDelegateField = IL2CPP.ResolveICall<MeshRenderer.get_additionalVertexStreamsDelegate>("UnityEngine.MeshRenderer::get_additionalVertexStreams");
			MeshRenderer.set_additionalVertexStreamsDelegateField = IL2CPP.ResolveICall<MeshRenderer.set_additionalVertexStreamsDelegate>("UnityEngine.MeshRenderer::set_additionalVertexStreams");
			MeshRenderer.get_enlightenVertexStreamDelegateField = IL2CPP.ResolveICall<MeshRenderer.get_enlightenVertexStreamDelegate>("UnityEngine.MeshRenderer::get_enlightenVertexStream");
			MeshRenderer.set_enlightenVertexStreamDelegateField = IL2CPP.ResolveICall<MeshRenderer.set_enlightenVertexStreamDelegate>("UnityEngine.MeshRenderer::set_enlightenVertexStream");
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x000425C4 File Offset: 0x000407C4
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DontStripMeshRenderer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshRenderer.NativeMethodInfoPtr_DontStripMeshRenderer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x000425F8 File Offset: 0x000407F8
		public unsafe int subMeshStartIndex
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1238249, RefRangeEnd = 1238251, XrefRangeStart = 1238247, XrefRangeEnd = 1238249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshRenderer.NativeMethodInfoPtr_get_subMeshStartIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00042634 File Offset: 0x00040834
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshRenderer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00008FC8 File Offset: 0x000071C8
		public MeshRenderer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x00042670 File Offset: 0x00040870
		// (set) Token: 0x06000ED5 RID: 3797 RVA: 0x00008FD1 File Offset: 0x000071D1
		public Mesh additionalVertexStreams
		{
			get
			{
				IntPtr intPtr = MeshRenderer.get_additionalVertexStreamsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				MeshRenderer.set_additionalVertexStreamsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x0004269C File Offset: 0x0004089C
		// (set) Token: 0x06000ED7 RID: 3799 RVA: 0x00008FE9 File Offset: 0x000071E9
		public Mesh enlightenVertexStream
		{
			get
			{
				IntPtr intPtr = MeshRenderer.get_enlightenVertexStreamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				MeshRenderer.set_enlightenVertexStreamDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeMethodInfoPtr_DontStripMeshRenderer_Private_Void_0;

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeMethodInfoPtr_get_subMeshStartIndex_Public_get_Int32_0;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BFE RID: 3070
		private static readonly MeshRenderer.get_additionalVertexStreamsDelegate get_additionalVertexStreamsDelegateField;

		// Token: 0x04000BFF RID: 3071
		private static readonly MeshRenderer.set_additionalVertexStreamsDelegate set_additionalVertexStreamsDelegateField;

		// Token: 0x04000C00 RID: 3072
		private static readonly MeshRenderer.get_enlightenVertexStreamDelegate get_enlightenVertexStreamDelegateField;

		// Token: 0x04000C01 RID: 3073
		private static readonly MeshRenderer.set_enlightenVertexStreamDelegate set_enlightenVertexStreamDelegateField;

		// Token: 0x02000774 RID: 1908
		// (Invoke) Token: 0x06003790 RID: 14224
		private delegate IntPtr get_additionalVertexStreamsDelegate(IntPtr @this);

		// Token: 0x02000775 RID: 1909
		// (Invoke) Token: 0x06003792 RID: 14226
		private delegate void set_additionalVertexStreamsDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000776 RID: 1910
		// (Invoke) Token: 0x06003794 RID: 14228
		private delegate IntPtr get_enlightenVertexStreamDelegate(IntPtr @this);

		// Token: 0x02000777 RID: 1911
		// (Invoke) Token: 0x06003796 RID: 14230
		private delegate void set_enlightenVertexStreamDelegate(IntPtr @this, IntPtr value);
	}
}
