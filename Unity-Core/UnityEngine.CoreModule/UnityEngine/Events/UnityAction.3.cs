using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Events
{
	// Token: 0x020001A6 RID: 422
	public sealed class UnityAction<T0, T1> : MulticastDelegate
	{
		// Token: 0x06001F7C RID: 8060 RVA: 0x00080BAC File Offset: 0x0007EDAC
		// Note: this type is marked as 'beforefieldinit'.
		static UnityAction()
		{
			Il2CppClassPointerStore<UnityAction<T0, T1>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityAction`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
			})).TypeHandle.value);
			UnityAction<T0, T1>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAction<T0, T1>>.NativeClassPtr, 100666734);
			UnityAction<T0, T1>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAction<T0, T1>>.NativeClassPtr, 100666735);
			UnityAction<T0, T1>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T0_T1_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAction<T0, T1>>.NativeClassPtr, 100666736);
			UnityAction<T0, T1>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAction<T0, T1>>.NativeClassPtr, 100666737);
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x00080C70 File Offset: 0x0007EE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285507, XrefRangeEnd = 1285510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityAction(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityAction<T0, T1>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAction<T0, T1>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x00080CCC File Offset: 0x0007EECC
		[CallerCount(0)]
		public unsafe void Invoke(T0 arg0, T1 arg1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T0 ptr4;
			if (!typeof(T0).IsValueType)
			{
				T0 t = arg0;
				if (!(t is string))
				{
					ref T0 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref arg0;
			}
			*ptr2 = ref ptr4;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T1 ptr7;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				if (!(t2 is string))
				{
					ref T1 ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase);
					if (ref ptr6 != null)
					{
						ptr7 = ref ptr6;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr6)))
						{
							ptr7 = IL2CPP.il2cpp_object_unbox(ref ptr6);
						}
					}
				}
				else
				{
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
				}
			}
			else
			{
				ptr7 = ref arg1;
			}
			*ptr5 = ref ptr7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAction<T0, T1>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x00080DB8 File Offset: 0x0007EFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285510, XrefRangeEnd = 1285517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(T0 arg0, T1 arg1, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T0 ptr4;
			if (!typeof(T0).IsValueType)
			{
				T0 t = arg0;
				if (!(t is string))
				{
					ref T0 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref arg0;
			}
			*ptr2 = ref ptr4;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T1 ptr7;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				if (!(t2 is string))
				{
					ref T1 ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase);
					if (ref ptr6 != null)
					{
						ptr7 = ref ptr6;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr6)))
						{
							ptr7 = IL2CPP.il2cpp_object_unbox(ref ptr6);
						}
					}
				}
				else
				{
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
				}
			}
			else
			{
				ptr7 = ref arg1;
			}
			*ptr5 = ref ptr7;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAction<T0, T1>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T0_T1_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x00080ED8 File Offset: 0x0007F0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAction<T0, T1>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x0000E9A2 File Offset: 0x0000CBA2
		public UnityAction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x0000E9AB File Offset: 0x0000CBAB
		public static implicit operator UnityAction<T0, T1>(Action<T0, T1> A_0)
		{
			return DelegateSupport.ConvertDelegate<UnityAction<T0, T1>>(A_0);
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x0000E9B3 File Offset: 0x0000CBB3
		public static UnityAction<T0, T1>operator +(UnityAction<T0, T1> A_0, UnityAction<T0, T1> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UnityAction<T0, T1>>();
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x0000E9C1 File Offset: 0x0000CBC1
		public static UnityAction<T0, T1>operator -(UnityAction<T0, T1> A_0, UnityAction<T0, T1> A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<UnityAction<T0, T1>>();
			}
			return result;
		}

		// Token: 0x040019A6 RID: 6566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040019A7 RID: 6567
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_T1_0;

		// Token: 0x040019A8 RID: 6568
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T0_T1_AsyncCallback_Object_0;

		// Token: 0x040019A9 RID: 6569
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
