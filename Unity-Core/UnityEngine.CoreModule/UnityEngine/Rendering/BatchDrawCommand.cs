using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000212 RID: 530
	[StructLayout(2)]
	public struct BatchDrawCommand
	{
		// Token: 0x06002432 RID: 9266 RVA: 0x00091984 File Offset: 0x0008FB84
		// Note: this type is marked as 'beforefieldinit'.
		static BatchDrawCommand()
		{
			Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchDrawCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr);
			BatchDrawCommand.NativeFieldInfoPtr_visibleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "visibleOffset");
			BatchDrawCommand.NativeFieldInfoPtr_visibleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "visibleCount");
			BatchDrawCommand.NativeFieldInfoPtr_batchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "batchID");
			BatchDrawCommand.NativeFieldInfoPtr_materialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "materialID");
			BatchDrawCommand.NativeFieldInfoPtr_meshID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "meshID");
			BatchDrawCommand.NativeFieldInfoPtr_submeshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "submeshIndex");
			BatchDrawCommand.NativeFieldInfoPtr_splitVisibilityMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "splitVisibilityMask");
			BatchDrawCommand.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "flags");
			BatchDrawCommand.NativeFieldInfoPtr_sortingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, "sortingPosition");
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x00010ACF File Offset: 0x0000ECCF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, ref this));
		}

		// Token: 0x04001E37 RID: 7735
		private static readonly IntPtr NativeFieldInfoPtr_visibleOffset;

		// Token: 0x04001E38 RID: 7736
		private static readonly IntPtr NativeFieldInfoPtr_visibleCount;

		// Token: 0x04001E39 RID: 7737
		private static readonly IntPtr NativeFieldInfoPtr_batchID;

		// Token: 0x04001E3A RID: 7738
		private static readonly IntPtr NativeFieldInfoPtr_materialID;

		// Token: 0x04001E3B RID: 7739
		private static readonly IntPtr NativeFieldInfoPtr_meshID;

		// Token: 0x04001E3C RID: 7740
		private static readonly IntPtr NativeFieldInfoPtr_submeshIndex;

		// Token: 0x04001E3D RID: 7741
		private static readonly IntPtr NativeFieldInfoPtr_splitVisibilityMask;

		// Token: 0x04001E3E RID: 7742
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04001E3F RID: 7743
		private static readonly IntPtr NativeFieldInfoPtr_sortingPosition;

		// Token: 0x04001E40 RID: 7744
		[FieldOffset(0)]
		public uint visibleOffset;

		// Token: 0x04001E41 RID: 7745
		[FieldOffset(4)]
		public uint visibleCount;

		// Token: 0x04001E42 RID: 7746
		[FieldOffset(8)]
		public BatchID batchID;

		// Token: 0x04001E43 RID: 7747
		[FieldOffset(12)]
		public BatchMaterialID materialID;

		// Token: 0x04001E44 RID: 7748
		[FieldOffset(16)]
		public BatchMeshID meshID;

		// Token: 0x04001E45 RID: 7749
		[FieldOffset(20)]
		public ushort submeshIndex;

		// Token: 0x04001E46 RID: 7750
		[FieldOffset(22)]
		public ushort splitVisibilityMask;

		// Token: 0x04001E47 RID: 7751
		[FieldOffset(24)]
		public BatchDrawCommandFlags flags;

		// Token: 0x04001E48 RID: 7752
		[FieldOffset(28)]
		public int sortingPosition;
	}
}
