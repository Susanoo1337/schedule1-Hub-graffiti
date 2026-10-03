using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000057 RID: 87
	public static class UnsafeUtility : Object
	{
		// Token: 0x060002B5 RID: 693 RVA: 0x0001F9C0 File Offset: 0x0001DBC0
		// Note: this type is marked as 'beforefieldinit'.
		static UnsafeUtility()
		{
			Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "UnsafeUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr);
			UnsafeUtility.NativeMethodInfoPtr_LeakRecord_Internal_Static_Int32_IntPtr_LeakCategory_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663547);
			UnsafeUtility.NativeMethodInfoPtr_LeakErase_Internal_Static_Int32_IntPtr_LeakCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663548);
			UnsafeUtility.NativeMethodInfoPtr_MallocTracked_Public_Static_ptr_Void_Int64_Int32_Allocator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663549);
			UnsafeUtility.NativeMethodInfoPtr_FreeTracked_Public_Static_Void_ptr_Void_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663550);
			UnsafeUtility.NativeMethodInfoPtr_Malloc_Public_Static_ptr_Void_Int64_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663551);
			UnsafeUtility.NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663552);
			UnsafeUtility.NativeMethodInfoPtr_MemCpy_Public_Static_Void_ptr_Void_ptr_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663553);
			UnsafeUtility.NativeMethodInfoPtr_MemCpyStride_Public_Static_Void_ptr_Void_Int32_ptr_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663554);
			UnsafeUtility.NativeMethodInfoPtr_MemMove_Public_Static_Void_ptr_Void_ptr_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663555);
			UnsafeUtility.NativeMethodInfoPtr_MemSet_Public_Static_Void_ptr_Void_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663556);
			UnsafeUtility.NativeMethodInfoPtr_MemClear_Public_Static_Void_ptr_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663557);
			UnsafeUtility.NativeMethodInfoPtr_MemCmp_Public_Static_Int32_ptr_Void_ptr_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663558);
			UnsafeUtility.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663559);
			UnsafeUtility.NativeMethodInfoPtr_IsBlittable_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663560);
			UnsafeUtility.NativeMethodInfoPtr_GetScriptingTypeFlags_Internal_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663561);
			UnsafeUtility.NativeMethodInfoPtr_IsBlittableValueType_Private_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663562);
			UnsafeUtility.NativeMethodInfoPtr_GetReasonForTypeNonBlittableImpl_Private_Static_String_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663563);
			UnsafeUtility.NativeMethodInfoPtr_IsArrayBlittable_Internal_Static_Boolean_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663564);
			UnsafeUtility.NativeMethodInfoPtr_GetReasonForArrayNonBlittable_Internal_Static_String_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663565);
			UnsafeUtility.NativeMethodInfoPtr_IsUnmanaged_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663566);
			UnsafeUtility.NativeMethodInfoPtr_IsValidNativeContainerElementType_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663567);
			UnsafeUtility.NativeMethodInfoPtr_AlignOf_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663568);
			UnsafeUtility.NativeMethodInfoPtr_CopyPtrToStructure_Public_Static_Void_ptr_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663569);
			UnsafeUtility.NativeMethodInfoPtr_InternalCopyPtrToStructure_Private_Static_Void_ptr_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663570);
			UnsafeUtility.NativeMethodInfoPtr_CopyStructureToPtr_Public_Static_Void_byref_T_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663571);
			UnsafeUtility.NativeMethodInfoPtr_InternalCopyStructureToPtr_Private_Static_Void_byref_T_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663572);
			UnsafeUtility.NativeMethodInfoPtr_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663573);
			UnsafeUtility.NativeMethodInfoPtr_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663574);
			UnsafeUtility.NativeMethodInfoPtr_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663575);
			UnsafeUtility.NativeMethodInfoPtr_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663576);
			UnsafeUtility.NativeMethodInfoPtr_AddressOf_Public_Static_ptr_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663577);
			UnsafeUtility.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663578);
			UnsafeUtility.NativeMethodInfoPtr_As_Public_Static_byref_T_byref_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663579);
			UnsafeUtility.NativeMethodInfoPtr_AsRef_Public_Static_byref_T_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663580);
			UnsafeUtility.NativeMethodInfoPtr_ArrayElementAsRef_Public_Static_byref_T_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663581);
			UnsafeUtility.NativeMethodInfoPtr_EnumToInt_Public_Static_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663582);
			UnsafeUtility.NativeMethodInfoPtr_InternalEnumToInt_Private_Static_Void_byref_T_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663583);
			UnsafeUtility.NativeMethodInfoPtr_EnumEquals_Public_Static_Boolean_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663584);
			UnsafeUtility.GetFieldOffsetInStructDelegateField = IL2CPP.ResolveICall<UnsafeUtility.GetFieldOffsetInStructDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::GetFieldOffsetInStruct");
			UnsafeUtility.GetFieldOffsetInClassDelegateField = IL2CPP.ResolveICall<UnsafeUtility.GetFieldOffsetInClassDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::GetFieldOffsetInClass");
			UnsafeUtility.PinSystemArrayAndGetAddressDelegateField = IL2CPP.ResolveICall<UnsafeUtility.PinSystemArrayAndGetAddressDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::PinSystemArrayAndGetAddress");
			UnsafeUtility.PinSystemObjectAndGetAddressDelegateField = IL2CPP.ResolveICall<UnsafeUtility.PinSystemObjectAndGetAddressDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::PinSystemObjectAndGetAddress");
			UnsafeUtility.ReleaseGCObjectDelegateField = IL2CPP.ResolveICall<UnsafeUtility.ReleaseGCObjectDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::ReleaseGCObject");
			UnsafeUtility.CopyObjectAddressToPtrDelegateField = IL2CPP.ResolveICall<UnsafeUtility.CopyObjectAddressToPtrDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::CopyObjectAddressToPtr");
			UnsafeUtility.CheckForLeaksDelegateField = IL2CPP.ResolveICall<UnsafeUtility.CheckForLeaksDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::CheckForLeaks");
			UnsafeUtility.ForgiveLeaksDelegateField = IL2CPP.ResolveICall<UnsafeUtility.ForgiveLeaksDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::ForgiveLeaks");
			UnsafeUtility.GetLeakDetectionModeDelegateField = IL2CPP.ResolveICall<UnsafeUtility.GetLeakDetectionModeDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::GetLeakDetectionMode");
			UnsafeUtility.SetLeakDetectionModeDelegateField = IL2CPP.ResolveICall<UnsafeUtility.SetLeakDetectionModeDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::SetLeakDetectionMode");
			UnsafeUtility.MemCpyReplicateDelegateField = IL2CPP.ResolveICall<UnsafeUtility.MemCpyReplicateDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpyReplicate");
			UnsafeUtility.IsUnmanagedDelegateField = IL2CPP.ResolveICall<UnsafeUtility.IsUnmanagedDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::IsUnmanaged");
			UnsafeUtility.IsValidNativeContainerElementTypeDelegateField = IL2CPP.ResolveICall<UnsafeUtility.IsValidNativeContainerElementTypeDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::IsValidNativeContainerElementType");
			UnsafeUtility.LogErrorDelegateField = IL2CPP.ResolveICall<UnsafeUtility.LogErrorDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::LogError");
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0001FDBC File Offset: 0x0001DFBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1226117, RefRangeEnd = 1226119, XrefRangeStart = 1226115, XrefRangeEnd = 1226117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LeakRecord(IntPtr handle, LeakCategory category, int callstacksToSkip)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref handle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref category;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callstacksToSkip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_LeakRecord_Internal_Static_Int32_IntPtr_LeakCategory_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0001FE18 File Offset: 0x0001E018
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1226121, RefRangeEnd = 1226122, XrefRangeStart = 1226119, XrefRangeEnd = 1226121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LeakErase(IntPtr handle, LeakCategory category)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref handle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_LeakErase_Internal_Static_Int32_IntPtr_LeakCategory_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0001FE64 File Offset: 0x0001E064
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1226124, RefRangeEnd = 1226125, XrefRangeStart = 1226122, XrefRangeEnd = 1226124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* MallocTracked(long size, int alignment, Allocator allocator, int callstacksToSkip)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref size;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignment;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callstacksToSkip;
			IntPtr intPtr;
			IntPtr result = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_MallocTracked_Public_Static_ptr_Void_Int64_Int32_Allocator_Int32_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return result;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0001FEC4 File Offset: 0x0001E0C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1226127, RefRangeEnd = 1226128, XrefRangeStart = 1226125, XrefRangeEnd = 1226127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FreeTracked(void* memory, Allocator allocator)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = memory;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_FreeTracked_Public_Static_Void_ptr_Void_Allocator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0001FF04 File Offset: 0x0001E104
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1226130, RefRangeEnd = 1226147, XrefRangeStart = 1226128, XrefRangeEnd = 1226130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* Malloc(long size, int alignment, Allocator allocator)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref size;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignment;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			IntPtr intPtr;
			IntPtr result = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_Malloc_Public_Static_ptr_Void_Int64_Int32_Allocator_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return result;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0001FF54 File Offset: 0x0001E154
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1226149, RefRangeEnd = 1226163, XrefRangeStart = 1226147, XrefRangeEnd = 1226149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Free(void* memory, Allocator allocator)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = memory;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_Allocator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0001FF94 File Offset: 0x0001E194
		[CallerCount(221)]
		[CachedScanResults(RefRangeStart = 1226165, RefRangeEnd = 1226386, XrefRangeStart = 1226163, XrefRangeEnd = 1226165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MemCpy(void* destination, void* source, long size)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = destination;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_MemCpy_Public_Static_Void_ptr_Void_ptr_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0001FFE0 File Offset: 0x0001E1E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1226388, RefRangeEnd = 1226392, XrefRangeStart = 1226386, XrefRangeEnd = 1226388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MemCpyStride(void* destination, int destinationStride, void* source, int sourceStride, int elementSize, int count)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = destination;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationStride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = source;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceStride;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_MemCpyStride_Public_Static_Void_ptr_Void_Int32_ptr_Void_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00020058 File Offset: 0x0001E258
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1226394, RefRangeEnd = 1226403, XrefRangeStart = 1226392, XrefRangeEnd = 1226394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MemMove(void* destination, void* source, long size)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = destination;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_MemMove_Public_Static_Void_ptr_Void_ptr_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000200A4 File Offset: 0x0001E2A4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1226405, RefRangeEnd = 1226412, XrefRangeStart = 1226403, XrefRangeEnd = 1226405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MemSet(void* destination, byte value, long size)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = destination;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_MemSet_Public_Static_Void_ptr_Void_Byte_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000200F4 File Offset: 0x0001E2F4
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 1226414, RefRangeEnd = 1226456, XrefRangeStart = 1226412, XrefRangeEnd = 1226414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MemClear(void* destination, long size)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = destination;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_MemClear_Public_Static_Void_ptr_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00020134 File Offset: 0x0001E334
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 1226458, RefRangeEnd = 1226535, XrefRangeStart = 1226456, XrefRangeEnd = 1226458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int MemCmp(void* ptr1, void* ptr2, long size)
		{
			IntPtr* ptr3 = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr3 = ptr1;
			ptr3[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ptr2;
			ptr3[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_MemCmp_Public_Static_Int32_ptr_Void_ptr_Void_Int64_0, 0, (void**)ptr3, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0002018C File Offset: 0x0001E38C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1226537, RefRangeEnd = 1226539, XrefRangeStart = 1226535, XrefRangeEnd = 1226537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SizeOf(Type type)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000201D0 File Offset: 0x0001E3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226539, XrefRangeEnd = 1226541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBlittable(Type type)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_IsBlittable_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00020214 File Offset: 0x0001E414
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1226543, RefRangeEnd = 1226545, XrefRangeStart = 1226541, XrefRangeEnd = 1226543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetScriptingTypeFlags(Type type)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_GetScriptingTypeFlags_Internal_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00020258 File Offset: 0x0001E458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226545, XrefRangeEnd = 1226546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBlittableValueType(Type t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_IsBlittableValueType_Private_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0002029C File Offset: 0x0001E49C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1226565, RefRangeEnd = 1226567, XrefRangeStart = 1226546, XrefRangeEnd = 1226565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetReasonForTypeNonBlittableImpl(Type t, string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_GetReasonForTypeNonBlittableImpl_Private_Static_String_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x000202EC File Offset: 0x0001E4EC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1226569, RefRangeEnd = 1226574, XrefRangeStart = 1226567, XrefRangeEnd = 1226569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsArrayBlittable(Array arr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(arr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_IsArrayBlittable_Internal_Static_Boolean_Array_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00020330 File Offset: 0x0001E530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1226577, RefRangeEnd = 1226578, XrefRangeStart = 1226574, XrefRangeEnd = 1226577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetReasonForArrayNonBlittable(Array arr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(arr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.NativeMethodInfoPtr_GetReasonForArrayNonBlittable_Internal_Static_String_Array_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0002036C File Offset: 0x0001E56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226578, XrefRangeEnd = 1226582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsUnmanaged<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_IsUnmanaged_Public_Static_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0002039C File Offset: 0x0001E59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226582, XrefRangeEnd = 1226586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidNativeContainerElementType<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_IsValidNativeContainerElementType_Public_Static_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x000203CC File Offset: 0x0001E5CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1226587, RefRangeEnd = 1226592, XrefRangeStart = 1226586, XrefRangeEnd = 1226587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AlignOf<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_AlignOf_Public_Static_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x000203FC File Offset: 0x0001E5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226592, XrefRangeEnd = 1226593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyPtrToStructure<T>(void* ptr, out T output) where T : new()
		{
			IntPtr* ptr2 = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr2 = ptr;
			ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref output;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_CopyPtrToStructure_Public_Static_Void_ptr_Void_byref_T_0<T>.Pointer, 0, (void**)ptr2, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				output = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0002047C File Offset: 0x0001E67C
		[CallerCount(0)]
		public unsafe static void InternalCopyPtrToStructure<T>(void* ptr, out T output) where T : new()
		{
			IntPtr* ptr2 = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr2 = ptr;
			ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref output;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_InternalCopyPtrToStructure_Private_Static_Void_ptr_Void_byref_T_0<T>.Pointer, 0, (void**)ptr2, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				output = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x000204FC File Offset: 0x0001E6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226593, XrefRangeEnd = 1226594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyStructureToPtr<T>(ref T input, void* ptr) where T : new()
		{
			IntPtr* ptr2 = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr3 = ref *ptr2;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr3 = &intPtr;
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ptr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_CopyStructureToPtr_Public_Static_Void_byref_T_ptr_Void_0<T>.Pointer, 0, (void**)ptr2, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			input = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00020558 File Offset: 0x0001E758
		[CallerCount(0)]
		public unsafe static void InternalCopyStructureToPtr<T>(ref T input, void* ptr) where T : new()
		{
			IntPtr* ptr2 = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr3 = ref *ptr2;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr3 = &intPtr;
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ptr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_InternalCopyStructureToPtr_Private_Static_Void_byref_T_ptr_Void_0<T>.Pointer, 0, (void**)ptr2, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			input = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x000205B4 File Offset: 0x0001E7B4
		[CallerCount(0)]
		public unsafe static T ReadArrayElement<T>(void* source, int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = source;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x000205FC File Offset: 0x0001E7FC
		[CallerCount(0)]
		public unsafe static T ReadArrayElementWithStride<T>(void* source, int index, int stride)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = source;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00020654 File Offset: 0x0001E854
		[CallerCount(0)]
		public unsafe static void WriteArrayElement<T>(void* destination, int index, T value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = destination;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
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
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000206F0 File Offset: 0x0001E8F0
		[CallerCount(0)]
		public unsafe static void WriteArrayElementWithStride<T>(void* destination, int index, int stride, T value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = destination;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
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
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0002079C File Offset: 0x0001E99C
		[CallerCount(1485)]
		[CachedScanResults(RefRangeStart = 115488, RefRangeEnd = 116973, XrefRangeStart = 115488, XrefRangeEnd = 116973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* AddressOf<T>(ref T output) where T : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr2 = &intPtr;
			IntPtr intPtr2;
			IntPtr result = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_AddressOf_Public_Static_ptr_Void_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			output = ((intPtr3 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr3, false, false));
			return result;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x000207EC File Offset: 0x0001E9EC
		[CallerCount(0)]
		public unsafe static int SizeOf<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0002081C File Offset: 0x0001EA1C
		[CallerCount(1485)]
		[CachedScanResults(RefRangeStart = 115488, RefRangeEnd = 116973, XrefRangeStart = 115488, XrefRangeEnd = 116973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref T As<U, T>(ref U from)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(from);
			ptr2 = &intPtr;
			IntPtr intPtr2;
			IntPtr result = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_As_Public_Static_byref_T_byref_U_0<U, T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			from = ((intPtr3 == 0) ? null : IL2CPP.PointerToValueGeneric<U>(intPtr3, false, false));
			return result;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0002086C File Offset: 0x0001EA6C
		[CallerCount(1485)]
		[CachedScanResults(RefRangeStart = 115488, RefRangeEnd = 116973, XrefRangeStart = 115488, XrefRangeEnd = 116973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref T AsRef<T>(void* ptr) where T : new()
		{
			IntPtr* ptr2 = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr2 = ptr;
			IntPtr intPtr;
			IntPtr result = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_AsRef_Public_Static_byref_T_ptr_Void_0<T>.Pointer, 0, (void**)ptr2, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return result;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000208A0 File Offset: 0x0001EAA0
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 533330, RefRangeEnd = 533393, XrefRangeStart = 533330, XrefRangeEnd = 533393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref T ArrayElementAsRef<T>(void* ptr, int index) where T : new()
		{
			IntPtr* ptr2 = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr2 = ptr;
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr;
			IntPtr result = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_ArrayElementAsRef_Public_Static_byref_T_ptr_Void_Int32_0<T>.Pointer, 0, (void**)ptr2, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return result;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000208E0 File Offset: 0x0001EAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226594, XrefRangeEnd = 1226595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int EnumToInt<T>(T enumValue) where T : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = enumValue;
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
				ptr4 = ref enumValue;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_EnumToInt_Public_Static_Int32_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0002096C File Offset: 0x0001EB6C
		[CallerCount(0)]
		public unsafe static void InternalEnumToInt<T>(ref T enumValue, ref int intValue)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(enumValue);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &intValue;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_InternalEnumToInt_Private_Static_Void_byref_T_byref_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			enumValue = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000209C8 File Offset: 0x0001EBC8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 392501, RefRangeEnd = 392507, XrefRangeStart = 392501, XrefRangeEnd = 392507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EnumEquals<T>(T lhs, T rhs) where T : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = lhs;
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
				ptr4 = ref lhs;
			}
			*ptr2 = ref ptr4;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T ptr7;
			if (!typeof(T).IsValueType)
			{
				T t2 = rhs;
				if (!(t2 is string))
				{
					ref T ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase);
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
				ptr7 = ref rhs;
			}
			*ptr5 = ref ptr7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.MethodInfoStoreGeneric_EnumEquals_Public_Static_Boolean_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000036D8 File Offset: 0x000018D8
		public UnsafeUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000036E1 File Offset: 0x000018E1
		public static int GetFieldOffsetInStruct(FieldInfo field)
		{
			return UnsafeUtility.GetFieldOffsetInStructDelegateField(IL2CPP.Il2CppObjectBaseToPtr(field));
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000036F3 File Offset: 0x000018F3
		public static int GetFieldOffsetInClass(FieldInfo field)
		{
			return UnsafeUtility.GetFieldOffsetInClassDelegateField(IL2CPP.Il2CppObjectBaseToPtr(field));
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00020AB4 File Offset: 0x0001ECB4
		public static int GetFieldOffset(FieldInfo field)
		{
			bool isValueType = field.DeclaringType.IsValueType;
			int result;
			if (isValueType)
			{
				result = UnsafeUtility.GetFieldOffsetInStruct(field);
			}
			else
			{
				bool isClass = field.DeclaringType.IsClass;
				if (isClass)
				{
					result = UnsafeUtility.GetFieldOffsetInClass(field);
				}
				else
				{
					result = -1;
				}
			}
			return result;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00020AF8 File Offset: 0x0001ECF8
		public unsafe static void* PinGCObjectAndGetAddress(Object target, out ulong gcHandle)
		{
			return UnsafeUtility.PinSystemObjectAndGetAddress(target, out gcHandle);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00020B14 File Offset: 0x0001ED14
		public unsafe static void* PinGCArrayAndGetDataAddress(Array target, out ulong gcHandle)
		{
			return UnsafeUtility.PinSystemArrayAndGetAddress(target, out gcHandle);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00003705 File Offset: 0x00001905
		public unsafe static void* PinSystemArrayAndGetAddress(Object target, out ulong gcHandle)
		{
			return UnsafeUtility.PinSystemArrayAndGetAddressDelegateField(IL2CPP.Il2CppObjectBaseToPtr(target), out gcHandle);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00003718 File Offset: 0x00001918
		public unsafe static void* PinSystemObjectAndGetAddress(Object target, out ulong gcHandle)
		{
			return UnsafeUtility.PinSystemObjectAndGetAddressDelegateField(IL2CPP.Il2CppObjectBaseToPtr(target), out gcHandle);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000372B File Offset: 0x0000192B
		public static void ReleaseGCObject(ulong gcHandle)
		{
			UnsafeUtility.ReleaseGCObjectDelegateField(gcHandle);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00003738 File Offset: 0x00001938
		public unsafe static void CopyObjectAddressToPtr(Object target, void* dstPtr)
		{
			UnsafeUtility.CopyObjectAddressToPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtr(target), dstPtr);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00020B30 File Offset: 0x0001ED30
		public static bool IsBlittable<T>() where T : struct
		{
			return UnsafeUtility.IsBlittable(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000374B File Offset: 0x0000194B
		public static int CheckForLeaks()
		{
			return UnsafeUtility.CheckForLeaksDelegateField();
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00003757 File Offset: 0x00001957
		public static int ForgiveLeaks()
		{
			return UnsafeUtility.ForgiveLeaksDelegateField();
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00003763 File Offset: 0x00001963
		public static NativeLeakDetectionMode GetLeakDetectionMode()
		{
			return UnsafeUtility.GetLeakDetectionModeDelegateField();
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000376F File Offset: 0x0000196F
		public static void SetLeakDetectionMode(NativeLeakDetectionMode value)
		{
			UnsafeUtility.SetLeakDetectionModeDelegateField(value);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00020B54 File Offset: 0x0001ED54
		public static bool IsValidAllocator(Allocator allocator)
		{
			return allocator > Allocator.None;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000377C File Offset: 0x0000197C
		public unsafe static void MemCpyReplicate(void* destination, void* source, int size, int count)
		{
			UnsafeUtility.MemCpyReplicateDelegateField(destination, source, size, count);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000378C File Offset: 0x0000198C
		public static bool IsUnmanaged(Type type)
		{
			return UnsafeUtility.IsUnmanagedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(type));
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000379E File Offset: 0x0000199E
		public static bool IsValidNativeContainerElementType(Type type)
		{
			return UnsafeUtility.IsValidNativeContainerElementTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(type));
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000037B0 File Offset: 0x000019B0
		public static void LogError(string msg, string filename, int linenumber)
		{
			UnsafeUtility.LogErrorDelegateField(IL2CPP.ManagedStringToIl2Cpp(msg), IL2CPP.ManagedStringToIl2Cpp(filename), linenumber);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00020B6C File Offset: 0x0001ED6C
		public static bool IsGenericListBlittable<T>() where T : struct
		{
			return UnsafeUtility.IsBlittable<T>();
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00020B84 File Offset: 0x0001ED84
		public static string GetReasonForGenericListNonBlittable<T>() where T : struct
		{
			Type typeFromHandle = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
			return UnsafeUtility.GetReasonForTypeNonBlittableImpl(typeFromHandle, typeFromHandle.Name);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00020BB0 File Offset: 0x0001EDB0
		public static string GetReasonForTypeNonBlittable(Type t)
		{
			return UnsafeUtility.GetReasonForTypeNonBlittableImpl(t, t.Name);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00020BD0 File Offset: 0x0001EDD0
		public static string GetReasonForValueTypeNonBlittable<T>() where T : struct
		{
			Type typeFromHandle = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
			return UnsafeUtility.GetReasonForTypeNonBlittableImpl(typeFromHandle, typeFromHandle.Name);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00020BFC File Offset: 0x0001EDFC
		public static bool IsNativeContainerType<T>()
		{
			return (UnsafeUtility.TypeFlagsCache.flags & 2) != 0;
		}

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr_LeakRecord_Internal_Static_Int32_IntPtr_LeakCategory_Int32_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_LeakErase_Internal_Static_Int32_IntPtr_LeakCategory_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_MallocTracked_Public_Static_ptr_Void_Int64_Int32_Allocator_Int32_0;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_FreeTracked_Public_Static_Void_ptr_Void_Allocator_0;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_Malloc_Public_Static_ptr_Void_Int64_Int32_Allocator_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_Allocator_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_MemCpy_Public_Static_Void_ptr_Void_ptr_Void_Int64_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_MemCpyStride_Public_Static_Void_ptr_Void_Int32_ptr_Void_Int32_Int32_Int32_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr_MemMove_Public_Static_Void_ptr_Void_ptr_Void_Int64_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_MemSet_Public_Static_Void_ptr_Void_Byte_Int64_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_MemClear_Public_Static_Void_ptr_Void_Int64_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_MemCmp_Public_Static_Int32_ptr_Void_ptr_Void_Int64_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_IsBlittable_Public_Static_Boolean_Type_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_GetScriptingTypeFlags_Internal_Static_Int32_Type_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_IsBlittableValueType_Private_Static_Boolean_Type_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_GetReasonForTypeNonBlittableImpl_Private_Static_String_Type_String_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_IsArrayBlittable_Internal_Static_Boolean_Array_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_GetReasonForArrayNonBlittable_Internal_Static_String_Array_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_IsUnmanaged_Public_Static_Boolean_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_IsValidNativeContainerElementType_Public_Static_Boolean_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_AlignOf_Public_Static_Int32_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_CopyPtrToStructure_Public_Static_Void_ptr_Void_byref_T_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_InternalCopyPtrToStructure_Private_Static_Void_ptr_Void_byref_T_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_CopyStructureToPtr_Public_Static_Void_byref_T_ptr_Void_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_InternalCopyStructureToPtr_Private_Static_Void_byref_T_ptr_Void_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_AddressOf_Public_Static_ptr_Void_byref_T_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_As_Public_Static_byref_T_byref_U_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_AsRef_Public_Static_byref_T_ptr_Void_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_ArrayElementAsRef_Public_Static_byref_T_ptr_Void_Int32_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_EnumToInt_Public_Static_Int32_T_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_InternalEnumToInt_Private_Static_Void_byref_T_byref_Int32_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_EnumEquals_Public_Static_Boolean_T_T_0;

		// Token: 0x0400022A RID: 554
		public const int kIsManaged = 1;

		// Token: 0x0400022B RID: 555
		public const int kIsNativeContainer = 2;

		// Token: 0x0400022C RID: 556
		private static readonly UnsafeUtility.GetFieldOffsetInStructDelegate GetFieldOffsetInStructDelegateField;

		// Token: 0x0400022D RID: 557
		private static readonly UnsafeUtility.GetFieldOffsetInClassDelegate GetFieldOffsetInClassDelegateField;

		// Token: 0x0400022E RID: 558
		private static readonly UnsafeUtility.PinSystemArrayAndGetAddressDelegate PinSystemArrayAndGetAddressDelegateField;

		// Token: 0x0400022F RID: 559
		private static readonly UnsafeUtility.PinSystemObjectAndGetAddressDelegate PinSystemObjectAndGetAddressDelegateField;

		// Token: 0x04000230 RID: 560
		private static readonly UnsafeUtility.ReleaseGCObjectDelegate ReleaseGCObjectDelegateField;

		// Token: 0x04000231 RID: 561
		private static readonly UnsafeUtility.CopyObjectAddressToPtrDelegate CopyObjectAddressToPtrDelegateField;

		// Token: 0x04000232 RID: 562
		private static readonly UnsafeUtility.CheckForLeaksDelegate CheckForLeaksDelegateField;

		// Token: 0x04000233 RID: 563
		private static readonly UnsafeUtility.ForgiveLeaksDelegate ForgiveLeaksDelegateField;

		// Token: 0x04000234 RID: 564
		private static readonly UnsafeUtility.GetLeakDetectionModeDelegate GetLeakDetectionModeDelegateField;

		// Token: 0x04000235 RID: 565
		private static readonly UnsafeUtility.SetLeakDetectionModeDelegate SetLeakDetectionModeDelegateField;

		// Token: 0x04000236 RID: 566
		private static readonly UnsafeUtility.MemCpyReplicateDelegate MemCpyReplicateDelegateField;

		// Token: 0x04000237 RID: 567
		private static readonly UnsafeUtility.IsUnmanagedDelegate IsUnmanagedDelegateField;

		// Token: 0x04000238 RID: 568
		private static readonly UnsafeUtility.IsValidNativeContainerElementTypeDelegate IsValidNativeContainerElementTypeDelegateField;

		// Token: 0x04000239 RID: 569
		private static readonly UnsafeUtility.LogErrorDelegate LogErrorDelegateField;

		// Token: 0x020003D0 RID: 976
		public sealed class TypeFlagsCache<T> : ValueType
		{
			// Token: 0x0600304B RID: 12363 RVA: 0x000AF558 File Offset: 0x000AD758
			// Note: this type is marked as 'beforefieldinit'.
			static TypeFlagsCache()
			{
				Il2CppClassPointerStore<UnsafeUtility.TypeFlagsCache<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, "TypeFlagsCache`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				UnsafeUtility.TypeFlagsCache<T>.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeUtility.TypeFlagsCache<T>>.NativeClassPtr, "flags");
				UnsafeUtility.TypeFlagsCache<T>.NativeMethodInfoPtr_Init_Private_Static_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility.TypeFlagsCache<T>>.NativeClassPtr, 100663586);
			}

			// Token: 0x0600304C RID: 12364 RVA: 0x000AF5DC File Offset: 0x000AD7DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226109, XrefRangeEnd = 1226115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Init(ref int flags)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = &flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeUtility.TypeFlagsCache<T>.NativeMethodInfoPtr_Init_Private_Static_Void_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600304D RID: 12365 RVA: 0x000158E1 File Offset: 0x00013AE1
			public TypeFlagsCache(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600304E RID: 12366 RVA: 0x000158EA File Offset: 0x00013AEA
			public TypeFlagsCache() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsafeUtility.TypeFlagsCache<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000A04 RID: 2564
			// (get) Token: 0x0600304F RID: 12367 RVA: 0x000AF610 File Offset: 0x000AD810
			// (set) Token: 0x06003050 RID: 12368 RVA: 0x000158FC File Offset: 0x00013AFC
			public unsafe static int flags
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(UnsafeUtility.TypeFlagsCache<T>.NativeFieldInfoPtr_flags, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnsafeUtility.TypeFlagsCache<T>.NativeFieldInfoPtr_flags, (void*)(&value));
				}
			}

			// Token: 0x04002A08 RID: 10760
			private static readonly IntPtr NativeFieldInfoPtr_flags;

			// Token: 0x04002A09 RID: 10761
			private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Static_Void_byref_Int32_0;
		}

		// Token: 0x020003D1 RID: 977
		public sealed class AlignOfHelper<T> : ValueType where T : new()
		{
			// Token: 0x06003051 RID: 12369 RVA: 0x000AF62C File Offset: 0x000AD82C
			// Note: this type is marked as 'beforefieldinit'.
			static AlignOfHelper()
			{
				Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, "AlignOfHelper`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr);
				UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_dummy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr, "dummy");
				UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr, "data");
			}

			// Token: 0x06003052 RID: 12370 RVA: 0x0001590A File Offset: 0x00013B0A
			public AlignOfHelper(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003053 RID: 12371 RVA: 0x00015913 File Offset: 0x00013B13
			public AlignOfHelper() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsafeUtility.AlignOfHelper<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000A05 RID: 2565
			// (get) Token: 0x06003054 RID: 12372 RVA: 0x000AF6BC File Offset: 0x000AD8BC
			// (set) Token: 0x06003055 RID: 12373 RVA: 0x00015925 File Offset: 0x00013B25
			public unsafe byte dummy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_dummy);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_dummy)) = value;
				}
			}

			// Token: 0x17000A06 RID: 2566
			// (get) Token: 0x06003056 RID: 12374 RVA: 0x000AF6E4 File Offset: 0x000AD8E4
			// (set) Token: 0x06003057 RID: 12375 RVA: 0x000AF70C File Offset: 0x000AD90C
			public unsafe T data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_data);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnsafeUtility.AlignOfHelper<T>.NativeFieldInfoPtr_data);
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

			// Token: 0x04002A0A RID: 10762
			private static readonly IntPtr NativeFieldInfoPtr_dummy;

			// Token: 0x04002A0B RID: 10763
			private static readonly IntPtr NativeFieldInfoPtr_data;
		}

		// Token: 0x020003D2 RID: 978
		private sealed class MethodInfoStoreGeneric_IsUnmanaged_Public_Static_Boolean_0<T>
		{
			// Token: 0x04002A0C RID: 10764
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_IsUnmanaged_Public_Static_Boolean_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003D3 RID: 979
		private sealed class MethodInfoStoreGeneric_IsValidNativeContainerElementType_Public_Static_Boolean_0<T>
		{
			// Token: 0x04002A0D RID: 10765
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_IsValidNativeContainerElementType_Public_Static_Boolean_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003D4 RID: 980
		private sealed class MethodInfoStoreGeneric_AlignOf_Public_Static_Int32_0<T>
		{
			// Token: 0x04002A0E RID: 10766
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_AlignOf_Public_Static_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003D5 RID: 981
		private sealed class MethodInfoStoreGeneric_CopyPtrToStructure_Public_Static_Void_ptr_Void_byref_T_0<T>
		{
			// Token: 0x04002A0F RID: 10767
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_CopyPtrToStructure_Public_Static_Void_ptr_Void_byref_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003D6 RID: 982
		private sealed class MethodInfoStoreGeneric_InternalCopyPtrToStructure_Private_Static_Void_ptr_Void_byref_T_0<T>
		{
			// Token: 0x04002A10 RID: 10768
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_InternalCopyPtrToStructure_Private_Static_Void_ptr_Void_byref_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003D7 RID: 983
		private sealed class MethodInfoStoreGeneric_CopyStructureToPtr_Public_Static_Void_byref_T_ptr_Void_0<T>
		{
			// Token: 0x04002A11 RID: 10769
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_CopyStructureToPtr_Public_Static_Void_byref_T_ptr_Void_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003D8 RID: 984
		private sealed class MethodInfoStoreGeneric_InternalCopyStructureToPtr_Private_Static_Void_byref_T_ptr_Void_0<T>
		{
			// Token: 0x04002A12 RID: 10770
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_InternalCopyStructureToPtr_Private_Static_Void_byref_T_ptr_Void_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003D9 RID: 985
		private sealed class MethodInfoStoreGeneric_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0<T>
		{
			// Token: 0x04002A13 RID: 10771
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003DA RID: 986
		private sealed class MethodInfoStoreGeneric_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0<T>
		{
			// Token: 0x04002A14 RID: 10772
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003DB RID: 987
		private sealed class MethodInfoStoreGeneric_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0<T>
		{
			// Token: 0x04002A15 RID: 10773
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003DC RID: 988
		private sealed class MethodInfoStoreGeneric_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0<T>
		{
			// Token: 0x04002A16 RID: 10774
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003DD RID: 989
		private sealed class MethodInfoStoreGeneric_AddressOf_Public_Static_ptr_Void_byref_T_0<T>
		{
			// Token: 0x04002A17 RID: 10775
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_AddressOf_Public_Static_ptr_Void_byref_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003DE RID: 990
		private sealed class MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_0<T>
		{
			// Token: 0x04002A18 RID: 10776
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003DF RID: 991
		private sealed class MethodInfoStoreGeneric_As_Public_Static_byref_T_byref_U_0<U, T>
		{
			// Token: 0x04002A19 RID: 10777
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_As_Public_Static_byref_T_byref_U_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003E0 RID: 992
		private sealed class MethodInfoStoreGeneric_AsRef_Public_Static_byref_T_ptr_Void_0<T>
		{
			// Token: 0x04002A1A RID: 10778
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_AsRef_Public_Static_byref_T_ptr_Void_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003E1 RID: 993
		private sealed class MethodInfoStoreGeneric_ArrayElementAsRef_Public_Static_byref_T_ptr_Void_Int32_0<T>
		{
			// Token: 0x04002A1B RID: 10779
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_ArrayElementAsRef_Public_Static_byref_T_ptr_Void_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003E2 RID: 994
		private sealed class MethodInfoStoreGeneric_EnumToInt_Public_Static_Int32_T_0<T>
		{
			// Token: 0x04002A1C RID: 10780
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_EnumToInt_Public_Static_Int32_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003E3 RID: 995
		private sealed class MethodInfoStoreGeneric_InternalEnumToInt_Private_Static_Void_byref_T_byref_Int32_0<T>
		{
			// Token: 0x04002A1D RID: 10781
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_InternalEnumToInt_Private_Static_Void_byref_T_byref_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003E4 RID: 996
		private sealed class MethodInfoStoreGeneric_EnumEquals_Public_Static_Boolean_T_T_0<T>
		{
			// Token: 0x04002A1E RID: 10782
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeUtility.NativeMethodInfoPtr_EnumEquals_Public_Static_Boolean_T_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003E5 RID: 997
		// (Invoke) Token: 0x0600306C RID: 12396
		private delegate int GetFieldOffsetInStructDelegate(IntPtr field);

		// Token: 0x020003E6 RID: 998
		// (Invoke) Token: 0x0600306E RID: 12398
		private delegate int GetFieldOffsetInClassDelegate(IntPtr field);

		// Token: 0x020003E7 RID: 999
		// (Invoke) Token: 0x06003070 RID: 12400
		private delegate IntPtr PinSystemArrayAndGetAddressDelegate(IntPtr target, [Out] IntPtr gcHandle);

		// Token: 0x020003E8 RID: 1000
		// (Invoke) Token: 0x06003072 RID: 12402
		private delegate IntPtr PinSystemObjectAndGetAddressDelegate(IntPtr target, [Out] IntPtr gcHandle);

		// Token: 0x020003E9 RID: 1001
		// (Invoke) Token: 0x06003074 RID: 12404
		private delegate void ReleaseGCObjectDelegate(ulong gcHandle);

		// Token: 0x020003EA RID: 1002
		// (Invoke) Token: 0x06003076 RID: 12406
		private delegate void CopyObjectAddressToPtrDelegate(IntPtr target, IntPtr dstPtr);

		// Token: 0x020003EB RID: 1003
		// (Invoke) Token: 0x06003078 RID: 12408
		private delegate int CheckForLeaksDelegate();

		// Token: 0x020003EC RID: 1004
		// (Invoke) Token: 0x0600307A RID: 12410
		private delegate int ForgiveLeaksDelegate();

		// Token: 0x020003ED RID: 1005
		// (Invoke) Token: 0x0600307C RID: 12412
		private delegate NativeLeakDetectionMode GetLeakDetectionModeDelegate();

		// Token: 0x020003EE RID: 1006
		// (Invoke) Token: 0x0600307E RID: 12414
		private delegate void SetLeakDetectionModeDelegate(NativeLeakDetectionMode value);

		// Token: 0x020003EF RID: 1007
		// (Invoke) Token: 0x06003080 RID: 12416
		private delegate void MemCpyReplicateDelegate(IntPtr destination, IntPtr source, int size, int count);

		// Token: 0x020003F0 RID: 1008
		// (Invoke) Token: 0x06003082 RID: 12418
		private delegate bool IsUnmanagedDelegate(IntPtr type);

		// Token: 0x020003F1 RID: 1009
		// (Invoke) Token: 0x06003084 RID: 12420
		private delegate bool IsValidNativeContainerElementTypeDelegate(IntPtr type);

		// Token: 0x020003F2 RID: 1010
		// (Invoke) Token: 0x06003086 RID: 12422
		private delegate void LogErrorDelegate(IntPtr msg, IntPtr filename, int linenumber);
	}
}
