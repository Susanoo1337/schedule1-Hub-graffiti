using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Jobs
{
	// Token: 0x02000010 RID: 16
	[StructLayout(2)]
	public struct JobHandle
	{
		// Token: 0x0600003F RID: 63 RVA: 0x000193AC File Offset: 0x000175AC
		// Note: this type is marked as 'beforefieldinit'.
		static JobHandle()
		{
			Il2CppClassPointerStore<JobHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs", "JobHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobHandle>.NativeClassPtr);
			JobHandle.NativeFieldInfoPtr_jobGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, "jobGroup");
			JobHandle.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, "version");
			JobHandle.NativeMethodInfoPtr_Complete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663332);
			JobHandle.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663333);
			JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobs_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663334);
			JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobsAndComplete_Private_Static_Void_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663335);
			JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobsAndIsCompleted_Private_Static_Boolean_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663336);
			JobHandle.NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_JobHandle_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663337);
			JobHandle.NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeArray_1_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663338);
			JobHandle.NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeSlice_1_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663339);
			JobHandle.NativeMethodInfoPtr_CombineDependenciesInternal2_Private_Static_JobHandle_byref_JobHandle_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663340);
			JobHandle.NativeMethodInfoPtr_CombineDependenciesInternalPtr_Internal_Static_JobHandle_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663341);
			JobHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663342);
			JobHandle.NativeMethodInfoPtr_CombineDependenciesInternal2_Injected_Private_Static_Void_byref_JobHandle_byref_JobHandle_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663343);
			JobHandle.NativeMethodInfoPtr_CombineDependenciesInternalPtr_Injected_Private_Static_Void_ptr_Void_Int32_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663344);
			JobHandle.ScheduleBatchedJobsAndCompleteAllDelegateField = IL2CPP.ResolveICall<JobHandle.ScheduleBatchedJobsAndCompleteAllDelegate>("Unity.Jobs.JobHandle::ScheduleBatchedJobsAndCompleteAll");
			JobHandle.CombineDependenciesInternal3_InjectedDelegateField = IL2CPP.ResolveICall<JobHandle.CombineDependenciesInternal3_InjectedDelegate>("Unity.Jobs.JobHandle::CombineDependenciesInternal3_Injected");
			JobHandle.CheckFenceIsDependencyOrDidSyncFence_InjectedDelegateField = IL2CPP.ResolveICall<JobHandle.CheckFenceIsDependencyOrDidSyncFence_InjectedDelegate>("Unity.Jobs.JobHandle::CheckFenceIsDependencyOrDidSyncFence_Injected");
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00019538 File Offset: 0x00017738
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 1224994, RefRangeEnd = 1225026, XrefRangeStart = 1224992, XrefRangeEnd = 1224994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_Complete_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00019560 File Offset: 0x00017760
		public unsafe bool IsCompleted
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1225028, RefRangeEnd = 1225030, XrefRangeStart = 1225026, XrefRangeEnd = 1225028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00019590 File Offset: 0x00017790
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1225032, RefRangeEnd = 1225036, XrefRangeStart = 1225030, XrefRangeEnd = 1225032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScheduleBatchedJobs()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobs_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000195B8 File Offset: 0x000177B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225036, XrefRangeEnd = 1225038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScheduleBatchedJobsAndComplete(ref JobHandle job)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &job;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobsAndComplete_Private_Static_Void_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000195EC File Offset: 0x000177EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1225028, RefRangeEnd = 1225030, XrefRangeStart = 1225028, XrefRangeEnd = 1225030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ScheduleBatchedJobsAndIsCompleted(ref JobHandle job)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &job;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobsAndIsCompleted_Private_Static_Boolean_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0001962C File Offset: 0x0001782C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1225040, RefRangeEnd = 1225041, XrefRangeStart = 1225038, XrefRangeEnd = 1225040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle CombineDependencies(JobHandle job0, JobHandle job1)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref job0;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref job1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_JobHandle_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00019678 File Offset: 0x00017878
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1225046, RefRangeEnd = 1225051, XrefRangeStart = 1225041, XrefRangeEnd = 1225046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle CombineDependencies(Unity.Collections.NativeArray<JobHandle> jobs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(jobs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeArray_1_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000196C0 File Offset: 0x000178C0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1225059, RefRangeEnd = 1225065, XrefRangeStart = 1225051, XrefRangeEnd = 1225059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle CombineDependencies(Unity.Collections.NativeSlice<JobHandle> jobs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(jobs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeSlice_1_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00019708 File Offset: 0x00017908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225065, XrefRangeEnd = 1225067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle CombineDependenciesInternal2(ref JobHandle job0, ref JobHandle job1)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &job0;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &job1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_CombineDependenciesInternal2_Private_Static_JobHandle_byref_JobHandle_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00019754 File Offset: 0x00017954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225067, XrefRangeEnd = 1225069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle CombineDependenciesInternalPtr(void* jobs, int count)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = jobs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_CombineDependenciesInternalPtr_Internal_Static_JobHandle_ptr_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000197A0 File Offset: 0x000179A0
		[CallerCount(0)]
		public unsafe bool Equals(JobHandle other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_JobHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000197E0 File Offset: 0x000179E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225069, XrefRangeEnd = 1225071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CombineDependenciesInternal2_Injected(ref JobHandle job0, ref JobHandle job1, out JobHandle ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &job0;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &job1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_CombineDependenciesInternal2_Injected_Private_Static_Void_byref_JobHandle_byref_JobHandle_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00019830 File Offset: 0x00017A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225071, XrefRangeEnd = 1225073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CombineDependenciesInternalPtr_Injected(void* jobs, int count, out JobHandle ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = jobs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_CombineDependenciesInternalPtr_Injected_Private_Static_Void_ptr_Void_Int32_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000227F File Offset: 0x0000047F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00019880 File Offset: 0x00017A80
		public unsafe static void CompleteAll(ref JobHandle job0, ref JobHandle job1)
		{
			JobHandle* ptr = stackalloc JobHandle[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JobHandle))];
			*ptr = job0;
			ptr[1] = job1;
			JobHandle.ScheduleBatchedJobsAndCompleteAll((void*)ptr, 2);
			job0 = default(JobHandle);
			job1 = default(JobHandle);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000198D0 File Offset: 0x00017AD0
		public unsafe static void CompleteAll(ref JobHandle job0, ref JobHandle job1, ref JobHandle job2)
		{
			JobHandle* ptr = stackalloc JobHandle[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JobHandle))];
			*ptr = job0;
			ptr[1] = job1;
			ptr[2] = job2;
			JobHandle.ScheduleBatchedJobsAndCompleteAll((void*)ptr, 3);
			job0 = default(JobHandle);
			job1 = default(JobHandle);
			job2 = default(JobHandle);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002291 File Offset: 0x00000491
		public static void CompleteAll(Unity.Collections.NativeArray<JobHandle> jobs)
		{
			JobHandle.ScheduleBatchedJobsAndCompleteAll(jobs.GetUnsafeReadOnlyPtr<JobHandle>(), jobs.Length);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000022A7 File Offset: 0x000004A7
		public unsafe static void ScheduleBatchedJobsAndCompleteAll(void* jobs, int count)
		{
			JobHandle.ScheduleBatchedJobsAndCompleteAllDelegateField(jobs, count);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0001993C File Offset: 0x00017B3C
		public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1, JobHandle job2)
		{
			return JobHandle.CombineDependenciesInternal3(ref job0, ref job1, ref job2);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0001995C File Offset: 0x00017B5C
		public static JobHandle CombineDependenciesInternal3(ref JobHandle job0, ref JobHandle job1, ref JobHandle job2)
		{
			JobHandle result;
			JobHandle.CombineDependenciesInternal3_Injected(ref job0, ref job1, ref job2, out result);
			return result;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000022B5 File Offset: 0x000004B5
		public static bool CheckFenceIsDependencyOrDidSyncFence(JobHandle jobHandle, JobHandle dependsOn)
		{
			return JobHandle.CheckFenceIsDependencyOrDidSyncFence_Injected(ref jobHandle, ref dependsOn);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000022C0 File Offset: 0x000004C0
		public static void CombineDependenciesInternal3_Injected(ref JobHandle job0, ref JobHandle job1, ref JobHandle job2, out JobHandle ret)
		{
			JobHandle.CombineDependenciesInternal3_InjectedDelegateField(ref job0, ref job1, ref job2, out ret);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000022D0 File Offset: 0x000004D0
		public static bool CheckFenceIsDependencyOrDidSyncFence_Injected(ref JobHandle jobHandle, ref JobHandle dependsOn)
		{
			return JobHandle.CheckFenceIsDependencyOrDidSyncFence_InjectedDelegateField(ref jobHandle, ref dependsOn);
		}

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_jobGroup;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleBatchedJobs_Public_Static_Void_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleBatchedJobsAndComplete_Private_Static_Void_byref_JobHandle_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleBatchedJobsAndIsCompleted_Private_Static_Boolean_byref_JobHandle_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_JobHandle_JobHandle_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeArray_1_JobHandle_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeSlice_1_JobHandle_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_CombineDependenciesInternal2_Private_Static_JobHandle_byref_JobHandle_byref_JobHandle_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_CombineDependenciesInternalPtr_Internal_Static_JobHandle_ptr_Void_Int32_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_JobHandle_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_CombineDependenciesInternal2_Injected_Private_Static_Void_byref_JobHandle_byref_JobHandle_byref_JobHandle_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_CombineDependenciesInternalPtr_Injected_Private_Static_Void_ptr_Void_Int32_byref_JobHandle_0;

		// Token: 0x04000030 RID: 48
		[FieldOffset(0)]
		public ulong jobGroup;

		// Token: 0x04000031 RID: 49
		[FieldOffset(8)]
		public int version;

		// Token: 0x04000032 RID: 50
		private static readonly JobHandle.ScheduleBatchedJobsAndCompleteAllDelegate ScheduleBatchedJobsAndCompleteAllDelegateField;

		// Token: 0x04000033 RID: 51
		private static readonly JobHandle.CombineDependenciesInternal3_InjectedDelegate CombineDependenciesInternal3_InjectedDelegateField;

		// Token: 0x04000034 RID: 52
		private static readonly JobHandle.CheckFenceIsDependencyOrDidSyncFence_InjectedDelegate CheckFenceIsDependencyOrDidSyncFence_InjectedDelegateField;

		// Token: 0x0200037F RID: 895
		// (Invoke) Token: 0x06002F87 RID: 12167
		private delegate void ScheduleBatchedJobsAndCompleteAllDelegate(IntPtr jobs, int count);

		// Token: 0x02000380 RID: 896
		// (Invoke) Token: 0x06002F89 RID: 12169
		private delegate void CombineDependenciesInternal3_InjectedDelegate(IntPtr job0, IntPtr job1, IntPtr job2, [Out] IntPtr ret);

		// Token: 0x02000381 RID: 897
		// (Invoke) Token: 0x06002F8B RID: 12171
		private delegate bool CheckFenceIsDependencyOrDidSyncFence_InjectedDelegate(IntPtr jobHandle, IntPtr dependsOn);
	}
}
