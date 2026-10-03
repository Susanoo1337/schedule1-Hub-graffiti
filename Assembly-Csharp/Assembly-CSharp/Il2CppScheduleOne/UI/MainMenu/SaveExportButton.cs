using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020007FE RID: 2046
	public class SaveExportButton : MonoBehaviour
	{
		// Token: 0x0600C6E6 RID: 50918 RVA: 0x00325CDC File Offset: 0x00323EDC
		// Note: this type is marked as 'beforefieldinit'.
		static SaveExportButton()
		{
			Il2CppClassPointerStore<SaveExportButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "SaveExportButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveExportButton>.NativeClassPtr);
			SaveExportButton.NativeFieldInfoPtr_SaveSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveExportButton>.NativeClassPtr, "SaveSlotIndex");
			SaveExportButton.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveExportButton>.NativeClassPtr, 100689056);
			SaveExportButton.NativeMethodInfoPtr_Clicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveExportButton>.NativeClassPtr, 100689057);
			SaveExportButton.NativeMethodInfoPtr_ShowSaveFileDialog_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveExportButton>.NativeClassPtr, 100689058);
			SaveExportButton.NativeMethodInfoPtr_ZipSaveFolder_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveExportButton>.NativeClassPtr, 100689059);
			SaveExportButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveExportButton>.NativeClassPtr, 100689060);
		}

		// Token: 0x0600C6E7 RID: 50919 RVA: 0x00325D84 File Offset: 0x00323F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328251, XrefRangeEnd = 328262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveExportButton.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6E8 RID: 50920 RVA: 0x00325DB8 File Offset: 0x00323FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328262, XrefRangeEnd = 328322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveExportButton.NativeMethodInfoPtr_Clicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6E9 RID: 50921 RVA: 0x00325DEC File Offset: 0x00323FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328322, XrefRangeEnd = 328346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ShowSaveFileDialog(string fileName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveExportButton.NativeMethodInfoPtr_ShowSaveFileDialog_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600C6EA RID: 50922 RVA: 0x00325E28 File Offset: 0x00324028
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328349, RefRangeEnd = 328350, XrefRangeStart = 328346, XrefRangeEnd = 328349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ZipSaveFolder(string sourceFolderPath, string destinationZipPath)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceFolderPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destinationZipPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveExportButton.NativeMethodInfoPtr_ZipSaveFolder_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6EB RID: 50923 RVA: 0x00325E70 File Offset: 0x00324070
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveExportButton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveExportButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveExportButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6EC RID: 50924 RVA: 0x0005DE88 File Offset: 0x0005C088
		public SaveExportButton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C5A RID: 15450
		// (get) Token: 0x0600C6ED RID: 50925 RVA: 0x00325EAC File Offset: 0x003240AC
		// (set) Token: 0x0600C6EE RID: 50926 RVA: 0x0005DE91 File Offset: 0x0005C091
		public unsafe int SaveSlotIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveExportButton.NativeFieldInfoPtr_SaveSlotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveExportButton.NativeFieldInfoPtr_SaveSlotIndex)) = value;
			}
		}

		// Token: 0x040087A3 RID: 34723
		private static readonly IntPtr NativeFieldInfoPtr_SaveSlotIndex;

		// Token: 0x040087A4 RID: 34724
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040087A5 RID: 34725
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Private_Void_0;

		// Token: 0x040087A6 RID: 34726
		private static readonly IntPtr NativeMethodInfoPtr_ShowSaveFileDialog_Public_Static_String_String_0;

		// Token: 0x040087A7 RID: 34727
		private static readonly IntPtr NativeMethodInfoPtr_ZipSaveFolder_Public_Static_Void_String_String_0;

		// Token: 0x040087A8 RID: 34728
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
