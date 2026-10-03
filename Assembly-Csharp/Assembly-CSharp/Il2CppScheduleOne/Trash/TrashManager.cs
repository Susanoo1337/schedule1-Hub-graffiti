using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000490 RID: 1168
	public class TrashManager : NetworkSingleton<TrashManager>
	{
		// Token: 0x06006983 RID: 27011 RVA: 0x001E807C File Offset: 0x001E627C
		// Note: this type is marked as 'beforefieldinit'.
		static TrashManager()
		{
			Il2CppClassPointerStore<TrashManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashManager>.NativeClassPtr);
			TrashManager.NativeFieldInfoPtr_TRASH_ITEM_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "TRASH_ITEM_LIMIT");
			TrashManager.NativeFieldInfoPtr_TRASH_REPLICATIONS_PER_SECOND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "TRASH_REPLICATIONS_PER_SECOND");
			TrashManager.NativeFieldInfoPtr_TrashPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "TrashPrefabs");
			TrashManager.NativeFieldInfoPtr_TrashBagPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "TrashBagPrefab");
			TrashManager.NativeFieldInfoPtr_GenerateableTrashItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "GenerateableTrashItems");
			TrashManager.NativeFieldInfoPtr_trashItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "trashItems");
			TrashManager.NativeFieldInfoPtr_TrashForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "TrashForceMultiplier");
			TrashManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "loader");
			TrashManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			TrashManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			TrashManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			TrashManager.NativeFieldInfoPtr__LoadOrder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "<LoadOrder>k__BackingField");
			TrashManager.NativeFieldInfoPtr_writtenItemFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "writtenItemFiles");
			TrashManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Trash.TrashManagerAssembly-CSharp.dll_Excuted");
			TrashManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Trash.TrashManagerAssembly-CSharp.dll_Excuted");
			TrashManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677109);
			TrashManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677110);
			TrashManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677111);
			TrashManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677112);
			TrashManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677113);
			TrashManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677114);
			TrashManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677115);
			TrashManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677116);
			TrashManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677117);
			TrashManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677118);
			TrashManager.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677119);
			TrashManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677120);
			TrashManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677121);
			TrashManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677122);
			TrashManager.NativeMethodInfoPtr_ReplicateTransformData_Public_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677123);
			TrashManager.NativeMethodInfoPtr_SendTransformData_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677124);
			TrashManager.NativeMethodInfoPtr_ReceiveTransformData_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677125);
			TrashManager.NativeMethodInfoPtr_CreateTrashItem_Public_TrashItem_String_Vector3_Quaternion_Vector3_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677126);
			TrashManager.NativeMethodInfoPtr_SendTrashItem_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677127);
			TrashManager.NativeMethodInfoPtr_CreateTrashItem_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677128);
			TrashManager.NativeMethodInfoPtr_CreateAndReturnTrashItem_Private_TrashItem_String_Vector3_Quaternion_Vector3_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677129);
			TrashManager.NativeMethodInfoPtr_CreateTrashBag_Public_TrashItem_String_Vector3_Quaternion_TrashContentData_Vector3_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677130);
			TrashManager.NativeMethodInfoPtr_SendTrashBag_Private_Void_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677131);
			TrashManager.NativeMethodInfoPtr_CreateTrashBag_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677132);
			TrashManager.NativeMethodInfoPtr_CreateAndReturnTrashBag_Private_TrashItem_String_Vector3_Quaternion_TrashContentData_Vector3_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677133);
			TrashManager.NativeMethodInfoPtr_DestroyAllTrash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677134);
			TrashManager.NativeMethodInfoPtr_DestroyTrash_Public_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677135);
			TrashManager.NativeMethodInfoPtr_SendDestroyTrash_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677136);
			TrashManager.NativeMethodInfoPtr_DestroyTrash_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677137);
			TrashManager.NativeMethodInfoPtr_GetTrashPrefab_Public_TrashItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677138);
			TrashManager.NativeMethodInfoPtr_GetRandomGeneratableTrashPrefab_Public_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677139);
			TrashManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677140);
			TrashManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677141);
			TrashManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677142);
			TrashManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677143);
			TrashManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677144);
			TrashManager.NativeMethodInfoPtr_RpcWriter___Server_SendTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677145);
			TrashManager.NativeMethodInfoPtr_RpcLogic___SendTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677146);
			TrashManager.NativeMethodInfoPtr_RpcReader___Server_SendTransformData_2990100769_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677147);
			TrashManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677148);
			TrashManager.NativeMethodInfoPtr_RpcLogic___ReceiveTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677149);
			TrashManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveTransformData_2990100769_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677150);
			TrashManager.NativeMethodInfoPtr_RpcWriter___Server_SendTrashItem_478112418_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677151);
			TrashManager.NativeMethodInfoPtr_RpcLogic___SendTrashItem_478112418_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677152);
			TrashManager.NativeMethodInfoPtr_RpcReader___Server_SendTrashItem_478112418_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677153);
			TrashManager.NativeMethodInfoPtr_RpcWriter___Observers_CreateTrashItem_2385526393_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677154);
			TrashManager.NativeMethodInfoPtr_RpcLogic___CreateTrashItem_2385526393_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677155);
			TrashManager.NativeMethodInfoPtr_RpcReader___Observers_CreateTrashItem_2385526393_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677156);
			TrashManager.NativeMethodInfoPtr_RpcWriter___Target_CreateTrashItem_2385526393_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677157);
			TrashManager.NativeMethodInfoPtr_RpcReader___Target_CreateTrashItem_2385526393_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677158);
			TrashManager.NativeMethodInfoPtr_RpcWriter___Server_SendTrashBag_3965031115_Private_Void_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677159);
			TrashManager.NativeMethodInfoPtr_RpcLogic___SendTrashBag_3965031115_Private_Void_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677160);
			TrashManager.NativeMethodInfoPtr_RpcReader___Server_SendTrashBag_3965031115_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677161);
			TrashManager.NativeMethodInfoPtr_RpcWriter___Observers_CreateTrashBag_680856992_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677162);
			TrashManager.NativeMethodInfoPtr_RpcLogic___CreateTrashBag_680856992_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677163);
			TrashManager.NativeMethodInfoPtr_RpcReader___Observers_CreateTrashBag_680856992_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677164);
			TrashManager.NativeMethodInfoPtr_RpcWriter___Target_CreateTrashBag_680856992_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677165);
			TrashManager.NativeMethodInfoPtr_RpcReader___Target_CreateTrashBag_680856992_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677166);
			TrashManager.NativeMethodInfoPtr_RpcWriter___Server_SendDestroyTrash_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677167);
			TrashManager.NativeMethodInfoPtr_RpcLogic___SendDestroyTrash_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677168);
			TrashManager.NativeMethodInfoPtr_RpcReader___Server_SendDestroyTrash_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677169);
			TrashManager.NativeMethodInfoPtr_RpcWriter___Observers_DestroyTrash_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677170);
			TrashManager.NativeMethodInfoPtr_RpcLogic___DestroyTrash_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677171);
			TrashManager.NativeMethodInfoPtr_RpcReader___Observers_DestroyTrash_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677172);
			TrashManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100677173);
		}

		// Token: 0x17002054 RID: 8276
		// (get) Token: 0x06006984 RID: 27012 RVA: 0x001E86EC File Offset: 0x001E68EC
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217768, XrefRangeEnd = 217770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002055 RID: 8277
		// (get) Token: 0x06006985 RID: 27013 RVA: 0x001E8724 File Offset: 0x001E6924
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217770, XrefRangeEnd = 217772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002056 RID: 8278
		// (get) Token: 0x06006986 RID: 27014 RVA: 0x001E875C File Offset: 0x001E695C
		public unsafe virtual Loader Loader
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 94584, RefRangeEnd = 94585, XrefRangeStart = 94584, XrefRangeEnd = 94585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17002057 RID: 8279
		// (get) Token: 0x06006987 RID: 27015 RVA: 0x001E879C File Offset: 0x001E699C
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(170)]
			[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002058 RID: 8280
		// (get) Token: 0x06006988 RID: 27016 RVA: 0x001E87D8 File Offset: 0x001E69D8
		// (set) Token: 0x06006989 RID: 27017 RVA: 0x001E8818 File Offset: 0x001E6A18
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002059 RID: 8281
		// (get) Token: 0x0600698A RID: 27018 RVA: 0x001E885C File Offset: 0x001E6A5C
		// (set) Token: 0x0600698B RID: 27019 RVA: 0x001E889C File Offset: 0x001E6A9C
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700205A RID: 8282
		// (get) Token: 0x0600698C RID: 27020 RVA: 0x001E88E0 File Offset: 0x001E6AE0
		// (set) Token: 0x0600698D RID: 27021 RVA: 0x001E891C File Offset: 0x001E6B1C
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700205B RID: 8283
		// (get) Token: 0x0600698E RID: 27022 RVA: 0x001E895C File Offset: 0x001E6B5C
		public unsafe virtual int LoadOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600698F RID: 27023 RVA: 0x001E8998 File Offset: 0x001E6B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217772, XrefRangeEnd = 217775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006990 RID: 27024 RVA: 0x001E89D4 File Offset: 0x001E6BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217775, XrefRangeEnd = 217781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006991 RID: 27025 RVA: 0x001E8A10 File Offset: 0x001E6C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217781, XrefRangeEnd = 217798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006992 RID: 27026 RVA: 0x001E8A60 File Offset: 0x001E6C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217798, XrefRangeEnd = 217810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplicateTransformData(TrashItem trash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trash);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_ReplicateTransformData_Public_Void_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006993 RID: 27027 RVA: 0x001E8AA4 File Offset: 0x001E6CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217810, XrefRangeEnd = 217811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTransformData(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_SendTransformData_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006994 RID: 27028 RVA: 0x001E8B24 File Offset: 0x001E6D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217811, XrefRangeEnd = 217812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveTransformData(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_ReceiveTransformData_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006995 RID: 27029 RVA: 0x001E8BA4 File Offset: 0x001E6DA4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 217824, RefRangeEnd = 217837, XrefRangeStart = 217812, XrefRangeEnd = 217824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashItem CreateTrashItem(string id, Vector3 posiiton, Quaternion rotation, Vector3 initialVelocity = default(Vector3), string guid = "", bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref posiiton;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_CreateTrashItem_Public_TrashItem_String_Vector3_Quaternion_Vector3_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr3) : null;
		}

		// Token: 0x06006996 RID: 27030 RVA: 0x001E8C40 File Offset: 0x001E6E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217837, XrefRangeEnd = 217838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTrashItem(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_SendTrashItem_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006997 RID: 27031 RVA: 0x001E8CE0 File Offset: 0x001E6EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217838, XrefRangeEnd = 217839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTrashItem(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_CreateTrashItem_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006998 RID: 27032 RVA: 0x001E8D94 File Offset: 0x001E6F94
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 217877, RefRangeEnd = 217882, XrefRangeStart = 217839, XrefRangeEnd = 217877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashItem CreateAndReturnTrashItem(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, string guid, bool startKinematic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_CreateAndReturnTrashItem_Private_TrashItem_String_Vector3_Quaternion_Vector3_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr3) : null;
		}

		// Token: 0x06006999 RID: 27033 RVA: 0x001E8E30 File Offset: 0x001E7030
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 217894, RefRangeEnd = 217899, XrefRangeStart = 217882, XrefRangeEnd = 217894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashItem CreateTrashBag(string id, Vector3 posiiton, Quaternion rotation, TrashContentData content, Vector3 initialVelocity = default(Vector3), string guid = "", bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref posiiton;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_CreateTrashBag_Public_TrashItem_String_Vector3_Quaternion_TrashContentData_Vector3_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr3) : null;
		}

		// Token: 0x0600699A RID: 27034 RVA: 0x001E8EE0 File Offset: 0x001E70E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217899, XrefRangeEnd = 217900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTrashBag(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_SendTrashBag_Private_Void_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600699B RID: 27035 RVA: 0x001E8F94 File Offset: 0x001E7194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217900, XrefRangeEnd = 217901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTrashBag(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_CreateTrashBag_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600699C RID: 27036 RVA: 0x001E905C File Offset: 0x001E725C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 217936, RefRangeEnd = 217940, XrefRangeStart = 217901, XrefRangeEnd = 217936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashItem CreateAndReturnTrashBag(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, string guid, bool startKinematic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_CreateAndReturnTrashBag_Private_TrashItem_String_Vector3_Quaternion_TrashContentData_Vector3_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr3) : null;
		}

		// Token: 0x0600699D RID: 27037 RVA: 0x001E910C File Offset: 0x001E730C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217956, RefRangeEnd = 217957, XrefRangeStart = 217940, XrefRangeEnd = 217956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyAllTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_DestroyAllTrash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600699E RID: 27038 RVA: 0x001E9140 File Offset: 0x001E7340
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217979, RefRangeEnd = 217981, XrefRangeStart = 217957, XrefRangeEnd = 217979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyTrash(TrashItem trash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trash);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_DestroyTrash_Public_Void_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600699F RID: 27039 RVA: 0x001E9184 File Offset: 0x001E7384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217981, XrefRangeEnd = 218003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDestroyTrash(string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_SendDestroyTrash_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069A0 RID: 27040 RVA: 0x001E91C8 File Offset: 0x001E73C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 218025, RefRangeEnd = 218028, XrefRangeStart = 218003, XrefRangeEnd = 218025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyTrash(string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_DestroyTrash_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069A1 RID: 27041 RVA: 0x001E920C File Offset: 0x001E740C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 218043, RefRangeEnd = 218048, XrefRangeStart = 218028, XrefRangeEnd = 218043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashItem GetTrashPrefab(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_GetTrashPrefab_Public_TrashItem_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr3) : null;
		}

		// Token: 0x060069A2 RID: 27042 RVA: 0x001E925C File Offset: 0x001E745C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218068, RefRangeEnd = 218069, XrefRangeStart = 218048, XrefRangeEnd = 218068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashItem GetRandomGeneratableTrashPrefab()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_GetRandomGeneratableTrashPrefab_Public_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr3) : null;
		}

		// Token: 0x060069A3 RID: 27043 RVA: 0x001E929C File Offset: 0x001E749C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218069, XrefRangeEnd = 218121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060069A4 RID: 27044 RVA: 0x001E92E0 File Offset: 0x001E74E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218121, XrefRangeEnd = 218153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069A5 RID: 27045 RVA: 0x001E931C File Offset: 0x001E751C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218153, XrefRangeEnd = 218218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069A6 RID: 27046 RVA: 0x001E9358 File Offset: 0x001E7558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218218, XrefRangeEnd = 218221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069A7 RID: 27047 RVA: 0x001E9394 File Offset: 0x001E7594
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069A8 RID: 27048 RVA: 0x001E93D0 File Offset: 0x001E75D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218250, RefRangeEnd = 218252, XrefRangeStart = 218221, XrefRangeEnd = 218250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcWriter___Server_SendTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069A9 RID: 27049 RVA: 0x001E9450 File Offset: 0x001E7650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcLogic___SendTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069AA RID: 27050 RVA: 0x001E94D0 File Offset: 0x001E76D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218252, XrefRangeEnd = 218264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendTransformData_2990100769(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcReader___Server_SendTransformData_2990100769_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069AB RID: 27051 RVA: 0x001E9534 File Offset: 0x001E7734
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 218293, RefRangeEnd = 218296, XrefRangeStart = 218264, XrefRangeEnd = 218293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069AC RID: 27052 RVA: 0x001E95B4 File Offset: 0x001E77B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218296, XrefRangeEnd = 218313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcLogic___ReceiveTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069AD RID: 27053 RVA: 0x001E9634 File Offset: 0x001E7834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218313, XrefRangeEnd = 218341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveTransformData_2990100769(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveTransformData_2990100769_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069AE RID: 27054 RVA: 0x001E9684 File Offset: 0x001E7884
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 218372, RefRangeEnd = 218375, XrefRangeStart = 218341, XrefRangeEnd = 218372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendTrashItem_478112418(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcWriter___Server_SendTrashItem_478112418_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069AF RID: 27055 RVA: 0x001E9724 File Offset: 0x001E7924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218375, XrefRangeEnd = 218382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendTrashItem_478112418(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcLogic___SendTrashItem_478112418_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069B0 RID: 27056 RVA: 0x001E97C4 File Offset: 0x001E79C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218382, XrefRangeEnd = 218401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendTrashItem_478112418(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcReader___Server_SendTrashItem_478112418_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069B1 RID: 27057 RVA: 0x001E9828 File Offset: 0x001E7A28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218432, RefRangeEnd = 218434, XrefRangeStart = 218401, XrefRangeEnd = 218432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_CreateTrashItem_2385526393(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcWriter___Observers_CreateTrashItem_2385526393_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069B2 RID: 27058 RVA: 0x001E98DC File Offset: 0x001E7ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218434, XrefRangeEnd = 218436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateTrashItem_2385526393(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcLogic___CreateTrashItem_2385526393_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069B3 RID: 27059 RVA: 0x001E9990 File Offset: 0x001E7B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218436, XrefRangeEnd = 218450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_CreateTrashItem_2385526393(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcReader___Observers_CreateTrashItem_2385526393_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069B4 RID: 27060 RVA: 0x001E99E0 File Offset: 0x001E7BE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218481, RefRangeEnd = 218483, XrefRangeStart = 218450, XrefRangeEnd = 218481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_CreateTrashItem_2385526393(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcWriter___Target_CreateTrashItem_2385526393_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069B5 RID: 27061 RVA: 0x001E9A94 File Offset: 0x001E7C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218483, XrefRangeEnd = 218498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_CreateTrashItem_2385526393(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcReader___Target_CreateTrashItem_2385526393_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069B6 RID: 27062 RVA: 0x001E9AE4 File Offset: 0x001E7CE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218530, RefRangeEnd = 218532, XrefRangeStart = 218498, XrefRangeEnd = 218530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendTrashBag_3965031115(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcWriter___Server_SendTrashBag_3965031115_Private_Void_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069B7 RID: 27063 RVA: 0x001E9B98 File Offset: 0x001E7D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218532, XrefRangeEnd = 218539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendTrashBag_3965031115(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcLogic___SendTrashBag_3965031115_Private_Void_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069B8 RID: 27064 RVA: 0x001E9C4C File Offset: 0x001E7E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218539, XrefRangeEnd = 218559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendTrashBag_3965031115(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcReader___Server_SendTrashBag_3965031115_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069B9 RID: 27065 RVA: 0x001E9CB0 File Offset: 0x001E7EB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218591, RefRangeEnd = 218593, XrefRangeStart = 218559, XrefRangeEnd = 218591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_CreateTrashBag_680856992(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcWriter___Observers_CreateTrashBag_680856992_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069BA RID: 27066 RVA: 0x001E9D78 File Offset: 0x001E7F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218593, XrefRangeEnd = 218595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateTrashBag_680856992(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcLogic___CreateTrashBag_680856992_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069BB RID: 27067 RVA: 0x001E9E40 File Offset: 0x001E8040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218595, XrefRangeEnd = 218610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_CreateTrashBag_680856992(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcReader___Observers_CreateTrashBag_680856992_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069BC RID: 27068 RVA: 0x001E9E90 File Offset: 0x001E8090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218642, RefRangeEnd = 218643, XrefRangeStart = 218610, XrefRangeEnd = 218642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_CreateTrashBag_680856992(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcWriter___Target_CreateTrashBag_680856992_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069BD RID: 27069 RVA: 0x001E9F58 File Offset: 0x001E8158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218643, XrefRangeEnd = 218659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_CreateTrashBag_680856992(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcReader___Target_CreateTrashBag_680856992_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069BE RID: 27070 RVA: 0x001E9FA8 File Offset: 0x001E81A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218659, XrefRangeEnd = 218669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendDestroyTrash_3615296227(string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcWriter___Server_SendDestroyTrash_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069BF RID: 27071 RVA: 0x001E9FEC File Offset: 0x001E81EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 218025, RefRangeEnd = 218028, XrefRangeStart = 218025, XrefRangeEnd = 218028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendDestroyTrash_3615296227(string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcLogic___SendDestroyTrash_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069C0 RID: 27072 RVA: 0x001EA030 File Offset: 0x001E8230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218669, XrefRangeEnd = 218673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendDestroyTrash_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcReader___Server_SendDestroyTrash_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069C1 RID: 27073 RVA: 0x001EA094 File Offset: 0x001E8294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218673, XrefRangeEnd = 218683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_DestroyTrash_3615296227(string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcWriter___Observers_DestroyTrash_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069C2 RID: 27074 RVA: 0x001EA0D8 File Offset: 0x001E82D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 218704, RefRangeEnd = 218707, XrefRangeStart = 218683, XrefRangeEnd = 218704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DestroyTrash_3615296227(string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcLogic___DestroyTrash_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069C3 RID: 27075 RVA: 0x001EA11C File Offset: 0x001E831C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218707, XrefRangeEnd = 218711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_DestroyTrash_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcReader___Observers_DestroyTrash_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069C4 RID: 27076 RVA: 0x001EA16C File Offset: 0x001E836C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218711, XrefRangeEnd = 218714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069C5 RID: 27077 RVA: 0x000319CC File Offset: 0x0002FBCC
		public TrashManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002045 RID: 8261
		// (get) Token: 0x060069C6 RID: 27078 RVA: 0x001EA1A8 File Offset: 0x001E83A8
		// (set) Token: 0x060069C7 RID: 27079 RVA: 0x000319D5 File Offset: 0x0002FBD5
		public unsafe static int TRASH_ITEM_LIMIT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(TrashManager.NativeFieldInfoPtr_TRASH_ITEM_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashManager.NativeFieldInfoPtr_TRASH_ITEM_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x17002046 RID: 8262
		// (get) Token: 0x060069C8 RID: 27080 RVA: 0x001EA1C4 File Offset: 0x001E83C4
		// (set) Token: 0x060069C9 RID: 27081 RVA: 0x000319E3 File Offset: 0x0002FBE3
		public unsafe static int TRASH_REPLICATIONS_PER_SECOND
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(TrashManager.NativeFieldInfoPtr_TRASH_REPLICATIONS_PER_SECOND, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashManager.NativeFieldInfoPtr_TRASH_REPLICATIONS_PER_SECOND, (void*)(&value));
			}
		}

		// Token: 0x17002047 RID: 8263
		// (get) Token: 0x060069CA RID: 27082 RVA: 0x001EA1E0 File Offset: 0x001E83E0
		// (set) Token: 0x060069CB RID: 27083 RVA: 0x000319F1 File Offset: 0x0002FBF1
		public unsafe Il2CppReferenceArray<TrashItem> TrashPrefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_TrashPrefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrashItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_TrashPrefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002048 RID: 8264
		// (get) Token: 0x060069CC RID: 27084 RVA: 0x001EA210 File Offset: 0x001E8410
		// (set) Token: 0x060069CD RID: 27085 RVA: 0x00031A10 File Offset: 0x0002FC10
		public unsafe TrashItem TrashBagPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_TrashBagPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_TrashBagPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002049 RID: 8265
		// (get) Token: 0x060069CE RID: 27086 RVA: 0x001EA240 File Offset: 0x001E8440
		// (set) Token: 0x060069CF RID: 27087 RVA: 0x00031A2F File Offset: 0x0002FC2F
		public unsafe Il2CppReferenceArray<TrashManager.TrashItemData> GenerateableTrashItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_GenerateableTrashItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrashManager.TrashItemData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_GenerateableTrashItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700204A RID: 8266
		// (get) Token: 0x060069D0 RID: 27088 RVA: 0x001EA270 File Offset: 0x001E8470
		// (set) Token: 0x060069D1 RID: 27089 RVA: 0x00031A4E File Offset: 0x0002FC4E
		public unsafe List<TrashItem> trashItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_trashItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrashItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_trashItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700204B RID: 8267
		// (get) Token: 0x060069D2 RID: 27090 RVA: 0x001EA2A0 File Offset: 0x001E84A0
		// (set) Token: 0x060069D3 RID: 27091 RVA: 0x00031A6D File Offset: 0x0002FC6D
		public unsafe float TrashForceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_TrashForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_TrashForceMultiplier)) = value;
			}
		}

		// Token: 0x1700204C RID: 8268
		// (get) Token: 0x060069D4 RID: 27092 RVA: 0x001EA2C8 File Offset: 0x001E84C8
		// (set) Token: 0x060069D5 RID: 27093 RVA: 0x00031A88 File Offset: 0x0002FC88
		public unsafe TrashLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700204D RID: 8269
		// (get) Token: 0x060069D6 RID: 27094 RVA: 0x001EA2F8 File Offset: 0x001E84F8
		// (set) Token: 0x060069D7 RID: 27095 RVA: 0x00031AA7 File Offset: 0x0002FCA7
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700204E RID: 8270
		// (get) Token: 0x060069D8 RID: 27096 RVA: 0x001EA328 File Offset: 0x001E8528
		// (set) Token: 0x060069D9 RID: 27097 RVA: 0x00031AC6 File Offset: 0x0002FCC6
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700204F RID: 8271
		// (get) Token: 0x060069DA RID: 27098 RVA: 0x001EA358 File Offset: 0x001E8558
		// (set) Token: 0x060069DB RID: 27099 RVA: 0x00031AE5 File Offset: 0x0002FCE5
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17002050 RID: 8272
		// (get) Token: 0x060069DC RID: 27100 RVA: 0x001EA380 File Offset: 0x001E8580
		// (set) Token: 0x060069DD RID: 27101 RVA: 0x00031B00 File Offset: 0x0002FD00
		public unsafe int _LoadOrder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr__LoadOrder_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr__LoadOrder_k__BackingField)) = value;
			}
		}

		// Token: 0x17002051 RID: 8273
		// (get) Token: 0x060069DE RID: 27102 RVA: 0x001EA3A8 File Offset: 0x001E85A8
		// (set) Token: 0x060069DF RID: 27103 RVA: 0x00031B1B File Offset: 0x0002FD1B
		public unsafe List<string> writtenItemFiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_writtenItemFiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_writtenItemFiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002052 RID: 8274
		// (get) Token: 0x060069E0 RID: 27104 RVA: 0x001EA3D8 File Offset: 0x001E85D8
		// (set) Token: 0x060069E1 RID: 27105 RVA: 0x00031B3A File Offset: 0x0002FD3A
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002053 RID: 8275
		// (get) Token: 0x060069E2 RID: 27106 RVA: 0x001EA400 File Offset: 0x001E8600
		// (set) Token: 0x060069E3 RID: 27107 RVA: 0x00031B55 File Offset: 0x0002FD55
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004895 RID: 18581
		private static readonly IntPtr NativeFieldInfoPtr_TRASH_ITEM_LIMIT;

		// Token: 0x04004896 RID: 18582
		private static readonly IntPtr NativeFieldInfoPtr_TRASH_REPLICATIONS_PER_SECOND;

		// Token: 0x04004897 RID: 18583
		private static readonly IntPtr NativeFieldInfoPtr_TrashPrefabs;

		// Token: 0x04004898 RID: 18584
		private static readonly IntPtr NativeFieldInfoPtr_TrashBagPrefab;

		// Token: 0x04004899 RID: 18585
		private static readonly IntPtr NativeFieldInfoPtr_GenerateableTrashItems;

		// Token: 0x0400489A RID: 18586
		private static readonly IntPtr NativeFieldInfoPtr_trashItems;

		// Token: 0x0400489B RID: 18587
		private static readonly IntPtr NativeFieldInfoPtr_TrashForceMultiplier;

		// Token: 0x0400489C RID: 18588
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x0400489D RID: 18589
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x0400489E RID: 18590
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x0400489F RID: 18591
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x040048A0 RID: 18592
		private static readonly IntPtr NativeFieldInfoPtr__LoadOrder_k__BackingField;

		// Token: 0x040048A1 RID: 18593
		private static readonly IntPtr NativeFieldInfoPtr_writtenItemFiles;

		// Token: 0x040048A2 RID: 18594
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040048A3 RID: 18595
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040048A4 RID: 18596
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040048A5 RID: 18597
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040048A6 RID: 18598
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x040048A7 RID: 18599
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040048A8 RID: 18600
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040048A9 RID: 18601
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x040048AA RID: 18602
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040048AB RID: 18603
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x040048AC RID: 18604
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040048AD RID: 18605
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040048AE RID: 18606
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040048AF RID: 18607
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040048B0 RID: 18608
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x040048B1 RID: 18609
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040048B2 RID: 18610
		private static readonly IntPtr NativeMethodInfoPtr_ReplicateTransformData_Public_Void_TrashItem_0;

		// Token: 0x040048B3 RID: 18611
		private static readonly IntPtr NativeMethodInfoPtr_SendTransformData_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0;

		// Token: 0x040048B4 RID: 18612
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveTransformData_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0;

		// Token: 0x040048B5 RID: 18613
		private static readonly IntPtr NativeMethodInfoPtr_CreateTrashItem_Public_TrashItem_String_Vector3_Quaternion_Vector3_String_Boolean_0;

		// Token: 0x040048B6 RID: 18614
		private static readonly IntPtr NativeMethodInfoPtr_SendTrashItem_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x040048B7 RID: 18615
		private static readonly IntPtr NativeMethodInfoPtr_CreateTrashItem_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x040048B8 RID: 18616
		private static readonly IntPtr NativeMethodInfoPtr_CreateAndReturnTrashItem_Private_TrashItem_String_Vector3_Quaternion_Vector3_String_Boolean_0;

		// Token: 0x040048B9 RID: 18617
		private static readonly IntPtr NativeMethodInfoPtr_CreateTrashBag_Public_TrashItem_String_Vector3_Quaternion_TrashContentData_Vector3_String_Boolean_0;

		// Token: 0x040048BA RID: 18618
		private static readonly IntPtr NativeMethodInfoPtr_SendTrashBag_Private_Void_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x040048BB RID: 18619
		private static readonly IntPtr NativeMethodInfoPtr_CreateTrashBag_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x040048BC RID: 18620
		private static readonly IntPtr NativeMethodInfoPtr_CreateAndReturnTrashBag_Private_TrashItem_String_Vector3_Quaternion_TrashContentData_Vector3_String_Boolean_0;

		// Token: 0x040048BD RID: 18621
		private static readonly IntPtr NativeMethodInfoPtr_DestroyAllTrash_Public_Void_0;

		// Token: 0x040048BE RID: 18622
		private static readonly IntPtr NativeMethodInfoPtr_DestroyTrash_Public_Void_TrashItem_0;

		// Token: 0x040048BF RID: 18623
		private static readonly IntPtr NativeMethodInfoPtr_SendDestroyTrash_Private_Void_String_0;

		// Token: 0x040048C0 RID: 18624
		private static readonly IntPtr NativeMethodInfoPtr_DestroyTrash_Private_Void_String_0;

		// Token: 0x040048C1 RID: 18625
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashPrefab_Public_TrashItem_String_0;

		// Token: 0x040048C2 RID: 18626
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomGeneratableTrashPrefab_Public_TrashItem_0;

		// Token: 0x040048C3 RID: 18627
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x040048C4 RID: 18628
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040048C5 RID: 18629
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040048C6 RID: 18630
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040048C7 RID: 18631
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040048C8 RID: 18632
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0;

		// Token: 0x040048C9 RID: 18633
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0;

		// Token: 0x040048CA RID: 18634
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendTransformData_2990100769_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040048CB RID: 18635
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0;

		// Token: 0x040048CC RID: 18636
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0;

		// Token: 0x040048CD RID: 18637
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveTransformData_2990100769_Private_Void_PooledReader_Channel_0;

		// Token: 0x040048CE RID: 18638
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendTrashItem_478112418_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x040048CF RID: 18639
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendTrashItem_478112418_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x040048D0 RID: 18640
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendTrashItem_478112418_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040048D1 RID: 18641
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_CreateTrashItem_2385526393_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x040048D2 RID: 18642
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateTrashItem_2385526393_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x040048D3 RID: 18643
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_CreateTrashItem_2385526393_Private_Void_PooledReader_Channel_0;

		// Token: 0x040048D4 RID: 18644
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_CreateTrashItem_2385526393_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x040048D5 RID: 18645
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_CreateTrashItem_2385526393_Private_Void_PooledReader_Channel_0;

		// Token: 0x040048D6 RID: 18646
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendTrashBag_3965031115_Private_Void_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x040048D7 RID: 18647
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendTrashBag_3965031115_Private_Void_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x040048D8 RID: 18648
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendTrashBag_3965031115_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040048D9 RID: 18649
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_CreateTrashBag_680856992_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x040048DA RID: 18650
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateTrashBag_680856992_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x040048DB RID: 18651
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_CreateTrashBag_680856992_Private_Void_PooledReader_Channel_0;

		// Token: 0x040048DC RID: 18652
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_CreateTrashBag_680856992_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x040048DD RID: 18653
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_CreateTrashBag_680856992_Private_Void_PooledReader_Channel_0;

		// Token: 0x040048DE RID: 18654
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendDestroyTrash_3615296227_Private_Void_String_0;

		// Token: 0x040048DF RID: 18655
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendDestroyTrash_3615296227_Private_Void_String_0;

		// Token: 0x040048E0 RID: 18656
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendDestroyTrash_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040048E1 RID: 18657
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_DestroyTrash_3615296227_Private_Void_String_0;

		// Token: 0x040048E2 RID: 18658
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DestroyTrash_3615296227_Private_Void_String_0;

		// Token: 0x040048E3 RID: 18659
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_DestroyTrash_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x040048E4 RID: 18660
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000B59 RID: 2905
		[Serializable]
		public class TrashItemData : Il2CppSystem.Object
		{
			// Token: 0x0600E7E3 RID: 59363 RVA: 0x00387FB0 File Offset: 0x003861B0
			// Note: this type is marked as 'beforefieldinit'.
			static TrashItemData()
			{
				Il2CppClassPointerStore<TrashManager.TrashItemData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "TrashItemData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashManager.TrashItemData>.NativeClassPtr);
				TrashManager.TrashItemData.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager.TrashItemData>.NativeClassPtr, "Item");
				TrashManager.TrashItemData.NativeFieldInfoPtr_GenerationChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager.TrashItemData>.NativeClassPtr, "GenerationChance");
				TrashManager.TrashItemData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager.TrashItemData>.NativeClassPtr, 100677174);
			}

			// Token: 0x0600E7E4 RID: 59364 RVA: 0x00388018 File Offset: 0x00386218
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217710, XrefRangeEnd = 217711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TrashItemData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashManager.TrashItemData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.TrashItemData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E7E5 RID: 59365 RVA: 0x0006D5B6 File Offset: 0x0006B7B6
			public TrashItemData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700465E RID: 18014
			// (get) Token: 0x0600E7E6 RID: 59366 RVA: 0x00388054 File Offset: 0x00386254
			// (set) Token: 0x0600E7E7 RID: 59367 RVA: 0x0006D5BF File Offset: 0x0006B7BF
			public unsafe TrashItem Item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.TrashItemData.NativeFieldInfoPtr_Item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.TrashItemData.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700465F RID: 18015
			// (get) Token: 0x0600E7E8 RID: 59368 RVA: 0x00388084 File Offset: 0x00386284
			// (set) Token: 0x0600E7E9 RID: 59369 RVA: 0x0006D5DE File Offset: 0x0006B7DE
			public unsafe float GenerationChance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.TrashItemData.NativeFieldInfoPtr_GenerationChance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.TrashItemData.NativeFieldInfoPtr_GenerationChance)) = value;
				}
			}

			// Token: 0x04009D5A RID: 40282
			private static readonly IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x04009D5B RID: 40283
			private static readonly IntPtr NativeFieldInfoPtr_GenerationChance;

			// Token: 0x04009D5C RID: 40284
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B5A RID: 2906
		[ObfuscatedName("ScheduleOne.Trash.TrashManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E7EA RID: 59370 RVA: 0x003880AC File Offset: 0x003862AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TrashManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashManager.__c>.NativeClassPtr);
				TrashManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager.__c>.NativeClassPtr, "<>9");
				TrashManager.__c.NativeFieldInfoPtr___9__52_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager.__c>.NativeClassPtr, "<>9__52_0");
				TrashManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager.__c>.NativeClassPtr, 100677176);
				TrashManager.__c.NativeMethodInfoPtr__GetRandomGeneratableTrashPrefab_b__52_0_Internal_Single_TrashItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager.__c>.NativeClassPtr, 100677177);
			}

			// Token: 0x0600E7EB RID: 59371 RVA: 0x00388128 File Offset: 0x00386328
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E7EC RID: 59372 RVA: 0x00388164 File Offset: 0x00386364
			[CallerCount(0)]
			public unsafe float _GetRandomGeneratableTrashPrefab_b__52_0(TrashManager.TrashItemData t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.__c.NativeMethodInfoPtr__GetRandomGeneratableTrashPrefab_b__52_0_Internal_Single_TrashItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E7ED RID: 59373 RVA: 0x0006D5F9 File Offset: 0x0006B7F9
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004660 RID: 18016
			// (get) Token: 0x0600E7EE RID: 59374 RVA: 0x003881B4 File Offset: 0x003863B4
			// (set) Token: 0x0600E7EF RID: 59375 RVA: 0x0006D602 File Offset: 0x0006B802
			public unsafe static TrashManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TrashManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TrashManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004661 RID: 18017
			// (get) Token: 0x0600E7F0 RID: 59376 RVA: 0x003881DC File Offset: 0x003863DC
			// (set) Token: 0x0600E7F1 RID: 59377 RVA: 0x0006D614 File Offset: 0x0006B814
			public unsafe static Func<TrashManager.TrashItemData, float> __9__52_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TrashManager.__c.NativeFieldInfoPtr___9__52_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TrashManager.TrashItemData, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TrashManager.__c.NativeFieldInfoPtr___9__52_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009D5D RID: 40285
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009D5E RID: 40286
			private static readonly IntPtr NativeFieldInfoPtr___9__52_0;

			// Token: 0x04009D5F RID: 40287
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009D60 RID: 40288
			private static readonly IntPtr NativeMethodInfoPtr__GetRandomGeneratableTrashPrefab_b__52_0_Internal_Single_TrashItemData_0;
		}

		// Token: 0x02000B5B RID: 2907
		[ObfuscatedName("ScheduleOne.Trash.TrashManager+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E7F2 RID: 59378 RVA: 0x00388204 File Offset: 0x00386404
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<TrashManager.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashManager.__c__DisplayClass35_0>.NativeClassPtr);
				TrashManager.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
				TrashManager.__c__DisplayClass35_0.NativeFieldInfoPtr_byteSizeEstimate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager.__c__DisplayClass35_0>.NativeClassPtr, "byteSizeEstimate");
				TrashManager.__c__DisplayClass35_0.NativeFieldInfoPtr_connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager.__c__DisplayClass35_0>.NativeClassPtr, "connection");
				TrashManager.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager.__c__DisplayClass35_0>.NativeClassPtr, 100677178);
				TrashManager.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_Void_NetworkConnection_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager.__c__DisplayClass35_0>.NativeClassPtr, 100677179);
				TrashManager.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager.__c__DisplayClass35_0>.NativeClassPtr, 100677180);
			}

			// Token: 0x0600E7F3 RID: 59379 RVA: 0x003882A8 File Offset: 0x003864A8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashManager.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E7F4 RID: 59380 RVA: 0x003882E4 File Offset: 0x003864E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217711, XrefRangeEnd = 217734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_NetworkConnection_PDM_0(NetworkConnection conn)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_Void_NetworkConnection_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E7F5 RID: 59381 RVA: 0x00388328 File Offset: 0x00386528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217734, XrefRangeEnd = 217745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Int32_PDM_0(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E7F6 RID: 59382 RVA: 0x0006D626 File Offset: 0x0006B826
			public __c__DisplayClass35_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004662 RID: 18018
			// (get) Token: 0x0600E7F7 RID: 59383 RVA: 0x00388368 File Offset: 0x00386568
			// (set) Token: 0x0600E7F8 RID: 59384 RVA: 0x0006D62F File Offset: 0x0006B82F
			public unsafe TrashManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004663 RID: 18019
			// (get) Token: 0x0600E7F9 RID: 59385 RVA: 0x00388398 File Offset: 0x00386598
			// (set) Token: 0x0600E7FA RID: 59386 RVA: 0x0006D64E File Offset: 0x0006B84E
			public unsafe int byteSizeEstimate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.__c__DisplayClass35_0.NativeFieldInfoPtr_byteSizeEstimate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.__c__DisplayClass35_0.NativeFieldInfoPtr_byteSizeEstimate)) = value;
				}
			}

			// Token: 0x17004664 RID: 18020
			// (get) Token: 0x0600E7FB RID: 59387 RVA: 0x003883C0 File Offset: 0x003865C0
			// (set) Token: 0x0600E7FC RID: 59388 RVA: 0x0006D669 File Offset: 0x0006B869
			public unsafe NetworkConnection connection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.__c__DisplayClass35_0.NativeFieldInfoPtr_connection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.__c__DisplayClass35_0.NativeFieldInfoPtr_connection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009D61 RID: 40289
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009D62 RID: 40290
			private static readonly IntPtr NativeFieldInfoPtr_byteSizeEstimate;

			// Token: 0x04009D63 RID: 40291
			private static readonly IntPtr NativeFieldInfoPtr_connection;

			// Token: 0x04009D64 RID: 40292
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009D65 RID: 40293
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_NetworkConnection_PDM_0;

			// Token: 0x04009D66 RID: 40294
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0;
		}

		// Token: 0x02000B5C RID: 2908
		[ObfuscatedName("ScheduleOne.Trash.TrashManager+<>c__DisplayClass51_0")]
		public sealed class __c__DisplayClass51_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E7FD RID: 59389 RVA: 0x003883F0 File Offset: 0x003865F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass51_0()
			{
				Il2CppClassPointerStore<TrashManager.__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "<>c__DisplayClass51_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashManager.__c__DisplayClass51_0>.NativeClassPtr);
				TrashManager.__c__DisplayClass51_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager.__c__DisplayClass51_0>.NativeClassPtr, "id");
				TrashManager.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager.__c__DisplayClass51_0>.NativeClassPtr, 100677181);
				TrashManager.__c__DisplayClass51_0.NativeMethodInfoPtr__GetTrashPrefab_b__0_Internal_Boolean_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager.__c__DisplayClass51_0>.NativeClassPtr, 100677182);
			}

			// Token: 0x0600E7FE RID: 59390 RVA: 0x00388458 File Offset: 0x00386658
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass51_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashManager.__c__DisplayClass51_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E7FF RID: 59391 RVA: 0x00388494 File Offset: 0x00386694
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217745, XrefRangeEnd = 217768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetTrashPrefab_b__0(TrashItem t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.__c__DisplayClass51_0.NativeMethodInfoPtr__GetTrashPrefab_b__0_Internal_Boolean_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E800 RID: 59392 RVA: 0x0006D688 File Offset: 0x0006B888
			public __c__DisplayClass51_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004665 RID: 18021
			// (get) Token: 0x0600E801 RID: 59393 RVA: 0x003884E4 File Offset: 0x003866E4
			// (set) Token: 0x0600E802 RID: 59394 RVA: 0x0006D691 File Offset: 0x0006B891
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.__c__DisplayClass51_0.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.__c__DisplayClass51_0.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009D67 RID: 40295
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04009D68 RID: 40296
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009D69 RID: 40297
			private static readonly IntPtr NativeMethodInfoPtr__GetTrashPrefab_b__0_Internal_Boolean_TrashItem_0;
		}
	}
}
