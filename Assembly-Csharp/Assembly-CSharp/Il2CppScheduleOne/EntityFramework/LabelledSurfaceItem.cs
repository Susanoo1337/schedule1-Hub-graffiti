using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppTMPro;

namespace Il2CppScheduleOne.EntityFramework
{
	// Token: 0x02000376 RID: 886
	public class LabelledSurfaceItem : SurfaceItem
	{
		// Token: 0x06004C19 RID: 19481 RVA: 0x0017F3B8 File Offset: 0x0017D5B8
		// Note: this type is marked as 'beforefieldinit'.
		static LabelledSurfaceItem()
		{
			Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.EntityFramework", "LabelledSurfaceItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr);
			LabelledSurfaceItem.NativeFieldInfoPtr__Message_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, "<Message>k__BackingField");
			LabelledSurfaceItem.NativeFieldInfoPtr_MaxCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, "MaxCharacters");
			LabelledSurfaceItem.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, "Label");
			LabelledSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.EntityFramework.LabelledSurfaceItemAssembly-CSharp.dll_Excuted");
			LabelledSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.EntityFramework.LabelledSurfaceItemAssembly-CSharp.dll_Excuted");
			LabelledSurfaceItem.NativeMethodInfoPtr_get_Message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673105);
			LabelledSurfaceItem.NativeMethodInfoPtr_set_Message_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673106);
			LabelledSurfaceItem.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673107);
			LabelledSurfaceItem.NativeMethodInfoPtr_SendMessageToServer_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673108);
			LabelledSurfaceItem.NativeMethodInfoPtr_SetMessage_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673109);
			LabelledSurfaceItem.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673110);
			LabelledSurfaceItem.NativeMethodInfoPtr_MessageSubmitted_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673111);
			LabelledSurfaceItem.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673112);
			LabelledSurfaceItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673113);
			LabelledSurfaceItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673114);
			LabelledSurfaceItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673115);
			LabelledSurfaceItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673116);
			LabelledSurfaceItem.NativeMethodInfoPtr_RpcWriter___Server_SendMessageToServer_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673117);
			LabelledSurfaceItem.NativeMethodInfoPtr_RpcLogic___SendMessageToServer_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673118);
			LabelledSurfaceItem.NativeMethodInfoPtr_RpcReader___Server_SendMessageToServer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673119);
			LabelledSurfaceItem.NativeMethodInfoPtr_RpcWriter___Observers_SetMessage_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673120);
			LabelledSurfaceItem.NativeMethodInfoPtr_RpcLogic___SetMessage_2971853958_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673121);
			LabelledSurfaceItem.NativeMethodInfoPtr_RpcReader___Observers_SetMessage_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673122);
			LabelledSurfaceItem.NativeMethodInfoPtr_RpcWriter___Target_SetMessage_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673123);
			LabelledSurfaceItem.NativeMethodInfoPtr_RpcReader___Target_SetMessage_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673124);
			LabelledSurfaceItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr, 100673125);
		}

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x06004C1A RID: 19482 RVA: 0x0017F5F0 File Offset: 0x0017D7F0
		// (set) Token: 0x06004C1B RID: 19483 RVA: 0x0017F628 File Offset: 0x0017D828
		public unsafe string Message
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_get_Message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173208, XrefRangeEnd = 173209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_set_Message_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C1C RID: 19484 RVA: 0x0017F66C File Offset: 0x0017D86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173209, XrefRangeEnd = 173213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabelledSurfaceItem.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C1D RID: 19485 RVA: 0x0017F6BC File Offset: 0x0017D8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173213, XrefRangeEnd = 173235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessageToServer(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_SendMessageToServer_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C1E RID: 19486 RVA: 0x0017F700 File Offset: 0x0017D900
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 173245, RefRangeEnd = 173252, XrefRangeStart = 173235, XrefRangeEnd = 173245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMessage(NetworkConnection conn, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_SetMessage_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C1F RID: 19487 RVA: 0x0017F754 File Offset: 0x0017D954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173252, XrefRangeEnd = 173265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C20 RID: 19488 RVA: 0x0017F788 File Offset: 0x0017D988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MessageSubmitted(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_MessageSubmitted_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C21 RID: 19489 RVA: 0x0017F7CC File Offset: 0x0017D9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173265, XrefRangeEnd = 173270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BuildableItemData GetBaseData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabelledSurfaceItem.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuildableItemData>(intPtr3) : null;
		}

		// Token: 0x06004C22 RID: 19490 RVA: 0x0017F818 File Offset: 0x0017DA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173270, XrefRangeEnd = 173295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabelledSurfaceItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabelledSurfaceItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C23 RID: 19491 RVA: 0x0017F854 File Offset: 0x0017DA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173295, XrefRangeEnd = 173336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabelledSurfaceItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C24 RID: 19492 RVA: 0x0017F890 File Offset: 0x0017DA90
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabelledSurfaceItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C25 RID: 19493 RVA: 0x0017F8CC File Offset: 0x0017DACC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabelledSurfaceItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C26 RID: 19494 RVA: 0x0017F908 File Offset: 0x0017DB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173336, XrefRangeEnd = 173346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendMessageToServer_3615296227(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_RpcWriter___Server_SendMessageToServer_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C27 RID: 19495 RVA: 0x0017F94C File Offset: 0x0017DB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173346, XrefRangeEnd = 173347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendMessageToServer_3615296227(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_RpcLogic___SendMessageToServer_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C28 RID: 19496 RVA: 0x0017F990 File Offset: 0x0017DB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173347, XrefRangeEnd = 173351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendMessageToServer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_RpcReader___Server_SendMessageToServer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C29 RID: 19497 RVA: 0x0017F9F4 File Offset: 0x0017DBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173351, XrefRangeEnd = 173361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetMessage_2971853958(NetworkConnection conn, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_RpcWriter___Observers_SetMessage_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C2A RID: 19498 RVA: 0x0017FA48 File Offset: 0x0017DC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173361, XrefRangeEnd = 173362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetMessage_2971853958(NetworkConnection conn, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_RpcLogic___SetMessage_2971853958_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C2B RID: 19499 RVA: 0x0017FA9C File Offset: 0x0017DC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173362, XrefRangeEnd = 173366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetMessage_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_RpcReader___Observers_SetMessage_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C2C RID: 19500 RVA: 0x0017FAEC File Offset: 0x0017DCEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173366, XrefRangeEnd = 173376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetMessage_2971853958(NetworkConnection conn, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_RpcWriter___Target_SetMessage_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C2D RID: 19501 RVA: 0x0017FB40 File Offset: 0x0017DD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173376, XrefRangeEnd = 173380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetMessage_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItem.NativeMethodInfoPtr_RpcReader___Target_SetMessage_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C2E RID: 19502 RVA: 0x0017FB90 File Offset: 0x0017DD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173380, XrefRangeEnd = 173381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabelledSurfaceItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C2F RID: 19503 RVA: 0x000249EC File Offset: 0x00022BEC
		public LabelledSurfaceItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170017C6 RID: 6086
		// (get) Token: 0x06004C30 RID: 19504 RVA: 0x0017FBCC File Offset: 0x0017DDCC
		// (set) Token: 0x06004C31 RID: 19505 RVA: 0x000249F5 File Offset: 0x00022BF5
		public unsafe string _Message_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItem.NativeFieldInfoPtr__Message_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItem.NativeFieldInfoPtr__Message_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170017C7 RID: 6087
		// (get) Token: 0x06004C32 RID: 19506 RVA: 0x0017FBF4 File Offset: 0x0017DDF4
		// (set) Token: 0x06004C33 RID: 19507 RVA: 0x00024A14 File Offset: 0x00022C14
		public unsafe int MaxCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItem.NativeFieldInfoPtr_MaxCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItem.NativeFieldInfoPtr_MaxCharacters)) = value;
			}
		}

		// Token: 0x170017C8 RID: 6088
		// (get) Token: 0x06004C34 RID: 19508 RVA: 0x0017FC1C File Offset: 0x0017DE1C
		// (set) Token: 0x06004C35 RID: 19509 RVA: 0x00024A2F File Offset: 0x00022C2F
		public unsafe TextMeshPro Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItem.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItem.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x06004C36 RID: 19510 RVA: 0x0017FC4C File Offset: 0x0017DE4C
		// (set) Token: 0x06004C37 RID: 19511 RVA: 0x00024A4E File Offset: 0x00022C4E
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x06004C38 RID: 19512 RVA: 0x0017FC74 File Offset: 0x0017DE74
		// (set) Token: 0x06004C39 RID: 19513 RVA: 0x00024A69 File Offset: 0x00022C69
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelledSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040033F3 RID: 13299
		private static readonly IntPtr NativeFieldInfoPtr__Message_k__BackingField;

		// Token: 0x040033F4 RID: 13300
		private static readonly IntPtr NativeFieldInfoPtr_MaxCharacters;

		// Token: 0x040033F5 RID: 13301
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x040033F6 RID: 13302
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040033F7 RID: 13303
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040033F8 RID: 13304
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_String_0;

		// Token: 0x040033F9 RID: 13305
		private static readonly IntPtr NativeMethodInfoPtr_set_Message_Private_set_Void_String_0;

		// Token: 0x040033FA RID: 13306
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040033FB RID: 13307
		private static readonly IntPtr NativeMethodInfoPtr_SendMessageToServer_Public_Void_String_0;

		// Token: 0x040033FC RID: 13308
		private static readonly IntPtr NativeMethodInfoPtr_SetMessage_Public_Void_NetworkConnection_String_0;

		// Token: 0x040033FD RID: 13309
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x040033FE RID: 13310
		private static readonly IntPtr NativeMethodInfoPtr_MessageSubmitted_Private_Void_String_0;

		// Token: 0x040033FF RID: 13311
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0;

		// Token: 0x04003400 RID: 13312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003401 RID: 13313
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003402 RID: 13314
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003403 RID: 13315
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003404 RID: 13316
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendMessageToServer_3615296227_Private_Void_String_0;

		// Token: 0x04003405 RID: 13317
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendMessageToServer_3615296227_Public_Void_String_0;

		// Token: 0x04003406 RID: 13318
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendMessageToServer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003407 RID: 13319
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetMessage_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04003408 RID: 13320
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetMessage_2971853958_Public_Void_NetworkConnection_String_0;

		// Token: 0x04003409 RID: 13321
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetMessage_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400340A RID: 13322
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetMessage_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x0400340B RID: 13323
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetMessage_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400340C RID: 13324
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
