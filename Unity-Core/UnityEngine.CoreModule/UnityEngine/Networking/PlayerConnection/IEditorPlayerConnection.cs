using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Events;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x020001CD RID: 461
	public class IEditorPlayerConnection : Il2CppObjectBase
	{
		// Token: 0x060020E7 RID: 8423 RVA: 0x00085C28 File Offset: 0x00083E28
		// Note: this type is marked as 'beforefieldinit'.
		static IEditorPlayerConnection()
		{
			Il2CppClassPointerStore<IEditorPlayerConnection>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Networking.PlayerConnection", "IEditorPlayerConnection");
			IEditorPlayerConnection.NativeMethodInfoPtr_Register_Public_Abstract_Virtual_New_Void_Guid_UnityAction_1_MessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEditorPlayerConnection>.NativeClassPtr, 100666869);
			IEditorPlayerConnection.NativeMethodInfoPtr_RegisterConnection_Public_Abstract_Virtual_New_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEditorPlayerConnection>.NativeClassPtr, 100666870);
			IEditorPlayerConnection.NativeMethodInfoPtr_RegisterDisconnection_Public_Abstract_Virtual_New_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEditorPlayerConnection>.NativeClassPtr, 100666871);
			IEditorPlayerConnection.NativeMethodInfoPtr_Send_Public_Abstract_Virtual_New_Void_Guid_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEditorPlayerConnection>.NativeClassPtr, 100666872);
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x00085CA0 File Offset: 0x00083EA0
		[CallerCount(0)]
		public unsafe virtual void Register(Guid messageId, UnityEngine.Events.UnityAction<MessageEventArgs> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref messageId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEditorPlayerConnection.NativeMethodInfoPtr_Register_Public_Abstract_Virtual_New_Void_Guid_UnityAction_1_MessageEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x00085CFC File Offset: 0x00083EFC
		[CallerCount(0)]
		public unsafe virtual void RegisterConnection(UnityEngine.Events.UnityAction<int> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEditorPlayerConnection.NativeMethodInfoPtr_RegisterConnection_Public_Abstract_Virtual_New_Void_UnityAction_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x00085D4C File Offset: 0x00083F4C
		[CallerCount(0)]
		public unsafe virtual void RegisterDisconnection(UnityEngine.Events.UnityAction<int> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEditorPlayerConnection.NativeMethodInfoPtr_RegisterDisconnection_Public_Abstract_Virtual_New_Void_UnityAction_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x00085D9C File Offset: 0x00083F9C
		[CallerCount(0)]
		public unsafe virtual void Send(Guid messageId, Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref messageId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEditorPlayerConnection.NativeMethodInfoPtr_Send_Public_Abstract_Virtual_New_Void_Guid_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x0000F3F6 File Offset: 0x0000D5F6
		public IEditorPlayerConnection(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001A72 RID: 6770
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Abstract_Virtual_New_Void_Guid_UnityAction_1_MessageEventArgs_0;

		// Token: 0x04001A73 RID: 6771
		private static readonly IntPtr NativeMethodInfoPtr_RegisterConnection_Public_Abstract_Virtual_New_Void_UnityAction_1_Int32_0;

		// Token: 0x04001A74 RID: 6772
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDisconnection_Public_Abstract_Virtual_New_Void_UnityAction_1_Int32_0;

		// Token: 0x04001A75 RID: 6773
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Abstract_Virtual_New_Void_Guid_Il2CppStructArray_1_Byte_0;
	}
}
