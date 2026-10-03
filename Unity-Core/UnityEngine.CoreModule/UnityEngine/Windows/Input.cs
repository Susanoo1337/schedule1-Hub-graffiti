using System;
using Il2CppSystem;

namespace UnityEngine.Windows
{
	// Token: 0x0200031E RID: 798
	public static class Input
	{
		// Token: 0x06002D9A RID: 11674 RVA: 0x00014354 File Offset: 0x00012554
		public unsafe static void ForwardRawInput(IntPtr rawInputHeaderIndices, IntPtr rawInputDataIndices, uint indicesCount, IntPtr rawInputData, uint rawInputDataSize)
		{
			Input.ForwardRawInput((uint*)((void*)rawInputHeaderIndices), (uint*)((void*)rawInputDataIndices), indicesCount, (byte*)((void*)rawInputData), rawInputDataSize);
		}

		// Token: 0x06002D9B RID: 11675 RVA: 0x00014374 File Offset: 0x00012574
		public unsafe static void ForwardRawInput(uint* rawInputHeaderIndices, uint* rawInputDataIndices, uint indicesCount, byte* rawInputData, uint rawInputDataSize)
		{
			throw new NotSupportedException();
		}
	}
}
