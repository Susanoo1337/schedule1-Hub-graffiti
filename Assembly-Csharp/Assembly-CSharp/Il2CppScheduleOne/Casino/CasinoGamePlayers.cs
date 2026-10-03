using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x02000432 RID: 1074
	public class CasinoGamePlayers : NetworkBehaviour
	{
		// Token: 0x06005F13 RID: 24339 RVA: 0x001C3B2C File Offset: 0x001C1D2C
		// Note: this type is marked as 'beforefieldinit'.
		static CasinoGamePlayers()
		{
			Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "CasinoGamePlayers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr);
			CasinoGamePlayers.NativeFieldInfoPtr_PlayerLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "PlayerLimit");
			CasinoGamePlayers.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "Players");
			CasinoGamePlayers.NativeFieldInfoPtr_onPlayerListChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "onPlayerListChanged");
			CasinoGamePlayers.NativeFieldInfoPtr_onPlayerScoresChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "onPlayerScoresChanged");
			CasinoGamePlayers.NativeFieldInfoPtr_playerScores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "playerScores");
			CasinoGamePlayers.NativeFieldInfoPtr_playerDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "playerDatas");
			CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Casino.CasinoGamePlayersAssembly-CSharp.dll_Excuted");
			CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Casino.CasinoGamePlayersAssembly-CSharp.dll_Excuted");
			CasinoGamePlayers.NativeMethodInfoPtr_get_CurrentPlayerCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675752);
			CasinoGamePlayers.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675753);
			CasinoGamePlayers.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675754);
			CasinoGamePlayers.NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675755);
			CasinoGamePlayers.NativeMethodInfoPtr_RemovePlayer_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675756);
			CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerScore_Public_Void_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675757);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerScore_Public_Int32_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675758);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayer_Public_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675759);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerIndex_Public_Int32_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675760);
			CasinoGamePlayers.NativeMethodInfoPtr_RequestAddPlayer_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675761);
			CasinoGamePlayers.NativeMethodInfoPtr_AddPlayerToArray_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675762);
			CasinoGamePlayers.NativeMethodInfoPtr_RequestRemovePlayer_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675763);
			CasinoGamePlayers.NativeMethodInfoPtr_RemovePlayerFromArray_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675764);
			CasinoGamePlayers.NativeMethodInfoPtr_RequestSetScore_Private_Void_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675765);
			CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerScore_Private_Void_NetworkConnection_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675766);
			CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerList_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675767);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675768);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675769);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675770);
			CasinoGamePlayers.NativeMethodInfoPtr_SendPlayerBool_Public_Void_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675771);
			CasinoGamePlayers.NativeMethodInfoPtr_ReceivePlayerBool_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675772);
			CasinoGamePlayers.NativeMethodInfoPtr_SendPlayerFloat_Public_Void_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675773);
			CasinoGamePlayers.NativeMethodInfoPtr_ReceivePlayerFloat_Private_Void_NetworkConnection_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675774);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerObjects_Private_Il2CppReferenceArray_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675775);
			CasinoGamePlayers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675776);
			CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675777);
			CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675778);
			CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675779);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestAddPlayer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675780);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestAddPlayer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675781);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestAddPlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675782);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675783);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675784);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675785);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675786);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675787);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestSetScore_4172557123_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675788);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675789);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675790);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675791);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675792);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675793);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675794);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675795);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675796);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675797);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675798);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerBool_77262511_Private_Void_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675799);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SendPlayerBool_77262511_Public_Void_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675800);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_SendPlayerBool_77262511_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675801);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675802);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675803);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675804);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675805);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675806);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerFloat_2931762093_Private_Void_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675807);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SendPlayerFloat_2931762093_Public_Void_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675808);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_SendPlayerFloat_2931762093_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675809);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675810);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675811);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675812);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675813);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675814);
			CasinoGamePlayers.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100675815);
		}

		// Token: 0x17001D55 RID: 7509
		// (get) Token: 0x06005F14 RID: 24340 RVA: 0x001C40FC File Offset: 0x001C22FC
		public unsafe int CurrentPlayerCount
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 202618, RefRangeEnd = 202640, XrefRangeStart = 202600, XrefRangeEnd = 202618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_get_CurrentPlayerCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005F15 RID: 24341 RVA: 0x001C4138 File Offset: 0x001C2338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202640, XrefRangeEnd = 202644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGamePlayers.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F16 RID: 24342 RVA: 0x001C4174 File Offset: 0x001C2374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202644, XrefRangeEnd = 202659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGamePlayers.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F17 RID: 24343 RVA: 0x001C41C4 File Offset: 0x001C23C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202659, XrefRangeEnd = 202681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F18 RID: 24344 RVA: 0x001C4208 File Offset: 0x001C2408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202681, XrefRangeEnd = 202700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RemovePlayer_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F19 RID: 24345 RVA: 0x001C424C File Offset: 0x001C244C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 202721, RefRangeEnd = 202726, XrefRangeStart = 202700, XrefRangeEnd = 202721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerScore(Player player, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerScore_Public_Void_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F1A RID: 24346 RVA: 0x001C429C File Offset: 0x001C249C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202736, RefRangeEnd = 202738, XrefRangeStart = 202726, XrefRangeEnd = 202736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPlayerScore(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerScore_Public_Int32_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005F1B RID: 24347 RVA: 0x001C42EC File Offset: 0x001C24EC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 202738, RefRangeEnd = 202747, XrefRangeStart = 202738, XrefRangeEnd = 202738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player GetPlayer(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayer_Public_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
		}

		// Token: 0x06005F1C RID: 24348 RVA: 0x001C4338 File Offset: 0x001C2538
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 202750, RefRangeEnd = 202754, XrefRangeStart = 202747, XrefRangeEnd = 202750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPlayerIndex(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerIndex_Public_Int32_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005F1D RID: 24349 RVA: 0x001C4388 File Offset: 0x001C2588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202754, XrefRangeEnd = 202776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestAddPlayer(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RequestAddPlayer_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F1E RID: 24350 RVA: 0x001C43CC File Offset: 0x001C25CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202776, XrefRangeEnd = 202780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayerToArray(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_AddPlayerToArray_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F1F RID: 24351 RVA: 0x001C4410 File Offset: 0x001C2610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202780, XrefRangeEnd = 202790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestRemovePlayer(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RequestRemovePlayer_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F20 RID: 24352 RVA: 0x001C4454 File Offset: 0x001C2654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202790, XrefRangeEnd = 202794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePlayerFromArray(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RemovePlayerFromArray_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F21 RID: 24353 RVA: 0x001C4498 File Offset: 0x001C2698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202794, XrefRangeEnd = 202806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestSetScore(NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RequestSetScore_Private_Void_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F22 RID: 24354 RVA: 0x001C44E8 File Offset: 0x001C26E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 202849, RefRangeEnd = 202852, XrefRangeStart = 202806, XrefRangeEnd = 202849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerScore(NetworkConnection conn, NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerScore_Private_Void_NetworkConnection_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F23 RID: 24355 RVA: 0x001C454C File Offset: 0x001C274C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 202891, RefRangeEnd = 202895, XrefRangeStart = 202852, XrefRangeEnd = 202891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerList(NetworkConnection conn, Il2CppReferenceArray<NetworkObject> playerObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObjects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerList_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F24 RID: 24356 RVA: 0x001C45A0 File Offset: 0x001C27A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202895, XrefRangeEnd = 202900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayerData GetPlayerData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerData>(intPtr3) : null;
		}

		// Token: 0x06005F25 RID: 24357 RVA: 0x001C45E0 File Offset: 0x001C27E0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 202914, RefRangeEnd = 202925, XrefRangeStart = 202900, XrefRangeEnd = 202914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayerData GetPlayerData(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerData>(intPtr3) : null;
		}

		// Token: 0x06005F26 RID: 24358 RVA: 0x001C4630 File Offset: 0x001C2830
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 202930, RefRangeEnd = 202936, XrefRangeStart = 202925, XrefRangeEnd = 202930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayerData GetPlayerData(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerData>(intPtr3) : null;
		}

		// Token: 0x06005F27 RID: 24359 RVA: 0x001C467C File Offset: 0x001C287C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202936, XrefRangeEnd = 202959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPlayerBool(NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_SendPlayerBool_Public_Void_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F28 RID: 24360 RVA: 0x001C46E0 File Offset: 0x001C28E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 203002, RefRangeEnd = 203005, XrefRangeStart = 202959, XrefRangeEnd = 203002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceivePlayerBool(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_ReceivePlayerBool_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F29 RID: 24361 RVA: 0x001C4754 File Offset: 0x001C2954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203028, RefRangeEnd = 203029, XrefRangeStart = 203005, XrefRangeEnd = 203028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPlayerFloat(NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_SendPlayerFloat_Public_Void_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F2A RID: 24362 RVA: 0x001C47B8 File Offset: 0x001C29B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 203075, RefRangeEnd = 203078, XrefRangeStart = 203029, XrefRangeEnd = 203075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceivePlayerFloat(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_ReceivePlayerFloat_Private_Void_NetworkConnection_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F2B RID: 24363 RVA: 0x001C482C File Offset: 0x001C2A2C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 203087, RefRangeEnd = 203091, XrefRangeStart = 203078, XrefRangeEnd = 203087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<NetworkObject> GetPlayerObjects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerObjects_Private_Il2CppReferenceArray_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NetworkObject>>(intPtr3) : null;
		}

		// Token: 0x06005F2C RID: 24364 RVA: 0x001C486C File Offset: 0x001C2A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203091, XrefRangeEnd = 203106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayers() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F2D RID: 24365 RVA: 0x001C48A8 File Offset: 0x001C2AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203106, XrefRangeEnd = 203186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F2E RID: 24366 RVA: 0x001C48E4 File Offset: 0x001C2AE4
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F2F RID: 24367 RVA: 0x001C4920 File Offset: 0x001C2B20
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F30 RID: 24368 RVA: 0x001C495C File Offset: 0x001C2B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203186, XrefRangeEnd = 203196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestAddPlayer_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestAddPlayer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F31 RID: 24369 RVA: 0x001C49A0 File Offset: 0x001C2BA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 203235, RefRangeEnd = 203239, XrefRangeStart = 203196, XrefRangeEnd = 203235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestAddPlayer_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestAddPlayer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F32 RID: 24370 RVA: 0x001C49E4 File Offset: 0x001C2BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203239, XrefRangeEnd = 203243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestAddPlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestAddPlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F33 RID: 24371 RVA: 0x001C4A48 File Offset: 0x001C2C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestRemovePlayer_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F34 RID: 24372 RVA: 0x001C4A8C File Offset: 0x001C2C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203243, XrefRangeEnd = 203263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestRemovePlayer_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F35 RID: 24373 RVA: 0x001C4AD0 File Offset: 0x001C2CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203263, XrefRangeEnd = 203281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestRemovePlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F36 RID: 24374 RVA: 0x001C4B34 File Offset: 0x001C2D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestSetScore_4172557123(NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F37 RID: 24375 RVA: 0x001C4B84 File Offset: 0x001C2D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203281, XrefRangeEnd = 203282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestSetScore_4172557123(NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F38 RID: 24376 RVA: 0x001C4BD4 File Offset: 0x001C2DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203282, XrefRangeEnd = 203287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestSetScore_4172557123(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestSetScore_4172557123_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F39 RID: 24377 RVA: 0x001C4C38 File Offset: 0x001C2E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203287, XrefRangeEnd = 203299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F3A RID: 24378 RVA: 0x001C4C9C File Offset: 0x001C2E9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 203317, RefRangeEnd = 203320, XrefRangeStart = 203299, XrefRangeEnd = 203317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F3B RID: 24379 RVA: 0x001C4D00 File Offset: 0x001C2F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203320, XrefRangeEnd = 203326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetPlayerScore_1865307316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F3C RID: 24380 RVA: 0x001C4D50 File Offset: 0x001C2F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203326, XrefRangeEnd = 203338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F3D RID: 24381 RVA: 0x001C4DB4 File Offset: 0x001C2FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203338, XrefRangeEnd = 203344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetPlayerScore_1865307316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F3E RID: 24382 RVA: 0x001C4E04 File Offset: 0x001C3004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203344, XrefRangeEnd = 203354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetPlayerList_204172449(NetworkConnection conn, Il2CppReferenceArray<NetworkObject> playerObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObjects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F3F RID: 24383 RVA: 0x001C4E58 File Offset: 0x001C3058
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 203389, RefRangeEnd = 203392, XrefRangeStart = 203354, XrefRangeEnd = 203389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetPlayerList_204172449(NetworkConnection conn, Il2CppReferenceArray<NetworkObject> playerObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObjects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F40 RID: 24384 RVA: 0x001C4EAC File Offset: 0x001C30AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203392, XrefRangeEnd = 203396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetPlayerList_204172449(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F41 RID: 24385 RVA: 0x001C4EFC File Offset: 0x001C30FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203396, XrefRangeEnd = 203406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetPlayerList_204172449(NetworkConnection conn, Il2CppReferenceArray<NetworkObject> playerObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObjects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F42 RID: 24386 RVA: 0x001C4F50 File Offset: 0x001C3150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203406, XrefRangeEnd = 203410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetPlayerList_204172449(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F43 RID: 24387 RVA: 0x001C4FA0 File Offset: 0x001C31A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203410, XrefRangeEnd = 203422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPlayerBool_77262511(NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerBool_77262511_Private_Void_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F44 RID: 24388 RVA: 0x001C5004 File Offset: 0x001C3204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203422, XrefRangeEnd = 203423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPlayerBool_77262511(NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SendPlayerBool_77262511_Public_Void_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F45 RID: 24389 RVA: 0x001C5068 File Offset: 0x001C3268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203423, XrefRangeEnd = 203428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPlayerBool_77262511(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_SendPlayerBool_77262511_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F46 RID: 24390 RVA: 0x001C50CC File Offset: 0x001C32CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203428, XrefRangeEnd = 203440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F47 RID: 24391 RVA: 0x001C5140 File Offset: 0x001C3340
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 203463, RefRangeEnd = 203466, XrefRangeStart = 203440, XrefRangeEnd = 203463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F48 RID: 24392 RVA: 0x001C51B4 File Offset: 0x001C33B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203466, XrefRangeEnd = 203471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceivePlayerBool_1748594478(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F49 RID: 24393 RVA: 0x001C5204 File Offset: 0x001C3404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203471, XrefRangeEnd = 203483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F4A RID: 24394 RVA: 0x001C5278 File Offset: 0x001C3478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203483, XrefRangeEnd = 203488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceivePlayerBool_1748594478(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F4B RID: 24395 RVA: 0x001C52C8 File Offset: 0x001C34C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203488, XrefRangeEnd = 203500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPlayerFloat_2931762093(NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerFloat_2931762093_Private_Void_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F4C RID: 24396 RVA: 0x001C532C File Offset: 0x001C352C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203500, XrefRangeEnd = 203501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPlayerFloat_2931762093(NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SendPlayerFloat_2931762093_Public_Void_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F4D RID: 24397 RVA: 0x001C5390 File Offset: 0x001C3590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203501, XrefRangeEnd = 203507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPlayerFloat_2931762093(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_SendPlayerFloat_2931762093_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F4E RID: 24398 RVA: 0x001C53F4 File Offset: 0x001C35F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203507, XrefRangeEnd = 203519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F4F RID: 24399 RVA: 0x001C5468 File Offset: 0x001C3668
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 203542, RefRangeEnd = 203545, XrefRangeStart = 203519, XrefRangeEnd = 203542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F50 RID: 24400 RVA: 0x001C54DC File Offset: 0x001C36DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203545, XrefRangeEnd = 203551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceivePlayerFloat_2317689966(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F51 RID: 24401 RVA: 0x001C552C File Offset: 0x001C372C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203551, XrefRangeEnd = 203563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F52 RID: 24402 RVA: 0x001C55A0 File Offset: 0x001C37A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203563, XrefRangeEnd = 203569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceivePlayerFloat_2317689966(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F53 RID: 24403 RVA: 0x001C55F0 File Offset: 0x001C37F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203569, XrefRangeEnd = 203573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F54 RID: 24404 RVA: 0x0002CF7F File Offset: 0x0002B17F
		public CasinoGamePlayers(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D4D RID: 7501
		// (get) Token: 0x06005F55 RID: 24405 RVA: 0x001C5624 File Offset: 0x001C3824
		// (set) Token: 0x06005F56 RID: 24406 RVA: 0x0002CF88 File Offset: 0x0002B188
		public unsafe int PlayerLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_PlayerLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_PlayerLimit)) = value;
			}
		}

		// Token: 0x17001D4E RID: 7502
		// (get) Token: 0x06005F57 RID: 24407 RVA: 0x001C564C File Offset: 0x001C384C
		// (set) Token: 0x06005F58 RID: 24408 RVA: 0x0002CFA3 File Offset: 0x0002B1A3
		public unsafe Il2CppReferenceArray<Player> Players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_Players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D4F RID: 7503
		// (get) Token: 0x06005F59 RID: 24409 RVA: 0x001C567C File Offset: 0x001C387C
		// (set) Token: 0x06005F5A RID: 24410 RVA: 0x0002CFC2 File Offset: 0x0002B1C2
		public unsafe UnityEvent onPlayerListChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_onPlayerListChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_onPlayerListChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D50 RID: 7504
		// (get) Token: 0x06005F5B RID: 24411 RVA: 0x001C56AC File Offset: 0x001C38AC
		// (set) Token: 0x06005F5C RID: 24412 RVA: 0x0002CFE1 File Offset: 0x0002B1E1
		public unsafe UnityEvent onPlayerScoresChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_onPlayerScoresChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_onPlayerScoresChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D51 RID: 7505
		// (get) Token: 0x06005F5D RID: 24413 RVA: 0x001C56DC File Offset: 0x001C38DC
		// (set) Token: 0x06005F5E RID: 24414 RVA: 0x0002D000 File Offset: 0x0002B200
		public unsafe Dictionary<Player, int> playerScores
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_playerScores);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Player, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_playerScores), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D52 RID: 7506
		// (get) Token: 0x06005F5F RID: 24415 RVA: 0x001C570C File Offset: 0x001C390C
		// (set) Token: 0x06005F60 RID: 24416 RVA: 0x0002D01F File Offset: 0x0002B21F
		public unsafe Dictionary<Player, CasinoGamePlayerData> playerDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_playerDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Player, CasinoGamePlayerData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_playerDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D53 RID: 7507
		// (get) Token: 0x06005F61 RID: 24417 RVA: 0x001C573C File Offset: 0x001C393C
		// (set) Token: 0x06005F62 RID: 24418 RVA: 0x0002D03E File Offset: 0x0002B23E
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001D54 RID: 7508
		// (get) Token: 0x06005F63 RID: 24419 RVA: 0x001C5764 File Offset: 0x001C3964
		// (set) Token: 0x06005F64 RID: 24420 RVA: 0x0002D059 File Offset: 0x0002B259
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400416E RID: 16750
		private static readonly IntPtr NativeFieldInfoPtr_PlayerLimit;

		// Token: 0x0400416F RID: 16751
		private static readonly IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x04004170 RID: 16752
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerListChanged;

		// Token: 0x04004171 RID: 16753
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerScoresChanged;

		// Token: 0x04004172 RID: 16754
		private static readonly IntPtr NativeFieldInfoPtr_playerScores;

		// Token: 0x04004173 RID: 16755
		private static readonly IntPtr NativeFieldInfoPtr_playerDatas;

		// Token: 0x04004174 RID: 16756
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004175 RID: 16757
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004176 RID: 16758
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayerCount_Public_get_Int32_0;

		// Token: 0x04004177 RID: 16759
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004178 RID: 16760
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004179 RID: 16761
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0;

		// Token: 0x0400417A RID: 16762
		private static readonly IntPtr NativeMethodInfoPtr_RemovePlayer_Public_Void_Player_0;

		// Token: 0x0400417B RID: 16763
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerScore_Public_Void_Player_Int32_0;

		// Token: 0x0400417C RID: 16764
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerScore_Public_Int32_Player_0;

		// Token: 0x0400417D RID: 16765
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayer_Public_Player_Int32_0;

		// Token: 0x0400417E RID: 16766
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerIndex_Public_Int32_Player_0;

		// Token: 0x0400417F RID: 16767
		private static readonly IntPtr NativeMethodInfoPtr_RequestAddPlayer_Private_Void_NetworkObject_0;

		// Token: 0x04004180 RID: 16768
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayerToArray_Private_Void_Player_0;

		// Token: 0x04004181 RID: 16769
		private static readonly IntPtr NativeMethodInfoPtr_RequestRemovePlayer_Private_Void_NetworkObject_0;

		// Token: 0x04004182 RID: 16770
		private static readonly IntPtr NativeMethodInfoPtr_RemovePlayerFromArray_Private_Void_Player_0;

		// Token: 0x04004183 RID: 16771
		private static readonly IntPtr NativeMethodInfoPtr_RequestSetScore_Private_Void_NetworkObject_Int32_0;

		// Token: 0x04004184 RID: 16772
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerScore_Private_Void_NetworkConnection_NetworkObject_Int32_0;

		// Token: 0x04004185 RID: 16773
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerList_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0;

		// Token: 0x04004186 RID: 16774
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_0;

		// Token: 0x04004187 RID: 16775
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Player_0;

		// Token: 0x04004188 RID: 16776
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Int32_0;

		// Token: 0x04004189 RID: 16777
		private static readonly IntPtr NativeMethodInfoPtr_SendPlayerBool_Public_Void_NetworkObject_String_Boolean_0;

		// Token: 0x0400418A RID: 16778
		private static readonly IntPtr NativeMethodInfoPtr_ReceivePlayerBool_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0;

		// Token: 0x0400418B RID: 16779
		private static readonly IntPtr NativeMethodInfoPtr_SendPlayerFloat_Public_Void_NetworkObject_String_Single_0;

		// Token: 0x0400418C RID: 16780
		private static readonly IntPtr NativeMethodInfoPtr_ReceivePlayerFloat_Private_Void_NetworkConnection_NetworkObject_String_Single_0;

		// Token: 0x0400418D RID: 16781
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerObjects_Private_Il2CppReferenceArray_1_NetworkObject_0;

		// Token: 0x0400418E RID: 16782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400418F RID: 16783
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004190 RID: 16784
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004191 RID: 16785
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004192 RID: 16786
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestAddPlayer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004193 RID: 16787
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RequestAddPlayer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004194 RID: 16788
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestAddPlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004195 RID: 16789
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004196 RID: 16790
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004197 RID: 16791
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004198 RID: 16792
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0;

		// Token: 0x04004199 RID: 16793
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0;

		// Token: 0x0400419A RID: 16794
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestSetScore_4172557123_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400419B RID: 16795
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0;

		// Token: 0x0400419C RID: 16796
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0;

		// Token: 0x0400419D RID: 16797
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400419E RID: 16798
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0;

		// Token: 0x0400419F RID: 16799
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0;

		// Token: 0x040041A0 RID: 16800
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0;

		// Token: 0x040041A1 RID: 16801
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0;

		// Token: 0x040041A2 RID: 16802
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0;

		// Token: 0x040041A3 RID: 16803
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0;

		// Token: 0x040041A4 RID: 16804
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0;

		// Token: 0x040041A5 RID: 16805
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPlayerBool_77262511_Private_Void_NetworkObject_String_Boolean_0;

		// Token: 0x040041A6 RID: 16806
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendPlayerBool_77262511_Public_Void_NetworkObject_String_Boolean_0;

		// Token: 0x040041A7 RID: 16807
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPlayerBool_77262511_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040041A8 RID: 16808
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0;

		// Token: 0x040041A9 RID: 16809
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0;

		// Token: 0x040041AA RID: 16810
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0;

		// Token: 0x040041AB RID: 16811
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0;

		// Token: 0x040041AC RID: 16812
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0;

		// Token: 0x040041AD RID: 16813
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPlayerFloat_2931762093_Private_Void_NetworkObject_String_Single_0;

		// Token: 0x040041AE RID: 16814
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendPlayerFloat_2931762093_Public_Void_NetworkObject_String_Single_0;

		// Token: 0x040041AF RID: 16815
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPlayerFloat_2931762093_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040041B0 RID: 16816
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0;

		// Token: 0x040041B1 RID: 16817
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0;

		// Token: 0x040041B2 RID: 16818
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0;

		// Token: 0x040041B3 RID: 16819
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0;

		// Token: 0x040041B4 RID: 16820
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0;

		// Token: 0x040041B5 RID: 16821
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x02000B21 RID: 2849
		[ObfuscatedName("ScheduleOne.Casino.CasinoGamePlayers+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600E628 RID: 58920 RVA: 0x00383100 File Offset: 0x00381300
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr);
				CasinoGamePlayers.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr, "<>9");
				CasinoGamePlayers.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr, "<>9__2_0");
				CasinoGamePlayers.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr, 100675817);
				CasinoGamePlayers.__c.NativeMethodInfoPtr__get_CurrentPlayerCount_b__2_0_Internal_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr, 100675818);
			}

			// Token: 0x0600E629 RID: 58921 RVA: 0x0038317C File Offset: 0x0038137C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E62A RID: 58922 RVA: 0x003831B8 File Offset: 0x003813B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202596, XrefRangeEnd = 202600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_CurrentPlayerCount_b__2_0(Player p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.__c.NativeMethodInfoPtr__get_CurrentPlayerCount_b__2_0_Internal_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E62B RID: 58923 RVA: 0x0006C887 File Offset: 0x0006AA87
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045DE RID: 17886
			// (get) Token: 0x0600E62C RID: 58924 RVA: 0x00383208 File Offset: 0x00381408
			// (set) Token: 0x0600E62D RID: 58925 RVA: 0x0006C890 File Offset: 0x0006AA90
			public unsafe static CasinoGamePlayers.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CasinoGamePlayers.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CasinoGamePlayers.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045DF RID: 17887
			// (get) Token: 0x0600E62E RID: 58926 RVA: 0x00383230 File Offset: 0x00381430
			// (set) Token: 0x0600E62F RID: 58927 RVA: 0x0006C8A2 File Offset: 0x0006AAA2
			public unsafe static Func<Player, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CasinoGamePlayers.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Player, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CasinoGamePlayers.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009C2A RID: 39978
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009C2B RID: 39979
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04009C2C RID: 39980
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C2D RID: 39981
			private static readonly IntPtr NativeMethodInfoPtr__get_CurrentPlayerCount_b__2_0_Internal_Boolean_Player_0;
		}
	}
}
