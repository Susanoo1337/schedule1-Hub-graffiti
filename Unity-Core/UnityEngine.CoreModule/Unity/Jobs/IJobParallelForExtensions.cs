using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs.LowLevel.Unsafe;

namespace Unity.Jobs
{
	// Token: 0x0200000F RID: 15
	public static class IJobParallelForExtensions : Object
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00019194 File Offset: 0x00017394
		// Note: this type is marked as 'beforefieldinit'.
		static IJobParallelForExtensions()
		{
			Il2CppClassPointerStore<IJobParallelForExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs", "IJobParallelForExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IJobParallelForExtensions>.NativeClassPtr);
			IJobParallelForExtensions.NativeMethodInfoPtr_EarlyJobInit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForExtensions>.NativeClassPtr, 100663324);
			IJobParallelForExtensions.NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForExtensions>.NativeClassPtr, 100663325);
			IJobParallelForExtensions.NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_T_Int32_Int32_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForExtensions>.NativeClassPtr, 100663326);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00019200 File Offset: 0x00017400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1224971, RefRangeEnd = 1224972, XrefRangeStart = 1224963, XrefRangeEnd = 1224971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EarlyJobInit<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobParallelForExtensions.MethodInfoStoreGeneric_EarlyJobInit_Public_Static_Void_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00019228 File Offset: 0x00017428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224972, XrefRangeEnd = 1224980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetReflectionData<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobParallelForExtensions.MethodInfoStoreGeneric_GetReflectionData_Private_Static_IntPtr_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00019258 File Offset: 0x00017458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1224991, RefRangeEnd = 1224992, XrefRangeStart = 1224980, XrefRangeEnd = 1224991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle Schedule<T>(this T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn = default(JobHandle)) where T : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = jobData;
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
				ptr4 = ref jobData;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref innerloopBatchCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dependsOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobParallelForExtensions.MethodInfoStoreGeneric_Schedule_Public_Static_JobHandle_T_Int32_Int32_JobHandle_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002276 File Offset: 0x00000476
		public IJobParallelForExtensions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00019310 File Offset: 0x00017510
		public static void Run<T>(T jobData, int arrayLength) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobParallelForExtensions.GetReflectionData<T>(), default(JobHandle), Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Run);
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.ScheduleParallelFor(ref jobScheduleParameters, arrayLength, arrayLength);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00019348 File Offset: 0x00017548
		public static JobHandle ScheduleByRef<T>(ref T jobData, int arrayLength, int innerloopBatchCount, [Optional] JobHandle dependsOn) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobParallelForExtensions.GetReflectionData<T>(), dependsOn, Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Batched);
			return Unity.Jobs.LowLevel.Unsafe.JobsUtility.ScheduleParallelFor(ref jobScheduleParameters, arrayLength, innerloopBatchCount);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00019378 File Offset: 0x00017578
		public static void RunByRef<T>(ref T jobData, int arrayLength) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobParallelForExtensions.GetReflectionData<T>(), default(JobHandle), Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Run);
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.ScheduleParallelFor(ref jobScheduleParameters, arrayLength, arrayLength);
		}

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_EarlyJobInit_Public_Static_Void_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_T_Int32_Int32_JobHandle_0;

		// Token: 0x0200037B RID: 891
		public sealed class ParallelForJobStruct<T> : ValueType where T : new()
		{
			// Token: 0x06002F7C RID: 12156 RVA: 0x000AE038 File Offset: 0x000AC238
			// Note: this type is marked as 'beforefieldinit'.
			static ParallelForJobStruct()
			{
				Il2CppClassPointerStore<IJobParallelForExtensions.ParallelForJobStruct<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IJobParallelForExtensions>.NativeClassPtr, "ParallelForJobStruct`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IJobParallelForExtensions.ParallelForJobStruct<T>>.NativeClassPtr);
				IJobParallelForExtensions.ParallelForJobStruct<T>.NativeFieldInfoPtr_jobReflectionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IJobParallelForExtensions.ParallelForJobStruct<T>>.NativeClassPtr, "jobReflectionData");
				IJobParallelForExtensions.ParallelForJobStruct<T>.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForExtensions.ParallelForJobStruct<T>>.NativeClassPtr, 100663327);
				IJobParallelForExtensions.ParallelForJobStruct<T>.NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForExtensions.ParallelForJobStruct<T>>.NativeClassPtr, 100663328);
			}

			// Token: 0x06002F7D RID: 12157 RVA: 0x000AE0DC File Offset: 0x000AC2DC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1224956, RefRangeEnd = 1224959, XrefRangeStart = 1224928, XrefRangeEnd = 1224956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Initialize()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobParallelForExtensions.ParallelForJobStruct<T>.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F7E RID: 12158 RVA: 0x000AE104 File Offset: 0x000AC304
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224959, XrefRangeEnd = 1224963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(jobData);
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferRangePatchData;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ranges;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jobIndex;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IJobParallelForExtensions.ParallelForJobStruct<T>.NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				jobData = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			}

			// Token: 0x06002F7F RID: 12159 RVA: 0x00015668 File Offset: 0x00013868
			public ParallelForJobStruct(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06002F80 RID: 12160 RVA: 0x00015671 File Offset: 0x00013871
			public ParallelForJobStruct() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IJobParallelForExtensions.ParallelForJobStruct<T>>.NativeClassPtr))
			{
			}

			// Token: 0x170009F3 RID: 2547
			// (get) Token: 0x06002F81 RID: 12161 RVA: 0x000AE18C File Offset: 0x000AC38C
			// (set) Token: 0x06002F82 RID: 12162 RVA: 0x00015683 File Offset: 0x00013883
			public unsafe static Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr> jobReflectionData
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr>>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(IJobParallelForExtensions.ParallelForJobStruct<T>.NativeFieldInfoPtr_jobReflectionData, intPtr);
					return new Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr>>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IJobParallelForExtensions.ParallelForJobStruct<T>.NativeFieldInfoPtr_jobReflectionData, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x040029BE RID: 10686
			private static readonly IntPtr NativeFieldInfoPtr_jobReflectionData;

			// Token: 0x040029BF RID: 10687
			private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

			// Token: 0x040029C0 RID: 10688
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0;

			// Token: 0x02000D45 RID: 3397
			public sealed class ExecuteJobFunction : MulticastDelegate
			{
				// Token: 0x06004322 RID: 17186 RVA: 0x000B6624 File Offset: 0x000B4824
				// Note: this type is marked as 'beforefieldinit'.
				static ExecuteJobFunction()
				{
					Il2CppClassPointerStore<IJobParallelForExtensions.ParallelForJobStruct<T>.ExecuteJobFunction>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IJobParallelForExtensions.ParallelForJobStruct<T>>.NativeClassPtr, "ExecuteJobFunction"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
					})).TypeHandle.value);
					IJobParallelForExtensions.ParallelForJobStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForExtensions.ParallelForJobStruct<T>.ExecuteJobFunction>.NativeClassPtr, 100663330);
					IJobParallelForExtensions.ParallelForJobStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForExtensions.ParallelForJobStruct<T>.ExecuteJobFunction>.NativeClassPtr, 100663331);
				}

				// Token: 0x06004323 RID: 17187 RVA: 0x000B66A8 File Offset: 0x000B48A8
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 1019380, RefRangeEnd = 1019384, XrefRangeStart = 1019380, XrefRangeEnd = 1019384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ExecuteJobFunction(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IJobParallelForExtensions.ParallelForJobStruct<T>.ExecuteJobFunction>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobParallelForExtensions.ParallelForJobStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06004324 RID: 17188 RVA: 0x000B6704 File Offset: 0x000B4904
				[CallerCount(0)]
				public unsafe void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(data);
					ptr2 = &intPtr;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalPtr;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferRangePatchData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ranges;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jobIndex;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IJobParallelForExtensions.ParallelForJobStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					data = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				}

				// Token: 0x06004325 RID: 17189 RVA: 0x00018849 File Offset: 0x00016A49
				public ExecuteJobFunction(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x04002C97 RID: 11415
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002C98 RID: 11416
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0;
			}
		}

		// Token: 0x0200037C RID: 892
		private sealed class MethodInfoStoreGeneric_EarlyJobInit_Public_Static_Void_0<T>
		{
			// Token: 0x040029C1 RID: 10689
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IJobParallelForExtensions.NativeMethodInfoPtr_EarlyJobInit_Public_Static_Void_0, Il2CppClassPointerStore<IJobParallelForExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200037D RID: 893
		private sealed class MethodInfoStoreGeneric_GetReflectionData_Private_Static_IntPtr_0<T>
		{
			// Token: 0x040029C2 RID: 10690
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IJobParallelForExtensions.NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0, Il2CppClassPointerStore<IJobParallelForExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200037E RID: 894
		private sealed class MethodInfoStoreGeneric_Schedule_Public_Static_JobHandle_T_Int32_Int32_JobHandle_0<T>
		{
			// Token: 0x040029C3 RID: 10691
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IJobParallelForExtensions.NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_T_Int32_Int32_JobHandle_0, Il2CppClassPointerStore<IJobParallelForExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
