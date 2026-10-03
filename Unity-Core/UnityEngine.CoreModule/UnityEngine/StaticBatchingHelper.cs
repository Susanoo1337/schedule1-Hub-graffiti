using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine
{
	// Token: 0x020002F2 RID: 754
	public struct StaticBatchingHelper
	{
		// Token: 0x06002D1F RID: 11551 RVA: 0x00013EB7 File Offset: 0x000120B7
		public static void CombineMeshes(Il2CppReferenceArray<GameObject> gos, GameObject staticBatchRoot)
		{
			StaticBatchingHelper.CombineMeshesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(gos), IL2CPP.Il2CppObjectBaseToPtr(staticBatchRoot));
		}

		// Token: 0x040027D3 RID: 10195
		private static readonly StaticBatchingHelper.CombineMeshesDelegate CombineMeshesDelegateField = IL2CPP.ResolveICall<StaticBatchingHelper.CombineMeshesDelegate>("UnityEngine.StaticBatchingHelper::CombineMeshes");

		// Token: 0x02000CB4 RID: 3252
		// (Invoke) Token: 0x06004205 RID: 16901
		private delegate void CombineMeshesDelegate(IntPtr gos, IntPtr staticBatchRoot);
	}
}
