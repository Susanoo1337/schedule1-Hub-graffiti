using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Unity.Jobs
{
	// Token: 0x0200000A RID: 10
	public class IJob : Il2CppObjectBase
	{
		// Token: 0x0600001C RID: 28 RVA: 0x000021BC File Offset: 0x000003BC
		// Note: this type is marked as 'beforefieldinit'.
		static IJob()
		{
			Il2CppClassPointerStore<IJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs", "IJob");
			IJob.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJob>.NativeClassPtr, 100663305);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00018C50 File Offset: 0x00016E50
		[CallerCount(0)]
		public unsafe virtual void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IJob.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000021EB File Offset: 0x000003EB
		public IJob(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_0;
	}
}
