using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000AE RID: 174
	[StructLayout(2)]
	public struct LightBakingOutput
	{
		// Token: 0x06000E1F RID: 3615 RVA: 0x00040E88 File Offset: 0x0003F088
		// Note: this type is marked as 'beforefieldinit'.
		static LightBakingOutput()
		{
			Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightBakingOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr);
			LightBakingOutput.NativeFieldInfoPtr_probeOcclusionLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "probeOcclusionLightIndex");
			LightBakingOutput.NativeFieldInfoPtr_occlusionMaskChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "occlusionMaskChannel");
			LightBakingOutput.NativeFieldInfoPtr_lightmapBakeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "lightmapBakeType");
			LightBakingOutput.NativeFieldInfoPtr_mixedLightingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "mixedLightingMode");
			LightBakingOutput.NativeFieldInfoPtr_isBaked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "isBaked");
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00008878 File Offset: 0x00006A78
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeFieldInfoPtr_probeOcclusionLightIndex;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeFieldInfoPtr_occlusionMaskChannel;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeFieldInfoPtr_lightmapBakeType;

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeFieldInfoPtr_mixedLightingMode;

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeFieldInfoPtr_isBaked;

		// Token: 0x04000A64 RID: 2660
		[FieldOffset(0)]
		public int probeOcclusionLightIndex;

		// Token: 0x04000A65 RID: 2661
		[FieldOffset(4)]
		public int occlusionMaskChannel;

		// Token: 0x04000A66 RID: 2662
		[FieldOffset(8)]
		public LightmapBakeType lightmapBakeType;

		// Token: 0x04000A67 RID: 2663
		[FieldOffset(12)]
		public MixedLightingMode mixedLightingMode;

		// Token: 0x04000A68 RID: 2664
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool isBaked;
	}
}
