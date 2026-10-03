using System;

namespace UnityEngine
{
	// Token: 0x02000151 RID: 337
	[Flags]
	public enum HideFlags
	{
		// Token: 0x0400150D RID: 5389
		None = 0,
		// Token: 0x0400150E RID: 5390
		HideInHierarchy = 1,
		// Token: 0x0400150F RID: 5391
		HideInInspector = 2,
		// Token: 0x04001510 RID: 5392
		DontSaveInEditor = 4,
		// Token: 0x04001511 RID: 5393
		NotEditable = 8,
		// Token: 0x04001512 RID: 5394
		DontSaveInBuild = 16,
		// Token: 0x04001513 RID: 5395
		DontUnloadUnusedAsset = 32,
		// Token: 0x04001514 RID: 5396
		DontSave = 52,
		// Token: 0x04001515 RID: 5397
		HideAndDontSave = 61
	}
}
