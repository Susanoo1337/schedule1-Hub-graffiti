using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Playables
{
	// Token: 0x0200024D RID: 589
	public class INotification : Il2CppObjectBase
	{
		// Token: 0x0600291B RID: 10523 RVA: 0x000126FA File Offset: 0x000108FA
		// Note: this type is marked as 'beforefieldinit'.
		static INotification()
		{
			Il2CppClassPointerStore<INotification>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "INotification");
			INotification.NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INotification>.NativeClassPtr, 100667674);
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x0600291C RID: 10524 RVA: 0x000A0438 File Offset: 0x0009E638
		public unsafe virtual PropertyName id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INotification.NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_PropertyName_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x00012729 File Offset: 0x00010929
		public INotification(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040022F3 RID: 8947
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_PropertyName_0;
	}
}
