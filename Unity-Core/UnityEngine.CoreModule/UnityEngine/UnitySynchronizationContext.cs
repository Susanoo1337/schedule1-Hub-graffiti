using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;

namespace UnityEngine
{
	// Token: 0x02000153 RID: 339
	public sealed class UnitySynchronizationContext : SynchronizationContext
	{
		// Token: 0x0600199B RID: 6555 RVA: 0x0006D4F0 File Offset: 0x0006B6F0
		// Note: this type is marked as 'beforefieldinit'.
		static UnitySynchronizationContext()
		{
			Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "UnitySynchronizationContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr);
			UnitySynchronizationContext.NativeFieldInfoPtr_m_AsyncWorkQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, "m_AsyncWorkQueue");
			UnitySynchronizationContext.NativeFieldInfoPtr_m_CurrentFrameWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, "m_CurrentFrameWork");
			UnitySynchronizationContext.NativeFieldInfoPtr_m_MainThreadID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, "m_MainThreadID");
			UnitySynchronizationContext.NativeFieldInfoPtr_m_TrackedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, "m_TrackedCount");
			UnitySynchronizationContext.NativeMethodInfoPtr__ctor_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666043);
			UnitySynchronizationContext.NativeMethodInfoPtr__ctor_Private_Void_List_1_WorkRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666044);
			UnitySynchronizationContext.NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666045);
			UnitySynchronizationContext.NativeMethodInfoPtr_OperationStarted_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666046);
			UnitySynchronizationContext.NativeMethodInfoPtr_OperationCompleted_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666047);
			UnitySynchronizationContext.NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666048);
			UnitySynchronizationContext.NativeMethodInfoPtr_CreateCopy_Public_Virtual_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666049);
			UnitySynchronizationContext.NativeMethodInfoPtr_Exec_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666050);
			UnitySynchronizationContext.NativeMethodInfoPtr_HasPendingTasks_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666051);
			UnitySynchronizationContext.NativeMethodInfoPtr_InitializeSynchronizationContext_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666052);
			UnitySynchronizationContext.NativeMethodInfoPtr_ExecuteTasks_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666053);
			UnitySynchronizationContext.NativeMethodInfoPtr_ExecutePendingTasks_Private_Static_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100666054);
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x0006D660 File Offset: 0x0006B860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271291, XrefRangeEnd = 1271304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitySynchronizationContext(int mainThreadID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mainThreadID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr__ctor_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x0006D6A8 File Offset: 0x0006B8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271304, XrefRangeEnd = 1271313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitySynchronizationContext(List<UnitySynchronizationContext.WorkRequest> queue, int mainThreadID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(queue);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mainThreadID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr__ctor_Private_Void_List_1_WorkRequest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x0006D704 File Offset: 0x0006B904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271313, XrefRangeEnd = 1271338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Send(SendOrPostCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x0006D758 File Offset: 0x0006B958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271338, XrefRangeEnd = 1271339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OperationStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_OperationStarted_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x0006D78C File Offset: 0x0006B98C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271339, XrefRangeEnd = 1271340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OperationCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_OperationCompleted_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x0006D7C0 File Offset: 0x0006B9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271340, XrefRangeEnd = 1271352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Post(SendOrPostCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x0006D814 File Offset: 0x0006BA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271352, XrefRangeEnd = 1271364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SynchronizationContext CreateCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_CreateCopy_Public_Virtual_SynchronizationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x0006D854 File Offset: 0x0006BA54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1271382, RefRangeEnd = 1271384, XrefRangeStart = 1271364, XrefRangeEnd = 1271382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exec()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_Exec_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x0006D888 File Offset: 0x0006BA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271384, XrefRangeEnd = 1271385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasPendingTasks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_HasPendingTasks_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x0006D8C4 File Offset: 0x0006BAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271385, XrefRangeEnd = 1271405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeSynchronizationContext()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_InitializeSynchronizationContext_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x0006D8EC File Offset: 0x0006BAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271405, XrefRangeEnd = 1271409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecuteTasks()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_ExecuteTasks_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x0006D914 File Offset: 0x0006BB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271409, XrefRangeEnd = 1271423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ExecutePendingTasks(long millisecondsTimeout)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref millisecondsTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_ExecutePendingTasks_Private_Static_Boolean_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x0000C659 File Offset: 0x0000A859
		public UnitySynchronizationContext(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060019A9 RID: 6569 RVA: 0x0006D954 File Offset: 0x0006BB54
		// (set) Token: 0x060019AA RID: 6570 RVA: 0x0000C662 File Offset: 0x0000A862
		public unsafe List<UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_AsyncWorkQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnitySynchronizationContext.WorkRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_AsyncWorkQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060019AB RID: 6571 RVA: 0x0006D984 File Offset: 0x0006BB84
		// (set) Token: 0x060019AC RID: 6572 RVA: 0x0000C681 File Offset: 0x0000A881
		public unsafe List<UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_CurrentFrameWork);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnitySynchronizationContext.WorkRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_CurrentFrameWork), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060019AD RID: 6573 RVA: 0x0006D9B4 File Offset: 0x0006BBB4
		// (set) Token: 0x060019AE RID: 6574 RVA: 0x0000C6A0 File Offset: 0x0000A8A0
		public unsafe int m_MainThreadID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_MainThreadID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_MainThreadID)) = value;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060019AF RID: 6575 RVA: 0x0006D9DC File Offset: 0x0006BBDC
		// (set) Token: 0x060019B0 RID: 6576 RVA: 0x0000C6BB File Offset: 0x0000A8BB
		public unsafe int m_TrackedCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_TrackedCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_TrackedCount)) = value;
			}
		}

		// Token: 0x04001554 RID: 5460
		private static readonly IntPtr NativeFieldInfoPtr_m_AsyncWorkQueue;

		// Token: 0x04001555 RID: 5461
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentFrameWork;

		// Token: 0x04001556 RID: 5462
		private static readonly IntPtr NativeFieldInfoPtr_m_MainThreadID;

		// Token: 0x04001557 RID: 5463
		private static readonly IntPtr NativeFieldInfoPtr_m_TrackedCount;

		// Token: 0x04001558 RID: 5464
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_0;

		// Token: 0x04001559 RID: 5465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_List_1_WorkRequest_Int32_0;

		// Token: 0x0400155A RID: 5466
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0;

		// Token: 0x0400155B RID: 5467
		private static readonly IntPtr NativeMethodInfoPtr_OperationStarted_Public_Virtual_Void_0;

		// Token: 0x0400155C RID: 5468
		private static readonly IntPtr NativeMethodInfoPtr_OperationCompleted_Public_Virtual_Void_0;

		// Token: 0x0400155D RID: 5469
		private static readonly IntPtr NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0;

		// Token: 0x0400155E RID: 5470
		private static readonly IntPtr NativeMethodInfoPtr_CreateCopy_Public_Virtual_SynchronizationContext_0;

		// Token: 0x0400155F RID: 5471
		private static readonly IntPtr NativeMethodInfoPtr_Exec_Public_Void_0;

		// Token: 0x04001560 RID: 5472
		private static readonly IntPtr NativeMethodInfoPtr_HasPendingTasks_Private_Boolean_0;

		// Token: 0x04001561 RID: 5473
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSynchronizationContext_Private_Static_Void_0;

		// Token: 0x04001562 RID: 5474
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteTasks_Private_Static_Void_0;

		// Token: 0x04001563 RID: 5475
		private static readonly IntPtr NativeMethodInfoPtr_ExecutePendingTasks_Private_Static_Boolean_Int64_0;

		// Token: 0x04001564 RID: 5476
		public const int kAwqInitialCapacity = 20;

		// Token: 0x02000902 RID: 2306
		public sealed class WorkRequest : ValueType
		{
			// Token: 0x06003A77 RID: 14967 RVA: 0x000B2E58 File Offset: 0x000B1058
			// Note: this type is marked as 'beforefieldinit'.
			static WorkRequest()
			{
				Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, "WorkRequest");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr);
				UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr, "m_DelagateCallback");
				UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr, "m_DelagateState");
				UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_WaitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr, "m_WaitHandle");
				UnitySynchronizationContext.WorkRequest.NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Object_ManualResetEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr, 100666055);
				UnitySynchronizationContext.WorkRequest.NativeMethodInfoPtr_Invoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr, 100666056);
			}

			// Token: 0x06003A78 RID: 14968 RVA: 0x000B2EE8 File Offset: 0x000B10E8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 347449, RefRangeEnd = 347452, XrefRangeStart = 347449, XrefRangeEnd = 347452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WorkRequest(SendOrPostCallback callback, Object state, ManualResetEvent waitHandle = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(waitHandle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.WorkRequest.NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Object_ManualResetEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A79 RID: 14969 RVA: 0x000B2F5C File Offset: 0x000B115C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1271290, RefRangeEnd = 1271291, XrefRangeStart = 1271286, XrefRangeEnd = 1271290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.WorkRequest.NativeMethodInfoPtr_Invoke_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A7A RID: 14970 RVA: 0x00015F7F File Offset: 0x0001417F
			public WorkRequest(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003A7B RID: 14971 RVA: 0x00015F88 File Offset: 0x00014188
			public WorkRequest() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr))
			{
			}

			// Token: 0x17000A21 RID: 2593
			// (get) Token: 0x06003A7C RID: 14972 RVA: 0x000B2F94 File Offset: 0x000B1194
			// (set) Token: 0x06003A7D RID: 14973 RVA: 0x00015F9A File Offset: 0x0001419A
			public unsafe SendOrPostCallback m_DelagateCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendOrPostCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A22 RID: 2594
			// (get) Token: 0x06003A7E RID: 14974 RVA: 0x000B2FC4 File Offset: 0x000B11C4
			// (set) Token: 0x06003A7F RID: 14975 RVA: 0x00015FB9 File Offset: 0x000141B9
			public unsafe Object m_DelagateState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateState);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateState), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A23 RID: 2595
			// (get) Token: 0x06003A80 RID: 14976 RVA: 0x000B2FF4 File Offset: 0x000B11F4
			// (set) Token: 0x06003A81 RID: 14977 RVA: 0x00015FD8 File Offset: 0x000141D8
			public unsafe ManualResetEvent m_WaitHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_WaitHandle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_WaitHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002B4E RID: 11086
			private static readonly IntPtr NativeFieldInfoPtr_m_DelagateCallback;

			// Token: 0x04002B4F RID: 11087
			private static readonly IntPtr NativeFieldInfoPtr_m_DelagateState;

			// Token: 0x04002B50 RID: 11088
			private static readonly IntPtr NativeFieldInfoPtr_m_WaitHandle;

			// Token: 0x04002B51 RID: 11089
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Object_ManualResetEvent_0;

			// Token: 0x04002B52 RID: 11090
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_0;
		}
	}
}
