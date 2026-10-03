using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020007FF RID: 2047
	public class SaveImportButton : MonoBehaviour
	{
		// Token: 0x0600C6EF RID: 50927 RVA: 0x00325ED4 File Offset: 0x003240D4
		// Note: this type is marked as 'beforefieldinit'.
		static SaveImportButton()
		{
			Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "SaveImportButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr);
			SaveImportButton.NativeFieldInfoPtr_ImportScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr, "ImportScreen");
			SaveImportButton.NativeFieldInfoPtr_ParentScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr, "ParentScreen");
			SaveImportButton.NativeFieldInfoPtr_SaveSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr, "SaveSlotIndex");
			SaveImportButton.NativeMethodInfoPtr_get_TempImportPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr, 100689061);
			SaveImportButton.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr, 100689062);
			SaveImportButton.NativeMethodInfoPtr_Clicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr, 100689063);
			SaveImportButton.NativeMethodInfoPtr_UnzipSaveFile_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr, 100689064);
			SaveImportButton.NativeMethodInfoPtr_ShowOpenFileDialog_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr, 100689065);
			SaveImportButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr, 100689066);
		}

		// Token: 0x17003C5E RID: 15454
		// (get) Token: 0x0600C6F0 RID: 50928 RVA: 0x00325FB8 File Offset: 0x003241B8
		public unsafe static string TempImportPath
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 328361, RefRangeEnd = 328364, XrefRangeStart = 328350, XrefRangeEnd = 328361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveImportButton.NativeMethodInfoPtr_get_TempImportPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600C6F1 RID: 50929 RVA: 0x00325FE4 File Offset: 0x003241E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328364, XrefRangeEnd = 328375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveImportButton.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6F2 RID: 50930 RVA: 0x00326018 File Offset: 0x00324218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328375, XrefRangeEnd = 328431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveImportButton.NativeMethodInfoPtr_Clicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6F3 RID: 50931 RVA: 0x0032604C File Offset: 0x0032424C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328431, XrefRangeEnd = 328444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnzipSaveFile(string zipFilePath, string destinationFolderPath)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(zipFilePath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destinationFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveImportButton.NativeMethodInfoPtr_UnzipSaveFile_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6F4 RID: 50932 RVA: 0x00326094 File Offset: 0x00324294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328444, XrefRangeEnd = 328468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ShowOpenFileDialog()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveImportButton.NativeMethodInfoPtr_ShowOpenFileDialog_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600C6F5 RID: 50933 RVA: 0x003260C0 File Offset: 0x003242C0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveImportButton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveImportButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6F6 RID: 50934 RVA: 0x0005DEAC File Offset: 0x0005C0AC
		public SaveImportButton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C5B RID: 15451
		// (get) Token: 0x0600C6F7 RID: 50935 RVA: 0x003260FC File Offset: 0x003242FC
		// (set) Token: 0x0600C6F8 RID: 50936 RVA: 0x0005DEB5 File Offset: 0x0005C0B5
		public unsafe ImportScreen ImportScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveImportButton.NativeFieldInfoPtr_ImportScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImportScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveImportButton.NativeFieldInfoPtr_ImportScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C5C RID: 15452
		// (get) Token: 0x0600C6F9 RID: 50937 RVA: 0x0032612C File Offset: 0x0032432C
		// (set) Token: 0x0600C6FA RID: 50938 RVA: 0x0005DED4 File Offset: 0x0005C0D4
		public unsafe MenuScreen ParentScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveImportButton.NativeFieldInfoPtr_ParentScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MenuScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveImportButton.NativeFieldInfoPtr_ParentScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C5D RID: 15453
		// (get) Token: 0x0600C6FB RID: 50939 RVA: 0x0032615C File Offset: 0x0032435C
		// (set) Token: 0x0600C6FC RID: 50940 RVA: 0x0005DEF3 File Offset: 0x0005C0F3
		public unsafe int SaveSlotIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveImportButton.NativeFieldInfoPtr_SaveSlotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveImportButton.NativeFieldInfoPtr_SaveSlotIndex)) = value;
			}
		}

		// Token: 0x040087A9 RID: 34729
		private static readonly IntPtr NativeFieldInfoPtr_ImportScreen;

		// Token: 0x040087AA RID: 34730
		private static readonly IntPtr NativeFieldInfoPtr_ParentScreen;

		// Token: 0x040087AB RID: 34731
		private static readonly IntPtr NativeFieldInfoPtr_SaveSlotIndex;

		// Token: 0x040087AC RID: 34732
		private static readonly IntPtr NativeMethodInfoPtr_get_TempImportPath_Public_Static_get_String_0;

		// Token: 0x040087AD RID: 34733
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040087AE RID: 34734
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Private_Void_0;

		// Token: 0x040087AF RID: 34735
		private static readonly IntPtr NativeMethodInfoPtr_UnzipSaveFile_Public_Static_Void_String_String_0;

		// Token: 0x040087B0 RID: 34736
		private static readonly IntPtr NativeMethodInfoPtr_ShowOpenFileDialog_Public_Static_String_0;

		// Token: 0x040087B1 RID: 34737
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
