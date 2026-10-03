using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x020002EF RID: 751
	public static class TextureMipmapLimitGroups
	{
		// Token: 0x06002D13 RID: 11539 RVA: 0x000ABE48 File Offset: 0x000AA048
		public static Il2CppStringArray GetGroups()
		{
			IntPtr intPtr = TextureMipmapLimitGroups.GetGroupsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x00013DF2 File Offset: 0x00011FF2
		public static bool HasGroup(string groupName)
		{
			return TextureMipmapLimitGroups.HasGroupDelegateField(IL2CPP.ManagedStringToIl2Cpp(groupName));
		}

		// Token: 0x040027C9 RID: 10185
		private static readonly TextureMipmapLimitGroups.GetGroupsDelegate GetGroupsDelegateField = IL2CPP.ResolveICall<TextureMipmapLimitGroups.GetGroupsDelegate>("UnityEngine.TextureMipmapLimitGroups::GetGroups");

		// Token: 0x040027CA RID: 10186
		private static readonly TextureMipmapLimitGroups.HasGroupDelegate HasGroupDelegateField = IL2CPP.ResolveICall<TextureMipmapLimitGroups.HasGroupDelegate>("UnityEngine.TextureMipmapLimitGroups::HasGroup");

		// Token: 0x02000CAE RID: 3246
		// (Invoke) Token: 0x060041F9 RID: 16889
		private delegate IntPtr GetGroupsDelegate();

		// Token: 0x02000CAF RID: 3247
		// (Invoke) Token: 0x060041FB RID: 16891
		private delegate bool HasGroupDelegate(IntPtr groupName);
	}
}
