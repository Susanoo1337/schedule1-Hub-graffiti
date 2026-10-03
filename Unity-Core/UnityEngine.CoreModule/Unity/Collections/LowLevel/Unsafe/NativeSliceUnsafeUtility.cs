using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000056 RID: 86
	public static class NativeSliceUnsafeUtility : Object
	{
		// Token: 0x060002B0 RID: 688 RVA: 0x0001F888 File Offset: 0x0001DA88
		// Note: this type is marked as 'beforefieldinit'.
		static NativeSliceUnsafeUtility()
		{
			Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeSliceUnsafeUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr);
			NativeSliceUnsafeUtility.NativeMethodInfoPtr_ConvertExistingDataToNativeSlice_Public_Static_NativeSlice_1_T_ptr_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr, 100663544);
			NativeSliceUnsafeUtility.NativeMethodInfoPtr_GetUnsafePtr_Public_Static_ptr_Void_NativeSlice_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr, 100663545);
			NativeSliceUnsafeUtility.NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeSlice_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr, 100663546);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0001F8F4 File Offset: 0x0001DAF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1226107, RefRangeEnd = 1226109, XrefRangeStart = 1226107, XrefRangeEnd = 1226107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NativeSlice<T> ConvertExistingDataToNativeSlice<T>(void* dataPointer, int stride, int length) where T : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = dataPointer;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeSliceUnsafeUtility.MethodInfoStoreGeneric_ConvertExistingDataToNativeSlice_Public_Static_NativeSlice_1_T_ptr_Void_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeSlice<T>(pointer);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0001F948 File Offset: 0x0001DB48
		[CallerCount(163)]
		[CachedScanResults(RefRangeStart = 532930, RefRangeEnd = 533093, XrefRangeStart = 532930, XrefRangeEnd = 533093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* GetUnsafePtr<T>(this NativeSlice<T> nativeSlice) where T : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(nativeSlice));
			IntPtr intPtr;
			IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeSliceUnsafeUtility.MethodInfoStoreGeneric_GetUnsafePtr_Public_Static_ptr_Void_NativeSlice_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return result;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0001F984 File Offset: 0x0001DB84
		[CallerCount(163)]
		[CachedScanResults(RefRangeStart = 532930, RefRangeEnd = 533093, XrefRangeStart = 532930, XrefRangeEnd = 533093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* GetUnsafeReadOnlyPtr<T>(this NativeSlice<T> nativeSlice) where T : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(nativeSlice));
			IntPtr intPtr;
			IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeSliceUnsafeUtility.MethodInfoStoreGeneric_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeSlice_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return result;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000036CF File Offset: 0x000018CF
		public NativeSliceUnsafeUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr_ConvertExistingDataToNativeSlice_Public_Static_NativeSlice_1_T_ptr_Void_Int32_Int32_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr_GetUnsafePtr_Public_Static_ptr_Void_NativeSlice_1_T_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeSlice_1_T_0;

		// Token: 0x020003CD RID: 973
		private sealed class MethodInfoStoreGeneric_ConvertExistingDataToNativeSlice_Public_Static_NativeSlice_1_T_ptr_Void_Int32_Int32_0<T>
		{
			// Token: 0x04002A05 RID: 10757
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeSliceUnsafeUtility.NativeMethodInfoPtr_ConvertExistingDataToNativeSlice_Public_Static_NativeSlice_1_T_ptr_Void_Int32_Int32_0, Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003CE RID: 974
		private sealed class MethodInfoStoreGeneric_GetUnsafePtr_Public_Static_ptr_Void_NativeSlice_1_T_0<T>
		{
			// Token: 0x04002A06 RID: 10758
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeSliceUnsafeUtility.NativeMethodInfoPtr_GetUnsafePtr_Public_Static_ptr_Void_NativeSlice_1_T_0, Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003CF RID: 975
		private sealed class MethodInfoStoreGeneric_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeSlice_1_T_0<T>
		{
			// Token: 0x04002A07 RID: 10759
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeSliceUnsafeUtility.NativeMethodInfoPtr_GetUnsafeReadOnlyPtr_Public_Static_ptr_Void_NativeSlice_1_T_0, Il2CppClassPointerStore<NativeSliceUnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
