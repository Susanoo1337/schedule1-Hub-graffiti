using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020002D1 RID: 721
	public sealed class OcclusionPortal : Component
	{
		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06002CFD RID: 11517 RVA: 0x00013C6F File Offset: 0x00011E6F
		// (set) Token: 0x06002CFE RID: 11518 RVA: 0x00013C81 File Offset: 0x00011E81
		public bool open
		{
			get
			{
				return OcclusionPortal.get_openDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				OcclusionPortal.set_openDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0400273F RID: 10047
		private static readonly OcclusionPortal.get_openDelegate get_openDelegateField = IL2CPP.ResolveICall<OcclusionPortal.get_openDelegate>("UnityEngine.OcclusionPortal::get_open");

		// Token: 0x04002740 RID: 10048
		private static readonly OcclusionPortal.set_openDelegate set_openDelegateField = IL2CPP.ResolveICall<OcclusionPortal.set_openDelegate>("UnityEngine.OcclusionPortal::set_open");

		// Token: 0x02000C9B RID: 3227
		// (Invoke) Token: 0x060041D3 RID: 16851
		private delegate bool get_openDelegate(IntPtr @this);

		// Token: 0x02000C9C RID: 3228
		// (Invoke) Token: 0x060041D5 RID: 16853
		private delegate void set_openDelegate(IntPtr @this, bool value);
	}
}
