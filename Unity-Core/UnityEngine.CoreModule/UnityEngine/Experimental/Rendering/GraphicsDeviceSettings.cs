using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000366 RID: 870
	public static class GraphicsDeviceSettings
	{
		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06002EED RID: 12013 RVA: 0x00014EF0 File Offset: 0x000130F0
		// (set) Token: 0x06002EEE RID: 12014 RVA: 0x00014EFC File Offset: 0x000130FC
		public static WaitForPresentSyncPoint waitForPresentSyncPoint
		{
			get
			{
				return GraphicsDeviceSettings.get_waitForPresentSyncPointDelegateField();
			}
			set
			{
				GraphicsDeviceSettings.set_waitForPresentSyncPointDelegateField(value);
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06002EEF RID: 12015 RVA: 0x00014F09 File Offset: 0x00013109
		// (set) Token: 0x06002EF0 RID: 12016 RVA: 0x00014F15 File Offset: 0x00013115
		public static GraphicsJobsSyncPoint graphicsJobsSyncPoint
		{
			get
			{
				return GraphicsDeviceSettings.get_graphicsJobsSyncPointDelegateField();
			}
			set
			{
				GraphicsDeviceSettings.set_graphicsJobsSyncPointDelegateField(value);
			}
		}

		// Token: 0x0400296D RID: 10605
		private static readonly GraphicsDeviceSettings.get_waitForPresentSyncPointDelegate get_waitForPresentSyncPointDelegateField = IL2CPP.ResolveICall<GraphicsDeviceSettings.get_waitForPresentSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::get_waitForPresentSyncPoint");

		// Token: 0x0400296E RID: 10606
		private static readonly GraphicsDeviceSettings.set_waitForPresentSyncPointDelegate set_waitForPresentSyncPointDelegateField = IL2CPP.ResolveICall<GraphicsDeviceSettings.set_waitForPresentSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::set_waitForPresentSyncPoint");

		// Token: 0x0400296F RID: 10607
		private static readonly GraphicsDeviceSettings.get_graphicsJobsSyncPointDelegate get_graphicsJobsSyncPointDelegateField = IL2CPP.ResolveICall<GraphicsDeviceSettings.get_graphicsJobsSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::get_graphicsJobsSyncPoint");

		// Token: 0x04002970 RID: 10608
		private static readonly GraphicsDeviceSettings.set_graphicsJobsSyncPointDelegate set_graphicsJobsSyncPointDelegateField = IL2CPP.ResolveICall<GraphicsDeviceSettings.set_graphicsJobsSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::set_graphicsJobsSyncPoint");

		// Token: 0x02000D16 RID: 3350
		// (Invoke) Token: 0x060042C5 RID: 17093
		private delegate WaitForPresentSyncPoint get_waitForPresentSyncPointDelegate();

		// Token: 0x02000D17 RID: 3351
		// (Invoke) Token: 0x060042C7 RID: 17095
		private delegate void set_waitForPresentSyncPointDelegate(WaitForPresentSyncPoint value);

		// Token: 0x02000D18 RID: 3352
		// (Invoke) Token: 0x060042C9 RID: 17097
		private delegate GraphicsJobsSyncPoint get_graphicsJobsSyncPointDelegate();

		// Token: 0x02000D19 RID: 3353
		// (Invoke) Token: 0x060042CB RID: 17099
		private delegate void set_graphicsJobsSyncPointDelegate(GraphicsJobsSyncPoint value);
	}
}
