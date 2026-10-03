using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000038 RID: 56
	public sealed class DeallocateOnJobCompletionAttribute : Attribute
	{
		// Token: 0x060001F1 RID: 497 RVA: 0x0000309E File Offset: 0x0000129E
		// Note: this type is marked as 'beforefieldinit'.
		static DeallocateOnJobCompletionAttribute()
		{
			Il2CppClassPointerStore<DeallocateOnJobCompletionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "DeallocateOnJobCompletionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeallocateOnJobCompletionAttribute>.NativeClassPtr);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000030C3 File Offset: 0x000012C3
		public DeallocateOnJobCompletionAttribute(IntPtr pointer) : base(pointer)
		{
		}
	}
}
