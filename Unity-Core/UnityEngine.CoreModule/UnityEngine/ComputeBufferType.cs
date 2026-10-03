using System;

namespace UnityEngine
{
	// Token: 0x020000B6 RID: 182
	[Flags]
	public enum ComputeBufferType
	{
		// Token: 0x04000AD4 RID: 2772
		Default = 0,
		// Token: 0x04000AD5 RID: 2773
		Raw = 1,
		// Token: 0x04000AD6 RID: 2774
		Append = 2,
		// Token: 0x04000AD7 RID: 2775
		Counter = 4,
		// Token: 0x04000AD8 RID: 2776
		Constant = 8,
		// Token: 0x04000AD9 RID: 2777
		Structured = 16,
		// Token: 0x04000ADA RID: 2778
		DrawIndirect = 256,
		// Token: 0x04000ADB RID: 2779
		IndirectArguments = 256,
		// Token: 0x04000ADC RID: 2780
		GPUMemory = 512
	}
}
