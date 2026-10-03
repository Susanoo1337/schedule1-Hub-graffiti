using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Jobs;
using UnityEngine;

namespace Unity.IO.Archive
{
	// Token: 0x02000035 RID: 53
	public static class ArchiveFileInterface : Il2CppSystem.Object
	{
		// Token: 0x060001D9 RID: 473 RVA: 0x0001CFEC File Offset: 0x0001B1EC
		// Note: this type is marked as 'beforefieldinit'.
		static ArchiveFileInterface()
		{
			Il2CppClassPointerStore<ArchiveFileInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.Archive", "ArchiveFileInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchiveFileInterface>.NativeClassPtr);
			ArchiveFileInterface.Archive_GetStatus_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_GetStatus_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_GetStatus_Injected");
			ArchiveFileInterface.Archive_GetJobHandle_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_GetJobHandle_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_GetJobHandle_Injected");
			ArchiveFileInterface.Archive_IsValid_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_IsValid_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_IsValid_Injected");
			ArchiveFileInterface.Archive_UnmountAsync_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_UnmountAsync_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_UnmountAsync_Injected");
			ArchiveFileInterface.Archive_GetMountPath_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_GetMountPath_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_GetMountPath_Injected");
			ArchiveFileInterface.Archive_GetCompression_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_GetCompression_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_GetCompression_Injected");
			ArchiveFileInterface.Archive_IsStreamed_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_IsStreamed_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_IsStreamed_Injected");
			ArchiveFileInterface.Archive_GetFileInfo_InjectedDelegateField = IL2CPP.ResolveICall<ArchiveFileInterface.Archive_GetFileInfo_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_GetFileInfo_Injected");
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002F8B File Offset: 0x0000118B
		public ArchiveFileInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002F94 File Offset: 0x00001194
		public static ArchiveStatus Archive_GetStatus(ArchiveHandle handle)
		{
			return ArchiveFileInterface.Archive_GetStatus_Injected(ref handle);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0001D094 File Offset: 0x0001B294
		public static Unity.Jobs.JobHandle Archive_GetJobHandle(ArchiveHandle handle)
		{
			Unity.Jobs.JobHandle result;
			ArchiveFileInterface.Archive_GetJobHandle_Injected(ref handle, out result);
			return result;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002F9D File Offset: 0x0000119D
		public static bool Archive_IsValid(ArchiveHandle handle)
		{
			return ArchiveFileInterface.Archive_IsValid_Injected(ref handle);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0001D0AC File Offset: 0x0001B2AC
		public static Unity.Jobs.JobHandle Archive_UnmountAsync(ArchiveHandle handle)
		{
			Unity.Jobs.JobHandle result;
			ArchiveFileInterface.Archive_UnmountAsync_Injected(ref handle, out result);
			return result;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002FA6 File Offset: 0x000011A6
		public static string Archive_GetMountPath(ArchiveHandle handle)
		{
			return ArchiveFileInterface.Archive_GetMountPath_Injected(ref handle);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002FAF File Offset: 0x000011AF
		public static UnityEngine.CompressionType Archive_GetCompression(ArchiveHandle handle)
		{
			return ArchiveFileInterface.Archive_GetCompression_Injected(ref handle);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002FB8 File Offset: 0x000011B8
		public static bool Archive_IsStreamed(ArchiveHandle handle)
		{
			return ArchiveFileInterface.Archive_IsStreamed_Injected(ref handle);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002FC1 File Offset: 0x000011C1
		public static Il2CppReferenceArray<ArchiveFileInfo> Archive_GetFileInfo(ArchiveHandle handle)
		{
			return ArchiveFileInterface.Archive_GetFileInfo_Injected(ref handle);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002FCA File Offset: 0x000011CA
		public static ArchiveStatus Archive_GetStatus_Injected(ref ArchiveHandle handle)
		{
			return ArchiveFileInterface.Archive_GetStatus_InjectedDelegateField(ref handle);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002FD7 File Offset: 0x000011D7
		public static void Archive_GetJobHandle_Injected(ref ArchiveHandle handle, out Unity.Jobs.JobHandle ret)
		{
			ArchiveFileInterface.Archive_GetJobHandle_InjectedDelegateField(ref handle, out ret);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002FE5 File Offset: 0x000011E5
		public static bool Archive_IsValid_Injected(ref ArchiveHandle handle)
		{
			return ArchiveFileInterface.Archive_IsValid_InjectedDelegateField(ref handle);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002FF2 File Offset: 0x000011F2
		public static void Archive_UnmountAsync_Injected(ref ArchiveHandle handle, out Unity.Jobs.JobHandle ret)
		{
			ArchiveFileInterface.Archive_UnmountAsync_InjectedDelegateField(ref handle, out ret);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0001D0C4 File Offset: 0x0001B2C4
		public static string Archive_GetMountPath_Injected(ref ArchiveHandle handle)
		{
			IntPtr intPtr = ArchiveFileInterface.Archive_GetMountPath_InjectedDelegateField(ref handle);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00003000 File Offset: 0x00001200
		public static UnityEngine.CompressionType Archive_GetCompression_Injected(ref ArchiveHandle handle)
		{
			return ArchiveFileInterface.Archive_GetCompression_InjectedDelegateField(ref handle);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000300D File Offset: 0x0000120D
		public static bool Archive_IsStreamed_Injected(ref ArchiveHandle handle)
		{
			return ArchiveFileInterface.Archive_IsStreamed_InjectedDelegateField(ref handle);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0001D0E4 File Offset: 0x0001B2E4
		public static Il2CppReferenceArray<ArchiveFileInfo> Archive_GetFileInfo_Injected(ref ArchiveHandle handle)
		{
			IntPtr intPtr = ArchiveFileInterface.Archive_GetFileInfo_InjectedDelegateField(ref handle);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ArchiveFileInfo>>(intPtr2) : null;
		}

		// Token: 0x04000189 RID: 393
		private static readonly ArchiveFileInterface.Archive_GetStatus_InjectedDelegate Archive_GetStatus_InjectedDelegateField;

		// Token: 0x0400018A RID: 394
		private static readonly ArchiveFileInterface.Archive_GetJobHandle_InjectedDelegate Archive_GetJobHandle_InjectedDelegateField;

		// Token: 0x0400018B RID: 395
		private static readonly ArchiveFileInterface.Archive_IsValid_InjectedDelegate Archive_IsValid_InjectedDelegateField;

		// Token: 0x0400018C RID: 396
		private static readonly ArchiveFileInterface.Archive_UnmountAsync_InjectedDelegate Archive_UnmountAsync_InjectedDelegateField;

		// Token: 0x0400018D RID: 397
		private static readonly ArchiveFileInterface.Archive_GetMountPath_InjectedDelegate Archive_GetMountPath_InjectedDelegateField;

		// Token: 0x0400018E RID: 398
		private static readonly ArchiveFileInterface.Archive_GetCompression_InjectedDelegate Archive_GetCompression_InjectedDelegateField;

		// Token: 0x0400018F RID: 399
		private static readonly ArchiveFileInterface.Archive_IsStreamed_InjectedDelegate Archive_IsStreamed_InjectedDelegateField;

		// Token: 0x04000190 RID: 400
		private static readonly ArchiveFileInterface.Archive_GetFileInfo_InjectedDelegate Archive_GetFileInfo_InjectedDelegateField;

		// Token: 0x020003B4 RID: 948
		// (Invoke) Token: 0x06002FF4 RID: 12276
		private delegate ArchiveStatus Archive_GetStatus_InjectedDelegate(IntPtr handle);

		// Token: 0x020003B5 RID: 949
		// (Invoke) Token: 0x06002FF6 RID: 12278
		private delegate void Archive_GetJobHandle_InjectedDelegate(IntPtr handle, [Out] IntPtr ret);

		// Token: 0x020003B6 RID: 950
		// (Invoke) Token: 0x06002FF8 RID: 12280
		private delegate bool Archive_IsValid_InjectedDelegate(IntPtr handle);

		// Token: 0x020003B7 RID: 951
		// (Invoke) Token: 0x06002FFA RID: 12282
		private delegate void Archive_UnmountAsync_InjectedDelegate(IntPtr handle, [Out] IntPtr ret);

		// Token: 0x020003B8 RID: 952
		// (Invoke) Token: 0x06002FFC RID: 12284
		private delegate IntPtr Archive_GetMountPath_InjectedDelegate(IntPtr handle);

		// Token: 0x020003B9 RID: 953
		// (Invoke) Token: 0x06002FFE RID: 12286
		private delegate UnityEngine.CompressionType Archive_GetCompression_InjectedDelegate(IntPtr handle);

		// Token: 0x020003BA RID: 954
		// (Invoke) Token: 0x06003000 RID: 12288
		private delegate bool Archive_IsStreamed_InjectedDelegate(IntPtr handle);

		// Token: 0x020003BB RID: 955
		// (Invoke) Token: 0x06003002 RID: 12290
		private delegate IntPtr Archive_GetFileInfo_InjectedDelegate(IntPtr handle);
	}
}
