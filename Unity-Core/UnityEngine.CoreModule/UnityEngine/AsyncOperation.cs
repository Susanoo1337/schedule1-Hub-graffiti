using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200011E RID: 286
	public class AsyncOperation : YieldInstruction
	{
		// Token: 0x06001739 RID: 5945 RVA: 0x00064BA0 File Offset: 0x00062DA0
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncOperation()
		{
			Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AsyncOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr);
			AsyncOperation.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, "m_Ptr");
			AsyncOperation.NativeFieldInfoPtr_m_completeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, "m_completeCallback");
			AsyncOperation.NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100665734);
			AsyncOperation.NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100665735);
			AsyncOperation.NativeMethodInfoPtr_get_progress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100665736);
			AsyncOperation.NativeMethodInfoPtr_set_allowSceneActivation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100665737);
			AsyncOperation.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100665738);
			AsyncOperation.NativeMethodInfoPtr_InvokeCompletionEvent_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100665739);
			AsyncOperation.NativeMethodInfoPtr_add_completed_Public_add_Void_Action_1_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100665740);
			AsyncOperation.NativeMethodInfoPtr_remove_completed_Public_rem_Void_Action_1_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100665741);
			AsyncOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100665742);
			AsyncOperation.get_priorityDelegateField = IL2CPP.ResolveICall<AsyncOperation.get_priorityDelegate>("UnityEngine.AsyncOperation::get_priority");
			AsyncOperation.set_priorityDelegateField = IL2CPP.ResolveICall<AsyncOperation.set_priorityDelegate>("UnityEngine.AsyncOperation::set_priority");
			AsyncOperation.get_allowSceneActivationDelegateField = IL2CPP.ResolveICall<AsyncOperation.get_allowSceneActivationDelegate>("UnityEngine.AsyncOperation::get_allowSceneActivation");
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x00064CDC File Offset: 0x00062EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246920, XrefRangeEnd = 1246922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalDestroy(IntPtr ptr)
		{
			IntPtr* ptr2 = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr2 = ref ptr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x00064D10 File Offset: 0x00062F10
		public unsafe bool isDone
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1246924, RefRangeEnd = 1246927, XrefRangeStart = 1246922, XrefRangeEnd = 1246924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x00064D4C File Offset: 0x00062F4C
		public unsafe float progress
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246927, XrefRangeEnd = 1246929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_get_progress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x0000B95D File Offset: 0x00009B5D
		// (set) Token: 0x0600173D RID: 5949 RVA: 0x00064D88 File Offset: 0x00062F88
		public unsafe bool allowSceneActivation
		{
			get
			{
				return AsyncOperation.get_allowSceneActivationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1246931, RefRangeEnd = 1246933, XrefRangeStart = 1246929, XrefRangeEnd = 1246931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_set_allowSceneActivation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x00064DC8 File Offset: 0x00062FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246933, XrefRangeEnd = 1246938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncOperation.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x00064E04 File Offset: 0x00063004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246938, XrefRangeEnd = 1246939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeCompletionEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_InvokeCompletionEvent_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x00064E38 File Offset: 0x00063038
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1246949, RefRangeEnd = 1246951, XrefRangeStart = 1246939, XrefRangeEnd = 1246949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_completed(Action<AsyncOperation> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_add_completed_Public_add_Void_Action_1_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x00064E7C File Offset: 0x0006307C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246951, XrefRangeEnd = 1246961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_completed(Action<AsyncOperation> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_remove_completed_Public_rem_Void_Action_1_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x00064EC0 File Offset: 0x000630C0
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x0000B8F5 File Offset: 0x00009AF5
		public AsyncOperation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x00064EFC File Offset: 0x000630FC
		// (set) Token: 0x06001745 RID: 5957 RVA: 0x0000B8FE File Offset: 0x00009AFE
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x00064F24 File Offset: 0x00063124
		// (set) Token: 0x06001747 RID: 5959 RVA: 0x0000B919 File Offset: 0x00009B19
		public unsafe Action<AsyncOperation> m_completeCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_m_completeCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_m_completeCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001748 RID: 5960 RVA: 0x0000B938 File Offset: 0x00009B38
		// (set) Token: 0x06001749 RID: 5961 RVA: 0x0000B94A File Offset: 0x00009B4A
		public int priority
		{
			get
			{
				return AsyncOperation.get_priorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AsyncOperation.set_priorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x040013BD RID: 5053
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x040013BE RID: 5054
		private static readonly IntPtr NativeFieldInfoPtr_m_completeCallback;

		// Token: 0x040013BF RID: 5055
		private static readonly IntPtr NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0;

		// Token: 0x040013C0 RID: 5056
		private static readonly IntPtr NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0;

		// Token: 0x040013C1 RID: 5057
		private static readonly IntPtr NativeMethodInfoPtr_get_progress_Public_get_Single_0;

		// Token: 0x040013C2 RID: 5058
		private static readonly IntPtr NativeMethodInfoPtr_set_allowSceneActivation_Public_set_Void_Boolean_0;

		// Token: 0x040013C3 RID: 5059
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040013C4 RID: 5060
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCompletionEvent_Internal_Void_0;

		// Token: 0x040013C5 RID: 5061
		private static readonly IntPtr NativeMethodInfoPtr_add_completed_Public_add_Void_Action_1_AsyncOperation_0;

		// Token: 0x040013C6 RID: 5062
		private static readonly IntPtr NativeMethodInfoPtr_remove_completed_Public_rem_Void_Action_1_AsyncOperation_0;

		// Token: 0x040013C7 RID: 5063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040013C8 RID: 5064
		private static readonly AsyncOperation.get_priorityDelegate get_priorityDelegateField;

		// Token: 0x040013C9 RID: 5065
		private static readonly AsyncOperation.set_priorityDelegate set_priorityDelegateField;

		// Token: 0x040013CA RID: 5066
		private static readonly AsyncOperation.get_allowSceneActivationDelegate get_allowSceneActivationDelegateField;

		// Token: 0x020008AA RID: 2218
		// (Invoke) Token: 0x060039D5 RID: 14805
		private delegate int get_priorityDelegate(IntPtr @this);

		// Token: 0x020008AB RID: 2219
		// (Invoke) Token: 0x060039D7 RID: 14807
		private delegate void set_priorityDelegate(IntPtr @this, int value);

		// Token: 0x020008AC RID: 2220
		// (Invoke) Token: 0x060039D9 RID: 14809
		private delegate bool get_allowSceneActivationDelegate(IntPtr @this);
	}
}
