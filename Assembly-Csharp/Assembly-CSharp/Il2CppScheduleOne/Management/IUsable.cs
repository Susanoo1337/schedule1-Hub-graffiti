using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002EF RID: 751
	public class IUsable : Il2CppObjectBase
	{
		// Token: 0x06003B7B RID: 15227 RVA: 0x00143C24 File Offset: 0x00141E24
		// Note: this type is marked as 'beforefieldinit'.
		static IUsable()
		{
			Il2CppClassPointerStore<IUsable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "IUsable");
			IUsable.NativeMethodInfoPtr_get_IsInUse_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100670927);
			IUsable.NativeMethodInfoPtr_get_IsUsedByLocalPlayer_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100670928);
			IUsable.NativeMethodInfoPtr_get_NPCUserObject_Public_Abstract_Virtual_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100670929);
			IUsable.NativeMethodInfoPtr_set_NPCUserObject_Public_Abstract_Virtual_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100670930);
			IUsable.NativeMethodInfoPtr_get_PlayerUserObject_Public_Abstract_Virtual_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100670931);
			IUsable.NativeMethodInfoPtr_set_PlayerUserObject_Public_Abstract_Virtual_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100670932);
			IUsable.NativeMethodInfoPtr_get_UserName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100670933);
			IUsable.NativeMethodInfoPtr_IsInUseByNPC_Public_Virtual_New_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100670934);
			IUsable.NativeMethodInfoPtr_SetPlayerUser_Public_Abstract_Virtual_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100670935);
			IUsable.NativeMethodInfoPtr_SetNPCUser_Public_Abstract_Virtual_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100670936);
		}

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x06003B7C RID: 15228 RVA: 0x00143D14 File Offset: 0x00141F14
		public unsafe virtual bool IsInUse
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150252, XrefRangeEnd = 150259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_get_IsInUse_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x06003B7D RID: 15229 RVA: 0x00143D5C File Offset: 0x00141F5C
		public unsafe virtual bool IsUsedByLocalPlayer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150259, XrefRangeEnd = 150266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_get_IsUsedByLocalPlayer_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x06003B7E RID: 15230 RVA: 0x00143DA4 File Offset: 0x00141FA4
		// (set) Token: 0x06003B7F RID: 15231 RVA: 0x00143DF0 File Offset: 0x00141FF0
		public unsafe virtual NetworkObject NPCUserObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_get_NPCUserObject_Public_Abstract_Virtual_New_get_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_set_NPCUserObject_Public_Abstract_Virtual_New_set_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x06003B80 RID: 15232 RVA: 0x00143E40 File Offset: 0x00142040
		// (set) Token: 0x06003B81 RID: 15233 RVA: 0x00143E8C File Offset: 0x0014208C
		public unsafe virtual NetworkObject PlayerUserObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_get_PlayerUserObject_Public_Abstract_Virtual_New_get_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_set_PlayerUserObject_Public_Abstract_Virtual_New_set_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x06003B82 RID: 15234 RVA: 0x00143EDC File Offset: 0x001420DC
		public unsafe virtual string UserName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150266, XrefRangeEnd = 150282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_get_UserName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003B83 RID: 15235 RVA: 0x00143F20 File Offset: 0x00142120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150282, XrefRangeEnd = 150290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsInUseByNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_IsInUseByNPC_Public_Virtual_New_Boolean_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003B84 RID: 15236 RVA: 0x00143F78 File Offset: 0x00142178
		[CallerCount(0)]
		public unsafe virtual void SetPlayerUser(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_SetPlayerUser_Public_Abstract_Virtual_New_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B85 RID: 15237 RVA: 0x00143FC8 File Offset: 0x001421C8
		[CallerCount(0)]
		public unsafe virtual void SetNPCUser(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_SetNPCUser_Public_Abstract_Virtual_New_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B86 RID: 15238 RVA: 0x0001DAD8 File Offset: 0x0001BCD8
		public IUsable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002826 RID: 10278
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInUse_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04002827 RID: 10279
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUsedByLocalPlayer_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04002828 RID: 10280
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCUserObject_Public_Abstract_Virtual_New_get_NetworkObject_0;

		// Token: 0x04002829 RID: 10281
		private static readonly IntPtr NativeMethodInfoPtr_set_NPCUserObject_Public_Abstract_Virtual_New_set_Void_NetworkObject_0;

		// Token: 0x0400282A RID: 10282
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerUserObject_Public_Abstract_Virtual_New_get_NetworkObject_0;

		// Token: 0x0400282B RID: 10283
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerUserObject_Public_Abstract_Virtual_New_set_Void_NetworkObject_0;

		// Token: 0x0400282C RID: 10284
		private static readonly IntPtr NativeMethodInfoPtr_get_UserName_Public_Virtual_New_get_String_0;

		// Token: 0x0400282D RID: 10285
		private static readonly IntPtr NativeMethodInfoPtr_IsInUseByNPC_Public_Virtual_New_Boolean_NPC_0;

		// Token: 0x0400282E RID: 10286
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerUser_Public_Abstract_Virtual_New_Void_NetworkObject_0;

		// Token: 0x0400282F RID: 10287
		private static readonly IntPtr NativeMethodInfoPtr_SetNPCUser_Public_Abstract_Virtual_New_Void_NetworkObject_0;
	}
}
