using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Diagnostics;

namespace UnityEngine
{
	// Token: 0x0200014B RID: 331
	public static class StackTraceUtility : Object
	{
		// Token: 0x06001916 RID: 6422 RVA: 0x0006B194 File Offset: 0x00069394
		// Note: this type is marked as 'beforefieldinit'.
		static StackTraceUtility()
		{
			Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "StackTraceUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr);
			StackTraceUtility.NativeFieldInfoPtr_projectFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, "projectFolder");
			StackTraceUtility.NativeMethodInfoPtr_SetProjectFolder_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100665959);
			StackTraceUtility.NativeMethodInfoPtr_ExtractStackTrace_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100665960);
			StackTraceUtility.NativeMethodInfoPtr_ExtractStringFromExceptionInternal_Internal_Static_Void_Object_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100665961);
			StackTraceUtility.NativeMethodInfoPtr_ExtractFormattedStackTrace_Internal_Static_String_StackTrace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100665962);
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x0006B228 File Offset: 0x00069428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260701, XrefRangeEnd = 1260720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetProjectFolder(string folder)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(folder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTraceUtility.NativeMethodInfoPtr_SetProjectFolder_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x0006B260 File Offset: 0x00069460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260720, XrefRangeEnd = 1260737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ExtractStackTrace()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTraceUtility.NativeMethodInfoPtr_ExtractStackTrace_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x0006B28C File Offset: 0x0006948C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260737, XrefRangeEnd = 1260791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExtractStringFromExceptionInternal(Object exceptiono, out string message, out string stackTrace)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptiono);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(StackTraceUtility.NativeMethodInfoPtr_ExtractStringFromExceptionInternal_Internal_Static_Void_Object_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			message = IL2CPP.Il2CppStringToManaged(intPtr);
			stackTrace = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x0006B2F8 File Offset: 0x000694F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1260885, RefRangeEnd = 1260887, XrefRangeStart = 1260791, XrefRangeEnd = 1260885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ExtractFormattedStackTrace(StackTrace stackTrace)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stackTrace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTraceUtility.NativeMethodInfoPtr_ExtractFormattedStackTrace_Internal_Static_String_StackTrace_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x0000C4D9 File Offset: 0x0000A6D9
		public StackTraceUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x0006B334 File Offset: 0x00069534
		// (set) Token: 0x0600191D RID: 6429 RVA: 0x0000C4E2 File Offset: 0x0000A6E2
		public unsafe static string projectFolder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StackTraceUtility.NativeFieldInfoPtr_projectFolder, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StackTraceUtility.NativeFieldInfoPtr_projectFolder, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x0006B354 File Offset: 0x00069554
		public static string ExtractStringFromException(Object exception)
		{
			string str;
			string str2;
			StackTraceUtility.ExtractStringFromExceptionInternal(exception, out str, out str2);
			return String.Concat(str, "\n", str2);
		}

		// Token: 0x040014EC RID: 5356
		private static readonly IntPtr NativeFieldInfoPtr_projectFolder;

		// Token: 0x040014ED RID: 5357
		private static readonly IntPtr NativeMethodInfoPtr_SetProjectFolder_Internal_Static_Void_String_0;

		// Token: 0x040014EE RID: 5358
		private static readonly IntPtr NativeMethodInfoPtr_ExtractStackTrace_Public_Static_String_0;

		// Token: 0x040014EF RID: 5359
		private static readonly IntPtr NativeMethodInfoPtr_ExtractStringFromExceptionInternal_Internal_Static_Void_Object_byref_String_byref_String_0;

		// Token: 0x040014F0 RID: 5360
		private static readonly IntPtr NativeMethodInfoPtr_ExtractFormattedStackTrace_Internal_Static_String_StackTrace_0;
	}
}
