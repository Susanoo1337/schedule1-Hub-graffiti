using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000050 RID: 80
	public sealed class NativeContainerNeedsThreadIndexAttribute : Attribute
	{
		// Token: 0x0600029C RID: 668 RVA: 0x000035A4 File Offset: 0x000017A4
		// Note: this type is marked as 'beforefieldinit'.
		static NativeContainerNeedsThreadIndexAttribute()
		{
			Il2CppClassPointerStore<NativeContainerNeedsThreadIndexAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeContainerNeedsThreadIndexAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerNeedsThreadIndexAttribute>.NativeClassPtr);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000035C9 File Offset: 0x000017C9
		public NativeContainerNeedsThreadIndexAttribute(IntPtr pointer) : base(pointer)
		{
		}
	}
}
