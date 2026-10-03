using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.U2D
{
	// Token: 0x02000263 RID: 611
	[StructLayout(2)]
	public struct SpriteIntermediateRendererInfo
	{
		// Token: 0x06002ABF RID: 10943 RVA: 0x000A696C File Offset: 0x000A4B6C
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteIntermediateRendererInfo()
		{
			Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.U2D", "SpriteIntermediateRendererInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr);
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_SpriteID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "SpriteID");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_TextureID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "TextureID");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_MaterialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "MaterialID");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "Color");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "Transform");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "Bounds");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_Layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "Layer");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_SortingLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "SortingLayer");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_SortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "SortingOrder");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_SceneCullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "SceneCullingMask");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_IndexData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "IndexData");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_VertexData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "VertexData");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "IndexCount");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_VertexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "VertexCount");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_ShaderChannelMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "ShaderChannelMask");
		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x00012DC1 File Offset: 0x00010FC1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04002421 RID: 9249
		private static readonly IntPtr NativeFieldInfoPtr_SpriteID;

		// Token: 0x04002422 RID: 9250
		private static readonly IntPtr NativeFieldInfoPtr_TextureID;

		// Token: 0x04002423 RID: 9251
		private static readonly IntPtr NativeFieldInfoPtr_MaterialID;

		// Token: 0x04002424 RID: 9252
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x04002425 RID: 9253
		private static readonly IntPtr NativeFieldInfoPtr_Transform;

		// Token: 0x04002426 RID: 9254
		private static readonly IntPtr NativeFieldInfoPtr_Bounds;

		// Token: 0x04002427 RID: 9255
		private static readonly IntPtr NativeFieldInfoPtr_Layer;

		// Token: 0x04002428 RID: 9256
		private static readonly IntPtr NativeFieldInfoPtr_SortingLayer;

		// Token: 0x04002429 RID: 9257
		private static readonly IntPtr NativeFieldInfoPtr_SortingOrder;

		// Token: 0x0400242A RID: 9258
		private static readonly IntPtr NativeFieldInfoPtr_SceneCullingMask;

		// Token: 0x0400242B RID: 9259
		private static readonly IntPtr NativeFieldInfoPtr_IndexData;

		// Token: 0x0400242C RID: 9260
		private static readonly IntPtr NativeFieldInfoPtr_VertexData;

		// Token: 0x0400242D RID: 9261
		private static readonly IntPtr NativeFieldInfoPtr_IndexCount;

		// Token: 0x0400242E RID: 9262
		private static readonly IntPtr NativeFieldInfoPtr_VertexCount;

		// Token: 0x0400242F RID: 9263
		private static readonly IntPtr NativeFieldInfoPtr_ShaderChannelMask;

		// Token: 0x04002430 RID: 9264
		[FieldOffset(0)]
		public int SpriteID;

		// Token: 0x04002431 RID: 9265
		[FieldOffset(4)]
		public int TextureID;

		// Token: 0x04002432 RID: 9266
		[FieldOffset(8)]
		public int MaterialID;

		// Token: 0x04002433 RID: 9267
		[FieldOffset(12)]
		public Color Color;

		// Token: 0x04002434 RID: 9268
		[FieldOffset(28)]
		public Matrix4x4 Transform;

		// Token: 0x04002435 RID: 9269
		[FieldOffset(92)]
		public Bounds Bounds;

		// Token: 0x04002436 RID: 9270
		[FieldOffset(116)]
		public int Layer;

		// Token: 0x04002437 RID: 9271
		[FieldOffset(120)]
		public int SortingLayer;

		// Token: 0x04002438 RID: 9272
		[FieldOffset(124)]
		public int SortingOrder;

		// Token: 0x04002439 RID: 9273
		[FieldOffset(128)]
		public ulong SceneCullingMask;

		// Token: 0x0400243A RID: 9274
		[FieldOffset(136)]
		public IntPtr IndexData;

		// Token: 0x0400243B RID: 9275
		[FieldOffset(144)]
		public IntPtr VertexData;

		// Token: 0x0400243C RID: 9276
		[FieldOffset(152)]
		public int IndexCount;

		// Token: 0x0400243D RID: 9277
		[FieldOffset(156)]
		public int VertexCount;

		// Token: 0x0400243E RID: 9278
		[FieldOffset(160)]
		public int ShaderChannelMask;
	}
}
