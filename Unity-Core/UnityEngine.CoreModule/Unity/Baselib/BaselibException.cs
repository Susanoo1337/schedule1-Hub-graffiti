using System;
using Unity.Baselib.LowLevel;

namespace Unity.Baselib
{
	// Token: 0x0200028D RID: 653
	public class BaselibException : Exception
	{
		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06002C37 RID: 11319 RVA: 0x000134ED File Offset: 0x000116ED
		public Unity.Baselib.LowLevel.Binding.Baselib_ErrorCode ErrorCode
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
