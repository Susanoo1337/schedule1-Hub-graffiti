using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x020001AD RID: 429
	public class ISaveable : Il2CppObjectBase
	{
		// Token: 0x06002ABD RID: 10941 RVA: 0x00108450 File Offset: 0x00106650
		// Note: this type is marked as 'beforefieldinit'.
		static ISaveable()
		{
			Il2CppClassPointerStore<ISaveable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "ISaveable");
			ISaveable.NativeMethodInfoPtr_get_SaveFolderName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668758);
			ISaveable.NativeMethodInfoPtr_get_SaveFileName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668759);
			ISaveable.NativeMethodInfoPtr_get_Loader_Public_Abstract_Virtual_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668760);
			ISaveable.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668761);
			ISaveable.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Abstract_Virtual_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668762);
			ISaveable.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Abstract_Virtual_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668763);
			ISaveable.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Abstract_Virtual_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668764);
			ISaveable.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Abstract_Virtual_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668765);
			ISaveable.NativeMethodInfoPtr_get_HasChanged_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668766);
			ISaveable.NativeMethodInfoPtr_set_HasChanged_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668767);
			ISaveable.NativeMethodInfoPtr_InitializeSaveable_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668768);
			ISaveable.NativeMethodInfoPtr_GetSaveString_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668769);
			ISaveable.NativeMethodInfoPtr_Save_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668770);
			ISaveable.NativeMethodInfoPtr_WriteBaseData_Public_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668771);
			ISaveable.NativeMethodInfoPtr_GetLocalPath_Public_Virtual_New_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668772);
			ISaveable.NativeMethodInfoPtr_CompleteSave_Public_Virtual_New_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668773);
			ISaveable.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668774);
			ISaveable.NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668775);
			ISaveable.NativeMethodInfoPtr_GetContainerFolder_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668776);
			ISaveable.NativeMethodInfoPtr_WriteSubfile_Public_Virtual_New_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668777);
			ISaveable.NativeMethodInfoPtr_WriteFolder_Public_Virtual_New_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668778);
			ISaveable.NativeMethodInfoPtr_TryLoadFile_Public_Virtual_New_Boolean_String_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668779);
			ISaveable.NativeMethodInfoPtr_TryLoadFile_Public_Virtual_New_Boolean_String_byref_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668780);
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06002ABE RID: 10942 RVA: 0x00108644 File Offset: 0x00106844
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_get_SaveFolderName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06002ABF RID: 10943 RVA: 0x00108688 File Offset: 0x00106888
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_get_SaveFileName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06002AC0 RID: 10944 RVA: 0x001086CC File Offset: 0x001068CC
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_get_Loader_Public_Abstract_Virtual_New_get_Loader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x00108718 File Offset: 0x00106918
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06002AC2 RID: 10946 RVA: 0x00108760 File Offset: 0x00106960
		// (set) Token: 0x06002AC3 RID: 10947 RVA: 0x001087AC File Offset: 0x001069AC
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Abstract_Virtual_New_get_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Abstract_Virtual_New_set_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06002AC4 RID: 10948 RVA: 0x001087FC File Offset: 0x001069FC
		// (set) Token: 0x06002AC5 RID: 10949 RVA: 0x00108848 File Offset: 0x00106A48
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Abstract_Virtual_New_get_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Abstract_Virtual_New_set_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06002AC6 RID: 10950 RVA: 0x00108898 File Offset: 0x00106A98
		// (set) Token: 0x06002AC7 RID: 10951 RVA: 0x001088E0 File Offset: 0x00106AE0
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_get_HasChanged_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_set_HasChanged_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x0010892C File Offset: 0x00106B2C
		[CallerCount(0)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_InitializeSaveable_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AC9 RID: 10953 RVA: 0x00108968 File Offset: 0x00106B68
		[CallerCount(0)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_GetSaveString_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002ACA RID: 10954 RVA: 0x001089AC File Offset: 0x00106BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124559, XrefRangeEnd = 124576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string Save(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_Save_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002ACB RID: 10955 RVA: 0x00108A00 File Offset: 0x00106C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124576, XrefRangeEnd = 124630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteBaseData(string parentFolderPath, string saveString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(saveString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_WriteBaseData_Public_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ACC RID: 10956 RVA: 0x00108A60 File Offset: 0x00106C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124630, XrefRangeEnd = 124638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalPath(out bool isFolder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &isFolder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_GetLocalPath_Public_Virtual_New_String_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002ACD RID: 10957 RVA: 0x00108AB0 File Offset: 0x00106CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124638, XrefRangeEnd = 124748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CompleteSave(string parentFolderPath, bool writeDataFile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeDataFile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_CompleteSave_Public_Virtual_New_Void_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x00108B0C File Offset: 0x00106D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124748, XrefRangeEnd = 124754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x00108B68 File Offset: 0x00106D68
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeleteUnapprovedFiles(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x00108BB8 File Offset: 0x00106DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124754, XrefRangeEnd = 124772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetContainerFolder(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_GetContainerFolder_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x00108C0C File Offset: 0x00106E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124772, XrefRangeEnd = 124826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string WriteSubfile(string parentPath, string localPath_NoExtensions, string contents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localPath_NoExtensions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_WriteSubfile_Public_Virtual_New_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x00108C84 File Offset: 0x00106E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124826, XrefRangeEnd = 124894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string WriteFolder(string parentPath, string localPath_NoExtensions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localPath_NoExtensions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_WriteFolder_Public_Virtual_New_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x00108CEC File Offset: 0x00106EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124894, XrefRangeEnd = 124902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryLoadFile(string parentPath, string fileName, out string contents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_TryLoadFile_Public_Virtual_New_Boolean_String_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			contents = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x00108D74 File Offset: 0x00106F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124902, XrefRangeEnd = 124913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryLoadFile(string path, out string contents, bool autoAddExtension = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoAddExtension;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_TryLoadFile_Public_Virtual_New_Boolean_String_byref_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			contents = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x00016412 File Offset: 0x00014612
		public ISaveable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001D63 RID: 7523
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04001D64 RID: 7524
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04001D65 RID: 7525
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Abstract_Virtual_New_get_Loader_0;

		// Token: 0x04001D66 RID: 7526
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001D67 RID: 7527
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Abstract_Virtual_New_get_List_1_String_0;

		// Token: 0x04001D68 RID: 7528
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Abstract_Virtual_New_set_Void_List_1_String_0;

		// Token: 0x04001D69 RID: 7529
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Abstract_Virtual_New_get_List_1_String_0;

		// Token: 0x04001D6A RID: 7530
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Abstract_Virtual_New_set_Void_List_1_String_0;

		// Token: 0x04001D6B RID: 7531
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001D6C RID: 7532
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04001D6D RID: 7533
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001D6E RID: 7534
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Abstract_Virtual_New_String_0;

		// Token: 0x04001D6F RID: 7535
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Virtual_New_String_String_0;

		// Token: 0x04001D70 RID: 7536
		private static readonly IntPtr NativeMethodInfoPtr_WriteBaseData_Public_Virtual_New_Void_String_String_0;

		// Token: 0x04001D71 RID: 7537
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalPath_Public_Virtual_New_String_byref_Boolean_0;

		// Token: 0x04001D72 RID: 7538
		private static readonly IntPtr NativeMethodInfoPtr_CompleteSave_Public_Virtual_New_Void_String_Boolean_0;

		// Token: 0x04001D73 RID: 7539
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x04001D74 RID: 7540
		private static readonly IntPtr NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0;

		// Token: 0x04001D75 RID: 7541
		private static readonly IntPtr NativeMethodInfoPtr_GetContainerFolder_Public_Virtual_New_String_String_0;

		// Token: 0x04001D76 RID: 7542
		private static readonly IntPtr NativeMethodInfoPtr_WriteSubfile_Public_Virtual_New_String_String_String_String_0;

		// Token: 0x04001D77 RID: 7543
		private static readonly IntPtr NativeMethodInfoPtr_WriteFolder_Public_Virtual_New_String_String_String_0;

		// Token: 0x04001D78 RID: 7544
		private static readonly IntPtr NativeMethodInfoPtr_TryLoadFile_Public_Virtual_New_Boolean_String_String_byref_String_0;

		// Token: 0x04001D79 RID: 7545
		private static readonly IntPtr NativeMethodInfoPtr_TryLoadFile_Public_Virtual_New_Boolean_String_byref_String_Boolean_0;
	}
}
