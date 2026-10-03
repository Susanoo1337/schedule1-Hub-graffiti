using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x0200048E RID: 1166
	public class TrashGenerator : MonoBehaviour
	{
		// Token: 0x060068F3 RID: 26867 RVA: 0x001E628C File Offset: 0x001E448C
		// Note: this type is marked as 'beforefieldinit'.
		static TrashGenerator()
		{
			Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr);
			TrashGenerator.NativeFieldInfoPtr_TRASH_GENERATION_FRACTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "TRASH_GENERATION_FRACTION");
			TrashGenerator.NativeFieldInfoPtr_DEFAULT_TRASH_PER_M2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "DEFAULT_TRASH_PER_M2");
			TrashGenerator.NativeFieldInfoPtr_AllGenerators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "AllGenerators");
			TrashGenerator.NativeFieldInfoPtr_MaxTrashCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "MaxTrashCount");
			TrashGenerator.NativeFieldInfoPtr_TrashCountMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "TrashCountMultiplier");
			TrashGenerator.NativeFieldInfoPtr_generatedTrash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "generatedTrash");
			TrashGenerator.NativeFieldInfoPtr_GroundCheckMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "GroundCheckMask");
			TrashGenerator.NativeFieldInfoPtr_boxCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "boxCollider");
			TrashGenerator.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			TrashGenerator.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			TrashGenerator.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "<HasChanged>k__BackingField");
			TrashGenerator.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "<GUID>k__BackingField");
			TrashGenerator.NativeFieldInfoPtr_StaticGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "StaticGUID");
			TrashGenerator.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677037);
			TrashGenerator.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677038);
			TrashGenerator.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677039);
			TrashGenerator.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677040);
			TrashGenerator.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677041);
			TrashGenerator.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677042);
			TrashGenerator.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677043);
			TrashGenerator.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677044);
			TrashGenerator.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677045);
			TrashGenerator.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677046);
			TrashGenerator.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677047);
			TrashGenerator.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677048);
			TrashGenerator.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677049);
			TrashGenerator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677050);
			TrashGenerator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677051);
			TrashGenerator.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677052);
			TrashGenerator.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677053);
			TrashGenerator.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677054);
			TrashGenerator.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677055);
			TrashGenerator.NativeMethodInfoPtr_AddGeneratedTrash_Public_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677056);
			TrashGenerator.NativeMethodInfoPtr_RemoveGeneratedTrash_Public_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677057);
			TrashGenerator.NativeMethodInfoPtr_RegenerateGUID_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677058);
			TrashGenerator.NativeMethodInfoPtr_AutoCalculateTrashCount_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677059);
			TrashGenerator.NativeMethodInfoPtr_GenerateMaxTrash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677060);
			TrashGenerator.NativeMethodInfoPtr_SleepStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677061);
			TrashGenerator.NativeMethodInfoPtr_GenerateTrash_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677062);
			TrashGenerator.NativeMethodInfoPtr_ShouldSave_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677063);
			TrashGenerator.NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_TrashGeneratorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677064);
			TrashGenerator.NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677065);
			TrashGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100677066);
		}

		// Token: 0x1700201D RID: 8221
		// (get) Token: 0x060068F4 RID: 26868 RVA: 0x001E6618 File Offset: 0x001E4818
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217072, XrefRangeEnd = 217077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700201E RID: 8222
		// (get) Token: 0x060068F5 RID: 26869 RVA: 0x001E6650 File Offset: 0x001E4850
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217077, XrefRangeEnd = 217082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700201F RID: 8223
		// (get) Token: 0x060068F6 RID: 26870 RVA: 0x001E6688 File Offset: 0x001E4888
		public unsafe virtual Loader Loader
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17002020 RID: 8224
		// (get) Token: 0x060068F7 RID: 26871 RVA: 0x001E66C8 File Offset: 0x001E48C8
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(170)]
			[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002021 RID: 8225
		// (get) Token: 0x060068F8 RID: 26872 RVA: 0x001E6704 File Offset: 0x001E4904
		// (set) Token: 0x060068F9 RID: 26873 RVA: 0x001E6744 File Offset: 0x001E4944
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30474, RefRangeEnd = 30475, XrefRangeStart = 30474, XrefRangeEnd = 30475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002022 RID: 8226
		// (get) Token: 0x060068FA RID: 26874 RVA: 0x001E6788 File Offset: 0x001E4988
		// (set) Token: 0x060068FB RID: 26875 RVA: 0x001E67C8 File Offset: 0x001E49C8
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002023 RID: 8227
		// (get) Token: 0x060068FC RID: 26876 RVA: 0x001E680C File Offset: 0x001E4A0C
		// (set) Token: 0x060068FD RID: 26877 RVA: 0x001E6848 File Offset: 0x001E4A48
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002024 RID: 8228
		// (get) Token: 0x060068FE RID: 26878 RVA: 0x001E6888 File Offset: 0x001E4A88
		// (set) Token: 0x060068FF RID: 26879 RVA: 0x001E68C4 File Offset: 0x001E4AC4
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006900 RID: 26880 RVA: 0x001E6904 File Offset: 0x001E4B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217082, XrefRangeEnd = 217086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006901 RID: 26881 RVA: 0x001E6944 File Offset: 0x001E4B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217086, XrefRangeEnd = 217096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006902 RID: 26882 RVA: 0x001E6978 File Offset: 0x001E4B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217096, XrefRangeEnd = 217126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006903 RID: 26883 RVA: 0x001E69AC File Offset: 0x001E4BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217126, XrefRangeEnd = 217132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGenerator.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006904 RID: 26884 RVA: 0x001E69E8 File Offset: 0x001E4BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217132, XrefRangeEnd = 217136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006905 RID: 26885 RVA: 0x001E6A1C File Offset: 0x001E4C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217136, XrefRangeEnd = 217144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006906 RID: 26886 RVA: 0x001E6A50 File Offset: 0x001E4C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217144, XrefRangeEnd = 217160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006907 RID: 26887 RVA: 0x001E6A84 File Offset: 0x001E4C84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 217179, RefRangeEnd = 217182, XrefRangeStart = 217160, XrefRangeEnd = 217179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddGeneratedTrash(TrashItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_AddGeneratedTrash_Public_Void_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006908 RID: 26888 RVA: 0x001E6AC8 File Offset: 0x001E4CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217182, XrefRangeEnd = 217198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveGeneratedTrash(TrashItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_RemoveGeneratedTrash_Public_Void_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006909 RID: 26889 RVA: 0x001E6B0C File Offset: 0x001E4D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_RegenerateGUID_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600690A RID: 26890 RVA: 0x001E6B40 File Offset: 0x001E4D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217198, XrefRangeEnd = 217212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AutoCalculateTrashCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_AutoCalculateTrashCount_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600690B RID: 26891 RVA: 0x001E6B74 File Offset: 0x001E4D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217212, XrefRangeEnd = 217215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateMaxTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_GenerateMaxTrash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600690C RID: 26892 RVA: 0x001E6BA8 File Offset: 0x001E4DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217215, XrefRangeEnd = 217222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_SleepStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600690D RID: 26893 RVA: 0x001E6BDC File Offset: 0x001E4DDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217280, RefRangeEnd = 217282, XrefRangeStart = 217222, XrefRangeEnd = 217280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateTrash(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_GenerateTrash_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600690E RID: 26894 RVA: 0x001E6C1C File Offset: 0x001E4E1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217283, RefRangeEnd = 217284, XrefRangeStart = 217282, XrefRangeEnd = 217283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_ShouldSave_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600690F RID: 26895 RVA: 0x001E6C58 File Offset: 0x001E4E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217284, XrefRangeEnd = 217310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TrashGeneratorData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGenerator.NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_TrashGeneratorData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashGeneratorData>(intPtr3) : null;
		}

		// Token: 0x06006910 RID: 26896 RVA: 0x001E6CA4 File Offset: 0x001E4EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217310, XrefRangeEnd = 217311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006911 RID: 26897 RVA: 0x001E6CDC File Offset: 0x001E4EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217311, XrefRangeEnd = 217334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006912 RID: 26898 RVA: 0x00031638 File Offset: 0x0002F838
		public TrashGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002010 RID: 8208
		// (get) Token: 0x06006913 RID: 26899 RVA: 0x001E6D18 File Offset: 0x001E4F18
		// (set) Token: 0x06006914 RID: 26900 RVA: 0x00031641 File Offset: 0x0002F841
		public unsafe static float TRASH_GENERATION_FRACTION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashGenerator.NativeFieldInfoPtr_TRASH_GENERATION_FRACTION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashGenerator.NativeFieldInfoPtr_TRASH_GENERATION_FRACTION, (void*)(&value));
			}
		}

		// Token: 0x17002011 RID: 8209
		// (get) Token: 0x06006915 RID: 26901 RVA: 0x001E6D34 File Offset: 0x001E4F34
		// (set) Token: 0x06006916 RID: 26902 RVA: 0x0003164F File Offset: 0x0002F84F
		public unsafe static float DEFAULT_TRASH_PER_M2
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashGenerator.NativeFieldInfoPtr_DEFAULT_TRASH_PER_M2, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashGenerator.NativeFieldInfoPtr_DEFAULT_TRASH_PER_M2, (void*)(&value));
			}
		}

		// Token: 0x17002012 RID: 8210
		// (get) Token: 0x06006917 RID: 26903 RVA: 0x001E6D50 File Offset: 0x001E4F50
		// (set) Token: 0x06006918 RID: 26904 RVA: 0x0003165D File Offset: 0x0002F85D
		public unsafe static List<TrashGenerator> AllGenerators
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TrashGenerator.NativeFieldInfoPtr_AllGenerators, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrashGenerator>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashGenerator.NativeFieldInfoPtr_AllGenerators, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002013 RID: 8211
		// (get) Token: 0x06006919 RID: 26905 RVA: 0x001E6D78 File Offset: 0x001E4F78
		// (set) Token: 0x0600691A RID: 26906 RVA: 0x0003166F File Offset: 0x0002F86F
		public unsafe int MaxTrashCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_MaxTrashCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_MaxTrashCount)) = value;
			}
		}

		// Token: 0x17002014 RID: 8212
		// (get) Token: 0x0600691B RID: 26907 RVA: 0x001E6DA0 File Offset: 0x001E4FA0
		// (set) Token: 0x0600691C RID: 26908 RVA: 0x0003168A File Offset: 0x0002F88A
		public unsafe int TrashCountMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_TrashCountMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_TrashCountMultiplier)) = value;
			}
		}

		// Token: 0x17002015 RID: 8213
		// (get) Token: 0x0600691D RID: 26909 RVA: 0x001E6DC8 File Offset: 0x001E4FC8
		// (set) Token: 0x0600691E RID: 26910 RVA: 0x000316A5 File Offset: 0x0002F8A5
		public unsafe List<TrashItem> generatedTrash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_generatedTrash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrashItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_generatedTrash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002016 RID: 8214
		// (get) Token: 0x0600691F RID: 26911 RVA: 0x001E6DF8 File Offset: 0x001E4FF8
		// (set) Token: 0x06006920 RID: 26912 RVA: 0x000316C4 File Offset: 0x0002F8C4
		public unsafe LayerMask GroundCheckMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_GroundCheckMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_GroundCheckMask)) = value;
			}
		}

		// Token: 0x17002017 RID: 8215
		// (get) Token: 0x06006921 RID: 26913 RVA: 0x001E6E20 File Offset: 0x001E5020
		// (set) Token: 0x06006922 RID: 26914 RVA: 0x000316DF File Offset: 0x0002F8DF
		public unsafe BoxCollider boxCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_boxCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_boxCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002018 RID: 8216
		// (get) Token: 0x06006923 RID: 26915 RVA: 0x001E6E50 File Offset: 0x001E5050
		// (set) Token: 0x06006924 RID: 26916 RVA: 0x000316FE File Offset: 0x0002F8FE
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002019 RID: 8217
		// (get) Token: 0x06006925 RID: 26917 RVA: 0x001E6E80 File Offset: 0x001E5080
		// (set) Token: 0x06006926 RID: 26918 RVA: 0x0003171D File Offset: 0x0002F91D
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700201A RID: 8218
		// (get) Token: 0x06006927 RID: 26919 RVA: 0x001E6EB0 File Offset: 0x001E50B0
		// (set) Token: 0x06006928 RID: 26920 RVA: 0x0003173C File Offset: 0x0002F93C
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x1700201B RID: 8219
		// (get) Token: 0x06006929 RID: 26921 RVA: 0x001E6ED8 File Offset: 0x001E50D8
		// (set) Token: 0x0600692A RID: 26922 RVA: 0x00031757 File Offset: 0x0002F957
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x1700201C RID: 8220
		// (get) Token: 0x0600692B RID: 26923 RVA: 0x001E6F00 File Offset: 0x001E5100
		// (set) Token: 0x0600692C RID: 26924 RVA: 0x00031772 File Offset: 0x0002F972
		public unsafe string StaticGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_StaticGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_StaticGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400482D RID: 18477
		private static readonly IntPtr NativeFieldInfoPtr_TRASH_GENERATION_FRACTION;

		// Token: 0x0400482E RID: 18478
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_TRASH_PER_M2;

		// Token: 0x0400482F RID: 18479
		private static readonly IntPtr NativeFieldInfoPtr_AllGenerators;

		// Token: 0x04004830 RID: 18480
		private static readonly IntPtr NativeFieldInfoPtr_MaxTrashCount;

		// Token: 0x04004831 RID: 18481
		private static readonly IntPtr NativeFieldInfoPtr_TrashCountMultiplier;

		// Token: 0x04004832 RID: 18482
		private static readonly IntPtr NativeFieldInfoPtr_generatedTrash;

		// Token: 0x04004833 RID: 18483
		private static readonly IntPtr NativeFieldInfoPtr_GroundCheckMask;

		// Token: 0x04004834 RID: 18484
		private static readonly IntPtr NativeFieldInfoPtr_boxCollider;

		// Token: 0x04004835 RID: 18485
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04004836 RID: 18486
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04004837 RID: 18487
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04004838 RID: 18488
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04004839 RID: 18489
		private static readonly IntPtr NativeFieldInfoPtr_StaticGUID;

		// Token: 0x0400483A RID: 18490
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400483B RID: 18491
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400483C RID: 18492
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x0400483D RID: 18493
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400483E RID: 18494
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400483F RID: 18495
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004840 RID: 18496
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004841 RID: 18497
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004842 RID: 18498
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004843 RID: 18499
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04004844 RID: 18500
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04004845 RID: 18501
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04004846 RID: 18502
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04004847 RID: 18503
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004848 RID: 18504
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004849 RID: 18505
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x0400484A RID: 18506
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400484B RID: 18507
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400484C RID: 18508
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x0400484D RID: 18509
		private static readonly IntPtr NativeMethodInfoPtr_AddGeneratedTrash_Public_Void_TrashItem_0;

		// Token: 0x0400484E RID: 18510
		private static readonly IntPtr NativeMethodInfoPtr_RemoveGeneratedTrash_Public_Void_TrashItem_0;

		// Token: 0x0400484F RID: 18511
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateGUID_Private_Void_0;

		// Token: 0x04004850 RID: 18512
		private static readonly IntPtr NativeMethodInfoPtr_AutoCalculateTrashCount_Private_Void_0;

		// Token: 0x04004851 RID: 18513
		private static readonly IntPtr NativeMethodInfoPtr_GenerateMaxTrash_Private_Void_0;

		// Token: 0x04004852 RID: 18514
		private static readonly IntPtr NativeMethodInfoPtr_SleepStart_Private_Void_0;

		// Token: 0x04004853 RID: 18515
		private static readonly IntPtr NativeMethodInfoPtr_GenerateTrash_Private_Void_Int32_0;

		// Token: 0x04004854 RID: 18516
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Boolean_0;

		// Token: 0x04004855 RID: 18517
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_TrashGeneratorData_0;

		// Token: 0x04004856 RID: 18518
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0;

		// Token: 0x04004857 RID: 18519
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B58 RID: 2904
		[ObfuscatedName("ScheduleOne.Trash.TrashGenerator+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E7DB RID: 59355 RVA: 0x00387E60 File Offset: 0x00386060
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TrashGenerator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashGenerator.__c>.NativeClassPtr);
				TrashGenerator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator.__c>.NativeClassPtr, "<>9");
				TrashGenerator.__c.NativeFieldInfoPtr___9__48_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator.__c>.NativeClassPtr, "<>9__48_0");
				TrashGenerator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator.__c>.NativeClassPtr, 100677069);
				TrashGenerator.__c.NativeMethodInfoPtr__GetSaveData_b__48_0_Internal_String_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator.__c>.NativeClassPtr, 100677070);
			}

			// Token: 0x0600E7DC RID: 59356 RVA: 0x00387EDC File Offset: 0x003860DC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGenerator.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E7DD RID: 59357 RVA: 0x00387F18 File Offset: 0x00386118
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217071, XrefRangeEnd = 217072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetSaveData_b__48_0(TrashItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.__c.NativeMethodInfoPtr__GetSaveData_b__48_0_Internal_String_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E7DE RID: 59358 RVA: 0x0006D589 File Offset: 0x0006B789
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700465C RID: 18012
			// (get) Token: 0x0600E7DF RID: 59359 RVA: 0x00387F60 File Offset: 0x00386160
			// (set) Token: 0x0600E7E0 RID: 59360 RVA: 0x0006D592 File Offset: 0x0006B792
			public unsafe static TrashGenerator.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TrashGenerator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashGenerator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TrashGenerator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700465D RID: 18013
			// (get) Token: 0x0600E7E1 RID: 59361 RVA: 0x00387F88 File Offset: 0x00386188
			// (set) Token: 0x0600E7E2 RID: 59362 RVA: 0x0006D5A4 File Offset: 0x0006B7A4
			public unsafe static Converter<TrashItem, string> __9__48_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TrashGenerator.__c.NativeFieldInfoPtr___9__48_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Converter<TrashItem, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TrashGenerator.__c.NativeFieldInfoPtr___9__48_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009D56 RID: 40278
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009D57 RID: 40279
			private static readonly IntPtr NativeFieldInfoPtr___9__48_0;

			// Token: 0x04009D58 RID: 40280
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009D59 RID: 40281
			private static readonly IntPtr NativeMethodInfoPtr__GetSaveData_b__48_0_Internal_String_TrashItem_0;
		}
	}
}
