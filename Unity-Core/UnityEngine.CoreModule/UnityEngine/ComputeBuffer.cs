using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x0200015E RID: 350
	public sealed class ComputeBuffer : Object
	{
		// Token: 0x060019DD RID: 6621 RVA: 0x0006E074 File Offset: 0x0006C274
		// Note: this type is marked as 'beforefieldinit'.
		static ComputeBuffer()
		{
			Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ComputeBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr);
			ComputeBuffer.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, "m_Ptr");
			ComputeBuffer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666073);
			ComputeBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666074);
			ComputeBuffer.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666075);
			ComputeBuffer.NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Int32_Int32_ComputeBufferType_ComputeBufferMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666076);
			ComputeBuffer.NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666077);
			ComputeBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666078);
			ComputeBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_ComputeBufferType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666079);
			ComputeBuffer.NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_ComputeBufferType_ComputeBufferMode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666080);
			ComputeBuffer.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666081);
			ComputeBuffer.NativeMethodInfoPtr_get_count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666082);
			ComputeBuffer.NativeMethodInfoPtr_get_stride_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666083);
			ComputeBuffer.NativeMethodInfoPtr_SetData_Public_Void_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666084);
			ComputeBuffer.NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666085);
			ComputeBuffer.NativeMethodInfoPtr_SetData_Public_Void_Array_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666086);
			ComputeBuffer.NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666087);
			ComputeBuffer.NativeMethodInfoPtr_InternalSetData_Private_Void_Array_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666088);
			ComputeBuffer.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666089);
			ComputeBuffer.NativeMethodInfoPtr_SetName_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666090);
			ComputeBuffer.NativeMethodInfoPtr_SetCounterValue_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666091);
			ComputeBuffer.NativeMethodInfoPtr_CopyCount_Public_Static_Void_ComputeBuffer_ComputeBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100666092);
			ComputeBuffer.IsValidBufferDelegateField = IL2CPP.ResolveICall<ComputeBuffer.IsValidBufferDelegate>("UnityEngine.ComputeBuffer::IsValidBuffer");
			ComputeBuffer.get_usageDelegateField = IL2CPP.ResolveICall<ComputeBuffer.get_usageDelegate>("UnityEngine.ComputeBuffer::get_usage");
			ComputeBuffer.InternalGetDataDelegateField = IL2CPP.ResolveICall<ComputeBuffer.InternalGetDataDelegate>("UnityEngine.ComputeBuffer::InternalGetData");
			ComputeBuffer.BeginBufferWriteDelegateField = IL2CPP.ResolveICall<ComputeBuffer.BeginBufferWriteDelegate>("UnityEngine.ComputeBuffer::BeginBufferWrite");
			ComputeBuffer.EndBufferWriteDelegateField = IL2CPP.ResolveICall<ComputeBuffer.EndBufferWriteDelegate>("UnityEngine.ComputeBuffer::EndBufferWrite");
			ComputeBuffer.GetNativeBufferPtrDelegateField = IL2CPP.ResolveICall<ComputeBuffer.GetNativeBufferPtrDelegate>("UnityEngine.ComputeBuffer::GetNativeBufferPtr");
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x0006E2A4 File Offset: 0x0006C4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271444, XrefRangeEnd = 1271454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x0006E2D8 File Offset: 0x0006C4D8
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1271462, RefRangeEnd = 1271486, XrefRangeStart = 1271454, XrefRangeEnd = 1271462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x0006E30C File Offset: 0x0006C50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271486, XrefRangeEnd = 1271493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref disposing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x0006E34C File Offset: 0x0006C54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271493, XrefRangeEnd = 1271495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Int32_Int32_ComputeBufferType_ComputeBufferMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x0006E3B4 File Offset: 0x0006C5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271495, XrefRangeEnd = 1271497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyBuffer(ComputeBuffer buf)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(buf);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_ComputeBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x0006E3EC File Offset: 0x0006C5EC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1271498, RefRangeEnd = 1271514, XrefRangeStart = 1271497, XrefRangeEnd = 1271498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBuffer(int count, int stride) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x0006E444 File Offset: 0x0006C644
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1271515, RefRangeEnd = 1271533, XrefRangeStart = 1271514, XrefRangeEnd = 1271515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBuffer(int count, int stride, ComputeBufferType type) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_ComputeBufferType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x0006E4A8 File Offset: 0x0006C6A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1271538, RefRangeEnd = 1271540, XrefRangeStart = 1271533, XrefRangeEnd = 1271538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usage;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stackDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_ComputeBufferType_ComputeBufferMode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x0006E528 File Offset: 0x0006C728
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1271462, RefRangeEnd = 1271486, XrefRangeStart = 1271462, XrefRangeEnd = 1271486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x0006E55C File Offset: 0x0006C75C
		public unsafe int count
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1271542, RefRangeEnd = 1271544, XrefRangeStart = 1271540, XrefRangeEnd = 1271542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_get_count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060019E8 RID: 6632 RVA: 0x0006E598 File Offset: 0x0006C798
		public unsafe int stride
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1271546, RefRangeEnd = 1271554, XrefRangeStart = 1271544, XrefRangeEnd = 1271546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_get_stride_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x0006E5D4 File Offset: 0x0006C7D4
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 1271560, RefRangeEnd = 1271587, XrefRangeStart = 1271554, XrefRangeEnd = 1271560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(Array data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_SetData_Public_Void_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x0006E618 File Offset: 0x0006C818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271587, XrefRangeEnd = 1271590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData<T>(Unity.Collections.NativeArray<T> data) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.MethodInfoStoreGeneric_SetData_Public_Void_NativeArray_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x0006E660 File Offset: 0x0006C860
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1271627, RefRangeEnd = 1271630, XrefRangeStart = 1271590, XrefRangeEnd = 1271627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref managedBufferStartIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref computeBufferStartIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_SetData_Public_Void_Array_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x0006E6CC File Offset: 0x0006C8CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1271632, RefRangeEnd = 1271633, XrefRangeStart = 1271630, XrefRangeEnd = 1271632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref data;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeBufferStartIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref computeBufferStartIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elemSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x0006E744 File Offset: 0x0006C944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271633, XrefRangeEnd = 1271635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref managedBufferStartIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref computeBufferStartIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elemSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_InternalSetData_Private_Void_Array_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700053C RID: 1340
		// (set) Token: 0x060019EE RID: 6638 RVA: 0x0006E7C0 File Offset: 0x0006C9C0
		public unsafe string name
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1271637, RefRangeEnd = 1271639, XrefRangeStart = 1271635, XrefRangeEnd = 1271637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x0006E804 File Offset: 0x0006CA04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1271637, RefRangeEnd = 1271639, XrefRangeStart = 1271637, XrefRangeEnd = 1271639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_SetName_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x0006E848 File Offset: 0x0006CA48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1271641, RefRangeEnd = 1271642, XrefRangeStart = 1271639, XrefRangeEnd = 1271641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCounterValue(uint counterValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref counterValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_SetCounterValue_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x0006E888 File Offset: 0x0006CA88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1271644, RefRangeEnd = 1271645, XrefRangeStart = 1271642, XrefRangeEnd = 1271644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstOffsetBytes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_CopyCount_Public_Static_Void_ComputeBuffer_ComputeBuffer_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x0000C8F6 File Offset: 0x0000AAF6
		public ComputeBuffer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060019F3 RID: 6643 RVA: 0x0006E8E0 File Offset: 0x0006CAE0
		// (set) Token: 0x060019F4 RID: 6644 RVA: 0x0000C8FF File Offset: 0x0000AAFF
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeBuffer.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeBuffer.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x0000C91A File Offset: 0x0000AB1A
		public static bool IsValidBuffer(ComputeBuffer buf)
		{
			return ComputeBuffer.IsValidBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(buf));
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x0006E908 File Offset: 0x0006CB08
		public bool IsValid()
		{
			return this.m_Ptr != IntPtr.Zero && ComputeBuffer.IsValidBuffer(this);
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060019F7 RID: 6647 RVA: 0x0000C92C File Offset: 0x0000AB2C
		public ComputeBufferMode usage
		{
			get
			{
				return ComputeBuffer.get_usageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x0006E938 File Offset: 0x0006CB38
		public void SetData<T>(List<T> data) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag2)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to ComputeBuffer.SetData(List<>) must be blittable.\n{1}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			this.InternalSetData(NoAllocHelpers.ExtractArrayFromList(data), 0, 0, NoAllocHelpers.SafeLength<T>(data), Marshal.SizeOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x0006E9AC File Offset: 0x0006CBAC
		public void SetData<T>(List<T> data, int managedBufferStartIndex, int computeBufferStartIndex, int count) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag2)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to ComputeBuffer.SetData(List<>) must be blittable.\n{1}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			bool flag3 = managedBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Count;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", managedBufferStartIndex, computeBufferStartIndex, count));
			}
			this.InternalSetData(NoAllocHelpers.ExtractArrayFromList(data), managedBufferStartIndex, computeBufferStartIndex, count, Marshal.SizeOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x0006EA5C File Offset: 0x0006CC5C
		public void SetData<T>(Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int computeBufferStartIndex, int count) where T : struct
		{
			bool flag = nativeBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || nativeBufferStartIndex + count > data.Length;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (nativeBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", nativeBufferStartIndex, computeBufferStartIndex, count));
			}
			this.InternalSetNativeData((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), nativeBufferStartIndex, computeBufferStartIndex, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>());
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x0006EACC File Offset: 0x0006CCCC
		public void GetData(Array data)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to ComputeBuffer.GetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			this.InternalGetData(data, 0, 0, data.Length, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x0006EB34 File Offset: 0x0006CD34
		public void GetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to ComputeBuffer.GetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag3 = managedBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Length;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count argument (managedBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", managedBufferStartIndex, computeBufferStartIndex, count));
			}
			this.InternalGetData(data, managedBufferStartIndex, computeBufferStartIndex, count, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x0000C93E File Offset: 0x0000AB3E
		public void InternalGetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
		{
			ComputeBuffer.InternalGetDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), managedBufferStartIndex, computeBufferStartIndex, count, elemSize);
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x0000C95C File Offset: 0x0000AB5C
		public unsafe void* BeginBufferWrite([Optional] int offset, [Optional] int size)
		{
			return ComputeBuffer.BeginBufferWriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), offset, size);
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x0000C970 File Offset: 0x0000AB70
		public Unity.Collections.NativeArray<T> BeginWrite<T>(int computeBufferStartIndex, int count) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x0000C97D File Offset: 0x0000AB7D
		public void EndBufferWrite([Optional] int bytesWritten)
		{
			ComputeBuffer.EndBufferWriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), bytesWritten);
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x0006EBD8 File Offset: 0x0006CDD8
		public void EndWrite<T>(int countWritten) where T : struct
		{
			bool flag = countWritten < 0;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (countWritten:{0})", countWritten));
			}
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			this.EndBufferWrite(countWritten * num);
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x0000C990 File Offset: 0x0000AB90
		public IntPtr GetNativeBufferPtr()
		{
			return ComputeBuffer.GetNativeBufferPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x04001579 RID: 5497
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x0400157A RID: 5498
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400157B RID: 5499
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400157C RID: 5500
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x0400157D RID: 5501
		private static readonly IntPtr NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Int32_Int32_ComputeBufferType_ComputeBufferMode_0;

		// Token: 0x0400157E RID: 5502
		private static readonly IntPtr NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_ComputeBuffer_0;

		// Token: 0x0400157F RID: 5503
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04001580 RID: 5504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_ComputeBufferType_0;

		// Token: 0x04001581 RID: 5505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_ComputeBufferType_ComputeBufferMode_Int32_0;

		// Token: 0x04001582 RID: 5506
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x04001583 RID: 5507
		private static readonly IntPtr NativeMethodInfoPtr_get_count_Public_get_Int32_0;

		// Token: 0x04001584 RID: 5508
		private static readonly IntPtr NativeMethodInfoPtr_get_stride_Public_get_Int32_0;

		// Token: 0x04001585 RID: 5509
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_Array_0;

		// Token: 0x04001586 RID: 5510
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_0;

		// Token: 0x04001587 RID: 5511
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_Array_Int32_Int32_Int32_0;

		// Token: 0x04001588 RID: 5512
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0;

		// Token: 0x04001589 RID: 5513
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetData_Private_Void_Array_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400158A RID: 5514
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

		// Token: 0x0400158B RID: 5515
		private static readonly IntPtr NativeMethodInfoPtr_SetName_Private_Void_String_0;

		// Token: 0x0400158C RID: 5516
		private static readonly IntPtr NativeMethodInfoPtr_SetCounterValue_Public_Void_UInt32_0;

		// Token: 0x0400158D RID: 5517
		private static readonly IntPtr NativeMethodInfoPtr_CopyCount_Public_Static_Void_ComputeBuffer_ComputeBuffer_Int32_0;

		// Token: 0x0400158E RID: 5518
		private static readonly ComputeBuffer.IsValidBufferDelegate IsValidBufferDelegateField;

		// Token: 0x0400158F RID: 5519
		private static readonly ComputeBuffer.get_usageDelegate get_usageDelegateField;

		// Token: 0x04001590 RID: 5520
		private static readonly ComputeBuffer.InternalGetDataDelegate InternalGetDataDelegateField;

		// Token: 0x04001591 RID: 5521
		private static readonly ComputeBuffer.BeginBufferWriteDelegate BeginBufferWriteDelegateField;

		// Token: 0x04001592 RID: 5522
		private static readonly ComputeBuffer.EndBufferWriteDelegate EndBufferWriteDelegateField;

		// Token: 0x04001593 RID: 5523
		private static readonly ComputeBuffer.GetNativeBufferPtrDelegate GetNativeBufferPtrDelegateField;

		// Token: 0x02000903 RID: 2307
		private sealed class MethodInfoStoreGeneric_SetData_Public_Void_NativeArray_1_T_0<T>
		{
			// Token: 0x04002B53 RID: 11091
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ComputeBuffer.NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_0, Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000904 RID: 2308
		// (Invoke) Token: 0x06003A84 RID: 14980
		private delegate bool IsValidBufferDelegate(IntPtr buf);

		// Token: 0x02000905 RID: 2309
		// (Invoke) Token: 0x06003A86 RID: 14982
		private delegate ComputeBufferMode get_usageDelegate(IntPtr @this);

		// Token: 0x02000906 RID: 2310
		// (Invoke) Token: 0x06003A88 RID: 14984
		private delegate void InternalGetDataDelegate(IntPtr @this, IntPtr data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);

		// Token: 0x02000907 RID: 2311
		// (Invoke) Token: 0x06003A8A RID: 14986
		private delegate IntPtr BeginBufferWriteDelegate(IntPtr @this, int offset, int size);

		// Token: 0x02000908 RID: 2312
		// (Invoke) Token: 0x06003A8C RID: 14988
		private delegate void EndBufferWriteDelegate(IntPtr @this, int bytesWritten);

		// Token: 0x02000909 RID: 2313
		// (Invoke) Token: 0x06003A8E RID: 14990
		private delegate IntPtr GetNativeBufferPtrDelegate(IntPtr @this);
	}
}
