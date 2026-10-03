using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000055 RID: 85
	public static class NativeArrayUnsafeUtility : Object
	{
		// Token: 0x060002A9 RID: 681 RVA: 0x0001F6E8 File Offset: 0x0001D8E8
		// Note: this type is marked as 'beforefieldinit'.
		static NativeArrayUnsafeUtility()
		{
			Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeArrayUnsafeUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr);
			NativeArrayUnsafeUtility.NativeMethodInfoPtr_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr, 100663540);
			NativeArrayUnsafeUtility.NativeMethodInfoPtr_GetUnsafePtr_Public_Static_ptr_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr, 100663541);
			NativeArrayUnsafeUtility.NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr, 100663542);
			NativeArrayUnsafeUtility.NativeMethodInfoPtr_GetUnsafeBufferPointerWithoutChecks_Public_Static_ptr_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr, 100663543);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0001F768 File Offset: 0x0001D968
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 1226067, RefRangeEnd = 1226107, XrefRangeStart = 1226067, XrefRangeEnd = 1226067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Allocator allocator) where T : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = dataPointer;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeArrayUnsafeUtility.MethodInfoStoreGeneric_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0<T>.Pointer, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<T>(pointer);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0001F7BC File Offset: 0x0001D9BC
		[CallerCount(163)]
		[CachedScanResults(RefRangeStart = 532930, RefRangeEnd = 533093, XrefRangeStart = 532930, XrefRangeEnd = 533093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* GetUnsafePtr<T>(this NativeArray<T> nativeArray) where T : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(nativeArray));
			IntPtr intPtr;
			IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeArrayUnsafeUtility.MethodInfoStoreGeneric_GetUnsafePtr_Public_Static_ptr_Void_NativeArray_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return result;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0001F7F8 File Offset: 0x0001D9F8
		[CallerCount(163)]
		[CachedScanResults(RefRangeStart = 532930, RefRangeEnd = 533093, XrefRangeStart = 532930, XrefRangeEnd = 533093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* GetUnsafeReadOnlyPtr<T>(this NativeArray<T> nativeArray) where T : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(nativeArray));
			IntPtr intPtr;
			IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeArrayUnsafeUtility.MethodInfoStoreGeneric_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return result;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0001F834 File Offset: 0x0001DA34
		[CallerCount(163)]
		[CachedScanResults(RefRangeStart = 532930, RefRangeEnd = 533093, XrefRangeStart = 532930, XrefRangeEnd = 533093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* GetUnsafeBufferPointerWithoutChecks<T>(NativeArray<T> nativeArray) where T : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(nativeArray));
			IntPtr intPtr;
			IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeArrayUnsafeUtility.MethodInfoStoreGeneric_GetUnsafeBufferPointerWithoutChecks_Public_Static_ptr_Void_NativeArray_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return result;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x000036C6 File Offset: 0x000018C6
		public NativeArrayUnsafeUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0001F870 File Offset: 0x0001DA70
		public unsafe static void* GetUnsafeReadOnlyPtr<T>(NativeArray<T>.ReadOnly nativeArray) where T : struct
		{
			return nativeArray.m_Buffer;
		}

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_GetUnsafePtr_Public_Static_ptr_Void_NativeArray_1_T_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_GetUnsafeBufferPointerWithoutChecks_Public_Static_ptr_Void_NativeArray_1_T_0;

		// Token: 0x020003C9 RID: 969
		private sealed class MethodInfoStoreGeneric_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0<T>
		{
			// Token: 0x04002A01 RID: 10753
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArrayUnsafeUtility.NativeMethodInfoPtr_ConvertExistingDataToNativeArray_Public_Static_NativeArray_1_T_ptr_Void_Int32_Allocator_0, Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003CA RID: 970
		private sealed class MethodInfoStoreGeneric_GetUnsafePtr_Public_Static_ptr_Void_NativeArray_1_T_0<T>
		{
			// Token: 0x04002A02 RID: 10754
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArrayUnsafeUtility.NativeMethodInfoPtr_GetUnsafePtr_Public_Static_ptr_Void_NativeArray_1_T_0, Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003CB RID: 971
		private sealed class MethodInfoStoreGeneric_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0<T>
		{
			// Token: 0x04002A03 RID: 10755
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArrayUnsafeUtility.NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeArray_1_T_0, Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003CC RID: 972
		private sealed class MethodInfoStoreGeneric_GetUnsafeBufferPointerWithoutChecks_Public_Static_ptr_Void_NativeArray_1_T_0<T>
		{
			// Token: 0x04002A04 RID: 10756
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeArrayUnsafeUtility.NativeMethodInfoPtr_GetUnsafeBufferPointerWithoutChecks_Public_Static_ptr_Void_NativeArray_1_T_0, Il2CppClassPointerStore<NativeArrayUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
