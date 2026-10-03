using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Unity.Profiling.Memory
{
	// Token: 0x0200002A RID: 42
	public static class MemoryProfiler : Il2CppSystem.Object
	{
		// Token: 0x06000165 RID: 357 RVA: 0x0001C4D8 File Offset: 0x0001A6D8
		// Note: this type is marked as 'beforefieldinit'.
		static MemoryProfiler()
		{
			Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling.Memory", "MemoryProfiler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr);
			MemoryProfiler.NativeFieldInfoPtr_m_SnapshotFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, "m_SnapshotFinished");
			MemoryProfiler.NativeFieldInfoPtr_m_SaveScreenshotToDisk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, "m_SaveScreenshotToDisk");
			MemoryProfiler.NativeFieldInfoPtr_CreatingMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, "CreatingMetadata");
			MemoryProfiler.NativeMethodInfoPtr_add_CreatingMetadata_Public_Static_add_Void_Action_1_MemorySnapshotMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663430);
			MemoryProfiler.NativeMethodInfoPtr_remove_CreatingMetadata_Public_Static_rem_Void_Action_1_MemorySnapshotMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663431);
			MemoryProfiler.NativeMethodInfoPtr_PrepareMetadata_Private_Static_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663432);
			MemoryProfiler.NativeMethodInfoPtr_WriteIntToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663433);
			MemoryProfiler.NativeMethodInfoPtr_WriteStringToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663434);
			MemoryProfiler.NativeMethodInfoPtr_FinalizeSnapshot_Private_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663435);
			MemoryProfiler.NativeMethodInfoPtr_SaveScreenshotToDisk_Private_Static_Void_String_Boolean_IntPtr_Int32_TextureFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663436);
			MemoryProfiler.StartOperationDelegateField = IL2CPP.ResolveICall<MemoryProfiler.StartOperationDelegate>("Unity.Profiling.Memory.MemoryProfiler::StartOperation");
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0001C5E0 File Offset: 0x0001A7E0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1225455, RefRangeEnd = 1225461, XrefRangeStart = 1225446, XrefRangeEnd = 1225455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_CreatingMetadata(Action<MemorySnapshotMetadata> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_add_CreatingMetadata_Public_Static_add_Void_Action_1_MemorySnapshotMetadata_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0001C618 File Offset: 0x0001A818
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1225470, RefRangeEnd = 1225476, XrefRangeStart = 1225461, XrefRangeEnd = 1225470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_CreatingMetadata(Action<MemorySnapshotMetadata> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_remove_CreatingMetadata_Public_Static_rem_Void_Action_1_MemorySnapshotMetadata_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0001C650 File Offset: 0x0001A850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225476, XrefRangeEnd = 1225501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> PrepareMetadata()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_PrepareMetadata_Private_Static_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0001C684 File Offset: 0x0001A884
		[CallerCount(0)]
		public unsafe static int WriteIntToByteArray(Il2CppStructArray<byte> array, int offset, int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_WriteIntToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0001C6E4 File Offset: 0x0001A8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225501, XrefRangeEnd = 1225502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WriteStringToByteArray(Il2CppStructArray<byte> array, int offset, string value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_WriteStringToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0001C748 File Offset: 0x0001A948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225502, XrefRangeEnd = 1225506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FinalizeSnapshot(string path, bool result)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_FinalizeSnapshot_Private_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0001C78C File Offset: 0x0001A98C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225506, XrefRangeEnd = 1225513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, UnityEngine.TextureFormat format, int width, int height)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref result;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryProfiler.NativeMethodInfoPtr_SaveScreenshotToDisk_Private_Static_Void_String_Boolean_IntPtr_Int32_TextureFormat_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002AAA File Offset: 0x00000CAA
		public MemoryProfiler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0001C818 File Offset: 0x0001AA18
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00002AB3 File Offset: 0x00000CB3
		public unsafe static Action<string, bool> m_SnapshotFinished
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MemoryProfiler.NativeFieldInfoPtr_m_SnapshotFinished, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MemoryProfiler.NativeFieldInfoPtr_m_SnapshotFinished, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0001C840 File Offset: 0x0001AA40
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00002AC5 File Offset: 0x00000CC5
		public unsafe static Action<string, bool, DebugScreenCapture> m_SaveScreenshotToDisk
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MemoryProfiler.NativeFieldInfoPtr_m_SaveScreenshotToDisk, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, bool, DebugScreenCapture>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MemoryProfiler.NativeFieldInfoPtr_m_SaveScreenshotToDisk, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000172 RID: 370 RVA: 0x0001C868 File Offset: 0x0001AA68
		// (set) Token: 0x06000173 RID: 371 RVA: 0x00002AD7 File Offset: 0x00000CD7
		public unsafe static Action<MemorySnapshotMetadata> CreatingMetadata
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MemoryProfiler.NativeFieldInfoPtr_CreatingMetadata, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<MemorySnapshotMetadata>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MemoryProfiler.NativeFieldInfoPtr_CreatingMetadata, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002AE9 File Offset: 0x00000CE9
		public static void add_m_SnapshotFinished(Action<string, bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002AF6 File Offset: 0x00000CF6
		public static void remove_m_SnapshotFinished(Action<string, bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002B03 File Offset: 0x00000D03
		public static void add_m_SaveScreenshotToDisk(Action<string, bool, DebugScreenCapture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002B10 File Offset: 0x00000D10
		public static void remove_m_SaveScreenshotToDisk(Action<string, bool, DebugScreenCapture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002B1D File Offset: 0x00000D1D
		public static void StartOperation(uint captureFlag, bool requestScreenshot, string path, bool isRemote)
		{
			MemoryProfiler.StartOperationDelegateField(captureFlag, requestScreenshot, IL2CPP.ManagedStringToIl2Cpp(path), isRemote);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002B32 File Offset: 0x00000D32
		public static void TakeSnapshot(string path, Action<string, bool> finishCallback, [Optional] CaptureFlags captureFlags)
		{
			MemoryProfiler.TakeSnapshot(path, finishCallback, null, captureFlags);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0001C890 File Offset: 0x0001AA90
		public static void TakeSnapshot(string path, Action<string, bool> finishCallback, Action<string, bool, DebugScreenCapture> screenshotCallback, [Optional] CaptureFlags captureFlags)
		{
			bool flag = MemoryProfiler.m_SnapshotFinished != null;
			if (flag)
			{
				UnityEngine.Debug.LogWarning("Canceling snapshot, there is another snapshot in progress.");
				finishCallback.Invoke(path, false);
			}
			else
			{
				MemoryProfiler.add_m_SnapshotFinished(finishCallback);
				MemoryProfiler.add_m_SaveScreenshotToDisk(screenshotCallback);
				MemoryProfiler.StartOperation((uint)captureFlags, MemoryProfiler.m_SaveScreenshotToDisk != null, path, false);
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002B3F File Offset: 0x00000D3F
		public static void TakeTempSnapshot(Action<string, bool> finishCallback, [Optional] CaptureFlags captureFlags)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeFieldInfoPtr_m_SnapshotFinished;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeFieldInfoPtr_m_SaveScreenshotToDisk;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeFieldInfoPtr_CreatingMetadata;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_add_CreatingMetadata_Public_Static_add_Void_Action_1_MemorySnapshotMetadata_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_remove_CreatingMetadata_Public_Static_rem_Void_Action_1_MemorySnapshotMetadata_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_PrepareMetadata_Private_Static_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_WriteIntToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_WriteStringToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_String_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeSnapshot_Private_Static_Void_String_Boolean_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_SaveScreenshotToDisk_Private_Static_Void_String_Boolean_IntPtr_Int32_TextureFormat_Int32_Int32_0;

		// Token: 0x04000151 RID: 337
		private static readonly MemoryProfiler.StartOperationDelegate StartOperationDelegateField;

		// Token: 0x020003B3 RID: 947
		// (Invoke) Token: 0x06002FF2 RID: 12274
		private delegate void StartOperationDelegate(uint captureFlag, bool requestScreenshot, IntPtr path, bool isRemote);
	}
}
