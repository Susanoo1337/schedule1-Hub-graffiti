using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x02000298 RID: 664
	public class ILobbyService : Il2CppObjectBase
	{
		// Token: 0x0600326A RID: 12906 RVA: 0x001218EC File Offset: 0x0011FAEC
		// Note: this type is marked as 'beforefieldinit'.
		static ILobbyService()
		{
			Il2CppClassPointerStore<ILobbyService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "ILobbyService");
			ILobbyService.NativeMethodInfoPtr_get_IsInLobby_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILobbyService>.NativeClassPtr, 100669580);
			ILobbyService.NativeMethodInfoPtr_get_IsHost_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILobbyService>.NativeClassPtr, 100669581);
			ILobbyService.NativeMethodInfoPtr_get_PlayerCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILobbyService>.NativeClassPtr, 100669582);
			ILobbyService.NativeMethodInfoPtr_add_OnLobbyChanged_Public_Abstract_Virtual_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILobbyService>.NativeClassPtr, 100669583);
			ILobbyService.NativeMethodInfoPtr_remove_OnLobbyChanged_Public_Abstract_Virtual_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILobbyService>.NativeClassPtr, 100669584);
			ILobbyService.NativeMethodInfoPtr_add_OnLobbyMessage_Public_Abstract_Virtual_New_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILobbyService>.NativeClassPtr, 100669585);
			ILobbyService.NativeMethodInfoPtr_remove_OnLobbyMessage_Public_Abstract_Virtual_New_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILobbyService>.NativeClassPtr, 100669586);
			ILobbyService.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILobbyService>.NativeClassPtr, 100669587);
			ILobbyService.NativeMethodInfoPtr_CreateLobby_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILobbyService>.NativeClassPtr, 100669588);
			ILobbyService.NativeMethodInfoPtr_JoinLobby_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILobbyService>.NativeClassPtr, 100669589);
			ILobbyService.NativeMethodInfoPtr_LeaveLobby_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILobbyService>.NativeClassPtr, 100669590);
			ILobbyService.NativeMethodInfoPtr_OpenInviteUI_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILobbyService>.NativeClassPtr, 100669591);
			ILobbyService.NativeMethodInfoPtr_SendMessage_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILobbyService>.NativeClassPtr, 100669592);
			ILobbyService.NativeMethodInfoPtr_SetLobbyData_Public_Abstract_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILobbyService>.NativeClassPtr, 100669593);
			ILobbyService.NativeMethodInfoPtr_GetLobbyData_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILobbyService>.NativeClassPtr, 100669594);
			ILobbyService.NativeMethodInfoPtr_GetPlayerIds_Public_Abstract_Virtual_New_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILobbyService>.NativeClassPtr, 100669595);
			ILobbyService.NativeMethodInfoPtr_GetSessionConnectionIdentifier_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILobbyService>.NativeClassPtr, 100669596);
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x0600326B RID: 12907 RVA: 0x00121A68 File Offset: 0x0011FC68
		public unsafe virtual bool IsInLobby
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILobbyService.NativeMethodInfoPtr_get_IsInLobby_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x0600326C RID: 12908 RVA: 0x00121AB0 File Offset: 0x0011FCB0
		public unsafe virtual bool IsHost
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILobbyService.NativeMethodInfoPtr_get_IsHost_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x0600326D RID: 12909 RVA: 0x00121AF8 File Offset: 0x0011FCF8
		public unsafe virtual int PlayerCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILobbyService.NativeMethodInfoPtr_get_PlayerCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600326E RID: 12910 RVA: 0x00121B40 File Offset: 0x0011FD40
		[CallerCount(0)]
		public unsafe virtual void add_OnLobbyChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILobbyService.NativeMethodInfoPtr_add_OnLobbyChanged_Public_Abstract_Virtual_New_add_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600326F RID: 12911 RVA: 0x00121B90 File Offset: 0x0011FD90
		[CallerCount(0)]
		public unsafe virtual void remove_OnLobbyChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILobbyService.NativeMethodInfoPtr_remove_OnLobbyChanged_Public_Abstract_Virtual_New_rem_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003270 RID: 12912 RVA: 0x00121BE0 File Offset: 0x0011FDE0
		[CallerCount(0)]
		public unsafe virtual void add_OnLobbyMessage(Action<string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILobbyService.NativeMethodInfoPtr_add_OnLobbyMessage_Public_Abstract_Virtual_New_add_Void_Action_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003271 RID: 12913 RVA: 0x00121C30 File Offset: 0x0011FE30
		[CallerCount(0)]
		public unsafe virtual void remove_OnLobbyMessage(Action<string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILobbyService.NativeMethodInfoPtr_remove_OnLobbyMessage_Public_Abstract_Virtual_New_rem_Void_Action_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003272 RID: 12914 RVA: 0x00121C80 File Offset: 0x0011FE80
		[CallerCount(0)]
		public unsafe virtual void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILobbyService.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x00121CBC File Offset: 0x0011FEBC
		[CallerCount(0)]
		public unsafe virtual void CreateLobby(int maxPlayers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref maxPlayers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILobbyService.NativeMethodInfoPtr_CreateLobby_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003274 RID: 12916 RVA: 0x00121D08 File Offset: 0x0011FF08
		[CallerCount(0)]
		public unsafe virtual void JoinLobby(string lobbyId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(lobbyId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILobbyService.NativeMethodInfoPtr_JoinLobby_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003275 RID: 12917 RVA: 0x00121D58 File Offset: 0x0011FF58
		[CallerCount(0)]
		public unsafe virtual void LeaveLobby()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILobbyService.NativeMethodInfoPtr_LeaveLobby_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x00121D94 File Offset: 0x0011FF94
		[CallerCount(0)]
		public unsafe virtual void OpenInviteUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILobbyService.NativeMethodInfoPtr_OpenInviteUI_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x00121DD0 File Offset: 0x0011FFD0
		[CallerCount(0)]
		public unsafe virtual void SendMessage(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILobbyService.NativeMethodInfoPtr_SendMessage_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003278 RID: 12920 RVA: 0x00121E20 File Offset: 0x00120020
		[CallerCount(0)]
		public unsafe virtual void SetLobbyData(string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILobbyService.NativeMethodInfoPtr_SetLobbyData_Public_Abstract_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003279 RID: 12921 RVA: 0x00121E80 File Offset: 0x00120080
		[CallerCount(0)]
		public unsafe virtual string GetLobbyData(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILobbyService.NativeMethodInfoPtr_GetLobbyData_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x00121ED4 File Offset: 0x001200D4
		[CallerCount(0)]
		public unsafe virtual List<string> GetPlayerIds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILobbyService.NativeMethodInfoPtr_GetPlayerIds_Public_Abstract_Virtual_New_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x0600327B RID: 12923 RVA: 0x00121F20 File Offset: 0x00120120
		[CallerCount(0)]
		public unsafe virtual string GetSessionConnectionIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILobbyService.NativeMethodInfoPtr_GetSessionConnectionIdentifier_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600327C RID: 12924 RVA: 0x0001A030 File Offset: 0x00018230
		public ILobbyService(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002192 RID: 8594
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInLobby_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04002193 RID: 8595
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHost_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04002194 RID: 8596
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04002195 RID: 8597
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLobbyChanged_Public_Abstract_Virtual_New_add_Void_Action_0;

		// Token: 0x04002196 RID: 8598
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLobbyChanged_Public_Abstract_Virtual_New_rem_Void_Action_0;

		// Token: 0x04002197 RID: 8599
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLobbyMessage_Public_Abstract_Virtual_New_add_Void_Action_1_String_0;

		// Token: 0x04002198 RID: 8600
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLobbyMessage_Public_Abstract_Virtual_New_rem_Void_Action_1_String_0;

		// Token: 0x04002199 RID: 8601
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400219A RID: 8602
		private static readonly IntPtr NativeMethodInfoPtr_CreateLobby_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x0400219B RID: 8603
		private static readonly IntPtr NativeMethodInfoPtr_JoinLobby_Public_Abstract_Virtual_New_Void_String_0;

		// Token: 0x0400219C RID: 8604
		private static readonly IntPtr NativeMethodInfoPtr_LeaveLobby_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400219D RID: 8605
		private static readonly IntPtr NativeMethodInfoPtr_OpenInviteUI_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400219E RID: 8606
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Abstract_Virtual_New_Void_String_0;

		// Token: 0x0400219F RID: 8607
		private static readonly IntPtr NativeMethodInfoPtr_SetLobbyData_Public_Abstract_Virtual_New_Void_String_String_0;

		// Token: 0x040021A0 RID: 8608
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyData_Public_Abstract_Virtual_New_String_String_0;

		// Token: 0x040021A1 RID: 8609
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerIds_Public_Abstract_Virtual_New_List_1_String_0;

		// Token: 0x040021A2 RID: 8610
		private static readonly IntPtr NativeMethodInfoPtr_GetSessionConnectionIdentifier_Public_Abstract_Virtual_New_String_0;
	}
}
