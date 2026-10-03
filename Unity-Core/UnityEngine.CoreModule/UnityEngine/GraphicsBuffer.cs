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
	// Token: 0x020000AB RID: 171
	public sealed class GraphicsBuffer : Object
	{
		// Token: 0x06000DD9 RID: 3545 RVA: 0x000401C0 File Offset: 0x0003E3C0
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicsBuffer()
		{
			Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "GraphicsBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr);
			GraphicsBuffer.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, "m_Ptr");
			GraphicsBuffer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664564);
			GraphicsBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664565);
			GraphicsBuffer.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664566);
			GraphicsBuffer.NativeMethodInfoPtr_RequiresCompute_Private_Static_Boolean_Target_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664567);
			GraphicsBuffer.NativeMethodInfoPtr_IsVertexIndexOrCopyOnly_Private_Static_Boolean_Target_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664568);
			GraphicsBuffer.NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Target_UsageFlags_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664569);
			GraphicsBuffer.NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664570);
			GraphicsBuffer.NativeMethodInfoPtr__ctor_Public_Void_Target_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664571);
			GraphicsBuffer.NativeMethodInfoPtr_InternalInitialization_Private_Void_Target_UsageFlags_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664572);
			GraphicsBuffer.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664573);
			GraphicsBuffer.NativeMethodInfoPtr_get_count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664574);
			GraphicsBuffer.NativeMethodInfoPtr_get_stride_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664575);
			GraphicsBuffer.NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664576);
			GraphicsBuffer.NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664577);
			GraphicsBuffer.NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664578);
			GraphicsBuffer.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664579);
			GraphicsBuffer.NativeMethodInfoPtr_SetName_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr, 100664580);
			GraphicsBuffer.IsValidBufferDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.IsValidBufferDelegate>("UnityEngine.GraphicsBuffer::IsValidBuffer");
			GraphicsBuffer.get_targetDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.get_targetDelegate>("UnityEngine.GraphicsBuffer::get_target");
			GraphicsBuffer.GetUsageFlagsDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.GetUsageFlagsDelegate>("UnityEngine.GraphicsBuffer::GetUsageFlags");
			GraphicsBuffer.InternalSetDataDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.InternalSetDataDelegate>("UnityEngine.GraphicsBuffer::InternalSetData");
			GraphicsBuffer.InternalGetDataDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.InternalGetDataDelegate>("UnityEngine.GraphicsBuffer::InternalGetData");
			GraphicsBuffer.GetNativeBufferPtrDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.GetNativeBufferPtrDelegate>("UnityEngine.GraphicsBuffer::GetNativeBufferPtr");
			GraphicsBuffer.BeginBufferWriteDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.BeginBufferWriteDelegate>("UnityEngine.GraphicsBuffer::BeginBufferWrite");
			GraphicsBuffer.EndBufferWriteDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.EndBufferWriteDelegate>("UnityEngine.GraphicsBuffer::EndBufferWrite");
			GraphicsBuffer.SetCounterValueDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.SetCounterValueDelegate>("UnityEngine.GraphicsBuffer::SetCounterValue");
			GraphicsBuffer.CopyCountCCDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.CopyCountCCDelegate>("UnityEngine.GraphicsBuffer::CopyCountCC");
			GraphicsBuffer.CopyCountGCDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.CopyCountGCDelegate>("UnityEngine.GraphicsBuffer::CopyCountGC");
			GraphicsBuffer.CopyCountCGDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.CopyCountCGDelegate>("UnityEngine.GraphicsBuffer::CopyCountCG");
			GraphicsBuffer.CopyCountGGDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.CopyCountGGDelegate>("UnityEngine.GraphicsBuffer::CopyCountGG");
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x0004041C File Offset: 0x0003E61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237759, XrefRangeEnd = 1237763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00040450 File Offset: 0x0003E650
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1237771, RefRangeEnd = 1237797, XrefRangeStart = 1237763, XrefRangeEnd = 1237771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00040484 File Offset: 0x0003E684
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237813, RefRangeEnd = 1237814, XrefRangeStart = 1237797, XrefRangeEnd = 1237813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref disposing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x000404C4 File Offset: 0x0003E6C4
		[CallerCount(0)]
		public unsafe static bool RequiresCompute(GraphicsBuffer.Target target)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref target;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_RequiresCompute_Private_Static_Boolean_Target_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00040504 File Offset: 0x0003E704
		[CallerCount(0)]
		public unsafe static bool IsVertexIndexOrCopyOnly(GraphicsBuffer.Target target)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref target;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_IsVertexIndexOrCopyOnly_Private_Static_Boolean_Target_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x00040544 File Offset: 0x0003E744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237814, XrefRangeEnd = 1237816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr InitBuffer(GraphicsBuffer.Target target, GraphicsBuffer.UsageFlags usageFlags, int count, int stride)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref target;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usageFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Target_UsageFlags_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x000405AC File Offset: 0x0003E7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237816, XrefRangeEnd = 1237818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyBuffer(GraphicsBuffer buf)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(buf);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_GraphicsBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x000405E4 File Offset: 0x0003E7E4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1237820, RefRangeEnd = 1237828, XrefRangeStart = 1237818, XrefRangeEnd = 1237820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsBuffer(GraphicsBuffer.Target target, int count, int stride) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref target;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr__ctor_Public_Void_Target_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00040648 File Offset: 0x0003E848
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237832, RefRangeEnd = 1237833, XrefRangeStart = 1237828, XrefRangeEnd = 1237832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalInitialization(GraphicsBuffer.Target target, GraphicsBuffer.UsageFlags usageFlags, int count, int stride)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref target;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usageFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_InternalInitialization_Private_Void_Target_UsageFlags_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x000406B0 File Offset: 0x0003E8B0
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1237771, RefRangeEnd = 1237797, XrefRangeStart = 1237771, XrefRangeEnd = 1237797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x000406E4 File Offset: 0x0003E8E4
		public unsafe int count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1237835, RefRangeEnd = 1237836, XrefRangeStart = 1237833, XrefRangeEnd = 1237835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_get_count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x00040720 File Offset: 0x0003E920
		public unsafe int stride
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1237838, RefRangeEnd = 1237841, XrefRangeStart = 1237836, XrefRangeEnd = 1237838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_get_stride_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x0004075C File Offset: 0x0003E95C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237845, RefRangeEnd = 1237846, XrefRangeStart = 1237841, XrefRangeEnd = 1237845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData<T>(Unity.Collections.NativeArray<T> data) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.MethodInfoStoreGeneric_SetData_Public_Void_NativeArray_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x000407A4 File Offset: 0x0003E9A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1237850, RefRangeEnd = 1237852, XrefRangeStart = 1237846, XrefRangeEnd = 1237850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData<T>(Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeBufferStartIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref graphicsBufferStartIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.MethodInfoStoreGeneric_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00040818 File Offset: 0x0003EA18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1237854, RefRangeEnd = 1237856, XrefRangeStart = 1237852, XrefRangeEnd = 1237854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref data;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeBufferStartIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref graphicsBufferStartIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elemSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002EE RID: 750
		// (set) Token: 0x06000DE9 RID: 3561 RVA: 0x00040890 File Offset: 0x0003EA90
		public unsafe string name
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1237858, RefRangeEnd = 1237860, XrefRangeStart = 1237856, XrefRangeEnd = 1237858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x000408D4 File Offset: 0x0003EAD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1237858, RefRangeEnd = 1237860, XrefRangeStart = 1237858, XrefRangeEnd = 1237860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBuffer.NativeMethodInfoPtr_SetName_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x000085F1 File Offset: 0x000067F1
		public GraphicsBuffer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x00040918 File Offset: 0x0003EB18
		// (set) Token: 0x06000DED RID: 3565 RVA: 0x000085FA File Offset: 0x000067FA
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsBuffer.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsBuffer.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00008615 File Offset: 0x00006815
		public static bool IsValidBuffer(GraphicsBuffer buf)
		{
			return GraphicsBuffer.IsValidBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(buf));
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00040940 File Offset: 0x0003EB40
		public bool IsValid()
		{
			return this.m_Ptr != IntPtr.Zero && GraphicsBuffer.IsValidBuffer(this);
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x00008627 File Offset: 0x00006827
		public GraphicsBuffer.Target target
		{
			get
			{
				return GraphicsBuffer.get_targetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00008639 File Offset: 0x00006839
		public GraphicsBuffer.UsageFlags GetUsageFlags()
		{
			return GraphicsBuffer.GetUsageFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x00040970 File Offset: 0x0003EB70
		public GraphicsBuffer.UsageFlags usageFlags
		{
			get
			{
				return this.GetUsageFlags();
			}
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00040988 File Offset: 0x0003EB88
		public void SetData(Array data)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to GraphicsBuffer.SetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			this.InternalSetData(data, 0, 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x000409F0 File Offset: 0x0003EBF0
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
				throw new ArgumentException(String.Format("List<{0}> passed to GraphicsBuffer.SetData(List<>) must be blittable.\n{1}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			this.InternalSetData(NoAllocHelpers.ExtractArrayFromList(data), 0, 0, NoAllocHelpers.SafeLength<T>(data), Marshal.SizeOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00040A64 File Offset: 0x0003EC64
		public void SetData(Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to GraphicsBuffer.SetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag3 = managedBufferStartIndex < 0 || graphicsBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Length;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} graphicsBufferStartIndex:{1} count:{2})", managedBufferStartIndex, graphicsBufferStartIndex, count));
			}
			this.InternalSetData(data, managedBufferStartIndex, graphicsBufferStartIndex, count, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00040B08 File Offset: 0x0003ED08
		public void SetData<T>(List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag2)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to GraphicsBuffer.SetData(List<>) must be blittable.\n{1}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			bool flag3 = managedBufferStartIndex < 0 || graphicsBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Count;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} graphicsBufferStartIndex:{1} count:{2})", managedBufferStartIndex, graphicsBufferStartIndex, count));
			}
			this.InternalSetData(NoAllocHelpers.ExtractArrayFromList(data), managedBufferStartIndex, graphicsBufferStartIndex, count, Marshal.SizeOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x0000864B File Offset: 0x0000684B
		public void InternalSetData(Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
			GraphicsBuffer.InternalSetDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), managedBufferStartIndex, graphicsBufferStartIndex, count, elemSize);
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00040BB8 File Offset: 0x0003EDB8
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
				throw new ArgumentException(String.Format("Array passed to GraphicsBuffer.GetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			this.InternalGetData(data, 0, 0, data.Length, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00040C20 File Offset: 0x0003EE20
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
				throw new ArgumentException(String.Format("Array passed to GraphicsBuffer.GetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag3 = managedBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Length;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count argument (managedBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", managedBufferStartIndex, computeBufferStartIndex, count));
			}
			this.InternalGetData(data, managedBufferStartIndex, computeBufferStartIndex, count, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00008669 File Offset: 0x00006869
		public void InternalGetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
		{
			GraphicsBuffer.InternalGetDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), managedBufferStartIndex, computeBufferStartIndex, count, elemSize);
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00008687 File Offset: 0x00006887
		public IntPtr GetNativeBufferPtr()
		{
			return GraphicsBuffer.GetNativeBufferPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00008699 File Offset: 0x00006899
		public unsafe void* BeginBufferWrite([Optional] int offset, [Optional] int size)
		{
			return GraphicsBuffer.BeginBufferWriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), offset, size);
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x000086AD File Offset: 0x000068AD
		public Unity.Collections.NativeArray<T> LockBufferForWrite<T>(int bufferStartIndex, int count) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x000086BA File Offset: 0x000068BA
		public void EndBufferWrite([Optional] int bytesWritten)
		{
			GraphicsBuffer.EndBufferWriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), bytesWritten);
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00040CC4 File Offset: 0x0003EEC4
		public void UnlockBufferAfterWrite<T>(int countWritten) where T : struct
		{
			bool flag = countWritten < 0;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (countWritten:{0})", countWritten));
			}
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			this.EndBufferWrite(countWritten * num);
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x000086CD File Offset: 0x000068CD
		public void SetCounterValue(uint counterValue)
		{
			GraphicsBuffer.SetCounterValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), counterValue);
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x000086E0 File Offset: 0x000068E0
		public static void CopyCountCC(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountCCDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x000086F9 File Offset: 0x000068F9
		public static void CopyCountGC(GraphicsBuffer src, ComputeBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountGCDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00008712 File Offset: 0x00006912
		public static void CopyCountCG(ComputeBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountCGDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0000872B File Offset: 0x0000692B
		public static void CopyCountGG(GraphicsBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountGGDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00008744 File Offset: 0x00006944
		public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountCC(src, dst, dstOffsetBytes);
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00008750 File Offset: 0x00006950
		public static void CopyCount(GraphicsBuffer src, ComputeBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountGC(src, dst, dstOffsetBytes);
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x0000875C File Offset: 0x0000695C
		public static void CopyCount(ComputeBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountCG(src, dst, dstOffsetBytes);
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00008768 File Offset: 0x00006968
		public static void CopyCount(GraphicsBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountGG(src, dst, dstOffsetBytes);
		}

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeMethodInfoPtr_RequiresCompute_Private_Static_Boolean_Target_0;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr_IsVertexIndexOrCopyOnly_Private_Static_Boolean_Target_0;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Target_UsageFlags_Int32_Int32_0;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_GraphicsBuffer_0;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Target_Int32_Int32_0;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeMethodInfoPtr_InternalInitialization_Private_Void_Target_UsageFlags_Int32_Int32_0;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeMethodInfoPtr_get_count_Public_get_Int32_0;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeMethodInfoPtr_get_stride_Public_get_Int32_0;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_0;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetNativeData_Private_Void_IntPtr_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeMethodInfoPtr_SetName_Private_Void_String_0;

		// Token: 0x04000A46 RID: 2630
		private static readonly GraphicsBuffer.IsValidBufferDelegate IsValidBufferDelegateField;

		// Token: 0x04000A47 RID: 2631
		private static readonly GraphicsBuffer.get_targetDelegate get_targetDelegateField;

		// Token: 0x04000A48 RID: 2632
		private static readonly GraphicsBuffer.GetUsageFlagsDelegate GetUsageFlagsDelegateField;

		// Token: 0x04000A49 RID: 2633
		private static readonly GraphicsBuffer.InternalSetDataDelegate InternalSetDataDelegateField;

		// Token: 0x04000A4A RID: 2634
		private static readonly GraphicsBuffer.InternalGetDataDelegate InternalGetDataDelegateField;

		// Token: 0x04000A4B RID: 2635
		private static readonly GraphicsBuffer.GetNativeBufferPtrDelegate GetNativeBufferPtrDelegateField;

		// Token: 0x04000A4C RID: 2636
		private static readonly GraphicsBuffer.BeginBufferWriteDelegate BeginBufferWriteDelegateField;

		// Token: 0x04000A4D RID: 2637
		private static readonly GraphicsBuffer.EndBufferWriteDelegate EndBufferWriteDelegateField;

		// Token: 0x04000A4E RID: 2638
		private static readonly GraphicsBuffer.SetCounterValueDelegate SetCounterValueDelegateField;

		// Token: 0x04000A4F RID: 2639
		private static readonly GraphicsBuffer.CopyCountCCDelegate CopyCountCCDelegateField;

		// Token: 0x04000A50 RID: 2640
		private static readonly GraphicsBuffer.CopyCountGCDelegate CopyCountGCDelegateField;

		// Token: 0x04000A51 RID: 2641
		private static readonly GraphicsBuffer.CopyCountCGDelegate CopyCountCGDelegateField;

		// Token: 0x04000A52 RID: 2642
		private static readonly GraphicsBuffer.CopyCountGGDelegate CopyCountGGDelegateField;

		// Token: 0x020006F4 RID: 1780
		[OriginalName("UnityEngine.CoreModule.dll", "", "Target")]
		[Flags]
		public enum Target
		{
			// Token: 0x04002A96 RID: 10902
			Vertex = 1,
			// Token: 0x04002A97 RID: 10903
			Index = 2,
			// Token: 0x04002A98 RID: 10904
			CopySource = 4,
			// Token: 0x04002A99 RID: 10905
			CopyDestination = 8,
			// Token: 0x04002A9A RID: 10906
			Structured = 16,
			// Token: 0x04002A9B RID: 10907
			Raw = 32,
			// Token: 0x04002A9C RID: 10908
			Append = 64,
			// Token: 0x04002A9D RID: 10909
			Counter = 128,
			// Token: 0x04002A9E RID: 10910
			IndirectArguments = 256,
			// Token: 0x04002A9F RID: 10911
			Constant = 512
		}

		// Token: 0x020006F5 RID: 1781
		[OriginalName("UnityEngine.CoreModule.dll", "", "UsageFlags")]
		[Flags]
		public enum UsageFlags
		{
			// Token: 0x04002AA1 RID: 10913
			None = 0,
			// Token: 0x04002AA2 RID: 10914
			LockBufferForWrite = 1
		}

		// Token: 0x020006F6 RID: 1782
		private sealed class MethodInfoStoreGeneric_SetData_Public_Void_NativeArray_1_T_0<T>
		{
			// Token: 0x04002AA3 RID: 10915
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GraphicsBuffer.NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_0, Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020006F7 RID: 1783
		private sealed class MethodInfoStoreGeneric_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0<T>
		{
			// Token: 0x04002AA4 RID: 10916
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GraphicsBuffer.NativeMethodInfoPtr_SetData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_0, Il2CppClassPointerStore<GraphicsBuffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020006F8 RID: 1784
		// (Invoke) Token: 0x060036A4 RID: 13988
		private delegate bool IsValidBufferDelegate(IntPtr buf);

		// Token: 0x020006F9 RID: 1785
		// (Invoke) Token: 0x060036A6 RID: 13990
		private delegate GraphicsBuffer.Target get_targetDelegate(IntPtr @this);

		// Token: 0x020006FA RID: 1786
		// (Invoke) Token: 0x060036A8 RID: 13992
		private delegate GraphicsBuffer.UsageFlags GetUsageFlagsDelegate(IntPtr @this);

		// Token: 0x020006FB RID: 1787
		// (Invoke) Token: 0x060036AA RID: 13994
		private delegate void InternalSetDataDelegate(IntPtr @this, IntPtr data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);

		// Token: 0x020006FC RID: 1788
		// (Invoke) Token: 0x060036AC RID: 13996
		private delegate void InternalGetDataDelegate(IntPtr @this, IntPtr data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);

		// Token: 0x020006FD RID: 1789
		// (Invoke) Token: 0x060036AE RID: 13998
		private delegate IntPtr GetNativeBufferPtrDelegate(IntPtr @this);

		// Token: 0x020006FE RID: 1790
		// (Invoke) Token: 0x060036B0 RID: 14000
		private delegate IntPtr BeginBufferWriteDelegate(IntPtr @this, int offset, int size);

		// Token: 0x020006FF RID: 1791
		// (Invoke) Token: 0x060036B2 RID: 14002
		private delegate void EndBufferWriteDelegate(IntPtr @this, int bytesWritten);

		// Token: 0x02000700 RID: 1792
		// (Invoke) Token: 0x060036B4 RID: 14004
		private delegate void SetCounterValueDelegate(IntPtr @this, uint counterValue);

		// Token: 0x02000701 RID: 1793
		// (Invoke) Token: 0x060036B6 RID: 14006
		private delegate void CopyCountCCDelegate(IntPtr src, IntPtr dst, int dstOffsetBytes);

		// Token: 0x02000702 RID: 1794
		// (Invoke) Token: 0x060036B8 RID: 14008
		private delegate void CopyCountGCDelegate(IntPtr src, IntPtr dst, int dstOffsetBytes);

		// Token: 0x02000703 RID: 1795
		// (Invoke) Token: 0x060036BA RID: 14010
		private delegate void CopyCountCGDelegate(IntPtr src, IntPtr dst, int dstOffsetBytes);

		// Token: 0x02000704 RID: 1796
		// (Invoke) Token: 0x060036BC RID: 14012
		private delegate void CopyCountGGDelegate(IntPtr src, IntPtr dst, int dstOffsetBytes);
	}
}
