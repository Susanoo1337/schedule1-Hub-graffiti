using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000DB RID: 219
	[StructLayout(2)]
	public struct CombineInstance
	{
		// Token: 0x06001052 RID: 4178 RVA: 0x00048810 File Offset: 0x00046A10
		// Note: this type is marked as 'beforefieldinit'.
		static CombineInstance()
		{
			Il2CppClassPointerStore<CombineInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CombineInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr);
			CombineInstance.NativeFieldInfoPtr_m_MeshInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, "m_MeshInstanceID");
			CombineInstance.NativeFieldInfoPtr_m_SubMeshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, "m_SubMeshIndex");
			CombineInstance.NativeFieldInfoPtr_m_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, "m_Transform");
			CombineInstance.NativeFieldInfoPtr_m_LightmapScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, "m_LightmapScaleOffset");
			CombineInstance.NativeFieldInfoPtr_m_RealtimeLightmapScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, "m_RealtimeLightmapScaleOffset");
			CombineInstance.NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, 100664807);
			CombineInstance.NativeMethodInfoPtr_set_subMeshIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, 100664808);
			CombineInstance.NativeMethodInfoPtr_set_transform_Public_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, 100664809);
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001057 RID: 4183 RVA: 0x00048980 File Offset: 0x00046B80
		// (set) Token: 0x06001053 RID: 4179 RVA: 0x000488E0 File Offset: 0x00046AE0
		public unsafe Mesh mesh
		{
			get
			{
				return Mesh.FromInstanceID(this.m_MeshInstanceID);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1239549, RefRangeEnd = 1239553, XrefRangeStart = 1239544, XrefRangeEnd = 1239549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombineInstance.NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x000489A0 File Offset: 0x00046BA0
		// (set) Token: 0x06001054 RID: 4180 RVA: 0x00048918 File Offset: 0x00046B18
		public unsafe int subMeshIndex
		{
			get
			{
				return this.m_SubMeshIndex;
			}
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 54944, RefRangeEnd = 54959, XrefRangeStart = 54944, XrefRangeEnd = 54959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombineInstance.NativeMethodInfoPtr_set_subMeshIndex_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06001059 RID: 4185 RVA: 0x000489B8 File Offset: 0x00046BB8
		// (set) Token: 0x06001055 RID: 4181 RVA: 0x0004894C File Offset: 0x00046B4C
		public unsafe Matrix4x4 transform
		{
			get
			{
				return this.m_Transform;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1239553, RefRangeEnd = 1239557, XrefRangeStart = 1239553, XrefRangeEnd = 1239553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombineInstance.NativeMethodInfoPtr_set_transform_Public_set_Void_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x00009906 File Offset: 0x00007B06
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, ref this));
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x0600105A RID: 4186 RVA: 0x000489D0 File Offset: 0x00046BD0
		// (set) Token: 0x0600105B RID: 4187 RVA: 0x00009918 File Offset: 0x00007B18
		public Vector4 lightmapScaleOffset
		{
			get
			{
				return this.m_LightmapScaleOffset;
			}
			set
			{
				this.m_LightmapScaleOffset = value;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x000489E8 File Offset: 0x00046BE8
		// (set) Token: 0x0600105D RID: 4189 RVA: 0x00009922 File Offset: 0x00007B22
		public Vector4 realtimeLightmapScaleOffset
		{
			get
			{
				return this.m_RealtimeLightmapScaleOffset;
			}
			set
			{
				this.m_RealtimeLightmapScaleOffset = value;
			}
		}

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeFieldInfoPtr_m_MeshInstanceID;

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeFieldInfoPtr_m_SubMeshIndex;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeFieldInfoPtr_m_Transform;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeFieldInfoPtr_m_LightmapScaleOffset;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeFieldInfoPtr_m_RealtimeLightmapScaleOffset;

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeMethodInfoPtr_set_subMeshIndex_Public_set_Void_Int32_0;

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeMethodInfoPtr_set_transform_Public_set_Void_Matrix4x4_0;

		// Token: 0x04000D15 RID: 3349
		[FieldOffset(0)]
		public int m_MeshInstanceID;

		// Token: 0x04000D16 RID: 3350
		[FieldOffset(4)]
		public int m_SubMeshIndex;

		// Token: 0x04000D17 RID: 3351
		[FieldOffset(8)]
		public Matrix4x4 m_Transform;

		// Token: 0x04000D18 RID: 3352
		[FieldOffset(72)]
		public Vector4 m_LightmapScaleOffset;

		// Token: 0x04000D19 RID: 3353
		[FieldOffset(88)]
		public Vector4 m_RealtimeLightmapScaleOffset;
	}
}
