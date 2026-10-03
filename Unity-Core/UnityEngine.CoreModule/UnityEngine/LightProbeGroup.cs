using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine
{
	// Token: 0x020000D6 RID: 214
	public sealed class LightProbeGroup : Behaviour
	{
		// Token: 0x06000ED8 RID: 3800 RVA: 0x00009001 File Offset: 0x00007201
		// Note: this type is marked as 'beforefieldinit'.
		static LightProbeGroup()
		{
			Il2CppClassPointerStore<LightProbeGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightProbeGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightProbeGroup>.NativeClassPtr);
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00009026 File Offset: 0x00007226
		public LightProbeGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x000426C8 File Offset: 0x000408C8
		public Il2CppStructArray<Vector3> probePositions
		{
			get
			{
				return null;
			}
		}
	}
}
