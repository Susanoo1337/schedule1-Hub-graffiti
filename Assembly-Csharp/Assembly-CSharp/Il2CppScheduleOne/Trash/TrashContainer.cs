using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x0200048A RID: 1162
	public class TrashContainer : NetworkBehaviour
	{
		// Token: 0x0600689B RID: 26779 RVA: 0x001E4C40 File Offset: 0x001E2E40
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContainer()
		{
			Il2CppClassPointerStore<TrashContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr);
			TrashContainer.NativeFieldInfoPtr__Content_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "<Content>k__BackingField");
			TrashContainer.NativeFieldInfoPtr_TrashCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "TrashCapacity");
			TrashContainer.NativeFieldInfoPtr_TrashBagDropLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "TrashBagDropLocation");
			TrashContainer.NativeFieldInfoPtr_onTrashAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "onTrashAdded");
			TrashContainer.NativeFieldInfoPtr_onTrashLevelChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "onTrashLevelChanged");
			TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Trash.TrashContainerAssembly-CSharp.dll_Excuted");
			TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Trash.TrashContainerAssembly-CSharp.dll_Excuted");
			TrashContainer.NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676976);
			TrashContainer.NativeMethodInfoPtr_set_Content_Protected_set_Void_TrashContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676977);
			TrashContainer.NativeMethodInfoPtr_get_TrashLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676978);
			TrashContainer.NativeMethodInfoPtr_get_NormalizedTrashLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676979);
			TrashContainer.NativeMethodInfoPtr_AddTrash_Public_Virtual_New_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676980);
			TrashContainer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676981);
			TrashContainer.NativeMethodInfoPtr_SendTrash_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676982);
			TrashContainer.NativeMethodInfoPtr_AddTrash_Private_Void_NetworkConnection_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676983);
			TrashContainer.NativeMethodInfoPtr_SendClear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676984);
			TrashContainer.NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676985);
			TrashContainer.NativeMethodInfoPtr_LoadContent_Private_Void_NetworkConnection_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676986);
			TrashContainer.NativeMethodInfoPtr_TriggerEnter_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676987);
			TrashContainer.NativeMethodInfoPtr_CanBeBagged_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676988);
			TrashContainer.NativeMethodInfoPtr_BagTrash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676989);
			TrashContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676990);
			TrashContainer.NativeMethodInfoPtr_Method_Private_Void_NetworkConnection_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676991);
			TrashContainer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676992);
			TrashContainer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676993);
			TrashContainer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676994);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Server_SendTrash_3643459082_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676995);
			TrashContainer.NativeMethodInfoPtr_RpcLogic___SendTrash_3643459082_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676996);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Server_SendTrash_3643459082_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676997);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Observers_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676998);
			TrashContainer.NativeMethodInfoPtr_RpcLogic___AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100676999);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Observers_AddTrash_3905681115_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677000);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Target_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677001);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Target_AddTrash_3905681115_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677002);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Server_SendClear_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677003);
			TrashContainer.NativeMethodInfoPtr_RpcLogic___SendClear_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677004);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Server_SendClear_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677005);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Observers_Clear_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677006);
			TrashContainer.NativeMethodInfoPtr_RpcLogic___Clear_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677007);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Observers_Clear_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677008);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Target_LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677009);
			TrashContainer.NativeMethodInfoPtr_RpcLogic___LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677010);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Target_LoadContent_189522235_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677011);
			TrashContainer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677012);
		}

		// Token: 0x17002005 RID: 8197
		// (get) Token: 0x0600689C RID: 26780 RVA: 0x001E4FE0 File Offset: 0x001E31E0
		// (set) Token: 0x0600689D RID: 26781 RVA: 0x001E5020 File Offset: 0x001E3220
		public unsafe TrashContent Content
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashContent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_set_Content_Protected_set_Void_TrashContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002006 RID: 8198
		// (get) Token: 0x0600689E RID: 26782 RVA: 0x001E5064 File Offset: 0x001E3264
		public unsafe int TrashLevel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 216461, RefRangeEnd = 216462, XrefRangeStart = 216459, XrefRangeEnd = 216461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_get_TrashLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002007 RID: 8199
		// (get) Token: 0x0600689F RID: 26783 RVA: 0x001E50A0 File Offset: 0x001E32A0
		public unsafe float NormalizedTrashLevel
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 216463, RefRangeEnd = 216467, XrefRangeStart = 216462, XrefRangeEnd = 216463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_get_NormalizedTrashLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060068A0 RID: 26784 RVA: 0x001E50DC File Offset: 0x001E32DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216467, XrefRangeEnd = 216507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddTrash(TrashItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_AddTrash_Public_Virtual_New_Void_TrashItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068A1 RID: 26785 RVA: 0x001E512C File Offset: 0x001E332C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216507, XrefRangeEnd = 216518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068A2 RID: 26786 RVA: 0x001E517C File Offset: 0x001E337C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216518, XrefRangeEnd = 216541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTrash(string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_SendTrash_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068A3 RID: 26787 RVA: 0x001E51CC File Offset: 0x001E33CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 216584, RefRangeEnd = 216588, XrefRangeStart = 216541, XrefRangeEnd = 216584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTrash(NetworkConnection conn, string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_AddTrash_Private_Void_NetworkConnection_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068A4 RID: 26788 RVA: 0x001E5230 File Offset: 0x001E3430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216588, XrefRangeEnd = 216609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendClear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_SendClear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068A5 RID: 26789 RVA: 0x001E5264 File Offset: 0x001E3464
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 216630, RefRangeEnd = 216633, XrefRangeStart = 216609, XrefRangeEnd = 216630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068A6 RID: 26790 RVA: 0x001E5298 File Offset: 0x001E3498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216633, XrefRangeEnd = 216643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadContent(NetworkConnection conn, TrashContentData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_LoadContent_Private_Void_NetworkConnection_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068A7 RID: 26791 RVA: 0x001E52EC File Offset: 0x001E34EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216643, XrefRangeEnd = 216652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_TriggerEnter_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068A8 RID: 26792 RVA: 0x001E5330 File Offset: 0x001E3530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216652, XrefRangeEnd = 216653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBeBagged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_CanBeBagged_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060068A9 RID: 26793 RVA: 0x001E536C File Offset: 0x001E356C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216702, RefRangeEnd = 216703, XrefRangeStart = 216653, XrefRangeEnd = 216702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BagTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_BagTrash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068AA RID: 26794 RVA: 0x001E53A0 File Offset: 0x001E35A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216703, XrefRangeEnd = 216709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068AB RID: 26795 RVA: 0x001E53DC File Offset: 0x001E35DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216709, XrefRangeEnd = 216729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_NetworkConnection_PDM_0(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_Method_Private_Void_NetworkConnection_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068AC RID: 26796 RVA: 0x001E5420 File Offset: 0x001E3620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216729, XrefRangeEnd = 216767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068AD RID: 26797 RVA: 0x001E545C File Offset: 0x001E365C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 216767, RefRangeEnd = 216770, XrefRangeStart = 216767, XrefRangeEnd = 216767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068AE RID: 26798 RVA: 0x001E5498 File Offset: 0x001E3698
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068AF RID: 26799 RVA: 0x001E54D4 File Offset: 0x001E36D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216770, XrefRangeEnd = 216782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendTrash_3643459082(string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Server_SendTrash_3643459082_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068B0 RID: 26800 RVA: 0x001E5524 File Offset: 0x001E3724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216782, XrefRangeEnd = 216783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendTrash_3643459082(string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcLogic___SendTrash_3643459082_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068B1 RID: 26801 RVA: 0x001E5574 File Offset: 0x001E3774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216783, XrefRangeEnd = 216789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendTrash_3643459082(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Server_SendTrash_3643459082_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068B2 RID: 26802 RVA: 0x001E55D8 File Offset: 0x001E37D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216789, XrefRangeEnd = 216801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Observers_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068B3 RID: 26803 RVA: 0x001E563C File Offset: 0x001E383C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 216806, RefRangeEnd = 216809, XrefRangeStart = 216801, XrefRangeEnd = 216806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcLogic___AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068B4 RID: 26804 RVA: 0x001E56A0 File Offset: 0x001E38A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216809, XrefRangeEnd = 216815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddTrash_3905681115(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Observers_AddTrash_3905681115_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068B5 RID: 26805 RVA: 0x001E56F0 File Offset: 0x001E38F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216815, XrefRangeEnd = 216827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Target_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068B6 RID: 26806 RVA: 0x001E5754 File Offset: 0x001E3954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216827, XrefRangeEnd = 216833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_AddTrash_3905681115(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Target_AddTrash_3905681115_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068B7 RID: 26807 RVA: 0x001E57A4 File Offset: 0x001E39A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216833, XrefRangeEnd = 216842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendClear_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Server_SendClear_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068B8 RID: 26808 RVA: 0x001E57D8 File Offset: 0x001E39D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 216630, RefRangeEnd = 216633, XrefRangeStart = 216630, XrefRangeEnd = 216633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendClear_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcLogic___SendClear_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068B9 RID: 26809 RVA: 0x001E580C File Offset: 0x001E3A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216842, XrefRangeEnd = 216845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendClear_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Server_SendClear_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068BA RID: 26810 RVA: 0x001E5870 File Offset: 0x001E3A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216845, XrefRangeEnd = 216854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Clear_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Observers_Clear_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068BB RID: 26811 RVA: 0x001E58A4 File Offset: 0x001E3AA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 216857, RefRangeEnd = 216860, XrefRangeStart = 216854, XrefRangeEnd = 216857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Clear_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcLogic___Clear_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068BC RID: 26812 RVA: 0x001E58D8 File Offset: 0x001E3AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216860, XrefRangeEnd = 216863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Clear_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Observers_Clear_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068BD RID: 26813 RVA: 0x001E5928 File Offset: 0x001E3B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_LoadContent_189522235(NetworkConnection conn, TrashContentData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Target_LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068BE RID: 26814 RVA: 0x001E597C File Offset: 0x001E3B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216863, XrefRangeEnd = 216866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___LoadContent_189522235(NetworkConnection conn, TrashContentData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcLogic___LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068BF RID: 26815 RVA: 0x001E59D0 File Offset: 0x001E3BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216866, XrefRangeEnd = 216872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_LoadContent_189522235(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Target_LoadContent_189522235_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068C0 RID: 26816 RVA: 0x001E5A20 File Offset: 0x001E3C20
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068C1 RID: 26817 RVA: 0x0003144F File Offset: 0x0002F64F
		public TrashContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FFE RID: 8190
		// (get) Token: 0x060068C2 RID: 26818 RVA: 0x001E5A5C File Offset: 0x001E3C5C
		// (set) Token: 0x060068C3 RID: 26819 RVA: 0x00031458 File Offset: 0x0002F658
		public unsafe TrashContent _Content_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr__Content_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr__Content_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FFF RID: 8191
		// (get) Token: 0x060068C4 RID: 26820 RVA: 0x001E5A8C File Offset: 0x001E3C8C
		// (set) Token: 0x060068C5 RID: 26821 RVA: 0x00031477 File Offset: 0x0002F677
		public unsafe int TrashCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_TrashCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_TrashCapacity)) = value;
			}
		}

		// Token: 0x17002000 RID: 8192
		// (get) Token: 0x060068C6 RID: 26822 RVA: 0x001E5AB4 File Offset: 0x001E3CB4
		// (set) Token: 0x060068C7 RID: 26823 RVA: 0x00031492 File Offset: 0x0002F692
		public unsafe Transform TrashBagDropLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_TrashBagDropLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_TrashBagDropLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002001 RID: 8193
		// (get) Token: 0x060068C8 RID: 26824 RVA: 0x001E5AE4 File Offset: 0x001E3CE4
		// (set) Token: 0x060068C9 RID: 26825 RVA: 0x000314B1 File Offset: 0x0002F6B1
		public unsafe UnityEvent<string> onTrashAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_onTrashAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_onTrashAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002002 RID: 8194
		// (get) Token: 0x060068CA RID: 26826 RVA: 0x001E5B14 File Offset: 0x001E3D14
		// (set) Token: 0x060068CB RID: 26827 RVA: 0x000314D0 File Offset: 0x0002F6D0
		public unsafe UnityEvent onTrashLevelChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_onTrashLevelChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_onTrashLevelChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002003 RID: 8195
		// (get) Token: 0x060068CC RID: 26828 RVA: 0x001E5B44 File Offset: 0x001E3D44
		// (set) Token: 0x060068CD RID: 26829 RVA: 0x000314EF File Offset: 0x0002F6EF
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002004 RID: 8196
		// (get) Token: 0x060068CE RID: 26830 RVA: 0x001E5B6C File Offset: 0x001E3D6C
		// (set) Token: 0x060068CF RID: 26831 RVA: 0x0003150A File Offset: 0x0002F70A
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040047EC RID: 18412
		private static readonly IntPtr NativeFieldInfoPtr__Content_k__BackingField;

		// Token: 0x040047ED RID: 18413
		private static readonly IntPtr NativeFieldInfoPtr_TrashCapacity;

		// Token: 0x040047EE RID: 18414
		private static readonly IntPtr NativeFieldInfoPtr_TrashBagDropLocation;

		// Token: 0x040047EF RID: 18415
		private static readonly IntPtr NativeFieldInfoPtr_onTrashAdded;

		// Token: 0x040047F0 RID: 18416
		private static readonly IntPtr NativeFieldInfoPtr_onTrashLevelChanged;

		// Token: 0x040047F1 RID: 18417
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040047F2 RID: 18418
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040047F3 RID: 18419
		private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0;

		// Token: 0x040047F4 RID: 18420
		private static readonly IntPtr NativeMethodInfoPtr_set_Content_Protected_set_Void_TrashContent_0;

		// Token: 0x040047F5 RID: 18421
		private static readonly IntPtr NativeMethodInfoPtr_get_TrashLevel_Public_get_Int32_0;

		// Token: 0x040047F6 RID: 18422
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedTrashLevel_Public_get_Single_0;

		// Token: 0x040047F7 RID: 18423
		private static readonly IntPtr NativeMethodInfoPtr_AddTrash_Public_Virtual_New_Void_TrashItem_0;

		// Token: 0x040047F8 RID: 18424
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040047F9 RID: 18425
		private static readonly IntPtr NativeMethodInfoPtr_SendTrash_Private_Void_String_Int32_0;

		// Token: 0x040047FA RID: 18426
		private static readonly IntPtr NativeMethodInfoPtr_AddTrash_Private_Void_NetworkConnection_String_Int32_0;

		// Token: 0x040047FB RID: 18427
		private static readonly IntPtr NativeMethodInfoPtr_SendClear_Private_Void_0;

		// Token: 0x040047FC RID: 18428
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;

		// Token: 0x040047FD RID: 18429
		private static readonly IntPtr NativeMethodInfoPtr_LoadContent_Private_Void_NetworkConnection_TrashContentData_0;

		// Token: 0x040047FE RID: 18430
		private static readonly IntPtr NativeMethodInfoPtr_TriggerEnter_Public_Void_Collider_0;

		// Token: 0x040047FF RID: 18431
		private static readonly IntPtr NativeMethodInfoPtr_CanBeBagged_Public_Boolean_0;

		// Token: 0x04004800 RID: 18432
		private static readonly IntPtr NativeMethodInfoPtr_BagTrash_Public_Void_0;

		// Token: 0x04004801 RID: 18433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004802 RID: 18434
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_NetworkConnection_PDM_0;

		// Token: 0x04004803 RID: 18435
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004804 RID: 18436
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004805 RID: 18437
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004806 RID: 18438
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendTrash_3643459082_Private_Void_String_Int32_0;

		// Token: 0x04004807 RID: 18439
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendTrash_3643459082_Private_Void_String_Int32_0;

		// Token: 0x04004808 RID: 18440
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendTrash_3643459082_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004809 RID: 18441
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0;

		// Token: 0x0400480A RID: 18442
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0;

		// Token: 0x0400480B RID: 18443
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddTrash_3905681115_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400480C RID: 18444
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0;

		// Token: 0x0400480D RID: 18445
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_AddTrash_3905681115_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400480E RID: 18446
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendClear_2166136261_Private_Void_0;

		// Token: 0x0400480F RID: 18447
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendClear_2166136261_Private_Void_0;

		// Token: 0x04004810 RID: 18448
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendClear_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004811 RID: 18449
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Clear_2166136261_Private_Void_0;

		// Token: 0x04004812 RID: 18450
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Clear_2166136261_Private_Void_0;

		// Token: 0x04004813 RID: 18451
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Clear_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004814 RID: 18452
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0;

		// Token: 0x04004815 RID: 18453
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0;

		// Token: 0x04004816 RID: 18454
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_LoadContent_189522235_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004817 RID: 18455
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
