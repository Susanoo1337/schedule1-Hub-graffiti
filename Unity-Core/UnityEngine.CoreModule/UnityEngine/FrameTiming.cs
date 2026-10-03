using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000099 RID: 153
	[StructLayout(2)]
	public struct FrameTiming
	{
		// Token: 0x0600093E RID: 2366 RVA: 0x00034C34 File Offset: 0x00032E34
		// Note: this type is marked as 'beforefieldinit'.
		static FrameTiming()
		{
			Il2CppClassPointerStore<FrameTiming>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "FrameTiming");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr);
			FrameTiming.NativeFieldInfoPtr_cpuFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "cpuFrameTime");
			FrameTiming.NativeFieldInfoPtr_cpuMainThreadFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "cpuMainThreadFrameTime");
			FrameTiming.NativeFieldInfoPtr_cpuMainThreadPresentWaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "cpuMainThreadPresentWaitTime");
			FrameTiming.NativeFieldInfoPtr_cpuRenderThreadFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "cpuRenderThreadFrameTime");
			FrameTiming.NativeFieldInfoPtr_gpuFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "gpuFrameTime");
			FrameTiming.NativeFieldInfoPtr_frameStartTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "frameStartTimestamp");
			FrameTiming.NativeFieldInfoPtr_firstSubmitTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "firstSubmitTimestamp");
			FrameTiming.NativeFieldInfoPtr_cpuTimePresentCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "cpuTimePresentCalled");
			FrameTiming.NativeFieldInfoPtr_cpuTimeFrameComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "cpuTimeFrameComplete");
			FrameTiming.NativeFieldInfoPtr_heightScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "heightScale");
			FrameTiming.NativeFieldInfoPtr_widthScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "widthScale");
			FrameTiming.NativeFieldInfoPtr_syncInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "syncInterval");
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00005F7E File Offset: 0x0000417E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, ref this));
		}

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeFieldInfoPtr_cpuFrameTime;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeFieldInfoPtr_cpuMainThreadFrameTime;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeFieldInfoPtr_cpuMainThreadPresentWaitTime;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeFieldInfoPtr_cpuRenderThreadFrameTime;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeFieldInfoPtr_gpuFrameTime;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeFieldInfoPtr_frameStartTimestamp;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeFieldInfoPtr_firstSubmitTimestamp;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeFieldInfoPtr_cpuTimePresentCalled;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeFieldInfoPtr_cpuTimeFrameComplete;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeFieldInfoPtr_heightScale;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeFieldInfoPtr_widthScale;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeFieldInfoPtr_syncInterval;

		// Token: 0x0400072F RID: 1839
		[FieldOffset(0)]
		public double cpuFrameTime;

		// Token: 0x04000730 RID: 1840
		[FieldOffset(8)]
		public double cpuMainThreadFrameTime;

		// Token: 0x04000731 RID: 1841
		[FieldOffset(16)]
		public double cpuMainThreadPresentWaitTime;

		// Token: 0x04000732 RID: 1842
		[FieldOffset(24)]
		public double cpuRenderThreadFrameTime;

		// Token: 0x04000733 RID: 1843
		[FieldOffset(32)]
		public double gpuFrameTime;

		// Token: 0x04000734 RID: 1844
		[FieldOffset(40)]
		public ulong frameStartTimestamp;

		// Token: 0x04000735 RID: 1845
		[FieldOffset(48)]
		public ulong firstSubmitTimestamp;

		// Token: 0x04000736 RID: 1846
		[FieldOffset(56)]
		public ulong cpuTimePresentCalled;

		// Token: 0x04000737 RID: 1847
		[FieldOffset(64)]
		public ulong cpuTimeFrameComplete;

		// Token: 0x04000738 RID: 1848
		[FieldOffset(72)]
		public float heightScale;

		// Token: 0x04000739 RID: 1849
		[FieldOffset(76)]
		public float widthScale;

		// Token: 0x0400073A RID: 1850
		[FieldOffset(80)]
		public uint syncInterval;
	}
}
