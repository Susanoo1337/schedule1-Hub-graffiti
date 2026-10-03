using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop
{
	// Token: 0x020001BE RID: 446
	[StructLayout(2)]
	public struct TimeUpdate
	{
		// Token: 0x06002099 RID: 8345 RVA: 0x0000F069 File Offset: 0x0000D269
		// Note: this type is marked as 'beforefieldinit'.
		static TimeUpdate()
		{
			Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "TimeUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr);
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x0000F08E File Offset: 0x0000D28E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr, ref this));
		}

		// Token: 0x02000A2F RID: 2607
		[StructLayout(2)]
		public struct WaitForLastPresentationAndUpdateTime
		{
			// Token: 0x06003D31 RID: 15665 RVA: 0x000168BA File Offset: 0x00014ABA
			// Note: this type is marked as 'beforefieldinit'.
			static WaitForLastPresentationAndUpdateTime()
			{
				Il2CppClassPointerStore<TimeUpdate.WaitForLastPresentationAndUpdateTime>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeUpdate>.NativeClassPtr, "WaitForLastPresentationAndUpdateTime");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeUpdate.WaitForLastPresentationAndUpdateTime>.NativeClassPtr);
			}

			// Token: 0x06003D32 RID: 15666 RVA: 0x000168DA File Offset: 0x00014ADA
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeUpdate.WaitForLastPresentationAndUpdateTime>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A30 RID: 2608
		public struct ProfilerStartFrame
		{
		}
	}
}
