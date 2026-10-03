using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Money
{
	// Token: 0x020002AC RID: 684
	public class MoneyManager : NetworkSingleton<MoneyManager>
	{
		// Token: 0x060034B2 RID: 13490 RVA: 0x0012A830 File Offset: 0x00128A30
		// Note: this type is marked as 'beforefieldinit'.
		static MoneyManager()
		{
			Il2CppClassPointerStore<MoneyManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Money", "MoneyManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr);
			MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "MONEY_TEXT_COLOR");
			MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR_DARKER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "MONEY_TEXT_COLOR_DARKER");
			MoneyManager.NativeFieldInfoPtr_ONLINE_BALANCE_COLOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "ONLINE_BALANCE_COLOR");
			MoneyManager.NativeFieldInfoPtr_cultureInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "cultureInfo");
			MoneyManager.NativeFieldInfoPtr_ledger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "ledger");
			MoneyManager.NativeFieldInfoPtr_onlineBalance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "onlineBalance");
			MoneyManager.NativeFieldInfoPtr_lifetimeEarnings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "lifetimeEarnings");
			MoneyManager.NativeFieldInfoPtr__LastCalculatedNetworth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<LastCalculatedNetworth>k__BackingField");
			MoneyManager.NativeFieldInfoPtr_CashSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "CashSound");
			MoneyManager.NativeFieldInfoPtr_moneyChangePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "moneyChangePrefab");
			MoneyManager.NativeFieldInfoPtr_cashChangePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "cashChangePrefab");
			MoneyManager.NativeFieldInfoPtr_LaunderingNotificationIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "LaunderingNotificationIcon");
			MoneyManager.NativeFieldInfoPtr_onNetworthCalculation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "onNetworthCalculation");
			MoneyManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "loader");
			MoneyManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			MoneyManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			MoneyManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			MoneyManager.NativeFieldInfoPtr__LoadOrder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<LoadOrder>k__BackingField");
			MoneyManager.NativeFieldInfoPtr_syncVar___onlineBalance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "syncVar___onlineBalance");
			MoneyManager.NativeFieldInfoPtr_syncVar___lifetimeEarnings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "syncVar___lifetimeEarnings");
			MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Money.MoneyManagerAssembly-CSharp.dll_Excuted");
			MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Money.MoneyManagerAssembly-CSharp.dll_Excuted");
			MoneyManager.NativeMethodInfoPtr_ApplyMoneyTextColor_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669970);
			MoneyManager.NativeMethodInfoPtr_ApplyMoneyTextColorDarker_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669971);
			MoneyManager.NativeMethodInfoPtr_ApplyOnlineBalanceColor_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669972);
			MoneyManager.NativeMethodInfoPtr_get_LifetimeEarnings_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669973);
			MoneyManager.NativeMethodInfoPtr_get_LastCalculatedNetworth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669974);
			MoneyManager.NativeMethodInfoPtr_set_LastCalculatedNetworth_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669975);
			MoneyManager.NativeMethodInfoPtr_get_cashBalance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669976);
			MoneyManager.NativeMethodInfoPtr_get_cashInstance_Protected_get_CashInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669977);
			MoneyManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669978);
			MoneyManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669979);
			MoneyManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669980);
			MoneyManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669981);
			MoneyManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669982);
			MoneyManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669983);
			MoneyManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669984);
			MoneyManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669985);
			MoneyManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669986);
			MoneyManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669987);
			MoneyManager.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669988);
			MoneyManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669989);
			MoneyManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669990);
			MoneyManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669991);
			MoneyManager.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669992);
			MoneyManager.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669993);
			MoneyManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669994);
			MoneyManager.NativeMethodInfoPtr_Loaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669995);
			MoneyManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669996);
			MoneyManager.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669997);
			MoneyManager.NativeMethodInfoPtr_GetCashInstance_Public_CashInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669998);
			MoneyManager.NativeMethodInfoPtr_CreateOnlineTransaction_Public_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100669999);
			MoneyManager.NativeMethodInfoPtr_ReceiveOnlineTransaction_Private_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670000);
			MoneyManager.NativeMethodInfoPtr_ShowOnlineBalanceChange_Protected_IEnumerator_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670001);
			MoneyManager.NativeMethodInfoPtr_ChangeLifetimeEarnings_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670002);
			MoneyManager.NativeMethodInfoPtr_PlayCashSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670003);
			MoneyManager.NativeMethodInfoPtr_ChangeCashBalance_Public_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670004);
			MoneyManager.NativeMethodInfoPtr_ShowCashChange_Protected_IEnumerator_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670005);
			MoneyManager.NativeMethodInfoPtr_FormatAmount_Public_Static_String_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670006);
			MoneyManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670007);
			MoneyManager.NativeMethodInfoPtr_Load_Public_Void_MoneyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670008);
			MoneyManager.NativeMethodInfoPtr_CheckNetworthAchievements_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670009);
			MoneyManager.NativeMethodInfoPtr_GetNetWorth_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670010);
			MoneyManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670011);
			MoneyManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670013);
			MoneyManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670014);
			MoneyManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670015);
			MoneyManager.NativeMethodInfoPtr_RpcWriter___Server_CreateOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670016);
			MoneyManager.NativeMethodInfoPtr_RpcLogic___CreateOnlineTransaction_1419830531_Public_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670017);
			MoneyManager.NativeMethodInfoPtr_RpcReader___Server_CreateOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670018);
			MoneyManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670019);
			MoneyManager.NativeMethodInfoPtr_RpcLogic___ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670020);
			MoneyManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670021);
			MoneyManager.NativeMethodInfoPtr_RpcWriter___Server_ChangeLifetimeEarnings_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670022);
			MoneyManager.NativeMethodInfoPtr_RpcLogic___ChangeLifetimeEarnings_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670023);
			MoneyManager.NativeMethodInfoPtr_RpcReader___Server_ChangeLifetimeEarnings_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670024);
			MoneyManager.NativeMethodInfoPtr_sync___get_value_onlineBalance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670025);
			MoneyManager.NativeMethodInfoPtr_sync___set_value_onlineBalance_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670026);
			MoneyManager.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Money_MoneyManager_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670027);
			MoneyManager.NativeMethodInfoPtr_sync___get_value_lifetimeEarnings_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670028);
			MoneyManager.NativeMethodInfoPtr_sync___set_value_lifetimeEarnings_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670029);
			MoneyManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100670030);
		}

		// Token: 0x060034B3 RID: 13491 RVA: 0x0012AEC8 File Offset: 0x001290C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 140389, RefRangeEnd = 140390, XrefRangeStart = 140384, XrefRangeEnd = 140389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ApplyMoneyTextColor(string text)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_ApplyMoneyTextColor_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x0012AF04 File Offset: 0x00129104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140390, XrefRangeEnd = 140395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ApplyMoneyTextColorDarker(string text)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_ApplyMoneyTextColorDarker_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x0012AF40 File Offset: 0x00129140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140395, XrefRangeEnd = 140400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ApplyOnlineBalanceColor(string text)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_ApplyOnlineBalanceColor_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x060034B6 RID: 13494 RVA: 0x0012AF7C File Offset: 0x0012917C
		public unsafe float LifetimeEarnings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 55017, RefRangeEnd = 55018, XrefRangeStart = 55017, XrefRangeEnd = 55018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_LifetimeEarnings_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x060034B7 RID: 13495 RVA: 0x0012AFB8 File Offset: 0x001291B8
		// (set) Token: 0x060034B8 RID: 13496 RVA: 0x0012AFF4 File Offset: 0x001291F4
		public unsafe float LastCalculatedNetworth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_LastCalculatedNetworth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_set_LastCalculatedNetworth_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x060034B9 RID: 13497 RVA: 0x0012B034 File Offset: 0x00129234
		public unsafe float cashBalance
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 140401, RefRangeEnd = 140426, XrefRangeStart = 140400, XrefRangeEnd = 140401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_cashBalance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x060034BA RID: 13498 RVA: 0x0012B070 File Offset: 0x00129270
		public unsafe CashInstance cashInstance
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 140430, RefRangeEnd = 140436, XrefRangeStart = 140426, XrefRangeEnd = 140430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_cashInstance_Protected_get_CashInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr3) : null;
			}
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x060034BB RID: 13499 RVA: 0x0012B0B0 File Offset: 0x001292B0
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140436, XrefRangeEnd = 140438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x060034BC RID: 13500 RVA: 0x0012B0E8 File Offset: 0x001292E8
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140438, XrefRangeEnd = 140440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x060034BD RID: 13501 RVA: 0x0012B120 File Offset: 0x00129320
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x060034BE RID: 13502 RVA: 0x0012B160 File Offset: 0x00129360
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(170)]
			[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x060034BF RID: 13503 RVA: 0x0012B19C File Offset: 0x0012939C
		// (set) Token: 0x060034C0 RID: 13504 RVA: 0x0012B1DC File Offset: 0x001293DC
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 109090, RefRangeEnd = 109096, XrefRangeStart = 109090, XrefRangeEnd = 109096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x060034C1 RID: 13505 RVA: 0x0012B220 File Offset: 0x00129420
		// (set) Token: 0x060034C2 RID: 13506 RVA: 0x0012B260 File Offset: 0x00129460
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 140441, RefRangeEnd = 140444, XrefRangeStart = 140440, XrefRangeEnd = 140441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x060034C3 RID: 13507 RVA: 0x0012B2A4 File Offset: 0x001294A4
		// (set) Token: 0x060034C4 RID: 13508 RVA: 0x0012B2E0 File Offset: 0x001294E0
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x060034C5 RID: 13509 RVA: 0x0012B320 File Offset: 0x00129520
		public unsafe virtual int LoadOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x0012B35C File Offset: 0x0012955C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140444, XrefRangeEnd = 140447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x0012B398 File Offset: 0x00129598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140447, XrefRangeEnd = 140453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x0012B3D4 File Offset: 0x001295D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140453, XrefRangeEnd = 140500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034C9 RID: 13513 RVA: 0x0012B410 File Offset: 0x00129610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140500, XrefRangeEnd = 140512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x0012B44C File Offset: 0x0012964C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140512, XrefRangeEnd = 140519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034CB RID: 13515 RVA: 0x0012B488 File Offset: 0x00129688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140519, XrefRangeEnd = 140564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034CC RID: 13516 RVA: 0x0012B4C4 File Offset: 0x001296C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140564, XrefRangeEnd = 140571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Loaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_Loaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x0012B4F8 File Offset: 0x001296F8
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x0012B52C File Offset: 0x0012972C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140571, XrefRangeEnd = 140599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x0012B560 File Offset: 0x00129760
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 140607, RefRangeEnd = 140612, XrefRangeStart = 140599, XrefRangeEnd = 140607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashInstance GetCashInstance(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_GetCashInstance_Public_CashInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr3) : null;
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x0012B5AC File Offset: 0x001297AC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 140637, RefRangeEnd = 140647, XrefRangeStart = 140612, XrefRangeEnd = 140637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateOnlineTransaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_CreateOnlineTransaction_Public_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x0012B620 File Offset: 0x00129820
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 140660, RefRangeEnd = 140662, XrefRangeStart = 140647, XrefRangeEnd = 140660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveOnlineTransaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_ReceiveOnlineTransaction_Private_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x0012B694 File Offset: 0x00129894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140662, XrefRangeEnd = 140667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowOnlineBalanceChange(RectTransform changeDisplay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(changeDisplay);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_ShowOnlineBalanceChange_Protected_IEnumerator_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x0012B6E4 File Offset: 0x001298E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 140677, RefRangeEnd = 140679, XrefRangeStart = 140667, XrefRangeEnd = 140677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeLifetimeEarnings(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_ChangeLifetimeEarnings_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x0012B724 File Offset: 0x00129924
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 140683, RefRangeEnd = 140686, XrefRangeStart = 140679, XrefRangeEnd = 140683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayCashSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_PlayCashSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x0012B758 File Offset: 0x00129958
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 140732, RefRangeEnd = 140757, XrefRangeStart = 140686, XrefRangeEnd = 140732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeCashBalance(float change, bool visualizeChange = true, bool playCashSound = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visualizeChange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playCashSound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_ChangeCashBalance_Public_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D6 RID: 13526 RVA: 0x0012B7B4 File Offset: 0x001299B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140757, XrefRangeEnd = 140762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowCashChange(RectTransform changeDisplay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(changeDisplay);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_ShowCashChange_Protected_IEnumerator_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x0012B804 File Offset: 0x00129A04
		[CallerCount(116)]
		[CachedScanResults(RefRangeStart = 140801, RefRangeEnd = 140917, XrefRangeStart = 140762, XrefRangeEnd = 140801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatAmount(float amount, bool showDecimals = false, bool includeColor = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showDecimals;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_FormatAmount_Public_Static_String_Single_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060034D8 RID: 13528 RVA: 0x0012B858 File Offset: 0x00129A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140917, XrefRangeEnd = 140930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060034D9 RID: 13529 RVA: 0x0012B89C File Offset: 0x00129A9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 140955, RefRangeEnd = 140956, XrefRangeStart = 140930, XrefRangeEnd = 140955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(MoneyData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_Load_Public_Void_MoneyData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034DA RID: 13530 RVA: 0x0012B8E0 File Offset: 0x00129AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140956, XrefRangeEnd = 140967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNetworthAchievements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_CheckNetworthAchievements_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034DB RID: 13531 RVA: 0x0012B914 File Offset: 0x00129B14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 140971, RefRangeEnd = 140973, XrefRangeStart = 140967, XrefRangeEnd = 140971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetNetWorth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_GetNetWorth_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060034DC RID: 13532 RVA: 0x0012B950 File Offset: 0x00129B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140973, XrefRangeEnd = 141000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoneyManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034DD RID: 13533 RVA: 0x0012B98C File Offset: 0x00129B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141000, XrefRangeEnd = 141046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034DE RID: 13534 RVA: 0x0012B9C8 File Offset: 0x00129BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141046, XrefRangeEnd = 141049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034DF RID: 13535 RVA: 0x0012BA04 File Offset: 0x00129C04
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x0012BA40 File Offset: 0x00129C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141049, XrefRangeEnd = 141062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_CreateOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcWriter___Server_CreateOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x0012BAB4 File Offset: 0x00129CB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 140660, RefRangeEnd = 140662, XrefRangeStart = 140660, XrefRangeEnd = 140662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcLogic___CreateOnlineTransaction_1419830531_Public_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x0012BB28 File Offset: 0x00129D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141062, XrefRangeEnd = 141069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_CreateOnlineTransaction_1419830531(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcReader___Server_CreateOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x0012BB8C File Offset: 0x00129D8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 140660, RefRangeEnd = 140662, XrefRangeStart = 140660, XrefRangeEnd = 140662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x0012BC00 File Offset: 0x00129E00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141140, RefRangeEnd = 141141, XrefRangeStart = 141069, XrefRangeEnd = 141140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcLogic___ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x0012BC74 File Offset: 0x00129E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141141, XrefRangeEnd = 141147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveOnlineTransaction_1419830531(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x0012BCC4 File Offset: 0x00129EC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 140677, RefRangeEnd = 140679, XrefRangeStart = 140677, XrefRangeEnd = 140679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ChangeLifetimeEarnings_431000436(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcWriter___Server_ChangeLifetimeEarnings_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x0012BD04 File Offset: 0x00129F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141147, XrefRangeEnd = 141163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ChangeLifetimeEarnings_431000436(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcLogic___ChangeLifetimeEarnings_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x0012BD44 File Offset: 0x00129F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141163, XrefRangeEnd = 141181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ChangeLifetimeEarnings_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcReader___Server_ChangeLifetimeEarnings_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x060034E9 RID: 13545 RVA: 0x0012BDA8 File Offset: 0x00129FA8
		// (set) Token: 0x060034EA RID: 13546 RVA: 0x0012BDE4 File Offset: 0x00129FE4
		public unsafe float SyncAccessor_onlineBalance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_sync___get_value_onlineBalance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141181, XrefRangeEnd = 141189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_sync___set_value_onlineBalance_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034EB RID: 13547 RVA: 0x0012BE30 File Offset: 0x0012A030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141189, XrefRangeEnd = 141190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Money_MoneyManager(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Money_MoneyManager_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x060034EC RID: 13548 RVA: 0x0012BEA4 File Offset: 0x0012A0A4
		// (set) Token: 0x060034ED RID: 13549 RVA: 0x0012BEE0 File Offset: 0x0012A0E0
		public unsafe float SyncAccessor_lifetimeEarnings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 55017, RefRangeEnd = 55018, XrefRangeStart = 55017, XrefRangeEnd = 55018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_sync___get_value_lifetimeEarnings_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141190, XrefRangeEnd = 141198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_sync___set_value_lifetimeEarnings_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034EE RID: 13550 RVA: 0x0012BF2C File Offset: 0x0012A12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141198, XrefRangeEnd = 141201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034EF RID: 13551 RVA: 0x0001AD2D File Offset: 0x00018F2D
		public MoneyManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x060034F0 RID: 13552 RVA: 0x0012BF68 File Offset: 0x0012A168
		// (set) Token: 0x060034F1 RID: 13553 RVA: 0x0001AD36 File Offset: 0x00018F36
		public unsafe static string MONEY_TEXT_COLOR
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x060034F2 RID: 13554 RVA: 0x0012BF88 File Offset: 0x0012A188
		// (set) Token: 0x060034F3 RID: 13555 RVA: 0x0001AD48 File Offset: 0x00018F48
		public unsafe static string MONEY_TEXT_COLOR_DARKER
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR_DARKER, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR_DARKER, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x060034F4 RID: 13556 RVA: 0x0012BFA8 File Offset: 0x0012A1A8
		// (set) Token: 0x060034F5 RID: 13557 RVA: 0x0001AD5A File Offset: 0x00018F5A
		public unsafe static string ONLINE_BALANCE_COLOR
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MoneyManager.NativeFieldInfoPtr_ONLINE_BALANCE_COLOR, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoneyManager.NativeFieldInfoPtr_ONLINE_BALANCE_COLOR, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x060034F6 RID: 13558 RVA: 0x0012BFC8 File Offset: 0x0012A1C8
		// (set) Token: 0x060034F7 RID: 13559 RVA: 0x0001AD6C File Offset: 0x00018F6C
		public unsafe static CultureInfo cultureInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MoneyManager.NativeFieldInfoPtr_cultureInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoneyManager.NativeFieldInfoPtr_cultureInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x060034F8 RID: 13560 RVA: 0x0012BFF0 File Offset: 0x0012A1F0
		// (set) Token: 0x060034F9 RID: 13561 RVA: 0x0001AD7E File Offset: 0x00018F7E
		public unsafe List<Transaction> ledger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_ledger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transaction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_ledger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x060034FA RID: 13562 RVA: 0x0012C020 File Offset: 0x0012A220
		// (set) Token: 0x060034FB RID: 13563 RVA: 0x0001AD9D File Offset: 0x00018F9D
		public unsafe float onlineBalance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_onlineBalance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_onlineBalance)) = value;
			}
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x060034FC RID: 13564 RVA: 0x0012C048 File Offset: 0x0012A248
		// (set) Token: 0x060034FD RID: 13565 RVA: 0x0001ADB8 File Offset: 0x00018FB8
		public unsafe float lifetimeEarnings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_lifetimeEarnings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_lifetimeEarnings)) = value;
			}
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x060034FE RID: 13566 RVA: 0x0012C070 File Offset: 0x0012A270
		// (set) Token: 0x060034FF RID: 13567 RVA: 0x0001ADD3 File Offset: 0x00018FD3
		public unsafe float _LastCalculatedNetworth_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LastCalculatedNetworth_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LastCalculatedNetworth_k__BackingField)) = value;
			}
		}

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x06003500 RID: 13568 RVA: 0x0012C098 File Offset: 0x0012A298
		// (set) Token: 0x06003501 RID: 13569 RVA: 0x0001ADEE File Offset: 0x00018FEE
		public unsafe AudioSourceController CashSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_CashSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_CashSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x06003502 RID: 13570 RVA: 0x0012C0C8 File Offset: 0x0012A2C8
		// (set) Token: 0x06003503 RID: 13571 RVA: 0x0001AE0D File Offset: 0x0001900D
		public unsafe GameObject moneyChangePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_moneyChangePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_moneyChangePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x06003504 RID: 13572 RVA: 0x0012C0F8 File Offset: 0x0012A2F8
		// (set) Token: 0x06003505 RID: 13573 RVA: 0x0001AE2C File Offset: 0x0001902C
		public unsafe GameObject cashChangePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_cashChangePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_cashChangePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x06003506 RID: 13574 RVA: 0x0012C128 File Offset: 0x0012A328
		// (set) Token: 0x06003507 RID: 13575 RVA: 0x0001AE4B File Offset: 0x0001904B
		public unsafe Sprite LaunderingNotificationIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_LaunderingNotificationIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_LaunderingNotificationIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x06003508 RID: 13576 RVA: 0x0012C158 File Offset: 0x0012A358
		// (set) Token: 0x06003509 RID: 13577 RVA: 0x0001AE6A File Offset: 0x0001906A
		public unsafe Action<MoneyManager.FloatContainer> onNetworthCalculation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_onNetworthCalculation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<MoneyManager.FloatContainer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_onNetworthCalculation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x0600350A RID: 13578 RVA: 0x0012C188 File Offset: 0x0012A388
		// (set) Token: 0x0600350B RID: 13579 RVA: 0x0001AE89 File Offset: 0x00019089
		public unsafe MoneyLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoneyLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x0600350C RID: 13580 RVA: 0x0012C1B8 File Offset: 0x0012A3B8
		// (set) Token: 0x0600350D RID: 13581 RVA: 0x0001AEA8 File Offset: 0x000190A8
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x0600350E RID: 13582 RVA: 0x0012C1E8 File Offset: 0x0012A3E8
		// (set) Token: 0x0600350F RID: 13583 RVA: 0x0001AEC7 File Offset: 0x000190C7
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x06003510 RID: 13584 RVA: 0x0012C218 File Offset: 0x0012A418
		// (set) Token: 0x06003511 RID: 13585 RVA: 0x0001AEE6 File Offset: 0x000190E6
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x06003512 RID: 13586 RVA: 0x0012C240 File Offset: 0x0012A440
		// (set) Token: 0x06003513 RID: 13587 RVA: 0x0001AF01 File Offset: 0x00019101
		public unsafe int _LoadOrder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LoadOrder_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LoadOrder_k__BackingField)) = value;
			}
		}

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x06003514 RID: 13588 RVA: 0x0012C268 File Offset: 0x0012A468
		// (set) Token: 0x06003515 RID: 13589 RVA: 0x0001AF1C File Offset: 0x0001911C
		public unsafe SyncVar<float> syncVar___onlineBalance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_syncVar___onlineBalance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_syncVar___onlineBalance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x06003516 RID: 13590 RVA: 0x0012C298 File Offset: 0x0012A498
		// (set) Token: 0x06003517 RID: 13591 RVA: 0x0001AF3B File Offset: 0x0001913B
		public unsafe SyncVar<float> syncVar___lifetimeEarnings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_syncVar___lifetimeEarnings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_syncVar___lifetimeEarnings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x06003518 RID: 13592 RVA: 0x0012C2C8 File Offset: 0x0012A4C8
		// (set) Token: 0x06003519 RID: 13593 RVA: 0x0001AF5A File Offset: 0x0001915A
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x0600351A RID: 13594 RVA: 0x0012C2F0 File Offset: 0x0012A4F0
		// (set) Token: 0x0600351B RID: 13595 RVA: 0x0001AF75 File Offset: 0x00019175
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002344 RID: 9028
		private static readonly IntPtr NativeFieldInfoPtr_MONEY_TEXT_COLOR;

		// Token: 0x04002345 RID: 9029
		private static readonly IntPtr NativeFieldInfoPtr_MONEY_TEXT_COLOR_DARKER;

		// Token: 0x04002346 RID: 9030
		private static readonly IntPtr NativeFieldInfoPtr_ONLINE_BALANCE_COLOR;

		// Token: 0x04002347 RID: 9031
		private static readonly IntPtr NativeFieldInfoPtr_cultureInfo;

		// Token: 0x04002348 RID: 9032
		private static readonly IntPtr NativeFieldInfoPtr_ledger;

		// Token: 0x04002349 RID: 9033
		private static readonly IntPtr NativeFieldInfoPtr_onlineBalance;

		// Token: 0x0400234A RID: 9034
		private static readonly IntPtr NativeFieldInfoPtr_lifetimeEarnings;

		// Token: 0x0400234B RID: 9035
		private static readonly IntPtr NativeFieldInfoPtr__LastCalculatedNetworth_k__BackingField;

		// Token: 0x0400234C RID: 9036
		private static readonly IntPtr NativeFieldInfoPtr_CashSound;

		// Token: 0x0400234D RID: 9037
		private static readonly IntPtr NativeFieldInfoPtr_moneyChangePrefab;

		// Token: 0x0400234E RID: 9038
		private static readonly IntPtr NativeFieldInfoPtr_cashChangePrefab;

		// Token: 0x0400234F RID: 9039
		private static readonly IntPtr NativeFieldInfoPtr_LaunderingNotificationIcon;

		// Token: 0x04002350 RID: 9040
		private static readonly IntPtr NativeFieldInfoPtr_onNetworthCalculation;

		// Token: 0x04002351 RID: 9041
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04002352 RID: 9042
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04002353 RID: 9043
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04002354 RID: 9044
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04002355 RID: 9045
		private static readonly IntPtr NativeFieldInfoPtr__LoadOrder_k__BackingField;

		// Token: 0x04002356 RID: 9046
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___onlineBalance;

		// Token: 0x04002357 RID: 9047
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___lifetimeEarnings;

		// Token: 0x04002358 RID: 9048
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002359 RID: 9049
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400235A RID: 9050
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMoneyTextColor_Public_Static_String_String_0;

		// Token: 0x0400235B RID: 9051
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMoneyTextColorDarker_Public_Static_String_String_0;

		// Token: 0x0400235C RID: 9052
		private static readonly IntPtr NativeMethodInfoPtr_ApplyOnlineBalanceColor_Public_Static_String_String_0;

		// Token: 0x0400235D RID: 9053
		private static readonly IntPtr NativeMethodInfoPtr_get_LifetimeEarnings_Public_get_Single_0;

		// Token: 0x0400235E RID: 9054
		private static readonly IntPtr NativeMethodInfoPtr_get_LastCalculatedNetworth_Public_get_Single_0;

		// Token: 0x0400235F RID: 9055
		private static readonly IntPtr NativeMethodInfoPtr_set_LastCalculatedNetworth_Protected_set_Void_Single_0;

		// Token: 0x04002360 RID: 9056
		private static readonly IntPtr NativeMethodInfoPtr_get_cashBalance_Public_get_Single_0;

		// Token: 0x04002361 RID: 9057
		private static readonly IntPtr NativeMethodInfoPtr_get_cashInstance_Protected_get_CashInstance_0;

		// Token: 0x04002362 RID: 9058
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04002363 RID: 9059
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04002364 RID: 9060
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04002365 RID: 9061
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002366 RID: 9062
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04002367 RID: 9063
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04002368 RID: 9064
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04002369 RID: 9065
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400236A RID: 9066
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400236B RID: 9067
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400236C RID: 9068
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400236D RID: 9069
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400236E RID: 9070
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x0400236F RID: 9071
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04002370 RID: 9072
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04002371 RID: 9073
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04002372 RID: 9074
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1;

		// Token: 0x04002373 RID: 9075
		private static readonly IntPtr NativeMethodInfoPtr_Loaded_Private_Void_0;

		// Token: 0x04002374 RID: 9076
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04002375 RID: 9077
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04002376 RID: 9078
		private static readonly IntPtr NativeMethodInfoPtr_GetCashInstance_Public_CashInstance_Single_0;

		// Token: 0x04002377 RID: 9079
		private static readonly IntPtr NativeMethodInfoPtr_CreateOnlineTransaction_Public_Void_String_Single_Single_String_0;

		// Token: 0x04002378 RID: 9080
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveOnlineTransaction_Private_Void_String_Single_Single_String_0;

		// Token: 0x04002379 RID: 9081
		private static readonly IntPtr NativeMethodInfoPtr_ShowOnlineBalanceChange_Protected_IEnumerator_RectTransform_0;

		// Token: 0x0400237A RID: 9082
		private static readonly IntPtr NativeMethodInfoPtr_ChangeLifetimeEarnings_Public_Void_Single_0;

		// Token: 0x0400237B RID: 9083
		private static readonly IntPtr NativeMethodInfoPtr_PlayCashSound_Public_Void_0;

		// Token: 0x0400237C RID: 9084
		private static readonly IntPtr NativeMethodInfoPtr_ChangeCashBalance_Public_Void_Single_Boolean_Boolean_0;

		// Token: 0x0400237D RID: 9085
		private static readonly IntPtr NativeMethodInfoPtr_ShowCashChange_Protected_IEnumerator_RectTransform_0;

		// Token: 0x0400237E RID: 9086
		private static readonly IntPtr NativeMethodInfoPtr_FormatAmount_Public_Static_String_Single_Boolean_Boolean_0;

		// Token: 0x0400237F RID: 9087
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04002380 RID: 9088
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_MoneyData_0;

		// Token: 0x04002381 RID: 9089
		private static readonly IntPtr NativeMethodInfoPtr_CheckNetworthAchievements_Public_Void_0;

		// Token: 0x04002382 RID: 9090
		private static readonly IntPtr NativeMethodInfoPtr_GetNetWorth_Public_Single_0;

		// Token: 0x04002383 RID: 9091
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002384 RID: 9092
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002385 RID: 9093
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002386 RID: 9094
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002387 RID: 9095
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_CreateOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0;

		// Token: 0x04002388 RID: 9096
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateOnlineTransaction_1419830531_Public_Void_String_Single_Single_String_0;

		// Token: 0x04002389 RID: 9097
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_CreateOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400238A RID: 9098
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0;

		// Token: 0x0400238B RID: 9099
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0;

		// Token: 0x0400238C RID: 9100
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400238D RID: 9101
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ChangeLifetimeEarnings_431000436_Private_Void_Single_0;

		// Token: 0x0400238E RID: 9102
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ChangeLifetimeEarnings_431000436_Public_Void_Single_0;

		// Token: 0x0400238F RID: 9103
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ChangeLifetimeEarnings_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002390 RID: 9104
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_onlineBalance_Public_get_Single_0;

		// Token: 0x04002391 RID: 9105
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_onlineBalance_Public_set_Void_Single_Boolean_0;

		// Token: 0x04002392 RID: 9106
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Money_MoneyManager_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04002393 RID: 9107
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_lifetimeEarnings_Public_get_Single_0;

		// Token: 0x04002394 RID: 9108
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_lifetimeEarnings_Public_set_Void_Single_Boolean_0;

		// Token: 0x04002395 RID: 9109
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A0C RID: 2572
		public class FloatContainer : Il2CppSystem.Object
		{
			// Token: 0x0600DDCD RID: 56781 RVA: 0x0036BC14 File Offset: 0x00369E14
			// Note: this type is marked as 'beforefieldinit'.
			static FloatContainer()
			{
				Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "FloatContainer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr);
				MoneyManager.FloatContainer.NativeFieldInfoPtr__value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr, "<value>k__BackingField");
				MoneyManager.FloatContainer.NativeMethodInfoPtr_get_value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr, 100670031);
				MoneyManager.FloatContainer.NativeMethodInfoPtr_set_value_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr, 100670032);
				MoneyManager.FloatContainer.NativeMethodInfoPtr_ChangeValue_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr, 100670033);
				MoneyManager.FloatContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr, 100670034);
			}

			// Token: 0x17004386 RID: 17286
			// (get) Token: 0x0600DDCE RID: 56782 RVA: 0x0036BCA4 File Offset: 0x00369EA4
			// (set) Token: 0x0600DDCF RID: 56783 RVA: 0x0036BCE0 File Offset: 0x00369EE0
			public unsafe float value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.FloatContainer.NativeMethodInfoPtr_get_value_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 29030, RefRangeEnd = 29033, XrefRangeStart = 29030, XrefRangeEnd = 29033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.FloatContainer.NativeMethodInfoPtr_set_value_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600DDD0 RID: 56784 RVA: 0x0036BD20 File Offset: 0x00369F20
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 140322, RefRangeEnd = 140328, XrefRangeStart = 140322, XrefRangeEnd = 140322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ChangeValue(float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.FloatContainer.NativeMethodInfoPtr_ChangeValue_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDD1 RID: 56785 RVA: 0x0036BD60 File Offset: 0x00369F60
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FloatContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.FloatContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDD2 RID: 56786 RVA: 0x00068674 File Offset: 0x00066874
			public FloatContainer(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004385 RID: 17285
			// (get) Token: 0x0600DDD3 RID: 56787 RVA: 0x0036BD9C File Offset: 0x00369F9C
			// (set) Token: 0x0600DDD4 RID: 56788 RVA: 0x0006867D File Offset: 0x0006687D
			public unsafe float _value_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.FloatContainer.NativeFieldInfoPtr__value_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.FloatContainer.NativeFieldInfoPtr__value_k__BackingField)) = value;
				}
			}

			// Token: 0x04009728 RID: 38696
			private static readonly IntPtr NativeFieldInfoPtr__value_k__BackingField;

			// Token: 0x04009729 RID: 38697
			private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Single_0;

			// Token: 0x0400972A RID: 38698
			private static readonly IntPtr NativeMethodInfoPtr_set_value_Private_set_Void_Single_0;

			// Token: 0x0400972B RID: 38699
			private static readonly IntPtr NativeMethodInfoPtr_ChangeValue_Public_Void_Single_0;

			// Token: 0x0400972C RID: 38700
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A0D RID: 2573
		[ObfuscatedName("ScheduleOne.Money.MoneyManager+<ShowCashChange>d__66")]
		public sealed class _ShowCashChange_d__66 : Il2CppSystem.Object
		{
			// Token: 0x0600DDD5 RID: 56789 RVA: 0x0036BDC4 File Offset: 0x00369FC4
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowCashChange_d__66()
			{
				Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__66>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<ShowCashChange>d__66");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__66>.NativeClassPtr);
				MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__66>.NativeClassPtr, "<>1__state");
				MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__66>.NativeClassPtr, "<>2__current");
				MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr_changeDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__66>.NativeClassPtr, "changeDisplay");
				MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr__text_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__66>.NativeClassPtr, "<text>5__2");
				MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr__startVert_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__66>.NativeClassPtr, "<startVert>5__3");
				MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr__lerpTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__66>.NativeClassPtr, "<lerpTime>5__4");
				MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr__vertOffset_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__66>.NativeClassPtr, "<vertOffset>5__5");
				MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__66>.NativeClassPtr, "<i>5__6");
				MoneyManager._ShowCashChange_d__66.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__66>.NativeClassPtr, 100670035);
				MoneyManager._ShowCashChange_d__66.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__66>.NativeClassPtr, 100670036);
				MoneyManager._ShowCashChange_d__66.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__66>.NativeClassPtr, 100670037);
				MoneyManager._ShowCashChange_d__66.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__66>.NativeClassPtr, 100670038);
				MoneyManager._ShowCashChange_d__66.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__66>.NativeClassPtr, 100670039);
				MoneyManager._ShowCashChange_d__66.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__66>.NativeClassPtr, 100670040);
			}

			// Token: 0x0600DDD6 RID: 56790 RVA: 0x0036BF08 File Offset: 0x0036A108
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowCashChange_d__66(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__66>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__66.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDD7 RID: 56791 RVA: 0x0036BF50 File Offset: 0x0036A150
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__66.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDD8 RID: 56792 RVA: 0x0036BF84 File Offset: 0x0036A184
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140328, XrefRangeEnd = 140351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__66.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700438F RID: 17295
			// (get) Token: 0x0600DDD9 RID: 56793 RVA: 0x0036BFC0 File Offset: 0x0036A1C0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__66.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DDDA RID: 56794 RVA: 0x0036C000 File Offset: 0x0036A200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140351, XrefRangeEnd = 140356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__66.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004390 RID: 17296
			// (get) Token: 0x0600DDDB RID: 56795 RVA: 0x0036C034 File Offset: 0x0036A234
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__66.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DDDC RID: 56796 RVA: 0x00068698 File Offset: 0x00066898
			public _ShowCashChange_d__66(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004387 RID: 17287
			// (get) Token: 0x0600DDDD RID: 56797 RVA: 0x0036C074 File Offset: 0x0036A274
			// (set) Token: 0x0600DDDE RID: 56798 RVA: 0x000686A1 File Offset: 0x000668A1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004388 RID: 17288
			// (get) Token: 0x0600DDDF RID: 56799 RVA: 0x0036C09C File Offset: 0x0036A29C
			// (set) Token: 0x0600DDE0 RID: 56800 RVA: 0x000686BC File Offset: 0x000668BC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004389 RID: 17289
			// (get) Token: 0x0600DDE1 RID: 56801 RVA: 0x0036C0CC File Offset: 0x0036A2CC
			// (set) Token: 0x0600DDE2 RID: 56802 RVA: 0x000686DB File Offset: 0x000668DB
			public unsafe RectTransform changeDisplay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr_changeDisplay);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr_changeDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700438A RID: 17290
			// (get) Token: 0x0600DDE3 RID: 56803 RVA: 0x0036C0FC File Offset: 0x0036A2FC
			// (set) Token: 0x0600DDE4 RID: 56804 RVA: 0x000686FA File Offset: 0x000668FA
			public unsafe TextMeshProUGUI _text_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr__text_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr__text_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700438B RID: 17291
			// (get) Token: 0x0600DDE5 RID: 56805 RVA: 0x0036C12C File Offset: 0x0036A32C
			// (set) Token: 0x0600DDE6 RID: 56806 RVA: 0x00068719 File Offset: 0x00066919
			public unsafe float _startVert_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr__startVert_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr__startVert_5__3)) = value;
				}
			}

			// Token: 0x1700438C RID: 17292
			// (get) Token: 0x0600DDE7 RID: 56807 RVA: 0x0036C154 File Offset: 0x0036A354
			// (set) Token: 0x0600DDE8 RID: 56808 RVA: 0x00068734 File Offset: 0x00066934
			public unsafe float _lerpTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr__lerpTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr__lerpTime_5__4)) = value;
				}
			}

			// Token: 0x1700438D RID: 17293
			// (get) Token: 0x0600DDE9 RID: 56809 RVA: 0x0036C17C File Offset: 0x0036A37C
			// (set) Token: 0x0600DDEA RID: 56810 RVA: 0x0006874F File Offset: 0x0006694F
			public unsafe float _vertOffset_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr__vertOffset_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr__vertOffset_5__5)) = value;
				}
			}

			// Token: 0x1700438E RID: 17294
			// (get) Token: 0x0600DDEB RID: 56811 RVA: 0x0036C1A4 File Offset: 0x0036A3A4
			// (set) Token: 0x0600DDEC RID: 56812 RVA: 0x0006876A File Offset: 0x0006696A
			public unsafe float _i_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr__i_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__66.NativeFieldInfoPtr__i_5__6)) = value;
				}
			}

			// Token: 0x0400972D RID: 38701
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400972E RID: 38702
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400972F RID: 38703
			private static readonly IntPtr NativeFieldInfoPtr_changeDisplay;

			// Token: 0x04009730 RID: 38704
			private static readonly IntPtr NativeFieldInfoPtr__text_5__2;

			// Token: 0x04009731 RID: 38705
			private static readonly IntPtr NativeFieldInfoPtr__startVert_5__3;

			// Token: 0x04009732 RID: 38706
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__4;

			// Token: 0x04009733 RID: 38707
			private static readonly IntPtr NativeFieldInfoPtr__vertOffset_5__5;

			// Token: 0x04009734 RID: 38708
			private static readonly IntPtr NativeFieldInfoPtr__i_5__6;

			// Token: 0x04009735 RID: 38709
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009736 RID: 38710
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009737 RID: 38711
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009738 RID: 38712
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009739 RID: 38713
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400973A RID: 38714
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A0E RID: 2574
		[ObfuscatedName("ScheduleOne.Money.MoneyManager+<ShowOnlineBalanceChange>d__62")]
		public sealed class _ShowOnlineBalanceChange_d__62 : Il2CppSystem.Object
		{
			// Token: 0x0600DDED RID: 56813 RVA: 0x0036C1CC File Offset: 0x0036A3CC
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowOnlineBalanceChange_d__62()
			{
				Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__62>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<ShowOnlineBalanceChange>d__62");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__62>.NativeClassPtr);
				MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__62>.NativeClassPtr, "<>1__state");
				MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__62>.NativeClassPtr, "<>2__current");
				MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr_changeDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__62>.NativeClassPtr, "changeDisplay");
				MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr__text_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__62>.NativeClassPtr, "<text>5__2");
				MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr__startVert_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__62>.NativeClassPtr, "<startVert>5__3");
				MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr__lerpTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__62>.NativeClassPtr, "<lerpTime>5__4");
				MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr__vertOffset_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__62>.NativeClassPtr, "<vertOffset>5__5");
				MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__62>.NativeClassPtr, "<i>5__6");
				MoneyManager._ShowOnlineBalanceChange_d__62.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__62>.NativeClassPtr, 100670041);
				MoneyManager._ShowOnlineBalanceChange_d__62.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__62>.NativeClassPtr, 100670042);
				MoneyManager._ShowOnlineBalanceChange_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__62>.NativeClassPtr, 100670043);
				MoneyManager._ShowOnlineBalanceChange_d__62.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__62>.NativeClassPtr, 100670044);
				MoneyManager._ShowOnlineBalanceChange_d__62.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__62>.NativeClassPtr, 100670045);
				MoneyManager._ShowOnlineBalanceChange_d__62.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__62>.NativeClassPtr, 100670046);
			}

			// Token: 0x0600DDEE RID: 56814 RVA: 0x0036C310 File Offset: 0x0036A510
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowOnlineBalanceChange_d__62(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__62>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__62.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDEF RID: 56815 RVA: 0x0036C358 File Offset: 0x0036A558
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__62.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDF0 RID: 56816 RVA: 0x0036C38C File Offset: 0x0036A58C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140356, XrefRangeEnd = 140379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004399 RID: 17305
			// (get) Token: 0x0600DDF1 RID: 56817 RVA: 0x0036C3C8 File Offset: 0x0036A5C8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__62.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DDF2 RID: 56818 RVA: 0x0036C408 File Offset: 0x0036A608
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140379, XrefRangeEnd = 140384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__62.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700439A RID: 17306
			// (get) Token: 0x0600DDF3 RID: 56819 RVA: 0x0036C43C File Offset: 0x0036A63C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__62.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DDF4 RID: 56820 RVA: 0x00068785 File Offset: 0x00066985
			public _ShowOnlineBalanceChange_d__62(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004391 RID: 17297
			// (get) Token: 0x0600DDF5 RID: 56821 RVA: 0x0036C47C File Offset: 0x0036A67C
			// (set) Token: 0x0600DDF6 RID: 56822 RVA: 0x0006878E File Offset: 0x0006698E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004392 RID: 17298
			// (get) Token: 0x0600DDF7 RID: 56823 RVA: 0x0036C4A4 File Offset: 0x0036A6A4
			// (set) Token: 0x0600DDF8 RID: 56824 RVA: 0x000687A9 File Offset: 0x000669A9
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004393 RID: 17299
			// (get) Token: 0x0600DDF9 RID: 56825 RVA: 0x0036C4D4 File Offset: 0x0036A6D4
			// (set) Token: 0x0600DDFA RID: 56826 RVA: 0x000687C8 File Offset: 0x000669C8
			public unsafe RectTransform changeDisplay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr_changeDisplay);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr_changeDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004394 RID: 17300
			// (get) Token: 0x0600DDFB RID: 56827 RVA: 0x0036C504 File Offset: 0x0036A704
			// (set) Token: 0x0600DDFC RID: 56828 RVA: 0x000687E7 File Offset: 0x000669E7
			public unsafe TextMeshProUGUI _text_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr__text_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr__text_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004395 RID: 17301
			// (get) Token: 0x0600DDFD RID: 56829 RVA: 0x0036C534 File Offset: 0x0036A734
			// (set) Token: 0x0600DDFE RID: 56830 RVA: 0x00068806 File Offset: 0x00066A06
			public unsafe float _startVert_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr__startVert_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr__startVert_5__3)) = value;
				}
			}

			// Token: 0x17004396 RID: 17302
			// (get) Token: 0x0600DDFF RID: 56831 RVA: 0x0036C55C File Offset: 0x0036A75C
			// (set) Token: 0x0600DE00 RID: 56832 RVA: 0x00068821 File Offset: 0x00066A21
			public unsafe float _lerpTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr__lerpTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr__lerpTime_5__4)) = value;
				}
			}

			// Token: 0x17004397 RID: 17303
			// (get) Token: 0x0600DE01 RID: 56833 RVA: 0x0036C584 File Offset: 0x0036A784
			// (set) Token: 0x0600DE02 RID: 56834 RVA: 0x0006883C File Offset: 0x00066A3C
			public unsafe float _vertOffset_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr__vertOffset_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr__vertOffset_5__5)) = value;
				}
			}

			// Token: 0x17004398 RID: 17304
			// (get) Token: 0x0600DE03 RID: 56835 RVA: 0x0036C5AC File Offset: 0x0036A7AC
			// (set) Token: 0x0600DE04 RID: 56836 RVA: 0x00068857 File Offset: 0x00066A57
			public unsafe float _i_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr__i_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__62.NativeFieldInfoPtr__i_5__6)) = value;
				}
			}

			// Token: 0x0400973B RID: 38715
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400973C RID: 38716
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400973D RID: 38717
			private static readonly IntPtr NativeFieldInfoPtr_changeDisplay;

			// Token: 0x0400973E RID: 38718
			private static readonly IntPtr NativeFieldInfoPtr__text_5__2;

			// Token: 0x0400973F RID: 38719
			private static readonly IntPtr NativeFieldInfoPtr__startVert_5__3;

			// Token: 0x04009740 RID: 38720
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__4;

			// Token: 0x04009741 RID: 38721
			private static readonly IntPtr NativeFieldInfoPtr__vertOffset_5__5;

			// Token: 0x04009742 RID: 38722
			private static readonly IntPtr NativeFieldInfoPtr__i_5__6;

			// Token: 0x04009743 RID: 38723
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009744 RID: 38724
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009745 RID: 38725
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009746 RID: 38726
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009747 RID: 38727
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009748 RID: 38728
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
