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
	// Token: 0x0200000B RID: 11
	public static class IJobExtensions : Object
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00018C8C File Offset: 0x00016E8C
		// Note: this type is marked as 'beforefieldinit'.
		static IJobExtensions()
		{
			Il2CppClassPointerStore<IJobExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs", "IJobExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IJobExtensions>.NativeClassPtr);
			IJobExtensions.NativeMethodInfoPtr_EarlyJobInit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobExtensions>.NativeClassPtr, 100663306);
			IJobExtensions.NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobExtensions>.NativeClassPtr, 100663307);
			IJobExtensions.NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_T_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobExtensions>.NativeClassPtr, 100663308);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00018CF8 File Offset: 0x00016EF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1224832, RefRangeEnd = 1224833, XrefRangeStart = 1224796, XrefRangeEnd = 1224832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EarlyJobInit<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobExtensions.MethodInfoStoreGeneric_EarlyJobInit_Public_Static_Void_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00018D20 File Offset: 0x00016F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224833, XrefRangeEnd = 1224841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetReflectionData<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobExtensions.MethodInfoStoreGeneric_GetReflectionData_Private_Static_IntPtr_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00018D50 File Offset: 0x00016F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224841, XrefRangeEnd = 1224852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle Schedule<T>(this T jobData, JobHandle dependsOn = default(JobHandle)) where T : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dependsOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobExtensions.MethodInfoStoreGeneric_Schedule_Public_Static_JobHandle_T_JobHandle_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000021F4 File Offset: 0x000003F4
		public IJobExtensions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00018DEC File Offset: 0x00016FEC
		public static void Run<T>(T jobData) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobExtensions.GetReflectionData<T>(), default(JobHandle), Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Run);
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.Schedule(ref jobScheduleParameters);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00018E20 File Offset: 0x00017020
		public static JobHandle ScheduleByRef<T>(ref T jobData, [Optional] JobHandle dependsOn) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobExtensions.GetReflectionData<T>(), dependsOn, Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Single);
			return Unity.Jobs.LowLevel.Unsafe.JobsUtility.Schedule(ref jobScheduleParameters);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00018E50 File Offset: 0x00017050
		public static void RunByRef<T>(ref T jobData) where T : struct
		{
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters jobScheduleParameters = new Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters(Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref jobData), IJobExtensions.GetReflectionData<T>(), default(JobHandle), Unity.Jobs.LowLevel.Unsafe.ScheduleMode.Run);
			Unity.Jobs.LowLevel.Unsafe.JobsUtility.Schedule(ref jobScheduleParameters);
		}

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_EarlyJobInit_Public_Static_Void_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_T_JobHandle_0;

		// Token: 0x02000373 RID: 883
		public sealed class JobStruct<T> : ValueType where T : new()
		{
			// Token: 0x06002F68 RID: 12136 RVA: 0x000ADB20 File Offset: 0x000ABD20
			// Note: this type is marked as 'beforefieldinit'.
			static JobStruct()
			{
				Il2CppClassPointerStore<IJobExtensions.JobStruct<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IJobExtensions>.NativeClassPtr, "JobStruct`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IJobExtensions.JobStruct<T>>.NativeClassPtr);
				IJobExtensions.JobStruct<T>.NativeFieldInfoPtr_jobReflectionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IJobExtensions.JobStruct<T>>.NativeClassPtr, "jobReflectionData");
				IJobExtensions.JobStruct<T>.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobExtensions.JobStruct<T>>.NativeClassPtr, 100663309);
				IJobExtensions.JobStruct<T>.NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobExtensions.JobStruct<T>>.NativeClassPtr, 100663310);
			}

			// Token: 0x06002F69 RID: 12137 RVA: 0x000ADBC4 File Offset: 0x000ABDC4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1224749, RefRangeEnd = 1224752, XrefRangeStart = 1224721, XrefRangeEnd = 1224749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Initialize()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobExtensions.JobStruct<T>.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F6A RID: 12138 RVA: 0x000ADBEC File Offset: 0x000ABDEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224752, XrefRangeEnd = 1224796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Execute(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferRangePatchData;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ranges;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jobIndex;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IJobExtensions.JobStruct<T>.NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				data = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			}

			// Token: 0x06002F6B RID: 12139 RVA: 0x00015604 File Offset: 0x00013804
			public JobStruct(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06002F6C RID: 12140 RVA: 0x0001560D File Offset: 0x0001380D
			public JobStruct() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IJobExtensions.JobStruct<T>>.NativeClassPtr))
			{
			}

			// Token: 0x170009F1 RID: 2545
			// (get) Token: 0x06002F6D RID: 12141 RVA: 0x000ADC74 File Offset: 0x000ABE74
			// (set) Token: 0x06002F6E RID: 12142 RVA: 0x0001561F File Offset: 0x0001381F
			public unsafe static Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr> jobReflectionData
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr>>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(IJobExtensions.JobStruct<T>.NativeFieldInfoPtr_jobReflectionData, intPtr);
					return new Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<IntPtr>>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IJobExtensions.JobStruct<T>.NativeFieldInfoPtr_jobReflectionData, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x040029B2 RID: 10674
			private static readonly IntPtr NativeFieldInfoPtr_jobReflectionData;

			// Token: 0x040029B3 RID: 10675
			private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

			// Token: 0x040029B4 RID: 10676
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0;

			// Token: 0x02000D43 RID: 3395
			public sealed class ExecuteJobFunction : MulticastDelegate
			{
				// Token: 0x0600431A RID: 17178 RVA: 0x000B633C File Offset: 0x000B453C
				// Note: this type is marked as 'beforefieldinit'.
				static ExecuteJobFunction()
				{
					Il2CppClassPointerStore<IJobExtensions.JobStruct<T>.ExecuteJobFunction>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IJobExtensions.JobStruct<T>>.NativeClassPtr, "ExecuteJobFunction"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
					})).TypeHandle.value);
					IJobExtensions.JobStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobExtensions.JobStruct<T>.ExecuteJobFunction>.NativeClassPtr, 100663312);
					IJobExtensions.JobStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobExtensions.JobStruct<T>.ExecuteJobFunction>.NativeClassPtr, 100663313);
				}

				// Token: 0x0600431B RID: 17179 RVA: 0x000B63C0 File Offset: 0x000B45C0
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 1019380, RefRangeEnd = 1019384, XrefRangeStart = 1019380, XrefRangeEnd = 1019384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ExecuteJobFunction(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IJobExtensions.JobStruct<T>.ExecuteJobFunction>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IJobExtensions.JobStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600431C RID: 17180 RVA: 0x000B641C File Offset: 0x000B461C
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IJobExtensions.JobStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					data = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				}

				// Token: 0x0600431D RID: 17181 RVA: 0x00018837 File Offset: 0x00016A37
				public ExecuteJobFunction(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x04002C93 RID: 11411
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002C94 RID: 11412
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0;
			}
		}

		// Token: 0x02000374 RID: 884
		private sealed class MethodInfoStoreGeneric_EarlyJobInit_Public_Static_Void_0<T>
		{
			// Token: 0x040029B5 RID: 10677
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IJobExtensions.NativeMethodInfoPtr_EarlyJobInit_Public_Static_Void_0, Il2CppClassPointerStore<IJobExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000375 RID: 885
		private sealed class MethodInfoStoreGeneric_GetReflectionData_Private_Static_IntPtr_0<T>
		{
			// Token: 0x040029B6 RID: 10678
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IJobExtensions.NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0, Il2CppClassPointerStore<IJobExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000376 RID: 886
		private sealed class MethodInfoStoreGeneric_Schedule_Public_Static_JobHandle_T_JobHandle_0<T>
		{
			// Token: 0x040029B7 RID: 10679
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IJobExtensions.NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_T_JobHandle_0, Il2CppClassPointerStore<IJobExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
