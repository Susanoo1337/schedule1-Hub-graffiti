using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Events
{
	// Token: 0x020001A4 RID: 420
	public sealed class UnityAction<T0> : MulticastDelegate
	{
		// Token: 0x06001F68 RID: 8040 RVA: 0x00080554 File Offset: 0x0007E754
		// Note: this type is marked as 'beforefieldinit'.
		static UnityAction()
		{
			Il2CppClassPointerStore<UnityAction<T0>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityAction`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr))
			})).TypeHandle.value);
			UnityAction<T0>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAction<T0>>.NativeClassPtr, 100666723);
			UnityAction<T0>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAction<T0>>.NativeClassPtr, 100666724);
			UnityAction<T0>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T0_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAction<T0>>.NativeClassPtr, 100666725);
			UnityAction<T0>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAction<T0>>.NativeClassPtr, 100666726);
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x00080608 File Offset: 0x0007E808
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 151132, RefRangeEnd = 151188, XrefRangeStart = 151132, XrefRangeEnd = 151188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityAction(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityAction<T0>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAction<T0>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x00080664 File Offset: 0x0007E864
		[CallerCount(0)]
		public unsafe void Invoke(T0 arg0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
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
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAction<T0>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x000806F4 File Offset: 0x0007E8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284928, XrefRangeEnd = 1284932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(T0 arg0, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAction<T0>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T0_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x000807B4 File Offset: 0x0007E9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAction<T0>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x0000E94A File Offset: 0x0000CB4A
		public UnityAction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x0000E953 File Offset: 0x0000CB53
		public static implicit operator UnityAction<T0>(Action<T0> A_0)
		{
			return DelegateSupport.ConvertDelegate<UnityAction<T0>>(A_0);
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x0000E95B File Offset: 0x0000CB5B
		public static UnityAction<T0>operator +(UnityAction<T0> A_0, UnityAction<T0> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UnityAction<T0>>();
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x0000E969 File Offset: 0x0000CB69
		public static UnityAction<T0>operator -(UnityAction<T0> A_0, UnityAction<T0> A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<UnityAction<T0>>();
			}
			return result;
		}

		// Token: 0x0400199A RID: 6554
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400199B RID: 6555
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_0;

		// Token: 0x0400199C RID: 6556
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T0_AsyncCallback_Object_0;

		// Token: 0x0400199D RID: 6557
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
