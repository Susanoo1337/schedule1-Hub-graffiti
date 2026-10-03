using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x02000143 RID: 323
	public sealed class NoAllocHelpers : Object
	{
		// Token: 0x060018EC RID: 6380 RVA: 0x0006A8E8 File Offset: 0x00068AE8
		// Note: this type is marked as 'beforefieldinit'.
		static NoAllocHelpers()
		{
			Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "NoAllocHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr);
			NoAllocHelpers.NativeMethodInfoPtr_ResizeList_Public_Static_Void_List_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100665937);
			NoAllocHelpers.NativeMethodInfoPtr_EnsureListElemCount_Public_Static_Void_List_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100665938);
			NoAllocHelpers.NativeMethodInfoPtr_SafeLength_Public_Static_Int32_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100665939);
			NoAllocHelpers.NativeMethodInfoPtr_SafeLength_Public_Static_Int32_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100665940);
			NoAllocHelpers.NativeMethodInfoPtr_ExtractArrayFromListT_Public_Static_Il2CppArrayBase_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100665941);
			NoAllocHelpers.NativeMethodInfoPtr_Internal_ResizeList_Internal_Static_Void_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100665942);
			NoAllocHelpers.NativeMethodInfoPtr_ExtractArrayFromList_Public_Static_Array_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr, 100665943);
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x0006A9A4 File Offset: 0x00068BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260428, XrefRangeEnd = 1260431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResizeList<T>(List<T> list, int size)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.MethodInfoStoreGeneric_ResizeList_Public_Static_Void_List_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x0006A9E8 File Offset: 0x00068BE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1260438, RefRangeEnd = 1260440, XrefRangeStart = 1260431, XrefRangeEnd = 1260438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureListElemCount<T>(List<T> list, int count)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.MethodInfoStoreGeneric_EnsureListElemCount_Public_Static_Void_List_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x0006AA2C File Offset: 0x00068C2C
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1260441, RefRangeEnd = 1260467, XrefRangeStart = 1260440, XrefRangeEnd = 1260441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SafeLength(Array values)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.NativeMethodInfoPtr_SafeLength_Public_Static_Int32_Array_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x0006AA70 File Offset: 0x00068C70
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1260468, RefRangeEnd = 1260484, XrefRangeStart = 1260467, XrefRangeEnd = 1260468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SafeLength<T>(List<T> values)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.MethodInfoStoreGeneric_SafeLength_Public_Static_Int32_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x0006AAB4 File Offset: 0x00068CB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1260487, RefRangeEnd = 1260490, XrefRangeStart = 1260484, XrefRangeEnd = 1260487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> ExtractArrayFromListT<T>(List<T> list)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.MethodInfoStoreGeneric_ExtractArrayFromListT_Public_Static_Il2CppArrayBase_1_T_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x0006AAF0 File Offset: 0x00068CF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1260492, RefRangeEnd = 1260494, XrefRangeStart = 1260490, XrefRangeEnd = 1260492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ResizeList(Object list, int size)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.NativeMethodInfoPtr_Internal_ResizeList_Internal_Static_Void_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x0006AB34 File Offset: 0x00068D34
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1260496, RefRangeEnd = 1260507, XrefRangeStart = 1260494, XrefRangeEnd = 1260496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array ExtractArrayFromList(Object list)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoAllocHelpers.NativeMethodInfoPtr_ExtractArrayFromList_Public_Static_Array_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x0000C3A7 File Offset: 0x0000A5A7
		public NoAllocHelpers(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040014C9 RID: 5321
		private static readonly IntPtr NativeMethodInfoPtr_ResizeList_Public_Static_Void_List_1_T_Int32_0;

		// Token: 0x040014CA RID: 5322
		private static readonly IntPtr NativeMethodInfoPtr_EnsureListElemCount_Public_Static_Void_List_1_T_Int32_0;

		// Token: 0x040014CB RID: 5323
		private static readonly IntPtr NativeMethodInfoPtr_SafeLength_Public_Static_Int32_Array_0;

		// Token: 0x040014CC RID: 5324
		private static readonly IntPtr NativeMethodInfoPtr_SafeLength_Public_Static_Int32_List_1_T_0;

		// Token: 0x040014CD RID: 5325
		private static readonly IntPtr NativeMethodInfoPtr_ExtractArrayFromListT_Public_Static_Il2CppArrayBase_1_T_List_1_T_0;

		// Token: 0x040014CE RID: 5326
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ResizeList_Internal_Static_Void_Object_Int32_0;

		// Token: 0x040014CF RID: 5327
		private static readonly IntPtr NativeMethodInfoPtr_ExtractArrayFromList_Public_Static_Array_Object_0;

		// Token: 0x020008E4 RID: 2276
		private sealed class MethodInfoStoreGeneric_ResizeList_Public_Static_Void_List_1_T_Int32_0<T>
		{
			// Token: 0x04002B34 RID: 11060
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoAllocHelpers.NativeMethodInfoPtr_ResizeList_Public_Static_Void_List_1_T_Int32_0, Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008E5 RID: 2277
		private sealed class MethodInfoStoreGeneric_EnsureListElemCount_Public_Static_Void_List_1_T_Int32_0<T>
		{
			// Token: 0x04002B35 RID: 11061
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoAllocHelpers.NativeMethodInfoPtr_EnsureListElemCount_Public_Static_Void_List_1_T_Int32_0, Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008E6 RID: 2278
		private sealed class MethodInfoStoreGeneric_SafeLength_Public_Static_Int32_List_1_T_0<T>
		{
			// Token: 0x04002B36 RID: 11062
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoAllocHelpers.NativeMethodInfoPtr_SafeLength_Public_Static_Int32_List_1_T_0, Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008E7 RID: 2279
		private sealed class MethodInfoStoreGeneric_ExtractArrayFromListT_Public_Static_Il2CppArrayBase_1_T_List_1_T_0<T>
		{
			// Token: 0x04002B37 RID: 11063
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoAllocHelpers.NativeMethodInfoPtr_ExtractArrayFromListT_Public_Static_Il2CppArrayBase_1_T_List_1_T_0, Il2CppClassPointerStore<NoAllocHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
