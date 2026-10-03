using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000047 RID: 71
	public static class BurstLike : Object
	{
		// Token: 0x06000280 RID: 640 RVA: 0x00003380 File Offset: 0x00001580
		// Note: this type is marked as 'beforefieldinit'.
		static BurstLike()
		{
			Il2CppClassPointerStore<BurstLike>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "BurstLike");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstLike>.NativeClassPtr);
			BurstLike.NativeFunctionCall_Int_IntPtr_IntPtrDelegateField = IL2CPP.ResolveICall<BurstLike.NativeFunctionCall_Int_IntPtr_IntPtrDelegate>("Unity.Collections.LowLevel.Unsafe.BurstLike::NativeFunctionCall_Int_IntPtr_IntPtr");
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000033B4 File Offset: 0x000015B4
		public BurstLike(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000033BD File Offset: 0x000015BD
		public static int NativeFunctionCall_Int_IntPtr_IntPtr(IntPtr function, IntPtr p0, IntPtr p1, out int error)
		{
			return BurstLike.NativeFunctionCall_Int_IntPtr_IntPtrDelegateField(function, p0, p1, out error);
		}

		// Token: 0x040001F0 RID: 496
		private static readonly BurstLike.NativeFunctionCall_Int_IntPtr_IntPtrDelegate NativeFunctionCall_Int_IntPtr_IntPtrDelegateField;

		// Token: 0x020003C4 RID: 964
		public sealed class SharedStatic<T> : ValueType where T : new()
		{
			// Token: 0x06003031 RID: 12337 RVA: 0x000AF028 File Offset: 0x000AD228
			// Note: this type is marked as 'beforefieldinit'.
			static SharedStatic()
			{
				Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstLike>.NativeClassPtr, "SharedStatic`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr);
				BurstLike.SharedStatic<T>.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr, "_buffer");
				BurstLike.SharedStatic<T>.NativeMethodInfoPtr__ctor_Private_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr, 100663523);
				BurstLike.SharedStatic<T>.NativeMethodInfoPtr_get_Data_Public_get_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr, 100663524);
				BurstLike.SharedStatic<T>.NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr, 100663525);
			}

			// Token: 0x06003032 RID: 12338 RVA: 0x000AF0E0 File Offset: 0x000AD2E0
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 389084, RefRangeEnd = 389119, XrefRangeStart = 389084, XrefRangeEnd = 389119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SharedStatic(void* buffer) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = buffer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstLike.SharedStatic<T>.NativeMethodInfoPtr__ctor_Private_Void_ptr_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A02 RID: 2562
			// (get) Token: 0x06003033 RID: 12339 RVA: 0x000AF12C File Offset: 0x000AD32C
			public unsafe ref T Data
			{
				[CallerCount(48)]
				[CachedScanResults(RefRangeStart = 1006683, RefRangeEnd = 1006731, XrefRangeStart = 1006683, XrefRangeEnd = 1006731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr result = IL2CPP.il2cpp_runtime_invoke(BurstLike.SharedStatic<T>.NativeMethodInfoPtr_get_Data_Public_get_byref_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return result;
				}
			}

			// Token: 0x06003034 RID: 12340 RVA: 0x000AF164 File Offset: 0x000AD364
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226057, XrefRangeEnd = 1226062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static BurstLike.SharedStatic<T> GetOrCreate<TContext>(uint alignment = 0U)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref alignment;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(BurstLike.SharedStatic.MethodInfoStoreGeneric_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0<TContext>.Pointer, 0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new BurstLike.SharedStatic<T>(pointer);
			}

			// Token: 0x06003035 RID: 12341 RVA: 0x00015845 File Offset: 0x00013A45
			public SharedStatic(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003036 RID: 12342 RVA: 0x0001584E File Offset: 0x00013A4E
			public SharedStatic() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstLike.SharedStatic<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000A01 RID: 2561
			// (get) Token: 0x06003037 RID: 12343 RVA: 0x000AF19C File Offset: 0x000AD39C
			// (set) Token: 0x06003038 RID: 12344 RVA: 0x00015860 File Offset: 0x00013A60
			public unsafe void* _buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstLike.SharedStatic<T>.NativeFieldInfoPtr__buffer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstLike.SharedStatic<T>.NativeFieldInfoPtr__buffer)) = value;
				}
			}

			// Token: 0x040029FA RID: 10746
			private static readonly IntPtr NativeFieldInfoPtr__buffer;

			// Token: 0x040029FB RID: 10747
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_ptr_Void_0;

			// Token: 0x040029FC RID: 10748
			private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_byref_T_0;

			// Token: 0x040029FD RID: 10749
			private static readonly IntPtr NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0;

			// Token: 0x02000D47 RID: 3399
			private sealed class MethodInfoStoreGeneric_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0
			{
				// Token: 0x04002CA2 RID: 11426
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BurstLike.SharedStatic<TContext>.NativeMethodInfoPtr_GetOrCreate_Public_Static_SharedStatic_1_T_UInt32_0, Il2CppClassPointerStore<BurstLike.SharedStatic<TContext>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContext>.NativeClassPtr))
				}))));
			}
		}

		// Token: 0x020003C5 RID: 965
		public static class SharedStatic : Object
		{
			// Token: 0x06003039 RID: 12345 RVA: 0x0001587B File Offset: 0x00013A7B
			// Note: this type is marked as 'beforefieldinit'.
			static SharedStatic()
			{
				Il2CppClassPointerStore<BurstLike.SharedStatic>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstLike>.NativeClassPtr, "SharedStatic");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstLike.SharedStatic>.NativeClassPtr);
				BurstLike.SharedStatic.NativeMethodInfoPtr_GetOrCreateSharedStaticInternal_Public_Static_ptr_Void_Int64_Int64_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstLike.SharedStatic>.NativeClassPtr, 100663526);
			}

			// Token: 0x0600303A RID: 12346 RVA: 0x000AF1C0 File Offset: 0x000AD3C0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1226065, RefRangeEnd = 1226067, XrefRangeStart = 1226062, XrefRangeEnd = 1226065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref getHashCode64;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref getSubHashCode64;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeOf;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignment;
				IntPtr intPtr;
				IntPtr result = IL2CPP.il2cpp_runtime_invoke(BurstLike.SharedStatic.NativeMethodInfoPtr_GetOrCreateSharedStaticInternal_Public_Static_ptr_Void_Int64_Int64_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return result;
			}

			// Token: 0x0600303B RID: 12347 RVA: 0x000158AF File Offset: 0x00013AAF
			public SharedStatic(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040029FE RID: 10750
			private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateSharedStaticInternal_Public_Static_ptr_Void_Int64_Int64_UInt32_UInt32_0;
		}

		// Token: 0x020003C6 RID: 966
		// (Invoke) Token: 0x0600303D RID: 12349
		private delegate int NativeFunctionCall_Int_IntPtr_IntPtrDelegate(IntPtr function, IntPtr p0, IntPtr p1, [Out] IntPtr error);
	}
}
