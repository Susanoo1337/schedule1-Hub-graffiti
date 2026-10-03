using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using UnityEngine;

namespace Il2CppScheduleOne.Reporting
{
	// Token: 0x02000133 RID: 307
	public class DebugLogCollector : MonoBehaviour
	{
		// Token: 0x06001EE5 RID: 7909 RVA: 0x000E0410 File Offset: 0x000DE610
		// Note: this type is marked as 'beforefieldinit'.
		static DebugLogCollector()
		{
			Il2CppClassPointerStore<DebugLogCollector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Reporting", "DebugLogCollector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugLogCollector>.NativeClassPtr);
			DebugLogCollector.NativeFieldInfoPtr_log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugLogCollector>.NativeClassPtr, "log");
			DebugLogCollector.NativeFieldInfoPtr_IgnoreList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugLogCollector>.NativeClassPtr, "IgnoreList");
			DebugLogCollector.NativeMethodInfoPtr_get_Log_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogCollector>.NativeClassPtr, 100667269);
			DebugLogCollector.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogCollector>.NativeClassPtr, 100667270);
			DebugLogCollector.NativeMethodInfoPtr_HandleLog_Private_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogCollector>.NativeClassPtr, 100667271);
			DebugLogCollector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogCollector>.NativeClassPtr, 100667272);
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06001EE6 RID: 7910 RVA: 0x000E04B8 File Offset: 0x000DE6B8
		public unsafe static string Log
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105557, XrefRangeEnd = 105565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugLogCollector.NativeMethodInfoPtr_get_Log_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x000E04E4 File Offset: 0x000DE6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105565, XrefRangeEnd = 105588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugLogCollector.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x000E0518 File Offset: 0x000DE718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105588, XrefRangeEnd = 105626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleLog(string logString, string stackTrace, LogType logType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(logString);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugLogCollector.NativeMethodInfoPtr_HandleLog_Private_Void_String_String_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x000E057C File Offset: 0x000DE77C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugLogCollector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugLogCollector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugLogCollector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x00010BC2 File Offset: 0x0000EDC2
		public DebugLogCollector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06001EEB RID: 7915 RVA: 0x000E05B8 File Offset: 0x000DE7B8
		// (set) Token: 0x06001EEC RID: 7916 RVA: 0x00010BCB File Offset: 0x0000EDCB
		public unsafe static StringBuilder log
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugLogCollector.NativeFieldInfoPtr_log, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugLogCollector.NativeFieldInfoPtr_log, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06001EED RID: 7917 RVA: 0x000E05E0 File Offset: 0x000DE7E0
		// (set) Token: 0x06001EEE RID: 7918 RVA: 0x00010BDD File Offset: 0x0000EDDD
		public unsafe static Il2CppStringArray IgnoreList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugLogCollector.NativeFieldInfoPtr_IgnoreList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugLogCollector.NativeFieldInfoPtr_IgnoreList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400155F RID: 5471
		private static readonly IntPtr NativeFieldInfoPtr_log;

		// Token: 0x04001560 RID: 5472
		private static readonly IntPtr NativeFieldInfoPtr_IgnoreList;

		// Token: 0x04001561 RID: 5473
		private static readonly IntPtr NativeMethodInfoPtr_get_Log_Public_Static_get_String_0;

		// Token: 0x04001562 RID: 5474
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04001563 RID: 5475
		private static readonly IntPtr NativeMethodInfoPtr_HandleLog_Private_Void_String_String_LogType_0;

		// Token: 0x04001564 RID: 5476
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
