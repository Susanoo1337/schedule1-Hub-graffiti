using System;

namespace JetBrains.Annotations
{
	// Token: 0x020002AA RID: 682
	public sealed class MustDisposeResourceAttribute : Attribute
	{
		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06002C92 RID: 11410 RVA: 0x00013824 File Offset: 0x00011A24
		public bool Value
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
