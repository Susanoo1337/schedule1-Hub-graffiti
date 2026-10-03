using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x0200029A RID: 666
	public class Lobby : PersistentSingleton<Lobby>
	{
		// Token: 0x06003281 RID: 12929 RVA: 0x00122038 File Offset: 0x00120238
		// Note: this type is marked as 'beforefieldinit'.
		static Lobby()
		{
			Il2CppClassPointerStore<Lobby>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "Lobby");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lobby>.NativeClassPtr);
			Lobby.NativeFieldInfoPtr_PlayerLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "PlayerLimit");
			Lobby.NativeFieldInfoPtr_JoinReadyMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "JoinReadyMessage");
			Lobby.NativeFieldInfoPtr_LoadTutorialMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "LoadTutorialMessage");
			Lobby.NativeFieldInfoPtr_HostLoadingMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "HostLoadingMessage");
			Lobby.NativeFieldInfoPtr__LobbyID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "<LobbyID>k__BackingField");
			Lobby.NativeFieldInfoPtr_OnLobbyChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "OnLobbyChange");
			Lobby.NativeFieldInfoPtr__lobbyService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "_lobbyService");
			Lobby.NativeMethodInfoPtr_get_IsHost_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100669599);
			Lobby.NativeMethodInfoPtr_get_LobbyID_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100669600);
			Lobby.NativeMethodInfoPtr_set_LobbyID_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100669601);
			Lobby.NativeMethodInfoPtr_get_IsInLobby_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100669602);
			Lobby.NativeMethodInfoPtr_get_PlayerCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100669603);
			Lobby.NativeMethodInfoPtr_add_OnLobbyChange_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100669604);
			Lobby.NativeMethodInfoPtr_remove_OnLobbyChange_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100669605);
			Lobby.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100669606);
			Lobby.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100669607);
			Lobby.NativeMethodInfoPtr_CreateLobbyService_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100669608);
			Lobby.NativeMethodInfoPtr_TryOpenInviteInterface_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100669609);
			Lobby.NativeMethodInfoPtr_CreateLobby_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100669610);
			Lobby.NativeMethodInfoPtr_LeaveLobby_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100669611);
			Lobby.NativeMethodInfoPtr_GetLaunchLobby_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100669612);
			Lobby.NativeMethodInfoPtr_GetLobbyMemberIDs_Public_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100669613);
			Lobby.NativeMethodInfoPtr_SendLobbyMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100669614);
			Lobby.NativeMethodInfoPtr_SetLobbyData_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100669615);
			Lobby.NativeMethodInfoPtr_IsSessionReadyForClient_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100669616);
			Lobby.NativeMethodInfoPtr_GetSessionConnectionIdentifier_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100669617);
			Lobby.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100669618);
			Lobby.NativeMethodInfoPtr__Start_b__19_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100669619);
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x06003282 RID: 12930 RVA: 0x00122298 File Offset: 0x00120498
		public unsafe bool IsHost
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 136670, RefRangeEnd = 136688, XrefRangeStart = 136669, XrefRangeEnd = 136670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_IsHost_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x06003283 RID: 12931 RVA: 0x001222D4 File Offset: 0x001204D4
		// (set) Token: 0x06003284 RID: 12932 RVA: 0x00122310 File Offset: 0x00120510
		public unsafe ulong LobbyID
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_LobbyID_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 136688, RefRangeEnd = 136689, XrefRangeStart = 136688, XrefRangeEnd = 136688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_set_LobbyID_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x06003285 RID: 12933 RVA: 0x00122350 File Offset: 0x00120550
		public unsafe bool IsInLobby
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 136690, RefRangeEnd = 136711, XrefRangeStart = 136689, XrefRangeEnd = 136690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_IsInLobby_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x06003286 RID: 12934 RVA: 0x0012238C File Offset: 0x0012058C
		public unsafe int PlayerCount
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 136714, RefRangeEnd = 136718, XrefRangeStart = 136711, XrefRangeEnd = 136714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_PlayerCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003287 RID: 12935 RVA: 0x001223C8 File Offset: 0x001205C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136722, RefRangeEnd = 136723, XrefRangeStart = 136718, XrefRangeEnd = 136722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnLobbyChange(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_add_OnLobbyChange_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003288 RID: 12936 RVA: 0x0012240C File Offset: 0x0012060C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136727, RefRangeEnd = 136728, XrefRangeStart = 136723, XrefRangeEnd = 136727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnLobbyChange(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_remove_OnLobbyChange_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x00122450 File Offset: 0x00120650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136728, XrefRangeEnd = 136745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lobby.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600328A RID: 12938 RVA: 0x0012248C File Offset: 0x0012068C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136745, XrefRangeEnd = 136816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lobby.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x001224C8 File Offset: 0x001206C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136816, XrefRangeEnd = 136841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateLobbyService()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_CreateLobbyService_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x001224FC File Offset: 0x001206FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136858, RefRangeEnd = 136859, XrefRangeStart = 136841, XrefRangeEnd = 136858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryOpenInviteInterface()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_TryOpenInviteInterface_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x00122530 File Offset: 0x00120730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136859, XrefRangeEnd = 136864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateLobby()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_CreateLobby_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600328E RID: 12942 RVA: 0x00122564 File Offset: 0x00120764
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 136868, RefRangeEnd = 136870, XrefRangeStart = 136864, XrefRangeEnd = 136868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LeaveLobby()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_LeaveLobby_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600328F RID: 12943 RVA: 0x00122598 File Offset: 0x00120798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136870, XrefRangeEnd = 136877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLaunchLobby()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_GetLaunchLobby_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x001225D0 File Offset: 0x001207D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136881, RefRangeEnd = 136882, XrefRangeStart = 136877, XrefRangeEnd = 136881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> GetLobbyMemberIDs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_GetLobbyMemberIDs_Public_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x00122610 File Offset: 0x00120810
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 136886, RefRangeEnd = 136889, XrefRangeStart = 136882, XrefRangeEnd = 136886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendLobbyMessage(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_SendLobbyMessage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x00122654 File Offset: 0x00120854
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 136894, RefRangeEnd = 136898, XrefRangeStart = 136889, XrefRangeEnd = 136894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLobbyData(string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_SetLobbyData_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003293 RID: 12947 RVA: 0x001226A8 File Offset: 0x001208A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136898, XrefRangeEnd = 136908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSessionReadyForClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_IsSessionReadyForClient_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003294 RID: 12948 RVA: 0x001226E4 File Offset: 0x001208E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136908, XrefRangeEnd = 136912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSessionConnectionIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_GetSessionConnectionIdentifier_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003295 RID: 12949 RVA: 0x0012271C File Offset: 0x0012091C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136912, XrefRangeEnd = 136915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lobby() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lobby>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003296 RID: 12950 RVA: 0x00122758 File Offset: 0x00120958
		[CallerCount(0)]
		public unsafe void _Start_b__19_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr__Start_b__19_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003297 RID: 12951 RVA: 0x0001A042 File Offset: 0x00018242
		public Lobby(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x06003298 RID: 12952 RVA: 0x0012278C File Offset: 0x0012098C
		// (set) Token: 0x06003299 RID: 12953 RVA: 0x0001A04B File Offset: 0x0001824B
		public unsafe static int PlayerLimit
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Lobby.NativeFieldInfoPtr_PlayerLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lobby.NativeFieldInfoPtr_PlayerLimit, (void*)(&value));
			}
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x0600329A RID: 12954 RVA: 0x001227A8 File Offset: 0x001209A8
		// (set) Token: 0x0600329B RID: 12955 RVA: 0x0001A059 File Offset: 0x00018259
		public unsafe static string JoinReadyMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Lobby.NativeFieldInfoPtr_JoinReadyMessage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lobby.NativeFieldInfoPtr_JoinReadyMessage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x0600329C RID: 12956 RVA: 0x001227C8 File Offset: 0x001209C8
		// (set) Token: 0x0600329D RID: 12957 RVA: 0x0001A06B File Offset: 0x0001826B
		public unsafe static string LoadTutorialMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Lobby.NativeFieldInfoPtr_LoadTutorialMessage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lobby.NativeFieldInfoPtr_LoadTutorialMessage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x0600329E RID: 12958 RVA: 0x001227E8 File Offset: 0x001209E8
		// (set) Token: 0x0600329F RID: 12959 RVA: 0x0001A07D File Offset: 0x0001827D
		public unsafe static string HostLoadingMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Lobby.NativeFieldInfoPtr_HostLoadingMessage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lobby.NativeFieldInfoPtr_HostLoadingMessage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x060032A0 RID: 12960 RVA: 0x00122808 File Offset: 0x00120A08
		// (set) Token: 0x060032A1 RID: 12961 RVA: 0x0001A08F File Offset: 0x0001828F
		public unsafe ulong _LobbyID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr__LobbyID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr__LobbyID_k__BackingField)) = value;
			}
		}

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x060032A2 RID: 12962 RVA: 0x00122830 File Offset: 0x00120A30
		// (set) Token: 0x060032A3 RID: 12963 RVA: 0x0001A0AA File Offset: 0x000182AA
		public unsafe Action OnLobbyChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_OnLobbyChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_OnLobbyChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x060032A4 RID: 12964 RVA: 0x00122860 File Offset: 0x00120A60
		// (set) Token: 0x060032A5 RID: 12965 RVA: 0x0001A0C9 File Offset: 0x000182C9
		public unsafe ILobbyService _lobbyService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr__lobbyService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILobbyService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr__lobbyService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040021A5 RID: 8613
		private static readonly IntPtr NativeFieldInfoPtr_PlayerLimit;

		// Token: 0x040021A6 RID: 8614
		private static readonly IntPtr NativeFieldInfoPtr_JoinReadyMessage;

		// Token: 0x040021A7 RID: 8615
		private static readonly IntPtr NativeFieldInfoPtr_LoadTutorialMessage;

		// Token: 0x040021A8 RID: 8616
		private static readonly IntPtr NativeFieldInfoPtr_HostLoadingMessage;

		// Token: 0x040021A9 RID: 8617
		private static readonly IntPtr NativeFieldInfoPtr__LobbyID_k__BackingField;

		// Token: 0x040021AA RID: 8618
		private static readonly IntPtr NativeFieldInfoPtr_OnLobbyChange;

		// Token: 0x040021AB RID: 8619
		private static readonly IntPtr NativeFieldInfoPtr__lobbyService;

		// Token: 0x040021AC RID: 8620
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHost_Public_get_Boolean_0;

		// Token: 0x040021AD RID: 8621
		private static readonly IntPtr NativeMethodInfoPtr_get_LobbyID_Public_get_UInt64_0;

		// Token: 0x040021AE RID: 8622
		private static readonly IntPtr NativeMethodInfoPtr_set_LobbyID_Private_set_Void_UInt64_0;

		// Token: 0x040021AF RID: 8623
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInLobby_Public_get_Boolean_0;

		// Token: 0x040021B0 RID: 8624
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerCount_Public_get_Int32_0;

		// Token: 0x040021B1 RID: 8625
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLobbyChange_Public_add_Void_Action_0;

		// Token: 0x040021B2 RID: 8626
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLobbyChange_Public_rem_Void_Action_0;

		// Token: 0x040021B3 RID: 8627
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040021B4 RID: 8628
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040021B5 RID: 8629
		private static readonly IntPtr NativeMethodInfoPtr_CreateLobbyService_Private_Void_0;

		// Token: 0x040021B6 RID: 8630
		private static readonly IntPtr NativeMethodInfoPtr_TryOpenInviteInterface_Public_Void_0;

		// Token: 0x040021B7 RID: 8631
		private static readonly IntPtr NativeMethodInfoPtr_CreateLobby_Public_Void_0;

		// Token: 0x040021B8 RID: 8632
		private static readonly IntPtr NativeMethodInfoPtr_LeaveLobby_Public_Void_0;

		// Token: 0x040021B9 RID: 8633
		private static readonly IntPtr NativeMethodInfoPtr_GetLaunchLobby_Private_String_0;

		// Token: 0x040021BA RID: 8634
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyMemberIDs_Public_List_1_String_0;

		// Token: 0x040021BB RID: 8635
		private static readonly IntPtr NativeMethodInfoPtr_SendLobbyMessage_Public_Void_String_0;

		// Token: 0x040021BC RID: 8636
		private static readonly IntPtr NativeMethodInfoPtr_SetLobbyData_Public_Void_String_String_0;

		// Token: 0x040021BD RID: 8637
		private static readonly IntPtr NativeMethodInfoPtr_IsSessionReadyForClient_Public_Boolean_0;

		// Token: 0x040021BE RID: 8638
		private static readonly IntPtr NativeMethodInfoPtr_GetSessionConnectionIdentifier_Public_String_0;

		// Token: 0x040021BF RID: 8639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040021C0 RID: 8640
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__19_0_Private_Void_0;
	}
}
