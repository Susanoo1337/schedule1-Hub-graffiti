using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000414 RID: 1044
	[Serializable]
	public class OtherSettings : Object
	{
		// Token: 0x06005BA6 RID: 23462 RVA: 0x001B71BC File Offset: 0x001B53BC
		// Note: this type is marked as 'beforefieldinit'.
		static OtherSettings()
		{
			Il2CppClassPointerStore<OtherSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "OtherSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OtherSettings>.NativeClassPtr);
			OtherSettings.NativeFieldInfoPtr_AutoBackupSaves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OtherSettings>.NativeClassPtr, "AutoBackupSaves");
			OtherSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OtherSettings>.NativeClassPtr, 100675254);
		}

		// Token: 0x06005BA7 RID: 23463 RVA: 0x001B7214 File Offset: 0x001B5414
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 197152, RefRangeEnd = 197154, XrefRangeStart = 197151, XrefRangeEnd = 197152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OtherSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OtherSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OtherSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BA8 RID: 23464 RVA: 0x0002B6D2 File Offset: 0x000298D2
		public OtherSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C3D RID: 7229
		// (get) Token: 0x06005BA9 RID: 23465 RVA: 0x001B7250 File Offset: 0x001B5450
		// (set) Token: 0x06005BAA RID: 23466 RVA: 0x0002B6DB File Offset: 0x000298DB
		public unsafe bool AutoBackupSaves
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OtherSettings.NativeFieldInfoPtr_AutoBackupSaves);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OtherSettings.NativeFieldInfoPtr_AutoBackupSaves)) = value;
			}
		}

		// Token: 0x04003ED6 RID: 16086
		private static readonly IntPtr NativeFieldInfoPtr_AutoBackupSaves;

		// Token: 0x04003ED7 RID: 16087
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
