using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSteamworks;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x0200029F RID: 671
	public class SteamLobbyService : Object
	{
		// Token: 0x060032FE RID: 13054 RVA: 0x00123E28 File Offset: 0x00122028
		// Note: this type is marked as 'beforefieldinit'.
		static SteamLobbyService()
		{
			Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "SteamLobbyService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr);
			SteamLobbyService.NativeFieldInfoPtr_OnLobbyChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, "OnLobbyChanged");
			SteamLobbyService.NativeFieldInfoPtr_OnLobbyMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, "OnLobbyMessage");
			SteamLobbyService.NativeFieldInfoPtr___lobbyID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, "<_lobbyID>k__BackingField");
			SteamLobbyService.NativeFieldInfoPtr___localPlayerID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, "<_localPlayerID>k__BackingField");
			SteamLobbyService.NativeFieldInfoPtr__players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, "_players");
			SteamLobbyService.NativeFieldInfoPtr__lobbyCreatedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, "_lobbyCreatedCallback");
			SteamLobbyService.NativeFieldInfoPtr__lobbyEnteredCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, "_lobbyEnteredCallback");
			SteamLobbyService.NativeFieldInfoPtr__chatUpdateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, "_chatUpdateCallback");
			SteamLobbyService.NativeFieldInfoPtr__gameLobbyJoinRequestedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, "_gameLobbyJoinRequestedCallback");
			SteamLobbyService.NativeFieldInfoPtr__lobbyChatMessageCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, "_lobbyChatMessageCallback");
			SteamLobbyService.NativeMethodInfoPtr_get_IsInLobby_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669684);
			SteamLobbyService.NativeMethodInfoPtr_get_IsHost_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669685);
			SteamLobbyService.NativeMethodInfoPtr_get_PlayerCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669686);
			SteamLobbyService.NativeMethodInfoPtr_add_OnLobbyChanged_Public_Virtual_Final_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669687);
			SteamLobbyService.NativeMethodInfoPtr_remove_OnLobbyChanged_Public_Virtual_Final_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669688);
			SteamLobbyService.NativeMethodInfoPtr_add_OnLobbyMessage_Public_Virtual_Final_New_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669689);
			SteamLobbyService.NativeMethodInfoPtr_remove_OnLobbyMessage_Public_Virtual_Final_New_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669690);
			SteamLobbyService.NativeMethodInfoPtr_get__lobbyID_Private_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669691);
			SteamLobbyService.NativeMethodInfoPtr_set__lobbyID_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669692);
			SteamLobbyService.NativeMethodInfoPtr_get__lobbySteamID_Private_get_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669693);
			SteamLobbyService.NativeMethodInfoPtr_get__localPlayerID_Private_get_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669694);
			SteamLobbyService.NativeMethodInfoPtr_set__localPlayerID_Private_set_Void_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669695);
			SteamLobbyService.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669696);
			SteamLobbyService.NativeMethodInfoPtr_CreateLobby_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669697);
			SteamLobbyService.NativeMethodInfoPtr_JoinLobby_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669698);
			SteamLobbyService.NativeMethodInfoPtr_LeaveLobby_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669699);
			SteamLobbyService.NativeMethodInfoPtr_SetLobbyData_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669700);
			SteamLobbyService.NativeMethodInfoPtr_GetLobbyData_Public_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669701);
			SteamLobbyService.NativeMethodInfoPtr_UpdateLobbyMembers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669702);
			SteamLobbyService.NativeMethodInfoPtr_JoinAsClient_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669703);
			SteamLobbyService.NativeMethodInfoPtr_SendMessage_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669704);
			SteamLobbyService.NativeMethodInfoPtr_OpenInviteUI_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669705);
			SteamLobbyService.NativeMethodInfoPtr_GetPlayerIds_Public_Virtual_Final_New_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669706);
			SteamLobbyService.NativeMethodInfoPtr_GetSessionConnectionIdentifier_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669707);
			SteamLobbyService.NativeMethodInfoPtr_OnLobbyCreated_Private_Void_LobbyCreated_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669708);
			SteamLobbyService.NativeMethodInfoPtr_OnLobbyEntered_Private_Void_LobbyEnter_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669709);
			SteamLobbyService.NativeMethodInfoPtr_PlayerEnterOrLeave_Private_Void_LobbyChatUpdate_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669710);
			SteamLobbyService.NativeMethodInfoPtr_LobbyJoinRequested_Private_Void_GameLobbyJoinRequested_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669711);
			SteamLobbyService.NativeMethodInfoPtr_OnLobbyChatMessage_Private_Void_LobbyChatMsg_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669712);
			SteamLobbyService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, 100669713);
		}

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x060032FF RID: 13055 RVA: 0x00124178 File Offset: 0x00122378
		public unsafe virtual bool IsInLobby
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 137245, RefRangeEnd = 137253, XrefRangeStart = 137245, XrefRangeEnd = 137245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_get_IsInLobby_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x06003300 RID: 13056 RVA: 0x001241B4 File Offset: 0x001223B4
		public unsafe virtual bool IsHost
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 137254, RefRangeEnd = 137256, XrefRangeStart = 137253, XrefRangeEnd = 137254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_get_IsHost_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x06003301 RID: 13057 RVA: 0x001241F0 File Offset: 0x001223F0
		public unsafe virtual int PlayerCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137256, XrefRangeEnd = 137274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_get_PlayerCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x0012422C File Offset: 0x0012242C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137274, XrefRangeEnd = 137278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_OnLobbyChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_add_OnLobbyChanged_Public_Virtual_Final_New_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x00124270 File Offset: 0x00122470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137278, XrefRangeEnd = 137282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_OnLobbyChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_remove_OnLobbyChanged_Public_Virtual_Final_New_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003304 RID: 13060 RVA: 0x001242B4 File Offset: 0x001224B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137282, XrefRangeEnd = 137287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_OnLobbyMessage(Action<string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_add_OnLobbyMessage_Public_Virtual_Final_New_add_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003305 RID: 13061 RVA: 0x001242F8 File Offset: 0x001224F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137287, XrefRangeEnd = 137292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_OnLobbyMessage(Action<string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_remove_OnLobbyMessage_Public_Virtual_Final_New_rem_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x06003306 RID: 13062 RVA: 0x0012433C File Offset: 0x0012253C
		// (set) Token: 0x06003307 RID: 13063 RVA: 0x00124378 File Offset: 0x00122578
		public unsafe ulong _lobbyID
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_get__lobbyID_Private_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_set__lobbyID_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x06003308 RID: 13064 RVA: 0x001243B8 File Offset: 0x001225B8
		public unsafe CSteamID _lobbySteamID
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_get__lobbySteamID_Private_get_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x06003309 RID: 13065 RVA: 0x001243F4 File Offset: 0x001225F4
		// (set) Token: 0x0600330A RID: 13066 RVA: 0x00124430 File Offset: 0x00122630
		public unsafe CSteamID _localPlayerID
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_get__localPlayerID_Private_get_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 136688, RefRangeEnd = 136689, XrefRangeStart = 136688, XrefRangeEnd = 136689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_set__localPlayerID_Private_set_Void_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x00124470 File Offset: 0x00122670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137292, XrefRangeEnd = 137343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x001244A4 File Offset: 0x001226A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137343, XrefRangeEnd = 137344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CreateLobby(int maxPlayers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref maxPlayers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_CreateLobby_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x001244E4 File Offset: 0x001226E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137344, XrefRangeEnd = 137352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void JoinLobby(string lobbyId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(lobbyId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_JoinLobby_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x00124528 File Offset: 0x00122728
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137362, RefRangeEnd = 137364, XrefRangeStart = 137352, XrefRangeEnd = 137362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LeaveLobby()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_LeaveLobby_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x0012455C File Offset: 0x0012275C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137364, XrefRangeEnd = 137371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLobbyData(string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_SetLobbyData_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x001245B0 File Offset: 0x001227B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137371, XrefRangeEnd = 137380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLobbyData(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_GetLobbyData_Public_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x001245F8 File Offset: 0x001227F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 137387, RefRangeEnd = 137391, XrefRangeStart = 137380, XrefRangeEnd = 137387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLobbyMembers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_UpdateLobbyMembers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x0012462C File Offset: 0x0012282C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137397, RefRangeEnd = 137398, XrefRangeStart = 137391, XrefRangeEnd = 137397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void JoinAsClient(string steamId64)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(steamId64);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_JoinAsClient_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x00124670 File Offset: 0x00122870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137398, XrefRangeEnd = 137407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendMessage(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_SendMessage_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x001246B4 File Offset: 0x001228B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137407, XrefRangeEnd = 137422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OpenInviteUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_OpenInviteUI_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x001246E8 File Offset: 0x001228E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137422, XrefRangeEnd = 137438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> GetPlayerIds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_GetPlayerIds_Public_Virtual_Final_New_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x00124728 File Offset: 0x00122928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137438, XrefRangeEnd = 137440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSessionConnectionIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_GetSessionConnectionIdentifier_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x00124760 File Offset: 0x00122960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137440, XrefRangeEnd = 137487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLobbyCreated(LobbyCreated_t result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_OnLobbyCreated_Private_Void_LobbyCreated_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x001247A0 File Offset: 0x001229A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137487, XrefRangeEnd = 137541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLobbyEntered(LobbyEnter_t result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_OnLobbyEntered_Private_Void_LobbyEnter_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x001247E0 File Offset: 0x001229E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137541, XrefRangeEnd = 137556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerEnterOrLeave(LobbyChatUpdate_t result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_PlayerEnterOrLeave_Private_Void_LobbyChatUpdate_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x00124820 File Offset: 0x00122A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137556, XrefRangeEnd = 137569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LobbyJoinRequested(GameLobbyJoinRequested_t result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_LobbyJoinRequested_Private_Void_GameLobbyJoinRequested_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x00124860 File Offset: 0x00122A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137569, XrefRangeEnd = 137606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLobbyChatMessage(LobbyChatMsg_t result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr_OnLobbyChatMessage_Private_Void_LobbyChatMsg_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x001248A0 File Offset: 0x00122AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137606, XrefRangeEnd = 137615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamLobbyService() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x0001A280 File Offset: 0x00018480
		public SteamLobbyService(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x0600331E RID: 13086 RVA: 0x001248DC File Offset: 0x00122ADC
		// (set) Token: 0x0600331F RID: 13087 RVA: 0x0001A289 File Offset: 0x00018489
		public unsafe Action OnLobbyChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamLobbyService.NativeFieldInfoPtr_OnLobbyChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamLobbyService.NativeFieldInfoPtr_OnLobbyChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x06003320 RID: 13088 RVA: 0x0012490C File Offset: 0x00122B0C
		// (set) Token: 0x06003321 RID: 13089 RVA: 0x0001A2A8 File Offset: 0x000184A8
		public unsafe Action<string> OnLobbyMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamLobbyService.NativeFieldInfoPtr_OnLobbyMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamLobbyService.NativeFieldInfoPtr_OnLobbyMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x06003322 RID: 13090 RVA: 0x0012493C File Offset: 0x00122B3C
		// (set) Token: 0x06003323 RID: 13091 RVA: 0x0001A2C7 File Offset: 0x000184C7
		public unsafe ulong __lobbyID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamLobbyService.NativeFieldInfoPtr___lobbyID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamLobbyService.NativeFieldInfoPtr___lobbyID_k__BackingField)) = value;
			}
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x06003324 RID: 13092 RVA: 0x00124964 File Offset: 0x00122B64
		// (set) Token: 0x06003325 RID: 13093 RVA: 0x0001A2E2 File Offset: 0x000184E2
		public unsafe CSteamID __localPlayerID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamLobbyService.NativeFieldInfoPtr___localPlayerID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamLobbyService.NativeFieldInfoPtr___localPlayerID_k__BackingField)) = value;
			}
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x06003326 RID: 13094 RVA: 0x0012498C File Offset: 0x00122B8C
		// (set) Token: 0x06003327 RID: 13095 RVA: 0x0001A2FD File Offset: 0x000184FD
		public unsafe Il2CppStructArray<CSteamID> _players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamLobbyService.NativeFieldInfoPtr__players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<CSteamID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamLobbyService.NativeFieldInfoPtr__players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x06003328 RID: 13096 RVA: 0x001249BC File Offset: 0x00122BBC
		// (set) Token: 0x06003329 RID: 13097 RVA: 0x0001A31C File Offset: 0x0001851C
		public unsafe Callback<LobbyCreated_t> _lobbyCreatedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamLobbyService.NativeFieldInfoPtr__lobbyCreatedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<LobbyCreated_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamLobbyService.NativeFieldInfoPtr__lobbyCreatedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x0600332A RID: 13098 RVA: 0x001249EC File Offset: 0x00122BEC
		// (set) Token: 0x0600332B RID: 13099 RVA: 0x0001A33B File Offset: 0x0001853B
		public unsafe Callback<LobbyEnter_t> _lobbyEnteredCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamLobbyService.NativeFieldInfoPtr__lobbyEnteredCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<LobbyEnter_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamLobbyService.NativeFieldInfoPtr__lobbyEnteredCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x0600332C RID: 13100 RVA: 0x00124A1C File Offset: 0x00122C1C
		// (set) Token: 0x0600332D RID: 13101 RVA: 0x0001A35A File Offset: 0x0001855A
		public unsafe Callback<LobbyChatUpdate_t> _chatUpdateCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamLobbyService.NativeFieldInfoPtr__chatUpdateCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<LobbyChatUpdate_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamLobbyService.NativeFieldInfoPtr__chatUpdateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x0600332E RID: 13102 RVA: 0x00124A4C File Offset: 0x00122C4C
		// (set) Token: 0x0600332F RID: 13103 RVA: 0x0001A379 File Offset: 0x00018579
		public unsafe Callback<GameLobbyJoinRequested_t> _gameLobbyJoinRequestedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamLobbyService.NativeFieldInfoPtr__gameLobbyJoinRequestedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<GameLobbyJoinRequested_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamLobbyService.NativeFieldInfoPtr__gameLobbyJoinRequestedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x06003330 RID: 13104 RVA: 0x00124A7C File Offset: 0x00122C7C
		// (set) Token: 0x06003331 RID: 13105 RVA: 0x0001A398 File Offset: 0x00018598
		public unsafe Callback<LobbyChatMsg_t> _lobbyChatMessageCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamLobbyService.NativeFieldInfoPtr__lobbyChatMessageCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<LobbyChatMsg_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamLobbyService.NativeFieldInfoPtr__lobbyChatMessageCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002203 RID: 8707
		private static readonly IntPtr NativeFieldInfoPtr_OnLobbyChanged;

		// Token: 0x04002204 RID: 8708
		private static readonly IntPtr NativeFieldInfoPtr_OnLobbyMessage;

		// Token: 0x04002205 RID: 8709
		private static readonly IntPtr NativeFieldInfoPtr___lobbyID_k__BackingField;

		// Token: 0x04002206 RID: 8710
		private static readonly IntPtr NativeFieldInfoPtr___localPlayerID_k__BackingField;

		// Token: 0x04002207 RID: 8711
		private static readonly IntPtr NativeFieldInfoPtr__players;

		// Token: 0x04002208 RID: 8712
		private static readonly IntPtr NativeFieldInfoPtr__lobbyCreatedCallback;

		// Token: 0x04002209 RID: 8713
		private static readonly IntPtr NativeFieldInfoPtr__lobbyEnteredCallback;

		// Token: 0x0400220A RID: 8714
		private static readonly IntPtr NativeFieldInfoPtr__chatUpdateCallback;

		// Token: 0x0400220B RID: 8715
		private static readonly IntPtr NativeFieldInfoPtr__gameLobbyJoinRequestedCallback;

		// Token: 0x0400220C RID: 8716
		private static readonly IntPtr NativeFieldInfoPtr__lobbyChatMessageCallback;

		// Token: 0x0400220D RID: 8717
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInLobby_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400220E RID: 8718
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHost_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400220F RID: 8719
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04002210 RID: 8720
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLobbyChanged_Public_Virtual_Final_New_add_Void_Action_0;

		// Token: 0x04002211 RID: 8721
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLobbyChanged_Public_Virtual_Final_New_rem_Void_Action_0;

		// Token: 0x04002212 RID: 8722
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLobbyMessage_Public_Virtual_Final_New_add_Void_Action_1_String_0;

		// Token: 0x04002213 RID: 8723
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLobbyMessage_Public_Virtual_Final_New_rem_Void_Action_1_String_0;

		// Token: 0x04002214 RID: 8724
		private static readonly IntPtr NativeMethodInfoPtr_get__lobbyID_Private_get_UInt64_0;

		// Token: 0x04002215 RID: 8725
		private static readonly IntPtr NativeMethodInfoPtr_set__lobbyID_Private_set_Void_UInt64_0;

		// Token: 0x04002216 RID: 8726
		private static readonly IntPtr NativeMethodInfoPtr_get__lobbySteamID_Private_get_CSteamID_0;

		// Token: 0x04002217 RID: 8727
		private static readonly IntPtr NativeMethodInfoPtr_get__localPlayerID_Private_get_CSteamID_0;

		// Token: 0x04002218 RID: 8728
		private static readonly IntPtr NativeMethodInfoPtr_set__localPlayerID_Private_set_Void_CSteamID_0;

		// Token: 0x04002219 RID: 8729
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400221A RID: 8730
		private static readonly IntPtr NativeMethodInfoPtr_CreateLobby_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x0400221B RID: 8731
		private static readonly IntPtr NativeMethodInfoPtr_JoinLobby_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x0400221C RID: 8732
		private static readonly IntPtr NativeMethodInfoPtr_LeaveLobby_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400221D RID: 8733
		private static readonly IntPtr NativeMethodInfoPtr_SetLobbyData_Public_Virtual_Final_New_Void_String_String_0;

		// Token: 0x0400221E RID: 8734
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyData_Public_Virtual_Final_New_String_String_0;

		// Token: 0x0400221F RID: 8735
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLobbyMembers_Private_Void_0;

		// Token: 0x04002220 RID: 8736
		private static readonly IntPtr NativeMethodInfoPtr_JoinAsClient_Public_Void_String_0;

		// Token: 0x04002221 RID: 8737
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04002222 RID: 8738
		private static readonly IntPtr NativeMethodInfoPtr_OpenInviteUI_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002223 RID: 8739
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerIds_Public_Virtual_Final_New_List_1_String_0;

		// Token: 0x04002224 RID: 8740
		private static readonly IntPtr NativeMethodInfoPtr_GetSessionConnectionIdentifier_Public_Virtual_Final_New_String_0;

		// Token: 0x04002225 RID: 8741
		private static readonly IntPtr NativeMethodInfoPtr_OnLobbyCreated_Private_Void_LobbyCreated_t_0;

		// Token: 0x04002226 RID: 8742
		private static readonly IntPtr NativeMethodInfoPtr_OnLobbyEntered_Private_Void_LobbyEnter_t_0;

		// Token: 0x04002227 RID: 8743
		private static readonly IntPtr NativeMethodInfoPtr_PlayerEnterOrLeave_Private_Void_LobbyChatUpdate_t_0;

		// Token: 0x04002228 RID: 8744
		private static readonly IntPtr NativeMethodInfoPtr_LobbyJoinRequested_Private_Void_GameLobbyJoinRequested_t_0;

		// Token: 0x04002229 RID: 8745
		private static readonly IntPtr NativeMethodInfoPtr_OnLobbyChatMessage_Private_Void_LobbyChatMsg_t_0;

		// Token: 0x0400222A RID: 8746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009FE RID: 2558
		[ObfuscatedName("ScheduleOne.Networking.SteamLobbyService+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600DD52 RID: 56658 RVA: 0x0036A4BC File Offset: 0x003686BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SteamLobbyService.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamLobbyService>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamLobbyService.__c>.NativeClassPtr);
				SteamLobbyService.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLobbyService.__c>.NativeClassPtr, "<>9");
				SteamLobbyService.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLobbyService.__c>.NativeClassPtr, "<>9__5_0");
				SteamLobbyService.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService.__c>.NativeClassPtr, 100669715);
				SteamLobbyService.__c.NativeMethodInfoPtr__get_PlayerCount_b__5_0_Internal_Boolean_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobbyService.__c>.NativeClassPtr, 100669716);
			}

			// Token: 0x0600DD53 RID: 56659 RVA: 0x0036A538 File Offset: 0x00368738
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamLobbyService.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD54 RID: 56660 RVA: 0x0036A574 File Offset: 0x00368774
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137240, XrefRangeEnd = 137245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_PlayerCount_b__5_0(CSteamID p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLobbyService.__c.NativeMethodInfoPtr__get_PlayerCount_b__5_0_Internal_Boolean_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD55 RID: 56661 RVA: 0x000682E3 File Offset: 0x000664E3
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004366 RID: 17254
			// (get) Token: 0x0600DD56 RID: 56662 RVA: 0x0036A5C0 File Offset: 0x003687C0
			// (set) Token: 0x0600DD57 RID: 56663 RVA: 0x000682EC File Offset: 0x000664EC
			public unsafe static SteamLobbyService.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamLobbyService.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamLobbyService.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamLobbyService.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004367 RID: 17255
			// (get) Token: 0x0600DD58 RID: 56664 RVA: 0x0036A5E8 File Offset: 0x003687E8
			// (set) Token: 0x0600DD59 RID: 56665 RVA: 0x000682FE File Offset: 0x000664FE
			public unsafe static Func<CSteamID, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamLobbyService.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CSteamID, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamLobbyService.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096E2 RID: 38626
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040096E3 RID: 38627
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040096E4 RID: 38628
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096E5 RID: 38629
			private static readonly IntPtr NativeMethodInfoPtr__get_PlayerCount_b__5_0_Internal_Boolean_CSteamID_0;
		}
	}
}
