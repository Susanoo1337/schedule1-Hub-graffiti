using System;

namespace JetBrains.Annotations
{
	// Token: 0x020002A8 RID: 680
	public sealed class PublicAPIAttribute : Attribute
	{
		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06002C91 RID: 11409 RVA: 0x00013817 File Offset: 0x00011A17
		public string Comment
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
