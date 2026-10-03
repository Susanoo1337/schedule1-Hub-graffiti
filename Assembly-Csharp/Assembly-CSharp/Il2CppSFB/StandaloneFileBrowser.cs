using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSFB
{
	// Token: 0x0200007D RID: 125
	public class StandaloneFileBrowser : Object
	{
		// Token: 0x06000949 RID: 2377 RVA: 0x00099668 File Offset: 0x00097868
		// Note: this type is marked as 'beforefieldinit'.
		static StandaloneFileBrowser()
		{
			Il2CppClassPointerStore<StandaloneFileBrowser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SFB", "StandaloneFileBrowser");
			StandaloneFileBrowser.NativeFieldInfoPtr__platformWrapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneFileBrowser>.NativeClassPtr, "_platformWrapper");
			StandaloneFileBrowser.NativeMethodInfoPtr_OpenFilePanel_Public_Static_Il2CppStringArray_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneFileBrowser>.NativeClassPtr, 100664484);
			StandaloneFileBrowser.NativeMethodInfoPtr_OpenFilePanel_Public_Static_Il2CppStringArray_String_String_Il2CppReferenceArray_1_ExtensionFilter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneFileBrowser>.NativeClassPtr, 100664485);
			StandaloneFileBrowser.NativeMethodInfoPtr_OpenFilePanelAsync_Public_Static_Void_String_String_String_Boolean_Action_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneFileBrowser>.NativeClassPtr, 100664486);
			StandaloneFileBrowser.NativeMethodInfoPtr_OpenFilePanelAsync_Public_Static_Void_String_String_Il2CppReferenceArray_1_ExtensionFilter_Boolean_Action_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneFileBrowser>.NativeClassPtr, 100664487);
			StandaloneFileBrowser.NativeMethodInfoPtr_OpenFolderPanel_Public_Static_Il2CppStringArray_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneFileBrowser>.NativeClassPtr, 100664488);
			StandaloneFileBrowser.NativeMethodInfoPtr_OpenFolderPanelAsync_Public_Static_Void_String_String_Boolean_Action_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneFileBrowser>.NativeClassPtr, 100664489);
			StandaloneFileBrowser.NativeMethodInfoPtr_SaveFilePanel_Public_Static_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneFileBrowser>.NativeClassPtr, 100664490);
			StandaloneFileBrowser.NativeMethodInfoPtr_SaveFilePanel_Public_Static_String_String_String_String_Il2CppReferenceArray_1_ExtensionFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneFileBrowser>.NativeClassPtr, 100664491);
			StandaloneFileBrowser.NativeMethodInfoPtr_SaveFilePanelAsync_Public_Static_Void_String_String_String_String_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneFileBrowser>.NativeClassPtr, 100664492);
			StandaloneFileBrowser.NativeMethodInfoPtr_SaveFilePanelAsync_Public_Static_Void_String_String_String_Il2CppReferenceArray_1_ExtensionFilter_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneFileBrowser>.NativeClassPtr, 100664493);
			StandaloneFileBrowser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneFileBrowser>.NativeClassPtr, 100664494);
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00099780 File Offset: 0x00097980
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 74930, RefRangeEnd = 74937, XrefRangeStart = 74906, XrefRangeEnd = 74930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray OpenFilePanel(string title, string directory, string extension, bool multiselect)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(directory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(extension);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiselect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneFileBrowser.NativeMethodInfoPtr_OpenFilePanel_Public_Static_Il2CppStringArray_String_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x000997F8 File Offset: 0x000979F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 74944, RefRangeEnd = 74947, XrefRangeStart = 74937, XrefRangeEnd = 74944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray OpenFilePanel(string title, string directory, Il2CppReferenceArray<ExtensionFilter> extensions, bool multiselect)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(directory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extensions);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiselect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneFileBrowser.NativeMethodInfoPtr_OpenFilePanel_Public_Static_Il2CppStringArray_String_String_Il2CppReferenceArray_1_ExtensionFilter_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00099870 File Offset: 0x00097A70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74971, RefRangeEnd = 74972, XrefRangeStart = 74947, XrefRangeEnd = 74971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenFilePanelAsync(string title, string directory, string extension, bool multiselect, Action<Il2CppStringArray> cb)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(directory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(extension);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiselect;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneFileBrowser.NativeMethodInfoPtr_OpenFilePanelAsync_Public_Static_Void_String_String_String_Boolean_Action_1_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x000998EC File Offset: 0x00097AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74972, XrefRangeEnd = 74979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenFilePanelAsync(string title, string directory, Il2CppReferenceArray<ExtensionFilter> extensions, bool multiselect, Action<Il2CppStringArray> cb)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(directory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extensions);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiselect;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneFileBrowser.NativeMethodInfoPtr_OpenFilePanelAsync_Public_Static_Void_String_String_Il2CppReferenceArray_1_ExtensionFilter_Boolean_Action_1_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00099968 File Offset: 0x00097B68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 74986, RefRangeEnd = 74988, XrefRangeStart = 74979, XrefRangeEnd = 74986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray OpenFolderPanel(string title, string directory, bool multiselect)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(directory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiselect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneFileBrowser.NativeMethodInfoPtr_OpenFolderPanel_Public_Static_Il2CppStringArray_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x000999CC File Offset: 0x00097BCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74995, RefRangeEnd = 74996, XrefRangeStart = 74988, XrefRangeEnd = 74995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenFolderPanelAsync(string title, string directory, bool multiselect, Action<Il2CppStringArray> cb)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(directory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiselect;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneFileBrowser.NativeMethodInfoPtr_OpenFolderPanelAsync_Public_Static_Void_String_String_Boolean_Action_1_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00099A34 File Offset: 0x00097C34
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 75020, RefRangeEnd = 75026, XrefRangeStart = 74996, XrefRangeEnd = 75020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SaveFilePanel(string title, string directory, string defaultName, string extension)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(directory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(extension);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneFileBrowser.NativeMethodInfoPtr_SaveFilePanel_Public_Static_String_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00099AA8 File Offset: 0x00097CA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 75033, RefRangeEnd = 75036, XrefRangeStart = 75026, XrefRangeEnd = 75033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SaveFilePanel(string title, string directory, string defaultName, Il2CppReferenceArray<ExtensionFilter> extensions)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(directory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extensions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneFileBrowser.NativeMethodInfoPtr_SaveFilePanel_Public_Static_String_String_String_String_Il2CppReferenceArray_1_ExtensionFilter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00099B1C File Offset: 0x00097D1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 75060, RefRangeEnd = 75062, XrefRangeStart = 75036, XrefRangeEnd = 75060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SaveFilePanelAsync(string title, string directory, string defaultName, string extension, Action<string> cb)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(directory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(extension);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneFileBrowser.NativeMethodInfoPtr_SaveFilePanelAsync_Public_Static_Void_String_String_String_String_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00099B9C File Offset: 0x00097D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75062, XrefRangeEnd = 75069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SaveFilePanelAsync(string title, string directory, string defaultName, Il2CppReferenceArray<ExtensionFilter> extensions, Action<string> cb)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(directory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extensions);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneFileBrowser.NativeMethodInfoPtr_SaveFilePanelAsync_Public_Static_Void_String_String_String_Il2CppReferenceArray_1_ExtensionFilter_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00099C1C File Offset: 0x00097E1C
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StandaloneFileBrowser() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandaloneFileBrowser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneFileBrowser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x000064C3 File Offset: 0x000046C3
		public StandaloneFileBrowser(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x00099C58 File Offset: 0x00097E58
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x000064CC File Offset: 0x000046CC
		public unsafe static IStandaloneFileBrowser _platformWrapper
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StandaloneFileBrowser.NativeFieldInfoPtr__platformWrapper, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStandaloneFileBrowser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StandaloneFileBrowser.NativeFieldInfoPtr__platformWrapper, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeFieldInfoPtr__platformWrapper;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeMethodInfoPtr_OpenFilePanel_Public_Static_Il2CppStringArray_String_String_String_Boolean_0;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeMethodInfoPtr_OpenFilePanel_Public_Static_Il2CppStringArray_String_String_Il2CppReferenceArray_1_ExtensionFilter_Boolean_0;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr_OpenFilePanelAsync_Public_Static_Void_String_String_String_Boolean_Action_1_Il2CppStringArray_0;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeMethodInfoPtr_OpenFilePanelAsync_Public_Static_Void_String_String_Il2CppReferenceArray_1_ExtensionFilter_Boolean_Action_1_Il2CppStringArray_0;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeMethodInfoPtr_OpenFolderPanel_Public_Static_Il2CppStringArray_String_String_Boolean_0;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeMethodInfoPtr_OpenFolderPanelAsync_Public_Static_Void_String_String_Boolean_Action_1_Il2CppStringArray_0;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeMethodInfoPtr_SaveFilePanel_Public_Static_String_String_String_String_String_0;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeMethodInfoPtr_SaveFilePanel_Public_Static_String_String_String_String_Il2CppReferenceArray_1_ExtensionFilter_0;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeMethodInfoPtr_SaveFilePanelAsync_Public_Static_Void_String_String_String_String_Action_1_String_0;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeMethodInfoPtr_SaveFilePanelAsync_Public_Static_Void_String_String_String_Il2CppReferenceArray_1_ExtensionFilter_Action_1_String_0;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
