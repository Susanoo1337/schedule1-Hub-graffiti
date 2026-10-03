using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Unity.Burst.LowLevel
{
	// Token: 0x0200005A RID: 90
	public static class BurstCompilerService : Il2CppSystem.Object
	{
		// Token: 0x060002FB RID: 763 RVA: 0x00020C90 File Offset: 0x0001EE90
		// Note: this type is marked as 'beforefieldinit'.
		static BurstCompilerService()
		{
			Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Burst.LowLevel", "BurstCompilerService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr);
			BurstCompilerService.NativeMethodInfoPtr_GetDisassembly_Public_Static_String_MethodInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663589);
			BurstCompilerService.NativeMethodInfoPtr_CompileAsyncDelegateMethod_Public_Static_Int32_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663590);
			BurstCompilerService.NativeMethodInfoPtr_GetAsyncCompiledAsyncDelegateMethod_Public_Static_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663591);
			BurstCompilerService.NativeMethodInfoPtr_GetOrCreateSharedMemory_Public_Static_ptr_Void_byref_Hash128_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663592);
			BurstCompilerService.NativeMethodInfoPtr_SetCurrentExecutionMode_Public_Static_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663593);
			BurstCompilerService.NativeMethodInfoPtr_GetCurrentExecutionMode_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663594);
			BurstCompilerService.NativeMethodInfoPtr_Log_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663595);
			BurstCompilerService.NativeMethodInfoPtr_RuntimeLog_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663596);
			BurstCompilerService.NativeMethodInfoPtr_LoadBurstLibrary_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663597);
			BurstCompilerService.GetMethodSignatureDelegateField = IL2CPP.ResolveICall<BurstCompilerService.GetMethodSignatureDelegate>("Unity.Burst.LowLevel.BurstCompilerService::GetMethodSignature");
			BurstCompilerService.get_IsInitializedDelegateField = IL2CPP.ResolveICall<BurstCompilerService.get_IsInitializedDelegate>("Unity.Burst.LowLevel.BurstCompilerService::get_IsInitialized");
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00020D94 File Offset: 0x0001EF94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1226597, RefRangeEnd = 1226598, XrefRangeStart = 1226595, XrefRangeEnd = 1226597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDisassembly(MethodInfo m, string compilerOptions)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(compilerOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_GetDisassembly_Public_Static_String_MethodInfo_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00020DE4 File Offset: 0x0001EFE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1226600, RefRangeEnd = 1226602, XrefRangeStart = 1226598, XrefRangeEnd = 1226600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompileAsyncDelegateMethod(Il2CppSystem.Object delegateMethod, string compilerOptions)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(delegateMethod);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(compilerOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_CompileAsyncDelegateMethod_Public_Static_Int32_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00020E38 File Offset: 0x0001F038
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1226604, RefRangeEnd = 1226606, XrefRangeStart = 1226602, XrefRangeEnd = 1226604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* GetAsyncCompiledAsyncDelegateMethod(int userID)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref userID;
			IntPtr intPtr;
			IntPtr result = IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_GetAsyncCompiledAsyncDelegateMethod_Public_Static_ptr_Void_Int32_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return result;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00020E6C File Offset: 0x0001F06C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1226608, RefRangeEnd = 1226609, XrefRangeStart = 1226606, XrefRangeEnd = 1226608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* GetOrCreateSharedMemory(ref UnityEngine.Hash128 key, uint size_of, uint alignment)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &key;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size_of;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignment;
			IntPtr intPtr;
			IntPtr result = IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_GetOrCreateSharedMemory_Public_Static_ptr_Void_byref_Hash128_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return result;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00020EBC File Offset: 0x0001F0BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1226611, RefRangeEnd = 1226612, XrefRangeStart = 1226609, XrefRangeEnd = 1226611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCurrentExecutionMode(uint environment)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref environment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_SetCurrentExecutionMode_Public_Static_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00020EF0 File Offset: 0x0001F0F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1226614, RefRangeEnd = 1226615, XrefRangeStart = 1226612, XrefRangeEnd = 1226614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetCurrentExecutionMode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_GetCurrentExecutionMode_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00020F20 File Offset: 0x0001F120
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1226617, RefRangeEnd = 1226618, XrefRangeStart = 1226615, XrefRangeEnd = 1226617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(void* userData, BurstCompilerService.BurstLogType logType, byte* message, byte* filename, int lineNumber)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = userData;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = message;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = filename;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_Log_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00020F88 File Offset: 0x0001F188
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1226620, RefRangeEnd = 1226621, XrefRangeStart = 1226618, XrefRangeEnd = 1226620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RuntimeLog(void* userData, BurstCompilerService.BurstLogType logType, byte* message, byte* filename, int lineNumber)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = userData;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = message;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = filename;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_RuntimeLog_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00020FF0 File Offset: 0x0001F1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226621, XrefRangeEnd = 1226623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LoadBurstLibrary(string fullPathToLibBurstGenerated)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPathToLibBurstGenerated);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_LoadBurstLibrary_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000384D File Offset: 0x00001A4D
		public BurstCompilerService(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00021034 File Offset: 0x0001F234
		public static string GetMethodSignature(MethodInfo method)
		{
			IntPtr intPtr = BurstCompilerService.GetMethodSignatureDelegateField(IL2CPP.Il2CppObjectBaseToPtr(method));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00003856 File Offset: 0x00001A56
		public static bool IsInitialized
		{
			get
			{
				return BurstCompilerService.get_IsInitializedDelegateField();
			}
		}

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_GetDisassembly_Public_Static_String_MethodInfo_String_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_CompileAsyncDelegateMethod_Public_Static_Int32_Object_String_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_GetAsyncCompiledAsyncDelegateMethod_Public_Static_ptr_Void_Int32_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateSharedMemory_Public_Static_ptr_Void_byref_Hash128_UInt32_UInt32_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentExecutionMode_Public_Static_Void_UInt32_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentExecutionMode_Public_Static_UInt32_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_RuntimeLog_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_LoadBurstLibrary_Public_Static_Boolean_String_0;

		// Token: 0x04000245 RID: 581
		private static readonly BurstCompilerService.GetMethodSignatureDelegate GetMethodSignatureDelegateField;

		// Token: 0x04000246 RID: 582
		private static readonly BurstCompilerService.get_IsInitializedDelegate get_IsInitializedDelegateField;

		// Token: 0x020003F3 RID: 1011
		[OriginalName("UnityEngine.CoreModule.dll", "", "BurstLogType")]
		public enum BurstLogType
		{
			// Token: 0x04002A20 RID: 10784
			Info,
			// Token: 0x04002A21 RID: 10785
			Warning,
			// Token: 0x04002A22 RID: 10786
			Error
		}

		// Token: 0x020003F4 RID: 1012
		// (Invoke) Token: 0x06003088 RID: 12424
		private delegate IntPtr GetMethodSignatureDelegate(IntPtr method);

		// Token: 0x020003F5 RID: 1013
		// (Invoke) Token: 0x0600308A RID: 12426
		private delegate bool get_IsInitializedDelegate();
	}
}
