using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x020001B5 RID: 437
	public class SaveManager : PersistentSingleton<SaveManager>
	{
		// Token: 0x06002B7C RID: 11132 RVA: 0x0010AEE8 File Offset: 0x001090E8
		// Note: this type is marked as 'beforefieldinit'.
		static SaveManager()
		{
			Il2CppClassPointerStore<SaveManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "SaveManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveManager>.NativeClassPtr);
			SaveManager.NativeFieldInfoPtr_MAIN_SCENE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "MAIN_SCENE_NAME");
			SaveManager.NativeFieldInfoPtr_MENU_SCENE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "MENU_SCENE_NAME");
			SaveManager.NativeFieldInfoPtr_TUTORIAL_SCENE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "TUTORIAL_SCENE_NAME");
			SaveManager.NativeFieldInfoPtr_SAVES_PER_FRAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "SAVES_PER_FRAME");
			SaveManager.NativeFieldInfoPtr_SAVE_FILE_EXTENSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "SAVE_FILE_EXTENSION");
			SaveManager.NativeFieldInfoPtr_SAVE_SLOT_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "SAVE_SLOT_COUNT");
			SaveManager.NativeFieldInfoPtr_SAVE_GAME_PREFIX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "SAVE_GAME_PREFIX");
			SaveManager.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "DEBUG");
			SaveManager.NativeFieldInfoPtr_PRETTY_PRINT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "PRETTY_PRINT");
			SaveManager.NativeFieldInfoPtr_SaveError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "SaveError");
			SaveManager.NativeFieldInfoPtr__AccessPermissionIssueDetected_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "<AccessPermissionIssueDetected>k__BackingField");
			SaveManager.NativeFieldInfoPtr__IsSaving_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "<IsSaving>k__BackingField");
			SaveManager.NativeFieldInfoPtr__SecondsSinceLastSave_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "<SecondsSinceLastSave>k__BackingField");
			SaveManager.NativeFieldInfoPtr__PlayersSavePath_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "<PlayersSavePath>k__BackingField");
			SaveManager.NativeFieldInfoPtr__IndividualSavesContainerPath_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "<IndividualSavesContainerPath>k__BackingField");
			SaveManager.NativeFieldInfoPtr__SaveName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "<SaveName>k__BackingField");
			SaveManager.NativeFieldInfoPtr_Saveables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "Saveables");
			SaveManager.NativeFieldInfoPtr_BaseSaveables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "BaseSaveables");
			SaveManager.NativeFieldInfoPtr_ApprovedBaseLevelPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "ApprovedBaseLevelPaths");
			SaveManager.NativeFieldInfoPtr_CompletedSaveables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "CompletedSaveables");
			SaveManager.NativeFieldInfoPtr_QueuedSaveRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "QueuedSaveRequests");
			SaveManager.NativeFieldInfoPtr_WriteIssueDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "WriteIssueDisplay");
			SaveManager.NativeFieldInfoPtr_onSaveStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "onSaveStart");
			SaveManager.NativeFieldInfoPtr_onSaveComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "onSaveComplete");
			SaveManager.NativeFieldInfoPtr_saveFolderInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "saveFolderInitialized");
			SaveManager.NativeMethodInfoPtr_ReportSaveError_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668915);
			SaveManager.NativeMethodInfoPtr_get_AccessPermissionIssueDetected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668916);
			SaveManager.NativeMethodInfoPtr_set_AccessPermissionIssueDetected_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668917);
			SaveManager.NativeMethodInfoPtr_get_IsSaving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668918);
			SaveManager.NativeMethodInfoPtr_set_IsSaving_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668919);
			SaveManager.NativeMethodInfoPtr_get_SecondsSinceLastSave_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668920);
			SaveManager.NativeMethodInfoPtr_set_SecondsSinceLastSave_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668921);
			SaveManager.NativeMethodInfoPtr_get_PlayersSavePath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668922);
			SaveManager.NativeMethodInfoPtr_set_PlayersSavePath_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668923);
			SaveManager.NativeMethodInfoPtr_get_IndividualSavesContainerPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668924);
			SaveManager.NativeMethodInfoPtr_set_IndividualSavesContainerPath_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668925);
			SaveManager.NativeMethodInfoPtr_get_BackupFolderPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668926);
			SaveManager.NativeMethodInfoPtr_get_SaveName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668927);
			SaveManager.NativeMethodInfoPtr_set_SaveName_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668928);
			SaveManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668929);
			SaveManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668930);
			SaveManager.NativeMethodInfoPtr_CheckSaveFolderInitialized_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668931);
			SaveManager.NativeMethodInfoPtr_HasWritePermissionOnDir_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668932);
			SaveManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668933);
			SaveManager.NativeMethodInfoPtr_Save_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668934);
			SaveManager.NativeMethodInfoPtr_Save_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668935);
			SaveManager.NativeMethodInfoPtr_ClearBaseLevelOutdatedSaves_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668936);
			SaveManager.NativeMethodInfoPtr_CompleteSaveable_Public_Void_ISaveable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668937);
			SaveManager.NativeMethodInfoPtr_ClearCompletedSaveable_Public_Void_ISaveable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668938);
			SaveManager.NativeMethodInfoPtr_CreateSaveBackup_Public_Void_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668939);
			SaveManager.NativeMethodInfoPtr_RegisterSaveable_Public_Void_ISaveable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668940);
			SaveManager.NativeMethodInfoPtr_QueueSaveRequest_Public_Void_SaveRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668941);
			SaveManager.NativeMethodInfoPtr_DequeueSaveRequest_Public_Void_SaveRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668942);
			SaveManager.NativeMethodInfoPtr_StripExtensions_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668943);
			SaveManager.NativeMethodInfoPtr_MakeFileSafe_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668944);
			SaveManager.NativeMethodInfoPtr_GetVersionNumber_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668945);
			SaveManager.NativeMethodInfoPtr_Clean_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668946);
			SaveManager.NativeMethodInfoPtr_DisablePlayTutorial_Public_Void_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668947);
			SaveManager.NativeMethodInfoPtr_SanitizeFileName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668948);
			SaveManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668949);
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x0010B3C8 File Offset: 0x001095C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 127464, RefRangeEnd = 127466, XrefRangeStart = 127462, XrefRangeEnd = 127464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReportSaveError()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_ReportSaveError_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06002B7E RID: 11134 RVA: 0x0010B3F0 File Offset: 0x001095F0
		// (set) Token: 0x06002B7F RID: 11135 RVA: 0x0010B42C File Offset: 0x0010962C
		public unsafe bool AccessPermissionIssueDetected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_get_AccessPermissionIssueDetected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 33070, RefRangeEnd = 33090, XrefRangeStart = 33070, XrefRangeEnd = 33090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_set_AccessPermissionIssueDetected_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06002B80 RID: 11136 RVA: 0x0010B46C File Offset: 0x0010966C
		// (set) Token: 0x06002B81 RID: 11137 RVA: 0x0010B4A8 File Offset: 0x001096A8
		public unsafe bool IsSaving
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_get_IsSaving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_set_IsSaving_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06002B82 RID: 11138 RVA: 0x0010B4E8 File Offset: 0x001096E8
		// (set) Token: 0x06002B83 RID: 11139 RVA: 0x0010B524 File Offset: 0x00109724
		public unsafe float SecondsSinceLastSave
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_get_SecondsSinceLastSave_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 126089, RefRangeEnd = 126091, XrefRangeStart = 126089, XrefRangeEnd = 126091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_set_SecondsSinceLastSave_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06002B84 RID: 11140 RVA: 0x0010B564 File Offset: 0x00109764
		// (set) Token: 0x06002B85 RID: 11141 RVA: 0x0010B59C File Offset: 0x0010979C
		public unsafe string PlayersSavePath
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_get_PlayersSavePath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 2978, RefRangeEnd = 2980, XrefRangeStart = 2978, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_set_PlayersSavePath_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06002B86 RID: 11142 RVA: 0x0010B5E0 File Offset: 0x001097E0
		// (set) Token: 0x06002B87 RID: 11143 RVA: 0x0010B618 File Offset: 0x00109818
		public unsafe string IndividualSavesContainerPath
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 2980, RefRangeEnd = 2987, XrefRangeStart = 2980, XrefRangeEnd = 2987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_get_IndividualSavesContainerPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_set_IndividualSavesContainerPath_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06002B88 RID: 11144 RVA: 0x0010B65C File Offset: 0x0010985C
		public unsafe string BackupFolderPath
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 127472, RefRangeEnd = 127473, XrefRangeStart = 127466, XrefRangeEnd = 127472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_get_BackupFolderPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06002B89 RID: 11145 RVA: 0x0010B694 File Offset: 0x00109894
		// (set) Token: 0x06002B8A RID: 11146 RVA: 0x0010B6CC File Offset: 0x001098CC
		public unsafe string SaveName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30474, RefRangeEnd = 30475, XrefRangeStart = 30474, XrefRangeEnd = 30475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_get_SaveName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_set_SaveName_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x0010B710 File Offset: 0x00109910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127473, XrefRangeEnd = 127513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SaveManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x0010B74C File Offset: 0x0010994C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127513, XrefRangeEnd = 127529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SaveManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x0010B788 File Offset: 0x00109988
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 127566, RefRangeEnd = 127568, XrefRangeStart = 127529, XrefRangeEnd = 127566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckSaveFolderInitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_CheckSaveFolderInitialized_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x0010B7BC File Offset: 0x001099BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127580, RefRangeEnd = 127581, XrefRangeStart = 127568, XrefRangeEnd = 127580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasWritePermissionOnDir(string path)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_HasWritePermissionOnDir_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x0010B800 File Offset: 0x00109A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127581, XrefRangeEnd = 127585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x0010B834 File Offset: 0x00109A34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 127591, RefRangeEnd = 127593, XrefRangeStart = 127585, XrefRangeEnd = 127591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_Save_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B91 RID: 11153 RVA: 0x0010B868 File Offset: 0x00109A68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 127630, RefRangeEnd = 127633, XrefRangeStart = 127593, XrefRangeEnd = 127630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Save(string saveFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(saveFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_Save_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B92 RID: 11154 RVA: 0x0010B8AC File Offset: 0x00109AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127633, XrefRangeEnd = 127691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearBaseLevelOutdatedSaves(string saveFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(saveFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_ClearBaseLevelOutdatedSaves_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B93 RID: 11155 RVA: 0x0010B8F0 File Offset: 0x00109AF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127704, RefRangeEnd = 127705, XrefRangeStart = 127691, XrefRangeEnd = 127704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteSaveable(ISaveable saveable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_CompleteSaveable_Public_Void_ISaveable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x0010B934 File Offset: 0x00109B34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127709, RefRangeEnd = 127710, XrefRangeStart = 127705, XrefRangeEnd = 127709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCompletedSaveable(ISaveable saveable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_ClearCompletedSaveable_Public_Void_ISaveable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x0010B978 File Offset: 0x00109B78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127776, RefRangeEnd = 127777, XrefRangeStart = 127710, XrefRangeEnd = 127776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateSaveBackup(SaveInfo saveInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_CreateSaveBackup_Public_Void_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x0010B9BC File Offset: 0x00109BBC
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 127791, RefRangeEnd = 127826, XrefRangeStart = 127777, XrefRangeEnd = 127791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterSaveable(ISaveable saveable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_RegisterSaveable_Public_Void_ISaveable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x0010BA00 File Offset: 0x00109C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127826, XrefRangeEnd = 127832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueSaveRequest(SaveRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_QueueSaveRequest_Public_Void_SaveRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x0010BA44 File Offset: 0x00109C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127832, XrefRangeEnd = 127836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DequeueSaveRequest(SaveRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_DequeueSaveRequest_Public_Void_SaveRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x0010BA88 File Offset: 0x00109C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127836, XrefRangeEnd = 127842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StripExtensions(string filePath)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_StripExtensions_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x0010BAC4 File Offset: 0x00109CC4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 127848, RefRangeEnd = 127852, XrefRangeStart = 127842, XrefRangeEnd = 127848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MakeFileSafe(string fileName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_MakeFileSafe_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x0010BB00 File Offset: 0x00109D00
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 127876, RefRangeEnd = 127884, XrefRangeStart = 127852, XrefRangeEnd = 127876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetVersionNumber(string version)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(version);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_GetVersionNumber_Public_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x0010BB44 File Offset: 0x00109D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127884, XrefRangeEnd = 127888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_Clean_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x0010BB78 File Offset: 0x00109D78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127917, RefRangeEnd = 127918, XrefRangeStart = 127888, XrefRangeEnd = 127917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisablePlayTutorial(SaveInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_DisablePlayTutorial_Public_Void_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x0010BBBC File Offset: 0x00109DBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 127924, RefRangeEnd = 127926, XrefRangeStart = 127918, XrefRangeEnd = 127924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SanitizeFileName(string fileName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_SanitizeFileName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x0010BBF8 File Offset: 0x00109DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127926, XrefRangeEnd = 127971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x0001694D File Offset: 0x00014B4D
		public SaveManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06002BA1 RID: 11169 RVA: 0x0010BC34 File Offset: 0x00109E34
		// (set) Token: 0x06002BA2 RID: 11170 RVA: 0x00016956 File Offset: 0x00014B56
		public unsafe static string MAIN_SCENE_NAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_MAIN_SCENE_NAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_MAIN_SCENE_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06002BA3 RID: 11171 RVA: 0x0010BC54 File Offset: 0x00109E54
		// (set) Token: 0x06002BA4 RID: 11172 RVA: 0x00016968 File Offset: 0x00014B68
		public unsafe static string MENU_SCENE_NAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_MENU_SCENE_NAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_MENU_SCENE_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06002BA5 RID: 11173 RVA: 0x0010BC74 File Offset: 0x00109E74
		// (set) Token: 0x06002BA6 RID: 11174 RVA: 0x0001697A File Offset: 0x00014B7A
		public unsafe static string TUTORIAL_SCENE_NAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_TUTORIAL_SCENE_NAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_TUTORIAL_SCENE_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06002BA7 RID: 11175 RVA: 0x0010BC94 File Offset: 0x00109E94
		// (set) Token: 0x06002BA8 RID: 11176 RVA: 0x0001698C File Offset: 0x00014B8C
		public unsafe static int SAVES_PER_FRAME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_SAVES_PER_FRAME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_SAVES_PER_FRAME, (void*)(&value));
			}
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06002BA9 RID: 11177 RVA: 0x0010BCB0 File Offset: 0x00109EB0
		// (set) Token: 0x06002BAA RID: 11178 RVA: 0x0001699A File Offset: 0x00014B9A
		public unsafe static string SAVE_FILE_EXTENSION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_SAVE_FILE_EXTENSION, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_SAVE_FILE_EXTENSION, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06002BAB RID: 11179 RVA: 0x0010BCD0 File Offset: 0x00109ED0
		// (set) Token: 0x06002BAC RID: 11180 RVA: 0x000169AC File Offset: 0x00014BAC
		public unsafe static int SAVE_SLOT_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_SAVE_SLOT_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_SAVE_SLOT_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06002BAD RID: 11181 RVA: 0x0010BCEC File Offset: 0x00109EEC
		// (set) Token: 0x06002BAE RID: 11182 RVA: 0x000169BA File Offset: 0x00014BBA
		public unsafe static string SAVE_GAME_PREFIX
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_SAVE_GAME_PREFIX, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_SAVE_GAME_PREFIX, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06002BAF RID: 11183 RVA: 0x0010BD0C File Offset: 0x00109F0C
		// (set) Token: 0x06002BB0 RID: 11184 RVA: 0x000169CC File Offset: 0x00014BCC
		public unsafe static bool DEBUG
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_DEBUG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_DEBUG, (void*)(&value));
			}
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06002BB1 RID: 11185 RVA: 0x0010BD28 File Offset: 0x00109F28
		// (set) Token: 0x06002BB2 RID: 11186 RVA: 0x000169DA File Offset: 0x00014BDA
		public unsafe static bool PRETTY_PRINT
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_PRETTY_PRINT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_PRETTY_PRINT, (void*)(&value));
			}
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06002BB3 RID: 11187 RVA: 0x0010BD44 File Offset: 0x00109F44
		// (set) Token: 0x06002BB4 RID: 11188 RVA: 0x000169E8 File Offset: 0x00014BE8
		public unsafe static bool SaveError
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_SaveError, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_SaveError, (void*)(&value));
			}
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06002BB5 RID: 11189 RVA: 0x0010BD60 File Offset: 0x00109F60
		// (set) Token: 0x06002BB6 RID: 11190 RVA: 0x000169F6 File Offset: 0x00014BF6
		public unsafe bool _AccessPermissionIssueDetected_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__AccessPermissionIssueDetected_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__AccessPermissionIssueDetected_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06002BB7 RID: 11191 RVA: 0x0010BD88 File Offset: 0x00109F88
		// (set) Token: 0x06002BB8 RID: 11192 RVA: 0x00016A11 File Offset: 0x00014C11
		public unsafe bool _IsSaving_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__IsSaving_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__IsSaving_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06002BB9 RID: 11193 RVA: 0x0010BDB0 File Offset: 0x00109FB0
		// (set) Token: 0x06002BBA RID: 11194 RVA: 0x00016A2C File Offset: 0x00014C2C
		public unsafe float _SecondsSinceLastSave_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__SecondsSinceLastSave_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__SecondsSinceLastSave_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06002BBB RID: 11195 RVA: 0x0010BDD8 File Offset: 0x00109FD8
		// (set) Token: 0x06002BBC RID: 11196 RVA: 0x00016A47 File Offset: 0x00014C47
		public unsafe string _PlayersSavePath_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__PlayersSavePath_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__PlayersSavePath_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06002BBD RID: 11197 RVA: 0x0010BE00 File Offset: 0x0010A000
		// (set) Token: 0x06002BBE RID: 11198 RVA: 0x00016A66 File Offset: 0x00014C66
		public unsafe string _IndividualSavesContainerPath_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__IndividualSavesContainerPath_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__IndividualSavesContainerPath_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06002BBF RID: 11199 RVA: 0x0010BE28 File Offset: 0x0010A028
		// (set) Token: 0x06002BC0 RID: 11200 RVA: 0x00016A85 File Offset: 0x00014C85
		public unsafe string _SaveName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__SaveName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__SaveName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06002BC1 RID: 11201 RVA: 0x0010BE50 File Offset: 0x0010A050
		// (set) Token: 0x06002BC2 RID: 11202 RVA: 0x00016AA4 File Offset: 0x00014CA4
		public unsafe List<ISaveable> Saveables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_Saveables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ISaveable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_Saveables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06002BC3 RID: 11203 RVA: 0x0010BE80 File Offset: 0x0010A080
		// (set) Token: 0x06002BC4 RID: 11204 RVA: 0x00016AC3 File Offset: 0x00014CC3
		public unsafe List<IBaseSaveable> BaseSaveables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_BaseSaveables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IBaseSaveable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_BaseSaveables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06002BC5 RID: 11205 RVA: 0x0010BEB0 File Offset: 0x0010A0B0
		// (set) Token: 0x06002BC6 RID: 11206 RVA: 0x00016AE2 File Offset: 0x00014CE2
		public unsafe List<string> ApprovedBaseLevelPaths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_ApprovedBaseLevelPaths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_ApprovedBaseLevelPaths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06002BC7 RID: 11207 RVA: 0x0010BEE0 File Offset: 0x0010A0E0
		// (set) Token: 0x06002BC8 RID: 11208 RVA: 0x00016B01 File Offset: 0x00014D01
		public unsafe List<ISaveable> CompletedSaveables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_CompletedSaveables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ISaveable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_CompletedSaveables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06002BC9 RID: 11209 RVA: 0x0010BF10 File Offset: 0x0010A110
		// (set) Token: 0x06002BCA RID: 11210 RVA: 0x00016B20 File Offset: 0x00014D20
		public unsafe List<SaveRequest> QueuedSaveRequests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_QueuedSaveRequests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SaveRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_QueuedSaveRequests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06002BCB RID: 11211 RVA: 0x0010BF40 File Offset: 0x0010A140
		// (set) Token: 0x06002BCC RID: 11212 RVA: 0x00016B3F File Offset: 0x00014D3F
		public unsafe RectTransform WriteIssueDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_WriteIssueDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_WriteIssueDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06002BCD RID: 11213 RVA: 0x0010BF70 File Offset: 0x0010A170
		// (set) Token: 0x06002BCE RID: 11214 RVA: 0x00016B5E File Offset: 0x00014D5E
		public unsafe UnityEvent onSaveStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_onSaveStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_onSaveStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06002BCF RID: 11215 RVA: 0x0010BFA0 File Offset: 0x0010A1A0
		// (set) Token: 0x06002BD0 RID: 11216 RVA: 0x00016B7D File Offset: 0x00014D7D
		public unsafe UnityEvent onSaveComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_onSaveComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_onSaveComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06002BD1 RID: 11217 RVA: 0x0010BFD0 File Offset: 0x0010A1D0
		// (set) Token: 0x06002BD2 RID: 11218 RVA: 0x00016B9C File Offset: 0x00014D9C
		public unsafe bool saveFolderInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_saveFolderInitialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_saveFolderInitialized)) = value;
			}
		}

		// Token: 0x04001DE5 RID: 7653
		private static readonly IntPtr NativeFieldInfoPtr_MAIN_SCENE_NAME;

		// Token: 0x04001DE6 RID: 7654
		private static readonly IntPtr NativeFieldInfoPtr_MENU_SCENE_NAME;

		// Token: 0x04001DE7 RID: 7655
		private static readonly IntPtr NativeFieldInfoPtr_TUTORIAL_SCENE_NAME;

		// Token: 0x04001DE8 RID: 7656
		private static readonly IntPtr NativeFieldInfoPtr_SAVES_PER_FRAME;

		// Token: 0x04001DE9 RID: 7657
		private static readonly IntPtr NativeFieldInfoPtr_SAVE_FILE_EXTENSION;

		// Token: 0x04001DEA RID: 7658
		private static readonly IntPtr NativeFieldInfoPtr_SAVE_SLOT_COUNT;

		// Token: 0x04001DEB RID: 7659
		private static readonly IntPtr NativeFieldInfoPtr_SAVE_GAME_PREFIX;

		// Token: 0x04001DEC RID: 7660
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04001DED RID: 7661
		private static readonly IntPtr NativeFieldInfoPtr_PRETTY_PRINT;

		// Token: 0x04001DEE RID: 7662
		private static readonly IntPtr NativeFieldInfoPtr_SaveError;

		// Token: 0x04001DEF RID: 7663
		private static readonly IntPtr NativeFieldInfoPtr__AccessPermissionIssueDetected_k__BackingField;

		// Token: 0x04001DF0 RID: 7664
		private static readonly IntPtr NativeFieldInfoPtr__IsSaving_k__BackingField;

		// Token: 0x04001DF1 RID: 7665
		private static readonly IntPtr NativeFieldInfoPtr__SecondsSinceLastSave_k__BackingField;

		// Token: 0x04001DF2 RID: 7666
		private static readonly IntPtr NativeFieldInfoPtr__PlayersSavePath_k__BackingField;

		// Token: 0x04001DF3 RID: 7667
		private static readonly IntPtr NativeFieldInfoPtr__IndividualSavesContainerPath_k__BackingField;

		// Token: 0x04001DF4 RID: 7668
		private static readonly IntPtr NativeFieldInfoPtr__SaveName_k__BackingField;

		// Token: 0x04001DF5 RID: 7669
		private static readonly IntPtr NativeFieldInfoPtr_Saveables;

		// Token: 0x04001DF6 RID: 7670
		private static readonly IntPtr NativeFieldInfoPtr_BaseSaveables;

		// Token: 0x04001DF7 RID: 7671
		private static readonly IntPtr NativeFieldInfoPtr_ApprovedBaseLevelPaths;

		// Token: 0x04001DF8 RID: 7672
		private static readonly IntPtr NativeFieldInfoPtr_CompletedSaveables;

		// Token: 0x04001DF9 RID: 7673
		private static readonly IntPtr NativeFieldInfoPtr_QueuedSaveRequests;

		// Token: 0x04001DFA RID: 7674
		private static readonly IntPtr NativeFieldInfoPtr_WriteIssueDisplay;

		// Token: 0x04001DFB RID: 7675
		private static readonly IntPtr NativeFieldInfoPtr_onSaveStart;

		// Token: 0x04001DFC RID: 7676
		private static readonly IntPtr NativeFieldInfoPtr_onSaveComplete;

		// Token: 0x04001DFD RID: 7677
		private static readonly IntPtr NativeFieldInfoPtr_saveFolderInitialized;

		// Token: 0x04001DFE RID: 7678
		private static readonly IntPtr NativeMethodInfoPtr_ReportSaveError_Public_Static_Void_0;

		// Token: 0x04001DFF RID: 7679
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessPermissionIssueDetected_Public_get_Boolean_0;

		// Token: 0x04001E00 RID: 7680
		private static readonly IntPtr NativeMethodInfoPtr_set_AccessPermissionIssueDetected_Protected_set_Void_Boolean_0;

		// Token: 0x04001E01 RID: 7681
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSaving_Public_get_Boolean_0;

		// Token: 0x04001E02 RID: 7682
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSaving_Protected_set_Void_Boolean_0;

		// Token: 0x04001E03 RID: 7683
		private static readonly IntPtr NativeMethodInfoPtr_get_SecondsSinceLastSave_Public_get_Single_0;

		// Token: 0x04001E04 RID: 7684
		private static readonly IntPtr NativeMethodInfoPtr_set_SecondsSinceLastSave_Protected_set_Void_Single_0;

		// Token: 0x04001E05 RID: 7685
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayersSavePath_Public_get_String_0;

		// Token: 0x04001E06 RID: 7686
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayersSavePath_Protected_set_Void_String_0;

		// Token: 0x04001E07 RID: 7687
		private static readonly IntPtr NativeMethodInfoPtr_get_IndividualSavesContainerPath_Public_get_String_0;

		// Token: 0x04001E08 RID: 7688
		private static readonly IntPtr NativeMethodInfoPtr_set_IndividualSavesContainerPath_Protected_set_Void_String_0;

		// Token: 0x04001E09 RID: 7689
		private static readonly IntPtr NativeMethodInfoPtr_get_BackupFolderPath_Public_get_String_0;

		// Token: 0x04001E0A RID: 7690
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveName_Public_get_String_0;

		// Token: 0x04001E0B RID: 7691
		private static readonly IntPtr NativeMethodInfoPtr_set_SaveName_Protected_set_Void_String_0;

		// Token: 0x04001E0C RID: 7692
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04001E0D RID: 7693
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001E0E RID: 7694
		private static readonly IntPtr NativeMethodInfoPtr_CheckSaveFolderInitialized_Public_Void_0;

		// Token: 0x04001E0F RID: 7695
		private static readonly IntPtr NativeMethodInfoPtr_HasWritePermissionOnDir_Public_Static_Boolean_String_0;

		// Token: 0x04001E10 RID: 7696
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001E11 RID: 7697
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Void_0;

		// Token: 0x04001E12 RID: 7698
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Void_String_0;

		// Token: 0x04001E13 RID: 7699
		private static readonly IntPtr NativeMethodInfoPtr_ClearBaseLevelOutdatedSaves_Private_Void_String_0;

		// Token: 0x04001E14 RID: 7700
		private static readonly IntPtr NativeMethodInfoPtr_CompleteSaveable_Public_Void_ISaveable_0;

		// Token: 0x04001E15 RID: 7701
		private static readonly IntPtr NativeMethodInfoPtr_ClearCompletedSaveable_Public_Void_ISaveable_0;

		// Token: 0x04001E16 RID: 7702
		private static readonly IntPtr NativeMethodInfoPtr_CreateSaveBackup_Public_Void_SaveInfo_0;

		// Token: 0x04001E17 RID: 7703
		private static readonly IntPtr NativeMethodInfoPtr_RegisterSaveable_Public_Void_ISaveable_0;

		// Token: 0x04001E18 RID: 7704
		private static readonly IntPtr NativeMethodInfoPtr_QueueSaveRequest_Public_Void_SaveRequest_0;

		// Token: 0x04001E19 RID: 7705
		private static readonly IntPtr NativeMethodInfoPtr_DequeueSaveRequest_Public_Void_SaveRequest_0;

		// Token: 0x04001E1A RID: 7706
		private static readonly IntPtr NativeMethodInfoPtr_StripExtensions_Public_Static_String_String_0;

		// Token: 0x04001E1B RID: 7707
		private static readonly IntPtr NativeMethodInfoPtr_MakeFileSafe_Public_Static_String_String_0;

		// Token: 0x04001E1C RID: 7708
		private static readonly IntPtr NativeMethodInfoPtr_GetVersionNumber_Public_Static_Single_String_0;

		// Token: 0x04001E1D RID: 7709
		private static readonly IntPtr NativeMethodInfoPtr_Clean_Private_Void_0;

		// Token: 0x04001E1E RID: 7710
		private static readonly IntPtr NativeMethodInfoPtr_DisablePlayTutorial_Public_Void_SaveInfo_0;

		// Token: 0x04001E1F RID: 7711
		private static readonly IntPtr NativeMethodInfoPtr_SanitizeFileName_Public_Static_String_String_0;

		// Token: 0x04001E20 RID: 7712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009B6 RID: 2486
		[ObfuscatedName("ScheduleOne.Persistence.SaveManager+<>c__DisplayClass52_0")]
		public sealed class __c__DisplayClass52_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB7D RID: 56189 RVA: 0x0036564C File Offset: 0x0036384C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass52_0()
			{
				Il2CppClassPointerStore<SaveManager.__c__DisplayClass52_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "<>c__DisplayClass52_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveManager.__c__DisplayClass52_0>.NativeClassPtr);
				SaveManager.__c__DisplayClass52_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager.__c__DisplayClass52_0>.NativeClassPtr, "<>4__this");
				SaveManager.__c__DisplayClass52_0.NativeFieldInfoPtr_saveFolderPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager.__c__DisplayClass52_0>.NativeClassPtr, "saveFolderPath");
				SaveManager.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass52_0>.NativeClassPtr, 100668950);
				SaveManager.__c__DisplayClass52_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass52_0>.NativeClassPtr, 100668951);
			}

			// Token: 0x0600DB7E RID: 56190 RVA: 0x003656C8 File Offset: 0x003638C8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass52_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveManager.__c__DisplayClass52_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB7F RID: 56191 RVA: 0x00365704 File Offset: 0x00363904
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127457, XrefRangeEnd = 127462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass52_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DB80 RID: 56192 RVA: 0x00067330 File Offset: 0x00065530
			public __c__DisplayClass52_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042F9 RID: 17145
			// (get) Token: 0x0600DB81 RID: 56193 RVA: 0x00365744 File Offset: 0x00363944
			// (set) Token: 0x0600DB82 RID: 56194 RVA: 0x00067339 File Offset: 0x00065539
			public unsafe SaveManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass52_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass52_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042FA RID: 17146
			// (get) Token: 0x0600DB83 RID: 56195 RVA: 0x00365774 File Offset: 0x00363974
			// (set) Token: 0x0600DB84 RID: 56196 RVA: 0x00067358 File Offset: 0x00065558
			public unsafe string saveFolderPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass52_0.NativeFieldInfoPtr_saveFolderPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass52_0.NativeFieldInfoPtr_saveFolderPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040095EA RID: 38378
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040095EB RID: 38379
			private static readonly IntPtr NativeFieldInfoPtr_saveFolderPath;

			// Token: 0x040095EC RID: 38380
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095ED RID: 38381
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DBB RID: 3515
			[ObfuscatedName("ScheduleOne.Persistence.SaveManager+<>c__DisplayClass52_0+<<Save>g__SaveRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FE07 RID: 65031 RVA: 0x003C7688 File Offset: 0x003C5888
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveManager.__c__DisplayClass52_0>.NativeClassPtr, "<<Save>g__SaveRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668952);
					SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668953);
					SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668954);
					SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668955);
					SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668956);
					SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668957);
				}

				// Token: 0x0600FE08 RID: 65032 RVA: 0x003C7768 File Offset: 0x003C5968
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FE09 RID: 65033 RVA: 0x003C77B0 File Offset: 0x003C59B0
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FE0A RID: 65034 RVA: 0x003C77E4 File Offset: 0x003C59E4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127365, XrefRangeEnd = 127452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004D43 RID: 19779
				// (get) Token: 0x0600FE0B RID: 65035 RVA: 0x003C7820 File Offset: 0x003C5A20
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FE0C RID: 65036 RVA: 0x003C7860 File Offset: 0x003C5A60
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127452, XrefRangeEnd = 127457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004D44 RID: 19780
				// (get) Token: 0x0600FE0D RID: 65037 RVA: 0x003C7894 File Offset: 0x003C5A94
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FE0E RID: 65038 RVA: 0x000785CE File Offset: 0x000767CE
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004D40 RID: 19776
				// (get) Token: 0x0600FE0F RID: 65039 RVA: 0x003C78D4 File Offset: 0x003C5AD4
				// (set) Token: 0x0600FE10 RID: 65040 RVA: 0x000785D7 File Offset: 0x000767D7
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004D41 RID: 19777
				// (get) Token: 0x0600FE11 RID: 65041 RVA: 0x003C78FC File Offset: 0x003C5AFC
				// (set) Token: 0x0600FE12 RID: 65042 RVA: 0x000785F2 File Offset: 0x000767F2
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D42 RID: 19778
				// (get) Token: 0x0600FE13 RID: 65043 RVA: 0x003C792C File Offset: 0x003C5B2C
				// (set) Token: 0x0600FE14 RID: 65044 RVA: 0x00078611 File Offset: 0x00076811
				public unsafe SaveManager.__c__DisplayClass52_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveManager.__c__DisplayClass52_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass52_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AB3A RID: 43834
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AB3B RID: 43835
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AB3C RID: 43836
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AB3D RID: 43837
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AB3E RID: 43838
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB3F RID: 43839
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AB40 RID: 43840
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AB41 RID: 43841
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB42 RID: 43842
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
