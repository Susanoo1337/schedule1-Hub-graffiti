using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000216 RID: 534
	[StructLayout(2)]
	public struct CullingSplit
	{
		// Token: 0x06002444 RID: 9284 RVA: 0x00091C74 File Offset: 0x0008FE74
		// Note: this type is marked as 'beforefieldinit'.
		static CullingSplit()
		{
			Il2CppClassPointerStore<CullingSplit>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "CullingSplit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr);
			CullingSplit.NativeFieldInfoPtr_sphereCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, "sphereCenter");
			CullingSplit.NativeFieldInfoPtr_sphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, "sphereRadius");
			CullingSplit.NativeFieldInfoPtr_cullingPlaneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, "cullingPlaneOffset");
			CullingSplit.NativeFieldInfoPtr_cullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, "cullingPlaneCount");
			CullingSplit.NativeFieldInfoPtr_cascadeBlendCullingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, "cascadeBlendCullingFactor");
			CullingSplit.NativeFieldInfoPtr_nearPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, "nearPlane");
			CullingSplit.NativeFieldInfoPtr_cullingMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, "cullingMatrix");
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x00010B8C File Offset: 0x0000ED8C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, ref this));
		}

		// Token: 0x04001E6F RID: 7791
		private static readonly IntPtr NativeFieldInfoPtr_sphereCenter;

		// Token: 0x04001E70 RID: 7792
		private static readonly IntPtr NativeFieldInfoPtr_sphereRadius;

		// Token: 0x04001E71 RID: 7793
		private static readonly IntPtr NativeFieldInfoPtr_cullingPlaneOffset;

		// Token: 0x04001E72 RID: 7794
		private static readonly IntPtr NativeFieldInfoPtr_cullingPlaneCount;

		// Token: 0x04001E73 RID: 7795
		private static readonly IntPtr NativeFieldInfoPtr_cascadeBlendCullingFactor;

		// Token: 0x04001E74 RID: 7796
		private static readonly IntPtr NativeFieldInfoPtr_nearPlane;

		// Token: 0x04001E75 RID: 7797
		private static readonly IntPtr NativeFieldInfoPtr_cullingMatrix;

		// Token: 0x04001E76 RID: 7798
		[FieldOffset(0)]
		public Vector3 sphereCenter;

		// Token: 0x04001E77 RID: 7799
		[FieldOffset(12)]
		public float sphereRadius;

		// Token: 0x04001E78 RID: 7800
		[FieldOffset(16)]
		public int cullingPlaneOffset;

		// Token: 0x04001E79 RID: 7801
		[FieldOffset(20)]
		public int cullingPlaneCount;

		// Token: 0x04001E7A RID: 7802
		[FieldOffset(24)]
		public float cascadeBlendCullingFactor;

		// Token: 0x04001E7B RID: 7803
		[FieldOffset(28)]
		public float nearPlane;

		// Token: 0x04001E7C RID: 7804
		[FieldOffset(32)]
		public Matrix4x4 cullingMatrix;
	}
}
