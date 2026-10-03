using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.VoiceOver;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Employees
{
	// Token: 0x02000381 RID: 897
	public class EmployeeManager : NetworkSingleton<EmployeeManager>
	{
		// Token: 0x06004EE5 RID: 20197 RVA: 0x0018AC08 File Offset: 0x00188E08
		// Note: this type is marked as 'beforefieldinit'.
		static EmployeeManager()
		{
			Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Employees", "EmployeeManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr);
			EmployeeManager.NativeFieldInfoPtr_MALE_EMPLOYEE_CHANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "MALE_EMPLOYEE_CHANCE");
			EmployeeManager.NativeFieldInfoPtr_AllEmployees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "AllEmployees");
			EmployeeManager.NativeFieldInfoPtr_EmployeeQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "EmployeeQuests");
			EmployeeManager.NativeFieldInfoPtr_BotanistPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "BotanistPrefab");
			EmployeeManager.NativeFieldInfoPtr_PackagerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "PackagerPrefab");
			EmployeeManager.NativeFieldInfoPtr_ChemistPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "ChemistPrefab");
			EmployeeManager.NativeFieldInfoPtr_CleanerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "CleanerPrefab");
			EmployeeManager.NativeFieldInfoPtr_MaleAppearances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "MaleAppearances");
			EmployeeManager.NativeFieldInfoPtr_FemaleAppearances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "FemaleAppearances");
			EmployeeManager.NativeFieldInfoPtr_MaleVoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "MaleVoices");
			EmployeeManager.NativeFieldInfoPtr_FemaleVoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "FemaleVoices");
			EmployeeManager.NativeFieldInfoPtr_MaleFirstNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "MaleFirstNames");
			EmployeeManager.NativeFieldInfoPtr_FemaleFirstNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "FemaleFirstNames");
			EmployeeManager.NativeFieldInfoPtr_LastNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "LastNames");
			EmployeeManager.NativeFieldInfoPtr_takenNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "takenNames");
			EmployeeManager.NativeFieldInfoPtr_takenMaleAppearances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "takenMaleAppearances");
			EmployeeManager.NativeFieldInfoPtr_takenFemaleAppearances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "takenFemaleAppearances");
			EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Employees.EmployeeManagerAssembly-CSharp.dll_Excuted");
			EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Employees.EmployeeManagerAssembly-CSharp.dll_Excuted");
			EmployeeManager.NativeMethodInfoPtr_CreateNewEmployee_Public_Void_Property_EEmployeeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100673562);
			EmployeeManager.NativeMethodInfoPtr_CreateEmployee_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100673563);
			EmployeeManager.NativeMethodInfoPtr_CreateEmployee_Server_Public_Employee_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100673564);
			EmployeeManager.NativeMethodInfoPtr_IsPositionValid_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100673565);
			EmployeeManager.NativeMethodInfoPtr_IsRotationValid_Private_Boolean_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100673566);
			EmployeeManager.NativeMethodInfoPtr_IsFloatValid_Private_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100673567);
			EmployeeManager.NativeMethodInfoPtr_RegisterName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100673568);
			EmployeeManager.NativeMethodInfoPtr_RegisterAppearance_Public_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100673569);
			EmployeeManager.NativeMethodInfoPtr_GenerateRandomName_Public_Void_Boolean_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100673570);
			EmployeeManager.NativeMethodInfoPtr_GetAppearance_Public_EmployeeAppearance_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100673571);
			EmployeeManager.NativeMethodInfoPtr_GetVoice_Public_VODatabase_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100673572);
			EmployeeManager.NativeMethodInfoPtr_GetRandomAppearance_Public_Void_Boolean_byref_Int32_byref_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100673573);
			EmployeeManager.NativeMethodInfoPtr_GetEmployeePrefab_Public_Employee_EEmployeeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100673574);
			EmployeeManager.NativeMethodInfoPtr_GetEmployeesByType_Public_List_1_Employee_EEmployeeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100673575);
			EmployeeManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100673576);
			EmployeeManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100673577);
			EmployeeManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100673578);
			EmployeeManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100673579);
			EmployeeManager.NativeMethodInfoPtr_RpcWriter___Server_CreateEmployee_311954683_Private_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100673580);
			EmployeeManager.NativeMethodInfoPtr_RpcLogic___CreateEmployee_311954683_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100673581);
			EmployeeManager.NativeMethodInfoPtr_RpcReader___Server_CreateEmployee_311954683_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100673582);
			EmployeeManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100673583);
		}

		// Token: 0x06004EE6 RID: 20198 RVA: 0x0018AF6C File Offset: 0x0018916C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177779, RefRangeEnd = 177780, XrefRangeStart = 177730, XrefRangeEnd = 177779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateNewEmployee(Property property, EEmployeeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_CreateNewEmployee_Public_Void_Property_EEmployeeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EE7 RID: 20199 RVA: 0x0018AFBC File Offset: 0x001891BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177780, XrefRangeEnd = 177781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateEmployee(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_CreateEmployee_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EE8 RID: 20200 RVA: 0x0018B094 File Offset: 0x00189294
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 177840, RefRangeEnd = 177843, XrefRangeStart = 177781, XrefRangeEnd = 177840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Employee CreateEmployee_Server(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_CreateEmployee_Server_Public_Employee_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr3) : null;
		}

		// Token: 0x06004EE9 RID: 20201 RVA: 0x0018B178 File Offset: 0x00189378
		[CallerCount(0)]
		public unsafe bool IsPositionValid(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_IsPositionValid_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004EEA RID: 20202 RVA: 0x0018B1C4 File Offset: 0x001893C4
		[CallerCount(0)]
		public unsafe bool IsRotationValid(Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_IsRotationValid_Private_Boolean_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004EEB RID: 20203 RVA: 0x0018B210 File Offset: 0x00189410
		[CallerCount(0)]
		public unsafe bool IsFloatValid(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_IsFloatValid_Private_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004EEC RID: 20204 RVA: 0x0018B25C File Offset: 0x0018945C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177843, XrefRangeEnd = 177849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_RegisterName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EED RID: 20205 RVA: 0x0018B2A0 File Offset: 0x001894A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177849, XrefRangeEnd = 177852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterAppearance(bool male, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref male;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_RegisterAppearance_Public_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EEE RID: 20206 RVA: 0x0018B2EC File Offset: 0x001894EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177863, RefRangeEnd = 177864, XrefRangeStart = 177852, XrefRangeEnd = 177863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateRandomName(bool male, out string firstName, out string lastName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref male;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GenerateRandomName_Public_Void_Boolean_byref_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			firstName = IL2CPP.Il2CppStringToManaged(intPtr);
			lastName = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06004EEF RID: 20207 RVA: 0x0018B360 File Offset: 0x00189560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177864, XrefRangeEnd = 177869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmployeeManager.EmployeeAppearance GetAppearance(bool male, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref male;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GetAppearance_Public_EmployeeAppearance_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EmployeeManager.EmployeeAppearance>(intPtr3) : null;
		}

		// Token: 0x06004EF0 RID: 20208 RVA: 0x0018B3BC File Offset: 0x001895BC
		[CallerCount(0)]
		public unsafe VODatabase GetVoice(bool male, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref male;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GetVoice_Public_VODatabase_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VODatabase>(intPtr3) : null;
		}

		// Token: 0x06004EF1 RID: 20209 RVA: 0x0018B418 File Offset: 0x00189618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177869, XrefRangeEnd = 177882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetRandomAppearance(bool male, out int index, out AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref male;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GetRandomAppearance_Public_Void_Boolean_byref_Int32_byref_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			settings = ((intPtr4 == 0) ? null : new AvatarSettings(intPtr4));
		}

		// Token: 0x06004EF2 RID: 20210 RVA: 0x0018B488 File Offset: 0x00189688
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 177892, RefRangeEnd = 177895, XrefRangeStart = 177882, XrefRangeEnd = 177892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Employee GetEmployeePrefab(EEmployeeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GetEmployeePrefab_Public_Employee_EEmployeeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr3) : null;
		}

		// Token: 0x06004EF3 RID: 20211 RVA: 0x0018B4D4 File Offset: 0x001896D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 177918, RefRangeEnd = 177922, XrefRangeStart = 177895, XrefRangeEnd = 177918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Employee> GetEmployeesByType(EEmployeeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GetEmployeesByType_Public_List_1_Employee_EEmployeeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr3) : null;
		}

		// Token: 0x06004EF4 RID: 20212 RVA: 0x0018B520 File Offset: 0x00189720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177922, XrefRangeEnd = 177951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmployeeManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EF5 RID: 20213 RVA: 0x0018B55C File Offset: 0x0018975C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177951, XrefRangeEnd = 177961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmployeeManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EF6 RID: 20214 RVA: 0x0018B598 File Offset: 0x00189798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177961, XrefRangeEnd = 177964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmployeeManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EF7 RID: 20215 RVA: 0x0018B5D4 File Offset: 0x001897D4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmployeeManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EF8 RID: 20216 RVA: 0x0018B610 File Offset: 0x00189810
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177997, RefRangeEnd = 177999, XrefRangeStart = 177964, XrefRangeEnd = 177997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_CreateEmployee_311954683(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_RpcWriter___Server_CreateEmployee_311954683_Private_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EF9 RID: 20217 RVA: 0x0018B6E8 File Offset: 0x001898E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177999, XrefRangeEnd = 178000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateEmployee_311954683(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_RpcLogic___CreateEmployee_311954683_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EFA RID: 20218 RVA: 0x0018B7C0 File Offset: 0x001899C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178000, XrefRangeEnd = 178015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_CreateEmployee_311954683(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_RpcReader___Server_CreateEmployee_311954683_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EFB RID: 20219 RVA: 0x0018B824 File Offset: 0x00189A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178015, XrefRangeEnd = 178018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmployeeManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EFC RID: 20220 RVA: 0x00025A8A File Offset: 0x00023C8A
		public EmployeeManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001893 RID: 6291
		// (get) Token: 0x06004EFD RID: 20221 RVA: 0x0018B860 File Offset: 0x00189A60
		// (set) Token: 0x06004EFE RID: 20222 RVA: 0x00025A93 File Offset: 0x00023C93
		public unsafe static float MALE_EMPLOYEE_CHANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EmployeeManager.NativeFieldInfoPtr_MALE_EMPLOYEE_CHANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EmployeeManager.NativeFieldInfoPtr_MALE_EMPLOYEE_CHANCE, (void*)(&value));
			}
		}

		// Token: 0x17001894 RID: 6292
		// (get) Token: 0x06004EFF RID: 20223 RVA: 0x0018B87C File Offset: 0x00189A7C
		// (set) Token: 0x06004F00 RID: 20224 RVA: 0x00025AA1 File Offset: 0x00023CA1
		public unsafe List<Employee> AllEmployees
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_AllEmployees);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_AllEmployees), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001895 RID: 6293
		// (get) Token: 0x06004F01 RID: 20225 RVA: 0x0018B8AC File Offset: 0x00189AAC
		// (set) Token: 0x06004F02 RID: 20226 RVA: 0x00025AC0 File Offset: 0x00023CC0
		public unsafe Il2CppReferenceArray<Quest_Employees> EmployeeQuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_EmployeeQuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Quest_Employees>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_EmployeeQuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001896 RID: 6294
		// (get) Token: 0x06004F03 RID: 20227 RVA: 0x0018B8DC File Offset: 0x00189ADC
		// (set) Token: 0x06004F04 RID: 20228 RVA: 0x00025ADF File Offset: 0x00023CDF
		public unsafe Botanist BotanistPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_BotanistPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_BotanistPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x06004F05 RID: 20229 RVA: 0x0018B90C File Offset: 0x00189B0C
		// (set) Token: 0x06004F06 RID: 20230 RVA: 0x00025AFE File Offset: 0x00023CFE
		public unsafe Packager PackagerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_PackagerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Packager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_PackagerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001898 RID: 6296
		// (get) Token: 0x06004F07 RID: 20231 RVA: 0x0018B93C File Offset: 0x00189B3C
		// (set) Token: 0x06004F08 RID: 20232 RVA: 0x00025B1D File Offset: 0x00023D1D
		public unsafe Chemist ChemistPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_ChemistPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_ChemistPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x06004F09 RID: 20233 RVA: 0x0018B96C File Offset: 0x00189B6C
		// (set) Token: 0x06004F0A RID: 20234 RVA: 0x00025B3C File Offset: 0x00023D3C
		public unsafe Cleaner CleanerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_CleanerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_CleanerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x06004F0B RID: 20235 RVA: 0x0018B99C File Offset: 0x00189B9C
		// (set) Token: 0x06004F0C RID: 20236 RVA: 0x00025B5B File Offset: 0x00023D5B
		public unsafe List<EmployeeManager.EmployeeAppearance> MaleAppearances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleAppearances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EmployeeManager.EmployeeAppearance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleAppearances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700189B RID: 6299
		// (get) Token: 0x06004F0D RID: 20237 RVA: 0x0018B9CC File Offset: 0x00189BCC
		// (set) Token: 0x06004F0E RID: 20238 RVA: 0x00025B7A File Offset: 0x00023D7A
		public unsafe List<EmployeeManager.EmployeeAppearance> FemaleAppearances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleAppearances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EmployeeManager.EmployeeAppearance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleAppearances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700189C RID: 6300
		// (get) Token: 0x06004F0F RID: 20239 RVA: 0x0018B9FC File Offset: 0x00189BFC
		// (set) Token: 0x06004F10 RID: 20240 RVA: 0x00025B99 File Offset: 0x00023D99
		public unsafe Il2CppReferenceArray<VODatabase> MaleVoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleVoices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VODatabase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleVoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700189D RID: 6301
		// (get) Token: 0x06004F11 RID: 20241 RVA: 0x0018BA2C File Offset: 0x00189C2C
		// (set) Token: 0x06004F12 RID: 20242 RVA: 0x00025BB8 File Offset: 0x00023DB8
		public unsafe Il2CppReferenceArray<VODatabase> FemaleVoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleVoices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VODatabase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleVoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700189E RID: 6302
		// (get) Token: 0x06004F13 RID: 20243 RVA: 0x0018BA5C File Offset: 0x00189C5C
		// (set) Token: 0x06004F14 RID: 20244 RVA: 0x00025BD7 File Offset: 0x00023DD7
		public unsafe Il2CppStringArray MaleFirstNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleFirstNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleFirstNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700189F RID: 6303
		// (get) Token: 0x06004F15 RID: 20245 RVA: 0x0018BA8C File Offset: 0x00189C8C
		// (set) Token: 0x06004F16 RID: 20246 RVA: 0x00025BF6 File Offset: 0x00023DF6
		public unsafe Il2CppStringArray FemaleFirstNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleFirstNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleFirstNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018A0 RID: 6304
		// (get) Token: 0x06004F17 RID: 20247 RVA: 0x0018BABC File Offset: 0x00189CBC
		// (set) Token: 0x06004F18 RID: 20248 RVA: 0x00025C15 File Offset: 0x00023E15
		public unsafe Il2CppStringArray LastNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_LastNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_LastNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x06004F19 RID: 20249 RVA: 0x0018BAEC File Offset: 0x00189CEC
		// (set) Token: 0x06004F1A RID: 20250 RVA: 0x00025C34 File Offset: 0x00023E34
		public unsafe List<string> takenNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x06004F1B RID: 20251 RVA: 0x0018BB1C File Offset: 0x00189D1C
		// (set) Token: 0x06004F1C RID: 20252 RVA: 0x00025C53 File Offset: 0x00023E53
		public unsafe List<int> takenMaleAppearances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenMaleAppearances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenMaleAppearances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018A3 RID: 6307
		// (get) Token: 0x06004F1D RID: 20253 RVA: 0x0018BB4C File Offset: 0x00189D4C
		// (set) Token: 0x06004F1E RID: 20254 RVA: 0x00025C72 File Offset: 0x00023E72
		public unsafe List<int> takenFemaleAppearances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenFemaleAppearances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenFemaleAppearances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x06004F1F RID: 20255 RVA: 0x0018BB7C File Offset: 0x00189D7C
		// (set) Token: 0x06004F20 RID: 20256 RVA: 0x00025C91 File Offset: 0x00023E91
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x06004F21 RID: 20257 RVA: 0x0018BBA4 File Offset: 0x00189DA4
		// (set) Token: 0x06004F22 RID: 20258 RVA: 0x00025CAC File Offset: 0x00023EAC
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400361D RID: 13853
		private static readonly IntPtr NativeFieldInfoPtr_MALE_EMPLOYEE_CHANCE;

		// Token: 0x0400361E RID: 13854
		private static readonly IntPtr NativeFieldInfoPtr_AllEmployees;

		// Token: 0x0400361F RID: 13855
		private static readonly IntPtr NativeFieldInfoPtr_EmployeeQuests;

		// Token: 0x04003620 RID: 13856
		private static readonly IntPtr NativeFieldInfoPtr_BotanistPrefab;

		// Token: 0x04003621 RID: 13857
		private static readonly IntPtr NativeFieldInfoPtr_PackagerPrefab;

		// Token: 0x04003622 RID: 13858
		private static readonly IntPtr NativeFieldInfoPtr_ChemistPrefab;

		// Token: 0x04003623 RID: 13859
		private static readonly IntPtr NativeFieldInfoPtr_CleanerPrefab;

		// Token: 0x04003624 RID: 13860
		private static readonly IntPtr NativeFieldInfoPtr_MaleAppearances;

		// Token: 0x04003625 RID: 13861
		private static readonly IntPtr NativeFieldInfoPtr_FemaleAppearances;

		// Token: 0x04003626 RID: 13862
		private static readonly IntPtr NativeFieldInfoPtr_MaleVoices;

		// Token: 0x04003627 RID: 13863
		private static readonly IntPtr NativeFieldInfoPtr_FemaleVoices;

		// Token: 0x04003628 RID: 13864
		private static readonly IntPtr NativeFieldInfoPtr_MaleFirstNames;

		// Token: 0x04003629 RID: 13865
		private static readonly IntPtr NativeFieldInfoPtr_FemaleFirstNames;

		// Token: 0x0400362A RID: 13866
		private static readonly IntPtr NativeFieldInfoPtr_LastNames;

		// Token: 0x0400362B RID: 13867
		private static readonly IntPtr NativeFieldInfoPtr_takenNames;

		// Token: 0x0400362C RID: 13868
		private static readonly IntPtr NativeFieldInfoPtr_takenMaleAppearances;

		// Token: 0x0400362D RID: 13869
		private static readonly IntPtr NativeFieldInfoPtr_takenFemaleAppearances;

		// Token: 0x0400362E RID: 13870
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400362F RID: 13871
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003630 RID: 13872
		private static readonly IntPtr NativeMethodInfoPtr_CreateNewEmployee_Public_Void_Property_EEmployeeType_0;

		// Token: 0x04003631 RID: 13873
		private static readonly IntPtr NativeMethodInfoPtr_CreateEmployee_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0;

		// Token: 0x04003632 RID: 13874
		private static readonly IntPtr NativeMethodInfoPtr_CreateEmployee_Server_Public_Employee_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0;

		// Token: 0x04003633 RID: 13875
		private static readonly IntPtr NativeMethodInfoPtr_IsPositionValid_Private_Boolean_Vector3_0;

		// Token: 0x04003634 RID: 13876
		private static readonly IntPtr NativeMethodInfoPtr_IsRotationValid_Private_Boolean_Quaternion_0;

		// Token: 0x04003635 RID: 13877
		private static readonly IntPtr NativeMethodInfoPtr_IsFloatValid_Private_Boolean_Single_0;

		// Token: 0x04003636 RID: 13878
		private static readonly IntPtr NativeMethodInfoPtr_RegisterName_Public_Void_String_0;

		// Token: 0x04003637 RID: 13879
		private static readonly IntPtr NativeMethodInfoPtr_RegisterAppearance_Public_Void_Boolean_Int32_0;

		// Token: 0x04003638 RID: 13880
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRandomName_Public_Void_Boolean_byref_String_byref_String_0;

		// Token: 0x04003639 RID: 13881
		private static readonly IntPtr NativeMethodInfoPtr_GetAppearance_Public_EmployeeAppearance_Boolean_Int32_0;

		// Token: 0x0400363A RID: 13882
		private static readonly IntPtr NativeMethodInfoPtr_GetVoice_Public_VODatabase_Boolean_Int32_0;

		// Token: 0x0400363B RID: 13883
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomAppearance_Public_Void_Boolean_byref_Int32_byref_AvatarSettings_0;

		// Token: 0x0400363C RID: 13884
		private static readonly IntPtr NativeMethodInfoPtr_GetEmployeePrefab_Public_Employee_EEmployeeType_0;

		// Token: 0x0400363D RID: 13885
		private static readonly IntPtr NativeMethodInfoPtr_GetEmployeesByType_Public_List_1_Employee_EEmployeeType_0;

		// Token: 0x0400363E RID: 13886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400363F RID: 13887
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003640 RID: 13888
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003641 RID: 13889
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003642 RID: 13890
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_CreateEmployee_311954683_Private_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0;

		// Token: 0x04003643 RID: 13891
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateEmployee_311954683_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0;

		// Token: 0x04003644 RID: 13892
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_CreateEmployee_311954683_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003645 RID: 13893
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A8A RID: 2698
		[Serializable]
		public class EmployeeAppearance : Il2CppSystem.Object
		{
			// Token: 0x0600E1DF RID: 57823 RVA: 0x0037702C File Offset: 0x0037522C
			// Note: this type is marked as 'beforefieldinit'.
			static EmployeeAppearance()
			{
				Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "EmployeeAppearance");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr);
				EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr, "Settings");
				EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Mugshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr, "Mugshot");
				EmployeeManager.EmployeeAppearance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr, 100673584);
			}

			// Token: 0x0600E1E0 RID: 57824 RVA: 0x00377094 File Offset: 0x00375294
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EmployeeAppearance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.EmployeeAppearance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E1E1 RID: 57825 RVA: 0x0006A711 File Offset: 0x00068911
			public EmployeeAppearance(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044BD RID: 17597
			// (get) Token: 0x0600E1E2 RID: 57826 RVA: 0x003770D0 File Offset: 0x003752D0
			// (set) Token: 0x0600E1E3 RID: 57827 RVA: 0x0006A71A File Offset: 0x0006891A
			public unsafe AvatarSettings Settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044BE RID: 17598
			// (get) Token: 0x0600E1E4 RID: 57828 RVA: 0x00377100 File Offset: 0x00375300
			// (set) Token: 0x0600E1E5 RID: 57829 RVA: 0x0006A739 File Offset: 0x00068939
			public unsafe Sprite Mugshot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Mugshot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Mugshot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099BB RID: 39355
			private static readonly IntPtr NativeFieldInfoPtr_Settings;

			// Token: 0x040099BC RID: 39356
			private static readonly IntPtr NativeFieldInfoPtr_Mugshot;

			// Token: 0x040099BD RID: 39357
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A8B RID: 2699
		[ObfuscatedName("ScheduleOne.Employees.EmployeeManager+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E1E6 RID: 57830 RVA: 0x00377130 File Offset: 0x00375330
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr);
				EmployeeManager.__c__DisplayClass20_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr, "type");
				EmployeeManager.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr, 100673585);
				EmployeeManager.__c__DisplayClass20_0.NativeMethodInfoPtr__CreateEmployee_Server_b__0_Internal_Boolean_Quest_Employees_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr, 100673586);
			}

			// Token: 0x0600E1E7 RID: 57831 RVA: 0x00377198 File Offset: 0x00375398
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E1E8 RID: 57832 RVA: 0x003771D4 File Offset: 0x003753D4
			[CallerCount(0)]
			public unsafe bool _CreateEmployee_Server_b__0(Quest_Employees x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.__c__DisplayClass20_0.NativeMethodInfoPtr__CreateEmployee_Server_b__0_Internal_Boolean_Quest_Employees_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E1E9 RID: 57833 RVA: 0x0006A758 File Offset: 0x00068958
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044BF RID: 17599
			// (get) Token: 0x0600E1EA RID: 57834 RVA: 0x00377224 File Offset: 0x00375424
			// (set) Token: 0x0600E1EB RID: 57835 RVA: 0x0006A761 File Offset: 0x00068961
			public unsafe EEmployeeType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.__c__DisplayClass20_0.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.__c__DisplayClass20_0.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x040099BE RID: 39358
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x040099BF RID: 39359
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040099C0 RID: 39360
			private static readonly IntPtr NativeMethodInfoPtr__CreateEmployee_Server_b__0_Internal_Boolean_Quest_Employees_0;
		}
	}
}
