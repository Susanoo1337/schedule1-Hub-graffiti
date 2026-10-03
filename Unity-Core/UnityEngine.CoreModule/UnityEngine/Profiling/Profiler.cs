using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Profiling;

namespace UnityEngine.Profiling
{
	// Token: 0x0200017E RID: 382
	public sealed class Profiler : Object
	{
		// Token: 0x06001D61 RID: 7521 RVA: 0x00079070 File Offset: 0x00077270
		// Note: this type is marked as 'beforefieldinit'.
		static Profiler()
		{
			Il2CppClassPointerStore<Profiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Profiling", "Profiler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Profiler>.NativeClassPtr);
			Profiler.NativeMethodInfoPtr_EndThreadProfiling_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100666453);
			Profiler.NativeMethodInfoPtr_GetRuntimeMemorySizeLong_Public_Static_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100666454);
			Profiler.get_supportedDelegateField = IL2CPP.ResolveICall<Profiler.get_supportedDelegate>("UnityEngine.Profiling.Profiler::get_supported");
			Profiler.get_logFileDelegateField = IL2CPP.ResolveICall<Profiler.get_logFileDelegate>("UnityEngine.Profiling.Profiler::get_logFile");
			Profiler.set_logFileDelegateField = IL2CPP.ResolveICall<Profiler.set_logFileDelegate>("UnityEngine.Profiling.Profiler::set_logFile");
			Profiler.get_enableBinaryLogDelegateField = IL2CPP.ResolveICall<Profiler.get_enableBinaryLogDelegate>("UnityEngine.Profiling.Profiler::get_enableBinaryLog");
			Profiler.set_enableBinaryLogDelegateField = IL2CPP.ResolveICall<Profiler.set_enableBinaryLogDelegate>("UnityEngine.Profiling.Profiler::set_enableBinaryLog");
			Profiler.get_maxUsedMemoryDelegateField = IL2CPP.ResolveICall<Profiler.get_maxUsedMemoryDelegate>("UnityEngine.Profiling.Profiler::get_maxUsedMemory");
			Profiler.set_maxUsedMemoryDelegateField = IL2CPP.ResolveICall<Profiler.set_maxUsedMemoryDelegate>("UnityEngine.Profiling.Profiler::set_maxUsedMemory");
			Profiler.get_enabledDelegateField = IL2CPP.ResolveICall<Profiler.get_enabledDelegate>("UnityEngine.Profiling.Profiler::get_enabled");
			Profiler.set_enabledDelegateField = IL2CPP.ResolveICall<Profiler.set_enabledDelegate>("UnityEngine.Profiling.Profiler::set_enabled");
			Profiler.get_enableAllocationCallstacksDelegateField = IL2CPP.ResolveICall<Profiler.get_enableAllocationCallstacksDelegate>("UnityEngine.Profiling.Profiler::get_enableAllocationCallstacks");
			Profiler.set_enableAllocationCallstacksDelegateField = IL2CPP.ResolveICall<Profiler.set_enableAllocationCallstacksDelegate>("UnityEngine.Profiling.Profiler::set_enableAllocationCallstacks");
			Profiler.SetAreaEnabledDelegateField = IL2CPP.ResolveICall<Profiler.SetAreaEnabledDelegate>("UnityEngine.Profiling.Profiler::SetAreaEnabled");
			Profiler.GetAreaEnabledDelegateField = IL2CPP.ResolveICall<Profiler.GetAreaEnabledDelegate>("UnityEngine.Profiling.Profiler::GetAreaEnabled");
			Profiler.AddFramesFromFile_InternalDelegateField = IL2CPP.ResolveICall<Profiler.AddFramesFromFile_InternalDelegate>("UnityEngine.Profiling.Profiler::AddFramesFromFile_Internal");
			Profiler.BeginThreadProfilingInternalDelegateField = IL2CPP.ResolveICall<Profiler.BeginThreadProfilingInternalDelegate>("UnityEngine.Profiling.Profiler::BeginThreadProfilingInternal");
			Profiler.BeginSampleImplDelegateField = IL2CPP.ResolveICall<Profiler.BeginSampleImplDelegate>("UnityEngine.Profiling.Profiler::BeginSampleImpl");
			Profiler.EndSampleDelegateField = IL2CPP.ResolveICall<Profiler.EndSampleDelegate>("UnityEngine.Profiling.Profiler::EndSample");
			Profiler.get_usedHeapSizeLongDelegateField = IL2CPP.ResolveICall<Profiler.get_usedHeapSizeLongDelegate>("UnityEngine.Profiling.Profiler::get_usedHeapSizeLong");
			Profiler.GetMonoHeapSizeLongDelegateField = IL2CPP.ResolveICall<Profiler.GetMonoHeapSizeLongDelegate>("UnityEngine.Profiling.Profiler::GetMonoHeapSizeLong");
			Profiler.GetMonoUsedSizeLongDelegateField = IL2CPP.ResolveICall<Profiler.GetMonoUsedSizeLongDelegate>("UnityEngine.Profiling.Profiler::GetMonoUsedSizeLong");
			Profiler.SetTempAllocatorRequestedSizeDelegateField = IL2CPP.ResolveICall<Profiler.SetTempAllocatorRequestedSizeDelegate>("UnityEngine.Profiling.Profiler::SetTempAllocatorRequestedSize");
			Profiler.GetTempAllocatorSizeDelegateField = IL2CPP.ResolveICall<Profiler.GetTempAllocatorSizeDelegate>("UnityEngine.Profiling.Profiler::GetTempAllocatorSize");
			Profiler.GetTotalAllocatedMemoryLongDelegateField = IL2CPP.ResolveICall<Profiler.GetTotalAllocatedMemoryLongDelegate>("UnityEngine.Profiling.Profiler::GetTotalAllocatedMemoryLong");
			Profiler.GetTotalUnusedReservedMemoryLongDelegateField = IL2CPP.ResolveICall<Profiler.GetTotalUnusedReservedMemoryLongDelegate>("UnityEngine.Profiling.Profiler::GetTotalUnusedReservedMemoryLong");
			Profiler.GetTotalReservedMemoryLongDelegateField = IL2CPP.ResolveICall<Profiler.GetTotalReservedMemoryLongDelegate>("UnityEngine.Profiling.Profiler::GetTotalReservedMemoryLong");
			Profiler.InternalGetTotalFragmentationInfoDelegateField = IL2CPP.ResolveICall<Profiler.InternalGetTotalFragmentationInfoDelegate>("UnityEngine.Profiling.Profiler::InternalGetTotalFragmentationInfo");
			Profiler.GetAllocatedMemoryForGraphicsDriverDelegateField = IL2CPP.ResolveICall<Profiler.GetAllocatedMemoryForGraphicsDriverDelegate>("UnityEngine.Profiling.Profiler::GetAllocatedMemoryForGraphicsDriver");
			Profiler.Internal_EmitGlobalMetaData_ArrayDelegateField = IL2CPP.ResolveICall<Profiler.Internal_EmitGlobalMetaData_ArrayDelegate>("UnityEngine.Profiling.Profiler::Internal_EmitGlobalMetaData_Array");
			Profiler.Internal_EmitGlobalMetaData_NativeDelegateField = IL2CPP.ResolveICall<Profiler.Internal_EmitGlobalMetaData_NativeDelegate>("UnityEngine.Profiling.Profiler::Internal_EmitGlobalMetaData_Native");
			Profiler.GetCategoriesCountDelegateField = IL2CPP.ResolveICall<Profiler.GetCategoriesCountDelegate>("UnityEngine.Profiling.Profiler::GetCategoriesCount");
			Profiler.Internal_SetCategoryEnabledDelegateField = IL2CPP.ResolveICall<Profiler.Internal_SetCategoryEnabledDelegate>("UnityEngine.Profiling.Profiler::Internal_SetCategoryEnabled");
			Profiler.Internal_IsCategoryEnabledDelegateField = IL2CPP.ResolveICall<Profiler.Internal_IsCategoryEnabledDelegate>("UnityEngine.Profiling.Profiler::Internal_IsCategoryEnabled");
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x000792A8 File Offset: 0x000774A8
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndThreadProfiling()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_EndThreadProfiling_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x000792D0 File Offset: 0x000774D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1282327, RefRangeEnd = 1282328, XrefRangeStart = 1282325, XrefRangeEnd = 1282327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetRuntimeMemorySizeLong(Object o)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_GetRuntimeMemorySizeLong_Public_Static_Int64_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x0000DD37 File Offset: 0x0000BF37
		public Profiler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x0000DD40 File Offset: 0x0000BF40
		public static bool supported
		{
			get
			{
				return Profiler.get_supportedDelegateField();
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001D66 RID: 7526 RVA: 0x00079314 File Offset: 0x00077514
		// (set) Token: 0x06001D67 RID: 7527 RVA: 0x0000DD4C File Offset: 0x0000BF4C
		public static string logFile
		{
			get
			{
				IntPtr intPtr = Profiler.get_logFileDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				Profiler.set_logFileDelegateField(IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001D68 RID: 7528 RVA: 0x0000DD5E File Offset: 0x0000BF5E
		// (set) Token: 0x06001D69 RID: 7529 RVA: 0x0000DD6A File Offset: 0x0000BF6A
		public static bool enableBinaryLog
		{
			get
			{
				return Profiler.get_enableBinaryLogDelegateField();
			}
			set
			{
				Profiler.set_enableBinaryLogDelegateField(value);
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x0000DD77 File Offset: 0x0000BF77
		// (set) Token: 0x06001D6B RID: 7531 RVA: 0x0000DD83 File Offset: 0x0000BF83
		public static int maxUsedMemory
		{
			get
			{
				return Profiler.get_maxUsedMemoryDelegateField();
			}
			set
			{
				Profiler.set_maxUsedMemoryDelegateField(value);
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001D6C RID: 7532 RVA: 0x0000DD90 File Offset: 0x0000BF90
		// (set) Token: 0x06001D6D RID: 7533 RVA: 0x0000DD9C File Offset: 0x0000BF9C
		public static bool enabled
		{
			get
			{
				return Profiler.get_enabledDelegateField();
			}
			set
			{
				Profiler.set_enabledDelegateField(value);
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001D6E RID: 7534 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		// (set) Token: 0x06001D6F RID: 7535 RVA: 0x0000DDB5 File Offset: 0x0000BFB5
		public static bool enableAllocationCallstacks
		{
			get
			{
				return Profiler.get_enableAllocationCallstacksDelegateField();
			}
			set
			{
				Profiler.set_enableAllocationCallstacksDelegateField(value);
			}
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x0000DDC2 File Offset: 0x0000BFC2
		public static void SetAreaEnabled(ProfilerArea area, bool enabled)
		{
			Profiler.SetAreaEnabledDelegateField(area, enabled);
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001D71 RID: 7537 RVA: 0x00079334 File Offset: 0x00077534
		public static int areaCount
		{
			get
			{
				return Enum.GetNames(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ProfilerArea>())).Length;
			}
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x0000DDD0 File Offset: 0x0000BFD0
		public static bool GetAreaEnabled(ProfilerArea area)
		{
			return Profiler.GetAreaEnabledDelegateField(area);
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x0007935C File Offset: 0x0007755C
		public static void AddFramesFromFile(string file)
		{
			bool flag = String.IsNullOrEmpty(file);
			if (flag)
			{
				Debug.LogError("AddFramesFromFile: Invalid or empty path");
			}
			else
			{
				Profiler.AddFramesFromFile_Internal(file, true);
			}
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x0000DDDD File Offset: 0x0000BFDD
		public static void AddFramesFromFile_Internal(string file, bool keepExistingFrames)
		{
			Profiler.AddFramesFromFile_InternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(file), keepExistingFrames);
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x0007938C File Offset: 0x0007758C
		public static void BeginThreadProfiling(string threadGroupName, string threadName)
		{
			bool flag = String.IsNullOrEmpty(threadGroupName);
			if (flag)
			{
				throw new ArgumentException("Argument should be a valid string", "threadGroupName");
			}
			bool flag2 = String.IsNullOrEmpty(threadName);
			if (flag2)
			{
				throw new ArgumentException("Argument should be a valid string", "threadName");
			}
			Profiler.BeginThreadProfilingInternal(threadGroupName, threadName);
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x0000DDF0 File Offset: 0x0000BFF0
		public static void BeginThreadProfilingInternal(string threadGroupName, string threadName)
		{
			Profiler.BeginThreadProfilingInternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(threadGroupName), IL2CPP.ManagedStringToIl2Cpp(threadName));
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x0000DE08 File Offset: 0x0000C008
		public static void BeginSample(string name)
		{
			Profiler.ValidateArguments(name);
			Profiler.BeginSampleImpl(name, null);
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x0000DE1A File Offset: 0x0000C01A
		public static void BeginSample(string name, Object targetObject)
		{
			Profiler.ValidateArguments(name);
			Profiler.BeginSampleImpl(name, targetObject);
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x000793D8 File Offset: 0x000775D8
		public static void ValidateArguments(string name)
		{
			bool flag = String.IsNullOrEmpty(name);
			if (flag)
			{
				throw new ArgumentException("Argument should be a valid string.", "name");
			}
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x0000DE2C File Offset: 0x0000C02C
		public static void BeginSampleImpl(string name, Object targetObject)
		{
			Profiler.BeginSampleImplDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), IL2CPP.Il2CppObjectBaseToPtr(targetObject));
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x0000DE44 File Offset: 0x0000C044
		public static void EndSample()
		{
			Profiler.EndSampleDelegateField();
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x00079404 File Offset: 0x00077604
		// (set) Token: 0x06001D7D RID: 7549 RVA: 0x0000DE50 File Offset: 0x0000C050
		public static int maxNumberOfSamplesPerFrame
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001D7E RID: 7550 RVA: 0x00079418 File Offset: 0x00077618
		public static uint usedHeapSize
		{
			get
			{
				return (uint)Profiler.usedHeapSizeLong;
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001D7F RID: 7551 RVA: 0x0000DE53 File Offset: 0x0000C053
		public static long usedHeapSizeLong
		{
			get
			{
				return Profiler.get_usedHeapSizeLongDelegateField();
			}
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x00079430 File Offset: 0x00077630
		public static int GetRuntimeMemorySize(Object o)
		{
			return (int)Profiler.GetRuntimeMemorySizeLong(o);
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x0007944C File Offset: 0x0007764C
		public static uint GetMonoHeapSize()
		{
			return (uint)Profiler.GetMonoHeapSizeLong();
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x0000DE5F File Offset: 0x0000C05F
		public static long GetMonoHeapSizeLong()
		{
			return Profiler.GetMonoHeapSizeLongDelegateField();
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x00079464 File Offset: 0x00077664
		public static uint GetMonoUsedSize()
		{
			return (uint)Profiler.GetMonoUsedSizeLong();
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x0000DE6B File Offset: 0x0000C06B
		public static long GetMonoUsedSizeLong()
		{
			return Profiler.GetMonoUsedSizeLongDelegateField();
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x0000DE77 File Offset: 0x0000C077
		public static bool SetTempAllocatorRequestedSize(uint size)
		{
			return Profiler.SetTempAllocatorRequestedSizeDelegateField(size);
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x0000DE84 File Offset: 0x0000C084
		public static uint GetTempAllocatorSize()
		{
			return Profiler.GetTempAllocatorSizeDelegateField();
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x0007947C File Offset: 0x0007767C
		public static uint GetTotalAllocatedMemory()
		{
			return (uint)Profiler.GetTotalAllocatedMemoryLong();
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x0000DE90 File Offset: 0x0000C090
		public static long GetTotalAllocatedMemoryLong()
		{
			return Profiler.GetTotalAllocatedMemoryLongDelegateField();
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x00079494 File Offset: 0x00077694
		public static uint GetTotalUnusedReservedMemory()
		{
			return (uint)Profiler.GetTotalUnusedReservedMemoryLong();
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x0000DE9C File Offset: 0x0000C09C
		public static long GetTotalUnusedReservedMemoryLong()
		{
			return Profiler.GetTotalUnusedReservedMemoryLongDelegateField();
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x000794AC File Offset: 0x000776AC
		public static uint GetTotalReservedMemory()
		{
			return (uint)Profiler.GetTotalReservedMemoryLong();
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x0000DEA8 File Offset: 0x0000C0A8
		public static long GetTotalReservedMemoryLong()
		{
			return Profiler.GetTotalReservedMemoryLongDelegateField();
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x000794C4 File Offset: 0x000776C4
		public static long GetTotalFragmentationInfo(Unity.Collections.NativeArray<int> stats)
		{
			return Profiler.InternalGetTotalFragmentationInfo((IntPtr)stats.GetUnsafePtr<int>(), stats.Length);
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x0000DEB4 File Offset: 0x0000C0B4
		public static long InternalGetTotalFragmentationInfo(IntPtr pStats, int count)
		{
			return Profiler.InternalGetTotalFragmentationInfoDelegateField(pStats, count);
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x0000DEC2 File Offset: 0x0000C0C2
		public static long GetAllocatedMemoryForGraphicsDriver()
		{
			return Profiler.GetAllocatedMemoryForGraphicsDriverDelegateField();
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x000794F0 File Offset: 0x000776F0
		public unsafe static void EmitFrameMetaData(Guid id, int tag, Array data)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			Type elementType = data.GetType().GetElementType();
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsBlittable(elementType);
			if (flag2)
			{
				throw new ArgumentException(String.Format("{0} type must be blittable", elementType));
			}
			Profiler.Internal_EmitGlobalMetaData_Array((void*)(&id), 16, tag, data, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf(elementType), true);
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x00079558 File Offset: 0x00077758
		public unsafe static void EmitFrameMetaData<T>(Guid id, int tag, List<T> data) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			Type typeFromHandle = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsBlittable(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
			if (flag2)
			{
				throw new ArgumentException(String.Format("{0} type must be blittable", typeFromHandle));
			}
			Profiler.Internal_EmitGlobalMetaData_Array((void*)(&id), 16, tag, NoAllocHelpers.ExtractArrayFromList(data), data.Count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf(typeFromHandle), true);
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x0000DECE File Offset: 0x0000C0CE
		public unsafe static void EmitFrameMetaData<T>(Guid id, int tag, Unity.Collections.NativeArray<T> data) where T : struct
		{
			Profiler.Internal_EmitGlobalMetaData_Native((void*)(&id), 16, tag, (IntPtr)data.GetUnsafeReadOnlyPtr<T>(), data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), true);
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x000795CC File Offset: 0x000777CC
		public unsafe static void EmitSessionMetaData(Guid id, int tag, Array data)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			Type elementType = data.GetType().GetElementType();
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsBlittable(elementType);
			if (flag2)
			{
				throw new ArgumentException(String.Format("{0} type must be blittable", elementType));
			}
			Profiler.Internal_EmitGlobalMetaData_Array((void*)(&id), 16, tag, data, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf(elementType), false);
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x00079634 File Offset: 0x00077834
		public unsafe static void EmitSessionMetaData<T>(Guid id, int tag, List<T> data) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			Type typeFromHandle = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsBlittable(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
			if (flag2)
			{
				throw new ArgumentException(String.Format("{0} type must be blittable", typeFromHandle));
			}
			Profiler.Internal_EmitGlobalMetaData_Array((void*)(&id), 16, tag, NoAllocHelpers.ExtractArrayFromList(data), data.Count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf(typeFromHandle), false);
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x0000DEF5 File Offset: 0x0000C0F5
		public unsafe static void EmitSessionMetaData<T>(Guid id, int tag, Unity.Collections.NativeArray<T> data) where T : struct
		{
			Profiler.Internal_EmitGlobalMetaData_Native((void*)(&id), 16, tag, (IntPtr)data.GetUnsafeReadOnlyPtr<T>(), data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), false);
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x0000DF1C File Offset: 0x0000C11C
		public unsafe static void Internal_EmitGlobalMetaData_Array(void* id, int idLen, int tag, Array data, int count, int elementSize, bool frameData)
		{
			Profiler.Internal_EmitGlobalMetaData_ArrayDelegateField(id, idLen, tag, IL2CPP.Il2CppObjectBaseToPtr(data), count, elementSize, frameData);
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x0000DF37 File Offset: 0x0000C137
		public unsafe static void Internal_EmitGlobalMetaData_Native(void* id, int idLen, int tag, IntPtr data, int count, int elementSize, bool frameData)
		{
			Profiler.Internal_EmitGlobalMetaData_NativeDelegateField(id, idLen, tag, data, count, elementSize, frameData);
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x000796A8 File Offset: 0x000778A8
		public static void SetCategoryEnabled(Unity.Profiling.ProfilerCategory category, bool enabled)
		{
			bool flag = category == Unity.Profiling.ProfilerCategory.Any;
			if (flag)
			{
				throw new ArgumentException("Argument should be a valid category", "category");
			}
			Profiler.Internal_SetCategoryEnabled(category, enabled);
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x000796EC File Offset: 0x000778EC
		public static bool IsCategoryEnabled(Unity.Profiling.ProfilerCategory category)
		{
			bool flag = category == Unity.Profiling.ProfilerCategory.Any;
			if (flag)
			{
				throw new ArgumentException("Argument should be a valid category", "category");
			}
			return Profiler.Internal_IsCategoryEnabled(category);
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x0000DF4D File Offset: 0x0000C14D
		public static uint GetCategoriesCount()
		{
			return Profiler.GetCategoriesCountDelegateField();
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x00079730 File Offset: 0x00077930
		public static void GetAllCategories(Il2CppStructArray<Unity.Profiling.ProfilerCategory> categories)
		{
			int num = 0;
			while ((long)num < Math.Min((long)((ulong)Profiler.GetCategoriesCount()), (long)categories.Length))
			{
				categories[num] = new Unity.Profiling.ProfilerCategory((ushort)num);
				num++;
			}
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x00079770 File Offset: 0x00077970
		public static void GetAllCategories(Unity.Collections.NativeArray<Unity.Profiling.ProfilerCategory> categories)
		{
			int num = 0;
			while ((long)num < Math.Min((long)((ulong)Profiler.GetCategoriesCount()), (long)categories.Length))
			{
				categories[num] = new Unity.Profiling.ProfilerCategory((ushort)num);
				num++;
			}
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x0000DF59 File Offset: 0x0000C159
		public static void Internal_SetCategoryEnabled(ushort categoryId, bool enabled)
		{
			Profiler.Internal_SetCategoryEnabledDelegateField(categoryId, enabled);
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x0000DF67 File Offset: 0x0000C167
		public static bool Internal_IsCategoryEnabled(ushort categoryId)
		{
			return Profiler.Internal_IsCategoryEnabledDelegateField(categoryId);
		}

		// Token: 0x0400181A RID: 6170
		private static readonly IntPtr NativeMethodInfoPtr_EndThreadProfiling_Public_Static_Void_0;

		// Token: 0x0400181B RID: 6171
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeMemorySizeLong_Public_Static_Int64_Object_0;

		// Token: 0x0400181C RID: 6172
		public const uint invalidProfilerArea = 4294967295U;

		// Token: 0x0400181D RID: 6173
		private static readonly Profiler.get_supportedDelegate get_supportedDelegateField;

		// Token: 0x0400181E RID: 6174
		private static readonly Profiler.get_logFileDelegate get_logFileDelegateField;

		// Token: 0x0400181F RID: 6175
		private static readonly Profiler.set_logFileDelegate set_logFileDelegateField;

		// Token: 0x04001820 RID: 6176
		private static readonly Profiler.get_enableBinaryLogDelegate get_enableBinaryLogDelegateField;

		// Token: 0x04001821 RID: 6177
		private static readonly Profiler.set_enableBinaryLogDelegate set_enableBinaryLogDelegateField;

		// Token: 0x04001822 RID: 6178
		private static readonly Profiler.get_maxUsedMemoryDelegate get_maxUsedMemoryDelegateField;

		// Token: 0x04001823 RID: 6179
		private static readonly Profiler.set_maxUsedMemoryDelegate set_maxUsedMemoryDelegateField;

		// Token: 0x04001824 RID: 6180
		private static readonly Profiler.get_enabledDelegate get_enabledDelegateField;

		// Token: 0x04001825 RID: 6181
		private static readonly Profiler.set_enabledDelegate set_enabledDelegateField;

		// Token: 0x04001826 RID: 6182
		private static readonly Profiler.get_enableAllocationCallstacksDelegate get_enableAllocationCallstacksDelegateField;

		// Token: 0x04001827 RID: 6183
		private static readonly Profiler.set_enableAllocationCallstacksDelegate set_enableAllocationCallstacksDelegateField;

		// Token: 0x04001828 RID: 6184
		private static readonly Profiler.SetAreaEnabledDelegate SetAreaEnabledDelegateField;

		// Token: 0x04001829 RID: 6185
		private static readonly Profiler.GetAreaEnabledDelegate GetAreaEnabledDelegateField;

		// Token: 0x0400182A RID: 6186
		private static readonly Profiler.AddFramesFromFile_InternalDelegate AddFramesFromFile_InternalDelegateField;

		// Token: 0x0400182B RID: 6187
		private static readonly Profiler.BeginThreadProfilingInternalDelegate BeginThreadProfilingInternalDelegateField;

		// Token: 0x0400182C RID: 6188
		private static readonly Profiler.BeginSampleImplDelegate BeginSampleImplDelegateField;

		// Token: 0x0400182D RID: 6189
		private static readonly Profiler.EndSampleDelegate EndSampleDelegateField;

		// Token: 0x0400182E RID: 6190
		private static readonly Profiler.get_usedHeapSizeLongDelegate get_usedHeapSizeLongDelegateField;

		// Token: 0x0400182F RID: 6191
		private static readonly Profiler.GetMonoHeapSizeLongDelegate GetMonoHeapSizeLongDelegateField;

		// Token: 0x04001830 RID: 6192
		private static readonly Profiler.GetMonoUsedSizeLongDelegate GetMonoUsedSizeLongDelegateField;

		// Token: 0x04001831 RID: 6193
		private static readonly Profiler.SetTempAllocatorRequestedSizeDelegate SetTempAllocatorRequestedSizeDelegateField;

		// Token: 0x04001832 RID: 6194
		private static readonly Profiler.GetTempAllocatorSizeDelegate GetTempAllocatorSizeDelegateField;

		// Token: 0x04001833 RID: 6195
		private static readonly Profiler.GetTotalAllocatedMemoryLongDelegate GetTotalAllocatedMemoryLongDelegateField;

		// Token: 0x04001834 RID: 6196
		private static readonly Profiler.GetTotalUnusedReservedMemoryLongDelegate GetTotalUnusedReservedMemoryLongDelegateField;

		// Token: 0x04001835 RID: 6197
		private static readonly Profiler.GetTotalReservedMemoryLongDelegate GetTotalReservedMemoryLongDelegateField;

		// Token: 0x04001836 RID: 6198
		private static readonly Profiler.InternalGetTotalFragmentationInfoDelegate InternalGetTotalFragmentationInfoDelegateField;

		// Token: 0x04001837 RID: 6199
		private static readonly Profiler.GetAllocatedMemoryForGraphicsDriverDelegate GetAllocatedMemoryForGraphicsDriverDelegateField;

		// Token: 0x04001838 RID: 6200
		private static readonly Profiler.Internal_EmitGlobalMetaData_ArrayDelegate Internal_EmitGlobalMetaData_ArrayDelegateField;

		// Token: 0x04001839 RID: 6201
		private static readonly Profiler.Internal_EmitGlobalMetaData_NativeDelegate Internal_EmitGlobalMetaData_NativeDelegateField;

		// Token: 0x0400183A RID: 6202
		private static readonly Profiler.GetCategoriesCountDelegate GetCategoriesCountDelegateField;

		// Token: 0x0400183B RID: 6203
		private static readonly Profiler.Internal_SetCategoryEnabledDelegate Internal_SetCategoryEnabledDelegateField;

		// Token: 0x0400183C RID: 6204
		private static readonly Profiler.Internal_IsCategoryEnabledDelegate Internal_IsCategoryEnabledDelegateField;

		// Token: 0x020009CF RID: 2511
		// (Invoke) Token: 0x06003C1D RID: 15389
		private delegate bool get_supportedDelegate();

		// Token: 0x020009D0 RID: 2512
		// (Invoke) Token: 0x06003C1F RID: 15391
		private delegate IntPtr get_logFileDelegate();

		// Token: 0x020009D1 RID: 2513
		// (Invoke) Token: 0x06003C21 RID: 15393
		private delegate void set_logFileDelegate(IntPtr value);

		// Token: 0x020009D2 RID: 2514
		// (Invoke) Token: 0x06003C23 RID: 15395
		private delegate bool get_enableBinaryLogDelegate();

		// Token: 0x020009D3 RID: 2515
		// (Invoke) Token: 0x06003C25 RID: 15397
		private delegate void set_enableBinaryLogDelegate(bool value);

		// Token: 0x020009D4 RID: 2516
		// (Invoke) Token: 0x06003C27 RID: 15399
		private delegate int get_maxUsedMemoryDelegate();

		// Token: 0x020009D5 RID: 2517
		// (Invoke) Token: 0x06003C29 RID: 15401
		private delegate void set_maxUsedMemoryDelegate(int value);

		// Token: 0x020009D6 RID: 2518
		// (Invoke) Token: 0x06003C2B RID: 15403
		private delegate bool get_enabledDelegate();

		// Token: 0x020009D7 RID: 2519
		// (Invoke) Token: 0x06003C2D RID: 15405
		private delegate void set_enabledDelegate(bool value);

		// Token: 0x020009D8 RID: 2520
		// (Invoke) Token: 0x06003C2F RID: 15407
		private delegate bool get_enableAllocationCallstacksDelegate();

		// Token: 0x020009D9 RID: 2521
		// (Invoke) Token: 0x06003C31 RID: 15409
		private delegate void set_enableAllocationCallstacksDelegate(bool value);

		// Token: 0x020009DA RID: 2522
		// (Invoke) Token: 0x06003C33 RID: 15411
		private delegate void SetAreaEnabledDelegate(ProfilerArea area, bool enabled);

		// Token: 0x020009DB RID: 2523
		// (Invoke) Token: 0x06003C35 RID: 15413
		private delegate bool GetAreaEnabledDelegate(ProfilerArea area);

		// Token: 0x020009DC RID: 2524
		// (Invoke) Token: 0x06003C37 RID: 15415
		private delegate void AddFramesFromFile_InternalDelegate(IntPtr file, bool keepExistingFrames);

		// Token: 0x020009DD RID: 2525
		// (Invoke) Token: 0x06003C39 RID: 15417
		private delegate void BeginThreadProfilingInternalDelegate(IntPtr threadGroupName, IntPtr threadName);

		// Token: 0x020009DE RID: 2526
		// (Invoke) Token: 0x06003C3B RID: 15419
		private delegate void BeginSampleImplDelegate(IntPtr name, IntPtr targetObject);

		// Token: 0x020009DF RID: 2527
		// (Invoke) Token: 0x06003C3D RID: 15421
		private delegate void EndSampleDelegate();

		// Token: 0x020009E0 RID: 2528
		// (Invoke) Token: 0x06003C3F RID: 15423
		private delegate long get_usedHeapSizeLongDelegate();

		// Token: 0x020009E1 RID: 2529
		// (Invoke) Token: 0x06003C41 RID: 15425
		private delegate long GetMonoHeapSizeLongDelegate();

		// Token: 0x020009E2 RID: 2530
		// (Invoke) Token: 0x06003C43 RID: 15427
		private delegate long GetMonoUsedSizeLongDelegate();

		// Token: 0x020009E3 RID: 2531
		// (Invoke) Token: 0x06003C45 RID: 15429
		private delegate bool SetTempAllocatorRequestedSizeDelegate(uint size);

		// Token: 0x020009E4 RID: 2532
		// (Invoke) Token: 0x06003C47 RID: 15431
		private delegate uint GetTempAllocatorSizeDelegate();

		// Token: 0x020009E5 RID: 2533
		// (Invoke) Token: 0x06003C49 RID: 15433
		private delegate long GetTotalAllocatedMemoryLongDelegate();

		// Token: 0x020009E6 RID: 2534
		// (Invoke) Token: 0x06003C4B RID: 15435
		private delegate long GetTotalUnusedReservedMemoryLongDelegate();

		// Token: 0x020009E7 RID: 2535
		// (Invoke) Token: 0x06003C4D RID: 15437
		private delegate long GetTotalReservedMemoryLongDelegate();

		// Token: 0x020009E8 RID: 2536
		// (Invoke) Token: 0x06003C4F RID: 15439
		private delegate long InternalGetTotalFragmentationInfoDelegate(IntPtr pStats, int count);

		// Token: 0x020009E9 RID: 2537
		// (Invoke) Token: 0x06003C51 RID: 15441
		private delegate long GetAllocatedMemoryForGraphicsDriverDelegate();

		// Token: 0x020009EA RID: 2538
		// (Invoke) Token: 0x06003C53 RID: 15443
		private delegate void Internal_EmitGlobalMetaData_ArrayDelegate(IntPtr id, int idLen, int tag, IntPtr data, int count, int elementSize, bool frameData);

		// Token: 0x020009EB RID: 2539
		// (Invoke) Token: 0x06003C55 RID: 15445
		private delegate void Internal_EmitGlobalMetaData_NativeDelegate(IntPtr id, int idLen, int tag, IntPtr data, int count, int elementSize, bool frameData);

		// Token: 0x020009EC RID: 2540
		// (Invoke) Token: 0x06003C57 RID: 15447
		private delegate uint GetCategoriesCountDelegate();

		// Token: 0x020009ED RID: 2541
		// (Invoke) Token: 0x06003C59 RID: 15449
		private delegate void Internal_SetCategoryEnabledDelegate(ushort categoryId, bool enabled);

		// Token: 0x020009EE RID: 2542
		// (Invoke) Token: 0x06003C5B RID: 15451
		private delegate bool Internal_IsCategoryEnabledDelegate(ushort categoryId);
	}
}
