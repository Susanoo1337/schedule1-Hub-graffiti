using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x02000306 RID: 774
	public sealed class Security
	{
		// Token: 0x06002D53 RID: 11603 RVA: 0x000AC2EC File Offset: 0x000AA4EC
		public static Assembly LoadAndVerifyAssembly(Il2CppStructArray<byte> assemblyData, string authorizationKey)
		{
			return null;
		}

		// Token: 0x06002D54 RID: 11604 RVA: 0x000AC300 File Offset: 0x000AA500
		public static Assembly LoadAndVerifyAssembly(Il2CppStructArray<byte> assemblyData)
		{
			return null;
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x000AC314 File Offset: 0x000AA514
		public static bool PrefetchSocketPolicy(string ip, int atPort)
		{
			int timeout = 3000;
			return Security.PrefetchSocketPolicy(ip, atPort, timeout);
		}

		// Token: 0x06002D56 RID: 11606 RVA: 0x000AC334 File Offset: 0x000AA534
		public static bool PrefetchSocketPolicy(string ip, int atPort, int timeout)
		{
			return false;
		}
	}
}
