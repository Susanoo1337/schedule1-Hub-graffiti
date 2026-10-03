using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x0200029C RID: 668
	public class MockLobbyService : Object
	{
		// Token: 0x060032AA RID: 12970 RVA: 0x00122958 File Offset: 0x00120B58
		// Note: this type is marked as 'beforefieldinit'.
		static MockLobbyService()
		{
			Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "MockLobbyService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr);
			MockLobbyService.NativeFieldInfoPtr_OnLobbyChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr, "OnLobbyChanged");
			MockLobbyService.NativeFieldInfoPtr_OnLobbyMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr, "OnLobbyMessage");
			MockLobbyService.NativeMethodInfoPtr_get_IsHost_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr, 100669622);
			MockLobbyService.NativeMethodInfoPtr_get_IsInLobby_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr, 100669623);
			MockLobbyService.NativeMethodInfoPtr_get_PlayerCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr, 100669624);
			MockLobbyService.NativeMethodInfoPtr_add_OnLobbyChanged_Public_Virtual_Final_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr, 100669625);
			MockLobbyService.NativeMethodInfoPtr_remove_OnLobbyChanged_Public_Virtual_Final_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr, 100669626);
			MockLobbyService.NativeMethodInfoPtr_add_OnLobbyMessage_Public_Virtual_Final_New_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr, 100669627);
			MockLobbyService.NativeMethodInfoPtr_remove_OnLobbyMessage_Public_Virtual_Final_New_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr, 100669628);
			MockLobbyService.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr, 100669629);
			MockLobbyService.NativeMethodInfoPtr_CreateLobby_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr, 100669630);
			MockLobbyService.NativeMethodInfoPtr_JoinLobby_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr, 100669631);
			MockLobbyService.NativeMethodInfoPtr_LeaveLobby_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr, 100669632);
			MockLobbyService.NativeMethodInfoPtr_SetLobbyData_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr, 100669633);
			MockLobbyService.NativeMethodInfoPtr_GetLobbyData_Public_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr, 100669634);
			MockLobbyService.NativeMethodInfoPtr_GetPlayerIds_Public_Virtual_Final_New_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr, 100669635);
			MockLobbyService.NativeMethodInfoPtr_SendMessage_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr, 100669636);
			MockLobbyService.NativeMethodInfoPtr_OpenInviteUI_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr, 100669637);
			MockLobbyService.NativeMethodInfoPtr_CloseInviteUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr, 100669638);
			MockLobbyService.NativeMethodInfoPtr_OnLobbyMessageReceived_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr, 100669639);
			MockLobbyService.NativeMethodInfoPtr_GetSessionConnectionIdentifier_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr, 100669640);
			MockLobbyService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr, 100669641);
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x060032AB RID: 12971 RVA: 0x00122B40 File Offset: 0x00120D40
		public unsafe virtual bool IsHost
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MockLobbyService.NativeMethodInfoPtr_get_IsHost_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x060032AC RID: 12972 RVA: 0x00122B7C File Offset: 0x00120D7C
		public unsafe virtual bool IsInLobby
		{
			[CallerCount(170)]
			[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MockLobbyService.NativeMethodInfoPtr_get_IsInLobby_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x060032AD RID: 12973 RVA: 0x00122BB8 File Offset: 0x00120DB8
		public unsafe virtual int PlayerCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 70633, RefRangeEnd = 70636, XrefRangeStart = 70633, XrefRangeEnd = 70636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MockLobbyService.NativeMethodInfoPtr_get_PlayerCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x00122BF4 File Offset: 0x00120DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136933, XrefRangeEnd = 136937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_OnLobbyChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MockLobbyService.NativeMethodInfoPtr_add_OnLobbyChanged_Public_Virtual_Final_New_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x00122C38 File Offset: 0x00120E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136937, XrefRangeEnd = 136941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_OnLobbyChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MockLobbyService.NativeMethodInfoPtr_remove_OnLobbyChanged_Public_Virtual_Final_New_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x00122C7C File Offset: 0x00120E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136941, XrefRangeEnd = 136946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_OnLobbyMessage(Action<string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MockLobbyService.NativeMethodInfoPtr_add_OnLobbyMessage_Public_Virtual_Final_New_add_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x00122CC0 File Offset: 0x00120EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136946, XrefRangeEnd = 136951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_OnLobbyMessage(Action<string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MockLobbyService.NativeMethodInfoPtr_remove_OnLobbyMessage_Public_Virtual_Final_New_rem_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x00122D04 File Offset: 0x00120F04
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MockLobbyService.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x00122D38 File Offset: 0x00120F38
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CreateLobby(int maxPlayers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref maxPlayers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MockLobbyService.NativeMethodInfoPtr_CreateLobby_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x00122D78 File Offset: 0x00120F78
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void JoinLobby(string lobbyID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(lobbyID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MockLobbyService.NativeMethodInfoPtr_JoinLobby_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032B5 RID: 12981 RVA: 0x00122DBC File Offset: 0x00120FBC
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LeaveLobby()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MockLobbyService.NativeMethodInfoPtr_LeaveLobby_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032B6 RID: 12982 RVA: 0x00122DF0 File Offset: 0x00120FF0
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLobbyData(string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MockLobbyService.NativeMethodInfoPtr_SetLobbyData_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x00122E44 File Offset: 0x00121044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136951, XrefRangeEnd = 136953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLobbyData(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MockLobbyService.NativeMethodInfoPtr_GetLobbyData_Public_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060032B8 RID: 12984 RVA: 0x00122E8C File Offset: 0x0012108C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136953, XrefRangeEnd = 136964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> GetPlayerIds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MockLobbyService.NativeMethodInfoPtr_GetPlayerIds_Public_Virtual_Final_New_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x060032B9 RID: 12985 RVA: 0x00122ECC File Offset: 0x001210CC
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendMessage(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MockLobbyService.NativeMethodInfoPtr_SendMessage_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032BA RID: 12986 RVA: 0x00122F10 File Offset: 0x00121110
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OpenInviteUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MockLobbyService.NativeMethodInfoPtr_OpenInviteUI_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032BB RID: 12987 RVA: 0x00122F44 File Offset: 0x00121144
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseInviteUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MockLobbyService.NativeMethodInfoPtr_CloseInviteUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032BC RID: 12988 RVA: 0x00122F78 File Offset: 0x00121178
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLobbyMessageReceived(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MockLobbyService.NativeMethodInfoPtr_OnLobbyMessageReceived_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032BD RID: 12989 RVA: 0x00122FBC File Offset: 0x001211BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136964, XrefRangeEnd = 136966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSessionConnectionIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MockLobbyService.NativeMethodInfoPtr_GetSessionConnectionIdentifier_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060032BE RID: 12990 RVA: 0x00122FF4 File Offset: 0x001211F4
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MockLobbyService() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MockLobbyService>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MockLobbyService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032BF RID: 12991 RVA: 0x0001A0F1 File Offset: 0x000182F1
		public MockLobbyService(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x060032C0 RID: 12992 RVA: 0x00123030 File Offset: 0x00121230
		// (set) Token: 0x060032C1 RID: 12993 RVA: 0x0001A0FA File Offset: 0x000182FA
		public unsafe Action OnLobbyChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MockLobbyService.NativeFieldInfoPtr_OnLobbyChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MockLobbyService.NativeFieldInfoPtr_OnLobbyChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x060032C2 RID: 12994 RVA: 0x00123060 File Offset: 0x00121260
		// (set) Token: 0x060032C3 RID: 12995 RVA: 0x0001A119 File Offset: 0x00018319
		public unsafe Action<string> OnLobbyMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MockLobbyService.NativeFieldInfoPtr_OnLobbyMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MockLobbyService.NativeFieldInfoPtr_OnLobbyMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040021C3 RID: 8643
		private static readonly IntPtr NativeFieldInfoPtr_OnLobbyChanged;

		// Token: 0x040021C4 RID: 8644
		private static readonly IntPtr NativeFieldInfoPtr_OnLobbyMessage;

		// Token: 0x040021C5 RID: 8645
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHost_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040021C6 RID: 8646
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInLobby_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040021C7 RID: 8647
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040021C8 RID: 8648
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLobbyChanged_Public_Virtual_Final_New_add_Void_Action_0;

		// Token: 0x040021C9 RID: 8649
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLobbyChanged_Public_Virtual_Final_New_rem_Void_Action_0;

		// Token: 0x040021CA RID: 8650
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLobbyMessage_Public_Virtual_Final_New_add_Void_Action_1_String_0;

		// Token: 0x040021CB RID: 8651
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLobbyMessage_Public_Virtual_Final_New_rem_Void_Action_1_String_0;

		// Token: 0x040021CC RID: 8652
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x040021CD RID: 8653
		private static readonly IntPtr NativeMethodInfoPtr_CreateLobby_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x040021CE RID: 8654
		private static readonly IntPtr NativeMethodInfoPtr_JoinLobby_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x040021CF RID: 8655
		private static readonly IntPtr NativeMethodInfoPtr_LeaveLobby_Public_Virtual_Final_New_Void_0;

		// Token: 0x040021D0 RID: 8656
		private static readonly IntPtr NativeMethodInfoPtr_SetLobbyData_Public_Virtual_Final_New_Void_String_String_0;

		// Token: 0x040021D1 RID: 8657
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyData_Public_Virtual_Final_New_String_String_0;

		// Token: 0x040021D2 RID: 8658
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerIds_Public_Virtual_Final_New_List_1_String_0;

		// Token: 0x040021D3 RID: 8659
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x040021D4 RID: 8660
		private static readonly IntPtr NativeMethodInfoPtr_OpenInviteUI_Public_Virtual_Final_New_Void_0;

		// Token: 0x040021D5 RID: 8661
		private static readonly IntPtr NativeMethodInfoPtr_CloseInviteUI_Public_Void_0;

		// Token: 0x040021D6 RID: 8662
		private static readonly IntPtr NativeMethodInfoPtr_OnLobbyMessageReceived_Public_Void_String_0;

		// Token: 0x040021D7 RID: 8663
		private static readonly IntPtr NativeMethodInfoPtr_GetSessionConnectionIdentifier_Public_Virtual_Final_New_String_0;

		// Token: 0x040021D8 RID: 8664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
