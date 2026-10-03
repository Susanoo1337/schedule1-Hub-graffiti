using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Unity.Jobs;
using UnityEngine;

namespace Unity.IO.Archive
{
	// Token: 0x02000034 RID: 52
	[StructLayout(2)]
	public struct ArchiveHandle
	{
		// Token: 0x060001CF RID: 463 RVA: 0x00002F40 File Offset: 0x00001140
		// Note: this type is marked as 'beforefieldinit'.
		static ArchiveHandle()
		{
			Il2CppClassPointerStore<ArchiveHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.Archive", "ArchiveHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchiveHandle>.NativeClassPtr);
			ArchiveHandle.NativeFieldInfoPtr_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchiveHandle>.NativeClassPtr, "Handle");
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002F79 File Offset: 0x00001179
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ArchiveHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0001CEC4 File Offset: 0x0001B0C4
		public ArchiveStatus Status
		{
			get
			{
				this.ThrowIfInvalid();
				return ArchiveFileInterface.Archive_GetStatus(this);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x0001CEE8 File Offset: 0x0001B0E8
		public Unity.Jobs.JobHandle JobHandle
		{
			get
			{
				this.ThrowIfInvalid();
				return ArchiveFileInterface.Archive_GetJobHandle(this);
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0001CF0C File Offset: 0x0001B10C
		public Unity.Jobs.JobHandle Unmount()
		{
			this.ThrowIfInvalid();
			return ArchiveFileInterface.Archive_UnmountAsync(this);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0001CF30 File Offset: 0x0001B130
		public void ThrowIfInvalid()
		{
			bool flag = !ArchiveFileInterface.Archive_IsValid(this);
			if (flag)
			{
				throw new InvalidOperationException("The archive has already been unmounted.");
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0001CF5C File Offset: 0x0001B15C
		public string GetMountPath()
		{
			this.ThrowIfInvalid();
			return ArchiveFileInterface.Archive_GetMountPath(this);
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0001CF80 File Offset: 0x0001B180
		public UnityEngine.CompressionType Compression
		{
			get
			{
				this.ThrowIfInvalid();
				return ArchiveFileInterface.Archive_GetCompression(this);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0001CFA4 File Offset: 0x0001B1A4
		public bool IsStreamed
		{
			get
			{
				this.ThrowIfInvalid();
				return ArchiveFileInterface.Archive_IsStreamed(this);
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0001CFC8 File Offset: 0x0001B1C8
		public Il2CppReferenceArray<ArchiveFileInfo> GetFileInfo()
		{
			this.ThrowIfInvalid();
			return ArchiveFileInterface.Archive_GetFileInfo(this);
		}

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeFieldInfoPtr_Handle;

		// Token: 0x04000188 RID: 392
		[FieldOffset(0)]
		public ulong Handle;
	}
}
