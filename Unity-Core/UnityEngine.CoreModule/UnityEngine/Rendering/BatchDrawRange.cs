using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000214 RID: 532
	[StructLayout(2)]
	public struct BatchDrawRange
	{
		// Token: 0x06002440 RID: 9280 RVA: 0x00091B24 File Offset: 0x0008FD24
		// Note: this type is marked as 'beforefieldinit'.
		static BatchDrawRange()
		{
			Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchDrawRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr);
			BatchDrawRange.NativeFieldInfoPtr_drawCommandsBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr, "drawCommandsBegin");
			BatchDrawRange.NativeFieldInfoPtr_drawCommandsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr, "drawCommandsCount");
			BatchDrawRange.NativeFieldInfoPtr_filterSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr, "filterSettings");
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x00010B68 File Offset: 0x0000ED68
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchDrawRange>.NativeClassPtr, ref this));
		}

		// Token: 0x04001E57 RID: 7767
		private static readonly IntPtr NativeFieldInfoPtr_drawCommandsBegin;

		// Token: 0x04001E58 RID: 7768
		private static readonly IntPtr NativeFieldInfoPtr_drawCommandsCount;

		// Token: 0x04001E59 RID: 7769
		private static readonly IntPtr NativeFieldInfoPtr_filterSettings;

		// Token: 0x04001E5A RID: 7770
		[FieldOffset(0)]
		public uint drawCommandsBegin;

		// Token: 0x04001E5B RID: 7771
		[FieldOffset(4)]
		public uint drawCommandsCount;

		// Token: 0x04001E5C RID: 7772
		[FieldOffset(8)]
		public BatchFilterSettings filterSettings;
	}
}
