using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Jobs
{
	// Token: 0x0200028F RID: 655
	public static class JobValidationInternal
	{
		// Token: 0x06002C4A RID: 11338 RVA: 0x000135CA File Offset: 0x000117CA
		public static void CheckReflectionDataCorrect<T>(IntPtr reflectionData)
		{
		}

		// Token: 0x06002C4B RID: 11339 RVA: 0x000AB0A4 File Offset: 0x000A92A4
		public static void CheckReflectionDataCorrectInternal<T>(IntPtr reflectionData, ref bool burstCompiled)
		{
			bool flag = reflectionData == IntPtr.Zero;
			if (flag)
			{
				throw new InvalidOperationException(String.Format("Reflection data was not set up by an Initialize() call. Support for burst compiled calls to Schedule depends on the Collections package.\n\nFor generic job types, please include [assembly: RegisterGenericJobType(typeof({0}))] in your source file.", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
			}
			burstCompiled = false;
		}
	}
}
