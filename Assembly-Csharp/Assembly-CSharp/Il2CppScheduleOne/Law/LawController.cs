using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x0200031B RID: 795
	public class LawController : Singleton<LawController>
	{
		// Token: 0x06003E5C RID: 15964 RVA: 0x0014D41C File Offset: 0x0014B61C
		// Note: this type is marked as 'beforefieldinit'.
		static LawController()
		{
			Il2CppClassPointerStore<LawController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "LawController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LawController>.NativeClassPtr);
			LawController.NativeFieldInfoPtr_DAILY_INTENSITY_DRAIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "DAILY_INTENSITY_DRAIN");
			LawController.NativeFieldInfoPtr_LE_Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "LE_Intensity");
			LawController.NativeFieldInfoPtr_internalLawIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "internalLawIntensity");
			LawController.NativeFieldInfoPtr_MondaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "MondaySettings");
			LawController.NativeFieldInfoPtr_TuesdaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "TuesdaySettings");
			LawController.NativeFieldInfoPtr_WednesdaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "WednesdaySettings");
			LawController.NativeFieldInfoPtr_ThursdaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "ThursdaySettings");
			LawController.NativeFieldInfoPtr_FridaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "FridaySettings");
			LawController.NativeFieldInfoPtr_SaturdaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "SaturdaySettings");
			LawController.NativeFieldInfoPtr_SundaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "SundaySettings");
			LawController.NativeFieldInfoPtr_IntensityIncreasePerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "IntensityIncreasePerDay");
			LawController.NativeFieldInfoPtr__OverrideSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<OverrideSettings>k__BackingField");
			LawController.NativeFieldInfoPtr__OverriddenSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<OverriddenSettings>k__BackingField");
			LawController.NativeFieldInfoPtr__CurrentSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<CurrentSettings>k__BackingField");
			LawController.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "loader");
			LawController.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			LawController.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			LawController.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<HasChanged>k__BackingField");
			LawController.NativeFieldInfoPtr__LoadOrder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<LoadOrder>k__BackingField");
			LawController.NativeMethodInfoPtr_get_OverrideSettings_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671234);
			LawController.NativeMethodInfoPtr_set_OverrideSettings_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671235);
			LawController.NativeMethodInfoPtr_get_OverriddenSettings_Public_get_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671236);
			LawController.NativeMethodInfoPtr_set_OverriddenSettings_Protected_set_Void_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671237);
			LawController.NativeMethodInfoPtr_get_CurrentSettings_Public_get_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671238);
			LawController.NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671239);
			LawController.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671240);
			LawController.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671241);
			LawController.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671242);
			LawController.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671243);
			LawController.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671244);
			LawController.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671245);
			LawController.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671246);
			LawController.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671247);
			LawController.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671248);
			LawController.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671249);
			LawController.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671250);
			LawController.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671251);
			LawController.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671252);
			LawController.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671253);
			LawController.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671254);
			LawController.NativeMethodInfoPtr_OnLoadComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671255);
			LawController.NativeMethodInfoPtr_OnUncappedMinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671256);
			LawController.NativeMethodInfoPtr_DayPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671257);
			LawController.NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671258);
			LawController.NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_EDay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671259);
			LawController.NativeMethodInfoPtr_OverrideSetings_Public_Void_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671260);
			LawController.NativeMethodInfoPtr_EndOverride_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671261);
			LawController.NativeMethodInfoPtr_ChangeInternalIntensity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671262);
			LawController.NativeMethodInfoPtr_SetInternalIntensity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671263);
			LawController.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671264);
			LawController.NativeMethodInfoPtr_Load_Public_Void_LawData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671265);
			LawController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100671266);
		}

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x06003E5D RID: 15965 RVA: 0x0014D85C File Offset: 0x0014BA5C
		// (set) Token: 0x06003E5E RID: 15966 RVA: 0x0014D898 File Offset: 0x0014BA98
		public unsafe bool OverrideSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_OverrideSettings_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_OverrideSettings_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x06003E5F RID: 15967 RVA: 0x0014D8D8 File Offset: 0x0014BAD8
		// (set) Token: 0x06003E60 RID: 15968 RVA: 0x0014D918 File Offset: 0x0014BB18
		public unsafe LawActivitySettings OverriddenSettings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22015, RefRangeEnd = 22016, XrefRangeStart = 22015, XrefRangeEnd = 22016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_OverriddenSettings_Public_get_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_OverriddenSettings_Protected_set_Void_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x06003E61 RID: 15969 RVA: 0x0014D95C File Offset: 0x0014BB5C
		// (set) Token: 0x06003E62 RID: 15970 RVA: 0x0014D99C File Offset: 0x0014BB9C
		public unsafe LawActivitySettings CurrentSettings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 41608, RefRangeEnd = 41609, XrefRangeStart = 41608, XrefRangeEnd = 41609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_CurrentSettings_Public_get_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x06003E63 RID: 15971 RVA: 0x0014D9E0 File Offset: 0x0014BBE0
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152673, XrefRangeEnd = 152675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x06003E64 RID: 15972 RVA: 0x0014DA18 File Offset: 0x0014BC18
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152675, XrefRangeEnd = 152677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x06003E65 RID: 15973 RVA: 0x0014DA50 File Offset: 0x0014BC50
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x06003E66 RID: 15974 RVA: 0x0014DA90 File Offset: 0x0014BC90
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(170)]
			[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x06003E67 RID: 15975 RVA: 0x0014DACC File Offset: 0x0014BCCC
		// (set) Token: 0x06003E68 RID: 15976 RVA: 0x0014DB0C File Offset: 0x0014BD0C
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 41637, RefRangeEnd = 41647, XrefRangeStart = 41637, XrefRangeEnd = 41647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 142409, RefRangeEnd = 142410, XrefRangeStart = 142409, XrefRangeEnd = 142410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x06003E69 RID: 15977 RVA: 0x0014DB50 File Offset: 0x0014BD50
		// (set) Token: 0x06003E6A RID: 15978 RVA: 0x0014DB90 File Offset: 0x0014BD90
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 70274, RefRangeEnd = 70285, XrefRangeStart = 70274, XrefRangeEnd = 70285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152677, XrefRangeEnd = 152678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x06003E6B RID: 15979 RVA: 0x0014DBD4 File Offset: 0x0014BDD4
		// (set) Token: 0x06003E6C RID: 15980 RVA: 0x0014DC10 File Offset: 0x0014BE10
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x06003E6D RID: 15981 RVA: 0x0014DC50 File Offset: 0x0014BE50
		public unsafe virtual int LoadOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003E6E RID: 15982 RVA: 0x0014DC8C File Offset: 0x0014BE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152678, XrefRangeEnd = 152681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawController.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E6F RID: 15983 RVA: 0x0014DCC8 File Offset: 0x0014BEC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152681, XrefRangeEnd = 152687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawController.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E70 RID: 15984 RVA: 0x0014DD04 File Offset: 0x0014BF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152687, XrefRangeEnd = 152729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawController.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E71 RID: 15985 RVA: 0x0014DD40 File Offset: 0x0014BF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152729, XrefRangeEnd = 152763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawController.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E72 RID: 15986 RVA: 0x0014DD7C File Offset: 0x0014BF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152763, XrefRangeEnd = 152772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLoadComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_OnLoadComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E73 RID: 15987 RVA: 0x0014DDB0 File Offset: 0x0014BFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152772, XrefRangeEnd = 152777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_OnUncappedMinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E74 RID: 15988 RVA: 0x0014DDE4 File Offset: 0x0014BFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152777, XrefRangeEnd = 152781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_DayPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x0014DE18 File Offset: 0x0014C018
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 152782, RefRangeEnd = 152784, XrefRangeStart = 152781, XrefRangeEnd = 152782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LawActivitySettings GetSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr3) : null;
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x0014DE58 File Offset: 0x0014C058
		[CallerCount(0)]
		public unsafe LawActivitySettings GetSettings(EDay day)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref day;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_EDay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr3) : null;
		}

		// Token: 0x06003E77 RID: 15991 RVA: 0x0014DEA4 File Offset: 0x0014C0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152784, XrefRangeEnd = 152785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideSetings(LawActivitySettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_OverrideSetings_Public_Void_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E78 RID: 15992 RVA: 0x0014DEE8 File Offset: 0x0014C0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152785, XrefRangeEnd = 152786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_EndOverride_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E79 RID: 15993 RVA: 0x0014DF1C File Offset: 0x0014C11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152786, XrefRangeEnd = 152789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeInternalIntensity(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_ChangeInternalIntensity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E7A RID: 15994 RVA: 0x0014DF5C File Offset: 0x0014C15C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152792, RefRangeEnd = 152793, XrefRangeStart = 152789, XrefRangeEnd = 152792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInternalIntensity(float intensity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref intensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_SetInternalIntensity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x0014DF9C File Offset: 0x0014C19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152793, XrefRangeEnd = 152798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawController.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003E7C RID: 15996 RVA: 0x0014DFE0 File Offset: 0x0014C1E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152801, RefRangeEnd = 152802, XrefRangeStart = 152798, XrefRangeEnd = 152801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(LawData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_Load_Public_Void_LawData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E7D RID: 15997 RVA: 0x0014E024 File Offset: 0x0014C224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152802, XrefRangeEnd = 152822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LawController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LawController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E7E RID: 15998 RVA: 0x0001EFF4 File Offset: 0x0001D1F4
		public LawController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x06003E7F RID: 15999 RVA: 0x0014E060 File Offset: 0x0014C260
		// (set) Token: 0x06003E80 RID: 16000 RVA: 0x0001EFFD File Offset: 0x0001D1FD
		public unsafe static float DAILY_INTENSITY_DRAIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LawController.NativeFieldInfoPtr_DAILY_INTENSITY_DRAIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LawController.NativeFieldInfoPtr_DAILY_INTENSITY_DRAIN, (void*)(&value));
			}
		}

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x06003E81 RID: 16001 RVA: 0x0014E07C File Offset: 0x0014C27C
		// (set) Token: 0x06003E82 RID: 16002 RVA: 0x0001F00B File Offset: 0x0001D20B
		public unsafe int LE_Intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_LE_Intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_LE_Intensity)) = value;
			}
		}

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x06003E83 RID: 16003 RVA: 0x0014E0A4 File Offset: 0x0014C2A4
		// (set) Token: 0x06003E84 RID: 16004 RVA: 0x0001F026 File Offset: 0x0001D226
		public unsafe float internalLawIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_internalLawIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_internalLawIntensity)) = value;
			}
		}

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x06003E85 RID: 16005 RVA: 0x0014E0CC File Offset: 0x0014C2CC
		// (set) Token: 0x06003E86 RID: 16006 RVA: 0x0001F041 File Offset: 0x0001D241
		public unsafe LawActivitySettings MondaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_MondaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_MondaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x06003E87 RID: 16007 RVA: 0x0014E0FC File Offset: 0x0014C2FC
		// (set) Token: 0x06003E88 RID: 16008 RVA: 0x0001F060 File Offset: 0x0001D260
		public unsafe LawActivitySettings TuesdaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_TuesdaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_TuesdaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x06003E89 RID: 16009 RVA: 0x0014E12C File Offset: 0x0014C32C
		// (set) Token: 0x06003E8A RID: 16010 RVA: 0x0001F07F File Offset: 0x0001D27F
		public unsafe LawActivitySettings WednesdaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_WednesdaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_WednesdaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x06003E8B RID: 16011 RVA: 0x0014E15C File Offset: 0x0014C35C
		// (set) Token: 0x06003E8C RID: 16012 RVA: 0x0001F09E File Offset: 0x0001D29E
		public unsafe LawActivitySettings ThursdaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_ThursdaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_ThursdaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x06003E8D RID: 16013 RVA: 0x0014E18C File Offset: 0x0014C38C
		// (set) Token: 0x06003E8E RID: 16014 RVA: 0x0001F0BD File Offset: 0x0001D2BD
		public unsafe LawActivitySettings FridaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_FridaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_FridaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x06003E8F RID: 16015 RVA: 0x0014E1BC File Offset: 0x0014C3BC
		// (set) Token: 0x06003E90 RID: 16016 RVA: 0x0001F0DC File Offset: 0x0001D2DC
		public unsafe LawActivitySettings SaturdaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_SaturdaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_SaturdaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x06003E91 RID: 16017 RVA: 0x0014E1EC File Offset: 0x0014C3EC
		// (set) Token: 0x06003E92 RID: 16018 RVA: 0x0001F0FB File Offset: 0x0001D2FB
		public unsafe LawActivitySettings SundaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_SundaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_SundaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x06003E93 RID: 16019 RVA: 0x0014E21C File Offset: 0x0014C41C
		// (set) Token: 0x06003E94 RID: 16020 RVA: 0x0001F11A File Offset: 0x0001D31A
		public unsafe float IntensityIncreasePerDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_IntensityIncreasePerDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_IntensityIncreasePerDay)) = value;
			}
		}

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x06003E95 RID: 16021 RVA: 0x0014E244 File Offset: 0x0014C444
		// (set) Token: 0x06003E96 RID: 16022 RVA: 0x0001F135 File Offset: 0x0001D335
		public unsafe bool _OverrideSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__OverrideSettings_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__OverrideSettings_k__BackingField)) = value;
			}
		}

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x06003E97 RID: 16023 RVA: 0x0014E26C File Offset: 0x0014C46C
		// (set) Token: 0x06003E98 RID: 16024 RVA: 0x0001F150 File Offset: 0x0001D350
		public unsafe LawActivitySettings _OverriddenSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__OverriddenSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__OverriddenSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x06003E99 RID: 16025 RVA: 0x0014E29C File Offset: 0x0014C49C
		// (set) Token: 0x06003E9A RID: 16026 RVA: 0x0001F16F File Offset: 0x0001D36F
		public unsafe LawActivitySettings _CurrentSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__CurrentSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__CurrentSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x06003E9B RID: 16027 RVA: 0x0014E2CC File Offset: 0x0014C4CC
		// (set) Token: 0x06003E9C RID: 16028 RVA: 0x0001F18E File Offset: 0x0001D38E
		public unsafe LawLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x06003E9D RID: 16029 RVA: 0x0014E2FC File Offset: 0x0014C4FC
		// (set) Token: 0x06003E9E RID: 16030 RVA: 0x0001F1AD File Offset: 0x0001D3AD
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x06003E9F RID: 16031 RVA: 0x0014E32C File Offset: 0x0014C52C
		// (set) Token: 0x06003EA0 RID: 16032 RVA: 0x0001F1CC File Offset: 0x0001D3CC
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x06003EA1 RID: 16033 RVA: 0x0014E35C File Offset: 0x0014C55C
		// (set) Token: 0x06003EA2 RID: 16034 RVA: 0x0001F1EB File Offset: 0x0001D3EB
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x06003EA3 RID: 16035 RVA: 0x0014E384 File Offset: 0x0014C584
		// (set) Token: 0x06003EA4 RID: 16036 RVA: 0x0001F206 File Offset: 0x0001D406
		public unsafe int _LoadOrder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__LoadOrder_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__LoadOrder_k__BackingField)) = value;
			}
		}

		// Token: 0x04002A0F RID: 10767
		private static readonly IntPtr NativeFieldInfoPtr_DAILY_INTENSITY_DRAIN;

		// Token: 0x04002A10 RID: 10768
		private static readonly IntPtr NativeFieldInfoPtr_LE_Intensity;

		// Token: 0x04002A11 RID: 10769
		private static readonly IntPtr NativeFieldInfoPtr_internalLawIntensity;

		// Token: 0x04002A12 RID: 10770
		private static readonly IntPtr NativeFieldInfoPtr_MondaySettings;

		// Token: 0x04002A13 RID: 10771
		private static readonly IntPtr NativeFieldInfoPtr_TuesdaySettings;

		// Token: 0x04002A14 RID: 10772
		private static readonly IntPtr NativeFieldInfoPtr_WednesdaySettings;

		// Token: 0x04002A15 RID: 10773
		private static readonly IntPtr NativeFieldInfoPtr_ThursdaySettings;

		// Token: 0x04002A16 RID: 10774
		private static readonly IntPtr NativeFieldInfoPtr_FridaySettings;

		// Token: 0x04002A17 RID: 10775
		private static readonly IntPtr NativeFieldInfoPtr_SaturdaySettings;

		// Token: 0x04002A18 RID: 10776
		private static readonly IntPtr NativeFieldInfoPtr_SundaySettings;

		// Token: 0x04002A19 RID: 10777
		private static readonly IntPtr NativeFieldInfoPtr_IntensityIncreasePerDay;

		// Token: 0x04002A1A RID: 10778
		private static readonly IntPtr NativeFieldInfoPtr__OverrideSettings_k__BackingField;

		// Token: 0x04002A1B RID: 10779
		private static readonly IntPtr NativeFieldInfoPtr__OverriddenSettings_k__BackingField;

		// Token: 0x04002A1C RID: 10780
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSettings_k__BackingField;

		// Token: 0x04002A1D RID: 10781
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04002A1E RID: 10782
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04002A1F RID: 10783
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04002A20 RID: 10784
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04002A21 RID: 10785
		private static readonly IntPtr NativeFieldInfoPtr__LoadOrder_k__BackingField;

		// Token: 0x04002A22 RID: 10786
		private static readonly IntPtr NativeMethodInfoPtr_get_OverrideSettings_Public_get_Boolean_0;

		// Token: 0x04002A23 RID: 10787
		private static readonly IntPtr NativeMethodInfoPtr_set_OverrideSettings_Protected_set_Void_Boolean_0;

		// Token: 0x04002A24 RID: 10788
		private static readonly IntPtr NativeMethodInfoPtr_get_OverriddenSettings_Public_get_LawActivitySettings_0;

		// Token: 0x04002A25 RID: 10789
		private static readonly IntPtr NativeMethodInfoPtr_set_OverriddenSettings_Protected_set_Void_LawActivitySettings_0;

		// Token: 0x04002A26 RID: 10790
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSettings_Public_get_LawActivitySettings_0;

		// Token: 0x04002A27 RID: 10791
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_LawActivitySettings_0;

		// Token: 0x04002A28 RID: 10792
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04002A29 RID: 10793
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04002A2A RID: 10794
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04002A2B RID: 10795
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002A2C RID: 10796
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04002A2D RID: 10797
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04002A2E RID: 10798
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04002A2F RID: 10799
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04002A30 RID: 10800
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002A31 RID: 10801
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04002A32 RID: 10802
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04002A33 RID: 10803
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002A34 RID: 10804
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04002A35 RID: 10805
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002A36 RID: 10806
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04002A37 RID: 10807
		private static readonly IntPtr NativeMethodInfoPtr_OnLoadComplete_Private_Void_0;

		// Token: 0x04002A38 RID: 10808
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Private_Void_0;

		// Token: 0x04002A39 RID: 10809
		private static readonly IntPtr NativeMethodInfoPtr_DayPass_Private_Void_0;

		// Token: 0x04002A3A RID: 10810
		private static readonly IntPtr NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_0;

		// Token: 0x04002A3B RID: 10811
		private static readonly IntPtr NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_EDay_0;

		// Token: 0x04002A3C RID: 10812
		private static readonly IntPtr NativeMethodInfoPtr_OverrideSetings_Public_Void_LawActivitySettings_0;

		// Token: 0x04002A3D RID: 10813
		private static readonly IntPtr NativeMethodInfoPtr_EndOverride_Public_Void_0;

		// Token: 0x04002A3E RID: 10814
		private static readonly IntPtr NativeMethodInfoPtr_ChangeInternalIntensity_Public_Void_Single_0;

		// Token: 0x04002A3F RID: 10815
		private static readonly IntPtr NativeMethodInfoPtr_SetInternalIntensity_Public_Void_Single_0;

		// Token: 0x04002A40 RID: 10816
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04002A41 RID: 10817
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_LawData_0;

		// Token: 0x04002A42 RID: 10818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
