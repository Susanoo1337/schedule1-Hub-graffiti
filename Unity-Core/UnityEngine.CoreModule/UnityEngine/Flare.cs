using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020002D2 RID: 722
	public sealed class Flare : Object
	{
		// Token: 0x06002D00 RID: 11520 RVA: 0x00013CA5 File Offset: 0x00011EA5
		public static void Internal_Create(Flare self)
		{
			Flare.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x04002741 RID: 10049
		private static readonly Flare.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<Flare.Internal_CreateDelegate>("UnityEngine.Flare::Internal_Create");

		// Token: 0x02000C9D RID: 3229
		// (Invoke) Token: 0x060041D7 RID: 16855
		private delegate void Internal_CreateDelegate(IntPtr self);
	}
}
