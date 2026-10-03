using System;
using Il2CppSystem;

namespace JetBrains.Annotations
{
	// Token: 0x020002A6 RID: 678
	public sealed class BaseTypeRequiredAttribute : Attribute
	{
		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06002C8E RID: 11406 RVA: 0x000137F0 File Offset: 0x000119F0
		public Type BaseType
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
