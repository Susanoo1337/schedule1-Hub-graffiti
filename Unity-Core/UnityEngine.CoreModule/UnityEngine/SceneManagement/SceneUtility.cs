using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.SceneManagement
{
	// Token: 0x0200032B RID: 811
	public static class SceneUtility
	{
		// Token: 0x06002DC2 RID: 11714 RVA: 0x000ACF94 File Offset: 0x000AB194
		public static string GetScenePathByBuildIndex(int buildIndex)
		{
			IntPtr intPtr = SceneUtility.GetScenePathByBuildIndexDelegateField(buildIndex);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x00014536 File Offset: 0x00012736
		public static int GetBuildIndexByScenePath(string scenePath)
		{
			return SceneUtility.GetBuildIndexByScenePathDelegateField(IL2CPP.ManagedStringToIl2Cpp(scenePath));
		}

		// Token: 0x04002897 RID: 10391
		private static readonly SceneUtility.GetScenePathByBuildIndexDelegate GetScenePathByBuildIndexDelegateField = IL2CPP.ResolveICall<SceneUtility.GetScenePathByBuildIndexDelegate>("UnityEngine.SceneManagement.SceneUtility::GetScenePathByBuildIndex");

		// Token: 0x04002898 RID: 10392
		private static readonly SceneUtility.GetBuildIndexByScenePathDelegate GetBuildIndexByScenePathDelegateField = IL2CPP.ResolveICall<SceneUtility.GetBuildIndexByScenePathDelegate>("UnityEngine.SceneManagement.SceneUtility::GetBuildIndexByScenePath");

		// Token: 0x02000CEA RID: 3306
		// (Invoke) Token: 0x0600426F RID: 17007
		private delegate IntPtr GetScenePathByBuildIndexDelegate(int buildIndex);

		// Token: 0x02000CEB RID: 3307
		// (Invoke) Token: 0x06004271 RID: 17009
		private delegate int GetBuildIndexByScenePathDelegate(IntPtr scenePath);
	}
}
