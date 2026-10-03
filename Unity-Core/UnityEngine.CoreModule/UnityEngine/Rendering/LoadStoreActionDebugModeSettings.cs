using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000334 RID: 820
	public static class LoadStoreActionDebugModeSettings
	{
		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06002DCE RID: 11726 RVA: 0x000145F3 File Offset: 0x000127F3
		// (set) Token: 0x06002DCF RID: 11727 RVA: 0x000145FF File Offset: 0x000127FF
		public static bool LoadStoreDebugModeEnabled
		{
			get
			{
				return LoadStoreActionDebugModeSettings.get_LoadStoreDebugModeEnabledDelegateField();
			}
			set
			{
				LoadStoreActionDebugModeSettings.set_LoadStoreDebugModeEnabledDelegateField(value);
			}
		}

		// Token: 0x040028A1 RID: 10401
		private static readonly LoadStoreActionDebugModeSettings.get_LoadStoreDebugModeEnabledDelegate get_LoadStoreDebugModeEnabledDelegateField = IL2CPP.ResolveICall<LoadStoreActionDebugModeSettings.get_LoadStoreDebugModeEnabledDelegate>("UnityEngine.Rendering.LoadStoreActionDebugModeSettings::get_LoadStoreDebugModeEnabled");

		// Token: 0x040028A2 RID: 10402
		private static readonly LoadStoreActionDebugModeSettings.set_LoadStoreDebugModeEnabledDelegate set_LoadStoreDebugModeEnabledDelegateField = IL2CPP.ResolveICall<LoadStoreActionDebugModeSettings.set_LoadStoreDebugModeEnabledDelegate>("UnityEngine.Rendering.LoadStoreActionDebugModeSettings::set_LoadStoreDebugModeEnabled");

		// Token: 0x02000CF0 RID: 3312
		// (Invoke) Token: 0x0600427B RID: 17019
		private delegate bool get_LoadStoreDebugModeEnabledDelegate();

		// Token: 0x02000CF1 RID: 3313
		// (Invoke) Token: 0x0600427D RID: 17021
		private delegate void set_LoadStoreDebugModeEnabledDelegate(bool value);
	}
}
