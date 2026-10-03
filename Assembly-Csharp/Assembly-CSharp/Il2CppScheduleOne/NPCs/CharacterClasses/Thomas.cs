using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Messaging;
using Il2CppScheduleOne.UI.Phone.Messages;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x0200064B RID: 1611
	public class Thomas : NPC
	{
		// Token: 0x060099CA RID: 39370 RVA: 0x00292DC4 File Offset: 0x00290FC4
		// Note: this type is marked as 'beforefieldinit'.
		static Thomas()
		{
			Il2CppClassPointerStore<Thomas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Thomas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Thomas>.NativeClassPtr);
			Thomas.NativeFieldInfoPtr_MessagingIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "MessagingIcon");
			Thomas.NativeFieldInfoPtr_onMeetingEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "onMeetingEnded");
			Thomas.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.ThomasAssembly-CSharp.dll_Excuted");
			Thomas.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.ThomasAssembly-CSharp.dll_Excuted");
			Thomas.NativeMethodInfoPtr_GetMessagingIcon_Public_Virtual_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100683316);
			Thomas.NativeMethodInfoPtr_SendIntroMessage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100683317);
			Thomas.NativeMethodInfoPtr_MeetingEnded_Server_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100683318);
			Thomas.NativeMethodInfoPtr_MeetingEnded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100683319);
			Thomas.NativeMethodInfoPtr_CreateMessageConversation_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100683320);
			Thomas.NativeMethodInfoPtr_CancelAgreement_Server_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100683321);
			Thomas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100683322);
			Thomas.NativeMethodInfoPtr_Method_Internal_Static_Boolean_SendableMessage_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100683323);
			Thomas.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100683324);
			Thomas.NativeMethodInfoPtr_Method_Private_Void_EResponse_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100683325);
			Thomas.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100683326);
			Thomas.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100683327);
			Thomas.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100683328);
			Thomas.NativeMethodInfoPtr_RpcWriter___Server_MeetingEnded_Server_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100683329);
			Thomas.NativeMethodInfoPtr_RpcLogic___MeetingEnded_Server_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100683330);
			Thomas.NativeMethodInfoPtr_RpcReader___Server_MeetingEnded_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100683331);
			Thomas.NativeMethodInfoPtr_RpcWriter___Observers_MeetingEnded_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100683332);
			Thomas.NativeMethodInfoPtr_RpcLogic___MeetingEnded_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100683333);
			Thomas.NativeMethodInfoPtr_RpcReader___Observers_MeetingEnded_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100683334);
			Thomas.NativeMethodInfoPtr_RpcWriter___Server_CancelAgreement_Server_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100683335);
			Thomas.NativeMethodInfoPtr_RpcLogic___CancelAgreement_Server_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100683336);
			Thomas.NativeMethodInfoPtr_RpcReader___Server_CancelAgreement_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100683337);
			Thomas.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100683338);
		}

		// Token: 0x060099CB RID: 39371 RVA: 0x00293010 File Offset: 0x00291210
		[CallerCount(0)]
		public unsafe override Sprite GetMessagingIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_GetMessagingIcon_Public_Virtual_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x060099CC RID: 39372 RVA: 0x0029305C File Offset: 0x0029125C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274207, RefRangeEnd = 274208, XrefRangeStart = 274199, XrefRangeEnd = 274207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendIntroMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_SendIntroMessage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099CD RID: 39373 RVA: 0x00293090 File Offset: 0x00291290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274208, XrefRangeEnd = 274217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MeetingEnded_Server()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_MeetingEnded_Server_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099CE RID: 39374 RVA: 0x002930C4 File Offset: 0x002912C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274217, XrefRangeEnd = 274226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MeetingEnded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_MeetingEnded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099CF RID: 39375 RVA: 0x002930F8 File Offset: 0x002912F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274226, XrefRangeEnd = 274251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CreateMessageConversation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_CreateMessageConversation_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099D0 RID: 39376 RVA: 0x00293134 File Offset: 0x00291334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274251, XrefRangeEnd = 274260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelAgreement_Server()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_CancelAgreement_Server_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099D1 RID: 39377 RVA: 0x00293168 File Offset: 0x00291368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Thomas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Thomas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099D2 RID: 39378 RVA: 0x002931A4 File Offset: 0x002913A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274260, XrefRangeEnd = 274264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_SendableMessage_PDM_0(SendableMessage msg)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_Method_Internal_Static_Boolean_SendableMessage_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060099D3 RID: 39379 RVA: 0x002931E8 File Offset: 0x002913E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274264, XrefRangeEnd = 274279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099D4 RID: 39380 RVA: 0x0029321C File Offset: 0x0029141C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274279, XrefRangeEnd = 274295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_EResponse_PDM_0(ConfirmationPopup.EResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref response;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_Method_Private_Void_EResponse_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099D5 RID: 39381 RVA: 0x0029325C File Offset: 0x0029145C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274295, XrefRangeEnd = 274316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099D6 RID: 39382 RVA: 0x00293298 File Offset: 0x00291498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099D7 RID: 39383 RVA: 0x002932D4 File Offset: 0x002914D4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099D8 RID: 39384 RVA: 0x00293310 File Offset: 0x00291510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_MeetingEnded_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_RpcWriter___Server_MeetingEnded_Server_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099D9 RID: 39385 RVA: 0x00293344 File Offset: 0x00291544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___MeetingEnded_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_RpcLogic___MeetingEnded_Server_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099DA RID: 39386 RVA: 0x00293378 File Offset: 0x00291578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274316, XrefRangeEnd = 274326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_MeetingEnded_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_RpcReader___Server_MeetingEnded_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099DB RID: 39387 RVA: 0x002933DC File Offset: 0x002915DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_MeetingEnded_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_RpcWriter___Observers_MeetingEnded_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099DC RID: 39388 RVA: 0x00293410 File Offset: 0x00291610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274326, XrefRangeEnd = 274327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___MeetingEnded_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_RpcLogic___MeetingEnded_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099DD RID: 39389 RVA: 0x00293444 File Offset: 0x00291644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274327, XrefRangeEnd = 274329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_MeetingEnded_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_RpcReader___Observers_MeetingEnded_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099DE RID: 39390 RVA: 0x00293494 File Offset: 0x00291694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_CancelAgreement_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_RpcWriter___Server_CancelAgreement_Server_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099DF RID: 39391 RVA: 0x002934C8 File Offset: 0x002916C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274329, XrefRangeEnd = 274339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CancelAgreement_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_RpcLogic___CancelAgreement_Server_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099E0 RID: 39392 RVA: 0x002934FC File Offset: 0x002916FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274339, XrefRangeEnd = 274350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_CancelAgreement_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_RpcReader___Server_CancelAgreement_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099E1 RID: 39393 RVA: 0x00293560 File Offset: 0x00291760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099E2 RID: 39394 RVA: 0x00047AC4 File Offset: 0x00045CC4
		public Thomas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F16 RID: 12054
		// (get) Token: 0x060099E3 RID: 39395 RVA: 0x0029359C File Offset: 0x0029179C
		// (set) Token: 0x060099E4 RID: 39396 RVA: 0x00047ACD File Offset: 0x00045CCD
		public unsafe Sprite MessagingIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_MessagingIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_MessagingIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F17 RID: 12055
		// (get) Token: 0x060099E5 RID: 39397 RVA: 0x002935CC File Offset: 0x002917CC
		// (set) Token: 0x060099E6 RID: 39398 RVA: 0x00047AEC File Offset: 0x00045CEC
		public unsafe UnityEvent onMeetingEnded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_onMeetingEnded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_onMeetingEnded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F18 RID: 12056
		// (get) Token: 0x060099E7 RID: 39399 RVA: 0x002935FC File Offset: 0x002917FC
		// (set) Token: 0x060099E8 RID: 39400 RVA: 0x00047B0B File Offset: 0x00045D0B
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002F19 RID: 12057
		// (get) Token: 0x060099E9 RID: 39401 RVA: 0x00293624 File Offset: 0x00291824
		// (set) Token: 0x060099EA RID: 39402 RVA: 0x00047B26 File Offset: 0x00045D26
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040069A9 RID: 27049
		private static readonly IntPtr NativeFieldInfoPtr_MessagingIcon;

		// Token: 0x040069AA RID: 27050
		private static readonly IntPtr NativeFieldInfoPtr_onMeetingEnded;

		// Token: 0x040069AB RID: 27051
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040069AC RID: 27052
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040069AD RID: 27053
		private static readonly IntPtr NativeMethodInfoPtr_GetMessagingIcon_Public_Virtual_Sprite_0;

		// Token: 0x040069AE RID: 27054
		private static readonly IntPtr NativeMethodInfoPtr_SendIntroMessage_Public_Void_0;

		// Token: 0x040069AF RID: 27055
		private static readonly IntPtr NativeMethodInfoPtr_MeetingEnded_Server_Public_Void_0;

		// Token: 0x040069B0 RID: 27056
		private static readonly IntPtr NativeMethodInfoPtr_MeetingEnded_Private_Void_0;

		// Token: 0x040069B1 RID: 27057
		private static readonly IntPtr NativeMethodInfoPtr_CreateMessageConversation_Protected_Virtual_Void_0;

		// Token: 0x040069B2 RID: 27058
		private static readonly IntPtr NativeMethodInfoPtr_CancelAgreement_Server_Private_Void_0;

		// Token: 0x040069B3 RID: 27059
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040069B4 RID: 27060
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_SendableMessage_PDM_0;

		// Token: 0x040069B5 RID: 27061
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x040069B6 RID: 27062
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_EResponse_PDM_0;

		// Token: 0x040069B7 RID: 27063
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040069B8 RID: 27064
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040069B9 RID: 27065
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040069BA RID: 27066
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_MeetingEnded_Server_2166136261_Private_Void_0;

		// Token: 0x040069BB RID: 27067
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___MeetingEnded_Server_2166136261_Public_Void_0;

		// Token: 0x040069BC RID: 27068
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_MeetingEnded_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040069BD RID: 27069
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_MeetingEnded_2166136261_Private_Void_0;

		// Token: 0x040069BE RID: 27070
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___MeetingEnded_2166136261_Private_Void_0;

		// Token: 0x040069BF RID: 27071
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_MeetingEnded_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040069C0 RID: 27072
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_CancelAgreement_Server_2166136261_Private_Void_0;

		// Token: 0x040069C1 RID: 27073
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CancelAgreement_Server_2166136261_Private_Void_0;

		// Token: 0x040069C2 RID: 27074
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_CancelAgreement_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040069C3 RID: 27075
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
