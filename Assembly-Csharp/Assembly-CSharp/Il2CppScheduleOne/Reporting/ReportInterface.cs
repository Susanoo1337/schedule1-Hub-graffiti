using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Reporting
{
	// Token: 0x02000134 RID: 308
	public class ReportInterface : MonoBehaviour
	{
		// Token: 0x06001EEF RID: 7919 RVA: 0x000E0608 File Offset: 0x000DE808
		// Note: this type is marked as 'beforefieldinit'.
		static ReportInterface()
		{
			Il2CppClassPointerStore<ReportInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Reporting", "ReportInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr);
			ReportInterface.NativeFieldInfoPtr__titleInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, "_titleInput");
			ReportInterface.NativeFieldInfoPtr__descriptionInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, "_descriptionInput");
			ReportInterface.NativeFieldInfoPtr__reportTypeDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, "_reportTypeDropdown");
			ReportInterface.NativeFieldInfoPtr__includeSaveFileToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, "_includeSaveFileToggle");
			ReportInterface.NativeFieldInfoPtr__includeScreenshotToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, "_includeScreenshotToggle");
			ReportInterface.NativeFieldInfoPtr__selectablesToTriggerAuthPrep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, "_selectablesToTriggerAuthPrep");
			ReportInterface.NativeFieldInfoPtr__titleRequiredLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, "_titleRequiredLabel");
			ReportInterface.NativeFieldInfoPtr__descriptionRequiredLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, "_descriptionRequiredLabel");
			ReportInterface.NativeFieldInfoPtr__typeRequiredLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, "_typeRequiredLabel");
			ReportInterface.NativeFieldInfoPtr__submitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, "_submitButton");
			ReportInterface.NativeFieldInfoPtr__inProgressContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, "_inProgressContainer");
			ReportInterface.NativeFieldInfoPtr__inProgressText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, "_inProgressText");
			ReportInterface.NativeFieldInfoPtr__cog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, "_cog");
			ReportInterface.NativeFieldInfoPtr__successContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, "_successContainer");
			ReportInterface.NativeFieldInfoPtr__errorContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, "_errorContainer");
			ReportInterface.NativeFieldInfoPtr__errorText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, "_errorText");
			ReportInterface.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, 100667274);
			ReportInterface.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, 100667275);
			ReportInterface.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, 100667276);
			ReportInterface.NativeMethodInfoPtr_UpdateInProgressDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, 100667277);
			ReportInterface.NativeMethodInfoPtr_UpdateRequirements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, 100667278);
			ReportInterface.NativeMethodInfoPtr_Submit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, 100667279);
			ReportInterface.NativeMethodInfoPtr_ResetAllInputs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, 100667280);
			ReportInterface.NativeMethodInfoPtr_TypeDropdownChanged_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, 100667281);
			ReportInterface.NativeMethodInfoPtr_AreInputsValid_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, 100667282);
			ReportInterface.NativeMethodInfoPtr_CanSubmit_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, 100667283);
			ReportInterface.NativeMethodInfoPtr_GetMetadata_Private_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, 100667284);
			ReportInterface.NativeMethodInfoPtr_GetTags_Private_Il2CppReferenceArray_1_ReportTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, 100667285);
			ReportInterface.NativeMethodInfoPtr_GetOSFamily_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, 100667286);
			ReportInterface.NativeMethodInfoPtr_GetNetworkStatus_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, 100667287);
			ReportInterface.NativeMethodInfoPtr_GetEnvironment_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, 100667288);
			ReportInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, 100667289);
			ReportInterface.NativeMethodInfoPtr__Awake_b__16_0_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, 100667290);
			ReportInterface.NativeMethodInfoPtr__Awake_b__16_1_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, 100667291);
			ReportInterface.NativeMethodInfoPtr__Awake_b__16_2_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, 100667292);
			ReportInterface.NativeMethodInfoPtr__Awake_b__16_3_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, 100667293);
			ReportInterface.NativeMethodInfoPtr__Awake_b__16_4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, 100667294);
			ReportInterface.NativeMethodInfoPtr_Method_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, 100667295);
			ReportInterface.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, 100667296);
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x000E0944 File Offset: 0x000DEB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105680, XrefRangeEnd = 105750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x000E0978 File Offset: 0x000DEB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105750, XrefRangeEnd = 105751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x000E09AC File Offset: 0x000DEBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105751, XrefRangeEnd = 105778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x000E09E0 File Offset: 0x000DEBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105778, XrefRangeEnd = 105794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInProgressDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.NativeMethodInfoPtr_UpdateInProgressDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x000E0A14 File Offset: 0x000DEC14
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 105805, RefRangeEnd = 105809, XrefRangeStart = 105794, XrefRangeEnd = 105805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRequirements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.NativeMethodInfoPtr_UpdateRequirements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x000E0A48 File Offset: 0x000DEC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105809, XrefRangeEnd = 105828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Submit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.NativeMethodInfoPtr_Submit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x000E0A7C File Offset: 0x000DEC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105828, XrefRangeEnd = 105837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAllInputs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.NativeMethodInfoPtr_ResetAllInputs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x000E0AB0 File Offset: 0x000DECB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105837, XrefRangeEnd = 105839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TypeDropdownChanged(int newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.NativeMethodInfoPtr_TypeDropdownChanged_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x000E0AF0 File Offset: 0x000DECF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105841, RefRangeEnd = 105842, XrefRangeStart = 105839, XrefRangeEnd = 105841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreInputsValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.NativeMethodInfoPtr_AreInputsValid_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x000E0B2C File Offset: 0x000DED2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 105857, RefRangeEnd = 105859, XrefRangeStart = 105842, XrefRangeEnd = 105857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.NativeMethodInfoPtr_CanSubmit_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x000E0B68 File Offset: 0x000DED68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105859, XrefRangeEnd = 105865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<string, string> GetMetadata()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.NativeMethodInfoPtr_GetMetadata_Private_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x000E0BA8 File Offset: 0x000DEDA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105865, XrefRangeEnd = 106016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<ReportTag> GetTags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.NativeMethodInfoPtr_GetTags_Private_Il2CppReferenceArray_1_ReportTag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ReportTag>>(intPtr3) : null;
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x000E0BE8 File Offset: 0x000DEDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106016, XrefRangeEnd = 106038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetOSFamily()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.NativeMethodInfoPtr_GetOSFamily_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x000E0C20 File Offset: 0x000DEE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106038, XrefRangeEnd = 106052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetNetworkStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.NativeMethodInfoPtr_GetNetworkStatus_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x000E0C58 File Offset: 0x000DEE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106052, XrefRangeEnd = 106074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetEnvironment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.NativeMethodInfoPtr_GetEnvironment_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x000E0C90 File Offset: 0x000DEE90
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReportInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x000E0CCC File Offset: 0x000DEECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__16_0(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.NativeMethodInfoPtr__Awake_b__16_0_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x000E0D10 File Offset: 0x000DEF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__16_1(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.NativeMethodInfoPtr__Awake_b__16_1_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x000E0D54 File Offset: 0x000DEF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__16_2(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.NativeMethodInfoPtr__Awake_b__16_2_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x000E0D94 File Offset: 0x000DEF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__16_3(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.NativeMethodInfoPtr__Awake_b__16_3_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x000E0DD4 File Offset: 0x000DEFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__16_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.NativeMethodInfoPtr__Awake_b__16_4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x000E0E08 File Offset: 0x000DF008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.NativeMethodInfoPtr_Method_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x000E0E30 File Offset: 0x000DF030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106074, XrefRangeEnd = 106079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x00010BEF File Offset: 0x0000EDEF
		public ReportInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06001F08 RID: 7944 RVA: 0x000E0E70 File Offset: 0x000DF070
		// (set) Token: 0x06001F09 RID: 7945 RVA: 0x00010BF8 File Offset: 0x0000EDF8
		public unsafe TMP_InputField _titleInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__titleInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__titleInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06001F0A RID: 7946 RVA: 0x000E0EA0 File Offset: 0x000DF0A0
		// (set) Token: 0x06001F0B RID: 7947 RVA: 0x00010C17 File Offset: 0x0000EE17
		public unsafe TMP_InputField _descriptionInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__descriptionInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__descriptionInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x000E0ED0 File Offset: 0x000DF0D0
		// (set) Token: 0x06001F0D RID: 7949 RVA: 0x00010C36 File Offset: 0x0000EE36
		public unsafe TMP_Dropdown _reportTypeDropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__reportTypeDropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__reportTypeDropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06001F0E RID: 7950 RVA: 0x000E0F00 File Offset: 0x000DF100
		// (set) Token: 0x06001F0F RID: 7951 RVA: 0x00010C55 File Offset: 0x0000EE55
		public unsafe Toggle _includeSaveFileToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__includeSaveFileToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__includeSaveFileToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06001F10 RID: 7952 RVA: 0x000E0F30 File Offset: 0x000DF130
		// (set) Token: 0x06001F11 RID: 7953 RVA: 0x00010C74 File Offset: 0x0000EE74
		public unsafe Toggle _includeScreenshotToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__includeScreenshotToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__includeScreenshotToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06001F12 RID: 7954 RVA: 0x000E0F60 File Offset: 0x000DF160
		// (set) Token: 0x06001F13 RID: 7955 RVA: 0x00010C93 File Offset: 0x0000EE93
		public unsafe Il2CppReferenceArray<Selectable> _selectablesToTriggerAuthPrep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__selectablesToTriggerAuthPrep);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Selectable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__selectablesToTriggerAuthPrep), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06001F14 RID: 7956 RVA: 0x000E0F90 File Offset: 0x000DF190
		// (set) Token: 0x06001F15 RID: 7957 RVA: 0x00010CB2 File Offset: 0x0000EEB2
		public unsafe TextMeshProUGUI _titleRequiredLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__titleRequiredLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__titleRequiredLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06001F16 RID: 7958 RVA: 0x000E0FC0 File Offset: 0x000DF1C0
		// (set) Token: 0x06001F17 RID: 7959 RVA: 0x00010CD1 File Offset: 0x0000EED1
		public unsafe TextMeshProUGUI _descriptionRequiredLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__descriptionRequiredLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__descriptionRequiredLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06001F18 RID: 7960 RVA: 0x000E0FF0 File Offset: 0x000DF1F0
		// (set) Token: 0x06001F19 RID: 7961 RVA: 0x00010CF0 File Offset: 0x0000EEF0
		public unsafe TextMeshProUGUI _typeRequiredLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__typeRequiredLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__typeRequiredLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06001F1A RID: 7962 RVA: 0x000E1020 File Offset: 0x000DF220
		// (set) Token: 0x06001F1B RID: 7963 RVA: 0x00010D0F File Offset: 0x0000EF0F
		public unsafe Button _submitButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__submitButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__submitButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06001F1C RID: 7964 RVA: 0x000E1050 File Offset: 0x000DF250
		// (set) Token: 0x06001F1D RID: 7965 RVA: 0x00010D2E File Offset: 0x0000EF2E
		public unsafe RectTransform _inProgressContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__inProgressContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__inProgressContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06001F1E RID: 7966 RVA: 0x000E1080 File Offset: 0x000DF280
		// (set) Token: 0x06001F1F RID: 7967 RVA: 0x00010D4D File Offset: 0x0000EF4D
		public unsafe TextMeshProUGUI _inProgressText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__inProgressText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__inProgressText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06001F20 RID: 7968 RVA: 0x000E10B0 File Offset: 0x000DF2B0
		// (set) Token: 0x06001F21 RID: 7969 RVA: 0x00010D6C File Offset: 0x0000EF6C
		public unsafe RectTransform _cog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__cog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__cog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06001F22 RID: 7970 RVA: 0x000E10E0 File Offset: 0x000DF2E0
		// (set) Token: 0x06001F23 RID: 7971 RVA: 0x00010D8B File Offset: 0x0000EF8B
		public unsafe RectTransform _successContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__successContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__successContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06001F24 RID: 7972 RVA: 0x000E1110 File Offset: 0x000DF310
		// (set) Token: 0x06001F25 RID: 7973 RVA: 0x00010DAA File Offset: 0x0000EFAA
		public unsafe RectTransform _errorContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__errorContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__errorContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06001F26 RID: 7974 RVA: 0x000E1140 File Offset: 0x000DF340
		// (set) Token: 0x06001F27 RID: 7975 RVA: 0x00010DC9 File Offset: 0x0000EFC9
		public unsafe TextMeshProUGUI _errorText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__errorText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.NativeFieldInfoPtr__errorText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001565 RID: 5477
		private static readonly IntPtr NativeFieldInfoPtr__titleInput;

		// Token: 0x04001566 RID: 5478
		private static readonly IntPtr NativeFieldInfoPtr__descriptionInput;

		// Token: 0x04001567 RID: 5479
		private static readonly IntPtr NativeFieldInfoPtr__reportTypeDropdown;

		// Token: 0x04001568 RID: 5480
		private static readonly IntPtr NativeFieldInfoPtr__includeSaveFileToggle;

		// Token: 0x04001569 RID: 5481
		private static readonly IntPtr NativeFieldInfoPtr__includeScreenshotToggle;

		// Token: 0x0400156A RID: 5482
		private static readonly IntPtr NativeFieldInfoPtr__selectablesToTriggerAuthPrep;

		// Token: 0x0400156B RID: 5483
		private static readonly IntPtr NativeFieldInfoPtr__titleRequiredLabel;

		// Token: 0x0400156C RID: 5484
		private static readonly IntPtr NativeFieldInfoPtr__descriptionRequiredLabel;

		// Token: 0x0400156D RID: 5485
		private static readonly IntPtr NativeFieldInfoPtr__typeRequiredLabel;

		// Token: 0x0400156E RID: 5486
		private static readonly IntPtr NativeFieldInfoPtr__submitButton;

		// Token: 0x0400156F RID: 5487
		private static readonly IntPtr NativeFieldInfoPtr__inProgressContainer;

		// Token: 0x04001570 RID: 5488
		private static readonly IntPtr NativeFieldInfoPtr__inProgressText;

		// Token: 0x04001571 RID: 5489
		private static readonly IntPtr NativeFieldInfoPtr__cog;

		// Token: 0x04001572 RID: 5490
		private static readonly IntPtr NativeFieldInfoPtr__successContainer;

		// Token: 0x04001573 RID: 5491
		private static readonly IntPtr NativeFieldInfoPtr__errorContainer;

		// Token: 0x04001574 RID: 5492
		private static readonly IntPtr NativeFieldInfoPtr__errorText;

		// Token: 0x04001575 RID: 5493
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001576 RID: 5494
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001577 RID: 5495
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001578 RID: 5496
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInProgressDisplay_Private_Void_0;

		// Token: 0x04001579 RID: 5497
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRequirements_Private_Void_0;

		// Token: 0x0400157A RID: 5498
		private static readonly IntPtr NativeMethodInfoPtr_Submit_Private_Void_0;

		// Token: 0x0400157B RID: 5499
		private static readonly IntPtr NativeMethodInfoPtr_ResetAllInputs_Private_Void_0;

		// Token: 0x0400157C RID: 5500
		private static readonly IntPtr NativeMethodInfoPtr_TypeDropdownChanged_Private_Void_Int32_0;

		// Token: 0x0400157D RID: 5501
		private static readonly IntPtr NativeMethodInfoPtr_AreInputsValid_Private_Boolean_0;

		// Token: 0x0400157E RID: 5502
		private static readonly IntPtr NativeMethodInfoPtr_CanSubmit_Private_Boolean_0;

		// Token: 0x0400157F RID: 5503
		private static readonly IntPtr NativeMethodInfoPtr_GetMetadata_Private_Dictionary_2_String_String_0;

		// Token: 0x04001580 RID: 5504
		private static readonly IntPtr NativeMethodInfoPtr_GetTags_Private_Il2CppReferenceArray_1_ReportTag_0;

		// Token: 0x04001581 RID: 5505
		private static readonly IntPtr NativeMethodInfoPtr_GetOSFamily_Private_String_0;

		// Token: 0x04001582 RID: 5506
		private static readonly IntPtr NativeMethodInfoPtr_GetNetworkStatus_Private_String_0;

		// Token: 0x04001583 RID: 5507
		private static readonly IntPtr NativeMethodInfoPtr_GetEnvironment_Private_String_0;

		// Token: 0x04001584 RID: 5508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001585 RID: 5509
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__16_0_Private_Void_String_0;

		// Token: 0x04001586 RID: 5510
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__16_1_Private_Void_String_0;

		// Token: 0x04001587 RID: 5511
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__16_2_Private_Void_Int32_0;

		// Token: 0x04001588 RID: 5512
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__16_3_Private_Void_Int32_0;

		// Token: 0x04001589 RID: 5513
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__16_4_Private_Void_0;

		// Token: 0x0400158A RID: 5514
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_0;

		// Token: 0x0400158B RID: 5515
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x0200095C RID: 2396
		[ObfuscatedName("ScheduleOne.Reporting.ReportInterface+<<Submit>g__Wait|21_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D8C2 RID: 55490 RVA: 0x0035D69C File Offset: 0x0035B89C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique()
			{
				Il2CppClassPointerStore<ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, "<<Submit>g__Wait|21_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr);
				ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>1__state");
				ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>2__current");
				ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>4__this");
				ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100667297);
				ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100667298);
				ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100667299);
				ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100667300);
				ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100667301);
				ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100667302);
			}

			// Token: 0x0600D8C3 RID: 55491 RVA: 0x0035D77C File Offset: 0x0035B97C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8C4 RID: 55492 RVA: 0x0035D7C4 File Offset: 0x0035B9C4
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8C5 RID: 55493 RVA: 0x0035D7F8 File Offset: 0x0035B9F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105626, XrefRangeEnd = 105638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004235 RID: 16949
			// (get) Token: 0x0600D8C6 RID: 55494 RVA: 0x0035D834 File Offset: 0x0035BA34
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D8C7 RID: 55495 RVA: 0x0035D874 File Offset: 0x0035BA74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105638, XrefRangeEnd = 105643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004236 RID: 16950
			// (get) Token: 0x0600D8C8 RID: 55496 RVA: 0x0035D8A8 File Offset: 0x0035BAA8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D8C9 RID: 55497 RVA: 0x00065EF3 File Offset: 0x000640F3
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004232 RID: 16946
			// (get) Token: 0x0600D8CA RID: 55498 RVA: 0x0035D8E8 File Offset: 0x0035BAE8
			// (set) Token: 0x0600D8CB RID: 55499 RVA: 0x00065EFC File Offset: 0x000640FC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004233 RID: 16947
			// (get) Token: 0x0600D8CC RID: 55500 RVA: 0x0035D910 File Offset: 0x0035BB10
			// (set) Token: 0x0600D8CD RID: 55501 RVA: 0x00065F17 File Offset: 0x00064117
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004234 RID: 16948
			// (get) Token: 0x0600D8CE RID: 55502 RVA: 0x0035D940 File Offset: 0x0035BB40
			// (set) Token: 0x0600D8CF RID: 55503 RVA: 0x00065F36 File Offset: 0x00064136
			public unsafe ReportInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReportInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093FF RID: 37887
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009400 RID: 37888
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009401 RID: 37889
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009402 RID: 37890
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009403 RID: 37891
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009404 RID: 37892
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009405 RID: 37893
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009406 RID: 37894
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009407 RID: 37895
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200095D RID: 2397
		[ObfuscatedName("ScheduleOne.Reporting.ReportInterface+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D8D0 RID: 55504 RVA: 0x0035D970 File Offset: 0x0035BB70
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ReportInterface.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReportInterface.__c>.NativeClassPtr);
				ReportInterface.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportInterface.__c>.NativeClassPtr, "<>9");
				ReportInterface.__c.NativeFieldInfoPtr___9__16_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportInterface.__c>.NativeClassPtr, "<>9__16_6");
				ReportInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface.__c>.NativeClassPtr, 100667304);
				ReportInterface.__c.NativeMethodInfoPtr__Awake_b__16_6_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface.__c>.NativeClassPtr, 100667305);
			}

			// Token: 0x0600D8D1 RID: 55505 RVA: 0x0035D9EC File Offset: 0x0035BBEC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReportInterface.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8D2 RID: 55506 RVA: 0x0035DA28 File Offset: 0x0035BC28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105643, XrefRangeEnd = 105653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__16_6(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.__c.NativeMethodInfoPtr__Awake_b__16_6_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8D3 RID: 55507 RVA: 0x00065F55 File Offset: 0x00064155
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004237 RID: 16951
			// (get) Token: 0x0600D8D4 RID: 55508 RVA: 0x0035DA6C File Offset: 0x0035BC6C
			// (set) Token: 0x0600D8D5 RID: 55509 RVA: 0x00065F5E File Offset: 0x0006415E
			public unsafe static ReportInterface.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReportInterface.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReportInterface.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReportInterface.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004238 RID: 16952
			// (get) Token: 0x0600D8D6 RID: 55510 RVA: 0x0035DA94 File Offset: 0x0035BC94
			// (set) Token: 0x0600D8D7 RID: 55511 RVA: 0x00065F70 File Offset: 0x00064170
			public unsafe static UnityAction<BaseEventData> __9__16_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReportInterface.__c.NativeFieldInfoPtr___9__16_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<BaseEventData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReportInterface.__c.NativeFieldInfoPtr___9__16_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009408 RID: 37896
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009409 RID: 37897
			private static readonly IntPtr NativeFieldInfoPtr___9__16_6;

			// Token: 0x0400940A RID: 37898
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400940B RID: 37899
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__16_6_Internal_Void_BaseEventData_0;
		}

		// Token: 0x0200095E RID: 2398
		[ObfuscatedName("ScheduleOne.Reporting.ReportInterface+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D8D8 RID: 55512 RVA: 0x0035DABC File Offset: 0x0035BCBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<ReportInterface.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReportInterface>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReportInterface.__c__DisplayClass21_0>.NativeClassPtr);
				ReportInterface.__c__DisplayClass21_0.NativeFieldInfoPtr_done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportInterface.__c__DisplayClass21_0>.NativeClassPtr, "done");
				ReportInterface.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportInterface.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
				ReportInterface.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface.__c__DisplayClass21_0>.NativeClassPtr, 100667306);
				ReportInterface.__c__DisplayClass21_0.NativeMethodInfoPtr__Submit_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface.__c__DisplayClass21_0>.NativeClassPtr, 100667307);
				ReportInterface.__c__DisplayClass21_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportInterface.__c__DisplayClass21_0>.NativeClassPtr, 100667308);
			}

			// Token: 0x0600D8D9 RID: 55513 RVA: 0x0035DB4C File Offset: 0x0035BD4C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReportInterface.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8DA RID: 55514 RVA: 0x0035DB88 File Offset: 0x0035BD88
			[CallerCount(0)]
			public unsafe bool _Submit_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.__c__DisplayClass21_0.NativeMethodInfoPtr__Submit_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D8DB RID: 55515 RVA: 0x0035DBC4 File Offset: 0x0035BDC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105653, XrefRangeEnd = 105680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Boolean_String_PDM_0(bool success, string message)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref success;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportInterface.__c__DisplayClass21_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_String_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8DC RID: 55516 RVA: 0x00065F82 File Offset: 0x00064182
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004239 RID: 16953
			// (get) Token: 0x0600D8DD RID: 55517 RVA: 0x0035DC14 File Offset: 0x0035BE14
			// (set) Token: 0x0600D8DE RID: 55518 RVA: 0x00065F8B File Offset: 0x0006418B
			public unsafe bool done
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.__c__DisplayClass21_0.NativeFieldInfoPtr_done);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.__c__DisplayClass21_0.NativeFieldInfoPtr_done)) = value;
				}
			}

			// Token: 0x1700423A RID: 16954
			// (get) Token: 0x0600D8DF RID: 55519 RVA: 0x0035DC3C File Offset: 0x0035BE3C
			// (set) Token: 0x0600D8E0 RID: 55520 RVA: 0x00065FA6 File Offset: 0x000641A6
			public unsafe ReportInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReportInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportInterface.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400940C RID: 37900
			private static readonly IntPtr NativeFieldInfoPtr_done;

			// Token: 0x0400940D RID: 37901
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400940E RID: 37902
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400940F RID: 37903
			private static readonly IntPtr NativeMethodInfoPtr__Submit_b__1_Internal_Boolean_0;

			// Token: 0x04009410 RID: 37904
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Boolean_String_PDM_0;
		}
	}
}
