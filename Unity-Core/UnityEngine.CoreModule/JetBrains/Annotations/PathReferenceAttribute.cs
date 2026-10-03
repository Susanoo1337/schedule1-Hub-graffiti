using System;

namespace JetBrains.Annotations
{
	// Token: 0x020002AC RID: 684
	public sealed class PathReferenceAttribute : Attribute
	{
		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06002C93 RID: 11411 RVA: 0x00013831 File Offset: 0x00011A31
		public string BasePath
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
