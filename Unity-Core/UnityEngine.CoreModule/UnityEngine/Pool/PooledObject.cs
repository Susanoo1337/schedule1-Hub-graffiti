using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Pool
{
	// Token: 0x020001CA RID: 458
	public sealed class PooledObject<T> : ValueType where T : class
	{
		// Token: 0x060020D1 RID: 8401 RVA: 0x0008576C File Offset: 0x0008396C
		// Note: this type is marked as 'beforefieldinit'.
		static PooledObject()
		{
			Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Pool", "PooledObject`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr);
			PooledObject<T>.NativeFieldInfoPtr_m_ToReturn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr, "m_ToReturn");
			PooledObject<T>.NativeFieldInfoPtr_m_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr, "m_Pool");
			PooledObject<T>.NativeMethodInfoPtr__ctor_Public_Void_T_IObjectPool_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr, 100666864);
			PooledObject<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr, 100666865);
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x00085828 File Offset: 0x00083A28
		[CallerCount(80)]
		[CachedScanResults(RefRangeStart = 62123, RefRangeEnd = 62203, XrefRangeStart = 62123, XrefRangeEnd = 62203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PooledObject(T value, IObjectPool<T> pool) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = value;
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
				ptr4 = ref value;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pool);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PooledObject<T>.NativeMethodInfoPtr__ctor_Public_Void_T_IObjectPool_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x000858D8 File Offset: 0x00083AD8
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 1286685, RefRangeEnd = 1286716, XrefRangeStart = 1286680, XrefRangeEnd = 1286685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PooledObject<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x0000F35E File Offset: 0x0000D55E
		public PooledObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x0000F367 File Offset: 0x0000D567
		public PooledObject() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr))
		{
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060020D6 RID: 8406 RVA: 0x00085910 File Offset: 0x00083B10
		// (set) Token: 0x060020D7 RID: 8407 RVA: 0x00085938 File Offset: 0x00083B38
		public unsafe T m_ToReturn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PooledObject<T>.NativeFieldInfoPtr_m_ToReturn);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PooledObject<T>.NativeFieldInfoPtr_m_ToReturn);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060020D8 RID: 8408 RVA: 0x000859E0 File Offset: 0x00083BE0
		// (set) Token: 0x060020D9 RID: 8409 RVA: 0x0000F379 File Offset: 0x0000D579
		public unsafe IObjectPool<T> m_Pool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PooledObject<T>.NativeFieldInfoPtr_m_Pool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IObjectPool<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PooledObject<T>.NativeFieldInfoPtr_m_Pool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A69 RID: 6761
		private static readonly IntPtr NativeFieldInfoPtr_m_ToReturn;

		// Token: 0x04001A6A RID: 6762
		private static readonly IntPtr NativeFieldInfoPtr_m_Pool;

		// Token: 0x04001A6B RID: 6763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_IObjectPool_1_T_0;

		// Token: 0x04001A6C RID: 6764
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
	}
}
