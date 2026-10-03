using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Pool
{
	// Token: 0x020001C6 RID: 454
	public class CollectionPool<TCollection, TItem> : Object where TCollection : class, new()
	{
		// Token: 0x060020A9 RID: 8361 RVA: 0x00084DCC File Offset: 0x00082FCC
		// Note: this type is marked as 'beforefieldinit'.
		static CollectionPool()
		{
			Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Pool", "CollectionPool`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCollection>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TItem>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr);
			CollectionPool<TCollection, TItem>.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, "s_Pool");
			CollectionPool<TCollection, TItem>.NativeMethodInfoPtr_Get_Public_Static_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, 100666846);
			CollectionPool<TCollection, TItem>.NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_TCollection_byref_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, 100666847);
			CollectionPool<TCollection, TItem>.NativeMethodInfoPtr_Release_Public_Static_Void_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, 100666848);
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x00084E9C File Offset: 0x0008309C
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 1286475, RefRangeEnd = 1286519, XrefRangeStart = 1286467, XrefRangeEnd = 1286475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TCollection Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionPool<TCollection, TItem>.NativeMethodInfoPtr_Get_Public_Static_TCollection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TCollection>(intPtr, false, true);
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x00084ECC File Offset: 0x000830CC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1286526, RefRangeEnd = 1286540, XrefRangeStart = 1286519, XrefRangeEnd = 1286526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PooledObject<TCollection> Get(out TCollection value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(TCollection).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr3;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CollectionPool<TCollection, TItem>.NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_TCollection_byref_TCollection_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			if (!typeof(TCollection).IsValueType)
			{
				IntPtr intPtr4 = intPtr;
				value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<TCollection>(intPtr4, false, false));
			}
			return new PooledObject<TCollection>(pointer);
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x00084F48 File Offset: 0x00083148
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 1286577, RefRangeEnd = 1286620, XrefRangeStart = 1286540, XrefRangeEnd = 1286577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(TCollection toRelease)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			TCollection ptr4;
			if (!typeof(TCollection).IsValueType)
			{
				TCollection tcollection = toRelease;
				if (!(tcollection is string))
				{
					ref TCollection ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tcollection as Il2CppObjectBase);
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(tcollection as string);
				}
			}
			else
			{
				ptr4 = ref toRelease;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionPool<TCollection, TItem>.NativeMethodInfoPtr_Release_Public_Static_Void_TCollection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x0000F221 File Offset: 0x0000D421
		public CollectionPool(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060020AE RID: 8366 RVA: 0x00084FCC File Offset: 0x000831CC
		// (set) Token: 0x060020AF RID: 8367 RVA: 0x0000F22A File Offset: 0x0000D42A
		public unsafe static ObjectPool<TCollection> s_Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CollectionPool<TCollection, TItem>.NativeFieldInfoPtr_s_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<TCollection>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CollectionPool<TCollection, TItem>.NativeFieldInfoPtr_s_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A53 RID: 6739
		private static readonly IntPtr NativeFieldInfoPtr_s_Pool;

		// Token: 0x04001A54 RID: 6740
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_TCollection_0;

		// Token: 0x04001A55 RID: 6741
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_TCollection_byref_TCollection_0;

		// Token: 0x04001A56 RID: 6742
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_TCollection_0;

		// Token: 0x02000AB5 RID: 2741
		[ObfuscatedName("UnityEngine.Pool.CollectionPool`2+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003E37 RID: 15927 RVA: 0x000B4270 File Offset: 0x000B2470
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCollection>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TItem>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr);
				CollectionPool<TCollection, TItem>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr, "<>9");
				CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr, 100666851);
				CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr, 100666852);
				CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr___cctor_b__5_1_Internal_Void_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr, 100666853);
			}

			// Token: 0x06003E38 RID: 15928 RVA: 0x000B4338 File Offset: 0x000B2538
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E39 RID: 15929 RVA: 0x000B4374 File Offset: 0x000B2574
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TCollection __cctor_b__5_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_TCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TCollection>(intPtr, false, true);
			}

			// Token: 0x06003E3A RID: 15930 RVA: 0x000B43B0 File Offset: 0x000B25B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286464, XrefRangeEnd = 1286467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__5_1(TCollection l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				TCollection ptr4;
				if (!typeof(TCollection).IsValueType)
				{
					TCollection tcollection = l;
					if (!(tcollection is string))
					{
						ref TCollection ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tcollection as Il2CppObjectBase);
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(tcollection as string);
					}
				}
				else
				{
					ptr4 = ref l;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionPool<TCollection, TItem>.__c.NativeMethodInfoPtr___cctor_b__5_1_Internal_Void_TCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003E3B RID: 15931 RVA: 0x00018250 File Offset: 0x00016450
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17000A28 RID: 2600
			// (get) Token: 0x06003E3C RID: 15932 RVA: 0x000B4440 File Offset: 0x000B2640
			// (set) Token: 0x06003E3D RID: 15933 RVA: 0x00018259 File Offset: 0x00016459
			public unsafe static CollectionPool<TCollection, TItem>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CollectionPool<TCollection, TItem>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CollectionPool<TCollection, TItem>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CollectionPool<TCollection, TItem>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002BA9 RID: 11177
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002BAA RID: 11178
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002BAB RID: 11179
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__5_0_Internal_TCollection_0;

			// Token: 0x04002BAC RID: 11180
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__5_1_Internal_Void_TCollection_0;
		}
	}
}
