using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x020002A3 RID: 675
	public class IMessageEntity : Il2CppObjectBase
	{
		// Token: 0x0600333F RID: 13119 RVA: 0x00124D44 File Offset: 0x00122F44
		// Note: this type is marked as 'beforefieldinit'.
		static IMessageEntity()
		{
			Il2CppClassPointerStore<IMessageEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "IMessageEntity");
			IMessageEntity.NativeMethodInfoPtr_get_MsgConversation_Public_Abstract_Virtual_New_get_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageEntity>.NativeClassPtr, 100669723);
			IMessageEntity.NativeMethodInfoPtr_set_MsgConversation_Public_Abstract_Virtual_New_set_Void_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageEntity>.NativeClassPtr, 100669724);
			IMessageEntity.NativeMethodInfoPtr_add_onResponseChosen_Public_Abstract_Virtual_New_add_Void_ResponseCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageEntity>.NativeClassPtr, 100669725);
			IMessageEntity.NativeMethodInfoPtr_remove_onResponseChosen_Public_Abstract_Virtual_New_rem_Void_ResponseCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageEntity>.NativeClassPtr, 100669726);
		}

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x06003340 RID: 13120 RVA: 0x00124DBC File Offset: 0x00122FBC
		// (set) Token: 0x06003341 RID: 13121 RVA: 0x00124E08 File Offset: 0x00123008
		public unsafe virtual MSGConversation MsgConversation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageEntity.NativeMethodInfoPtr_get_MsgConversation_Public_Abstract_Virtual_New_get_MSGConversation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageEntity.NativeMethodInfoPtr_set_MsgConversation_Public_Abstract_Virtual_New_set_Void_MSGConversation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x00124E58 File Offset: 0x00123058
		[CallerCount(0)]
		public unsafe virtual void add_onResponseChosen(ResponseCallback value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageEntity.NativeMethodInfoPtr_add_onResponseChosen_Public_Abstract_Virtual_New_add_Void_ResponseCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003343 RID: 13123 RVA: 0x00124EA8 File Offset: 0x001230A8
		[CallerCount(0)]
		public unsafe virtual void remove_onResponseChosen(ResponseCallback value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageEntity.NativeMethodInfoPtr_remove_onResponseChosen_Public_Abstract_Virtual_New_rem_Void_ResponseCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003344 RID: 13124 RVA: 0x0001A3F0 File Offset: 0x000185F0
		public IMessageEntity(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002235 RID: 8757
		private static readonly IntPtr NativeMethodInfoPtr_get_MsgConversation_Public_Abstract_Virtual_New_get_MSGConversation_0;

		// Token: 0x04002236 RID: 8758
		private static readonly IntPtr NativeMethodInfoPtr_set_MsgConversation_Public_Abstract_Virtual_New_set_Void_MSGConversation_0;

		// Token: 0x04002237 RID: 8759
		private static readonly IntPtr NativeMethodInfoPtr_add_onResponseChosen_Public_Abstract_Virtual_New_add_Void_ResponseCallback_0;

		// Token: 0x04002238 RID: 8760
		private static readonly IntPtr NativeMethodInfoPtr_remove_onResponseChosen_Public_Abstract_Virtual_New_rem_Void_ResponseCallback_0;
	}
}
