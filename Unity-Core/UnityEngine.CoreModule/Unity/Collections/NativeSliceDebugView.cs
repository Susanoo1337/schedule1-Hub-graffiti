using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000046 RID: 70
	public sealed class NativeSliceDebugView<T> : Object where T : new()
	{
		// Token: 0x0600027D RID: 637 RVA: 0x0001F358 File Offset: 0x0001D558
		// Note: this type is marked as 'beforefieldinit'.
		static NativeSliceDebugView()
		{
			Il2CppClassPointerStore<NativeSliceDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeSliceDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeSliceDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000336A File Offset: 0x0000156A
		public NativeSliceDebugView(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00003373 File Offset: 0x00001573
		public Il2CppArrayBase<T> Items
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
