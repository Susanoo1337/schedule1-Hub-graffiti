using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004EA RID: 1258
	public class LogToConsole : MonoBehaviour
	{
		// Token: 0x0600723A RID: 29242 RVA: 0x00202AF0 File Offset: 0x00200CF0
		// Note: this type is marked as 'beforefieldinit'.
		static LogToConsole()
		{
			Il2CppClassPointerStore<LogToConsole>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "LogToConsole");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogToConsole>.NativeClassPtr);
			LogToConsole.NativeMethodInfoPtr_Log_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogToConsole>.NativeClassPtr, 100678075);
			LogToConsole.NativeMethodInfoPtr_LogWarning_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogToConsole>.NativeClassPtr, 100678076);
			LogToConsole.NativeMethodInfoPtr_LogError_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogToConsole>.NativeClassPtr, 100678077);
			LogToConsole.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogToConsole>.NativeClassPtr, 100678078);
		}

		// Token: 0x0600723B RID: 29243 RVA: 0x00202B70 File Offset: 0x00200D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226223, XrefRangeEnd = 226227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Log(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogToConsole.NativeMethodInfoPtr_Log_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600723C RID: 29244 RVA: 0x00202BB4 File Offset: 0x00200DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226227, XrefRangeEnd = 226231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogWarning(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogToConsole.NativeMethodInfoPtr_LogWarning_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600723D RID: 29245 RVA: 0x00202BF8 File Offset: 0x00200DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226231, XrefRangeEnd = 226235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogError(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogToConsole.NativeMethodInfoPtr_LogError_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600723E RID: 29246 RVA: 0x00202C3C File Offset: 0x00200E3C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogToConsole() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogToConsole>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogToConsole.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600723F RID: 29247 RVA: 0x00036532 File Offset: 0x00034732
		public LogToConsole(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004E06 RID: 19974
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Void_String_0;

		// Token: 0x04004E07 RID: 19975
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Void_String_0;

		// Token: 0x04004E08 RID: 19976
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Void_String_0;

		// Token: 0x04004E09 RID: 19977
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
