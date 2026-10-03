using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x0200029A RID: 666
	public static class VirtualFileSystem
	{
		// Token: 0x06002C82 RID: 11394 RVA: 0x000AB4B4 File Offset: 0x000A96B4
		public unsafe static bool GetLocalFileSystemName(string vfsFileName, out string localFileName, out ulong localFileOffset, out ulong localFileSize)
		{
			VirtualFileSystem.GetLocalFileSystemNameDelegate getLocalFileSystemNameDelegateField = VirtualFileSystem.GetLocalFileSystemNameDelegateField;
			IntPtr vfsFileName2 = IL2CPP.ManagedStringToIl2Cpp(vfsFileName);
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(localFileName);
			return getLocalFileSystemNameDelegateField(vfsFileName2, &intPtr, out localFileOffset, out localFileSize);
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x000AB4E0 File Offset: 0x000A96E0
		public static string ToLogicalPath(string physicalPath)
		{
			IntPtr intPtr = VirtualFileSystem.ToLogicalPathDelegateField(IL2CPP.ManagedStringToIl2Cpp(physicalPath));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x040026C1 RID: 9921
		private static readonly VirtualFileSystem.GetLocalFileSystemNameDelegate GetLocalFileSystemNameDelegateField = IL2CPP.ResolveICall<VirtualFileSystem.GetLocalFileSystemNameDelegate>("Unity.IO.LowLevel.Unsafe.VirtualFileSystem::GetLocalFileSystemName");

		// Token: 0x040026C2 RID: 9922
		private static readonly VirtualFileSystem.ToLogicalPathDelegate ToLogicalPathDelegateField = IL2CPP.ResolveICall<VirtualFileSystem.ToLogicalPathDelegate>("Unity.IO.LowLevel.Unsafe.VirtualFileSystem::ToLogicalPath");

		// Token: 0x02000C69 RID: 3177
		// (Invoke) Token: 0x06004171 RID: 16753
		private delegate bool GetLocalFileSystemNameDelegate(IntPtr vfsFileName, [Out] IntPtr localFileName, [Out] IntPtr localFileOffset, [Out] IntPtr localFileSize);

		// Token: 0x02000C6A RID: 3178
		// (Invoke) Token: 0x06004173 RID: 16755
		private delegate IntPtr ToLogicalPathDelegate(IntPtr physicalPath);
	}
}
