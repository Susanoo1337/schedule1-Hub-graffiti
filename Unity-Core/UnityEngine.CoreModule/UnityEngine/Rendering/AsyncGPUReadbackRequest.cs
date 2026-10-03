using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	// Token: 0x020001D2 RID: 466
	[StructLayout(2)]
	public struct AsyncGPUReadbackRequest
	{
		// Token: 0x06002123 RID: 8483 RVA: 0x00086A94 File Offset: 0x00084C94
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncGPUReadbackRequest()
		{
			Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "AsyncGPUReadbackRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr);
			AsyncGPUReadbackRequest.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, "m_Ptr");
			AsyncGPUReadbackRequest.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, "m_Version");
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_WaitForCompletion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100666918);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetData_Public_NativeArray_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100666919);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_done_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100666920);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_hasError_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100666921);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_layerCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100666922);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_layerDataSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100666923);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_IsDone_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100666924);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_HasError_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100666925);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetLayerCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100666926);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetLayerDataSize_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100666927);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_SetScriptingCallback_Internal_Void_Action_1_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100666928);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetDataRaw_Private_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100666929);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_WaitForCompletion_Injected_Private_Static_Void_byref_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100666930);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_IsDone_Injected_Private_Static_Boolean_byref_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100666931);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_HasError_Injected_Private_Static_Boolean_byref_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100666932);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetLayerCount_Injected_Private_Static_Int32_byref_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100666933);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetLayerDataSize_Injected_Private_Static_Int32_byref_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100666934);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_SetScriptingCallback_Injected_Private_Static_Void_byref_AsyncGPUReadbackRequest_Action_1_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100666935);
			AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetDataRaw_Injected_Private_Static_IntPtr_byref_AsyncGPUReadbackRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100666936);
			AsyncGPUReadbackRequest.Update_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadbackRequest.Update_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::Update_Injected");
			AsyncGPUReadbackRequest.GetWidth_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadbackRequest.GetWidth_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::GetWidth_Injected");
			AsyncGPUReadbackRequest.GetHeight_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadbackRequest.GetHeight_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::GetHeight_Injected");
			AsyncGPUReadbackRequest.GetDepth_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadbackRequest.GetDepth_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::GetDepth_Injected");
			AsyncGPUReadbackRequest.GetForcePlayerLoopUpdate_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadbackRequest.GetForcePlayerLoopUpdate_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::GetForcePlayerLoopUpdate_Injected");
			AsyncGPUReadbackRequest.SetForcePlayerLoopUpdate_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadbackRequest.SetForcePlayerLoopUpdate_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::SetForcePlayerLoopUpdate_Injected");
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x00086CC4 File Offset: 0x00084EC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1287181, RefRangeEnd = 1287182, XrefRangeStart = 1287179, XrefRangeEnd = 1287181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WaitForCompletion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_WaitForCompletion_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x00086CEC File Offset: 0x00084EEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1287190, RefRangeEnd = 1287191, XrefRangeStart = 1287182, XrefRangeEnd = 1287190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Unity.Collections.NativeArray<T> GetData<T>(int layer = 0) where T : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref layer;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.MethodInfoStoreGeneric_GetData_Public_NativeArray_1_T_Int32_0<T>.Pointer, ref this, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Unity.Collections.NativeArray<T>(pointer);
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06002126 RID: 8486 RVA: 0x00086D24 File Offset: 0x00084F24
		public unsafe bool done
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1287193, RefRangeEnd = 1287196, XrefRangeStart = 1287191, XrefRangeEnd = 1287193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_done_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06002127 RID: 8487 RVA: 0x00086D54 File Offset: 0x00084F54
		public unsafe bool hasError
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1287198, RefRangeEnd = 1287202, XrefRangeStart = 1287196, XrefRangeEnd = 1287198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_hasError_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06002128 RID: 8488 RVA: 0x00086D84 File Offset: 0x00084F84
		public unsafe int layerCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1287204, RefRangeEnd = 1287205, XrefRangeStart = 1287202, XrefRangeEnd = 1287204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_layerCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06002129 RID: 8489 RVA: 0x00086DB4 File Offset: 0x00084FB4
		public unsafe int layerDataSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1287207, RefRangeEnd = 1287208, XrefRangeStart = 1287205, XrefRangeEnd = 1287207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_layerDataSize_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x00086DE4 File Offset: 0x00084FE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1287193, RefRangeEnd = 1287196, XrefRangeStart = 1287193, XrefRangeEnd = 1287196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDone()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_IsDone_Private_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x00086E14 File Offset: 0x00085014
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1287198, RefRangeEnd = 1287202, XrefRangeStart = 1287198, XrefRangeEnd = 1287202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasError()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_HasError_Private_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x00086E44 File Offset: 0x00085044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1287204, RefRangeEnd = 1287205, XrefRangeStart = 1287204, XrefRangeEnd = 1287205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLayerCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetLayerCount_Private_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x00086E74 File Offset: 0x00085074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1287207, RefRangeEnd = 1287208, XrefRangeStart = 1287207, XrefRangeEnd = 1287208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLayerDataSize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetLayerDataSize_Private_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x00086EA4 File Offset: 0x000850A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287208, XrefRangeEnd = 1287210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScriptingCallback(Action<AsyncGPUReadbackRequest> callback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_SetScriptingCallback_Internal_Void_Action_1_AsyncGPUReadbackRequest_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x00086EDC File Offset: 0x000850DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1287212, RefRangeEnd = 1287213, XrefRangeStart = 1287210, XrefRangeEnd = 1287212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetDataRaw(int layer)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref layer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetDataRaw_Private_IntPtr_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x00086F1C File Offset: 0x0008511C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1287181, RefRangeEnd = 1287182, XrefRangeStart = 1287181, XrefRangeEnd = 1287182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WaitForCompletion_Injected(ref AsyncGPUReadbackRequest _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_WaitForCompletion_Injected_Private_Static_Void_byref_AsyncGPUReadbackRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x00086F50 File Offset: 0x00085150
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1287193, RefRangeEnd = 1287196, XrefRangeStart = 1287193, XrefRangeEnd = 1287196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDone_Injected(ref AsyncGPUReadbackRequest _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_IsDone_Injected_Private_Static_Boolean_byref_AsyncGPUReadbackRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x00086F90 File Offset: 0x00085190
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1287198, RefRangeEnd = 1287202, XrefRangeStart = 1287198, XrefRangeEnd = 1287202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasError_Injected(ref AsyncGPUReadbackRequest _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_HasError_Injected_Private_Static_Boolean_byref_AsyncGPUReadbackRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x00086FD0 File Offset: 0x000851D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1287204, RefRangeEnd = 1287205, XrefRangeStart = 1287204, XrefRangeEnd = 1287205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLayerCount_Injected(ref AsyncGPUReadbackRequest _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetLayerCount_Injected_Private_Static_Int32_byref_AsyncGPUReadbackRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x00087010 File Offset: 0x00085210
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1287207, RefRangeEnd = 1287208, XrefRangeStart = 1287207, XrefRangeEnd = 1287208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLayerDataSize_Injected(ref AsyncGPUReadbackRequest _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetLayerDataSize_Injected_Private_Static_Int32_byref_AsyncGPUReadbackRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x00087050 File Offset: 0x00085250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetScriptingCallback_Injected(ref AsyncGPUReadbackRequest _unity_self, Action<AsyncGPUReadbackRequest> callback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_SetScriptingCallback_Injected_Private_Static_Void_byref_AsyncGPUReadbackRequest_Action_1_AsyncGPUReadbackRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x00087094 File Offset: 0x00085294
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1287212, RefRangeEnd = 1287213, XrefRangeStart = 1287212, XrefRangeEnd = 1287213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetDataRaw_Injected(ref AsyncGPUReadbackRequest _unity_self, int layer)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetDataRaw_Injected_Private_Static_IntPtr_byref_AsyncGPUReadbackRequest_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x0000F555 File Offset: 0x0000D755
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, ref this));
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x0000F567 File Offset: 0x0000D767
		public void Update()
		{
			AsyncGPUReadbackRequest.Update_Injected(ref this);
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06002139 RID: 8505 RVA: 0x000870E0 File Offset: 0x000852E0
		public int width
		{
			get
			{
				return this.GetWidth();
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x0600213A RID: 8506 RVA: 0x000870F8 File Offset: 0x000852F8
		public int height
		{
			get
			{
				return this.GetHeight();
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x00087110 File Offset: 0x00085310
		public int depth
		{
			get
			{
				return this.GetDepth();
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x0600213C RID: 8508 RVA: 0x00087128 File Offset: 0x00085328
		// (set) Token: 0x0600213D RID: 8509 RVA: 0x0000F56F File Offset: 0x0000D76F
		public bool forcePlayerLoopUpdate
		{
			get
			{
				return this.GetForcePlayerLoopUpdate();
			}
			set
			{
				this.SetForcePlayerLoopUpdate(value);
			}
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x0000F57A File Offset: 0x0000D77A
		public int GetWidth()
		{
			return AsyncGPUReadbackRequest.GetWidth_Injected(ref this);
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x0000F582 File Offset: 0x0000D782
		public int GetHeight()
		{
			return AsyncGPUReadbackRequest.GetHeight_Injected(ref this);
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x0000F58A File Offset: 0x0000D78A
		public int GetDepth()
		{
			return AsyncGPUReadbackRequest.GetDepth_Injected(ref this);
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x0000F592 File Offset: 0x0000D792
		public bool GetForcePlayerLoopUpdate()
		{
			return AsyncGPUReadbackRequest.GetForcePlayerLoopUpdate_Injected(ref this);
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x0000F59A File Offset: 0x0000D79A
		public void SetForcePlayerLoopUpdate(bool b)
		{
			AsyncGPUReadbackRequest.SetForcePlayerLoopUpdate_Injected(ref this, b);
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x0000F5A3 File Offset: 0x0000D7A3
		public static void Update_Injected(ref AsyncGPUReadbackRequest _unity_self)
		{
			AsyncGPUReadbackRequest.Update_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x0000F5B0 File Offset: 0x0000D7B0
		public static int GetWidth_Injected(ref AsyncGPUReadbackRequest _unity_self)
		{
			return AsyncGPUReadbackRequest.GetWidth_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x0000F5BD File Offset: 0x0000D7BD
		public static int GetHeight_Injected(ref AsyncGPUReadbackRequest _unity_self)
		{
			return AsyncGPUReadbackRequest.GetHeight_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x0000F5CA File Offset: 0x0000D7CA
		public static int GetDepth_Injected(ref AsyncGPUReadbackRequest _unity_self)
		{
			return AsyncGPUReadbackRequest.GetDepth_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x0000F5D7 File Offset: 0x0000D7D7
		public static bool GetForcePlayerLoopUpdate_Injected(ref AsyncGPUReadbackRequest _unity_self)
		{
			return AsyncGPUReadbackRequest.GetForcePlayerLoopUpdate_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x0000F5E4 File Offset: 0x0000D7E4
		public static void SetForcePlayerLoopUpdate_Injected(ref AsyncGPUReadbackRequest _unity_self, bool b)
		{
			AsyncGPUReadbackRequest.SetForcePlayerLoopUpdate_InjectedDelegateField(ref _unity_self, b);
		}

		// Token: 0x04001A9B RID: 6811
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04001A9C RID: 6812
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04001A9D RID: 6813
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Public_Void_0;

		// Token: 0x04001A9E RID: 6814
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_NativeArray_1_T_Int32_0;

		// Token: 0x04001A9F RID: 6815
		private static readonly IntPtr NativeMethodInfoPtr_get_done_Public_get_Boolean_0;

		// Token: 0x04001AA0 RID: 6816
		private static readonly IntPtr NativeMethodInfoPtr_get_hasError_Public_get_Boolean_0;

		// Token: 0x04001AA1 RID: 6817
		private static readonly IntPtr NativeMethodInfoPtr_get_layerCount_Public_get_Int32_0;

		// Token: 0x04001AA2 RID: 6818
		private static readonly IntPtr NativeMethodInfoPtr_get_layerDataSize_Public_get_Int32_0;

		// Token: 0x04001AA3 RID: 6819
		private static readonly IntPtr NativeMethodInfoPtr_IsDone_Private_Boolean_0;

		// Token: 0x04001AA4 RID: 6820
		private static readonly IntPtr NativeMethodInfoPtr_HasError_Private_Boolean_0;

		// Token: 0x04001AA5 RID: 6821
		private static readonly IntPtr NativeMethodInfoPtr_GetLayerCount_Private_Int32_0;

		// Token: 0x04001AA6 RID: 6822
		private static readonly IntPtr NativeMethodInfoPtr_GetLayerDataSize_Private_Int32_0;

		// Token: 0x04001AA7 RID: 6823
		private static readonly IntPtr NativeMethodInfoPtr_SetScriptingCallback_Internal_Void_Action_1_AsyncGPUReadbackRequest_0;

		// Token: 0x04001AA8 RID: 6824
		private static readonly IntPtr NativeMethodInfoPtr_GetDataRaw_Private_IntPtr_Int32_0;

		// Token: 0x04001AA9 RID: 6825
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Injected_Private_Static_Void_byref_AsyncGPUReadbackRequest_0;

		// Token: 0x04001AAA RID: 6826
		private static readonly IntPtr NativeMethodInfoPtr_IsDone_Injected_Private_Static_Boolean_byref_AsyncGPUReadbackRequest_0;

		// Token: 0x04001AAB RID: 6827
		private static readonly IntPtr NativeMethodInfoPtr_HasError_Injected_Private_Static_Boolean_byref_AsyncGPUReadbackRequest_0;

		// Token: 0x04001AAC RID: 6828
		private static readonly IntPtr NativeMethodInfoPtr_GetLayerCount_Injected_Private_Static_Int32_byref_AsyncGPUReadbackRequest_0;

		// Token: 0x04001AAD RID: 6829
		private static readonly IntPtr NativeMethodInfoPtr_GetLayerDataSize_Injected_Private_Static_Int32_byref_AsyncGPUReadbackRequest_0;

		// Token: 0x04001AAE RID: 6830
		private static readonly IntPtr NativeMethodInfoPtr_SetScriptingCallback_Injected_Private_Static_Void_byref_AsyncGPUReadbackRequest_Action_1_AsyncGPUReadbackRequest_0;

		// Token: 0x04001AAF RID: 6831
		private static readonly IntPtr NativeMethodInfoPtr_GetDataRaw_Injected_Private_Static_IntPtr_byref_AsyncGPUReadbackRequest_Int32_0;

		// Token: 0x04001AB0 RID: 6832
		[FieldOffset(0)]
		public IntPtr m_Ptr;

		// Token: 0x04001AB1 RID: 6833
		[FieldOffset(8)]
		public int m_Version;

		// Token: 0x04001AB2 RID: 6834
		private static readonly AsyncGPUReadbackRequest.Update_InjectedDelegate Update_InjectedDelegateField;

		// Token: 0x04001AB3 RID: 6835
		private static readonly AsyncGPUReadbackRequest.GetWidth_InjectedDelegate GetWidth_InjectedDelegateField;

		// Token: 0x04001AB4 RID: 6836
		private static readonly AsyncGPUReadbackRequest.GetHeight_InjectedDelegate GetHeight_InjectedDelegateField;

		// Token: 0x04001AB5 RID: 6837
		private static readonly AsyncGPUReadbackRequest.GetDepth_InjectedDelegate GetDepth_InjectedDelegateField;

		// Token: 0x04001AB6 RID: 6838
		private static readonly AsyncGPUReadbackRequest.GetForcePlayerLoopUpdate_InjectedDelegate GetForcePlayerLoopUpdate_InjectedDelegateField;

		// Token: 0x04001AB7 RID: 6839
		private static readonly AsyncGPUReadbackRequest.SetForcePlayerLoopUpdate_InjectedDelegate SetForcePlayerLoopUpdate_InjectedDelegateField;

		// Token: 0x02000AC5 RID: 2757
		private sealed class MethodInfoStoreGeneric_GetData_Public_NativeArray_1_T_Int32_0<T>
		{
			// Token: 0x04002BC7 RID: 11207
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetData_Public_NativeArray_1_T_Int32_0, Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000AC6 RID: 2758
		// (Invoke) Token: 0x06003E75 RID: 15989
		private delegate void Update_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000AC7 RID: 2759
		// (Invoke) Token: 0x06003E77 RID: 15991
		private delegate int GetWidth_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000AC8 RID: 2760
		// (Invoke) Token: 0x06003E79 RID: 15993
		private delegate int GetHeight_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000AC9 RID: 2761
		// (Invoke) Token: 0x06003E7B RID: 15995
		private delegate int GetDepth_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000ACA RID: 2762
		// (Invoke) Token: 0x06003E7D RID: 15997
		private delegate bool GetForcePlayerLoopUpdate_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000ACB RID: 2763
		// (Invoke) Token: 0x06003E7F RID: 15999
		private delegate void SetForcePlayerLoopUpdate_InjectedDelegate(IntPtr _unity_self, bool b);
	}
}
