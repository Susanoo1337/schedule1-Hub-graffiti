using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000042 RID: 66
	public sealed class NativeArrayDebugView<T> : Object where T : new()
	{
		// Token: 0x0600024C RID: 588 RVA: 0x0001E7A8 File Offset: 0x0001C9A8
		// Note: this type is marked as 'beforefieldinit'.
		static NativeArrayDebugView()
		{
			Il2CppClassPointerStore<NativeArrayDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeArrayDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArrayDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x000032C3 File Offset: 0x000014C3
		public NativeArrayDebugView(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600024E RID: 590 RVA: 0x000032CC File Offset: 0x000014CC
		public Il2CppArrayBase<T> Items
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
