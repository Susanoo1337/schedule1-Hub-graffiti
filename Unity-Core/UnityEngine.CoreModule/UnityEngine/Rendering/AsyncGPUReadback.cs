using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
	// Token: 0x020001D4 RID: 468
	public static class AsyncGPUReadback : Object
	{
		// Token: 0x0600214D RID: 8525 RVA: 0x0008723C File Offset: 0x0008543C
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncGPUReadback()
		{
			Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "AsyncGPUReadback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr);
			AsyncGPUReadback.NativeMethodInfoPtr_ValidateFormat_Internal_Static_Void_Texture_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr, 100666937);
			AsyncGPUReadback.NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_ComputeBuffer_Action_1_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr, 100666938);
			AsyncGPUReadback.NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_GraphicsBuffer_Action_1_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr, 100666939);
			AsyncGPUReadback.NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_Texture_Int32_TextureFormat_Action_1_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr, 100666940);
			AsyncGPUReadback.NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_Texture_Int32_GraphicsFormat_Action_1_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr, 100666941);
			AsyncGPUReadback.NativeMethodInfoPtr_Request_Internal_ComputeBuffer_1_Private_Static_AsyncGPUReadbackRequest_ComputeBuffer_ptr_AsyncRequestNativeArrayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr, 100666942);
			AsyncGPUReadback.NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Private_Static_AsyncGPUReadbackRequest_GraphicsBuffer_ptr_AsyncRequestNativeArrayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr, 100666943);
			AsyncGPUReadback.NativeMethodInfoPtr_Request_Internal_Texture_2_Private_Static_AsyncGPUReadbackRequest_Texture_Int32_GraphicsFormat_ptr_AsyncRequestNativeArrayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr, 100666944);
			AsyncGPUReadback.NativeMethodInfoPtr_Request_Internal_ComputeBuffer_1_Injected_Private_Static_Void_ComputeBuffer_ptr_AsyncRequestNativeArrayData_byref_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr, 100666945);
			AsyncGPUReadback.NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Injected_Private_Static_Void_GraphicsBuffer_ptr_AsyncRequestNativeArrayData_byref_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr, 100666946);
			AsyncGPUReadback.NativeMethodInfoPtr_Request_Internal_Texture_2_Injected_Private_Static_Void_Texture_Int32_GraphicsFormat_ptr_AsyncRequestNativeArrayData_byref_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr, 100666947);
			AsyncGPUReadback.WaitAllRequestsDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.WaitAllRequestsDelegate>("UnityEngine.Rendering.AsyncGPUReadback::WaitAllRequests");
			AsyncGPUReadback.Request_Internal_ComputeBuffer_2_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.Request_Internal_ComputeBuffer_2_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_ComputeBuffer_2_Injected");
			AsyncGPUReadback.Request_Internal_GraphicsBuffer_2_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.Request_Internal_GraphicsBuffer_2_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_GraphicsBuffer_2_Injected");
			AsyncGPUReadback.Request_Internal_Texture_1_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.Request_Internal_Texture_1_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_Texture_1_Injected");
			AsyncGPUReadback.Request_Internal_Texture_3_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.Request_Internal_Texture_3_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_Texture_3_Injected");
			AsyncGPUReadback.Request_Internal_Texture_4_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.Request_Internal_Texture_4_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_Texture_4_Injected");
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x000873A4 File Offset: 0x000855A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287213, XrefRangeEnd = 1287228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateFormat(Texture src, UnityEngine.Experimental.Rendering.GraphicsFormat dstformat)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstformat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadback.NativeMethodInfoPtr_ValidateFormat_Internal_Static_Void_Texture_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x000873E8 File Offset: 0x000855E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1287232, RefRangeEnd = 1287233, XrefRangeStart = 1287228, XrefRangeEnd = 1287232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncGPUReadbackRequest Request(ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadback.NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_ComputeBuffer_Action_1_AsyncGPUReadbackRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x0008743C File Offset: 0x0008563C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1287237, RefRangeEnd = 1287238, XrefRangeStart = 1287233, XrefRangeEnd = 1287237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncGPUReadbackRequest Request(GraphicsBuffer src, Action<AsyncGPUReadbackRequest> callback = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadback.NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_GraphicsBuffer_Action_1_AsyncGPUReadbackRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x00087490 File Offset: 0x00085690
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1287262, RefRangeEnd = 1287263, XrefRangeStart = 1287238, XrefRangeEnd = 1287262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncGPUReadbackRequest Request(Texture src, int mipIndex, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadback.NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_Texture_Int32_TextureFormat_Action_1_AsyncGPUReadbackRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x00087500 File Offset: 0x00085700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287263, XrefRangeEnd = 1287282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncGPUReadbackRequest Request(Texture src, int mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadback.NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_Texture_Int32_GraphicsFormat_Action_1_AsyncGPUReadbackRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x00087570 File Offset: 0x00085770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287282, XrefRangeEnd = 1287284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncGPUReadbackRequest Request_Internal_ComputeBuffer_1(ComputeBuffer buffer, AsyncRequestNativeArrayData* data)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadback.NativeMethodInfoPtr_Request_Internal_ComputeBuffer_1_Private_Static_AsyncGPUReadbackRequest_ComputeBuffer_ptr_AsyncRequestNativeArrayData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x000875C0 File Offset: 0x000857C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287284, XrefRangeEnd = 1287286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncGPUReadbackRequest Request_Internal_GraphicsBuffer_1(GraphicsBuffer buffer, AsyncRequestNativeArrayData* data)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadback.NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Private_Static_AsyncGPUReadbackRequest_GraphicsBuffer_ptr_AsyncRequestNativeArrayData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x00087610 File Offset: 0x00085810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287286, XrefRangeEnd = 1287288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncGPUReadbackRequest Request_Internal_Texture_2(Texture src, int mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, AsyncRequestNativeArrayData* data)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadback.NativeMethodInfoPtr_Request_Internal_Texture_2_Private_Static_AsyncGPUReadbackRequest_Texture_Int32_GraphicsFormat_ptr_AsyncRequestNativeArrayData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x0008767C File Offset: 0x0008587C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287288, XrefRangeEnd = 1287290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Request_Internal_ComputeBuffer_1_Injected(ComputeBuffer buffer, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadback.NativeMethodInfoPtr_Request_Internal_ComputeBuffer_1_Injected_Private_Static_Void_ComputeBuffer_ptr_AsyncRequestNativeArrayData_byref_AsyncGPUReadbackRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x000876D0 File Offset: 0x000858D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287290, XrefRangeEnd = 1287292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Request_Internal_GraphicsBuffer_1_Injected(GraphicsBuffer buffer, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadback.NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Injected_Private_Static_Void_GraphicsBuffer_ptr_AsyncRequestNativeArrayData_byref_AsyncGPUReadbackRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x00087724 File Offset: 0x00085924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287292, XrefRangeEnd = 1287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Request_Internal_Texture_2_Injected(Texture src, int mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadback.NativeMethodInfoPtr_Request_Internal_Texture_2_Injected_Private_Static_Void_Texture_Int32_GraphicsFormat_ptr_AsyncRequestNativeArrayData_byref_AsyncGPUReadbackRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x0000F604 File Offset: 0x0000D804
		public AsyncGPUReadback(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x0000F60D File Offset: 0x0000D80D
		public static void WaitAllRequests()
		{
			AsyncGPUReadback.WaitAllRequestsDelegateField();
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x00087794 File Offset: 0x00085994
		public static AsyncGPUReadbackRequest Request(ComputeBuffer src, int size, int offset, [Optional] Action<AsyncGPUReadbackRequest> callback)
		{
			AsyncGPUReadbackRequest result = AsyncGPUReadback.Request_Internal_ComputeBuffer_2(src, size, offset, null);
			result.SetScriptingCallback(callback);
			return result;
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x000877BC File Offset: 0x000859BC
		public static AsyncGPUReadbackRequest Request(GraphicsBuffer src, int size, int offset, [Optional] Action<AsyncGPUReadbackRequest> callback)
		{
			AsyncGPUReadbackRequest result = AsyncGPUReadback.Request_Internal_GraphicsBuffer_2(src, size, offset, null);
			result.SetScriptingCallback(callback);
			return result;
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x000877E4 File Offset: 0x000859E4
		public static AsyncGPUReadbackRequest Request(Texture src, [Optional] int mipIndex, [Optional] Action<AsyncGPUReadbackRequest> callback)
		{
			AsyncGPUReadbackRequest result = AsyncGPUReadback.Request_Internal_Texture_1(src, mipIndex, null);
			result.SetScriptingCallback(callback);
			return result;
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x0008780C File Offset: 0x00085A0C
		public static AsyncGPUReadbackRequest Request(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, [Optional] Action<AsyncGPUReadbackRequest> callback)
		{
			AsyncGPUReadbackRequest result = AsyncGPUReadback.Request_Internal_Texture_3(src, mipIndex, x, width, y, height, z, depth, null);
			result.SetScriptingCallback(callback);
			return result;
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x00087840 File Offset: 0x00085A40
		public static AsyncGPUReadbackRequest Request(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, [Optional] Action<AsyncGPUReadbackRequest> callback)
		{
			return AsyncGPUReadback.Request(src, mipIndex, x, width, y, height, z, depth, UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(dstFormat, QualitySettings.activeColorSpace == ColorSpace.Linear), callback);
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x00087874 File Offset: 0x00085A74
		public static AsyncGPUReadbackRequest Request(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, [Optional] Action<AsyncGPUReadbackRequest> callback)
		{
			AsyncGPUReadback.ValidateFormat(src, dstFormat);
			AsyncGPUReadbackRequest result = AsyncGPUReadback.Request_Internal_Texture_4(src, mipIndex, x, width, y, height, z, depth, dstFormat, null);
			result.SetScriptingCallback(callback);
			return result;
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x000878B4 File Offset: 0x00085AB4
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, ComputeBuffer src, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest result = AsyncGPUReadback.Request_Internal_ComputeBuffer_1(src, &asyncRequestNativeArrayData);
			result.SetScriptingCallback(callback);
			return result;
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x000878E8 File Offset: 0x00085AE8
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, ComputeBuffer src, int size, int offset, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest result = AsyncGPUReadback.Request_Internal_ComputeBuffer_2(src, size, offset, &asyncRequestNativeArrayData);
			result.SetScriptingCallback(callback);
			return result;
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x00087920 File Offset: 0x00085B20
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, GraphicsBuffer src, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest result = AsyncGPUReadback.Request_Internal_GraphicsBuffer_1(src, &asyncRequestNativeArrayData);
			result.SetScriptingCallback(callback);
			return result;
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x00087954 File Offset: 0x00085B54
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, GraphicsBuffer src, int size, int offset, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest result = AsyncGPUReadback.Request_Internal_GraphicsBuffer_2(src, size, offset, &asyncRequestNativeArrayData);
			result.SetScriptingCallback(callback);
			return result;
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x0008798C File Offset: 0x00085B8C
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, Texture src, [Optional] int mipIndex, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest result = AsyncGPUReadback.Request_Internal_Texture_1(src, mipIndex, &asyncRequestNativeArrayData);
			result.SetScriptingCallback(callback);
			return result;
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x000879C0 File Offset: 0x00085BC0
		public static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, Texture src, int mipIndex, TextureFormat dstFormat, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			return AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(dstFormat, QualitySettings.activeColorSpace == ColorSpace.Linear), callback);
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x000879EC File Offset: 0x00085BEC
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, Texture src, int mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncGPUReadback.ValidateFormat(src, dstFormat);
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest result = AsyncGPUReadback.Request_Internal_Texture_2(src, mipIndex, dstFormat, &asyncRequestNativeArrayData);
			result.SetScriptingCallback(callback);
			return result;
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x00087A2C File Offset: 0x00085C2C
		public static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			return AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, mipIndex, x, width, y, height, z, depth, UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(dstFormat, QualitySettings.activeColorSpace == ColorSpace.Linear), callback);
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x00087A64 File Offset: 0x00085C64
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncGPUReadback.ValidateFormat(src, dstFormat);
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest result = AsyncGPUReadback.Request_Internal_Texture_4(src, mipIndex, x, width, y, height, z, depth, dstFormat, &asyncRequestNativeArrayData);
			result.SetScriptingCallback(callback);
			return result;
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x00087AB0 File Offset: 0x00085CB0
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref Unity.Collections.NativeSlice<T> output, ComputeBuffer src, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest result = AsyncGPUReadback.Request_Internal_ComputeBuffer_1(src, &asyncRequestNativeArrayData);
			result.SetScriptingCallback(callback);
			return result;
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x00087AE4 File Offset: 0x00085CE4
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref Unity.Collections.NativeSlice<T> output, ComputeBuffer src, int size, int offset, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest result = AsyncGPUReadback.Request_Internal_ComputeBuffer_2(src, size, offset, &asyncRequestNativeArrayData);
			result.SetScriptingCallback(callback);
			return result;
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x00087B1C File Offset: 0x00085D1C
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref Unity.Collections.NativeSlice<T> output, GraphicsBuffer src, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest result = AsyncGPUReadback.Request_Internal_GraphicsBuffer_1(src, &asyncRequestNativeArrayData);
			result.SetScriptingCallback(callback);
			return result;
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x00087B50 File Offset: 0x00085D50
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref Unity.Collections.NativeSlice<T> output, GraphicsBuffer src, int size, int offset, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest result = AsyncGPUReadback.Request_Internal_GraphicsBuffer_2(src, size, offset, &asyncRequestNativeArrayData);
			result.SetScriptingCallback(callback);
			return result;
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x00087B88 File Offset: 0x00085D88
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref Unity.Collections.NativeSlice<T> output, Texture src, [Optional] int mipIndex, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest result = AsyncGPUReadback.Request_Internal_Texture_1(src, mipIndex, &asyncRequestNativeArrayData);
			result.SetScriptingCallback(callback);
			return result;
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x00087BBC File Offset: 0x00085DBC
		public static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref Unity.Collections.NativeSlice<T> output, Texture src, int mipIndex, TextureFormat dstFormat, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			return AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(dstFormat, QualitySettings.activeColorSpace == ColorSpace.Linear), callback);
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x00087BE8 File Offset: 0x00085DE8
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref Unity.Collections.NativeSlice<T> output, Texture src, int mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncGPUReadback.ValidateFormat(src, dstFormat);
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest result = AsyncGPUReadback.Request_Internal_Texture_2(src, mipIndex, dstFormat, &asyncRequestNativeArrayData);
			result.SetScriptingCallback(callback);
			return result;
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x00087C28 File Offset: 0x00085E28
		public static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref Unity.Collections.NativeSlice<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			return AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, mipIndex, x, width, y, height, z, depth, UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(dstFormat, QualitySettings.activeColorSpace == ColorSpace.Linear), callback);
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x00087C60 File Offset: 0x00085E60
		public unsafe static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref Unity.Collections.NativeSlice<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, [Optional] Action<AsyncGPUReadbackRequest> callback) where T : struct
		{
			AsyncGPUReadback.ValidateFormat(src, dstFormat);
			AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
			AsyncGPUReadbackRequest result = AsyncGPUReadback.Request_Internal_Texture_4(src, mipIndex, x, width, y, height, z, depth, dstFormat, &asyncRequestNativeArrayData);
			result.SetScriptingCallback(callback);
			return result;
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x00087CAC File Offset: 0x00085EAC
		public unsafe static AsyncGPUReadbackRequest Request_Internal_ComputeBuffer_2(ComputeBuffer src, int size, int offset, AsyncRequestNativeArrayData* data)
		{
			AsyncGPUReadbackRequest result;
			AsyncGPUReadback.Request_Internal_ComputeBuffer_2_Injected(src, size, offset, data, out result);
			return result;
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x00087CC8 File Offset: 0x00085EC8
		public unsafe static AsyncGPUReadbackRequest Request_Internal_GraphicsBuffer_2(GraphicsBuffer src, int size, int offset, AsyncRequestNativeArrayData* data)
		{
			AsyncGPUReadbackRequest result;
			AsyncGPUReadback.Request_Internal_GraphicsBuffer_2_Injected(src, size, offset, data, out result);
			return result;
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x00087CE4 File Offset: 0x00085EE4
		public unsafe static AsyncGPUReadbackRequest Request_Internal_Texture_1(Texture src, int mipIndex, AsyncRequestNativeArrayData* data)
		{
			AsyncGPUReadbackRequest result;
			AsyncGPUReadback.Request_Internal_Texture_1_Injected(src, mipIndex, data, out result);
			return result;
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x00087CFC File Offset: 0x00085EFC
		public unsafe static AsyncGPUReadbackRequest Request_Internal_Texture_3(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, AsyncRequestNativeArrayData* data)
		{
			AsyncGPUReadbackRequest result;
			AsyncGPUReadback.Request_Internal_Texture_3_Injected(src, mipIndex, x, width, y, height, z, depth, data, out result);
			return result;
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x00087D20 File Offset: 0x00085F20
		public unsafe static AsyncGPUReadbackRequest Request_Internal_Texture_4(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, AsyncRequestNativeArrayData* data)
		{
			AsyncGPUReadbackRequest result;
			AsyncGPUReadback.Request_Internal_Texture_4_Injected(src, mipIndex, x, width, y, height, z, depth, dstFormat, data, out result);
			return result;
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x0000F619 File Offset: 0x0000D819
		public unsafe static void Request_Internal_ComputeBuffer_2_Injected(ComputeBuffer src, int size, int offset, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
		{
			AsyncGPUReadback.Request_Internal_ComputeBuffer_2_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), size, offset, data, out ret);
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x0000F630 File Offset: 0x0000D830
		public unsafe static void Request_Internal_GraphicsBuffer_2_Injected(GraphicsBuffer src, int size, int offset, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
		{
			AsyncGPUReadback.Request_Internal_GraphicsBuffer_2_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), size, offset, data, out ret);
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x0000F647 File Offset: 0x0000D847
		public unsafe static void Request_Internal_Texture_1_Injected(Texture src, int mipIndex, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
		{
			AsyncGPUReadback.Request_Internal_Texture_1_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), mipIndex, data, out ret);
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x00087D48 File Offset: 0x00085F48
		public unsafe static void Request_Internal_Texture_3_Injected(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
		{
			AsyncGPUReadback.Request_Internal_Texture_3_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), mipIndex, x, width, y, height, z, depth, data, out ret);
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x00087D74 File Offset: 0x00085F74
		public unsafe static void Request_Internal_Texture_4_Injected(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
		{
			AsyncGPUReadback.Request_Internal_Texture_4_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), mipIndex, x, width, y, height, z, depth, dstFormat, data, out ret);
		}

		// Token: 0x04001ABC RID: 6844
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Static_Void_Texture_GraphicsFormat_0;

		// Token: 0x04001ABD RID: 6845
		private static readonly IntPtr NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_ComputeBuffer_Action_1_AsyncGPUReadbackRequest_0;

		// Token: 0x04001ABE RID: 6846
		private static readonly IntPtr NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_GraphicsBuffer_Action_1_AsyncGPUReadbackRequest_0;

		// Token: 0x04001ABF RID: 6847
		private static readonly IntPtr NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_Texture_Int32_TextureFormat_Action_1_AsyncGPUReadbackRequest_0;

		// Token: 0x04001AC0 RID: 6848
		private static readonly IntPtr NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_Texture_Int32_GraphicsFormat_Action_1_AsyncGPUReadbackRequest_0;

		// Token: 0x04001AC1 RID: 6849
		private static readonly IntPtr NativeMethodInfoPtr_Request_Internal_ComputeBuffer_1_Private_Static_AsyncGPUReadbackRequest_ComputeBuffer_ptr_AsyncRequestNativeArrayData_0;

		// Token: 0x04001AC2 RID: 6850
		private static readonly IntPtr NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Private_Static_AsyncGPUReadbackRequest_GraphicsBuffer_ptr_AsyncRequestNativeArrayData_0;

		// Token: 0x04001AC3 RID: 6851
		private static readonly IntPtr NativeMethodInfoPtr_Request_Internal_Texture_2_Private_Static_AsyncGPUReadbackRequest_Texture_Int32_GraphicsFormat_ptr_AsyncRequestNativeArrayData_0;

		// Token: 0x04001AC4 RID: 6852
		private static readonly IntPtr NativeMethodInfoPtr_Request_Internal_ComputeBuffer_1_Injected_Private_Static_Void_ComputeBuffer_ptr_AsyncRequestNativeArrayData_byref_AsyncGPUReadbackRequest_0;

		// Token: 0x04001AC5 RID: 6853
		private static readonly IntPtr NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Injected_Private_Static_Void_GraphicsBuffer_ptr_AsyncRequestNativeArrayData_byref_AsyncGPUReadbackRequest_0;

		// Token: 0x04001AC6 RID: 6854
		private static readonly IntPtr NativeMethodInfoPtr_Request_Internal_Texture_2_Injected_Private_Static_Void_Texture_Int32_GraphicsFormat_ptr_AsyncRequestNativeArrayData_byref_AsyncGPUReadbackRequest_0;

		// Token: 0x04001AC7 RID: 6855
		private static readonly AsyncGPUReadback.WaitAllRequestsDelegate WaitAllRequestsDelegateField;

		// Token: 0x04001AC8 RID: 6856
		private static readonly AsyncGPUReadback.Request_Internal_ComputeBuffer_2_InjectedDelegate Request_Internal_ComputeBuffer_2_InjectedDelegateField;

		// Token: 0x04001AC9 RID: 6857
		private static readonly AsyncGPUReadback.Request_Internal_GraphicsBuffer_2_InjectedDelegate Request_Internal_GraphicsBuffer_2_InjectedDelegateField;

		// Token: 0x04001ACA RID: 6858
		private static readonly AsyncGPUReadback.Request_Internal_Texture_1_InjectedDelegate Request_Internal_Texture_1_InjectedDelegateField;

		// Token: 0x04001ACB RID: 6859
		private static readonly AsyncGPUReadback.Request_Internal_Texture_3_InjectedDelegate Request_Internal_Texture_3_InjectedDelegateField;

		// Token: 0x04001ACC RID: 6860
		private static readonly AsyncGPUReadback.Request_Internal_Texture_4_InjectedDelegate Request_Internal_Texture_4_InjectedDelegateField;

		// Token: 0x02000ACC RID: 2764
		// (Invoke) Token: 0x06003E81 RID: 16001
		private delegate void WaitAllRequestsDelegate();

		// Token: 0x02000ACD RID: 2765
		// (Invoke) Token: 0x06003E83 RID: 16003
		private delegate void Request_Internal_ComputeBuffer_2_InjectedDelegate(IntPtr src, int size, int offset, IntPtr data, [Out] IntPtr ret);

		// Token: 0x02000ACE RID: 2766
		// (Invoke) Token: 0x06003E85 RID: 16005
		private delegate void Request_Internal_GraphicsBuffer_2_InjectedDelegate(IntPtr src, int size, int offset, IntPtr data, [Out] IntPtr ret);

		// Token: 0x02000ACF RID: 2767
		// (Invoke) Token: 0x06003E87 RID: 16007
		private delegate void Request_Internal_Texture_1_InjectedDelegate(IntPtr src, int mipIndex, IntPtr data, [Out] IntPtr ret);

		// Token: 0x02000AD0 RID: 2768
		// (Invoke) Token: 0x06003E89 RID: 16009
		private delegate void Request_Internal_Texture_3_InjectedDelegate(IntPtr src, int mipIndex, int x, int width, int y, int height, int z, int depth, IntPtr data, [Out] IntPtr ret);

		// Token: 0x02000AD1 RID: 2769
		// (Invoke) Token: 0x06003E8B RID: 16011
		private delegate void Request_Internal_Texture_4_InjectedDelegate(IntPtr src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, IntPtr data, [Out] IntPtr ret);
	}
}
