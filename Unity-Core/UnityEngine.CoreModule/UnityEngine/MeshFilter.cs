using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x020000B1 RID: 177
	public sealed class MeshFilter : Component
	{
		// Token: 0x06000E89 RID: 3721 RVA: 0x00041D04 File Offset: 0x0003FF04
		// Note: this type is marked as 'beforefieldinit'.
		static MeshFilter()
		{
			Il2CppClassPointerStore<MeshFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "MeshFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr);
			MeshFilter.NativeMethodInfoPtr_DontStripMeshFilter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr, 100664609);
			MeshFilter.NativeMethodInfoPtr_get_sharedMesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr, 100664610);
			MeshFilter.NativeMethodInfoPtr_set_sharedMesh_Public_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr, 100664611);
			MeshFilter.NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr, 100664612);
			MeshFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr, 100664613);
			MeshFilter.get_meshDelegateField = IL2CPP.ResolveICall<MeshFilter.get_meshDelegate>("UnityEngine.MeshFilter::get_mesh");
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00041DA8 File Offset: 0x0003FFA8
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DontStripMeshFilter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshFilter.NativeMethodInfoPtr_DontStripMeshFilter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000E8B RID: 3723 RVA: 0x00041DDC File Offset: 0x0003FFDC
		// (set) Token: 0x06000E8C RID: 3724 RVA: 0x00041E1C File Offset: 0x0004001C
		public unsafe Mesh sharedMesh
		{
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 1238120, RefRangeEnd = 1238181, XrefRangeStart = 1238118, XrefRangeEnd = 1238120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshFilter.NativeMethodInfoPtr_get_sharedMesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 1238183, RefRangeEnd = 1238204, XrefRangeStart = 1238181, XrefRangeEnd = 1238183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshFilter.NativeMethodInfoPtr_set_sharedMesh_Public_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x00041EE0 File Offset: 0x000400E0
		// (set) Token: 0x06000E8D RID: 3725 RVA: 0x00041E60 File Offset: 0x00040060
		public unsafe Mesh mesh
		{
			get
			{
				IntPtr intPtr = MeshFilter.get_meshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1238206, RefRangeEnd = 1238207, XrefRangeStart = 1238204, XrefRangeEnd = 1238206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshFilter.NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00041EA4 File Offset: 0x000400A4
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshFilter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshFilter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00008C90 File Offset: 0x00006E90
		public MeshFilter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeMethodInfoPtr_DontStripMeshFilter_Private_Void_0;

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeMethodInfoPtr_get_sharedMesh_Public_get_Mesh_0;

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeMethodInfoPtr_set_sharedMesh_Public_set_Void_Mesh_0;

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0;

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000ABC RID: 2748
		private static readonly MeshFilter.get_meshDelegate get_meshDelegateField;

		// Token: 0x02000742 RID: 1858
		// (Invoke) Token: 0x06003738 RID: 14136
		private delegate IntPtr get_meshDelegate(IntPtr @this);
	}
}
