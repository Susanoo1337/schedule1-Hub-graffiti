using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.IO.Archive
{
	// Token: 0x02000033 RID: 51
	public sealed class ArchiveFileInfo : ValueType
	{
		// Token: 0x060001C8 RID: 456 RVA: 0x0001CE1C File Offset: 0x0001B01C
		// Note: this type is marked as 'beforefieldinit'.
		static ArchiveFileInfo()
		{
			Il2CppClassPointerStore<ArchiveFileInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.Archive", "ArchiveFileInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchiveFileInfo>.NativeClassPtr);
			ArchiveFileInfo.NativeFieldInfoPtr_Filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchiveFileInfo>.NativeClassPtr, "Filename");
			ArchiveFileInfo.NativeFieldInfoPtr_FileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchiveFileInfo>.NativeClassPtr, "FileSize");
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002EEB File Offset: 0x000010EB
		public ArchiveFileInfo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002EF4 File Offset: 0x000010F4
		public ArchiveFileInfo() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchiveFileInfo>.NativeClassPtr))
		{
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001CB RID: 459 RVA: 0x0001CE74 File Offset: 0x0001B074
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00002F06 File Offset: 0x00001106
		public unsafe string Filename
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchiveFileInfo.NativeFieldInfoPtr_Filename);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchiveFileInfo.NativeFieldInfoPtr_Filename), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0001CE9C File Offset: 0x0001B09C
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00002F25 File Offset: 0x00001125
		public unsafe ulong FileSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchiveFileInfo.NativeFieldInfoPtr_FileSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchiveFileInfo.NativeFieldInfoPtr_FileSize)) = value;
			}
		}

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeFieldInfoPtr_Filename;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeFieldInfoPtr_FileSize;
	}
}
