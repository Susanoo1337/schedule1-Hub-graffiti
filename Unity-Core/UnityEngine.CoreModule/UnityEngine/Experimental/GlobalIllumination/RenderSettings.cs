using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200035F RID: 863
	public class RenderSettings
	{
		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06002EDF RID: 11999 RVA: 0x00014E0C File Offset: 0x0001300C
		// (set) Token: 0x06002EE0 RID: 12000 RVA: 0x00014E18 File Offset: 0x00013018
		public static bool useRadianceAmbientProbe
		{
			get
			{
				return RenderSettings.get_useRadianceAmbientProbeDelegateField();
			}
			set
			{
				RenderSettings.set_useRadianceAmbientProbeDelegateField(value);
			}
		}

		// Token: 0x0400295F RID: 10591
		private static readonly RenderSettings.get_useRadianceAmbientProbeDelegate get_useRadianceAmbientProbeDelegateField = IL2CPP.ResolveICall<RenderSettings.get_useRadianceAmbientProbeDelegate>("UnityEngine.Experimental.GlobalIllumination.RenderSettings::get_useRadianceAmbientProbe");

		// Token: 0x04002960 RID: 10592
		private static readonly RenderSettings.set_useRadianceAmbientProbeDelegate set_useRadianceAmbientProbeDelegateField = IL2CPP.ResolveICall<RenderSettings.set_useRadianceAmbientProbeDelegate>("UnityEngine.Experimental.GlobalIllumination.RenderSettings::set_useRadianceAmbientProbe");

		// Token: 0x02000D10 RID: 3344
		// (Invoke) Token: 0x060042B9 RID: 17081
		private delegate bool get_useRadianceAmbientProbeDelegate();

		// Token: 0x02000D11 RID: 3345
		// (Invoke) Token: 0x060042BB RID: 17083
		private delegate void set_useRadianceAmbientProbeDelegate(bool value);
	}
}
