using System;

namespace Unity.Jobs.LowLevel.Unsafe
{
	// Token: 0x02000290 RID: 656
	public static class JobHandleUnsafeUtility
	{
		// Token: 0x06002C4C RID: 11340 RVA: 0x000AB0E0 File Offset: 0x000A92E0
		public unsafe static JobHandle CombineDependencies(JobHandle* jobs, int count)
		{
			return JobHandle.CombineDependenciesInternalPtr((void*)jobs, count);
		}
	}
}
