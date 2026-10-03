using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000043 RID: 67
	public sealed class NativeArrayReadOnlyDebugView<T> : Object where T : new()
	{
		// Token: 0x0600024F RID: 591 RVA: 0x0001E814 File Offset: 0x0001CA14
		// Note: this type is marked as 'beforefieldinit'.
		static NativeArrayReadOnlyDebugView()
		{
			Il2CppClassPointerStore<NativeArrayReadOnlyDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeArrayReadOnlyDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArrayReadOnlyDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000032D9 File Offset: 0x000014D9
		public NativeArrayReadOnlyDebugView(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000251 RID: 593 RVA: 0x000032E2 File Offset: 0x000014E2
		public Il2CppArrayBase<T> Items
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
