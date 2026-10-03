using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x0200024E RID: 590
	public class INotificationReceiver : Il2CppObjectBase
	{
		// Token: 0x0600291E RID: 10526 RVA: 0x00012732 File Offset: 0x00010932
		// Note: this type is marked as 'beforefieldinit'.
		static INotificationReceiver()
		{
			Il2CppClassPointerStore<INotificationReceiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "INotificationReceiver");
			INotificationReceiver.NativeMethodInfoPtr_OnNotify_Public_Abstract_Virtual_New_Void_Playable_INotification_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INotificationReceiver>.NativeClassPtr, 100667675);
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x000A0480 File Offset: 0x0009E680
		[CallerCount(0)]
		public unsafe virtual void OnNotify(Playable origin, INotification notification, Object context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(notification);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INotificationReceiver.NativeMethodInfoPtr_OnNotify_Public_Abstract_Virtual_New_Void_Playable_INotification_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x00012761 File Offset: 0x00010961
		public INotificationReceiver(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040022F4 RID: 8948
		private static readonly IntPtr NativeMethodInfoPtr_OnNotify_Public_Abstract_Virtual_New_Void_Playable_INotification_Object_0;
	}
}
