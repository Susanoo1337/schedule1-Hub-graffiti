using System;

namespace UnityEngine
{
	// Token: 0x02000305 RID: 773
	public sealed class WaitWhile : CustomYieldInstruction
	{
		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06002D52 RID: 11602 RVA: 0x00014146 File Offset: 0x00012346
		public override bool keepWaiting
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
