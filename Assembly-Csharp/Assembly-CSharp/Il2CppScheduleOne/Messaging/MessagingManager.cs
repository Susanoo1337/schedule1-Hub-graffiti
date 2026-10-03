using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI.Phone.Messages;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x020002A5 RID: 677
	public class MessagingManager : NetworkSingleton<MessagingManager>
	{
		// Token: 0x06003353 RID: 13139 RVA: 0x001251A8 File Offset: 0x001233A8
		// Note: this type is marked as 'beforefieldinit'.
		static MessagingManager()
		{
			Il2CppClassPointerStore<MessagingManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "MessagingManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr);
			MessagingManager.NativeFieldInfoPtr_ConversationMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, "ConversationMap");
			MessagingManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Messaging.MessagingManagerAssembly-CSharp.dll_Excuted");
			MessagingManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Messaging.MessagingManagerAssembly-CSharp.dll_Excuted");
			MessagingManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669731);
			MessagingManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669732);
			MessagingManager.NativeMethodInfoPtr_GetConversation_Public_MSGConversation_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669733);
			MessagingManager.NativeMethodInfoPtr_Register_Public_Void_NPC_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669734);
			MessagingManager.NativeMethodInfoPtr_SendMessage_Public_Void_Message_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669735);
			MessagingManager.NativeMethodInfoPtr_ReceiveMessage_Private_Void_Message_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669736);
			MessagingManager.NativeMethodInfoPtr_SendMessageChain_Public_Void_MessageChain_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669737);
			MessagingManager.NativeMethodInfoPtr_ReceiveMessageChain_Private_Void_MessageChain_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669738);
			MessagingManager.NativeMethodInfoPtr_SendResponse_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669739);
			MessagingManager.NativeMethodInfoPtr_ReceiveResponse_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669740);
			MessagingManager.NativeMethodInfoPtr_SendPlayerMessage_Public_Void_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669741);
			MessagingManager.NativeMethodInfoPtr_ReceivePlayerMessage_Private_Void_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669742);
			MessagingManager.NativeMethodInfoPtr_ReceiveMSGConversationData_Private_Void_NetworkConnection_String_MSGConversationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669743);
			MessagingManager.NativeMethodInfoPtr_ClearResponses_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669744);
			MessagingManager.NativeMethodInfoPtr_ReceiveClearResponses_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669745);
			MessagingManager.NativeMethodInfoPtr_ShowResponses_Public_Void_String_List_1_Response_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669746);
			MessagingManager.NativeMethodInfoPtr_ReceiveShowResponses_Private_Void_String_List_1_Response_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669747);
			MessagingManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669748);
			MessagingManager.NativeMethodInfoPtr_Method_Private_Void_NPC_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669749);
			MessagingManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669750);
			MessagingManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669751);
			MessagingManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669752);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_SendMessage_2134336246_Private_Void_Message_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669753);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___SendMessage_2134336246_Public_Void_Message_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669754);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Server_SendMessage_2134336246_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669755);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveMessage_2134336246_Private_Void_Message_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669756);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveMessage_2134336246_Private_Void_Message_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669757);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveMessage_2134336246_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669758);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_SendMessageChain_3949292778_Private_Void_MessageChain_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669759);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___SendMessageChain_3949292778_Public_Void_MessageChain_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669760);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Server_SendMessageChain_3949292778_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669761);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveMessageChain_3949292778_Private_Void_MessageChain_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669762);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveMessageChain_3949292778_Private_Void_MessageChain_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669763);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveMessageChain_3949292778_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669764);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_SendResponse_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669765);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___SendResponse_2801973956_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669766);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Server_SendResponse_2801973956_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669767);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveResponse_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669768);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveResponse_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669769);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveResponse_2801973956_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669770);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerMessage_1952281135_Private_Void_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669771);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___SendPlayerMessage_1952281135_Public_Void_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669772);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Server_SendPlayerMessage_1952281135_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669773);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerMessage_1952281135_Private_Void_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669774);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceivePlayerMessage_1952281135_Private_Void_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669775);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerMessage_1952281135_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669776);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Target_ReceiveMSGConversationData_2662241369_Private_Void_NetworkConnection_String_MSGConversationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669777);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveMSGConversationData_2662241369_Private_Void_NetworkConnection_String_MSGConversationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669778);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Target_ReceiveMSGConversationData_2662241369_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669779);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_ClearResponses_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669780);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___ClearResponses_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669781);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Server_ClearResponses_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669782);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveClearResponses_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669783);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveClearResponses_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669784);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveClearResponses_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669785);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_ShowResponses_995803534_Private_Void_String_List_1_Response_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669786);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___ShowResponses_995803534_Public_Void_String_List_1_Response_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669787);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Server_ShowResponses_995803534_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669788);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveShowResponses_995803534_Private_Void_String_List_1_Response_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669789);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveShowResponses_995803534_Private_Void_String_List_1_Response_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669790);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveShowResponses_995803534_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669791);
			MessagingManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100669792);
		}

		// Token: 0x06003354 RID: 13140 RVA: 0x001256EC File Offset: 0x001238EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137732, XrefRangeEnd = 137735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagingManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003355 RID: 13141 RVA: 0x00125728 File Offset: 0x00123928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137735, XrefRangeEnd = 137775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagingManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x00125778 File Offset: 0x00123978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137775, XrefRangeEnd = 137789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MSGConversation GetConversation(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_GetConversation_Public_MSGConversation_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr3) : null;
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x001257C8 File Offset: 0x001239C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137804, RefRangeEnd = 137805, XrefRangeStart = 137789, XrefRangeEnd = 137804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Register(NPC npc, MSGConversation convs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(convs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_Register_Public_Void_NPC_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x0012581C File Offset: 0x00123A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137805, XrefRangeEnd = 137829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessage(Message m, bool notify, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_SendMessage_Public_Void_Message_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003359 RID: 13145 RVA: 0x00125880 File Offset: 0x00123A80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137853, RefRangeEnd = 137855, XrefRangeStart = 137829, XrefRangeEnd = 137853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveMessage(Message m, bool notify, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_ReceiveMessage_Private_Void_Message_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600335A RID: 13146 RVA: 0x001258E4 File Offset: 0x00123AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137855, XrefRangeEnd = 137880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessageChain(MessageChain m, string npcID, float initialDelay, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDelay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_SendMessageChain_Public_Void_MessageChain_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x00125954 File Offset: 0x00123B54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137905, RefRangeEnd = 137907, XrefRangeStart = 137880, XrefRangeEnd = 137905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveMessageChain(MessageChain m, string npcID, float initialDelay, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDelay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_ReceiveMessageChain_Private_Void_MessageChain_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x001259C4 File Offset: 0x00123BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137907, XrefRangeEnd = 137931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendResponse(int responseIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref responseIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_SendResponse_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x00125A14 File Offset: 0x00123C14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137955, RefRangeEnd = 137957, XrefRangeStart = 137931, XrefRangeEnd = 137955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveResponse(int responseIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref responseIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_ReceiveResponse_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600335E RID: 13150 RVA: 0x00125A64 File Offset: 0x00123C64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137983, RefRangeEnd = 137984, XrefRangeStart = 137957, XrefRangeEnd = 137983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPlayerMessage(int sendableIndex, int sentIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sendableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sentIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_SendPlayerMessage_Public_Void_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600335F RID: 13151 RVA: 0x00125AC4 File Offset: 0x00123CC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138010, RefRangeEnd = 138012, XrefRangeStart = 137984, XrefRangeEnd = 138010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceivePlayerMessage(int sendableIndex, int sentIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sendableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sentIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_ReceivePlayerMessage_Private_Void_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003360 RID: 13152 RVA: 0x00125B24 File Offset: 0x00123D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138012, XrefRangeEnd = 138023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveMSGConversationData(NetworkConnection conn, string npcID, MSGConversationData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_ReceiveMSGConversationData_Private_Void_NetworkConnection_String_MSGConversationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x00125B8C File Offset: 0x00123D8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138033, RefRangeEnd = 138034, XrefRangeStart = 138023, XrefRangeEnd = 138033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearResponses(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_ClearResponses_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x00125BD0 File Offset: 0x00123DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138034, XrefRangeEnd = 138044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveClearResponses(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_ReceiveClearResponses_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x00125C14 File Offset: 0x00123E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138044, XrefRangeEnd = 138068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowResponses(string npcID, List<Response> responses, float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responses);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_ShowResponses_Public_Void_String_List_1_Response_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003364 RID: 13156 RVA: 0x00125C78 File Offset: 0x00123E78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138092, RefRangeEnd = 138094, XrefRangeStart = 138068, XrefRangeEnd = 138092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveShowResponses(string npcID, List<Response> responses, float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responses);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_ReceiveShowResponses_Private_Void_String_List_1_Response_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003365 RID: 13157 RVA: 0x00125CDC File Offset: 0x00123EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138094, XrefRangeEnd = 138104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessagingManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003366 RID: 13158 RVA: 0x00125D18 File Offset: 0x00123F18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138114, RefRangeEnd = 138115, XrefRangeStart = 138104, XrefRangeEnd = 138114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_NPC_NetworkConnection_0(NPC npc, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_Method_Private_Void_NPC_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003367 RID: 13159 RVA: 0x00125D6C File Offset: 0x00123F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138115, XrefRangeEnd = 138198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagingManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x00125DA8 File Offset: 0x00123FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138198, XrefRangeEnd = 138201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagingManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x00125DE4 File Offset: 0x00123FE4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagingManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x00125E20 File Offset: 0x00124020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138201, XrefRangeEnd = 138213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendMessage_2134336246(Message m, bool notify, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_SendMessage_2134336246_Private_Void_Message_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x00125E84 File Offset: 0x00124084
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137853, RefRangeEnd = 137855, XrefRangeStart = 137853, XrefRangeEnd = 137855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendMessage_2134336246(Message m, bool notify, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___SendMessage_2134336246_Public_Void_Message_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x00125EE8 File Offset: 0x001240E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138213, XrefRangeEnd = 138218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendMessage_2134336246(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Server_SendMessage_2134336246_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x00125F4C File Offset: 0x0012414C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138218, XrefRangeEnd = 138230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveMessage_2134336246(Message m, bool notify, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveMessage_2134336246_Private_Void_Message_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600336E RID: 13166 RVA: 0x00125FB0 File Offset: 0x001241B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 138250, RefRangeEnd = 138253, XrefRangeStart = 138230, XrefRangeEnd = 138250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveMessage_2134336246(Message m, bool notify, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveMessage_2134336246_Private_Void_Message_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600336F RID: 13167 RVA: 0x00126014 File Offset: 0x00124214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138253, XrefRangeEnd = 138258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveMessage_2134336246(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveMessage_2134336246_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003370 RID: 13168 RVA: 0x00126064 File Offset: 0x00124264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138258, XrefRangeEnd = 138271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDelay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_SendMessageChain_3949292778_Private_Void_MessageChain_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003371 RID: 13169 RVA: 0x001260D4 File Offset: 0x001242D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137905, RefRangeEnd = 137907, XrefRangeStart = 137905, XrefRangeEnd = 137907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDelay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___SendMessageChain_3949292778_Public_Void_MessageChain_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003372 RID: 13170 RVA: 0x00126144 File Offset: 0x00124344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138271, XrefRangeEnd = 138277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendMessageChain_3949292778(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Server_SendMessageChain_3949292778_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x001261A8 File Offset: 0x001243A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138277, XrefRangeEnd = 138290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDelay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveMessageChain_3949292778_Private_Void_MessageChain_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x00126218 File Offset: 0x00124418
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 138310, RefRangeEnd = 138313, XrefRangeStart = 138290, XrefRangeEnd = 138310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDelay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveMessageChain_3949292778_Private_Void_MessageChain_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x00126288 File Offset: 0x00124488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138313, XrefRangeEnd = 138319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveMessageChain_3949292778(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveMessageChain_3949292778_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x001262D8 File Offset: 0x001244D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138319, XrefRangeEnd = 138331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendResponse_2801973956(int responseIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref responseIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_SendResponse_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003377 RID: 13175 RVA: 0x00126328 File Offset: 0x00124528
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137955, RefRangeEnd = 137957, XrefRangeStart = 137955, XrefRangeEnd = 137957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendResponse_2801973956(int responseIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref responseIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___SendResponse_2801973956_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x00126378 File Offset: 0x00124578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138331, XrefRangeEnd = 138337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendResponse_2801973956(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Server_SendResponse_2801973956_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x001263DC File Offset: 0x001245DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138337, XrefRangeEnd = 138349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveResponse_2801973956(int responseIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref responseIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveResponse_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x0012642C File Offset: 0x0012462C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 138380, RefRangeEnd = 138383, XrefRangeStart = 138349, XrefRangeEnd = 138380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveResponse_2801973956(int responseIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref responseIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveResponse_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x0012647C File Offset: 0x0012467C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138383, XrefRangeEnd = 138389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveResponse_2801973956(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveResponse_2801973956_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x001264CC File Offset: 0x001246CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138389, XrefRangeEnd = 138403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sendableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sentIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerMessage_1952281135_Private_Void_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x0012652C File Offset: 0x0012472C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138010, RefRangeEnd = 138012, XrefRangeStart = 138010, XrefRangeEnd = 138012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sendableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sentIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___SendPlayerMessage_1952281135_Public_Void_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600337E RID: 13182 RVA: 0x0012658C File Offset: 0x0012478C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138403, XrefRangeEnd = 138411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPlayerMessage_1952281135(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Server_SendPlayerMessage_1952281135_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x001265F0 File Offset: 0x001247F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138411, XrefRangeEnd = 138425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceivePlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sendableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sentIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerMessage_1952281135_Private_Void_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003380 RID: 13184 RVA: 0x00126650 File Offset: 0x00124850
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 138445, RefRangeEnd = 138448, XrefRangeStart = 138425, XrefRangeEnd = 138445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceivePlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sendableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sentIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceivePlayerMessage_1952281135_Private_Void_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x001266B0 File Offset: 0x001248B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138448, XrefRangeEnd = 138456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceivePlayerMessage_1952281135(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerMessage_1952281135_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x00126700 File Offset: 0x00124900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveMSGConversationData_2662241369(NetworkConnection conn, string npcID, MSGConversationData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Target_ReceiveMSGConversationData_2662241369_Private_Void_NetworkConnection_String_MSGConversationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x00126768 File Offset: 0x00124968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138456, XrefRangeEnd = 138475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveMSGConversationData_2662241369(NetworkConnection conn, string npcID, MSGConversationData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveMSGConversationData_2662241369_Private_Void_NetworkConnection_String_MSGConversationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x001267D0 File Offset: 0x001249D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138475, XrefRangeEnd = 138492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveMSGConversationData_2662241369(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Target_ReceiveMSGConversationData_2662241369_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x00126820 File Offset: 0x00124A20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138033, RefRangeEnd = 138034, XrefRangeStart = 138033, XrefRangeEnd = 138034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ClearResponses_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_ClearResponses_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003386 RID: 13190 RVA: 0x00126864 File Offset: 0x00124A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ClearResponses_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___ClearResponses_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003387 RID: 13191 RVA: 0x001268A8 File Offset: 0x00124AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138492, XrefRangeEnd = 138504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ClearResponses_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Server_ClearResponses_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003388 RID: 13192 RVA: 0x0012690C File Offset: 0x00124B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveClearResponses_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveClearResponses_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003389 RID: 13193 RVA: 0x00126950 File Offset: 0x00124B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138504, XrefRangeEnd = 138524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveClearResponses_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveClearResponses_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600338A RID: 13194 RVA: 0x00126994 File Offset: 0x00124B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138524, XrefRangeEnd = 138540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveClearResponses_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveClearResponses_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600338B RID: 13195 RVA: 0x001269E4 File Offset: 0x00124BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138540, XrefRangeEnd = 138552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ShowResponses_995803534(string npcID, List<Response> responses, float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responses);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_ShowResponses_995803534_Private_Void_String_List_1_Response_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600338C RID: 13196 RVA: 0x00126A48 File Offset: 0x00124C48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138092, RefRangeEnd = 138094, XrefRangeStart = 138092, XrefRangeEnd = 138094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ShowResponses_995803534(string npcID, List<Response> responses, float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responses);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___ShowResponses_995803534_Public_Void_String_List_1_Response_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600338D RID: 13197 RVA: 0x00126AAC File Offset: 0x00124CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138552, XrefRangeEnd = 138558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ShowResponses_995803534(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Server_ShowResponses_995803534_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600338E RID: 13198 RVA: 0x00126B10 File Offset: 0x00124D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138558, XrefRangeEnd = 138570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveShowResponses_995803534(string npcID, List<Response> responses, float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responses);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveShowResponses_995803534_Private_Void_String_List_1_Response_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600338F RID: 13199 RVA: 0x00126B74 File Offset: 0x00124D74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 138590, RefRangeEnd = 138593, XrefRangeStart = 138570, XrefRangeEnd = 138590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveShowResponses_995803534(string npcID, List<Response> responses, float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responses);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveShowResponses_995803534_Private_Void_String_List_1_Response_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003390 RID: 13200 RVA: 0x00126BD8 File Offset: 0x00124DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138593, XrefRangeEnd = 138599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveShowResponses_995803534(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveShowResponses_995803534_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003391 RID: 13201 RVA: 0x00126C28 File Offset: 0x00124E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138599, XrefRangeEnd = 138602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagingManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003392 RID: 13202 RVA: 0x0001A472 File Offset: 0x00018672
		public MessagingManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x06003393 RID: 13203 RVA: 0x00126C64 File Offset: 0x00124E64
		// (set) Token: 0x06003394 RID: 13204 RVA: 0x0001A47B File Offset: 0x0001867B
		public unsafe Dictionary<NPC, MSGConversation> ConversationMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.NativeFieldInfoPtr_ConversationMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<NPC, MSGConversation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.NativeFieldInfoPtr_ConversationMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x06003395 RID: 13205 RVA: 0x00126C94 File Offset: 0x00124E94
		// (set) Token: 0x06003396 RID: 13206 RVA: 0x0001A49A File Offset: 0x0001869A
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x06003397 RID: 13207 RVA: 0x00126CBC File Offset: 0x00124EBC
		// (set) Token: 0x06003398 RID: 13208 RVA: 0x0001A4B5 File Offset: 0x000186B5
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002241 RID: 8769
		private static readonly IntPtr NativeFieldInfoPtr_ConversationMap;

		// Token: 0x04002242 RID: 8770
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002243 RID: 8771
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002244 RID: 8772
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002245 RID: 8773
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04002246 RID: 8774
		private static readonly IntPtr NativeMethodInfoPtr_GetConversation_Public_MSGConversation_NPC_0;

		// Token: 0x04002247 RID: 8775
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Void_NPC_MSGConversation_0;

		// Token: 0x04002248 RID: 8776
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_Message_Boolean_String_0;

		// Token: 0x04002249 RID: 8777
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMessage_Private_Void_Message_Boolean_String_0;

		// Token: 0x0400224A RID: 8778
		private static readonly IntPtr NativeMethodInfoPtr_SendMessageChain_Public_Void_MessageChain_String_Single_Boolean_0;

		// Token: 0x0400224B RID: 8779
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMessageChain_Private_Void_MessageChain_String_Single_Boolean_0;

		// Token: 0x0400224C RID: 8780
		private static readonly IntPtr NativeMethodInfoPtr_SendResponse_Public_Void_Int32_String_0;

		// Token: 0x0400224D RID: 8781
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveResponse_Private_Void_Int32_String_0;

		// Token: 0x0400224E RID: 8782
		private static readonly IntPtr NativeMethodInfoPtr_SendPlayerMessage_Public_Void_Int32_Int32_String_0;

		// Token: 0x0400224F RID: 8783
		private static readonly IntPtr NativeMethodInfoPtr_ReceivePlayerMessage_Private_Void_Int32_Int32_String_0;

		// Token: 0x04002250 RID: 8784
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMSGConversationData_Private_Void_NetworkConnection_String_MSGConversationData_0;

		// Token: 0x04002251 RID: 8785
		private static readonly IntPtr NativeMethodInfoPtr_ClearResponses_Public_Void_String_0;

		// Token: 0x04002252 RID: 8786
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveClearResponses_Private_Void_String_0;

		// Token: 0x04002253 RID: 8787
		private static readonly IntPtr NativeMethodInfoPtr_ShowResponses_Public_Void_String_List_1_Response_Single_0;

		// Token: 0x04002254 RID: 8788
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveShowResponses_Private_Void_String_List_1_Response_Single_0;

		// Token: 0x04002255 RID: 8789
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002256 RID: 8790
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_NPC_NetworkConnection_0;

		// Token: 0x04002257 RID: 8791
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002258 RID: 8792
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002259 RID: 8793
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400225A RID: 8794
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendMessage_2134336246_Private_Void_Message_Boolean_String_0;

		// Token: 0x0400225B RID: 8795
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendMessage_2134336246_Public_Void_Message_Boolean_String_0;

		// Token: 0x0400225C RID: 8796
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendMessage_2134336246_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400225D RID: 8797
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveMessage_2134336246_Private_Void_Message_Boolean_String_0;

		// Token: 0x0400225E RID: 8798
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveMessage_2134336246_Private_Void_Message_Boolean_String_0;

		// Token: 0x0400225F RID: 8799
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveMessage_2134336246_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002260 RID: 8800
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendMessageChain_3949292778_Private_Void_MessageChain_String_Single_Boolean_0;

		// Token: 0x04002261 RID: 8801
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendMessageChain_3949292778_Public_Void_MessageChain_String_Single_Boolean_0;

		// Token: 0x04002262 RID: 8802
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendMessageChain_3949292778_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002263 RID: 8803
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveMessageChain_3949292778_Private_Void_MessageChain_String_Single_Boolean_0;

		// Token: 0x04002264 RID: 8804
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveMessageChain_3949292778_Private_Void_MessageChain_String_Single_Boolean_0;

		// Token: 0x04002265 RID: 8805
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveMessageChain_3949292778_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002266 RID: 8806
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendResponse_2801973956_Private_Void_Int32_String_0;

		// Token: 0x04002267 RID: 8807
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendResponse_2801973956_Public_Void_Int32_String_0;

		// Token: 0x04002268 RID: 8808
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendResponse_2801973956_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002269 RID: 8809
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveResponse_2801973956_Private_Void_Int32_String_0;

		// Token: 0x0400226A RID: 8810
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveResponse_2801973956_Private_Void_Int32_String_0;

		// Token: 0x0400226B RID: 8811
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveResponse_2801973956_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400226C RID: 8812
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPlayerMessage_1952281135_Private_Void_Int32_Int32_String_0;

		// Token: 0x0400226D RID: 8813
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendPlayerMessage_1952281135_Public_Void_Int32_Int32_String_0;

		// Token: 0x0400226E RID: 8814
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPlayerMessage_1952281135_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400226F RID: 8815
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerMessage_1952281135_Private_Void_Int32_Int32_String_0;

		// Token: 0x04002270 RID: 8816
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceivePlayerMessage_1952281135_Private_Void_Int32_Int32_String_0;

		// Token: 0x04002271 RID: 8817
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerMessage_1952281135_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002272 RID: 8818
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveMSGConversationData_2662241369_Private_Void_NetworkConnection_String_MSGConversationData_0;

		// Token: 0x04002273 RID: 8819
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveMSGConversationData_2662241369_Private_Void_NetworkConnection_String_MSGConversationData_0;

		// Token: 0x04002274 RID: 8820
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveMSGConversationData_2662241369_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002275 RID: 8821
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ClearResponses_3615296227_Private_Void_String_0;

		// Token: 0x04002276 RID: 8822
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ClearResponses_3615296227_Public_Void_String_0;

		// Token: 0x04002277 RID: 8823
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ClearResponses_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002278 RID: 8824
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveClearResponses_3615296227_Private_Void_String_0;

		// Token: 0x04002279 RID: 8825
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveClearResponses_3615296227_Private_Void_String_0;

		// Token: 0x0400227A RID: 8826
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveClearResponses_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400227B RID: 8827
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ShowResponses_995803534_Private_Void_String_List_1_Response_Single_0;

		// Token: 0x0400227C RID: 8828
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ShowResponses_995803534_Public_Void_String_List_1_Response_Single_0;

		// Token: 0x0400227D RID: 8829
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ShowResponses_995803534_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400227E RID: 8830
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveShowResponses_995803534_Private_Void_String_List_1_Response_Single_0;

		// Token: 0x0400227F RID: 8831
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveShowResponses_995803534_Private_Void_String_List_1_Response_Single_0;

		// Token: 0x04002280 RID: 8832
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveShowResponses_995803534_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002281 RID: 8833
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A00 RID: 2560
		[ObfuscatedName("ScheduleOne.Messaging.MessagingManager+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600DD5A RID: 56666 RVA: 0x0036A610 File Offset: 0x00368810
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0>.NativeClassPtr);
				MessagingManager.__c__DisplayClass2_0.NativeFieldInfoPtr_npcCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0>.NativeClassPtr, "npcCache");
				MessagingManager.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
				MessagingManager.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0>.NativeClassPtr, 100669793);
				MessagingManager.__c__DisplayClass2_0.NativeMethodInfoPtr__OnSpawnServer_b__1_Internal_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0>.NativeClassPtr, 100669794);
			}

			// Token: 0x0600DD5B RID: 56667 RVA: 0x0036A68C File Offset: 0x0036888C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD5C RID: 56668 RVA: 0x0036A6C8 File Offset: 0x003688C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137702, XrefRangeEnd = 137704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnSpawnServer_b__1(NetworkConnection conn)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.__c__DisplayClass2_0.NativeMethodInfoPtr__OnSpawnServer_b__1_Internal_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD5D RID: 56669 RVA: 0x00068310 File Offset: 0x00066510
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004368 RID: 17256
			// (get) Token: 0x0600DD5E RID: 56670 RVA: 0x0036A70C File Offset: 0x0036890C
			// (set) Token: 0x0600DD5F RID: 56671 RVA: 0x00068319 File Offset: 0x00066519
			public unsafe NPC npcCache
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_0.NativeFieldInfoPtr_npcCache);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_0.NativeFieldInfoPtr_npcCache), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004369 RID: 17257
			// (get) Token: 0x0600DD60 RID: 56672 RVA: 0x0036A73C File Offset: 0x0036893C
			// (set) Token: 0x0600DD61 RID: 56673 RVA: 0x00068338 File Offset: 0x00066538
			public unsafe MessagingManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessagingManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096E9 RID: 38633
			private static readonly IntPtr NativeFieldInfoPtr_npcCache;

			// Token: 0x040096EA RID: 38634
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040096EB RID: 38635
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096EC RID: 38636
			private static readonly IntPtr NativeMethodInfoPtr__OnSpawnServer_b__1_Internal_Void_NetworkConnection_0;
		}

		// Token: 0x02000A01 RID: 2561
		[ObfuscatedName("ScheduleOne.Messaging.MessagingManager+<>c__DisplayClass2_1")]
		public sealed class __c__DisplayClass2_1 : Object
		{
			// Token: 0x0600DD62 RID: 56674 RVA: 0x0036A76C File Offset: 0x0036896C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_1()
			{
				Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, "<>c__DisplayClass2_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_1>.NativeClassPtr);
				MessagingManager.__c__DisplayClass2_1.NativeFieldInfoPtr_conn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_1>.NativeClassPtr, "conn");
				MessagingManager.__c__DisplayClass2_1.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_1>.NativeClassPtr, "npc");
				MessagingManager.__c__DisplayClass2_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_1>.NativeClassPtr, "<>4__this");
				MessagingManager.__c__DisplayClass2_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_1>.NativeClassPtr, 100669795);
				MessagingManager.__c__DisplayClass2_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_1>.NativeClassPtr, 100669796);
				MessagingManager.__c__DisplayClass2_1.NativeMethodInfoPtr__OnSpawnServer_b__3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_1>.NativeClassPtr, 100669797);
			}

			// Token: 0x0600DD63 RID: 56675 RVA: 0x0036A810 File Offset: 0x00368A10
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.__c__DisplayClass2_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD64 RID: 56676 RVA: 0x0036A84C File Offset: 0x00368A4C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137726, RefRangeEnd = 137727, XrefRangeStart = 137721, XrefRangeEnd = 137726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.__c__DisplayClass2_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DD65 RID: 56677 RVA: 0x0036A88C File Offset: 0x00368A8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137727, XrefRangeEnd = 137732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnSpawnServer_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.__c__DisplayClass2_1.NativeMethodInfoPtr__OnSpawnServer_b__3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD66 RID: 56678 RVA: 0x00068357 File Offset: 0x00066557
			public __c__DisplayClass2_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700436A RID: 17258
			// (get) Token: 0x0600DD67 RID: 56679 RVA: 0x0036A8C8 File Offset: 0x00368AC8
			// (set) Token: 0x0600DD68 RID: 56680 RVA: 0x00068360 File Offset: 0x00066560
			public unsafe NetworkConnection conn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_1.NativeFieldInfoPtr_conn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_1.NativeFieldInfoPtr_conn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700436B RID: 17259
			// (get) Token: 0x0600DD69 RID: 56681 RVA: 0x0036A8F8 File Offset: 0x00368AF8
			// (set) Token: 0x0600DD6A RID: 56682 RVA: 0x0006837F File Offset: 0x0006657F
			public unsafe NPC npc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_1.NativeFieldInfoPtr_npc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_1.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700436C RID: 17260
			// (get) Token: 0x0600DD6B RID: 56683 RVA: 0x0036A928 File Offset: 0x00368B28
			// (set) Token: 0x0600DD6C RID: 56684 RVA: 0x0006839E File Offset: 0x0006659E
			public unsafe MessagingManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessagingManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096ED RID: 38637
			private static readonly IntPtr NativeFieldInfoPtr_conn;

			// Token: 0x040096EE RID: 38638
			private static readonly IntPtr NativeFieldInfoPtr_npc;

			// Token: 0x040096EF RID: 38639
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040096F0 RID: 38640
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096F1 RID: 38641
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x040096F2 RID: 38642
			private static readonly IntPtr NativeMethodInfoPtr__OnSpawnServer_b__3_Internal_Boolean_0;

			// Token: 0x02000DBF RID: 3519
			[ObfuscatedName("ScheduleOne.Messaging.MessagingManager+<>c__DisplayClass2_1+<<OnSpawnServer>g__SendMessages|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Object
			{
				// Token: 0x0600FE43 RID: 65091 RVA: 0x003C8258 File Offset: 0x003C6458
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_1>.NativeClassPtr, "<<OnSpawnServer>g__SendMessages|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669798);
					MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669799);
					MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669800);
					MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669801);
					MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669802);
					MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669803);
				}

				// Token: 0x0600FE44 RID: 65092 RVA: 0x003C8338 File Offset: 0x003C6538
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FE45 RID: 65093 RVA: 0x003C8380 File Offset: 0x003C6580
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FE46 RID: 65094 RVA: 0x003C83B4 File Offset: 0x003C65B4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137704, XrefRangeEnd = 137716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004D59 RID: 19801
				// (get) Token: 0x0600FE47 RID: 65095 RVA: 0x003C83F0 File Offset: 0x003C65F0
				public unsafe Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FE48 RID: 65096 RVA: 0x003C8430 File Offset: 0x003C6630
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137716, XrefRangeEnd = 137721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004D5A RID: 19802
				// (get) Token: 0x0600FE49 RID: 65097 RVA: 0x003C8464 File Offset: 0x003C6664
				public unsafe Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FE4A RID: 65098 RVA: 0x00078790 File Offset: 0x00076990
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004D56 RID: 19798
				// (get) Token: 0x0600FE4B RID: 65099 RVA: 0x003C84A4 File Offset: 0x003C66A4
				// (set) Token: 0x0600FE4C RID: 65100 RVA: 0x00078799 File Offset: 0x00076999
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004D57 RID: 19799
				// (get) Token: 0x0600FE4D RID: 65101 RVA: 0x003C84CC File Offset: 0x003C66CC
				// (set) Token: 0x0600FE4E RID: 65102 RVA: 0x000787B4 File Offset: 0x000769B4
				public unsafe Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D58 RID: 19800
				// (get) Token: 0x0600FE4F RID: 65103 RVA: 0x003C84FC File Offset: 0x003C66FC
				// (set) Token: 0x0600FE50 RID: 65104 RVA: 0x000787D3 File Offset: 0x000769D3
				public unsafe MessagingManager.__c__DisplayClass2_1 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessagingManager.__c__DisplayClass2_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AB60 RID: 43872
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AB61 RID: 43873
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AB62 RID: 43874
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AB63 RID: 43875
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AB64 RID: 43876
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB65 RID: 43877
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AB66 RID: 43878
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AB67 RID: 43879
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AB68 RID: 43880
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
