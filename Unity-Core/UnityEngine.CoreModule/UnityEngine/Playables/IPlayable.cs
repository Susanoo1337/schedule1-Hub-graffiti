using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Playables
{
	// Token: 0x0200024F RID: 591
	public class IPlayable : Il2CppObjectBase
	{
		// Token: 0x06002921 RID: 10529 RVA: 0x0001276A File Offset: 0x0001096A
		// Note: this type is marked as 'beforefieldinit'.
		static IPlayable()
		{
			Il2CppClassPointerStore<IPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "IPlayable");
			IPlayable.NativeMethodInfoPtr_GetHandle_Public_Abstract_Virtual_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayable>.NativeClassPtr, 100667676);
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x000A04F0 File Offset: 0x0009E6F0
		[CallerCount(0)]
		public unsafe virtual PlayableHandle GetHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayable.NativeMethodInfoPtr_GetHandle_Public_Abstract_Virtual_New_PlayableHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x00012799 File Offset: 0x00010999
		public IPlayable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040022F5 RID: 8949
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Abstract_Virtual_New_PlayableHandle_0;
	}
}
