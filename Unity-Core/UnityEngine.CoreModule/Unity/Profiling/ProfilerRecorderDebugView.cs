using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Profiling
{
	// Token: 0x02000021 RID: 33
	public sealed class ProfilerRecorderDebugView : Object
	{
		// Token: 0x06000103 RID: 259 RVA: 0x0000279F File Offset: 0x0000099F
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilerRecorderDebugView()
		{
			Il2CppClassPointerStore<ProfilerRecorderDebugView>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", "ProfilerRecorderDebugView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerRecorderDebugView>.NativeClassPtr);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000027C4 File Offset: 0x000009C4
		public ProfilerRecorderDebugView(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000105 RID: 261 RVA: 0x000027CD File Offset: 0x000009CD
		public Il2CppStructArray<ProfilerRecorderSample> Items
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
