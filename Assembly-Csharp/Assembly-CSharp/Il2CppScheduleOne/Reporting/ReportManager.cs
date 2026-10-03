using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Networking;

namespace Il2CppScheduleOne.Reporting
{
	// Token: 0x02000135 RID: 309
	public static class ReportManager : Object
	{
		// Token: 0x06001F28 RID: 7976 RVA: 0x000E1170 File Offset: 0x000DF370
		// Note: this type is marked as 'beforefieldinit'.
		static ReportManager()
		{
			Il2CppClassPointerStore<ReportManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Reporting", "ReportManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReportManager>.NativeClassPtr);
			ReportManager.NativeFieldInfoPtr_ServerUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, "ServerUrl");
			ReportManager.NativeFieldInfoPtr_SubmissionCooldownSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, "SubmissionCooldownSeconds");
			ReportManager.NativeFieldInfoPtr__CurrentSubmissionStage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, "<CurrentSubmissionStage>k__BackingField");
			ReportManager.NativeFieldInfoPtr__submissionInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, "_submissionInProgress");
			ReportManager.NativeFieldInfoPtr__timeOnLastSubmissionCompletion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, "_timeOnLastSubmissionCompletion");
			ReportManager.NativeFieldInfoPtr__pendingCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, "_pendingCallback");
			ReportManager.NativeFieldInfoPtr__screenshotInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, "_screenshotInProgress");
			ReportManager.NativeFieldInfoPtr__screenshotBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, "_screenshotBytes");
			ReportManager.NativeMethodInfoPtr_get_IsSubmittingReport_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, 100667309);
			ReportManager.NativeMethodInfoPtr_get_IsOnSubmissionCooldown_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, 100667310);
			ReportManager.NativeMethodInfoPtr_get_CurrentSubmissionStage_Public_Static_get_ESubmissionStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, 100667311);
			ReportManager.NativeMethodInfoPtr_set_CurrentSubmissionStage_Private_Static_set_Void_ESubmissionStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, 100667312);
			ReportManager.NativeMethodInfoPtr_CanSubmitReport_Public_Static_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, 100667313);
			ReportManager.NativeMethodInfoPtr_SubmitReport_Public_Static_Void_String_String_Il2CppReferenceArray_1_ReportTag_Dictionary_2_String_String_Boolean_Boolean_Action_2_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, 100667314);
			ReportManager.NativeMethodInfoPtr_GetSaveGameBytes_Private_Static_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, 100667315);
			ReportManager.NativeMethodInfoPtr_PrepareScreenshot_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, 100667316);
			ReportManager.NativeMethodInfoPtr_UploadAttachments_Private_Static_IEnumerator_ReportResponseData_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, 100667317);
			ReportManager.NativeMethodInfoPtr_UploadBytes_Private_Static_IEnumerator_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, 100667318);
			ReportManager.NativeMethodInfoPtr_GetAdditionalInfo_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, 100667319);
			ReportManager.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, 100667321);
			ReportManager.NativeMethodInfoPtr_Method_Internal_Static_Void_Il2CppStructArray_1_Byte_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, 100667322);
			ReportManager.NativeMethodInfoPtr_Method_Internal_Static_Void_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, 100667323);
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06001F29 RID: 7977 RVA: 0x000E1358 File Offset: 0x000DF558
		public unsafe static bool IsSubmittingReport
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106465, XrefRangeEnd = 106469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.NativeMethodInfoPtr_get_IsSubmittingReport_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06001F2A RID: 7978 RVA: 0x000E1388 File Offset: 0x000DF588
		public unsafe static bool IsOnSubmissionCooldown
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106469, XrefRangeEnd = 106474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.NativeMethodInfoPtr_get_IsOnSubmissionCooldown_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06001F2B RID: 7979 RVA: 0x000E13B8 File Offset: 0x000DF5B8
		// (set) Token: 0x06001F2C RID: 7980 RVA: 0x000E13E8 File Offset: 0x000DF5E8
		public unsafe static ReportManager.ESubmissionStage CurrentSubmissionStage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106474, XrefRangeEnd = 106478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.NativeMethodInfoPtr_get_CurrentSubmissionStage_Public_Static_get_ESubmissionStage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106478, XrefRangeEnd = 106482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.NativeMethodInfoPtr_set_CurrentSubmissionStage_Private_Static_set_Void_ESubmissionStage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x000E141C File Offset: 0x000DF61C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106502, RefRangeEnd = 106503, XrefRangeStart = 106482, XrefRangeEnd = 106502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanSubmitReport(out string reason)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReportManager.NativeMethodInfoPtr_CanSubmitReport_Public_Static_Boolean_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x000E1468 File Offset: 0x000DF668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106503, XrefRangeEnd = 106591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SubmitReport(string title, string description, Il2CppReferenceArray<ReportTag> tags, Dictionary<string, string> metadata, bool includeScreenshot, bool includeSaveFile, Action<bool, string> callback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tags);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(metadata);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeScreenshot;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeSaveFile;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.NativeMethodInfoPtr_SubmitReport_Public_Static_Void_String_String_Il2CppReferenceArray_1_ReportTag_Dictionary_2_String_String_Boolean_Boolean_Action_2_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x000E1504 File Offset: 0x000DF704
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106611, RefRangeEnd = 106612, XrefRangeStart = 106591, XrefRangeEnd = 106611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetSaveGameBytes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.NativeMethodInfoPtr_GetSaveGameBytes_Private_Static_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x000E1538 File Offset: 0x000DF738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106612, XrefRangeEnd = 106632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PrepareScreenshot()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.NativeMethodInfoPtr_PrepareScreenshot_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x000E1560 File Offset: 0x000DF760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106632, XrefRangeEnd = 106639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator UploadAttachments(ReportResponseData responseData, Il2CppStructArray<byte> screenshot, Il2CppStructArray<byte> savedGame)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(responseData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(screenshot);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(savedGame);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.NativeMethodInfoPtr_UploadAttachments_Private_Static_IEnumerator_ReportResponseData_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x000E15C8 File Offset: 0x000DF7C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106645, RefRangeEnd = 106646, XrefRangeStart = 106639, XrefRangeEnd = 106645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator UploadBytes(string signedUrl, Il2CppStructArray<byte> bytes)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(signedUrl);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.NativeMethodInfoPtr_UploadBytes_Private_Static_IEnumerator_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x000E1620 File Offset: 0x000DF820
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106771, RefRangeEnd = 106772, XrefRangeStart = 106646, XrefRangeEnd = 106771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAdditionalInfo()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.NativeMethodInfoPtr_GetAdditionalInfo_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x000E164C File Offset: 0x000DF84C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106772, XrefRangeEnd = 106776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Method_Internal_Static_IEnumerator_PDM_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x000E1680 File Offset: 0x000DF880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106776, XrefRangeEnd = 106783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_Il2CppStructArray_1_Byte_PDM_0(Il2CppStructArray<byte> screenshotBytes)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(screenshotBytes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.NativeMethodInfoPtr_Method_Internal_Static_Void_Il2CppStructArray_1_Byte_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x000E16B8 File Offset: 0x000DF8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106783, XrefRangeEnd = 106797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_String_PDM_0(string error)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.NativeMethodInfoPtr_Method_Internal_Static_Void_String_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x00010DE8 File Offset: 0x0000EFE8
		public ReportManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06001F38 RID: 7992 RVA: 0x000E16F0 File Offset: 0x000DF8F0
		// (set) Token: 0x06001F39 RID: 7993 RVA: 0x00010DF1 File Offset: 0x0000EFF1
		public unsafe static string ServerUrl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReportManager.NativeFieldInfoPtr_ServerUrl, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReportManager.NativeFieldInfoPtr_ServerUrl, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06001F3A RID: 7994 RVA: 0x000E1710 File Offset: 0x000DF910
		// (set) Token: 0x06001F3B RID: 7995 RVA: 0x00010E03 File Offset: 0x0000F003
		public unsafe static float SubmissionCooldownSeconds
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ReportManager.NativeFieldInfoPtr_SubmissionCooldownSeconds, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReportManager.NativeFieldInfoPtr_SubmissionCooldownSeconds, (void*)(&value));
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06001F3C RID: 7996 RVA: 0x000E172C File Offset: 0x000DF92C
		// (set) Token: 0x06001F3D RID: 7997 RVA: 0x00010E11 File Offset: 0x0000F011
		public unsafe static ReportManager.ESubmissionStage _CurrentSubmissionStage_k__BackingField
		{
			get
			{
				ReportManager.ESubmissionStage result;
				IL2CPP.il2cpp_field_static_get_value(ReportManager.NativeFieldInfoPtr__CurrentSubmissionStage_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReportManager.NativeFieldInfoPtr__CurrentSubmissionStage_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06001F3E RID: 7998 RVA: 0x000E1748 File Offset: 0x000DF948
		// (set) Token: 0x06001F3F RID: 7999 RVA: 0x00010E1F File Offset: 0x0000F01F
		public unsafe static bool _submissionInProgress
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(ReportManager.NativeFieldInfoPtr__submissionInProgress, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReportManager.NativeFieldInfoPtr__submissionInProgress, (void*)(&value));
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06001F40 RID: 8000 RVA: 0x000E1764 File Offset: 0x000DF964
		// (set) Token: 0x06001F41 RID: 8001 RVA: 0x00010E2D File Offset: 0x0000F02D
		public unsafe static float _timeOnLastSubmissionCompletion
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ReportManager.NativeFieldInfoPtr__timeOnLastSubmissionCompletion, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReportManager.NativeFieldInfoPtr__timeOnLastSubmissionCompletion, (void*)(&value));
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06001F42 RID: 8002 RVA: 0x000E1780 File Offset: 0x000DF980
		// (set) Token: 0x06001F43 RID: 8003 RVA: 0x00010E3B File Offset: 0x0000F03B
		public unsafe static Action<bool, string> _pendingCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReportManager.NativeFieldInfoPtr__pendingCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReportManager.NativeFieldInfoPtr__pendingCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06001F44 RID: 8004 RVA: 0x000E17A8 File Offset: 0x000DF9A8
		// (set) Token: 0x06001F45 RID: 8005 RVA: 0x00010E4D File Offset: 0x0000F04D
		public unsafe static bool _screenshotInProgress
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(ReportManager.NativeFieldInfoPtr__screenshotInProgress, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReportManager.NativeFieldInfoPtr__screenshotInProgress, (void*)(&value));
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06001F46 RID: 8006 RVA: 0x000E17C4 File Offset: 0x000DF9C4
		// (set) Token: 0x06001F47 RID: 8007 RVA: 0x00010E5B File Offset: 0x0000F05B
		public unsafe static Il2CppStructArray<byte> _screenshotBytes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReportManager.NativeFieldInfoPtr__screenshotBytes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReportManager.NativeFieldInfoPtr__screenshotBytes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400158C RID: 5516
		private static readonly IntPtr NativeFieldInfoPtr_ServerUrl;

		// Token: 0x0400158D RID: 5517
		private static readonly IntPtr NativeFieldInfoPtr_SubmissionCooldownSeconds;

		// Token: 0x0400158E RID: 5518
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSubmissionStage_k__BackingField;

		// Token: 0x0400158F RID: 5519
		private static readonly IntPtr NativeFieldInfoPtr__submissionInProgress;

		// Token: 0x04001590 RID: 5520
		private static readonly IntPtr NativeFieldInfoPtr__timeOnLastSubmissionCompletion;

		// Token: 0x04001591 RID: 5521
		private static readonly IntPtr NativeFieldInfoPtr__pendingCallback;

		// Token: 0x04001592 RID: 5522
		private static readonly IntPtr NativeFieldInfoPtr__screenshotInProgress;

		// Token: 0x04001593 RID: 5523
		private static readonly IntPtr NativeFieldInfoPtr__screenshotBytes;

		// Token: 0x04001594 RID: 5524
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSubmittingReport_Public_Static_get_Boolean_0;

		// Token: 0x04001595 RID: 5525
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOnSubmissionCooldown_Public_Static_get_Boolean_0;

		// Token: 0x04001596 RID: 5526
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSubmissionStage_Public_Static_get_ESubmissionStage_0;

		// Token: 0x04001597 RID: 5527
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSubmissionStage_Private_Static_set_Void_ESubmissionStage_0;

		// Token: 0x04001598 RID: 5528
		private static readonly IntPtr NativeMethodInfoPtr_CanSubmitReport_Public_Static_Boolean_byref_String_0;

		// Token: 0x04001599 RID: 5529
		private static readonly IntPtr NativeMethodInfoPtr_SubmitReport_Public_Static_Void_String_String_Il2CppReferenceArray_1_ReportTag_Dictionary_2_String_String_Boolean_Boolean_Action_2_Boolean_String_0;

		// Token: 0x0400159A RID: 5530
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveGameBytes_Private_Static_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400159B RID: 5531
		private static readonly IntPtr NativeMethodInfoPtr_PrepareScreenshot_Public_Static_Void_0;

		// Token: 0x0400159C RID: 5532
		private static readonly IntPtr NativeMethodInfoPtr_UploadAttachments_Private_Static_IEnumerator_ReportResponseData_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400159D RID: 5533
		private static readonly IntPtr NativeMethodInfoPtr_UploadBytes_Private_Static_IEnumerator_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400159E RID: 5534
		private static readonly IntPtr NativeMethodInfoPtr_GetAdditionalInfo_Private_Static_String_0;

		// Token: 0x0400159F RID: 5535
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0;

		// Token: 0x040015A0 RID: 5536
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_Il2CppStructArray_1_Byte_PDM_0;

		// Token: 0x040015A1 RID: 5537
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_String_PDM_0;

		// Token: 0x0200095F RID: 2399
		[OriginalName("Assembly-CSharp.dll", "", "ESubmissionStage")]
		public enum ESubmissionStage
		{
			// Token: 0x04009412 RID: 37906
			Authenticating,
			// Token: 0x04009413 RID: 37907
			SubmittingReport,
			// Token: 0x04009414 RID: 37908
			UploadingAttachments
		}

		// Token: 0x02000960 RID: 2400
		[ObfuscatedName("ScheduleOne.Reporting.ReportManager+<<PrepareScreenshot>g__CaptureScreenshot|19_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Object
		{
			// Token: 0x0600D8E1 RID: 55521 RVA: 0x0035DC6C File Offset: 0x0035BE6C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
			{
				Il2CppClassPointerStore<ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, "<<PrepareScreenshot>g__CaptureScreenshot|19_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
				ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
				ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
				ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667324);
				ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667325);
				ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667326);
				ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667327);
				ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667328);
				ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667329);
			}

			// Token: 0x0600D8E2 RID: 55522 RVA: 0x0035DD38 File Offset: 0x0035BF38
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8E3 RID: 55523 RVA: 0x0035DD80 File Offset: 0x0035BF80
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8E4 RID: 55524 RVA: 0x0035DDB4 File Offset: 0x0035BFB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106079, XrefRangeEnd = 106097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700423D RID: 16957
			// (get) Token: 0x0600D8E5 RID: 55525 RVA: 0x0035DDF0 File Offset: 0x0035BFF0
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D8E6 RID: 55526 RVA: 0x0035DE30 File Offset: 0x0035C030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106097, XrefRangeEnd = 106102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700423E RID: 16958
			// (get) Token: 0x0600D8E7 RID: 55527 RVA: 0x0035DE64 File Offset: 0x0035C064
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D8E8 RID: 55528 RVA: 0x00065FC5 File Offset: 0x000641C5
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700423B RID: 16955
			// (get) Token: 0x0600D8E9 RID: 55529 RVA: 0x0035DEA4 File Offset: 0x0035C0A4
			// (set) Token: 0x0600D8EA RID: 55530 RVA: 0x00065FCE File Offset: 0x000641CE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700423C RID: 16956
			// (get) Token: 0x0600D8EB RID: 55531 RVA: 0x0035DECC File Offset: 0x0035C0CC
			// (set) Token: 0x0600D8EC RID: 55532 RVA: 0x00065FE9 File Offset: 0x000641E9
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009415 RID: 37909
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009416 RID: 37910
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009417 RID: 37911
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009418 RID: 37912
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009419 RID: 37913
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400941A RID: 37914
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400941B RID: 37915
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400941C RID: 37916
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000961 RID: 2401
		[ObfuscatedName("ScheduleOne.Reporting.ReportManager+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600D8ED RID: 55533 RVA: 0x0035DEFC File Offset: 0x0035C0FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ReportManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReportManager.__c>.NativeClassPtr);
				ReportManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager.__c>.NativeClassPtr, "<>9");
				ReportManager.__c.NativeFieldInfoPtr___9__17_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager.__c>.NativeClassPtr, "<>9__17_1");
				ReportManager.__c.NativeFieldInfoPtr___9__17_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager.__c>.NativeClassPtr, "<>9__17_2");
				ReportManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager.__c>.NativeClassPtr, 100667331);
				ReportManager.__c.NativeMethodInfoPtr__SubmitReport_b__17_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager.__c>.NativeClassPtr, 100667332);
				ReportManager.__c.NativeMethodInfoPtr__SubmitReport_b__17_2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager.__c>.NativeClassPtr, 100667333);
			}

			// Token: 0x0600D8EE RID: 55534 RVA: 0x0035DFA0 File Offset: 0x0035C1A0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReportManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8EF RID: 55535 RVA: 0x0035DFDC File Offset: 0x0035C1DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106102, XrefRangeEnd = 106109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SubmitReport_b__17_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.__c.NativeMethodInfoPtr__SubmitReport_b__17_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D8F0 RID: 55536 RVA: 0x0035E018 File Offset: 0x0035C218
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106109, XrefRangeEnd = 106113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SubmitReport_b__17_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.__c.NativeMethodInfoPtr__SubmitReport_b__17_2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D8F1 RID: 55537 RVA: 0x00066008 File Offset: 0x00064208
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700423F RID: 16959
			// (get) Token: 0x0600D8F2 RID: 55538 RVA: 0x0035E054 File Offset: 0x0035C254
			// (set) Token: 0x0600D8F3 RID: 55539 RVA: 0x00066011 File Offset: 0x00064211
			public unsafe static ReportManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReportManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReportManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReportManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004240 RID: 16960
			// (get) Token: 0x0600D8F4 RID: 55540 RVA: 0x0035E07C File Offset: 0x0035C27C
			// (set) Token: 0x0600D8F5 RID: 55541 RVA: 0x00066023 File Offset: 0x00064223
			public unsafe static Func<bool> __9__17_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReportManager.__c.NativeFieldInfoPtr___9__17_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReportManager.__c.NativeFieldInfoPtr___9__17_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004241 RID: 16961
			// (get) Token: 0x0600D8F6 RID: 55542 RVA: 0x0035E0A4 File Offset: 0x0035C2A4
			// (set) Token: 0x0600D8F7 RID: 55543 RVA: 0x00066035 File Offset: 0x00064235
			public unsafe static Func<bool> __9__17_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReportManager.__c.NativeFieldInfoPtr___9__17_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReportManager.__c.NativeFieldInfoPtr___9__17_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400941D RID: 37917
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400941E RID: 37918
			private static readonly IntPtr NativeFieldInfoPtr___9__17_1;

			// Token: 0x0400941F RID: 37919
			private static readonly IntPtr NativeFieldInfoPtr___9__17_2;

			// Token: 0x04009420 RID: 37920
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009421 RID: 37921
			private static readonly IntPtr NativeMethodInfoPtr__SubmitReport_b__17_1_Internal_Boolean_0;

			// Token: 0x04009422 RID: 37922
			private static readonly IntPtr NativeMethodInfoPtr__SubmitReport_b__17_2_Internal_Boolean_0;
		}

		// Token: 0x02000962 RID: 2402
		[ObfuscatedName("ScheduleOne.Reporting.ReportManager+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Object
		{
			// Token: 0x0600D8F8 RID: 55544 RVA: 0x0035E0CC File Offset: 0x0035C2CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0>.NativeClassPtr);
				ReportManager.__c__DisplayClass17_0.NativeFieldInfoPtr_submission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0>.NativeClassPtr, "submission");
				ReportManager.__c__DisplayClass17_0.NativeFieldInfoPtr_includeScreenshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0>.NativeClassPtr, "includeScreenshot");
				ReportManager.__c__DisplayClass17_0.NativeFieldInfoPtr_savedGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0>.NativeClassPtr, "savedGame");
				ReportManager.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0>.NativeClassPtr, 100667334);
				ReportManager.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0>.NativeClassPtr, 100667335);
			}

			// Token: 0x0600D8F9 RID: 55545 RVA: 0x0035E15C File Offset: 0x0035C35C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8FA RID: 55546 RVA: 0x0035E198 File Offset: 0x0035C398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106314, XrefRangeEnd = 106319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D8FB RID: 55547 RVA: 0x00066047 File Offset: 0x00064247
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004242 RID: 16962
			// (get) Token: 0x0600D8FC RID: 55548 RVA: 0x0035E1D8 File Offset: 0x0035C3D8
			// (set) Token: 0x0600D8FD RID: 55549 RVA: 0x00066050 File Offset: 0x00064250
			public unsafe ReportSubmission submission
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager.__c__DisplayClass17_0.NativeFieldInfoPtr_submission);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReportSubmission>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager.__c__DisplayClass17_0.NativeFieldInfoPtr_submission), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004243 RID: 16963
			// (get) Token: 0x0600D8FE RID: 55550 RVA: 0x0035E208 File Offset: 0x0035C408
			// (set) Token: 0x0600D8FF RID: 55551 RVA: 0x0006606F File Offset: 0x0006426F
			public unsafe bool includeScreenshot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager.__c__DisplayClass17_0.NativeFieldInfoPtr_includeScreenshot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager.__c__DisplayClass17_0.NativeFieldInfoPtr_includeScreenshot)) = value;
				}
			}

			// Token: 0x17004244 RID: 16964
			// (get) Token: 0x0600D900 RID: 55552 RVA: 0x0035E230 File Offset: 0x0035C430
			// (set) Token: 0x0600D901 RID: 55553 RVA: 0x0006608A File Offset: 0x0006428A
			public unsafe Il2CppStructArray<byte> savedGame
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager.__c__DisplayClass17_0.NativeFieldInfoPtr_savedGame);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager.__c__DisplayClass17_0.NativeFieldInfoPtr_savedGame), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009423 RID: 37923
			private static readonly IntPtr NativeFieldInfoPtr_submission;

			// Token: 0x04009424 RID: 37924
			private static readonly IntPtr NativeFieldInfoPtr_includeScreenshot;

			// Token: 0x04009425 RID: 37925
			private static readonly IntPtr NativeFieldInfoPtr_savedGame;

			// Token: 0x04009426 RID: 37926
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009427 RID: 37927
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DB3 RID: 3507
			[ObfuscatedName("ScheduleOne.Reporting.ReportManager+<>c__DisplayClass17_0+<<SubmitReport>g__Submit|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique : Object
			{
				// Token: 0x0600FD78 RID: 64888 RVA: 0x003C5BCC File Offset: 0x003C3DCC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique()
				{
					Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0>.NativeClassPtr, "<<SubmitReport>g__Submit|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique>.NativeClassPtr);
					ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique>.NativeClassPtr, "<>1__state");
					ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique>.NativeClassPtr, "<>2__current");
					ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique>.NativeClassPtr, "<>4__this");
					ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeFieldInfoPtr__req_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique>.NativeClassPtr, "<req>5__2");
					ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeFieldInfoPtr__response_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique>.NativeClassPtr, "<response>5__3");
					ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique>.NativeClassPtr, 100667336);
					ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique>.NativeClassPtr, 100667337);
					ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique>.NativeClassPtr, 100667338);
					ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique>.NativeClassPtr, 100667339);
					ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique>.NativeClassPtr, 100667340);
					ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique>.NativeClassPtr, 100667341);
					ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique>.NativeClassPtr, 100667342);
				}

				// Token: 0x0600FD79 RID: 64889 RVA: 0x003C5CE8 File Offset: 0x003C3EE8
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FD7A RID: 64890 RVA: 0x003C5D30 File Offset: 0x003C3F30
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106113, XrefRangeEnd = 106118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FD7B RID: 64891 RVA: 0x003C5D64 File Offset: 0x003C3F64
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106118, XrefRangeEnd = 106306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600FD7C RID: 64892 RVA: 0x003C5DA0 File Offset: 0x003C3FA0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106306, XrefRangeEnd = 106309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void __m__Finally1()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004D0E RID: 19726
				// (get) Token: 0x0600FD7D RID: 64893 RVA: 0x003C5DD4 File Offset: 0x003C3FD4
				public unsafe Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FD7E RID: 64894 RVA: 0x003C5E14 File Offset: 0x003C4014
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106309, XrefRangeEnd = 106314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004D0F RID: 19727
				// (get) Token: 0x0600FD7F RID: 64895 RVA: 0x003C5E48 File Offset: 0x003C4048
				public unsafe Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FD80 RID: 64896 RVA: 0x00078101 File Offset: 0x00076301
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004D09 RID: 19721
				// (get) Token: 0x0600FD81 RID: 64897 RVA: 0x003C5E88 File Offset: 0x003C4088
				// (set) Token: 0x0600FD82 RID: 64898 RVA: 0x0007810A File Offset: 0x0007630A
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004D0A RID: 19722
				// (get) Token: 0x0600FD83 RID: 64899 RVA: 0x003C5EB0 File Offset: 0x003C40B0
				// (set) Token: 0x0600FD84 RID: 64900 RVA: 0x00078125 File Offset: 0x00076325
				public unsafe Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D0B RID: 19723
				// (get) Token: 0x0600FD85 RID: 64901 RVA: 0x003C5EE0 File Offset: 0x003C40E0
				// (set) Token: 0x0600FD86 RID: 64902 RVA: 0x00078144 File Offset: 0x00076344
				public unsafe ReportManager.__c__DisplayClass17_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReportManager.__c__DisplayClass17_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D0C RID: 19724
				// (get) Token: 0x0600FD87 RID: 64903 RVA: 0x003C5F10 File Offset: 0x003C4110
				// (set) Token: 0x0600FD88 RID: 64904 RVA: 0x00078163 File Offset: 0x00076363
				public unsafe UnityWebRequest _req_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeFieldInfoPtr__req_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeFieldInfoPtr__req_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D0D RID: 19725
				// (get) Token: 0x0600FD89 RID: 64905 RVA: 0x003C5F40 File Offset: 0x003C4140
				// (set) Token: 0x0600FD8A RID: 64906 RVA: 0x00078182 File Offset: 0x00076382
				public unsafe ReportSubmissionResponse _response_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeFieldInfoPtr__response_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReportSubmissionResponse>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUnReObObUnique.NativeFieldInfoPtr__response_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AAE2 RID: 43746
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AAE3 RID: 43747
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AAE4 RID: 43748
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AAE5 RID: 43749
				private static readonly IntPtr NativeFieldInfoPtr__req_5__2;

				// Token: 0x0400AAE6 RID: 43750
				private static readonly IntPtr NativeFieldInfoPtr__response_5__3;

				// Token: 0x0400AAE7 RID: 43751
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AAE8 RID: 43752
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AAE9 RID: 43753
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AAEA RID: 43754
				private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

				// Token: 0x0400AAEB RID: 43755
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AAEC RID: 43756
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AAED RID: 43757
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000963 RID: 2403
		[ObfuscatedName("ScheduleOne.Reporting.ReportManager+<UploadAttachments>d__20")]
		public sealed class _UploadAttachments_d__20 : Object
		{
			// Token: 0x0600D902 RID: 55554 RVA: 0x0035E260 File Offset: 0x0035C460
			// Note: this type is marked as 'beforefieldinit'.
			static _UploadAttachments_d__20()
			{
				Il2CppClassPointerStore<ReportManager._UploadAttachments_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, "<UploadAttachments>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReportManager._UploadAttachments_d__20>.NativeClassPtr);
				ReportManager._UploadAttachments_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager._UploadAttachments_d__20>.NativeClassPtr, "<>1__state");
				ReportManager._UploadAttachments_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager._UploadAttachments_d__20>.NativeClassPtr, "<>2__current");
				ReportManager._UploadAttachments_d__20.NativeFieldInfoPtr_responseData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager._UploadAttachments_d__20>.NativeClassPtr, "responseData");
				ReportManager._UploadAttachments_d__20.NativeFieldInfoPtr_savedGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager._UploadAttachments_d__20>.NativeClassPtr, "savedGame");
				ReportManager._UploadAttachments_d__20.NativeFieldInfoPtr_screenshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager._UploadAttachments_d__20>.NativeClassPtr, "screenshot");
				ReportManager._UploadAttachments_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager._UploadAttachments_d__20>.NativeClassPtr, 100667343);
				ReportManager._UploadAttachments_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager._UploadAttachments_d__20>.NativeClassPtr, 100667344);
				ReportManager._UploadAttachments_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager._UploadAttachments_d__20>.NativeClassPtr, 100667345);
				ReportManager._UploadAttachments_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager._UploadAttachments_d__20>.NativeClassPtr, 100667346);
				ReportManager._UploadAttachments_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager._UploadAttachments_d__20>.NativeClassPtr, 100667347);
				ReportManager._UploadAttachments_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager._UploadAttachments_d__20>.NativeClassPtr, 100667348);
			}

			// Token: 0x0600D903 RID: 55555 RVA: 0x0035E368 File Offset: 0x0035C568
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UploadAttachments_d__20(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReportManager._UploadAttachments_d__20>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager._UploadAttachments_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D904 RID: 55556 RVA: 0x0035E3B0 File Offset: 0x0035C5B0
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager._UploadAttachments_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D905 RID: 55557 RVA: 0x0035E3E4 File Offset: 0x0035C5E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106319, XrefRangeEnd = 106417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager._UploadAttachments_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700424A RID: 16970
			// (get) Token: 0x0600D906 RID: 55558 RVA: 0x0035E420 File Offset: 0x0035C620
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager._UploadAttachments_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D907 RID: 55559 RVA: 0x0035E460 File Offset: 0x0035C660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106417, XrefRangeEnd = 106422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager._UploadAttachments_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700424B RID: 16971
			// (get) Token: 0x0600D908 RID: 55560 RVA: 0x0035E494 File Offset: 0x0035C694
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager._UploadAttachments_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D909 RID: 55561 RVA: 0x000660A9 File Offset: 0x000642A9
			public _UploadAttachments_d__20(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004245 RID: 16965
			// (get) Token: 0x0600D90A RID: 55562 RVA: 0x0035E4D4 File Offset: 0x0035C6D4
			// (set) Token: 0x0600D90B RID: 55563 RVA: 0x000660B2 File Offset: 0x000642B2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager._UploadAttachments_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager._UploadAttachments_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004246 RID: 16966
			// (get) Token: 0x0600D90C RID: 55564 RVA: 0x0035E4FC File Offset: 0x0035C6FC
			// (set) Token: 0x0600D90D RID: 55565 RVA: 0x000660CD File Offset: 0x000642CD
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager._UploadAttachments_d__20.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager._UploadAttachments_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004247 RID: 16967
			// (get) Token: 0x0600D90E RID: 55566 RVA: 0x0035E52C File Offset: 0x0035C72C
			// (set) Token: 0x0600D90F RID: 55567 RVA: 0x000660EC File Offset: 0x000642EC
			public unsafe ReportResponseData responseData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager._UploadAttachments_d__20.NativeFieldInfoPtr_responseData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReportResponseData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager._UploadAttachments_d__20.NativeFieldInfoPtr_responseData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004248 RID: 16968
			// (get) Token: 0x0600D910 RID: 55568 RVA: 0x0035E55C File Offset: 0x0035C75C
			// (set) Token: 0x0600D911 RID: 55569 RVA: 0x0006610B File Offset: 0x0006430B
			public unsafe Il2CppStructArray<byte> savedGame
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager._UploadAttachments_d__20.NativeFieldInfoPtr_savedGame);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager._UploadAttachments_d__20.NativeFieldInfoPtr_savedGame), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004249 RID: 16969
			// (get) Token: 0x0600D912 RID: 55570 RVA: 0x0035E58C File Offset: 0x0035C78C
			// (set) Token: 0x0600D913 RID: 55571 RVA: 0x0006612A File Offset: 0x0006432A
			public unsafe Il2CppStructArray<byte> screenshot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager._UploadAttachments_d__20.NativeFieldInfoPtr_screenshot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager._UploadAttachments_d__20.NativeFieldInfoPtr_screenshot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009428 RID: 37928
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009429 RID: 37929
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400942A RID: 37930
			private static readonly IntPtr NativeFieldInfoPtr_responseData;

			// Token: 0x0400942B RID: 37931
			private static readonly IntPtr NativeFieldInfoPtr_savedGame;

			// Token: 0x0400942C RID: 37932
			private static readonly IntPtr NativeFieldInfoPtr_screenshot;

			// Token: 0x0400942D RID: 37933
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400942E RID: 37934
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400942F RID: 37935
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009430 RID: 37936
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009431 RID: 37937
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009432 RID: 37938
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000964 RID: 2404
		[ObfuscatedName("ScheduleOne.Reporting.ReportManager+<UploadBytes>d__21")]
		public sealed class _UploadBytes_d__21 : Object
		{
			// Token: 0x0600D914 RID: 55572 RVA: 0x0035E5BC File Offset: 0x0035C7BC
			// Note: this type is marked as 'beforefieldinit'.
			static _UploadBytes_d__21()
			{
				Il2CppClassPointerStore<ReportManager._UploadBytes_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReportManager>.NativeClassPtr, "<UploadBytes>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReportManager._UploadBytes_d__21>.NativeClassPtr);
				ReportManager._UploadBytes_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager._UploadBytes_d__21>.NativeClassPtr, "<>1__state");
				ReportManager._UploadBytes_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager._UploadBytes_d__21>.NativeClassPtr, "<>2__current");
				ReportManager._UploadBytes_d__21.NativeFieldInfoPtr_signedUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager._UploadBytes_d__21>.NativeClassPtr, "signedUrl");
				ReportManager._UploadBytes_d__21.NativeFieldInfoPtr_bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager._UploadBytes_d__21>.NativeClassPtr, "bytes");
				ReportManager._UploadBytes_d__21.NativeFieldInfoPtr__request_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportManager._UploadBytes_d__21>.NativeClassPtr, "<request>5__2");
				ReportManager._UploadBytes_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager._UploadBytes_d__21>.NativeClassPtr, 100667349);
				ReportManager._UploadBytes_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager._UploadBytes_d__21>.NativeClassPtr, 100667350);
				ReportManager._UploadBytes_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager._UploadBytes_d__21>.NativeClassPtr, 100667351);
				ReportManager._UploadBytes_d__21.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager._UploadBytes_d__21>.NativeClassPtr, 100667352);
				ReportManager._UploadBytes_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager._UploadBytes_d__21>.NativeClassPtr, 100667353);
				ReportManager._UploadBytes_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager._UploadBytes_d__21>.NativeClassPtr, 100667354);
				ReportManager._UploadBytes_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportManager._UploadBytes_d__21>.NativeClassPtr, 100667355);
			}

			// Token: 0x0600D915 RID: 55573 RVA: 0x0035E6D8 File Offset: 0x0035C8D8
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UploadBytes_d__21(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReportManager._UploadBytes_d__21>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager._UploadBytes_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D916 RID: 55574 RVA: 0x0035E720 File Offset: 0x0035C920
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106422, XrefRangeEnd = 106427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager._UploadBytes_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D917 RID: 55575 RVA: 0x0035E754 File Offset: 0x0035C954
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106427, XrefRangeEnd = 106457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager._UploadBytes_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D918 RID: 55576 RVA: 0x0035E790 File Offset: 0x0035C990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106457, XrefRangeEnd = 106460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager._UploadBytes_d__21.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004251 RID: 16977
			// (get) Token: 0x0600D919 RID: 55577 RVA: 0x0035E7C4 File Offset: 0x0035C9C4
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager._UploadBytes_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D91A RID: 55578 RVA: 0x0035E804 File Offset: 0x0035CA04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106460, XrefRangeEnd = 106465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager._UploadBytes_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004252 RID: 16978
			// (get) Token: 0x0600D91B RID: 55579 RVA: 0x0035E838 File Offset: 0x0035CA38
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportManager._UploadBytes_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D91C RID: 55580 RVA: 0x00066149 File Offset: 0x00064349
			public _UploadBytes_d__21(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700424C RID: 16972
			// (get) Token: 0x0600D91D RID: 55581 RVA: 0x0035E878 File Offset: 0x0035CA78
			// (set) Token: 0x0600D91E RID: 55582 RVA: 0x00066152 File Offset: 0x00064352
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager._UploadBytes_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager._UploadBytes_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700424D RID: 16973
			// (get) Token: 0x0600D91F RID: 55583 RVA: 0x0035E8A0 File Offset: 0x0035CAA0
			// (set) Token: 0x0600D920 RID: 55584 RVA: 0x0006616D File Offset: 0x0006436D
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager._UploadBytes_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager._UploadBytes_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700424E RID: 16974
			// (get) Token: 0x0600D921 RID: 55585 RVA: 0x0035E8D0 File Offset: 0x0035CAD0
			// (set) Token: 0x0600D922 RID: 55586 RVA: 0x0006618C File Offset: 0x0006438C
			public unsafe string signedUrl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager._UploadBytes_d__21.NativeFieldInfoPtr_signedUrl);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager._UploadBytes_d__21.NativeFieldInfoPtr_signedUrl), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700424F RID: 16975
			// (get) Token: 0x0600D923 RID: 55587 RVA: 0x0035E8F8 File Offset: 0x0035CAF8
			// (set) Token: 0x0600D924 RID: 55588 RVA: 0x000661AB File Offset: 0x000643AB
			public unsafe Il2CppStructArray<byte> bytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager._UploadBytes_d__21.NativeFieldInfoPtr_bytes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager._UploadBytes_d__21.NativeFieldInfoPtr_bytes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004250 RID: 16976
			// (get) Token: 0x0600D925 RID: 55589 RVA: 0x0035E928 File Offset: 0x0035CB28
			// (set) Token: 0x0600D926 RID: 55590 RVA: 0x000661CA File Offset: 0x000643CA
			public unsafe UnityWebRequest _request_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager._UploadBytes_d__21.NativeFieldInfoPtr__request_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportManager._UploadBytes_d__21.NativeFieldInfoPtr__request_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009433 RID: 37939
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009434 RID: 37940
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009435 RID: 37941
			private static readonly IntPtr NativeFieldInfoPtr_signedUrl;

			// Token: 0x04009436 RID: 37942
			private static readonly IntPtr NativeFieldInfoPtr_bytes;

			// Token: 0x04009437 RID: 37943
			private static readonly IntPtr NativeFieldInfoPtr__request_5__2;

			// Token: 0x04009438 RID: 37944
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009439 RID: 37945
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400943A RID: 37946
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400943B RID: 37947
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400943C RID: 37948
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400943D RID: 37949
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400943E RID: 37950
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
