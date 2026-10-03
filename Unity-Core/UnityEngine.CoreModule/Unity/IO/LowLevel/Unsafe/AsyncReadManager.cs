using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Unity.Jobs;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x02000297 RID: 663
	public static class AsyncReadManager
	{
		// Token: 0x06002C4E RID: 11342 RVA: 0x000AB0FC File Offset: 0x000A92FC
		public static Unity.Jobs.JobHandle CloseCachedFileAsync(string fileName, [Optional] Unity.Jobs.JobHandle dependency)
		{
			Unity.Jobs.JobHandle result;
			AsyncReadManager.CloseCachedFileAsync_Injected(fileName, ref dependency, out result);
			return result;
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x000135DE File Offset: 0x000117DE
		public static void CloseCachedFileAsync_Injected(string fileName, [Optional] ref Unity.Jobs.JobHandle dependency, out Unity.Jobs.JobHandle ret)
		{
			AsyncReadManager.CloseCachedFileAsync_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(fileName), ref dependency, out ret);
		}

		// Token: 0x040026B1 RID: 9905
		private static readonly AsyncReadManager.CloseCachedFileAsync_InjectedDelegate CloseCachedFileAsync_InjectedDelegateField = IL2CPP.ResolveICall<AsyncReadManager.CloseCachedFileAsync_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManager::CloseCachedFileAsync_Injected");

		// Token: 0x02000C58 RID: 3160
		// (Invoke) Token: 0x06004151 RID: 16721
		private delegate void CloseCachedFileAsync_InjectedDelegate(IntPtr fileName, IntPtr dependency, [Out] IntPtr ret);
	}
}
