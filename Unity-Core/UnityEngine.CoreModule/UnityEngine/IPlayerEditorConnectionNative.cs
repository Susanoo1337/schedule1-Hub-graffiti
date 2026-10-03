using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000104 RID: 260
	public class IPlayerEditorConnectionNative : Il2CppObjectBase
	{
		// Token: 0x0600163D RID: 5693 RVA: 0x00061768 File Offset: 0x0005F968
		// Note: this type is marked as 'beforefieldinit'.
		static IPlayerEditorConnectionNative()
		{
			Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "IPlayerEditorConnectionNative");
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100665627);
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_DisconnectAll_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100665628);
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_SendMessage_Public_Abstract_Virtual_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100665629);
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_TrySendMessage_Public_Abstract_Virtual_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100665630);
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_Poll_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100665631);
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_RegisterInternal_Public_Abstract_Virtual_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100665632);
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_UnregisterInternal_Public_Abstract_Virtual_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100665633);
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_IsConnected_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100665634);
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00061830 File Offset: 0x0005FA30
		[CallerCount(0)]
		public unsafe virtual void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x0006186C File Offset: 0x0005FA6C
		[CallerCount(0)]
		public unsafe virtual void DisconnectAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_DisconnectAll_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x000618A8 File Offset: 0x0005FAA8
		[CallerCount(0)]
		public unsafe virtual void SendMessage(Guid messageId, Il2CppStructArray<byte> data, int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref messageId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_SendMessage_Public_Abstract_Virtual_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00061914 File Offset: 0x0005FB14
		[CallerCount(0)]
		public unsafe virtual bool TrySendMessage(Guid messageId, Il2CppStructArray<byte> data, int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref messageId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_TrySendMessage_Public_Abstract_Virtual_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00061988 File Offset: 0x0005FB88
		[CallerCount(0)]
		public unsafe virtual void Poll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_Poll_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x000619C4 File Offset: 0x0005FBC4
		[CallerCount(0)]
		public unsafe virtual void RegisterInternal(Guid messageId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref messageId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_RegisterInternal_Public_Abstract_Virtual_New_Void_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00061A10 File Offset: 0x0005FC10
		[CallerCount(0)]
		public unsafe virtual void UnregisterInternal(Guid messageId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref messageId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_UnregisterInternal_Public_Abstract_Virtual_New_Void_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00061A5C File Offset: 0x0005FC5C
		[CallerCount(0)]
		public unsafe virtual bool IsConnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_IsConnected_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x0000B35D File Offset: 0x0000955D
		public IPlayerEditorConnectionNative(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001328 RID: 4904
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001329 RID: 4905
		private static readonly IntPtr NativeMethodInfoPtr_DisconnectAll_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400132A RID: 4906
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Abstract_Virtual_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400132B RID: 4907
		private static readonly IntPtr NativeMethodInfoPtr_TrySendMessage_Public_Abstract_Virtual_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400132C RID: 4908
		private static readonly IntPtr NativeMethodInfoPtr_Poll_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400132D RID: 4909
		private static readonly IntPtr NativeMethodInfoPtr_RegisterInternal_Public_Abstract_Virtual_New_Void_Guid_0;

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterInternal_Public_Abstract_Virtual_New_Void_Guid_0;

		// Token: 0x0400132F RID: 4911
		private static readonly IntPtr NativeMethodInfoPtr_IsConnected_Public_Abstract_Virtual_New_Boolean_0;
	}
}
