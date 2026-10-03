using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Unity.Baselib.LowLevel
{
	// Token: 0x0200028E RID: 654
	public static class Binding
	{
		// Token: 0x06002C39 RID: 11321 RVA: 0x000134FA File Offset: 0x000116FA
		public static IntPtr Baselib_Memory_Allocate(UIntPtr size)
		{
			return Binding.Baselib_Memory_AllocateDelegateField(size);
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x00013507 File Offset: 0x00011707
		public static IntPtr Baselib_Memory_Reallocate(IntPtr ptr, UIntPtr newSize)
		{
			return Binding.Baselib_Memory_ReallocateDelegateField(ptr, newSize);
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x00013515 File Offset: 0x00011715
		public static void Baselib_Memory_Free(IntPtr ptr)
		{
			Binding.Baselib_Memory_FreeDelegateField(ptr);
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x00013522 File Offset: 0x00011722
		public static IntPtr Baselib_Memory_AlignedAllocate(UIntPtr size, UIntPtr alignment)
		{
			return Binding.Baselib_Memory_AlignedAllocateDelegateField(size, alignment);
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x00013530 File Offset: 0x00011730
		public static IntPtr Baselib_Memory_AlignedReallocate(IntPtr ptr, UIntPtr newSize, UIntPtr alignment)
		{
			return Binding.Baselib_Memory_AlignedReallocateDelegateField(ptr, newSize, alignment);
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x0001353F File Offset: 0x0001173F
		public static void Baselib_Memory_AlignedFree(IntPtr ptr)
		{
			Binding.Baselib_Memory_AlignedFreeDelegateField(ptr);
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x000AB08C File Offset: 0x000A928C
		public static Binding.Baselib_RegisteredNetwork_Endpoint Baselib_RegisteredNetwork_Endpoint_Empty()
		{
			Binding.Baselib_RegisteredNetwork_Endpoint result;
			Binding.Baselib_RegisteredNetwork_Endpoint_Empty_Injected(out result);
			return result;
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x0001354C File Offset: 0x0001174C
		public static void Baselib_Thread_YieldExecution()
		{
			Binding.Baselib_Thread_YieldExecutionDelegateField();
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x00013558 File Offset: 0x00011758
		public static IntPtr Baselib_Thread_GetCurrentThreadId()
		{
			return Binding.Baselib_Thread_GetCurrentThreadIdDelegateField();
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x00013564 File Offset: 0x00011764
		public static UIntPtr Baselib_TLS_Alloc()
		{
			return Binding.Baselib_TLS_AllocDelegateField();
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x00013570 File Offset: 0x00011770
		public static void Baselib_TLS_Free(UIntPtr handle)
		{
			Binding.Baselib_TLS_FreeDelegateField(handle);
		}

		// Token: 0x06002C44 RID: 11332 RVA: 0x0001357D File Offset: 0x0001177D
		public static void Baselib_TLS_Set(UIntPtr handle, UIntPtr value)
		{
			Binding.Baselib_TLS_SetDelegateField(handle, value);
		}

		// Token: 0x06002C45 RID: 11333 RVA: 0x0001358B File Offset: 0x0001178B
		public static UIntPtr Baselib_TLS_Get(UIntPtr handle)
		{
			return Binding.Baselib_TLS_GetDelegateField(handle);
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x00013598 File Offset: 0x00011798
		public static ulong Baselib_Timer_GetHighPrecisionTimerTicks()
		{
			return Binding.Baselib_Timer_GetHighPrecisionTimerTicksDelegateField();
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x000135A4 File Offset: 0x000117A4
		public static void Baselib_Timer_WaitForAtLeast(uint timeInMilliseconds)
		{
			Binding.Baselib_Timer_WaitForAtLeastDelegateField(timeInMilliseconds);
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x000135B1 File Offset: 0x000117B1
		public static double Baselib_Timer_GetTimeSinceStartupInSeconds()
		{
			return Binding.Baselib_Timer_GetTimeSinceStartupInSecondsDelegateField();
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x000135BD File Offset: 0x000117BD
		public static void Baselib_RegisteredNetwork_Endpoint_Empty_Injected(out Binding.Baselib_RegisteredNetwork_Endpoint ret)
		{
			Binding.Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegateField(out ret);
		}

		// Token: 0x04002675 RID: 9845
		public const uint Baselib_NetworkAddress_IpMaxStringLength = 46U;

		// Token: 0x04002676 RID: 9846
		public const uint Baselib_RegisteredNetwork_Endpoint_MaxSize = 28U;

		// Token: 0x04002677 RID: 9847
		public const uint Baselib_TLS_MinimumGuaranteedSlots = 100U;

		// Token: 0x04002678 RID: 9848
		public const ulong Baselib_SecondsPerMinute = 60UL;

		// Token: 0x04002679 RID: 9849
		public const ulong Baselib_MillisecondsPerSecond = 1000UL;

		// Token: 0x0400267A RID: 9850
		public const ulong Baselib_MillisecondsPerMinute = 60000UL;

		// Token: 0x0400267B RID: 9851
		public const ulong Baselib_MicrosecondsPerMillisecond = 1000UL;

		// Token: 0x0400267C RID: 9852
		public const ulong Baselib_MicrosecondsPerSecond = 1000000UL;

		// Token: 0x0400267D RID: 9853
		public const ulong Baselib_MicrosecondsPerMinute = 60000000UL;

		// Token: 0x0400267E RID: 9854
		public const ulong Baselib_NanosecondsPerMicrosecond = 1000UL;

		// Token: 0x0400267F RID: 9855
		public const ulong Baselib_NanosecondsPerMillisecond = 1000000UL;

		// Token: 0x04002680 RID: 9856
		public const ulong Baselib_NanosecondsPerSecond = 1000000000UL;

		// Token: 0x04002681 RID: 9857
		public const ulong Baselib_NanosecondsPerMinute = 60000000000UL;

		// Token: 0x04002682 RID: 9858
		public const ulong Baselib_Timer_MaxNumberOfNanosecondsPerTick = 1000UL;

		// Token: 0x04002683 RID: 9859
		public const double Baselib_Timer_MinNumberOfNanosecondsPerTick = 0.01;

		// Token: 0x04002684 RID: 9860
		public const double Baselib_Timer_HighPrecisionTimerCrossThreadMontotonyTolerance_InNanoseconds = 100.0;

		// Token: 0x04002685 RID: 9861
		private static readonly Binding.Baselib_Memory_AllocateDelegate Baselib_Memory_AllocateDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_AllocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_Allocate");

		// Token: 0x04002686 RID: 9862
		private static readonly Binding.Baselib_Memory_ReallocateDelegate Baselib_Memory_ReallocateDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_ReallocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_Reallocate");

		// Token: 0x04002687 RID: 9863
		private static readonly Binding.Baselib_Memory_FreeDelegate Baselib_Memory_FreeDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_FreeDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_Free");

		// Token: 0x04002688 RID: 9864
		private static readonly Binding.Baselib_Memory_AlignedAllocateDelegate Baselib_Memory_AlignedAllocateDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_AlignedAllocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_AlignedAllocate");

		// Token: 0x04002689 RID: 9865
		private static readonly Binding.Baselib_Memory_AlignedReallocateDelegate Baselib_Memory_AlignedReallocateDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_AlignedReallocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_AlignedReallocate");

		// Token: 0x0400268A RID: 9866
		private static readonly Binding.Baselib_Memory_AlignedFreeDelegate Baselib_Memory_AlignedFreeDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_AlignedFreeDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_AlignedFree");

		// Token: 0x0400268B RID: 9867
		private static readonly Binding.Baselib_Thread_YieldExecutionDelegate Baselib_Thread_YieldExecutionDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Thread_YieldExecutionDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Thread_YieldExecution");

		// Token: 0x0400268C RID: 9868
		private static readonly Binding.Baselib_Thread_GetCurrentThreadIdDelegate Baselib_Thread_GetCurrentThreadIdDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Thread_GetCurrentThreadIdDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Thread_GetCurrentThreadId");

		// Token: 0x0400268D RID: 9869
		private static readonly Binding.Baselib_TLS_AllocDelegate Baselib_TLS_AllocDelegateField = IL2CPP.ResolveICall<Binding.Baselib_TLS_AllocDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Alloc");

		// Token: 0x0400268E RID: 9870
		private static readonly Binding.Baselib_TLS_FreeDelegate Baselib_TLS_FreeDelegateField = IL2CPP.ResolveICall<Binding.Baselib_TLS_FreeDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Free");

		// Token: 0x0400268F RID: 9871
		private static readonly Binding.Baselib_TLS_SetDelegate Baselib_TLS_SetDelegateField = IL2CPP.ResolveICall<Binding.Baselib_TLS_SetDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Set");

		// Token: 0x04002690 RID: 9872
		private static readonly Binding.Baselib_TLS_GetDelegate Baselib_TLS_GetDelegateField = IL2CPP.ResolveICall<Binding.Baselib_TLS_GetDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Get");

		// Token: 0x04002691 RID: 9873
		private static readonly Binding.Baselib_Timer_GetHighPrecisionTimerTicksDelegate Baselib_Timer_GetHighPrecisionTimerTicksDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Timer_GetHighPrecisionTimerTicksDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Timer_GetHighPrecisionTimerTicks");

		// Token: 0x04002692 RID: 9874
		private static readonly Binding.Baselib_Timer_WaitForAtLeastDelegate Baselib_Timer_WaitForAtLeastDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Timer_WaitForAtLeastDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Timer_WaitForAtLeast");

		// Token: 0x04002693 RID: 9875
		private static readonly Binding.Baselib_Timer_GetTimeSinceStartupInSecondsDelegate Baselib_Timer_GetTimeSinceStartupInSecondsDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Timer_GetTimeSinceStartupInSecondsDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Timer_GetTimeSinceStartupInSeconds");

		// Token: 0x04002694 RID: 9876
		private static readonly Binding.Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegate Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegateField = IL2CPP.ResolveICall<Binding.Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_RegisteredNetwork_Endpoint_Empty_Injected");

		// Token: 0x02000C38 RID: 3128
		public enum Baselib_ErrorCode
		{
			// Token: 0x04002C2D RID: 11309
			Success,
			// Token: 0x04002C2E RID: 11310
			OutOfMemory = 16777216,
			// Token: 0x04002C2F RID: 11311
			OutOfSystemResources,
			// Token: 0x04002C30 RID: 11312
			InvalidAddressRange,
			// Token: 0x04002C31 RID: 11313
			InvalidArgument,
			// Token: 0x04002C32 RID: 11314
			InvalidBufferSize,
			// Token: 0x04002C33 RID: 11315
			InvalidState,
			// Token: 0x04002C34 RID: 11316
			NotSupported,
			// Token: 0x04002C35 RID: 11317
			Timeout,
			// Token: 0x04002C36 RID: 11318
			UnsupportedAlignment = 33554432,
			// Token: 0x04002C37 RID: 11319
			InvalidPageSize,
			// Token: 0x04002C38 RID: 11320
			InvalidPageCount,
			// Token: 0x04002C39 RID: 11321
			UnsupportedPageState,
			// Token: 0x04002C3A RID: 11322
			ThreadCannotJoinSelf = 50331648,
			// Token: 0x04002C3B RID: 11323
			NetworkInitializationError = 67108864,
			// Token: 0x04002C3C RID: 11324
			AddressInUse,
			// Token: 0x04002C3D RID: 11325
			AddressUnreachable,
			// Token: 0x04002C3E RID: 11326
			AddressFamilyNotSupported,
			// Token: 0x04002C3F RID: 11327
			Disconnected,
			// Token: 0x04002C40 RID: 11328
			InvalidPathname = 83886080,
			// Token: 0x04002C41 RID: 11329
			RequestedAccessIsNotAllowed,
			// Token: 0x04002C42 RID: 11330
			IOError,
			// Token: 0x04002C43 RID: 11331
			FailedToOpenDynamicLibrary = 100663296,
			// Token: 0x04002C44 RID: 11332
			FunctionNotFound,
			// Token: 0x04002C45 RID: 11333
			UnexpectedError = -1
		}

		// Token: 0x02000C39 RID: 3129
		public enum Baselib_ErrorState_NativeErrorCodeType : byte
		{
			// Token: 0x04002C47 RID: 11335
			None,
			// Token: 0x04002C48 RID: 11336
			PlatformDefined
		}

		// Token: 0x02000C3A RID: 3130
		public enum Baselib_ErrorState_ExtraInformationType : byte
		{
			// Token: 0x04002C4A RID: 11338
			None,
			// Token: 0x04002C4B RID: 11339
			StaticString,
			// Token: 0x04002C4C RID: 11340
			GenerationCounter
		}

		// Token: 0x02000C3B RID: 3131
		public enum Baselib_ErrorState_ExplainVerbosity
		{
			// Token: 0x04002C4E RID: 11342
			ErrorType,
			// Token: 0x04002C4F RID: 11343
			ErrorType_SourceLocation_Explanation
		}

		// Token: 0x02000C3C RID: 3132
		public enum Baselib_FileIO_OpenFlags : uint
		{
			// Token: 0x04002C51 RID: 11345
			Read = 1U,
			// Token: 0x04002C52 RID: 11346
			Write,
			// Token: 0x04002C53 RID: 11347
			OpenAlways = 4U,
			// Token: 0x04002C54 RID: 11348
			CreateAlways = 8U
		}

		// Token: 0x02000C3D RID: 3133
		public enum Baselib_FileIO_Priority
		{
			// Token: 0x04002C56 RID: 11350
			Normal,
			// Token: 0x04002C57 RID: 11351
			High
		}

		// Token: 0x02000C3E RID: 3134
		public enum Baselib_FileIO_EventQueue_ResultType
		{
			// Token: 0x04002C59 RID: 11353
			Baselib_FileIO_EventQueue_Callback = 1,
			// Token: 0x04002C5A RID: 11354
			Baselib_FileIO_EventQueue_OpenFile,
			// Token: 0x04002C5B RID: 11355
			Baselib_FileIO_EventQueue_ReadFile,
			// Token: 0x04002C5C RID: 11356
			Baselib_FileIO_EventQueue_CloseFile
		}

		// Token: 0x02000C3F RID: 3135
		public enum Baselib_Memory_PageState
		{
			// Token: 0x04002C5E RID: 11358
			Reserved,
			// Token: 0x04002C5F RID: 11359
			NoAccess,
			// Token: 0x04002C60 RID: 11360
			ReadOnly,
			// Token: 0x04002C61 RID: 11361
			ReadWrite = 4,
			// Token: 0x04002C62 RID: 11362
			ReadOnly_Executable = 18,
			// Token: 0x04002C63 RID: 11363
			ReadWrite_Executable = 20
		}

		// Token: 0x02000C40 RID: 3136
		public enum Baselib_NetworkAddress_Family
		{
			// Token: 0x04002C65 RID: 11365
			Invalid,
			// Token: 0x04002C66 RID: 11366
			IPv4,
			// Token: 0x04002C67 RID: 11367
			IPv6
		}

		// Token: 0x02000C41 RID: 3137
		public enum Baselib_NetworkAddress_AddressReuse
		{
			// Token: 0x04002C69 RID: 11369
			DoNotAllow,
			// Token: 0x04002C6A RID: 11370
			Allow
		}

		// Token: 0x02000C42 RID: 3138
		public struct Baselib_RegisteredNetwork_Endpoint
		{
		}

		// Token: 0x02000C43 RID: 3139
		public enum Baselib_RegisteredNetwork_CompletionStatus
		{
			// Token: 0x04002C6C RID: 11372
			Failed,
			// Token: 0x04002C6D RID: 11373
			Success
		}

		// Token: 0x02000C44 RID: 3140
		public enum Baselib_RegisteredNetwork_ProcessStatus
		{
			// Token: 0x04002C6F RID: 11375
			NonePendingImmediately,
			// Token: 0x04002C70 RID: 11376
			Done = 0,
			// Token: 0x04002C71 RID: 11377
			Pending
		}

		// Token: 0x02000C45 RID: 3141
		public enum Baselib_RegisteredNetwork_CompletionQueueStatus
		{
			// Token: 0x04002C73 RID: 11379
			NoResultsAvailable,
			// Token: 0x04002C74 RID: 11380
			ResultsAvailable
		}

		// Token: 0x02000C46 RID: 3142
		public enum Baselib_Socket_Protocol
		{
			// Token: 0x04002C76 RID: 11382
			UDP = 1,
			// Token: 0x04002C77 RID: 11383
			TCP
		}

		// Token: 0x02000C47 RID: 3143
		public enum Baselib_Socket_PollEvents
		{
			// Token: 0x04002C79 RID: 11385
			Readable = 1,
			// Token: 0x04002C7A RID: 11386
			Writable,
			// Token: 0x04002C7B RID: 11387
			Connected = 4
		}

		// Token: 0x02000C48 RID: 3144
		// (Invoke) Token: 0x06004131 RID: 16689
		private delegate IntPtr Baselib_Memory_AllocateDelegate(UIntPtr size);

		// Token: 0x02000C49 RID: 3145
		// (Invoke) Token: 0x06004133 RID: 16691
		private delegate IntPtr Baselib_Memory_ReallocateDelegate(IntPtr ptr, UIntPtr newSize);

		// Token: 0x02000C4A RID: 3146
		// (Invoke) Token: 0x06004135 RID: 16693
		private delegate void Baselib_Memory_FreeDelegate(IntPtr ptr);

		// Token: 0x02000C4B RID: 3147
		// (Invoke) Token: 0x06004137 RID: 16695
		private delegate IntPtr Baselib_Memory_AlignedAllocateDelegate(UIntPtr size, UIntPtr alignment);

		// Token: 0x02000C4C RID: 3148
		// (Invoke) Token: 0x06004139 RID: 16697
		private delegate IntPtr Baselib_Memory_AlignedReallocateDelegate(IntPtr ptr, UIntPtr newSize, UIntPtr alignment);

		// Token: 0x02000C4D RID: 3149
		// (Invoke) Token: 0x0600413B RID: 16699
		private delegate void Baselib_Memory_AlignedFreeDelegate(IntPtr ptr);

		// Token: 0x02000C4E RID: 3150
		// (Invoke) Token: 0x0600413D RID: 16701
		private delegate void Baselib_Thread_YieldExecutionDelegate();

		// Token: 0x02000C4F RID: 3151
		// (Invoke) Token: 0x0600413F RID: 16703
		private delegate IntPtr Baselib_Thread_GetCurrentThreadIdDelegate();

		// Token: 0x02000C50 RID: 3152
		// (Invoke) Token: 0x06004141 RID: 16705
		private delegate UIntPtr Baselib_TLS_AllocDelegate();

		// Token: 0x02000C51 RID: 3153
		// (Invoke) Token: 0x06004143 RID: 16707
		private delegate void Baselib_TLS_FreeDelegate(UIntPtr handle);

		// Token: 0x02000C52 RID: 3154
		// (Invoke) Token: 0x06004145 RID: 16709
		private delegate void Baselib_TLS_SetDelegate(UIntPtr handle, UIntPtr value);

		// Token: 0x02000C53 RID: 3155
		// (Invoke) Token: 0x06004147 RID: 16711
		private delegate UIntPtr Baselib_TLS_GetDelegate(UIntPtr handle);

		// Token: 0x02000C54 RID: 3156
		// (Invoke) Token: 0x06004149 RID: 16713
		private delegate ulong Baselib_Timer_GetHighPrecisionTimerTicksDelegate();

		// Token: 0x02000C55 RID: 3157
		// (Invoke) Token: 0x0600414B RID: 16715
		private delegate void Baselib_Timer_WaitForAtLeastDelegate(uint timeInMilliseconds);

		// Token: 0x02000C56 RID: 3158
		// (Invoke) Token: 0x0600414D RID: 16717
		private delegate double Baselib_Timer_GetTimeSinceStartupInSecondsDelegate();

		// Token: 0x02000C57 RID: 3159
		// (Invoke) Token: 0x0600414F RID: 16719
		private delegate void Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegate([Out] IntPtr ret);
	}
}
