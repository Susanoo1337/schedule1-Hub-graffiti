using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Pool
{
	// Token: 0x020001C7 RID: 455
	public class IObjectPool<T> : Il2CppObjectBase where T : class
	{
		// Token: 0x060020B0 RID: 8368 RVA: 0x00084FF4 File Offset: 0x000831F4
		// Note: this type is marked as 'beforefieldinit'.
		static IObjectPool()
		{
			Il2CppClassPointerStore<IObjectPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Pool", "IObjectPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IObjectPool<T>.NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectPool<T>>.NativeClassPtr, 100666854);
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x0008506C File Offset: 0x0008326C
		[CallerCount(0)]
		public unsafe virtual void Release(T element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = element;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref element;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IObjectPool<T>.NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x0000F23C File Offset: 0x0000D43C
		public IObjectPool(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001A57 RID: 6743
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_T_0;
	}
}
