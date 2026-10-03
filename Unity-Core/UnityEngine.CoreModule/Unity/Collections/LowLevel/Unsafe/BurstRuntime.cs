using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000048 RID: 72
	public static class BurstRuntime : Object
	{
		// Token: 0x06000283 RID: 643 RVA: 0x0001F3C4 File Offset: 0x0001D5C4
		// Note: this type is marked as 'beforefieldinit'.
		static BurstRuntime()
		{
			Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "BurstRuntime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr);
			BurstRuntime.NativeMethodInfoPtr_GetHashCode64_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663527);
			BurstRuntime.NativeMethodInfoPtr_HashStringWithFNV1A64_Internal_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, 100663528);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0001F41C File Offset: 0x0001D61C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1006035, RefRangeEnd = 1006036, XrefRangeStart = 1006035, XrefRangeEnd = 1006036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetHashCode64<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.MethodInfoStoreGeneric_GetHashCode64_Public_Static_Int64_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0001F44C File Offset: 0x0001D64C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long HashStringWithFNV1A64(string text)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstRuntime.NativeMethodInfoPtr_HashStringWithFNV1A64_Internal_Static_Int64_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000033CD File Offset: 0x000015CD
		public BurstRuntime(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode64_Public_Static_Int64_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_HashStringWithFNV1A64_Internal_Static_Int64_String_0;

		// Token: 0x020003C7 RID: 967
		public sealed class HashCode64<T> : ValueType
		{
			// Token: 0x0600303E RID: 12350 RVA: 0x000AF220 File Offset: 0x000AD420
			// Note: this type is marked as 'beforefieldinit'.
			static HashCode64()
			{
				Il2CppClassPointerStore<BurstRuntime.HashCode64<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr, "HashCode64`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstRuntime.HashCode64<T>>.NativeClassPtr);
				BurstRuntime.HashCode64<T>.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstRuntime.HashCode64<T>>.NativeClassPtr, "Value");
			}

			// Token: 0x0600303F RID: 12351 RVA: 0x000158B8 File Offset: 0x00013AB8
			public HashCode64(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003040 RID: 12352 RVA: 0x000158C1 File Offset: 0x00013AC1
			public HashCode64() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstRuntime.HashCode64<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000A03 RID: 2563
			// (get) Token: 0x06003041 RID: 12353 RVA: 0x000AF29C File Offset: 0x000AD49C
			// (set) Token: 0x06003042 RID: 12354 RVA: 0x000158D3 File Offset: 0x00013AD3
			public unsafe static long Value
			{
				get
				{
					long result;
					IL2CPP.il2cpp_field_static_get_value(BurstRuntime.HashCode64<T>.NativeFieldInfoPtr_Value, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BurstRuntime.HashCode64<T>.NativeFieldInfoPtr_Value, (void*)(&value));
				}
			}

			// Token: 0x040029FF RID: 10751
			private static readonly IntPtr NativeFieldInfoPtr_Value;
		}

		// Token: 0x020003C8 RID: 968
		private sealed class MethodInfoStoreGeneric_GetHashCode64_Public_Static_Int64_0<T>
		{
			// Token: 0x04002A00 RID: 10752
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BurstRuntime.NativeMethodInfoPtr_GetHashCode64_Public_Static_Int64_0, Il2CppClassPointerStore<BurstRuntime>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
