using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;

namespace UnityEngine.Jobs
{
	// Token: 0x02000183 RID: 387
	public static class IJobParallelForTransformExtensions : Object
	{
		// Token: 0x06001DCF RID: 7631 RVA: 0x0007A07C File Offset: 0x0007827C
		// Note: this type is marked as 'beforefieldinit'.
		static IJobParallelForTransformExtensions()
		{
			Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Jobs", "IJobParallelForTransformExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr);
			IJobParallelForTransformExtensions.NativeMethodInfoPtr_EarlyJobInit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr, 100666475);
			IJobParallelForTransformExtensions.NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr, 100666476);
			IJobParallelForTransformExtensions.NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_T_TransformAccessArray_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr, 100666477);
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x0007A0E8 File Offset: 0x000782E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EarlyJobInit<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobParallelForTransformExtensions.MethodInfoStoreGeneric_EarlyJobInit_Public_Static_Void_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x0007A110 File Offset: 0x00078310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282465, XrefRangeEnd = 1282472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetReflectionData<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobParallelForTransformExtensions.MethodInfoStoreGeneric_GetReflectionData_Private_Static_IntPtr_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x0007A140 File Offset: 0x00078340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282472, XrefRangeEnd = 1282476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Unity.Jobs.JobHandle Schedule<T>(this T jobData, TransformAccessArray transforms, Unity.Jobs.JobHandle dependsOn = default(Unity.Jobs.JobHandle)) where T : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transforms;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dependsOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobParallelForTransformExtensions.MethodInfoStoreGeneric_Schedule_Public_Static_JobHandle_T_TransformAccessArray_JobHandle_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x0000E0B1 File Offset: 0x0000C2B1
		public IJobParallelForTransformExtensions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x0007A1E8 File Offset: 0x000783E8
		public static Unity.Jobs.JobHandle ScheduleReadOnly<T>(T jobData, TransformAccessArray transforms, int batchSize, [Optional] Unity.Jobs.JobHandle dependsOn) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobParallelForTransformExtensions.GetReflectionData<T>(), dependsOn, Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Batched);
			return Unity.Jobs.LowLevel.Unsafe.JobsUtility.ScheduleParallelForTransformReadOnly(ref jobScheduleParameters, transforms.GetTransformAccessArrayForSchedule(), batchSize);
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x0007A220 File Offset: 0x00078420
		public static void RunReadOnly<T>(T jobData, TransformAccessArray transforms) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobParallelForTransformExtensions.GetReflectionData<T>(), default(Unity.Jobs.JobHandle), Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Run);
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.ScheduleParallelForTransformReadOnly(ref jobScheduleParameters, transforms.GetTransformAccessArrayForSchedule(), transforms.length);
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x0007A264 File Offset: 0x00078464
		public static Unity.Jobs.JobHandle ScheduleByRef<T>(ref T jobData, TransformAccessArray transforms, [Optional] Unity.Jobs.JobHandle dependsOn) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobParallelForTransformExtensions.GetReflectionData<T>(), dependsOn, Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Batched);
			return Unity.Jobs.LowLevel.Unsafe.JobsUtility.ScheduleParallelForTransform(ref jobScheduleParameters, transforms.GetTransformAccessArrayForSchedule());
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x0007A298 File Offset: 0x00078498
		public static Unity.Jobs.JobHandle ScheduleReadOnlyByRef<T>(ref T jobData, TransformAccessArray transforms, int batchSize, [Optional] Unity.Jobs.JobHandle dependsOn) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobParallelForTransformExtensions.GetReflectionData<T>(), dependsOn, Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Batched);
			return Unity.Jobs.LowLevel.Unsafe.JobsUtility.ScheduleParallelForTransformReadOnly(ref jobScheduleParameters, transforms.GetTransformAccessArrayForSchedule(), batchSize);
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x0007A2D0 File Offset: 0x000784D0
		public static void RunReadOnlyByRef<T>(ref T jobData, TransformAccessArray transforms) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobParallelForTransformExtensions.GetReflectionData<T>(), default(Unity.Jobs.JobHandle), Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Run);
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.ScheduleParallelForTransformReadOnly(ref jobScheduleParameters, transforms.GetTransformAccessArrayForSchedule(), transforms.length);
		}

		// Token: 0x04001854 RID: 6228
		private static readonly IntPtr NativeMethodInfoPtr_EarlyJobInit_Public_Static_Void_0;

		// Token: 0x04001855 RID: 6229
		private static readonly IntPtr NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0;

		// Token: 0x04001856 RID: 6230
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_T_TransformAccessArray_JobHandle_0;

		// Token: 0x020009EF RID: 2543
		public sealed class TransformParallelForLoopStruct<T> : ValueType where T : new()
		{
			// Token: 0x06003C5C RID: 15452 RVA: 0x000B33B8 File Offset: 0x000B15B8
			// Note: this type is marked as 'beforefieldinit'.
			static TransformParallelForLoopStruct()
			{
				Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr, "TransformParallelForLoopStruct`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr);
				IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.NativeFieldInfoPtr_jobReflectionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr, "jobReflectionData");
				IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr, 100666478);
				IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr, 100666479);
			}

			// Token: 0x06003C5D RID: 15453 RVA: 0x000B345C File Offset: 0x000B165C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282412, XrefRangeEnd = 1282440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Initialize()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C5E RID: 15454 RVA: 0x000B3484 File Offset: 0x000B1684
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282440, XrefRangeEnd = 1282465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Execute(ref T jobData, IntPtr jobData2, IntPtr bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(jobData);
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jobData2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferRangePatchData;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ranges;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jobIndex;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				jobData = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			}

			// Token: 0x06003C5F RID: 15455 RVA: 0x000160A8 File Offset: 0x000142A8
			public TransformParallelForLoopStruct(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003C60 RID: 15456 RVA: 0x000160B1 File Offset: 0x000142B1
			public TransformParallelForLoopStruct() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000A27 RID: 2599
			// (get) Token: 0x06003C61 RID: 15457 RVA: 0x000B350C File Offset: 0x000B170C
			// (set) Token: 0x06003C62 RID: 15458 RVA: 0x000160C3 File Offset: 0x000142C3
			public unsafe static Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr> jobReflectionData
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr>>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.NativeFieldInfoPtr_jobReflectionData, intPtr);
					return new Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr>>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.NativeFieldInfoPtr_jobReflectionData, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x04002B6B RID: 11115
			private static readonly IntPtr NativeFieldInfoPtr_jobReflectionData;

			// Token: 0x04002B6C RID: 11116
			private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

			// Token: 0x04002B6D RID: 11117
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0;

			// Token: 0x02000D49 RID: 3401
			public sealed class TransformJobData : ValueType
			{
				// Token: 0x06004337 RID: 17207 RVA: 0x000B6C14 File Offset: 0x000B4E14
				// Note: this type is marked as 'beforefieldinit'.
				static TransformJobData()
				{
					Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr, "TransformJobData"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData>.NativeClassPtr);
					IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData.NativeFieldInfoPtr_TransformAccessArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData>.NativeClassPtr, "TransformAccessArray");
					IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData.NativeFieldInfoPtr_IsReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData>.NativeClassPtr, "IsReadOnly");
				}

				// Token: 0x06004338 RID: 17208 RVA: 0x000188B6 File Offset: 0x00016AB6
				public TransformJobData(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x06004339 RID: 17209 RVA: 0x000188BF File Offset: 0x00016ABF
				public TransformJobData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData>.NativeClassPtr))
				{
				}

				// Token: 0x17000A3D RID: 2621
				// (get) Token: 0x0600433A RID: 17210 RVA: 0x000B6CA4 File Offset: 0x000B4EA4
				// (set) Token: 0x0600433B RID: 17211 RVA: 0x000188D1 File Offset: 0x00016AD1
				public unsafe IntPtr TransformAccessArray
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData.NativeFieldInfoPtr_TransformAccessArray);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData.NativeFieldInfoPtr_TransformAccessArray)) = value;
					}
				}

				// Token: 0x17000A3E RID: 2622
				// (get) Token: 0x0600433C RID: 17212 RVA: 0x000B6CCC File Offset: 0x000B4ECC
				// (set) Token: 0x0600433D RID: 17213 RVA: 0x000188EC File Offset: 0x00016AEC
				public unsafe int IsReadOnly
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData.NativeFieldInfoPtr_IsReadOnly);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData.NativeFieldInfoPtr_IsReadOnly)) = value;
					}
				}

				// Token: 0x04002CA4 RID: 11428
				private static readonly IntPtr NativeFieldInfoPtr_TransformAccessArray;

				// Token: 0x04002CA5 RID: 11429
				private static readonly IntPtr NativeFieldInfoPtr_IsReadOnly;
			}

			// Token: 0x02000D4A RID: 3402
			public sealed class ExecuteJobFunction : MulticastDelegate
			{
				// Token: 0x0600433E RID: 17214 RVA: 0x000B6CF4 File Offset: 0x000B4EF4
				// Note: this type is marked as 'beforefieldinit'.
				static ExecuteJobFunction()
				{
					Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr, "ExecuteJobFunction"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
					})).TypeHandle.value);
					IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction>.NativeClassPtr, 100666481);
					IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction>.NativeClassPtr, 100666482);
				}

				// Token: 0x0600433F RID: 17215 RVA: 0x000B6D78 File Offset: 0x000B4F78
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 1019380, RefRangeEnd = 1019384, XrefRangeStart = 1019380, XrefRangeEnd = 1019384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ExecuteJobFunction(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06004340 RID: 17216 RVA: 0x000B6DD4 File Offset: 0x000B4FD4
				[CallerCount(0)]
				public unsafe void Invoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(jobData);
					ptr2 = &intPtr;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalPtr;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferRangePatchData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ranges;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jobIndex;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					jobData = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				}

				// Token: 0x06004341 RID: 17217 RVA: 0x00018907 File Offset: 0x00016B07
				public ExecuteJobFunction(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x04002CA6 RID: 11430
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002CA7 RID: 11431
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0;
			}
		}

		// Token: 0x020009F0 RID: 2544
		private sealed class MethodInfoStoreGeneric_EarlyJobInit_Public_Static_Void_0<T>
		{
			// Token: 0x04002B6E RID: 11118
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IJobParallelForTransformExtensions.NativeMethodInfoPtr_EarlyJobInit_Public_Static_Void_0, Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020009F1 RID: 2545
		private sealed class MethodInfoStoreGeneric_GetReflectionData_Private_Static_IntPtr_0<T>
		{
			// Token: 0x04002B6F RID: 11119
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IJobParallelForTransformExtensions.NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0, Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020009F2 RID: 2546
		private sealed class MethodInfoStoreGeneric_Schedule_Public_Static_JobHandle_T_TransformAccessArray_JobHandle_0<T>
		{
			// Token: 0x04002B70 RID: 11120
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IJobParallelForTransformExtensions.NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_T_TransformAccessArray_JobHandle_0, Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
