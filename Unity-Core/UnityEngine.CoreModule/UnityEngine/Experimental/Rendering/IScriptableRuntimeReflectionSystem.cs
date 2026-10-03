using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000278 RID: 632
	public class IScriptableRuntimeReflectionSystem : Il2CppObjectBase
	{
		// Token: 0x06002B3F RID: 11071 RVA: 0x0001300A File Offset: 0x0001120A
		// Note: this type is marked as 'beforefieldinit'.
		static IScriptableRuntimeReflectionSystem()
		{
			Il2CppClassPointerStore<IScriptableRuntimeReflectionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", "IScriptableRuntimeReflectionSystem");
			IScriptableRuntimeReflectionSystem.NativeMethodInfoPtr_TickRealtimeProbes_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IScriptableRuntimeReflectionSystem>.NativeClassPtr, 100667955);
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x000A8770 File Offset: 0x000A6970
		[CallerCount(0)]
		public unsafe virtual bool TickRealtimeProbes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IScriptableRuntimeReflectionSystem.NativeMethodInfoPtr_TickRealtimeProbes_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x00013039 File Offset: 0x00011239
		public IScriptableRuntimeReflectionSystem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002534 RID: 9524
		private static readonly IntPtr NativeMethodInfoPtr_TickRealtimeProbes_Public_Abstract_Virtual_New_Boolean_0;
	}
}
