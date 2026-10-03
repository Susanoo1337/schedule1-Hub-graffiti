using System;
using Il2Cpp;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Cartel
{
	// Token: 0x02000447 RID: 1095
	public class Cartel : NetworkSingleton<Cartel>
	{
		// Token: 0x060062D1 RID: 25297 RVA: 0x001D17FC File Offset: 0x001CF9FC
		// Note: this type is marked as 'beforefieldinit'.
		static Cartel()
		{
			Il2CppClassPointerStore<Cartel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cartel", "Cartel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cartel>.NativeClassPtr);
			Cartel.NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cartel>.NativeClassPtr, "<Status>k__BackingField");
			Cartel.NativeFieldInfoPtr__HoursSinceStatusChange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cartel>.NativeClassPtr, "<HoursSinceStatusChange>k__BackingField");
			Cartel.NativeFieldInfoPtr_Activities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cartel>.NativeClassPtr, "Activities");
			Cartel.NativeFieldInfoPtr_Influence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cartel>.NativeClassPtr, "Influence");
			Cartel.NativeFieldInfoPtr_GoonPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cartel>.NativeClassPtr, "GoonPool");
			Cartel.NativeFieldInfoPtr_DealManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cartel>.NativeClassPtr, "DealManager");
			Cartel.NativeFieldInfoPtr_OnStatusChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cartel>.NativeClassPtr, "OnStatusChange");
			Cartel.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cartel>.NativeClassPtr, "loader");
			Cartel.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cartel>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			Cartel.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cartel>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			Cartel.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cartel>.NativeClassPtr, "<HasChanged>k__BackingField");
			Cartel.NativeFieldInfoPtr__LoadOrder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cartel>.NativeClassPtr, "<LoadOrder>k__BackingField");
			Cartel.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cartel>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Cartel.CartelAssembly-CSharp.dll_Excuted");
			Cartel.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cartel>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Cartel.CartelAssembly-CSharp.dll_Excuted");
			Cartel.NativeMethodInfoPtr_get_Status_Public_get_ECartelStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676274);
			Cartel.NativeMethodInfoPtr_set_Status_Private_set_Void_ECartelStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676275);
			Cartel.NativeMethodInfoPtr_get_HoursSinceStatusChange_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676276);
			Cartel.NativeMethodInfoPtr_set_HoursSinceStatusChange_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676277);
			Cartel.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676278);
			Cartel.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676279);
			Cartel.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676280);
			Cartel.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676281);
			Cartel.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676282);
			Cartel.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676283);
			Cartel.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676284);
			Cartel.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676285);
			Cartel.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676286);
			Cartel.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676287);
			Cartel.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676288);
			Cartel.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676289);
			Cartel.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676290);
			Cartel.NativeMethodInfoPtr_HourPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676291);
			Cartel.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676292);
			Cartel.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676293);
			Cartel.NativeMethodInfoPtr_Load_Public_Void_CartelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676294);
			Cartel.NativeMethodInfoPtr_SetStatus_Server_Public_Void_ECartelStatus_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676295);
			Cartel.NativeMethodInfoPtr_SetStatus_Public_Void_NetworkConnection_ECartelStatus_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676296);
			Cartel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676297);
			Cartel.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676298);
			Cartel.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676299);
			Cartel.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676300);
			Cartel.NativeMethodInfoPtr_RpcWriter___Server_SetStatus_Server_2366206100_Private_Void_ECartelStatus_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676301);
			Cartel.NativeMethodInfoPtr_RpcLogic___SetStatus_Server_2366206100_Public_Void_ECartelStatus_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676302);
			Cartel.NativeMethodInfoPtr_RpcReader___Server_SetStatus_Server_2366206100_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676303);
			Cartel.NativeMethodInfoPtr_RpcWriter___Observers_SetStatus_3666943613_Private_Void_NetworkConnection_ECartelStatus_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676304);
			Cartel.NativeMethodInfoPtr_RpcLogic___SetStatus_3666943613_Public_Void_NetworkConnection_ECartelStatus_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676305);
			Cartel.NativeMethodInfoPtr_RpcReader___Observers_SetStatus_3666943613_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676306);
			Cartel.NativeMethodInfoPtr_RpcWriter___Target_SetStatus_3666943613_Private_Void_NetworkConnection_ECartelStatus_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676307);
			Cartel.NativeMethodInfoPtr_RpcReader___Target_SetStatus_3666943613_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676308);
			Cartel.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cartel>.NativeClassPtr, 100676309);
		}

		// Token: 0x17001E67 RID: 7783
		// (get) Token: 0x060062D2 RID: 25298 RVA: 0x001D1C14 File Offset: 0x001CFE14
		// (set) Token: 0x060062D3 RID: 25299 RVA: 0x001D1C50 File Offset: 0x001CFE50
		public unsafe ECartelStatus Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_get_Status_Public_get_ECartelStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_set_Status_Private_set_Void_ECartelStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x060062D4 RID: 25300 RVA: 0x001D1C90 File Offset: 0x001CFE90
		// (set) Token: 0x060062D5 RID: 25301 RVA: 0x001D1CCC File Offset: 0x001CFECC
		public unsafe int HoursSinceStatusChange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_get_HoursSinceStatusChange_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_set_HoursSinceStatusChange_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x060062D6 RID: 25302 RVA: 0x001D1D0C File Offset: 0x001CFF0C
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208490, XrefRangeEnd = 208492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001E6A RID: 7786
		// (get) Token: 0x060062D7 RID: 25303 RVA: 0x001D1D44 File Offset: 0x001CFF44
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208492, XrefRangeEnd = 208494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001E6B RID: 7787
		// (get) Token: 0x060062D8 RID: 25304 RVA: 0x001D1D7C File Offset: 0x001CFF7C
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17001E6C RID: 7788
		// (get) Token: 0x060062D9 RID: 25305 RVA: 0x001D1DBC File Offset: 0x001CFFBC
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(170)]
			[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001E6D RID: 7789
		// (get) Token: 0x060062DA RID: 25306 RVA: 0x001D1DF8 File Offset: 0x001CFFF8
		// (set) Token: 0x060062DB RID: 25307 RVA: 0x001D1E38 File Offset: 0x001D0038
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E6E RID: 7790
		// (get) Token: 0x060062DC RID: 25308 RVA: 0x001D1E7C File Offset: 0x001D007C
		// (set) Token: 0x060062DD RID: 25309 RVA: 0x001D1EBC File Offset: 0x001D00BC
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E6F RID: 7791
		// (get) Token: 0x060062DE RID: 25310 RVA: 0x001D1F00 File Offset: 0x001D0100
		// (set) Token: 0x060062DF RID: 25311 RVA: 0x001D1F3C File Offset: 0x001D013C
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E70 RID: 7792
		// (get) Token: 0x060062E0 RID: 25312 RVA: 0x001D1F7C File Offset: 0x001D017C
		public unsafe virtual int LoadOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060062E1 RID: 25313 RVA: 0x001D1FB8 File Offset: 0x001D01B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208494, XrefRangeEnd = 208515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cartel.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062E2 RID: 25314 RVA: 0x001D1FF4 File Offset: 0x001D01F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208515, XrefRangeEnd = 208518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cartel.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062E3 RID: 25315 RVA: 0x001D2044 File Offset: 0x001D0244
		[CallerCount(0)]
		public unsafe void HourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_HourPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062E4 RID: 25316 RVA: 0x001D2078 File Offset: 0x001D0278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208518, XrefRangeEnd = 208524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cartel.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062E5 RID: 25317 RVA: 0x001D20B4 File Offset: 0x001D02B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208524, XrefRangeEnd = 208558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cartel.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060062E6 RID: 25318 RVA: 0x001D20F8 File Offset: 0x001D02F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208599, RefRangeEnd = 208600, XrefRangeStart = 208558, XrefRangeEnd = 208599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(CartelData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_Load_Public_Void_CartelData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062E7 RID: 25319 RVA: 0x001D213C File Offset: 0x001D033C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208611, RefRangeEnd = 208612, XrefRangeStart = 208600, XrefRangeEnd = 208611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStatus_Server(ECartelStatus status, bool resetStatusChangedTimer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref status;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resetStatusChangedTimer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_SetStatus_Server_Public_Void_ECartelStatus_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062E8 RID: 25320 RVA: 0x001D2188 File Offset: 0x001D0388
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 208653, RefRangeEnd = 208662, XrefRangeStart = 208612, XrefRangeEnd = 208653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStatus(NetworkConnection conn, ECartelStatus newStatus, bool resetStatusChangeTimer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newStatus;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resetStatusChangeTimer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_SetStatus_Public_Void_NetworkConnection_ECartelStatus_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062E9 RID: 25321 RVA: 0x001D21E8 File Offset: 0x001D03E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208662, XrefRangeEnd = 208682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cartel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cartel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062EA RID: 25322 RVA: 0x001D2224 File Offset: 0x001D0424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208682, XrefRangeEnd = 208705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cartel.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062EB RID: 25323 RVA: 0x001D2260 File Offset: 0x001D0460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208705, XrefRangeEnd = 208708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cartel.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062EC RID: 25324 RVA: 0x001D229C File Offset: 0x001D049C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cartel.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062ED RID: 25325 RVA: 0x001D22D8 File Offset: 0x001D04D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208611, RefRangeEnd = 208612, XrefRangeStart = 208611, XrefRangeEnd = 208612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetStatus_Server_2366206100(ECartelStatus status, bool resetStatusChangedTimer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref status;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resetStatusChangedTimer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_RpcWriter___Server_SetStatus_Server_2366206100_Private_Void_ECartelStatus_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062EE RID: 25326 RVA: 0x001D2324 File Offset: 0x001D0524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208708, XrefRangeEnd = 208709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetStatus_Server_2366206100(ECartelStatus status, bool resetStatusChangedTimer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref status;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resetStatusChangedTimer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_RpcLogic___SetStatus_Server_2366206100_Public_Void_ECartelStatus_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062EF RID: 25327 RVA: 0x001D2370 File Offset: 0x001D0570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208709, XrefRangeEnd = 208712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetStatus_Server_2366206100(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_RpcReader___Server_SetStatus_Server_2366206100_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062F0 RID: 25328 RVA: 0x001D23D4 File Offset: 0x001D05D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208712, XrefRangeEnd = 208723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetStatus_3666943613(NetworkConnection conn, ECartelStatus newStatus, bool resetStatusChangeTimer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newStatus;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resetStatusChangeTimer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_RpcWriter___Observers_SetStatus_3666943613_Private_Void_NetworkConnection_ECartelStatus_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062F1 RID: 25329 RVA: 0x001D2434 File Offset: 0x001D0634
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 208733, RefRangeEnd = 208736, XrefRangeStart = 208723, XrefRangeEnd = 208733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetStatus_3666943613(NetworkConnection conn, ECartelStatus newStatus, bool resetStatusChangeTimer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newStatus;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resetStatusChangeTimer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_RpcLogic___SetStatus_3666943613_Public_Void_NetworkConnection_ECartelStatus_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062F2 RID: 25330 RVA: 0x001D2494 File Offset: 0x001D0694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208736, XrefRangeEnd = 208740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetStatus_3666943613(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_RpcReader___Observers_SetStatus_3666943613_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062F3 RID: 25331 RVA: 0x001D24E4 File Offset: 0x001D06E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208740, XrefRangeEnd = 208751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetStatus_3666943613(NetworkConnection conn, ECartelStatus newStatus, bool resetStatusChangeTimer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newStatus;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resetStatusChangeTimer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_RpcWriter___Target_SetStatus_3666943613_Private_Void_NetworkConnection_ECartelStatus_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062F4 RID: 25332 RVA: 0x001D2544 File Offset: 0x001D0744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208751, XrefRangeEnd = 208755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetStatus_3666943613(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cartel.NativeMethodInfoPtr_RpcReader___Target_SetStatus_3666943613_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062F5 RID: 25333 RVA: 0x001D2594 File Offset: 0x001D0794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208755, XrefRangeEnd = 208758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cartel.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062F6 RID: 25334 RVA: 0x0002EA90 File Offset: 0x0002CC90
		public Cartel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E59 RID: 7769
		// (get) Token: 0x060062F7 RID: 25335 RVA: 0x001D25D0 File Offset: 0x001D07D0
		// (set) Token: 0x060062F8 RID: 25336 RVA: 0x0002EA99 File Offset: 0x0002CC99
		public unsafe ECartelStatus _Status_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr__Status_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr__Status_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E5A RID: 7770
		// (get) Token: 0x060062F9 RID: 25337 RVA: 0x001D25F8 File Offset: 0x001D07F8
		// (set) Token: 0x060062FA RID: 25338 RVA: 0x0002EAB4 File Offset: 0x0002CCB4
		public unsafe int _HoursSinceStatusChange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr__HoursSinceStatusChange_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr__HoursSinceStatusChange_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E5B RID: 7771
		// (get) Token: 0x060062FB RID: 25339 RVA: 0x001D2620 File Offset: 0x001D0820
		// (set) Token: 0x060062FC RID: 25340 RVA: 0x0002EACF File Offset: 0x0002CCCF
		public unsafe CartelActivities Activities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr_Activities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelActivities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr_Activities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E5C RID: 7772
		// (get) Token: 0x060062FD RID: 25341 RVA: 0x001D2650 File Offset: 0x001D0850
		// (set) Token: 0x060062FE RID: 25342 RVA: 0x0002EAEE File Offset: 0x0002CCEE
		public unsafe CartelInfluence Influence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr_Influence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelInfluence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr_Influence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E5D RID: 7773
		// (get) Token: 0x060062FF RID: 25343 RVA: 0x001D2680 File Offset: 0x001D0880
		// (set) Token: 0x06006300 RID: 25344 RVA: 0x0002EB0D File Offset: 0x0002CD0D
		public unsafe GoonPool GoonPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr_GoonPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GoonPool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr_GoonPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E5E RID: 7774
		// (get) Token: 0x06006301 RID: 25345 RVA: 0x001D26B0 File Offset: 0x001D08B0
		// (set) Token: 0x06006302 RID: 25346 RVA: 0x0002EB2C File Offset: 0x0002CD2C
		public unsafe CartelDealManager DealManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr_DealManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelDealManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr_DealManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E5F RID: 7775
		// (get) Token: 0x06006303 RID: 25347 RVA: 0x001D26E0 File Offset: 0x001D08E0
		// (set) Token: 0x06006304 RID: 25348 RVA: 0x0002EB4B File Offset: 0x0002CD4B
		public unsafe Action<ECartelStatus, ECartelStatus> OnStatusChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr_OnStatusChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ECartelStatus, ECartelStatus>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr_OnStatusChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E60 RID: 7776
		// (get) Token: 0x06006305 RID: 25349 RVA: 0x001D2710 File Offset: 0x001D0910
		// (set) Token: 0x06006306 RID: 25350 RVA: 0x0002EB6A File Offset: 0x0002CD6A
		public unsafe CartelLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E61 RID: 7777
		// (get) Token: 0x06006307 RID: 25351 RVA: 0x001D2740 File Offset: 0x001D0940
		// (set) Token: 0x06006308 RID: 25352 RVA: 0x0002EB89 File Offset: 0x0002CD89
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E62 RID: 7778
		// (get) Token: 0x06006309 RID: 25353 RVA: 0x001D2770 File Offset: 0x001D0970
		// (set) Token: 0x0600630A RID: 25354 RVA: 0x0002EBA8 File Offset: 0x0002CDA8
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E63 RID: 7779
		// (get) Token: 0x0600630B RID: 25355 RVA: 0x001D27A0 File Offset: 0x001D09A0
		// (set) Token: 0x0600630C RID: 25356 RVA: 0x0002EBC7 File Offset: 0x0002CDC7
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E64 RID: 7780
		// (get) Token: 0x0600630D RID: 25357 RVA: 0x001D27C8 File Offset: 0x001D09C8
		// (set) Token: 0x0600630E RID: 25358 RVA: 0x0002EBE2 File Offset: 0x0002CDE2
		public unsafe int _LoadOrder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr__LoadOrder_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr__LoadOrder_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E65 RID: 7781
		// (get) Token: 0x0600630F RID: 25359 RVA: 0x001D27F0 File Offset: 0x001D09F0
		// (set) Token: 0x06006310 RID: 25360 RVA: 0x0002EBFD File Offset: 0x0002CDFD
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001E66 RID: 7782
		// (get) Token: 0x06006311 RID: 25361 RVA: 0x001D2818 File Offset: 0x001D0A18
		// (set) Token: 0x06006312 RID: 25362 RVA: 0x0002EC18 File Offset: 0x0002CE18
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cartel.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004417 RID: 17431
		private static readonly IntPtr NativeFieldInfoPtr__Status_k__BackingField;

		// Token: 0x04004418 RID: 17432
		private static readonly IntPtr NativeFieldInfoPtr__HoursSinceStatusChange_k__BackingField;

		// Token: 0x04004419 RID: 17433
		private static readonly IntPtr NativeFieldInfoPtr_Activities;

		// Token: 0x0400441A RID: 17434
		private static readonly IntPtr NativeFieldInfoPtr_Influence;

		// Token: 0x0400441B RID: 17435
		private static readonly IntPtr NativeFieldInfoPtr_GoonPool;

		// Token: 0x0400441C RID: 17436
		private static readonly IntPtr NativeFieldInfoPtr_DealManager;

		// Token: 0x0400441D RID: 17437
		private static readonly IntPtr NativeFieldInfoPtr_OnStatusChange;

		// Token: 0x0400441E RID: 17438
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x0400441F RID: 17439
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04004420 RID: 17440
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04004421 RID: 17441
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04004422 RID: 17442
		private static readonly IntPtr NativeFieldInfoPtr__LoadOrder_k__BackingField;

		// Token: 0x04004423 RID: 17443
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004424 RID: 17444
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004425 RID: 17445
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_ECartelStatus_0;

		// Token: 0x04004426 RID: 17446
		private static readonly IntPtr NativeMethodInfoPtr_set_Status_Private_set_Void_ECartelStatus_0;

		// Token: 0x04004427 RID: 17447
		private static readonly IntPtr NativeMethodInfoPtr_get_HoursSinceStatusChange_Public_get_Int32_0;

		// Token: 0x04004428 RID: 17448
		private static readonly IntPtr NativeMethodInfoPtr_set_HoursSinceStatusChange_Private_set_Void_Int32_0;

		// Token: 0x04004429 RID: 17449
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400442A RID: 17450
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400442B RID: 17451
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x0400442C RID: 17452
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400442D RID: 17453
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400442E RID: 17454
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400442F RID: 17455
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004430 RID: 17456
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004431 RID: 17457
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004432 RID: 17458
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04004433 RID: 17459
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04004434 RID: 17460
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004435 RID: 17461
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004436 RID: 17462
		private static readonly IntPtr NativeMethodInfoPtr_HourPass_Private_Void_0;

		// Token: 0x04004437 RID: 17463
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04004438 RID: 17464
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04004439 RID: 17465
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_CartelData_0;

		// Token: 0x0400443A RID: 17466
		private static readonly IntPtr NativeMethodInfoPtr_SetStatus_Server_Public_Void_ECartelStatus_Boolean_0;

		// Token: 0x0400443B RID: 17467
		private static readonly IntPtr NativeMethodInfoPtr_SetStatus_Public_Void_NetworkConnection_ECartelStatus_Boolean_0;

		// Token: 0x0400443C RID: 17468
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400443D RID: 17469
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400443E RID: 17470
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400443F RID: 17471
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004440 RID: 17472
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetStatus_Server_2366206100_Private_Void_ECartelStatus_Boolean_0;

		// Token: 0x04004441 RID: 17473
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetStatus_Server_2366206100_Public_Void_ECartelStatus_Boolean_0;

		// Token: 0x04004442 RID: 17474
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetStatus_Server_2366206100_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004443 RID: 17475
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetStatus_3666943613_Private_Void_NetworkConnection_ECartelStatus_Boolean_0;

		// Token: 0x04004444 RID: 17476
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetStatus_3666943613_Public_Void_NetworkConnection_ECartelStatus_Boolean_0;

		// Token: 0x04004445 RID: 17477
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetStatus_3666943613_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004446 RID: 17478
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetStatus_3666943613_Private_Void_NetworkConnection_ECartelStatus_Boolean_0;

		// Token: 0x04004447 RID: 17479
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetStatus_3666943613_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004448 RID: 17480
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
