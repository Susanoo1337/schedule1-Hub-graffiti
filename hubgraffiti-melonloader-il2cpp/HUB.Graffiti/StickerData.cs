using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace HUB.Graffiti
{
	// Token: 0x0200000A RID: 10
	[NullableContext(1)]
	[Nullable(0)]
	internal class StickerData
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00004CC8 File Offset: 0x00002EC8
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00004CD0 File Offset: 0x00002ED0
		public string Name { get; set; } = "";

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00004CD9 File Offset: 0x00002ED9
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00004CE1 File Offset: 0x00002EE1
		public string FilePath { get; set; } = "";

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00004CEA File Offset: 0x00002EEA
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00004CF2 File Offset: 0x00002EF2
		[Nullable(2)]
		public Texture2D Texture { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00004CFB File Offset: 0x00002EFB
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00004D03 File Offset: 0x00002F03
		[Nullable(2)]
		public Sprite Sprite { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
