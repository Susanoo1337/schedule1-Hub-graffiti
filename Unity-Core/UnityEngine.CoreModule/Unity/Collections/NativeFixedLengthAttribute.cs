using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000039 RID: 57
	public sealed class NativeFixedLengthAttribute : Attribute
	{
		// Token: 0x060001F3 RID: 499 RVA: 0x000030CC File Offset: 0x000012CC
		// Note: this type is marked as 'beforefieldinit'.
		static NativeFixedLengthAttribute()
		{
			Il2CppClassPointerStore<NativeFixedLengthAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeFixedLengthAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeFixedLengthAttribute>.NativeClassPtr);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000030F1 File Offset: 0x000012F1
		public NativeFixedLengthAttribute(IntPtr pointer) : base(pointer)
		{
		}
	}
}
