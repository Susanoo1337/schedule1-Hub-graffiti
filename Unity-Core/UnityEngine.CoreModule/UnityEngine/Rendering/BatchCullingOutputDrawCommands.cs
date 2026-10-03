using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000215 RID: 533
	[StructLayout(2)]
	public struct BatchCullingOutputDrawCommands
	{
		// Token: 0x06002442 RID: 9282 RVA: 0x00091B90 File Offset: 0x0008FD90
		// Note: this type is marked as 'beforefieldinit'.
		static BatchCullingOutputDrawCommands()
		{
			Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchCullingOutputDrawCommands");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr);
			BatchCullingOutputDrawCommands.NativeFieldInfoPtr_drawCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "drawCommands");
			BatchCullingOutputDrawCommands.NativeFieldInfoPtr_visibleInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "visibleInstances");
			BatchCullingOutputDrawCommands.NativeFieldInfoPtr_drawRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "drawRanges");
			BatchCullingOutputDrawCommands.NativeFieldInfoPtr_instanceSortingPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "instanceSortingPositions");
			BatchCullingOutputDrawCommands.NativeFieldInfoPtr_drawCommandPickingInstanceIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "drawCommandPickingInstanceIDs");
			BatchCullingOutputDrawCommands.NativeFieldInfoPtr_drawCommandCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "drawCommandCount");
			BatchCullingOutputDrawCommands.NativeFieldInfoPtr_visibleInstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "visibleInstanceCount");
			BatchCullingOutputDrawCommands.NativeFieldInfoPtr_drawRangeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "drawRangeCount");
			BatchCullingOutputDrawCommands.NativeFieldInfoPtr_instanceSortingPositionFloatCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, "instanceSortingPositionFloatCount");
		}

		// Token: 0x06002443 RID: 9283 RVA: 0x00010B7A File Offset: 0x0000ED7A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, ref this));
		}

		// Token: 0x04001E5D RID: 7773
		private static readonly IntPtr NativeFieldInfoPtr_drawCommands;

		// Token: 0x04001E5E RID: 7774
		private static readonly IntPtr NativeFieldInfoPtr_visibleInstances;

		// Token: 0x04001E5F RID: 7775
		private static readonly IntPtr NativeFieldInfoPtr_drawRanges;

		// Token: 0x04001E60 RID: 7776
		private static readonly IntPtr NativeFieldInfoPtr_instanceSortingPositions;

		// Token: 0x04001E61 RID: 7777
		private static readonly IntPtr NativeFieldInfoPtr_drawCommandPickingInstanceIDs;

		// Token: 0x04001E62 RID: 7778
		private static readonly IntPtr NativeFieldInfoPtr_drawCommandCount;

		// Token: 0x04001E63 RID: 7779
		private static readonly IntPtr NativeFieldInfoPtr_visibleInstanceCount;

		// Token: 0x04001E64 RID: 7780
		private static readonly IntPtr NativeFieldInfoPtr_drawRangeCount;

		// Token: 0x04001E65 RID: 7781
		private static readonly IntPtr NativeFieldInfoPtr_instanceSortingPositionFloatCount;

		// Token: 0x04001E66 RID: 7782
		[FieldOffset(0)]
		public IntPtr drawCommands;

		// Token: 0x04001E67 RID: 7783
		[FieldOffset(8)]
		public IntPtr visibleInstances;

		// Token: 0x04001E68 RID: 7784
		[FieldOffset(16)]
		public IntPtr drawRanges;

		// Token: 0x04001E69 RID: 7785
		[FieldOffset(24)]
		public IntPtr instanceSortingPositions;

		// Token: 0x04001E6A RID: 7786
		[FieldOffset(32)]
		public IntPtr drawCommandPickingInstanceIDs;

		// Token: 0x04001E6B RID: 7787
		[FieldOffset(40)]
		public int drawCommandCount;

		// Token: 0x04001E6C RID: 7788
		[FieldOffset(44)]
		public int visibleInstanceCount;

		// Token: 0x04001E6D RID: 7789
		[FieldOffset(48)]
		public int drawRangeCount;

		// Token: 0x04001E6E RID: 7790
		[FieldOffset(52)]
		public int instanceSortingPositionFloatCount;
	}
}
