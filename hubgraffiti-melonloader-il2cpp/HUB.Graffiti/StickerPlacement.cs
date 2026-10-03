using System;
using System.Runtime.CompilerServices;

namespace HUB.Graffiti
{
	// Token: 0x0200000D RID: 13
	[NullableContext(1)]
	[Nullable(0)]
	internal class StickerPlacement
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000064A1 File Offset: 0x000046A1
		// (set) Token: 0x0600004D RID: 77 RVA: 0x000064A9 File Offset: 0x000046A9
		public string SurfaceGuid { get; set; } = "";

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600004E RID: 78 RVA: 0x000064B2 File Offset: 0x000046B2
		// (set) Token: 0x0600004F RID: 79 RVA: 0x000064BA File Offset: 0x000046BA
		public string StickerFileName { get; set; } = "";
	}
}
