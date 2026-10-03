using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Playables
{
	// Token: 0x02000251 RID: 593
	public class IPlayableOutput : Il2CppObjectBase
	{
		// Token: 0x0600292E RID: 10542 RVA: 0x000127AB File Offset: 0x000109AB
		// Note: this type is marked as 'beforefieldinit'.
		static IPlayableOutput()
		{
			Il2CppClassPointerStore<IPlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "IPlayableOutput");
			IPlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Abstract_Virtual_New_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableOutput>.NativeClassPtr, 100667685);
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x000A08A4 File Offset: 0x0009EAA4
		[CallerCount(0)]
		public unsafe virtual PlayableOutputHandle GetHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Abstract_Virtual_New_PlayableOutputHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x000127DA File Offset: 0x000109DA
		public IPlayableOutput(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040022FE RID: 8958
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Abstract_Virtual_New_PlayableOutputHandle_0;
	}
}
