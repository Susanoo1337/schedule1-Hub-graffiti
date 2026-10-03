using System;
using System.Runtime.InteropServices;
using Unity.Baselib.LowLevel;

namespace Unity.Baselib
{
	// Token: 0x0200028C RID: 652
	public struct ErrorState
	{
		// Token: 0x06002C34 RID: 11316 RVA: 0x000AAF64 File Offset: 0x000A9164
		public void ThrowIfFailed()
		{
			bool flag = this.ErrorCode > Unity.Baselib.LowLevel.Binding.Baselib_ErrorCode.Success;
			if (flag)
			{
				throw new BaselibException(this);
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06002C35 RID: 11317 RVA: 0x000134D3 File Offset: 0x000116D3
		public Unity.Baselib.LowLevel.Binding.Baselib_ErrorCode ErrorCode
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x000134E0 File Offset: 0x000116E0
		public string Explain([Optional] Unity.Baselib.LowLevel.Binding.Baselib_ErrorState_ExplainVerbosity verbosity)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
