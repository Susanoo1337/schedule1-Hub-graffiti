using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000222 RID: 546
	[StructLayout(2)]
	public struct CullingAllocationInfo
	{
		// Token: 0x0600254B RID: 9547 RVA: 0x00094D50 File Offset: 0x00092F50
		// Note: this type is marked as 'beforefieldinit'.
		static CullingAllocationInfo()
		{
			Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "CullingAllocationInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr);
			CullingAllocationInfo.NativeFieldInfoPtr_visibleLightsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, "visibleLightsPtr");
			CullingAllocationInfo.NativeFieldInfoPtr_visibleOffscreenVertexLightsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, "visibleOffscreenVertexLightsPtr");
			CullingAllocationInfo.NativeFieldInfoPtr_visibleReflectionProbesPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, "visibleReflectionProbesPtr");
			CullingAllocationInfo.NativeFieldInfoPtr_visibleLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, "visibleLightCount");
			CullingAllocationInfo.NativeFieldInfoPtr_visibleOffscreenVertexLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, "visibleOffscreenVertexLightCount");
			CullingAllocationInfo.NativeFieldInfoPtr_visibleReflectionProbeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, "visibleReflectionProbeCount");
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x0001127C File Offset: 0x0000F47C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04001FBC RID: 8124
		private static readonly IntPtr NativeFieldInfoPtr_visibleLightsPtr;

		// Token: 0x04001FBD RID: 8125
		private static readonly IntPtr NativeFieldInfoPtr_visibleOffscreenVertexLightsPtr;

		// Token: 0x04001FBE RID: 8126
		private static readonly IntPtr NativeFieldInfoPtr_visibleReflectionProbesPtr;

		// Token: 0x04001FBF RID: 8127
		private static readonly IntPtr NativeFieldInfoPtr_visibleLightCount;

		// Token: 0x04001FC0 RID: 8128
		private static readonly IntPtr NativeFieldInfoPtr_visibleOffscreenVertexLightCount;

		// Token: 0x04001FC1 RID: 8129
		private static readonly IntPtr NativeFieldInfoPtr_visibleReflectionProbeCount;

		// Token: 0x04001FC2 RID: 8130
		[FieldOffset(0)]
		public IntPtr visibleLightsPtr;

		// Token: 0x04001FC3 RID: 8131
		[FieldOffset(8)]
		public IntPtr visibleOffscreenVertexLightsPtr;

		// Token: 0x04001FC4 RID: 8132
		[FieldOffset(16)]
		public IntPtr visibleReflectionProbesPtr;

		// Token: 0x04001FC5 RID: 8133
		[FieldOffset(24)]
		public int visibleLightCount;

		// Token: 0x04001FC6 RID: 8134
		[FieldOffset(28)]
		public int visibleOffscreenVertexLightCount;

		// Token: 0x04001FC7 RID: 8135
		[FieldOffset(32)]
		public int visibleReflectionProbeCount;
	}
}
