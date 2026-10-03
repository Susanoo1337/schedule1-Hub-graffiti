using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Jobs.LowLevel.Unsafe
{
	// Token: 0x02000014 RID: 20
	[StructLayout(2)]
	public struct JobRanges
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00019CB0 File Offset: 0x00017EB0
		// Note: this type is marked as 'beforefieldinit'.
		static JobRanges()
		{
			Il2CppClassPointerStore<JobRanges>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs.LowLevel.Unsafe", "JobRanges");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobRanges>.NativeClassPtr);
			JobRanges.NativeFieldInfoPtr_BatchSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, "BatchSize");
			JobRanges.NativeFieldInfoPtr_NumJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, "NumJobs");
			JobRanges.NativeFieldInfoPtr_TotalIterationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, "TotalIterationCount");
			JobRanges.NativeFieldInfoPtr_StartEndIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, "StartEndIndex");
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000023AE File Offset: 0x000005AE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JobRanges>.NativeClassPtr, ref this));
		}

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr_BatchSize;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr_NumJobs;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr_TotalIterationCount;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_StartEndIndex;

		// Token: 0x04000040 RID: 64
		[FieldOffset(0)]
		public int BatchSize;

		// Token: 0x04000041 RID: 65
		[FieldOffset(4)]
		public int NumJobs;

		// Token: 0x04000042 RID: 66
		[FieldOffset(8)]
		public int TotalIterationCount;

		// Token: 0x04000043 RID: 67
		[FieldOffset(16)]
		public IntPtr StartEndIndex;
	}
}
