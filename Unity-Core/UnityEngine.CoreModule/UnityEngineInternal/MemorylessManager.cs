using System;
using Il2CppInterop.Runtime;

namespace UnityEngineInternal
{
	// Token: 0x02000288 RID: 648
	public class MemorylessManager
	{
		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06002C2F RID: 11311 RVA: 0x000AAF4C File Offset: 0x000A914C
		// (set) Token: 0x06002C30 RID: 11312 RVA: 0x000134A8 File Offset: 0x000116A8
		public static MemorylessMode depthMemorylessMode
		{
			get
			{
				return MemorylessManager.GetFramebufferDepthMemorylessMode();
			}
			set
			{
				MemorylessManager.SetFramebufferDepthMemorylessMode(value);
			}
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x000134B2 File Offset: 0x000116B2
		public static MemorylessMode GetFramebufferDepthMemorylessMode()
		{
			return MemorylessManager.GetFramebufferDepthMemorylessModeDelegateField();
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x000134BE File Offset: 0x000116BE
		public static void SetFramebufferDepthMemorylessMode(MemorylessMode mode)
		{
			MemorylessManager.SetFramebufferDepthMemorylessModeDelegateField(mode);
		}

		// Token: 0x04002673 RID: 9843
		private static readonly MemorylessManager.GetFramebufferDepthMemorylessModeDelegate GetFramebufferDepthMemorylessModeDelegateField = IL2CPP.ResolveICall<MemorylessManager.GetFramebufferDepthMemorylessModeDelegate>("UnityEngineInternal.MemorylessManager::GetFramebufferDepthMemorylessMode");

		// Token: 0x04002674 RID: 9844
		private static readonly MemorylessManager.SetFramebufferDepthMemorylessModeDelegate SetFramebufferDepthMemorylessModeDelegateField = IL2CPP.ResolveICall<MemorylessManager.SetFramebufferDepthMemorylessModeDelegate>("UnityEngineInternal.MemorylessManager::SetFramebufferDepthMemorylessMode");

		// Token: 0x02000C36 RID: 3126
		// (Invoke) Token: 0x0600412D RID: 16685
		private delegate MemorylessMode GetFramebufferDepthMemorylessModeDelegate();

		// Token: 0x02000C37 RID: 3127
		// (Invoke) Token: 0x0600412F RID: 16687
		private delegate void SetFramebufferDepthMemorylessModeDelegate(MemorylessMode mode);
	}
}
