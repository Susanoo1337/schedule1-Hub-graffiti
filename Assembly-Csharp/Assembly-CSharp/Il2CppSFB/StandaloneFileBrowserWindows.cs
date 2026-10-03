using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSFB
{
	// Token: 0x0200007F RID: 127
	public class StandaloneFileBrowserWindows : Object
	{
		// Token: 0x0600095D RID: 2397 RVA: 0x00099D3C File Offset: 0x00097F3C
		// Note: this type is marked as 'beforefieldinit'.
		static StandaloneFileBrowserWindows()
		{
			Il2CppClassPointerStore<StandaloneFileBrowserWindows>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SFB", "StandaloneFileBrowserWindows");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandaloneFileBrowserWindows>.NativeClassPtr);
			StandaloneFileBrowserWindows.NativeMethodInfoPtr_GetActiveWindow_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneFileBrowserWindows>.NativeClassPtr, 100664497);
			StandaloneFileBrowserWindows.NativeMethodInfoPtr_OpenFilePanel_Public_Virtual_Final_New_Il2CppStringArray_String_String_Il2CppReferenceArray_1_ExtensionFilter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneFileBrowserWindows>.NativeClassPtr, 100664498);
			StandaloneFileBrowserWindows.NativeMethodInfoPtr_OpenFilePanelAsync_Public_Virtual_Final_New_Void_String_String_Il2CppReferenceArray_1_ExtensionFilter_Boolean_Action_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneFileBrowserWindows>.NativeClassPtr, 100664499);
			StandaloneFileBrowserWindows.NativeMethodInfoPtr_OpenFolderPanel_Public_Virtual_Final_New_Il2CppStringArray_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneFileBrowserWindows>.NativeClassPtr, 100664500);
			StandaloneFileBrowserWindows.NativeMethodInfoPtr_OpenFolderPanelAsync_Public_Virtual_Final_New_Void_String_String_Boolean_Action_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneFileBrowserWindows>.NativeClassPtr, 100664501);
			StandaloneFileBrowserWindows.NativeMethodInfoPtr_SaveFilePanel_Public_Virtual_Final_New_String_String_String_String_Il2CppReferenceArray_1_ExtensionFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneFileBrowserWindows>.NativeClassPtr, 100664502);
			StandaloneFileBrowserWindows.NativeMethodInfoPtr_SaveFilePanelAsync_Public_Virtual_Final_New_Void_String_String_String_Il2CppReferenceArray_1_ExtensionFilter_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneFileBrowserWindows>.NativeClassPtr, 100664503);
			StandaloneFileBrowserWindows.NativeMethodInfoPtr_GetFilterFromFileExtensionList_Private_Static_String_Il2CppReferenceArray_1_ExtensionFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneFileBrowserWindows>.NativeClassPtr, 100664504);
			StandaloneFileBrowserWindows.NativeMethodInfoPtr_GetDirectoryPath_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneFileBrowserWindows>.NativeClassPtr, 100664505);
			StandaloneFileBrowserWindows.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneFileBrowserWindows>.NativeClassPtr, 100664506);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00099E34 File Offset: 0x00098034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75069, XrefRangeEnd = 75071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetActiveWindow()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneFileBrowserWindows.NativeMethodInfoPtr_GetActiveWindow_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00099E64 File Offset: 0x00098064
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75100, RefRangeEnd = 75101, XrefRangeStart = 75071, XrefRangeEnd = 75100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStringArray OpenFilePanel(string title, string directory, Il2CppReferenceArray<ExtensionFilter> extensions, bool multiselect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(directory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extensions);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiselect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneFileBrowserWindows.NativeMethodInfoPtr_OpenFilePanel_Public_Virtual_Final_New_Il2CppStringArray_String_String_Il2CppReferenceArray_1_ExtensionFilter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00099EE8 File Offset: 0x000980E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75101, XrefRangeEnd = 75103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OpenFilePanelAsync(string title, string directory, Il2CppReferenceArray<ExtensionFilter> extensions, bool multiselect, Action<Il2CppStringArray> cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(directory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extensions);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiselect;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneFileBrowserWindows.NativeMethodInfoPtr_OpenFilePanelAsync_Public_Virtual_Final_New_Void_String_String_Il2CppReferenceArray_1_ExtensionFilter_Boolean_Action_1_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00099F70 File Offset: 0x00098170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75103, XrefRangeEnd = 75126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStringArray OpenFolderPanel(string title, string directory, bool multiselect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(directory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiselect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneFileBrowserWindows.NativeMethodInfoPtr_OpenFolderPanel_Public_Virtual_Final_New_Il2CppStringArray_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00099FE0 File Offset: 0x000981E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75126, XrefRangeEnd = 75151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OpenFolderPanelAsync(string title, string directory, bool multiselect, Action<Il2CppStringArray> cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(directory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiselect;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneFileBrowserWindows.NativeMethodInfoPtr_OpenFolderPanelAsync_Public_Virtual_Final_New_Void_String_String_Boolean_Action_1_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0009A058 File Offset: 0x00098258
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75185, RefRangeEnd = 75186, XrefRangeStart = 75151, XrefRangeEnd = 75185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string SaveFilePanel(string title, string directory, string defaultName, Il2CppReferenceArray<ExtensionFilter> extensions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(directory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extensions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneFileBrowserWindows.NativeMethodInfoPtr_SaveFilePanel_Public_Virtual_Final_New_String_String_String_String_Il2CppReferenceArray_1_ExtensionFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0009A0D8 File Offset: 0x000982D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75186, XrefRangeEnd = 75188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SaveFilePanelAsync(string title, string directory, string defaultName, Il2CppReferenceArray<ExtensionFilter> extensions, Action<string> cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(directory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extensions);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneFileBrowserWindows.NativeMethodInfoPtr_SaveFilePanelAsync_Public_Virtual_Final_New_Void_String_String_String_Il2CppReferenceArray_1_ExtensionFilter_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0009A164 File Offset: 0x00098364
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 75215, RefRangeEnd = 75217, XrefRangeStart = 75188, XrefRangeEnd = 75215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFilterFromFileExtensionList(Il2CppReferenceArray<ExtensionFilter> extensions)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(extensions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneFileBrowserWindows.NativeMethodInfoPtr_GetFilterFromFileExtensionList_Private_Static_String_Il2CppReferenceArray_1_ExtensionFilter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0009A1A0 File Offset: 0x000983A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 75239, RefRangeEnd = 75243, XrefRangeStart = 75217, XrefRangeEnd = 75239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDirectoryPath(string directory)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(directory);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneFileBrowserWindows.NativeMethodInfoPtr_GetDirectoryPath_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x0009A1DC File Offset: 0x000983DC
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StandaloneFileBrowserWindows() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandaloneFileBrowserWindows>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneFileBrowserWindows.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00006502 File Offset: 0x00004702
		public StandaloneFileBrowserWindows(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveWindow_Private_Static_IntPtr_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr_OpenFilePanel_Public_Virtual_Final_New_Il2CppStringArray_String_String_Il2CppReferenceArray_1_ExtensionFilter_Boolean_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr_OpenFilePanelAsync_Public_Virtual_Final_New_Void_String_String_Il2CppReferenceArray_1_ExtensionFilter_Boolean_Action_1_Il2CppStringArray_0;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr_OpenFolderPanel_Public_Virtual_Final_New_Il2CppStringArray_String_String_Boolean_0;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_OpenFolderPanelAsync_Public_Virtual_Final_New_Void_String_String_Boolean_Action_1_Il2CppStringArray_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr_SaveFilePanel_Public_Virtual_Final_New_String_String_String_String_Il2CppReferenceArray_1_ExtensionFilter_0;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeMethodInfoPtr_SaveFilePanelAsync_Public_Virtual_Final_New_Void_String_String_String_Il2CppReferenceArray_1_ExtensionFilter_Action_1_String_0;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr_GetFilterFromFileExtensionList_Private_Static_String_Il2CppReferenceArray_1_ExtensionFilter_0;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectoryPath_Private_Static_String_String_0;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
