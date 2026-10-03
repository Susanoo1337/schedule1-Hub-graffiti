using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200011D RID: 285
	public class AsyncInstantiateOperationHelper : Object
	{
		// Token: 0x06001736 RID: 5942 RVA: 0x0000B8B3 File Offset: 0x00009AB3
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncInstantiateOperationHelper()
		{
			Il2CppClassPointerStore<AsyncInstantiateOperationHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AsyncInstantiateOperationHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncInstantiateOperationHelper>.NativeClassPtr);
			AsyncInstantiateOperationHelper.NativeMethodInfoPtr_SetAsyncInstantiateOperationResult_Public_Static_Void_AsyncInstantiateOperation_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncInstantiateOperationHelper>.NativeClassPtr, 100665733);
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x00064B58 File Offset: 0x00062D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246918, XrefRangeEnd = 1246920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetAsyncInstantiateOperationResult(AsyncInstantiateOperation op, Il2CppReferenceArray<Object> result)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncInstantiateOperationHelper.NativeMethodInfoPtr_SetAsyncInstantiateOperationResult_Public_Static_Void_AsyncInstantiateOperation_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x0000B8EC File Offset: 0x00009AEC
		public AsyncInstantiateOperationHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040013BC RID: 5052
		private static readonly IntPtr NativeMethodInfoPtr_SetAsyncInstantiateOperationResult_Public_Static_Void_AsyncInstantiateOperation_Il2CppReferenceArray_1_Object_0;
	}
}
