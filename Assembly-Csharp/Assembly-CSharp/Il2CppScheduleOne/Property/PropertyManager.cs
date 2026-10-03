using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x0200016A RID: 362
	public class PropertyManager : Singleton<PropertyManager>
	{
		// Token: 0x06002447 RID: 9287 RVA: 0x000F3144 File Offset: 0x000F1344
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyManager()
		{
			Il2CppClassPointerStore<PropertyManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "PropertyManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr);
			PropertyManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, "loader");
			PropertyManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			PropertyManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			PropertyManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			PropertyManager.NativeFieldInfoPtr__LoadOrder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, "<LoadOrder>k__BackingField");
			PropertyManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100667988);
			PropertyManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100667989);
			PropertyManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100667990);
			PropertyManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100667991);
			PropertyManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100667992);
			PropertyManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100667993);
			PropertyManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100667994);
			PropertyManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100667995);
			PropertyManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100667996);
			PropertyManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100667997);
			PropertyManager.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100667998);
			PropertyManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100667999);
			PropertyManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100668000);
			PropertyManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100668001);
			PropertyManager.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100668002);
			PropertyManager.NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100668003);
			PropertyManager.NativeMethodInfoPtr_LoadProperty_Public_Void_PropertyData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100668004);
			PropertyManager.NativeMethodInfoPtr_GetProperty_Public_Property_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100668005);
			PropertyManager.NativeMethodInfoPtr_GetNearestProperty_Public_Property_Vector3_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100668006);
			PropertyManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100668007);
			PropertyManager.NativeMethodInfoPtr_Method_Internal_Static_Property_Property_Single_Property_byref_Single_byref___c__DisplayClass31_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100668008);
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06002448 RID: 9288 RVA: 0x000F337C File Offset: 0x000F157C
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114113, XrefRangeEnd = 114115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x06002449 RID: 9289 RVA: 0x000F33B4 File Offset: 0x000F15B4
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114115, XrefRangeEnd = 114117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x0600244A RID: 9290 RVA: 0x000F33EC File Offset: 0x000F15EC
		public unsafe virtual Loader Loader
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x0600244B RID: 9291 RVA: 0x000F342C File Offset: 0x000F162C
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x0600244C RID: 9292 RVA: 0x000F3468 File Offset: 0x000F1668
		// (set) Token: 0x0600244D RID: 9293 RVA: 0x000F34A8 File Offset: 0x000F16A8
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 2978, RefRangeEnd = 2980, XrefRangeStart = 2978, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x0600244E RID: 9294 RVA: 0x000F34EC File Offset: 0x000F16EC
		// (set) Token: 0x0600244F RID: 9295 RVA: 0x000F352C File Offset: 0x000F172C
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 2980, RefRangeEnd = 2987, XrefRangeStart = 2980, XrefRangeEnd = 2987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06002450 RID: 9296 RVA: 0x000F3570 File Offset: 0x000F1770
		// (set) Token: 0x06002451 RID: 9297 RVA: 0x000F35AC File Offset: 0x000F17AC
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06002452 RID: 9298 RVA: 0x000F35EC File Offset: 0x000F17EC
		public unsafe virtual int LoadOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x000F3628 File Offset: 0x000F1828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114117, XrefRangeEnd = 114120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x000F3664 File Offset: 0x000F1864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114120, XrefRangeEnd = 114126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x000F36A0 File Offset: 0x000F18A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114126, XrefRangeEnd = 114128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x000F36E4 File Offset: 0x000F18E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114128, XrefRangeEnd = 114229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyManager.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x000F3740 File Offset: 0x000F1940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114229, XrefRangeEnd = 114239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeleteUnapprovedFiles(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyManager.NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002458 RID: 9304 RVA: 0x000F3790 File Offset: 0x000F1990
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114290, RefRangeEnd = 114292, XrefRangeStart = 114239, XrefRangeEnd = 114290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadProperty(PropertyData propertyData, string propertyDataString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyDataString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_LoadProperty_Public_Void_PropertyData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002459 RID: 9305 RVA: 0x000F37E4 File Offset: 0x000F19E4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 114324, RefRangeEnd = 114336, XrefRangeStart = 114292, XrefRangeEnd = 114324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Property GetProperty(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_GetProperty_Public_Property_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x000F3834 File Offset: 0x000F1A34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114384, RefRangeEnd = 114385, XrefRangeStart = 114336, XrefRangeEnd = 114384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Property GetNearestProperty(Vector3 point, bool includeOwned = true, bool includeUnowned = true, bool includeBusinesses = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeOwned;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeUnowned;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeBusinesses;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_GetNearestProperty_Public_Property_Vector3_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x000F38AC File Offset: 0x000F1AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114385, XrefRangeEnd = 114405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x000F38E8 File Offset: 0x000F1AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114405, XrefRangeEnd = 114407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Property Method_Internal_Static_Property_Property_Single_Property_byref_Single_byref___c__DisplayClass31_0_PDM_0(Property existingClosest, float existingClosestDist, Property candidate, out float dist, ref PropertyManager.__c__DisplayClass31_0 A_4)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(existingClosest);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref existingClosestDist;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(candidate);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dist;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_Method_Internal_Static_Property_Property_Single_Property_byref_Single_byref___c__DisplayClass31_0_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x00013332 File Offset: 0x00011532
		public PropertyManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x0600245E RID: 9310 RVA: 0x000F396C File Offset: 0x000F1B6C
		// (set) Token: 0x0600245F RID: 9311 RVA: 0x0001333B File Offset: 0x0001153B
		public unsafe PropertiesLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertiesLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06002460 RID: 9312 RVA: 0x000F399C File Offset: 0x000F1B9C
		// (set) Token: 0x06002461 RID: 9313 RVA: 0x0001335A File Offset: 0x0001155A
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06002462 RID: 9314 RVA: 0x000F39CC File Offset: 0x000F1BCC
		// (set) Token: 0x06002463 RID: 9315 RVA: 0x00013379 File Offset: 0x00011579
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x06002464 RID: 9316 RVA: 0x000F39FC File Offset: 0x000F1BFC
		// (set) Token: 0x06002465 RID: 9317 RVA: 0x00013398 File Offset: 0x00011598
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06002466 RID: 9318 RVA: 0x000F3A24 File Offset: 0x000F1C24
		// (set) Token: 0x06002467 RID: 9319 RVA: 0x000133B3 File Offset: 0x000115B3
		public unsafe int _LoadOrder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.NativeFieldInfoPtr__LoadOrder_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.NativeFieldInfoPtr__LoadOrder_k__BackingField)) = value;
			}
		}

		// Token: 0x0400190D RID: 6413
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x0400190E RID: 6414
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x0400190F RID: 6415
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04001910 RID: 6416
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04001911 RID: 6417
		private static readonly IntPtr NativeFieldInfoPtr__LoadOrder_k__BackingField;

		// Token: 0x04001912 RID: 6418
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001913 RID: 6419
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001914 RID: 6420
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04001915 RID: 6421
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001916 RID: 6422
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04001917 RID: 6423
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04001918 RID: 6424
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04001919 RID: 6425
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400191A RID: 6426
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400191B RID: 6427
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400191C RID: 6428
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400191D RID: 6429
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400191E RID: 6430
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x0400191F RID: 6431
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04001920 RID: 6432
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x04001921 RID: 6433
		private static readonly IntPtr NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0;

		// Token: 0x04001922 RID: 6434
		private static readonly IntPtr NativeMethodInfoPtr_LoadProperty_Public_Void_PropertyData_String_0;

		// Token: 0x04001923 RID: 6435
		private static readonly IntPtr NativeMethodInfoPtr_GetProperty_Public_Property_String_0;

		// Token: 0x04001924 RID: 6436
		private static readonly IntPtr NativeMethodInfoPtr_GetNearestProperty_Public_Property_Vector3_Boolean_Boolean_Boolean_0;

		// Token: 0x04001925 RID: 6437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001926 RID: 6438
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Property_Property_Single_Property_byref_Single_byref___c__DisplayClass31_0_PDM_0;

		// Token: 0x0200097D RID: 2429
		[ObfuscatedName("ScheduleOne.Property.PropertyManager+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D9DE RID: 55774 RVA: 0x00360AF0 File Offset: 0x0035ECF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<PropertyManager.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass29_0>.NativeClassPtr);
				PropertyManager.__c__DisplayClass29_0.NativeFieldInfoPtr_propertyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass29_0>.NativeClassPtr, "propertyData");
				PropertyManager.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass29_0>.NativeClassPtr, 100668009);
				PropertyManager.__c__DisplayClass29_0.NativeMethodInfoPtr__LoadProperty_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass29_0>.NativeClassPtr, 100668010);
				PropertyManager.__c__DisplayClass29_0.NativeMethodInfoPtr__LoadProperty_b__1_Internal_Boolean_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass29_0>.NativeClassPtr, 100668011);
			}

			// Token: 0x0600D9DF RID: 55775 RVA: 0x00360B6C File Offset: 0x0035ED6C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9E0 RID: 55776 RVA: 0x00360BA8 File Offset: 0x0035EDA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114082, XrefRangeEnd = 114086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadProperty_b__0(Property p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.__c__DisplayClass29_0.NativeMethodInfoPtr__LoadProperty_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D9E1 RID: 55777 RVA: 0x00360BF8 File Offset: 0x0035EDF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114086, XrefRangeEnd = 114090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadProperty_b__1(Business p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.__c__DisplayClass29_0.NativeMethodInfoPtr__LoadProperty_b__1_Internal_Boolean_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D9E2 RID: 55778 RVA: 0x000666BD File Offset: 0x000648BD
			public __c__DisplayClass29_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004282 RID: 17026
			// (get) Token: 0x0600D9E3 RID: 55779 RVA: 0x00360C48 File Offset: 0x0035EE48
			// (set) Token: 0x0600D9E4 RID: 55780 RVA: 0x000666C6 File Offset: 0x000648C6
			public unsafe PropertyData propertyData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.__c__DisplayClass29_0.NativeFieldInfoPtr_propertyData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.__c__DisplayClass29_0.NativeFieldInfoPtr_propertyData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040094B0 RID: 38064
			private static readonly IntPtr NativeFieldInfoPtr_propertyData;

			// Token: 0x040094B1 RID: 38065
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040094B2 RID: 38066
			private static readonly IntPtr NativeMethodInfoPtr__LoadProperty_b__0_Internal_Boolean_Property_0;

			// Token: 0x040094B3 RID: 38067
			private static readonly IntPtr NativeMethodInfoPtr__LoadProperty_b__1_Internal_Boolean_Business_0;
		}

		// Token: 0x0200097E RID: 2430
		[ObfuscatedName("ScheduleOne.Property.PropertyManager+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D9E5 RID: 55781 RVA: 0x00360C78 File Offset: 0x0035EE78
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<PropertyManager.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass30_0>.NativeClassPtr);
				PropertyManager.__c__DisplayClass30_0.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass30_0>.NativeClassPtr, "code");
				PropertyManager.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass30_0>.NativeClassPtr, 100668012);
				PropertyManager.__c__DisplayClass30_0.NativeMethodInfoPtr__GetProperty_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass30_0>.NativeClassPtr, 100668013);
				PropertyManager.__c__DisplayClass30_0.NativeMethodInfoPtr__GetProperty_b__1_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass30_0>.NativeClassPtr, 100668014);
			}

			// Token: 0x0600D9E6 RID: 55782 RVA: 0x00360CF4 File Offset: 0x0035EEF4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9E7 RID: 55783 RVA: 0x00360D30 File Offset: 0x0035EF30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114090, XrefRangeEnd = 114113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetProperty_b__0(Property p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.__c__DisplayClass30_0.NativeMethodInfoPtr__GetProperty_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D9E8 RID: 55784 RVA: 0x00360D80 File Offset: 0x0035EF80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetProperty_b__1(Property p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.__c__DisplayClass30_0.NativeMethodInfoPtr__GetProperty_b__1_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D9E9 RID: 55785 RVA: 0x000666E5 File Offset: 0x000648E5
			public __c__DisplayClass30_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004283 RID: 17027
			// (get) Token: 0x0600D9EA RID: 55786 RVA: 0x00360DD0 File Offset: 0x0035EFD0
			// (set) Token: 0x0600D9EB RID: 55787 RVA: 0x000666EE File Offset: 0x000648EE
			public unsafe string code
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.__c__DisplayClass30_0.NativeFieldInfoPtr_code);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.__c__DisplayClass30_0.NativeFieldInfoPtr_code), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040094B4 RID: 38068
			private static readonly IntPtr NativeFieldInfoPtr_code;

			// Token: 0x040094B5 RID: 38069
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040094B6 RID: 38070
			private static readonly IntPtr NativeMethodInfoPtr__GetProperty_b__0_Internal_Boolean_Property_0;

			// Token: 0x040094B7 RID: 38071
			private static readonly IntPtr NativeMethodInfoPtr__GetProperty_b__1_Internal_Boolean_Property_0;
		}

		// Token: 0x0200097F RID: 2431
		[ObfuscatedName("ScheduleOne.Property.PropertyManager+<>c__DisplayClass31_0")]
		[StructLayout(2)]
		public struct __c__DisplayClass31_0
		{
			// Token: 0x0600D9EC RID: 55788 RVA: 0x0006670D File Offset: 0x0006490D
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<PropertyManager.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass31_0>.NativeClassPtr);
				PropertyManager.__c__DisplayClass31_0.NativeFieldInfoPtr_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass31_0>.NativeClassPtr, "point");
			}

			// Token: 0x0600D9ED RID: 55789 RVA: 0x00066741 File Offset: 0x00064941
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass31_0>.NativeClassPtr, ref this));
			}

			// Token: 0x040094B8 RID: 38072
			private static readonly IntPtr NativeFieldInfoPtr_point;

			// Token: 0x040094B9 RID: 38073
			[FieldOffset(0)]
			public Vector3 point;
		}
	}
}
