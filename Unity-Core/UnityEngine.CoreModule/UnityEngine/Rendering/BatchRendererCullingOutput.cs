using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	// Token: 0x02000219 RID: 537
	[StructLayout(2)]
	public struct BatchRendererCullingOutput
	{
		// Token: 0x06002469 RID: 9321 RVA: 0x000921BC File Offset: 0x000903BC
		// Note: this type is marked as 'beforefieldinit'.
		static BatchRendererCullingOutput()
		{
			Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchRendererCullingOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr);
			BatchRendererCullingOutput.NativeFieldInfoPtr_cullingJobsFence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingJobsFence");
			BatchRendererCullingOutput.NativeFieldInfoPtr_localToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "localToWorldMatrix");
			BatchRendererCullingOutput.NativeFieldInfoPtr_cullingPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingPlanes");
			BatchRendererCullingOutput.NativeFieldInfoPtr_cullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingPlaneCount");
			BatchRendererCullingOutput.NativeFieldInfoPtr_receiverPlaneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "receiverPlaneOffset");
			BatchRendererCullingOutput.NativeFieldInfoPtr_receiverPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "receiverPlaneCount");
			BatchRendererCullingOutput.NativeFieldInfoPtr_cullingSplits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingSplits");
			BatchRendererCullingOutput.NativeFieldInfoPtr_cullingSplitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingSplitCount");
			BatchRendererCullingOutput.NativeFieldInfoPtr_viewType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "viewType");
			BatchRendererCullingOutput.NativeFieldInfoPtr_projectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "projectionType");
			BatchRendererCullingOutput.NativeFieldInfoPtr_cullingFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingFlags");
			BatchRendererCullingOutput.NativeFieldInfoPtr_viewID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "viewID");
			BatchRendererCullingOutput.NativeFieldInfoPtr_cullingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingLayerMask");
			BatchRendererCullingOutput.NativeFieldInfoPtr_sceneCullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "sceneCullingMask");
			BatchRendererCullingOutput.NativeFieldInfoPtr_drawCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "drawCommands");
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x00010DC0 File Offset: 0x0000EFC0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x04001E8C RID: 7820
		private static readonly IntPtr NativeFieldInfoPtr_cullingJobsFence;

		// Token: 0x04001E8D RID: 7821
		private static readonly IntPtr NativeFieldInfoPtr_localToWorldMatrix;

		// Token: 0x04001E8E RID: 7822
		private static readonly IntPtr NativeFieldInfoPtr_cullingPlanes;

		// Token: 0x04001E8F RID: 7823
		private static readonly IntPtr NativeFieldInfoPtr_cullingPlaneCount;

		// Token: 0x04001E90 RID: 7824
		private static readonly IntPtr NativeFieldInfoPtr_receiverPlaneOffset;

		// Token: 0x04001E91 RID: 7825
		private static readonly IntPtr NativeFieldInfoPtr_receiverPlaneCount;

		// Token: 0x04001E92 RID: 7826
		private static readonly IntPtr NativeFieldInfoPtr_cullingSplits;

		// Token: 0x04001E93 RID: 7827
		private static readonly IntPtr NativeFieldInfoPtr_cullingSplitCount;

		// Token: 0x04001E94 RID: 7828
		private static readonly IntPtr NativeFieldInfoPtr_viewType;

		// Token: 0x04001E95 RID: 7829
		private static readonly IntPtr NativeFieldInfoPtr_projectionType;

		// Token: 0x04001E96 RID: 7830
		private static readonly IntPtr NativeFieldInfoPtr_cullingFlags;

		// Token: 0x04001E97 RID: 7831
		private static readonly IntPtr NativeFieldInfoPtr_viewID;

		// Token: 0x04001E98 RID: 7832
		private static readonly IntPtr NativeFieldInfoPtr_cullingLayerMask;

		// Token: 0x04001E99 RID: 7833
		private static readonly IntPtr NativeFieldInfoPtr_sceneCullingMask;

		// Token: 0x04001E9A RID: 7834
		private static readonly IntPtr NativeFieldInfoPtr_drawCommands;

		// Token: 0x04001E9B RID: 7835
		[FieldOffset(0)]
		public Unity.Jobs.JobHandle cullingJobsFence;

		// Token: 0x04001E9C RID: 7836
		[FieldOffset(16)]
		public Matrix4x4 localToWorldMatrix;

		// Token: 0x04001E9D RID: 7837
		[FieldOffset(80)]
		public IntPtr cullingPlanes;

		// Token: 0x04001E9E RID: 7838
		[FieldOffset(88)]
		public int cullingPlaneCount;

		// Token: 0x04001E9F RID: 7839
		[FieldOffset(92)]
		public int receiverPlaneOffset;

		// Token: 0x04001EA0 RID: 7840
		[FieldOffset(96)]
		public int receiverPlaneCount;

		// Token: 0x04001EA1 RID: 7841
		[FieldOffset(104)]
		public IntPtr cullingSplits;

		// Token: 0x04001EA2 RID: 7842
		[FieldOffset(112)]
		public int cullingSplitCount;

		// Token: 0x04001EA3 RID: 7843
		[FieldOffset(116)]
		public BatchCullingViewType viewType;

		// Token: 0x04001EA4 RID: 7844
		[FieldOffset(120)]
		public BatchCullingProjectionType projectionType;

		// Token: 0x04001EA5 RID: 7845
		[FieldOffset(124)]
		public BatchCullingFlags cullingFlags;

		// Token: 0x04001EA6 RID: 7846
		[FieldOffset(128)]
		public ulong viewID;

		// Token: 0x04001EA7 RID: 7847
		[FieldOffset(136)]
		public uint cullingLayerMask;

		// Token: 0x04001EA8 RID: 7848
		[FieldOffset(144)]
		public ulong sceneCullingMask;

		// Token: 0x04001EA9 RID: 7849
		[FieldOffset(152)]
		public IntPtr drawCommands;
	}
}
