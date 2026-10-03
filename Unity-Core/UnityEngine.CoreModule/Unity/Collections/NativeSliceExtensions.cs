using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections
{
	// Token: 0x02000044 RID: 68
	public static class NativeSliceExtensions : Object
	{
		// Token: 0x06000252 RID: 594 RVA: 0x0001E880 File Offset: 0x0001CA80
		// Note: this type is marked as 'beforefieldinit'.
		static NativeSliceExtensions()
		{
			Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeSliceExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr);
			NativeSliceExtensions.NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr, 100663497);
			NativeSliceExtensions.NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeSlice_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr, 100663498);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0001E8D8 File Offset: 0x0001CAD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1225887, RefRangeEnd = 1225888, XrefRangeStart = 1225885, XrefRangeEnd = 1225887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NativeSlice<T> Slice<T>(this NativeArray<T> thisArray, int start, int length) where T : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(thisArray));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeSliceExtensions.MethodInfoStoreGeneric_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeSlice<T>(pointer);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0001E938 File Offset: 0x0001CB38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1225890, RefRangeEnd = 1225894, XrefRangeStart = 1225888, XrefRangeEnd = 1225890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NativeSlice<T> Slice<T>(this NativeSlice<T> thisSlice, int start, int length) where T : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(thisSlice));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeSliceExtensions.MethodInfoStoreGeneric_Slice_Public_Static_NativeSlice_1_T_NativeSlice_1_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeSlice<T>(pointer);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000032EF File Offset: 0x000014EF
		public NativeSliceExtensions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0001E998 File Offset: 0x0001CB98
		public static NativeSlice<T> Slice<T>(NativeArray<T> thisArray) where T : struct
		{
			return new NativeSlice<T>(thisArray);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0001E9B0 File Offset: 0x0001CBB0
		public static NativeSlice<T> Slice<T>(NativeArray<T> thisArray, int start) where T : struct
		{
			return new NativeSlice<T>(thisArray, start);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0001E9CC File Offset: 0x0001CBCC
		public static NativeSlice<T> Slice<T>(NativeSlice<T> thisSlice) where T : struct
		{
			return thisSlice;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0001E9E0 File Offset: 0x0001CBE0
		public static NativeSlice<T> Slice<T>(NativeSlice<T> thisSlice, int start) where T : struct
		{
			return new NativeSlice<T>(thisSlice, start);
		}

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_Int32_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeSlice_1_T_Int32_Int32_0;

		// Token: 0x020003C1 RID: 961
		private sealed class MethodInfoStoreGeneric_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_Int32_0<T>
		{
			// Token: 0x040029F0 RID: 10736
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeSliceExtensions.NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeArray_1_T_Int32_Int32_0, Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003C2 RID: 962
		private sealed class MethodInfoStoreGeneric_Slice_Public_Static_NativeSlice_1_T_NativeSlice_1_T_Int32_Int32_0<T>
		{
			// Token: 0x040029F1 RID: 10737
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeSliceExtensions.NativeMethodInfoPtr_Slice_Public_Static_NativeSlice_1_T_NativeSlice_1_T_Int32_Int32_0, Il2CppClassPointerStore<NativeSliceExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
