using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Messaging;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Framework;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppScheduleOne.NPCs.Schedules;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI.Phone;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200039D RID: 925
	public class Supplier : NPC
	{
		// Token: 0x06005390 RID: 21392 RVA: 0x0019C6B8 File Offset: 0x0019A8B8
		// Note: this type is marked as 'beforefieldinit'.
		static Supplier()
		{
			Il2CppClassPointerStore<Supplier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "Supplier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Supplier>.NativeClassPtr);
			Supplier.NativeFieldInfoPtr_MeetupRelationshipRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "MeetupRelationshipRequirement");
			Supplier.NativeFieldInfoPtr_MeetupDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "MeetupDuration");
			Supplier.NativeFieldInfoPtr_MeetupCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "MeetupCooldown");
			Supplier.NativeFieldInfoPtr_DeaddropWaitPerItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "DeaddropWaitPerItem");
			Supplier.NativeFieldInfoPtr_DeaddropMaxWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "DeaddropMaxWait");
			Supplier.NativeFieldInfoPtr_DeaddropItemLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "DeaddropItemLimit");
			Supplier.NativeFieldInfoPtr_MeetingEndDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "MeetingEndDistance");
			Supplier.NativeFieldInfoPtr_DeliveryRelationshipRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "DeliveryRelationshipRequirement");
			Supplier.NativeFieldInfoPtr_SupplierLabelColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "SupplierLabelColor");
			Supplier.NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<Status>k__BackingField");
			Supplier.NativeFieldInfoPtr__DeliveriesEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<DeliveriesEnabled>k__BackingField");
			Supplier.NativeFieldInfoPtr__MinsUntilDeaddropReady_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<MinsUntilDeaddropReady>k__BackingField");
			Supplier.NativeFieldInfoPtr_Shop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "Shop");
			Supplier.NativeFieldInfoPtr_Stash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "Stash");
			Supplier.NativeFieldInfoPtr_OnDeaddropReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "OnDeaddropReady");
			Supplier.NativeFieldInfoPtr__debt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "_debt");
			Supplier.NativeFieldInfoPtr__deadDropPreparing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "_deadDropPreparing");
			Supplier.NativeFieldInfoPtr__deaddropItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "_deaddropItems");
			Supplier.NativeFieldInfoPtr__minsSinceDeaddropOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "_minsSinceDeaddropOrder");
			Supplier.NativeFieldInfoPtr__repaymentReminderSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "_repaymentReminderSent");
			Supplier.NativeFieldInfoPtr__minsSinceMeetingStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "_minsSinceMeetingStart");
			Supplier.NativeFieldInfoPtr__minsSinceLastMeetingEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "_minsSinceLastMeetingEnd");
			Supplier.NativeFieldInfoPtr__playerSpendSinceMeetingStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "_playerSpendSinceMeetingStart");
			Supplier.NativeFieldInfoPtr__meetingAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "_meetingAction");
			Supplier.NativeFieldInfoPtr__currentLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "_currentLocation");
			Supplier.NativeFieldInfoPtr_syncVar____debt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "syncVar____debt");
			Supplier.NativeFieldInfoPtr_syncVar____deadDropPreparing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "syncVar____deadDropPreparing");
			Supplier.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Economy.SupplierAssembly-CSharp.dll_Excuted");
			Supplier.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Economy.SupplierAssembly-CSharp.dll_Excuted");
			Supplier.NativeMethodInfoPtr_get_Status_Public_get_ESupplierStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674261);
			Supplier.NativeMethodInfoPtr_set_Status_Private_set_Void_ESupplierStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674262);
			Supplier.NativeMethodInfoPtr_get_DeliveriesEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674263);
			Supplier.NativeMethodInfoPtr_set_DeliveriesEnabled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674264);
			Supplier.NativeMethodInfoPtr_get_Debt_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674265);
			Supplier.NativeMethodInfoPtr_get_MinsUntilDeaddropReady_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674266);
			Supplier.NativeMethodInfoPtr_set_MinsUntilDeaddropReady_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674267);
			Supplier.NativeMethodInfoPtr_get_SupplierData_Public_get_SupplierNPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674268);
			Supplier.NativeMethodInfoPtr_add_OnDeaddropReady_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674269);
			Supplier.NativeMethodInfoPtr_remove_OnDeaddropReady_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674270);
			Supplier.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674271);
			Supplier.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674272);
			Supplier.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674273);
			Supplier.NativeMethodInfoPtr_SendUnlocked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674274);
			Supplier.NativeMethodInfoPtr_SetUnlocked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674275);
			Supplier.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674276);
			Supplier.NativeMethodInfoPtr_OnTick_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674277);
			Supplier.NativeMethodInfoPtr_HourPass_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674278);
			Supplier.NativeMethodInfoPtr_OnTimeSkip_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674279);
			Supplier.NativeMethodInfoPtr_MeetAtLocation_Public_Void_NetworkConnection_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674280);
			Supplier.NativeMethodInfoPtr_EndMeeting_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674281);
			Supplier.NativeMethodInfoPtr_SupplierUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674282);
			Supplier.NativeMethodInfoPtr_RelationshipChange_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674283);
			Supplier.NativeMethodInfoPtr_EnableDeliveries_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674284);
			Supplier.NativeMethodInfoPtr_SendUnlockMessage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674285);
			Supplier.NativeMethodInfoPtr_CreateMessageConversation_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674286);
			Supplier.NativeMethodInfoPtr_DeaddropRequested_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674287);
			Supplier.NativeMethodInfoPtr_DeaddropConfirmed_Protected_Virtual_New_Void_List_1_CartEntry_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674288);
			Supplier.NativeMethodInfoPtr_SetDeaddrop_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674289);
			Supplier.NativeMethodInfoPtr_ChangeDebt_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674290);
			Supplier.NativeMethodInfoPtr_TryRecoverDebt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674291);
			Supplier.NativeMethodInfoPtr_CompleteDeaddrop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674292);
			Supplier.NativeMethodInfoPtr_SendDebtReminder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674293);
			Supplier.NativeMethodInfoPtr_MeetupRequested_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674294);
			Supplier.NativeMethodInfoPtr_PayDebtRequested_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674295);
			Supplier.NativeMethodInfoPtr_GetAppropriateLocation_Protected_SupplierLocation_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674296);
			Supplier.NativeMethodInfoPtr_IsDeadDropValid_Private_Boolean_SendableMessage_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674297);
			Supplier.NativeMethodInfoPtr_IsMeetupValid_Private_Boolean_SendableMessage_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674298);
			Supplier.NativeMethodInfoPtr_GetDeadDropLimit_Public_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674299);
			Supplier.NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674300);
			Supplier.NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674301);
			Supplier.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674302);
			Supplier.NativeMethodInfoPtr_MeetupOrderCompleted_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674303);
			Supplier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674304);
			Supplier.NativeMethodInfoPtr__Start_b__42_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674306);
			Supplier.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674307);
			Supplier.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674308);
			Supplier.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674309);
			Supplier.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674310);
			Supplier.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674311);
			Supplier.NativeMethodInfoPtr_RpcWriter___Server_SendUnlocked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674312);
			Supplier.NativeMethodInfoPtr_RpcLogic___SendUnlocked_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674313);
			Supplier.NativeMethodInfoPtr_RpcReader___Server_SendUnlocked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674314);
			Supplier.NativeMethodInfoPtr_RpcWriter___Observers_SetUnlocked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674315);
			Supplier.NativeMethodInfoPtr_RpcLogic___SetUnlocked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674316);
			Supplier.NativeMethodInfoPtr_RpcReader___Observers_SetUnlocked_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674317);
			Supplier.NativeMethodInfoPtr_RpcWriter___Observers_MeetAtLocation_3470796954_Private_Void_NetworkConnection_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674318);
			Supplier.NativeMethodInfoPtr_RpcLogic___MeetAtLocation_3470796954_Public_Void_NetworkConnection_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674319);
			Supplier.NativeMethodInfoPtr_RpcReader___Observers_MeetAtLocation_3470796954_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674320);
			Supplier.NativeMethodInfoPtr_RpcWriter___Observers_EnableDeliveries_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674321);
			Supplier.NativeMethodInfoPtr_RpcLogic___EnableDeliveries_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674322);
			Supplier.NativeMethodInfoPtr_RpcReader___Observers_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674323);
			Supplier.NativeMethodInfoPtr_RpcWriter___Target_EnableDeliveries_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674324);
			Supplier.NativeMethodInfoPtr_RpcReader___Target_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674325);
			Supplier.NativeMethodInfoPtr_RpcWriter___Server_SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674326);
			Supplier.NativeMethodInfoPtr_RpcLogic___SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674327);
			Supplier.NativeMethodInfoPtr_RpcReader___Server_SetDeaddrop_3971994486_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674328);
			Supplier.NativeMethodInfoPtr_RpcWriter___Server_ChangeDebt_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674329);
			Supplier.NativeMethodInfoPtr_RpcLogic___ChangeDebt_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674330);
			Supplier.NativeMethodInfoPtr_RpcReader___Server_ChangeDebt_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674331);
			Supplier.NativeMethodInfoPtr_sync___get_value__debt_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674332);
			Supplier.NativeMethodInfoPtr_sync___set_value__debt_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674333);
			Supplier.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Supplier_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674334);
			Supplier.NativeMethodInfoPtr_sync___get_value__deadDropPreparing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674335);
			Supplier.NativeMethodInfoPtr_sync___set_value__deadDropPreparing_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674336);
			Supplier.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674337);
		}

		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x06005391 RID: 21393 RVA: 0x0019CF1C File Offset: 0x0019B11C
		// (set) Token: 0x06005392 RID: 21394 RVA: 0x0019CF58 File Offset: 0x0019B158
		public unsafe Supplier.ESupplierStatus Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_get_Status_Public_get_ESupplierStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_set_Status_Private_set_Void_ESupplierStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x06005393 RID: 21395 RVA: 0x0019CF98 File Offset: 0x0019B198
		// (set) Token: 0x06005394 RID: 21396 RVA: 0x0019CFD4 File Offset: 0x0019B1D4
		public unsafe bool DeliveriesEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_get_DeliveriesEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_set_DeliveriesEnabled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A08 RID: 6664
		// (get) Token: 0x06005395 RID: 21397 RVA: 0x0019D014 File Offset: 0x0019B214
		public unsafe float Debt
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 186607, RefRangeEnd = 186611, XrefRangeStart = 186607, XrefRangeEnd = 186607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_get_Debt_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x06005396 RID: 21398 RVA: 0x0019D050 File Offset: 0x0019B250
		// (set) Token: 0x06005397 RID: 21399 RVA: 0x0019D08C File Offset: 0x0019B28C
		public unsafe int MinsUntilDeaddropReady
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_get_MinsUntilDeaddropReady_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_set_MinsUntilDeaddropReady_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x06005398 RID: 21400 RVA: 0x0019D0CC File Offset: 0x0019B2CC
		public unsafe SupplierNPCData SupplierData
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 186613, RefRangeEnd = 186622, XrefRangeStart = 186611, XrefRangeEnd = 186613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_get_SupplierData_Public_get_SupplierNPCData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SupplierNPCData>(intPtr3) : null;
			}
		}

		// Token: 0x06005399 RID: 21401 RVA: 0x0019D10C File Offset: 0x0019B30C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186626, RefRangeEnd = 186627, XrefRangeStart = 186622, XrefRangeEnd = 186626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnDeaddropReady(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_add_OnDeaddropReady_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600539A RID: 21402 RVA: 0x0019D150 File Offset: 0x0019B350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186627, XrefRangeEnd = 186631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnDeaddropReady(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_remove_OnDeaddropReady_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600539B RID: 21403 RVA: 0x0019D194 File Offset: 0x0019B394
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 186632, RefRangeEnd = 186636, XrefRangeStart = 186631, XrefRangeEnd = 186632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600539C RID: 21404 RVA: 0x0019D1D0 File Offset: 0x0019B3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186636, XrefRangeEnd = 186773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600539D RID: 21405 RVA: 0x0019D20C File Offset: 0x0019B40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186773, XrefRangeEnd = 186784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600539E RID: 21406 RVA: 0x0019D25C File Offset: 0x0019B45C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186793, RefRangeEnd = 186794, XrefRangeStart = 186784, XrefRangeEnd = 186793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendUnlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_SendUnlocked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600539F RID: 21407 RVA: 0x0019D290 File Offset: 0x0019B490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186794, XrefRangeEnd = 186803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUnlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_SetUnlocked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053A0 RID: 21408 RVA: 0x0019D2C4 File Offset: 0x0019B4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186803, XrefRangeEnd = 186819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053A1 RID: 21409 RVA: 0x0019D300 File Offset: 0x0019B500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186819, XrefRangeEnd = 186823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_OnTick_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053A2 RID: 21410 RVA: 0x0019D33C File Offset: 0x0019B53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186823, XrefRangeEnd = 186843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_HourPass_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053A3 RID: 21411 RVA: 0x0019D370 File Offset: 0x0019B570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186843, XrefRangeEnd = 186844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTimeSkip(int minsSlept)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minsSlept;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_OnTimeSkip_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053A4 RID: 21412 RVA: 0x0019D3B0 File Offset: 0x0019B5B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 186870, RefRangeEnd = 186872, XrefRangeStart = 186844, XrefRangeEnd = 186870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MeetAtLocation(NetworkConnection conn, int locationIndex, int expireIn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locationIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expireIn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_MeetAtLocation_Public_Void_NetworkConnection_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053A5 RID: 21413 RVA: 0x0019D410 File Offset: 0x0019B610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186872, XrefRangeEnd = 186882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndMeeting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_EndMeeting_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053A6 RID: 21414 RVA: 0x0019D444 File Offset: 0x0019B644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186895, RefRangeEnd = 186896, XrefRangeStart = 186882, XrefRangeEnd = 186895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SupplierUnlocked(NPCRelationData.EUnlockType type, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_SupplierUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053A7 RID: 21415 RVA: 0x0019D49C File Offset: 0x0019B69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186896, XrefRangeEnd = 186923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RelationshipChange(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_RelationshipChange_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053A8 RID: 21416 RVA: 0x0019D4E8 File Offset: 0x0019B6E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 186960, RefRangeEnd = 186962, XrefRangeStart = 186923, XrefRangeEnd = 186960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableDeliveries(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_EnableDeliveries_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053A9 RID: 21417 RVA: 0x0019D52C File Offset: 0x0019B72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186962, XrefRangeEnd = 186968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendUnlockMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_SendUnlockMessage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053AA RID: 21418 RVA: 0x0019D560 File Offset: 0x0019B760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187031, RefRangeEnd = 187032, XrefRangeStart = 186968, XrefRangeEnd = 187031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CreateMessageConversation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_CreateMessageConversation_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053AB RID: 21419 RVA: 0x0019D59C File Offset: 0x0019B79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187032, XrefRangeEnd = 187051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeaddropRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_DeaddropRequested_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053AC RID: 21420 RVA: 0x0019D5D8 File Offset: 0x0019B7D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187182, RefRangeEnd = 187183, XrefRangeStart = 187051, XrefRangeEnd = 187182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeaddropConfirmed(List<PhoneShopInterface.CartEntry> cart, float totalPrice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cart);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalPrice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_DeaddropConfirmed_Protected_Virtual_New_Void_List_1_CartEntry_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053AD RID: 21421 RVA: 0x0019D634 File Offset: 0x0019B834
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 187195, RefRangeEnd = 187197, XrefRangeStart = 187183, XrefRangeEnd = 187195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDeaddrop(Il2CppReferenceArray<StringIntPair> items, int minsUntilReady)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minsUntilReady;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_SetDeaddrop_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053AE RID: 21422 RVA: 0x0019D684 File Offset: 0x0019B884
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 187219, RefRangeEnd = 187221, XrefRangeStart = 187197, XrefRangeEnd = 187219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeDebt(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_ChangeDebt_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053AF RID: 21423 RVA: 0x0019D6C4 File Offset: 0x0019B8C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187267, RefRangeEnd = 187268, XrefRangeStart = 187221, XrefRangeEnd = 187267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryRecoverDebt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_TryRecoverDebt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053B0 RID: 21424 RVA: 0x0019D6F8 File Offset: 0x0019B8F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187348, RefRangeEnd = 187349, XrefRangeStart = 187268, XrefRangeEnd = 187348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteDeaddrop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_CompleteDeaddrop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053B1 RID: 21425 RVA: 0x0019D72C File Offset: 0x0019B92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187349, XrefRangeEnd = 187367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDebtReminder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_SendDebtReminder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053B2 RID: 21426 RVA: 0x0019D760 File Offset: 0x0019B960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187367, XrefRangeEnd = 187385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MeetupRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_MeetupRequested_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053B3 RID: 21427 RVA: 0x0019D79C File Offset: 0x0019B99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187385, XrefRangeEnd = 187400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PayDebtRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_PayDebtRequested_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053B4 RID: 21428 RVA: 0x0019D7D8 File Offset: 0x0019B9D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187482, RefRangeEnd = 187483, XrefRangeStart = 187400, XrefRangeEnd = 187482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupplierLocation GetAppropriateLocation(out int locationIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &locationIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_GetAppropriateLocation_Protected_SupplierLocation_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SupplierLocation>(intPtr3) : null;
		}

		// Token: 0x060053B5 RID: 21429 RVA: 0x0019D824 File Offset: 0x0019BA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187483, XrefRangeEnd = 187487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDeadDropValid(SendableMessage message, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_IsDeadDropValid_Private_Boolean_SendableMessage_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060053B6 RID: 21430 RVA: 0x0019D88C File Offset: 0x0019BA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187487, XrefRangeEnd = 187493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMeetupValid(SendableMessage message, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_IsMeetupValid_Private_Boolean_SendableMessage_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060053B7 RID: 21431 RVA: 0x0019D8F4 File Offset: 0x0019BAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187493, XrefRangeEnd = 187496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetDeadDropLimit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_GetDeadDropLimit_Public_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060053B8 RID: 21432 RVA: 0x0019D93C File Offset: 0x0019BB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187496, XrefRangeEnd = 187501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppScheduleOne.Persistence.Datas.NPCData GetNPCData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.Persistence.Datas.NPCData>(intPtr3) : null;
		}

		// Token: 0x060053B9 RID: 21433 RVA: 0x0019D988 File Offset: 0x0019BB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187501, XrefRangeEnd = 187528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(Il2CppScheduleOne.Persistence.Datas.NPCData data, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053BA RID: 21434 RVA: 0x0019D9E8 File Offset: 0x0019BBE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187528, XrefRangeEnd = 187550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(DynamicSaveData dynamicData, Il2CppScheduleOne.Persistence.Datas.NPCData npcData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dynamicData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_NPCData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053BB RID: 21435 RVA: 0x0019DA48 File Offset: 0x0019BC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187550, XrefRangeEnd = 187563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MeetupOrderCompleted(float spend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref spend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_MeetupOrderCompleted_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053BC RID: 21436 RVA: 0x0019DA88 File Offset: 0x0019BC88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 187564, RefRangeEnd = 187568, XrefRangeStart = 187563, XrefRangeEnd = 187564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Supplier() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Supplier>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053BD RID: 21437 RVA: 0x0019DAC4 File Offset: 0x0019BCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187568, XrefRangeEnd = 187570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__42_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr__Start_b__42_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053BE RID: 21438 RVA: 0x0019DAF8 File Offset: 0x0019BCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187570, XrefRangeEnd = 187575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060053BF RID: 21439 RVA: 0x0019DB38 File Offset: 0x0019BD38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187575, XrefRangeEnd = 187580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060053C0 RID: 21440 RVA: 0x0019DB78 File Offset: 0x0019BD78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 187650, RefRangeEnd = 187654, XrefRangeStart = 187580, XrefRangeEnd = 187650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053C1 RID: 21441 RVA: 0x0019DBB4 File Offset: 0x0019BDB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 187655, RefRangeEnd = 187659, XrefRangeStart = 187654, XrefRangeEnd = 187655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053C2 RID: 21442 RVA: 0x0019DBF0 File Offset: 0x0019BDF0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053C3 RID: 21443 RVA: 0x0019DC2C File Offset: 0x0019BE2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186793, RefRangeEnd = 186794, XrefRangeStart = 186793, XrefRangeEnd = 186794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendUnlocked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Server_SendUnlocked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053C4 RID: 21444 RVA: 0x0019DC60 File Offset: 0x0019BE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendUnlocked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___SendUnlocked_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053C5 RID: 21445 RVA: 0x0019DC94 File Offset: 0x0019BE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187659, XrefRangeEnd = 187669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendUnlocked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Server_SendUnlocked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053C6 RID: 21446 RVA: 0x0019DCF8 File Offset: 0x0019BEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetUnlocked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Observers_SetUnlocked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053C7 RID: 21447 RVA: 0x0019DD2C File Offset: 0x0019BF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187669, XrefRangeEnd = 187670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetUnlocked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___SetUnlocked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053C8 RID: 21448 RVA: 0x0019DD60 File Offset: 0x0019BF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187670, XrefRangeEnd = 187671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetUnlocked_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Observers_SetUnlocked_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053C9 RID: 21449 RVA: 0x0019DDB0 File Offset: 0x0019BFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187671, XrefRangeEnd = 187685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_MeetAtLocation_3470796954(NetworkConnection conn, int locationIndex, int expireIn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locationIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expireIn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Observers_MeetAtLocation_3470796954_Private_Void_NetworkConnection_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053CA RID: 21450 RVA: 0x0019DE10 File Offset: 0x0019C010
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 187734, RefRangeEnd = 187736, XrefRangeStart = 187685, XrefRangeEnd = 187734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___MeetAtLocation_3470796954(NetworkConnection conn, int locationIndex, int expireIn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locationIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expireIn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___MeetAtLocation_3470796954_Public_Void_NetworkConnection_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053CB RID: 21451 RVA: 0x0019DE70 File Offset: 0x0019C070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187736, XrefRangeEnd = 187744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_MeetAtLocation_3470796954(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Observers_MeetAtLocation_3470796954_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053CC RID: 21452 RVA: 0x0019DEC0 File Offset: 0x0019C0C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187744, XrefRangeEnd = 187753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EnableDeliveries_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Observers_EnableDeliveries_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053CD RID: 21453 RVA: 0x0019DF04 File Offset: 0x0019C104
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 187764, RefRangeEnd = 187767, XrefRangeStart = 187753, XrefRangeEnd = 187764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___EnableDeliveries_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___EnableDeliveries_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053CE RID: 21454 RVA: 0x0019DF48 File Offset: 0x0019C148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187767, XrefRangeEnd = 187770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EnableDeliveries_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Observers_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053CF RID: 21455 RVA: 0x0019DF98 File Offset: 0x0019C198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187770, XrefRangeEnd = 187779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_EnableDeliveries_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Target_EnableDeliveries_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053D0 RID: 21456 RVA: 0x0019DFDC File Offset: 0x0019C1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187779, XrefRangeEnd = 187782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_EnableDeliveries_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Target_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053D1 RID: 21457 RVA: 0x0019E02C File Offset: 0x0019C22C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 187195, RefRangeEnd = 187197, XrefRangeStart = 187195, XrefRangeEnd = 187197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetDeaddrop_3971994486(Il2CppReferenceArray<StringIntPair> items, int minsUntilReady)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minsUntilReady;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Server_SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053D2 RID: 21458 RVA: 0x0019E07C File Offset: 0x0019C27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187782, XrefRangeEnd = 187798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetDeaddrop_3971994486(Il2CppReferenceArray<StringIntPair> items, int minsUntilReady)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minsUntilReady;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053D3 RID: 21459 RVA: 0x0019E0CC File Offset: 0x0019C2CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187798, XrefRangeEnd = 187816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetDeaddrop_3971994486(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Server_SetDeaddrop_3971994486_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053D4 RID: 21460 RVA: 0x0019E130 File Offset: 0x0019C330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187816, XrefRangeEnd = 187826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ChangeDebt_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Server_ChangeDebt_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053D5 RID: 21461 RVA: 0x0019E170 File Offset: 0x0019C370
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 187834, RefRangeEnd = 187836, XrefRangeStart = 187826, XrefRangeEnd = 187834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ChangeDebt_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___ChangeDebt_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053D6 RID: 21462 RVA: 0x0019E1B0 File Offset: 0x0019C3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187836, XrefRangeEnd = 187840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ChangeDebt_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Server_ChangeDebt_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x060053D7 RID: 21463 RVA: 0x0019E214 File Offset: 0x0019C414
		// (set) Token: 0x060053D8 RID: 21464 RVA: 0x0019E250 File Offset: 0x0019C450
		public unsafe float SyncAccessor__debt
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 186607, RefRangeEnd = 186611, XrefRangeStart = 186607, XrefRangeEnd = 186611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_sync___get_value__debt_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187840, XrefRangeEnd = 187848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_sync___set_value__debt_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060053D9 RID: 21465 RVA: 0x0019E29C File Offset: 0x0019C49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187848, XrefRangeEnd = 187850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Economy_Supplier(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Supplier_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x060053DA RID: 21466 RVA: 0x0019E310 File Offset: 0x0019C510
		// (set) Token: 0x060053DB RID: 21467 RVA: 0x0019E34C File Offset: 0x0019C54C
		public unsafe bool SyncAccessor__deadDropPreparing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_sync___get_value__deadDropPreparing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187850, XrefRangeEnd = 187858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_sync___set_value__deadDropPreparing_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060053DC RID: 21468 RVA: 0x0019E398 File Offset: 0x0019C598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187858, XrefRangeEnd = 187859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053DD RID: 21469 RVA: 0x000278C9 File Offset: 0x00025AC9
		public Supplier(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019E9 RID: 6633
		// (get) Token: 0x060053DE RID: 21470 RVA: 0x0019E3D4 File Offset: 0x0019C5D4
		// (set) Token: 0x060053DF RID: 21471 RVA: 0x000278D2 File Offset: 0x00025AD2
		public unsafe static float MeetupRelationshipRequirement
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_MeetupRelationshipRequirement, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_MeetupRelationshipRequirement, (void*)(&value));
			}
		}

		// Token: 0x170019EA RID: 6634
		// (get) Token: 0x060053E0 RID: 21472 RVA: 0x0019E3F0 File Offset: 0x0019C5F0
		// (set) Token: 0x060053E1 RID: 21473 RVA: 0x000278E0 File Offset: 0x00025AE0
		public unsafe static int MeetupDuration
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_MeetupDuration, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_MeetupDuration, (void*)(&value));
			}
		}

		// Token: 0x170019EB RID: 6635
		// (get) Token: 0x060053E2 RID: 21474 RVA: 0x0019E40C File Offset: 0x0019C60C
		// (set) Token: 0x060053E3 RID: 21475 RVA: 0x000278EE File Offset: 0x00025AEE
		public unsafe static int MeetupCooldown
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_MeetupCooldown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_MeetupCooldown, (void*)(&value));
			}
		}

		// Token: 0x170019EC RID: 6636
		// (get) Token: 0x060053E4 RID: 21476 RVA: 0x0019E428 File Offset: 0x0019C628
		// (set) Token: 0x060053E5 RID: 21477 RVA: 0x000278FC File Offset: 0x00025AFC
		public unsafe static int DeaddropWaitPerItem
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_DeaddropWaitPerItem, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_DeaddropWaitPerItem, (void*)(&value));
			}
		}

		// Token: 0x170019ED RID: 6637
		// (get) Token: 0x060053E6 RID: 21478 RVA: 0x0019E444 File Offset: 0x0019C644
		// (set) Token: 0x060053E7 RID: 21479 RVA: 0x0002790A File Offset: 0x00025B0A
		public unsafe static int DeaddropMaxWait
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_DeaddropMaxWait, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_DeaddropMaxWait, (void*)(&value));
			}
		}

		// Token: 0x170019EE RID: 6638
		// (get) Token: 0x060053E8 RID: 21480 RVA: 0x0019E460 File Offset: 0x0019C660
		// (set) Token: 0x060053E9 RID: 21481 RVA: 0x00027918 File Offset: 0x00025B18
		public unsafe static int DeaddropItemLimit
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_DeaddropItemLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_DeaddropItemLimit, (void*)(&value));
			}
		}

		// Token: 0x170019EF RID: 6639
		// (get) Token: 0x060053EA RID: 21482 RVA: 0x0019E47C File Offset: 0x0019C67C
		// (set) Token: 0x060053EB RID: 21483 RVA: 0x00027926 File Offset: 0x00025B26
		public unsafe static float MeetingEndDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_MeetingEndDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_MeetingEndDistance, (void*)(&value));
			}
		}

		// Token: 0x170019F0 RID: 6640
		// (get) Token: 0x060053EC RID: 21484 RVA: 0x0019E498 File Offset: 0x0019C698
		// (set) Token: 0x060053ED RID: 21485 RVA: 0x00027934 File Offset: 0x00025B34
		public unsafe static float DeliveryRelationshipRequirement
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_DeliveryRelationshipRequirement, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_DeliveryRelationshipRequirement, (void*)(&value));
			}
		}

		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x060053EE RID: 21486 RVA: 0x0019E4B4 File Offset: 0x0019C6B4
		// (set) Token: 0x060053EF RID: 21487 RVA: 0x00027942 File Offset: 0x00025B42
		public unsafe static Color32 SupplierLabelColor
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_SupplierLabelColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_SupplierLabelColor, (void*)(&value));
			}
		}

		// Token: 0x170019F2 RID: 6642
		// (get) Token: 0x060053F0 RID: 21488 RVA: 0x0019E4D0 File Offset: 0x0019C6D0
		// (set) Token: 0x060053F1 RID: 21489 RVA: 0x00027950 File Offset: 0x00025B50
		public unsafe Supplier.ESupplierStatus _Status_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__Status_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__Status_k__BackingField)) = value;
			}
		}

		// Token: 0x170019F3 RID: 6643
		// (get) Token: 0x060053F2 RID: 21490 RVA: 0x0019E4F8 File Offset: 0x0019C6F8
		// (set) Token: 0x060053F3 RID: 21491 RVA: 0x0002796B File Offset: 0x00025B6B
		public unsafe bool _DeliveriesEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__DeliveriesEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__DeliveriesEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x170019F4 RID: 6644
		// (get) Token: 0x060053F4 RID: 21492 RVA: 0x0019E520 File Offset: 0x0019C720
		// (set) Token: 0x060053F5 RID: 21493 RVA: 0x00027986 File Offset: 0x00025B86
		public unsafe int _MinsUntilDeaddropReady_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__MinsUntilDeaddropReady_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__MinsUntilDeaddropReady_k__BackingField)) = value;
			}
		}

		// Token: 0x170019F5 RID: 6645
		// (get) Token: 0x060053F6 RID: 21494 RVA: 0x0019E548 File Offset: 0x0019C748
		// (set) Token: 0x060053F7 RID: 21495 RVA: 0x000279A1 File Offset: 0x00025BA1
		public unsafe ShopInterface Shop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_Shop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_Shop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019F6 RID: 6646
		// (get) Token: 0x060053F8 RID: 21496 RVA: 0x0019E578 File Offset: 0x0019C778
		// (set) Token: 0x060053F9 RID: 21497 RVA: 0x000279C0 File Offset: 0x00025BC0
		public unsafe SupplierStash Stash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_Stash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SupplierStash>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_Stash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019F7 RID: 6647
		// (get) Token: 0x060053FA RID: 21498 RVA: 0x0019E5A8 File Offset: 0x0019C7A8
		// (set) Token: 0x060053FB RID: 21499 RVA: 0x000279DF File Offset: 0x00025BDF
		public unsafe Action OnDeaddropReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_OnDeaddropReady);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_OnDeaddropReady), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019F8 RID: 6648
		// (get) Token: 0x060053FC RID: 21500 RVA: 0x0019E5D8 File Offset: 0x0019C7D8
		// (set) Token: 0x060053FD RID: 21501 RVA: 0x000279FE File Offset: 0x00025BFE
		public unsafe float _debt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__debt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__debt)) = value;
			}
		}

		// Token: 0x170019F9 RID: 6649
		// (get) Token: 0x060053FE RID: 21502 RVA: 0x0019E600 File Offset: 0x0019C800
		// (set) Token: 0x060053FF RID: 21503 RVA: 0x00027A19 File Offset: 0x00025C19
		public unsafe bool _deadDropPreparing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__deadDropPreparing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__deadDropPreparing)) = value;
			}
		}

		// Token: 0x170019FA RID: 6650
		// (get) Token: 0x06005400 RID: 21504 RVA: 0x0019E628 File Offset: 0x0019C828
		// (set) Token: 0x06005401 RID: 21505 RVA: 0x00027A34 File Offset: 0x00025C34
		public unsafe Il2CppReferenceArray<StringIntPair> _deaddropItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__deaddropItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringIntPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__deaddropItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019FB RID: 6651
		// (get) Token: 0x06005402 RID: 21506 RVA: 0x0019E658 File Offset: 0x0019C858
		// (set) Token: 0x06005403 RID: 21507 RVA: 0x00027A53 File Offset: 0x00025C53
		public unsafe int _minsSinceDeaddropOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__minsSinceDeaddropOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__minsSinceDeaddropOrder)) = value;
			}
		}

		// Token: 0x170019FC RID: 6652
		// (get) Token: 0x06005404 RID: 21508 RVA: 0x0019E680 File Offset: 0x0019C880
		// (set) Token: 0x06005405 RID: 21509 RVA: 0x00027A6E File Offset: 0x00025C6E
		public unsafe bool _repaymentReminderSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__repaymentReminderSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__repaymentReminderSent)) = value;
			}
		}

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x06005406 RID: 21510 RVA: 0x0019E6A8 File Offset: 0x0019C8A8
		// (set) Token: 0x06005407 RID: 21511 RVA: 0x00027A89 File Offset: 0x00025C89
		public unsafe int _minsSinceMeetingStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__minsSinceMeetingStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__minsSinceMeetingStart)) = value;
			}
		}

		// Token: 0x170019FE RID: 6654
		// (get) Token: 0x06005408 RID: 21512 RVA: 0x0019E6D0 File Offset: 0x0019C8D0
		// (set) Token: 0x06005409 RID: 21513 RVA: 0x00027AA4 File Offset: 0x00025CA4
		public unsafe int _minsSinceLastMeetingEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__minsSinceLastMeetingEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__minsSinceLastMeetingEnd)) = value;
			}
		}

		// Token: 0x170019FF RID: 6655
		// (get) Token: 0x0600540A RID: 21514 RVA: 0x0019E6F8 File Offset: 0x0019C8F8
		// (set) Token: 0x0600540B RID: 21515 RVA: 0x00027ABF File Offset: 0x00025CBF
		public unsafe float _playerSpendSinceMeetingStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__playerSpendSinceMeetingStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__playerSpendSinceMeetingStart)) = value;
			}
		}

		// Token: 0x17001A00 RID: 6656
		// (get) Token: 0x0600540C RID: 21516 RVA: 0x0019E720 File Offset: 0x0019C920
		// (set) Token: 0x0600540D RID: 21517 RVA: 0x00027ADA File Offset: 0x00025CDA
		public unsafe NPCEvent_LocationDialogue _meetingAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__meetingAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEvent_LocationDialogue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__meetingAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A01 RID: 6657
		// (get) Token: 0x0600540E RID: 21518 RVA: 0x0019E750 File Offset: 0x0019C950
		// (set) Token: 0x0600540F RID: 21519 RVA: 0x00027AF9 File Offset: 0x00025CF9
		public unsafe SupplierLocation _currentLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__currentLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SupplierLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__currentLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A02 RID: 6658
		// (get) Token: 0x06005410 RID: 21520 RVA: 0x0019E780 File Offset: 0x0019C980
		// (set) Token: 0x06005411 RID: 21521 RVA: 0x00027B18 File Offset: 0x00025D18
		public unsafe SyncVar<float> syncVar____debt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_syncVar____debt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_syncVar____debt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A03 RID: 6659
		// (get) Token: 0x06005412 RID: 21522 RVA: 0x0019E7B0 File Offset: 0x0019C9B0
		// (set) Token: 0x06005413 RID: 21523 RVA: 0x00027B37 File Offset: 0x00025D37
		public unsafe SyncVar<bool> syncVar____deadDropPreparing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_syncVar____deadDropPreparing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_syncVar____deadDropPreparing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A04 RID: 6660
		// (get) Token: 0x06005414 RID: 21524 RVA: 0x0019E7E0 File Offset: 0x0019C9E0
		// (set) Token: 0x06005415 RID: 21525 RVA: 0x00027B56 File Offset: 0x00025D56
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001A05 RID: 6661
		// (get) Token: 0x06005416 RID: 21526 RVA: 0x0019E808 File Offset: 0x0019CA08
		// (set) Token: 0x06005417 RID: 21527 RVA: 0x00027B71 File Offset: 0x00025D71
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400398F RID: 14735
		private static readonly IntPtr NativeFieldInfoPtr_MeetupRelationshipRequirement;

		// Token: 0x04003990 RID: 14736
		private static readonly IntPtr NativeFieldInfoPtr_MeetupDuration;

		// Token: 0x04003991 RID: 14737
		private static readonly IntPtr NativeFieldInfoPtr_MeetupCooldown;

		// Token: 0x04003992 RID: 14738
		private static readonly IntPtr NativeFieldInfoPtr_DeaddropWaitPerItem;

		// Token: 0x04003993 RID: 14739
		private static readonly IntPtr NativeFieldInfoPtr_DeaddropMaxWait;

		// Token: 0x04003994 RID: 14740
		private static readonly IntPtr NativeFieldInfoPtr_DeaddropItemLimit;

		// Token: 0x04003995 RID: 14741
		private static readonly IntPtr NativeFieldInfoPtr_MeetingEndDistance;

		// Token: 0x04003996 RID: 14742
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryRelationshipRequirement;

		// Token: 0x04003997 RID: 14743
		private static readonly IntPtr NativeFieldInfoPtr_SupplierLabelColor;

		// Token: 0x04003998 RID: 14744
		private static readonly IntPtr NativeFieldInfoPtr__Status_k__BackingField;

		// Token: 0x04003999 RID: 14745
		private static readonly IntPtr NativeFieldInfoPtr__DeliveriesEnabled_k__BackingField;

		// Token: 0x0400399A RID: 14746
		private static readonly IntPtr NativeFieldInfoPtr__MinsUntilDeaddropReady_k__BackingField;

		// Token: 0x0400399B RID: 14747
		private static readonly IntPtr NativeFieldInfoPtr_Shop;

		// Token: 0x0400399C RID: 14748
		private static readonly IntPtr NativeFieldInfoPtr_Stash;

		// Token: 0x0400399D RID: 14749
		private static readonly IntPtr NativeFieldInfoPtr_OnDeaddropReady;

		// Token: 0x0400399E RID: 14750
		private static readonly IntPtr NativeFieldInfoPtr__debt;

		// Token: 0x0400399F RID: 14751
		private static readonly IntPtr NativeFieldInfoPtr__deadDropPreparing;

		// Token: 0x040039A0 RID: 14752
		private static readonly IntPtr NativeFieldInfoPtr__deaddropItems;

		// Token: 0x040039A1 RID: 14753
		private static readonly IntPtr NativeFieldInfoPtr__minsSinceDeaddropOrder;

		// Token: 0x040039A2 RID: 14754
		private static readonly IntPtr NativeFieldInfoPtr__repaymentReminderSent;

		// Token: 0x040039A3 RID: 14755
		private static readonly IntPtr NativeFieldInfoPtr__minsSinceMeetingStart;

		// Token: 0x040039A4 RID: 14756
		private static readonly IntPtr NativeFieldInfoPtr__minsSinceLastMeetingEnd;

		// Token: 0x040039A5 RID: 14757
		private static readonly IntPtr NativeFieldInfoPtr__playerSpendSinceMeetingStart;

		// Token: 0x040039A6 RID: 14758
		private static readonly IntPtr NativeFieldInfoPtr__meetingAction;

		// Token: 0x040039A7 RID: 14759
		private static readonly IntPtr NativeFieldInfoPtr__currentLocation;

		// Token: 0x040039A8 RID: 14760
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____debt;

		// Token: 0x040039A9 RID: 14761
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____deadDropPreparing;

		// Token: 0x040039AA RID: 14762
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040039AB RID: 14763
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040039AC RID: 14764
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_ESupplierStatus_0;

		// Token: 0x040039AD RID: 14765
		private static readonly IntPtr NativeMethodInfoPtr_set_Status_Private_set_Void_ESupplierStatus_0;

		// Token: 0x040039AE RID: 14766
		private static readonly IntPtr NativeMethodInfoPtr_get_DeliveriesEnabled_Public_get_Boolean_0;

		// Token: 0x040039AF RID: 14767
		private static readonly IntPtr NativeMethodInfoPtr_set_DeliveriesEnabled_Private_set_Void_Boolean_0;

		// Token: 0x040039B0 RID: 14768
		private static readonly IntPtr NativeMethodInfoPtr_get_Debt_Public_get_Single_0;

		// Token: 0x040039B1 RID: 14769
		private static readonly IntPtr NativeMethodInfoPtr_get_MinsUntilDeaddropReady_Public_get_Int32_0;

		// Token: 0x040039B2 RID: 14770
		private static readonly IntPtr NativeMethodInfoPtr_set_MinsUntilDeaddropReady_Private_set_Void_Int32_0;

		// Token: 0x040039B3 RID: 14771
		private static readonly IntPtr NativeMethodInfoPtr_get_SupplierData_Public_get_SupplierNPCData_0;

		// Token: 0x040039B4 RID: 14772
		private static readonly IntPtr NativeMethodInfoPtr_add_OnDeaddropReady_Public_add_Void_Action_0;

		// Token: 0x040039B5 RID: 14773
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnDeaddropReady_Public_rem_Void_Action_0;

		// Token: 0x040039B6 RID: 14774
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040039B7 RID: 14775
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x040039B8 RID: 14776
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040039B9 RID: 14777
		private static readonly IntPtr NativeMethodInfoPtr_SendUnlocked_Public_Void_0;

		// Token: 0x040039BA RID: 14778
		private static readonly IntPtr NativeMethodInfoPtr_SetUnlocked_Private_Void_0;

		// Token: 0x040039BB RID: 14779
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1;

		// Token: 0x040039BC RID: 14780
		private static readonly IntPtr NativeMethodInfoPtr_OnTick_Protected_Virtual_Void_1;

		// Token: 0x040039BD RID: 14781
		private static readonly IntPtr NativeMethodInfoPtr_HourPass_Protected_Void_0;

		// Token: 0x040039BE RID: 14782
		private static readonly IntPtr NativeMethodInfoPtr_OnTimeSkip_Private_Void_Int32_0;

		// Token: 0x040039BF RID: 14783
		private static readonly IntPtr NativeMethodInfoPtr_MeetAtLocation_Public_Void_NetworkConnection_Int32_Int32_0;

		// Token: 0x040039C0 RID: 14784
		private static readonly IntPtr NativeMethodInfoPtr_EndMeeting_Public_Void_0;

		// Token: 0x040039C1 RID: 14785
		private static readonly IntPtr NativeMethodInfoPtr_SupplierUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0;

		// Token: 0x040039C2 RID: 14786
		private static readonly IntPtr NativeMethodInfoPtr_RelationshipChange_Protected_Virtual_New_Void_Single_0;

		// Token: 0x040039C3 RID: 14787
		private static readonly IntPtr NativeMethodInfoPtr_EnableDeliveries_Private_Void_NetworkConnection_0;

		// Token: 0x040039C4 RID: 14788
		private static readonly IntPtr NativeMethodInfoPtr_SendUnlockMessage_Private_Void_0;

		// Token: 0x040039C5 RID: 14789
		private static readonly IntPtr NativeMethodInfoPtr_CreateMessageConversation_Protected_Virtual_Void_1;

		// Token: 0x040039C6 RID: 14790
		private static readonly IntPtr NativeMethodInfoPtr_DeaddropRequested_Protected_Virtual_New_Void_0;

		// Token: 0x040039C7 RID: 14791
		private static readonly IntPtr NativeMethodInfoPtr_DeaddropConfirmed_Protected_Virtual_New_Void_List_1_CartEntry_Single_0;

		// Token: 0x040039C8 RID: 14792
		private static readonly IntPtr NativeMethodInfoPtr_SetDeaddrop_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0;

		// Token: 0x040039C9 RID: 14793
		private static readonly IntPtr NativeMethodInfoPtr_ChangeDebt_Private_Void_Single_0;

		// Token: 0x040039CA RID: 14794
		private static readonly IntPtr NativeMethodInfoPtr_TryRecoverDebt_Private_Void_0;

		// Token: 0x040039CB RID: 14795
		private static readonly IntPtr NativeMethodInfoPtr_CompleteDeaddrop_Private_Void_0;

		// Token: 0x040039CC RID: 14796
		private static readonly IntPtr NativeMethodInfoPtr_SendDebtReminder_Private_Void_0;

		// Token: 0x040039CD RID: 14797
		private static readonly IntPtr NativeMethodInfoPtr_MeetupRequested_Protected_Virtual_New_Void_0;

		// Token: 0x040039CE RID: 14798
		private static readonly IntPtr NativeMethodInfoPtr_PayDebtRequested_Protected_Virtual_New_Void_0;

		// Token: 0x040039CF RID: 14799
		private static readonly IntPtr NativeMethodInfoPtr_GetAppropriateLocation_Protected_SupplierLocation_byref_Int32_0;

		// Token: 0x040039D0 RID: 14800
		private static readonly IntPtr NativeMethodInfoPtr_IsDeadDropValid_Private_Boolean_SendableMessage_byref_String_0;

		// Token: 0x040039D1 RID: 14801
		private static readonly IntPtr NativeMethodInfoPtr_IsMeetupValid_Private_Boolean_SendableMessage_byref_String_0;

		// Token: 0x040039D2 RID: 14802
		private static readonly IntPtr NativeMethodInfoPtr_GetDeadDropLimit_Public_Virtual_New_Single_0;

		// Token: 0x040039D3 RID: 14803
		private static readonly IntPtr NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0;

		// Token: 0x040039D4 RID: 14804
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0;

		// Token: 0x040039D5 RID: 14805
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_NPCData_0;

		// Token: 0x040039D6 RID: 14806
		private static readonly IntPtr NativeMethodInfoPtr_MeetupOrderCompleted_Private_Void_Single_0;

		// Token: 0x040039D7 RID: 14807
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040039D8 RID: 14808
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__42_1_Private_Void_0;

		// Token: 0x040039D9 RID: 14809
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x040039DA RID: 14810
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x040039DB RID: 14811
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040039DC RID: 14812
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040039DD RID: 14813
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040039DE RID: 14814
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendUnlocked_2166136261_Private_Void_0;

		// Token: 0x040039DF RID: 14815
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendUnlocked_2166136261_Public_Void_0;

		// Token: 0x040039E0 RID: 14816
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendUnlocked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040039E1 RID: 14817
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetUnlocked_2166136261_Private_Void_0;

		// Token: 0x040039E2 RID: 14818
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetUnlocked_2166136261_Private_Void_0;

		// Token: 0x040039E3 RID: 14819
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetUnlocked_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040039E4 RID: 14820
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_MeetAtLocation_3470796954_Private_Void_NetworkConnection_Int32_Int32_0;

		// Token: 0x040039E5 RID: 14821
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___MeetAtLocation_3470796954_Public_Void_NetworkConnection_Int32_Int32_0;

		// Token: 0x040039E6 RID: 14822
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_MeetAtLocation_3470796954_Private_Void_PooledReader_Channel_0;

		// Token: 0x040039E7 RID: 14823
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EnableDeliveries_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040039E8 RID: 14824
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EnableDeliveries_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040039E9 RID: 14825
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040039EA RID: 14826
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_EnableDeliveries_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040039EB RID: 14827
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040039EC RID: 14828
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0;

		// Token: 0x040039ED RID: 14829
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0;

		// Token: 0x040039EE RID: 14830
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetDeaddrop_3971994486_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040039EF RID: 14831
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ChangeDebt_431000436_Private_Void_Single_0;

		// Token: 0x040039F0 RID: 14832
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ChangeDebt_431000436_Private_Void_Single_0;

		// Token: 0x040039F1 RID: 14833
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ChangeDebt_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040039F2 RID: 14834
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__debt_Public_get_Single_0;

		// Token: 0x040039F3 RID: 14835
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__debt_Public_set_Void_Single_Boolean_0;

		// Token: 0x040039F4 RID: 14836
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Supplier_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x040039F5 RID: 14837
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__deadDropPreparing_Public_get_Boolean_0;

		// Token: 0x040039F6 RID: 14838
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__deadDropPreparing_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x040039F7 RID: 14839
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000AB1 RID: 2737
		[OriginalName("Assembly-CSharp.dll", "", "ESupplierStatus")]
		public enum ESupplierStatus
		{
			// Token: 0x04009A69 RID: 39529
			Idle,
			// Token: 0x04009A6A RID: 39530
			PreppingDeadDrop,
			// Token: 0x04009A6B RID: 39531
			Meeting
		}

		// Token: 0x02000AB2 RID: 2738
		[ObfuscatedName("ScheduleOne.Economy.Supplier+<<EnableDeliveries>g__Wait|54_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600E327 RID: 58151 RVA: 0x0037A744 File Offset: 0x00378944
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<<EnableDeliveries>g__Wait|54_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100674338);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100674339);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100674340);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100674341);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100674342);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100674343);
			}

			// Token: 0x0600E328 RID: 58152 RVA: 0x0037A824 File Offset: 0x00378A24
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E329 RID: 58153 RVA: 0x0037A86C File Offset: 0x00378A6C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E32A RID: 58154 RVA: 0x0037A8A0 File Offset: 0x00378AA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186543, XrefRangeEnd = 186564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004519 RID: 17689
			// (get) Token: 0x0600E32B RID: 58155 RVA: 0x0037A8DC File Offset: 0x00378ADC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E32C RID: 58156 RVA: 0x0037A91C File Offset: 0x00378B1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186564, XrefRangeEnd = 186569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700451A RID: 17690
			// (get) Token: 0x0600E32D RID: 58157 RVA: 0x0037A950 File Offset: 0x00378B50
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E32E RID: 58158 RVA: 0x0006B1A8 File Offset: 0x000693A8
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004516 RID: 17686
			// (get) Token: 0x0600E32F RID: 58159 RVA: 0x0037A990 File Offset: 0x00378B90
			// (set) Token: 0x0600E330 RID: 58160 RVA: 0x0006B1B1 File Offset: 0x000693B1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004517 RID: 17687
			// (get) Token: 0x0600E331 RID: 58161 RVA: 0x0037A9B8 File Offset: 0x00378BB8
			// (set) Token: 0x0600E332 RID: 58162 RVA: 0x0006B1CC File Offset: 0x000693CC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004518 RID: 17688
			// (get) Token: 0x0600E333 RID: 58163 RVA: 0x0037A9E8 File Offset: 0x00378BE8
			// (set) Token: 0x0600E334 RID: 58164 RVA: 0x0006B1EB File Offset: 0x000693EB
			public unsafe Supplier __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A6C RID: 39532
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009A6D RID: 39533
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009A6E RID: 39534
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009A6F RID: 39535
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009A70 RID: 39536
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009A71 RID: 39537
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009A72 RID: 39538
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009A73 RID: 39539
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009A74 RID: 39540
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AB3 RID: 2739
		[ObfuscatedName("ScheduleOne.Economy.Supplier+<<SupplierUnlocked>g__WaitForPlayer|52_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600E335 RID: 58165 RVA: 0x0037AA18 File Offset: 0x00378C18
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<<SupplierUnlocked>g__WaitForPlayer|52_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100674344);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100674345);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100674346);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100674347);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100674348);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100674349);
			}

			// Token: 0x0600E336 RID: 58166 RVA: 0x0037AAF8 File Offset: 0x00378CF8
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E337 RID: 58167 RVA: 0x0037AB40 File Offset: 0x00378D40
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E338 RID: 58168 RVA: 0x0037AB74 File Offset: 0x00378D74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186569, XrefRangeEnd = 186589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700451E RID: 17694
			// (get) Token: 0x0600E339 RID: 58169 RVA: 0x0037ABB0 File Offset: 0x00378DB0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E33A RID: 58170 RVA: 0x0037ABF0 File Offset: 0x00378DF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186589, XrefRangeEnd = 186594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700451F RID: 17695
			// (get) Token: 0x0600E33B RID: 58171 RVA: 0x0037AC24 File Offset: 0x00378E24
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E33C RID: 58172 RVA: 0x0006B20A File Offset: 0x0006940A
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700451B RID: 17691
			// (get) Token: 0x0600E33D RID: 58173 RVA: 0x0037AC64 File Offset: 0x00378E64
			// (set) Token: 0x0600E33E RID: 58174 RVA: 0x0006B213 File Offset: 0x00069413
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700451C RID: 17692
			// (get) Token: 0x0600E33F RID: 58175 RVA: 0x0037AC8C File Offset: 0x00378E8C
			// (set) Token: 0x0600E340 RID: 58176 RVA: 0x0006B22E File Offset: 0x0006942E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700451D RID: 17693
			// (get) Token: 0x0600E341 RID: 58177 RVA: 0x0037ACBC File Offset: 0x00378EBC
			// (set) Token: 0x0600E342 RID: 58178 RVA: 0x0006B24D File Offset: 0x0006944D
			public unsafe Supplier __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A75 RID: 39541
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009A76 RID: 39542
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009A77 RID: 39543
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009A78 RID: 39544
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009A79 RID: 39545
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009A7A RID: 39546
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009A7B RID: 39547
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009A7C RID: 39548
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009A7D RID: 39549
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AB4 RID: 2740
		[ObfuscatedName("ScheduleOne.Economy.Supplier+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E343 RID: 58179 RVA: 0x0037ACEC File Offset: 0x00378EEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr);
				Supplier.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, "<>9");
				Supplier.__c.NativeFieldInfoPtr___9__42_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, "<>9__42_0");
				Supplier.__c.NativeFieldInfoPtr___9__52_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, "<>9__52_1");
				Supplier.__c.NativeFieldInfoPtr___9__54_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, "<>9__54_1");
				Supplier.__c.NativeFieldInfoPtr___9__58_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, "<>9__58_0");
				Supplier.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, 100674351);
				Supplier.__c.NativeMethodInfoPtr__Start_b__42_0_Internal_Boolean_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, 100674352);
				Supplier.__c.NativeMethodInfoPtr__SupplierUnlocked_b__52_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, 100674353);
				Supplier.__c.NativeMethodInfoPtr__EnableDeliveries_b__54_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, 100674354);
				Supplier.__c.NativeMethodInfoPtr__DeaddropConfirmed_b__58_0_Internal_Int32_CartEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, 100674355);
			}

			// Token: 0x0600E344 RID: 58180 RVA: 0x0037ADE0 File Offset: 0x00378FE0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E345 RID: 58181 RVA: 0x0037AE1C File Offset: 0x0037901C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186594, XrefRangeEnd = 186596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__42_0(NPCAction x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.__c.NativeMethodInfoPtr__Start_b__42_0_Internal_Boolean_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E346 RID: 58182 RVA: 0x0037AE6C File Offset: 0x0037906C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186596, XrefRangeEnd = 186604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SupplierUnlocked_b__52_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.__c.NativeMethodInfoPtr__SupplierUnlocked_b__52_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E347 RID: 58183 RVA: 0x0037AEA8 File Offset: 0x003790A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186604, XrefRangeEnd = 186607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _EnableDeliveries_b__54_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.__c.NativeMethodInfoPtr__EnableDeliveries_b__54_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E348 RID: 58184 RVA: 0x0037AEE4 File Offset: 0x003790E4
			[CallerCount(0)]
			public unsafe int _DeaddropConfirmed_b__58_0(PhoneShopInterface.CartEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.__c.NativeMethodInfoPtr__DeaddropConfirmed_b__58_0_Internal_Int32_CartEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E349 RID: 58185 RVA: 0x0006B26C File Offset: 0x0006946C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004520 RID: 17696
			// (get) Token: 0x0600E34A RID: 58186 RVA: 0x0037AF34 File Offset: 0x00379134
			// (set) Token: 0x0600E34B RID: 58187 RVA: 0x0006B275 File Offset: 0x00069475
			public unsafe static Supplier.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Supplier.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Supplier.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004521 RID: 17697
			// (get) Token: 0x0600E34C RID: 58188 RVA: 0x0037AF5C File Offset: 0x0037915C
			// (set) Token: 0x0600E34D RID: 58189 RVA: 0x0006B287 File Offset: 0x00069487
			public unsafe static Func<NPCAction, bool> __9__42_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Supplier.__c.NativeFieldInfoPtr___9__42_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPCAction, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Supplier.__c.NativeFieldInfoPtr___9__42_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004522 RID: 17698
			// (get) Token: 0x0600E34E RID: 58190 RVA: 0x0037AF84 File Offset: 0x00379184
			// (set) Token: 0x0600E34F RID: 58191 RVA: 0x0006B299 File Offset: 0x00069499
			public unsafe static Func<bool> __9__52_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Supplier.__c.NativeFieldInfoPtr___9__52_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Supplier.__c.NativeFieldInfoPtr___9__52_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004523 RID: 17699
			// (get) Token: 0x0600E350 RID: 58192 RVA: 0x0037AFAC File Offset: 0x003791AC
			// (set) Token: 0x0600E351 RID: 58193 RVA: 0x0006B2AB File Offset: 0x000694AB
			public unsafe static Func<bool> __9__54_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Supplier.__c.NativeFieldInfoPtr___9__54_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Supplier.__c.NativeFieldInfoPtr___9__54_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004524 RID: 17700
			// (get) Token: 0x0600E352 RID: 58194 RVA: 0x0037AFD4 File Offset: 0x003791D4
			// (set) Token: 0x0600E353 RID: 58195 RVA: 0x0006B2BD File Offset: 0x000694BD
			public unsafe static Func<PhoneShopInterface.CartEntry, int> __9__58_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Supplier.__c.NativeFieldInfoPtr___9__58_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PhoneShopInterface.CartEntry, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Supplier.__c.NativeFieldInfoPtr___9__58_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A7E RID: 39550
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009A7F RID: 39551
			private static readonly IntPtr NativeFieldInfoPtr___9__42_0;

			// Token: 0x04009A80 RID: 39552
			private static readonly IntPtr NativeFieldInfoPtr___9__52_1;

			// Token: 0x04009A81 RID: 39553
			private static readonly IntPtr NativeFieldInfoPtr___9__54_1;

			// Token: 0x04009A82 RID: 39554
			private static readonly IntPtr NativeFieldInfoPtr___9__58_0;

			// Token: 0x04009A83 RID: 39555
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A84 RID: 39556
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__42_0_Internal_Boolean_NPCAction_0;

			// Token: 0x04009A85 RID: 39557
			private static readonly IntPtr NativeMethodInfoPtr__SupplierUnlocked_b__52_1_Internal_Boolean_0;

			// Token: 0x04009A86 RID: 39558
			private static readonly IntPtr NativeMethodInfoPtr__EnableDeliveries_b__54_1_Internal_Boolean_0;

			// Token: 0x04009A87 RID: 39559
			private static readonly IntPtr NativeMethodInfoPtr__DeaddropConfirmed_b__58_0_Internal_Int32_CartEntry_0;
		}
	}
}
