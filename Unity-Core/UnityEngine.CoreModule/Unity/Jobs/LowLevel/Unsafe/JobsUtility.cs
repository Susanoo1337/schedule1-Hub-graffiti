using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Jobs.LowLevel.Unsafe
{
	// Token: 0x02000016 RID: 22
	public static class JobsUtility : Object
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00019D30 File Offset: 0x00017F30
		// Note: this type is marked as 'beforefieldinit'.
		static JobsUtility()
		{
			Il2CppClassPointerStore<JobsUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs.LowLevel.Unsafe", "JobsUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr);
			JobsUtility.NativeFieldInfoPtr_PanicFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, "PanicFunction");
			JobsUtility.NativeMethodInfoPtr_GetJobRange_Public_Static_Void_byref_JobRanges_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663348);
			JobsUtility.NativeMethodInfoPtr_GetWorkStealingRange_Public_Static_Boolean_byref_JobRanges_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663349);
			JobsUtility.NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_byref_JobScheduleParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663350);
			JobsUtility.NativeMethodInfoPtr_ScheduleParallelFor_Public_Static_JobHandle_byref_JobScheduleParameters_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663351);
			JobsUtility.NativeMethodInfoPtr_ScheduleParallelForDeferArraySize_Public_Static_JobHandle_byref_JobScheduleParameters_Int32_ptr_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663352);
			JobsUtility.NativeMethodInfoPtr_ScheduleParallelForTransform_Public_Static_JobHandle_byref_JobScheduleParameters_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663353);
			JobsUtility.NativeMethodInfoPtr_CreateJobReflectionData_Private_Static_IntPtr_Type_Type_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663354);
			JobsUtility.NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_IntPtr_Type_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663355);
			JobsUtility.NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_IntPtr_Type_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663356);
			JobsUtility.NativeMethodInfoPtr_get_IsExecutingJob_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663357);
			JobsUtility.NativeMethodInfoPtr_set_JobCompilerEnabled_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663358);
			JobsUtility.NativeMethodInfoPtr_InvokePanicFunction_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663359);
			JobsUtility.NativeMethodInfoPtr_Schedule_Injected_Private_Static_Void_byref_JobScheduleParameters_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663360);
			JobsUtility.NativeMethodInfoPtr_ScheduleParallelFor_Injected_Private_Static_Void_byref_JobScheduleParameters_Int32_Int32_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663361);
			JobsUtility.NativeMethodInfoPtr_ScheduleParallelForDeferArraySize_Injected_Private_Static_Void_byref_JobScheduleParameters_Int32_ptr_Void_ptr_Void_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663362);
			JobsUtility.NativeMethodInfoPtr_ScheduleParallelForTransform_Injected_Private_Static_Void_byref_JobScheduleParameters_IntPtr_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663363);
			JobsUtility.PatchBufferMinMaxRangesDelegateField = IL2CPP.ResolveICall<JobsUtility.PatchBufferMinMaxRangesDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::PatchBufferMinMaxRanges");
			JobsUtility.get_JobDebuggerEnabledDelegateField = IL2CPP.ResolveICall<JobsUtility.get_JobDebuggerEnabledDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_JobDebuggerEnabled");
			JobsUtility.set_JobDebuggerEnabledDelegateField = IL2CPP.ResolveICall<JobsUtility.set_JobDebuggerEnabledDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::set_JobDebuggerEnabled");
			JobsUtility.get_JobCompilerEnabledDelegateField = IL2CPP.ResolveICall<JobsUtility.get_JobCompilerEnabledDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_JobCompilerEnabled");
			JobsUtility.GetJobQueueWorkerThreadCountDelegateField = IL2CPP.ResolveICall<JobsUtility.GetJobQueueWorkerThreadCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetJobQueueWorkerThreadCount");
			JobsUtility.SetJobQueueMaximumActiveThreadCountDelegateField = IL2CPP.ResolveICall<JobsUtility.SetJobQueueMaximumActiveThreadCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::SetJobQueueMaximumActiveThreadCount");
			JobsUtility.get_JobWorkerMaximumCountDelegateField = IL2CPP.ResolveICall<JobsUtility.get_JobWorkerMaximumCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_JobWorkerMaximumCount");
			JobsUtility.ResetJobWorkerCountDelegateField = IL2CPP.ResolveICall<JobsUtility.ResetJobWorkerCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::ResetJobWorkerCount");
			JobsUtility.get_ThreadIndexDelegateField = IL2CPP.ResolveICall<JobsUtility.get_ThreadIndexDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_ThreadIndex");
			JobsUtility.get_ThreadIndexCountDelegateField = IL2CPP.ResolveICall<JobsUtility.get_ThreadIndexCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_ThreadIndexCount");
			JobsUtility.GetJobBatchingEnabledDelegateField = IL2CPP.ResolveICall<JobsUtility.GetJobBatchingEnabledDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetJobBatchingEnabled");
			JobsUtility.GetSystemIdCellPtrDelegateField = IL2CPP.ResolveICall<JobsUtility.GetSystemIdCellPtrDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetSystemIdCellPtr");
			JobsUtility.ClearSystemIdsDelegateField = IL2CPP.ResolveICall<JobsUtility.ClearSystemIdsDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::ClearSystemIds");
			JobsUtility.GetSystemIdMappingsDelegateField = IL2CPP.ResolveICall<JobsUtility.GetSystemIdMappingsDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetSystemIdMappings");
			JobsUtility.ScheduleParallelForTransformReadOnly_InjectedDelegateField = IL2CPP.ResolveICall<JobsUtility.ScheduleParallelForTransformReadOnly_InjectedDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::ScheduleParallelForTransformReadOnly_Injected");
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00019F98 File Offset: 0x00018198
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1225104, RefRangeEnd = 1225105, XrefRangeStart = 1225103, XrefRangeEnd = 1225104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetJobRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ranges;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jobIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &beginIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &endIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_GetJobRange_Public_Static_Void_byref_JobRanges_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00019FF4 File Offset: 0x000181F4
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1225107, RefRangeEnd = 1225123, XrefRangeStart = 1225105, XrefRangeEnd = 1225107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ranges;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jobIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &beginIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &endIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_GetWorkStealingRange_Public_Static_Boolean_byref_JobRanges_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0001A05C File Offset: 0x0001825C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1225125, RefRangeEnd = 1225132, XrefRangeStart = 1225123, XrefRangeEnd = 1225125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle Schedule(ref JobsUtility.JobScheduleParameters parameters)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &parameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_byref_JobScheduleParameters_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0001A09C File Offset: 0x0001829C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1225134, RefRangeEnd = 1225140, XrefRangeStart = 1225132, XrefRangeEnd = 1225134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle ScheduleParallelFor(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &parameters;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref innerloopBatchCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_ScheduleParallelFor_Public_Static_JobHandle_byref_JobScheduleParameters_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0001A0F8 File Offset: 0x000182F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1225142, RefRangeEnd = 1225143, XrefRangeStart = 1225140, XrefRangeEnd = 1225142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle ScheduleParallelForDeferArraySize(ref JobsUtility.JobScheduleParameters parameters, int innerloopBatchCount, void* listData, void* listDataAtomicSafetyHandle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &parameters;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref innerloopBatchCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = listData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = listDataAtomicSafetyHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_ScheduleParallelForDeferArraySize_Public_Static_JobHandle_byref_JobScheduleParameters_Int32_ptr_Void_ptr_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0001A160 File Offset: 0x00018360
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1225145, RefRangeEnd = 1225146, XrefRangeStart = 1225143, XrefRangeEnd = 1225145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle ScheduleParallelForTransform(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &parameters;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transfromAccesssArray;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_ScheduleParallelForTransform_Public_Static_JobHandle_byref_JobScheduleParameters_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0001A1AC File Offset: 0x000183AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225146, XrefRangeEnd = 1225148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, Object managedJobFunction0, Object managedJobFunction1, Object managedJobFunction2)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(wrapperJobType);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userJobType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(managedJobFunction0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(managedJobFunction1);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(managedJobFunction2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_CreateJobReflectionData_Private_Static_IntPtr_Type_Type_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0001A238 File Offset: 0x00018438
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1225150, RefRangeEnd = 1225160, XrefRangeStart = 1225148, XrefRangeEnd = 1225150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateJobReflectionData(Type type, Object managedJobFunction0, Object managedJobFunction1 = null, Object managedJobFunction2 = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(managedJobFunction0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(managedJobFunction1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(managedJobFunction2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_IntPtr_Type_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0001A2B0 File Offset: 0x000184B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1225162, RefRangeEnd = 1225163, XrefRangeStart = 1225160, XrefRangeEnd = 1225162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, Object managedJobFunction0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(wrapperJobType);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userJobType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(managedJobFunction0);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_IntPtr_Type_Type_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0001A318 File Offset: 0x00018518
		public unsafe static bool IsExecutingJob
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1225165, RefRangeEnd = 1225167, XrefRangeStart = 1225163, XrefRangeEnd = 1225165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_get_IsExecutingJob_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00002404 File Offset: 0x00000604
		// (set) Token: 0x06000078 RID: 120 RVA: 0x0001A348 File Offset: 0x00018548
		public unsafe static bool JobCompilerEnabled
		{
			get
			{
				return JobsUtility.get_JobCompilerEnabledDelegateField();
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1225169, RefRangeEnd = 1225174, XrefRangeStart = 1225167, XrefRangeEnd = 1225169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_set_JobCompilerEnabled_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0001A37C File Offset: 0x0001857C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225174, XrefRangeEnd = 1225176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokePanicFunction()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_InvokePanicFunction_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0001A3A4 File Offset: 0x000185A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225176, XrefRangeEnd = 1225178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Schedule_Injected(ref JobsUtility.JobScheduleParameters parameters, out JobHandle ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &parameters;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_Schedule_Injected_Private_Static_Void_byref_JobScheduleParameters_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0001A3E4 File Offset: 0x000185E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225178, XrefRangeEnd = 1225180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScheduleParallelFor_Injected(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, out JobHandle ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &parameters;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref innerloopBatchCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_ScheduleParallelFor_Injected_Private_Static_Void_byref_JobScheduleParameters_Int32_Int32_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0001A440 File Offset: 0x00018640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225180, XrefRangeEnd = 1225182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScheduleParallelForDeferArraySize_Injected(ref JobsUtility.JobScheduleParameters parameters, int innerloopBatchCount, void* listData, void* listDataAtomicSafetyHandle, out JobHandle ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &parameters;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref innerloopBatchCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = listData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = listDataAtomicSafetyHandle;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_ScheduleParallelForDeferArraySize_Injected_Private_Static_Void_byref_JobScheduleParameters_Int32_ptr_Void_ptr_Void_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0001A4AC File Offset: 0x000186AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225182, XrefRangeEnd = 1225184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScheduleParallelForTransform_Injected(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray, out JobHandle ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &parameters;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transfromAccesssArray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_ScheduleParallelForTransform_Injected_Private_Static_Void_byref_JobScheduleParameters_IntPtr_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000023C0 File Offset: 0x000005C0
		public JobsUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0001A4FC File Offset: 0x000186FC
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000023C9 File Offset: 0x000005C9
		public unsafe static JobsUtility.PanicFunction_ PanicFunction
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JobsUtility.NativeFieldInfoPtr_PanicFunction, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JobsUtility.PanicFunction_>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JobsUtility.NativeFieldInfoPtr_PanicFunction, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0001A524 File Offset: 0x00018724
		public static JobHandle ScheduleParallelForTransformReadOnly(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray, int innerloopBatchCount)
		{
			JobHandle result;
			JobsUtility.ScheduleParallelForTransformReadOnly_Injected(ref parameters, transfromAccesssArray, innerloopBatchCount, out result);
			return result;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000023DB File Offset: 0x000005DB
		public unsafe static void PatchBufferMinMaxRanges(IntPtr bufferRangePatchData, void* jobdata, int startIndex, int rangeSize)
		{
			JobsUtility.PatchBufferMinMaxRangesDelegateField(bufferRangePatchData, jobdata, startIndex, rangeSize);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0001A53C File Offset: 0x0001873C
		public static IntPtr CreateJobReflectionData(Type type, JobType jobType, Object managedJobFunction0, [Optional] Object managedJobFunction1, [Optional] Object managedJobFunction2)
		{
			return JobsUtility.CreateJobReflectionData(type, type, managedJobFunction0, managedJobFunction1, managedJobFunction2);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0001A55C File Offset: 0x0001875C
		public static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, JobType jobType, Object managedJobFunction0)
		{
			return JobsUtility.CreateJobReflectionData(wrapperJobType, userJobType, managedJobFunction0, null, null);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000023EB File Offset: 0x000005EB
		// (set) Token: 0x06000086 RID: 134 RVA: 0x000023F7 File Offset: 0x000005F7
		public static bool JobDebuggerEnabled
		{
			get
			{
				return JobsUtility.get_JobDebuggerEnabledDelegateField();
			}
			set
			{
				JobsUtility.set_JobDebuggerEnabledDelegateField(value);
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002410 File Offset: 0x00000610
		public static int GetJobQueueWorkerThreadCount()
		{
			return JobsUtility.GetJobQueueWorkerThreadCountDelegateField();
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000241C File Offset: 0x0000061C
		public static void SetJobQueueMaximumActiveThreadCount(int count)
		{
			JobsUtility.SetJobQueueMaximumActiveThreadCountDelegateField(count);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002429 File Offset: 0x00000629
		public static int JobWorkerMaximumCount
		{
			get
			{
				return JobsUtility.get_JobWorkerMaximumCountDelegateField();
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002435 File Offset: 0x00000635
		public static void ResetJobWorkerCount()
		{
			JobsUtility.ResetJobWorkerCountDelegateField();
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0001A578 File Offset: 0x00018778
		// (set) Token: 0x0600008D RID: 141 RVA: 0x0001A590 File Offset: 0x00018790
		public static int JobWorkerCount
		{
			get
			{
				return JobsUtility.GetJobQueueWorkerThreadCount();
			}
			set
			{
				bool flag = value < 0 || value > JobsUtility.JobWorkerMaximumCount;
				if (flag)
				{
					throw new ArgumentOutOfRangeException("JobWorkerCount", String.Format("Invalid JobWorkerCount {0} must be in the range 0 -> {1}", value, JobsUtility.JobWorkerMaximumCount));
				}
				JobsUtility.SetJobQueueMaximumActiveThreadCount(value);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00002441 File Offset: 0x00000641
		public static int ThreadIndex
		{
			get
			{
				return JobsUtility.get_ThreadIndexDelegateField();
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0000244D File Offset: 0x0000064D
		public static int ThreadIndexCount
		{
			get
			{
				return JobsUtility.get_ThreadIndexCountDelegateField();
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002459 File Offset: 0x00000659
		public static bool GetJobBatchingEnabled()
		{
			return JobsUtility.GetJobBatchingEnabledDelegateField();
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00002465 File Offset: 0x00000665
		public static bool JobBatchingEnabled
		{
			get
			{
				return JobsUtility.GetJobBatchingEnabled();
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000246C File Offset: 0x0000066C
		public static IntPtr GetSystemIdCellPtr()
		{
			return JobsUtility.GetSystemIdCellPtrDelegateField();
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002478 File Offset: 0x00000678
		public static void ClearSystemIds()
		{
			JobsUtility.ClearSystemIdsDelegateField();
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002484 File Offset: 0x00000684
		public unsafe static int GetSystemIdMappings(JobHandle* handles, int* systemIds, int maxCount)
		{
			return JobsUtility.GetSystemIdMappingsDelegateField(handles, systemIds, maxCount);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002493 File Offset: 0x00000693
		public static void ScheduleParallelForTransformReadOnly_Injected(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray, int innerloopBatchCount, out JobHandle ret)
		{
			JobsUtility.ScheduleParallelForTransformReadOnly_InjectedDelegateField(ref parameters, transfromAccesssArray, innerloopBatchCount, out ret);
		}

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_PanicFunction;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_GetJobRange_Public_Static_Void_byref_JobRanges_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_GetWorkStealingRange_Public_Static_Boolean_byref_JobRanges_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_byref_JobScheduleParameters_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleParallelFor_Public_Static_JobHandle_byref_JobScheduleParameters_Int32_Int32_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleParallelForDeferArraySize_Public_Static_JobHandle_byref_JobScheduleParameters_Int32_ptr_Void_ptr_Void_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleParallelForTransform_Public_Static_JobHandle_byref_JobScheduleParameters_IntPtr_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_CreateJobReflectionData_Private_Static_IntPtr_Type_Type_Object_Object_Object_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_IntPtr_Type_Object_Object_Object_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_IntPtr_Type_Type_Object_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_get_IsExecutingJob_Public_Static_get_Boolean_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_set_JobCompilerEnabled_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_InvokePanicFunction_Private_Static_Void_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Injected_Private_Static_Void_byref_JobScheduleParameters_byref_JobHandle_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleParallelFor_Injected_Private_Static_Void_byref_JobScheduleParameters_Int32_Int32_byref_JobHandle_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleParallelForDeferArraySize_Injected_Private_Static_Void_byref_JobScheduleParameters_Int32_ptr_Void_ptr_Void_byref_JobHandle_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleParallelForTransform_Injected_Private_Static_Void_byref_JobScheduleParameters_IntPtr_byref_JobHandle_0;

		// Token: 0x0400005A RID: 90
		public const int MaxJobThreadCount = 128;

		// Token: 0x0400005B RID: 91
		public const int CacheLineSize = 64;

		// Token: 0x0400005C RID: 92
		private static readonly JobsUtility.PatchBufferMinMaxRangesDelegate PatchBufferMinMaxRangesDelegateField;

		// Token: 0x0400005D RID: 93
		private static readonly JobsUtility.get_JobDebuggerEnabledDelegate get_JobDebuggerEnabledDelegateField;

		// Token: 0x0400005E RID: 94
		private static readonly JobsUtility.set_JobDebuggerEnabledDelegate set_JobDebuggerEnabledDelegateField;

		// Token: 0x0400005F RID: 95
		private static readonly JobsUtility.get_JobCompilerEnabledDelegate get_JobCompilerEnabledDelegateField;

		// Token: 0x04000060 RID: 96
		private static readonly JobsUtility.GetJobQueueWorkerThreadCountDelegate GetJobQueueWorkerThreadCountDelegateField;

		// Token: 0x04000061 RID: 97
		private static readonly JobsUtility.SetJobQueueMaximumActiveThreadCountDelegate SetJobQueueMaximumActiveThreadCountDelegateField;

		// Token: 0x04000062 RID: 98
		private static readonly JobsUtility.get_JobWorkerMaximumCountDelegate get_JobWorkerMaximumCountDelegateField;

		// Token: 0x04000063 RID: 99
		private static readonly JobsUtility.ResetJobWorkerCountDelegate ResetJobWorkerCountDelegateField;

		// Token: 0x04000064 RID: 100
		private static readonly JobsUtility.get_ThreadIndexDelegate get_ThreadIndexDelegateField;

		// Token: 0x04000065 RID: 101
		private static readonly JobsUtility.get_ThreadIndexCountDelegate get_ThreadIndexCountDelegateField;

		// Token: 0x04000066 RID: 102
		private static readonly JobsUtility.GetJobBatchingEnabledDelegate GetJobBatchingEnabledDelegateField;

		// Token: 0x04000067 RID: 103
		private static readonly JobsUtility.GetSystemIdCellPtrDelegate GetSystemIdCellPtrDelegateField;

		// Token: 0x04000068 RID: 104
		private static readonly JobsUtility.ClearSystemIdsDelegate ClearSystemIdsDelegateField;

		// Token: 0x04000069 RID: 105
		private static readonly JobsUtility.GetSystemIdMappingsDelegate GetSystemIdMappingsDelegateField;

		// Token: 0x0400006A RID: 106
		private static readonly JobsUtility.ScheduleParallelForTransformReadOnly_InjectedDelegate ScheduleParallelForTransformReadOnly_InjectedDelegateField;

		// Token: 0x02000382 RID: 898
		[StructLayout(2)]
		public struct JobScheduleParameters
		{
			// Token: 0x06002F8C RID: 12172 RVA: 0x000AE2C4 File Offset: 0x000AC4C4
			// Note: this type is marked as 'beforefieldinit'.
			static JobScheduleParameters()
			{
				Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, "JobScheduleParameters");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr);
				JobsUtility.JobScheduleParameters.NativeFieldInfoPtr_Dependency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, "Dependency");
				JobsUtility.JobScheduleParameters.NativeFieldInfoPtr_ScheduleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, "ScheduleMode");
				JobsUtility.JobScheduleParameters.NativeFieldInfoPtr_ReflectionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, "ReflectionData");
				JobsUtility.JobScheduleParameters.NativeFieldInfoPtr_JobDataPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, "JobDataPtr");
				JobsUtility.JobScheduleParameters.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_IntPtr_JobHandle_ScheduleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, 100663364);
			}

			// Token: 0x06002F8D RID: 12173 RVA: 0x000AE354 File Offset: 0x000AC554
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 1225087, RefRangeEnd = 1225103, XrefRangeStart = 1225086, XrefRangeEnd = 1225087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe JobScheduleParameters(void* i_jobData, IntPtr i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = i_jobData;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i_reflectionData;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i_dependency;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i_scheduleMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.JobScheduleParameters.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_IntPtr_JobHandle_ScheduleMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F8E RID: 12174 RVA: 0x0001569A File Offset: 0x0001389A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, ref this));
			}

			// Token: 0x040029C4 RID: 10692
			private static readonly IntPtr NativeFieldInfoPtr_Dependency;

			// Token: 0x040029C5 RID: 10693
			private static readonly IntPtr NativeFieldInfoPtr_ScheduleMode;

			// Token: 0x040029C6 RID: 10694
			private static readonly IntPtr NativeFieldInfoPtr_ReflectionData;

			// Token: 0x040029C7 RID: 10695
			private static readonly IntPtr NativeFieldInfoPtr_JobDataPtr;

			// Token: 0x040029C8 RID: 10696
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_IntPtr_JobHandle_ScheduleMode_0;

			// Token: 0x040029C9 RID: 10697
			[FieldOffset(0)]
			public JobHandle Dependency;

			// Token: 0x040029CA RID: 10698
			[FieldOffset(16)]
			public int ScheduleMode;

			// Token: 0x040029CB RID: 10699
			[FieldOffset(24)]
			public IntPtr ReflectionData;

			// Token: 0x040029CC RID: 10700
			[FieldOffset(32)]
			public IntPtr JobDataPtr;
		}

		// Token: 0x02000383 RID: 899
		public sealed class PanicFunction_ : MulticastDelegate
		{
			// Token: 0x06002F8F RID: 12175 RVA: 0x000156AC File Offset: 0x000138AC
			// Note: this type is marked as 'beforefieldinit'.
			static PanicFunction_()
			{
				Il2CppClassPointerStore<JobsUtility.PanicFunction_>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, "PanicFunction_");
				JobsUtility.PanicFunction_.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility.PanicFunction_>.NativeClassPtr, 100663365);
				JobsUtility.PanicFunction_.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility.PanicFunction_>.NativeClassPtr, 100663366);
			}

			// Token: 0x06002F90 RID: 12176 RVA: 0x000AE3B0 File Offset: 0x000AC5B0
			[CallerCount(1472)]
			[CachedScanResults(RefRangeStart = 20074, RefRangeEnd = 21546, XrefRangeStart = 20074, XrefRangeEnd = 21546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PanicFunction_(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JobsUtility.PanicFunction_>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.PanicFunction_.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F91 RID: 12177 RVA: 0x000AE40C File Offset: 0x000AC60C
			[CallerCount(0)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobsUtility.PanicFunction_.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F92 RID: 12178 RVA: 0x000156EA File Offset: 0x000138EA
			public PanicFunction_(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06002F93 RID: 12179 RVA: 0x000156F3 File Offset: 0x000138F3
			public static implicit operator JobsUtility.PanicFunction_(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<JobsUtility.PanicFunction_>(A_0);
			}

			// Token: 0x06002F94 RID: 12180 RVA: 0x000156FB File Offset: 0x000138FB
			public static JobsUtility.PanicFunction_ operator +(JobsUtility.PanicFunction_ A_0, JobsUtility.PanicFunction_ A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<JobsUtility.PanicFunction_>();
			}

			// Token: 0x06002F95 RID: 12181 RVA: 0x00015709 File Offset: 0x00013909
			public static JobsUtility.PanicFunction_ operator -(JobsUtility.PanicFunction_ A_0, JobsUtility.PanicFunction_ A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<JobsUtility.PanicFunction_>();
				}
				return result;
			}

			// Token: 0x040029CD RID: 10701
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040029CE RID: 10702
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
		}

		// Token: 0x02000384 RID: 900
		// (Invoke) Token: 0x06002F97 RID: 12183
		private delegate void PatchBufferMinMaxRangesDelegate(IntPtr bufferRangePatchData, IntPtr jobdata, int startIndex, int rangeSize);

		// Token: 0x02000385 RID: 901
		// (Invoke) Token: 0x06002F99 RID: 12185
		private delegate bool get_JobDebuggerEnabledDelegate();

		// Token: 0x02000386 RID: 902
		// (Invoke) Token: 0x06002F9B RID: 12187
		private delegate void set_JobDebuggerEnabledDelegate(bool value);

		// Token: 0x02000387 RID: 903
		// (Invoke) Token: 0x06002F9D RID: 12189
		private delegate bool get_JobCompilerEnabledDelegate();

		// Token: 0x02000388 RID: 904
		// (Invoke) Token: 0x06002F9F RID: 12191
		private delegate int GetJobQueueWorkerThreadCountDelegate();

		// Token: 0x02000389 RID: 905
		// (Invoke) Token: 0x06002FA1 RID: 12193
		private delegate void SetJobQueueMaximumActiveThreadCountDelegate(int count);

		// Token: 0x0200038A RID: 906
		// (Invoke) Token: 0x06002FA3 RID: 12195
		private delegate int get_JobWorkerMaximumCountDelegate();

		// Token: 0x0200038B RID: 907
		// (Invoke) Token: 0x06002FA5 RID: 12197
		private delegate void ResetJobWorkerCountDelegate();

		// Token: 0x0200038C RID: 908
		// (Invoke) Token: 0x06002FA7 RID: 12199
		private delegate int get_ThreadIndexDelegate();

		// Token: 0x0200038D RID: 909
		// (Invoke) Token: 0x06002FA9 RID: 12201
		private delegate int get_ThreadIndexCountDelegate();

		// Token: 0x0200038E RID: 910
		// (Invoke) Token: 0x06002FAB RID: 12203
		private delegate bool GetJobBatchingEnabledDelegate();

		// Token: 0x0200038F RID: 911
		// (Invoke) Token: 0x06002FAD RID: 12205
		private delegate IntPtr GetSystemIdCellPtrDelegate();

		// Token: 0x02000390 RID: 912
		// (Invoke) Token: 0x06002FAF RID: 12207
		private delegate void ClearSystemIdsDelegate();

		// Token: 0x02000391 RID: 913
		// (Invoke) Token: 0x06002FB1 RID: 12209
		private delegate int GetSystemIdMappingsDelegate(IntPtr handles, IntPtr systemIds, int maxCount);

		// Token: 0x02000392 RID: 914
		// (Invoke) Token: 0x06002FB3 RID: 12211
		private delegate void ScheduleParallelForTransformReadOnly_InjectedDelegate(IntPtr parameters, IntPtr transfromAccesssArray, int innerloopBatchCount, [Out] IntPtr ret);
	}
}
